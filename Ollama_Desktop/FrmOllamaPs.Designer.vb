<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOllamaPs
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
        components = New ComponentModel.Container()
        DataGridView_ps = New DataGridView()
        Timer_refresh = New Timer(components)
        CType(DataGridView_ps, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView_ps
        ' 
        DataGridView_ps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView_ps.Dock = DockStyle.Fill
        DataGridView_ps.Location = New Point(0, 0)
        DataGridView_ps.Name = "DataGridView_ps"
        DataGridView_ps.Size = New Size(1088, 450)
        DataGridView_ps.TabIndex = 0
        ' 
        ' Timer_refresh
        ' 
        Timer_refresh.Interval = 3000
        ' 
        ' FrmOllamaPs
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1088, 450)
        Controls.Add(DataGridView_ps)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "FrmOllamaPs"
        Text = "FrmOllamaPs"
        CType(DataGridView_ps, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView_ps As DataGridView
    Friend WithEvents Timer_refresh As Timer
End Class
