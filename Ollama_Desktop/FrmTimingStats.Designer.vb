<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTimingStats
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        TableLayoutPanel1 = New TableLayoutPanel()
        OK_Button = New Button()
        lblTotalTime = New Label()
        lblLoadTime = New Label()
        lblPromptStats = New Label()
        lblResponseStats = New Label()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(OK_Button, 1, 0)
        TableLayoutPanel1.Location = New Point(410, 96)
        TableLayoutPanel1.Margin = New Padding(4, 3, 4, 3)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(83, 33)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' OK_Button
        ' 
        OK_Button.Anchor = AnchorStyles.None
        OK_Button.Location = New Point(4, 3)
        OK_Button.Margin = New Padding(4, 3, 4, 3)
        OK_Button.Name = "OK_Button"
        OK_Button.Size = New Size(75, 27)
        OK_Button.TabIndex = 0
        OK_Button.Text = "OK"
        ' 
        ' lblTotalTime
        ' 
        lblTotalTime.AutoSize = True
        lblTotalTime.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotalTime.Location = New Point(12, 9)
        lblTotalTime.Name = "lblTotalTime"
        lblTotalTime.Size = New Size(56, 21)
        lblTotalTime.TabIndex = 1
        lblTotalTime.Text = "Label1"
        ' 
        ' lblLoadTime
        ' 
        lblLoadTime.AutoSize = True
        lblLoadTime.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblLoadTime.Location = New Point(12, 30)
        lblLoadTime.Name = "lblLoadTime"
        lblLoadTime.Size = New Size(56, 21)
        lblLoadTime.TabIndex = 2
        lblLoadTime.Text = "Label2"
        ' 
        ' lblPromptStats
        ' 
        lblPromptStats.AutoSize = True
        lblPromptStats.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPromptStats.Location = New Point(12, 51)
        lblPromptStats.Name = "lblPromptStats"
        lblPromptStats.Size = New Size(56, 21)
        lblPromptStats.TabIndex = 3
        lblPromptStats.Text = "Label3"
        ' 
        ' lblResponseStats
        ' 
        lblResponseStats.AutoSize = True
        lblResponseStats.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblResponseStats.Location = New Point(12, 72)
        lblResponseStats.Name = "lblResponseStats"
        lblResponseStats.Size = New Size(60, 21)
        lblResponseStats.TabIndex = 4
        lblResponseStats.Text = "Label4"
        ' 
        ' FrmTimingStats
        ' 
        AcceptButton = OK_Button
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(507, 143)
        Controls.Add(lblResponseStats)
        Controls.Add(lblPromptStats)
        Controls.Add(lblLoadTime)
        Controls.Add(lblTotalTime)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        MinimizeBox = False
        Name = "FrmTimingStats"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Statistics"
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents lblTotalTime As Label
    Friend WithEvents lblLoadTime As Label
    Friend WithEvents lblPromptStats As Label
    Friend WithEvents lblResponseStats As Label

End Class
