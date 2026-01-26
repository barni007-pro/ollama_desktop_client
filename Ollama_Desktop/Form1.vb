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
Imports Microsoft.Web.WebView2.Core
Imports Newtonsoft.Json            ' Für die JSON-Serialisierung
Imports Newtonsoft.Json.Linq       ' Für die JSON-Verarbeitung
Imports Ollama_Desktop.Form1
Imports Ollama_Desktop.My
Imports Ollama_Desktop.My.Resources
Imports ScintillaNET
Imports SiticoneNetCoreUI
Imports UglyToad.PdfPig


Public Class Form1
    'Public fileContent As String = ""
    'Public imageContent As String = ""
    'Public fileContentName As String = ""
    'Public fileContentExt As String = ""

    Public Class text_content_def
        Public Property text As String
        Public Property fileName As String
        Public Property fileExtention As String
    End Class

    Public text_contents As New List(Of text_content_def)
    Public rag_content As New text_content_def

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

    Public image_contents As New List(Of String)

    Public Request_JSON As String = ""
    Public Response_JSON As String = ""
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

    Public Class message
        Public Property role As String
        Public Property content As String
    End Class

    Public messages As New List(Of message)

    Public chat_mem As String = ""
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
        Public Property tools As Boolean
        Public Property thinking As Boolean
        Public Property embedding As Boolean
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
    End Class
    Public SettingsInfo_dic As Dictionary(Of String, SettingsInfo)

    Public APP_Start = True

    Private Async Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await InitializeWebView2()
        WebView21.CoreWebView2.Settings.IsScriptEnabled = True
        'ToolTip1.SetToolTip(SiticoneCheckBox_temperature, "Bedeutung: Beeinflusst die Streuung der Wahrscheinlichkeiten für die Auswahl von Vorschlägen." & vbCrLf & "Beispiel: `temperature = 0.8` sorgt für eine moderate Zufälligkeit in den Auswahlmöglichkeiten.")
        'ToolTip1.SetToolTip(SiticoneCheckBox_top_p, "Bedeutung: Diese Parameter steuern die Auswahl der Vorschläge." & vbCrLf & "Beispiel: `top_p = 0.9` berücksichtigt die Kandidaten, bis eine kumulierte Wahrscheinlichkeit von 90% erreicht ist.")
        'ToolTip1.SetToolTip(SiticoneCheckBox_top_k, "Bedeutung: Diese Parameter steuern die Auswahl der Vorschläge." & vbCrLf & "Beispiel: `top_k = 20` wählt nur aus den besten 20 Wahrscheinlichkeiten.")
        'ToolTip1.SetToolTip(SiticoneCheckBox_num_ctx, "Bedeutung: Steht für Context Size." & vbCrLf & "Beispiel: `num_ctx = 1024` es werden 1024 Token pro Context Window berücksichtigt. Das gilt für Input und Ountput.")
        'ToolTip1.SetToolTip(SiticoneCheckBox_num_keep, "Bedeutung: Dieser Parameter gibt an, wie viele der besten Vorschläge beibehalten werden sollen." & vbCrLf & "Beispiel: `num_keep = 5` bedeutet, dass die fünf am wahrscheinlichsten erscheinenden Fortsetzungen im Modell beibehalten werden.")
        'ToolTip1.SetToolTip(SiticoneCheckBox_num_predict, "Bedeutung: Gibt die Anzahl der Zeichen an, die vorausgesagt werden sollen." & vbCrLf & "Beispiel: `num_predict = 100` bedeutet, dass das Modell bis zu 100 Zeichen generiert.")
        ToolTip1.AutoPopDelay = 10000
        SiticoneTextBox_host.Text = My.Settings.ollama_host
        SiticoneDropdown_API.SelectedIndex = 0
        'SiticoneSplitContainer_main.SplitterDistance = 720
        SiticoneSplitContainer_runcont.SplitterDistance = 495


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
        Scintilla_format.Text = My.Settings.format
        SiticoneTextArea_content_prompt.Text = My.Settings.content_prompt

        SiticoneTextArea_Tools_system.Text = My.Settings.tools_system
        Scintilla_Tools_Json.Text = My.Settings.tools_json
        Scintilla_Tools_pythoncode.Text = My.Settings.tools_pythoncode

        SiticoneTextArea_Rag_system.Text = My.Settings.rag_system
        Scintilla_Rag_Json.Text = My.Settings.rag_json

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
        SetupEditor(Scintilla_Request_JSON, "json")
        SetupEditor(Scintilla_Response_JSON, "json")
        SetupEditor(Scintilla_response, "markdown")

        'Me.Icon = New Icon("D: \Projekte\Visual Studio 2008\Projekte\Ollama_Desktop\Ollama_Desktop\pic\315878_ai_document_file_icon.ico")
        SiticoneTextArea_prompt.ScrollBars = ScrollBars.None
        RegisterStateImages(SiticoneButton_file, My.Resources.Resource_pic.paperclip_32_blau, My.Resources.Resource_pic.paperclip_32_grau)
        RegisterStateImages(SiticoneButton_screenshot, My.Resources.Resource_pic.screenshot_32_blau, My.Resources.Resource_pic.screenshot_32_grau)
        RegisterStateImages(SiticoneButton_timing, My.Resources.Resource_pic.statistics_32_blau, My.Resources.Resource_pic.statistics_32_grau)
        RegisterStateImages(SiticoneButton_show_thinking, My.Resources.Resource_pic.think_32_blau, My.Resources.Resource_pic.think_32_grau)
        RegisterStateImages(SiticoneButton_HTMLtoPDF, My.Resources.Resource_pic.save_32_blau, My.Resources.Resource_pic.save_32_grau)

        'öffnet LLM API Setting Menü
        SiticoneGroupBox_LLM_setting.IsCollapsed = My.Settings.LLM_seting

        'läd die letzte Modell Liste
        If My.Settings.LLM_model_info IsNot Nothing Then
            For Each jsonString As String In My.Settings.LLM_model_info
                ' Den JSON-String parsen, um an den Namen zu kommen
                Dim modelJson As JObject = JObject.Parse(jsonString)
                Dim displayName As String = modelJson("name").ToString()

                ' JSON in die lokale Liste (für später) und Name ins Dropdown
                model_info.Add(jsonString)
                SiticoneDropdown_model.Items.Add(displayName)
            Next
        End If
        'Selektiert die letzte Modell Auswahl
        If SiticoneDropdown_model.Items.Count > 0 Then
            SiticoneDropdown_model.SelectedIndex = My.Settings.LLM_model_index
        End If
        APP_Start = False
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        My.Settings.ollama_host = SiticoneTextBox_host.Text

        My.Settings.system = SiticoneTextArea_system.Text
        My.Settings.system_use = SiticoneToggleSwitch_system_use.Checked
        My.Settings.format_use = SiticoneToggleSwitch_format_use.Checked
        My.Settings.format = Scintilla_format.Text
        My.Settings.content_prompt = SiticoneTextArea_content_prompt.Text

        My.Settings.tools_system = SiticoneTextArea_Tools_system.Text
        My.Settings.tools_json = Scintilla_Tools_Json.Text
        My.Settings.tools_pythoncode = Scintilla_Tools_pythoncode.Text

        My.Settings.rag_system = SiticoneTextArea_Rag_system.Text
        My.Settings.rag_json = Scintilla_Rag_Json.Text

        My.Settings.LLM_seting = SiticoneGroupBox_LLM_setting.IsCollapsed

        My.Settings.LLM_model_info = New Specialized.StringCollection()
        My.Settings.LLM_model_info.AddRange(model_info.ToArray())
        My.Settings.LLM_model_index = SiticoneDropdown_model.SelectedIndex
    End Sub

    Private Sub RegisterStateImages(btn As SiticoneButton,
                                imgEnabled As Image,
                                imgDisabled As Image)

        ' 1. Die Logik zum Wechseln definieren
        Dim updateImage = Sub()
                              If btn.Enabled Then
                                  ' Hier nutzen wir ButtonImage statt Image
                                  btn.ButtonImage = imgEnabled
                              Else
                                  btn.ButtonImage = imgDisabled
                              End If
                          End Sub

        ' 2. Event-Handler anhängen: Wenn sich "Enabled" ändert, Bild tauschen
        AddHandler btn.EnabledChanged, Sub(sender, e) updateImage()

        ' 3. Sofort einmal ausführen
        updateImage()
    End Sub

    Private Sub SiticoneTextArea_prompt_KeyDown(sender As Object, e As KeyEventArgs) Handles SiticoneTextArea_prompt.KeyDown
        If e.KeyCode = Keys.Enter AndAlso Not ModifierKeys.HasFlag(Keys.Shift) Then
            e.SuppressKeyPress = True ' Verhindert auch Umbrüche bei Enter
            SiticonePlayPauseButton_request.IsPlaying = True
        End If
        If e.Control AndAlso e.KeyCode = Keys.V Then


            If Clipboard.ContainsImage Then
                import_clp_image()
                ' Unterdrücke Standard-Paste falls nötig
                e.SuppressKeyPress = True
            End If
        End If
    End Sub

    Private Sub import_clp_image()
        Dim img As Image = Clipboard.GetImage()
        If img Is Nothing Then Return

        ' Temporären Pfad erstellen
        Dim tempPath As String = Path.Combine(Path.GetTempPath(), $"Screenshot_{DateTime.Now:HHmmss}.png")
        img.Save(tempPath, System.Drawing.Imaging.ImageFormat.Png)

        ' Alte Inhalte löschen (wie in deinem Original-Code gewünscht)
        ' Falls du mehrere Anhänge erlauben willst, entferne diese .Clear() Zeilen
        'text_contents.Clear()
        'image_contents.Clear()
        'SiticoneFlowPanel_prompt_filecontent.Controls.Clear()

        ' In Base64 Liste für die API speichern
        Dim imageBytes() As Byte = File.ReadAllBytes(tempPath)
        image_contents.Add(Convert.ToBase64String(imageBytes))

        ' Visuellen Chip hinzufügen (48px Version)
        AddFileChip(tempPath, "png")

        ' UI Aktualisierung
        SiticoneFlowPanel_prompt_filecontent.Visible = True
    End Sub

    Private Async Sub SiticonePlayPauseButton_request_StateChanged(sender As Object, e As EventArgs) Handles SiticonePlayPauseButton_request.StateChanged
        If SiticonePlayPauseButton_request.IsPlaying = True Then
            SiticoneTextBox_request_answer.Text = ""
            Dim prompt = SiticoneTextArea_prompt.Text.Trim

            ' --- OLLAMA API SONDERBEFEHLE ---
            If prompt.StartsWith("ollama") Then
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
                Else
                    Scintilla_response.Text = "Syntax: ollama [rm|pull] MODELNAME"
                End If
                SiticonePlayPauseButton_request.IsPlaying = False
                SiticoneTabControl_tab.SelectedTab = TabPage_responsemd
                Exit Sub
            End If

            ' --- NORMALE LLM-ANFRAGE ---
            Await MainAsync()

            ' --- TOOLS / RAG VERARBEITUNG ---
            If ToolsCodeBlockJson <> "empty" Then
                If SiticoneToggleSwitch_tools.Checked Then
                    tools_Response_mem = python_code_run(Scintilla_Tools_pythoncode.Text, ToolsCodeBlockJson)
                End If
                If SiticoneToggleSwitch_ragtools.Checked Then
                    documentIndex.ResetHits()
                    ProcessLLMResponse(ToolsCodeBlockJson, SiticoneDropdown_delta_val.SelectedIndex)
                    tools_Response_mem = ""
                    Dim HITS = documentIndex.GetSentencesWithHits
                    SiticoneLabel_HitCountVal.Text = HITS.Count.ToString
                    For Each HIT In HITS
                        tools_Response_mem &= HIT.Text & vbCrLf
                    Next
                End If

                ' Vorherige Chips entfernen
                ClearFileChips()

                Try
                    ' JSON parsen & minify
                    Dim jsonObj = JsonConvert.DeserializeObject(Of Object)(tools_Response_mem)
                    tools_Response_mem = JsonConvert.SerializeObject(jsonObj, Formatting.None)

                    Dim text_content As New text_content_def With {
                    .text = tools_Response_mem,
                    .fileName = "tools_response.json",
                    .fileExtention = "json"
                }
                    text_contents.Clear()
                    text_contents.Add(text_content)

                    ' --- NEU: Chip statt ListBox ---
                    Dim tempPath = Path.Combine(Path.GetTempPath, text_content.fileName)
                    File.WriteAllText(tempPath, tools_Response_mem)

                    AddFileChip(tempPath, "json")
                    SiticoneFlowPanel_prompt_filecontent.Visible = True

                Catch ex As Exception
                    Dim text_content As New text_content_def With {
                    .text = tools_Response_mem,
                    .fileName = "tools_response.txt",
                    .fileExtention = "txt"
                }
                    text_contents.Clear()
                    text_contents.Add(text_content)

                    ' --- NEU: Chip statt ListBox (Fallback TXT) ---
                    Dim tempPath = Path.Combine(Path.GetTempPath, text_content.fileName)
                    File.WriteAllText(tempPath, tools_Response_mem)

                    AddFileChip(tempPath, "txt")
                    SiticoneFlowPanel_prompt_filecontent.Visible = True
                End Try

                ' Layout-Höhe nach dem Hinzufügen des Chips aktualisieren
                SiticoneTextArea_prompt_TextChanged(Nothing, Nothing)

                SiticoneToggleSwitch_tools.Checked = False
                SiticoneToggleSwitch_ragtools.Checked = False
                Await MainAsync()
            Else
                SiticonePlayPauseButton_request.IsPlaying = False
            End If

        Else
            If cancellationTokenSource IsNot Nothing Then
                cancellationTokenSource.Cancel()
            End If
        End If
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
        Await LoadModelsAsync() ' Modelle beim Start laden
    End Sub

    Private Async Function MainAsync() As Task
        cancellationTokenSource = New CancellationTokenSource()
        Try
            'Me.Cursor = Cursors.WaitCursor
            cancellationTokenSource = New CancellationTokenSource()
            SiticoneLoadingSpinner_request.IsRunning = True
            Dim model As String = SiticoneDropdown_model.SelectedItem
            Dim prompt As String = SiticoneTextArea_prompt.Text
            Dim prompt_mem As String = prompt
            Dim system As String = ""
            If SiticoneToggleSwitch_system_use.Checked = True Then
                system = SiticoneTextArea_system.Text
            End If
            Dim format As String = ""
            If SiticoneToggleSwitch_format_use.Checked = True Then
                format = Scintilla_format.Text
            End If
            Dim tools As String = ""
            If SiticoneToggleSwitch_tools.Checked = True Then
                tools = Scintilla_Tools_Json.Text
                system = SiticoneTextArea_Tools_system.Text
            End If
            If SiticoneToggleSwitch_ragtools.Checked = True Then
                tools = Scintilla_Rag_Json.Text
                system = SiticoneTextArea_Rag_system.Text
            End If
            Dim think As Boolean = SiticoneToggleSwitch_thinking_use.Checked
            Dim think_level As String = SiticoneDropdown_thinking_use.SelectedItem
            Dim context As Boolean = SiticoneToggleSwitch_last_context.Checked
            If extractedContext.Count = 0 Then
                context = False
            End If
            If context = True Then
                system = ""
            End If
            prompt = prompt.Replace(vbCr, "") 'nur noch("/n") im prompt'
            request_mem = prompt

            If text_contents.Count > 0 Then
                Dim prompt_text_content As String = ""
                prompt_text_content = SiticoneTextArea_content_prompt.Text
                Dim prompt_file_content As String = ""
                Dim prompt_files_content As String = ""
                For Each text_content In text_contents
                    prompt_file_content = My.Settings.context_file
                    prompt_file_content = prompt_file_content.Replace("{filename}", text_content.fileName)
                    prompt_file_content = prompt_file_content.Replace("{filextention}", text_content.fileExtention)
                    prompt_file_content = prompt_file_content.Replace("{text}", text_content.text)
                    prompt_files_content &= prompt_file_content & vbCrLf
                Next
                prompt_text_content = prompt_text_content.Replace("{files}", prompt_files_content)
                prompt = prompt_text_content.Replace("{prompt}", prompt)
            End If
            prompt = prompt.Replace(vbCr, "") 'nur noch("/n") im prompt'

            'Dim response As String = Await QueryOllamaAsync(model, prompt, imageContent, system, temperature, num_ctx, top_p, top_k, num_keep, num_predict)
            Dim response As String = Await QueryOllamaAsync(model, prompt, image_contents, text_contents, My.Settings.option_list, system, format, tools, think, think_level, context, extractedContext, cancellationTokenSource.Token)
            response_mem = response
            If extractedThinking <> "" Then
                SiticoneButton_show_thinking.Enabled = True
            Else
                SiticoneButton_show_thinking.Enabled = False
            End If
            Try
                Dim parsedJson As JToken = JToken.Parse(Request_JSON)
                Dim prettyJsonString As String = parsedJson.ToString(Formatting.Indented)
                Scintilla_Request_JSON.Text = prettyJsonString
            Catch ex As Exception
                Scintilla_Request_JSON.Text = Request_JSON
            End Try
            If response <> Nothing Then
                'prüfe ob response ein JSON ist und kein MarkDown, das kann vorkommen wenn ein format JSON angefordert wurde
                If IsValidJsonCore(response) Then
                    'format wurde genutzt und json zurückgeliefert
                    response = "```json" & vbLf & response & vbLf & "```"
                End If

                Scintilla_response.Text = response.Replace(vbLf, vbCrLf)
                ' 1. Markdig-Pipeline mit Tabellen- und Mathe-Unterstützung
                If SiticoneDropdown_API.SelectedIndex = 0 Then
                    WebView21.NavigateToString(BuildHtml(response))
                    chat_mem = "***" & vbLf & ":star: user:  " & vbLf & prompt_mem.Replace(vbCrLf, "  " & vbLf) & "  " & vbLf & "***" & vbLf & ":thumbsup: " & model & ":  " & vbLf & response & "  " & vbLf & "***" & vbLf
                    SiticoneButton_HTMLtoPDF.Enabled = True
                Else
                    chat_mem = chat_mem & "***" & vbLf & ":star: user:  " & vbLf & prompt_mem.Replace(vbCrLf, "  " & vbLf) & "  " & vbLf & "***" & vbLf & ":thumbsup: " & model & ":  " & vbLf & response & "  " & vbLf & "***" & vbLf
                    WebView21.NavigateToString(BuildHtml(chat_mem))
                    SiticoneTextArea_prompt.Text = ""
                    SiticoneButton_HTMLtoPDF.Enabled = True
                End If

                Try
                    Dim parsedJson As JToken = JToken.Parse(Response_JSON)
                    Dim prettyJsonString As String = parsedJson.ToString(Formatting.Indented)
                    Scintilla_Response_JSON.Text = prettyJsonString
                    CodeBlock_List.Clear()
                    ToolsCodeBlockJson = ""
                    SiticoneDropdown_language.Items.Clear()
                    Scintilla_code_block.Text = ""
                    SiticoneTextArea_run_output.Text = ""
                    CodeBlock_List = ExtractCodeBlocks(response)
                    If ToolsCodeBlockJson <> "empty" Then
                        SiticoneTextBox_request_answer.Text = ToolsCodeBlockJson
                    End If
                    SiticoneButton_code_run.Enabled = False
                    If CodeBlock_List.Count >= 1 Then
                        For Each CodeBlock In CodeBlock_List
                            SiticoneDropdown_language.Items.Add(CodeBlock.Language)
                        Next
                        SiticoneDropdown_language.SelectedIndex = 0
                        change_language()
                    End If
                Catch ex As Exception
                    Scintilla_Response_JSON.Text = Response_JSON
                End Try
            Else
                Scintilla_Response_JSON.Text = "empty"
                Scintilla_response.Text = "empty"
                WebView21.NavigateToString(BuildHtml("empty"))
            End If
        Catch ex As OperationCanceledException
            MessageBox.Show("The process was aborted (timeout or user cancellation).", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            'Me.Cursor = Cursors.Default
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Cursor zurücksetzen, egal ob Erfolg oder Fehler
            'Me.Cursor = Cursors.Default
            'SiticoneCircularSpinner_request.IsRunning = False
            SiticoneLoadingSpinner_request.IsRunning = False
            If SiticoneToggleSwitch_tools.Checked = False Then
                SiticonePlayPauseButton_request.IsPlaying = False
            End If
            If SiticoneToggleSwitch_ragtools.Checked = False Then
                SiticonePlayPauseButton_request.IsPlaying = False
            End If
            SystemSounds.Asterisk.Play()
            'SiticoneTabControl_control.SelectedIndex = 6
            SiticoneTabControl_tab.SelectedTab = TabPage_responsehtml
        End Try
    End Function

    Private Function BuildHtml(markDownStr As String) As String
        ' Erstelle die Pipeline für Markdig mit den gewünschten Extensions:
        Dim pipeline = New MarkdownPipelineBuilder() _
        .UseAdvancedExtensions() _   ' Für Tabellen, Tasklisten, etc.
        .UseMathematics() _            ' KaTeX Unterstützung für LaTeX-Formeln
        .UseEmojiAndSmiley() _         ' Unterstützung für Emoji und Smiley
        .Build()

        ' Konvertiere den Markdown-String in HTML:
        'normaler MarkDown
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

        ' Baue das vollständige HTML-Dokument zusammen:
        Dim fullHtml = Replace(My.Settings.html_def, "{htmlContent}", htmlContent)

        Return fullHtml
    End Function

    Function AddLanguageTag2(markdown As String) As String
        ' Regex: Erfasst den gesamten Code-Block in Gruppe 1, wobei Gruppe 2 die Programmiersprache enthält.
        Dim pattern As String = "(```\s*(\S+)\s*[\n]+([\s\S]*?)[\n]+```)"

        Dim replaced As String = Regex.Replace(markdown, pattern, Function(m)
                                                                      Dim entireBlock As String = m.Groups(1).Value  ' Originaler Code-Block inkl. Backticks
                                                                      Dim language As String = m.Groups(2).Value.Trim()  ' Hier wird die Sprache extrahiert

                                                                      ' Füge die Sprach-Markierung in einer neuen Zeile vor dem Code-Block ein.
                                                                      Return vbLf & "<lang>" & language & "</lang>" & vbLf & entireBlock
                                                                  End Function, RegexOptions.Singleline)

        Return replaced
    End Function

    Function AddLanguageTag_xxx(markdown As String) As String
        ' Regex: Erfasse den gesamten Code-Block. Sprache ist optional.
        Dim pattern As String = "(```\s*(\S*)[\n]+([\s\S]*?)\n```)"

        Dim replaced As String = Regex.Replace(markdown, pattern, Function(m)
                                                                      Dim entireBlock As String = m.Groups(1).Value  ' Originaler Code-Block inkl. Backticks
                                                                      Dim language As String = m.Groups(2).Value.Trim() ' Sprache (falls angegeben)
                                                                      Dim codeContent As String = m.Groups(3).Value.Trim() ' Der Inhalt des Code-Blocks

                                                                      If Not String.IsNullOrWhiteSpace(language) Then
                                                                          ' Füge die Sprach-Markierung hinzu, wenn eine Sprache explizit angegeben wurde
                                                                          Return vbLf & "<lang>" & language & "</lang>" & vbLf & entireBlock
                                                                      Else
                                                                          ' Kein Tag hinzufügen, falls keine Sprache angegeben ist
                                                                          Return entireBlock
                                                                      End If
                                                                  End Function, RegexOptions.Singleline)

        Return replaced
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
        Dim teststr = result.ToString()
        Return result.ToString()
    End Function

    Public Function ConvertThinkBlocks(markdown As String) As String
        ' Muster, das alle Inhalte zwischen <think> und </think> einfängt (Singleline-Option erlaubt Zeilenumbrüche)
        Dim pattern As String = "<think>(.*?)</think>"

        Dim evaluator As MatchEvaluator = Function(m As Match)
                                              ' Gesamten Inhalt des Think-Blocks trimmen
                                              Dim content As String = m.Groups(1).Value.Trim()
                                              ' Inhalt zeilenweise aufsplitten (unabhängig von CR/LF)
                                              Dim lines As String() = Regex.Split(content, "\r?\n")
                                              ' Jede Zeile mit "> " versehen
                                              For i As Integer = 0 To lines.Length - 1
                                                  lines(i) = "> " & lines(i)
                                              Next
                                              ' Zusammenführen der Zeilen mit Überschrift
                                              Dim newContent As String = "> **think:**" & Environment.NewLine & String.Join(Environment.NewLine, lines)
                                              Return newContent
                                          End Function

        ' Ersetze alle <think>...</think>-Blöcke im Text
        Dim result As String = Regex.Replace(markdown, pattern, evaluator, RegexOptions.Singleline)
        Return result
    End Function

    Private Async Function QueryOllamaAsync(model As String,
                                    prompt As String,
                                    image_list As List(Of String),
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
        ' Haupt-Payload
        Dim apiUrl As String = ""
        Dim requestBody As String = ""
        If SiticoneDropdown_API.SelectedIndex = 0 Then
            apiUrl = "http://" & SiticoneTextBox_host.Text & "/api/generate"

            Dim payload As New Dictionary(Of String, Object) From {
                {"model", model},
                {"prompt", prompt},
                {"stream", False}
            }

            If Not String.IsNullOrEmpty(format) Then
                Dim raw = format.Trim()
                Try
                    Dim formatSchema As JToken = JToken.Parse(raw)
                    payload("format") = formatSchema
                Catch ex As Exception
                    payload("format") = raw
                End Try
            End If

            If image_list.Count > 0 Then
                payload("images") = image_list
            End If

            ' input geht leider bei Ollama noch nicht
            'Dim inputs As New Dictionary(Of String, Object)
            'For Each text_obj In text_list
            '    inputs(text_obj.fileName) = text_obj.text
            'Next

            'If inputs.Count > 0 Then
            '    payload("input") = inputs
            'End If

            If Not String.IsNullOrEmpty(system) Then
                payload("system") = system
            End If

            If Not String.IsNullOrEmpty(tools) Then
                Dim raw = tools.Trim()
                Try
                    Dim formatSchema As JToken = JToken.Parse(raw)
                    payload("tools") = formatSchema
                Catch ex As Exception
                    payload("tools") = raw
                End Try
            End If

            If think = True Then
                Select Case think_level
                    Case "false"
                        payload("think") = False
                    Case "true"
                        payload("think") = True
                    Case Else
                        payload("think") = think_level
                End Select
            End If

            If (context = True) And (last_context.Count <> 0) Then
                payload("context") = last_context
            End If

            ' Options-Dictionary
            Dim options As New Dictionary(Of String, Object)

            For Each optionString As String In My.Settings.option_list
                Dim values() As String = optionString.Split(New String() {"<|>"}, StringSplitOptions.None)
                If LCase(values(1)) = "true" Then
                    Select Case values(2)
                        '"string", "int", "float", "boolean"
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

            ' Nur wenn tatsächlich Optionen gesetzt wurden, fügen wir das "options"-Objekt hinzu
            If options.Count > 0 Then
                payload("options") = options
            End If

            ' JSON erzeugen
            requestBody = JsonConvert.SerializeObject(payload)
            Try
                ' Parse den JSON-String
                Dim jsonObj As JObject = JObject.Parse(requestBody)

                ' Überprüfe, ob das "images"-Feld existiert
                If jsonObj("images") IsNot Nothing Then
                    ' Setze den Wert des "images"-Abschnitts auf ["..."]
                    jsonObj("images") = JArray.Parse("[""...""]")
                End If

                ' Serialisiere das JSON-Objekt zurück in einen String
                Request_JSON = jsonObj.ToString()
            Catch ex As Exception
                ' Fehlerbehandlung
                Request_JSON = requestBody.Substring(0, Math.Min(requestBody.Length, 5000))
            End Try
        Else
            apiUrl = "http://" & SiticoneTextBox_host.Text & "/api/chat"
            Dim payload As New Dictionary(Of String, Object) From {
                {"model", model},
                {"stream", False}
            }

            'If Not String.IsNullOrEmpty(Image) Then
            '    payload("images") = New List(Of String) From {Image}    ' image
            'End If

            'If image_list.Count > 0 Then
            '    payload("images") = image_list
            'End If

            If messages.Count = 0 Then
                Dim newMessageSystem As New message()
                newMessageSystem.role = "system"
                newMessageSystem.content = SiticoneTextArea_system.Text
                messages.Add(newMessageSystem)
                SiticoneLabel_chat_clear.Text = "Chat Mem:: " & messages.Count.ToString
            End If
            Dim newMessageUser As New message()
            newMessageUser.role = "user"
            newMessageUser.content = prompt
            messages.Add(newMessageUser)
            SiticoneLabel_chat_clear.Text = "Chat Mem:: " & messages.Count.ToString

            If messages.Count > 0 Then
                payload("messages") = messages
            End If

            If think = True Then
                Select Case think_level
                    Case "false"
                        payload("think") = False
                    Case "true"
                        payload("think") = True
                    Case Else
                        payload("think") = think_level
                End Select
            End If

            ' Options-Dictionary
            Dim options As New Dictionary(Of String, Object)

            For Each optionString As String In My.Settings.option_list
                Dim values() As String = optionString.Split(New String() {"<|>"}, StringSplitOptions.None)
                If LCase(values(1)) = "true" Then
                    Select Case values(2)
                        '"string", "int", "float", "boolean"
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

            ' Nur wenn tatsächlich Optionen gesetzt wurden, fügen wir das "options"-Objekt hinzu
            If options.Count > 0 Then
                payload("options") = options
            End If

            ' JSON erzeugen
            requestBody = JsonConvert.SerializeObject(payload)
            Try
                ' Parse den JSON-String
                Dim jsonObj As JObject = JObject.Parse(requestBody)

                ' Überprüfe, ob das "images"-Feld existiert
                If jsonObj("images") IsNot Nothing Then
                    ' Setze den Wert des "images"-Abschnitts auf ["..."]
                    jsonObj("images") = JArray.Parse("[""...""]")
                End If

                ' Serialisiere das JSON-Objekt zurück in einen String
                Request_JSON = jsonObj.ToString()
            Catch ex As Exception
                ' Fehlerbehandlung
                Request_JSON = requestBody.Substring(0, Math.Min(requestBody.Length, 5000))
            End Try
            'If requestBody.Length > 5000 Then
            'Request_JSON = requestBody.Substring(0, 5000)
            'Else
            'Request_JSON = requestBody
            'End If
            ClearFileChips()
        End If



        If SiticoneToggleSwitch_test.Checked = False Then
            ' HTTP-Request absetzen
            Dim handler As New HttpClientHandler()
            handler.UseProxy = My.Settings.use_proxy  ' Erzwingt direkte Verbindung ohne Firmen-Proxy

            Using client As New HttpClient(handler)
                ' Timeout setzen (muss am client Objekt gesetzt werden)
                client.Timeout = TimeSpan.FromSeconds(Val(SiticoneTextBox_timeout.Text))

                Dim content As New StringContent(requestBody, Encoding.UTF8, "application/json")

                Try
                    Dim response As HttpResponseMessage = Await client.PostAsync(apiUrl, content, ct)

                    If response.IsSuccessStatusCode Then
                        Dim responseBody As String = Await response.Content.ReadAsStringAsync()
                        Response_JSON = responseBody

                        Dim json As JObject = JObject.Parse(responseBody)
                        Dim search_str As String = If(SiticoneDropdown_API.SelectedIndex = 0, "response", "message.content")

                        Dim extractedResponse As String = json.SelectToken(search_str)?.ToString()

                        If SiticoneDropdown_API.SelectedIndex = 1 Then
                            Dim newMessageAssistant As New message()
                            newMessageAssistant.role = "assistant"
                            newMessageAssistant.content = extractedResponse
                            messages.Add(newMessageAssistant)
                            SiticoneLabel_chat_clear.Text = "Chat Mem: " & messages.Count.ToString
                        End If

                        Try
                            extractedContext.Clear()
                            Dim think_search = If(SiticoneDropdown_API.SelectedIndex = 0, "thinking", "message.thinking")
                            extractedThinking = json.SelectToken(think_search)?.ToString()

                            Dim tempItems = json("context")?.ToObject(Of List(Of Integer))()
                            If tempItems IsNot Nothing Then
                                extractedContext.AddRange(tempItems)
                            End If
                            SiticoneLabel_last_context.Text = String.Format("Use Last Context ({0} Tokens)", extractedContext.Count)

                            timing_total_duration = json.SelectToken("total_duration")?.Value(Of Long)
                            timing_load_duration = json.SelectToken("load_duration")?.Value(Of Long)
                            timing_prompt_eval_count = json.SelectToken("prompt_eval_count")?.Value(Of Long)
                            timing_prompt_eval_duration = json.SelectToken("prompt_eval_duration")?.Value(Of Long)
                            timing_eval_count = json.SelectToken("eval_count")?.Value(Of Long)
                            timing_eval_duration = json.SelectToken("eval_duration")?.Value(Of Long)
                            SiticoneButton_timing.Enabled = True
                        Catch ex As Exception
                            SiticoneButton_timing.Enabled = False
                        End Try

                        Return If(extractedResponse, "Error: No result field found.")
                    Else
                        Return $"Error: {response.StatusCode} - {response.ReasonPhrase}"
                    End If
                Catch ex As TaskCanceledException
                    Return "Error: Request timed out (Client-side)."
                Catch ex As Exception
                    Return $"Error: {ex.Message}"
                End Try
            End Using
        Else
            Response_JSON = "Test Mode"
            Return Scintilla_response.Text
        End If

    End Function
    ' Die Funktion nimmt nun optional eine Marke entgegen (z.B. "export")
    Private Async Function InitializeWebView2(Optional ByVal anchor As String = "") As Task
        Try
            ' --- SCHRITT 1: Initialisierung nur, wenn noch nicht geschehen ---
            If WebView21.CoreWebView2 Is Nothing Then
                Dim userDataFolder As String = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "Ollama_Desktop",
                "WebView2_Data"
            )

                If Not Directory.Exists(userDataFolder) Then Directory.CreateDirectory(userDataFolder)

                Dim env = Await CoreWebView2Environment.CreateAsync(Nothing, userDataFolder)

                ' Das hier darf nur einmal pro Control-Lebenszeit aufgerufen werden
                Await WebView21.EnsureCoreWebView2Async(env)
            End If
            ' --------------------------------------------------------------------

            ' --- SCHRITT 2: Pfad prüfen und Navigation vorbereiten ---
            Dim appPath As String = AppContext.BaseDirectory
            Dim helpFilePath As String = Path.Combine(appPath, My.Settings.help_path)

            If File.Exists(helpFilePath) Then
                ' Tab aktivieren
                SiticoneTabControl_tab.SelectedTab = TabPage_responsehtml

                Dim fileUri As String = New Uri(helpFilePath).AbsoluteUri

                ' Prüfen: Sind wir schon auf der Seite? 
                ' Wenn ja, können wir direkt scrollen, ohne neu zu laden.
                If WebView21.Source IsNot Nothing AndAlso WebView21.Source.AbsoluteUri = fileUri Then
                    Await ScrollToAnchor(anchor)
                Else
                    ' Wenn neue Seite: Handler hinzufügen und navigieren
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

    ' Hilfsfunktion für das eigentliche JavaScript-Scrolling
    Private Async Function ScrollToAnchor(anchor As String) As Task
        If Not String.IsNullOrEmpty(anchor) Then
            Await Task.Delay(250) ' Kurze Pause, damit die Engine das DOM verarbeiten kann
            Dim script As String = $"document.getElementById('{anchor}')?.scrollIntoView({{behavior: 'smooth', block: 'start'}});"
            Await WebView21.ExecuteScriptAsync(script)
        End If
    End Function

    Private Async Function LoadModelsAsync() As Task
        Me.Cursor = Cursors.WaitCursor
        Try
            ' Verwende den funktionierenden Endpunkt "/api/tags"
            Dim apiUrl As String = "http://" & SiticoneTextBox_host.Text & "/api/tags"
            Using client As New HttpClient()
                Dim response As HttpResponseMessage = Await client.GetAsync(apiUrl)
                If response.IsSuccessStatusCode Then
                    Dim responseBody As String = Await response.Content.ReadAsStringAsync()

                    ' Parsen der JSON-Antwort
                    Dim json As JObject = JObject.Parse(responseBody)
                    Dim modelsArray As JArray = json("models")

                    ' --- ÄNDERUNG: Hier sortieren wir alphabetisch nach 'name' ---
                    ' Wir nutzen LINQ, um die Models nach dem Namen zu ordnen
                    Dim sortedModels = modelsArray.OrderBy(Function(m) m("name").ToString()).ToList()
                    ' -------------------------------------------------------------

                    SiticoneDropdown_model.Items.Clear()
                    model_info.Clear()

                    ' Jetzt iterieren wir über die sortierte Liste
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

    Private Sub SiticoneButton_file_Click(sender As Object, e As EventArgs) Handles SiticoneButton_file.Click
        ' Wir entfernen die Abfrage "If text_contents.Count = 0..." 
        ' damit der Dialog immer geöffnet werden kann.

        Dim openFileDialog As New OpenFileDialog

        ' Filter-Logik basierend auf der API-Auswahl
        If SiticoneDropdown_API.SelectedIndex = 0 Then
            openFileDialog.Filter = "Text Dateien (*.txt)|*.txt|PDF Datei (*.pdf)|*.pdf|JSON Datei (*.json)|*.json|Bild (*.jpg)|*.jpg|Bild (*.png)|*.png|Alle Dateien (*.*)|*.*"
        Else
            openFileDialog.Filter = "Text Dateien (*.txt)|*.txt|PDF Datei (*.pdf)|*.pdf|Alle Dateien (*.*)|*.*"
        End If

        openFileDialog.Multiselect = True

        If openFileDialog.ShowDialog = DialogResult.OK Then
            For Each filePath In openFileDialog.FileNames
                Dim fileExtension = Mid(LCase(Path.GetExtension(filePath)), 2)
                Dim fileName = Path.GetFileName(filePath)

                Try
                    Select Case fileExtension
                        Case "jpg", "png"
                            ' --- BILDER HINZUFÜGEN ---
                            Dim imageBytes = File.ReadAllBytes(filePath)
                            image_contents.Add(Convert.ToBase64String(imageBytes))

                        Case "txt"
                            ' --- TEXT DATEIEN HINZUFÜGEN ---
                            Dim file_content = File.ReadAllText(filePath)
                            Dim tContent As New text_content_def With {
                            .text = file_content,
                            .fileName = fileName,
                            .fileExtention = fileExtension
                        }
                            text_contents.Add(tContent)

                        Case "pdf"
                            ' --- PDF DATEIEN HINZUFÜGEN ---
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
                            ' --- JSON DATEIEN HINZUFÜGEN ---
                            Dim file_content = File.ReadAllText(filePath)
                            Try
                                Dim jsonObj = JsonConvert.DeserializeObject(Of Object)(file_content)
                                file_content = JsonConvert.SerializeObject(jsonObj, Formatting.None)
                            Catch
                                ' Bei Fehler Rohtext lassen
                            End Try
                            Dim tContent As New text_content_def With {
                            .text = file_content,
                            .fileName = fileName,
                            .fileExtention = fileExtension
                        }
                            text_contents.Add(tContent)

                        Case Else
                            ' --- ANDERE DATEIEN ---
                            Dim file_content = File.ReadAllText(filePath)
                            Dim tContent As New text_content_def With {
                            .text = file_content,
                            .fileName = fileName,
                            .fileExtention = fileExtension
                        }
                            text_contents.Add(tContent)
                    End Select

                    ' Erstellt den visuellen Chip im FlowPanel
                    AddFileChip(filePath, fileExtension)

                Catch ex As Exception
                    MessageBox.Show("Fehler beim Laden der Datei '" & fileName & "': " & ex.Message)
                End Try
            Next

            ' UI sichtbar machen und Layout aktualisieren
            SiticoneFlowPanel_prompt_filecontent.Visible = True
            SiticoneTextArea_prompt_TextChanged(Nothing, Nothing)
        End If
    End Sub

    Private Sub ClearFileChips()
        ' Alles leeren
        text_contents.Clear()
        image_contents.Clear()
        SiticoneFlowPanel_prompt_filecontent.Controls.Clear()
        SiticoneFlowPanel_prompt_filecontent.Visible = False
        SiticoneTextArea_prompt_TextChanged(Nothing, Nothing)
    End Sub


    Private Sub AddFileChip(filePath As String, ext As String)
        ' --- 1. DER CHIP-CONTAINER (SiticonePanel) ---
        Dim chip As New SiticonePanel()
        With chip
            .Size = New Size(210, 64)
            ' Eigenschaft aus image_1236cf.png
            .FillColor = Color.FromArgb(235, 237, 240)
            .BorderThickness = 0 ' Aus image_1236cf.png
            .ShowBorder = False ' Verhindert Rahmen wie in image_1236cf.png
            .Margin = New Padding(5)
            .Tag = filePath
        End With

        ' --- 2. DAS ICON (SiticonePictureBox) ---
        Dim picIcon As New SiticonePictureBox()
        With picIcon
            .Size = New Size(48, 48)
            .Location = New Point(8, 8)
            .SizeMode = PictureBoxSizeMode.Zoom
            .BackColor = Color.Transparent
            ' Icon-Logik bleibt gleich
            Select Case ext.ToLower()
                Case "txt" : .Image = Resource_pic.icon_txt
                Case "pdf" : .Image = Resource_pic.icon_pdf
                Case "json" : .Image = Resource_pic.icon_json
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

        ' --- 3. DER DATEINAME (Standard Label) ---
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

        ' --- 4. DER LÖSCH-BUTTON (SiticoneButton) ---
        ' Korrektur basierend auf image_227e20.png, image_227e66.png und image_227ec3.png
        Dim btnDelete As New SiticoneButton()
        With btnDelete
            .Size = New Size(24, 24)
            .Location = New Point(180, 5)
            .Text = "x"
            ' In image_227e20.png heißt es ButtonBackColor statt FillColor
            .ButtonBackColor = Color.Transparent
            ' In image_227ec3.png heißt es TextColor statt ForeColor
            .TextColor = Color.Gray
            .Font = New Font("Arial", 12, FontStyle.Bold)
            ' In image_227e20.png heißt es BorderWidth statt BorderThickness
            .BorderWidth = 0
            ' Hover-Eigenschaften aus image_227e66.png
            .HoverBackColor = Color.FromArgb(255, 200, 200)
            .HoverTextColor = Color.Red
            ' CornerRadius einzeln setzen laut image_227e20.png
            .CornerRadiusTopLeft = 12
            .CornerRadiusTopRight = 12
            .CornerRadiusBottomLeft = 12
            .CornerRadiusBottomRight = 12
            .Cursor = Cursors.Hand
        End With

        ' --- 5. LÖSCH-LOGIK (Angepasst) ---
        ' ... (Code für btnDelete Setup) ...

        AddHandler btnDelete.Click, Sub(s, ev)
                                        SiticoneFlowPanel_prompt_filecontent.Controls.Remove(chip)

                                        ' Listen leeren
                                        image_contents.Clear() ' Ggf. anpassen, dass nur das spezifische Item gelöscht wird?
                                        text_contents.Clear()

                                        ' Sichtbarkeit prüfen
                                        If SiticoneFlowPanel_prompt_filecontent.Controls.Count = 0 Then
                                            SiticoneFlowPanel_prompt_filecontent.Visible = False
                                        End If

                                        ' HIER: Layout neu berechnen
                                        UpdatePromptLayout()
                                    End Sub

        ' --- ZUSAMMENBAUEN & HINZUFÜGEN ---
        chip.Controls.Add(picIcon)
        chip.Controls.Add(lblName)
        chip.Controls.Add(btnDelete)

        SiticoneFlowPanel_prompt_filecontent.Controls.Add(chip)

        ' WICHTIG: Panel sichtbar machen, falls es das erste Element ist
        If SiticoneFlowPanel_prompt_filecontent.Controls.Count > 0 Then
            SiticoneFlowPanel_prompt_filecontent.Visible = True
        End If

        ' HIER: Layout neu berechnen (nachdem hinzugefügt wurde)
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
            SiticoneChip_model_info_Tools.IsSelected = model_info_get.tools
            SiticoneChip_model_info_Thinking.IsSelected = model_info_get.thinking
            SiticoneChip_model_info_Embedding.IsSelected = model_info_get.embedding
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
            SiticoneChip_model_info_Tools.IsSelected = False
            SiticoneChip_model_info_Thinking.IsSelected = False
            SiticoneChip_model_info_Embedding.IsSelected = False
            SiticoneChip_model_info_Context.IsSelected = False
            SiticoneChip_model_info_Context.Text = "context: ?"
            SiticoneChip_model_info_Context.Refresh()
        End If
        Try
            ' Verwende den funktionierenden Endpunkt "/api/tags"
            Dim apiUrl As String = "http://" & SiticoneTextBox_host.Text & "/api/show"
            Using client As New HttpClient()
                Dim requestBody As String = "{ ""model"": """ & model_name & """}"
                Dim content As New StringContent(requestBody, Encoding.UTF8, "application/json")
                Dim response As HttpResponseMessage = Await client.PostAsync(apiUrl, content)

                If response.IsSuccessStatusCode Then
                    Dim minifiedJson As String = Await response.Content.ReadAsStringAsync()
                    ' In ein Objekt deserialisieren (optional, aber sicherer)
                    Dim jsonObject = JsonConvert.DeserializeObject(minifiedJson)
                    ' In „Pretty“-Format serialisieren
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
        SiticoneLabel_last_context.Text = String.Format("Use Last Context ({0} Tokens)", extractedContext.Count)
    End Sub

    ' Extrahiert Code-Blöcke aus einem Markdown-String
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
                    ' Codeblock-Ende
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
                    ' Codeblock-Start
                    inCodeBlock = True
                    Dim codeLine As String = line.Trim()
                    currentLanguage = If(codeLine.Length > 3, codeLine.Substring(3).Trim(), "")
                End If
            ElseIf inCodeBlock Then
                currentCode.Add(line)
            End If
        Next
        Return codeBlocks
    End Function

    Function DeleteSpaces(ByVal code As String) As String
        Dim zeilen As String() = code.Split({vbCrLf, vbLf}, StringSplitOptions.None)
        Dim minIndent As Integer = Integer.MaxValue

        ' Bestimme die minimale Einrückung
        For Each zeile In zeilen
            Dim trimZeile As String = zeile.TrimStart()
            If trimZeile.Length > 0 Then
                Dim indent As Integer = zeile.Length - trimZeile.Length
                minIndent = Math.Min(minIndent, indent)
            End If
        Next

        ' Falls keine Einrückung gefunden wurde, gib den Code unverändert zurück
        If minIndent = Integer.MaxValue Then Return code

        ' Entferne die minimale Einrückung aus allen Zeilen
        Dim result As New Text.StringBuilder()
        For Each zeile In zeilen
            If zeile.Length >= minIndent Then
                result.AppendLine(zeile.Substring(minIndent))
            Else
                result.AppendLine(zeile)
            End If
        Next

        Return result.ToString().TrimEnd() ' Entfernt eventuell überschüssige Leerzeilen
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
            ' 1. Lese den Programm-Code aus dem Scintilla_code_block
            Dim pythonCode As String = Scintilla_code_block.Text

            ' 2. Speichere den Code in einer temporären Datei
            Dim tempFilePath As String = Path.Combine(Path.GetTempPath(), run_parameter.file)
            SiticoneLabel_runpath.Text = "path: " & tempFilePath
            File.WriteAllText(tempFilePath, pythonCode)

            ' 3. Führe das Python-Skript mit python.exe aus
            Dim psi As New ProcessStartInfo()
            psi.FileName = run_parameter.exe  ' Stelle sicher, dass diese Software im PATH ist
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

                ' 4. Lese die Ausgabe und Fehler
                If SiticoneToggleSwitch_UseShellExecute.Checked = False Then
                    ' Asynchrones Lesen der Ausgabe und Fehler, falls ein Timeout erforderlich ist
                    Dim outputTask As Task(Of String) = Task.Run(Function() process.StandardOutput.ReadToEnd())
                    Dim errorTask As Task(Of String) = Task.Run(Function() process.StandardError.ReadToEnd())

                    ' Timeout setzen
                    Dim timeout As Integer = 10000 ' 5000 Millisekunden (5 Sekunden)

                    ' Überprüfen, ob der Prozess rechtzeitig beendet wird
                    If process.WaitForExit(timeout) Then
                        ' Prozess hat rechtzeitig beendet, lese die Streams aus
                        output = outputTask.Result
                        errors = errorTask.Result
                    Else
                        ' Timeout erreicht, Prozess beenden
                        process.Kill()
                        output = outputTask.Result
                        errors = errorTask.Result & vbCrLf & "The process was terminated due to a timeout error."
                    End If
                Else
                    ' Warte normal auf Beendigung, wenn UseShellExecute = True
                    process.WaitForExit()
                End If

                ' 5. Zeige die Ausgabe in einer RichTextBox oder einem anderen Control
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
            ' Temporäre Datei erstellen
            Dim tempFilePath As String = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName() & ".py")
            File.WriteAllText(tempFilePath, script)

            ' JSON-Argument korrekt escapen
            Dim escapedJson As String = jsonArgument.Replace("""", "\""")

            ' Prozess vorbereiten
            Dim psi As New ProcessStartInfo()
            psi.FileName = "python"
            psi.Arguments = $"""{tempFilePath}"" ""{escapedJson}"""
            psi.UseShellExecute = False
            psi.RedirectStandardOutput = True
            psi.RedirectStandardError = True
            psi.CreateNoWindow = True
            ' Prozess starten
            Using process As Process = Process.Start(psi)
                Dim output As String = process.StandardOutput.ReadToEnd()
                Dim errorOutput As String = process.StandardError.ReadToEnd()
                process.WaitForExit()

                ' Temporäre Datei löschen
                File.Delete(tempFilePath)

                ' Fehlerbehandlung
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
            ' Versuche, ein JsonDocument daraus zu erstellen
            Using JsonDocument.Parse(strInput)
                ' Wenn kein Exception geworfen wird, ist es valide
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub SiticoneButton_chat_clear_Click(sender As Object, e As EventArgs) Handles SiticoneButton_chat_clear.Click
        messages.Clear()
        chat_mem = ""
        SiticoneLabel_chat_clear.Text = "Chat Mem:: " & messages.Count.ToString
    End Sub

    Private Sub SiticoneDropdown_API_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SiticoneDropdown_API.SelectedIndexChanged
        If SiticoneDropdown_API.SelectedIndex = 0 Then
            SiticoneButton_chat_clear.Enabled = False
            SiticoneButton_switch_chat.Enabled = True
            SiticoneButton_screenshot.Enabled = True
        Else
            SiticoneButton_chat_clear.Enabled = True
            SiticoneButton_switch_chat.Enabled = False
            SiticoneButton_screenshot.Enabled = False
        End If
    End Sub

    Private Async Sub WebView21_NavigationCompleted(sender As Object, e As CoreWebView2NavigationCompletedEventArgs) Handles WebView21.NavigationCompleted
        If SiticoneDropdown_model.SelectedIndex = 0 Then
            Await WebView21.ExecuteScriptAsync("window.scrollTo(0, 0);") 'an den Anfang bei Genarate
        Else
            Await WebView21.ExecuteScriptAsync("window.scrollTo(0, document.body.scrollHeight);") 'an das Ende bei Chat
        End If
    End Sub

    Private Async Sub SiticoneButton_HTMLtoPDF_Click(sender As Object, e As EventArgs) Handles SiticoneButton_HTMLtoPDF.Click
        Using saveFileDialog As New SaveFileDialog
            ' Filter enthält alle gewünschten Dateiformate
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf|Markdown files (*.md)|*.md|HTML files (*.html)|*.html"
            saveFileDialog.Title = "Save as PDF, Markdown or HTML"
            saveFileDialog.FileName = "output.pdf"  ' Standardmäßig PDF als Dateiendung

            If saveFileDialog.ShowDialog = DialogResult.OK Then
                Dim filePath = saveFileDialog.FileName
                Dim ext = Path.GetExtension(filePath).ToLower

                Select Case ext
                    Case ".pdf"
                        ' Hier wird das PDF exportiert
                        Dim printSettings = WebView21.CoreWebView2.Environment.CreatePrintSettings
                        printSettings.ShouldPrintBackgrounds = True 'Aktiviert den Druck von Hintergrundfarben und -bildern
                        printSettings.ColorMode = CoreWebView2PrintColorMode.Color
                        Await WebView21.CoreWebView2.PrintToPdfAsync(filePath, printSettings)
                    Case ".html"
                        ' JavaScript ausführen, um den HTML-Inhalt der Seite abzurufen:
                        Dim result = Await WebView21.CoreWebView2.ExecuteScriptAsync("document.documentElement.outerHTML;")
                        ' Parsing des JSON-kodierten Rückgabewertes mithilfe von JsonDocument:
                        Dim htmlContent = ""
                        Using doc = JsonDocument.Parse(result)
                            htmlContent = doc.RootElement.GetString
                        End Using
                        ' Den HTML-Code in die ausgewählte Datei schreiben:
                        File.WriteAllText(saveFileDialog.FileName, htmlContent)
                    Case ".md"
                        ' Speichern des Textinhalts in die gewählte Datei:
                        File.WriteAllText(filePath, Scintilla_response.Text)
                    Case Else
                        ' Optional: Fehlermeldung, falls ein unbekannter Dateityp ausgewählt wird.
                End Select
            End If
        End Using
    End Sub

    Private Sub SiticoneTextArea_prompt_TextChanged(sender As Object, e As EventArgs) Handles SiticoneTextArea_prompt.TextChanged
        UpdatePromptLayout()
        If SiticoneTextArea_prompt.TextLength = 0 Then
            SiticonePlayPauseButton_request.Enabled = False
        Else
            SiticonePlayPauseButton_request.Enabled = True
        End If
    End Sub

    Private Sub UpdatePromptLayout()
        ' --- 1. EINSTELLUNGEN ---
        Dim minTextBoxHeight = 36
        Dim maxTextBoxHeight = 200
        Dim paddingAroundControls = 20

        ' --- 2. TEXTHÖHE BERECHNEN ---
        Dim textSize = TextRenderer.MeasureText(SiticoneTextArea_prompt.Text,
                                            SiticoneTextArea_prompt.Font,
                                            New Size(SiticoneTextArea_prompt.Width - 10, Integer.MaxValue),
                                            TextFormatFlags.WordBreak)
        Dim calculatedHeight = textSize.Height + 15

        ' --- 3. TEXTAREA-HÖHE SETZEN ---
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

        ' --- 4. GESAMTHÖHE DES ÄUẞEREN PANELS BERECHNEN ---
        Dim currentFileHeight = 0
        ' Sicherstellen, dass das FlowPanel seine Layout-Berechnung abgeschlossen hat,
        ' bevor wir die Höhe abrufen (wichtig bei AutoSize)
        If SiticoneFlowPanel_prompt_filecontent.Visible Then
            ' FIX: Wir fragen das Panel: "Wie hoch musst du sein, um alle Controls bei deiner aktuellen Breite anzuzeigen?"
            ' Das ignoriert die aktuelle (evtl. falsche) Höhe und berechnet sie frisch.
            Dim preferredSize As Size = SiticoneFlowPanel_prompt_filecontent.GetPreferredSize(New Size(SiticoneFlowPanel_prompt_filecontent.Width, 0))
            currentFileHeight = preferredSize.Height
        End If

        SiticonePanel_prompt.Height = currentFileHeight +
                                  SiticoneTextArea_prompt.Height +
                                  SiticonePanel_prompt_action.Height +
                                  paddingAroundControls

        ' --- 5. LAYOUT ERZWINGEN ---
        SiticonePanel_prompt.PerformLayout()
        Me.PerformLayout()
    End Sub

    Private Sub dgv_option_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_option.CellValueChanged
        Dim dgv = CType(sender, DataGridView)

        ' Aktualisiere die StringCollection mit den neuen Werten
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
                    ' Optional: Fehlerbehandlung hinzufügen
                End Try
            End If
        Next

        ' Speichere die aktualisierte StringCollection in den Einstellungen
        My.Settings.option_list = newOptionList
        My.Settings.Save()
    End Sub

    Private Sub dgv_option_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgv_option.RowsRemoved
        Dim dgv = CType(sender, DataGridView)

        ' Aktualisiere die StringCollection mit den neuen Werten
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
                    ' Optional: Fehlerbehandlung hinzufügen
                End Try
            End If
        Next

        ' Speichere die aktualisierte StringCollection in den Einstellungen
        My.Settings.option_list = newOptionList
        My.Settings.Save()
    End Sub

    Private Sub dvg_execute_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dvg_execute.CellValueChanged
        Dim dgv = CType(sender, DataGridView)

        ' Aktualisiere die StringCollection mit den neuen Werten
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
                    ' Optional: Fehlerbehandlung hinzufügen
                End Try
            End If
        Next

        ' Speichere die aktualisierte StringCollection in den Einstellungen
        My.Settings.run_execute_list = newExecuteList
        My.Settings.Save()
    End Sub

    Private Sub dvg_execute_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dvg_execute.RowsRemoved
        Dim dgv = CType(sender, DataGridView)

        ' Aktualisiere die StringCollection mit den neuen Werten
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
                    ' Optional: Fehlerbehandlung hinzufügen
                End Try
            End If
        Next

        ' Speichere die aktualisierte StringCollection in den Einstellungen
        My.Settings.run_execute_list = newExecuteList
        My.Settings.Save()
    End Sub

    Private Sub SiticoneButton_save_parameter_Click(sender As Object, e As EventArgs) Handles SiticoneButton_save_parameter.Click
        ' Create a SaveFileDialog
        Dim saveFileDialog As New SaveFileDialog
        saveFileDialog.Filter = "JSON files (*.model.json)|*.model.json|All files (*.*)|*.*"
        saveFileDialog.Title = "Save Model Parameter to JSON File"

        ' Show the dialog and check if the user clicked OK
        If saveFileDialog.ShowDialog = DialogResult.OK Then
            ' Get the content from the controls
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

            ' Create an object to hold the data
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

            ' Serialize the object to JSON
            Dim json = JsonConvert.SerializeObject(data, Formatting.Indented)

            ' Save the JSON to the selected file
            File.WriteAllText(saveFileDialog.FileName, json)
        End If
    End Sub

    Private Sub SiticoneButton_load_parameter_Click(sender As Object, e As EventArgs) Handles SiticoneButton_load_parameter.Click
        ' Create an OpenFileDialog
        Dim openFileDialog As New OpenFileDialog
        openFileDialog.Filter = "JSON files (*.model.json)|*.model.json|All files (*.*)|*.*"
        openFileDialog.Title = "Load Model Parameter from JSON File"

        ' Show the dialog and check if the user clicked OK
        If openFileDialog.ShowDialog = DialogResult.OK Then
            load_model(openFileDialog.FileName)
        End If
    End Sub

    Private Sub load_model(setting_path As String)
        If File.Exists(setting_path) Then
            ' Read the JSON from the selected file
            Dim json = File.ReadAllText(setting_path)

            ' Deserialize the JSON to an object
            Dim data = JObject.Parse(json)

            Try
                ' Load the content into the controls
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
        ' Create a SaveFileDialog
        Dim saveFileDialog As New SaveFileDialog
        saveFileDialog.Filter = "JSON files (*.code.json)|*.code.json|All files (*.*)|*.*"
        saveFileDialog.Title = "Save Execute Parameter to JSON File"

        ' Show the dialog and check if the user clicked OK
        If saveFileDialog.ShowDialog = DialogResult.OK Then
            ' Get the content from the controls

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

            ' Create an object to hold the data
            Dim data As New Dictionary(Of String, Object) From {
                {"execute_parameter", dataGridViewContent}
            }

            ' Serialize the object to JSON
            Dim json = JsonConvert.SerializeObject(data, Formatting.Indented)

            ' Save the JSON to the selected file
            File.WriteAllText(saveFileDialog.FileName, json)
        End If
    End Sub

    Private Sub SiticoneButton_load_execute_Click(sender As Object, e As EventArgs) Handles SiticoneButton_load_execute.Click
        ' Create an OpenFileDialog
        Dim openFileDialog As New OpenFileDialog
        openFileDialog.Filter = "JSON files (*.code.json)|*.code.json|All files (*.*)|*.*"
        openFileDialog.Title = "Load Execute Parameter from JSON File"

        ' Show the dialog and check if the user clicked OK
        If openFileDialog.ShowDialog = DialogResult.OK Then
            load_execute(openFileDialog.FileName)
        End If
    End Sub

    Private Sub load_execute(setting_path As String)
        If File.Exists(setting_path) Then
            ' Read the JSON from the selected file
            Dim json = File.ReadAllText(setting_path)

            Dim data = JObject.Parse(json)

            Try
                ' Deserialize the JSON to an object

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
        ' Create a SaveFileDialog
        Dim saveFileDialog As New SaveFileDialog
        saveFileDialog.Filter = "JSON files (*.tools.json)|*.tools.json|All files (*.*)|*.*"
        saveFileDialog.Title = "Save Tools Parameter to JSON File"

        ' Show the dialog and check if the user clicked OK
        If saveFileDialog.ShowDialog = DialogResult.OK Then
            ' Get the content from the controls
            Dim textAreaContent = SiticoneTextArea_system.Text
            Dim dataGridViewContent As New List(Of Dictionary(Of String, Object))

            ' Create an object to hold the data
            Dim data As New Dictionary(Of String, Object) From {
                {"tools_use", SiticoneToggleSwitch_tools.Checked},
                {"tools_system_prompt", SiticoneTextArea_Tools_system.Text},
                {"tools_json", Scintilla_Tools_Json.Text},
                {"tools_python_code", Scintilla_Tools_pythoncode.Text}
            }

            ' Serialize the object to JSON
            Dim json = JsonConvert.SerializeObject(data, Formatting.Indented)

            ' Save the JSON to the selected file
            File.WriteAllText(saveFileDialog.FileName, json)
        End If
    End Sub

    Private Sub SiticoneButton_load_tools_Click(sender As Object, e As EventArgs) Handles SiticoneButton_load_tools.Click
        ' Create an OpenFileDialog
        Dim openFileDialog As New OpenFileDialog
        openFileDialog.Filter = "JSON files (*.tools.json)|*.tools.json|All files (*.*)|*.*"
        openFileDialog.Title = "Load Tools Parameter from JSON File"

        ' Show the dialog and check if the user clicked OK
        If openFileDialog.ShowDialog = DialogResult.OK Then
            load_tools(openFileDialog.FileName)
        End If
    End Sub

    Private Sub load_tools(setting_path As String)
        If File.Exists(setting_path) Then
            ' Read the JSON from the selected file
            Dim json = File.ReadAllText(setting_path)

            ' Deserialize the JSON to an object
            Dim data = JObject.Parse(json)

            Try
                ' Load the content into the controls
                SiticoneToggleSwitch_tools.Checked = data("tools_use")
                SiticoneTextArea_Tools_system.Text = data("tools_system_prompt").ToString
                Scintilla_Tools_Json.Text = data("tools_json").ToString
                Scintilla_Tools_pythoncode.Text = data("tools_python_code").ToString
            Catch ex As Exception
                MessageBox.Show("Error loading parameters: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub SiticoneButton_save_rag_Click(sender As Object, e As EventArgs) Handles SiticoneButton_save_rag.Click
        ' Create a SaveFileDialog
        Dim saveFileDialog As New SaveFileDialog
        saveFileDialog.Filter = "JSON files (*.rag.json)|*.rag.json|All files (*.*)|*.*"
        saveFileDialog.Title = "Save RAG Parameter to JSON File"

        ' Show the dialog and check if the user clicked OK
        If saveFileDialog.ShowDialog = DialogResult.OK Then
            ' Get the content from the controls
            Dim textAreaContent = SiticoneTextArea_system.Text
            Dim dataGridViewContent As New List(Of Dictionary(Of String, Object))

            ' Create an object to hold the data
            Dim data As New Dictionary(Of String, Object) From {
                {"rag_use", SiticoneToggleSwitch_ragtools.Checked},
                {"rag_system_prompt", SiticoneTextArea_Rag_system.Text},
                {"rag_json", Scintilla_Rag_Json.Text}
            }

            ' Serialize the object to JSON
            Dim json = JsonConvert.SerializeObject(data, Formatting.Indented)

            ' Save the JSON to the selected file
            File.WriteAllText(saveFileDialog.FileName, json)
        End If
    End Sub

    Private Sub SiticoneButton_load_rag_Click(sender As Object, e As EventArgs) Handles SiticoneButton_load_rag.Click
        ' Create an OpenFileDialog
        Dim openFileDialog As New OpenFileDialog
        openFileDialog.Filter = "JSON files (*.rag.json)|*.rag.json|All files (*.*)|*.*"
        openFileDialog.Title = "Load RAG Parameter from JSON File"

        ' Show the dialog and check if the user clicked OK
        If openFileDialog.ShowDialog = DialogResult.OK Then
            load_rag(openFileDialog.FileName)
        End If
    End Sub

    Private Sub load_rag(setting_path As String)
        If File.Exists(setting_path) Then
            ' Read the JSON from the selected file
            Dim json = File.ReadAllText(setting_path)

            ' Deserialize the JSON to an object
            Dim data = JObject.Parse(json)

            Try
                ' Load the content into the controls
                SiticoneToggleSwitch_ragtools.Checked = data("rag_use")
                SiticoneTextArea_Rag_system.Text = data("rag_system_prompt").ToString
                Scintilla_Rag_Json.Text = data("rag_json").ToString
            Catch ex As Exception
                MessageBox.Show("Error loading parameters: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub SiticoneButton_switch_chat_Click(sender As Object, e As EventArgs) Handles SiticoneButton_switch_chat.Click
        If request_mem <> "" And response_mem <> "" Then
            SiticoneDropdown_API.SelectedIndex = 1
            Dim newMessageSystem As New message()
            newMessageSystem.role = "system"
            newMessageSystem.content = SiticoneTextArea_system.Text
            messages.Add(newMessageSystem)
            SiticoneLabel_chat_clear.Text = "Chat Mem:: " & messages.Count.ToString
            Dim newMessageUser As New message()
            newMessageUser.role = "user"
            newMessageUser.content = request_mem
            messages.Add(newMessageUser)
            SiticoneLabel_chat_clear.Text = "Chat Mem:: " & messages.Count.ToString
            Dim newMessageAssistant As New message()
            newMessageAssistant.role = "assistant"
            newMessageAssistant.content = response_mem
            messages.Add(newMessageAssistant)
            SiticoneLabel_chat_clear.Text = "Chat Mem: " & messages.Count.ToString
        End If
    End Sub

    Private Sub SiticoneButton_resp_clp_Click(sender As Object, e As EventArgs) Handles SiticoneButton_resp_clp.Click
        'ins die Zwischenablage kopieren
        Clipboard.SetText(tools_Response_mem)
    End Sub

    Public Sub OpenSnipToolByUri()
        Dim psi As New ProcessStartInfo("ms-screenclip:") With {
            .UseShellExecute = True
        }
        Process.Start(psi)
    End Sub

    ' Wartet asynchron bis ein Bild in der Zwischenablage liegt oder ein Timeout erreicht ist.
    ' Gibt das Bild zurück (oder Nothing bei Timeout/Abbruch).
    Public Async Function WaitForClipboardImageAsync(timeout As TimeSpan, Optional pollInterval As TimeSpan = Nothing, Optional ct As CancellationToken = Nothing) As Task(Of Image)

        If pollInterval = Nothing OrElse pollInterval <= TimeSpan.Zero Then
            pollInterval = TimeSpan.FromMilliseconds(100)
        End If

        Dim sw = Stopwatch.StartNew()

        While sw.Elapsed < timeout AndAlso Not ct.IsCancellationRequested
            Try
                If Clipboard.ContainsImage() Then
                    ' Optional: Direkt holen, damit wir einen stabilen Snapshot haben
                    Return Clipboard.GetImage()
                End If
            Catch
                ' Ignorieren (z.B. wenn gerade kein Zugriff auf die Zwischenablage möglich ist)
            End Try

            ' Sehr wichtig: yielden, damit die UI weiter reagiert
            Await Task.Delay(pollInterval, ct)
        End While

        Return Nothing
    End Function


    Private Async Sub SiticoneButton_screenshot_Click(sender As Object, e As EventArgs) Handles SiticoneButton_screenshot.Click
        WindowState = FormWindowState.Minimized
        Try
            Clipboard.Clear
        Catch
            ' notfalls ignorieren
        End Try

        OpenSnipToolByUri ' öffnet die Windows-Snipping-UI

        ' 45s warten, dabei UI nicht blockieren
        Dim img = Await WaitForClipboardImageAsync(TimeSpan.FromSeconds(45))

        If img IsNot Nothing Then
            ' Falls deine Funktion direkt aus der Zwischenablage liest,
            ' kannst du stattdessen img übergeben, um Race Conditions zu vermeiden:
            import_clp_image() ' oder: import_clp_image_from_image(img)
        Else
            ' Optional: Nutzer informieren, dass kein Bild kam
            MessageBox.Show("No screenshot found in the clipboard.")
        End If
        WindowState = FormWindowState.Normal
        Activate()
        BringToFront()
        Application.DoEvents()
        UpdatePromptLayout()
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
        Debug.Print("")
    End Sub

    Public Function GetModelInfo(model_name As String) As ModelInfo
        ' Nur den Modellnamen vor dem Doppelpunkt extrahieren
        Dim key As String = model_name.Split(":"c)(0).Trim().ToLower()

        ' Prüfen, ob es den Eintrag gibt
        If ModelInfo_dic.ContainsKey(key) Then
            Return ModelInfo_dic(key)
        Else
            Return Nothing
        End If
    End Function

    Private Sub SiticoneButton_ragpath_Click(sender As Object, e As EventArgs) Handles SiticoneButton_ragpath.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Text files (*.txt)|*.txt|PDF files (*.pdf)|*.pdf|All files (*.*)|*.*"
        openFileDialog.Multiselect = False

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath = openFileDialog.FileName
            Dim fileExtension As String = Mid(LCase(System.IO.Path.GetExtension(filePath)), 2)
            Dim fileName As String = System.IO.Path.GetFileName(filePath)
            Dim file_content As String = ""

            Select Case fileExtension
                Case "txt"
                    file_content = File.ReadAllText(filePath)

                Case "pdf"
                    Dim sb As New Text.StringBuilder()
                    Using Pdfdoc = PdfDocument.Open(filePath)
                        For Each page In Pdfdoc.GetPages()
                            sb.AppendLine(page.Text & vbLf)
                        Next
                    End Using
                    file_content = sb.ToString()

                Case Else
                    file_content = File.ReadAllText(filePath)
            End Select

            ' Bestehende Variablen setzen
            rag_content.text = file_content
            rag_content.fileName = fileName
            rag_content.fileExtention = fileExtension
            SiticoneTextBox_ragpath.Text = filePath

            ' Dokument indexieren für schnelle Wortsuche
            documentIndex.IndexDocument(file_content)
            Dim sentenece_n = documentIndex.GetAllSentences()
            SiticoneLabel_SentencesCountVal.Text = sentenece_n.Count.ToString

        End If
    End Sub

    ' JSON parsen mit Newtonsoft.Json (Json.NET)
    ' Benötigt: Imports Newtonsoft.Json
    ' Benötigt: Imports Newtonsoft.Json.Linq
    Private Sub ProcessLLMResponse(jsonResponse As String, Optional delta As Integer = 0)
        Try
            ' JSON parsen
            Dim jsonObj As JObject = JObject.Parse(jsonResponse)

            ' Words-Array extrahieren
            Dim wordsToken As JToken = jsonObj("arguments")("words")

            If wordsToken IsNot Nothing AndAlso wordsToken.Type = JTokenType.Array Then
                Dim wordsArray As JArray = DirectCast(wordsToken, JArray)

                ' Alle Treffer sammeln
                'Dim allResults As New List(Of SentenceData)()

                ' Jedes Wort durchsuchen
                For Each wordToken In wordsArray
                    Dim searchWord As String = wordToken.ToString()
                    'Console.WriteLine($"Suche nach: {searchWord}")

                    Dim results = documentIndex.SearchAndIncrementHits(searchWord, delta)
                    'allResults.AddRange(results)

                    'Console.WriteLine($"  -> {results.Count} Sätze gefunden")
                Next
            End If

        Catch ex As Exception
            MessageBox.Show("Error parsing the JSON: " & ex.Message)
        End Try
    End Sub

    Private Sub SiticoneButton_resp_clp_rag_Click(sender As Object, e As EventArgs) Handles SiticoneButton_resp_clp_rag.Click
        'ins die Zwischenablage kopieren
        Clipboard.SetText(tools_Response_mem)
    End Sub

    Private Sub SiticoneButton_show_thinking_Click(sender As Object, e As EventArgs) Handles SiticoneButton_show_thinking.Click
        ' 1. Buttons erstellen
        Dim btnOk = TaskDialogButton.OK
        Dim btnCopy As New TaskDialogButton("Copy to Clipboard")

        ' 2. Handler für den Kopier-Button
        AddHandler btnCopy.Click, Sub(s, args)
                                      If Not String.IsNullOrEmpty(extractedThinking) Then
                                          Clipboard.SetText(extractedThinking)
                                          ' Optional: args.AllowClose = False (Dialog offen lassen)
                                      End If
                                  End Sub

        ' 3. Page konfigurieren (ohne .Buttons im Initialisierer!)
        Dim page As New TaskDialogPage With {
        .Caption = "Ollama Desktop",
        .Heading = "Thinking Response",
        .Text = "The model's thought process (thinking block):",
        .Expander = New TaskDialogExpander With {
            .Text = extractedThinking,
            .Expanded = True
        }
    }

        ' 4. Buttons zur Collection hinzufügen (Das löst den Fehler)
        page.Buttons.Add(btnOk)
        page.Buttons.Add(btnCopy)

        ' 5. Dialog anzeigen
        TaskDialog.ShowDialog(page)
    End Sub

    Private Sub SiticoneButton_show_licence_Click(sender As Object, e As EventArgs) Handles SiticoneButton_show_licence.Click
        Dim page As New TaskDialogPage With {
            .Caption = "Ollama Desktop",
            .Heading = "License",
            .Text = SiticoneDropdown_model.SelectedItem & ":",
            .Expander = New TaskDialogExpander With {
                .Text = extractedLicense,
                .Expanded = True ' Text ist standardmäßig eingeklappt
            }
        }
        ' Button explizit hinzufügen statt über den Initialisierer
        page.Buttons.Add(TaskDialogButton.OK)
        TaskDialog.ShowDialog(page)
    End Sub

    Private Sub SiticoneButton_clear_context_Click(sender As Object, e As EventArgs) Handles SiticoneButton_clear_context.Click
        extractedContext.Clear()
        SiticoneLabel_last_context.Text = String.Format("Use Last Context ({0} Tokens)", extractedContext.Count)
    End Sub

    Private Sub SiticoneButton_load_context_Click(sender As Object, e As EventArgs) Handles SiticoneButton_load_context.Click
        Dim modelName As String = SiticoneDropdown_model.SelectedItem?.ToString()
        Dim safeModelName As String = GetSafeFilename(modelName)

        Using ofd As New OpenFileDialog()
            ' Using the safe name for the filter and dialog
            ofd.Filter = $"Context File (*.{safeModelName}.cnt)|*.{safeModelName}.cnt"
            ofd.Title = "Ollama Context load"

            If ofd.ShowDialog() = DialogResult.OK Then
                Try
                    Using reader As New BinaryReader(File.Open(ofd.FileName, FileMode.Open))
                        Dim count As Integer = reader.ReadInt32()

                        ' Clear and refill the list
                        extractedContext.Clear()
                        For i As Integer = 0 To count - 1
                            extractedContext.Add(reader.ReadInt32())
                        Next
                    End Using

                    MessageBox.Show($"Successful {extractedContext.Count} Context-Token loaded.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Update the Label after successful load
                    SiticoneLabel_last_context.Text = String.Format("Use Last Context ({0} Tokens)", extractedContext.Count)
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
            ' Using the safe name for the filter and default filename
            sfd.Filter = $"Context File (*.{safeModelName}.cnt)|*.{safeModelName}.cnt"
            sfd.Title = "Ollama Context save"
            sfd.FileName = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss")

            If sfd.ShowDialog() = DialogResult.OK Then
                Try
                    Using writer As New BinaryWriter(File.Open(sfd.FileName, FileMode.Create))
                        ' Write the count first as a header
                        writer.Write(extractedContext.Count)
                        For Each id As Integer In extractedContext
                            writer.Write(id)
                        Next
                    End Using
                    ' Optional: Success message could be added here
                Catch ex As Exception
                    MessageBox.Show("Error saving: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    Private Function GetSafeFilename(input As String) As String
        If String.IsNullOrEmpty(input) Then Return "default"
        Dim invalidChars As String = New String(Path.GetInvalidFileNameChars())
        ' Replace invalid chars with "_"
        Return Regex.Replace(input, "[" & Regex.Escape(invalidChars) & "]", "_")
    End Function

    Private Sub SiticoneButton_timing_Click(sender As Object, e As EventArgs) Handles SiticoneButton_timing.Click
        ' Prüfen, ob überhaupt schon Daten vorhanden sind
        If timing_total_duration = 0 Then
            MessageBox.Show("No timing data available yet. Please run a query first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Instanz der neuen Form erstellen und Werte übergeben
        Using frm As New FrmTimingStats(
            timing_total_duration,
            timing_load_duration,
            timing_prompt_eval_count,
            timing_prompt_eval_duration,
            timing_eval_count,
            timing_eval_duration)

            frm.ShowDialog ' Als Dialog öffnen
        End Using
    End Sub

    Private Async Sub SiticoneDropdown_default_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SiticoneDropdown_default.SelectedIndexChanged
        Me.Cursor = Cursors.WaitCursor
        Dim key As String = SiticoneDropdown_default.SelectedItem
        Dim val = SettingsInfo_dic(key)
        Dim appPath As String = AppContext.BaseDirectory
        My.Settings.help_path = val.help_path
        Await InitializeWebView2()
        load_model(Path.Combine(appPath, val.model_path))
        load_execute(Path.Combine(appPath, val.code_path))
        load_tools(Path.Combine(appPath, val.tools_path))
        load_rag(Path.Combine(appPath, val.rag_path))
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

    Private Async Sub SiticoneButton_link_rag_tool_json_Click(sender As Object, e As EventArgs) Handles SiticoneButton_link_rag_tool_json.Click
        Await InitializeWebView2("link_rag_tool_json")
    End Sub

    Private Async Sub SiticoneButton_link_execute_list_Click(sender As Object, e As EventArgs) Handles SiticoneButton_link_execute_list.Click
        Await InitializeWebView2("link_execute_list")
    End Sub

    Private Async Sub SiticoneButton_execute_run_Click(sender As Object, e As EventArgs) Handles SiticoneButton_execute_run.Click
        Await InitializeWebView2("link_execute_run")
    End Sub

    Private Sub SetupEditor(editor As ScintillaNET.Scintilla, langType As String)
        ' -------------------------------------------------------------------------
        ' 1. GRUND-DESIGN (RESET)
        ' -------------------------------------------------------------------------
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

        ' Alte Keywords löschen
        editor.SetKeywords(0, "")
        editor.SetKeywords(1, "")

        ' -------------------------------------------------------------------------
        ' 2. SPRACHE SETZEN (Deine Methode mit LexerLanguage)
        ' -------------------------------------------------------------------------
        ' Standard-Fallback auf NULL (Text)
        editor.LexerLanguage = ScintillaNET.Lexer.SCLEX_NULL

        Dim lang As String = langType.ToLower().Trim()

        Select Case lang
        ' =====================================================================
        ' PYTHON
        ' =====================================================================
            Case "python", "py"
                ' Hier nutzen wir deine Syntax:
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

        ' =====================================================================
        ' JSON (ID 112)
        ' =====================================================================
            Case "json"
                editor.LexerLanguage = ScintillaNET.Lexer.SCLEX_JSON

                editor.Styles(ScintillaNET.Style.Json.PropertyName).ForeColor = Color.DarkBlue
                editor.Styles(ScintillaNET.Style.Json.String).ForeColor = Color.Maroon
                editor.Styles(ScintillaNET.Style.Json.Number).ForeColor = Color.DarkGreen
                editor.Styles(ScintillaNET.Style.Json.Operator).ForeColor = Color.Black
                editor.Styles(ScintillaNET.Style.Json.BlockComment).ForeColor = Color.Green

        ' =====================================================================
        ' MARKDOWN (ID 98)
        ' =====================================================================
            Case "markdown", "md"
                editor.LexerLanguage = ScintillaNET.Lexer.SCLEX_MARKDOWN

                editor.WrapMode = ScintillaNET.WrapMode.Word
                ' Styles über IDs setzen (funktioniert immer)
                editor.Styles(2).ForeColor = Color.DarkBlue       ' Header 1
                editor.Styles(2).Bold = True
                editor.Styles(3).ForeColor = Color.RoyalBlue      ' Header 2
                editor.Styles(3).Bold = True
                editor.Styles(9).ForeColor = Color.OrangeRed      ' List Item
                editor.Styles(14).ForeColor = Color.Blue          ' Link
                editor.Styles(14).Underline = True
                editor.Styles(15).ForeColor = Color.DarkOliveGreen ' Code

        ' =====================================================================
        ' HTML / XML
        ' =====================================================================
            Case "html", "xml"
                editor.LexerLanguage = ScintillaNET.Lexer.SCLEX_HTML

                editor.Styles(ScintillaNET.Style.Html.Tag).ForeColor = Color.DarkBlue
                editor.Styles(ScintillaNET.Style.Html.Attribute).ForeColor = Color.Red
                editor.Styles(ScintillaNET.Style.Html.Value).ForeColor = Color.Blue
                editor.Styles(ScintillaNET.Style.Html.Comment).ForeColor = Color.Green

        ' =====================================================================
        ' JAVASCRIPT (nutzt C++ Lexer)
        ' =====================================================================
            Case "javascript", "js"
                editor.LexerLanguage = ScintillaNET.Lexer.SCLEX_JAVA

                Dim jsKeys As String = "abstract await boolean break case catch class const continue debugger default delete do double else enum export extends false final finally float for function if import in instanceof int interface let long native new null package private protected public return short static super switch synchronized this throw throws transient true try typeof var void volatile while with yield"
                editor.SetKeywords(0, jsKeys)

                editor.Styles(ScintillaNET.Style.Cpp.Word).ForeColor = Color.Blue
                editor.Styles(ScintillaNET.Style.Cpp.String).ForeColor = Color.Maroon
                editor.Styles(ScintillaNET.Style.Cpp.CommentLine).ForeColor = Color.Green

        ' =====================================================================
        ' POWERSHELL (ID 127) oder BATCH
        ' =====================================================================
            Case "powershell", "ps1"
                editor.LexerLanguage = ScintillaNET.Lexer.SCLEX_POWERSHELL

                Dim psKeys As String = "if else elseif switch while do for foreach in return break continue throw trap param function filter begin process end"
                editor.SetKeywords(0, psKeys)
                editor.Styles(ScintillaNET.Style.PowerShell.Keyword).ForeColor = Color.Blue
                editor.Styles(ScintillaNET.Style.PowerShell.Variable).ForeColor = Color.OrangeRed

            Case "batch", "bat", "cmd"
                editor.LexerLanguage = ScintillaNET.Lexer.SCLEX_BATCH
                editor.Styles(ScintillaNET.Style.Batch.Command).ForeColor = Color.Blue

                ' =====================================================================
                ' SONSTIGES
                ' =====================================================================
            Case Else
                ' Hier passiert nichts, da Default oben schon auf SCLEX_NULL gesetzt wurde.

        End Select
    End Sub

    Private Async Sub SiticoneButton_preload_Click(sender As Object, e As EventArgs) Handles SiticoneButton_preload.Click
        ' 1. Prüfen, ob ein Modell ausgewählt ist
        If SiticoneDropdown_model.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a model first.")
            Return
        End If

        Dim modelName As String = SiticoneDropdown_model.SelectedItem.ToString()

        ' UI Feedback: Cursor ändern und Button deaktivieren
        Me.Cursor = Cursors.WaitCursor
        SiticoneButton_preload.Enabled = False

        Try
            ' URL zusammenbauen (nutzt deine existierende TextBox für den Host)
            Dim apiUrl As String = "http://" & SiticoneTextBox_host.Text & "/api/generate"

            ' 2. JSON Payload erstellen
            ' Wir senden einen leeren Prompt. Das signalisiert Ollama: "Lade das Modell, aber mach nichts."
            Dim jsonPayload As New JObject()
            jsonPayload("model") = modelName
            jsonPayload("prompt") = ""      ' Leerer Prompt = nur Laden
            jsonPayload("stream") = False   ' Kein Streaming notwendig

            Dim content As New StringContent(jsonPayload.ToString(), Encoding.UTF8, "application/json")

            Using client As New HttpClient()
                ' Optional: Timeout erhöhen, da große Modelle (z.B. 70b) ein paar Sekunden zum Laden brauchen
                client.Timeout = TimeSpan.FromMinutes(2)

                ' 3. Anfrage senden
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
            ' UI wieder freigeben
            Me.Cursor = Cursors.Default
            SiticoneButton_preload.Enabled = True
        End Try
    End Sub

End Class

Public Class DocumentIndex
    ' Dictionary: Wort -> Liste von Satzindizes
    Private wordToSentences As New Dictionary(Of String, List(Of Integer))(StringComparer.OrdinalIgnoreCase)

    ' Liste aller Sätze
    Private sentences As New List(Of SentenceData)

    ' Dokument indexieren
    Public Sub IndexDocument(content As String)
        wordToSentences.Clear()
        sentences.Clear()

        ' Text in Sätze aufteilen
        Dim sentenceArray = SplitIntoSentences(content)

        For i As Integer = 0 To sentenceArray.Length - 1
            Dim sentence As String = sentenceArray(i).Trim()
            If String.IsNullOrWhiteSpace(sentence) Then Continue For

            ' Satz hinzufügen
            Dim sentData As New SentenceData(sentence, i)
            sentences.Add(sentData)

            ' Wörter extrahieren und indexieren
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

    ' Suche nach einem Wort und inkrementiere Treffer mit Delta-Bereich
    Public Function SearchAndIncrementHits(searchWord As String, Optional delta As Integer = 0) As List(Of SentenceData)
        Dim results As New List(Of SentenceData)()

        If wordToSentences.ContainsKey(searchWord) Then
            ' Sammle alle betroffenen Satzindizes
            Dim affectedIndices As New HashSet(Of Integer)()

            For Each sentenceIdx In wordToSentences(searchWord)
                ' Füge den Haupttreffer hinzu
                affectedIndices.Add(sentenceIdx)

                ' Füge Sätze im Delta-Bereich hinzu
                If delta > 0 Then
                    For offset As Integer = -delta To delta
                        Dim targetIdx As Integer = sentenceIdx + offset
                        ' Prüfe ob Index gültig ist
                        If targetIdx >= 0 AndAlso targetIdx < sentences.Count Then
                            affectedIndices.Add(targetIdx)
                        End If
                    Next
                End If
            Next

            ' Inkrementiere alle betroffenen Sätze
            For Each idx In affectedIndices
                sentences(idx).HitCount += 1
                results.Add(sentences(idx))
            Next

            ' Sortiere Ergebnisse nach Satzindex
            results = results.OrderBy(Function(s) s.SentenceIndex).ToList()
        End If

        Return results
    End Function

    ' Alle Sätze mit Treffern abrufen
    Public Function GetSentencesWithHits() As List(Of SentenceData)
        Return sentences.Where(Function(s) s.HitCount > 0).OrderByDescending(Function(s) s.HitCount).ToList()
    End Function

    ' Alle Sätze abrufen
    Public Function GetAllSentences() As List(Of SentenceData)
        Return sentences
    End Function

    ' Treffer zurücksetzen
    Public Sub ResetHits()
        For Each sent In sentences
            sent.HitCount = 0
        Next
    End Sub

    ' Text in Sätze aufteilen (berücksichtigt Satzzeichen UND Zeilenumbrüche)
    Private Function SplitIntoSentences(text As String) As String()
        Dim sentences As New List(Of String)()

        ' Erst nach Zeilenumbrüchen trennen
        Dim lines As String() = text.Split({vbCrLf, vbLf, vbCr}, StringSplitOptions.None)

        For Each line In lines
            If String.IsNullOrWhiteSpace(line) Then
                Continue For
            End If

            ' Jede Zeile zusätzlich nach Satzzeichen aufteilen
            ' ABER: Ignoriere Punkte nach Zahlen (Aufzählungen)
            Dim lineSentences = SplitByPunctuation(line.Trim())

            For Each sent In lineSentences
                If Not String.IsNullOrWhiteSpace(sent) Then
                    sentences.Add(sent.Trim())
                End If
            Next
        Next

        Return sentences.ToArray()
    End Function

    ' Hilfsfunktion: Text nach Satzzeichen aufteilen, ignoriert Aufzählungen
    Private Function SplitByPunctuation(text As String) As List(Of String)
        Dim result As New List(Of String)()

        ' Pattern erklärt:
        ' (?<!               = Negativer Lookbehind (das davor darf NICHT sein)
        '   \d               = Ziffer (verhindert: "1. Text")
        '   |                = ODER
        '   \b[A-ZÄÖÜ]       = Einzelner Großbuchstabe (verhindert: "Dr. Müller")
        '   |                = ODER
        '   [IVXivx]{1,4}    = Römische Zahlen (verhindert: "IV. Kapitel")
        ' )
        ' [.!?]              = Satzzeichen
        ' (?=\s)             = Positiver Lookahead: danach muss Whitespace folgen
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

    ' Wörter aus Satz extrahieren
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

