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
            DataGridView_ps.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "Size", .HeaderText = "Size (GB)", .Width = 100})
            DataGridView_ps.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "Processor", .HeaderText = "VRAM / Offload", .Width = 150})
            DataGridView_ps.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "ExpiresAt", .HeaderText = "Expires At", .Width = 150})
        End If

        Await LoadOllamaPsDataAsync()
        Timer_refresh.Start()
    End Sub

    Private Async Function LoadOllamaPsDataAsync() As Task
        Try
            Dim apiUrl As String = "http://" & hostUrl & "/api/ps"
            Using client As New HttpClient()
                client.Timeout = TimeSpan.FromSeconds(5)
                Dim response = Await client.GetAsync(apiUrl)

                If response.IsSuccessStatusCode Then
                    Dim jsonResponse = Await response.Content.ReadAsStringAsync()
                    Dim jsonObj = JObject.Parse(jsonResponse)
                    Dim modelsArray = CType(jsonObj("models"), JArray)

                    DataGridView_ps.Rows.Clear()

                    If modelsArray IsNot Nothing Then
                        For Each m In modelsArray
                            Dim modelName As String = If(m("name")?.ToString(), "Unknown")
                            Dim processName As String = If(m("model")?.ToString(), "Unknown")

                            ' Gesamtgröße des Modells auslesen und in GB umrechnen
                            Dim sizeBytes As Long = 0
                            If m("size") IsNot Nothing Then
                                Long.TryParse(m("size").ToString(), sizeBytes)
                            End If
                            Dim sizeGb As Double = Math.Round(sizeBytes / (1024.0 * 1024.0 * 1024.0), 2)

                            ' VRAM-Anteil auslesen und in GB umrechnen
                            Dim sizeVramBytes As Long = 0
                            If m("size_vram") IsNot Nothing Then
                                Long.TryParse(m("size_vram").ToString(), sizeVramBytes)
                            End If
                            Dim sizeVramGb As Double = Math.Round(sizeVramBytes / (1024.0 * 1024.0 * 1024.0), 2)

                            ' Klarer Status für VRAM / Offload berechnen
                            Dim processorType As String
                            If sizeBytes <= 0 Then
                                processorType = "Unknown"
                            ElseIf sizeVramBytes >= sizeBytes Then
                                processorType = "100% GPU"
                            ElseIf sizeVramBytes <= 0 Then
                                processorType = "0% GPU (100% CPU/RAM)"
                            Else
                                Dim gpuPercent As Integer = CInt(Math.Round((sizeVramBytes / CDbl(sizeBytes)) * 100.0))
                                Dim offloadRamGb As Double = Math.Round((sizeBytes - sizeVramBytes) / (1024.0 * 1024.0 * 1024.0), 2)
                                processorType = $"{gpuPercent}% GPU (+{offloadRamGb:F2} GB RAM)"
                            End If

                            ' Ablaufzeitpunkt formatieren
                            Dim expiresAt As String = If(m("expires_at")?.ToString(), "-")
                            Dim parsedDate As DateTime
                            If DateTime.TryParse(expiresAt, Nothing, Globalization.DateTimeStyles.RoundtripKind, parsedDate) Then
                                expiresAt = parsedDate.ToLocalTime().ToString("HH:mm:ss dd.MM.yyyy")
                            End If

                            ' Zeile zum DataGridView hinzufügen
                            Dim rowIndex As Integer = DataGridView_ps.Rows.Add(modelName, processName, sizeGb.ToString("F2") & " GB", processorType, expiresAt)

                            ' Optional: Farbliche Kennzeichnung bei RAM-Offload
                            If sizeBytes > 0 AndAlso sizeVramBytes < sizeBytes Then
                                DataGridView_ps.Rows(rowIndex).Cells("Processor").Style.ForeColor = Color.OrangeRed
                            Else
                                DataGridView_ps.Rows(rowIndex).Cells("Processor").Style.ForeColor = Color.DarkGreen
                            End If
                        Next
                    End If
                End If
            End Using
        Catch ex As Exception
            ' Fehler abfangen, damit der Hintergrund-Timer nicht abstürzt
        End Try
    End Function

    Private Async Sub Timer_refresh_Tick(sender As Object, e As EventArgs) Handles Timer_refresh.Tick
        Await LoadOllamaPsDataAsync()
    End Sub

    Private Sub FrmOllamaPs_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Timer_refresh.Stop()
    End Sub

End Class