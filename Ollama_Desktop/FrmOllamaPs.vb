Imports System.Net.Http
Imports Newtonsoft.Json.Linq

Public Class FrmOllamaPs
    Private hostUrl As String


    Public Sub New(ollamaHost As String)
        InitializeComponent()
        Me.hostUrl = ollamaHost
    End Sub

    Private Async Sub FrmOllamaPs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Ollama Running Models (/api/ps)"

        If DataGridView_ps.Columns.Count = 0 Then
            DataGridView_ps.AutoGenerateColumns = False
            DataGridView_ps.AllowUserToAddRows = False
            DataGridView_ps.ReadOnly = True
            DataGridView_ps.SelectionMode = DataGridViewSelectionMode.FullRowSelect

            DataGridView_ps.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "Model", .HeaderText = "Model", .Width = 220})
            DataGridView_ps.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "Name", .HeaderText = "Process Name", .Width = 150})
            DataGridView_ps.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "Context", .HeaderText = "Context Length", .Width = 120})
            DataGridView_ps.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "ModelSize", .HeaderText = "Model Size", .Width = 120})
            DataGridView_ps.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "MemoryUsage", .HeaderText = "Memory Usage", .Width = 120})
            DataGridView_ps.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "Processor", .HeaderText = "VRAM / Offload", .Width = 150})
            DataGridView_ps.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "ExpiresAt", .HeaderText = "Expires At", .Width = 150})
        End If

        Await LoadOllamaPsDataAsync()
        Timer_refresh.Start()
    End Sub

    Private Async Function LoadOllamaPsDataAsync() As Task
        Try
            Using client As New HttpClient()
                client.Timeout = TimeSpan.FromSeconds(5)

                ' 1. Alle auf dem Server installierten Modelle via /api/tags abfragen
                Dim modelSizesDic As New Dictionary(Of String, Long)(StringComparer.OrdinalIgnoreCase)
                Try
                    Dim tagsUrl As String = "http://" & hostUrl & "/api/tags"
                    Dim tagsResponse = Await client.GetAsync(tagsUrl)
                    If tagsResponse.IsSuccessStatusCode Then
                        Dim tagsJsonStr = Await tagsResponse.Content.ReadAsStringAsync()
                        Dim tagsObj = JObject.Parse(tagsJsonStr)
                        Dim tagModels = CType(tagsObj("models"), JArray)

                        If tagModels IsNot Nothing Then
                            For Each tm In tagModels
                                Dim tName As String = tm("name")?.ToString()
                                Dim tModel As String = tm("model")?.ToString()
                                Dim tSize As Long = 0
                                If tm("size") IsNot Nothing Then
                                    Long.TryParse(tm("size").ToString(), tSize)
                                End If

                                If Not String.IsNullOrEmpty(tName) AndAlso Not modelSizesDic.ContainsKey(tName) Then
                                    modelSizesDic(tName) = tSize
                                End If
                                If Not String.IsNullOrEmpty(tModel) AndAlso Not modelSizesDic.ContainsKey(tModel) Then
                                    modelSizesDic(tModel) = tSize
                                End If
                            Next
                        End If
                    End If
                Catch ex As Exception
                    ' Falls /api/tags fehlschlägt, läuft die Prozessanzeige trotzdem weiter
                End Try

                ' 2. Aktive Prozesse via /api/ps abfragen
                Dim psUrl As String = "http://" & hostUrl & "/api/ps"
                Dim psResponse = Await client.GetAsync(psUrl)

                If psResponse.IsSuccessStatusCode Then
                    Dim jsonResponse = Await psResponse.Content.ReadAsStringAsync()
                    Dim jsonObj = JObject.Parse(jsonResponse)
                    Dim modelsArray = CType(jsonObj("models"), JArray)

                    DataGridView_ps.Rows.Clear()

                    If modelsArray IsNot Nothing Then
                        For Each m In modelsArray
                            Dim modelName As String = If(m("name")?.ToString(), "Unknown")
                            Dim processName As String = If(m("model")?.ToString(), "Unknown")

                            ' 3. context_length direkt aus /api/ps
                            Dim contextLengthStr As String = "-"
                            Dim rawCtx As Long = 0
                            If m("context_length") IsNot Nothing AndAlso Long.TryParse(m("context_length").ToString(), rawCtx) AndAlso rawCtx > 0 Then
                                Dim ctxK As Integer = CInt(Math.Round(rawCtx / 1024.0))
                                contextLengthStr = $"{rawCtx:N0} ({ctxK}k)"
                            End If

                            ' 4. Echte Dateigröße (Model Size) aus dem /api/tags Dictionary ermitteln
                            Dim fileSizeBytes As Long = 0
                            If modelSizesDic.ContainsKey(modelName) Then
                                fileSizeBytes = modelSizesDic(modelName)
                            ElseIf modelSizesDic.ContainsKey(processName) Then
                                fileSizeBytes = modelSizesDic(processName)
                            End If
                            Dim modelSizeStr As String = If(fileSizeBytes > 0, $"{Math.Round(fileSizeBytes / (1024.0 * 1024.0 * 1024.0), 2):F2} GB", "-")

                            ' 5. Belegter Prozess-Speicher (Memory Usage) aus /api/ps
                            Dim memBytes As Long = 0
                            If m("size") IsNot Nothing Then
                                Long.TryParse(m("size").ToString(), memBytes)
                            End If
                            Dim memGb As Double = Math.Round(memBytes / (1024.0 * 1024.0 * 1024.0), 2)
                            Dim memoryUsageStr As String = $"{memGb:F2} GB"

                            ' 6. VRAM / Offload Status berechnen
                            Dim vramBytes As Long = 0
                            If m("size_vram") IsNot Nothing Then
                                Long.TryParse(m("size_vram").ToString(), vramBytes)
                            End If

                            Dim processorType As String
                            If memBytes <= 0 Then
                                processorType = "Unknown"
                            ElseIf vramBytes >= memBytes Then
                                processorType = "100% GPU"
                            ElseIf vramBytes <= 0 Then
                                processorType = "0% GPU (100% CPU/RAM)"
                            Else
                                Dim gpuPercent As Integer = CInt(Math.Round((vramBytes / CDbl(memBytes)) * 100.0))
                                Dim offloadRamGb As Double = Math.Round((memBytes - vramBytes) / (1024.0 * 1024.0 * 1024.0), 2)
                                processorType = $"{gpuPercent}% GPU (+{offloadRamGb:F2} GB RAM)"
                            End If

                            ' 7. Ablaufzeitpunkt exakt in Lokalzeit
                            Dim expiresAtRaw As String = If(m("expires_at")?.ToString(), "")
                            Dim expiresAtLocal As String = "-"
                            If Not String.IsNullOrWhiteSpace(expiresAtRaw) Then
                                Dim dto As DateTimeOffset
                                If DateTimeOffset.TryParse(expiresAtRaw, dto) Then
                                    expiresAtLocal = dto.ToLocalTime().ToString("HH:mm:ss dd.MM.yyyy")
                                End If
                            End If

                            ' 8. Zeile hinzufügen
                            Dim rowIndex As Integer = DataGridView_ps.Rows.Add(modelName, processName, contextLengthStr, modelSizeStr, memoryUsageStr, processorType, expiresAtLocal)

                            ' Farbliche Kennzeichnung bei RAM-Offload
                            If memBytes > 0 AndAlso vramBytes < memBytes Then
                                DataGridView_ps.Rows(rowIndex).Cells("Processor").Style.ForeColor = Color.OrangeRed
                            Else
                                DataGridView_ps.Rows(rowIndex).Cells("Processor").Style.ForeColor = Color.DarkGreen
                            End If
                        Next
                    End If
                End If
            End Using
        Catch ex As Exception
            ' Fehler abfangen
        End Try
    End Function

    Private Async Sub Timer_refresh_Tick(sender As Object, e As EventArgs) Handles Timer_refresh.Tick
        Await LoadOllamaPsDataAsync()
    End Sub

    Private Sub FrmOllamaPs_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Timer_refresh.Stop()
    End Sub

End Class