<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmServerManager
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
        Panel_bottom = New Panel()
        Button_close = New Button()
        Button_delete = New Button()
        Button_apply = New Button()
        DataGridView_servers = New DataGridView()
        col_name = New DataGridViewTextBoxColumn()
        col_host = New DataGridViewTextBoxColumn()
        col_apikey = New DataGridViewTextBoxColumn()
        Button_export = New Button()
        Button_import = New Button()
        Panel_bottom.SuspendLayout()
        CType(DataGridView_servers, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel_bottom
        ' 
        Panel_bottom.Controls.Add(Button_import)
        Panel_bottom.Controls.Add(Button_export)
        Panel_bottom.Controls.Add(Button_close)
        Panel_bottom.Controls.Add(Button_delete)
        Panel_bottom.Controls.Add(Button_apply)
        Panel_bottom.Dock = DockStyle.Bottom
        Panel_bottom.Location = New Point(0, 229)
        Panel_bottom.Name = "Panel_bottom"
        Panel_bottom.Size = New Size(684, 32)
        Panel_bottom.TabIndex = 0
        ' 
        ' Button_close
        ' 
        Button_close.Location = New Point(597, 5)
        Button_close.Name = "Button_close"
        Button_close.Size = New Size(75, 23)
        Button_close.TabIndex = 3
        Button_close.Text = "Close"
        Button_close.UseVisualStyleBackColor = True
        ' 
        ' Button_delete
        ' 
        Button_delete.Location = New Point(516, 5)
        Button_delete.Name = "Button_delete"
        Button_delete.Size = New Size(75, 23)
        Button_delete.TabIndex = 1
        Button_delete.Text = "Delete"
        Button_delete.UseVisualStyleBackColor = True
        ' 
        ' Button_apply
        ' 
        Button_apply.Location = New Point(435, 5)
        Button_apply.Name = "Button_apply"
        Button_apply.Size = New Size(75, 23)
        Button_apply.TabIndex = 0
        Button_apply.Text = "Apply"
        Button_apply.UseVisualStyleBackColor = True
        ' 
        ' DataGridView_servers
        ' 
        DataGridView_servers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView_servers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView_servers.Columns.AddRange(New DataGridViewColumn() {col_name, col_host, col_apikey})
        DataGridView_servers.Dock = DockStyle.Fill
        DataGridView_servers.Location = New Point(0, 0)
        DataGridView_servers.MultiSelect = False
        DataGridView_servers.Name = "DataGridView_servers"
        DataGridView_servers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView_servers.Size = New Size(684, 229)
        DataGridView_servers.TabIndex = 1
        ' 
        ' col_name
        ' 
        col_name.HeaderText = "Title"
        col_name.Name = "col_name"
        ' 
        ' col_host
        ' 
        col_host.HeaderText = "Address / Host"
        col_host.Name = "col_host"
        ' 
        ' col_apikey
        ' 
        col_apikey.HeaderText = "API Key"
        col_apikey.Name = "col_apikey"
        ' 
        ' Button_export
        ' 
        Button_export.Location = New Point(12, 5)
        Button_export.Name = "Button_export"
        Button_export.Size = New Size(75, 23)
        Button_export.TabIndex = 4
        Button_export.Text = "Export"
        Button_export.UseVisualStyleBackColor = True
        ' 
        ' Button_import
        ' 
        Button_import.Location = New Point(93, 5)
        Button_import.Name = "Button_import"
        Button_import.Size = New Size(75, 23)
        Button_import.TabIndex = 5
        Button_import.Text = "Import"
        Button_import.UseVisualStyleBackColor = True
        ' 
        ' FrmServerManager
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(684, 261)
        Controls.Add(DataGridView_servers)
        Controls.Add(Panel_bottom)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "FrmServerManager"
        StartPosition = FormStartPosition.CenterParent
        Text = "Ollama Server Manager"
        Panel_bottom.ResumeLayout(False)
        CType(DataGridView_servers, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel_bottom As Panel
    Friend WithEvents Button_apply As Button
    Friend WithEvents Button_close As Button
    Friend WithEvents Button_delete As Button
    Friend WithEvents DataGridView_servers As DataGridView
    Friend WithEvents col_name As DataGridViewTextBoxColumn
    Friend WithEvents col_host As DataGridViewTextBoxColumn
    Friend WithEvents col_apikey As DataGridViewTextBoxColumn
    Friend WithEvents Button_import As Button
    Friend WithEvents Button_export As Button
End Class
