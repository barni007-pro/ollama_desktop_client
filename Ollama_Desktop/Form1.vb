Imports System.Drawing.Printing
Imports System.Formats
Imports System.IO
Imports System.Management
Imports System.Media
Imports System.Net.Http
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Text.Json
Imports System.Text.RegularExpressions
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Web ' Für HttpUtility.HtmlEncode
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Markdig
Imports Markdig.Renderers
Imports Markdig.Renderers.Html
Imports Markdig.Syntax
Imports Microsoft.DotNet.DesignTools.Protocol.Endpoints
Imports Microsoft.Web.WebView2.Core
Imports Newtonsoft.Json            ' Für die JSON-Serialisierung
Imports Newtonsoft.Json.Linq       ' Für die JSON-Verarbeitung
Imports Ollama_Desktop.Form1
Imports Ollama_Desktop.My
Imports Ollama_Desktop.My.Resources
Imports ScintillaNET
Imports SiticoneNetCoreUI
Imports UglyToad.PdfPig
Imports Renci.SshNet
Imports Renci.SshNet.Common
Imports System.Text.Json.Nodes
Imports NAudio.Wave
Imports Whisper.net
Imports Whisper.net.Ggml


Public Class Form1

    Public Class text_content_def
        Public Property text As String
        Public Property fileName As String
        Public Property fileExtention As String
    End Class

    Public text_contents As New List(Of text_content_def)
    Public rag_content As New text_content_def

    Public Class image_content_def
        Public Property base64String As String
        Public Property fileName As String
        Public Property fileExtension As String
    End Class

    Dim image_contents As New List(Of image_content_def)

    Public Class audio_content_def
        Public Property base64String As String
        Public Property fileName As String
        Public Property fileExtension As String
    End Class

    Dim audio_contents As New List(Of audio_content_def)

    ' Datenklasse für einen Satz mit Trefferanzahl
    Public Class SentenceData
        Public Property Text As String
        Public Property HitCount As Integer
        Public Property SentenceIndex As Integer
        Public Sub New(text As String, index As Integer)
            Me.Text = text
            Me.HitCount = 0
            Me.SentenceIndex = index
        End Sub
    End Class

    Private documentIndex As New DocumentIndex()

    Public Request_JSON As String = ""
    Public Response_JSON As String = ""
    Public Response_json_nav_mem As New List(Of String)
    Public Response_nav_pointer As Integer = -1
    Public model_info As New List(Of String)


    ' Klasse zur Speicherung von Code und Sprache
    Public Class CodeBlock
        Public Property Language As String
        Public Property Code As String
    End Class

    Public CodeBlock_List As New List(Of CodeBlock)

    Public ToolsCodeBlockJson As String = "empty"

    Public Class Execute_val
        Public Property exe As String
        Public Property arg As String
        Public Property file As String
        Public Property ext As String
    End Class

    Public request_mem As String = ""
    Public response_mem As String = ""
    Public tools_Response_mem As String = ""
    Public extractedThinking As String = ""
    Public extractedLicense As String = ""
    Public extractedContext As New List(Of Integer)

    Public timing_total_duration As Long
    Public timing_load_duration As Long
    Public timing_prompt_eval_count As Long
    Public timing_prompt_eval_duration As Long
    Public timing_eval_count As Long
    Public timing_eval_duration As Long

    Private cancellationTokenSource As CancellationTokenSource

    Public Class ModelInfo
        Public Property vision As Boolean
        Public Property audio As Boolean
        Public Property tools As Boolean
        Public Property thinking As Boolean
        Public Property embedding As Boolean
        Public Property image As Boolean
        Public Property decision As Boolean
        Public Property context As Integer
        Public Property description As String
    End Class
    Public ModelInfo_dic As Dictionary(Of String, ModelInfo)

    Public Class SettingsInfo
        Public Property help_path As String
        Public Property model_path As String
        Public Property code_path As String
        Public Property tools_path As String
        Public Property rag_path As String
        Public Property decision_path As String
        Public Property ssh_path As String
    End Class

    Public SettingsInfo_dic As Dictionary(Of String, SettingsInfo)

    Public APP_Start = True

    Public Ollama_ver As String = My.Settings.serv_ver

    Private isRequestRunning As Boolean = False

    ' Der Pfad zu unserer geheimen Log-Datei im Windows-Temp-Ordner
    Private logFilePath As String = IO.Path.Combine(IO.Path.GetTempPath(), "OllamaDesktop_LiveLog.txt")
    Private logLock As New Object() ' Verhindert Abstürze, wenn zwei Threads gleichzeitig loggen wollen

    ' SSH Terminal in WebView2 
    Private _sshClient As SshClient
    Private _shellStream As ShellStream
    Private _cts As CancellationTokenSource
    ' Variablen für den SSH LLM-Rückkanal
    Private _llmBuffer As New StringBuilder()
    Private _bufferLock As New Object()

    Private currentErrMultiline As String
    Private currentErrFormat As String
    Private currentErrDenied As String

    Private WithEvents waveIn As WaveInEvent = Nothing
    Private waveWriter As WaveFileWriter = Nothing

    Private isRecordingAudio As Boolean = False
    Private audioTempPath As String = ""
    Private selectedAudioDeviceIndex As Integer

    ' --- Klassenvariablen für Whisper Live ---
    Private isListeningWhisper As Boolean = False
    Private whisperFactory As WhisperFactory = Nothing
    Private whisperProcessor As WhisperProcessor = Nothing

    ' NAudio Streamer für Live-Daten
    Private whisperWaveIn As WaveInEvent = Nothing
    Private whisperBufferedStream As BufferedWaveProvider = Nothing

    ' Thread-sichere Warteschlange für fertige Audio-Sätze
    Private whisperJobQueue As New System.Collections.Concurrent.ConcurrentQueue(Of Byte())()

    ' Eine Variable, die signalisiert, ob die App mit dem Laden fertig ist
    Private isAppReady As Boolean = False

    ' Kumulierter Markdown-Verlauf für die HTML-Ausgabe bei aktivem Kontext
    Private conversationHistoryMarkdown As New StringBuilder()

    'Variable zur Verfolgung des aktuellen Navigations-Indexes im Chat-Verlauf
    Public Structure ChatTurn
        Public UserPrompt As String
        Public ResponseText As String
        Public ContextTokens As List(Of Integer) ' Speichert die KI-Context-Tokens für diesen Schritt
        Public ModelName As String ' Speichert das Modell, mit dem die Antwort generiert wurde
    End Structure

    ' Die Liste, die alle bisherigen Chat-Schritte speichert
    Private chatHistory As New List(Of ChatTurn)()
    Private currentTurnIndex As Integer = -1

    Private Async Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isAppReady = False

        ' --- Log-Datei bei jedem Programmstart leeren ---
        Try
            Dim startMessage As String = $"--- NEUE OLLAMA SITZUNG: {DateTime.Now:dd.MM.yyyy HH:mm:ss} ---{vbCrLf}"
            IO.File.WriteAllText(logFilePath, startMessage)
        Catch ex As Exception
            ' Falls die Datei noch von einer alten PowerShell blockiert wird, ignorieren wir das
        End Try
        ' -----------------------------------------------------
        Await InitializeWebView2()
        WebView21.CoreWebView2.Settings.IsScriptEnabled = True

        ' WebView2 SSH Terminal initialisieren
        Await InitializeWebViewTerminal()

        ToolTip1.AutoPopDelay = 10000
        SiticoneTextBox_host.Text = My.Settings.ollama_host
        SiticoneSplitContainer_runcont.SplitterDistance = 495


        ' Auslesen von Name und Version
        Dim programName As String = My.Application.Info.Title
        Dim programVersion As String = My.Application.Info.Version.ToString()

        ' Zusammenfügen zu einem String
        Dim appInfo As String = programName & ": v" & programVersion & " / Ollama: v" & Ollama_ver
        SiticoneDragForm_Header.Title = appInfo

        ' Option Name Spalte
        Dim optionNameColumn As New DataGridViewTextBoxColumn()
        optionNameColumn.Name = "OptionName"
        optionNameColumn.HeaderText = "Option Name"
        optionNameColumn.Width = 300
        dgv_option.Columns.Add(optionNameColumn)

        ' Use Spalte
        Dim useColumn As New DataGridViewCheckBoxColumn()
        useColumn.Name = "Use"
        useColumn.HeaderText = "Use"
        useColumn.Width = 50
        dgv_option.Columns.Add(useColumn)

        ' Value Typ Spalte
        Dim valueTypeColumn As New DataGridViewComboBoxColumn()
        valueTypeColumn.Name = "ValueType"
        valueTypeColumn.HeaderText = "Value Typ"
        valueTypeColumn.Items.AddRange(New String() {"string", "int", "float", "boolean"})
        valueTypeColumn.Width = 100
        dgv_option.Columns.Add(valueTypeColumn)

        ' Value Spalte
        Dim valueColumn As New DataGridViewTextBoxColumn()
        valueColumn.Name = "Value"
        valueColumn.HeaderText = "Value"
        valueColumn.Width = 300
        dgv_option.Columns.Add(valueColumn)

        ' Befülle die DataGridView mit den Werten aus der StringCollection
        For Each optionString As String In My.Settings.option_list
            Dim values() As String = optionString.Split(New String() {"<|>"}, StringSplitOptions.None)
            dgv_option.Rows.Add(values(0), Boolean.Parse(values(1)), values(2), values(3))
        Next

        SiticoneTextArea_system.Text = My.Settings.system
        SiticoneToggleSwitch_system_use.Checked = My.Settings.system_use
        SiticoneToggleSwitch_format_use.Checked = My.Settings.format_use
        SiticoneToggleSwitch_last_context.Checked = My.Settings.context_use
        Scintilla_format.Text = My.Settings.format
        SiticoneTextArea_content_prompt.Text = My.Settings.content_prompt

        SiticoneTextArea_Tools_system.Text = My.Settings.tools_system
        Scintilla_Tools_Json.Text = My.Settings.tools_json
        Scintilla_Tools_pythoncode.Text = My.Settings.tools_pythoncode

        SiticoneTextArea_Rag_system.Text = My.Settings.rag_system
        Scintilla_Rag_Json.Text = My.Settings.rag_json

        Scintilla_Decision_Json.Text = My.Settings.decision_json

        SiticoneTextArea_ssh_system.Text = My.Settings.ssh_system
        SiticoneTextArea_ssh_response.Text = My.Settings.ssh_response
        SiticoneTextBox_ssh_address.Text = My.Settings.ssh_address
        SiticoneTextBox_ssh_user.Text = My.Settings.ssh_user
        SiticoneTextBox_ssh_pw.Text = My.Settings.ssh_pw
        SiticoneTextBox_ssh_regex.Text = My.Settings.ssh_regex
        SiticoneTextBox_ssh_pwrequest.Text = My.Settings.ssh_pwrequest
        SiticoneTextBox_ssh_sudopw.Text = My.Settings.ssh_sudopw
        SiticoneTextBox_ssh_timeout.Text = My.Settings.ssh_timeout
        SiticoneTextBox_ssh_maxi.Text = My.Settings.ssh_maxi
        currentErrMultiline = My.Settings.currentErrMultiline
        currentErrFormat = My.Settings.currentErrFormat
        currentErrDenied = My.Settings.currentErrDenied

        SiticoneNavbar_tab.Visible = My.Settings.show_menue

        ' Execute Language Spalte
        Dim ExecuteLanguageColumn As New DataGridViewTextBoxColumn()
        ExecuteLanguageColumn.Name = "Language"
        ExecuteLanguageColumn.HeaderText = "Language"
        ExecuteLanguageColumn.Width = 300
        dvg_execute.Columns.Add(ExecuteLanguageColumn)

        ' Execute Program Spalte
        Dim ExecuteProgramColumn As New DataGridViewTextBoxColumn()
        ExecuteProgramColumn.Name = "Program"
        ExecuteProgramColumn.HeaderText = "Program"
        ExecuteProgramColumn.Width = 300
        dvg_execute.Columns.Add(ExecuteProgramColumn)

        ' Execute Argument Spalte
        Dim ExecuteArgumentColumn As New DataGridViewTextBoxColumn()
        ExecuteArgumentColumn.Name = "Argument"
        ExecuteArgumentColumn.HeaderText = "Argument"
        ExecuteArgumentColumn.Width = 100
        dvg_execute.Columns.Add(ExecuteArgumentColumn)

        ' Execute Tempfile Spalte
        Dim ExecuteTempfileColumn As New DataGridViewTextBoxColumn()
        ExecuteTempfileColumn.Name = "Tempfile"
        ExecuteTempfileColumn.HeaderText = "Tempfile"
        ExecuteTempfileColumn.Width = 200
        dvg_execute.Columns.Add(ExecuteTempfileColumn)

        ' Execute Extention Spalte
        Dim ExecuteExtentionColumn As New DataGridViewTextBoxColumn()
        ExecuteExtentionColumn.Name = "Extention"
        ExecuteExtentionColumn.HeaderText = "Extention"
        ExecuteExtentionColumn.Width = 100
        dvg_execute.Columns.Add(ExecuteExtentionColumn)

        ' Befülle die DataGridView mit den Werten aus der StringCollection
        For Each executeString As String In My.Settings.run_execute_list
            Dim values() As String = executeString.Split(New String() {"<|>"}, StringSplitOptions.None)
            dvg_execute.Rows.Add(values(0), values(1), values(2), values(3), values(4))
        Next

        LoadModelConfig("settings\models_config.json")
        LoadSettings("settings\settings.json")
        For Each setings_item In SettingsInfo_dic
            SiticoneDropdown_default.Items.Add(setings_item.Key)
        Next

        SetupEditor(Scintilla_model_info_request, "json")
        SetupEditor(Scintilla_model_info, "json")
        SetupEditor(Scintilla_format, "json")
        SetupEditor(Scintilla_Tools_Json, "json")
        SetupEditor(Scintilla_Tools_pythoncode, "python")
        SetupEditor(Scintilla_Rag_Json, "json")
        SetupEditor(Scintilla_Decision_Json, "json")
        SetupEditor(Scintilla_Request_JSON, "json")
        SetupEditor(Scintilla_Response_JSON, "json")
        SetupEditor(Scintilla_response, "markdown")

        SiticoneTextArea_prompt.ScrollBars = ScrollBars.None
        RegisterStateImages(SiticoneButton_file, My.Resources.Resource_pic.paperclip_32_blau, My.Resources.Resource_pic.paperclip_32_grau)
        RegisterStateImages(SiticoneButton_screenshot, My.Resources.Resource_pic.screenshot_32_blau, My.Resources.Resource_pic.screenshot_32_grau)
        RegisterStateImages(SiticoneButton_timing, My.Resources.Resource_pic.statistics_32_blau, My.Resources.Resource_pic.statistics_32_grau)
        RegisterStateImages(SiticoneButton_show_thinking, My.Resources.Resource_pic.think_32_blau, My.Resources.Resource_pic.think_32_grau)
        RegisterStateImages(SiticoneButton_HTMLtoPDF, My.Resources.Resource_pic.save_32_blau, My.Resources.Resource_pic.save_32_grau)
        RegisterStateImages(SiticoneButton_clear_prompt, My.Resources.Resource_pic.edit_clear_all_blau, My.Resources.Resource_pic.edit_clear_all_grau)
        RegisterStateImages(SiticoneButton_audio, My.Resources.Resource_pic.mic_32_blau, My.Resources.Resource_pic.mic_32_grau)
        RegisterStateImages(SiticoneButton_wisper, My.Resources.Resource_pic.speech_32_blau, My.Resources.Resource_pic.speech_32_grau)

        'öffnet LLM API Setting Menü
        SiticonePanel_llm_setting.Visible = My.Settings.LLM_seting

        'läd die letzte Modell Liste
        If My.Settings.LLM_model_info IsNot Nothing Then
            For Each jsonString As String In My.Settings.LLM_model_info
                Dim modelJson As JObject = JObject.Parse(jsonString)
                Dim displayName As String = modelJson("name").ToString()

                model_info.Add(jsonString)
                SiticoneDropdown_model.Items.Add(displayName)
            Next
        End If
        'Selektiert die letzte Modell Auswahl
        If SiticoneDropdown_model.Items.Count > 0 Then
            SiticoneDropdown_model.SelectedIndex = My.Settings.LLM_model_index
        End If
        APP_Start = False

        SiticoneTabControl_tab.Top -= 51
        SiticoneTabControl_tab.Height += 51

        ' Navbar vorbereiten
        SiticoneNavbar_tab.Items.Clear()

        ' Navbar mit Tabs synchronisieren
        For i As Integer = 0 To SiticoneTabControl_tab.TabPages.Count - 1
            Dim page = SiticoneTabControl_tab.TabPages(i)
            Dim navItem As New NavBarItem()

            With navItem
                .Text = page.Text
                .Tag = i

                Dim resourceName As String = page.Text.Replace(" ", "_")

                Try
                    Dim resObject = My.Resources.Resource_svg.ResourceManager.GetObject(resourceName)

                    If resObject IsNot Nothing Then
                        .Image = DirectCast(resObject, Drawing.Image)
                    End If
                Catch ex As Exception
                    AppLog("[DEBUG-Load] Bild nicht gefunden für: " & resourceName)
                End Try
            End With

            SiticoneNavbar_tab.Items.Add(navItem)
            SiticoneNavbar_tab.SelectedIndex = SiticoneTabControl_tab.SelectedIndex
        Next

        ' Zuletzt gespeicherte Sprache aus der User-Config laden
        Dim savedLang As String = My.Settings.WhisperLanguage
        If String.IsNullOrEmpty(savedLang) Then savedLang = "de"

        Dim itemFound As Boolean = False
        For i As Integer = 0 To SiticoneDropdown_wisperlang.Items.Count - 1
            Dim itemText As String = SiticoneDropdown_wisperlang.Items(i).ToString()

            If itemText.EndsWith(" displays, " & savedLang) OrElse itemText.EndsWith("," & savedLang) Then
                SiticoneDropdown_wisperlang.SelectedIndex = i
                itemFound = True
                Exit For
            End If
        Next

        If Not itemFound AndAlso SiticoneDropdown_wisperlang.Items.Count > 0 Then
            SiticoneDropdown_wisperlang.SelectedIndex = 0
        End If

        selectedAudioDeviceIndex = My.Settings.AudioDevice

        ' Whisper-Modell laden
        InitWhisper()

        isAppReady = True

        SiticoneTextArea_prompt.Focus()
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        My.Settings.ollama_host = SiticoneTextBox_host.Text

        My.Settings.system = SiticoneTextArea_system.Text
        My.Settings.system_use = SiticoneToggleSwitch_system_use.Checked
        My.Settings.format_use = SiticoneToggleSwitch_format_use.Checked
        My.Settings.context_use = SiticoneToggleSwitch_last_context.Checked
        My.Settings.format = Scintilla_format.Text
        My.Settings.content_prompt = SiticoneTextArea_content_prompt.Text

        My.Settings.tools_system = SiticoneTextArea_Tools_system.Text
        My.Settings.tools_json = Scintilla_Tools_Json.Text
        My.Settings.tools_pythoncode = Scintilla_Tools_pythoncode.Text

        My.Settings.rag_system = SiticoneTextArea_Rag_system.Text
        My.Settings.rag_json = Scintilla_Rag_Json.Text

        My.Settings.decision_json = Scintilla_Decision_Json.Text

        My.Settings.ssh_system = SiticoneTextArea_ssh_system.Text
        My.Settings.ssh_response = SiticoneTextArea_ssh_response.Text
        My.Settings.ssh_address = SiticoneTextBox_ssh_address.Text
        My.Settings.ssh_user = SiticoneTextBox_ssh_user.Text
        My.Settings.ssh_pw = SiticoneTextBox_ssh_pw.Text
        My.Settings.ssh_regex = SiticoneTextBox_ssh_regex.Text
        My.Settings.ssh_pwrequest = SiticoneTextBox_ssh_pwrequest.Text
        My.Settings.ssh_sudopw = SiticoneTextBox_ssh_sudopw.Text
        My.Settings.ssh_timeout = SiticoneTextBox_ssh_timeout.Text
        My.Settings.ssh_maxi = SiticoneTextBox_ssh_maxi.Text
        My.Settings.currentErrMultiline = currentErrMultiline
        My.Settings.currentErrFormat = currentErrFormat
        My.Settings.currentErrDenied = currentErrDenied

        My.Settings.LLM_seting = SiticonePanel_llm_setting.Visible
        My.Settings.LLM_model_info = New Specialized.StringCollection()
        My.Settings.LLM_model_info.AddRange(model_info.ToArray())
        My.Settings.LLM_model_index = SiticoneDropdown_model.SelectedIndex

        My.Settings.show_menue = SiticoneNavbar_tab.Visible
        My.Settings.serv_ver = Ollama_ver
    End Sub

    Private Sub RegisterStateImages(btn As SiticoneButton,
                                imgEnabled As Image,
                                imgDisabled As Image)

        Dim updateImage = Sub()
                              If btn.Enabled Then
                                  btn.ButtonImage = imgEnabled
                              Else
                                  btn.ButtonImage = imgDisabled
                              End If
                          End Sub

        AddHandler btn.EnabledChanged, Sub(sender, e) updateImage()
        updateImage()
    End Sub

    Private Sub SiticoneTextArea_prompt_KeyDown(sender As Object, e As KeyEventArgs) Handles SiticoneTextArea_prompt.KeyDown
        If e.KeyCode = Keys.Enter AndAlso Not ModifierKeys.HasFlag(Keys.Shift) Then
            e.SuppressKeyPress = True
            SiticonePlayPauseButton_request.IsPlaying = True
        End If
        If e.Control AndAlso e.KeyCode = Keys.V Then
            If Clipboard.ContainsImage Then
                import_clp_image()
                e.SuppressKeyPress = True
            End If
        End If
    End Sub

    Private Sub import_clp_image()
        Dim img As Image = Clipboard.GetImage()
        If img Is Nothing Then Return

        Dim tempPath As String = Path.Combine(Path.GetTempPath(), $"Screenshot_{DateTime.Now:HHmmss}.png")
        img.Save(tempPath, System.Drawing.Imaging.ImageFormat.Png)

        Dim imageBytes() As Byte = File.ReadAllBytes(tempPath)

        Dim iContent As New image_content_def With {
            .base64String = Convert.ToBase64String(imageBytes),
            .fileName = Path.GetFileName(tempPath),
            .fileExtension = "png"
        }
        image_contents.Add(iContent)

        AddFileChip(tempPath, "png")
        SiticoneFlowPanel_prompt_filecontent.Visible = True
    End Sub

    Private Sub CreateAndAddFileChip(fileName As String, fileExtention As String, content As String)
        Dim text_content As New text_content_def With {
            .text = content,
            .fileName = fileName,
            .fileExtention = fileExtention
        }

        text_contents.Clear()
        text_contents.Add(text_content)

        Dim tempPath = IO.Path.Combine(IO.Path.GetTempPath(), fileName)
        IO.File.WriteAllText(tempPath, content)

        AddFileChip(tempPath, fileExtention)
        SiticoneFlowPanel_prompt_filecontent.Visible = True
    End Sub

    Private Async Sub SiticonePlayPauseButton_request_StateChanged(sender As Object, e As EventArgs) Handles SiticonePlayPauseButton_request.StateChanged
        AppLog($"[DEBUG-StateChanged] ---> StateChanged EVENT GEFEUERT! IsPlaying: {SiticonePlayPauseButton_request.IsPlaying}")

        If Not SiticonePlayPauseButton_request.IsPlaying Then
            AppLog("[DEBUG-StateChanged] Button auf Pause. Breche ab.")
            If cancellationTokenSource IsNot Nothing Then cancellationTokenSource.Cancel()
            Exit Sub
        End If

        If isRequestRunning Then
            AppLog("[DEBUG-StateChanged] BLOCKIERT: Request läuft bereits.")
            Exit Sub
        End If

        If SiticoneToggleSwitch_sshbot.Checked Then
            SiticoneToggleSwitch_last_context.Checked = True
        End If

        isRequestRunning = True
        AppLog("[DEBUG-StateChanged] Sperre aktiviert. Starte Agent-Loop...")

        Try
            Dim iterationCount As Integer = 0
            Dim maxIterations As Integer = Val(SiticoneTextBox_ssh_maxi.Text)
            Dim continueLoop As Boolean = True

            Dim originalGoal As String = SiticoneTextArea_prompt.Text.Trim()

            While continueLoop AndAlso SiticonePlayPauseButton_request.IsPlaying
                iterationCount += 1
                AppLog($"[DEBUG-StateChanged] Agent Durchgang #{iterationCount}")

                CodeBlock_List.Clear()

                SiticoneTextBox_request_answer.Text = ""
                Dim prompt = SiticoneTextArea_prompt.Text.Trim

                ' Ollama Sonderbefehle
                If iterationCount = 1 AndAlso prompt.StartsWith("ollama") Then
                    AppLog("[DEBUG-StateChanged] Ollama Sonderbefehl erkannt.")
                    Dim apiBaseUrl = "http://" & SiticoneTextBox_host.Text & "/api"
                    Dim parts = prompt.Split(" "c)
                    If parts.Length >= 3 Then
                        Dim command = parts(1).ToLower
                        Dim model = parts(2)
                        Select Case command
                            Case "rm", "delete" : Await OllamaDeleteModel(apiBaseUrl, model)
                            Case "pull", "run" : Await OllamaPullModel(apiBaseUrl, model)
                            Case Else : Scintilla_response.Text = "Unknown ollama command: " & command
                        End Select
                    End If
                    SiticoneTabControl_tab.SelectedTab = TabPage_responsemd
                    Exit While
                End If

                If iterationCount = 1 Then
                    If SiticoneToggleSwitch_tools.Checked Or SiticoneToggleSwitch_ragtools.Checked Or SiticoneToggleSwitch_sshbot.Checked Then
                        extractedContext.Clear()
                        AppLog("[DEBUG-StateChanged] Kontext-Speicher für den Start einer neuen Agenten-Aufgabe geleert.")
                    End If
                End If

                ToolsCodeBlockJson = "empty"

                AppLog($"[DEBUG-StateChanged] Rufe MainAsync (Schritt {iterationCount})...")
                Await MainAsync()

                ' TOOLS / RAG VERARBEITUNG
                If ToolsCodeBlockJson <> "empty" Then
                    AppLog("[DEBUG-StateChanged] Starte Tool/RAG-Verarbeitung...")

                    If SiticoneToggleSwitch_tools.Checked Or SiticoneToggleSwitch_ragtools.Checked Then
                        extractedContext.Clear()
                        tools_Response_mem = python_code_run(Scintilla_Tools_pythoncode.Text, ToolsCodeBlockJson)
                    End If

                    If SiticoneToggleSwitch_ragtools.Checked Then
                        documentIndex.ResetHits()
                        ProcessLLMResponse(ToolsCodeBlockJson, SiticoneDropdown_delta_val.SelectedIndex)
                        tools_Response_mem = ""
                        Dim HITS = documentIndex.GetSentencesWithHits
                        SiticoneLabel_HitCountVal.Text = HITS.Count.ToString
                        For Each HIT In HITS : tools_Response_mem &= HIT.Text & vbCrLf : Next
                    End If

                    ClearFileChips()
                    Try
                        Dim jsonObj = JsonConvert.DeserializeObject(Of Object)(tools_Response_mem)
                        tools_Response_mem = JsonConvert.SerializeObject(jsonObj, Formatting.None)
                        CreateAndAddFileChip("tools_response.json", "json", tools_Response_mem)
                    Catch
                        CreateAndAddFileChip("tools_response.txt", "txt", tools_Response_mem)
                    End Try

                    SiticoneTextArea_prompt_TextChanged(Nothing, Nothing)
                    SiticoneToggleSwitch_tools.Checked = False
                    SiticoneToggleSwitch_ragtools.Checked = False

                    Continue While
                End If

                ' SSH BOT VERARBEITUNG
                If SiticoneToggleSwitch_sshbot.Checked Then
                    Dim sshBlock = CodeBlock_List.FirstOrDefault(Function(cb) cb.Language.ToLower() = "sh" Or cb.Language.ToLower() = "bash")

                    If sshBlock IsNot Nothing Then
                        Dim sshCommand = sshBlock.Code.Trim()
                        AppLog("[DEBUG-StateChanged] SSH Befehl erkannt: " & sshCommand)

                        Dim darfAusgefuehrtWerden As Boolean = True

                        If Not SiticoneToggleSwitch_sshautoexecute.Checked Then
                            Dim msg = "Befehl ausführen?" & vbCrLf & vbCrLf & sshCommand
                            If MessageBox.Show(msg, "SSH Sicherheit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                                darfAusgefuehrtWerden = False
                            End If
                        End If

                        Dim sshResult As String

                        If sshCommand.Contains(vbLf) Then
                            AppLog("[DEBUG-StateChanged] LLM hat mehrzeiligen Block gesendet. Blockiere Ausführung!")
                            darfAusgefuehrtWerden = False
                            sshResult = currentErrMultiline
                        End If

                        If darfAusgefuehrtWerden Then
                            SiticoneTextBox_request_answer.Text = "SSH Executing: " & sshCommand
                            sshResult = Await ExecuteCommandAndWaitAsync(sshCommand, Val(SiticoneTextBox_ssh_timeout.Text))
                        ElseIf Not sshCommand.Contains(vbLf) Then
                            AppLog("[DEBUG-StateChanged] SSH blockiert.")
                            sshResult = currentErrDenied
                        End If

                        Dim cleanResult = sshResult.Replace(vbCr, "").Replace(vbLf, vbCrLf)

                        SiticoneTextArea_prompt.Text = SiticoneTextArea_ssh_response.Text _
                          .Replace("{original_prompt}", originalGoal) _
                          .Replace("{command}", sshCommand) _
                          .Replace("{response}", cleanResult)

                        If iterationCount >= maxIterations Then
                            AppLog("[DEBUG-StateChanged] Agent Maximum an Schritten erreicht.")
                            continueLoop = False
                        End If

                    ElseIf response_mem.Contains("[ZIEL ERREICHT]") OrElse response_mem.Contains("[GOAL ACHIEVED]") Then
                        AppLog("[DEBUG-StateChanged] Agent meldet [ZIEL ERREICHT]. Aufgabe beendet.")
                        continueLoop = False

                    Else
                        AppLog("[DEBUG-StateChanged] Warnung: Kein bash-Block und kein Abschluss-Flag. Erziehe KI...")

                        Dim fehlerMeldung As String = currentErrFormat

                        SiticoneTextArea_prompt.Text = SiticoneTextArea_ssh_response.Text _
                          .Replace("{original_prompt}", originalGoal) _
                          .Replace("{command}", "[FEHLENDER BEFEHL]") _
                          .Replace("{response}", fehlerMeldung)

                        If iterationCount >= maxIterations Then
                            AppLog("[DEBUG-StateChanged] Agent Maximum an Schritten erreicht (beim Format-Failsafe).")
                            continueLoop = False
                        End If
                    End If
                Else
                    continueLoop = False
                End If

                Await Task.Delay(500)
            End While

        Finally
            AppLog("[DEBUG-StateChanged] <--- FINALLY. Agent-Loop beendet.")
            If SiticonePlayPauseButton_request.IsPlaying Then
                SiticonePlayPauseButton_request.IsPlaying = False
            End If
            isRequestRunning = False
            SiticoneTextArea_prompt.Focus()
        End Try
    End Sub

    Private Async Function OllamaDeleteModel(apiBaseUrl As String, model As String) As Task
        Try
            Using client As New HttpClient()
                Dim url As String = $"{apiBaseUrl}/delete"
                Dim req As New HttpRequestMessage(HttpMethod.Delete, url)
                req.Content = New StringContent(
                $"{{ ""model"": ""{model}"" }}",
                Encoding.UTF8,
                "application/json"
            )

                Dim response = Await client.SendAsync(req)
                Dim result = Await response.Content.ReadAsStringAsync()

                Scintilla_response.Text = "DELETE RESULT: " & result
            End Using
        Catch ex As Exception
            Scintilla_response.Text = "ERROR DELETE: " & ex.Message
        End Try
    End Function

    Private Async Function OllamaPullModel(apiBaseUrl As String, model As String) As Task
        Try
            Using client As New HttpClient()
                client.Timeout = TimeSpan.FromSeconds(Val(SiticoneTextBox_timeout.Text))
                Dim url As String = $"{apiBaseUrl}/pull"
                Dim json = $"{{ ""model"": ""{model}"" }}"
                Dim content As New StringContent(json, Encoding.UTF8, "application/json")

                Dim response = Await client.PostAsync(url, content)
                Dim result = Await response.Content.ReadAsStringAsync()

                Scintilla_response.Text = "PULL RESULT: " & result
            End Using
        Catch ex As Exception
            Scintilla_response.Text = "ERROR PULL: " & ex.Message
        End Try
    End Function


    Private Async Sub SiticoneButton_get_llm_Click(sender As Object, e As EventArgs) Handles SiticoneButton_get_llm.Click
        Await LoadModelsAsync()
        Await GetOllamaVersionAsync()
    End Sub

    Private Async Function MainAsync() As Task
        AppLog("[DEBUG-MainAsync] MainAsync gestartet.")
        Try
            cancellationTokenSource = New CancellationTokenSource()
            LLM_progress(True)

            ' --- NEU: Falls zurückgesprungen wurde (currentTurnIndex steht vor dem Ende), 
            ' --- spätere Verlaufsschritte kappen, bevor der neue Request gesendet wird.
            If chatHistory.Count > 0 AndAlso currentTurnIndex >= 0 AndAlso currentTurnIndex < chatHistory.Count - 1 Then
                Dim removeStart As Integer = currentTurnIndex + 1
                Dim removeCount As Integer = chatHistory.Count - removeStart

                chatHistory.RemoveRange(removeStart, removeCount)

                If Response_json_nav_mem.Count > chatHistory.Count Then
                    Response_json_nav_mem.RemoveRange(removeStart, Response_json_nav_mem.Count - removeStart)
                End If

                ' Markdown-Verlauf bis zu diesem Punkt neu aufbauen
                RebuildConversationMarkdownUpToCurrent()
            End If

            Dim model As String = SiticoneDropdown_model.SelectedItem
            Dim prompt As String = SiticoneTextArea_prompt.Text
            Dim system As String = If(SiticoneToggleSwitch_system_use.Checked, SiticoneTextArea_system.Text, "")
            Dim format As String = If(SiticoneToggleSwitch_format_use.Checked, Scintilla_format.Text, "")
            Dim tools As String = ""

            If SiticoneToggleSwitch_tools.Checked Then
                AppLog("[DEBUG-MainAsync] Tools-Modus aktiv: Überschreibe System-Prompt mit 'Tools-System'.")
                tools = Scintilla_Tools_Json.Text
                system = SiticoneTextArea_Tools_system.Text
            ElseIf SiticoneToggleSwitch_ragtools.Checked Then
                AppLog("[DEBUG-MainAsync] RAG-Modus aktiv: Überschreibe System-Prompt mit 'RAG-System'.")
                tools = Scintilla_Rag_Json.Text
                system = SiticoneTextArea_Rag_system.Text
            ElseIf SiticoneToggleSwitch_sshbot.Checked Then
                AppLog("[DEBUG-MainAsync] SSH-Bot-Modus aktiv: Überschreibe System-Prompt mit 'SSH-System'.")
                system = SiticoneTextArea_ssh_system.Text
                tools = ""
            Else
                AppLog("[DEBUG-MainAsync] Normaler Modus: Nutze Standard-System-Prompt (falls aktiviert).")
            End If

            Dim think As Boolean = SiticoneToggleSwitch_thinking_use.Checked
            Dim think_level As String = SiticoneDropdown_thinking_use.SelectedItem
            Dim context As Boolean = SiticoneToggleSwitch_last_context.Checked AndAlso extractedContext.Count > 0

            If SiticoneToggleSwitch_sshbot.Checked Then
                If SiticoneToggleSwitch_sshreinsert.Checked = False Then
                    If context Then
                        system = ""
                        AppLog("[DEBUG-MainAsync] System Prompt gelöscht")
                    End If
                End If
            Else
                If context Then
                    system = ""
                    AppLog("[DEBUG-MainAsync] System Prompt gelöscht")
                End If
            End If

            If text_contents.Count > 0 Then
                Dim prompt_files_content As String = ""
                For Each text_content In text_contents
                    Dim file_content = My.Settings.context_file _
                    .Replace("{filename}", text_content.fileName) _
                    .Replace("{filextention}", text_content.fileExtention) _
                    .Replace("{text}", text_content.text)
                    prompt_files_content &= file_content & vbCrLf
                Next
                prompt = SiticoneTextArea_content_prompt.Text.Replace("{files}", prompt_files_content).Replace("{prompt}", prompt)
            End If

            prompt = prompt.Replace(vbCr, "")
            request_mem = prompt

            AppLog("[DEBUG-MainAsync] Warte auf QueryOllamaAsync...")
            Dim response As String = Await QueryOllamaAsync(model, prompt, image_contents, audio_contents, text_contents, My.Settings.option_list, system, format, tools, think, think_level, context, extractedContext, cancellationTokenSource.Token)
            AppLog("[DEBUG-MainAsync] QueryOllamaAsync hat geantwortet!")

            response_mem = response
            SiticoneButton_show_thinking.Enabled = (extractedThinking <> "")

            Try
                Scintilla_Request_JSON.Text = JToken.Parse(Request_JSON).ToString(Formatting.Indented)
            Catch
                Scintilla_Request_JSON.Text = Request_JSON
            End Try

            If Not String.IsNullOrEmpty(response) Then
                If response.StartsWith("Error:") Then
                    Console.Beep(800, 150)
                    Threading.Thread.Sleep(50)
                    Console.Beep(600, 150)
                    Threading.Thread.Sleep(50)
                    Console.Beep(300, 150)
                Else
                    SystemSounds.Asterisk.Play()
                End If

                Response_json_nav_mem.Add(Response_JSON)
                Response_nav_pointer = Response_json_nav_mem.Count - 1

                AppLog("[DEBUG-MainAsync] Rufe render_response() auf...")
                render_response(response, isNewTurn:=True, promptText:=request_mem)

                If SiticoneToggleSwitch_sshbot.Checked AndAlso response.Contains("```bash") Then
                    SiticoneTabControl_tab.SelectedTab = TabPage_sshbot
                Else
                    SiticoneTabControl_tab.SelectedTab = TabPage_responsehtml
                End If

                UpdateMemoryUI()
            Else
                AppLog("[DEBUG-MainAsync] Response war leer, lade leeres HTML.")
                Scintilla_Response_JSON.Text = "empty"
                Scintilla_response.Text = "empty"
                WebView21.NavigateToString(BuildHtml("empty"))
            End If

        Finally
            AppLog("[DEBUG-MainAsync] Finally-Block erreicht, stoppe Timer (LLM_progress).")
            LLM_progress(False)
        End Try
    End Function

    Sub render_response(response_sub As String, Optional isNewTurn As Boolean = False, Optional promptText As String = "")
        Dim model As String = If(SiticoneDropdown_model.SelectedItem IsNot Nothing, SiticoneDropdown_model.SelectedItem.ToString(), "Model")

        ' Wenn die Antwort valides JSON ist, erst in hübsch formatierten Text (Pretty Print) umwandeln
        If IsValidJsonCore(response_sub) Then
            Try
                Dim parsedJson As JToken = JToken.Parse(response_sub)
                response_sub = parsedJson.ToString(Newtonsoft.Json.Formatting.Indented)
            Catch ex As Exception
            End Try

            response_sub = "```json" & vbLf & response_sub & vbLf & "```"
        End If

        Dim backtickCount As Integer = Regex.Matches(response_sub, "```").Count
        If backtickCount Mod 2 <> 0 Then
            response_sub &= vbLf & "```"
        End If

        Scintilla_response.Text = response_sub.Replace(vbLf, vbCrLf)

        If isNewTurn Then
            ' Kopie der aktuellen KI-Kontext-Tokens für diesen Schritt sichern
            Dim contextCopy As New List(Of Integer)(extractedContext)

            chatHistory.Add(New ChatTurn With {
            .UserPrompt = promptText,
            .ResponseText = response_sub,
            .ContextTokens = contextCopy,
            .ModelName = model
        })
            currentTurnIndex = chatHistory.Count - 1

            ' Verlauf bis zum aktuellen Index aufbauen und im WebView2 anzeigen
            RebuildConversationMarkdownUpToCurrent()
            WebView21.NavigateToString(BuildHtml(conversationHistoryMarkdown.ToString()))

            UpdateButtonStates()
        Else
            If SiticoneToggleSwitch_last_context.Checked AndAlso conversationHistoryMarkdown.Length > 0 Then
                WebView21.NavigateToString(BuildHtml(conversationHistoryMarkdown.ToString()))
            Else
                WebView21.NavigateToString(BuildHtml(response_sub))
            End If
        End If

        SiticoneButton_HTMLtoPDF.Enabled = True

        Try
            Dim parsedJson As JToken = JToken.Parse(Response_JSON)
            If parsedJson("image") IsNot Nothing Then
                parsedJson("image") = "<... Base64 Image Data Truncated ...>"
            End If
            Dim prettyJsonString As String = parsedJson.ToString(Formatting.Indented)
            Scintilla_Response_JSON.Text = prettyJsonString
            CodeBlock_List.Clear()
            ToolsCodeBlockJson = ""
            SiticoneDropdown_language.Items.Clear()
            Scintilla_code_block.Text = ""
            SiticoneTextArea_run_output.Text = ""
            CodeBlock_List = ExtractCodeBlocks(response_sub)
            If ToolsCodeBlockJson <> "empty" Then
                SiticoneTextBox_request_answer.Text = ToolsCodeBlockJson
            End If
            SiticoneButton_code_run.Enabled = False

            If CodeBlock_List.Count >= 1 Then
                For i As Integer = 0 To CodeBlock_List.Count - 1
                    Dim block As CodeBlock = CodeBlock_List(i)
                    Dim displayLanguage As String = If(String.IsNullOrWhiteSpace(block.Language), "unknown", block.Language)
                    SiticoneDropdown_language.Items.Add($"{i + 1}. {displayLanguage}")
                Next
                SiticoneDropdown_language.SelectedIndex = 0
                change_language()
            End If

        Catch ex As Exception
            Scintilla_Response_JSON.Text = Response_JSON
        End Try
    End Sub

    Private Function GetResponseTextFromJson(jsonString As String) As String
        Try
            Dim json As JObject = JObject.Parse(jsonString)
            If json("response") IsNot Nothing Then
                Return json("response").ToString()
            ElseIf json("message") IsNot Nothing AndAlso json("message")("content") IsNot Nothing Then
                Return json("message")("content").ToString()
            End If
            Return "Kein Inhalt gefunden."
        Catch ex As Exception
            Return "Fehler beim Lesen der Historie: " & ex.Message
        End Try
    End Function

    Private Sub LLM_progress(start As Boolean)
        Timer_LLM_progress.Enabled = start
        SiticonePlayPauseButton_request.ShowProgress = start
    End Sub

    Private Sub Timer_LLM_progress_Tick(sender As Object, e As EventArgs) Handles Timer_LLM_progress.Tick
        Dim progress_val = SiticonePlayPauseButton_request.PlayProgress
        progress_val += 0.05
        If progress_val >= 1 Then
            progress_val = 0
        End If
        SiticonePlayPauseButton_request.PlayProgress = progress_val
    End Sub

    Private Sub SiticoneButton_nav_l_Click(sender As Object, e As EventArgs) Handles SiticoneButton_nav_l.Click
        If currentTurnIndex > 0 Then
            RenderChatHistoryUpTo(currentTurnIndex - 1)
        End If
    End Sub

    Private Sub SiticoneButton_nav_r_Click(sender As Object, e As EventArgs) Handles SiticoneButton_nav_r.Click
        If chatHistory IsNot Nothing AndAlso currentTurnIndex < chatHistory.Count - 1 Then
            RenderChatHistoryUpTo(currentTurnIndex + 1)
        End If
    End Sub

    Private Sub RenderChatHistoryUpTo(ByVal maxIndex As Integer)
        If chatHistory Is Nothing OrElse chatHistory.Count = 0 Then
            currentTurnIndex = -1
            extractedContext.Clear()
            conversationHistoryMarkdown.Clear()
            UpdateButtonStates()
            Return
        End If

        If maxIndex < 0 Then maxIndex = 0
        If maxIndex >= chatHistory.Count Then maxIndex = chatHistory.Count - 1

        currentTurnIndex = maxIndex

        ' Setze die KI-Kontext-Tokens auf den Stand dieses gewählten Schrittes zurück
        If chatHistory(currentTurnIndex).ContextTokens IsNot Nothing Then
            extractedContext = New List(Of Integer)(chatHistory(currentTurnIndex).ContextTokens)
        Else
            extractedContext.Clear()
        End If

        ' Markdown-Verlauf bis zum gewählten Schritt neu aufbauen
        RebuildConversationMarkdownUpToCurrent()

        If WebView21 IsNot Nothing AndAlso WebView21.CoreWebView2 IsNot Nothing Then
            WebView21.NavigateToString(BuildHtml(conversationHistoryMarkdown.ToString()))
        End If

        UpdateButtonStates()
    End Sub

    Private Sub RebuildConversationMarkdownUpToCurrent()
        conversationHistoryMarkdown.Clear()
        If chatHistory Is Nothing OrElse chatHistory.Count = 0 OrElse currentTurnIndex < 0 Then Return

        Dim currentFallbackModel As String = If(SiticoneDropdown_model.SelectedItem IsNot Nothing, SiticoneDropdown_model.SelectedItem.ToString(), "Model")

        For i As Integer = 0 To currentTurnIndex
            Dim turn = chatHistory(i)

            ' Verwende den im ChatTurn gespeicherten Modellnamen, sonst Fallback
            Dim displayModel As String = If(Not String.IsNullOrWhiteSpace(turn.ModelName), turn.ModelName, currentFallbackModel)

            Dim encodedPrompt As String = System.Web.HttpUtility.HtmlEncode(turn.UserPrompt) _
            .Replace(vbCrLf, "<br>") _
            .Replace(vbLf, "<br>") _
            .Replace(vbCr, "<br>")

            Dim userBubbleHtml As String = $"<div style=""background-color: #f0f2f5; border-radius: 12px; padding: 12px 16px; margin: 12px 0 20px 0; border: 1px solid #e4e6eb; border-left: 4px solid #0078d4; box-shadow: 0 2px 4px rgba(0,0,0,0.05);"">" &
                                       $"<div style=""font-weight: 600; font-size: 0.95em; color: #1c1e21; margin-bottom: 6px;"">👤 User</div>" &
                                       $"<div style=""color: #050505; line-height: 1.5; font-size: 0.98em;"">{encodedPrompt}</div>" &
                                       $"</div>"

            Dim turnMarkdown As String = userBubbleHtml & vbCrLf & vbCrLf &
                                     $"### 🤖 {displayModel}{vbCrLf}{turn.ResponseText}{vbCrLf}{vbCrLf}---{vbCrLf}"

            conversationHistoryMarkdown.AppendLine(turnMarkdown)
        Next
    End Sub

    Private Function GetHtmlHeader() As String
        Return "<html><head><meta charset='utf-8'>" &
           "<style>" &
           "  body { font-family: 'Segoe UI', sans-serif; background-color: #1e1e1e; color: #dcdcdc; margin: 10px; padding: 0; }" &
           "  .chat-turn { margin-bottom: 20px; border-bottom: 1px solid #333; padding-bottom: 10px; }" &
           "  .user-message { background-color: #2d2d2d; padding: 10px; border-radius: 6px; margin-bottom: 8px; font-weight: bold; }" &
           "  .assistant-message { background-color: #252526; padding: 10px; border-radius: 6px; }" &
           "</style></head><body>"
    End Function

    Private Function GetHtmlFooter() As String
        Return "<script>window.scrollTo(0, document.body.scrollHeight);</script></body></html>"
    End Function

    Private Sub UpdateButtonStates()
        Dim hasHistory As Boolean = (chatHistory IsNot Nothing AndAlso chatHistory.Count > 0)

        ' Zurück-Button ist aktiv, sobald wir mehr als 1 Eintrag haben und nicht beim ersten stehen
        SiticoneButton_nav_l.Enabled = hasHistory AndAlso (currentTurnIndex > 0)

        ' Vor-Button ist aktiv, wenn wir zurückgesprungen sind
        SiticoneButton_nav_r.Enabled = hasHistory AndAlso (currentTurnIndex < chatHistory.Count - 1)

        UpdateMemoryUI()
    End Sub
    Private Sub SiticoneButton_nav_clear_Click(sender As Object, e As EventArgs) Handles SiticoneButton_nav_clear.Click
        AppLog("[DEBUG-nav_clear_Click] User hat Navigation und Context gelöscht.")

        ' chatHistory zurücksetzen
        chatHistory.Clear()
        currentTurnIndex = -1
        UpdateButtonStates()

        Response_nav_pointer = -1
        Response_json_nav_mem.Clear()
        extractedContext.Clear()
        conversationHistoryMarkdown.Clear()
        WebView21.NavigateToString(BuildHtml("*Context memory and HTML history have been cleared.*"))

        UpdateMemoryUI()
    End Sub

    Private Sub UpdateMemoryUI()
        Dim currentPage As Integer = currentTurnIndex + 1
        Dim totalPages As Integer = If(chatHistory IsNot Nothing, chatHistory.Count, 0)
        Dim ctxCount As Integer = extractedContext.Count

        SiticoneButton_nav_clear.Text = $"{currentPage}/{totalPages} ({ctxCount})"
        SiticoneLabel_last_context.Text = $"Use Last Context ({ctxCount} Tokens)"
    End Sub

    Private Function BuildHtml(markDownStr As String) As String
        Dim pipeline = New MarkdownPipelineBuilder() _
        .UseAdvancedExtensions() _
        .UseMathematics() _
        .UseEmojiAndSmiley() _
        .Build()

        markDownStr = markDownStr.Replace("\[", "$$")
        markDownStr = markDownStr.Replace("\]", "$$")
        markDownStr = markDownStr.Replace("\(", "$")
        markDownStr = markDownStr.Replace("\)", "$")
        markDownStr = markDownStr.Replace("\begin{equation}", "$$")
        markDownStr = markDownStr.Replace("\end{equation}", "$$")
        markDownStr = AddLanguageTag(markDownStr)
        markDownStr = ConvertThinkBlocks(markDownStr)

        If SiticoneToggleSwitch_test.Checked = True Then
            Clipboard.SetText(markDownStr)
        End If
        Dim htmlContent As String = Markdig.Markdown.ToHtml(markDownStr, pipeline)

        Dim fullHtml = Replace(My.Settings.html_def, "{htmlContent}", htmlContent)

        Return fullHtml
    End Function

    Function AddLanguageTag(markdown As String) As String
        Dim lines As String() = markdown.Split({vbCrLf, vbCr, vbLf}, StringSplitOptions.None)
        Dim result As New System.Text.StringBuilder()

        For Each line As String In lines
            If line.Trim().StartsWith("```") And (line.Trim().Length > 3) Then
                Dim language As String = Mid(line.Trim(), 4).Trim()
                Dim leadingSpaces As Integer = line.Length - line.TrimStart().Length
                result.AppendLine(Space(leadingSpaces) & "<lang>" & language & "</lang>")
                result.AppendLine(line)

            Else
                result.AppendLine(line)
            End If
        Next
        Return result.ToString()
    End Function

    Public Function ConvertThinkBlocks(markdown As String) As String
        Dim pattern As String = "<think>(.*?)</think>"

        Dim evaluator As MatchEvaluator = Function(m As Match)
                                              Dim content As String = m.Groups(1).Value.Trim()
                                              Dim lines As String() = Regex.Split(content, "\r?\n")
                                              For i As Integer = 0 To lines.Length - 1
                                                  lines(i) = "> " & lines(i)
                                              Next
                                              Dim newContent As String = "> **think:**" & Environment.NewLine & String.Join(Environment.NewLine, lines)
                                              Return newContent
                                          End Function

        Dim result As String = Regex.Replace(markdown, pattern, evaluator, RegexOptions.Singleline)
        Return result
    End Function

    Private Async Function QueryOllamaAsync(model As String,
                                        prompt As String,
                                        image_list As List(Of image_content_def),
                                        audio_list As List(Of audio_content_def),
                                        text_list As List(Of text_content_def),
                                        option_list As System.Collections.Specialized.StringCollection,
                                        Optional system As String = "",
                                        Optional format As String = "",
                                        Optional tools As String = "",
                                        Optional think As Boolean = False,
                                        Optional think_level As String = "false",
                                        Optional context As Boolean = False,
                                        Optional last_context As List(Of Integer) = Nothing,
                                        Optional ct As CancellationToken = Nothing) As Task(Of String)

        AppLog($"[DEBUG-QueryOllama] ---> QueryOllamaAsync gestartet. Model: '{model}'")

        ' 1. API-Endpunkt dynamisch wählen
        Dim apiUrl As String
        If SiticoneToggleSwitch_decisiontools.Checked Then
            apiUrl = "http://" & SiticoneTextBox_host.Text & "/v1/systemone"
        Else
            apiUrl = "http://" & SiticoneTextBox_host.Text & "/api/generate"
        End If

        Dim requestBody As String = ""

        If image_contents.Count > 0 AndAlso prompt = "" Then
            prompt = "Analyse Image"
        End If

        If audio_contents.Count > 0 AndAlso prompt = "" Then
            prompt = "Analyse Audio"
        End If

        ' Options-Dictionary für normalen Modus vorbereiten
        Dim options As New Dictionary(Of String, Object)
        For Each optionString As String In My.Settings.option_list
            Dim values() As String = optionString.Split(New String() {"<|>"}, StringSplitOptions.None)
            If LCase(values(1)) = "true" Then
                Select Case values(2)
                    Case "string"
                        options(values(0)) = values(3)
                    Case "int"
                        options(values(0)) = Integer.Parse(values(3))
                    Case "float"
                        options(values(0)) = Double.Parse(values(3))
                    Case "boolean"
                        options(values(0)) = Boolean.Parse(values(3))
                End Select
            End If
        Next

        ' 2. PAYLOAD GENERIERUNG
        If SiticoneToggleSwitch_decisiontools.Checked Then
            AppLog($"[DEBUG-QueryOllama] Modus: Decision Tools ({apiUrl})")

            Dim payload As New JObject()
            payload("model") = model
            payload("state") = prompt

            ' Bilder für Vision-fähige Decision Modelle (z.B. clef-flash) hinzufügen
            If image_list.Count > 0 Then
                AppLog($"[DEBUG-QueryOllama] Füge {image_list.Count} Bild(er) zum Decision-Payload hinzu.")
                Dim base64Images As New List(Of String)
                For Each imgObj In image_list
                    base64Images.Add(imgObj.base64String)
                Next
                payload("images") = JArray.FromObject(base64Images)
            End If

            ' Questions-Objekt verarbeiten
            Dim rawQuestions As String = Scintilla_Decision_Json.Text.Trim()
            Try
                If Not String.IsNullOrEmpty(rawQuestions) Then
                    Dim parsedJson As JToken = JToken.Parse(rawQuestions)

                    ' Falls der User das komplette JSON inkl. "questions"-Key eingefügt hat:
                    If parsedJson.Type = JTokenType.Object AndAlso parsedJson("questions") IsNot Nothing Then
                        payload("questions") = parsedJson("questions")
                    Else
                        payload("questions") = parsedJson
                    End If
                Else
                    payload("questions") = New JObject()
                End If
            Catch ex As Exception
                AppLog($"[DEBUG-QueryOllama] FEHLER beim Parsen von Scintilla_Decision_Json: {ex.Message}")
                payload("questions") = New JObject()
            End Try

            requestBody = payload.ToString(Newtonsoft.Json.Formatting.None)
        Else
            AppLog($"[DEBUG-QueryOllama] Modus: Normal ({apiUrl})")

            Dim payload As New Dictionary(Of String, Object) From {
            {"model", model},
            {"prompt", prompt},
            {"stream", False}
        }

            If Not String.IsNullOrEmpty(format) Then
                Dim raw = format.Trim()
                Try
                    payload("format") = JToken.Parse(raw)
                Catch ex As Exception
                    payload("format") = raw
                End Try
            End If

            If image_list.Count > 0 Then
                Dim base64Images As New List(Of String)
                For Each imgObj In image_list
                    base64Images.Add(imgObj.base64String)
                Next
                payload("images") = base64Images
            End If

            If audio_list.Count > 0 Then
                Dim base64Audio As New List(Of String)
                For Each audObj In audio_list
                    base64Audio.Add(audObj.base64String)
                Next
                payload("audio") = base64Audio
            End If

            If Not String.IsNullOrEmpty(system) Then
                payload("system") = system
            End If

            If Not String.IsNullOrEmpty(tools) Then
                Dim raw = tools.Trim()
                Try
                    payload("tools") = JToken.Parse(raw)
                Catch ex As Exception
                    payload("tools") = raw
                End Try
            End If

            If think Then
                Select Case think_level
                    Case "false" : payload("think") = False
                    Case "true" : payload("think") = True
                    Case Else : payload("think") = think_level
                End Select
            End If

            If context AndAlso last_context IsNot Nothing AndAlso last_context.Count <> 0 Then
                payload("context") = last_context
            End If

            If options.Count > 0 Then
                payload("options") = options
            End If

            requestBody = JsonConvert.SerializeObject(payload)
        End If

        ' 3. UI Request_JSON vorbereiten (Bilder für Log/Anzeige einkürzen)
        Try
            Dim jsonObj As JObject = JObject.Parse(requestBody)
            If jsonObj("images") IsNot Nothing Then
                jsonObj("images") = JArray.Parse("[""<... Base64 Image Data Truncated ...>""]")
            End If
            Request_JSON = jsonObj.ToString()
            AppLog("[DEBUG-QueryOllama] JSON für UI erfolgreich generiert.")
        Catch ex As Exception
            AppLog($"[DEBUG-QueryOllama] FEHLER beim Parsen des Request-JSONs für das UI: {ex.Message}")
            Request_JSON = requestBody.Substring(0, Math.Min(requestBody.Length, 5000))
        End Try

        AppLog($"[DEBUG-QueryOllama] Payload-Generierung beendet. URL: {apiUrl}")

        ' 4. HTTP REQUEST AUSFÜHREN
        If SiticoneToggleSwitch_test.Checked = False Then

            Response_JSON = ""

            Dim handler As New HttpClientHandler()
            handler.UseProxy = My.Settings.use_proxy

            Using client As New HttpClient(handler)

                Dim timeoutSecs As Double = Val(SiticoneTextBox_timeout.Text.Trim())
                If timeoutSecs <= 0 Then
                    AppLog("[DEBUG-QueryOllama] WARNUNG: Timeout war <= 0 oder ungültig. Setze Fallback auf 600 Sekunden.")
                    timeoutSecs = 600
                End If
                client.Timeout = TimeSpan.FromSeconds(timeoutSecs)
                AppLog($"[DEBUG-QueryOllama] HttpClient Timeout gesetzt auf: {timeoutSecs} Sekunden.")

                Dim content As New StringContent(requestBody, Encoding.UTF8, "application/json")

                Try
                    AppLog("[DEBUG-QueryOllama] Sende POST Request an Ollama...")
                    Dim response As HttpResponseMessage = Await client.PostAsync(apiUrl, content, ct)
                    AppLog($"[DEBUG-QueryOllama] Antwort erhalten. StatusCode: {response.StatusCode}")

                    If response.IsSuccessStatusCode Then
                        Dim responseBody As String = Await response.Content.ReadAsStringAsync()

                        If My.Settings.test_response <> "" Then
                            AppLog("[DEBUG-QueryOllama] Überschreibe Antwort mit Test-Response aus Settings.")
                            responseBody = My.Settings.test_response
                        End If

                        Response_JSON = responseBody
                        Dim json As JObject = JObject.Parse(responseBody)
                        Dim extractedResponse As String = json.SelectToken("response")?.ToString()

                        ' Fallback: Falls die Antwort kein "response"-Feld besitzt (sondern z.B. direkt ein Decision-JSON ist):
                        If String.IsNullOrEmpty(extractedResponse) Then
                            extractedResponse = responseBody
                        End If

                        ' Bildverarbeitung
                        Dim imageBase64 As String = json.SelectToken("image")?.ToString()
                        If Not String.IsNullOrEmpty(imageBase64) Then
                            AppLog("[DEBUG-QueryOllama] Bild in Antwort gefunden. Starte Speicherung...")
                            Try
                                Dim imageBytes As Byte() = Convert.FromBase64String(imageBase64)
                                Dim fileExtension As String = ".png"

                                If imageBytes.Length > 1 Then
                                    If imageBytes(0) = &HFF AndAlso imageBytes(1) = &HD8 Then
                                        fileExtension = ".jpg"
                                    ElseIf imageBytes(0) = &H89 AndAlso imageBytes(1) = &H50 Then
                                        fileExtension = ".png"
                                    ElseIf imageBytes(0) = &H47 AndAlso imageBytes(1) = &H49 Then
                                        fileExtension = ".gif"
                                    ElseIf imageBytes(0) = &H42 AndAlso imageBytes(1) = &H4D Then
                                        fileExtension = ".bmp"
                                    End If
                                End If

                                Dim fileName As String = $"ollama_img_{DateTime.Now:yyyyMMdd_HHmmss}_{Guid.NewGuid().ToString().Substring(0, 5)}{fileExtension}"
                                Dim tempFilePath As String = IO.Path.Combine(IO.Path.GetTempPath(), fileName)

                                IO.File.WriteAllBytes(tempFilePath, imageBytes)
                                AppLog($"[DEBUG-QueryOllama] Bild gespeichert unter: {tempFilePath}")

                                Dim fileNameOnly As String = IO.Path.GetFileName(tempFilePath)
                                Dim virtualUrl As String = $"https://ollama.local/{fileNameOnly}"
                                Dim markdownImage As String = $"![Generiertes Bild]({virtualUrl})"

                                If String.IsNullOrEmpty(extractedResponse) Then
                                    extractedResponse = markdownImage
                                Else
                                    extractedResponse &= vbCrLf & vbCrLf & markdownImage
                                End If
                            Catch ex As Exception
                                AppLog($"[DEBUG-QueryOllama] FEHLER beim Speichern des Bildes: {ex.Message}")
                                extractedResponse &= vbCrLf & $"[ERROR_SAVING_IMAGE: {ex.Message}]"
                            End Try
                        End If

                        Try
                            extractedContext.Clear()
                            extractedThinking = json.SelectToken("thinking")?.ToString()

                            Dim tempItems = json("context")?.ToObject(Of List(Of Integer))()
                            If tempItems IsNot Nothing Then
                                extractedContext.AddRange(tempItems)
                            End If

                            timing_total_duration = json.SelectToken("total_duration")?.Value(Of Long)
                            timing_load_duration = json.SelectToken("load_duration")?.Value(Of Long)
                            timing_prompt_eval_count = json.SelectToken("prompt_eval_count")?.Value(Of Long)
                            timing_prompt_eval_duration = json.SelectToken("prompt_eval_duration")?.Value(Of Long)
                            timing_eval_count = json.SelectToken("eval_count")?.Value(Of Long)
                            timing_eval_duration = json.SelectToken("eval_duration")?.Value(Of Long)
                            SiticoneButton_timing.Enabled = True
                            AppLog("[DEBUG-QueryOllama] Timing und Context erfolgreich geparst.")
                        Catch ex As Exception
                            AppLog($"[DEBUG-QueryOllama] FEHLER beim Parsen von Timing/Context: {ex.Message}")
                            SiticoneButton_timing.Enabled = False
                        End Try

                        AppLog("[DEBUG-QueryOllama] <--- QueryOllamaAsync erfolgreich beendet.")
                        Return extractedResponse
                    Else
                        AppLog($"[DEBUG-QueryOllama] <--- HTTP FEHLER: {response.StatusCode} - {response.ReasonPhrase}")
                        Return $"Error: {response.StatusCode} - {response.ReasonPhrase}"
                    End If

                Catch ex As TaskCanceledException
                    If ct.IsCancellationRequested Then
                        AppLog("[DEBUG-QueryOllama] <--- ABBRUCH: Request wurde durch User/UI storniert (CancellationToken).")
                        Return "Error: Request cancelled by UI (User hat auf Stop gedrückt)."
                    Else
                        AppLog($"[DEBUG-QueryOllama] <--- TIMEOUT: Request timed out by HttpClient nach {client.Timeout.TotalSeconds} Sekunden!")
                        Return $"Error: Request timed out by HttpClient nach {client.Timeout.TotalSeconds} Sekunden!"
                    End If
                Catch ex As Exception
                    AppLog($"[DEBUG-QueryOllama] <--- AUSNAHME: {ex.Message}")
                    Return $"Error: {ex.Message}"
                End Try
            End Using
        Else
            AppLog("[DEBUG-QueryOllama] <--- Test-Modus aktiv. Gebe vorhandenen Scintilla Text zurück.")
            Response_JSON = "empty"
            Return Scintilla_response.Text
        End If

    End Function

    Private Async Function InitializeWebView2(Optional ByVal anchor As String = "") As Task
        Try
            If WebView21.CoreWebView2 Is Nothing Then
                Dim userDataFolder As String = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "Ollama_Desktop",
                "WebView2_Data"
            )

                If Not Directory.Exists(userDataFolder) Then Directory.CreateDirectory(userDataFolder)

                Dim env = Await CoreWebView2Environment.CreateAsync(Nothing, userDataFolder)

                Await WebView21.EnsureCoreWebView2Async(env)

                WebView21.CoreWebView2.SetVirtualHostNameToFolderMapping(
                    "ollama.local",
                    IO.Path.GetTempPath(),
                    Microsoft.Web.WebView2.Core.CoreWebView2HostResourceAccessKind.Allow
                )
            End If

            Dim appPath As String = AppContext.BaseDirectory
            Dim helpFilePath As String = Path.Combine(appPath, My.Settings.help_path)

            If File.Exists(helpFilePath) Then
                SiticoneTabControl_tab.SelectedTab = TabPage_responsehtml

                Dim fileUri As String = New Uri(helpFilePath).AbsoluteUri

                If WebView21.Source IsNot Nothing AndAlso WebView21.Source.AbsoluteUri = fileUri Then
                    Await ScrollToAnchor(anchor)
                Else
                    Dim handler As EventHandler(Of Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs) = Nothing
                    handler = Async Sub(sender, e)
                                  RemoveHandler WebView21.NavigationCompleted, handler
                                  If e.IsSuccess Then
                                      Await ScrollToAnchor(anchor)
                                  End If
                              End Sub

                    AddHandler WebView21.NavigationCompleted, handler
                    WebView21.CoreWebView2.Navigate(fileUri)
                End If
            Else
                WebView21.NavigateToString($"<html><body><h2 style='color:red;'>Datei nicht gefunden!</h2><p>Gesuchter Pfad:<br><code>{helpFilePath}</code></p></body></html>")
            End If

        Catch ex As Exception
            MessageBox.Show("Fehler: " & ex.Message)
        End Try
    End Function

    Private Async Function InitializeWebViewTerminal() As Task
        Dim userDataFolder As String = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "Ollama_Desktop",
            "WebView2_Terminal"
        )
        If Not Directory.Exists(userDataFolder) Then Directory.CreateDirectory(userDataFolder)
        Dim env = Await CoreWebView2Environment.CreateAsync(Nothing, userDataFolder)
        Await WebViewTerminal.EnsureCoreWebView2Async(env)
        Dim htmlPath As String = Path.Combine(AppContext.BaseDirectory, "terminal.html")
        WebViewTerminal.CoreWebView2.Navigate(htmlPath)
    End Function

    Private Async Function ScrollToAnchor(anchor As String) As Task
        If Not String.IsNullOrEmpty(anchor) Then
            Await Task.Delay(250)
            Dim script As String = $"document.getElementById('{anchor}')?.scrollIntoView({{behavior: 'smooth', block: 'start'}});"
            Await WebView21.ExecuteScriptAsync(script)
        End If
    End Function

    Private Async Function LoadModelsAsync() As Task
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim apiUrl As String = "http://" & SiticoneTextBox_host.Text & "/api/tags"
            Using client As New HttpClient()
                Dim response As HttpResponseMessage = Await client.GetAsync(apiUrl)
                If response.IsSuccessStatusCode Then
                    Dim responseBody As String = Await response.Content.ReadAsStringAsync()

                    Dim json As JObject = JObject.Parse(responseBody)
                    Dim modelsArray As JArray = json("models")

                    Dim sortedModels = modelsArray.OrderBy(Function(m) m("name").ToString()).ToList()

                    SiticoneDropdown_model.Items.Clear()
                    model_info.Clear()

                    For Each model In sortedModels
                        Dim modelName As String = model("name").ToString()
                        SiticoneDropdown_model.Items.Add(modelName)
                        model_info.Add(model.ToString)
                    Next

                    If SiticoneDropdown_model.Items.Count > 0 Then
                        SiticoneDropdown_model.SelectedIndex = 0
                    End If
                Else
                    MessageBox.Show("Error loading models: " & response.ReasonPhrase)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving models: " & ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Function

    Private Async Function GetOllamaVersionAsync() As Task
        Dim version As String = "Unknown Version"

        Try
            Dim apiUrl As String = "http://" & SiticoneTextBox_host.Text & "/api/version"

            Using client As New HttpClient()
                client.Timeout = TimeSpan.FromSeconds(5)

                Dim response As HttpResponseMessage = Await client.GetAsync(apiUrl)

                If response.IsSuccessStatusCode Then
                    Dim responseBody As String = Await response.Content.ReadAsStringAsync()

                    Dim json As JObject = JObject.Parse(responseBody)
                    version = json("version").ToString()
                Else
                    version = "Error: " & response.StatusCode.ToString()
                End If
            End Using

        Catch ex As Exception
            version = "Offline / Error"
        End Try

        Ollama_ver = version
        Dim programName As String = My.Application.Info.Title
        Dim programVersion As String = My.Application.Info.Version.ToString()

        Dim appInfo As String = programName & ": v" & programVersion & " / Ollama: v" & Ollama_ver
        SiticoneDragForm_Header.Title = appInfo

    End Function

    Private Sub SiticoneButton_file_Click(sender As Object, e As EventArgs) Handles SiticoneButton_file.Click
        Dim openFileDialog As New OpenFileDialog
        openFileDialog.Filter = "Text Dateien (*.txt)|*.txt|PDF Datei (*.pdf)|*.pdf|JSON Datei (*.json)|*.json|Audio Dateien (*.wav;*.mp3)|*.wav;*.mp3|Bild (*.jpg)|*.jpg|Bild (*.png)|*.png|Alle Dateien (*.*)|*.*"
        openFileDialog.Multiselect = True

        If openFileDialog.ShowDialog = DialogResult.OK Then
            For Each filePath In openFileDialog.FileNames
                Dim fileExtension = Mid(LCase(Path.GetExtension(filePath)), 2)
                Dim fileName = Path.GetFileName(filePath)

                Try
                    Select Case fileExtension
                        Case "jpg", "png"
                            Dim imageBytes = File.ReadAllBytes(filePath)
                            Dim iContent As New image_content_def With {
                                .base64String = Convert.ToBase64String(imageBytes),
                                .fileName = fileName,
                                .fileExtension = fileExtension
                            }
                            image_contents.Add(iContent)

                        Case "wav", "mp3"
                            Dim audioBytes = File.ReadAllBytes(filePath)
                            Dim aContent As New audio_content_def With {
                                .base64String = Convert.ToBase64String(audioBytes),
                                .fileName = fileName,
                                .fileExtension = fileExtension
                            }
                            audio_contents.Add(aContent)

                        Case "txt"
                            Dim file_content = File.ReadAllText(filePath)
                            Dim tContent As New text_content_def With {
                                .text = file_content,
                                .fileName = fileName,
                                .fileExtention = fileExtension
                            }
                            text_contents.Add(tContent)

                        Case "pdf"
                            Dim sb As New Text.StringBuilder()
                            Using Pdfdoc = UglyToad.PdfPig.PdfDocument.Open(filePath)
                                For Each page In Pdfdoc.GetPages()
                                    sb.AppendLine(page.Text & vbLf)
                                Next
                            End Using
                            Dim tContent As New text_content_def With {
                                .text = sb.ToString(),
                                .fileName = fileName,
                                .fileExtention = fileExtension
                            }
                            text_contents.Add(tContent)

                        Case "json"
                            Dim file_content = File.ReadAllText(filePath)
                            Try
                                Dim jsonObj = JsonConvert.DeserializeObject(Of Object)(file_content)
                                file_content = JsonConvert.SerializeObject(jsonObj, Formatting.None)
                            Catch
                            End Try
                            Dim tContent As New text_content_def With {
                                .text = file_content,
                                .fileName = fileName,
                                .fileExtention = fileExtension
                            }
                            text_contents.Add(tContent)

                        Case Else
                            Dim file_content = File.ReadAllText(filePath)
                            Dim tContent As New text_content_def With {
                                .text = file_content,
                                .fileName = fileName,
                                .fileExtention = fileExtension
                            }
                            text_contents.Add(tContent)
                    End Select

                    AddFileChip(filePath, fileExtension)

                Catch ex As Exception
                    MessageBox.Show("Fehler beim Laden der Datei '" & fileName & "': " & ex.Message)
                End Try
            Next

            SiticoneFlowPanel_prompt_filecontent.Visible = True
            SiticoneTextArea_prompt_TextChanged(Nothing, Nothing)
        End If
    End Sub

    Private Sub ClearFileChips()
        text_contents.Clear()
        image_contents.Clear()
        audio_contents.Clear()
        SiticoneFlowPanel_prompt_filecontent.Controls.Clear()
        SiticoneFlowPanel_prompt_filecontent.Visible = False
        SiticoneTextArea_prompt_TextChanged(Nothing, Nothing)
    End Sub


    Private Sub AddFileChip(filePath As String, ext As String)
        Dim chip As New SiticonePanel()
        With chip
            .Size = New Size(210, 64)
            .FillColor = Color.FromArgb(235, 237, 240)
            .BorderThickness = 0
            .ShowBorder = False
            .Margin = New Padding(5)
            .Tag = filePath
        End With

        Dim picIcon As New SiticonePictureBox()
        With picIcon
            .Size = New Size(48, 48)
            .Location = New Point(8, 8)
            .SizeMode = PictureBoxSizeMode.Zoom
            .BackColor = Color.Transparent
            Select Case ext.ToLower()
                Case "txt" : .Image = Resource_pic.icon_txt
                Case "pdf" : .Image = Resource_pic.icon_pdf
                Case "json" : .Image = Resource_pic.icon_json
                Case "wav" : .Image = Resource_pic.icon_wav
                Case "jpg", "png", "jpeg"
                    Try
                        Using fs As New FileStream(filePath, FileMode.Open, FileAccess.Read)
                            .Image = New Bitmap(Image.FromStream(fs).GetThumbnailImage(48, 48, Nothing, IntPtr.Zero))
                        End Using
                    Catch
                        .Image = Resource_pic.icon_generic
                    End Try
                Case Else : .Image = Resource_pic.icon_generic
            End Select
        End With

        Dim lblName As New Label()
        With lblName
            .Text = Path.GetFileName(filePath)
            .AutoSize = False
            .Location = New Point(62, 12)
            .Size = New Size(115, 40)
            .Font = New Font("Segoe UI Semibold", 8.5)
            .TextAlign = ContentAlignment.MiddleLeft
            .BackColor = Color.Transparent
        End With

        Dim btnDelete As New SiticoneButton()
        With btnDelete
            .Size = New Size(24, 24)
            .Location = New Point(180, 5)
            .Text = "x"
            .ButtonBackColor = Color.Transparent
            .TextColor = Color.Gray
            .Font = New Font("Arial", 12, FontStyle.Bold)
            .BorderWidth = 0
            .HoverBackColor = Color.FromArgb(255, 200, 200)
            .HoverTextColor = Color.Red
            .CornerRadiusTopLeft = 12
            .CornerRadiusTopRight = 12
            .CornerRadiusBottomLeft = 12
            .CornerRadiusBottomRight = 12
            .Cursor = Cursors.Hand
        End With

        AddHandler btnDelete.Click, Sub(s, ev)
                                        Dim deletedFilePath As String = filePath
                                        Dim deletedFileName As String = Path.GetFileName(deletedFilePath)

                                        SiticoneFlowPanel_prompt_filecontent.Controls.Remove(chip)

                                        Dim imageToRemove = image_contents.FirstOrDefault(Function(i) i.fileName = deletedFileName)
                                        If imageToRemove IsNot Nothing Then
                                            image_contents.Remove(imageToRemove)
                                        End If

                                        Dim audioToRemove = audio_contents.FirstOrDefault(Function(a) a.fileName = deletedFileName)
                                        If audioToRemove IsNot Nothing Then
                                            audio_contents.Remove(audioToRemove)
                                        End If

                                        Dim textToRemove = text_contents.FirstOrDefault(Function(t) t.fileName = deletedFileName)
                                        If textToRemove IsNot Nothing Then
                                            text_contents.Remove(textToRemove)
                                        End If

                                        If deletedFilePath.StartsWith(Path.GetTempPath(), StringComparison.OrdinalIgnoreCase) Then
                                            Try
                                                If File.Exists(deletedFilePath) Then
                                                    File.Delete(deletedFilePath)
                                                End If
                                            Catch ex As Exception
                                                AppLog("[DEBUG-AddFileChip] Konnte temporäre Datei nicht löschen: " & ex.Message)
                                            End Try
                                        End If

                                        If SiticoneFlowPanel_prompt_filecontent.Controls.Count = 0 Then
                                            SiticoneFlowPanel_prompt_filecontent.Visible = False
                                        End If

                                        UpdatePromptLayout()
                                        SiticoneTextArea_prompt_TextChanged(Nothing, Nothing)
                                    End Sub

        chip.Controls.Add(picIcon)
        chip.Controls.Add(lblName)
        chip.Controls.Add(btnDelete)

        SiticoneFlowPanel_prompt_filecontent.Controls.Add(chip)

        If SiticoneFlowPanel_prompt_filecontent.Controls.Count > 0 Then
            SiticoneFlowPanel_prompt_filecontent.Visible = True
        End If

        UpdatePromptLayout()
    End Sub

    Private Async Sub SiticoneDropdown_model_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SiticoneDropdown_model.SelectedIndexChanged
        Scintilla_model_info.Text = model_info.Item(SiticoneDropdown_model.SelectedIndex)
        If APP_Start = False Then
            SiticoneTabControl_tab.SelectedTab = TabPage_modelinfo
        End If
        Dim model_name = SiticoneDropdown_model.SelectedItem
        SiticoneLabel_show_LLM.Text = model_name
        Dim model_info_get As ModelInfo = GetModelInfo(model_name)
        If model_info_get IsNot Nothing Then
            SiticoneLabel1_model_info_description.Text = model_info_get.description
            SiticoneChip_model_info_Vision.IsSelected = model_info_get.vision
            SiticoneChip_model_info_Audio.IsSelected = model_info_get.audio
            SiticoneChip_model_info_Tools.IsSelected = model_info_get.tools
            SiticoneChip_model_info_Thinking.IsSelected = model_info_get.thinking
            SiticoneChip_model_info_Embedding.IsSelected = model_info_get.embedding
            SiticoneChip_model_info_Image.IsSelected = model_info_get.image
            SiticoneChip_model_info_Decision.IsSelected = model_info_get.decision

            If model_info_get.context > 0 Then
                SiticoneChip_model_info_Context.IsSelected = True
                SiticoneChip_model_info_Context.Text = "context: " & model_info_get.context.ToString & "k"
                SiticoneChip_model_info_Context.Refresh()
            Else
                SiticoneChip_model_info_Context.IsSelected = False
                SiticoneChip_model_info_Context.Text = "context: ?"
                SiticoneChip_model_info_Context.Refresh()
            End If
        Else
            SiticoneLabel1_model_info_description.Text = "unknown"
            SiticoneChip_model_info_Vision.IsSelected = False
            SiticoneChip_model_info_Audio.IsSelected = False
            SiticoneChip_model_info_Tools.IsSelected = False
            SiticoneChip_model_info_Thinking.IsSelected = False
            SiticoneChip_model_info_Embedding.IsSelected = False
            SiticoneChip_model_info_Image.IsSelected = False
            SiticoneChip_model_info_Decision.IsSelected = False
            SiticoneChip_model_info_Context.IsSelected = False
            SiticoneChip_model_info_Context.Text = "context: ?"
            SiticoneChip_model_info_Context.Refresh()
        End If
        Try
            Dim apiUrl As String = "http://" & SiticoneTextBox_host.Text & "/api/show"
            Using client As New HttpClient()
                Dim requestBody As String = "{ ""model"": """ & model_name & """}"
                Dim content As New StringContent(requestBody, Encoding.UTF8, "application/json")
                Dim response As HttpResponseMessage = Await client.PostAsync(apiUrl, content)

                If response.IsSuccessStatusCode Then
                    Dim minifiedJson As String = Await response.Content.ReadAsStringAsync()
                    Dim jsonObject = JsonConvert.DeserializeObject(minifiedJson)
                    Dim prettyJson As String = JsonConvert.SerializeObject(jsonObject, Formatting.Indented)
                    Scintilla_model_info_request.Text = prettyJson
                    extractedLicense = jsonObject.SelectToken("license")?.ToString()
                    SiticoneButton_preload.Enabled = True
                Else
                    MessageBox.Show("Error loading model information: " & response.ReasonPhrase)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading model information: " & ex.Message)
        End Try
        extractedContext.Clear()
        UpdateMemoryUI()
    End Sub

    Public Function ExtractCodeBlocks(markdownContent As String) As List(Of CodeBlock)
        Dim codeBlocks As New List(Of CodeBlock)()
        Dim lines As String() = markdownContent.Split({vbCrLf, vbCr, vbLf}, StringSplitOptions.None)
        Dim inCodeBlock As Boolean = False
        Dim currentLanguage As String = ""
        Dim currentCode As New List(Of String)()
        ToolsCodeBlockJson = "empty"

        For Each line As String In lines
            If line.Trim().StartsWith("```") Then
                If inCodeBlock Then
                    codeBlocks.Add(New CodeBlock With {
                        .Language = currentLanguage,
                        .Code = DeleteSpaces(String.Join(Environment.NewLine, currentCode))
                    })
                    If currentLanguage = "json" And (DeleteSpaces(String.Join(Environment.NewLine, currentCode)).Contains("""name"":") Or DeleteSpaces(String.Join(Environment.NewLine, currentCode)).Contains("""tool"":")) And (SiticoneToggleSwitch_tools.Checked = True Or SiticoneToggleSwitch_ragtools.Checked = True) Then
                        ToolsCodeBlockJson = DeleteSpaces(String.Join(Environment.NewLine, currentCode))
                        Dim parsedJson As JObject = JObject.Parse(ToolsCodeBlockJson)
                        ToolsCodeBlockJson = JsonConvert.SerializeObject(parsedJson, Formatting.None)
                    End If
                    currentCode.Clear()
                    inCodeBlock = False
                Else
                    inCodeBlock = True
                    Dim codeLine As String = line.Trim()
                    currentLanguage = If(codeLine.Length > 3, codeLine.Substring(3).Trim(), "")
                End If
            ElseIf inCodeBlock Then
                currentCode.Add(line)
            End If
        Next

        If inCodeBlock AndAlso currentCode.Count > 0 Then
            codeBlocks.Add(New CodeBlock With {
                .Language = currentLanguage,
                .Code = DeleteSpaces(String.Join(Environment.NewLine, currentCode))
            })
            If currentLanguage = "json" And (DeleteSpaces(String.Join(Environment.NewLine, currentCode)).Contains("""name"":") Or DeleteSpaces(String.Join(Environment.NewLine, currentCode)).Contains("""tool"":")) And (SiticoneToggleSwitch_tools.Checked = True Or SiticoneToggleSwitch_ragtools.Checked = True) Then
                ToolsCodeBlockJson = DeleteSpaces(String.Join(Environment.NewLine, currentCode))
                Dim parsedJson As JObject = JObject.Parse(ToolsCodeBlockJson)
                ToolsCodeBlockJson = JsonConvert.SerializeObject(parsedJson, Formatting.None)
            End If
        End If

        Return codeBlocks
    End Function

    Function DeleteSpaces(ByVal code As String) As String
        Dim zeilen As String() = code.Split({vbCrLf, vbLf}, StringSplitOptions.None)
        Dim minIndent As Integer = Integer.MaxValue

        For Each zeile In zeilen
            Dim trimZeile As String = zeile.TrimStart()
            If trimZeile.Length > 0 Then
                Dim indent As Integer = zeile.Length - trimZeile.Length
                minIndent = Math.Min(minIndent, indent)
            End If
        Next

        If minIndent = Integer.MaxValue Then Return code

        Dim result As New Text.StringBuilder()
        For Each zeile In zeilen
            If zeile.Length >= minIndent Then
                result.AppendLine(zeile.Substring(minIndent))
            Else
                result.AppendLine(zeile)
            End If
        Next

        Return result.ToString().TrimEnd()
    End Function

    Private Sub SiticoneDropdown_language_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SiticoneDropdown_language.SelectedIndexChanged
        change_language()
    End Sub

    Private Sub change_language()
        SiticoneTextArea_run_output.Text = ""
        SetupEditor(Scintilla_code_block, SiticoneDropdown_language.SelectedItem)
        Scintilla_code_block.Text = CodeBlock_List.Item(SiticoneDropdown_language.SelectedIndex).Code
        If execute_check(CodeBlock_List.Item(SiticoneDropdown_language.SelectedIndex).Language).exe <> "" Then
            SiticoneButton_code_run.Enabled = True
        Else
            SiticoneButton_code_run.Enabled = False
        End If
        If execute_check(CodeBlock_List.Item(SiticoneDropdown_language.SelectedIndex).Language).ext <> "" Then
            SiticoneButton_code_save.Enabled = True
        Else
            SiticoneButton_code_save.Enabled = False
        End If

    End Sub

    Private Sub SiticoneButton_code_run_Click(sender As Object, e As EventArgs) Handles SiticoneButton_code_run.Click
        Dim run_parameter = execute_check(CodeBlock_List.Item(SiticoneDropdown_language.SelectedIndex).Language)
        If run_parameter.exe <> "" Then
            Dim pythonCode As String = Scintilla_code_block.Text

            Dim tempFilePath As String = Path.Combine(Path.GetTempPath(), run_parameter.file)
            SiticoneLabel_runpath.Text = "path: " & tempFilePath
            File.WriteAllText(tempFilePath, pythonCode)

            Dim psi As New ProcessStartInfo()
            psi.FileName = run_parameter.exe
            If run_parameter.arg = "" Then
                psi.Arguments = """" & tempFilePath & """"
            Else
                psi.Arguments = run_parameter.arg & " " & """" & tempFilePath & """"
            End If

            psi.RedirectStandardOutput = Not (SiticoneToggleSwitch_UseShellExecute.Checked)
            psi.RedirectStandardError = Not (SiticoneToggleSwitch_UseShellExecute.Checked)
            psi.UseShellExecute = SiticoneToggleSwitch_UseShellExecute.Checked
            psi.CreateNoWindow = True

            Dim process As New Process()
            process.StartInfo = psi

            Try
                process.Start()
                Dim output As String = ""
                Dim errors As String = ""
                SiticoneTextArea_run_output.Text = ""

                If SiticoneToggleSwitch_UseShellExecute.Checked = False Then
                    Dim outputTask As Task(Of String) = Task.Run(Function() process.StandardOutput.ReadToEnd())
                    Dim errorTask As Task(Of String) = Task.Run(Function() process.StandardError.ReadToEnd())

                    Dim timeout As Integer = 10000

                    If process.WaitForExit(timeout) Then
                        output = outputTask.Result
                        errors = errorTask.Result
                    Else
                        process.Kill()
                        output = outputTask.Result
                        errors = errorTask.Result & vbCrLf & "The process was terminated due to a timeout error."
                    End If
                Else
                    process.WaitForExit()
                End If

                SiticoneTextArea_run_output.Text = "Execute:" & vbCrLf & psi.FileName & " " & psi.Arguments & vbCrLf & "Output:" & vbCrLf & output & vbCrLf & "Errors:" & vbCrLf & errors
            Catch ex As Exception
                MessageBox.Show("Error executing the script: " & ex.Message)
            End Try

        Else
            MessageBox.Show("No execution program was specified in ""run_execute_list"" for this script type! ")
        End If
    End Sub

    Private Function python_code_run(script As String, jsonArgument As String) As String
        Try
            Dim tempFilePath As String = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName() & ".py")
            File.WriteAllText(tempFilePath, script)

            Dim escapedJson As String = jsonArgument.Replace("""", "\""")

            Dim psi As New ProcessStartInfo()
            psi.FileName = "python"
            psi.Arguments = $"""{tempFilePath}"" ""{escapedJson}"""
            psi.UseShellExecute = False
            psi.RedirectStandardOutput = True
            psi.RedirectStandardError = True
            psi.CreateNoWindow = True
            Using process As Process = Process.Start(psi)
                Dim output As String = process.StandardOutput.ReadToEnd()
                Dim errorOutput As String = process.StandardError.ReadToEnd()
                process.WaitForExit()

                File.Delete(tempFilePath)

                If Not String.IsNullOrEmpty(errorOutput) Then
                    Return $"Error executing the script:{Environment.NewLine}{errorOutput}"
                End If

                Return output
            End Using
        Catch ex As Exception
            Return $"Exception when running the script: {ex.Message}"
        End Try
    End Function

    Private Sub SiticoneButton_code_save_Click(sender As Object, e As EventArgs) Handles SiticoneButton_code_save.Click
        Dim Extention As String = execute_check(CodeBlock_List.Item(SiticoneDropdown_language.SelectedIndex).Language).ext
        If Extention <> "" Then
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "Code Files (*." & Extention & ")|*." & Extention
            saveFileDialog.DefaultExt = Extention
            saveFileDialog.AddExtension = True

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                System.IO.File.WriteAllText(saveFileDialog.FileName, Scintilla_code_block.Text)
            End If
        End If
    End Sub

    Private Function execute_check(check_str As String) As Execute_val
        Dim ret_str As New Execute_val
        ret_str.exe = ""
        ret_str.arg = ""
        ret_str.file = ""
        For Each run_execute In My.Settings.run_execute_list
            Dim run_execute_par() = Split(run_execute, "<|>")
            If run_execute_par.Count = 5 Then
                If LCase(check_str) = LCase(run_execute_par(0)) Then
                    ret_str.exe = run_execute_par(1)
                    ret_str.arg = run_execute_par(2)
                    ret_str.file = run_execute_par(3)
                    ret_str.ext = run_execute_par(4)
                End If
            End If
        Next
        Return ret_str
    End Function

    Public Function IsValidJsonCore(ByVal strInput As String) As Boolean
        If String.IsNullOrWhiteSpace(strInput) Then
            Return False
        End If

        strInput = strInput.Trim()
        If Not ((strInput.StartsWith("{") AndAlso strInput.EndsWith("}")) _
         OrElse (strInput.StartsWith("[") AndAlso strInput.EndsWith("]"))) Then
            Return False
        End If

        Try
            Using JsonDocument.Parse(strInput)
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Async Sub WebView21_NavigationCompleted(sender As Object, e As CoreWebView2NavigationCompletedEventArgs) Handles WebView21.NavigationCompleted
        If e.IsSuccess Then
            ' Immer direkt ans Ende der generierten HTML-Seite scrollen
            Await WebView21.ExecuteScriptAsync("window.scrollTo({ top: document.body.scrollHeight, behavior: 'instant' });")
        End If
    End Sub

    Private Async Sub SiticoneButton_HTMLtoPDF_Click(sender As Object, e As EventArgs) Handles SiticoneButton_HTMLtoPDF.Click
        Using saveFileDialog As New SaveFileDialog
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf|Markdown files (*.md)|*.md|HTML files (*.html)|*.html"
            saveFileDialog.Title = "Save as PDF, Markdown or HTML"
            saveFileDialog.FileName = "output.pdf"

            If saveFileDialog.ShowDialog = DialogResult.OK Then
                Dim filePath = saveFileDialog.FileName
                Dim ext = Path.GetExtension(filePath).ToLower

                Select Case ext
                    Case ".pdf"
                        Dim printSettings = WebView21.CoreWebView2.Environment.CreatePrintSettings
                        printSettings.ShouldPrintBackgrounds = True
                        printSettings.ColorMode = CoreWebView2PrintColorMode.Color
                        Await WebView21.CoreWebView2.PrintToPdfAsync(filePath, printSettings)
                    Case ".html"
                        Dim result = Await WebView21.CoreWebView2.ExecuteScriptAsync("document.documentElement.outerHTML;")
                        Dim htmlContent = ""
                        Using doc = JsonDocument.Parse(result)
                            htmlContent = doc.RootElement.GetString
                        End Using
                        File.WriteAllText(saveFileDialog.FileName, htmlContent)
                    Case ".md"
                        File.WriteAllText(filePath, Scintilla_response.Text)
                    Case Else
                End Select
            End If
        End Using
    End Sub

    Private Sub SiticoneTextArea_prompt_TextChanged(sender As Object, e As EventArgs) Handles SiticoneTextArea_prompt.TextChanged
        Me.BeginInvoke(Sub() UpdatePromptLayout())

        If SiticoneTextArea_prompt.TextLength > 0 OrElse image_contents.Count > 0 OrElse audio_contents.Count > 0 Then
            SiticonePlayPauseButton_request.Enabled = True
        Else
            SiticonePlayPauseButton_request.Enabled = False
        End If
    End Sub

    Private Sub UpdatePromptLayout()
        Dim minTextBoxHeight = 36
        Dim maxTextBoxHeight = 200
        Dim paddingAroundControls = 20

        Dim textSize = TextRenderer.MeasureText(SiticoneTextArea_prompt.Text,
                                            SiticoneTextArea_prompt.Font,
                                            New Size(SiticoneTextArea_prompt.Width - 10, Integer.MaxValue),
                                            TextFormatFlags.WordBreak)
        Dim calculatedHeight = textSize.Height + 15

        If calculatedHeight > maxTextBoxHeight Then
            SiticoneTextArea_prompt.Height = maxTextBoxHeight
            SiticoneTextArea_prompt.ScrollBars = ScrollBars.Vertical
        ElseIf calculatedHeight < minTextBoxHeight Then
            SiticoneTextArea_prompt.Height = minTextBoxHeight
            SiticoneTextArea_prompt.ScrollBars = ScrollBars.None
        Else
            SiticoneTextArea_prompt.Height = calculatedHeight
            SiticoneTextArea_prompt.ScrollBars = ScrollBars.None
        End If

        Dim currentFileHeight = 0
        If SiticoneFlowPanel_prompt_filecontent.Visible Then
            Dim preferredSize As Size = SiticoneFlowPanel_prompt_filecontent.GetPreferredSize(New Size(SiticoneFlowPanel_prompt_filecontent.Width, 0))
            currentFileHeight = preferredSize.Height
        End If

        SiticonePanel_prompt.Height = currentFileHeight +
                                  SiticoneTextArea_prompt.Height +
                                  SiticonePanel_prompt_action.Height +
                                  paddingAroundControls

        SiticonePanel_prompt.PerformLayout()
        Me.PerformLayout()
    End Sub

    Private Sub dgv_option_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_option.CellValueChanged
        Dim dgv = CType(sender, DataGridView)

        Dim newOptionList As New Specialized.StringCollection
        For Each row As DataGridViewRow In dgv.Rows
            If Not row.IsNewRow Then
                Try
                    Dim optionName = If(row.Cells("OptionName").Value?.ToString, String.Empty)
                    Dim use = If(row.Cells("Use").Value IsNot Nothing, CType(row.Cells("Use").Value, Boolean), False)
                    Dim valueType = If(row.Cells("ValueType").Value?.ToString, String.Empty)
                    Dim value = If(row.Cells("Value").Value?.ToString, String.Empty)
                    Dim optionString = $"{optionName}<|>{use}<|>{valueType}<|>{value}"
                    newOptionList.Add(optionString)
                Catch ex As Exception
                End Try
            End If
        Next

        My.Settings.option_list = newOptionList
        My.Settings.Save()
    End Sub

    Private Sub dgv_option_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgv_option.RowsRemoved
        Dim dgv = CType(sender, DataGridView)

        Dim newOptionList As New Specialized.StringCollection
        For Each row As DataGridViewRow In dgv.Rows
            If Not row.IsNewRow Then
                Try
                    Dim optionName = If(row.Cells("OptionName").Value?.ToString, String.Empty)
                    Dim use = If(row.Cells("Use").Value IsNot Nothing, CType(row.Cells("Use").Value, Boolean), False)
                    Dim valueType = If(row.Cells("ValueType").Value?.ToString, String.Empty)
                    Dim value = If(row.Cells("Value").Value?.ToString, String.Empty)
                    Dim optionString = $"{optionName}<|>{use}<|>{valueType}<|>{value}"
                    newOptionList.Add(optionString)
                Catch ex As Exception
                End Try
            End If
        Next

        My.Settings.option_list = newOptionList
        My.Settings.Save()
    End Sub

    Private Sub dvg_execute_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dvg_execute.CellValueChanged
        Dim dgv = CType(sender, DataGridView)

        Dim newExecuteList As New Specialized.StringCollection
        For Each row As DataGridViewRow In dgv.Rows
            If Not row.IsNewRow Then
                Try
                    Dim Language = If(row.Cells("Language").Value?.ToString, String.Empty)
                    Dim Program = If(row.Cells("Program").Value?.ToString, String.Empty)
                    Dim Argument = If(row.Cells("Argument").Value?.ToString, String.Empty)
                    Dim Tempfile = If(row.Cells("Tempfile").Value?.ToString, String.Empty)
                    Dim Extention = If(row.Cells("Extention").Value?.ToString, String.Empty)
                    Dim ExecuteString = $"{Language}<|>{Program}<|>{Argument}<|>{Tempfile}<|>{Extention}"
                    newExecuteList.Add(ExecuteString)
                Catch ex As Exception
                End Try
            End If
        Next

        My.Settings.run_execute_list = newExecuteList
        My.Settings.Save()
    End Sub

    Private Sub dvg_execute_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dvg_execute.RowsRemoved
        Dim dgv = CType(sender, DataGridView)

        Dim newExecuteList As New Specialized.StringCollection
        For Each row As DataGridViewRow In dgv.Rows
            If Not row.IsNewRow Then
                Try
                    Dim Language = If(row.Cells("Language").Value?.ToString, String.Empty)
                    Dim Program = If(row.Cells("Program").Value?.ToString, String.Empty)
                    Dim Argument = If(row.Cells("Argument").Value?.ToString, String.Empty)
                    Dim Tempfile = If(row.Cells("Tempfile").Value?.ToString, String.Empty)
                    Dim Extention = If(row.Cells("Extention").Value?.ToString, String.Empty)
                    Dim ExecuteString = $"{Language}<|>{Program}<|>{Argument}<|>{Tempfile}<|>{Extention}"
                    newExecuteList.Add(ExecuteString)
                Catch ex As Exception
                End Try
            End If
        Next

        My.Settings.run_execute_list = newExecuteList
        My.Settings.Save()
    End Sub

    Private Sub SiticoneButton_save_parameter_Click(sender As Object, e As EventArgs) Handles SiticoneButton_save_parameter.Click
        Dim saveFileDialog As New SaveFileDialog
        saveFileDialog.Filter = "JSON files (*.model.json)|*.model.json|All files (*.*)|*.*"
        saveFileDialog.Title = "Save Model Parameter to JSON File"

        If saveFileDialog.ShowDialog = DialogResult.OK Then
            Dim textAreaContent = SiticoneTextArea_system.Text
            Dim dataGridViewContent As New List(Of Dictionary(Of String, Object))

            For Each row As DataGridViewRow In dgv_option.Rows
                If Not row.IsNewRow Then
                    Dim rowData As New Dictionary(Of String, Object)
                    For Each cell As DataGridViewCell In row.Cells
                        rowData.Add(dgv_option.Columns(cell.ColumnIndex).Name, cell.Value)
                    Next
                    dataGridViewContent.Add(rowData)
                End If
            Next

            Dim data As New Dictionary(Of String, Object) From {
                {"system_prompt", textAreaContent},
                {"option_parameter", dataGridViewContent},
                {"output_system_use", SiticoneToggleSwitch_system_use.Checked},
                {"output_format_use", SiticoneToggleSwitch_format_use.Checked},
                {"output_format", Scintilla_format.Text},
                {"timeout", SiticoneTextBox_timeout.Text},
                {"thinking_use", SiticoneToggleSwitch_thinking_use.Checked},
                {"thinking_parameter", SiticoneDropdown_thinking_use.SelectedItem},
                {"context_use", SiticoneToggleSwitch_last_context.Checked},
                {"content_prompt", SiticoneTextArea_content_prompt.Text}
            }

            Dim json = JsonConvert.SerializeObject(data, Formatting.Indented)
            File.WriteAllText(saveFileDialog.FileName, json)
        End If
    End Sub

    Private Sub SiticoneButton_load_parameter_Click(sender As Object, e As EventArgs) Handles SiticoneButton_load_parameter.Click
        Dim openFileDialog As New OpenFileDialog
        openFileDialog.Filter = "JSON files (*.model.json)|*.model.json|All files (*.*)|*.*"
        openFileDialog.Title = "Load Model Parameter from JSON File"

        If openFileDialog.ShowDialog = DialogResult.OK Then
            load_model(openFileDialog.FileName)
        End If
    End Sub

    Private Sub load_model(setting_path As String)
        If File.Exists(setting_path) Then
            Dim json = File.ReadAllText(setting_path)
            Dim data = JObject.Parse(json)

            Try
                SiticoneTextArea_system.Text = data("system_prompt").ToString

                dgv_option.Rows.Clear()
                Dim dataGridViewContent = CType(data("option_parameter"), JArray)
                For Each rowData As JObject In dataGridViewContent
                    Dim rowIndex = dgv_option.Rows.Add
                    For Each key In rowData.Properties.Select(Function(p) p.Name)
                        dgv_option.Rows(rowIndex).Cells(key).Value = rowData(key).ToObject(Of Object)
                    Next
                Next
                SiticoneToggleSwitch_system_use.Checked = data("output_system_use")
                SiticoneToggleSwitch_format_use.Checked = data("output_format_use")
                Scintilla_format.Text = data("output_format").ToString
                SiticoneTextBox_timeout.Text = data("timeout").ToString
                SiticoneToggleSwitch_thinking_use.Checked = data("thinking_use")
                SiticoneDropdown_thinking_use.SelectedItem = data("thinking_parameter").ToString
                SiticoneToggleSwitch_last_context.Checked = data("context_use")
                SiticoneTextArea_content_prompt.Text = data("content_prompt")
            Catch ex As Exception
                MessageBox.Show("Error loading parameters: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub SiticoneButton_save_execute_Click(sender As Object, e As EventArgs) Handles SiticoneButton_save_execute.Click
        Dim saveFileDialog As New SaveFileDialog
        saveFileDialog.Filter = "JSON files (*.code.json)|*.code.json|All files (*.*)|*.*"
        saveFileDialog.Title = "Save Execute Parameter to JSON File"

        If saveFileDialog.ShowDialog = DialogResult.OK Then
            Dim dataGridViewContent As New List(Of Dictionary(Of String, Object))

            For Each row As DataGridViewRow In dvg_execute.Rows
                If Not row.IsNewRow Then
                    Dim rowData As New Dictionary(Of String, Object)
                    For Each cell As DataGridViewCell In row.Cells
                        rowData.Add(dvg_execute.Columns(cell.ColumnIndex).Name, cell.Value)
                    Next
                    dataGridViewContent.Add(rowData)
                End If
            Next

            Dim data As New Dictionary(Of String, Object) From {
                {"execute_parameter", dataGridViewContent}
            }

            Dim json = JsonConvert.SerializeObject(data, Formatting.Indented)
            File.WriteAllText(saveFileDialog.FileName, json)
        End If
    End Sub

    Private Sub SiticoneButton_load_execute_Click(sender As Object, e As EventArgs) Handles SiticoneButton_load_execute.Click
        Dim openFileDialog As New OpenFileDialog
        openFileDialog.Filter = "JSON files (*.code.json)|*.code.json|All files (*.*)|*.*"
        openFileDialog.Title = "Load Execute Parameter from JSON File"

        If openFileDialog.ShowDialog = DialogResult.OK Then
            load_execute(openFileDialog.FileName)
        End If
    End Sub

    Private Sub load_execute(setting_path As String)
        If File.Exists(setting_path) Then
            Dim json = File.ReadAllText(setting_path)
            Dim data = JObject.Parse(json)

            Try
                dvg_execute.Rows.Clear()
                Dim dataGridViewContent = CType(data("execute_parameter"), JArray)
                For Each rowData As JObject In dataGridViewContent
                    Dim rowIndex = dvg_execute.Rows.Add
                    For Each key In rowData.Properties.Select(Function(p) p.Name)
                        dvg_execute.Rows(rowIndex).Cells(key).Value = rowData(key).ToObject(Of Object)
                    Next
                Next
            Catch ex As Exception
                MessageBox.Show("Error loading parameters: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub SiticoneButton_save_tools_Click(sender As Object, e As EventArgs) Handles SiticoneButton_save_tools.Click
        Dim saveFileDialog As New SaveFileDialog
        saveFileDialog.Filter = "JSON files (*.tools.json)|*.tools.json|All files (*.*)|*.*"
        saveFileDialog.Title = "Save Tools Parameter to JSON File"

        If saveFileDialog.ShowDialog = DialogResult.OK Then
            Dim textAreaContent = SiticoneTextArea_system.Text
            Dim dataGridViewContent As New List(Of Dictionary(Of String, Object))

            Dim data As New Dictionary(Of String, Object) From {
                {"tools_use", SiticoneToggleSwitch_tools.Checked},
                {"tools_system_prompt", SiticoneTextArea_Tools_system.Text},
                {"tools_json", Scintilla_Tools_Json.Text},
                {"tools_python_code", Scintilla_Tools_pythoncode.Text}
            }

            Dim json = JsonConvert.SerializeObject(data, Formatting.Indented)
            File.WriteAllText(saveFileDialog.FileName, json)
        End If
    End Sub

    Private Sub SiticoneButton_load_tools_Click(sender As Object, e As EventArgs) Handles SiticoneButton_load_tools.Click
        Dim openFileDialog As New OpenFileDialog
        openFileDialog.Filter = "JSON files (*.tools.json)|*.tools.json|All files (*.*)|*.*"
        openFileDialog.Title = "Load Tools Parameter from JSON File"

        If openFileDialog.ShowDialog = DialogResult.OK Then
            load_tools(openFileDialog.FileName)
        End If
    End Sub

    Private Sub load_tools(setting_path As String)
        If File.Exists(setting_path) Then
            Try
                Dim json = File.ReadAllText(setting_path)
                Dim data = JObject.Parse(json)

                If data.ContainsKey("tools_use") Then
                    SiticoneToggleSwitch_tools.Checked = Convert.ToBoolean(data("tools_use"))
                End If

                If data.ContainsKey("tools_system_prompt") Then
                    SiticoneTextArea_Tools_system.Text = data("tools_system_prompt").ToString()
                End If

                If data.ContainsKey("tools_json") Then
                    Scintilla_Tools_Json.Text = data("tools_json").ToString()
                End If

                If data.ContainsKey("tools_python_code") Then
                    Scintilla_Tools_pythoncode.Text = data("tools_python_code").ToString()
                End If

            Catch ex As Exception
                MessageBox.Show("Fehler beim Laden der Tool-Parameter: " & ex.Message, "Ladefehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub SiticoneButton_save_rag_Click(sender As Object, e As EventArgs) Handles SiticoneButton_save_rag.Click
        Dim saveFileDialog As New SaveFileDialog
        saveFileDialog.Filter = "JSON files (*.rag.json)|*.rag.json|All files (*.*)|*.*"
        saveFileDialog.Title = "Save RAG Parameter to JSON File"

        If saveFileDialog.ShowDialog = DialogResult.OK Then
            Dim textAreaContent = SiticoneTextArea_system.Text
            Dim dataGridViewContent As New List(Of Dictionary(Of String, Object))

            Dim data As New Dictionary(Of String, Object) From {
                {"rag_use", SiticoneToggleSwitch_ragtools.Checked},
                {"rag_system_prompt", SiticoneTextArea_Rag_system.Text},
                {"rag_json", Scintilla_Rag_Json.Text}
            }

            Dim json = JsonConvert.SerializeObject(data, Formatting.Indented)
            File.WriteAllText(saveFileDialog.FileName, json)
        End If
    End Sub

    Private Sub SiticoneButton_load_rag_Click(sender As Object, e As EventArgs) Handles SiticoneButton_load_rag.Click
        Dim openFileDialog As New OpenFileDialog
        openFileDialog.Filter = "JSON files (*.rag.json)|*.rag.json|All files (*.*)|*.*"
        openFileDialog.Title = "Load RAG Parameter from JSON File"

        If openFileDialog.ShowDialog = DialogResult.OK Then
            load_rag(openFileDialog.FileName)
        End If
    End Sub

    Private Sub load_rag(setting_path As String)
        If File.Exists(setting_path) Then
            Try
                Dim json = File.ReadAllText(setting_path)
                Dim data = JObject.Parse(json)

                If data.ContainsKey("rag_use") Then
                    SiticoneToggleSwitch_ragtools.Checked = Convert.ToBoolean(data("rag_use"))
                End If

                If data.ContainsKey("rag_system_prompt") Then
                    SiticoneTextArea_Rag_system.Text = data("rag_system_prompt").ToString()
                End If

                If data.ContainsKey("rag_json") Then
                    Scintilla_Rag_Json.Text = data("rag_json").ToString()
                End If

            Catch ex As Exception
                MessageBox.Show("Fehler beim Laden der RAG-Parameter: " & ex.Message, "Ladefehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub SiticoneButton_save_decision_Click(sender As Object, e As EventArgs) Handles SiticoneButton_save_decision.Click
        Dim saveFileDialog As New SaveFileDialog
        saveFileDialog.Filter = "JSON files (*.decision.json)|*.decision.json|All files (*.*)|*.*"
        saveFileDialog.Title = "Save Decision Parameter to JSON File"

        If saveFileDialog.ShowDialog = DialogResult.OK Then
            Dim textAreaContent = SiticoneTextArea_system.Text
            Dim dataGridViewContent As New List(Of Dictionary(Of String, Object))

            Dim data As New Dictionary(Of String, Object) From {
                {"decision_use", SiticoneToggleSwitch_decisiontools.Checked},
                {"decision_json", Scintilla_Decision_Json.Text}
            }

            Dim json = JsonConvert.SerializeObject(data, Formatting.Indented)
            File.WriteAllText(saveFileDialog.FileName, json)
        End If
    End Sub

    Private Sub SiticoneButton_load_decision_Click(sender As Object, e As EventArgs) Handles SiticoneButton_load_decision.Click
        Dim openFileDialog As New OpenFileDialog
        openFileDialog.Filter = "JSON files (*.decision.json)|*.decision.json|All files (*.*)|*.*"
        openFileDialog.Title = "Load Decision Parameter from JSON File"

        If openFileDialog.ShowDialog = DialogResult.OK Then
            load_decision(openFileDialog.FileName)
        End If
    End Sub

    Private Sub load_decision(setting_path As String)
        If File.Exists(setting_path) Then
            Try
                Dim json = File.ReadAllText(setting_path)
                Dim data = JObject.Parse(json)

                If data.ContainsKey("decision_use") Then
                    SiticoneToggleSwitch_decisiontools.Checked = Convert.ToBoolean(data("decision_use"))
                End If

                If data.ContainsKey("decision_json") Then
                    Scintilla_Decision_Json.Text = data("decision_json").ToString()
                End If

            Catch ex As Exception
                MessageBox.Show("Fehler beim Laden der Decision-Parameter: " & ex.Message, "Ladefehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub SiticoneButton_save_ssh_Click(sender As Object, e As EventArgs) Handles SiticoneButton_save_ssh.Click
        Dim saveFileDialog As New SaveFileDialog
        saveFileDialog.Filter = "JSON files (*.ssh.json)|*.ssh.json|All files (*.*)|*.*"
        saveFileDialog.Title = "Save SSH Parameter to JSON File"

        If saveFileDialog.ShowDialog = DialogResult.OK Then
            Dim textAreaContent = SiticoneTextArea_system.Text
            Dim dataGridViewContent As New List(Of Dictionary(Of String, Object))

            Dim data As New Dictionary(Of String, Object) From {
                {"ssh_system", SiticoneTextArea_ssh_system.Text},
                {"ssh_response", SiticoneTextArea_ssh_response.Text},
                {"ssh_address", SiticoneTextBox_ssh_address.Text},
                {"ssh_user", SiticoneTextBox_ssh_user.Text},
                {"ssh_pw", SiticoneTextBox_ssh_pw.Text},
                {"ssh_regex", SiticoneTextBox_ssh_regex.Text},
                {"ssh_pwrequest", SiticoneTextBox_ssh_pwrequest.Text},
                {"ssh_sudopw", SiticoneTextBox_ssh_sudopw.Text},
                {"ssh_timeout", SiticoneTextBox_ssh_timeout.Text},
                {"ssh_maxi", SiticoneTextBox_ssh_maxi.Text},
                {"ssh_err_multiline", currentErrMultiline},
                {"ssh_err_format", currentErrFormat},
                {"ssh_err_denied", currentErrDenied}
            }

            Dim json = JsonConvert.SerializeObject(data, Formatting.Indented)
            File.WriteAllText(saveFileDialog.FileName, json)
        End If
    End Sub

    Private Sub SiticoneButton_load_ssh_Click(sender As Object, e As EventArgs) Handles SiticoneButton_load_ssh.Click
        Dim openFileDialog As New OpenFileDialog
        openFileDialog.Filter = "JSON files (*.ssh.json)|*.ssh.json|All files (*.*)|*.*"
        openFileDialog.Title = "Load SSH Parameter from JSON File"

        If openFileDialog.ShowDialog = DialogResult.OK Then
            load_ssh(openFileDialog.FileName)
        End If
    End Sub

    Private Sub load_ssh(setting_path As String)
        If File.Exists(setting_path) Then
            Try
                Dim json = File.ReadAllText(setting_path)
                Dim data = JObject.Parse(json)

                If data.ContainsKey("ssh_system") Then SiticoneTextArea_ssh_system.Text = data("ssh_system").ToString()
                If data.ContainsKey("ssh_response") Then SiticoneTextArea_ssh_response.Text = data("ssh_response").ToString()

                If data.ContainsKey("ssh_address") Then SiticoneTextBox_ssh_address.Text = data("ssh_address").ToString()
                If data.ContainsKey("ssh_user") Then SiticoneTextBox_ssh_user.Text = data("ssh_user").ToString()
                If data.ContainsKey("ssh_pw") Then SiticoneTextBox_ssh_pw.Text = data("ssh_pw").ToString()
                If data.ContainsKey("ssh_regex") Then SiticoneTextBox_ssh_regex.Text = data("ssh_regex").ToString()
                If data.ContainsKey("ssh_pwrequest") Then SiticoneTextBox_ssh_pwrequest.Text = data("ssh_pwrequest").ToString()
                If data.ContainsKey("ssh_sudopw") Then SiticoneTextBox_ssh_sudopw.Text = data("ssh_sudopw").ToString()
                If data.ContainsKey("ssh_timeout") Then SiticoneTextBox_ssh_timeout.Text = data("ssh_timeout").ToString()
                If data.ContainsKey("ssh_maxi") Then SiticoneTextBox_ssh_maxi.Text = data("ssh_maxi").ToString()

                If data.ContainsKey("ssh_err_multiline") Then currentErrMultiline = data("ssh_err_multiline").ToString()
                If data.ContainsKey("ssh_err_format") Then currentErrFormat = data("ssh_err_format").ToString()
                If data.ContainsKey("ssh_err_denied") Then currentErrDenied = data("ssh_err_denied").ToString()

            Catch ex As Exception
                MessageBox.Show("Fehler beim Laden der SSH-Parameter: " & ex.Message, "Ladefehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub SiticoneButton_resp_clp_Click(sender As Object, e As EventArgs) Handles SiticoneButton_resp_clp.Click
        Clipboard.SetText(tools_Response_mem)
    End Sub

    Public Sub OpenSnipToolByUri()
        Dim psi As New ProcessStartInfo("ms-screenclip:") With {
            .UseShellExecute = True
        }
        Process.Start(psi)
    End Sub

    Public Async Function WaitForClipboardImageAsync(timeout As TimeSpan, Optional pollInterval As TimeSpan = Nothing, Optional ct As CancellationToken = Nothing) As Task(Of Image)
        If pollInterval = Nothing OrElse pollInterval <= TimeSpan.Zero Then
            pollInterval = TimeSpan.FromMilliseconds(100)
        End If

        Dim sw = Stopwatch.StartNew()

        While sw.Elapsed < timeout AndAlso Not ct.IsCancellationRequested
            Try
                If Clipboard.ContainsImage() Then
                    Return Clipboard.GetImage()
                End If
            Catch
            End Try

            Await Task.Delay(pollInterval, ct)
        End While

        Return Nothing
    End Function

    Private Async Sub SiticoneButton_screenshot_Click(sender As Object, e As EventArgs) Handles SiticoneButton_screenshot.Click
        WindowState = FormWindowState.Minimized
        Try
            Clipboard.Clear()
        Catch
        End Try

        OpenSnipToolByUri()

        Dim img = Await WaitForClipboardImageAsync(TimeSpan.FromSeconds(45))

        If img IsNot Nothing Then
            import_clp_image()
        Else
            MessageBox.Show("No screenshot found in the clipboard.")
        End If
        WindowState = FormWindowState.Normal
        Activate()
        BringToFront()
        Application.DoEvents()
        UpdatePromptLayout()
    End Sub

    Private Sub SiticoneButton_clear_prompt_Click(sender As Object, e As EventArgs) Handles SiticoneButton_clear_prompt.Click
        SiticoneTextArea_prompt.Clear()
        ClearFileChips()
    End Sub

    Public Sub LoadModelConfig(filePath As String)
        If Not File.Exists(filePath) Then
            Throw New FileNotFoundException("Model config file not found: " & filePath)
        End If

        Dim json As String = File.ReadAllText(filePath)
        ModelInfo_dic = JsonConvert.DeserializeObject(Of Dictionary(Of String, ModelInfo))(json)
    End Sub

    Public Sub LoadSettings(filePath As String)
        If Not File.Exists(filePath) Then
            Throw New FileNotFoundException("Settings file not found: " & filePath)
        End If

        Dim json As String = File.ReadAllText(filePath)
        SettingsInfo_dic = JsonConvert.DeserializeObject(Of Dictionary(Of String, SettingsInfo))(json)
        AppLog("[DEBUG-LoadSettings]")
    End Sub

    Public Function GetModelInfo(model_name As String) As ModelInfo
        Dim key As String = model_name.Split(":"c)(0).Trim().ToLower()

        If ModelInfo_dic.ContainsKey(key) Then
            Return ModelInfo_dic(key)
        Else
            Return Nothing
        End If
    End Function

    Private Sub SiticoneButton_ragpath_Click(sender As Object, e As EventArgs) Handles SiticoneButton_ragpath.Click
        Dim openFileDialog As New OpenFileDialog
        openFileDialog.Filter = "Text files (*.txt)|*.txt|PDF files (*.pdf)|*.pdf|All files (*.*)|*.*"
        openFileDialog.Multiselect = False

        If openFileDialog.ShowDialog = DialogResult.OK Then
            Dim filePath = openFileDialog.FileName
            Dim fileExtension = Mid(LCase(Path.GetExtension(filePath)), 2)
            Dim fileName = Path.GetFileName(filePath)
            Dim file_content = ""

            Select Case fileExtension
                Case "txt"
                    file_content = File.ReadAllText(filePath)

                Case "pdf"
                    Dim sb As New StringBuilder
                    Using Pdfdoc = PdfDocument.Open(filePath)
                        For Each page In Pdfdoc.GetPages
                            sb.AppendLine(page.Text & vbLf)
                        Next
                    End Using
                    file_content = sb.ToString

                Case Else
                    file_content = File.ReadAllText(filePath)
            End Select

            rag_content.text = file_content
            rag_content.fileName = fileName
            rag_content.fileExtention = fileExtension
            SiticoneTextBox_ragpath.Text = filePath

            documentIndex.IndexDocument(file_content)
            Dim sentenece_n = documentIndex.GetAllSentences
            SiticoneLabel_SentencesCountVal.Text = sentenece_n.Count.ToString

        End If
    End Sub

    Private Sub ProcessLLMResponse(jsonResponse As String, Optional delta As Integer = 0)
        Try
            Dim jsonObj As JObject = JObject.Parse(jsonResponse)
            Dim wordsToken As JToken = jsonObj("arguments")("words")

            If wordsToken IsNot Nothing AndAlso wordsToken.Type = JTokenType.Array Then
                Dim wordsArray As JArray = DirectCast(wordsToken, JArray)

                For Each wordToken In wordsArray
                    Dim searchWord As String = wordToken.ToString()
                    Dim results = documentIndex.SearchAndIncrementHits(searchWord, delta)
                Next
            End If

        Catch ex As Exception
            MessageBox.Show("Error parsing the JSON: " & ex.Message)
        End Try
    End Sub

    Private Sub SiticoneButton_resp_clp_rag_Click(sender As Object, e As EventArgs) Handles SiticoneButton_resp_clp_rag.Click
        Clipboard.SetText(tools_Response_mem)
    End Sub

    Private Sub SiticoneButton_show_thinking_Click(sender As Object, e As EventArgs) Handles SiticoneButton_show_thinking.Click
        Dim btnOk = TaskDialogButton.OK
        Dim btnCopy As New TaskDialogButton("Copy to Clipboard")

        AddHandler btnCopy.Click, Sub(s, args)
                                      If Not String.IsNullOrEmpty(extractedThinking) Then
                                          Clipboard.SetText(extractedThinking)
                                      End If
                                  End Sub

        Dim page As New TaskDialogPage With {
        .Caption = "Ollama Desktop",
        .Heading = "Thinking Response",
        .Text = "The model's thought process (thinking block):",
        .Expander = New TaskDialogExpander With {
            .Text = extractedThinking,
            .Expanded = True
        }
    }

        page.Buttons.Add(btnOk)
        page.Buttons.Add(btnCopy)

        TaskDialog.ShowDialog(page)
    End Sub

    Private Sub SiticoneButton_show_licence_Click(sender As Object, e As EventArgs) Handles SiticoneButton_show_licence.Click
        Dim page As New TaskDialogPage With {
            .Caption = "Ollama Desktop",
            .Heading = "License",
            .Text = SiticoneDropdown_model.SelectedItem & ":",
            .Expander = New TaskDialogExpander With {
                .Text = extractedLicense,
                .Expanded = True
            }
        }
        page.Buttons.Add(TaskDialogButton.OK)
        TaskDialog.ShowDialog(page)
    End Sub

    Private Sub SiticoneButton_load_context_Click(sender As Object, e As EventArgs) Handles SiticoneButton_load_context.Click
        Dim modelName As String = SiticoneDropdown_model.SelectedItem?.ToString()
        Dim safeModelName As String = GetSafeFilename(modelName)

        Using ofd As New OpenFileDialog()
            ofd.Filter = $"Context File (*.{safeModelName}.cnt)|*.{safeModelName}.cnt"
            ofd.Title = "Ollama Context load"

            If ofd.ShowDialog() = DialogResult.OK Then
                Try
                    Using reader As New BinaryReader(File.Open(ofd.FileName, FileMode.Open))
                        Dim count As Integer = reader.ReadInt32()

                        extractedContext.Clear()
                        For i As Integer = 0 To count - 1
                            extractedContext.Add(reader.ReadInt32())
                        Next
                    End Using

                    MessageBox.Show($"Successful {extractedContext.Count} Context-Token loaded.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    UpdateMemoryUI()
                Catch ex As Exception
                    MessageBox.Show("Error loading: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    Private Sub SiticoneButton_save_context_Click(sender As Object, e As EventArgs) Handles SiticoneButton_save_context.Click
        If extractedContext Is Nothing OrElse extractedContext.Count = 0 Then
            MessageBox.Show("No context available for saving.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim modelName As String = SiticoneDropdown_model.SelectedItem?.ToString()
        Dim safeModelName As String = GetSafeFilename(modelName)

        Using sfd As New SaveFileDialog()
            sfd.Filter = $"Context File (*.{safeModelName}.cnt)|*.{safeModelName}.cnt"
            sfd.Title = "Ollama Context save"
            sfd.FileName = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss")

            If sfd.ShowDialog() = DialogResult.OK Then
                Try
                    Using writer As New BinaryWriter(File.Open(sfd.FileName, FileMode.Create))
                        writer.Write(extractedContext.Count)
                        For Each id As Integer In extractedContext
                            writer.Write(id)
                        Next
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error saving: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    Private Function GetSafeFilename(input As String) As String
        If String.IsNullOrEmpty(input) Then Return "default"
        Dim invalidChars As String = New String(Path.GetInvalidFileNameChars())
        Return Regex.Replace(input, "[" & Regex.Escape(invalidChars) & "]", "_")
    End Function

    Private Sub SiticoneButton_timing_Click(sender As Object, e As EventArgs) Handles SiticoneButton_timing.Click
        If timing_total_duration = 0 Then
            MessageBox.Show("No timing data available yet. Please run a query first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Using frm As New FrmTimingStats(
            timing_total_duration,
            timing_load_duration,
            timing_prompt_eval_count,
            timing_prompt_eval_duration,
            timing_eval_count,
            timing_eval_duration)


            frm.ShowDialog()
        End Using
    End Sub

    Private Async Sub SiticoneDropdown_default_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SiticoneDropdown_default.SelectedIndexChanged
        Me.Cursor = Cursors.WaitCursor
        Application.DoEvents()
        Dim key As String = SiticoneDropdown_default.SelectedItem
        Dim val = SettingsInfo_dic(key)
        Dim appPath As String = AppContext.BaseDirectory
        My.Settings.help_path = val.help_path
        Await InitializeWebView2()
        load_model(Path.Combine(appPath, val.model_path))
        load_execute(Path.Combine(appPath, val.code_path))
        load_tools(Path.Combine(appPath, val.tools_path))
        load_rag(Path.Combine(appPath, val.rag_path))
        load_decision(Path.Combine(appPath, val.decision_path))
        load_ssh(Path.Combine(appPath, val.ssh_path))
        Me.Cursor = Cursors.Default
    End Sub

    Private Async Sub SiticoneButton_link_options_parameter_Click(sender As Object, e As EventArgs) Handles SiticoneButton_link_options_parameter.Click
        Await InitializeWebView2("link_options_parameter")
    End Sub

    Private Async Sub SiticoneButton_link_system_prompt_Click(sender As Object, e As EventArgs) Handles SiticoneButton_link_system_prompt.Click
        Await InitializeWebView2("link_system_prompt")
    End Sub

    Private Async Sub SiticoneButton_link_output_format_Click(sender As Object, e As EventArgs) Handles SiticoneButton_link_output_format.Click
        Await InitializeWebView2("link_output_format")
    End Sub

    Private Async Sub SiticoneButton_link_tool_system_prompt_Click(sender As Object, e As EventArgs) Handles SiticoneButton_link_tool_system_prompt.Click
        Await InitializeWebView2("link_tool_system_prompt")
    End Sub

    Private Async Sub SiticoneButton_link_tool_json_Click(sender As Object, e As EventArgs) Handles SiticoneButton_link_tool_json.Click
        Await InitializeWebView2("link_tool_json")
    End Sub

    Private Async Sub SiticoneButton_link_tool_python_code_Click(sender As Object, e As EventArgs) Handles SiticoneButton_link_tool_python_code.Click
        Await InitializeWebView2("link_tool_python_code")
    End Sub

    Private Async Sub SiticoneButton_link_content_prompt_Click(sender As Object, e As EventArgs) Handles SiticoneButton_link_content_prompt.Click
        Await InitializeWebView2("link_content_prompt")
    End Sub

    Private Async Sub SiticoneButton_link_rag_tool_system_prompt_Click(sender As Object, e As EventArgs) Handles SiticoneButton_link_rag_tool_system_prompt.Click
        Await InitializeWebView2("link_rag_tool_system_prompt")
    End Sub

    Private Async Sub SiticoneButton_link_decision_tool_Click(sender As Object, e As EventArgs) Handles SiticoneButton_link_decition_tool.Click
        Await InitializeWebView2("link_decision_tool_json")
    End Sub

    Private Async Sub SiticoneButton_link_rag_tool_json_Click(sender As Object, e As EventArgs) Handles SiticoneButton_link_rag_tool_json.Click
        Await InitializeWebView2("link_rag_tool_json")
    End Sub

    Private Async Sub SiticoneButton_link_execute_list_Click(sender As Object, e As EventArgs) Handles SiticoneButton_link_execute_list.Click
        Await InitializeWebView2("link_execute_list")
    End Sub

    Private Async Sub SiticoneButton_execute_run_Click(sender As Object, e As EventArgs) Handles SiticoneButton_execute_run.Click
        Await InitializeWebView2("link_execute_run")
    End Sub

    Private Async Sub SiticoneButton_ssh_system_Click(sender As Object, e As EventArgs) Handles SiticoneButton_ssh_system.Click
        Await InitializeWebView2("link_ssh_system")
    End Sub

    Private Async Sub SiticoneButton_ssh_response_Click(sender As Object, e As EventArgs) Handles SiticoneButton_ssh_response.Click
        Await InitializeWebView2("link_ssh_response")
    End Sub

    Private Async Sub SiticoneButton_ssh_par_Click(sender As Object, e As EventArgs) Handles SiticoneButton_ssh_par.Click
        Await InitializeWebView2("link_ssh_par")
    End Sub

    Private Sub SetupEditor(editor As ScintillaNET.Scintilla, langType As String)
        editor.StyleResetDefault()
        editor.Styles(ScintillaNET.Style.Default).Font = "Consolas"
        editor.Styles(ScintillaNET.Style.Default).Size = 10
        editor.Styles(ScintillaNET.Style.Default).BackColor = Color.White
        editor.Styles(ScintillaNET.Style.Default).ForeColor = Color.Black
        editor.StyleClearAll()

        editor.BorderStyle = BorderStyle.None
        editor.Margins(0).Width = 35
        editor.Margins(1).Width = 8

        editor.Styles(ScintillaNET.Style.LineNumber).BackColor = Color.FromArgb(250, 250, 250)
        editor.Styles(ScintillaNET.Style.LineNumber).ForeColor = Color.DarkGray
        editor.CaretLineVisible = True
        editor.CaretLineBackColor = Color.FromArgb(245, 248, 255)

        editor.SetKeywords(0, "")
        editor.SetKeywords(1, "")

        editor.LexerLanguage = ScintillaNET.Lexer.SCLEX_NULL

        Dim lang As String = langType.ToLower().Trim()

        Select Case lang
            Case "python", "py"
                editor.LexerLanguage = ScintillaNET.Lexer.SCLEX_PYTHON

                Dim pyKeys As String = "and as assert break class continue def del elif else except exec finally for from global if import in is lambda nonlocal not or pass print raise return try while with yield True False None"
                editor.SetKeywords(0, pyKeys)

                editor.Styles(ScintillaNET.Style.Python.Word).ForeColor = Color.Blue
                editor.Styles(ScintillaNET.Style.Python.String).ForeColor = Color.Maroon
                editor.Styles(ScintillaNET.Style.Python.CommentLine).ForeColor = Color.Green
                editor.Styles(ScintillaNET.Style.Python.Number).ForeColor = Color.DarkCyan
                editor.Styles(ScintillaNET.Style.Python.ClassName).ForeColor = Color.Purple
                editor.Styles(ScintillaNET.Style.Python.DefName).ForeColor = Color.DarkBlue
                editor.Styles(ScintillaNET.Style.Python.Decorator).ForeColor = Color.Gray

            Case "json"
                editor.LexerLanguage = ScintillaNET.Lexer.SCLEX_JSON

                editor.Styles(ScintillaNET.Style.Json.PropertyName).ForeColor = Color.DarkBlue
                editor.Styles(ScintillaNET.Style.Json.String).ForeColor = Color.Maroon
                editor.Styles(ScintillaNET.Style.Json.Number).ForeColor = Color.DarkGreen
                editor.Styles(ScintillaNET.Style.Json.Operator).ForeColor = Color.Black
                editor.Styles(ScintillaNET.Style.Json.BlockComment).ForeColor = Color.Green

            Case "markdown", "md"
                editor.LexerLanguage = ScintillaNET.Lexer.SCLEX_MARKDOWN

                editor.WrapMode = ScintillaNET.WrapMode.Word
                editor.Styles(2).ForeColor = Color.DarkBlue
                editor.Styles(2).Bold = True
                editor.Styles(3).ForeColor = Color.RoyalBlue
                editor.Styles(3).Bold = True
                editor.Styles(9).ForeColor = Color.OrangeRed
                editor.Styles(14).ForeColor = Color.Blue
                editor.Styles(14).Underline = True
                editor.Styles(15).ForeColor = Color.DarkOliveGreen

            Case "html", "xml"
                editor.LexerLanguage = ScintillaNET.Lexer.SCLEX_HTML

                editor.Styles(ScintillaNET.Style.Html.Tag).ForeColor = Color.DarkBlue
                editor.Styles(ScintillaNET.Style.Html.Attribute).ForeColor = Color.Red
                editor.Styles(ScintillaNET.Style.Html.Value).ForeColor = Color.Blue
                editor.Styles(ScintillaNET.Style.Html.Comment).ForeColor = Color.Green

            Case "javascript", "js"
                editor.LexerLanguage = ScintillaNET.Lexer.SCLEX_JAVA

                Dim jsKeys As String = "abstract await boolean break case catch class const continue debugger default delete do double else enum export extends false final finally float for function if import in instanceof int interface let long native new null package private protected public return short static super switch synchronized this throw throws transient true try typeof var void volatile while with yield"
                editor.SetKeywords(0, jsKeys)

                editor.Styles(ScintillaNET.Style.Cpp.Word).ForeColor = Color.Blue
                editor.Styles(ScintillaNET.Style.Cpp.String).ForeColor = Color.Maroon
                editor.Styles(ScintillaNET.Style.Cpp.CommentLine).ForeColor = Color.Green

            Case "powershell", "ps1"
                editor.LexerLanguage = ScintillaNET.Lexer.SCLEX_POWERSHELL

                Dim psKeys As String = "if else elseif switch while do for foreach in return break continue throw trap param function filter begin process end"
                editor.SetKeywords(0, psKeys)
                editor.Styles(ScintillaNET.Style.PowerShell.Keyword).ForeColor = Color.Blue
                editor.Styles(ScintillaNET.Style.PowerShell.Variable).ForeColor = Color.OrangeRed

            Case "batch", "bat", "cmd"
                editor.LexerLanguage = ScintillaNET.Lexer.SCLEX_BATCH
                editor.Styles(ScintillaNET.Style.Batch.Command).ForeColor = Color.Blue

            Case Else

        End Select
    End Sub

    Private Async Sub SiticoneButton_preload_Click(sender As Object, e As EventArgs) Handles SiticoneButton_preload.Click
        If SiticoneDropdown_model.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a model first.")
            Return
        End If

        Dim modelName As String = SiticoneDropdown_model.SelectedItem.ToString()

        Me.Cursor = Cursors.WaitCursor
        SiticoneButton_preload.Enabled = False

        Try
            Dim apiUrl As String = "http://" & SiticoneTextBox_host.Text & "/api/generate"

            Dim jsonPayload As New JObject()
            jsonPayload("model") = modelName
            jsonPayload("prompt") = ""
            jsonPayload("stream") = False

            Dim content As New StringContent(jsonPayload.ToString(), Encoding.UTF8, "application/json")

            Using client As New HttpClient()
                client.Timeout = TimeSpan.FromMinutes(2)

                Dim response As HttpResponseMessage = Await client.PostAsync(apiUrl, content)

                If response.IsSuccessStatusCode Then
                    MessageBox.Show($"The model '{modelName}' was successfully preloaded!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Preloading error: " & response.ReasonPhrase, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Connection error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.Cursor = Cursors.Default
            SiticoneButton_preload.Enabled = True
        End Try
    End Sub

    Private Sub SiticoneNavbar_tab_SelectedItemChanged(sender As Object, e As SiticoneNavbar.NavBarSelectionEventArgs) Handles SiticoneNavbar_tab.SelectedItemChanged
        SiticoneTabControl_tab.SelectedIndex = SiticoneNavbar_tab.SelectedIndex
        SiticoneTextArea_prompt.Focus()
    End Sub

    Private Sub SiticoneTabControl_tab_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SiticoneTabControl_tab.SelectedIndexChanged
        SiticoneNavbar_tab.SelectedIndex = SiticoneTabControl_tab.SelectedIndex
        SiticoneTextArea_prompt.Focus()
    End Sub

    Private Sub SiticoneButton4_close1_Click(sender As Object, e As EventArgs) Handles SiticoneButton4_close1.Click
        Close()
    End Sub

    Private Sub SiticoneButton_max1_Click(sender As Object, e As EventArgs) Handles SiticoneButton_max1.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
            SiticoneButton_max1.Text = "❐"
        Else
            WindowState = FormWindowState.Normal
            SiticoneButton_max1.Text = "☐"
        End If
    End Sub

    Private Sub SiticoneButton_min1_Click(sender As Object, e As EventArgs) Handles SiticoneButton_min1.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub SiticoneButton_hamburg_Click(sender As Object, e As EventArgs) Handles SiticoneButton_hamburg.Click
        SiticoneNavbar_tab.Visible = Not SiticoneNavbar_tab.Visible
    End Sub

    Private Sub SiticoneButton_LLM_Click(sender As Object, e As EventArgs) Handles SiticoneButton_LLM.Click
        SiticonePanel_llm_setting.Visible = Not SiticonePanel_llm_setting.Visible
    End Sub

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Const WM_NCHITTEST As Integer = &H84

        Const HTCLIENT As Integer = 1
        Const HTLEFT As Integer = 10
        Const HTRIGHT As Integer = 11
        Const HTTOP As Integer = 12
        Const HTTOPLEFT As Integer = 13
        Const HTTOPRIGHT As Integer = 14
        Const HTBOTTOM As Integer = 15
        Const HTBOTTOMLEFT As Integer = 16
        Const HTBOTTOMRIGHT As Integer = 17

        If m.Msg <> WM_NCHITTEST Then
            MyBase.WndProc(m)
            Return
        End If

        Dim screenPoint As Point = Cursor.Position
        Dim clientPoint As Point = Me.PointToClient(screenPoint)
        Dim resizeArea As Integer = 40

        m.Result = New IntPtr(HTCLIENT)

        If clientPoint.Y <= resizeArea Then
            If clientPoint.X <= resizeArea Then
                m.Result = New IntPtr(HTTOPLEFT)
            ElseIf clientPoint.X >= (Me.Size.Width - resizeArea) Then
                m.Result = New IntPtr(HTTOPRIGHT)
            Else
                m.Result = New IntPtr(HTTOP)
            End If
        ElseIf clientPoint.Y >= (Me.Size.Height - resizeArea) Then
            If clientPoint.X <= resizeArea Then
                m.Result = New IntPtr(HTBOTTOMLEFT)
            ElseIf clientPoint.X >= (Me.Size.Width - resizeArea) Then
                m.Result = New IntPtr(HTBOTTOMRIGHT)
            Else
                m.Result = New IntPtr(HTBOTTOM)
            End If
        Else
            If clientPoint.X <= resizeArea Then
                m.Result = New IntPtr(HTLEFT)
            ElseIf clientPoint.X >= (Me.Size.Width - resizeArea) Then
                m.Result = New IntPtr(HTRIGHT)
            Else
                MyBase.WndProc(m)
            End If
        End If
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Debug.WriteLine($"[DEBUG-HOTKEY] Taste gedrückt: {e.KeyCode} | Shift: {e.Shift} | Control: {e.Control}")

        If e.Shift AndAlso e.KeyCode = Keys.F12 Then
            Debug.WriteLine("[DEBUG-HOTKEY] BINGO! Shift + F12 wurde erkannt! Versuche PowerShell zu starten...")
            Try
                If Not IO.File.Exists(logFilePath) Then
                    Debug.WriteLine($"[DEBUG-HOTKEY] Log-Datei existiert noch nicht. Erstelle sie unter: {logFilePath}")
                    IO.File.WriteAllText(logFilePath, "--- OLLAMA DESKTOP LIVE DEBUG LOG START ---" & vbCrLf)
                Else
                    Debug.WriteLine($"[DEBUG-HOTKEY] Log-Datei gefunden unter: {logFilePath}")
                End If

                Dim psCommand As String = $"-NoProfile -Command ""Get-Content '{logFilePath}' -Wait -Tail 20 -Encoding UTF8"""
                Debug.WriteLine($"[DEBUG-HOTKEY] Führe aus: powershell.exe {psCommand}")

                Process.Start("powershell.exe", psCommand)

                AppLog("[DEBUG-KeyDown] PowerShell Live-Monitor wurde vom User über Shift+F12 gestartet.")
                Debug.WriteLine("[DEBUG-HOTKEY] PowerShell wurde erfolgreich gestartet!")
            Catch ex As Exception
                Debug.WriteLine($"[DEBUG-HOTKEY] FEHLER beim Starten der PowerShell: {ex.Message}")
                MessageBox.Show("Fehler beim Starten der PowerShell: " & ex.Message)
            End Try
        End If
        If e.Shift AndAlso e.KeyCode = Keys.F11 Then
            SiticoneLabel_test.Visible = Not SiticoneLabel_test.Visible
            SiticoneToggleSwitch_test.Visible = Not SiticoneToggleSwitch_test.Visible
        End If
    End Sub

    Public Sub AppLog(message As String)
        Dim logLine As String = $"[{DateTime.Now:HH:mm:ss.fff}] {message}"

        System.Diagnostics.Debug.WriteLine(logLine)

        Try
            SyncLock logLock
                IO.File.AppendAllText(logFilePath, logLine & vbCrLf)
            End SyncLock
        Catch
        End Try
    End Sub

    ' SSH Terminal in WebView2
    Private Async Sub SiticoneButton_connectssh_Click(sender As Object, e As EventArgs) Handles SiticoneButton_connectssh.Click
        SiticoneButton_connectssh.Enabled = False
        _sshClient = New SshClient(SiticoneTextBox_ssh_address.Text, SiticoneTextBox_ssh_user.Text, SiticoneTextBox_ssh_pw.Text)
        Try
            Await Task.Run(Sub() _sshClient.Connect())

            _shellStream = _sshClient.CreateShellStream("xterm-256color", 80, 24, 800, 600, 1024)

            If WebViewTerminal IsNot Nothing AndAlso WebViewTerminal.CoreWebView2 IsNot Nothing Then
                WebViewTerminal.CoreWebView2.ExecuteScriptAsync("if (typeof updateTerminalSize === 'function') updateTerminalSize();")
            End If

            _cts = New CancellationTokenSource()
            StartReadingLoop(_cts.Token)

        Catch ex As SshAuthenticationException
            MessageBox.Show("Access denied! Please check your username and password.",
                            "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Catch ex As Net.Sockets.SocketException
            MessageBox.Show("The server is unreachable. Please verify the IP address or hostname.",
                            "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch ex As Exception
            MessageBox.Show("An unexpected error occurred while connecting: " & ex.Message,
                            "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            SiticoneButton_connectssh.Enabled = True
        End Try
    End Sub

    Private Sub StartReadingLoop(token As CancellationToken)
        Task.Run(Async Function()
                     Dim buffer(4096) As Byte
                     Try
                         While _sshClient.IsConnected AndAlso Not token.IsCancellationRequested
                             If _shellStream.DataAvailable Then
                                 Dim count = _shellStream.Read(buffer, 0, buffer.Length)
                                 Dim text = Encoding.UTF8.GetString(buffer, 0, count)

                                 Dim base64Str = Convert.ToBase64String(buffer, 0, count)
                                 Me.Invoke(Sub()
                                               WebViewTerminal.CoreWebView2.ExecuteScriptAsync($"window.writeFromDotNet('{base64Str}');")
                                           End Sub)

                                 SyncLock _bufferLock
                                     _llmBuffer.Append(text)
                                     AppLog($"[DEBUG-StartReadingLoop] Append _llmBuffer {text.Length} Zeichen hinzu...")
                                     If _llmBuffer.Length > 10000 Then
                                         _llmBuffer.Remove(0, _llmBuffer.Length - 10000)
                                     End If
                                 End SyncLock
                             End If
                         End While
                     Catch ex As Exception
                     End Try
                 End Function, token)
    End Sub

    Private Sub WebViewTerminal_WebMessageReceived(sender As Object, e As CoreWebView2WebMessageReceivedEventArgs) Handles WebViewTerminal.WebMessageReceived
        Dim msg As String = e.TryGetWebMessageAsString()

        Try
            Dim parsedJson = JsonNode.Parse(msg)
            Dim msgType = parsedJson("type")?.ToString()

            If msgType = "resize" Then
                If _shellStream IsNot Nothing Then
                    Dim cols As UInteger = parsedJson("cols").GetValue(Of UInteger)()
                    Dim rows As UInteger = parsedJson("rows").GetValue(Of UInteger)()

                    _shellStream.ChangeWindowSize(cols, rows, 0, 0)
                End If

            ElseIf msgType = "input" Then
                If _shellStream IsNot Nothing AndAlso _shellStream.CanWrite Then
                    Dim data As String = parsedJson("data")?.ToString()
                    Dim bytes = Encoding.UTF8.GetBytes(data)
                    _shellStream.Write(bytes, 0, bytes.Length)
                    _shellStream.Flush()
                End If
            End If

        Catch ex As Exception
            Debug.WriteLine("JSON Parse Error: " & ex.Message)
        End Try
    End Sub

    Public Sub ExecuteLlmCommand(llmCommand As String)
        If _shellStream IsNot Nothing AndAlso _shellStream.CanWrite Then
            Dim bytes = Encoding.UTF8.GetBytes(llmCommand & vbLf)
            _shellStream.Write(bytes, 0, bytes.Length)
            _shellStream.Flush()
        End If
    End Sub

    Private Async Sub SiticoneButton_test_Click(sender As Object, e As EventArgs) Handles SiticoneButton_test.Click
        SiticoneButton_test.Enabled = False

        Dim ergebnis = Await ExecuteCommandAndWaitAsync("sudo ls -al", Val(SiticoneTextBox_ssh_timeout.Text))

        AppLog("[DEBUG-test_Click] SSH Response: " & ergebnis)

        SiticoneButton_test.Enabled = True
    End Sub

    Public Function GetTerminalContextForLlm() As String
        SyncLock _bufferLock
            Dim output = _llmBuffer.ToString()
            _llmBuffer.Clear()
            AppLog($"[DEBUG-GetTerminalContextForLlm] Clear _llmBuffer...")
            Return output
        End SyncLock
    End Function

    Public Async Function ExecuteCommandAndWaitAsync(command As String, maxWaitTimeSeconds As Integer) As Task(Of String)
        SyncLock _bufferLock
            _llmBuffer.Clear()
            AppLog("[DEBUG-ExecuteCommandAndWaitAsync] Clear _llmBuffer...")
        End SyncLock

        Dim safeCommand As String = command.Trim()

        Dim botEnvVars As String = "PAGER=cat SYSTEMD_PAGER=cat DEBIAN_FRONTEND=noninteractive "

        If safeCommand.Contains("sudo ") Then
            safeCommand = safeCommand.Replace("sudo ", "sudo " & botEnvVars)
        Else
            safeCommand = botEnvVars & safeCommand
        End If

        ExecuteLlmCommand(safeCommand)
        AppLog("[DEBUG-ExecuteCommandAndWaitAsync] SSH Command: " & safeCommand)

        Dim promptRegex As New Regex(SiticoneTextBox_ssh_regex.Text, RegexOptions.Multiline)
        Dim passwordRequest As String = SiticoneTextBox_ssh_pwrequest.Text
        Dim sudoPassword As String = SiticoneTextBox_ssh_sudopw.Text

        Dim ansiStripRegex As New Regex("\x1B(?:[@-Z\\-_]|\[[0-?]*[ -/]*[@-~])")

        Dim startTime As DateTime = DateTime.Now
        Dim currentOutput As String = ""
        Dim cleanOutput As String = ""
        Dim isFinished As Boolean = False
        Dim passwordSent As Boolean = False

        AppLog("[DEBUG-ExecuteCommandAndWaitAsync] SSH Wait for RegEx or Password Request...")

        While (DateTime.Now - startTime).TotalSeconds < maxWaitTimeSeconds
            Await Task.Delay(200)

            SyncLock _bufferLock
                currentOutput = _llmBuffer.ToString()
            End SyncLock

            cleanOutput = ansiStripRegex.Replace(currentOutput, "")
            cleanOutput = cleanOutput.Replace(vbCr, "").Replace(vbLf, vbCrLf)

            If Not passwordSent AndAlso cleanOutput.Contains(passwordRequest) Then
                AppLog("[DEBUG-ExecuteCommandAndWaitAsync] SSH Sudo password requested. Sending password...")

                Dim pwBytes = Encoding.UTF8.GetBytes(sudoPassword & vbLf)
                _shellStream.Write(pwBytes, 0, pwBytes.Length)
                _shellStream.Flush()

                passwordSent = True
                startTime = DateTime.Now
            End If

            If promptRegex.IsMatch(cleanOutput) Then
                isFinished = True
                Exit While
            End If
        End While

        SyncLock _bufferLock
            _llmBuffer.Clear()
            AppLog($"[DEBUG-ExecuteCommandAndWaitAsync] Clear _llmBuffer...")
        End SyncLock

        If Not isFinished Then
            cleanOutput &= vbCrLf & "[SYSTEM: Timeout reached. Command might still be running or Sudo failed.]"
            AppLog("[DEBUG-ExecuteCommandAndWaitAsync] SSH SYSTEM: Timeout reached.")
        End If

        Dim cmdIndex As Integer = cleanOutput.IndexOf(safeCommand)
        If cmdIndex >= 0 Then
            cleanOutput = cleanOutput.Substring(cmdIndex + safeCommand.Length)
        End If

        cleanOutput = Regex.Replace(cleanOutput, "\]?0;[^\x07]+\x07", "")

        cleanOutput = promptRegex.Replace(cleanOutput, "")

        Dim lines As String() = cleanOutput.Split(vbLf)
        For i As Integer = 0 To lines.Length - 1
            Dim currentLine As String = lines(i)
            If currentLine.EndsWith(vbCr) Then
                currentLine = currentLine.Substring(0, currentLine.Length - 1)
            End If
            If currentLine.Contains(vbCr) Then
                lines(i) = currentLine.Split(vbCr).Last()
            Else
                lines(i) = currentLine
            End If
        Next
        cleanOutput = String.Join(vbLf, lines)

        cleanOutput = Regex.Replace(cleanOutput, "\d+%\s*\[[^\]]+\][ \t]*", "")
        cleanOutput = Regex.Replace(cleanOutput, "\[[^\]]+%\][ \t]*", "")
        cleanOutput = Regex.Replace(cleanOutput, "(?:\d+%\s*)?\[(?:Working|Connecting|Waiting)[^\]]*\][ \t]*", "")
        cleanOutput = Regex.Replace(cleanOutput, "(?:\d+%\s*)?\[[^\]]+\][ \t]{5,}", "")

        cleanOutput = Regex.Replace(cleanOutput, "(?m)^[ \t]+(Hit:|Get:|Ign:|Err:|Unpacking|Setting up|Preparing|Progress:)", "$1")

        cleanOutput = Regex.Replace(cleanOutput, "[ \t]*(Reading package lists|Building dependency tree|Reading state information|Calculating upgrade)[ \.\d%]*", "")

        cleanOutput = Regex.Replace(cleanOutput, "\x1B[78]?", "")

        cleanOutput = Regex.Replace(cleanOutput, "\(?Reading database \.\.\.[ \d%]*\)?", "")
        cleanOutput = Regex.Replace(cleanOutput, ".*files and directories currently installed\.\)", "")

        cleanOutput = Regex.Replace(cleanOutput, "Progress:\s*\[[^\]]*\]\s*", "")

        cleanOutput = cleanOutput.Trim()
        cleanOutput = Regex.Replace(cleanOutput, "\n{3,}", vbLf & vbLf)

        If String.IsNullOrWhiteSpace(cleanOutput) Then
            cleanOutput = "[Keine Textausgabe - Befehl wurde erfolgreich ohne Fehler ausgeführt]"
        End If

        Return cleanOutput.Replace(vbLf, vbCrLf)
    End Function

    Private Sub SiticoneButton_audio_Click(sender As Object, e As EventArgs) Handles SiticoneButton_audio.Click
        Dim mouseEv As MouseEventArgs = TryCast(e, MouseEventArgs)
        If mouseEv IsNot Nothing AndAlso mouseEv.Button = MouseButtons.Right Then Exit Sub

        If Not isRecordingAudio Then
            Try
                audioTempPath = Path.Combine(Path.GetTempPath(), $"Voice_{DateTime.Now:yyyyMMdd_HHmmss}.wav")

                If selectedAudioDeviceIndex >= waveIn.DeviceCount Then
                    AppLog($"[AUDIO] Warnung: Gespeichertes Gerät (Index {selectedAudioDeviceIndex}) nicht mehr verfügbar. Fallback auf Windows-Standard (0).")
                    selectedAudioDeviceIndex = 0
                End If

                waveIn = New WaveInEvent()
                waveIn.DeviceNumber = selectedAudioDeviceIndex
                waveIn.WaveFormat = New WaveFormat(16000, 16, 1)

                waveWriter = New WaveFileWriter(audioTempPath, waveIn.WaveFormat)

                AddHandler waveIn.DataAvailable, Sub(s, waveArgs)
                                                     waveWriter?.Write(waveArgs.Buffer, 0, waveArgs.BytesRecorded)
                                                 End Sub

                AddHandler waveIn.RecordingStopped, Sub(s, waveArgs)
                                                        waveWriter?.Dispose()
                                                        waveWriter = Nothing
                                                        waveIn?.Dispose()
                                                        waveIn = Nothing

                                                        Me.BeginInvoke(Sub()
                                                                           Try
                                                                               If File.Exists(audioTempPath) Then
                                                                                   Dim audioBytes() As Byte = File.ReadAllBytes(audioTempPath)
                                                                                   Dim aContent As New audio_content_def With {
                                                                                       .base64String = Convert.ToBase64String(audioBytes),
                                                                                       .fileName = Path.GetFileName(audioTempPath),
                                                                                       .fileExtension = "wav"
                                                                                   }
                                                                                   audio_contents.Add(aContent)
                                                                                   AppLog("[AUDIO] Datei erfolgreich geladen und Base64 generiert.")
                                                                               End If

                                                                               AddFileChip(audioTempPath, "wav")
                                                                               SiticoneFlowPanel_prompt_filecontent.Visible = True
                                                                               UpdatePromptLayout()
                                                                               SiticoneTextArea_prompt_TextChanged(Nothing, Nothing)

                                                                           Catch ex As Exception
                                                                               MessageBox.Show("Fehler beim Verarbeiten der Audiodatei: " & ex.Message, "Audio Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                                                           End Try
                                                                       End Sub)
                                                    End Sub

                waveIn.StartRecording()
                isRecordingAudio = True

                Dim recordColor As Color = Color.FromArgb(239, 83, 80)
                SiticoneButton_audio.ButtonBackColor = recordColor
                SiticoneButton_audio.HoverBackColor = recordColor

                AppLog($"[AUDIO] Aufnahme gestartet mit Gerät Index: {selectedAudioDeviceIndex}")
            Catch ex As Exception
                MessageBox.Show("Fehler beim Starten der NAudio-Aufnahme: " & ex.Message, "Audio Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            Try
                isRecordingAudio = False

                SiticoneButton_audio.ButtonBackColor = Color.Transparent
                SiticoneButton_audio.HoverBackColor = Color.FromArgb(240, 240, 240)

                waveIn?.StopRecording()

                AppLog("[AUDIO] Stop-Signal gesendet, warte auf Dateifreigabe...")
            Catch ex As Exception
                MessageBox.Show("Fehler beim Stoppen der Audioaufnahme: " & ex.Message, "Audio Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub SiticoneAudioButtons_MouseClick(sender As Object, e As MouseEventArgs) Handles SiticoneButton_audio.MouseClick, SiticoneButton_wisper.MouseClick
        If e.Button <> MouseButtons.Right Then Exit Sub
        If isRecordingAudio OrElse isListeningWhisper Then Exit Sub

        Dim targetButton As Control = CType(sender, Control)
        Dim audioMenu As New ContextMenuStrip()

        Try
            Dim deviceCount As Integer = waveIn.DeviceCount

            If deviceCount = 0 Then
                audioMenu.Items.Add("Keine Mikrofone gefunden").Enabled = False
            Else
                For i As Integer = 0 To deviceCount - 1
                    Dim capabilities = waveIn.GetCapabilities(i)
                    Dim itemName As String = capabilities.ProductName

                    Dim menuItem As New ToolStripMenuItem(itemName)
                    menuItem.Tag = i

                    If i = selectedAudioDeviceIndex Then
                        menuItem.Checked = True
                    End If

                    AddHandler menuItem.Click, Sub(menuSender As Object, menuE As EventArgs)
                                                   Dim clickedItem = CType(menuSender, ToolStripMenuItem)
                                                   selectedAudioDeviceIndex = CType(clickedItem.Tag, Integer)

                                                   My.Settings.AudioDevice = selectedAudioDeviceIndex
                                                   My.Settings.Save()

                                                   AppLog($"[AUDIO/WHISPER] Eingabegerät geändert auf: {clickedItem.Text} (Index: {selectedAudioDeviceIndex})")
                                               End Sub

                    audioMenu.Items.Add(menuItem)
                Next
            End If
        Catch ex As Exception
            audioMenu.Items.Add($"Fehler beim Laden: {ex.Message}").Enabled = False
        End Try

        audioMenu.Show(targetButton, e.Location)
    End Sub

    Private Sub InitWhisper()
        Try
            Dim modelPath As String = Path.Combine(System.Windows.Forms.Application.StartupPath, "ggml-base.bin")

            If File.Exists(modelPath) Then
                whisperFactory = WhisperFactory.FromPath(modelPath)

                Dim savedLang As String = My.Settings.WhisperLanguage
                If String.IsNullOrEmpty(savedLang) Then savedLang = "de"

                Dim builder = whisperFactory.CreateBuilder()

                If savedLang <> "auto" Then
                    builder.WithLanguage(savedLang)
                End If

                whisperProcessor = builder.Build()
                AppLog($"[WHISPER] Modell erfolgreich geladen (Sprache: {savedLang}).")
            Else
                AppLog("[WHISPER] Warnung: Modelldatei 'ggml-base.bin' nicht gefunden!")
            End If
        Catch ex As Exception
            AppLog($"[WHISPER] Fehler bei Initialisierung: {ex.Message}")
        End Try
    End Sub

    Private Sub ChangeWhisperLanguage(ByVal newLangCode As String)
        Try
            My.Settings.WhisperLanguage = newLangCode
            My.Settings.Save()

            whisperProcessor?.Dispose()

            Dim builder = whisperFactory.CreateBuilder()
            If newLangCode <> "auto" Then
                builder.WithLanguage(newLangCode)
            End If

            whisperProcessor = builder.Build()
            AppLog($"[WHISPER] Sprache erfolgreich umgestellt auf: {newLangCode}")
        Catch ex As Exception
            AppLog($"[WHISPER] Fehler beim Sprachwechsel: {ex.Message}")
        End Try
    End Sub

    Private Async Sub SiticoneButton_wisper_Click(sender As Object, e As EventArgs) Handles SiticoneButton_wisper.Click
        Dim mouseEv As MouseEventArgs = TryCast(e, MouseEventArgs)
        If mouseEv IsNot Nothing AndAlso mouseEv.Button = MouseButtons.Right Then Exit Sub

        If whisperProcessor Is Nothing Then
            MessageBox.Show("Whisper-Modell ist nicht geladen oder initialisiert.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not isListeningWhisper Then
            Try
                isListeningWhisper = True

                Dim waitGreen As Color = Color.FromArgb(46, 204, 113)
                SiticoneButton_wisper.ButtonBackColor = waitGreen
                SiticoneButton_wisper.HoverBackColor = waitGreen

                whisperWaveIn = New WaveInEvent()
                whisperWaveIn.DeviceNumber = selectedAudioDeviceIndex
                whisperWaveIn.WaveFormat = New WaveFormat(16000, 16, 1)

                whisperBufferedStream = New BufferedWaveProvider(whisperWaveIn.WaveFormat)
                whisperBufferedStream.DiscardOnBufferOverflow = True

                AddHandler whisperWaveIn.DataAvailable, Sub(s, waveArgs)
                                                            whisperBufferedStream.AddSamples(waveArgs.Buffer, 0, waveArgs.BytesRecorded)
                                                        End Sub

                whisperWaveIn.StartRecording()
                AppLog("[WHISPER] Live-Zuhören gestartet...")

                Task.Run(AddressOf ProcessWhisperStreamAsync)
                Task.Run(AddressOf ProcessWhisperQueueAsync)

            Catch ex As Exception
                MessageBox.Show("Fehler beim Starten des Transkripts: " & ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ResetWhisperUI()
            End Try
        Else
            isListeningWhisper = False
            ResetWhisperUI()

            Try
                whisperWaveIn?.StopRecording()

                AppLog("[WHISPER] Live-Zuhören beendet. Verarbeite Restdaten...")

                SiticoneTextArea_prompt.Focus()
                SiticoneTextArea_prompt.SelectionStart = SiticoneTextArea_prompt.TextLength
            Catch ex As Exception
                AppLog($"[WHISPER] Fehler beim Stoppen: {ex.Message}")
            End Try
        End If
    End Sub

    Private Sub ResetWhisperUI()
        SiticoneButton_wisper.ButtonBackColor = Color.Transparent
        SiticoneButton_wisper.HoverBackColor = Color.FromArgb(240, 240, 240)
    End Sub

    Private Async Function ProcessWhisperStreamAsync() As Task
        Dim chunkSize As Integer = 16000 * 2 * 0.2
        Dim chunkBuffer(chunkSize - 1) As Byte
        Dim phraseBuffer As New List(Of Byte)()

        Dim preRollBuffer As New List(Of Byte())()
        Dim maxPreRollChunks As Integer = 2

        Dim isRecordingPhrase As Boolean = False
        Dim silenceDurationMs As Integer = 0
        Dim silenceThreshold As Single = 0.004F
        Dim maxSilenceMs As Integer = 800

        While isListeningWhisper OrElse (whisperBufferedStream IsNot Nothing AndAlso whisperBufferedStream.BufferedBytes > 0)
            Dim hasProcessed As Boolean = False

            While whisperBufferedStream IsNot Nothing AndAlso whisperBufferedStream.BufferedBytes >= If(isListeningWhisper, chunkSize, 1)
                hasProcessed = True
                Dim currentAvailable As Integer = whisperBufferedStream.BufferedBytes
                Dim currentChunkSize As Integer = If(isListeningWhisper, chunkSize, currentAvailable)

                Dim localBuffer(currentChunkSize - 1) As Byte
                Dim bytesRead As Integer = whisperBufferedStream.Read(localBuffer, 0, currentChunkSize)

                If bytesRead > 0 Then
                    If isListeningWhisper Then
                        Dim floatSamples(bytesRead / 2 - 1) As Single
                        Dim rmsSum As Double = 0
                        For i As Integer = 0 To floatSamples.Length - 1
                            Dim sample As Short = BitConverter.ToInt16(localBuffer, i * 2)
                            Dim fSample As Single = sample / 32768.0F
                            floatSamples(i) = fSample
                            rmsSum += fSample * fSample
                        Next
                        Dim rms As Double = Math.Sqrt(rmsSum / floatSamples.Length)
                        Dim isSpeech As Boolean = (rms >= silenceThreshold)

                        If Not isRecordingPhrase Then
                            If isSpeech Then
                                isRecordingPhrase = True

                                SetWhisperButtonColor(Color.FromArgb(231, 76, 60))

                                silenceDurationMs = 0
                                phraseBuffer.Clear()

                                For Each preChunk In preRollBuffer
                                    phraseBuffer.AddRange(preChunk)
                                Next
                                preRollBuffer.Clear()

                                Dim actualChunk(bytesRead - 1) As Byte
                                Array.Copy(localBuffer, actualChunk, bytesRead)
                                phraseBuffer.AddRange(actualChunk)
                            Else
                                Dim actualChunk(bytesRead - 1) As Byte
                                Array.Copy(localBuffer, actualChunk, bytesRead)
                                preRollBuffer.Add(actualChunk)
                                If preRollBuffer.Count > maxPreRollChunks Then preRollBuffer.RemoveAt(0)
                            End If
                        Else
                            Dim actualChunk(bytesRead - 1) As Byte
                            Array.Copy(localBuffer, actualChunk, bytesRead)
                            phraseBuffer.AddRange(actualChunk)

                            If Not isSpeech Then silenceDurationMs += 200 Else silenceDurationMs = 0
                            Dim phraseDurationSeconds As Double = phraseBuffer.Count / (16000 * 2)

                            If silenceDurationMs >= maxSilenceMs OrElse phraseDurationSeconds > 12.0 Then
                                Dim bytesToKeep As Integer = phraseBuffer.Count
                                If silenceDurationMs >= maxSilenceMs Then
                                    Dim bytesToTrim As Integer = CInt((silenceDurationMs - 200) * 16000 * 2 / 1000)
                                    bytesToKeep = phraseBuffer.Count - bytesToTrim
                                End If

                                If bytesToKeep > 0 Then
                                    Dim trimmedPhrase(bytesToKeep - 1) As Byte
                                    phraseBuffer.CopyTo(0, trimmedPhrase, 0, bytesToKeep)
                                    whisperJobQueue.Enqueue(trimmedPhrase)
                                End If

                                phraseBuffer.Clear()
                                isRecordingPhrase = False

                                SetWhisperButtonColor(Color.FromArgb(46, 204, 113))

                                silenceDurationMs = 0
                                preRollBuffer.Clear()
                            End If
                        End If
                    Else
                        phraseBuffer.AddRange(localBuffer)
                        If phraseBuffer.Count > 0 Then
                            whisperJobQueue.Enqueue(phraseBuffer.ToArray())
                            phraseBuffer.Clear()
                        End If
                    End If
                End If
            End While

            If Not hasProcessed Then Await Task.Delay(40)
        End While

        If phraseBuffer.Count > 0 Then
            whisperJobQueue.Enqueue(phraseBuffer.ToArray())
            phraseBuffer.Clear()
        End If

        Try
            whisperWaveIn?.Dispose()
            whisperWaveIn = Nothing
            whisperBufferedStream = Nothing
            AppLog("[WHISPER] Ressourcen erfolgreich freigegeben.")
        Catch ex As Exception
        End Try
    End Function

    Private Async Function ProcessWhisperQueueAsync() As Task
        While isListeningWhisper OrElse Not whisperJobQueue.IsEmpty
            Dim nextAudioChunk() As Byte = Nothing

            If whisperJobQueue.TryDequeue(nextAudioChunk) Then
                Await TranscribeAudioChunkAsync(nextAudioChunk)
            Else
                Await Task.Delay(100)
            End If
        End While
        AppLog("[WHISPER] Warteschlange vollständig abgearbeitet.")
    End Function

    Private Async Function TranscribeAudioChunkAsync(ByVal audioBytes() As Byte) As Task
        Dim whisperSamples(audioBytes.Length / 2 - 1) As Single

        For i As Integer = 0 To whisperSamples.Length - 1
            Dim sample As Short = BitConverter.ToInt16(audioBytes, i * 2)
            whisperSamples(i) = sample / 32768.0F
        Next

        Try
            Dim asyncEnumerable = whisperProcessor.ProcessAsync(whisperSamples)
            Dim enumerator = asyncEnumerable.GetAsyncEnumerator()
            Dim processingDone As Boolean = False

            While Not processingDone
                Dim hasNext As Boolean = Await enumerator.MoveNextAsync()
                If hasNext Then
                    Dim segment = enumerator.Current
                    Dim textResult As String = segment.Text

                    If Not String.IsNullOrWhiteSpace(textResult) Then
                        AppendTranscribedText(textResult.Trim())
                    End If
                Else
                    processingDone = True
                End If
            End While

            Await enumerator.DisposeAsync()
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine($"[WHISPER] Fehler bei Segment-Verarbeitung: {ex.Message}")
        End Try
    End Function

    Private Sub AppendTranscribedText(ByVal text As String)
        If SiticoneTextArea_prompt.InvokeRequired Then
            Me.BeginInvoke(Sub() AppendTranscribedText(text))
            Exit Sub
        End If

        Dim cleanedText As String = text

        cleanedText = System.Text.RegularExpressions.Regex.Replace(cleanedText, "\[.*?\]", "")
        cleanedText = System.Text.RegularExpressions.Regex.Replace(cleanedText, "\*.*?\*", "")

        cleanedText = cleanedText.Trim()

        If String.IsNullOrWhiteSpace(cleanedText) Then Exit Sub

        If SiticoneTextArea_prompt.TextLength > 0 AndAlso Not SiticoneTextArea_prompt.Text.EndsWith(" ") Then
            SiticoneTextArea_prompt.AppendText(" ")
        End If

        SiticoneTextArea_prompt.AppendText(cleanedText)

        SiticoneTextArea_prompt_TextChanged(Nothing, Nothing)
    End Sub

    Private Sub SetWhisperButtonColor(ByVal targetColor As Color)
        If SiticoneButton_wisper.InvokeRequired Then
            Me.BeginInvoke(Sub() SetWhisperButtonColor(targetColor))
            Exit Sub
        End If

        SiticoneButton_wisper.ButtonBackColor = targetColor
        SiticoneButton_wisper.HoverBackColor = targetColor
    End Sub

    Private Sub SiticoneDropdown_wisperlang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SiticoneDropdown_wisperlang.SelectedIndexChanged
        If SiticoneDropdown_wisperlang.SelectedItem IsNot Nothing Then
            Dim selectedItem As String = SiticoneDropdown_wisperlang.SelectedItem.ToString()

            Dim parts() As String = selectedItem.Split(","c)

            If parts.Length = 2 Then
                Dim langCode As String = parts(1).Trim()

                If langCode <> My.Settings.WhisperLanguage Then
                    ChangeWhisperLanguage(langCode)
                End If
            End If
        End If
    End Sub

    Private Sub ExclusiveToggleSwitches_CheckedChanged(sender As Object, e As EventArgs) Handles _
        SiticoneToggleSwitch_sshbot.CheckedChanged,
        SiticoneToggleSwitch_tools.CheckedChanged,
        SiticoneToggleSwitch_ragtools.CheckedChanged,
        SiticoneToggleSwitch_decisiontools.CheckedChanged

        Dim activeSwitch = TryCast(sender, SiticoneToggleSwitch)

        ' Wenn der Schalter ausgeschaltet wurde, müssen die anderen nicht angefasst werden
        If activeSwitch Is Nothing OrElse Not activeSwitch.Checked Then Exit Sub

        ' Alle anderen Schalter ausschalten
        If activeSwitch IsNot SiticoneToggleSwitch_sshbot Then SiticoneToggleSwitch_sshbot.Checked = False
        If activeSwitch IsNot SiticoneToggleSwitch_tools Then SiticoneToggleSwitch_tools.Checked = False
        If activeSwitch IsNot SiticoneToggleSwitch_ragtools Then SiticoneToggleSwitch_ragtools.Checked = False
        If activeSwitch IsNot SiticoneToggleSwitch_decisiontools Then SiticoneToggleSwitch_decisiontools.Checked = False
    End Sub

End Class

Public Class DocumentIndex
    Private wordToSentences As New Dictionary(Of String, List(Of Integer))(StringComparer.OrdinalIgnoreCase)

    Private sentences As New List(Of SentenceData)

    Public Sub IndexDocument(content As String)
        wordToSentences.Clear()
        sentences.Clear()

        Dim sentenceArray = SplitIntoSentences(content)

        For i As Integer = 0 To sentenceArray.Length - 1
            Dim sentence As String = sentenceArray(i).Trim()
            If String.IsNullOrWhiteSpace(sentence) Then Continue For

            Dim sentData As New SentenceData(sentence, i)
            sentences.Add(sentData)

            Dim words = ExtractWords(sentence)
            For Each word In words
                If Not wordToSentences.ContainsKey(word) Then
                    wordToSentences(word) = New List(Of Integer)()
                End If
                If Not wordToSentences(word).Contains(i) Then
                    wordToSentences(word).Add(i)
                End If
            Next
        Next
    End Sub

    Public Function SearchAndIncrementHits(searchWord As String, Optional delta As Integer = 0) As List(Of SentenceData)
        Dim results As New List(Of SentenceData)()

        If wordToSentences.ContainsKey(searchWord) Then
            Dim affectedIndices As New HashSet(Of Integer)()

            For Each sentenceIdx In wordToSentences(searchWord)
                affectedIndices.Add(sentenceIdx)

                If delta > 0 Then
                    For offset As Integer = -delta To delta
                        Dim targetIdx As Integer = sentenceIdx + offset
                        If targetIdx >= 0 AndAlso targetIdx < sentences.Count Then
                            affectedIndices.Add(targetIdx)
                        End If
                    Next
                End If
            Next

            For Each idx In affectedIndices
                sentences(idx).HitCount += 1
                results.Add(sentences(idx))
            Next

            results = results.OrderBy(Function(s) s.SentenceIndex).ToList()
        End If

        Return results
    End Function

    Public Function GetSentencesWithHits() As List(Of SentenceData)
        Return sentences.Where(Function(s) s.HitCount > 0).OrderByDescending(Function(s) s.HitCount).ToList()
    End Function

    Public Function GetAllSentences() As List(Of SentenceData)
        Return sentences
    End Function

    Public Sub ResetHits()
        For Each sent In sentences
            sent.HitCount = 0
        Next
    End Sub

    Private Function SplitIntoSentences(text As String) As String()
        Dim sentences As New List(Of String)()

        Dim lines As String() = text.Split({vbCrLf, vbLf, vbCr}, StringSplitOptions.None)

        For Each line In lines
            If String.IsNullOrWhiteSpace(line) Then
                Continue For
            End If

            Dim lineSentences = SplitByPunctuation(line.Trim())

            For Each sent In lineSentences
                If Not String.IsNullOrWhiteSpace(sent) Then
                    sentences.Add(sent.Trim())
                End If
            Next
        Next

        Return sentences.ToArray()
    End Function

    Private Function SplitByPunctuation(text As String) As List(Of String)
        Dim result As New List(Of String)()

        Dim pattern As String = "(?<!\d|\b[A-ZÄÖÜ]|[IVXivx]{1,4})[.!?](?=\s)"

        Dim parts = System.Text.RegularExpressions.Regex.Split(text, pattern)

        For Each Partn In parts
            Dim trimmed As String = Partn.Trim()
            If Not String.IsNullOrWhiteSpace(trimmed) Then
                result.Add(trimmed)
            End If
        Next

        Return result
    End Function

    Private Function ExtractWords(sentence As String) As HashSet(Of String)
        Dim words As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase)
        Dim pattern As String = "\b[\w]+\b"
        Dim matches = System.Text.RegularExpressions.Regex.Matches(sentence, pattern)

        For Each match As System.Text.RegularExpressions.Match In matches
            words.Add(match.Value)
        Next

        Return words
    End Function

End Class