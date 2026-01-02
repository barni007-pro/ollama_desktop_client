Imports System.Windows.Forms

Public Class FrmTimingStats

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As Object, ByVal e As EventArgs)
        DialogResult = DialogResult.Cancel
        Close
    End Sub

    Private Sub FrmTimingStats_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' Konstruktor, der die globalen Werte entgegennimmt
    Public Sub New(total As Long, load As Long, pCount As Long, pDuration As Long, eCount As Long, eDuration As Long)
        InitializeComponent()

        ' Berechnungen (Umrechnung ns in s)
        Dim totalSec As Double = total / 1000000000.0
        Dim loadSec As Double = load / 1000000000.0
        Dim promptSec As Double = pDuration / 1000000000.0
        Dim evalSec As Double = eDuration / 1000000000.0

        ' Geschwindigkeit berechnen (Tokens / Sekunden)
        Dim promptSpeed As Double = If(promptSec > 0, pCount / promptSec, 0)
        Dim responseSpeed As Double = If(evalSec > 0, eCount / evalSec, 0)

        ' Anzeige zuweisen (English Labels)
        Me.Text = "Performance Analysis"
        lblTotalTime.Text = $"Total Time: {totalSec:F2} sec"
        lblLoadTime.Text = $"Load Time: {loadSec:F2} sec"

        lblPromptStats.Text = $"Prompt: {pCount} tokens ({promptSpeed:F2} tokens/sec)"
        lblResponseStats.Text = $"Response: {eCount} tokens ({responseSpeed:F2} tokens/sec)"

    End Sub

End Class
