<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen1
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
    Friend WithEvents ApplicationTitle As System.Windows.Forms.Label
    Friend WithEvents Copyright As System.Windows.Forms.Label

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Version = New Label()
        Copyright = New Label()
        ApplicationTitle = New Label()
        SuspendLayout()
        ' 
        ' Version
        ' 
        Version.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Version.BackColor = Color.Transparent
        Version.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Version.ImageAlign = ContentAlignment.MiddleRight
        Version.Location = New Point(12, 552)
        Version.Name = "Version"
        Version.Size = New Size(574, 20)
        Version.TabIndex = 1
        Version.Text = "Version"
        Version.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Copyright
        ' 
        Copyright.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Copyright.BackColor = Color.Transparent
        Copyright.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Copyright.Location = New Point(12, 572)
        Copyright.Name = "Copyright"
        Copyright.Size = New Size(574, 20)
        Copyright.TabIndex = 2
        Copyright.Text = "Copyright"
        Copyright.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ApplicationTitle
        ' 
        ApplicationTitle.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        ApplicationTitle.BackColor = Color.Transparent
        ApplicationTitle.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ApplicationTitle.ForeColor = Color.Red
        ApplicationTitle.Location = New Point(12, 504)
        ApplicationTitle.Name = "ApplicationTitle"
        ApplicationTitle.Size = New Size(574, 48)
        ApplicationTitle.TabIndex = 0
        ApplicationTitle.Text = "Anwendungstitel"
        ApplicationTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' SplashScreen1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.splash_background
        ClientSize = New Size(598, 598)
        ControlBox = False
        Controls.Add(Copyright)
        Controls.Add(Version)
        Controls.Add(ApplicationTitle)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "SplashScreen1"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)

    End Sub

    Public WithEvents Version As Label

End Class
