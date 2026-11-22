Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class FrmServerManager

    Public Property SelectedName As String = ""
    Public Property SelectedHost As String = ""
    Public Property SelectedApiKey As String = ""
    Public Property ApplyRequested As Boolean = False

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(currentHost As String, currentApiKey As String)
        InitializeComponent()
        SelectedHost = currentHost
        SelectedApiKey = currentApiKey
    End Sub

    Private Sub FrmServerManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadServers()
    End Sub

    ''' <summary>
    ''' Lädt die gespeicherten Server ausschließlich aus My.Settings.server_list.
    ''' </summary>
    Private Sub LoadServers()
        DataGridView_servers.Rows.Clear()

        Try
            Dim jsonText As String = My.Settings.server_list

            If Not String.IsNullOrWhiteSpace(jsonText) Then
                Dim serverList = JArray.Parse(jsonText)
                For Each item As JObject In serverList
                    Dim name As String = If(item("name") IsNot Nothing, item("name").ToString(), "")
                    Dim host As String = If(item("host") IsNot Nothing, item("host").ToString(), "")
                    Dim apiKey As String = If(item("api_key") IsNot Nothing, item("api_key").ToString(), "")
                    DataGridView_servers.Rows.Add(name, host, apiKey)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show($"Error loading server list: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' Falls die Liste noch komplett leer ist (nur die leere Neuerfassungszeile vorhanden ist)
        Dim hasDataRows As Boolean = False
        For Each r As DataGridViewRow In DataGridView_servers.Rows
            If Not r.IsNewRow Then
                hasDataRows = True
                Exit For
            End If
        Next

        If Not hasDataRows Then
            ' Default entry: localhost, localhost:11434, without API key
            Dim defaultName As String = "localhost"
            Dim defaultHost As String = If(Not String.IsNullOrWhiteSpace(SelectedHost), SelectedHost, "localhost:11434")
            Dim defaultApiKey As String = If(Not String.IsNullOrWhiteSpace(SelectedApiKey), SelectedApiKey, "")

            DataGridView_servers.Rows.Add(defaultName, defaultHost, defaultApiKey)
            SaveServers()
        End If
    End Sub

    ''' <summary>
    ''' Speichert die Zeilen der DataGridView ausschließlich in My.Settings.server_list.
    ''' </summary>
    Private Sub SaveServers()
        DataGridView_servers.EndEdit()

        Try
            Dim serverList As New JArray()

            For Each row As DataGridViewRow In DataGridView_servers.Rows
                If row.IsNewRow Then Continue For

                Dim name As String = If(row.Cells("col_name").Value IsNot Nothing, row.Cells("col_name").Value.ToString().Trim(), "")
                Dim host As String = If(row.Cells("col_host").Value IsNot Nothing, row.Cells("col_host").Value.ToString().Trim(), "")
                Dim apiKey As String = If(row.Cells("col_apikey").Value IsNot Nothing, row.Cells("col_apikey").Value.ToString().Trim(), "")

                ' Nur Einträge mit mindestens Host oder Name speichern
                If Not String.IsNullOrWhiteSpace(host) OrElse Not String.IsNullOrWhiteSpace(name) Then
                    Dim serverObj As New JObject()
                    serverObj("name") = name
                    serverObj("host") = host
                    serverObj("api_key") = apiKey
                    serverList.Add(serverObj)
                End If
            Next

            Dim jsonFormatted As String = serverList.ToString(Formatting.Indented)

            ' Ausschließlich in My.Settings speichern (liegt in %LOCALAPPDATA%, benötigt keine Admin-Rechte)
            My.Settings.server_list = jsonFormatted
            My.Settings.Save()
        Catch ex As Exception
            MessageBox.Show($"Error saving server list: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Klick-Handler für Löschen
    ''' </summary>
    Private Sub Button_delete_Click(sender As Object, e As EventArgs) Handles Button_delete.Click
        If DataGridView_servers.CurrentRow IsNot Nothing AndAlso Not DataGridView_servers.CurrentRow.IsNewRow Then
            Dim name As String = If(DataGridView_servers.CurrentRow.Cells("col_name").Value IsNot Nothing, DataGridView_servers.CurrentRow.Cells("col_name").Value.ToString(), "")
            Dim host As String = If(DataGridView_servers.CurrentRow.Cells("col_host").Value IsNot Nothing, DataGridView_servers.CurrentRow.Cells("col_host").Value.ToString(), "")
            Dim displayInfo As String = If(String.IsNullOrWhiteSpace(name), host, name)

            Dim result = MessageBox.Show($"Are you sure you want to delete the entry '{displayInfo}'?", "Delete Entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                DataGridView_servers.Rows.Remove(DataGridView_servers.CurrentRow)
                SaveServers()
            End If
        End If
    End Sub

    ''' <summary>
    ''' Übernimmt den aktuell ausgewählten Server und schließt den Dialog.
    ''' </summary>
    Private Sub ApplyCurrentSelection()
        If DataGridView_servers.CurrentRow IsNot Nothing AndAlso Not DataGridView_servers.CurrentRow.IsNewRow Then
            Dim host As String = If(DataGridView_servers.CurrentRow.Cells("col_host").Value IsNot Nothing, DataGridView_servers.CurrentRow.Cells("col_host").Value.ToString().Trim(), "")
            Dim apiKey As String = If(DataGridView_servers.CurrentRow.Cells("col_apikey").Value IsNot Nothing, DataGridView_servers.CurrentRow.Cells("col_apikey").Value.ToString().Trim(), "")
            Dim name As String = If(DataGridView_servers.CurrentRow.Cells("col_name").Value IsNot Nothing, DataGridView_servers.CurrentRow.Cells("col_name").Value.ToString().Trim(), "")

            If String.IsNullOrWhiteSpace(host) Then
                MessageBox.Show("The selected row does not contain a host address.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            SaveServers()

            SelectedName = name
            SelectedHost = host
            SelectedApiKey = apiKey
            ApplyRequested = True

            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            MessageBox.Show("Please select a server from the list first.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button_apply_Click(sender As Object, e As EventArgs) Handles Button_apply.Click
        ApplyCurrentSelection()
    End Sub

    Private Sub DataGridView_servers_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_servers.CellDoubleClick
        If e.RowIndex >= 0 Then
            ApplyCurrentSelection()
        End If
    End Sub

    Private Sub Button_close_Click(sender As Object, e As EventArgs) Handles Button_close.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub FrmServerManager_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not ApplyRequested Then
            SaveServers()
        End If
    End Sub

    ''' <summary>
    ''' Exportiert die gesamte Serverliste in eine Datei (*.server.json).
    ''' </summary>
    Private Sub Button_export_Click(sender As Object, e As EventArgs) Handles Button_export.Click
        DataGridView_servers.EndEdit()

        Dim serverList As New JArray()
        For Each row As DataGridViewRow In DataGridView_servers.Rows
            If row.IsNewRow Then Continue For

            Dim name As String = If(row.Cells("col_name").Value IsNot Nothing, row.Cells("col_name").Value.ToString().Trim(), "")
            Dim host As String = If(row.Cells("col_host").Value IsNot Nothing, row.Cells("col_host").Value.ToString().Trim(), "")
            Dim apiKey As String = If(row.Cells("col_apikey").Value IsNot Nothing, row.Cells("col_apikey").Value.ToString().Trim(), "")

            If Not String.IsNullOrWhiteSpace(host) OrElse Not String.IsNullOrWhiteSpace(name) Then
                Dim serverObj As New JObject()
                serverObj("name") = name
                serverObj("host") = host
                serverObj("api_key") = apiKey
                serverList.Add(serverObj)
            End If
        Next

        Using sfd As New SaveFileDialog()
            sfd.Title = "Export Server List"
            sfd.Filter = "Ollama Server List (*.server.json)|*.server.json|All Files (*.*)|*.*"
            sfd.DefaultExt = "server.json"
            sfd.FileName = "ollama_servers.server.json"

            If sfd.ShowDialog(Me) = DialogResult.OK Then
                Try
                    File.WriteAllText(sfd.FileName, serverList.ToString(Formatting.Indented))
                    MessageBox.Show($"Server list exported successfully:{vbCrLf}{sfd.FileName}", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show($"Error exporting: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    ''' <summary>
    ''' Importiert Server aus einer Datei (*.server.json).
    ''' </summary>
    Private Sub Button_import_Click(sender As Object, e As EventArgs) Handles Button_import.Click
        Using ofd As New OpenFileDialog()
            ofd.Title = "Import Server List"
            ofd.Filter = "Ollama Server List (*.server.json)|*.server.json|JSON Files (*.json)|*.json|All Files (*.*)|*.*"
            ofd.DefaultExt = "server.json"

            If ofd.ShowDialog(Me) = DialogResult.OK Then
                Try
                    Dim jsonText As String = File.ReadAllText(ofd.FileName)
                    If String.IsNullOrWhiteSpace(jsonText) Then
                        MessageBox.Show("The selected file is empty.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If

                    Dim importedList = JArray.Parse(jsonText)
                    If importedList.Count = 0 Then
                        MessageBox.Show("No server entries found in the file.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Return
                    End If

                    ' Select mode: Replace or Append
                    Dim choice = MessageBox.Show(
                        "Do you want to replace the current list (Yes) or append the imported entries (No)?" & vbCrLf & vbCrLf &
                        "• Yes = Clear current list and load imported servers" & vbCrLf &
                        "• No = Append imported servers to current list" & vbCrLf &
                        "• Cancel = Abort import",
                        "Select Import Mode",
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Question)

                    If choice = DialogResult.Cancel Then Return

                    If choice = DialogResult.Yes Then
                        DataGridView_servers.Rows.Clear()
                    End If

                    For Each item As JObject In importedList
                        Dim name As String = If(item("name") IsNot Nothing, item("name").ToString(), "")
                        Dim host As String = If(item("host") IsNot Nothing, item("host").ToString(), "")
                        Dim apiKey As String = If(item("api_key") IsNot Nothing, item("api_key").ToString(), "")

                        If Not String.IsNullOrWhiteSpace(host) OrElse Not String.IsNullOrWhiteSpace(name) Then
                            DataGridView_servers.Rows.Add(name, host, apiKey)
                        End If
                    Next

                    SaveServers()
                    MessageBox.Show($"Successfully imported {importedList.Count} server entries.", "Import Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Catch ex As Exception
                    MessageBox.Show($"Error importing file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

End Class