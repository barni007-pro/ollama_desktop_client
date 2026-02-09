<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim LayoutState3 As SiticoneNetCoreUI.SiticoneFlowPanel.LayoutState = New SiticoneNetCoreUI.SiticoneFlowPanel.LayoutState()
        Dim NavBarItem3 As SiticoneNetCoreUI.NavBarItem = New SiticoneNetCoreUI.NavBarItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        WebView21 = New Microsoft.Web.WebView2.WinForms.WebView2()
        SiticoneTextBox_host = New SiticoneNetCoreUI.SiticoneTextBox()
        SiticoneDropdown_model = New SiticoneNetCoreUI.SiticoneDropdown()
        SiticoneButton_get_llm = New SiticoneNetCoreUI.SiticoneButton()
        SiticoneTextArea_prompt = New SiticoneNetCoreUI.SiticoneTextArea()
        SiticoneButton_file = New SiticoneNetCoreUI.SiticoneButton()
        SiticoneTabControl_tab = New SiticoneNetCoreUI.SiticoneTabControl()
        TabPage_modelinfo = New TabPage()
        SiticoneChip_model_info_Image = New SiticoneNetCoreUI.SiticoneChip()
        Scintilla_model_info = New ScintillaNET.Scintilla()
        Scintilla_model_info_request = New ScintillaNET.Scintilla()
        SiticoneButton_show_licence = New SiticoneNetCoreUI.SiticoneButton()
        SiticoneChip_model_info_Context = New SiticoneNetCoreUI.SiticoneChip()
        SiticoneChip_model_info_Embedding = New SiticoneNetCoreUI.SiticoneChip()
        SiticoneChip_model_info_Thinking = New SiticoneNetCoreUI.SiticoneChip()
        SiticoneChip_model_info_Tools = New SiticoneNetCoreUI.SiticoneChip()
        SiticoneChip_model_info_Vision = New SiticoneNetCoreUI.SiticoneChip()
        SiticoneLabel1_model_info_description = New SiticoneNetCoreUI.SiticoneLabel()
        TabPage_modelparameter = New TabPage()
        SiticoneFlatPanel_trenn3 = New SiticoneNetCoreUI.SiticoneFlatPanel()
        SiticoneFlatPanel_thinking_use = New SiticoneNetCoreUI.SiticoneFlatPanel()
        SiticoneLabel_thinking_use = New SiticoneNetCoreUI.SiticoneLabel()
        SiticoneToggleSwitch_thinking_use = New SiticoneNetCoreUI.SiticoneToggleSwitch()
        SiticoneDropdown_thinking_use = New SiticoneNetCoreUI.SiticoneDropdown()
        SiticoneFlatPanel_trenn2 = New SiticoneNetCoreUI.SiticoneFlatPanel()
        SiticoneLabel5 = New SiticoneNetCoreUI.SiticoneLabel()
        SiticoneTextBox_timeout = New SiticoneNetCoreUI.SiticoneTextBox()
        SiticoneFlatPanel_trenn1 = New SiticoneNetCoreUI.SiticoneFlatPanel()
        SiticoneFlatPanel_last_context = New SiticoneNetCoreUI.SiticoneFlatPanel()
        SiticoneLabel_last_context = New SiticoneNetCoreUI.SiticoneLabel()
        SiticoneToggleSwitch_last_context = New SiticoneNetCoreUI.SiticoneToggleSwitch()
        SiticoneButton_save_context = New SiticoneNetCoreUI.SiticoneButton()
        SiticoneButton_clear_context = New SiticoneNetCoreUI.SiticoneButton()
        SiticoneButton_load_context = New SiticoneNetCoreUI.SiticoneButton()
        SiticoneFlatPanel_format_use = New SiticoneNetCoreUI.SiticoneFlatPanel()
        SiticoneLabel_format_use = New SiticoneNetCoreUI.SiticoneLabel()
        SiticoneToggleSwitch_format_use = New SiticoneNetCoreUI.SiticoneToggleSwitch()
        SiticoneFlatPanel_system_use = New SiticoneNetCoreUI.SiticoneFlatPanel()
        SiticoneLabel_system_use = New SiticoneNetCoreUI.SiticoneLabel()
        SiticoneToggleSwitch_system_use = New SiticoneNetCoreUI.SiticoneToggleSwitch()
        Scintilla_format = New ScintillaNET.Scintilla()
        SiticoneButton_link_content_prompt = New SiticoneNetCoreUI.SiticoneButton()
        SiticoneTextArea_content_prompt = New SiticoneNetCoreUI.SiticoneTextArea()
        SiticoneLabel13 = New SiticoneNetCoreUI.SiticoneLabel()
        SiticoneButton_link_output_format = New SiticoneNetCoreUI.SiticoneButton()
        SiticoneButton_link_system_prompt = New SiticoneNetCoreUI.SiticoneButton()
        SiticoneButton_link_options_parameter = New SiticoneNetCoreUI.SiticoneButton()
        SiticoneLabel6 = New SiticoneNetCoreUI.SiticoneLabel()
        SiticoneButton_load_parameter = New SiticoneNetCoreUI.SiticoneButton()
        SiticoneButton_save_parameter = New SiticoneNetCoreUI.SiticoneButton()
        SiticoneLabel1 = New SiticoneNetCoreUI.SiticoneLabel()
        dgv_option = New DataGridView()
        SiticoneLabel4 = New SiticoneNetCoreUI.SiticoneLabel()
        SiticoneTextArea_system = New SiticoneNetCoreUI.SiticoneTextArea()
        TabPage_tool = New TabPage()
        SiticoneFlatPanel_tools = New SiticoneNetCoreUI.SiticoneFlatPanel()
        SiticoneLabel_tools = New SiticoneNetCoreUI.SiticoneLabel()
        SiticoneToggleSwitch_tools = New SiticoneNetCoreUI.SiticoneToggleSwitch()
        Scintilla_Tools_pythoncode = New ScintillaNET.Scintilla()
        Scintilla_Tools_Json = New ScintillaNET.Scintilla()
        SiticoneButton_link_tool_python_code = New SiticoneNetCoreUI.SiticoneButton()
        SiticoneButton_link_tool_json = New SiticoneNetCoreUI.SiticoneButton()
        SiticoneButton_link_tool_system_prompt = New SiticoneNetCoreUI.SiticoneButton()
        SiticoneLabel10 = New SiticoneNetCoreUI.SiticoneLabel()
        SiticoneButton_resp_clp = New SiticoneNetCoreUI.SiticoneButton()
        SiticoneButton_load_tools = New SiticoneNetCoreUI.SiticoneButton()
        SiticoneButton_save_tools = New SiticoneNetCoreUI.SiticoneButton()
        SiticoneTextBox_request_answer = New SiticoneNetCoreUI.SiticoneTextBox()
        SiticoneTextArea_Tools_system = New SiticoneNetCoreUI.SiticoneTextArea()
        SiticoneLabel9 = New SiticoneNetCoreUI.SiticoneLabel()
        SiticoneLabel8 = New SiticoneNetCoreUI.SiticoneLabel()
        SiticoneLabel7 = New SiticoneNetCoreUI.SiticoneLabel()
        TabPage_ragtool = New TabPage()
        SiticoneFlatPanel_ragtools = New SiticoneNetCoreUI.SiticoneFlatPanel()
        SiticoneLabel_ragtools = New SiticoneNetCoreUI.SiticoneLabel()
        SiticoneToggleSwitch_ragtools = New SiticoneNetCoreUI.SiticoneToggleSwitch()
        Scintilla_Rag_Json = New ScintillaNET.Scintilla()
        SiticoneButton_link_rag_tool_json = New SiticoneNetCoreUI.SiticoneButton()
        SiticoneButton_link_rag_tool_system_prompt = New SiticoneNetCoreUI.SiticoneButton()
        SiticoneButton_load_rag = New SiticoneNetCoreUI.SiticoneButton()
        SiticoneButton_save_rag = New SiticoneNetCoreUI.SiticoneButton()
        SiticoneTextArea_Rag_system = New SiticoneNetCoreUI.SiticoneTextArea()
        SiticoneLabel11 = New SiticoneNetCoreUI.SiticoneLabel()
        SiticoneLabel12 = New SiticoneNetCoreUI.SiticoneLabel()
        SiticoneDropdown_delta_val = New SiticoneNetCoreUI.SiticoneDropdown()
        SiticoneLabel1_delta = New SiticoneNetCoreUI.SiticoneLabel()
        SiticoneButton_resp_clp_rag = New SiticoneNetCoreUI.SiticoneButton()
        SiticoneLabel_HitCountVal = New SiticoneNetCoreUI.SiticoneLabel()
        SiticoneLabel_HitCount = New SiticoneNetCoreUI.SiticoneLabel()
        SiticoneLabel_SentencesCountVal = New SiticoneNetCoreUI.SiticoneLabel()
        SiticoneLabel_SentencesCount = New SiticoneNetCoreUI.SiticoneLabel()
        SiticoneButton_ragpath = New SiticoneNetCoreUI.SiticoneButton()
        SiticoneLabel1_ragpath = New SiticoneNetCoreUI.SiticoneLabel()
        SiticoneTextBox_ragpath = New SiticoneNetCoreUI.SiticoneTextBox()
        TabPage_requestjson = New TabPage()
        Scintilla_Request_JSON = New ScintillaNET.Scintilla()
        TabPage_responsejson = New TabPage()
        Scintilla_Response_JSON = New ScintillaNET.Scintilla()
        TabPage_responsemd = New TabPage()
        Scintilla_response = New ScintillaNET.Scintilla()
        TabPage_responsehtml = New TabPage()
        TabPage_codeparameter = New TabPage()
        SiticoneButton_link_execute_list = New SiticoneNetCoreUI.SiticoneButton()
        SiticoneButton_load_execute = New SiticoneNetCoreUI.SiticoneButton()
        SiticoneButton_save_execute = New SiticoneNetCoreUI.SiticoneButton()
        dvg_execute = New DataGridView()
        SiticoneLabel2 = New SiticoneNetCoreUI.SiticoneLabel()
        TabPage_codeblock = New TabPage()
        SiticoneFlatPanel_UseShellExecute = New SiticoneNetCoreUI.SiticoneFlatPanel()
        SiticoneLabel_UseShellExecute = New SiticoneNetCoreUI.SiticoneLabel()
        SiticoneToggleSwitch_UseShellExecute = New SiticoneNetCoreUI.SiticoneToggleSwitch()
        SiticoneButton_execute_run = New SiticoneNetCoreUI.SiticoneButton()
        SiticoneButton_code_save = New SiticoneNetCoreUI.SiticoneButton()
        SiticoneLabel_runpath = New SiticoneNetCoreUI.SiticoneLabel()
        SiticoneSplitContainer_runcont = New SiticoneNetCoreUI.SiticoneSplitContainer()
        Scintilla_code_block = New ScintillaNET.Scintilla()
        SiticoneTextArea_run_output = New SiticoneNetCoreUI.SiticoneTextArea()
        SiticoneButton_code_run = New SiticoneNetCoreUI.SiticoneButton()
        SiticoneDropdown_language = New SiticoneNetCoreUI.SiticoneDropdown()
        ToolTip1 = New ToolTip(components)
        SiticoneLabel_host = New SiticoneNetCoreUI.SiticoneLabel()
        SiticoneLabel_model = New SiticoneNetCoreUI.SiticoneLabel()
        SiticoneButton_chat_clear = New SiticoneNetCoreUI.SiticoneButton()
        SiticoneDropdown_API = New SiticoneNetCoreUI.SiticoneDropdown()
        SiticoneLabel_API = New SiticoneNetCoreUI.SiticoneLabel()
        SiticoneLabel_chat_clear = New SiticoneNetCoreUI.SiticoneLabel()
        SiticoneButton_HTMLtoPDF = New SiticoneNetCoreUI.SiticoneButton()
        SiticonePanel_prompt = New SiticoneNetCoreUI.SiticonePanel()
        SiticonePanel_prompt_action = New SiticoneNetCoreUI.SiticonePanel()
        SiticoneToggleSwitch_show_menue = New SiticoneNetCoreUI.SiticoneToggleSwitch()
        SiticoneLabel_show_LLM = New SiticoneNetCoreUI.SiticoneLabel()
        SiticonePlayPauseButton_request = New SiticoneNetCoreUI.SiticonePlayPauseButton()
        SiticoneButton_screenshot = New SiticoneNetCoreUI.SiticoneButton()
        SiticoneButton_timing = New SiticoneNetCoreUI.SiticoneButton()
        SiticoneButton_show_thinking = New SiticoneNetCoreUI.SiticoneButton()
        SiticoneLoadingSpinner_request = New SiticoneNetCoreUI.SiticoneLoadingSpinner()
        SiticoneFlowPanel_prompt_filecontent = New SiticoneNetCoreUI.SiticoneFlowPanel()
        MySiticoneLicenseSettings1 = New SiticoneNetCoreUI.MySiticoneLicenseSettings()
        SiticoneButton_switch_chat = New SiticoneNetCoreUI.SiticoneButton()
        SiticoneLabel_default = New SiticoneNetCoreUI.SiticoneLabel()
        SiticoneDropdown_default = New SiticoneNetCoreUI.SiticoneDropdown()
        SiticoneButton_preload = New SiticoneNetCoreUI.SiticoneButton()
        SiticoneLabel_test = New SiticoneNetCoreUI.SiticoneLabel()
        SiticoneToggleSwitch_test = New SiticoneNetCoreUI.SiticoneToggleSwitch()
        SiticoneGroupBox_LLM_setting = New SiticoneNetCoreUI.SiticoneGroupBox()
        SiticoneNavbar_tab = New SiticoneNetCoreUI.SiticoneNavbar()
        SiticonePanel_dock = New SiticoneNetCoreUI.SiticonePanel()
        CType(WebView21, ComponentModel.ISupportInitialize).BeginInit()
        SiticoneTabControl_tab.SuspendLayout()
        TabPage_modelinfo.SuspendLayout()
        TabPage_modelparameter.SuspendLayout()
        SiticoneFlatPanel_trenn3.SuspendLayout()
        SiticoneFlatPanel_thinking_use.SuspendLayout()
        SiticoneFlatPanel_trenn2.SuspendLayout()
        SiticoneFlatPanel_trenn1.SuspendLayout()
        SiticoneFlatPanel_last_context.SuspendLayout()
        SiticoneFlatPanel_format_use.SuspendLayout()
        SiticoneFlatPanel_system_use.SuspendLayout()
        CType(dgv_option, ComponentModel.ISupportInitialize).BeginInit()
        TabPage_tool.SuspendLayout()
        SiticoneFlatPanel_tools.SuspendLayout()
        TabPage_ragtool.SuspendLayout()
        SiticoneFlatPanel_ragtools.SuspendLayout()
        TabPage_requestjson.SuspendLayout()
        TabPage_responsejson.SuspendLayout()
        TabPage_responsemd.SuspendLayout()
        TabPage_responsehtml.SuspendLayout()
        TabPage_codeparameter.SuspendLayout()
        CType(dvg_execute, ComponentModel.ISupportInitialize).BeginInit()
        TabPage_codeblock.SuspendLayout()
        SiticoneFlatPanel_UseShellExecute.SuspendLayout()
        CType(SiticoneSplitContainer_runcont, ComponentModel.ISupportInitialize).BeginInit()
        SiticoneSplitContainer_runcont.Panel1.SuspendLayout()
        SiticoneSplitContainer_runcont.Panel2.SuspendLayout()
        SiticoneSplitContainer_runcont.SuspendLayout()
        SiticonePanel_prompt.SuspendLayout()
        SiticonePanel_prompt_action.SuspendLayout()
        SiticoneGroupBox_LLM_setting.SuspendLayout()
        SiticonePanel_dock.SuspendLayout()
        SuspendLayout()
        ' 
        ' WebView21
        ' 
        WebView21.AllowExternalDrop = True
        WebView21.CreationProperties = Nothing
        WebView21.DefaultBackgroundColor = Color.White
        WebView21.Dock = DockStyle.Fill
        WebView21.Location = New Point(3, 3)
        WebView21.Name = "WebView21"
        WebView21.Size = New Size(1401, 624)
        WebView21.TabIndex = 0
        WebView21.ZoomFactor = 1.1R
        ' 
        ' SiticoneTextBox_host
        ' 
        SiticoneTextBox_host.AccessibleDescription = "A customizable text input field."
        SiticoneTextBox_host.AccessibleName = "Text Box"
        SiticoneTextBox_host.AccessibleRole = AccessibleRole.Text
        SiticoneTextBox_host.BackColor = Color.Transparent
        SiticoneTextBox_host.BlinkCount = 3
        SiticoneTextBox_host.BlinkShadow = False
        SiticoneTextBox_host.BorderColor1 = Color.LightSlateGray
        SiticoneTextBox_host.BorderColor2 = Color.LightSlateGray
        SiticoneTextBox_host.BorderFocusColor1 = Color.FromArgb(CByte(77), CByte(77), CByte(255))
        SiticoneTextBox_host.BorderFocusColor2 = Color.FromArgb(CByte(77), CByte(77), CByte(255))
        SiticoneTextBox_host.CanShake = True
        SiticoneTextBox_host.ContinuousBlink = False
        SiticoneTextBox_host.CornerRadiusBottomLeft = 8
        SiticoneTextBox_host.CornerRadiusBottomRight = 8
        SiticoneTextBox_host.CornerRadiusTopLeft = 8
        SiticoneTextBox_host.CornerRadiusTopRight = 8
        SiticoneTextBox_host.CursorBlinkRate = 500
        SiticoneTextBox_host.CursorColor = Color.Black
        SiticoneTextBox_host.CursorHeight = 26
        SiticoneTextBox_host.CursorOffset = 0
        SiticoneTextBox_host.CursorStyle = SiticoneNetCoreUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid
        SiticoneTextBox_host.CursorWidth = 1
        SiticoneTextBox_host.DisabledBackColor = Color.WhiteSmoke
        SiticoneTextBox_host.DisabledBorderColor = Color.LightGray
        SiticoneTextBox_host.DisabledTextColor = Color.Gray
        SiticoneTextBox_host.EnableDropShadow = False
        SiticoneTextBox_host.FillColor1 = Color.AliceBlue
        SiticoneTextBox_host.FillColor2 = Color.AliceBlue
        SiticoneTextBox_host.Font = New Font("Segoe UI", 9.5F)
        SiticoneTextBox_host.ForeColor = Color.DimGray
        SiticoneTextBox_host.HoverBorderColor1 = Color.Gray
        SiticoneTextBox_host.HoverBorderColor2 = Color.Gray
        SiticoneTextBox_host.IsEnabled = True
        SiticoneTextBox_host.Location = New Point(12, 51)
        SiticoneTextBox_host.Name = "SiticoneTextBox_host"
        SiticoneTextBox_host.PlaceholderColor = Color.Gray
        SiticoneTextBox_host.PlaceholderText = "Enter Ollama Address:"
        SiticoneTextBox_host.ReadOnlyBorderColor1 = Color.LightGray
        SiticoneTextBox_host.ReadOnlyBorderColor2 = Color.LightGray
        SiticoneTextBox_host.ReadOnlyFillColor1 = Color.WhiteSmoke
        SiticoneTextBox_host.ReadOnlyFillColor2 = Color.WhiteSmoke
        SiticoneTextBox_host.ReadOnlyPlaceholderColor = Color.DarkGray
        SiticoneTextBox_host.SelectionBackColor = Color.FromArgb(CByte(77), CByte(77), CByte(255))
        SiticoneTextBox_host.ShadowAnimationDuration = 1
        SiticoneTextBox_host.ShadowBlur = 10
        SiticoneTextBox_host.ShadowColor = Color.FromArgb(CByte(15), CByte(0), CByte(0), CByte(0))
        SiticoneTextBox_host.Size = New Size(259, 30)
        SiticoneTextBox_host.SolidBorderColor = Color.LightSlateGray
        SiticoneTextBox_host.SolidBorderFocusColor = Color.FromArgb(CByte(77), CByte(77), CByte(255))
        SiticoneTextBox_host.SolidBorderHoverColor = Color.Gray
        SiticoneTextBox_host.SolidFillColor = Color.FromArgb(CByte(209), CByte(232), CByte(255))
        SiticoneTextBox_host.TabIndex = 14
        SiticoneTextBox_host.Text = "localhost:11434"
        SiticoneTextBox_host.TextPadding = New Padding(16, 0, 6, 0)
        SiticoneTextBox_host.ValidationErrorMessage = "Invalid input."
        SiticoneTextBox_host.ValidationFunction = Nothing
        ' 
        ' SiticoneDropdown_model
        ' 
        SiticoneDropdown_model.AllowMultipleSelection = False
        SiticoneDropdown_model.BackColor = Color.FromArgb(CByte(209), CByte(232), CByte(255))
        SiticoneDropdown_model.BorderColor = Color.Gray
        SiticoneDropdown_model.BorderSize = 2
        SiticoneDropdown_model.CanBeep = False
        SiticoneDropdown_model.CanShake = True
        SiticoneDropdown_model.CornerRadius = 8
        SiticoneDropdown_model.DataSource = Nothing
        SiticoneDropdown_model.DisplayMember = Nothing
        SiticoneDropdown_model.DropdownBackColor = Color.White
        SiticoneDropdown_model.DropdownCornerRadius = 8
        SiticoneDropdown_model.DropdownWidth = 0
        SiticoneDropdown_model.DropShadowEnabled = False
        SiticoneDropdown_model.Font = New Font("Segoe UI", 10F)
        SiticoneDropdown_model.ForeColor = Color.DimGray
        SiticoneDropdown_model.HoveredItemBackColor = Color.LightGray
        SiticoneDropdown_model.HoveredItemTextColor = Color.Black
        SiticoneDropdown_model.IsReadonly = False
        SiticoneDropdown_model.ItemHeight = 30
        SiticoneDropdown_model.Location = New Point(390, 51)
        SiticoneDropdown_model.MaxDropDownItems = 8
        SiticoneDropdown_model.Name = "SiticoneDropdown_model"
        SiticoneDropdown_model.NotFoundBackColor = Color.Transparent
        SiticoneDropdown_model.NotFoundFont = Nothing
        SiticoneDropdown_model.NotFoundTextColor = Color.Gray
        SiticoneDropdown_model.PlaceholderColor = Color.Gray
        SiticoneDropdown_model.PlaceholderDisappearsOnFocus = False
        SiticoneDropdown_model.PlaceholderText = "Select a model"
        SiticoneDropdown_model.SearchTextColor = Color.DimGray
        SiticoneDropdown_model.SearchTextFont = Nothing
        SiticoneDropdown_model.SelectedIndex = -1
        SiticoneDropdown_model.SelectedItem = Nothing
        SiticoneDropdown_model.SelectedItemBackColor = Color.LightBlue
        SiticoneDropdown_model.SelectedItemTextColor = Color.Black
        SiticoneDropdown_model.SelectedValue = Nothing
        SiticoneDropdown_model.Size = New Size(288, 30)
        SiticoneDropdown_model.TabIndex = 15
        SiticoneDropdown_model.UnselectedItemTextColor = Color.Black
        SiticoneDropdown_model.ValueMember = Nothing
        ' 
        ' SiticoneButton_get_llm
        ' 
        SiticoneButton_get_llm.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard"
        SiticoneButton_get_llm.AccessibleName = "Get LLM List"
        SiticoneButton_get_llm.AutoSizeBasedOnText = False
        SiticoneButton_get_llm.BackColor = Color.Transparent
        SiticoneButton_get_llm.BadgeBackColor = Color.Red
        SiticoneButton_get_llm.BadgeFont = New Font("Segoe UI", 8F, FontStyle.Bold)
        SiticoneButton_get_llm.BadgeValue = 0
        SiticoneButton_get_llm.BadgeValueForeColor = Color.White
        SiticoneButton_get_llm.BorderColor = Color.FromArgb(CByte(16), CByte(100), CByte(220))
        SiticoneButton_get_llm.BorderWidth = 2
        SiticoneButton_get_llm.ButtonBackColor = Color.FromArgb(CByte(26), CByte(115), CByte(232))
        SiticoneButton_get_llm.ButtonImage = Nothing
        SiticoneButton_get_llm.ButtonTextLeftPadding = 0
        SiticoneButton_get_llm.CanBeep = True
        SiticoneButton_get_llm.CanGlow = True
        SiticoneButton_get_llm.CanShake = True
        SiticoneButton_get_llm.ContextMenuStripEx = Nothing
        SiticoneButton_get_llm.CornerRadiusBottomLeft = 8
        SiticoneButton_get_llm.CornerRadiusBottomRight = 8
        SiticoneButton_get_llm.CornerRadiusTopLeft = 8
        SiticoneButton_get_llm.CornerRadiusTopRight = 8
        SiticoneButton_get_llm.CustomCursor = Cursors.Default
        SiticoneButton_get_llm.DisabledTextColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        SiticoneButton_get_llm.EnableLongPress = False
        SiticoneButton_get_llm.EnablePressAnimation = True
        SiticoneButton_get_llm.EnableRippleEffect = True
        SiticoneButton_get_llm.EnableShadow = True
        SiticoneButton_get_llm.EnableTextWrapping = False
        SiticoneButton_get_llm.Font = New Font("Segoe UI", 9F)
        SiticoneButton_get_llm.GlowColor = Color.FromArgb(CByte(30), CByte(110), CByte(178), CByte(230))
        SiticoneButton_get_llm.GlowIntensity = 100
        SiticoneButton_get_llm.GlowRadius = 20F
        SiticoneButton_get_llm.GradientBackground = False
        SiticoneButton_get_llm.GradientColor = Color.FromArgb(CByte(255), CByte(77), CByte(146))
        SiticoneButton_get_llm.GradientMode = Drawing2D.LinearGradientMode.ForwardDiagonal
        SiticoneButton_get_llm.HintText = Nothing
        SiticoneButton_get_llm.HoverBackColor = Color.FromArgb(CByte(40), CByte(130), CByte(240))
        SiticoneButton_get_llm.HoverFontStyle = FontStyle.Regular
        SiticoneButton_get_llm.HoverTextColor = Color.White
        SiticoneButton_get_llm.HoverTransitionDuration = 250
        SiticoneButton_get_llm.ImageAlign = ContentAlignment.MiddleLeft
        SiticoneButton_get_llm.ImagePadding = 5
        SiticoneButton_get_llm.ImageSize = New Size(16, 16)
        SiticoneButton_get_llm.IsRadial = False
        SiticoneButton_get_llm.IsReadOnly = False
        SiticoneButton_get_llm.IsToggleButton = False
        SiticoneButton_get_llm.IsToggled = False
        SiticoneButton_get_llm.Location = New Point(277, 51)
        SiticoneButton_get_llm.LongPressDurationMS = 1000
        SiticoneButton_get_llm.Name = "SiticoneButton_get_llm"
        SiticoneButton_get_llm.NormalFontStyle = FontStyle.Regular
        SiticoneButton_get_llm.ParticleColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        SiticoneButton_get_llm.ParticleCount = 15
        SiticoneButton_get_llm.PressAnimationScale = 0.97F
        SiticoneButton_get_llm.PressedBackColor = Color.FromArgb(CByte(16), CByte(100), CByte(220))
        SiticoneButton_get_llm.PressedFontStyle = FontStyle.Regular
        SiticoneButton_get_llm.PressTransitionDuration = 150
        SiticoneButton_get_llm.ReadOnlyTextColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        SiticoneButton_get_llm.RippleColor = Color.White
        SiticoneButton_get_llm.RippleOpacity = 0.2F
        SiticoneButton_get_llm.RippleRadiusMultiplier = 0.6F
        SiticoneButton_get_llm.ShadowBlur = 5
        SiticoneButton_get_llm.ShadowColor = Color.FromArgb(CByte(50), CByte(0), CByte(64), CByte(128))
        SiticoneButton_get_llm.ShadowOffset = New Point(0, 2)
        SiticoneButton_get_llm.ShakeDuration = 500
        SiticoneButton_get_llm.ShakeIntensity = 5
        SiticoneButton_get_llm.Size = New Size(107, 30)
        SiticoneButton_get_llm.TabIndex = 30
        SiticoneButton_get_llm.Text = "Get LLM List"
        SiticoneButton_get_llm.TextAlign = ContentAlignment.MiddleCenter
        SiticoneButton_get_llm.TextColor = Color.White
        SiticoneButton_get_llm.TooltipText = Nothing
        SiticoneButton_get_llm.UseAdvancedRendering = True
        SiticoneButton_get_llm.UseParticles = False
        ' 
        ' SiticoneTextArea_prompt
        ' 
        SiticoneTextArea_prompt.BackColor = Color.LightGray
        SiticoneTextArea_prompt.BorderStyle = BorderStyle.None
        SiticoneTextArea_prompt.Dock = DockStyle.Top
        SiticoneTextArea_prompt.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SiticoneTextArea_prompt.Location = New Point(10, 10)
        SiticoneTextArea_prompt.Margin = New Padding(5)
        SiticoneTextArea_prompt.MinimumSize = New Size(100, 10)
        SiticoneTextArea_prompt.Multiline = True
        SiticoneTextArea_prompt.Name = "SiticoneTextArea_prompt"
        SiticoneTextArea_prompt.PlaceholderText = "Write Prompt here..."
        SiticoneTextArea_prompt.ScrollBars = ScrollBars.Vertical
        SiticoneTextArea_prompt.Size = New Size(1465, 36)
        SiticoneTextArea_prompt.TabIndex = 17
        ' 
        ' SiticoneButton_file
        ' 
        SiticoneButton_file.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard"
        SiticoneButton_file.AccessibleName = ""
        SiticoneButton_file.AutoSizeBasedOnText = False
        SiticoneButton_file.BackColor = Color.Transparent
        SiticoneButton_file.BadgeBackColor = Color.Red
        SiticoneButton_file.BadgeFont = New Font("Segoe UI", 8F, FontStyle.Bold)
        SiticoneButton_file.BadgeValue = 0
        SiticoneButton_file.BadgeValueForeColor = Color.White
        SiticoneButton_file.BorderColor = Color.Transparent
        SiticoneButton_file.BorderWidth = 2
        SiticoneButton_file.ButtonBackColor = Color.Transparent
        SiticoneButton_file.ButtonImage = My.Resources.Resource_pic.paperclip_32
        SiticoneButton_file.ButtonTextLeftPadding = 0
        SiticoneButton_file.CanBeep = True
        SiticoneButton_file.CanGlow = False
        SiticoneButton_file.CanShake = True
        SiticoneButton_file.ContextMenuStripEx = Nothing
        SiticoneButton_file.CornerRadiusBottomLeft = 8
        SiticoneButton_file.CornerRadiusBottomRight = 8
        SiticoneButton_file.CornerRadiusTopLeft = 8
        SiticoneButton_file.CornerRadiusTopRight = 8
        SiticoneButton_file.CustomCursor = Cursors.Default
        SiticoneButton_file.DisabledTextColor = Color.Transparent
        SiticoneButton_file.EnableLongPress = False
        SiticoneButton_file.EnablePressAnimation = True
        SiticoneButton_file.EnableRippleEffect = True
        SiticoneButton_file.EnableShadow = False
        SiticoneButton_file.EnableTextWrapping = False
        SiticoneButton_file.Font = New Font("Segoe UI", 9F)
        SiticoneButton_file.ForeColor = Color.LightGray
        SiticoneButton_file.GlowColor = Color.FromArgb(CByte(30), CByte(110), CByte(178), CByte(230))
        SiticoneButton_file.GlowIntensity = 100
        SiticoneButton_file.GlowRadius = 20F
        SiticoneButton_file.GradientBackground = False
        SiticoneButton_file.GradientColor = Color.FromArgb(CByte(255), CByte(77), CByte(146))
        SiticoneButton_file.GradientMode = Drawing2D.LinearGradientMode.ForwardDiagonal
        SiticoneButton_file.HintText = Nothing
        SiticoneButton_file.HoverBackColor = SystemColors.ActiveCaption
        SiticoneButton_file.HoverFontStyle = FontStyle.Regular
        SiticoneButton_file.HoverTextColor = Color.White
        SiticoneButton_file.HoverTransitionDuration = 250
        SiticoneButton_file.ImageAlign = ContentAlignment.MiddleCenter
        SiticoneButton_file.ImagePadding = 0
        SiticoneButton_file.ImageSize = New Size(32, 32)
        SiticoneButton_file.IsRadial = False
        SiticoneButton_file.IsReadOnly = False
        SiticoneButton_file.IsToggleButton = False
        SiticoneButton_file.IsToggled = False
        SiticoneButton_file.Location = New Point(54, 1)
        SiticoneButton_file.LongPressDurationMS = 1000
        SiticoneButton_file.Name = "SiticoneButton_file"
        SiticoneButton_file.NormalFontStyle = FontStyle.Regular
        SiticoneButton_file.ParticleColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        SiticoneButton_file.ParticleCount = 15
        SiticoneButton_file.PressAnimationScale = 0.97F
        SiticoneButton_file.PressedBackColor = Color.FromArgb(CByte(16), CByte(100), CByte(220))
        SiticoneButton_file.PressedFontStyle = FontStyle.Regular
        SiticoneButton_file.PressTransitionDuration = 150
        SiticoneButton_file.ReadOnlyTextColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        SiticoneButton_file.RippleColor = Color.White
        SiticoneButton_file.RippleOpacity = 0.2F
        SiticoneButton_file.RippleRadiusMultiplier = 0.6F
        SiticoneButton_file.ShadowBlur = 5
        SiticoneButton_file.ShadowColor = Color.FromArgb(CByte(50), CByte(0), CByte(64), CByte(128))
        SiticoneButton_file.ShadowOffset = New Point(0, 2)
        SiticoneButton_file.ShakeDuration = 500
        SiticoneButton_file.ShakeIntensity = 5
        SiticoneButton_file.Size = New Size(32, 32)
        SiticoneButton_file.TabIndex = 16
        SiticoneButton_file.TextAlign = ContentAlignment.MiddleCenter
        SiticoneButton_file.TextColor = Color.White
        SiticoneButton_file.TooltipText = "Add File to Context"
        SiticoneButton_file.UseAdvancedRendering = True
        SiticoneButton_file.UseParticles = False
        ' 
        ' SiticoneTabControl_tab
        ' 
        SiticoneTabControl_tab.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        SiticoneTabControl_tab.BorderColor = Color.Transparent
        SiticoneTabControl_tab.BorderWidth = 1
        SiticoneTabControl_tab.CloseButtonColor = Color.Gray
        SiticoneTabControl_tab.CloseButtonHoverColor = Color.Red
        SiticoneTabControl_tab.CloseButtonSymbolPadding = 0.25F
        SiticoneTabControl_tab.CloseButtonThickness = 1.8F
        SiticoneTabControl_tab.ContextMenuFont = New Font("Segoe UI", 10F)
        SiticoneTabControl_tab.Controls.Add(TabPage_modelinfo)
        SiticoneTabControl_tab.Controls.Add(TabPage_modelparameter)
        SiticoneTabControl_tab.Controls.Add(TabPage_tool)
        SiticoneTabControl_tab.Controls.Add(TabPage_ragtool)
        SiticoneTabControl_tab.Controls.Add(TabPage_requestjson)
        SiticoneTabControl_tab.Controls.Add(TabPage_responsejson)
        SiticoneTabControl_tab.Controls.Add(TabPage_responsemd)
        SiticoneTabControl_tab.Controls.Add(TabPage_responsehtml)
        SiticoneTabControl_tab.Controls.Add(TabPage_codeparameter)
        SiticoneTabControl_tab.Controls.Add(TabPage_codeblock)
        SiticoneTabControl_tab.DragIndicatorColor = Color.FromArgb(CByte(25), CByte(118), CByte(210))
        SiticoneTabControl_tab.Font = New Font("Segoe UI", 10F)
        SiticoneTabControl_tab.GhostBackColor = Color.FromArgb(CByte(20), CByte(34), CByte(30), CByte(65))
        SiticoneTabControl_tab.GhostForeColor = Color.FromArgb(CByte(180), CByte(0), CByte(0), CByte(0))
        SiticoneTabControl_tab.ItemSize = New Size(148, 50)
        SiticoneTabControl_tab.Location = New Point(0, 0)
        SiticoneTabControl_tab.Name = "SiticoneTabControl_tab"
        SiticoneTabControl_tab.PinIconHoverColor = Color.DarkGray
        SiticoneTabControl_tab.PinIconSize = 32
        SiticoneTabControl_tab.PinnedIconColor = Color.FromArgb(CByte(30), CByte(136), CByte(229))
        SiticoneTabControl_tab.RippleColor = Color.LightGray
        SiticoneTabControl_tab.SelectedIndex = 0
        SiticoneTabControl_tab.SelectedTabBackColor = Color.FromArgb(CByte(209), CByte(232), CByte(255))
        SiticoneTabControl_tab.SelectedTabFont = New Font("Segoe UI", 10F, FontStyle.Bold)
        SiticoneTabControl_tab.SelectedTabIndicatorColor = Color.FromArgb(CByte(16), CByte(100), CByte(220))
        SiticoneTabControl_tab.SelectedTabIndicatorHeight = 7
        SiticoneTabControl_tab.SelectedTextColor = Color.MediumBlue
        SiticoneTabControl_tab.SeparatorLineColor = Color.FromArgb(CByte(0), CByte(0), CByte(0))
        SiticoneTabControl_tab.SeparatorLineOpacity = 0.4F
        SiticoneTabControl_tab.ShowSeparatorLine = True
        SiticoneTabControl_tab.Size = New Size(1415, 688)
        SiticoneTabControl_tab.SizeMode = TabSizeMode.Fixed
        SiticoneTabControl_tab.TabImagePadding = 3
        SiticoneTabControl_tab.TabImageSize = 32
        SiticoneTabControl_tab.TabImageTextGap = 2
        SiticoneTabControl_tab.TabIndex = 23
        SiticoneTabControl_tab.TabWidth = 148
        SiticoneTabControl_tab.UnpinnedIconColor = Color.Gray
        SiticoneTabControl_tab.UnselectedTabColor = Color.Transparent
        SiticoneTabControl_tab.UnselectedTextColor = Color.Gray
        ' 
        ' TabPage_modelinfo
        ' 
        TabPage_modelinfo.BackColor = Color.WhiteSmoke
        TabPage_modelinfo.Controls.Add(SiticoneChip_model_info_Image)
        TabPage_modelinfo.Controls.Add(Scintilla_model_info)
        TabPage_modelinfo.Controls.Add(Scintilla_model_info_request)
        TabPage_modelinfo.Controls.Add(SiticoneButton_show_licence)
        TabPage_modelinfo.Controls.Add(SiticoneChip_model_info_Context)
        TabPage_modelinfo.Controls.Add(SiticoneChip_model_info_Embedding)
        TabPage_modelinfo.Controls.Add(SiticoneChip_model_info_Thinking)
        TabPage_modelinfo.Controls.Add(SiticoneChip_model_info_Tools)
        TabPage_modelinfo.Controls.Add(SiticoneChip_model_info_Vision)
        TabPage_modelinfo.Controls.Add(SiticoneLabel1_model_info_description)
        TabPage_modelinfo.Location = New Point(4, 54)
        TabPage_modelinfo.Name = "TabPage_modelinfo"
        TabPage_modelinfo.Padding = New Padding(3)
        TabPage_modelinfo.Size = New Size(1407, 630)
        SiticoneTabControl_tab.SetTabImage(TabPage_modelinfo, My.Resources.Resource_svg.Model_Info)
        TabPage_modelinfo.TabIndex = 5
        TabPage_modelinfo.Text = "Model Info"
        ' 
        ' SiticoneChip_model_info_Image
        ' 
        SiticoneChip_model_info_Image.AccentColor = Color.FromArgb(CByte(0), CByte(122), CByte(204))
        SiticoneChip_model_info_Image.AutoDisposeOnClose = True
        SiticoneChip_model_info_Image.Avatar = Nothing
        SiticoneChip_model_info_Image.BackColor = Color.Transparent
        SiticoneChip_model_info_Image.BorderColor = Color.FromArgb(CByte(210), CByte(210), CByte(210))
        SiticoneChip_model_info_Image.BorderWidth = 1
        SiticoneChip_model_info_Image.BottomLeftRadius = 20F
        SiticoneChip_model_info_Image.BottomRightRadius = 20F
        SiticoneChip_model_info_Image.CheckmarkColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        SiticoneChip_model_info_Image.CheckmarkPadding = New Padding(8, 8, 0, 8)
        SiticoneChip_model_info_Image.CheckmarkScale = 0.6F
        SiticoneChip_model_info_Image.CheckmarkThickness = 2F
        SiticoneChip_model_info_Image.CheckmarkWidth = 20
        SiticoneChip_model_info_Image.CloseButtonBorderColor = Color.FromArgb(CByte(128), CByte(128), CByte(128))
        SiticoneChip_model_info_Image.CloseButtonBorderThickness = 1F
        SiticoneChip_model_info_Image.CloseButtonHoverBackColor = Color.FromArgb(CByte(30), CByte(128), CByte(128), CByte(128))
        SiticoneChip_model_info_Image.CloseIconColor = Color.Black
        SiticoneChip_model_info_Image.CloseIconHoverColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        SiticoneChip_model_info_Image.CloseIconInnerPadding = 4
        SiticoneChip_model_info_Image.CloseIconPadding = New Padding(8)
        SiticoneChip_model_info_Image.CloseIconSize = 20
        SiticoneChip_model_info_Image.CloseIconThickness = 1.5F
        SiticoneChip_model_info_Image.EnableHoverAnimation = False
        SiticoneChip_model_info_Image.EnableRipples = False
        SiticoneChip_model_info_Image.EnableSelection = False
        SiticoneChip_model_info_Image.FillColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        SiticoneChip_model_info_Image.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        SiticoneChip_model_info_Image.ForeColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        SiticoneChip_model_info_Image.Group = ""
        SiticoneChip_model_info_Image.HoverColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        SiticoneChip_model_info_Image.HoverTextColor = Color.Empty
        SiticoneChip_model_info_Image.IsSelected = False
        SiticoneChip_model_info_Image.Location = New Point(630, 31)
        SiticoneChip_model_info_Image.Name = "SiticoneChip_model_info_Image"
        SiticoneChip_model_info_Image.Padding = New Padding(8, 4, 8, 4)
        SiticoneChip_model_info_Image.PressedColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        SiticoneChip_model_info_Image.RippleColor = Color.Gray
        SiticoneChip_model_info_Image.RippleDurationMS = 500
        SiticoneChip_model_info_Image.RippleOpacity = 0.1F
        SiticoneChip_model_info_Image.SelectedFillColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        SiticoneChip_model_info_Image.SelectedTextColor = Color.Empty
        SiticoneChip_model_info_Image.ShowCheckmark = True
        SiticoneChip_model_info_Image.ShowCloseButton = False
        SiticoneChip_model_info_Image.ShowCloseButtonBorder = False
        SiticoneChip_model_info_Image.Size = New Size(150, 29)
        SiticoneChip_model_info_Image.TabIndex = 50
        SiticoneChip_model_info_Image.Text = "image"
        SiticoneChip_model_info_Image.TopLeftRadius = 20F
        SiticoneChip_model_info_Image.TopRightRadius = 20F
        ' 
        ' Scintilla_model_info
        ' 
        Scintilla_model_info.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Scintilla_model_info.AutocompleteListSelectedBackColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        Scintilla_model_info.Font = New Font("Consolas", 10F)
        Scintilla_model_info.LexerName = "json"
        Scintilla_model_info.Location = New Point(8, 66)
        Scintilla_model_info.Name = "Scintilla_model_info"
        Scintilla_model_info.ScrollWidth = 70
        Scintilla_model_info.Size = New Size(1393, 264)
        Scintilla_model_info.TabIndex = 49
        ' 
        ' Scintilla_model_info_request
        ' 
        Scintilla_model_info_request.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Scintilla_model_info_request.AutocompleteListSelectedBackColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        Scintilla_model_info_request.Font = New Font("Consolas", 10F)
        Scintilla_model_info_request.LexerName = "json"
        Scintilla_model_info_request.Location = New Point(8, 336)
        Scintilla_model_info_request.Name = "Scintilla_model_info_request"
        Scintilla_model_info_request.ScrollWidth = 70
        Scintilla_model_info_request.Size = New Size(1393, 257)
        Scintilla_model_info_request.TabIndex = 48
        ' 
        ' SiticoneButton_show_licence
        ' 
        SiticoneButton_show_licence.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard"
        SiticoneButton_show_licence.AccessibleName = "Show License"
        SiticoneButton_show_licence.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        SiticoneButton_show_licence.AutoSizeBasedOnText = False
        SiticoneButton_show_licence.BackColor = Color.Transparent
        SiticoneButton_show_licence.BadgeBackColor = Color.Red
        SiticoneButton_show_licence.BadgeFont = New Font("Segoe UI", 8F, FontStyle.Bold)
        SiticoneButton_show_licence.BadgeValue = 0
        SiticoneButton_show_licence.BadgeValueForeColor = Color.White
        SiticoneButton_show_licence.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        SiticoneButton_show_licence.BorderWidth = 2
        SiticoneButton_show_licence.ButtonBackColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        SiticoneButton_show_licence.ButtonImage = Nothing
        SiticoneButton_show_licence.ButtonTextLeftPadding = 0
        SiticoneButton_show_licence.CanBeep = True
        SiticoneButton_show_licence.CanGlow = False
        SiticoneButton_show_licence.CanShake = True
        SiticoneButton_show_licence.ContextMenuStripEx = Nothing
        SiticoneButton_show_licence.CornerRadiusBottomLeft = 8
        SiticoneButton_show_licence.CornerRadiusBottomRight = 8
        SiticoneButton_show_licence.CornerRadiusTopLeft = 8
        SiticoneButton_show_licence.CornerRadiusTopRight = 8
        SiticoneButton_show_licence.CustomCursor = Cursors.Default
        SiticoneButton_show_licence.DisabledTextColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        SiticoneButton_show_licence.EnableLongPress = False
        SiticoneButton_show_licence.EnablePressAnimation = True
        SiticoneButton_show_licence.EnableRippleEffect = True
        SiticoneButton_show_licence.EnableShadow = False
        SiticoneButton_show_licence.EnableTextWrapping = False
        SiticoneButton_show_licence.Font = New Font("Segoe UI", 9F)
        SiticoneButton_show_licence.GlowColor = Color.FromArgb(CByte(100), CByte(255), CByte(255), CByte(255))
        SiticoneButton_show_licence.GlowIntensity = 100
        SiticoneButton_show_licence.GlowRadius = 20F
        SiticoneButton_show_licence.GradientBackground = False
        SiticoneButton_show_licence.GradientColor = Color.FromArgb(CByte(114), CByte(168), CByte(255))
        SiticoneButton_show_licence.GradientMode = Drawing2D.LinearGradientMode.Vertical
        SiticoneButton_show_licence.HintText = Nothing
        SiticoneButton_show_licence.HoverBackColor = Color.FromArgb(CByte(114), CByte(168), CByte(255))
        SiticoneButton_show_licence.HoverFontStyle = FontStyle.Regular
        SiticoneButton_show_licence.HoverTextColor = Color.White
        SiticoneButton_show_licence.HoverTransitionDuration = 250
        SiticoneButton_show_licence.ImageAlign = ContentAlignment.MiddleLeft
        SiticoneButton_show_licence.ImagePadding = 5
        SiticoneButton_show_licence.ImageSize = New Size(16, 16)
        SiticoneButton_show_licence.IsRadial = False
        SiticoneButton_show_licence.IsReadOnly = False
        SiticoneButton_show_licence.IsToggleButton = False
        SiticoneButton_show_licence.IsToggled = False
        SiticoneButton_show_licence.Location = New Point(1294, 599)
        SiticoneButton_show_licence.LongPressDurationMS = 1000
        SiticoneButton_show_licence.Name = "SiticoneButton_show_licence"
        SiticoneButton_show_licence.NormalFontStyle = FontStyle.Regular
        SiticoneButton_show_licence.ParticleColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        SiticoneButton_show_licence.ParticleCount = 15
        SiticoneButton_show_licence.PressAnimationScale = 0.97F
        SiticoneButton_show_licence.PressedBackColor = Color.FromArgb(CByte(74), CByte(128), CByte(235))
        SiticoneButton_show_licence.PressedFontStyle = FontStyle.Regular
        SiticoneButton_show_licence.PressTransitionDuration = 150
        SiticoneButton_show_licence.ReadOnlyTextColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        SiticoneButton_show_licence.RippleColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        SiticoneButton_show_licence.RippleOpacity = 0.3F
        SiticoneButton_show_licence.RippleRadiusMultiplier = 0.6F
        SiticoneButton_show_licence.ShadowBlur = 5
        SiticoneButton_show_licence.ShadowColor = Color.FromArgb(CByte(100), CByte(0), CByte(0), CByte(0))
        SiticoneButton_show_licence.ShadowOffset = New Point(2, 2)
        SiticoneButton_show_licence.ShakeDuration = 500
        SiticoneButton_show_licence.ShakeIntensity = 5
        SiticoneButton_show_licence.Size = New Size(107, 24)
        SiticoneButton_show_licence.TabIndex = 46
        SiticoneButton_show_licence.Text = "Show License"
        SiticoneButton_show_licence.TextAlign = ContentAlignment.MiddleCenter
        SiticoneButton_show_licence.TextColor = Color.White
        SiticoneButton_show_licence.TooltipText = Nothing
        SiticoneButton_show_licence.UseAdvancedRendering = True
        SiticoneButton_show_licence.UseParticles = False
        ' 
        ' SiticoneChip_model_info_Context
        ' 
        SiticoneChip_model_info_Context.AccentColor = Color.FromArgb(CByte(0), CByte(122), CByte(204))
        SiticoneChip_model_info_Context.AutoDisposeOnClose = True
        SiticoneChip_model_info_Context.Avatar = Nothing
        SiticoneChip_model_info_Context.BackColor = Color.Transparent
        SiticoneChip_model_info_Context.BorderColor = Color.FromArgb(CByte(210), CByte(210), CByte(210))
        SiticoneChip_model_info_Context.BorderWidth = 1
        SiticoneChip_model_info_Context.BottomLeftRadius = 20F
        SiticoneChip_model_info_Context.BottomRightRadius = 20F
        SiticoneChip_model_info_Context.CheckmarkColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        SiticoneChip_model_info_Context.CheckmarkPadding = New Padding(8, 8, 0, 8)
        SiticoneChip_model_info_Context.CheckmarkScale = 0.6F
        SiticoneChip_model_info_Context.CheckmarkThickness = 2F
        SiticoneChip_model_info_Context.CheckmarkWidth = 20
        SiticoneChip_model_info_Context.CloseButtonBorderColor = Color.FromArgb(CByte(128), CByte(128), CByte(128))
        SiticoneChip_model_info_Context.CloseButtonBorderThickness = 1F
        SiticoneChip_model_info_Context.CloseButtonHoverBackColor = Color.FromArgb(CByte(30), CByte(128), CByte(128), CByte(128))
        SiticoneChip_model_info_Context.CloseIconColor = Color.Black
        SiticoneChip_model_info_Context.CloseIconHoverColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        SiticoneChip_model_info_Context.CloseIconInnerPadding = 4
        SiticoneChip_model_info_Context.CloseIconPadding = New Padding(8)
        SiticoneChip_model_info_Context.CloseIconSize = 20
        SiticoneChip_model_info_Context.CloseIconThickness = 1.5F
        SiticoneChip_model_info_Context.EnableHoverAnimation = False
        SiticoneChip_model_info_Context.EnableRipples = False
        SiticoneChip_model_info_Context.EnableSelection = False
        SiticoneChip_model_info_Context.FillColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        SiticoneChip_model_info_Context.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SiticoneChip_model_info_Context.ForeColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        SiticoneChip_model_info_Context.Group = ""
        SiticoneChip_model_info_Context.HoverColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        SiticoneChip_model_info_Context.HoverTextColor = Color.Empty
        SiticoneChip_model_info_Context.IsSelected = False
        SiticoneChip_model_info_Context.Location = New Point(786, 31)
        SiticoneChip_model_info_Context.Name = "SiticoneChip_model_info_Context"
        SiticoneChip_model_info_Context.Padding = New Padding(8, 4, 8, 4)
        SiticoneChip_model_info_Context.PressedColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        SiticoneChip_model_info_Context.RippleColor = Color.Gray
        SiticoneChip_model_info_Context.RippleDurationMS = 500
        SiticoneChip_model_info_Context.RippleOpacity = 0.1F
        SiticoneChip_model_info_Context.SelectedFillColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        SiticoneChip_model_info_Context.SelectedTextColor = Color.Empty
        SiticoneChip_model_info_Context.ShowCheckmark = True
        SiticoneChip_model_info_Context.ShowCloseButton = False
        SiticoneChip_model_info_Context.ShowCloseButtonBorder = False
        SiticoneChip_model_info_Context.Size = New Size(200, 29)
        SiticoneChip_model_info_Context.TabIndex = 9
        SiticoneChip_model_info_Context.Text = "context: ?"
        SiticoneChip_model_info_Context.TopLeftRadius = 20F
        SiticoneChip_model_info_Context.TopRightRadius = 20F
        ' 
        ' SiticoneChip_model_info_Embedding
        ' 
        SiticoneChip_model_info_Embedding.AccentColor = Color.FromArgb(CByte(0), CByte(122), CByte(204))
        SiticoneChip_model_info_Embedding.AutoDisposeOnClose = True
        SiticoneChip_model_info_Embedding.Avatar = Nothing
        SiticoneChip_model_info_Embedding.BackColor = Color.Transparent
        SiticoneChip_model_info_Embedding.BorderColor = Color.FromArgb(CByte(210), CByte(210), CByte(210))
        SiticoneChip_model_info_Embedding.BorderWidth = 1
        SiticoneChip_model_info_Embedding.BottomLeftRadius = 20F
        SiticoneChip_model_info_Embedding.BottomRightRadius = 20F
        SiticoneChip_model_info_Embedding.CheckmarkColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        SiticoneChip_model_info_Embedding.CheckmarkPadding = New Padding(8, 8, 0, 8)
        SiticoneChip_model_info_Embedding.CheckmarkScale = 0.6F
        SiticoneChip_model_info_Embedding.CheckmarkThickness = 2F
        SiticoneChip_model_info_Embedding.CheckmarkWidth = 20
        SiticoneChip_model_info_Embedding.CloseButtonBorderColor = Color.FromArgb(CByte(128), CByte(128), CByte(128))
        SiticoneChip_model_info_Embedding.CloseButtonBorderThickness = 1F
        SiticoneChip_model_info_Embedding.CloseButtonHoverBackColor = Color.FromArgb(CByte(30), CByte(128), CByte(128), CByte(128))
        SiticoneChip_model_info_Embedding.CloseIconColor = Color.Black
        SiticoneChip_model_info_Embedding.CloseIconHoverColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        SiticoneChip_model_info_Embedding.CloseIconInnerPadding = 4
        SiticoneChip_model_info_Embedding.CloseIconPadding = New Padding(8)
        SiticoneChip_model_info_Embedding.CloseIconSize = 20
        SiticoneChip_model_info_Embedding.CloseIconThickness = 1.5F
        SiticoneChip_model_info_Embedding.EnableHoverAnimation = False
        SiticoneChip_model_info_Embedding.EnableRipples = False
        SiticoneChip_model_info_Embedding.EnableSelection = False
        SiticoneChip_model_info_Embedding.FillColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        SiticoneChip_model_info_Embedding.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        SiticoneChip_model_info_Embedding.ForeColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        SiticoneChip_model_info_Embedding.Group = ""
        SiticoneChip_model_info_Embedding.HoverColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        SiticoneChip_model_info_Embedding.HoverTextColor = Color.Empty
        SiticoneChip_model_info_Embedding.IsSelected = False
        SiticoneChip_model_info_Embedding.Location = New Point(474, 31)
        SiticoneChip_model_info_Embedding.Name = "SiticoneChip_model_info_Embedding"
        SiticoneChip_model_info_Embedding.Padding = New Padding(8, 4, 8, 4)
        SiticoneChip_model_info_Embedding.PressedColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        SiticoneChip_model_info_Embedding.RippleColor = Color.Gray
        SiticoneChip_model_info_Embedding.RippleDurationMS = 500
        SiticoneChip_model_info_Embedding.RippleOpacity = 0.1F
        SiticoneChip_model_info_Embedding.SelectedFillColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        SiticoneChip_model_info_Embedding.SelectedTextColor = Color.Empty
        SiticoneChip_model_info_Embedding.ShowCheckmark = True
        SiticoneChip_model_info_Embedding.ShowCloseButton = False
        SiticoneChip_model_info_Embedding.ShowCloseButtonBorder = False
        SiticoneChip_model_info_Embedding.Size = New Size(150, 29)
        SiticoneChip_model_info_Embedding.TabIndex = 8
        SiticoneChip_model_info_Embedding.Text = "embedding"
        SiticoneChip_model_info_Embedding.TopLeftRadius = 20F
        SiticoneChip_model_info_Embedding.TopRightRadius = 20F
        ' 
        ' SiticoneChip_model_info_Thinking
        ' 
        SiticoneChip_model_info_Thinking.AccentColor = Color.FromArgb(CByte(0), CByte(122), CByte(204))
        SiticoneChip_model_info_Thinking.AutoDisposeOnClose = True
        SiticoneChip_model_info_Thinking.Avatar = Nothing
        SiticoneChip_model_info_Thinking.BackColor = Color.Transparent
        SiticoneChip_model_info_Thinking.BorderColor = Color.FromArgb(CByte(210), CByte(210), CByte(210))
        SiticoneChip_model_info_Thinking.BorderWidth = 1
        SiticoneChip_model_info_Thinking.BottomLeftRadius = 20F
        SiticoneChip_model_info_Thinking.BottomRightRadius = 20F
        SiticoneChip_model_info_Thinking.CheckmarkColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        SiticoneChip_model_info_Thinking.CheckmarkPadding = New Padding(8, 8, 0, 8)
        SiticoneChip_model_info_Thinking.CheckmarkScale = 0.6F
        SiticoneChip_model_info_Thinking.CheckmarkThickness = 2F
        SiticoneChip_model_info_Thinking.CheckmarkWidth = 20
        SiticoneChip_model_info_Thinking.CloseButtonBorderColor = Color.FromArgb(CByte(128), CByte(128), CByte(128))
        SiticoneChip_model_info_Thinking.CloseButtonBorderThickness = 1F
        SiticoneChip_model_info_Thinking.CloseButtonHoverBackColor = Color.FromArgb(CByte(30), CByte(128), CByte(128), CByte(128))
        SiticoneChip_model_info_Thinking.CloseIconColor = Color.Black
        SiticoneChip_model_info_Thinking.CloseIconHoverColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        SiticoneChip_model_info_Thinking.CloseIconInnerPadding = 4
        SiticoneChip_model_info_Thinking.CloseIconPadding = New Padding(8)
        SiticoneChip_model_info_Thinking.CloseIconSize = 20
        SiticoneChip_model_info_Thinking.CloseIconThickness = 1.5F
        SiticoneChip_model_info_Thinking.EnableHoverAnimation = False
        SiticoneChip_model_info_Thinking.EnableRipples = False
        SiticoneChip_model_info_Thinking.EnableSelection = False
        SiticoneChip_model_info_Thinking.FillColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        SiticoneChip_model_info_Thinking.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        SiticoneChip_model_info_Thinking.ForeColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        SiticoneChip_model_info_Thinking.Group = ""
        SiticoneChip_model_info_Thinking.HoverColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        SiticoneChip_model_info_Thinking.HoverTextColor = Color.Empty
        SiticoneChip_model_info_Thinking.IsSelected = False
        SiticoneChip_model_info_Thinking.Location = New Point(318, 31)
        SiticoneChip_model_info_Thinking.Name = "SiticoneChip_model_info_Thinking"
        SiticoneChip_model_info_Thinking.Padding = New Padding(8, 4, 8, 4)
        SiticoneChip_model_info_Thinking.PressedColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        SiticoneChip_model_info_Thinking.RippleColor = Color.Gray
        SiticoneChip_model_info_Thinking.RippleDurationMS = 500
        SiticoneChip_model_info_Thinking.RippleOpacity = 0.1F
        SiticoneChip_model_info_Thinking.SelectedFillColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        SiticoneChip_model_info_Thinking.SelectedTextColor = Color.Empty
        SiticoneChip_model_info_Thinking.ShowCheckmark = True
        SiticoneChip_model_info_Thinking.ShowCloseButton = False
        SiticoneChip_model_info_Thinking.ShowCloseButtonBorder = False
        SiticoneChip_model_info_Thinking.Size = New Size(150, 29)
        SiticoneChip_model_info_Thinking.TabIndex = 7
        SiticoneChip_model_info_Thinking.Text = "thinking"
        SiticoneChip_model_info_Thinking.TopLeftRadius = 20F
        SiticoneChip_model_info_Thinking.TopRightRadius = 20F
        ' 
        ' SiticoneChip_model_info_Tools
        ' 
        SiticoneChip_model_info_Tools.AccentColor = Color.FromArgb(CByte(0), CByte(122), CByte(204))
        SiticoneChip_model_info_Tools.AutoDisposeOnClose = True
        SiticoneChip_model_info_Tools.Avatar = Nothing
        SiticoneChip_model_info_Tools.BackColor = Color.Transparent
        SiticoneChip_model_info_Tools.BorderColor = Color.FromArgb(CByte(210), CByte(210), CByte(210))
        SiticoneChip_model_info_Tools.BorderWidth = 1
        SiticoneChip_model_info_Tools.BottomLeftRadius = 20F
        SiticoneChip_model_info_Tools.BottomRightRadius = 20F
        SiticoneChip_model_info_Tools.CheckmarkColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        SiticoneChip_model_info_Tools.CheckmarkPadding = New Padding(8, 8, 0, 8)
        SiticoneChip_model_info_Tools.CheckmarkScale = 0.6F
        SiticoneChip_model_info_Tools.CheckmarkThickness = 2F
        SiticoneChip_model_info_Tools.CheckmarkWidth = 20
        SiticoneChip_model_info_Tools.CloseButtonBorderColor = Color.FromArgb(CByte(128), CByte(128), CByte(128))
        SiticoneChip_model_info_Tools.CloseButtonBorderThickness = 1F
        SiticoneChip_model_info_Tools.CloseButtonHoverBackColor = Color.FromArgb(CByte(30), CByte(128), CByte(128), CByte(128))
        SiticoneChip_model_info_Tools.CloseIconColor = Color.Black
        SiticoneChip_model_info_Tools.CloseIconHoverColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        SiticoneChip_model_info_Tools.CloseIconInnerPadding = 4
        SiticoneChip_model_info_Tools.CloseIconPadding = New Padding(8)
        SiticoneChip_model_info_Tools.CloseIconSize = 20
        SiticoneChip_model_info_Tools.CloseIconThickness = 1.5F
        SiticoneChip_model_info_Tools.EnableHoverAnimation = False
        SiticoneChip_model_info_Tools.EnableRipples = False
        SiticoneChip_model_info_Tools.EnableSelection = False
        SiticoneChip_model_info_Tools.FillColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        SiticoneChip_model_info_Tools.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SiticoneChip_model_info_Tools.ForeColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        SiticoneChip_model_info_Tools.Group = ""
        SiticoneChip_model_info_Tools.HoverColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        SiticoneChip_model_info_Tools.HoverTextColor = Color.Empty
        SiticoneChip_model_info_Tools.IsSelected = False
        SiticoneChip_model_info_Tools.Location = New Point(162, 31)
        SiticoneChip_model_info_Tools.Name = "SiticoneChip_model_info_Tools"
        SiticoneChip_model_info_Tools.Padding = New Padding(8, 4, 8, 4)
        SiticoneChip_model_info_Tools.PressedColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        SiticoneChip_model_info_Tools.RippleColor = Color.Gray
        SiticoneChip_model_info_Tools.RippleDurationMS = 500
        SiticoneChip_model_info_Tools.RippleOpacity = 0.1F
        SiticoneChip_model_info_Tools.SelectedFillColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        SiticoneChip_model_info_Tools.SelectedTextColor = Color.Empty
        SiticoneChip_model_info_Tools.ShowCheckmark = True
        SiticoneChip_model_info_Tools.ShowCloseButton = False
        SiticoneChip_model_info_Tools.ShowCloseButtonBorder = False
        SiticoneChip_model_info_Tools.Size = New Size(150, 29)
        SiticoneChip_model_info_Tools.TabIndex = 6
        SiticoneChip_model_info_Tools.Text = "tools"
        SiticoneChip_model_info_Tools.TopLeftRadius = 20F
        SiticoneChip_model_info_Tools.TopRightRadius = 20F
        ' 
        ' SiticoneChip_model_info_Vision
        ' 
        SiticoneChip_model_info_Vision.AccentColor = Color.FromArgb(CByte(0), CByte(122), CByte(204))
        SiticoneChip_model_info_Vision.AutoDisposeOnClose = True
        SiticoneChip_model_info_Vision.Avatar = Nothing
        SiticoneChip_model_info_Vision.BackColor = Color.Transparent
        SiticoneChip_model_info_Vision.BorderColor = Color.FromArgb(CByte(210), CByte(210), CByte(210))
        SiticoneChip_model_info_Vision.BorderWidth = 1
        SiticoneChip_model_info_Vision.BottomLeftRadius = 20F
        SiticoneChip_model_info_Vision.BottomRightRadius = 20F
        SiticoneChip_model_info_Vision.CheckmarkColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        SiticoneChip_model_info_Vision.CheckmarkPadding = New Padding(8, 8, 0, 8)
        SiticoneChip_model_info_Vision.CheckmarkScale = 0.6F
        SiticoneChip_model_info_Vision.CheckmarkThickness = 2F
        SiticoneChip_model_info_Vision.CheckmarkWidth = 20
        SiticoneChip_model_info_Vision.CloseButtonBorderColor = Color.FromArgb(CByte(128), CByte(128), CByte(128))
        SiticoneChip_model_info_Vision.CloseButtonBorderThickness = 1F
        SiticoneChip_model_info_Vision.CloseButtonHoverBackColor = Color.FromArgb(CByte(30), CByte(128), CByte(128), CByte(128))
        SiticoneChip_model_info_Vision.CloseIconColor = Color.Black
        SiticoneChip_model_info_Vision.CloseIconHoverColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        SiticoneChip_model_info_Vision.CloseIconInnerPadding = 4
        SiticoneChip_model_info_Vision.CloseIconPadding = New Padding(8)
        SiticoneChip_model_info_Vision.CloseIconSize = 20
        SiticoneChip_model_info_Vision.CloseIconThickness = 1.5F
        SiticoneChip_model_info_Vision.EnableHoverAnimation = True
        SiticoneChip_model_info_Vision.EnableRipples = True
        SiticoneChip_model_info_Vision.EnableSelection = False
        SiticoneChip_model_info_Vision.FillColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        SiticoneChip_model_info_Vision.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        SiticoneChip_model_info_Vision.ForeColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        SiticoneChip_model_info_Vision.Group = ""
        SiticoneChip_model_info_Vision.HoverColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        SiticoneChip_model_info_Vision.HoverTextColor = Color.Empty
        SiticoneChip_model_info_Vision.IsSelected = False
        SiticoneChip_model_info_Vision.Location = New Point(6, 31)
        SiticoneChip_model_info_Vision.Name = "SiticoneChip_model_info_Vision"
        SiticoneChip_model_info_Vision.Padding = New Padding(8, 4, 8, 4)
        SiticoneChip_model_info_Vision.PressedColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        SiticoneChip_model_info_Vision.RippleColor = Color.Gray
        SiticoneChip_model_info_Vision.RippleDurationMS = 500
        SiticoneChip_model_info_Vision.RippleOpacity = 0.1F
        SiticoneChip_model_info_Vision.SelectedFillColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        SiticoneChip_model_info_Vision.SelectedTextColor = Color.Empty
        SiticoneChip_model_info_Vision.ShowCheckmark = True
        SiticoneChip_model_info_Vision.ShowCloseButton = False
        SiticoneChip_model_info_Vision.ShowCloseButtonBorder = False
        SiticoneChip_model_info_Vision.Size = New Size(150, 29)
        SiticoneChip_model_info_Vision.TabIndex = 5
        SiticoneChip_model_info_Vision.Text = "vision"
        SiticoneChip_model_info_Vision.TopLeftRadius = 20F
        SiticoneChip_model_info_Vision.TopRightRadius = 20F
        ' 
        ' SiticoneLabel1_model_info_description
        ' 
        SiticoneLabel1_model_info_description.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        SiticoneLabel1_model_info_description.BackColor = Color.Transparent
        SiticoneLabel1_model_info_description.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        SiticoneLabel1_model_info_description.ForeColor = Color.FromArgb(CByte(26), CByte(115), CByte(232))
        SiticoneLabel1_model_info_description.Location = New Point(6, 3)
        SiticoneLabel1_model_info_description.Name = "SiticoneLabel1_model_info_description"
        SiticoneLabel1_model_info_description.Size = New Size(1395, 25)
        SiticoneLabel1_model_info_description.TabIndex = 2
        SiticoneLabel1_model_info_description.Text = "unknown"
        SiticoneLabel1_model_info_description.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TabPage_modelparameter
        ' 
        TabPage_modelparameter.BackColor = Color.WhiteSmoke
        TabPage_modelparameter.Controls.Add(SiticoneFlatPanel_trenn3)
        TabPage_modelparameter.Controls.Add(SiticoneFlatPanel_trenn2)
        TabPage_modelparameter.Controls.Add(SiticoneFlatPanel_trenn1)
        TabPage_modelparameter.Controls.Add(SiticoneFlatPanel_format_use)
        TabPage_modelparameter.Controls.Add(SiticoneFlatPanel_system_use)
        TabPage_modelparameter.Controls.Add(Scintilla_format)
        TabPage_modelparameter.Controls.Add(SiticoneButton_link_content_prompt)
        TabPage_modelparameter.Controls.Add(SiticoneTextArea_content_prompt)
        TabPage_modelparameter.Controls.Add(SiticoneLabel13)
        TabPage_modelparameter.Controls.Add(SiticoneButton_link_output_format)
        TabPage_modelparameter.Controls.Add(SiticoneButton_link_system_prompt)
        TabPage_modelparameter.Controls.Add(SiticoneButton_link_options_parameter)
        TabPage_modelparameter.Controls.Add(SiticoneLabel6)
        TabPage_modelparameter.Controls.Add(SiticoneButton_load_parameter)
        TabPage_modelparameter.Controls.Add(SiticoneButton_save_parameter)
        TabPage_modelparameter.Controls.Add(SiticoneLabel1)
        TabPage_modelparameter.Controls.Add(dgv_option)
        TabPage_modelparameter.Controls.Add(SiticoneLabel4)
        TabPage_modelparameter.Controls.Add(SiticoneTextArea_system)
        TabPage_modelparameter.Location = New Point(4, 54)
        TabPage_modelparameter.Name = "TabPage_modelparameter"
        TabPage_modelparameter.Padding = New Padding(3)
        TabPage_modelparameter.Size = New Size(1407, 630)
        SiticoneTabControl_tab.SetTabImage(TabPage_modelparameter, My.Resources.Resource_svg.Model_Parameter)
        TabPage_modelparameter.TabIndex = 0
        TabPage_modelparameter.Text = "Model Parameter"
        ' 
        ' SiticoneFlatPanel_trenn3
        ' 
        SiticoneFlatPanel_trenn3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        SiticoneFlatPanel_trenn3.BackColor = Color.FromArgb(CByte(209), CByte(232), CByte(255))
        SiticoneFlatPanel_trenn3.Controls.Add(SiticoneFlatPanel_thinking_use)
        SiticoneFlatPanel_trenn3.Controls.Add(SiticoneDropdown_thinking_use)
        SiticoneFlatPanel_trenn3.Location = New Point(188, 593)
        SiticoneFlatPanel_trenn3.MinimumSize = New Size(20, 20)
        SiticoneFlatPanel_trenn3.Name = "SiticoneFlatPanel_trenn3"
        SiticoneFlatPanel_trenn3.Size = New Size(324, 36)
        SiticoneFlatPanel_trenn3.TabIndex = 63
        ' 
        ' SiticoneFlatPanel_thinking_use
        ' 
        SiticoneFlatPanel_thinking_use.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        SiticoneFlatPanel_thinking_use.BackColor = Color.Transparent
        SiticoneFlatPanel_thinking_use.Controls.Add(SiticoneLabel_thinking_use)
        SiticoneFlatPanel_thinking_use.Controls.Add(SiticoneToggleSwitch_thinking_use)
        SiticoneFlatPanel_thinking_use.Location = New Point(3, 6)
        SiticoneFlatPanel_thinking_use.MinimumSize = New Size(20, 20)
        SiticoneFlatPanel_thinking_use.Name = "SiticoneFlatPanel_thinking_use"
        SiticoneFlatPanel_thinking_use.Size = New Size(209, 25)
        SiticoneFlatPanel_thinking_use.TabIndex = 57
        ' 
        ' SiticoneLabel_thinking_use
        ' 
        SiticoneLabel_thinking_use.BackColor = Color.Transparent
        SiticoneLabel_thinking_use.Dock = DockStyle.Right
        SiticoneLabel_thinking_use.Font = New Font("Segoe UI", 10F)
        SiticoneLabel_thinking_use.Location = New Point(50, 0)
        SiticoneLabel_thinking_use.Name = "SiticoneLabel_thinking_use"
        SiticoneLabel_thinking_use.Size = New Size(159, 25)
        SiticoneLabel_thinking_use.TabIndex = 55
        SiticoneLabel_thinking_use.Text = "Use Thinking Parameter:"
        SiticoneLabel_thinking_use.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' SiticoneToggleSwitch_thinking_use
        ' 
        SiticoneToggleSwitch_thinking_use.AccessibleDescription = "A customizable toggle switch that can be turned on or off."
        SiticoneToggleSwitch_thinking_use.AccessibleName = "Siticone Toggle Switch"
        SiticoneToggleSwitch_thinking_use.AccessibleRole = AccessibleRole.CheckButton
        SiticoneToggleSwitch_thinking_use.CanBeep = True
        SiticoneToggleSwitch_thinking_use.CanShake = True
        SiticoneToggleSwitch_thinking_use.DisabledColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        SiticoneToggleSwitch_thinking_use.DisallowToggling = False
        SiticoneToggleSwitch_thinking_use.Dock = DockStyle.Left
        SiticoneToggleSwitch_thinking_use.EnableGlowEffect = True
        SiticoneToggleSwitch_thinking_use.ExtraThumbSize = 2
        SiticoneToggleSwitch_thinking_use.IsOn = False
        SiticoneToggleSwitch_thinking_use.IsReadOnly = False
        SiticoneToggleSwitch_thinking_use.IsRequired = False
        SiticoneToggleSwitch_thinking_use.LabelColor = Color.Black
        SiticoneToggleSwitch_thinking_use.LabelFont = New Font("Segoe UI", 9F)
        SiticoneToggleSwitch_thinking_use.Location = New Point(0, 0)
        SiticoneToggleSwitch_thinking_use.Logger = Nothing
        SiticoneToggleSwitch_thinking_use.Name = "SiticoneToggleSwitch_thinking_use"
        SiticoneToggleSwitch_thinking_use.OffBackColor1 = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        SiticoneToggleSwitch_thinking_use.OffBackColor2 = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        SiticoneToggleSwitch_thinking_use.OffBorderColor1 = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        SiticoneToggleSwitch_thinking_use.OffBorderColor2 = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        SiticoneToggleSwitch_thinking_use.OffIcon = Nothing
        SiticoneToggleSwitch_thinking_use.OffThumbColor1 = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        SiticoneToggleSwitch_thinking_use.OffThumbColor2 = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        SiticoneToggleSwitch_thinking_use.OnBackColor1 = Color.FromArgb(CByte(26), CByte(115), CByte(232))
        SiticoneToggleSwitch_thinking_use.OnBackColor2 = Color.FromArgb(CByte(26), CByte(115), CByte(232))
        SiticoneToggleSwitch_thinking_use.OnBorderColor1 = Color.FromArgb(CByte(26), CByte(115), CByte(232))
        SiticoneToggleSwitch_thinking_use.OnBorderColor2 = Color.FromArgb(CByte(26), CByte(115), CByte(232))
        SiticoneToggleSwitch_thinking_use.OnIcon = Nothing
        SiticoneToggleSwitch_thinking_use.OnThumbColor1 = Color.White
        SiticoneToggleSwitch_thinking_use.OnThumbColor2 = Color.White
        SiticoneToggleSwitch_thinking_use.PreventToggleOff = False
        SiticoneToggleSwitch_thinking_use.RippleColor = Color.FromArgb(CByte(100), CByte(255), CByte(255), CByte(255))
        SiticoneToggleSwitch_thinking_use.RippleExpansionRate = 2F
        SiticoneToggleSwitch_thinking_use.RippleOpacityDecay = 0.02F
        SiticoneToggleSwitch_thinking_use.Size = New Size(50, 25)
        SiticoneToggleSwitch_thinking_use.TabIndex = 54
        SiticoneToggleSwitch_thinking_use.ToggleOffSoundPath = ""
        SiticoneToggleSwitch_thinking_use.ToggleOnSoundPath = ""
        SiticoneToggleSwitch_thinking_use.ToolTipText = ""
        SiticoneToggleSwitch_thinking_use.TrackDeviceTheme = True
        ' 
        ' SiticoneDropdown_thinking_use
        ' 
        SiticoneDropdown_thinking_use.AllowMultipleSelection = False
        SiticoneDropdown_thinking_use.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        SiticoneDropdown_thinking_use.BackColor = Color.White
        SiticoneDropdown_thinking_use.BorderColor = Color.Gray
        SiticoneDropdown_thinking_use.BorderSize = 2
        SiticoneDropdown_thinking_use.CanBeep = False
        SiticoneDropdown_thinking_use.CanShake = True
        SiticoneDropdown_thinking_use.CornerRadius = 8
        SiticoneDropdown_thinking_use.DataSource = Nothing
        SiticoneDropdown_thinking_use.DisplayMember = Nothing
        SiticoneDropdown_thinking_use.DropdownBackColor = Color.White
        SiticoneDropdown_thinking_use.DropdownCornerRadius = 8
        SiticoneDropdown_thinking_use.DropdownWidth = 0
        SiticoneDropdown_thinking_use.DropShadowEnabled = False
        SiticoneDropdown_thinking_use.Font = New Font("Segoe UI", 10F)
        SiticoneDropdown_thinking_use.ForeColor = Color.DimGray
        SiticoneDropdown_thinking_use.HoveredItemBackColor = Color.LightGray
        SiticoneDropdown_thinking_use.HoveredItemTextColor = Color.Black
        SiticoneDropdown_thinking_use.IsReadonly = False
        SiticoneDropdown_thinking_use.ItemHeight = 30
        SiticoneDropdown_thinking_use.Items.AddRange(New String() {"false", "true", "low", "medium", "high"})
        SiticoneDropdown_thinking_use.Location = New Point(218, 4)
        SiticoneDropdown_thinking_use.MaxDropDownItems = 8
        SiticoneDropdown_thinking_use.Name = "SiticoneDropdown_thinking_use"
        SiticoneDropdown_thinking_use.NotFoundBackColor = Color.Transparent
        SiticoneDropdown_thinking_use.NotFoundFont = Nothing
        SiticoneDropdown_thinking_use.NotFoundTextColor = Color.Gray
        SiticoneDropdown_thinking_use.PlaceholderColor = Color.Gray
        SiticoneDropdown_thinking_use.PlaceholderDisappearsOnFocus = False
        SiticoneDropdown_thinking_use.PlaceholderText = "Select think level"
        SiticoneDropdown_thinking_use.SearchTextColor = Color.DimGray
        SiticoneDropdown_thinking_use.SearchTextFont = Nothing
        SiticoneDropdown_thinking_use.SelectedIndex = 0
        SiticoneDropdown_thinking_use.SelectedItem = "false"
        SiticoneDropdown_thinking_use.SelectedItemBackColor = Color.LightBlue
        SiticoneDropdown_thinking_use.SelectedItemTextColor = Color.Black
        SiticoneDropdown_thinking_use.SelectedValue = Nothing
        SiticoneDropdown_thinking_use.Size = New Size(92, 30)
        SiticoneDropdown_thinking_use.TabIndex = 44
        SiticoneDropdown_thinking_use.Text = "true"
        SiticoneDropdown_thinking_use.UnselectedItemTextColor = Color.Black
        SiticoneDropdown_thinking_use.ValueMember = Nothing
        ' 
        ' SiticoneFlatPanel_trenn2
        ' 
        SiticoneFlatPanel_trenn2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        SiticoneFlatPanel_trenn2.BackColor = Color.FromArgb(CByte(209), CByte(232), CByte(255))
        SiticoneFlatPanel_trenn2.Controls.Add(SiticoneLabel5)
        SiticoneFlatPanel_trenn2.Controls.Add(SiticoneTextBox_timeout)
        SiticoneFlatPanel_trenn2.Location = New Point(8, 593)
        SiticoneFlatPanel_trenn2.MinimumSize = New Size(20, 20)
        SiticoneFlatPanel_trenn2.Name = "SiticoneFlatPanel_trenn2"
        SiticoneFlatPanel_trenn2.Size = New Size(174, 36)
        SiticoneFlatPanel_trenn2.TabIndex = 62
        ' 
        ' SiticoneLabel5
        ' 
        SiticoneLabel5.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        SiticoneLabel5.BackColor = Color.Transparent
        SiticoneLabel5.Font = New Font("Segoe UI", 10F)
        SiticoneLabel5.Location = New Point(3, 8)
        SiticoneLabel5.Name = "SiticoneLabel5"
        SiticoneLabel5.Size = New Size(82, 21)
        SiticoneLabel5.TabIndex = 36
        SiticoneLabel5.Text = "Timeout [s]:"
        ' 
        ' SiticoneTextBox_timeout
        ' 
        SiticoneTextBox_timeout.AccessibleDescription = "A customizable text input field."
        SiticoneTextBox_timeout.AccessibleName = "Text Box"
        SiticoneTextBox_timeout.AccessibleRole = AccessibleRole.Text
        SiticoneTextBox_timeout.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        SiticoneTextBox_timeout.BackColor = Color.Transparent
        SiticoneTextBox_timeout.BlinkCount = 3
        SiticoneTextBox_timeout.BlinkShadow = False
        SiticoneTextBox_timeout.BorderColor1 = Color.LightSlateGray
        SiticoneTextBox_timeout.BorderColor2 = Color.LightSlateGray
        SiticoneTextBox_timeout.BorderFocusColor1 = Color.FromArgb(CByte(77), CByte(77), CByte(255))
        SiticoneTextBox_timeout.BorderFocusColor2 = Color.FromArgb(CByte(77), CByte(77), CByte(255))
        SiticoneTextBox_timeout.BorderSize = 2
        SiticoneTextBox_timeout.CanShake = True
        SiticoneTextBox_timeout.ContinuousBlink = False
        SiticoneTextBox_timeout.CornerRadiusBottomLeft = 8
        SiticoneTextBox_timeout.CornerRadiusBottomRight = 8
        SiticoneTextBox_timeout.CornerRadiusTopLeft = 8
        SiticoneTextBox_timeout.CornerRadiusTopRight = 8
        SiticoneTextBox_timeout.CursorBlinkRate = 500
        SiticoneTextBox_timeout.CursorColor = Color.Black
        SiticoneTextBox_timeout.CursorHeight = 26
        SiticoneTextBox_timeout.CursorOffset = 0
        SiticoneTextBox_timeout.CursorStyle = SiticoneNetCoreUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid
        SiticoneTextBox_timeout.CursorWidth = 1
        SiticoneTextBox_timeout.DisabledBackColor = Color.WhiteSmoke
        SiticoneTextBox_timeout.DisabledBorderColor = Color.LightGray
        SiticoneTextBox_timeout.DisabledTextColor = Color.Gray
        SiticoneTextBox_timeout.EnableDropShadow = False
        SiticoneTextBox_timeout.FillColor1 = Color.White
        SiticoneTextBox_timeout.FillColor2 = Color.White
        SiticoneTextBox_timeout.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SiticoneTextBox_timeout.ForeColor = Color.DimGray
        SiticoneTextBox_timeout.HoverBorderColor1 = Color.Gray
        SiticoneTextBox_timeout.HoverBorderColor2 = Color.Gray
        SiticoneTextBox_timeout.IsEnabled = True
        SiticoneTextBox_timeout.Location = New Point(89, 4)
        SiticoneTextBox_timeout.Name = "SiticoneTextBox_timeout"
        SiticoneTextBox_timeout.PlaceholderColor = Color.Gray
        SiticoneTextBox_timeout.PlaceholderText = "Enter text here..."
        SiticoneTextBox_timeout.ReadOnlyBorderColor1 = Color.LightGray
        SiticoneTextBox_timeout.ReadOnlyBorderColor2 = Color.LightGray
        SiticoneTextBox_timeout.ReadOnlyFillColor1 = Color.WhiteSmoke
        SiticoneTextBox_timeout.ReadOnlyFillColor2 = Color.WhiteSmoke
        SiticoneTextBox_timeout.ReadOnlyPlaceholderColor = Color.DarkGray
        SiticoneTextBox_timeout.SelectionBackColor = Color.FromArgb(CByte(77), CByte(77), CByte(255))
        SiticoneTextBox_timeout.ShadowAnimationDuration = 1
        SiticoneTextBox_timeout.ShadowBlur = 10
        SiticoneTextBox_timeout.ShadowColor = Color.FromArgb(CByte(15), CByte(0), CByte(0), CByte(0))
        SiticoneTextBox_timeout.Size = New Size(78, 28)
        SiticoneTextBox_timeout.SolidBorderColor = Color.LightSlateGray
        SiticoneTextBox_timeout.SolidBorderFocusColor = Color.FromArgb(CByte(77), CByte(77), CByte(255))
        SiticoneTextBox_timeout.SolidBorderHoverColor = Color.Gray
        SiticoneTextBox_timeout.SolidFillColor = Color.White
        SiticoneTextBox_timeout.TabIndex = 37
        SiticoneTextBox_timeout.Text = "600"
        SiticoneTextBox_timeout.TextPadding = New Padding(11, 2, 11, 2)
        SiticoneTextBox_timeout.ValidationErrorMessage = "Invalid input."
        SiticoneTextBox_timeout.ValidationFunction = Nothing
        ' 
        ' SiticoneFlatPanel_trenn1
        ' 
        SiticoneFlatPanel_trenn1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        SiticoneFlatPanel_trenn1.BackColor = Color.FromArgb(CByte(209), CByte(232), CByte(255))
        SiticoneFlatPanel_trenn1.Controls.Add(SiticoneFlatPanel_last_context)
        SiticoneFlatPanel_trenn1.Controls.Add(SiticoneButton_save_context)
        SiticoneFlatPanel_trenn1.Controls.Add(SiticoneButton_clear_context)
        SiticoneFlatPanel_trenn1.Controls.Add(SiticoneButton_load_context)
        SiticoneFlatPanel_trenn1.Location = New Point(518, 593)
        SiticoneFlatPanel_trenn1.MinimumSize = New Size(20, 20)
        SiticoneFlatPanel_trenn1.Name = "SiticoneFlatPanel_trenn1"
        SiticoneFlatPanel_trenn1.Size = New Size(608, 36)
        SiticoneFlatPanel_trenn1.TabIndex = 61
        ' 
        ' SiticoneFlatPanel_last_context
        ' 
        SiticoneFlatPanel_last_context.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        SiticoneFlatPanel_last_context.BackColor = Color.Transparent
        SiticoneFlatPanel_last_context.Controls.Add(SiticoneLabel_last_context)
        SiticoneFlatPanel_last_context.Controls.Add(SiticoneToggleSwitch_last_context)
        SiticoneFlatPanel_last_context.Location = New Point(5, 6)
        SiticoneFlatPanel_last_context.MinimumSize = New Size(20, 20)
        SiticoneFlatPanel_last_context.Name = "SiticoneFlatPanel_last_context"
        SiticoneFlatPanel_last_context.Size = New Size(253, 25)
        SiticoneFlatPanel_last_context.TabIndex = 58
        ' 
        ' SiticoneLabel_last_context
        ' 
        SiticoneLabel_last_context.BackColor = Color.Transparent
        SiticoneLabel_last_context.Dock = DockStyle.Right
        SiticoneLabel_last_context.Font = New Font("Segoe UI", 10F)
        SiticoneLabel_last_context.Location = New Point(50, 0)
        SiticoneLabel_last_context.Name = "SiticoneLabel_last_context"
        SiticoneLabel_last_context.Size = New Size(203, 25)
        SiticoneLabel_last_context.TabIndex = 55
        SiticoneLabel_last_context.Text = "Use Last Context (0 Tokens)"
        SiticoneLabel_last_context.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' SiticoneToggleSwitch_last_context
        ' 
        SiticoneToggleSwitch_last_context.AccessibleDescription = "A customizable toggle switch that can be turned on or off."
        SiticoneToggleSwitch_last_context.AccessibleName = "Siticone Toggle Switch"
        SiticoneToggleSwitch_last_context.AccessibleRole = AccessibleRole.CheckButton
        SiticoneToggleSwitch_last_context.CanBeep = True
        SiticoneToggleSwitch_last_context.CanShake = True
        SiticoneToggleSwitch_last_context.DisabledColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        SiticoneToggleSwitch_last_context.DisallowToggling = False
        SiticoneToggleSwitch_last_context.Dock = DockStyle.Left
        SiticoneToggleSwitch_last_context.EnableGlowEffect = True
        SiticoneToggleSwitch_last_context.ExtraThumbSize = 2
        SiticoneToggleSwitch_last_context.IsOn = False
        SiticoneToggleSwitch_last_context.IsReadOnly = False
        SiticoneToggleSwitch_last_context.IsRequired = False
        SiticoneToggleSwitch_last_context.LabelColor = Color.Black
        SiticoneToggleSwitch_last_context.LabelFont = New Font("Segoe UI", 9F)
        SiticoneToggleSwitch_last_context.Location = New Point(0, 0)
        SiticoneToggleSwitch_last_context.Logger = Nothing
        SiticoneToggleSwitch_last_context.Name = "SiticoneToggleSwitch_last_context"
        SiticoneToggleSwitch_last_context.OffBackColor1 = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        SiticoneToggleSwitch_last_context.OffBackColor2 = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        SiticoneToggleSwitch_last_context.OffBorderColor1 = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        SiticoneToggleSwitch_last_context.OffBorderColor2 = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        SiticoneToggleSwitch_last_context.OffIcon = Nothing
        SiticoneToggleSwitch_last_context.OffThumbColor1 = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        SiticoneToggleSwitch_last_context.OffThumbColor2 = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        SiticoneToggleSwitch_last_context.OnBackColor1 = Color.FromArgb(CByte(26), CByte(115), CByte(232))
        SiticoneToggleSwitch_last_context.OnBackColor2 = Color.FromArgb(CByte(26), CByte(115), CByte(232))
        SiticoneToggleSwitch_last_context.OnBorderColor1 = Color.FromArgb(CByte(26), CByte(115), CByte(232))
        SiticoneToggleSwitch_last_context.OnBorderColor2 = Color.FromArgb(CByte(26), CByte(115), CByte(232))
        SiticoneToggleSwitch_last_context.OnIcon = Nothing
        SiticoneToggleSwitch_last_context.OnThumbColor1 = Color.White
        SiticoneToggleSwitch_last_context.OnThumbColor2 = Color.White
        SiticoneToggleSwitch_last_context.PreventToggleOff = False
        SiticoneToggleSwitch_last_context.RippleColor = Color.FromArgb(CByte(100), CByte(255), CByte(255), CByte(255))
        SiticoneToggleSwitch_last_context.RippleExpansionRate = 2F
        SiticoneToggleSwitch_last_context.RippleOpacityDecay = 0.02F
        SiticoneToggleSwitch_last_context.Size = New Size(50, 25)
        SiticoneToggleSwitch_last_context.TabIndex = 54
        SiticoneToggleSwitch_last_context.ToggleOffSoundPath = ""
        SiticoneToggleSwitch_last_context.ToggleOnSoundPath = ""
        SiticoneToggleSwitch_last_context.ToolTipText = ""
        SiticoneToggleSwitch_last_context.TrackDeviceTheme = True
        ' 
        ' SiticoneButton_save_context
        ' 
        SiticoneButton_save_context.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard"
        SiticoneButton_save_context.AccessibleName = "Save Context"
        SiticoneButton_save_context.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        SiticoneButton_save_context.AutoSizeBasedOnText = False
        SiticoneButton_save_context.BackColor = Color.Transparent
        SiticoneButton_save_context.BadgeBackColor = Color.Red
        SiticoneButton_save_context.BadgeFont = New Font("Segoe UI", 8F, FontStyle.Bold)
        SiticoneButton_save_context.BadgeValue = 0
        SiticoneButton_save_context.BadgeValueForeColor = Color.White
        SiticoneButton_save_context.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        SiticoneButton_save_context.BorderWidth = 2
        SiticoneButton_save_context.ButtonBackColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        SiticoneButton_save_context.ButtonImage = Nothing
        SiticoneButton_save_context.ButtonTextLeftPadding = 0
        SiticoneButton_save_context.CanBeep = True
        SiticoneButton_save_context.CanGlow = False
        SiticoneButton_save_context.CanShake = True
        SiticoneButton_save_context.ContextMenuStripEx = Nothing
        SiticoneButton_save_context.CornerRadiusBottomLeft = 8
        SiticoneButton_save_context.CornerRadiusBottomRight = 8
        SiticoneButton_save_context.CornerRadiusTopLeft = 8
        SiticoneButton_save_context.CornerRadiusTopRight = 8
        SiticoneButton_save_context.CustomCursor = Cursors.Default
        SiticoneButton_save_context.DisabledTextColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        SiticoneButton_save_context.EnableLongPress = False
        SiticoneButton_save_context.EnablePressAnimation = True
        SiticoneButton_save_context.EnableRippleEffect = True
        SiticoneButton_save_context.EnableShadow = False
        SiticoneButton_save_context.EnableTextWrapping = False
        SiticoneButton_save_context.Font = New Font("Segoe UI", 9F)
        SiticoneButton_save_context.GlowColor = Color.FromArgb(CByte(100), CByte(255), CByte(255), CByte(255))
        SiticoneButton_save_context.GlowIntensity = 100
        SiticoneButton_save_context.GlowRadius = 20F
        SiticoneButton_save_context.GradientBackground = False
        SiticoneButton_save_context.GradientColor = Color.FromArgb(CByte(114), CByte(168), CByte(255))
        SiticoneButton_save_context.GradientMode = Drawing2D.LinearGradientMode.Vertical
        SiticoneButton_save_context.HintText = Nothing
        SiticoneButton_save_context.HoverBackColor = Color.FromArgb(CByte(114), CByte(168), CByte(255))
        SiticoneButton_save_context.HoverFontStyle = FontStyle.Regular
        SiticoneButton_save_context.HoverTextColor = Color.White
        SiticoneButton_save_context.HoverTransitionDuration = 250
        SiticoneButton_save_context.ImageAlign = ContentAlignment.MiddleLeft
        SiticoneButton_save_context.ImagePadding = 5
        SiticoneButton_save_context.ImageSize = New Size(16, 16)
        SiticoneButton_save_context.IsRadial = False
        SiticoneButton_save_context.IsReadOnly = False
        SiticoneButton_save_context.IsToggleButton = False
        SiticoneButton_save_context.IsToggled = False
        SiticoneButton_save_context.Location = New Point(490, 6)
        SiticoneButton_save_context.LongPressDurationMS = 1000
        SiticoneButton_save_context.Name = "SiticoneButton_save_context"
        SiticoneButton_save_context.NormalFontStyle = FontStyle.Regular
        SiticoneButton_save_context.ParticleColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        SiticoneButton_save_context.ParticleCount = 15
        SiticoneButton_save_context.PressAnimationScale = 0.97F
        SiticoneButton_save_context.PressedBackColor = Color.FromArgb(CByte(74), CByte(128), CByte(235))
        SiticoneButton_save_context.PressedFontStyle = FontStyle.Regular
        SiticoneButton_save_context.PressTransitionDuration = 150
        SiticoneButton_save_context.ReadOnlyTextColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        SiticoneButton_save_context.RippleColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        SiticoneButton_save_context.RippleOpacity = 0.3F
        SiticoneButton_save_context.RippleRadiusMultiplier = 0.6F
        SiticoneButton_save_context.ShadowBlur = 5
        SiticoneButton_save_context.ShadowColor = Color.FromArgb(CByte(100), CByte(0), CByte(0), CByte(0))
        SiticoneButton_save_context.ShadowOffset = New Point(2, 2)
        SiticoneButton_save_context.ShakeDuration = 500
        SiticoneButton_save_context.ShakeIntensity = 5
        SiticoneButton_save_context.Size = New Size(107, 24)
        SiticoneButton_save_context.TabIndex = 60
        SiticoneButton_save_context.Text = "Save Context"
        SiticoneButton_save_context.TextAlign = ContentAlignment.MiddleCenter
        SiticoneButton_save_context.TextColor = Color.White
        SiticoneButton_save_context.TooltipText = Nothing
        SiticoneButton_save_context.UseAdvancedRendering = True
        SiticoneButton_save_context.UseParticles = False
        ' 
        ' SiticoneButton_clear_context
        ' 
        SiticoneButton_clear_context.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard"
        SiticoneButton_clear_context.AccessibleName = "Clear Context"
        SiticoneButton_clear_context.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        SiticoneButton_clear_context.AutoSizeBasedOnText = False
        SiticoneButton_clear_context.BackColor = Color.Transparent
        SiticoneButton_clear_context.BadgeBackColor = Color.Red
        SiticoneButton_clear_context.BadgeFont = New Font("Segoe UI", 8F, FontStyle.Bold)
        SiticoneButton_clear_context.BadgeValue = 0
        SiticoneButton_clear_context.BadgeValueForeColor = Color.White
        SiticoneButton_clear_context.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        SiticoneButton_clear_context.BorderWidth = 2
        SiticoneButton_clear_context.ButtonBackColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        SiticoneButton_clear_context.ButtonImage = Nothing
        SiticoneButton_clear_context.ButtonTextLeftPadding = 0
        SiticoneButton_clear_context.CanBeep = True
        SiticoneButton_clear_context.CanGlow = False
        SiticoneButton_clear_context.CanShake = True
        SiticoneButton_clear_context.ContextMenuStripEx = Nothing
        SiticoneButton_clear_context.CornerRadiusBottomLeft = 8
        SiticoneButton_clear_context.CornerRadiusBottomRight = 8
        SiticoneButton_clear_context.CornerRadiusTopLeft = 8
        SiticoneButton_clear_context.CornerRadiusTopRight = 8
        SiticoneButton_clear_context.CustomCursor = Cursors.Default
        SiticoneButton_clear_context.DisabledTextColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        SiticoneButton_clear_context.EnableLongPress = False
        SiticoneButton_clear_context.EnablePressAnimation = True
        SiticoneButton_clear_context.EnableRippleEffect = True
        SiticoneButton_clear_context.EnableShadow = False
        SiticoneButton_clear_context.EnableTextWrapping = False
        SiticoneButton_clear_context.Font = New Font("Segoe UI", 9F)
        SiticoneButton_clear_context.GlowColor = Color.FromArgb(CByte(100), CByte(255), CByte(255), CByte(255))
        SiticoneButton_clear_context.GlowIntensity = 100
        SiticoneButton_clear_context.GlowRadius = 20F
        SiticoneButton_clear_context.GradientBackground = False
        SiticoneButton_clear_context.GradientColor = Color.FromArgb(CByte(114), CByte(168), CByte(255))
        SiticoneButton_clear_context.GradientMode = Drawing2D.LinearGradientMode.Vertical
        SiticoneButton_clear_context.HintText = Nothing
        SiticoneButton_clear_context.HoverBackColor = Color.FromArgb(CByte(114), CByte(168), CByte(255))
        SiticoneButton_clear_context.HoverFontStyle = FontStyle.Regular
        SiticoneButton_clear_context.HoverTextColor = Color.White
        SiticoneButton_clear_context.HoverTransitionDuration = 250
        SiticoneButton_clear_context.ImageAlign = ContentAlignment.MiddleLeft
        SiticoneButton_clear_context.ImagePadding = 5
        SiticoneButton_clear_context.ImageSize = New Size(16, 16)
        SiticoneButton_clear_context.IsRadial = False
        SiticoneButton_clear_context.IsReadOnly = False
        SiticoneButton_clear_context.IsToggleButton = False
        SiticoneButton_clear_context.IsToggled = False
        SiticoneButton_clear_context.Location = New Point(264, 6)
        SiticoneButton_clear_context.LongPressDurationMS = 1000
        SiticoneButton_clear_context.Name = "SiticoneButton_clear_context"
        SiticoneButton_clear_context.NormalFontStyle = FontStyle.Regular
        SiticoneButton_clear_context.ParticleColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        SiticoneButton_clear_context.ParticleCount = 15
        SiticoneButton_clear_context.PressAnimationScale = 0.97F
        SiticoneButton_clear_context.PressedBackColor = Color.FromArgb(CByte(74), CByte(128), CByte(235))
        SiticoneButton_clear_context.PressedFontStyle = FontStyle.Regular
        SiticoneButton_clear_context.PressTransitionDuration = 150
        SiticoneButton_clear_context.ReadOnlyTextColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        SiticoneButton_clear_context.RippleColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        SiticoneButton_clear_context.RippleOpacity = 0.3F
        SiticoneButton_clear_context.RippleRadiusMultiplier = 0.6F
        SiticoneButton_clear_context.ShadowBlur = 5
        SiticoneButton_clear_context.ShadowColor = Color.FromArgb(CByte(100), CByte(0), CByte(0), CByte(0))
        SiticoneButton_clear_context.ShadowOffset = New Point(2, 2)
        SiticoneButton_clear_context.ShakeDuration = 500
        SiticoneButton_clear_context.ShakeIntensity = 5
        SiticoneButton_clear_context.Size = New Size(107, 24)
        SiticoneButton_clear_context.TabIndex = 47
        SiticoneButton_clear_context.Text = "Clear Context"
        SiticoneButton_clear_context.TextAlign = ContentAlignment.MiddleCenter
        SiticoneButton_clear_context.TextColor = Color.White
        SiticoneButton_clear_context.TooltipText = Nothing
        SiticoneButton_clear_context.UseAdvancedRendering = True
        SiticoneButton_clear_context.UseParticles = False
        ' 
        ' SiticoneButton_load_context
        ' 
        SiticoneButton_load_context.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard"
        SiticoneButton_load_context.AccessibleName = "Load Context"
        SiticoneButton_load_context.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        SiticoneButton_load_context.AutoSizeBasedOnText = False
        SiticoneButton_load_context.BackColor = Color.Transparent
        SiticoneButton_load_context.BadgeBackColor = Color.Red
        SiticoneButton_load_context.BadgeFont = New Font("Segoe UI", 8F, FontStyle.Bold)
        SiticoneButton_load_context.BadgeValue = 0
        SiticoneButton_load_context.BadgeValueForeColor = Color.White
        SiticoneButton_load_context.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        SiticoneButton_load_context.BorderWidth = 2
        SiticoneButton_load_context.ButtonBackColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        SiticoneButton_load_context.ButtonImage = Nothing
        SiticoneButton_load_context.ButtonTextLeftPadding = 0
        SiticoneButton_load_context.CanBeep = True
        SiticoneButton_load_context.CanGlow = False
        SiticoneButton_load_context.CanShake = True
        SiticoneButton_load_context.ContextMenuStripEx = Nothing
        SiticoneButton_load_context.CornerRadiusBottomLeft = 8
        SiticoneButton_load_context.CornerRadiusBottomRight = 8
        SiticoneButton_load_context.CornerRadiusTopLeft = 8
        SiticoneButton_load_context.CornerRadiusTopRight = 8
        SiticoneButton_load_context.CustomCursor = Cursors.Default
        SiticoneButton_load_context.DisabledTextColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        SiticoneButton_load_context.EnableLongPress = False
        SiticoneButton_load_context.EnablePressAnimation = True
        SiticoneButton_load_context.EnableRippleEffect = True
        SiticoneButton_load_context.EnableShadow = False
        SiticoneButton_load_context.EnableTextWrapping = False
        SiticoneButton_load_context.Font = New Font("Segoe UI", 9F)
        SiticoneButton_load_context.GlowColor = Color.FromArgb(CByte(100), CByte(255), CByte(255), CByte(255))
        SiticoneButton_load_context.GlowIntensity = 100
        SiticoneButton_load_context.GlowRadius = 20F
        SiticoneButton_load_context.GradientBackground = False
        SiticoneButton_load_context.GradientColor = Color.FromArgb(CByte(114), CByte(168), CByte(255))
        SiticoneButton_load_context.GradientMode = Drawing2D.LinearGradientMode.Vertical
        SiticoneButton_load_context.HintText = Nothing
        SiticoneButton_load_context.HoverBackColor = Color.FromArgb(CByte(114), CByte(168), CByte(255))
        SiticoneButton_load_context.HoverFontStyle = FontStyle.Regular
        SiticoneButton_load_context.HoverTextColor = Color.White
        SiticoneButton_load_context.HoverTransitionDuration = 250
        SiticoneButton_load_context.ImageAlign = ContentAlignment.MiddleLeft
        SiticoneButton_load_context.ImagePadding = 5
        SiticoneButton_load_context.ImageSize = New Size(16, 16)
        SiticoneButton_load_context.IsRadial = False
        SiticoneButton_load_context.IsReadOnly = False
        SiticoneButton_load_context.IsToggleButton = False
        SiticoneButton_load_context.IsToggled = False
        SiticoneButton_load_context.Location = New Point(377, 6)
        SiticoneButton_load_context.LongPressDurationMS = 1000
        SiticoneButton_load_context.Name = "SiticoneButton_load_context"
        SiticoneButton_load_context.NormalFontStyle = FontStyle.Regular
        SiticoneButton_load_context.ParticleColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        SiticoneButton_load_context.ParticleCount = 15
        SiticoneButton_load_context.PressAnimationScale = 0.97F
        SiticoneButton_load_context.PressedBackColor = Color.FromArgb(CByte(74), CByte(128), CByte(235))
        SiticoneButton_load_context.PressedFontStyle = FontStyle.Regular
        SiticoneButton_load_context.PressTransitionDuration = 150
        SiticoneButton_load_context.ReadOnlyTextColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        SiticoneButton_load_context.RippleColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        SiticoneButton_load_context.RippleOpacity = 0.3F
        SiticoneButton_load_context.RippleRadiusMultiplier = 0.6F
        SiticoneButton_load_context.ShadowBlur = 5
        SiticoneButton_load_context.ShadowColor = Color.FromArgb(CByte(100), CByte(0), CByte(0), CByte(0))
        SiticoneButton_load_context.ShadowOffset = New Point(2, 2)
        SiticoneButton_load_context.ShakeDuration = 500
        SiticoneButton_load_context.ShakeIntensity = 5
        SiticoneButton_load_context.Size = New Size(107, 24)
        SiticoneButton_load_context.TabIndex = 59
        SiticoneButton_load_context.Text = "Load Context"
        SiticoneButton_load_context.TextAlign = ContentAlignment.MiddleCenter
        SiticoneButton_load_context.TextColor = Color.White
        SiticoneButton_load_context.TooltipText = Nothing
        SiticoneButton_load_context.UseAdvancedRendering = True
        SiticoneButton_load_context.UseParticles = False
        ' 
        ' SiticoneFlatPanel_format_use
        ' 
        SiticoneFlatPanel_format_use.BackColor = Color.Transparent
        SiticoneFlatPanel_format_use.Controls.Add(SiticoneLabel_format_use)
        SiticoneFlatPanel_format_use.Controls.Add(SiticoneToggleSwitch_format_use)
        SiticoneFlatPanel_format_use.Location = New Point(232, 104)
        SiticoneFlatPanel_format_use.MinimumSize = New Size(20, 20)
        SiticoneFlatPanel_format_use.Name = "SiticoneFlatPanel_format_use"
        SiticoneFlatPanel_format_use.Size = New Size(178, 25)
        SiticoneFlatPanel_format_use.TabIndex = 56
        ' 
        ' SiticoneLabel_format_use
        ' 
        SiticoneLabel_format_use.BackColor = Color.Transparent
        SiticoneLabel_format_use.Dock = DockStyle.Right
        SiticoneLabel_format_use.Font = New Font("Segoe UI", 10F)
        SiticoneLabel_format_use.Location = New Point(48, 0)
        SiticoneLabel_format_use.Name = "SiticoneLabel_format_use"
        SiticoneLabel_format_use.Size = New Size(130, 25)
        SiticoneLabel_format_use.TabIndex = 55
        SiticoneLabel_format_use.Text = "Use Output Format"
        SiticoneLabel_format_use.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' SiticoneToggleSwitch_format_use
        ' 
        SiticoneToggleSwitch_format_use.AccessibleDescription = "A customizable toggle switch that can be turned on or off."
        SiticoneToggleSwitch_format_use.AccessibleName = "Siticone Toggle Switch"
        SiticoneToggleSwitch_format_use.AccessibleRole = AccessibleRole.CheckButton
        SiticoneToggleSwitch_format_use.CanBeep = True
        SiticoneToggleSwitch_format_use.CanShake = True
        SiticoneToggleSwitch_format_use.DisabledColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        SiticoneToggleSwitch_format_use.DisallowToggling = False
        SiticoneToggleSwitch_format_use.Dock = DockStyle.Left
        SiticoneToggleSwitch_format_use.EnableGlowEffect = True
        SiticoneToggleSwitch_format_use.ExtraThumbSize = 2
        SiticoneToggleSwitch_format_use.IsOn = False
        SiticoneToggleSwitch_format_use.IsReadOnly = False
        SiticoneToggleSwitch_format_use.IsRequired = False
        SiticoneToggleSwitch_format_use.LabelColor = Color.Black
        SiticoneToggleSwitch_format_use.LabelFont = New Font("Segoe UI", 9F)
        SiticoneToggleSwitch_format_use.Location = New Point(0, 0)
        SiticoneToggleSwitch_format_use.Logger = Nothing
        SiticoneToggleSwitch_format_use.Name = "SiticoneToggleSwitch_format_use"
        SiticoneToggleSwitch_format_use.OffBackColor1 = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        SiticoneToggleSwitch_format_use.OffBackColor2 = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        SiticoneToggleSwitch_format_use.OffBorderColor1 = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        SiticoneToggleSwitch_format_use.OffBorderColor2 = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        SiticoneToggleSwitch_format_use.OffIcon = Nothing
        SiticoneToggleSwitch_format_use.OffThumbColor1 = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        SiticoneToggleSwitch_format_use.OffThumbColor2 = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        SiticoneToggleSwitch_format_use.OnBackColor1 = Color.FromArgb(CByte(26), CByte(115), CByte(232))
        SiticoneToggleSwitch_format_use.OnBackColor2 = Color.FromArgb(CByte(26), CByte(115), CByte(232))
        SiticoneToggleSwitch_format_use.OnBorderColor1 = Color.FromArgb(CByte(26), CByte(115), CByte(232))
        SiticoneToggleSwitch_format_use.OnBorderColor2 = Color.FromArgb(CByte(26), CByte(115), CByte(232))
        SiticoneToggleSwitch_format_use.OnIcon = Nothing
        SiticoneToggleSwitch_format_use.OnThumbColor1 = Color.White
        SiticoneToggleSwitch_format_use.OnThumbColor2 = Color.White
        SiticoneToggleSwitch_format_use.PreventToggleOff = False
        SiticoneToggleSwitch_format_use.RippleColor = Color.FromArgb(CByte(100), CByte(255), CByte(255), CByte(255))
        SiticoneToggleSwitch_format_use.RippleExpansionRate = 2F
        SiticoneToggleSwitch_format_use.RippleOpacityDecay = 0.02F
        SiticoneToggleSwitch_format_use.Size = New Size(50, 25)
        SiticoneToggleSwitch_format_use.TabIndex = 54
        SiticoneToggleSwitch_format_use.ToggleOffSoundPath = ""
        SiticoneToggleSwitch_format_use.ToggleOnSoundPath = ""
        SiticoneToggleSwitch_format_use.ToolTipText = ""
        SiticoneToggleSwitch_format_use.TrackDeviceTheme = True
        ' 
        ' SiticoneFlatPanel_system_use
        ' 
        SiticoneFlatPanel_system_use.BackColor = Color.Transparent
        SiticoneFlatPanel_system_use.Controls.Add(SiticoneLabel_system_use)
        SiticoneFlatPanel_system_use.Controls.Add(SiticoneToggleSwitch_system_use)
        SiticoneFlatPanel_system_use.Location = New Point(232, 4)
        SiticoneFlatPanel_system_use.MinimumSize = New Size(20, 20)
        SiticoneFlatPanel_system_use.Name = "SiticoneFlatPanel_system_use"
        SiticoneFlatPanel_system_use.Size = New Size(178, 25)
        SiticoneFlatPanel_system_use.TabIndex = 55
        ' 
        ' SiticoneLabel_system_use
        ' 
        SiticoneLabel_system_use.BackColor = Color.Transparent
        SiticoneLabel_system_use.Dock = DockStyle.Right
        SiticoneLabel_system_use.Font = New Font("Segoe UI", 10F)
        SiticoneLabel_system_use.Location = New Point(48, 0)
        SiticoneLabel_system_use.Name = "SiticoneLabel_system_use"
        SiticoneLabel_system_use.Size = New Size(130, 25)
        SiticoneLabel_system_use.TabIndex = 55
        SiticoneLabel_system_use.Text = "Use System Prompt"
        SiticoneLabel_system_use.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' SiticoneToggleSwitch_system_use
        ' 
        SiticoneToggleSwitch_system_use.AccessibleDescription = "A customizable toggle switch that can be turned on or off."
        SiticoneToggleSwitch_system_use.AccessibleName = "Siticone Toggle Switch"
        SiticoneToggleSwitch_system_use.AccessibleRole = AccessibleRole.CheckButton
        SiticoneToggleSwitch_system_use.CanBeep = True
        SiticoneToggleSwitch_system_use.CanShake = True
        SiticoneToggleSwitch_system_use.DisabledColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        SiticoneToggleSwitch_system_use.DisallowToggling = False
        SiticoneToggleSwitch_system_use.Dock = DockStyle.Left
        SiticoneToggleSwitch_system_use.EnableGlowEffect = True
        SiticoneToggleSwitch_system_use.ExtraThumbSize = 2
        SiticoneToggleSwitch_system_use.IsOn = False
        SiticoneToggleSwitch_system_use.IsReadOnly = False
        SiticoneToggleSwitch_system_use.IsRequired = False
        SiticoneToggleSwitch_system_use.LabelColor = Color.Black
        SiticoneToggleSwitch_system_use.LabelFont = New Font("Segoe UI", 9F)
        SiticoneToggleSwitch_system_use.Location = New Point(0, 0)
        SiticoneToggleSwitch_system_use.Logger = Nothing
        SiticoneToggleSwitch_system_use.Name = "SiticoneToggleSwitch_system_use"
        SiticoneToggleSwitch_system_use.OffBackColor1 = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        SiticoneToggleSwitch_system_use.OffBackColor2 = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        SiticoneToggleSwitch_system_use.OffBorderColor1 = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        SiticoneToggleSwitch_system_use.OffBorderColor2 = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        SiticoneToggleSwitch_system_use.OffIcon = Nothing
        SiticoneToggleSwitch_system_use.OffThumbColor1 = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        SiticoneToggleSwitch_system_use.OffThumbColor2 = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        SiticoneToggleSwitch_system_use.OnBackColor1 = Color.FromArgb(CByte(26), CByte(115), CByte(232))
        SiticoneToggleSwitch_system_use.OnBackColor2 = Color.FromArgb(CByte(26), CByte(115), CByte(232))
        SiticoneToggleSwitch_system_use.OnBorderColor1 = Color.FromArgb(CByte(26), CByte(115), CByte(232))
        SiticoneToggleSwitch_system_use.OnBorderColor2 = Color.FromArgb(CByte(26), CByte(115), CByte(232))
        SiticoneToggleSwitch_system_use.OnIcon = Nothing
        SiticoneToggleSwitch_system_use.OnThumbColor1 = Color.White
        SiticoneToggleSwitch_system_use.OnThumbColor2 = Color.White
        SiticoneToggleSwitch_system_use.PreventToggleOff = False
        SiticoneToggleSwitch_system_use.RippleColor = Color.FromArgb(CByte(100), CByte(255), CByte(255), CByte(255))
        SiticoneToggleSwitch_system_use.RippleExpansionRate = 2F
        SiticoneToggleSwitch_system_use.RippleOpacityDecay = 0.02F
        SiticoneToggleSwitch_system_use.Size = New Size(50, 25)
        SiticoneToggleSwitch_system_use.TabIndex = 54
        SiticoneToggleSwitch_system_use.ToggleOffSoundPath = ""
        SiticoneToggleSwitch_system_use.ToggleOnSoundPath = ""
        SiticoneToggleSwitch_system_use.ToolTipText = ""
        SiticoneToggleSwitch_system_use.TrackDeviceTheme = True
        ' 
        ' Scintilla_format
        ' 
        Scintilla_format.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Scintilla_format.AutocompleteListSelectedBackColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        Scintilla_format.Font = New Font("Consolas", 10F)
        Scintilla_format.LexerName = "json"
        Scintilla_format.Location = New Point(8, 130)
        Scintilla_format.Name = "Scintilla_format"
        Scintilla_format.ScrollWidth = 70
        Scintilla_format.Size = New Size(1391, 203)
        Scintilla_format.TabIndex = 53
        ' 
        ' SiticoneButton_link_content_prompt
        ' 
        SiticoneButton_link_content_prompt.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard"
        SiticoneButton_link_content_prompt.AccessibleName = ""
        SiticoneButton_link_content_prompt.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        SiticoneButton_link_content_prompt.AutoSizeBasedOnText = False
        SiticoneButton_link_content_prompt.BackColor = Color.Transparent
        SiticoneButton_link_content_prompt.BadgeBackColor = Color.Red
        SiticoneButton_link_content_prompt.BadgeFont = New Font("Segoe UI", 8F, FontStyle.Bold)
        SiticoneButton_link_content_prompt.BadgeValue = 0
        SiticoneButton_link_content_prompt.BadgeValueForeColor = Color.White
        SiticoneButton_link_content_prompt.BorderColor = Color.Gray
        SiticoneButton_link_content_prompt.BorderWidth = 2
        SiticoneButton_link_content_prompt.ButtonBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        SiticoneButton_link_content_prompt.ButtonImage = My.Resources.Resource_pic.help_16
        SiticoneButton_link_content_prompt.ButtonTextLeftPadding = 0
        SiticoneButton_link_content_prompt.CanBeep = True
        SiticoneButton_link_content_prompt.CanGlow = False
        SiticoneButton_link_content_prompt.CanShake = True
        SiticoneButton_link_content_prompt.ContextMenuStripEx = Nothing
        SiticoneButton_link_content_prompt.CornerRadiusBottomLeft = 8
        SiticoneButton_link_content_prompt.CornerRadiusBottomRight = 8
        SiticoneButton_link_content_prompt.CornerRadiusTopLeft = 8
        SiticoneButton_link_content_prompt.CornerRadiusTopRight = 8
        SiticoneButton_link_content_prompt.CustomCursor = Cursors.Default
        SiticoneButton_link_content_prompt.DisabledTextColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        SiticoneButton_link_content_prompt.EnableLongPress = False
        SiticoneButton_link_content_prompt.EnablePressAnimation = True
        SiticoneButton_link_content_prompt.EnableRippleEffect = True
        SiticoneButton_link_content_prompt.EnableShadow = False
        SiticoneButton_link_content_prompt.EnableTextWrapping = False
        SiticoneButton_link_content_prompt.Font = New Font("Segoe UI", 9F)
        SiticoneButton_link_content_prompt.GlowColor = Color.FromArgb(CByte(100), CByte(255), CByte(255), CByte(255))
        SiticoneButton_link_content_prompt.GlowIntensity = 100
        SiticoneButton_link_content_prompt.GlowRadius = 20F
        SiticoneButton_link_content_prompt.GradientBackground = False
        SiticoneButton_link_content_prompt.GradientColor = Color.Gray
        SiticoneButton_link_content_prompt.GradientMode = Drawing2D.LinearGradientMode.Vertical
        SiticoneButton_link_content_prompt.HintText = Nothing
        SiticoneButton_link_content_prompt.HoverBackColor = Color.Silver
        SiticoneButton_link_content_prompt.HoverFontStyle = FontStyle.Regular
        SiticoneButton_link_content_prompt.HoverTextColor = Color.White
        SiticoneButton_link_content_prompt.HoverTransitionDuration = 250
        SiticoneButton_link_content_prompt.ImageAlign = ContentAlignment.MiddleCenter
        SiticoneButton_link_content_prompt.ImagePadding = 5
        SiticoneButton_link_content_prompt.ImageSize = New Size(16, 16)
        SiticoneButton_link_content_prompt.IsRadial = False
        SiticoneButton_link_content_prompt.IsReadOnly = False
        SiticoneButton_link_content_prompt.IsToggleButton = False
        SiticoneButton_link_content_prompt.IsToggled = False
        SiticoneButton_link_content_prompt.Location = New Point(8, 501)
        SiticoneButton_link_content_prompt.LongPressDurationMS = 1000
        SiticoneButton_link_content_prompt.Name = "SiticoneButton_link_content_prompt"
        SiticoneButton_link_content_prompt.NormalFontStyle = FontStyle.Regular
        SiticoneButton_link_content_prompt.ParticleColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        SiticoneButton_link_content_prompt.ParticleCount = 15
        SiticoneButton_link_content_prompt.PressAnimationScale = 0.97F
        SiticoneButton_link_content_prompt.PressedBackColor = Color.FromArgb(CByte(74), CByte(128), CByte(235))
        SiticoneButton_link_content_prompt.PressedFontStyle = FontStyle.Regular
        SiticoneButton_link_content_prompt.PressTransitionDuration = 150
        SiticoneButton_link_content_prompt.ReadOnlyTextColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        SiticoneButton_link_content_prompt.RippleColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        SiticoneButton_link_content_prompt.RippleOpacity = 0.3F
        SiticoneButton_link_content_prompt.RippleRadiusMultiplier = 0.6F
        SiticoneButton_link_content_prompt.ShadowBlur = 5
        SiticoneButton_link_content_prompt.ShadowColor = Color.FromArgb(CByte(100), CByte(0), CByte(0), CByte(0))
        SiticoneButton_link_content_prompt.ShadowOffset = New Point(2, 2)
        SiticoneButton_link_content_prompt.ShakeDuration = 500
        SiticoneButton_link_content_prompt.ShakeIntensity = 5
        SiticoneButton_link_content_prompt.Size = New Size(30, 24)
        SiticoneButton_link_content_prompt.TabIndex = 52
        SiticoneButton_link_content_prompt.TextAlign = ContentAlignment.MiddleCenter
        SiticoneButton_link_content_prompt.TextColor = Color.White
        ToolTip1.SetToolTip(SiticoneButton_link_content_prompt, "Help")
        SiticoneButton_link_content_prompt.TooltipText = Nothing
        SiticoneButton_link_content_prompt.UseAdvancedRendering = True
        SiticoneButton_link_content_prompt.UseParticles = False
        ' 
        ' SiticoneTextArea_content_prompt
        ' 
        SiticoneTextArea_content_prompt.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        SiticoneTextArea_content_prompt.BackColor = SystemColors.GradientInactiveCaption
        SiticoneTextArea_content_prompt.BorderStyle = BorderStyle.None
        SiticoneTextArea_content_prompt.Font = New Font("Century Gothic", 10F)
        SiticoneTextArea_content_prompt.Location = New Point(8, 526)
        SiticoneTextArea_content_prompt.Margin = New Padding(5)
        SiticoneTextArea_content_prompt.MinimumSize = New Size(100, 65)
        SiticoneTextArea_content_prompt.Multiline = True
        SiticoneTextArea_content_prompt.Name = "SiticoneTextArea_content_prompt"
        SiticoneTextArea_content_prompt.PlaceholderText = "Write Contentprompt here..."
        SiticoneTextArea_content_prompt.ScrollBars = ScrollBars.Vertical
        SiticoneTextArea_content_prompt.Size = New Size(1391, 65)
        SiticoneTextArea_content_prompt.TabIndex = 51
        ' 
        ' SiticoneLabel13
        ' 
        SiticoneLabel13.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        SiticoneLabel13.BackColor = Color.Transparent
        SiticoneLabel13.Font = New Font("Segoe UI", 10F)
        SiticoneLabel13.Location = New Point(44, 504)
        SiticoneLabel13.Name = "SiticoneLabel13"
        SiticoneLabel13.Size = New Size(170, 21)
        SiticoneLabel13.TabIndex = 50
        SiticoneLabel13.Text = "Content Prompt:"
        ' 
        ' SiticoneButton_link_output_format
        ' 
        SiticoneButton_link_output_format.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard"
        SiticoneButton_link_output_format.AccessibleName = ""
        SiticoneButton_link_output_format.AutoSizeBasedOnText = False
        SiticoneButton_link_output_format.BackColor = Color.Transparent
        SiticoneButton_link_output_format.BadgeBackColor = Color.Red
        SiticoneButton_link_output_format.BadgeFont = New Font("Segoe UI", 8F, FontStyle.Bold)
        SiticoneButton_link_output_format.BadgeValue = 0
        SiticoneButton_link_output_format.BadgeValueForeColor = Color.White
        SiticoneButton_link_output_format.BorderColor = Color.Gray
        SiticoneButton_link_output_format.BorderWidth = 2
        SiticoneButton_link_output_format.ButtonBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        SiticoneButton_link_output_format.ButtonImage = My.Resources.Resource_pic.help_16
        SiticoneButton_link_output_format.ButtonTextLeftPadding = 0
        SiticoneButton_link_output_format.CanBeep = True
        SiticoneButton_link_output_format.CanGlow = False
        SiticoneButton_link_output_format.CanShake = True
        SiticoneButton_link_output_format.ContextMenuStripEx = Nothing
        SiticoneButton_link_output_format.CornerRadiusBottomLeft = 8
        SiticoneButton_link_output_format.CornerRadiusBottomRight = 8
        SiticoneButton_link_output_format.CornerRadiusTopLeft = 8
        SiticoneButton_link_output_format.CornerRadiusTopRight = 8
        SiticoneButton_link_output_format.CustomCursor = Cursors.Default
        SiticoneButton_link_output_format.DisabledTextColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        SiticoneButton_link_output_format.EnableLongPress = False
        SiticoneButton_link_output_format.EnablePressAnimation = True
        SiticoneButton_link_output_format.EnableRippleEffect = True
        SiticoneButton_link_output_format.EnableShadow = False
        SiticoneButton_link_output_format.EnableTextWrapping = False
        SiticoneButton_link_output_format.Font = New Font("Segoe UI", 9F)
        SiticoneButton_link_output_format.GlowColor = Color.FromArgb(CByte(100), CByte(255), CByte(255), CByte(255))
        SiticoneButton_link_output_format.GlowIntensity = 100
        SiticoneButton_link_output_format.GlowRadius = 20F
        SiticoneButton_link_output_format.GradientBackground = False
        SiticoneButton_link_output_format.GradientColor = Color.Gray
        SiticoneButton_link_output_format.GradientMode = Drawing2D.LinearGradientMode.Vertical
        SiticoneButton_link_output_format.HintText = Nothing
        SiticoneButton_link_output_format.HoverBackColor = Color.Silver
        SiticoneButton_link_output_format.HoverFontStyle = FontStyle.Regular
        SiticoneButton_link_output_format.HoverTextColor = Color.White
        SiticoneButton_link_output_format.HoverTransitionDuration = 250
        SiticoneButton_link_output_format.ImageAlign = ContentAlignment.MiddleCenter
        SiticoneButton_link_output_format.ImagePadding = 5
        SiticoneButton_link_output_format.ImageSize = New Size(16, 16)
        SiticoneButton_link_output_format.IsRadial = False
        SiticoneButton_link_output_format.IsReadOnly = False
        SiticoneButton_link_output_format.IsToggleButton = False
        SiticoneButton_link_output_format.IsToggled = False
        SiticoneButton_link_output_format.Location = New Point(8, 105)
        SiticoneButton_link_output_format.LongPressDurationMS = 1000
        SiticoneButton_link_output_format.Name = "SiticoneButton_link_output_format"
        SiticoneButton_link_output_format.NormalFontStyle = FontStyle.Regular
        SiticoneButton_link_output_format.ParticleColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        SiticoneButton_link_output_format.ParticleCount = 15
        SiticoneButton_link_output_format.PressAnimationScale = 0.97F
        SiticoneButton_link_output_format.PressedBackColor = Color.FromArgb(CByte(74), CByte(128), CByte(235))
        SiticoneButton_link_output_format.PressedFontStyle = FontStyle.Regular
        SiticoneButton_link_output_format.PressTransitionDuration = 150
        SiticoneButton_link_output_format.ReadOnlyTextColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        SiticoneButton_link_output_format.RippleColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        SiticoneButton_link_output_format.RippleOpacity = 0.3F
        SiticoneButton_link_output_format.RippleRadiusMultiplier = 0.6F
        SiticoneButton_link_output_format.ShadowBlur = 5
        SiticoneButton_link_output_format.ShadowColor = Color.FromArgb(CByte(100), CByte(0), CByte(0), CByte(0))
        SiticoneButton_link_output_format.ShadowOffset = New Point(2, 2)
        SiticoneButton_link_output_format.ShakeDuration = 500
        SiticoneButton_link_output_format.ShakeIntensity = 5
        SiticoneButton_link_output_format.Size = New Size(30, 24)
        SiticoneButton_link_output_format.TabIndex = 49
        SiticoneButton_link_output_format.TextAlign = ContentAlignment.MiddleCenter
        SiticoneButton_link_output_format.TextColor = Color.White
        ToolTip1.SetToolTip(SiticoneButton_link_output_format, "Help")
        SiticoneButton_link_output_format.TooltipText = Nothing
        SiticoneButton_link_output_format.UseAdvancedRendering = True
        SiticoneButton_link_output_format.UseParticles = False
        ' 
        ' SiticoneButton_link_system_prompt
        ' 
        SiticoneButton_link_system_prompt.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard"
        SiticoneButton_link_system_prompt.AccessibleName = ""
        SiticoneButton_link_system_prompt.AutoSizeBasedOnText = False
        SiticoneButton_link_system_prompt.BackColor = Color.Transparent
        SiticoneButton_link_system_prompt.BadgeBackColor = Color.Red
        SiticoneButton_link_system_prompt.BadgeFont = New Font("Segoe UI", 8F, FontStyle.Bold)
        SiticoneButton_link_system_prompt.BadgeValue = 0
        SiticoneButton_link_system_prompt.BadgeValueForeColor = Color.White
        SiticoneButton_link_system_prompt.BorderColor = Color.Gray
        SiticoneButton_link_system_prompt.BorderWidth = 2
        SiticoneButton_link_system_prompt.ButtonBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        SiticoneButton_link_system_prompt.ButtonImage = My.Resources.Resource_pic.help_16
        SiticoneButton_link_system_prompt.ButtonTextLeftPadding = 0
        SiticoneButton_link_system_prompt.CanBeep = True
        SiticoneButton_link_system_prompt.CanGlow = False
        SiticoneButton_link_system_prompt.CanShake = True
        SiticoneButton_link_system_prompt.ContextMenuStripEx = Nothing
        SiticoneButton_link_system_prompt.CornerRadiusBottomLeft = 8
        SiticoneButton_link_system_prompt.CornerRadiusBottomRight = 8
        SiticoneButton_link_system_prompt.CornerRadiusTopLeft = 8
        SiticoneButton_link_system_prompt.CornerRadiusTopRight = 8
        SiticoneButton_link_system_prompt.CustomCursor = Cursors.Default
        SiticoneButton_link_system_prompt.DisabledTextColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        SiticoneButton_link_system_prompt.EnableLongPress = False
        SiticoneButton_link_system_prompt.EnablePressAnimation = True
        SiticoneButton_link_system_prompt.EnableRippleEffect = True
        SiticoneButton_link_system_prompt.EnableShadow = False
        SiticoneButton_link_system_prompt.EnableTextWrapping = False
        SiticoneButton_link_system_prompt.Font = New Font("Segoe UI", 9F)
        SiticoneButton_link_system_prompt.GlowColor = Color.FromArgb(CByte(100), CByte(255), CByte(255), CByte(255))
        SiticoneButton_link_system_prompt.GlowIntensity = 100
        SiticoneButton_link_system_prompt.GlowRadius = 20F
        SiticoneButton_link_system_prompt.GradientBackground = False
        SiticoneButton_link_system_prompt.GradientColor = Color.Gray
        SiticoneButton_link_system_prompt.GradientMode = Drawing2D.LinearGradientMode.Vertical
        SiticoneButton_link_system_prompt.HintText = Nothing
        SiticoneButton_link_system_prompt.HoverBackColor = Color.Silver
        SiticoneButton_link_system_prompt.HoverFontStyle = FontStyle.Regular
        SiticoneButton_link_system_prompt.HoverTextColor = Color.White
        SiticoneButton_link_system_prompt.HoverTransitionDuration = 250
        SiticoneButton_link_system_prompt.ImageAlign = ContentAlignment.MiddleCenter
        SiticoneButton_link_system_prompt.ImagePadding = 5
        SiticoneButton_link_system_prompt.ImageSize = New Size(16, 16)
        SiticoneButton_link_system_prompt.IsRadial = False
        SiticoneButton_link_system_prompt.IsReadOnly = False
        SiticoneButton_link_system_prompt.IsToggleButton = False
        SiticoneButton_link_system_prompt.IsToggled = False
        SiticoneButton_link_system_prompt.Location = New Point(8, 6)
        SiticoneButton_link_system_prompt.LongPressDurationMS = 1000
        SiticoneButton_link_system_prompt.Name = "SiticoneButton_link_system_prompt"
        SiticoneButton_link_system_prompt.NormalFontStyle = FontStyle.Regular
        SiticoneButton_link_system_prompt.ParticleColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        SiticoneButton_link_system_prompt.ParticleCount = 15
        SiticoneButton_link_system_prompt.PressAnimationScale = 0.97F
        SiticoneButton_link_system_prompt.PressedBackColor = Color.FromArgb(CByte(74), CByte(128), CByte(235))
        SiticoneButton_link_system_prompt.PressedFontStyle = FontStyle.Regular
        SiticoneButton_link_system_prompt.PressTransitionDuration = 150
        SiticoneButton_link_system_prompt.ReadOnlyTextColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        SiticoneButton_link_system_prompt.RippleColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        SiticoneButton_link_system_prompt.RippleOpacity = 0.3F
        SiticoneButton_link_system_prompt.RippleRadiusMultiplier = 0.6F
        SiticoneButton_link_system_prompt.ShadowBlur = 5
        SiticoneButton_link_system_prompt.ShadowColor = Color.FromArgb(CByte(100), CByte(0), CByte(0), CByte(0))
        SiticoneButton_link_system_prompt.ShadowOffset = New Point(2, 2)
        SiticoneButton_link_system_prompt.ShakeDuration = 500
        SiticoneButton_link_system_prompt.ShakeIntensity = 5
        SiticoneButton_link_system_prompt.Size = New Size(30, 24)
        SiticoneButton_link_system_prompt.TabIndex = 48
        SiticoneButton_link_system_prompt.TextAlign = ContentAlignment.MiddleCenter
        SiticoneButton_link_system_prompt.TextColor = Color.White
        ToolTip1.SetToolTip(SiticoneButton_link_system_prompt, "Help")
        SiticoneButton_link_system_prompt.TooltipText = Nothing
        SiticoneButton_link_system_prompt.UseAdvancedRendering = True
        SiticoneButton_link_system_prompt.UseParticles = False
        ' 
        ' SiticoneButton_link_options_parameter
        ' 
        SiticoneButton_link_options_parameter.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard"
        SiticoneButton_link_options_parameter.AccessibleName = ""
        SiticoneButton_link_options_parameter.AutoSizeBasedOnText = False
        SiticoneButton_link_options_parameter.BackColor = Color.Transparent
        SiticoneButton_link_options_parameter.BadgeBackColor = Color.Red
        SiticoneButton_link_options_parameter.BadgeFont = New Font("Segoe UI", 8F, FontStyle.Bold)
        SiticoneButton_link_options_parameter.BadgeValue = 0
        SiticoneButton_link_options_parameter.BadgeValueForeColor = Color.White
        SiticoneButton_link_options_parameter.BorderColor = Color.Gray
        SiticoneButton_link_options_parameter.BorderWidth = 2
        SiticoneButton_link_options_parameter.ButtonBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        SiticoneButton_link_options_parameter.ButtonImage = My.Resources.Resource_pic.help_16
        SiticoneButton_link_options_parameter.ButtonTextLeftPadding = 0
        SiticoneButton_link_options_parameter.CanBeep = True
        SiticoneButton_link_options_parameter.CanGlow = False
        SiticoneButton_link_options_parameter.CanShake = True
        SiticoneButton_link_options_parameter.ContextMenuStripEx = Nothing
        SiticoneButton_link_options_parameter.CornerRadiusBottomLeft = 8
        SiticoneButton_link_options_parameter.CornerRadiusBottomRight = 8
        SiticoneButton_link_options_parameter.CornerRadiusTopLeft = 8
        SiticoneButton_link_options_parameter.CornerRadiusTopRight = 8
        SiticoneButton_link_options_parameter.CustomCursor = Cursors.Default
        SiticoneButton_link_options_parameter.DisabledTextColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        SiticoneButton_link_options_parameter.EnableLongPress = False
        SiticoneButton_link_options_parameter.EnablePressAnimation = True
        SiticoneButton_link_options_parameter.EnableRippleEffect = True
        SiticoneButton_link_options_parameter.EnableShadow = False
        SiticoneButton_link_options_parameter.EnableTextWrapping = False
        SiticoneButton_link_options_parameter.Font = New Font("Segoe UI", 9F)
        SiticoneButton_link_options_parameter.GlowColor = Color.FromArgb(CByte(100), CByte(255), CByte(255), CByte(255))
        SiticoneButton_link_options_parameter.GlowIntensity = 100
        SiticoneButton_link_options_parameter.GlowRadius = 20F
        SiticoneButton_link_options_parameter.GradientBackground = False
        SiticoneButton_link_options_parameter.GradientColor = Color.Gray
        SiticoneButton_link_options_parameter.GradientMode = Drawing2D.LinearGradientMode.Vertical
        SiticoneButton_link_options_parameter.HintText = Nothing
        SiticoneButton_link_options_parameter.HoverBackColor = Color.Silver
        SiticoneButton_link_options_parameter.HoverFontStyle = FontStyle.Regular
        SiticoneButton_link_options_parameter.HoverTextColor = Color.White
        SiticoneButton_link_options_parameter.HoverTransitionDuration = 250
        SiticoneButton_link_options_parameter.ImageAlign = ContentAlignment.MiddleCenter
        SiticoneButton_link_options_parameter.ImagePadding = 5
        SiticoneButton_link_options_parameter.ImageSize = New Size(16, 16)
        SiticoneButton_link_options_parameter.IsRadial = False
        SiticoneButton_link_options_parameter.IsReadOnly = False
        SiticoneButton_link_options_parameter.IsToggleButton = False
        SiticoneButton_link_options_parameter.IsToggled = False
        SiticoneButton_link_options_parameter.Location = New Point(8, 339)
        SiticoneButton_link_options_parameter.LongPressDurationMS = 1000
        SiticoneButton_link_options_parameter.Name = "SiticoneButton_link_options_parameter"
        SiticoneButton_link_options_parameter.NormalFontStyle = FontStyle.Regular
        SiticoneButton_link_options_parameter.ParticleColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        SiticoneButton_link_options_parameter.ParticleCount = 15
        SiticoneButton_link_options_parameter.PressAnimationScale = 0.97F
        SiticoneButton_link_options_parameter.PressedBackColor = Color.FromArgb(CByte(74), CByte(128), CByte(235))
        SiticoneButton_link_options_parameter.PressedFontStyle = FontStyle.Regular
        SiticoneButton_link_options_parameter.PressTransitionDuration = 150
        SiticoneButton_link_options_parameter.ReadOnlyTextColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        SiticoneButton_link_options_parameter.RippleColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        SiticoneButton_link_options_parameter.RippleOpacity = 0.3F
        SiticoneButton_link_options_parameter.RippleRadiusMultiplier = 0.6F
        SiticoneButton_link_options_parameter.ShadowBlur = 5
        SiticoneButton_link_options_parameter.ShadowColor = Color.FromArgb(CByte(100), CByte(0), CByte(0), CByte(0))
        SiticoneButton_link_options_parameter.ShadowOffset = New Point(2, 2)
        SiticoneButton_link_options_parameter.ShakeDuration = 500
        SiticoneButton_link_options_parameter.ShakeIntensity = 5
        SiticoneButton_link_options_parameter.Size = New Size(30, 24)
        SiticoneButton_link_options_parameter.TabIndex = 45
        SiticoneButton_link_options_parameter.TextAlign = ContentAlignment.MiddleCenter
        SiticoneButton_link_options_parameter.TextColor = Color.White
        ToolTip1.SetToolTip(SiticoneButton_link_options_parameter, "Help")
        SiticoneButton_link_options_parameter.TooltipText = Nothing
        SiticoneButton_link_options_parameter.UseAdvancedRendering = True
        SiticoneButton_link_options_parameter.UseParticles = False
        ' 
        ' SiticoneLabel6
        ' 
        SiticoneLabel6.BackColor = Color.Transparent
        SiticoneLabel6.Font = New Font("Segoe UI", 10F)
        SiticoneLabel6.Location = New Point(44, 108)
        SiticoneLabel6.Name = "SiticoneLabel6"
        SiticoneLabel6.Size = New Size(116, 21)
        SiticoneLabel6.TabIndex = 38
        SiticoneLabel6.Text = "Output Format:"
        ' 
        ' SiticoneButton_load_parameter
        ' 
        SiticoneButton_load_parameter.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard"
        SiticoneButton_load_parameter.AccessibleName = "Load Parameter"
        SiticoneButton_load_parameter.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        SiticoneButton_load_parameter.AutoSizeBasedOnText = False
        SiticoneButton_load_parameter.BackColor = Color.Transparent
        SiticoneButton_load_parameter.BadgeBackColor = Color.Red
        SiticoneButton_load_parameter.BadgeFont = New Font("Segoe UI", 8F, FontStyle.Bold)
        SiticoneButton_load_parameter.BadgeValue = 0
        SiticoneButton_load_parameter.BadgeValueForeColor = Color.White
        SiticoneButton_load_parameter.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        SiticoneButton_load_parameter.BorderWidth = 2
        SiticoneButton_load_parameter.ButtonBackColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        SiticoneButton_load_parameter.ButtonImage = Nothing
        SiticoneButton_load_parameter.ButtonTextLeftPadding = 0
        SiticoneButton_load_parameter.CanBeep = True
        SiticoneButton_load_parameter.CanGlow = False
        SiticoneButton_load_parameter.CanShake = True
        SiticoneButton_load_parameter.ContextMenuStripEx = Nothing
        SiticoneButton_load_parameter.CornerRadiusBottomLeft = 8
        SiticoneButton_load_parameter.CornerRadiusBottomRight = 8
        SiticoneButton_load_parameter.CornerRadiusTopLeft = 8
        SiticoneButton_load_parameter.CornerRadiusTopRight = 8
        SiticoneButton_load_parameter.CustomCursor = Cursors.Default
        SiticoneButton_load_parameter.DisabledTextColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        SiticoneButton_load_parameter.EnableLongPress = False
        SiticoneButton_load_parameter.EnablePressAnimation = True
        SiticoneButton_load_parameter.EnableRippleEffect = True
        SiticoneButton_load_parameter.EnableShadow = False
        SiticoneButton_load_parameter.EnableTextWrapping = False
        SiticoneButton_load_parameter.Font = New Font("Segoe UI", 9F)
        SiticoneButton_load_parameter.GlowColor = Color.FromArgb(CByte(100), CByte(255), CByte(255), CByte(255))
        SiticoneButton_load_parameter.GlowIntensity = 100
        SiticoneButton_load_parameter.GlowRadius = 20F
        SiticoneButton_load_parameter.GradientBackground = False
        SiticoneButton_load_parameter.GradientColor = Color.FromArgb(CByte(114), CByte(168), CByte(255))
        SiticoneButton_load_parameter.GradientMode = Drawing2D.LinearGradientMode.Vertical
        SiticoneButton_load_parameter.HintText = Nothing
        SiticoneButton_load_parameter.HoverBackColor = Color.FromArgb(CByte(114), CByte(168), CByte(255))
        SiticoneButton_load_parameter.HoverFontStyle = FontStyle.Regular
        SiticoneButton_load_parameter.HoverTextColor = Color.White
        SiticoneButton_load_parameter.HoverTransitionDuration = 250
        SiticoneButton_load_parameter.ImageAlign = ContentAlignment.MiddleLeft
        SiticoneButton_load_parameter.ImagePadding = 5
        SiticoneButton_load_parameter.ImageSize = New Size(16, 16)
        SiticoneButton_load_parameter.IsRadial = False
        SiticoneButton_load_parameter.IsReadOnly = False
        SiticoneButton_load_parameter.IsToggleButton = False
        SiticoneButton_load_parameter.IsToggled = False
        SiticoneButton_load_parameter.Location = New Point(1182, 600)
        SiticoneButton_load_parameter.LongPressDurationMS = 1000
        SiticoneButton_load_parameter.Name = "SiticoneButton_load_parameter"
        SiticoneButton_load_parameter.NormalFontStyle = FontStyle.Regular
        SiticoneButton_load_parameter.ParticleColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        SiticoneButton_load_parameter.ParticleCount = 15
        SiticoneButton_load_parameter.PressAnimationScale = 0.97F
        SiticoneButton_load_parameter.PressedBackColor = Color.FromArgb(CByte(74), CByte(128), CByte(235))
        SiticoneButton_load_parameter.PressedFontStyle = FontStyle.Regular
        SiticoneButton_load_parameter.PressTransitionDuration = 150
        SiticoneButton_load_parameter.ReadOnlyTextColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        SiticoneButton_load_parameter.RippleColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        SiticoneButton_load_parameter.RippleOpacity = 0.3F
        SiticoneButton_load_parameter.RippleRadiusMultiplier = 0.6F
        SiticoneButton_load_parameter.ShadowBlur = 5
        SiticoneButton_load_parameter.ShadowColor = Color.FromArgb(CByte(100), CByte(0), CByte(0), CByte(0))
        SiticoneButton_load_parameter.ShadowOffset = New Point(2, 2)
        SiticoneButton_load_parameter.ShakeDuration = 500
        SiticoneButton_load_parameter.ShakeIntensity = 5
        SiticoneButton_load_parameter.Size = New Size(107, 24)
        SiticoneButton_load_parameter.TabIndex = 35
        SiticoneButton_load_parameter.Text = "Load Parameter"
        SiticoneButton_load_parameter.TextAlign = ContentAlignment.MiddleCenter
        SiticoneButton_load_parameter.TextColor = Color.White
        SiticoneButton_load_parameter.TooltipText = Nothing
        SiticoneButton_load_parameter.UseAdvancedRendering = True
        SiticoneButton_load_parameter.UseParticles = False
        ' 
        ' SiticoneButton_save_parameter
        ' 
        SiticoneButton_save_parameter.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard"
        SiticoneButton_save_parameter.AccessibleName = "Save Parameter"
        SiticoneButton_save_parameter.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        SiticoneButton_save_parameter.AutoSizeBasedOnText = False
        SiticoneButton_save_parameter.BackColor = Color.Transparent
        SiticoneButton_save_parameter.BadgeBackColor = Color.Red
        SiticoneButton_save_parameter.BadgeFont = New Font("Segoe UI", 8F, FontStyle.Bold)
        SiticoneButton_save_parameter.BadgeValue = 0
        SiticoneButton_save_parameter.BadgeValueForeColor = Color.White
        SiticoneButton_save_parameter.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        SiticoneButton_save_parameter.BorderWidth = 2
        SiticoneButton_save_parameter.ButtonBackColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        SiticoneButton_save_parameter.ButtonImage = Nothing
        SiticoneButton_save_parameter.ButtonTextLeftPadding = 0
        SiticoneButton_save_parameter.CanBeep = True
        SiticoneButton_save_parameter.CanGlow = False
        SiticoneButton_save_parameter.CanShake = True
        SiticoneButton_save_parameter.ContextMenuStripEx = Nothing
        SiticoneButton_save_parameter.CornerRadiusBottomLeft = 8
        SiticoneButton_save_parameter.CornerRadiusBottomRight = 8
        SiticoneButton_save_parameter.CornerRadiusTopLeft = 8
        SiticoneButton_save_parameter.CornerRadiusTopRight = 8
        SiticoneButton_save_parameter.CustomCursor = Cursors.Default
        SiticoneButton_save_parameter.DisabledTextColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        SiticoneButton_save_parameter.EnableLongPress = False
        SiticoneButton_save_parameter.EnablePressAnimation = True
        SiticoneButton_save_parameter.EnableRippleEffect = True
        SiticoneButton_save_parameter.EnableShadow = False
        SiticoneButton_save_parameter.EnableTextWrapping = False
        SiticoneButton_save_parameter.Font = New Font("Segoe UI", 9F)
        SiticoneButton_save_parameter.GlowColor = Color.FromArgb(CByte(100), CByte(255), CByte(255), CByte(255))
        SiticoneButton_save_parameter.GlowIntensity = 100
        SiticoneButton_save_parameter.GlowRadius = 20F
        SiticoneButton_save_parameter.GradientBackground = False
        SiticoneButton_save_parameter.GradientColor = Color.FromArgb(CByte(114), CByte(168), CByte(255))
        SiticoneButton_save_parameter.GradientMode = Drawing2D.LinearGradientMode.Vertical
        SiticoneButton_save_parameter.HintText = Nothing
        SiticoneButton_save_parameter.HoverBackColor = Color.FromArgb(CByte(114), CByte(168), CByte(255))
        SiticoneButton_save_parameter.HoverFontStyle = FontStyle.Regular
        SiticoneButton_save_parameter.HoverTextColor = Color.White
        SiticoneButton_save_parameter.HoverTransitionDuration = 250
        SiticoneButton_save_parameter.ImageAlign = ContentAlignment.MiddleLeft
        SiticoneButton_save_parameter.ImagePadding = 5
        SiticoneButton_save_parameter.ImageSize = New Size(16, 16)
        SiticoneButton_save_parameter.IsRadial = False
        SiticoneButton_save_parameter.IsReadOnly = False
        SiticoneButton_save_parameter.IsToggleButton = False
        SiticoneButton_save_parameter.IsToggled = False
        SiticoneButton_save_parameter.Location = New Point(1295, 600)
        SiticoneButton_save_parameter.LongPressDurationMS = 1000
        SiticoneButton_save_parameter.Name = "SiticoneButton_save_parameter"
        SiticoneButton_save_parameter.NormalFontStyle = FontStyle.Regular
        SiticoneButton_save_parameter.ParticleColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        SiticoneButton_save_parameter.ParticleCount = 15
        SiticoneButton_save_parameter.PressAnimationScale = 0.97F
        SiticoneButton_save_parameter.PressedBackColor = Color.FromArgb(CByte(74), CByte(128), CByte(235))
        SiticoneButton_save_parameter.PressedFontStyle = FontStyle.Regular
        SiticoneButton_save_parameter.PressTransitionDuration = 150
        SiticoneButton_save_parameter.ReadOnlyTextColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        SiticoneButton_save_parameter.RippleColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        SiticoneButton_save_parameter.RippleOpacity = 0.3F
        SiticoneButton_save_parameter.RippleRadiusMultiplier = 0.6F
        SiticoneButton_save_parameter.ShadowBlur = 5
        SiticoneButton_save_parameter.ShadowColor = Color.FromArgb(CByte(100), CByte(0), CByte(0), CByte(0))
        SiticoneButton_save_parameter.ShadowOffset = New Point(2, 2)
        SiticoneButton_save_parameter.ShakeDuration = 500
        SiticoneButton_save_parameter.ShakeIntensity = 5
        SiticoneButton_save_parameter.Size = New Size(107, 24)
        SiticoneButton_save_parameter.TabIndex = 34
        SiticoneButton_save_parameter.Text = "Save Parameter"
        SiticoneButton_save_parameter.TextAlign = ContentAlignment.MiddleCenter
        SiticoneButton_save_parameter.TextColor = Color.White
        SiticoneButton_save_parameter.TooltipText = Nothing
        SiticoneButton_save_parameter.UseAdvancedRendering = True
        SiticoneButton_save_parameter.UseParticles = False
        ' 
        ' SiticoneLabel1
        ' 
        SiticoneLabel1.BackColor = Color.Transparent
        SiticoneLabel1.Font = New Font("Segoe UI", 10F)
        SiticoneLabel1.Location = New Point(44, 342)
        SiticoneLabel1.Name = "SiticoneLabel1"
        SiticoneLabel1.Size = New Size(129, 21)
        SiticoneLabel1.TabIndex = 33
        SiticoneLabel1.Text = "Options Parameter:"
        ' 
        ' dgv_option
        ' 
        dgv_option.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgv_option.BackgroundColor = Color.White
        dgv_option.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_option.Location = New Point(8, 364)
        dgv_option.Name = "dgv_option"
        dgv_option.Size = New Size(1391, 131)
        dgv_option.TabIndex = 32
        ' 
        ' SiticoneLabel4
        ' 
        SiticoneLabel4.BackColor = Color.Transparent
        SiticoneLabel4.Font = New Font("Segoe UI", 10F)
        SiticoneLabel4.Location = New Point(44, 9)
        SiticoneLabel4.Name = "SiticoneLabel4"
        SiticoneLabel4.Size = New Size(116, 21)
        SiticoneLabel4.TabIndex = 30
        SiticoneLabel4.Text = "System Prompt:"
        ' 
        ' SiticoneTextArea_system
        ' 
        SiticoneTextArea_system.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        SiticoneTextArea_system.BackColor = SystemColors.GradientInactiveCaption
        SiticoneTextArea_system.BorderStyle = BorderStyle.None
        SiticoneTextArea_system.Font = New Font("Century Gothic", 10F)
        SiticoneTextArea_system.Location = New Point(8, 32)
        SiticoneTextArea_system.Margin = New Padding(5)
        SiticoneTextArea_system.MinimumSize = New Size(100, 65)
        SiticoneTextArea_system.Multiline = True
        SiticoneTextArea_system.Name = "SiticoneTextArea_system"
        SiticoneTextArea_system.PlaceholderText = "Write Systemprompt here..."
        SiticoneTextArea_system.ScrollBars = ScrollBars.Vertical
        SiticoneTextArea_system.Size = New Size(1391, 65)
        SiticoneTextArea_system.TabIndex = 25
        ' 
        ' TabPage_tool
        ' 
        TabPage_tool.BackColor = Color.WhiteSmoke
        TabPage_tool.Controls.Add(SiticoneFlatPanel_tools)
        TabPage_tool.Controls.Add(Scintilla_Tools_pythoncode)
        TabPage_tool.Controls.Add(Scintilla_Tools_Json)
        TabPage_tool.Controls.Add(SiticoneButton_link_tool_python_code)
        TabPage_tool.Controls.Add(SiticoneButton_link_tool_json)
        TabPage_tool.Controls.Add(SiticoneButton_link_tool_system_prompt)
        TabPage_tool.Controls.Add(SiticoneLabel10)
        TabPage_tool.Controls.Add(SiticoneButton_resp_clp)
        TabPage_tool.Controls.Add(SiticoneButton_load_tools)
        TabPage_tool.Controls.Add(SiticoneButton_save_tools)
        TabPage_tool.Controls.Add(SiticoneTextBox_request_answer)
        TabPage_tool.Controls.Add(SiticoneTextArea_Tools_system)
        TabPage_tool.Controls.Add(SiticoneLabel9)
        TabPage_tool.Controls.Add(SiticoneLabel8)
        TabPage_tool.Controls.Add(SiticoneLabel7)
        TabPage_tool.Location = New Point(4, 54)
        TabPage_tool.Name = "TabPage_tool"
        TabPage_tool.Padding = New Padding(3)
        TabPage_tool.Size = New Size(1407, 630)
        SiticoneTabControl_tab.SetTabImage(TabPage_tool, My.Resources.Resource_svg.Tools)
        TabPage_tool.TabIndex = 8
        TabPage_tool.Text = "Tools"
        ' 
        ' SiticoneFlatPanel_tools
        ' 
        SiticoneFlatPanel_tools.BackColor = Color.Transparent
        SiticoneFlatPanel_tools.Controls.Add(SiticoneLabel_tools)
        SiticoneFlatPanel_tools.Controls.Add(SiticoneToggleSwitch_tools)
        SiticoneFlatPanel_tools.Location = New Point(232, 6)
        SiticoneFlatPanel_tools.MinimumSize = New Size(20, 20)
        SiticoneFlatPanel_tools.Name = "SiticoneFlatPanel_tools"
        SiticoneFlatPanel_tools.Size = New Size(120, 25)
        SiticoneFlatPanel_tools.TabIndex = 59
        ' 
        ' SiticoneLabel_tools
        ' 
        SiticoneLabel_tools.BackColor = Color.Transparent
        SiticoneLabel_tools.Dock = DockStyle.Right
        SiticoneLabel_tools.Font = New Font("Segoe UI", 10F)
        SiticoneLabel_tools.Location = New Point(56, 0)
        SiticoneLabel_tools.Name = "SiticoneLabel_tools"
        SiticoneLabel_tools.Size = New Size(64, 25)
        SiticoneLabel_tools.TabIndex = 55
        SiticoneLabel_tools.Text = "Use Tool"
        SiticoneLabel_tools.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' SiticoneToggleSwitch_tools
        ' 
        SiticoneToggleSwitch_tools.AccessibleDescription = "A customizable toggle switch that can be turned on or off."
        SiticoneToggleSwitch_tools.AccessibleName = "Siticone Toggle Switch"
        SiticoneToggleSwitch_tools.AccessibleRole = AccessibleRole.CheckButton
        SiticoneToggleSwitch_tools.CanBeep = True
        SiticoneToggleSwitch_tools.CanShake = True
        SiticoneToggleSwitch_tools.DisabledColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        SiticoneToggleSwitch_tools.DisallowToggling = False
        SiticoneToggleSwitch_tools.Dock = DockStyle.Left
        SiticoneToggleSwitch_tools.EnableGlowEffect = True
        SiticoneToggleSwitch_tools.ExtraThumbSize = 2
        SiticoneToggleSwitch_tools.IsOn = False
        SiticoneToggleSwitch_tools.IsReadOnly = False
        SiticoneToggleSwitch_tools.IsRequired = False
        SiticoneToggleSwitch_tools.LabelColor = Color.Black
        SiticoneToggleSwitch_tools.LabelFont = New Font("Segoe UI", 9F)
        SiticoneToggleSwitch_tools.Location = New Point(0, 0)
        SiticoneToggleSwitch_tools.Logger = Nothing
        SiticoneToggleSwitch_tools.Name = "SiticoneToggleSwitch_tools"
        SiticoneToggleSwitch_tools.OffBackColor1 = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        SiticoneToggleSwitch_tools.OffBackColor2 = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        SiticoneToggleSwitch_tools.OffBorderColor1 = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        SiticoneToggleSwitch_tools.OffBorderColor2 = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        SiticoneToggleSwitch_tools.OffIcon = Nothing
        SiticoneToggleSwitch_tools.OffThumbColor1 = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        SiticoneToggleSwitch_tools.OffThumbColor2 = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        SiticoneToggleSwitch_tools.OnBackColor1 = Color.FromArgb(CByte(26), CByte(115), CByte(232))
        SiticoneToggleSwitch_tools.OnBackColor2 = Color.FromArgb(CByte(26), CByte(115), CByte(232))
        SiticoneToggleSwitch_tools.OnBorderColor1 = Color.FromArgb(CByte(26), CByte(115), CByte(232))
        SiticoneToggleSwitch_tools.OnBorderColor2 = Color.FromArgb(CByte(26), CByte(115), CByte(232))
        SiticoneToggleSwitch_tools.OnIcon = Nothing
        SiticoneToggleSwitch_tools.OnThumbColor1 = Color.White
        SiticoneToggleSwitch_tools.OnThumbColor2 = Color.White
        SiticoneToggleSwitch_tools.PreventToggleOff = False
        SiticoneToggleSwitch_tools.RippleColor = Color.FromArgb(CByte(100), CByte(255), CByte(255), CByte(255))
        SiticoneToggleSwitch_tools.RippleExpansionRate = 2F
        SiticoneToggleSwitch_tools.RippleOpacityDecay = 0.02F
        SiticoneToggleSwitch_tools.Size = New Size(50, 25)
        SiticoneToggleSwitch_tools.TabIndex = 54
        SiticoneToggleSwitch_tools.ToggleOffSoundPath = ""
        SiticoneToggleSwitch_tools.ToggleOnSoundPath = ""
        SiticoneToggleSwitch_tools.ToolTipText = ""
        SiticoneToggleSwitch_tools.TrackDeviceTheme = True
        ' 
        ' Scintilla_Tools_pythoncode
        ' 
        Scintilla_Tools_pythoncode._ScintillaManagedDragDrop = True
        Scintilla_Tools_pythoncode.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Scintilla_Tools_pythoncode.AutocompleteListSelectedBackColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        Scintilla_Tools_pythoncode.Font = New Font("Consolas", 10F)
        Scintilla_Tools_pythoncode.LexerName = "python"
        Scintilla_Tools_pythoncode.Location = New Point(6, 445)
        Scintilla_Tools_pythoncode.Name = "Scintilla_Tools_pythoncode"
        Scintilla_Tools_pythoncode.ScrollWidth = 70
        Scintilla_Tools_pythoncode.Size = New Size(1393, 149)
        Scintilla_Tools_pythoncode.TabIndex = 58
        ' 
        ' Scintilla_Tools_Json
        ' 
        Scintilla_Tools_Json.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Scintilla_Tools_Json.AutocompleteListSelectedBackColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        Scintilla_Tools_Json.Font = New Font("Consolas", 10F)
        Scintilla_Tools_Json.LexerName = "json"
        Scintilla_Tools_Json.Location = New Point(8, 130)
        Scintilla_Tools_Json.Name = "Scintilla_Tools_Json"
        Scintilla_Tools_Json.ScrollWidth = 70
        Scintilla_Tools_Json.Size = New Size(1391, 284)
        Scintilla_Tools_Json.TabIndex = 57
        ' 
        ' SiticoneButton_link_tool_python_code
        ' 
        SiticoneButton_link_tool_python_code.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard"
        SiticoneButton_link_tool_python_code.AccessibleName = ""
        SiticoneButton_link_tool_python_code.AutoSizeBasedOnText = False
        SiticoneButton_link_tool_python_code.BackColor = Color.Transparent
        SiticoneButton_link_tool_python_code.BadgeBackColor = Color.Red
        SiticoneButton_link_tool_python_code.BadgeFont = New Font("Segoe UI", 8F, FontStyle.Bold)
        SiticoneButton_link_tool_python_code.BadgeValue = 0
        SiticoneButton_link_tool_python_code.BadgeValueForeColor = Color.White
        SiticoneButton_link_tool_python_code.BorderColor = Color.Gray
        SiticoneButton_link_tool_python_code.BorderWidth = 2
        SiticoneButton_link_tool_python_code.ButtonBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        SiticoneButton_link_tool_python_code.ButtonImage = My.Resources.Resource_pic.help_16
        SiticoneButton_link_tool_python_code.ButtonTextLeftPadding = 0
        SiticoneButton_link_tool_python_code.CanBeep = True
        SiticoneButton_link_tool_python_code.CanGlow = False
        SiticoneButton_link_tool_python_code.CanShake = True
        SiticoneButton_link_tool_python_code.ContextMenuStripEx = Nothing
        SiticoneButton_link_tool_python_code.CornerRadiusBottomLeft = 8
        SiticoneButton_link_tool_python_code.CornerRadiusBottomRight = 8
        SiticoneButton_link_tool_python_code.CornerRadiusTopLeft = 8
        SiticoneButton_link_tool_python_code.CornerRadiusTopRight = 8
        SiticoneButton_link_tool_python_code.CustomCursor = Cursors.Default
        SiticoneButton_link_tool_python_code.DisabledTextColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        SiticoneButton_link_tool_python_code.EnableLongPress = False
        SiticoneButton_link_tool_python_code.EnablePressAnimation = True
        SiticoneButton_link_tool_python_code.EnableRippleEffect = True
        SiticoneButton_link_tool_python_code.EnableShadow = False
        SiticoneButton_link_tool_python_code.EnableTextWrapping = False
        SiticoneButton_link_tool_python_code.Font = New Font("Segoe UI", 9F)
        SiticoneButton_link_tool_python_code.GlowColor = Color.FromArgb(CByte(100), CByte(255), CByte(255), CByte(255))
        SiticoneButton_link_tool_python_code.GlowIntensity = 100
        SiticoneButton_link_tool_python_code.GlowRadius = 20F
        SiticoneButton_link_tool_python_code.GradientBackground = False
        SiticoneButton_link_tool_python_code.GradientColor = Color.Gray
        SiticoneButton_link_tool_python_code.GradientMode = Drawing2D.LinearGradientMode.Vertical
        SiticoneButton_link_tool_python_code.HintText = Nothing
        SiticoneButton_link_tool_python_code.HoverBackColor = Color.Silver
        SiticoneButton_link_tool_python_code.HoverFontStyle = FontStyle.Regular
        SiticoneButton_link_tool_python_code.HoverTextColor = Color.White
        SiticoneButton_link_tool_python_code.HoverTransitionDuration = 250
        SiticoneButton_link_tool_python_code.ImageAlign = ContentAlignment.MiddleCenter
        SiticoneButton_link_tool_python_code.ImagePadding = 5
        SiticoneButton_link_tool_python_code.ImageSize = New Size(16, 16)
        SiticoneButton_link_tool_python_code.IsRadial = False
        SiticoneButton_link_tool_python_code.IsReadOnly = False
        SiticoneButton_link_tool_python_code.IsToggleButton = False
        SiticoneButton_link_tool_python_code.IsToggled = False
        SiticoneButton_link_tool_python_code.Location = New Point(8, 420)
        SiticoneButton_link_tool_python_code.LongPressDurationMS = 1000
        SiticoneButton_link_tool_python_code.Name = "SiticoneButton_link_tool_python_code"
        SiticoneButton_link_tool_python_code.NormalFontStyle = FontStyle.Regular
        SiticoneButton_link_tool_python_code.ParticleColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        SiticoneButton_link_tool_python_code.ParticleCount = 15
        SiticoneButton_link_tool_python_code.PressAnimationScale = 0.97F
        SiticoneButton_link_tool_python_code.PressedBackColor = Color.FromArgb(CByte(74), CByte(128), CByte(235))
        SiticoneButton_link_tool_python_code.PressedFontStyle = FontStyle.Regular
        SiticoneButton_link_tool_python_code.PressTransitionDuration = 150
        SiticoneButton_link_tool_python_code.ReadOnlyTextColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        SiticoneButton_link_tool_python_code.RippleColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        SiticoneButton_link_tool_python_code.RippleOpacity = 0.3F
        SiticoneButton_link_tool_python_code.RippleRadiusMultiplier = 0.6F
        SiticoneButton_link_tool_python_code.ShadowBlur = 5
        SiticoneButton_link_tool_python_code.ShadowColor = Color.FromArgb(CByte(100), CByte(0), CByte(0), CByte(0))
        SiticoneButton_link_tool_python_code.ShadowOffset = New Point(2, 2)
        SiticoneButton_link_tool_python_code.ShakeDuration = 500
        SiticoneButton_link_tool_python_code.ShakeIntensity = 5
        SiticoneButton_link_tool_python_code.Size = New Size(30, 24)
        SiticoneButton_link_tool_python_code.TabIndex = 56
        SiticoneButton_link_tool_python_code.TextAlign = ContentAlignment.MiddleCenter
        SiticoneButton_link_tool_python_code.TextColor = Color.White
        ToolTip1.SetToolTip(SiticoneButton_link_tool_python_code, "Help")
        SiticoneButton_link_tool_python_code.TooltipText = Nothing
        SiticoneButton_link_tool_python_code.UseAdvancedRendering = True
        SiticoneButton_link_tool_python_code.UseParticles = False
        ' 
        ' SiticoneButton_link_tool_json
        ' 
        SiticoneButton_link_tool_json.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard"
        SiticoneButton_link_tool_json.AccessibleName = ""
        SiticoneButton_link_tool_json.AutoSizeBasedOnText = False
        SiticoneButton_link_tool_json.BackColor = Color.Transparent
        SiticoneButton_link_tool_json.BadgeBackColor = Color.Red
        SiticoneButton_link_tool_json.BadgeFont = New Font("Segoe UI", 8F, FontStyle.Bold)
        SiticoneButton_link_tool_json.BadgeValue = 0
        SiticoneButton_link_tool_json.BadgeValueForeColor = Color.White
        SiticoneButton_link_tool_json.BorderColor = Color.Gray
        SiticoneButton_link_tool_json.BorderWidth = 2
        SiticoneButton_link_tool_json.ButtonBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        SiticoneButton_link_tool_json.ButtonImage = My.Resources.Resource_pic.help_16
        SiticoneButton_link_tool_json.ButtonTextLeftPadding = 0
        SiticoneButton_link_tool_json.CanBeep = True
        SiticoneButton_link_tool_json.CanGlow = False
        SiticoneButton_link_tool_json.CanShake = True
        SiticoneButton_link_tool_json.ContextMenuStripEx = Nothing
        SiticoneButton_link_tool_json.CornerRadiusBottomLeft = 8
        SiticoneButton_link_tool_json.CornerRadiusBottomRight = 8
        SiticoneButton_link_tool_json.CornerRadiusTopLeft = 8
        SiticoneButton_link_tool_json.CornerRadiusTopRight = 8
        SiticoneButton_link_tool_json.CustomCursor = Cursors.Default
        SiticoneButton_link_tool_json.DisabledTextColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        SiticoneButton_link_tool_json.EnableLongPress = False
        SiticoneButton_link_tool_json.EnablePressAnimation = True
        SiticoneButton_link_tool_json.EnableRippleEffect = True
        SiticoneButton_link_tool_json.EnableShadow = False
        SiticoneButton_link_tool_json.EnableTextWrapping = False
        SiticoneButton_link_tool_json.Font = New Font("Segoe UI", 9F)
        SiticoneButton_link_tool_json.GlowColor = Color.FromArgb(CByte(100), CByte(255), CByte(255), CByte(255))
        SiticoneButton_link_tool_json.GlowIntensity = 100
        SiticoneButton_link_tool_json.GlowRadius = 20F
        SiticoneButton_link_tool_json.GradientBackground = False
        SiticoneButton_link_tool_json.GradientColor = Color.Gray
        SiticoneButton_link_tool_json.GradientMode = Drawing2D.LinearGradientMode.Vertical
        SiticoneButton_link_tool_json.HintText = Nothing
        SiticoneButton_link_tool_json.HoverBackColor = Color.Silver
        SiticoneButton_link_tool_json.HoverFontStyle = FontStyle.Regular
        SiticoneButton_link_tool_json.HoverTextColor = Color.White
        SiticoneButton_link_tool_json.HoverTransitionDuration = 250
        SiticoneButton_link_tool_json.ImageAlign = ContentAlignment.MiddleCenter
        SiticoneButton_link_tool_json.ImagePadding = 5
        SiticoneButton_link_tool_json.ImageSize = New Size(16, 16)
        SiticoneButton_link_tool_json.IsRadial = False
        SiticoneButton_link_tool_json.IsReadOnly = False
        SiticoneButton_link_tool_json.IsToggleButton = False
        SiticoneButton_link_tool_json.IsToggled = False
        SiticoneButton_link_tool_json.Location = New Point(8, 105)
        SiticoneButton_link_tool_json.LongPressDurationMS = 1000
        SiticoneButton_link_tool_json.Name = "SiticoneButton_link_tool_json"
        SiticoneButton_link_tool_json.NormalFontStyle = FontStyle.Regular
        SiticoneButton_link_tool_json.ParticleColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        SiticoneButton_link_tool_json.ParticleCount = 15
        SiticoneButton_link_tool_json.PressAnimationScale = 0.97F
        SiticoneButton_link_tool_json.PressedBackColor = Color.FromArgb(CByte(74), CByte(128), CByte(235))
        SiticoneButton_link_tool_json.PressedFontStyle = FontStyle.Regular
        SiticoneButton_link_tool_json.PressTransitionDuration = 150
        SiticoneButton_link_tool_json.ReadOnlyTextColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        SiticoneButton_link_tool_json.RippleColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        SiticoneButton_link_tool_json.RippleOpacity = 0.3F
        SiticoneButton_link_tool_json.RippleRadiusMultiplier = 0.6F
        SiticoneButton_link_tool_json.ShadowBlur = 5
        SiticoneButton_link_tool_json.ShadowColor = Color.FromArgb(CByte(100), CByte(0), CByte(0), CByte(0))
        SiticoneButton_link_tool_json.ShadowOffset = New Point(2, 2)
        SiticoneButton_link_tool_json.ShakeDuration = 500
        SiticoneButton_link_tool_json.ShakeIntensity = 5
        SiticoneButton_link_tool_json.Size = New Size(30, 24)
        SiticoneButton_link_tool_json.TabIndex = 55
        SiticoneButton_link_tool_json.TextAlign = ContentAlignment.MiddleCenter
        SiticoneButton_link_tool_json.TextColor = Color.White
        ToolTip1.SetToolTip(SiticoneButton_link_tool_json, "Help")
        SiticoneButton_link_tool_json.TooltipText = Nothing
        SiticoneButton_link_tool_json.UseAdvancedRendering = True
        SiticoneButton_link_tool_json.UseParticles = False
        ' 
        ' SiticoneButton_link_tool_system_prompt
        ' 
        SiticoneButton_link_tool_system_prompt.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard"
        SiticoneButton_link_tool_system_prompt.AccessibleName = ""
        SiticoneButton_link_tool_system_prompt.AutoSizeBasedOnText = False
        SiticoneButton_link_tool_system_prompt.BackColor = Color.Transparent
        SiticoneButton_link_tool_system_prompt.BadgeBackColor = Color.Red
        SiticoneButton_link_tool_system_prompt.BadgeFont = New Font("Segoe UI", 8F, FontStyle.Bold)
        SiticoneButton_link_tool_system_prompt.BadgeValue = 0
        SiticoneButton_link_tool_system_prompt.BadgeValueForeColor = Color.White
        SiticoneButton_link_tool_system_prompt.BorderColor = Color.Gray
        SiticoneButton_link_tool_system_prompt.BorderWidth = 2
        SiticoneButton_link_tool_system_prompt.ButtonBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        SiticoneButton_link_tool_system_prompt.ButtonImage = My.Resources.Resource_pic.help_16
        SiticoneButton_link_tool_system_prompt.ButtonTextLeftPadding = 0
        SiticoneButton_link_tool_system_prompt.CanBeep = True
        SiticoneButton_link_tool_system_prompt.CanGlow = False
        SiticoneButton_link_tool_system_prompt.CanShake = True
        SiticoneButton_link_tool_system_prompt.ContextMenuStripEx = Nothing
        SiticoneButton_link_tool_system_prompt.CornerRadiusBottomLeft = 8
        SiticoneButton_link_tool_system_prompt.CornerRadiusBottomRight = 8
        SiticoneButton_link_tool_system_prompt.CornerRadiusTopLeft = 8
        SiticoneButton_link_tool_system_prompt.CornerRadiusTopRight = 8
        SiticoneButton_link_tool_system_prompt.CustomCursor = Cursors.Default
        SiticoneButton_link_tool_system_prompt.DisabledTextColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        SiticoneButton_link_tool_system_prompt.EnableLongPress = False
        SiticoneButton_link_tool_system_prompt.EnablePressAnimation = True
        SiticoneButton_link_tool_system_prompt.EnableRippleEffect = True
        SiticoneButton_link_tool_system_prompt.EnableShadow = False
        SiticoneButton_link_tool_system_prompt.EnableTextWrapping = False
        SiticoneButton_link_tool_system_prompt.Font = New Font("Segoe UI", 9F)
        SiticoneButton_link_tool_system_prompt.GlowColor = Color.FromArgb(CByte(100), CByte(255), CByte(255), CByte(255))
        SiticoneButton_link_tool_system_prompt.GlowIntensity = 100
        SiticoneButton_link_tool_system_prompt.GlowRadius = 20F
        SiticoneButton_link_tool_system_prompt.GradientBackground = False
        SiticoneButton_link_tool_system_prompt.GradientColor = Color.Gray
        SiticoneButton_link_tool_system_prompt.GradientMode = Drawing2D.LinearGradientMode.Vertical
        SiticoneButton_link_tool_system_prompt.HintText = Nothing
        SiticoneButton_link_tool_system_prompt.HoverBackColor = Color.Silver
        SiticoneButton_link_tool_system_prompt.HoverFontStyle = FontStyle.Regular
        SiticoneButton_link_tool_system_prompt.HoverTextColor = Color.White
        SiticoneButton_link_tool_system_prompt.HoverTransitionDuration = 250
        SiticoneButton_link_tool_system_prompt.ImageAlign = ContentAlignment.MiddleCenter
        SiticoneButton_link_tool_system_prompt.ImagePadding = 5
        SiticoneButton_link_tool_system_prompt.ImageSize = New Size(16, 16)
        SiticoneButton_link_tool_system_prompt.IsRadial = False
        SiticoneButton_link_tool_system_prompt.IsReadOnly = False
        SiticoneButton_link_tool_system_prompt.IsToggleButton = False
        SiticoneButton_link_tool_system_prompt.IsToggled = False
        SiticoneButton_link_tool_system_prompt.Location = New Point(8, 6)
        SiticoneButton_link_tool_system_prompt.LongPressDurationMS = 1000
        SiticoneButton_link_tool_system_prompt.Name = "SiticoneButton_link_tool_system_prompt"
        SiticoneButton_link_tool_system_prompt.NormalFontStyle = FontStyle.Regular
        SiticoneButton_link_tool_system_prompt.ParticleColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        SiticoneButton_link_tool_system_prompt.ParticleCount = 15
        SiticoneButton_link_tool_system_prompt.PressAnimationScale = 0.97F
        SiticoneButton_link_tool_system_prompt.PressedBackColor = Color.FromArgb(CByte(74), CByte(128), CByte(235))
        SiticoneButton_link_tool_system_prompt.PressedFontStyle = FontStyle.Regular
        SiticoneButton_link_tool_system_prompt.PressTransitionDuration = 150
        SiticoneButton_link_tool_system_prompt.ReadOnlyTextColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        SiticoneButton_link_tool_system_prompt.RippleColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        SiticoneButton_link_tool_system_prompt.RippleOpacity = 0.3F
        SiticoneButton_link_tool_system_prompt.RippleRadiusMultiplier = 0.6F
        SiticoneButton_link_tool_system_prompt.ShadowBlur = 5
        SiticoneButton_link_tool_system_prompt.ShadowColor = Color.FromArgb(CByte(100), CByte(0), CByte(0), CByte(0))
        SiticoneButton_link_tool_system_prompt.ShadowOffset = New Point(2, 2)
        SiticoneButton_link_tool_system_prompt.ShakeDuration = 500
        SiticoneButton_link_tool_system_prompt.ShakeIntensity = 5
        SiticoneButton_link_tool_system_prompt.Size = New Size(30, 24)
        SiticoneButton_link_tool_system_prompt.TabIndex = 54
        SiticoneButton_link_tool_system_prompt.TextAlign = ContentAlignment.MiddleCenter
        SiticoneButton_link_tool_system_prompt.TextColor = Color.White
        ToolTip1.SetToolTip(SiticoneButton_link_tool_system_prompt, "Help")
        SiticoneButton_link_tool_system_prompt.TooltipText = Nothing
        SiticoneButton_link_tool_system_prompt.UseAdvancedRendering = True
        SiticoneButton_link_tool_system_prompt.UseParticles = False
        ' 
        ' SiticoneLabel10
        ' 
        SiticoneLabel10.BackColor = Color.Transparent
        SiticoneLabel10.Font = New Font("Segoe UI", 10F)
        SiticoneLabel10.Location = New Point(205, 423)
        SiticoneLabel10.Name = "SiticoneLabel10"
        SiticoneLabel10.Size = New Size(169, 21)
        SiticoneLabel10.TabIndex = 53
        SiticoneLabel10.Text = "Python Code Argument:"
        ' 
        ' SiticoneButton_resp_clp
        ' 
        SiticoneButton_resp_clp.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard"
        SiticoneButton_resp_clp.AccessibleName = "Tools resp > CLP"
        SiticoneButton_resp_clp.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        SiticoneButton_resp_clp.AutoSizeBasedOnText = False
        SiticoneButton_resp_clp.BackColor = Color.Transparent
        SiticoneButton_resp_clp.BadgeBackColor = Color.Red
        SiticoneButton_resp_clp.BadgeFont = New Font("Segoe UI", 8F, FontStyle.Bold)
        SiticoneButton_resp_clp.BadgeValue = 0
        SiticoneButton_resp_clp.BadgeValueForeColor = Color.White
        SiticoneButton_resp_clp.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        SiticoneButton_resp_clp.BorderWidth = 2
        SiticoneButton_resp_clp.ButtonBackColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        SiticoneButton_resp_clp.ButtonImage = Nothing
        SiticoneButton_resp_clp.ButtonTextLeftPadding = 0
        SiticoneButton_resp_clp.CanBeep = True
        SiticoneButton_resp_clp.CanGlow = False
        SiticoneButton_resp_clp.CanShake = True
        SiticoneButton_resp_clp.ContextMenuStripEx = Nothing
        SiticoneButton_resp_clp.CornerRadiusBottomLeft = 8
        SiticoneButton_resp_clp.CornerRadiusBottomRight = 8
        SiticoneButton_resp_clp.CornerRadiusTopLeft = 8
        SiticoneButton_resp_clp.CornerRadiusTopRight = 8
        SiticoneButton_resp_clp.CustomCursor = Cursors.Default
        SiticoneButton_resp_clp.DisabledTextColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        SiticoneButton_resp_clp.EnableLongPress = False
        SiticoneButton_resp_clp.EnablePressAnimation = True
        SiticoneButton_resp_clp.EnableRippleEffect = True
        SiticoneButton_resp_clp.EnableShadow = False
        SiticoneButton_resp_clp.EnableTextWrapping = False
        SiticoneButton_resp_clp.Font = New Font("Segoe UI", 9F)
        SiticoneButton_resp_clp.GlowColor = Color.FromArgb(CByte(100), CByte(255), CByte(255), CByte(255))
        SiticoneButton_resp_clp.GlowIntensity = 100
        SiticoneButton_resp_clp.GlowRadius = 20F
        SiticoneButton_resp_clp.GradientBackground = False
        SiticoneButton_resp_clp.GradientColor = Color.FromArgb(CByte(114), CByte(168), CByte(255))
        SiticoneButton_resp_clp.GradientMode = Drawing2D.LinearGradientMode.Vertical
        SiticoneButton_resp_clp.HintText = Nothing
        SiticoneButton_resp_clp.HoverBackColor = Color.FromArgb(CByte(114), CByte(168), CByte(255))
        SiticoneButton_resp_clp.HoverFontStyle = FontStyle.Regular
        SiticoneButton_resp_clp.HoverTextColor = Color.White
        SiticoneButton_resp_clp.HoverTransitionDuration = 250
        SiticoneButton_resp_clp.ImageAlign = ContentAlignment.MiddleLeft
        SiticoneButton_resp_clp.ImagePadding = 5
        SiticoneButton_resp_clp.ImageSize = New Size(16, 16)
        SiticoneButton_resp_clp.IsRadial = False
        SiticoneButton_resp_clp.IsReadOnly = False
        SiticoneButton_resp_clp.IsToggleButton = False
        SiticoneButton_resp_clp.IsToggled = False
        SiticoneButton_resp_clp.Location = New Point(8, 600)
        SiticoneButton_resp_clp.LongPressDurationMS = 1000
        SiticoneButton_resp_clp.Name = "SiticoneButton_resp_clp"
        SiticoneButton_resp_clp.NormalFontStyle = FontStyle.Regular
        SiticoneButton_resp_clp.ParticleColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        SiticoneButton_resp_clp.ParticleCount = 15
        SiticoneButton_resp_clp.PressAnimationScale = 0.97F
        SiticoneButton_resp_clp.PressedBackColor = Color.FromArgb(CByte(74), CByte(128), CByte(235))
        SiticoneButton_resp_clp.PressedFontStyle = FontStyle.Regular
        SiticoneButton_resp_clp.PressTransitionDuration = 150
        SiticoneButton_resp_clp.ReadOnlyTextColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        SiticoneButton_resp_clp.RippleColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        SiticoneButton_resp_clp.RippleOpacity = 0.3F
        SiticoneButton_resp_clp.RippleRadiusMultiplier = 0.6F
        SiticoneButton_resp_clp.ShadowBlur = 5
        SiticoneButton_resp_clp.ShadowColor = Color.FromArgb(CByte(100), CByte(0), CByte(0), CByte(0))
        SiticoneButton_resp_clp.ShadowOffset = New Point(2, 2)
        SiticoneButton_resp_clp.ShakeDuration = 500
        SiticoneButton_resp_clp.ShakeIntensity = 5
        SiticoneButton_resp_clp.Size = New Size(107, 24)
        SiticoneButton_resp_clp.TabIndex = 52
        SiticoneButton_resp_clp.Text = "Tools resp > CLP"
        SiticoneButton_resp_clp.TextAlign = ContentAlignment.MiddleCenter
        SiticoneButton_resp_clp.TextColor = Color.White
        SiticoneButton_resp_clp.TooltipText = Nothing
        SiticoneButton_resp_clp.UseAdvancedRendering = True
        SiticoneButton_resp_clp.UseParticles = False
        ' 
        ' SiticoneButton_load_tools
        ' 
        SiticoneButton_load_tools.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard"
        SiticoneButton_load_tools.AccessibleName = "Load Tools"
        SiticoneButton_load_tools.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        SiticoneButton_load_tools.AutoSizeBasedOnText = False
        SiticoneButton_load_tools.BackColor = Color.Transparent
        SiticoneButton_load_tools.BadgeBackColor = Color.Red
        SiticoneButton_load_tools.BadgeFont = New Font("Segoe UI", 8F, FontStyle.Bold)
        SiticoneButton_load_tools.BadgeValue = 0
        SiticoneButton_load_tools.BadgeValueForeColor = Color.White
        SiticoneButton_load_tools.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        SiticoneButton_load_tools.BorderWidth = 2
        SiticoneButton_load_tools.ButtonBackColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        SiticoneButton_load_tools.ButtonImage = Nothing
        SiticoneButton_load_tools.ButtonTextLeftPadding = 0
        SiticoneButton_load_tools.CanBeep = True
        SiticoneButton_load_tools.CanGlow = False
        SiticoneButton_load_tools.CanShake = True
        SiticoneButton_load_tools.ContextMenuStripEx = Nothing
        SiticoneButton_load_tools.CornerRadiusBottomLeft = 8
        SiticoneButton_load_tools.CornerRadiusBottomRight = 8
        SiticoneButton_load_tools.CornerRadiusTopLeft = 8
        SiticoneButton_load_tools.CornerRadiusTopRight = 8
        SiticoneButton_load_tools.CustomCursor = Cursors.Default
        SiticoneButton_load_tools.DisabledTextColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        SiticoneButton_load_tools.EnableLongPress = False
        SiticoneButton_load_tools.EnablePressAnimation = True
        SiticoneButton_load_tools.EnableRippleEffect = True
        SiticoneButton_load_tools.EnableShadow = False
        SiticoneButton_load_tools.EnableTextWrapping = False
        SiticoneButton_load_tools.Font = New Font("Segoe UI", 9F)
        SiticoneButton_load_tools.GlowColor = Color.FromArgb(CByte(100), CByte(255), CByte(255), CByte(255))
        SiticoneButton_load_tools.GlowIntensity = 100
        SiticoneButton_load_tools.GlowRadius = 20F
        SiticoneButton_load_tools.GradientBackground = False
        SiticoneButton_load_tools.GradientColor = Color.FromArgb(CByte(114), CByte(168), CByte(255))
        SiticoneButton_load_tools.GradientMode = Drawing2D.LinearGradientMode.Vertical
        SiticoneButton_load_tools.HintText = Nothing
        SiticoneButton_load_tools.HoverBackColor = Color.FromArgb(CByte(114), CByte(168), CByte(255))
        SiticoneButton_load_tools.HoverFontStyle = FontStyle.Regular
        SiticoneButton_load_tools.HoverTextColor = Color.White
        SiticoneButton_load_tools.HoverTransitionDuration = 250
        SiticoneButton_load_tools.ImageAlign = ContentAlignment.MiddleLeft
        SiticoneButton_load_tools.ImagePadding = 5
        SiticoneButton_load_tools.ImageSize = New Size(16, 16)
        SiticoneButton_load_tools.IsRadial = False
        SiticoneButton_load_tools.IsReadOnly = False
        SiticoneButton_load_tools.IsToggleButton = False
        SiticoneButton_load_tools.IsToggled = False
        SiticoneButton_load_tools.Location = New Point(1183, 600)
        SiticoneButton_load_tools.LongPressDurationMS = 1000
        SiticoneButton_load_tools.Name = "SiticoneButton_load_tools"
        SiticoneButton_load_tools.NormalFontStyle = FontStyle.Regular
        SiticoneButton_load_tools.ParticleColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        SiticoneButton_load_tools.ParticleCount = 15
        SiticoneButton_load_tools.PressAnimationScale = 0.97F
        SiticoneButton_load_tools.PressedBackColor = Color.FromArgb(CByte(74), CByte(128), CByte(235))
        SiticoneButton_load_tools.PressedFontStyle = FontStyle.Regular
        SiticoneButton_load_tools.PressTransitionDuration = 150
        SiticoneButton_load_tools.ReadOnlyTextColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        SiticoneButton_load_tools.RippleColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        SiticoneButton_load_tools.RippleOpacity = 0.3F
        SiticoneButton_load_tools.RippleRadiusMultiplier = 0.6F
        SiticoneButton_load_tools.ShadowBlur = 5
        SiticoneButton_load_tools.ShadowColor = Color.FromArgb(CByte(100), CByte(0), CByte(0), CByte(0))
        SiticoneButton_load_tools.ShadowOffset = New Point(2, 2)
        SiticoneButton_load_tools.ShakeDuration = 500
        SiticoneButton_load_tools.ShakeIntensity = 5
        SiticoneButton_load_tools.Size = New Size(107, 24)
        SiticoneButton_load_tools.TabIndex = 49
        SiticoneButton_load_tools.Text = "Load Tools"
        SiticoneButton_load_tools.TextAlign = ContentAlignment.MiddleCenter
        SiticoneButton_load_tools.TextColor = Color.White
        SiticoneButton_load_tools.TooltipText = Nothing
        SiticoneButton_load_tools.UseAdvancedRendering = True
        SiticoneButton_load_tools.UseParticles = False
        ' 
        ' SiticoneButton_save_tools
        ' 
        SiticoneButton_save_tools.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard"
        SiticoneButton_save_tools.AccessibleName = "Save Tools"
        SiticoneButton_save_tools.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        SiticoneButton_save_tools.AutoSizeBasedOnText = False
        SiticoneButton_save_tools.BackColor = Color.Transparent
        SiticoneButton_save_tools.BadgeBackColor = Color.Red
        SiticoneButton_save_tools.BadgeFont = New Font("Segoe UI", 8F, FontStyle.Bold)
        SiticoneButton_save_tools.BadgeValue = 0
        SiticoneButton_save_tools.BadgeValueForeColor = Color.White
        SiticoneButton_save_tools.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        SiticoneButton_save_tools.BorderWidth = 2
        SiticoneButton_save_tools.ButtonBackColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        SiticoneButton_save_tools.ButtonImage = Nothing
        SiticoneButton_save_tools.ButtonTextLeftPadding = 0
        SiticoneButton_save_tools.CanBeep = True
        SiticoneButton_save_tools.CanGlow = False
        SiticoneButton_save_tools.CanShake = True
        SiticoneButton_save_tools.ContextMenuStripEx = Nothing
        SiticoneButton_save_tools.CornerRadiusBottomLeft = 8
        SiticoneButton_save_tools.CornerRadiusBottomRight = 8
        SiticoneButton_save_tools.CornerRadiusTopLeft = 8
        SiticoneButton_save_tools.CornerRadiusTopRight = 8
        SiticoneButton_save_tools.CustomCursor = Cursors.Default
        SiticoneButton_save_tools.DisabledTextColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        SiticoneButton_save_tools.EnableLongPress = False
        SiticoneButton_save_tools.EnablePressAnimation = True
        SiticoneButton_save_tools.EnableRippleEffect = True
        SiticoneButton_save_tools.EnableShadow = False
        SiticoneButton_save_tools.EnableTextWrapping = False
        SiticoneButton_save_tools.Font = New Font("Segoe UI", 9F)
        SiticoneButton_save_tools.GlowColor = Color.FromArgb(CByte(100), CByte(255), CByte(255), CByte(255))
        SiticoneButton_save_tools.GlowIntensity = 100
        SiticoneButton_save_tools.GlowRadius = 20F
        SiticoneButton_save_tools.GradientBackground = False
        SiticoneButton_save_tools.GradientColor = Color.FromArgb(CByte(114), CByte(168), CByte(255))
        SiticoneButton_save_tools.GradientMode = Drawing2D.LinearGradientMode.Vertical
        SiticoneButton_save_tools.HintText = Nothing
        SiticoneButton_save_tools.HoverBackColor = Color.FromArgb(CByte(114), CByte(168), CByte(255))
        SiticoneButton_save_tools.HoverFontStyle = FontStyle.Regular
        SiticoneButton_save_tools.HoverTextColor = Color.White
        SiticoneButton_save_tools.HoverTransitionDuration = 250
        SiticoneButton_save_tools.ImageAlign = ContentAlignment.MiddleLeft
        SiticoneButton_save_tools.ImagePadding = 5
        SiticoneButton_save_tools.ImageSize = New Size(16, 16)
        SiticoneButton_save_tools.IsRadial = False
        SiticoneButton_save_tools.IsReadOnly = False
        SiticoneButton_save_tools.IsToggleButton = False
        SiticoneButton_save_tools.IsToggled = False
        SiticoneButton_save_tools.Location = New Point(1296, 600)
        SiticoneButton_save_tools.LongPressDurationMS = 1000
        SiticoneButton_save_tools.Name = "SiticoneButton_save_tools"
        SiticoneButton_save_tools.NormalFontStyle = FontStyle.Regular
        SiticoneButton_save_tools.ParticleColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        SiticoneButton_save_tools.ParticleCount = 15
        SiticoneButton_save_tools.PressAnimationScale = 0.97F
        SiticoneButton_save_tools.PressedBackColor = Color.FromArgb(CByte(74), CByte(128), CByte(235))
        SiticoneButton_save_tools.PressedFontStyle = FontStyle.Regular
        SiticoneButton_save_tools.PressTransitionDuration = 150
        SiticoneButton_save_tools.ReadOnlyTextColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        SiticoneButton_save_tools.RippleColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        SiticoneButton_save_tools.RippleOpacity = 0.3F
        SiticoneButton_save_tools.RippleRadiusMultiplier = 0.6F
        SiticoneButton_save_tools.ShadowBlur = 5
        SiticoneButton_save_tools.ShadowColor = Color.FromArgb(CByte(100), CByte(0), CByte(0), CByte(0))
        SiticoneButton_save_tools.ShadowOffset = New Point(2, 2)
        SiticoneButton_save_tools.ShakeDuration = 500
        SiticoneButton_save_tools.ShakeIntensity = 5
        SiticoneButton_save_tools.Size = New Size(107, 24)
        SiticoneButton_save_tools.TabIndex = 48
        SiticoneButton_save_tools.Text = "Save Tools"
        SiticoneButton_save_tools.TextAlign = ContentAlignment.MiddleCenter
        SiticoneButton_save_tools.TextColor = Color.White
        SiticoneButton_save_tools.TooltipText = Nothing
        SiticoneButton_save_tools.UseAdvancedRendering = True
        SiticoneButton_save_tools.UseParticles = False
        ' 
        ' SiticoneTextBox_request_answer
        ' 
        SiticoneTextBox_request_answer.AccessibleDescription = "A customizable text input field."
        SiticoneTextBox_request_answer.AccessibleName = "Text Box"
        SiticoneTextBox_request_answer.AccessibleRole = AccessibleRole.Text
        SiticoneTextBox_request_answer.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        SiticoneTextBox_request_answer.BackColor = Color.Transparent
        SiticoneTextBox_request_answer.BlinkCount = 3
        SiticoneTextBox_request_answer.BlinkShadow = False
        SiticoneTextBox_request_answer.BorderColor1 = Color.LightSlateGray
        SiticoneTextBox_request_answer.BorderColor2 = Color.LightSlateGray
        SiticoneTextBox_request_answer.BorderFocusColor1 = Color.FromArgb(CByte(77), CByte(77), CByte(255))
        SiticoneTextBox_request_answer.BorderFocusColor2 = Color.FromArgb(CByte(77), CByte(77), CByte(255))
        SiticoneTextBox_request_answer.CanShake = True
        SiticoneTextBox_request_answer.ContinuousBlink = False
        SiticoneTextBox_request_answer.CursorBlinkRate = 500
        SiticoneTextBox_request_answer.CursorColor = Color.Black
        SiticoneTextBox_request_answer.CursorHeight = 26
        SiticoneTextBox_request_answer.CursorOffset = 0
        SiticoneTextBox_request_answer.CursorStyle = SiticoneNetCoreUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid
        SiticoneTextBox_request_answer.CursorWidth = 1
        SiticoneTextBox_request_answer.DisabledBackColor = Color.WhiteSmoke
        SiticoneTextBox_request_answer.DisabledBorderColor = Color.LightGray
        SiticoneTextBox_request_answer.DisabledTextColor = Color.Gray
        SiticoneTextBox_request_answer.Enabled = False
        SiticoneTextBox_request_answer.EnableDropShadow = False
        SiticoneTextBox_request_answer.FillColor1 = Color.White
        SiticoneTextBox_request_answer.FillColor2 = Color.White
        SiticoneTextBox_request_answer.Font = New Font("Segoe UI", 9.5F)
        SiticoneTextBox_request_answer.ForeColor = Color.DimGray
        SiticoneTextBox_request_answer.HoverBorderColor1 = Color.Gray
        SiticoneTextBox_request_answer.HoverBorderColor2 = Color.Gray
        SiticoneTextBox_request_answer.IsEnabled = True
        SiticoneTextBox_request_answer.Location = New Point(404, 421)
        SiticoneTextBox_request_answer.Name = "SiticoneTextBox_request_answer"
        SiticoneTextBox_request_answer.PlaceholderColor = Color.Gray
        SiticoneTextBox_request_answer.PlaceholderText = "no request answer"
        SiticoneTextBox_request_answer.ReadOnlyBorderColor1 = Color.LightGray
        SiticoneTextBox_request_answer.ReadOnlyBorderColor2 = Color.LightGray
        SiticoneTextBox_request_answer.ReadOnlyFillColor1 = Color.WhiteSmoke
        SiticoneTextBox_request_answer.ReadOnlyFillColor2 = Color.WhiteSmoke
        SiticoneTextBox_request_answer.ReadOnlyPlaceholderColor = Color.DarkGray
        SiticoneTextBox_request_answer.SelectionBackColor = Color.FromArgb(CByte(77), CByte(77), CByte(255))
        SiticoneTextBox_request_answer.ShadowAnimationDuration = 1
        SiticoneTextBox_request_answer.ShadowBlur = 10
        SiticoneTextBox_request_answer.ShadowColor = Color.FromArgb(CByte(15), CByte(0), CByte(0), CByte(0))
        SiticoneTextBox_request_answer.Size = New Size(995, 23)
        SiticoneTextBox_request_answer.SolidBorderColor = Color.LightSlateGray
        SiticoneTextBox_request_answer.SolidBorderFocusColor = Color.FromArgb(CByte(77), CByte(77), CByte(255))
        SiticoneTextBox_request_answer.SolidBorderHoverColor = Color.Gray
        SiticoneTextBox_request_answer.SolidFillColor = Color.White
        SiticoneTextBox_request_answer.TabIndex = 47
        SiticoneTextBox_request_answer.TextPadding = New Padding(16, 0, 6, 0)
        SiticoneTextBox_request_answer.ValidationErrorMessage = "Invalid input."
        SiticoneTextBox_request_answer.ValidationFunction = Nothing
        ' 
        ' SiticoneTextArea_Tools_system
        ' 
        SiticoneTextArea_Tools_system.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        SiticoneTextArea_Tools_system.BackColor = SystemColors.GradientInactiveCaption
        SiticoneTextArea_Tools_system.BorderStyle = BorderStyle.None
        SiticoneTextArea_Tools_system.Font = New Font("Century Gothic", 10F)
        SiticoneTextArea_Tools_system.Location = New Point(8, 32)
        SiticoneTextArea_Tools_system.Margin = New Padding(5)
        SiticoneTextArea_Tools_system.MinimumSize = New Size(100, 65)
        SiticoneTextArea_Tools_system.Multiline = True
        SiticoneTextArea_Tools_system.Name = "SiticoneTextArea_Tools_system"
        SiticoneTextArea_Tools_system.PlaceholderText = "Write addition Prompt here..."
        SiticoneTextArea_Tools_system.ScrollBars = ScrollBars.Vertical
        SiticoneTextArea_Tools_system.Size = New Size(1391, 65)
        SiticoneTextArea_Tools_system.TabIndex = 45
        ' 
        ' SiticoneLabel9
        ' 
        SiticoneLabel9.BackColor = Color.Transparent
        SiticoneLabel9.Font = New Font("Segoe UI", 10F)
        SiticoneLabel9.Location = New Point(44, 8)
        SiticoneLabel9.Name = "SiticoneLabel9"
        SiticoneLabel9.Size = New Size(150, 21)
        SiticoneLabel9.TabIndex = 44
        SiticoneLabel9.Text = "Tool System Prompt:"
        ' 
        ' SiticoneLabel8
        ' 
        SiticoneLabel8.BackColor = Color.Transparent
        SiticoneLabel8.Font = New Font("Segoe UI", 10F)
        SiticoneLabel8.Location = New Point(44, 423)
        SiticoneLabel8.Name = "SiticoneLabel8"
        SiticoneLabel8.Size = New Size(150, 21)
        SiticoneLabel8.TabIndex = 32
        SiticoneLabel8.Text = "Tool Python Code:"
        ' 
        ' SiticoneLabel7
        ' 
        SiticoneLabel7.BackColor = Color.Transparent
        SiticoneLabel7.Font = New Font("Segoe UI", 10F)
        SiticoneLabel7.Location = New Point(44, 108)
        SiticoneLabel7.Name = "SiticoneLabel7"
        SiticoneLabel7.Size = New Size(116, 21)
        SiticoneLabel7.TabIndex = 31
        SiticoneLabel7.Text = "Tool JSON:"
        ' 
        ' TabPage_ragtool
        ' 
        TabPage_ragtool.BackColor = Color.WhiteSmoke
        TabPage_ragtool.Controls.Add(SiticoneFlatPanel_ragtools)
        TabPage_ragtool.Controls.Add(Scintilla_Rag_Json)
        TabPage_ragtool.Controls.Add(SiticoneButton_link_rag_tool_json)
        TabPage_ragtool.Controls.Add(SiticoneButton_link_rag_tool_system_prompt)
        TabPage_ragtool.Controls.Add(SiticoneButton_load_rag)
        TabPage_ragtool.Controls.Add(SiticoneButton_save_rag)
        TabPage_ragtool.Controls.Add(SiticoneTextArea_Rag_system)
        TabPage_ragtool.Controls.Add(SiticoneLabel11)
        TabPage_ragtool.Controls.Add(SiticoneLabel12)
        TabPage_ragtool.Controls.Add(SiticoneDropdown_delta_val)
        TabPage_ragtool.Controls.Add(SiticoneLabel1_delta)
        TabPage_ragtool.Controls.Add(SiticoneButton_resp_clp_rag)
        TabPage_ragtool.Controls.Add(SiticoneLabel_HitCountVal)
        TabPage_ragtool.Controls.Add(SiticoneLabel_HitCount)
        TabPage_ragtool.Controls.Add(SiticoneLabel_SentencesCountVal)
        TabPage_ragtool.Controls.Add(SiticoneLabel_SentencesCount)
        TabPage_ragtool.Controls.Add(SiticoneButton_ragpath)
        TabPage_ragtool.Controls.Add(SiticoneLabel1_ragpath)
        TabPage_ragtool.Controls.Add(SiticoneTextBox_ragpath)
        TabPage_ragtool.Location = New Point(4, 54)
        TabPage_ragtool.Name = "TabPage_ragtool"
        TabPage_ragtool.Padding = New Padding(3)
        TabPage_ragtool.Size = New Size(1407, 630)
        SiticoneTabControl_tab.SetTabImage(TabPage_ragtool, My.Resources.Resource_svg.RAG_Tool)
        TabPage_ragtool.TabIndex = 9
        TabPage_ragtool.Text = "RAG Tool"
        ' 
        ' SiticoneFlatPanel_ragtools
        ' 
        SiticoneFlatPanel_ragtools.BackColor = Color.Transparent
        SiticoneFlatPanel_ragtools.Controls.Add(SiticoneLabel_ragtools)
        SiticoneFlatPanel_ragtools.Controls.Add(SiticoneToggleSwitch_ragtools)
        SiticoneFlatPanel_ragtools.Location = New Point(232, 6)
        SiticoneFlatPanel_ragtools.MinimumSize = New Size(20, 20)
        SiticoneFlatPanel_ragtools.Name = "SiticoneFlatPanel_ragtools"
        SiticoneFlatPanel_ragtools.Size = New Size(145, 25)
        SiticoneFlatPanel_ragtools.TabIndex = 69
        ' 
        ' SiticoneLabel_ragtools
        ' 
        SiticoneLabel_ragtools.BackColor = Color.Transparent
        SiticoneLabel_ragtools.Dock = DockStyle.Right
        SiticoneLabel_ragtools.Font = New Font("Segoe UI", 10F)
        SiticoneLabel_ragtools.Location = New Point(51, 0)
        SiticoneLabel_ragtools.Name = "SiticoneLabel_ragtools"
        SiticoneLabel_ragtools.Size = New Size(94, 25)
        SiticoneLabel_ragtools.TabIndex = 55
        SiticoneLabel_ragtools.Text = "Use RAG Tool"
        SiticoneLabel_ragtools.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' SiticoneToggleSwitch_ragtools
        ' 
        SiticoneToggleSwitch_ragtools.AccessibleDescription = "A customizable toggle switch that can be turned on or off."
        SiticoneToggleSwitch_ragtools.AccessibleName = "Siticone Toggle Switch"
        SiticoneToggleSwitch_ragtools.AccessibleRole = AccessibleRole.CheckButton
        SiticoneToggleSwitch_ragtools.CanBeep = True
        SiticoneToggleSwitch_ragtools.CanShake = True
        SiticoneToggleSwitch_ragtools.DisabledColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        SiticoneToggleSwitch_ragtools.DisallowToggling = False
        SiticoneToggleSwitch_ragtools.Dock = DockStyle.Left
        SiticoneToggleSwitch_ragtools.EnableGlowEffect = True
        SiticoneToggleSwitch_ragtools.ExtraThumbSize = 2
        SiticoneToggleSwitch_ragtools.IsOn = False
        SiticoneToggleSwitch_ragtools.IsReadOnly = False
        SiticoneToggleSwitch_ragtools.IsRequired = False
        SiticoneToggleSwitch_ragtools.LabelColor = Color.Black
        SiticoneToggleSwitch_ragtools.LabelFont = New Font("Segoe UI", 9F)
        SiticoneToggleSwitch_ragtools.Location = New Point(0, 0)
        SiticoneToggleSwitch_ragtools.Logger = Nothing
        SiticoneToggleSwitch_ragtools.Name = "SiticoneToggleSwitch_ragtools"
        SiticoneToggleSwitch_ragtools.OffBackColor1 = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        SiticoneToggleSwitch_ragtools.OffBackColor2 = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        SiticoneToggleSwitch_ragtools.OffBorderColor1 = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        SiticoneToggleSwitch_ragtools.OffBorderColor2 = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        SiticoneToggleSwitch_ragtools.OffIcon = Nothing
        SiticoneToggleSwitch_ragtools.OffThumbColor1 = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        SiticoneToggleSwitch_ragtools.OffThumbColor2 = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        SiticoneToggleSwitch_ragtools.OnBackColor1 = Color.FromArgb(CByte(26), CByte(115), CByte(232))
        SiticoneToggleSwitch_ragtools.OnBackColor2 = Color.FromArgb(CByte(26), CByte(115), CByte(232))
        SiticoneToggleSwitch_ragtools.OnBorderColor1 = Color.FromArgb(CByte(26), CByte(115), CByte(232))
        SiticoneToggleSwitch_ragtools.OnBorderColor2 = Color.FromArgb(CByte(26), CByte(115), CByte(232))
        SiticoneToggleSwitch_ragtools.OnIcon = Nothing
        SiticoneToggleSwitch_ragtools.OnThumbColor1 = Color.White
        SiticoneToggleSwitch_ragtools.OnThumbColor2 = Color.White
        SiticoneToggleSwitch_ragtools.PreventToggleOff = False
        SiticoneToggleSwitch_ragtools.RippleColor = Color.FromArgb(CByte(100), CByte(255), CByte(255), CByte(255))
        SiticoneToggleSwitch_ragtools.RippleExpansionRate = 2F
        SiticoneToggleSwitch_ragtools.RippleOpacityDecay = 0.02F
        SiticoneToggleSwitch_ragtools.Size = New Size(50, 25)
        SiticoneToggleSwitch_ragtools.TabIndex = 54
        SiticoneToggleSwitch_ragtools.ToggleOffSoundPath = ""
        SiticoneToggleSwitch_ragtools.ToggleOnSoundPath = ""
        SiticoneToggleSwitch_ragtools.ToolTipText = ""
        SiticoneToggleSwitch_ragtools.TrackDeviceTheme = True
        ' 
        ' Scintilla_Rag_Json
        ' 
        Scintilla_Rag_Json.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Scintilla_Rag_Json.AutocompleteListSelectedBackColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        Scintilla_Rag_Json.Font = New Font("Consolas", 10F)
        Scintilla_Rag_Json.LexerName = "json"
        Scintilla_Rag_Json.Location = New Point(8, 130)
        Scintilla_Rag_Json.Name = "Scintilla_Rag_Json"
        Scintilla_Rag_Json.ScrollWidth = 70
        Scintilla_Rag_Json.Size = New Size(1391, 355)
        Scintilla_Rag_Json.TabIndex = 68
        ' 
        ' SiticoneButton_link_rag_tool_json
        ' 
        SiticoneButton_link_rag_tool_json.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard"
        SiticoneButton_link_rag_tool_json.AccessibleName = ""
        SiticoneButton_link_rag_tool_json.AutoSizeBasedOnText = False
        SiticoneButton_link_rag_tool_json.BackColor = Color.Transparent
        SiticoneButton_link_rag_tool_json.BadgeBackColor = Color.Red
        SiticoneButton_link_rag_tool_json.BadgeFont = New Font("Segoe UI", 8F, FontStyle.Bold)
        SiticoneButton_link_rag_tool_json.BadgeValue = 0
        SiticoneButton_link_rag_tool_json.BadgeValueForeColor = Color.White
        SiticoneButton_link_rag_tool_json.BorderColor = Color.Gray
        SiticoneButton_link_rag_tool_json.BorderWidth = 2
        SiticoneButton_link_rag_tool_json.ButtonBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        SiticoneButton_link_rag_tool_json.ButtonImage = My.Resources.Resource_pic.help_16
        SiticoneButton_link_rag_tool_json.ButtonTextLeftPadding = 0
        SiticoneButton_link_rag_tool_json.CanBeep = True
        SiticoneButton_link_rag_tool_json.CanGlow = False
        SiticoneButton_link_rag_tool_json.CanShake = True
        SiticoneButton_link_rag_tool_json.ContextMenuStripEx = Nothing
        SiticoneButton_link_rag_tool_json.CornerRadiusBottomLeft = 8
        SiticoneButton_link_rag_tool_json.CornerRadiusBottomRight = 8
        SiticoneButton_link_rag_tool_json.CornerRadiusTopLeft = 8
        SiticoneButton_link_rag_tool_json.CornerRadiusTopRight = 8
        SiticoneButton_link_rag_tool_json.CustomCursor = Cursors.Default
        SiticoneButton_link_rag_tool_json.DisabledTextColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        SiticoneButton_link_rag_tool_json.EnableLongPress = False
        SiticoneButton_link_rag_tool_json.EnablePressAnimation = True
        SiticoneButton_link_rag_tool_json.EnableRippleEffect = True
        SiticoneButton_link_rag_tool_json.EnableShadow = False
        SiticoneButton_link_rag_tool_json.EnableTextWrapping = False
        SiticoneButton_link_rag_tool_json.Font = New Font("Segoe UI", 9F)
        SiticoneButton_link_rag_tool_json.GlowColor = Color.FromArgb(CByte(100), CByte(255), CByte(255), CByte(255))
        SiticoneButton_link_rag_tool_json.GlowIntensity = 100
        SiticoneButton_link_rag_tool_json.GlowRadius = 20F
        SiticoneButton_link_rag_tool_json.GradientBackground = False
        SiticoneButton_link_rag_tool_json.GradientColor = Color.Gray
        SiticoneButton_link_rag_tool_json.GradientMode = Drawing2D.LinearGradientMode.Vertical
        SiticoneButton_link_rag_tool_json.HintText = Nothing
        SiticoneButton_link_rag_tool_json.HoverBackColor = Color.Silver
        SiticoneButton_link_rag_tool_json.HoverFontStyle = FontStyle.Regular
        SiticoneButton_link_rag_tool_json.HoverTextColor = Color.White
        SiticoneButton_link_rag_tool_json.HoverTransitionDuration = 250
        SiticoneButton_link_rag_tool_json.ImageAlign = ContentAlignment.MiddleCenter
        SiticoneButton_link_rag_tool_json.ImagePadding = 5
        SiticoneButton_link_rag_tool_json.ImageSize = New Size(16, 16)
        SiticoneButton_link_rag_tool_json.IsRadial = False
        SiticoneButton_link_rag_tool_json.IsReadOnly = False
        SiticoneButton_link_rag_tool_json.IsToggleButton = False
        SiticoneButton_link_rag_tool_json.IsToggled = False
        SiticoneButton_link_rag_tool_json.Location = New Point(8, 105)
        SiticoneButton_link_rag_tool_json.LongPressDurationMS = 1000
        SiticoneButton_link_rag_tool_json.Name = "SiticoneButton_link_rag_tool_json"
        SiticoneButton_link_rag_tool_json.NormalFontStyle = FontStyle.Regular
        SiticoneButton_link_rag_tool_json.ParticleColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        SiticoneButton_link_rag_tool_json.ParticleCount = 15
        SiticoneButton_link_rag_tool_json.PressAnimationScale = 0.97F
        SiticoneButton_link_rag_tool_json.PressedBackColor = Color.FromArgb(CByte(74), CByte(128), CByte(235))
        SiticoneButton_link_rag_tool_json.PressedFontStyle = FontStyle.Regular
        SiticoneButton_link_rag_tool_json.PressTransitionDuration = 150
        SiticoneButton_link_rag_tool_json.ReadOnlyTextColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        SiticoneButton_link_rag_tool_json.RippleColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        SiticoneButton_link_rag_tool_json.RippleOpacity = 0.3F
        SiticoneButton_link_rag_tool_json.RippleRadiusMultiplier = 0.6F
        SiticoneButton_link_rag_tool_json.ShadowBlur = 5
        SiticoneButton_link_rag_tool_json.ShadowColor = Color.FromArgb(CByte(100), CByte(0), CByte(0), CByte(0))
        SiticoneButton_link_rag_tool_json.ShadowOffset = New Point(2, 2)
        SiticoneButton_link_rag_tool_json.ShakeDuration = 500
        SiticoneButton_link_rag_tool_json.ShakeIntensity = 5
        SiticoneButton_link_rag_tool_json.Size = New Size(30, 24)
        SiticoneButton_link_rag_tool_json.TabIndex = 67
        SiticoneButton_link_rag_tool_json.TextAlign = ContentAlignment.MiddleCenter
        SiticoneButton_link_rag_tool_json.TextColor = Color.White
        ToolTip1.SetToolTip(SiticoneButton_link_rag_tool_json, "Help")
        SiticoneButton_link_rag_tool_json.TooltipText = Nothing
        SiticoneButton_link_rag_tool_json.UseAdvancedRendering = True
        SiticoneButton_link_rag_tool_json.UseParticles = False
        ' 
        ' SiticoneButton_link_rag_tool_system_prompt
        ' 
        SiticoneButton_link_rag_tool_system_prompt.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard"
        SiticoneButton_link_rag_tool_system_prompt.AccessibleName = ""
        SiticoneButton_link_rag_tool_system_prompt.AutoSizeBasedOnText = False
        SiticoneButton_link_rag_tool_system_prompt.BackColor = Color.Transparent
        SiticoneButton_link_rag_tool_system_prompt.BadgeBackColor = Color.Red
        SiticoneButton_link_rag_tool_system_prompt.BadgeFont = New Font("Segoe UI", 8F, FontStyle.Bold)
        SiticoneButton_link_rag_tool_system_prompt.BadgeValue = 0
        SiticoneButton_link_rag_tool_system_prompt.BadgeValueForeColor = Color.White
        SiticoneButton_link_rag_tool_system_prompt.BorderColor = Color.Gray
        SiticoneButton_link_rag_tool_system_prompt.BorderWidth = 2
        SiticoneButton_link_rag_tool_system_prompt.ButtonBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        SiticoneButton_link_rag_tool_system_prompt.ButtonImage = My.Resources.Resource_pic.help_16
        SiticoneButton_link_rag_tool_system_prompt.ButtonTextLeftPadding = 0
        SiticoneButton_link_rag_tool_system_prompt.CanBeep = True
        SiticoneButton_link_rag_tool_system_prompt.CanGlow = False
        SiticoneButton_link_rag_tool_system_prompt.CanShake = True
        SiticoneButton_link_rag_tool_system_prompt.ContextMenuStripEx = Nothing
        SiticoneButton_link_rag_tool_system_prompt.CornerRadiusBottomLeft = 8
        SiticoneButton_link_rag_tool_system_prompt.CornerRadiusBottomRight = 8
        SiticoneButton_link_rag_tool_system_prompt.CornerRadiusTopLeft = 8
        SiticoneButton_link_rag_tool_system_prompt.CornerRadiusTopRight = 8
        SiticoneButton_link_rag_tool_system_prompt.CustomCursor = Cursors.Default
        SiticoneButton_link_rag_tool_system_prompt.DisabledTextColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        SiticoneButton_link_rag_tool_system_prompt.EnableLongPress = False
        SiticoneButton_link_rag_tool_system_prompt.EnablePressAnimation = True
        SiticoneButton_link_rag_tool_system_prompt.EnableRippleEffect = True
        SiticoneButton_link_rag_tool_system_prompt.EnableShadow = False
        SiticoneButton_link_rag_tool_system_prompt.EnableTextWrapping = False
        SiticoneButton_link_rag_tool_system_prompt.Font = New Font("Segoe UI", 9F)
        SiticoneButton_link_rag_tool_system_prompt.GlowColor = Color.FromArgb(CByte(100), CByte(255), CByte(255), CByte(255))
        SiticoneButton_link_rag_tool_system_prompt.GlowIntensity = 100
        SiticoneButton_link_rag_tool_system_prompt.GlowRadius = 20F
        SiticoneButton_link_rag_tool_system_prompt.GradientBackground = False
        SiticoneButton_link_rag_tool_system_prompt.GradientColor = Color.Gray
        SiticoneButton_link_rag_tool_system_prompt.GradientMode = Drawing2D.LinearGradientMode.Vertical
        SiticoneButton_link_rag_tool_system_prompt.HintText = Nothing
        SiticoneButton_link_rag_tool_system_prompt.HoverBackColor = Color.Silver
        SiticoneButton_link_rag_tool_system_prompt.HoverFontStyle = FontStyle.Regular
        SiticoneButton_link_rag_tool_system_prompt.HoverTextColor = Color.White
        SiticoneButton_link_rag_tool_system_prompt.HoverTransitionDuration = 250
        SiticoneButton_link_rag_tool_system_prompt.ImageAlign = ContentAlignment.MiddleCenter
        SiticoneButton_link_rag_tool_system_prompt.ImagePadding = 5
        SiticoneButton_link_rag_tool_system_prompt.ImageSize = New Size(16, 16)
        SiticoneButton_link_rag_tool_system_prompt.IsRadial = False
        SiticoneButton_link_rag_tool_system_prompt.IsReadOnly = False
        SiticoneButton_link_rag_tool_system_prompt.IsToggleButton = False
        SiticoneButton_link_rag_tool_system_prompt.IsToggled = False
        SiticoneButton_link_rag_tool_system_prompt.Location = New Point(8, 6)
        SiticoneButton_link_rag_tool_system_prompt.LongPressDurationMS = 1000
        SiticoneButton_link_rag_tool_system_prompt.Name = "SiticoneButton_link_rag_tool_system_prompt"
        SiticoneButton_link_rag_tool_system_prompt.NormalFontStyle = FontStyle.Regular
        SiticoneButton_link_rag_tool_system_prompt.ParticleColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        SiticoneButton_link_rag_tool_system_prompt.ParticleCount = 15
        SiticoneButton_link_rag_tool_system_prompt.PressAnimationScale = 0.97F
        SiticoneButton_link_rag_tool_system_prompt.PressedBackColor = Color.FromArgb(CByte(74), CByte(128), CByte(235))
        SiticoneButton_link_rag_tool_system_prompt.PressedFontStyle = FontStyle.Regular
        SiticoneButton_link_rag_tool_system_prompt.PressTransitionDuration = 150
        SiticoneButton_link_rag_tool_system_prompt.ReadOnlyTextColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        SiticoneButton_link_rag_tool_system_prompt.RippleColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        SiticoneButton_link_rag_tool_system_prompt.RippleOpacity = 0.3F
        SiticoneButton_link_rag_tool_system_prompt.RippleRadiusMultiplier = 0.6F
        SiticoneButton_link_rag_tool_system_prompt.ShadowBlur = 5
        SiticoneButton_link_rag_tool_system_prompt.ShadowColor = Color.FromArgb(CByte(100), CByte(0), CByte(0), CByte(0))
        SiticoneButton_link_rag_tool_system_prompt.ShadowOffset = New Point(2, 2)
        SiticoneButton_link_rag_tool_system_prompt.ShakeDuration = 500
        SiticoneButton_link_rag_tool_system_prompt.ShakeIntensity = 5
        SiticoneButton_link_rag_tool_system_prompt.Size = New Size(30, 24)
        SiticoneButton_link_rag_tool_system_prompt.TabIndex = 66
        SiticoneButton_link_rag_tool_system_prompt.TextAlign = ContentAlignment.MiddleCenter
        SiticoneButton_link_rag_tool_system_prompt.TextColor = Color.White
        ToolTip1.SetToolTip(SiticoneButton_link_rag_tool_system_prompt, "Help")
        SiticoneButton_link_rag_tool_system_prompt.TooltipText = Nothing
        SiticoneButton_link_rag_tool_system_prompt.UseAdvancedRendering = True
        SiticoneButton_link_rag_tool_system_prompt.UseParticles = False
        ' 
        ' SiticoneButton_load_rag
        ' 
        SiticoneButton_load_rag.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard"
        SiticoneButton_load_rag.AccessibleName = "Load RAG"
        SiticoneButton_load_rag.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        SiticoneButton_load_rag.AutoSizeBasedOnText = False
        SiticoneButton_load_rag.BackColor = Color.Transparent
        SiticoneButton_load_rag.BadgeBackColor = Color.Red
        SiticoneButton_load_rag.BadgeFont = New Font("Segoe UI", 8F, FontStyle.Bold)
        SiticoneButton_load_rag.BadgeValue = 0
        SiticoneButton_load_rag.BadgeValueForeColor = Color.White
        SiticoneButton_load_rag.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        SiticoneButton_load_rag.BorderWidth = 2
        SiticoneButton_load_rag.ButtonBackColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        SiticoneButton_load_rag.ButtonImage = Nothing
        SiticoneButton_load_rag.ButtonTextLeftPadding = 0
        SiticoneButton_load_rag.CanBeep = True
        SiticoneButton_load_rag.CanGlow = False
        SiticoneButton_load_rag.CanShake = True
        SiticoneButton_load_rag.ContextMenuStripEx = Nothing
        SiticoneButton_load_rag.CornerRadiusBottomLeft = 8
        SiticoneButton_load_rag.CornerRadiusBottomRight = 8
        SiticoneButton_load_rag.CornerRadiusTopLeft = 8
        SiticoneButton_load_rag.CornerRadiusTopRight = 8
        SiticoneButton_load_rag.CustomCursor = Cursors.Default
        SiticoneButton_load_rag.DisabledTextColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        SiticoneButton_load_rag.EnableLongPress = False
        SiticoneButton_load_rag.EnablePressAnimation = True
        SiticoneButton_load_rag.EnableRippleEffect = True
        SiticoneButton_load_rag.EnableShadow = False
        SiticoneButton_load_rag.EnableTextWrapping = False
        SiticoneButton_load_rag.Font = New Font("Segoe UI", 9F)
        SiticoneButton_load_rag.GlowColor = Color.FromArgb(CByte(100), CByte(255), CByte(255), CByte(255))
        SiticoneButton_load_rag.GlowIntensity = 100
        SiticoneButton_load_rag.GlowRadius = 20F
        SiticoneButton_load_rag.GradientBackground = False
        SiticoneButton_load_rag.GradientColor = Color.FromArgb(CByte(114), CByte(168), CByte(255))
        SiticoneButton_load_rag.GradientMode = Drawing2D.LinearGradientMode.Vertical
        SiticoneButton_load_rag.HintText = Nothing
        SiticoneButton_load_rag.HoverBackColor = Color.FromArgb(CByte(114), CByte(168), CByte(255))
        SiticoneButton_load_rag.HoverFontStyle = FontStyle.Regular
        SiticoneButton_load_rag.HoverTextColor = Color.White
        SiticoneButton_load_rag.HoverTransitionDuration = 250
        SiticoneButton_load_rag.ImageAlign = ContentAlignment.MiddleLeft
        SiticoneButton_load_rag.ImagePadding = 5
        SiticoneButton_load_rag.ImageSize = New Size(16, 16)
        SiticoneButton_load_rag.IsRadial = False
        SiticoneButton_load_rag.IsReadOnly = False
        SiticoneButton_load_rag.IsToggleButton = False
        SiticoneButton_load_rag.IsToggled = False
        SiticoneButton_load_rag.Location = New Point(1183, 600)
        SiticoneButton_load_rag.LongPressDurationMS = 1000
        SiticoneButton_load_rag.Name = "SiticoneButton_load_rag"
        SiticoneButton_load_rag.NormalFontStyle = FontStyle.Regular
        SiticoneButton_load_rag.ParticleColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        SiticoneButton_load_rag.ParticleCount = 15
        SiticoneButton_load_rag.PressAnimationScale = 0.97F
        SiticoneButton_load_rag.PressedBackColor = Color.FromArgb(CByte(74), CByte(128), CByte(235))
        SiticoneButton_load_rag.PressedFontStyle = FontStyle.Regular
        SiticoneButton_load_rag.PressTransitionDuration = 150
        SiticoneButton_load_rag.ReadOnlyTextColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        SiticoneButton_load_rag.RippleColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        SiticoneButton_load_rag.RippleOpacity = 0.3F
        SiticoneButton_load_rag.RippleRadiusMultiplier = 0.6F
        SiticoneButton_load_rag.ShadowBlur = 5
        SiticoneButton_load_rag.ShadowColor = Color.FromArgb(CByte(100), CByte(0), CByte(0), CByte(0))
        SiticoneButton_load_rag.ShadowOffset = New Point(2, 2)
        SiticoneButton_load_rag.ShakeDuration = 500
        SiticoneButton_load_rag.ShakeIntensity = 5
        SiticoneButton_load_rag.Size = New Size(107, 24)
        SiticoneButton_load_rag.TabIndex = 65
        SiticoneButton_load_rag.Text = "Load RAG"
        SiticoneButton_load_rag.TextAlign = ContentAlignment.MiddleCenter
        SiticoneButton_load_rag.TextColor = Color.White
        SiticoneButton_load_rag.TooltipText = Nothing
        SiticoneButton_load_rag.UseAdvancedRendering = True
        SiticoneButton_load_rag.UseParticles = False
        ' 
        ' SiticoneButton_save_rag
        ' 
        SiticoneButton_save_rag.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard"
        SiticoneButton_save_rag.AccessibleName = "Save RAG"
        SiticoneButton_save_rag.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        SiticoneButton_save_rag.AutoSizeBasedOnText = False
        SiticoneButton_save_rag.BackColor = Color.Transparent
        SiticoneButton_save_rag.BadgeBackColor = Color.Red
        SiticoneButton_save_rag.BadgeFont = New Font("Segoe UI", 8F, FontStyle.Bold)
        SiticoneButton_save_rag.BadgeValue = 0
        SiticoneButton_save_rag.BadgeValueForeColor = Color.White
        SiticoneButton_save_rag.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        SiticoneButton_save_rag.BorderWidth = 2
        SiticoneButton_save_rag.ButtonBackColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        SiticoneButton_save_rag.ButtonImage = Nothing
        SiticoneButton_save_rag.ButtonTextLeftPadding = 0
        SiticoneButton_save_rag.CanBeep = True
        SiticoneButton_save_rag.CanGlow = False
        SiticoneButton_save_rag.CanShake = True
        SiticoneButton_save_rag.ContextMenuStripEx = Nothing
        SiticoneButton_save_rag.CornerRadiusBottomLeft = 8
        SiticoneButton_save_rag.CornerRadiusBottomRight = 8
        SiticoneButton_save_rag.CornerRadiusTopLeft = 8
        SiticoneButton_save_rag.CornerRadiusTopRight = 8
        SiticoneButton_save_rag.CustomCursor = Cursors.Default
        SiticoneButton_save_rag.DisabledTextColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        SiticoneButton_save_rag.EnableLongPress = False
        SiticoneButton_save_rag.EnablePressAnimation = True
        SiticoneButton_save_rag.EnableRippleEffect = True
        SiticoneButton_save_rag.EnableShadow = False
        SiticoneButton_save_rag.EnableTextWrapping = False
        SiticoneButton_save_rag.Font = New Font("Segoe UI", 9F)
        SiticoneButton_save_rag.GlowColor = Color.FromArgb(CByte(100), CByte(255), CByte(255), CByte(255))
        SiticoneButton_save_rag.GlowIntensity = 100
        SiticoneButton_save_rag.GlowRadius = 20F
        SiticoneButton_save_rag.GradientBackground = False
        SiticoneButton_save_rag.GradientColor = Color.FromArgb(CByte(114), CByte(168), CByte(255))
        SiticoneButton_save_rag.GradientMode = Drawing2D.LinearGradientMode.Vertical
        SiticoneButton_save_rag.HintText = Nothing
        SiticoneButton_save_rag.HoverBackColor = Color.FromArgb(CByte(114), CByte(168), CByte(255))
        SiticoneButton_save_rag.HoverFontStyle = FontStyle.Regular
        SiticoneButton_save_rag.HoverTextColor = Color.White
        SiticoneButton_save_rag.HoverTransitionDuration = 250
        SiticoneButton_save_rag.ImageAlign = ContentAlignment.MiddleLeft
        SiticoneButton_save_rag.ImagePadding = 5
        SiticoneButton_save_rag.ImageSize = New Size(16, 16)
        SiticoneButton_save_rag.IsRadial = False
        SiticoneButton_save_rag.IsReadOnly = False
        SiticoneButton_save_rag.IsToggleButton = False
        SiticoneButton_save_rag.IsToggled = False
        SiticoneButton_save_rag.Location = New Point(1296, 600)
        SiticoneButton_save_rag.LongPressDurationMS = 1000
        SiticoneButton_save_rag.Name = "SiticoneButton_save_rag"
        SiticoneButton_save_rag.NormalFontStyle = FontStyle.Regular
        SiticoneButton_save_rag.ParticleColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        SiticoneButton_save_rag.ParticleCount = 15
        SiticoneButton_save_rag.PressAnimationScale = 0.97F
        SiticoneButton_save_rag.PressedBackColor = Color.FromArgb(CByte(74), CByte(128), CByte(235))
        SiticoneButton_save_rag.PressedFontStyle = FontStyle.Regular
        SiticoneButton_save_rag.PressTransitionDuration = 150
        SiticoneButton_save_rag.ReadOnlyTextColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        SiticoneButton_save_rag.RippleColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        SiticoneButton_save_rag.RippleOpacity = 0.3F
        SiticoneButton_save_rag.RippleRadiusMultiplier = 0.6F
        SiticoneButton_save_rag.ShadowBlur = 5
        SiticoneButton_save_rag.ShadowColor = Color.FromArgb(CByte(100), CByte(0), CByte(0), CByte(0))
        SiticoneButton_save_rag.ShadowOffset = New Point(2, 2)
        SiticoneButton_save_rag.ShakeDuration = 500
        SiticoneButton_save_rag.ShakeIntensity = 5
        SiticoneButton_save_rag.Size = New Size(107, 24)
        SiticoneButton_save_rag.TabIndex = 64
        SiticoneButton_save_rag.Text = "Save RAG"
        SiticoneButton_save_rag.TextAlign = ContentAlignment.MiddleCenter
        SiticoneButton_save_rag.TextColor = Color.White
        SiticoneButton_save_rag.TooltipText = Nothing
        SiticoneButton_save_rag.UseAdvancedRendering = True
        SiticoneButton_save_rag.UseParticles = False
        ' 
        ' SiticoneTextArea_Rag_system
        ' 
        SiticoneTextArea_Rag_system.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        SiticoneTextArea_Rag_system.BackColor = SystemColors.GradientInactiveCaption
        SiticoneTextArea_Rag_system.BorderStyle = BorderStyle.None
        SiticoneTextArea_Rag_system.Font = New Font("Century Gothic", 10F)
        SiticoneTextArea_Rag_system.Location = New Point(8, 32)
        SiticoneTextArea_Rag_system.Margin = New Padding(5)
        SiticoneTextArea_Rag_system.MinimumSize = New Size(100, 65)
        SiticoneTextArea_Rag_system.Multiline = True
        SiticoneTextArea_Rag_system.Name = "SiticoneTextArea_Rag_system"
        SiticoneTextArea_Rag_system.PlaceholderText = "Write addition Prompt here..."
        SiticoneTextArea_Rag_system.ScrollBars = ScrollBars.Vertical
        SiticoneTextArea_Rag_system.Size = New Size(1391, 65)
        SiticoneTextArea_Rag_system.TabIndex = 63
        ' 
        ' SiticoneLabel11
        ' 
        SiticoneLabel11.BackColor = Color.Transparent
        SiticoneLabel11.Font = New Font("Segoe UI", 10F)
        SiticoneLabel11.Location = New Point(44, 8)
        SiticoneLabel11.Name = "SiticoneLabel11"
        SiticoneLabel11.Size = New Size(174, 21)
        SiticoneLabel11.TabIndex = 62
        SiticoneLabel11.Text = "RAG Tool System Prompt:"
        ' 
        ' SiticoneLabel12
        ' 
        SiticoneLabel12.BackColor = Color.Transparent
        SiticoneLabel12.Font = New Font("Segoe UI", 10F)
        SiticoneLabel12.Location = New Point(44, 108)
        SiticoneLabel12.Name = "SiticoneLabel12"
        SiticoneLabel12.Size = New Size(174, 21)
        SiticoneLabel12.TabIndex = 60
        SiticoneLabel12.Text = "RAG Tool JSON:"
        ' 
        ' SiticoneDropdown_delta_val
        ' 
        SiticoneDropdown_delta_val.AllowMultipleSelection = False
        SiticoneDropdown_delta_val.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        SiticoneDropdown_delta_val.BackColor = Color.Transparent
        SiticoneDropdown_delta_val.BorderColor = Color.Gray
        SiticoneDropdown_delta_val.BorderSize = 2
        SiticoneDropdown_delta_val.CanBeep = False
        SiticoneDropdown_delta_val.CanShake = True
        SiticoneDropdown_delta_val.CornerRadius = 8
        SiticoneDropdown_delta_val.DataSource = Nothing
        SiticoneDropdown_delta_val.DisplayMember = Nothing
        SiticoneDropdown_delta_val.DropdownBackColor = Color.White
        SiticoneDropdown_delta_val.DropdownCornerRadius = 8
        SiticoneDropdown_delta_val.DropdownWidth = 0
        SiticoneDropdown_delta_val.DropShadowEnabled = False
        SiticoneDropdown_delta_val.Font = New Font("Segoe UI", 10F)
        SiticoneDropdown_delta_val.ForeColor = Color.DimGray
        SiticoneDropdown_delta_val.HoveredItemBackColor = Color.LightGray
        SiticoneDropdown_delta_val.HoveredItemTextColor = Color.Black
        SiticoneDropdown_delta_val.IsReadonly = False
        SiticoneDropdown_delta_val.ItemHeight = 30
        SiticoneDropdown_delta_val.Items.AddRange(New String() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        SiticoneDropdown_delta_val.Location = New Point(1344, 491)
        SiticoneDropdown_delta_val.MaxDropDownItems = 10
        SiticoneDropdown_delta_val.Name = "SiticoneDropdown_delta_val"
        SiticoneDropdown_delta_val.NotFoundBackColor = Color.Transparent
        SiticoneDropdown_delta_val.NotFoundFont = Nothing
        SiticoneDropdown_delta_val.NotFoundTextColor = Color.Gray
        SiticoneDropdown_delta_val.PlaceholderColor = Color.Gray
        SiticoneDropdown_delta_val.PlaceholderDisappearsOnFocus = False
        SiticoneDropdown_delta_val.PlaceholderText = "Select a Delta Value"
        SiticoneDropdown_delta_val.SearchPlaceholderText = "1"
        SiticoneDropdown_delta_val.SearchTextColor = Color.DimGray
        SiticoneDropdown_delta_val.SearchTextFont = Nothing
        SiticoneDropdown_delta_val.SelectedIndex = 1
        SiticoneDropdown_delta_val.SelectedItem = "1"
        SiticoneDropdown_delta_val.SelectedItemBackColor = Color.LightBlue
        SiticoneDropdown_delta_val.SelectedItemTextColor = Color.Black
        SiticoneDropdown_delta_val.SelectedValue = Nothing
        SiticoneDropdown_delta_val.Size = New Size(57, 30)
        SiticoneDropdown_delta_val.TabIndex = 59
        SiticoneDropdown_delta_val.Text = "1"
        SiticoneDropdown_delta_val.UnselectedItemTextColor = Color.Black
        SiticoneDropdown_delta_val.ValueMember = Nothing
        ' 
        ' SiticoneLabel1_delta
        ' 
        SiticoneLabel1_delta.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        SiticoneLabel1_delta.BackColor = Color.Transparent
        SiticoneLabel1_delta.Font = New Font("Segoe UI", 10F)
        SiticoneLabel1_delta.Location = New Point(1293, 496)
        SiticoneLabel1_delta.Name = "SiticoneLabel1_delta"
        SiticoneLabel1_delta.Size = New Size(45, 21)
        SiticoneLabel1_delta.TabIndex = 58
        SiticoneLabel1_delta.Text = "Delta:"
        ' 
        ' SiticoneButton_resp_clp_rag
        ' 
        SiticoneButton_resp_clp_rag.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard"
        SiticoneButton_resp_clp_rag.AccessibleName = "Tools resp > CLP"
        SiticoneButton_resp_clp_rag.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        SiticoneButton_resp_clp_rag.AutoSizeBasedOnText = False
        SiticoneButton_resp_clp_rag.BackColor = Color.Transparent
        SiticoneButton_resp_clp_rag.BadgeBackColor = Color.Red
        SiticoneButton_resp_clp_rag.BadgeFont = New Font("Segoe UI", 8F, FontStyle.Bold)
        SiticoneButton_resp_clp_rag.BadgeValue = 0
        SiticoneButton_resp_clp_rag.BadgeValueForeColor = Color.White
        SiticoneButton_resp_clp_rag.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        SiticoneButton_resp_clp_rag.BorderWidth = 2
        SiticoneButton_resp_clp_rag.ButtonBackColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        SiticoneButton_resp_clp_rag.ButtonImage = Nothing
        SiticoneButton_resp_clp_rag.ButtonTextLeftPadding = 0
        SiticoneButton_resp_clp_rag.CanBeep = True
        SiticoneButton_resp_clp_rag.CanGlow = False
        SiticoneButton_resp_clp_rag.CanShake = True
        SiticoneButton_resp_clp_rag.ContextMenuStripEx = Nothing
        SiticoneButton_resp_clp_rag.CornerRadiusBottomLeft = 8
        SiticoneButton_resp_clp_rag.CornerRadiusBottomRight = 8
        SiticoneButton_resp_clp_rag.CornerRadiusTopLeft = 8
        SiticoneButton_resp_clp_rag.CornerRadiusTopRight = 8
        SiticoneButton_resp_clp_rag.CustomCursor = Cursors.Default
        SiticoneButton_resp_clp_rag.DisabledTextColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        SiticoneButton_resp_clp_rag.EnableLongPress = False
        SiticoneButton_resp_clp_rag.EnablePressAnimation = True
        SiticoneButton_resp_clp_rag.EnableRippleEffect = True
        SiticoneButton_resp_clp_rag.EnableShadow = False
        SiticoneButton_resp_clp_rag.EnableTextWrapping = False
        SiticoneButton_resp_clp_rag.Font = New Font("Segoe UI", 9F)
        SiticoneButton_resp_clp_rag.GlowColor = Color.FromArgb(CByte(100), CByte(255), CByte(255), CByte(255))
        SiticoneButton_resp_clp_rag.GlowIntensity = 100
        SiticoneButton_resp_clp_rag.GlowRadius = 20F
        SiticoneButton_resp_clp_rag.GradientBackground = False
        SiticoneButton_resp_clp_rag.GradientColor = Color.FromArgb(CByte(114), CByte(168), CByte(255))
        SiticoneButton_resp_clp_rag.GradientMode = Drawing2D.LinearGradientMode.Vertical
        SiticoneButton_resp_clp_rag.HintText = Nothing
        SiticoneButton_resp_clp_rag.HoverBackColor = Color.FromArgb(CByte(114), CByte(168), CByte(255))
        SiticoneButton_resp_clp_rag.HoverFontStyle = FontStyle.Regular
        SiticoneButton_resp_clp_rag.HoverTextColor = Color.White
        SiticoneButton_resp_clp_rag.HoverTransitionDuration = 250
        SiticoneButton_resp_clp_rag.ImageAlign = ContentAlignment.MiddleLeft
        SiticoneButton_resp_clp_rag.ImagePadding = 5
        SiticoneButton_resp_clp_rag.ImageSize = New Size(16, 16)
        SiticoneButton_resp_clp_rag.IsRadial = False
        SiticoneButton_resp_clp_rag.IsReadOnly = False
        SiticoneButton_resp_clp_rag.IsToggleButton = False
        SiticoneButton_resp_clp_rag.IsToggled = False
        SiticoneButton_resp_clp_rag.Location = New Point(8, 600)
        SiticoneButton_resp_clp_rag.LongPressDurationMS = 1000
        SiticoneButton_resp_clp_rag.Name = "SiticoneButton_resp_clp_rag"
        SiticoneButton_resp_clp_rag.NormalFontStyle = FontStyle.Regular
        SiticoneButton_resp_clp_rag.ParticleColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        SiticoneButton_resp_clp_rag.ParticleCount = 15
        SiticoneButton_resp_clp_rag.PressAnimationScale = 0.97F
        SiticoneButton_resp_clp_rag.PressedBackColor = Color.FromArgb(CByte(74), CByte(128), CByte(235))
        SiticoneButton_resp_clp_rag.PressedFontStyle = FontStyle.Regular
        SiticoneButton_resp_clp_rag.PressTransitionDuration = 150
        SiticoneButton_resp_clp_rag.ReadOnlyTextColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        SiticoneButton_resp_clp_rag.RippleColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        SiticoneButton_resp_clp_rag.RippleOpacity = 0.3F
        SiticoneButton_resp_clp_rag.RippleRadiusMultiplier = 0.6F
        SiticoneButton_resp_clp_rag.ShadowBlur = 5
        SiticoneButton_resp_clp_rag.ShadowColor = Color.FromArgb(CByte(100), CByte(0), CByte(0), CByte(0))
        SiticoneButton_resp_clp_rag.ShadowOffset = New Point(2, 2)
        SiticoneButton_resp_clp_rag.ShakeDuration = 500
        SiticoneButton_resp_clp_rag.ShakeIntensity = 5
        SiticoneButton_resp_clp_rag.Size = New Size(107, 24)
        SiticoneButton_resp_clp_rag.TabIndex = 57
        SiticoneButton_resp_clp_rag.Text = "Tools resp > CLP"
        SiticoneButton_resp_clp_rag.TextAlign = ContentAlignment.MiddleCenter
        SiticoneButton_resp_clp_rag.TextColor = Color.White
        SiticoneButton_resp_clp_rag.TooltipText = Nothing
        SiticoneButton_resp_clp_rag.UseAdvancedRendering = True
        SiticoneButton_resp_clp_rag.UseParticles = False
        ' 
        ' SiticoneLabel_HitCountVal
        ' 
        SiticoneLabel_HitCountVal.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        SiticoneLabel_HitCountVal.BackColor = Color.Transparent
        SiticoneLabel_HitCountVal.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        SiticoneLabel_HitCountVal.Location = New Point(288, 563)
        SiticoneLabel_HitCountVal.Name = "SiticoneLabel_HitCountVal"
        SiticoneLabel_HitCountVal.Size = New Size(49, 28)
        SiticoneLabel_HitCountVal.TabIndex = 56
        SiticoneLabel_HitCountVal.Text = "0"
        ' 
        ' SiticoneLabel_HitCount
        ' 
        SiticoneLabel_HitCount.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        SiticoneLabel_HitCount.BackColor = Color.Transparent
        SiticoneLabel_HitCount.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        SiticoneLabel_HitCount.Location = New Point(104, 563)
        SiticoneLabel_HitCount.Name = "SiticoneLabel_HitCount"
        SiticoneLabel_HitCount.Size = New Size(178, 28)
        SiticoneLabel_HitCount.TabIndex = 55
        SiticoneLabel_HitCount.Text = "Hit Count:"
        ' 
        ' SiticoneLabel_SentencesCountVal
        ' 
        SiticoneLabel_SentencesCountVal.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        SiticoneLabel_SentencesCountVal.BackColor = Color.Transparent
        SiticoneLabel_SentencesCountVal.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        SiticoneLabel_SentencesCountVal.Location = New Point(288, 535)
        SiticoneLabel_SentencesCountVal.Name = "SiticoneLabel_SentencesCountVal"
        SiticoneLabel_SentencesCountVal.Size = New Size(49, 28)
        SiticoneLabel_SentencesCountVal.TabIndex = 54
        SiticoneLabel_SentencesCountVal.Text = "0"
        ' 
        ' SiticoneLabel_SentencesCount
        ' 
        SiticoneLabel_SentencesCount.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        SiticoneLabel_SentencesCount.BackColor = Color.Transparent
        SiticoneLabel_SentencesCount.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        SiticoneLabel_SentencesCount.Location = New Point(104, 535)
        SiticoneLabel_SentencesCount.Name = "SiticoneLabel_SentencesCount"
        SiticoneLabel_SentencesCount.Size = New Size(178, 28)
        SiticoneLabel_SentencesCount.TabIndex = 53
        SiticoneLabel_SentencesCount.Text = "Sentences Count:"
        ' 
        ' SiticoneButton_ragpath
        ' 
        SiticoneButton_ragpath.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard"
        SiticoneButton_ragpath.AccessibleName = "..."
        SiticoneButton_ragpath.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        SiticoneButton_ragpath.AutoSizeBasedOnText = False
        SiticoneButton_ragpath.BackColor = Color.Transparent
        SiticoneButton_ragpath.BadgeBackColor = Color.Red
        SiticoneButton_ragpath.BadgeFont = New Font("Segoe UI", 8F, FontStyle.Bold)
        SiticoneButton_ragpath.BadgeValue = 0
        SiticoneButton_ragpath.BadgeValueForeColor = Color.White
        SiticoneButton_ragpath.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        SiticoneButton_ragpath.BorderWidth = 2
        SiticoneButton_ragpath.ButtonBackColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        SiticoneButton_ragpath.ButtonImage = Nothing
        SiticoneButton_ragpath.ButtonTextLeftPadding = 0
        SiticoneButton_ragpath.CanBeep = True
        SiticoneButton_ragpath.CanGlow = False
        SiticoneButton_ragpath.CanShake = True
        SiticoneButton_ragpath.ContextMenuStripEx = Nothing
        SiticoneButton_ragpath.CornerRadiusBottomLeft = 8
        SiticoneButton_ragpath.CornerRadiusBottomRight = 8
        SiticoneButton_ragpath.CornerRadiusTopLeft = 8
        SiticoneButton_ragpath.CornerRadiusTopRight = 8
        SiticoneButton_ragpath.CustomCursor = Cursors.Default
        SiticoneButton_ragpath.DisabledTextColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        SiticoneButton_ragpath.EnableLongPress = False
        SiticoneButton_ragpath.EnablePressAnimation = True
        SiticoneButton_ragpath.EnableRippleEffect = True
        SiticoneButton_ragpath.EnableShadow = False
        SiticoneButton_ragpath.EnableTextWrapping = False
        SiticoneButton_ragpath.Font = New Font("Segoe UI", 9F)
        SiticoneButton_ragpath.GlowColor = Color.FromArgb(CByte(100), CByte(255), CByte(255), CByte(255))
        SiticoneButton_ragpath.GlowIntensity = 100
        SiticoneButton_ragpath.GlowRadius = 20F
        SiticoneButton_ragpath.GradientBackground = False
        SiticoneButton_ragpath.GradientColor = Color.FromArgb(CByte(114), CByte(168), CByte(255))
        SiticoneButton_ragpath.GradientMode = Drawing2D.LinearGradientMode.Vertical
        SiticoneButton_ragpath.HintText = Nothing
        SiticoneButton_ragpath.HoverBackColor = Color.FromArgb(CByte(114), CByte(168), CByte(255))
        SiticoneButton_ragpath.HoverFontStyle = FontStyle.Regular
        SiticoneButton_ragpath.HoverTextColor = Color.White
        SiticoneButton_ragpath.HoverTransitionDuration = 250
        SiticoneButton_ragpath.ImageAlign = ContentAlignment.MiddleLeft
        SiticoneButton_ragpath.ImagePadding = 5
        SiticoneButton_ragpath.ImageSize = New Size(16, 16)
        SiticoneButton_ragpath.IsRadial = False
        SiticoneButton_ragpath.IsReadOnly = False
        SiticoneButton_ragpath.IsToggleButton = False
        SiticoneButton_ragpath.IsToggled = False
        SiticoneButton_ragpath.Location = New Point(1237, 491)
        SiticoneButton_ragpath.LongPressDurationMS = 1000
        SiticoneButton_ragpath.Name = "SiticoneButton_ragpath"
        SiticoneButton_ragpath.NormalFontStyle = FontStyle.Regular
        SiticoneButton_ragpath.ParticleColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        SiticoneButton_ragpath.ParticleCount = 15
        SiticoneButton_ragpath.PressAnimationScale = 0.97F
        SiticoneButton_ragpath.PressedBackColor = Color.FromArgb(CByte(74), CByte(128), CByte(235))
        SiticoneButton_ragpath.PressedFontStyle = FontStyle.Regular
        SiticoneButton_ragpath.PressTransitionDuration = 150
        SiticoneButton_ragpath.ReadOnlyTextColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        SiticoneButton_ragpath.RippleColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        SiticoneButton_ragpath.RippleOpacity = 0.3F
        SiticoneButton_ragpath.RippleRadiusMultiplier = 0.6F
        SiticoneButton_ragpath.ShadowBlur = 5
        SiticoneButton_ragpath.ShadowColor = Color.FromArgb(CByte(100), CByte(0), CByte(0), CByte(0))
        SiticoneButton_ragpath.ShadowOffset = New Point(2, 2)
        SiticoneButton_ragpath.ShakeDuration = 500
        SiticoneButton_ragpath.ShakeIntensity = 5
        SiticoneButton_ragpath.Size = New Size(42, 30)
        SiticoneButton_ragpath.TabIndex = 50
        SiticoneButton_ragpath.Text = "..."
        SiticoneButton_ragpath.TextAlign = ContentAlignment.MiddleCenter
        SiticoneButton_ragpath.TextColor = Color.White
        SiticoneButton_ragpath.TooltipText = Nothing
        SiticoneButton_ragpath.UseAdvancedRendering = True
        SiticoneButton_ragpath.UseParticles = False
        ' 
        ' SiticoneLabel1_ragpath
        ' 
        SiticoneLabel1_ragpath.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        SiticoneLabel1_ragpath.BackColor = Color.Transparent
        SiticoneLabel1_ragpath.Font = New Font("Segoe UI", 10F)
        SiticoneLabel1_ragpath.Location = New Point(6, 496)
        SiticoneLabel1_ragpath.Name = "SiticoneLabel1_ragpath"
        SiticoneLabel1_ragpath.Size = New Size(82, 21)
        SiticoneLabel1_ragpath.TabIndex = 49
        SiticoneLabel1_ragpath.Text = "Source File:"
        ' 
        ' SiticoneTextBox_ragpath
        ' 
        SiticoneTextBox_ragpath.AccessibleDescription = "A customizable text input field."
        SiticoneTextBox_ragpath.AccessibleName = "Text Box"
        SiticoneTextBox_ragpath.AccessibleRole = AccessibleRole.Text
        SiticoneTextBox_ragpath.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        SiticoneTextBox_ragpath.BackColor = Color.Transparent
        SiticoneTextBox_ragpath.BlinkCount = 3
        SiticoneTextBox_ragpath.BlinkShadow = False
        SiticoneTextBox_ragpath.BorderColor1 = Color.LightSlateGray
        SiticoneTextBox_ragpath.BorderColor2 = Color.LightSlateGray
        SiticoneTextBox_ragpath.BorderFocusColor1 = Color.FromArgb(CByte(77), CByte(77), CByte(255))
        SiticoneTextBox_ragpath.BorderFocusColor2 = Color.FromArgb(CByte(77), CByte(77), CByte(255))
        SiticoneTextBox_ragpath.CanShake = True
        SiticoneTextBox_ragpath.ContinuousBlink = False
        SiticoneTextBox_ragpath.CornerRadiusBottomLeft = 8
        SiticoneTextBox_ragpath.CornerRadiusBottomRight = 8
        SiticoneTextBox_ragpath.CornerRadiusTopLeft = 8
        SiticoneTextBox_ragpath.CornerRadiusTopRight = 8
        SiticoneTextBox_ragpath.CursorBlinkRate = 500
        SiticoneTextBox_ragpath.CursorColor = Color.Black
        SiticoneTextBox_ragpath.CursorHeight = 30
        SiticoneTextBox_ragpath.CursorOffset = 0
        SiticoneTextBox_ragpath.CursorStyle = SiticoneNetCoreUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid
        SiticoneTextBox_ragpath.CursorWidth = 1
        SiticoneTextBox_ragpath.DisabledBackColor = Color.WhiteSmoke
        SiticoneTextBox_ragpath.DisabledBorderColor = Color.LightGray
        SiticoneTextBox_ragpath.DisabledTextColor = Color.Gray
        SiticoneTextBox_ragpath.Enabled = False
        SiticoneTextBox_ragpath.EnableDropShadow = False
        SiticoneTextBox_ragpath.FillColor1 = Color.White
        SiticoneTextBox_ragpath.FillColor2 = Color.White
        SiticoneTextBox_ragpath.Font = New Font("Segoe UI", 9.5F)
        SiticoneTextBox_ragpath.ForeColor = Color.DimGray
        SiticoneTextBox_ragpath.HoverBorderColor1 = Color.Gray
        SiticoneTextBox_ragpath.HoverBorderColor2 = Color.Gray
        SiticoneTextBox_ragpath.IsEnabled = True
        SiticoneTextBox_ragpath.Location = New Point(94, 491)
        SiticoneTextBox_ragpath.Name = "SiticoneTextBox_ragpath"
        SiticoneTextBox_ragpath.PlaceholderColor = Color.Gray
        SiticoneTextBox_ragpath.PlaceholderText = "Select a source file"
        SiticoneTextBox_ragpath.ReadOnlyBorderColor1 = Color.LightGray
        SiticoneTextBox_ragpath.ReadOnlyBorderColor2 = Color.LightGray
        SiticoneTextBox_ragpath.ReadOnlyFillColor1 = Color.WhiteSmoke
        SiticoneTextBox_ragpath.ReadOnlyFillColor2 = Color.WhiteSmoke
        SiticoneTextBox_ragpath.ReadOnlyPlaceholderColor = Color.DarkGray
        SiticoneTextBox_ragpath.SelectionBackColor = Color.FromArgb(CByte(77), CByte(77), CByte(255))
        SiticoneTextBox_ragpath.ShadowAnimationDuration = 1
        SiticoneTextBox_ragpath.ShadowBlur = 10
        SiticoneTextBox_ragpath.ShadowColor = Color.FromArgb(CByte(15), CByte(0), CByte(0), CByte(0))
        SiticoneTextBox_ragpath.Size = New Size(1137, 30)
        SiticoneTextBox_ragpath.SolidBorderColor = Color.LightSlateGray
        SiticoneTextBox_ragpath.SolidBorderFocusColor = Color.FromArgb(CByte(77), CByte(77), CByte(255))
        SiticoneTextBox_ragpath.SolidBorderHoverColor = Color.Gray
        SiticoneTextBox_ragpath.SolidFillColor = Color.White
        SiticoneTextBox_ragpath.TabIndex = 48
        SiticoneTextBox_ragpath.TextPadding = New Padding(16, 0, 6, 0)
        SiticoneTextBox_ragpath.ValidationErrorMessage = "Invalid input."
        SiticoneTextBox_ragpath.ValidationFunction = Nothing
        ' 
        ' TabPage_requestjson
        ' 
        TabPage_requestjson.BackColor = Color.White
        TabPage_requestjson.Controls.Add(Scintilla_Request_JSON)
        TabPage_requestjson.Location = New Point(4, 54)
        TabPage_requestjson.Name = "TabPage_requestjson"
        TabPage_requestjson.Padding = New Padding(3)
        TabPage_requestjson.Size = New Size(1407, 630)
        SiticoneTabControl_tab.SetTabImage(TabPage_requestjson, My.Resources.Resource_svg.Request_JSON)
        TabPage_requestjson.TabIndex = 1
        TabPage_requestjson.Text = "Request JSON"
        ' 
        ' Scintilla_Request_JSON
        ' 
        Scintilla_Request_JSON.AutocompleteListSelectedBackColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        Scintilla_Request_JSON.Dock = DockStyle.Fill
        Scintilla_Request_JSON.Font = New Font("Consolas", 10F)
        Scintilla_Request_JSON.LexerName = "json"
        Scintilla_Request_JSON.Location = New Point(3, 3)
        Scintilla_Request_JSON.Name = "Scintilla_Request_JSON"
        Scintilla_Request_JSON.ScrollWidth = 70
        Scintilla_Request_JSON.Size = New Size(1401, 624)
        Scintilla_Request_JSON.TabIndex = 69
        ' 
        ' TabPage_responsejson
        ' 
        TabPage_responsejson.BackColor = Color.White
        TabPage_responsejson.Controls.Add(Scintilla_Response_JSON)
        TabPage_responsejson.Location = New Point(4, 54)
        TabPage_responsejson.Name = "TabPage_responsejson"
        TabPage_responsejson.Padding = New Padding(3)
        TabPage_responsejson.Size = New Size(1407, 630)
        SiticoneTabControl_tab.SetTabImage(TabPage_responsejson, My.Resources.Resource_svg.Response_JSON)
        TabPage_responsejson.TabIndex = 2
        TabPage_responsejson.Text = "Response JSON"
        ' 
        ' Scintilla_Response_JSON
        ' 
        Scintilla_Response_JSON.AutocompleteListSelectedBackColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        Scintilla_Response_JSON.Dock = DockStyle.Fill
        Scintilla_Response_JSON.Font = New Font("Consolas", 10F)
        Scintilla_Response_JSON.LexerName = "json"
        Scintilla_Response_JSON.Location = New Point(3, 3)
        Scintilla_Response_JSON.Name = "Scintilla_Response_JSON"
        Scintilla_Response_JSON.ScrollWidth = 70
        Scintilla_Response_JSON.Size = New Size(1401, 624)
        Scintilla_Response_JSON.TabIndex = 70
        ' 
        ' TabPage_responsemd
        ' 
        TabPage_responsemd.BackColor = Color.White
        TabPage_responsemd.Controls.Add(Scintilla_response)
        TabPage_responsemd.Location = New Point(4, 54)
        TabPage_responsemd.Name = "TabPage_responsemd"
        TabPage_responsemd.Padding = New Padding(3)
        TabPage_responsemd.Size = New Size(1407, 630)
        SiticoneTabControl_tab.SetTabImage(TabPage_responsemd, My.Resources.Resource_svg.Response_MD)
        TabPage_responsemd.TabIndex = 3
        TabPage_responsemd.Text = "Response MD"
        ' 
        ' Scintilla_response
        ' 
        Scintilla_response.AutocompleteListSelectedBackColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        Scintilla_response.Dock = DockStyle.Fill
        Scintilla_response.Font = New Font("Consolas", 10F)
        Scintilla_response.LexerName = "markdown"
        Scintilla_response.Location = New Point(3, 3)
        Scintilla_response.Name = "Scintilla_response"
        Scintilla_response.ScrollWidth = 70
        Scintilla_response.Size = New Size(1401, 624)
        Scintilla_response.TabIndex = 71
        ' 
        ' TabPage_responsehtml
        ' 
        TabPage_responsehtml.BackColor = Color.White
        TabPage_responsehtml.Controls.Add(WebView21)
        TabPage_responsehtml.Location = New Point(4, 54)
        TabPage_responsehtml.Name = "TabPage_responsehtml"
        TabPage_responsehtml.Padding = New Padding(3)
        TabPage_responsehtml.Size = New Size(1407, 630)
        SiticoneTabControl_tab.SetTabImage(TabPage_responsehtml, My.Resources.Resource_svg.Response_HTML)
        TabPage_responsehtml.TabIndex = 4
        TabPage_responsehtml.Text = "Response HTML"
        ' 
        ' TabPage_codeparameter
        ' 
        TabPage_codeparameter.BackColor = Color.WhiteSmoke
        TabPage_codeparameter.Controls.Add(SiticoneButton_link_execute_list)
        TabPage_codeparameter.Controls.Add(SiticoneButton_load_execute)
        TabPage_codeparameter.Controls.Add(SiticoneButton_save_execute)
        TabPage_codeparameter.Controls.Add(dvg_execute)
        TabPage_codeparameter.Controls.Add(SiticoneLabel2)
        TabPage_codeparameter.Location = New Point(4, 54)
        TabPage_codeparameter.Name = "TabPage_codeparameter"
        TabPage_codeparameter.Padding = New Padding(3)
        TabPage_codeparameter.Size = New Size(1407, 630)
        SiticoneTabControl_tab.SetTabImage(TabPage_codeparameter, My.Resources.Resource_svg.Code_Parameter)
        TabPage_codeparameter.TabIndex = 7
        TabPage_codeparameter.Text = "Code Parameter"
        ' 
        ' SiticoneButton_link_execute_list
        ' 
        SiticoneButton_link_execute_list.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard"
        SiticoneButton_link_execute_list.AccessibleName = ""
        SiticoneButton_link_execute_list.AutoSizeBasedOnText = False
        SiticoneButton_link_execute_list.BackColor = Color.Transparent
        SiticoneButton_link_execute_list.BadgeBackColor = Color.Red
        SiticoneButton_link_execute_list.BadgeFont = New Font("Segoe UI", 8F, FontStyle.Bold)
        SiticoneButton_link_execute_list.BadgeValue = 0
        SiticoneButton_link_execute_list.BadgeValueForeColor = Color.White
        SiticoneButton_link_execute_list.BorderColor = Color.Gray
        SiticoneButton_link_execute_list.BorderWidth = 2
        SiticoneButton_link_execute_list.ButtonBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        SiticoneButton_link_execute_list.ButtonImage = My.Resources.Resource_pic.help_16
        SiticoneButton_link_execute_list.ButtonTextLeftPadding = 0
        SiticoneButton_link_execute_list.CanBeep = True
        SiticoneButton_link_execute_list.CanGlow = False
        SiticoneButton_link_execute_list.CanShake = True
        SiticoneButton_link_execute_list.ContextMenuStripEx = Nothing
        SiticoneButton_link_execute_list.CornerRadiusBottomLeft = 8
        SiticoneButton_link_execute_list.CornerRadiusBottomRight = 8
        SiticoneButton_link_execute_list.CornerRadiusTopLeft = 8
        SiticoneButton_link_execute_list.CornerRadiusTopRight = 8
        SiticoneButton_link_execute_list.CustomCursor = Cursors.Default
        SiticoneButton_link_execute_list.DisabledTextColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        SiticoneButton_link_execute_list.EnableLongPress = False
        SiticoneButton_link_execute_list.EnablePressAnimation = True
        SiticoneButton_link_execute_list.EnableRippleEffect = True
        SiticoneButton_link_execute_list.EnableShadow = False
        SiticoneButton_link_execute_list.EnableTextWrapping = False
        SiticoneButton_link_execute_list.Font = New Font("Segoe UI", 9F)
        SiticoneButton_link_execute_list.GlowColor = Color.FromArgb(CByte(100), CByte(255), CByte(255), CByte(255))
        SiticoneButton_link_execute_list.GlowIntensity = 100
        SiticoneButton_link_execute_list.GlowRadius = 20F
        SiticoneButton_link_execute_list.GradientBackground = False
        SiticoneButton_link_execute_list.GradientColor = Color.Gray
        SiticoneButton_link_execute_list.GradientMode = Drawing2D.LinearGradientMode.Vertical
        SiticoneButton_link_execute_list.HintText = Nothing
        SiticoneButton_link_execute_list.HoverBackColor = Color.Silver
        SiticoneButton_link_execute_list.HoverFontStyle = FontStyle.Regular
        SiticoneButton_link_execute_list.HoverTextColor = Color.White
        SiticoneButton_link_execute_list.HoverTransitionDuration = 250
        SiticoneButton_link_execute_list.ImageAlign = ContentAlignment.MiddleCenter
        SiticoneButton_link_execute_list.ImagePadding = 5
        SiticoneButton_link_execute_list.ImageSize = New Size(16, 16)
        SiticoneButton_link_execute_list.IsRadial = False
        SiticoneButton_link_execute_list.IsReadOnly = False
        SiticoneButton_link_execute_list.IsToggleButton = False
        SiticoneButton_link_execute_list.IsToggled = False
        SiticoneButton_link_execute_list.Location = New Point(8, 6)
        SiticoneButton_link_execute_list.LongPressDurationMS = 1000
        SiticoneButton_link_execute_list.Name = "SiticoneButton_link_execute_list"
        SiticoneButton_link_execute_list.NormalFontStyle = FontStyle.Regular
        SiticoneButton_link_execute_list.ParticleColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        SiticoneButton_link_execute_list.ParticleCount = 15
        SiticoneButton_link_execute_list.PressAnimationScale = 0.97F
        SiticoneButton_link_execute_list.PressedBackColor = Color.FromArgb(CByte(74), CByte(128), CByte(235))
        SiticoneButton_link_execute_list.PressedFontStyle = FontStyle.Regular
        SiticoneButton_link_execute_list.PressTransitionDuration = 150
        SiticoneButton_link_execute_list.ReadOnlyTextColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        SiticoneButton_link_execute_list.RippleColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        SiticoneButton_link_execute_list.RippleOpacity = 0.3F
        SiticoneButton_link_execute_list.RippleRadiusMultiplier = 0.6F
        SiticoneButton_link_execute_list.ShadowBlur = 5
        SiticoneButton_link_execute_list.ShadowColor = Color.FromArgb(CByte(100), CByte(0), CByte(0), CByte(0))
        SiticoneButton_link_execute_list.ShadowOffset = New Point(2, 2)
        SiticoneButton_link_execute_list.ShakeDuration = 500
        SiticoneButton_link_execute_list.ShakeIntensity = 5
        SiticoneButton_link_execute_list.Size = New Size(30, 24)
        SiticoneButton_link_execute_list.TabIndex = 68
        SiticoneButton_link_execute_list.TextAlign = ContentAlignment.MiddleCenter
        SiticoneButton_link_execute_list.TextColor = Color.White
        ToolTip1.SetToolTip(SiticoneButton_link_execute_list, "Help")
        SiticoneButton_link_execute_list.TooltipText = Nothing
        SiticoneButton_link_execute_list.UseAdvancedRendering = True
        SiticoneButton_link_execute_list.UseParticles = False
        ' 
        ' SiticoneButton_load_execute
        ' 
        SiticoneButton_load_execute.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard"
        SiticoneButton_load_execute.AccessibleName = "Load Parameter"
        SiticoneButton_load_execute.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        SiticoneButton_load_execute.AutoSizeBasedOnText = False
        SiticoneButton_load_execute.BackColor = Color.Transparent
        SiticoneButton_load_execute.BadgeBackColor = Color.Red
        SiticoneButton_load_execute.BadgeFont = New Font("Segoe UI", 8F, FontStyle.Bold)
        SiticoneButton_load_execute.BadgeValue = 0
        SiticoneButton_load_execute.BadgeValueForeColor = Color.White
        SiticoneButton_load_execute.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        SiticoneButton_load_execute.BorderWidth = 2
        SiticoneButton_load_execute.ButtonBackColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        SiticoneButton_load_execute.ButtonImage = Nothing
        SiticoneButton_load_execute.ButtonTextLeftPadding = 0
        SiticoneButton_load_execute.CanBeep = True
        SiticoneButton_load_execute.CanGlow = False
        SiticoneButton_load_execute.CanShake = True
        SiticoneButton_load_execute.ContextMenuStripEx = Nothing
        SiticoneButton_load_execute.CornerRadiusBottomLeft = 8
        SiticoneButton_load_execute.CornerRadiusBottomRight = 8
        SiticoneButton_load_execute.CornerRadiusTopLeft = 8
        SiticoneButton_load_execute.CornerRadiusTopRight = 8
        SiticoneButton_load_execute.CustomCursor = Cursors.Default
        SiticoneButton_load_execute.DisabledTextColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        SiticoneButton_load_execute.EnableLongPress = False
        SiticoneButton_load_execute.EnablePressAnimation = True
        SiticoneButton_load_execute.EnableRippleEffect = True
        SiticoneButton_load_execute.EnableShadow = False
        SiticoneButton_load_execute.EnableTextWrapping = False
        SiticoneButton_load_execute.Font = New Font("Segoe UI", 9F)
        SiticoneButton_load_execute.GlowColor = Color.FromArgb(CByte(100), CByte(255), CByte(255), CByte(255))
        SiticoneButton_load_execute.GlowIntensity = 100
        SiticoneButton_load_execute.GlowRadius = 20F
        SiticoneButton_load_execute.GradientBackground = False
        SiticoneButton_load_execute.GradientColor = Color.FromArgb(CByte(114), CByte(168), CByte(255))
        SiticoneButton_load_execute.GradientMode = Drawing2D.LinearGradientMode.Vertical
        SiticoneButton_load_execute.HintText = Nothing
        SiticoneButton_load_execute.HoverBackColor = Color.FromArgb(CByte(114), CByte(168), CByte(255))
        SiticoneButton_load_execute.HoverFontStyle = FontStyle.Regular
        SiticoneButton_load_execute.HoverTextColor = Color.White
        SiticoneButton_load_execute.HoverTransitionDuration = 250
        SiticoneButton_load_execute.ImageAlign = ContentAlignment.MiddleLeft
        SiticoneButton_load_execute.ImagePadding = 5
        SiticoneButton_load_execute.ImageSize = New Size(16, 16)
        SiticoneButton_load_execute.IsRadial = False
        SiticoneButton_load_execute.IsReadOnly = False
        SiticoneButton_load_execute.IsToggleButton = False
        SiticoneButton_load_execute.IsToggled = False
        SiticoneButton_load_execute.Location = New Point(1183, 600)
        SiticoneButton_load_execute.LongPressDurationMS = 1000
        SiticoneButton_load_execute.Name = "SiticoneButton_load_execute"
        SiticoneButton_load_execute.NormalFontStyle = FontStyle.Regular
        SiticoneButton_load_execute.ParticleColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        SiticoneButton_load_execute.ParticleCount = 15
        SiticoneButton_load_execute.PressAnimationScale = 0.97F
        SiticoneButton_load_execute.PressedBackColor = Color.FromArgb(CByte(74), CByte(128), CByte(235))
        SiticoneButton_load_execute.PressedFontStyle = FontStyle.Regular
        SiticoneButton_load_execute.PressTransitionDuration = 150
        SiticoneButton_load_execute.ReadOnlyTextColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        SiticoneButton_load_execute.RippleColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        SiticoneButton_load_execute.RippleOpacity = 0.3F
        SiticoneButton_load_execute.RippleRadiusMultiplier = 0.6F
        SiticoneButton_load_execute.ShadowBlur = 5
        SiticoneButton_load_execute.ShadowColor = Color.FromArgb(CByte(100), CByte(0), CByte(0), CByte(0))
        SiticoneButton_load_execute.ShadowOffset = New Point(2, 2)
        SiticoneButton_load_execute.ShakeDuration = 500
        SiticoneButton_load_execute.ShakeIntensity = 5
        SiticoneButton_load_execute.Size = New Size(107, 24)
        SiticoneButton_load_execute.TabIndex = 37
        SiticoneButton_load_execute.Text = "Load Parameter"
        SiticoneButton_load_execute.TextAlign = ContentAlignment.MiddleCenter
        SiticoneButton_load_execute.TextColor = Color.White
        SiticoneButton_load_execute.TooltipText = Nothing
        SiticoneButton_load_execute.UseAdvancedRendering = True
        SiticoneButton_load_execute.UseParticles = False
        ' 
        ' SiticoneButton_save_execute
        ' 
        SiticoneButton_save_execute.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard"
        SiticoneButton_save_execute.AccessibleName = "Save Parameter"
        SiticoneButton_save_execute.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        SiticoneButton_save_execute.AutoSizeBasedOnText = False
        SiticoneButton_save_execute.BackColor = Color.Transparent
        SiticoneButton_save_execute.BadgeBackColor = Color.Red
        SiticoneButton_save_execute.BadgeFont = New Font("Segoe UI", 8F, FontStyle.Bold)
        SiticoneButton_save_execute.BadgeValue = 0
        SiticoneButton_save_execute.BadgeValueForeColor = Color.White
        SiticoneButton_save_execute.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        SiticoneButton_save_execute.BorderWidth = 2
        SiticoneButton_save_execute.ButtonBackColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        SiticoneButton_save_execute.ButtonImage = Nothing
        SiticoneButton_save_execute.ButtonTextLeftPadding = 0
        SiticoneButton_save_execute.CanBeep = True
        SiticoneButton_save_execute.CanGlow = False
        SiticoneButton_save_execute.CanShake = True
        SiticoneButton_save_execute.ContextMenuStripEx = Nothing
        SiticoneButton_save_execute.CornerRadiusBottomLeft = 8
        SiticoneButton_save_execute.CornerRadiusBottomRight = 8
        SiticoneButton_save_execute.CornerRadiusTopLeft = 8
        SiticoneButton_save_execute.CornerRadiusTopRight = 8
        SiticoneButton_save_execute.CustomCursor = Cursors.Default
        SiticoneButton_save_execute.DisabledTextColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        SiticoneButton_save_execute.EnableLongPress = False
        SiticoneButton_save_execute.EnablePressAnimation = True
        SiticoneButton_save_execute.EnableRippleEffect = True
        SiticoneButton_save_execute.EnableShadow = False
        SiticoneButton_save_execute.EnableTextWrapping = False
        SiticoneButton_save_execute.Font = New Font("Segoe UI", 9F)
        SiticoneButton_save_execute.GlowColor = Color.FromArgb(CByte(100), CByte(255), CByte(255), CByte(255))
        SiticoneButton_save_execute.GlowIntensity = 100
        SiticoneButton_save_execute.GlowRadius = 20F
        SiticoneButton_save_execute.GradientBackground = False
        SiticoneButton_save_execute.GradientColor = Color.FromArgb(CByte(114), CByte(168), CByte(255))
        SiticoneButton_save_execute.GradientMode = Drawing2D.LinearGradientMode.Vertical
        SiticoneButton_save_execute.HintText = Nothing
        SiticoneButton_save_execute.HoverBackColor = Color.FromArgb(CByte(114), CByte(168), CByte(255))
        SiticoneButton_save_execute.HoverFontStyle = FontStyle.Regular
        SiticoneButton_save_execute.HoverTextColor = Color.White
        SiticoneButton_save_execute.HoverTransitionDuration = 250
        SiticoneButton_save_execute.ImageAlign = ContentAlignment.MiddleLeft
        SiticoneButton_save_execute.ImagePadding = 5
        SiticoneButton_save_execute.ImageSize = New Size(16, 16)
        SiticoneButton_save_execute.IsRadial = False
        SiticoneButton_save_execute.IsReadOnly = False
        SiticoneButton_save_execute.IsToggleButton = False
        SiticoneButton_save_execute.IsToggled = False
        SiticoneButton_save_execute.Location = New Point(1296, 600)
        SiticoneButton_save_execute.LongPressDurationMS = 1000
        SiticoneButton_save_execute.Name = "SiticoneButton_save_execute"
        SiticoneButton_save_execute.NormalFontStyle = FontStyle.Regular
        SiticoneButton_save_execute.ParticleColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        SiticoneButton_save_execute.ParticleCount = 15
        SiticoneButton_save_execute.PressAnimationScale = 0.97F
        SiticoneButton_save_execute.PressedBackColor = Color.FromArgb(CByte(74), CByte(128), CByte(235))
        SiticoneButton_save_execute.PressedFontStyle = FontStyle.Regular
        SiticoneButton_save_execute.PressTransitionDuration = 150
        SiticoneButton_save_execute.ReadOnlyTextColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        SiticoneButton_save_execute.RippleColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        SiticoneButton_save_execute.RippleOpacity = 0.3F
        SiticoneButton_save_execute.RippleRadiusMultiplier = 0.6F
        SiticoneButton_save_execute.ShadowBlur = 5
        SiticoneButton_save_execute.ShadowColor = Color.FromArgb(CByte(100), CByte(0), CByte(0), CByte(0))
        SiticoneButton_save_execute.ShadowOffset = New Point(2, 2)
        SiticoneButton_save_execute.ShakeDuration = 500
        SiticoneButton_save_execute.ShakeIntensity = 5
        SiticoneButton_save_execute.Size = New Size(107, 24)
        SiticoneButton_save_execute.TabIndex = 36
        SiticoneButton_save_execute.Text = "Save Parameter"
        SiticoneButton_save_execute.TextAlign = ContentAlignment.MiddleCenter
        SiticoneButton_save_execute.TextColor = Color.White
        SiticoneButton_save_execute.TooltipText = Nothing
        SiticoneButton_save_execute.UseAdvancedRendering = True
        SiticoneButton_save_execute.UseParticles = False
        ' 
        ' dvg_execute
        ' 
        dvg_execute.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dvg_execute.BackgroundColor = Color.White
        dvg_execute.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dvg_execute.Location = New Point(8, 31)
        dvg_execute.Name = "dvg_execute"
        dvg_execute.Size = New Size(1391, 563)
        dvg_execute.TabIndex = 33
        ' 
        ' SiticoneLabel2
        ' 
        SiticoneLabel2.BackColor = Color.Transparent
        SiticoneLabel2.Font = New Font("Segoe UI", 10F)
        SiticoneLabel2.Location = New Point(44, 9)
        SiticoneLabel2.Name = "SiticoneLabel2"
        SiticoneLabel2.Size = New Size(171, 21)
        SiticoneLabel2.TabIndex = 31
        SiticoneLabel2.Text = "Execute List:"
        ' 
        ' TabPage_codeblock
        ' 
        TabPage_codeblock.BackColor = Color.WhiteSmoke
        TabPage_codeblock.Controls.Add(SiticoneFlatPanel_UseShellExecute)
        TabPage_codeblock.Controls.Add(SiticoneButton_execute_run)
        TabPage_codeblock.Controls.Add(SiticoneButton_code_save)
        TabPage_codeblock.Controls.Add(SiticoneLabel_runpath)
        TabPage_codeblock.Controls.Add(SiticoneSplitContainer_runcont)
        TabPage_codeblock.Controls.Add(SiticoneButton_code_run)
        TabPage_codeblock.Controls.Add(SiticoneDropdown_language)
        TabPage_codeblock.Location = New Point(4, 54)
        TabPage_codeblock.Name = "TabPage_codeblock"
        TabPage_codeblock.Size = New Size(1407, 630)
        SiticoneTabControl_tab.SetTabImage(TabPage_codeblock, My.Resources.Resource_svg.Code_Block)
        TabPage_codeblock.TabIndex = 6
        TabPage_codeblock.Text = "Code Block"
        ' 
        ' SiticoneFlatPanel_UseShellExecute
        ' 
        SiticoneFlatPanel_UseShellExecute.BackColor = Color.Transparent
        SiticoneFlatPanel_UseShellExecute.Controls.Add(SiticoneLabel_UseShellExecute)
        SiticoneFlatPanel_UseShellExecute.Controls.Add(SiticoneToggleSwitch_UseShellExecute)
        SiticoneFlatPanel_UseShellExecute.Location = New Point(412, 5)
        SiticoneFlatPanel_UseShellExecute.MinimumSize = New Size(20, 20)
        SiticoneFlatPanel_UseShellExecute.Name = "SiticoneFlatPanel_UseShellExecute"
        SiticoneFlatPanel_UseShellExecute.Size = New Size(179, 25)
        SiticoneFlatPanel_UseShellExecute.TabIndex = 70
        ' 
        ' SiticoneLabel_UseShellExecute
        ' 
        SiticoneLabel_UseShellExecute.BackColor = Color.Transparent
        SiticoneLabel_UseShellExecute.Dock = DockStyle.Right
        SiticoneLabel_UseShellExecute.Font = New Font("Segoe UI", 10F)
        SiticoneLabel_UseShellExecute.Location = New Point(60, 0)
        SiticoneLabel_UseShellExecute.Name = "SiticoneLabel_UseShellExecute"
        SiticoneLabel_UseShellExecute.Size = New Size(119, 25)
        SiticoneLabel_UseShellExecute.TabIndex = 55
        SiticoneLabel_UseShellExecute.Text = "Use Shell Execute"
        SiticoneLabel_UseShellExecute.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' SiticoneToggleSwitch_UseShellExecute
        ' 
        SiticoneToggleSwitch_UseShellExecute.AccessibleDescription = "A customizable toggle switch that can be turned on or off."
        SiticoneToggleSwitch_UseShellExecute.AccessibleName = "Siticone Toggle Switch"
        SiticoneToggleSwitch_UseShellExecute.AccessibleRole = AccessibleRole.CheckButton
        SiticoneToggleSwitch_UseShellExecute.CanBeep = True
        SiticoneToggleSwitch_UseShellExecute.CanShake = True
        SiticoneToggleSwitch_UseShellExecute.DisabledColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        SiticoneToggleSwitch_UseShellExecute.DisallowToggling = False
        SiticoneToggleSwitch_UseShellExecute.Dock = DockStyle.Left
        SiticoneToggleSwitch_UseShellExecute.EnableGlowEffect = True
        SiticoneToggleSwitch_UseShellExecute.ExtraThumbSize = 2
        SiticoneToggleSwitch_UseShellExecute.IsOn = False
        SiticoneToggleSwitch_UseShellExecute.IsReadOnly = False
        SiticoneToggleSwitch_UseShellExecute.IsRequired = False
        SiticoneToggleSwitch_UseShellExecute.LabelColor = Color.Black
        SiticoneToggleSwitch_UseShellExecute.LabelFont = New Font("Segoe UI", 9F)
        SiticoneToggleSwitch_UseShellExecute.Location = New Point(0, 0)
        SiticoneToggleSwitch_UseShellExecute.Logger = Nothing
        SiticoneToggleSwitch_UseShellExecute.Name = "SiticoneToggleSwitch_UseShellExecute"
        SiticoneToggleSwitch_UseShellExecute.OffBackColor1 = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        SiticoneToggleSwitch_UseShellExecute.OffBackColor2 = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        SiticoneToggleSwitch_UseShellExecute.OffBorderColor1 = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        SiticoneToggleSwitch_UseShellExecute.OffBorderColor2 = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        SiticoneToggleSwitch_UseShellExecute.OffIcon = Nothing
        SiticoneToggleSwitch_UseShellExecute.OffThumbColor1 = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        SiticoneToggleSwitch_UseShellExecute.OffThumbColor2 = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        SiticoneToggleSwitch_UseShellExecute.OnBackColor1 = Color.FromArgb(CByte(26), CByte(115), CByte(232))
        SiticoneToggleSwitch_UseShellExecute.OnBackColor2 = Color.FromArgb(CByte(26), CByte(115), CByte(232))
        SiticoneToggleSwitch_UseShellExecute.OnBorderColor1 = Color.FromArgb(CByte(26), CByte(115), CByte(232))
        SiticoneToggleSwitch_UseShellExecute.OnBorderColor2 = Color.FromArgb(CByte(26), CByte(115), CByte(232))
        SiticoneToggleSwitch_UseShellExecute.OnIcon = Nothing
        SiticoneToggleSwitch_UseShellExecute.OnThumbColor1 = Color.White
        SiticoneToggleSwitch_UseShellExecute.OnThumbColor2 = Color.White
        SiticoneToggleSwitch_UseShellExecute.PreventToggleOff = False
        SiticoneToggleSwitch_UseShellExecute.RippleColor = Color.FromArgb(CByte(100), CByte(255), CByte(255), CByte(255))
        SiticoneToggleSwitch_UseShellExecute.RippleExpansionRate = 2F
        SiticoneToggleSwitch_UseShellExecute.RippleOpacityDecay = 0.02F
        SiticoneToggleSwitch_UseShellExecute.Size = New Size(50, 25)
        SiticoneToggleSwitch_UseShellExecute.TabIndex = 54
        SiticoneToggleSwitch_UseShellExecute.ToggleOffSoundPath = ""
        SiticoneToggleSwitch_UseShellExecute.ToggleOnSoundPath = ""
        SiticoneToggleSwitch_UseShellExecute.ToolTipText = ""
        SiticoneToggleSwitch_UseShellExecute.TrackDeviceTheme = True
        ' 
        ' SiticoneButton_execute_run
        ' 
        SiticoneButton_execute_run.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard"
        SiticoneButton_execute_run.AccessibleName = ""
        SiticoneButton_execute_run.AutoSizeBasedOnText = False
        SiticoneButton_execute_run.BackColor = Color.Transparent
        SiticoneButton_execute_run.BadgeBackColor = Color.Red
        SiticoneButton_execute_run.BadgeFont = New Font("Segoe UI", 8F, FontStyle.Bold)
        SiticoneButton_execute_run.BadgeValue = 0
        SiticoneButton_execute_run.BadgeValueForeColor = Color.White
        SiticoneButton_execute_run.BorderColor = Color.Gray
        SiticoneButton_execute_run.BorderWidth = 2
        SiticoneButton_execute_run.ButtonBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        SiticoneButton_execute_run.ButtonImage = My.Resources.Resource_pic.help_16
        SiticoneButton_execute_run.ButtonTextLeftPadding = 0
        SiticoneButton_execute_run.CanBeep = True
        SiticoneButton_execute_run.CanGlow = False
        SiticoneButton_execute_run.CanShake = True
        SiticoneButton_execute_run.ContextMenuStripEx = Nothing
        SiticoneButton_execute_run.CornerRadiusBottomLeft = 8
        SiticoneButton_execute_run.CornerRadiusBottomRight = 8
        SiticoneButton_execute_run.CornerRadiusTopLeft = 8
        SiticoneButton_execute_run.CornerRadiusTopRight = 8
        SiticoneButton_execute_run.CustomCursor = Cursors.Default
        SiticoneButton_execute_run.DisabledTextColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        SiticoneButton_execute_run.EnableLongPress = False
        SiticoneButton_execute_run.EnablePressAnimation = True
        SiticoneButton_execute_run.EnableRippleEffect = True
        SiticoneButton_execute_run.EnableShadow = False
        SiticoneButton_execute_run.EnableTextWrapping = False
        SiticoneButton_execute_run.Font = New Font("Segoe UI", 9F)
        SiticoneButton_execute_run.GlowColor = Color.FromArgb(CByte(100), CByte(255), CByte(255), CByte(255))
        SiticoneButton_execute_run.GlowIntensity = 100
        SiticoneButton_execute_run.GlowRadius = 20F
        SiticoneButton_execute_run.GradientBackground = False
        SiticoneButton_execute_run.GradientColor = Color.Gray
        SiticoneButton_execute_run.GradientMode = Drawing2D.LinearGradientMode.Vertical
        SiticoneButton_execute_run.HintText = Nothing
        SiticoneButton_execute_run.HoverBackColor = Color.Silver
        SiticoneButton_execute_run.HoverFontStyle = FontStyle.Regular
        SiticoneButton_execute_run.HoverTextColor = Color.White
        SiticoneButton_execute_run.HoverTransitionDuration = 250
        SiticoneButton_execute_run.ImageAlign = ContentAlignment.MiddleCenter
        SiticoneButton_execute_run.ImagePadding = 5
        SiticoneButton_execute_run.ImageSize = New Size(16, 16)
        SiticoneButton_execute_run.IsRadial = False
        SiticoneButton_execute_run.IsReadOnly = False
        SiticoneButton_execute_run.IsToggleButton = False
        SiticoneButton_execute_run.IsToggled = False
        SiticoneButton_execute_run.Location = New Point(8, 6)
        SiticoneButton_execute_run.LongPressDurationMS = 1000
        SiticoneButton_execute_run.Name = "SiticoneButton_execute_run"
        SiticoneButton_execute_run.NormalFontStyle = FontStyle.Regular
        SiticoneButton_execute_run.ParticleColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        SiticoneButton_execute_run.ParticleCount = 15
        SiticoneButton_execute_run.PressAnimationScale = 0.97F
        SiticoneButton_execute_run.PressedBackColor = Color.FromArgb(CByte(74), CByte(128), CByte(235))
        SiticoneButton_execute_run.PressedFontStyle = FontStyle.Regular
        SiticoneButton_execute_run.PressTransitionDuration = 150
        SiticoneButton_execute_run.ReadOnlyTextColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        SiticoneButton_execute_run.RippleColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        SiticoneButton_execute_run.RippleOpacity = 0.3F
        SiticoneButton_execute_run.RippleRadiusMultiplier = 0.6F
        SiticoneButton_execute_run.ShadowBlur = 5
        SiticoneButton_execute_run.ShadowColor = Color.FromArgb(CByte(100), CByte(0), CByte(0), CByte(0))
        SiticoneButton_execute_run.ShadowOffset = New Point(2, 2)
        SiticoneButton_execute_run.ShakeDuration = 500
        SiticoneButton_execute_run.ShakeIntensity = 5
        SiticoneButton_execute_run.Size = New Size(30, 24)
        SiticoneButton_execute_run.TabIndex = 69
        SiticoneButton_execute_run.TextAlign = ContentAlignment.MiddleCenter
        SiticoneButton_execute_run.TextColor = Color.White
        ToolTip1.SetToolTip(SiticoneButton_execute_run, "Help")
        SiticoneButton_execute_run.TooltipText = Nothing
        SiticoneButton_execute_run.UseAdvancedRendering = True
        SiticoneButton_execute_run.UseParticles = False
        ' 
        ' SiticoneButton_code_save
        ' 
        SiticoneButton_code_save.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard"
        SiticoneButton_code_save.AccessibleName = "Save Code"
        SiticoneButton_code_save.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        SiticoneButton_code_save.AutoSizeBasedOnText = False
        SiticoneButton_code_save.BackColor = Color.Transparent
        SiticoneButton_code_save.BadgeBackColor = Color.Red
        SiticoneButton_code_save.BadgeFont = New Font("Segoe UI", 8F, FontStyle.Bold)
        SiticoneButton_code_save.BadgeValue = 0
        SiticoneButton_code_save.BadgeValueForeColor = Color.White
        SiticoneButton_code_save.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        SiticoneButton_code_save.BorderWidth = 2
        SiticoneButton_code_save.ButtonBackColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        SiticoneButton_code_save.ButtonImage = Nothing
        SiticoneButton_code_save.ButtonTextLeftPadding = 0
        SiticoneButton_code_save.CanBeep = True
        SiticoneButton_code_save.CanGlow = False
        SiticoneButton_code_save.CanShake = True
        SiticoneButton_code_save.ContextMenuStripEx = Nothing
        SiticoneButton_code_save.CornerRadiusBottomLeft = 8
        SiticoneButton_code_save.CornerRadiusBottomRight = 8
        SiticoneButton_code_save.CornerRadiusTopLeft = 8
        SiticoneButton_code_save.CornerRadiusTopRight = 8
        SiticoneButton_code_save.CustomCursor = Cursors.Default
        SiticoneButton_code_save.DisabledTextColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        SiticoneButton_code_save.Enabled = False
        SiticoneButton_code_save.EnableLongPress = False
        SiticoneButton_code_save.EnablePressAnimation = True
        SiticoneButton_code_save.EnableRippleEffect = True
        SiticoneButton_code_save.EnableShadow = False
        SiticoneButton_code_save.EnableTextWrapping = False
        SiticoneButton_code_save.Font = New Font("Segoe UI", 9F)
        SiticoneButton_code_save.GlowColor = Color.FromArgb(CByte(100), CByte(255), CByte(255), CByte(255))
        SiticoneButton_code_save.GlowIntensity = 100
        SiticoneButton_code_save.GlowRadius = 20F
        SiticoneButton_code_save.GradientBackground = False
        SiticoneButton_code_save.GradientColor = Color.FromArgb(CByte(114), CByte(168), CByte(255))
        SiticoneButton_code_save.GradientMode = Drawing2D.LinearGradientMode.Vertical
        SiticoneButton_code_save.HintText = Nothing
        SiticoneButton_code_save.HoverBackColor = Color.FromArgb(CByte(114), CByte(168), CByte(255))
        SiticoneButton_code_save.HoverFontStyle = FontStyle.Regular
        SiticoneButton_code_save.HoverTextColor = Color.White
        SiticoneButton_code_save.HoverTransitionDuration = 250
        SiticoneButton_code_save.ImageAlign = ContentAlignment.MiddleLeft
        SiticoneButton_code_save.ImagePadding = 5
        SiticoneButton_code_save.ImageSize = New Size(16, 16)
        SiticoneButton_code_save.IsRadial = False
        SiticoneButton_code_save.IsReadOnly = False
        SiticoneButton_code_save.IsToggleButton = False
        SiticoneButton_code_save.IsToggled = False
        SiticoneButton_code_save.Location = New Point(1294, 6)
        SiticoneButton_code_save.LongPressDurationMS = 1000
        SiticoneButton_code_save.Name = "SiticoneButton_code_save"
        SiticoneButton_code_save.NormalFontStyle = FontStyle.Regular
        SiticoneButton_code_save.ParticleColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        SiticoneButton_code_save.ParticleCount = 15
        SiticoneButton_code_save.PressAnimationScale = 0.97F
        SiticoneButton_code_save.PressedBackColor = Color.FromArgb(CByte(74), CByte(128), CByte(235))
        SiticoneButton_code_save.PressedFontStyle = FontStyle.Regular
        SiticoneButton_code_save.PressTransitionDuration = 150
        SiticoneButton_code_save.ReadOnlyTextColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        SiticoneButton_code_save.RippleColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        SiticoneButton_code_save.RippleOpacity = 0.3F
        SiticoneButton_code_save.RippleRadiusMultiplier = 0.6F
        SiticoneButton_code_save.ShadowBlur = 5
        SiticoneButton_code_save.ShadowColor = Color.FromArgb(CByte(100), CByte(0), CByte(0), CByte(0))
        SiticoneButton_code_save.ShadowOffset = New Point(2, 2)
        SiticoneButton_code_save.ShakeDuration = 500
        SiticoneButton_code_save.ShakeIntensity = 5
        SiticoneButton_code_save.Size = New Size(107, 24)
        SiticoneButton_code_save.TabIndex = 32
        SiticoneButton_code_save.Text = "Save Code"
        SiticoneButton_code_save.TextAlign = ContentAlignment.MiddleCenter
        SiticoneButton_code_save.TextColor = Color.White
        SiticoneButton_code_save.TooltipText = Nothing
        SiticoneButton_code_save.UseAdvancedRendering = True
        SiticoneButton_code_save.UseParticles = False
        ' 
        ' SiticoneLabel_runpath
        ' 
        SiticoneLabel_runpath.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        SiticoneLabel_runpath.BackColor = Color.Transparent
        SiticoneLabel_runpath.Font = New Font("Segoe UI", 10F)
        SiticoneLabel_runpath.Location = New Point(596, 8)
        SiticoneLabel_runpath.Name = "SiticoneLabel_runpath"
        SiticoneLabel_runpath.Size = New Size(692, 23)
        SiticoneLabel_runpath.TabIndex = 31
        SiticoneLabel_runpath.Tag = ""
        SiticoneLabel_runpath.Text = "path:"
        ' 
        ' SiticoneSplitContainer_runcont
        ' 
        SiticoneSplitContainer_runcont.AccessibleDescription = "Allows resizing of two panels using a movable splitter"
        SiticoneSplitContainer_runcont.AccessibleName = "Split Container"
        SiticoneSplitContainer_runcont.AccessibleRole = AccessibleRole.Pane
        SiticoneSplitContainer_runcont.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        SiticoneSplitContainer_runcont.AnimationInterval = 15
        SiticoneSplitContainer_runcont.AnimationStep = 5
        SiticoneSplitContainer_runcont.AspectRatio = 1F
        SiticoneSplitContainer_runcont.AutoHideDelay = 2000
        SiticoneSplitContainer_runcont.BackColor = SystemColors.Control
        SiticoneSplitContainer_runcont.CollapseThreshold = 10
        SiticoneSplitContainer_runcont.DragUpdateInterval = 16
        SiticoneSplitContainer_runcont.EnableAnimatedSplitter = False
        SiticoneSplitContainer_runcont.EnableAutoHide = False
        SiticoneSplitContainer_runcont.EnableDynamicResizing = True
        SiticoneSplitContainer_runcont.EnableHotkeys = True
        SiticoneSplitContainer_runcont.EnableKeyboardNavigation = True
        SiticoneSplitContainer_runcont.EnablePanelCollapse = False
        SiticoneSplitContainer_runcont.EnablePanelReordering = False
        SiticoneSplitContainer_runcont.EnableSmoothDrag = False
        SiticoneSplitContainer_runcont.EnableSnapping = False
        SiticoneSplitContainer_runcont.EnableSplitterHighlight = True
        SiticoneSplitContainer_runcont.EnableSplitterLock = False
        SiticoneSplitContainer_runcont.EnableStateManagement = True
        SiticoneSplitContainer_runcont.FixedPanel = FixedPanel.Panel2
        SiticoneSplitContainer_runcont.IsSplitterLocked = False
        SiticoneSplitContainer_runcont.Location = New Point(5, 33)
        SiticoneSplitContainer_runcont.MaintainAspectRatio = False
        SiticoneSplitContainer_runcont.Name = "SiticoneSplitContainer_runcont"
        SiticoneSplitContainer_runcont.Orientation = Orientation.Horizontal
        ' 
        ' SiticoneSplitContainer_runcont.Panel1
        ' 
        SiticoneSplitContainer_runcont.Panel1.Controls.Add(Scintilla_code_block)
        SiticoneSplitContainer_runcont.Panel1Title = "Code:"
        ' 
        ' SiticoneSplitContainer_runcont.Panel2
        ' 
        SiticoneSplitContainer_runcont.Panel2.Controls.Add(SiticoneTextArea_run_output)
        SiticoneSplitContainer_runcont.Panel2Title = "Output:"
        SiticoneSplitContainer_runcont.ShowPanelHeaders = False
        SiticoneSplitContainer_runcont.Size = New Size(1399, 594)
        SiticoneSplitContainer_runcont.SnapDistance = 20
        SiticoneSplitContainer_runcont.SnapPositions = New Single() {0.25F, 0.5F, 0.75F}
        SiticoneSplitContainer_runcont.SplitterCursor = Cursors.HSplit
        SiticoneSplitContainer_runcont.SplitterDistance = 448
        SiticoneSplitContainer_runcont.SplitterHighlightColor = Color.DodgerBlue
        SiticoneSplitContainer_runcont.SplitterMoveable = True
        SiticoneSplitContainer_runcont.SplitterMoveLeftKey = Keys.Left
        SiticoneSplitContainer_runcont.SplitterMoveRightKey = Keys.Right
        SiticoneSplitContainer_runcont.SplitterPositionKey = "EnhancedSplitContainer_SplitterPosition"
        SiticoneSplitContainer_runcont.SplitterTexture = Nothing
        SiticoneSplitContainer_runcont.SwapPanelsHotkey = Keys.Control Or Keys.Alt Or Keys.S
        SiticoneSplitContainer_runcont.TabIndex = 29
        SiticoneSplitContainer_runcont.ToggleOrientationHotkey = Keys.Control Or Keys.Alt Or Keys.O
        ' 
        ' Scintilla_code_block
        ' 
        Scintilla_code_block._ScintillaManagedDragDrop = True
        Scintilla_code_block.AutocompleteListSelectedBackColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        Scintilla_code_block.Dock = DockStyle.Fill
        Scintilla_code_block.Font = New Font("Consolas", 10F)
        Scintilla_code_block.LexerName = "python"
        Scintilla_code_block.Location = New Point(0, 0)
        Scintilla_code_block.Name = "Scintilla_code_block"
        Scintilla_code_block.ScrollWidth = 70
        Scintilla_code_block.Size = New Size(1399, 448)
        Scintilla_code_block.TabIndex = 59
        ' 
        ' SiticoneTextArea_run_output
        ' 
        SiticoneTextArea_run_output.BorderStyle = BorderStyle.None
        SiticoneTextArea_run_output.Dock = DockStyle.Fill
        SiticoneTextArea_run_output.Font = New Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SiticoneTextArea_run_output.Location = New Point(0, 0)
        SiticoneTextArea_run_output.Margin = New Padding(5)
        SiticoneTextArea_run_output.MinimumSize = New Size(100, 10)
        SiticoneTextArea_run_output.Multiline = True
        SiticoneTextArea_run_output.Name = "SiticoneTextArea_run_output"
        SiticoneTextArea_run_output.PlaceholderText = "Wait for Output..."
        SiticoneTextArea_run_output.ScrollBars = ScrollBars.Vertical
        SiticoneTextArea_run_output.Size = New Size(1399, 142)
        SiticoneTextArea_run_output.TabIndex = 2
        ' 
        ' SiticoneButton_code_run
        ' 
        SiticoneButton_code_run.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard"
        SiticoneButton_code_run.AccessibleName = "Run"
        SiticoneButton_code_run.AutoSizeBasedOnText = False
        SiticoneButton_code_run.BackColor = Color.Transparent
        SiticoneButton_code_run.BadgeBackColor = Color.Red
        SiticoneButton_code_run.BadgeFont = New Font("Segoe UI", 8F, FontStyle.Bold)
        SiticoneButton_code_run.BadgeValue = 0
        SiticoneButton_code_run.BadgeValueForeColor = Color.White
        SiticoneButton_code_run.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        SiticoneButton_code_run.BorderWidth = 2
        SiticoneButton_code_run.ButtonBackColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        SiticoneButton_code_run.ButtonImage = Nothing
        SiticoneButton_code_run.ButtonTextLeftPadding = 0
        SiticoneButton_code_run.CanBeep = True
        SiticoneButton_code_run.CanGlow = False
        SiticoneButton_code_run.CanShake = True
        SiticoneButton_code_run.ContextMenuStripEx = Nothing
        SiticoneButton_code_run.CornerRadiusBottomLeft = 8
        SiticoneButton_code_run.CornerRadiusBottomRight = 8
        SiticoneButton_code_run.CornerRadiusTopLeft = 8
        SiticoneButton_code_run.CornerRadiusTopRight = 8
        SiticoneButton_code_run.CustomCursor = Cursors.Default
        SiticoneButton_code_run.DisabledTextColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        SiticoneButton_code_run.Enabled = False
        SiticoneButton_code_run.EnableLongPress = False
        SiticoneButton_code_run.EnablePressAnimation = True
        SiticoneButton_code_run.EnableRippleEffect = True
        SiticoneButton_code_run.EnableShadow = False
        SiticoneButton_code_run.EnableTextWrapping = False
        SiticoneButton_code_run.Font = New Font("Segoe UI", 9F)
        SiticoneButton_code_run.GlowColor = Color.FromArgb(CByte(100), CByte(255), CByte(255), CByte(255))
        SiticoneButton_code_run.GlowIntensity = 100
        SiticoneButton_code_run.GlowRadius = 20F
        SiticoneButton_code_run.GradientBackground = False
        SiticoneButton_code_run.GradientColor = Color.FromArgb(CByte(114), CByte(168), CByte(255))
        SiticoneButton_code_run.GradientMode = Drawing2D.LinearGradientMode.Vertical
        SiticoneButton_code_run.HintText = Nothing
        SiticoneButton_code_run.HoverBackColor = Color.FromArgb(CByte(114), CByte(168), CByte(255))
        SiticoneButton_code_run.HoverFontStyle = FontStyle.Regular
        SiticoneButton_code_run.HoverTextColor = Color.White
        SiticoneButton_code_run.HoverTransitionDuration = 250
        SiticoneButton_code_run.ImageAlign = ContentAlignment.MiddleLeft
        SiticoneButton_code_run.ImagePadding = 5
        SiticoneButton_code_run.ImageSize = New Size(16, 16)
        SiticoneButton_code_run.IsRadial = False
        SiticoneButton_code_run.IsReadOnly = False
        SiticoneButton_code_run.IsToggleButton = False
        SiticoneButton_code_run.IsToggled = False
        SiticoneButton_code_run.Location = New Point(299, 6)
        SiticoneButton_code_run.LongPressDurationMS = 1000
        SiticoneButton_code_run.Name = "SiticoneButton_code_run"
        SiticoneButton_code_run.NormalFontStyle = FontStyle.Regular
        SiticoneButton_code_run.ParticleColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        SiticoneButton_code_run.ParticleCount = 15
        SiticoneButton_code_run.PressAnimationScale = 0.97F
        SiticoneButton_code_run.PressedBackColor = Color.FromArgb(CByte(74), CByte(128), CByte(235))
        SiticoneButton_code_run.PressedFontStyle = FontStyle.Regular
        SiticoneButton_code_run.PressTransitionDuration = 150
        SiticoneButton_code_run.ReadOnlyTextColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        SiticoneButton_code_run.RippleColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        SiticoneButton_code_run.RippleOpacity = 0.3F
        SiticoneButton_code_run.RippleRadiusMultiplier = 0.6F
        SiticoneButton_code_run.ShadowBlur = 5
        SiticoneButton_code_run.ShadowColor = Color.FromArgb(CByte(100), CByte(0), CByte(0), CByte(0))
        SiticoneButton_code_run.ShadowOffset = New Point(2, 2)
        SiticoneButton_code_run.ShakeDuration = 500
        SiticoneButton_code_run.ShakeIntensity = 5
        SiticoneButton_code_run.Size = New Size(107, 24)
        SiticoneButton_code_run.TabIndex = 28
        SiticoneButton_code_run.Text = "Run"
        SiticoneButton_code_run.TextAlign = ContentAlignment.MiddleCenter
        SiticoneButton_code_run.TextColor = Color.White
        SiticoneButton_code_run.TooltipText = Nothing
        SiticoneButton_code_run.UseAdvancedRendering = True
        SiticoneButton_code_run.UseParticles = False
        ' 
        ' SiticoneDropdown_language
        ' 
        SiticoneDropdown_language.AllowMultipleSelection = False
        SiticoneDropdown_language.BackColor = Color.Transparent
        SiticoneDropdown_language.BorderColor = Color.Gray
        SiticoneDropdown_language.BorderSize = 2
        SiticoneDropdown_language.CanBeep = False
        SiticoneDropdown_language.CanShake = True
        SiticoneDropdown_language.CornerRadius = 8
        SiticoneDropdown_language.DataSource = Nothing
        SiticoneDropdown_language.DisplayMember = Nothing
        SiticoneDropdown_language.DropdownBackColor = Color.White
        SiticoneDropdown_language.DropdownCornerRadius = 8
        SiticoneDropdown_language.DropdownWidth = 0
        SiticoneDropdown_language.DropShadowEnabled = False
        SiticoneDropdown_language.Font = New Font("Segoe UI", 10F)
        SiticoneDropdown_language.ForeColor = Color.DimGray
        SiticoneDropdown_language.HoveredItemBackColor = Color.LightGray
        SiticoneDropdown_language.HoveredItemTextColor = Color.Black
        SiticoneDropdown_language.IsReadonly = False
        SiticoneDropdown_language.ItemHeight = 30
        SiticoneDropdown_language.Location = New Point(44, 6)
        SiticoneDropdown_language.MaxDropDownItems = 8
        SiticoneDropdown_language.Name = "SiticoneDropdown_language"
        SiticoneDropdown_language.NotFoundBackColor = Color.Transparent
        SiticoneDropdown_language.NotFoundFont = Nothing
        SiticoneDropdown_language.NotFoundTextColor = Color.Gray
        SiticoneDropdown_language.PlaceholderColor = Color.Gray
        SiticoneDropdown_language.PlaceholderDisappearsOnFocus = False
        SiticoneDropdown_language.PlaceholderText = "Select a language"
        SiticoneDropdown_language.SearchTextColor = Color.DimGray
        SiticoneDropdown_language.SearchTextFont = Nothing
        SiticoneDropdown_language.SelectedIndex = -1
        SiticoneDropdown_language.SelectedItem = Nothing
        SiticoneDropdown_language.SelectedItemBackColor = Color.LightBlue
        SiticoneDropdown_language.SelectedItemTextColor = Color.Black
        SiticoneDropdown_language.SelectedValue = Nothing
        SiticoneDropdown_language.Size = New Size(249, 23)
        SiticoneDropdown_language.TabIndex = 27
        SiticoneDropdown_language.UnselectedItemTextColor = Color.Black
        SiticoneDropdown_language.ValueMember = Nothing
        ' 
        ' SiticoneLabel_host
        ' 
        SiticoneLabel_host.BackColor = Color.Transparent
        SiticoneLabel_host.Font = New Font("Segoe UI", 10F)
        SiticoneLabel_host.Location = New Point(12, 28)
        SiticoneLabel_host.Name = "SiticoneLabel_host"
        SiticoneLabel_host.Size = New Size(116, 21)
        SiticoneLabel_host.TabIndex = 24
        SiticoneLabel_host.Text = "Ollama Address:"
        ' 
        ' SiticoneLabel_model
        ' 
        SiticoneLabel_model.BackColor = Color.Transparent
        SiticoneLabel_model.Font = New Font("Segoe UI", 10F)
        SiticoneLabel_model.Location = New Point(390, 28)
        SiticoneLabel_model.Name = "SiticoneLabel_model"
        SiticoneLabel_model.Size = New Size(116, 21)
        SiticoneLabel_model.TabIndex = 25
        SiticoneLabel_model.Text = "LLM:"
        ' 
        ' SiticoneButton_chat_clear
        ' 
        SiticoneButton_chat_clear.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard"
        SiticoneButton_chat_clear.AccessibleName = "Clear Chat"
        SiticoneButton_chat_clear.AutoSizeBasedOnText = False
        SiticoneButton_chat_clear.BackColor = Color.Transparent
        SiticoneButton_chat_clear.BadgeBackColor = Color.Red
        SiticoneButton_chat_clear.BadgeFont = New Font("Segoe UI", 8F, FontStyle.Bold)
        SiticoneButton_chat_clear.BadgeValue = 0
        SiticoneButton_chat_clear.BadgeValueForeColor = Color.White
        SiticoneButton_chat_clear.BorderColor = Color.FromArgb(CByte(16), CByte(100), CByte(220))
        SiticoneButton_chat_clear.BorderWidth = 2
        SiticoneButton_chat_clear.ButtonBackColor = Color.FromArgb(CByte(26), CByte(115), CByte(232))
        SiticoneButton_chat_clear.ButtonImage = Nothing
        SiticoneButton_chat_clear.ButtonTextLeftPadding = 0
        SiticoneButton_chat_clear.CanBeep = True
        SiticoneButton_chat_clear.CanGlow = True
        SiticoneButton_chat_clear.CanShake = True
        SiticoneButton_chat_clear.ContextMenuStripEx = Nothing
        SiticoneButton_chat_clear.CornerRadiusBottomLeft = 8
        SiticoneButton_chat_clear.CornerRadiusBottomRight = 8
        SiticoneButton_chat_clear.CornerRadiusTopLeft = 8
        SiticoneButton_chat_clear.CornerRadiusTopRight = 8
        SiticoneButton_chat_clear.CustomCursor = Cursors.Default
        SiticoneButton_chat_clear.DisabledTextColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        SiticoneButton_chat_clear.EnableLongPress = False
        SiticoneButton_chat_clear.EnablePressAnimation = True
        SiticoneButton_chat_clear.EnableRippleEffect = True
        SiticoneButton_chat_clear.EnableShadow = True
        SiticoneButton_chat_clear.EnableTextWrapping = False
        SiticoneButton_chat_clear.Font = New Font("Segoe UI", 9F)
        SiticoneButton_chat_clear.GlowColor = Color.FromArgb(CByte(30), CByte(110), CByte(178), CByte(230))
        SiticoneButton_chat_clear.GlowIntensity = 100
        SiticoneButton_chat_clear.GlowRadius = 20F
        SiticoneButton_chat_clear.GradientBackground = False
        SiticoneButton_chat_clear.GradientColor = Color.FromArgb(CByte(255), CByte(77), CByte(146))
        SiticoneButton_chat_clear.GradientMode = Drawing2D.LinearGradientMode.ForwardDiagonal
        SiticoneButton_chat_clear.HintText = Nothing
        SiticoneButton_chat_clear.HoverBackColor = Color.FromArgb(CByte(40), CByte(130), CByte(240))
        SiticoneButton_chat_clear.HoverFontStyle = FontStyle.Regular
        SiticoneButton_chat_clear.HoverTextColor = Color.White
        SiticoneButton_chat_clear.HoverTransitionDuration = 250
        SiticoneButton_chat_clear.ImageAlign = ContentAlignment.MiddleLeft
        SiticoneButton_chat_clear.ImagePadding = 5
        SiticoneButton_chat_clear.ImageSize = New Size(16, 16)
        SiticoneButton_chat_clear.IsRadial = False
        SiticoneButton_chat_clear.IsReadOnly = False
        SiticoneButton_chat_clear.IsToggleButton = False
        SiticoneButton_chat_clear.IsToggled = False
        SiticoneButton_chat_clear.Location = New Point(950, 51)
        SiticoneButton_chat_clear.LongPressDurationMS = 1000
        SiticoneButton_chat_clear.Name = "SiticoneButton_chat_clear"
        SiticoneButton_chat_clear.NormalFontStyle = FontStyle.Regular
        SiticoneButton_chat_clear.ParticleColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        SiticoneButton_chat_clear.ParticleCount = 15
        SiticoneButton_chat_clear.PressAnimationScale = 0.97F
        SiticoneButton_chat_clear.PressedBackColor = Color.FromArgb(CByte(16), CByte(100), CByte(220))
        SiticoneButton_chat_clear.PressedFontStyle = FontStyle.Regular
        SiticoneButton_chat_clear.PressTransitionDuration = 150
        SiticoneButton_chat_clear.ReadOnlyTextColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        SiticoneButton_chat_clear.RippleColor = Color.White
        SiticoneButton_chat_clear.RippleOpacity = 0.2F
        SiticoneButton_chat_clear.RippleRadiusMultiplier = 0.6F
        SiticoneButton_chat_clear.ShadowBlur = 5
        SiticoneButton_chat_clear.ShadowColor = Color.FromArgb(CByte(50), CByte(0), CByte(64), CByte(128))
        SiticoneButton_chat_clear.ShadowOffset = New Point(0, 2)
        SiticoneButton_chat_clear.ShakeDuration = 500
        SiticoneButton_chat_clear.ShakeIntensity = 5
        SiticoneButton_chat_clear.Size = New Size(107, 30)
        SiticoneButton_chat_clear.TabIndex = 16
        SiticoneButton_chat_clear.Text = "Clear Chat"
        SiticoneButton_chat_clear.TextAlign = ContentAlignment.MiddleCenter
        SiticoneButton_chat_clear.TextColor = Color.White
        SiticoneButton_chat_clear.TooltipText = Nothing
        SiticoneButton_chat_clear.UseAdvancedRendering = True
        SiticoneButton_chat_clear.UseParticles = False
        ' 
        ' SiticoneDropdown_API
        ' 
        SiticoneDropdown_API.AllowMultipleSelection = False
        SiticoneDropdown_API.BackColor = Color.FromArgb(CByte(209), CByte(232), CByte(255))
        SiticoneDropdown_API.BorderColor = Color.Gray
        SiticoneDropdown_API.BorderSize = 2
        SiticoneDropdown_API.CanBeep = False
        SiticoneDropdown_API.CanShake = True
        SiticoneDropdown_API.CornerRadius = 8
        SiticoneDropdown_API.DataSource = Nothing
        SiticoneDropdown_API.DisplayMember = Nothing
        SiticoneDropdown_API.DropdownBackColor = Color.White
        SiticoneDropdown_API.DropdownCornerRadius = 8
        SiticoneDropdown_API.DropdownWidth = 0
        SiticoneDropdown_API.DropShadowEnabled = False
        SiticoneDropdown_API.Font = New Font("Segoe UI", 10F)
        SiticoneDropdown_API.ForeColor = Color.DimGray
        SiticoneDropdown_API.HoveredItemBackColor = Color.LightGray
        SiticoneDropdown_API.HoveredItemTextColor = Color.Black
        SiticoneDropdown_API.IsReadonly = False
        SiticoneDropdown_API.ItemHeight = 30
        SiticoneDropdown_API.Items.AddRange(New String() {"generate", "chat"})
        SiticoneDropdown_API.Location = New Point(798, 51)
        SiticoneDropdown_API.MaxDropDownItems = 8
        SiticoneDropdown_API.Name = "SiticoneDropdown_API"
        SiticoneDropdown_API.NotFoundBackColor = Color.Transparent
        SiticoneDropdown_API.NotFoundFont = Nothing
        SiticoneDropdown_API.NotFoundTextColor = Color.Gray
        SiticoneDropdown_API.PlaceholderColor = Color.Gray
        SiticoneDropdown_API.PlaceholderDisappearsOnFocus = False
        SiticoneDropdown_API.PlaceholderText = "Select a API"
        SiticoneDropdown_API.SearchTextColor = Color.DimGray
        SiticoneDropdown_API.SearchTextFont = Nothing
        SiticoneDropdown_API.SelectedIndex = -1
        SiticoneDropdown_API.SelectedItem = Nothing
        SiticoneDropdown_API.SelectedItemBackColor = Color.LightBlue
        SiticoneDropdown_API.SelectedItemTextColor = Color.Black
        SiticoneDropdown_API.SelectedValue = Nothing
        SiticoneDropdown_API.Size = New Size(146, 30)
        SiticoneDropdown_API.TabIndex = 30
        SiticoneDropdown_API.Text = "generate"
        SiticoneDropdown_API.UnselectedItemTextColor = Color.Black
        SiticoneDropdown_API.ValueMember = Nothing
        ' 
        ' SiticoneLabel_API
        ' 
        SiticoneLabel_API.BackColor = Color.Transparent
        SiticoneLabel_API.Font = New Font("Segoe UI", 10F)
        SiticoneLabel_API.Location = New Point(798, 27)
        SiticoneLabel_API.Name = "SiticoneLabel_API"
        SiticoneLabel_API.Size = New Size(116, 21)
        SiticoneLabel_API.TabIndex = 31
        SiticoneLabel_API.Text = "API:"
        ' 
        ' SiticoneLabel_chat_clear
        ' 
        SiticoneLabel_chat_clear.BackColor = Color.Transparent
        SiticoneLabel_chat_clear.Font = New Font("Segoe UI", 10F)
        SiticoneLabel_chat_clear.Location = New Point(950, 27)
        SiticoneLabel_chat_clear.Name = "SiticoneLabel_chat_clear"
        SiticoneLabel_chat_clear.Size = New Size(116, 21)
        SiticoneLabel_chat_clear.TabIndex = 32
        SiticoneLabel_chat_clear.Text = "Chat Mem: 0"
        ' 
        ' SiticoneButton_HTMLtoPDF
        ' 
        SiticoneButton_HTMLtoPDF.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard"
        SiticoneButton_HTMLtoPDF.AccessibleName = ""
        SiticoneButton_HTMLtoPDF.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        SiticoneButton_HTMLtoPDF.AutoSizeBasedOnText = False
        SiticoneButton_HTMLtoPDF.BackColor = Color.Transparent
        SiticoneButton_HTMLtoPDF.BadgeBackColor = Color.Red
        SiticoneButton_HTMLtoPDF.BadgeFont = New Font("Segoe UI", 8F, FontStyle.Bold)
        SiticoneButton_HTMLtoPDF.BadgeValue = 0
        SiticoneButton_HTMLtoPDF.BadgeValueForeColor = Color.White
        SiticoneButton_HTMLtoPDF.BorderColor = Color.Transparent
        SiticoneButton_HTMLtoPDF.BorderWidth = 2
        SiticoneButton_HTMLtoPDF.ButtonBackColor = Color.Transparent
        SiticoneButton_HTMLtoPDF.ButtonImage = My.Resources.Resource_pic.save_32
        SiticoneButton_HTMLtoPDF.ButtonTextLeftPadding = 0
        SiticoneButton_HTMLtoPDF.CanBeep = True
        SiticoneButton_HTMLtoPDF.CanGlow = False
        SiticoneButton_HTMLtoPDF.CanShake = True
        SiticoneButton_HTMLtoPDF.ContextMenuStripEx = Nothing
        SiticoneButton_HTMLtoPDF.CornerRadiusBottomLeft = 8
        SiticoneButton_HTMLtoPDF.CornerRadiusBottomRight = 8
        SiticoneButton_HTMLtoPDF.CornerRadiusTopLeft = 8
        SiticoneButton_HTMLtoPDF.CornerRadiusTopRight = 8
        SiticoneButton_HTMLtoPDF.CustomCursor = Cursors.Default
        SiticoneButton_HTMLtoPDF.DisabledTextColor = Color.Transparent
        SiticoneButton_HTMLtoPDF.Enabled = False
        SiticoneButton_HTMLtoPDF.EnableLongPress = False
        SiticoneButton_HTMLtoPDF.EnablePressAnimation = True
        SiticoneButton_HTMLtoPDF.EnableRippleEffect = True
        SiticoneButton_HTMLtoPDF.EnableShadow = False
        SiticoneButton_HTMLtoPDF.EnableTextWrapping = False
        SiticoneButton_HTMLtoPDF.Font = New Font("Segoe UI", 9F)
        SiticoneButton_HTMLtoPDF.ForeColor = Color.LightGray
        SiticoneButton_HTMLtoPDF.GlowColor = Color.FromArgb(CByte(30), CByte(110), CByte(178), CByte(230))
        SiticoneButton_HTMLtoPDF.GlowIntensity = 100
        SiticoneButton_HTMLtoPDF.GlowRadius = 20F
        SiticoneButton_HTMLtoPDF.GradientBackground = False
        SiticoneButton_HTMLtoPDF.GradientColor = Color.FromArgb(CByte(255), CByte(77), CByte(146))
        SiticoneButton_HTMLtoPDF.GradientMode = Drawing2D.LinearGradientMode.ForwardDiagonal
        SiticoneButton_HTMLtoPDF.HintText = Nothing
        SiticoneButton_HTMLtoPDF.HoverBackColor = SystemColors.ActiveCaption
        SiticoneButton_HTMLtoPDF.HoverFontStyle = FontStyle.Regular
        SiticoneButton_HTMLtoPDF.HoverTextColor = Color.White
        SiticoneButton_HTMLtoPDF.HoverTransitionDuration = 250
        SiticoneButton_HTMLtoPDF.ImageAlign = ContentAlignment.MiddleCenter
        SiticoneButton_HTMLtoPDF.ImagePadding = 5
        SiticoneButton_HTMLtoPDF.ImageSize = New Size(32, 32)
        SiticoneButton_HTMLtoPDF.IsRadial = False
        SiticoneButton_HTMLtoPDF.IsReadOnly = False
        SiticoneButton_HTMLtoPDF.IsToggleButton = False
        SiticoneButton_HTMLtoPDF.IsToggled = False
        SiticoneButton_HTMLtoPDF.Location = New Point(1275, 1)
        SiticoneButton_HTMLtoPDF.LongPressDurationMS = 1000
        SiticoneButton_HTMLtoPDF.Name = "SiticoneButton_HTMLtoPDF"
        SiticoneButton_HTMLtoPDF.NormalFontStyle = FontStyle.Regular
        SiticoneButton_HTMLtoPDF.ParticleColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        SiticoneButton_HTMLtoPDF.ParticleCount = 15
        SiticoneButton_HTMLtoPDF.PressAnimationScale = 0.97F
        SiticoneButton_HTMLtoPDF.PressedBackColor = Color.FromArgb(CByte(16), CByte(100), CByte(220))
        SiticoneButton_HTMLtoPDF.PressedFontStyle = FontStyle.Regular
        SiticoneButton_HTMLtoPDF.PressTransitionDuration = 150
        SiticoneButton_HTMLtoPDF.ReadOnlyTextColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        SiticoneButton_HTMLtoPDF.RippleColor = Color.White
        SiticoneButton_HTMLtoPDF.RippleOpacity = 0.2F
        SiticoneButton_HTMLtoPDF.RippleRadiusMultiplier = 0.6F
        SiticoneButton_HTMLtoPDF.ShadowBlur = 5
        SiticoneButton_HTMLtoPDF.ShadowColor = Color.FromArgb(CByte(50), CByte(0), CByte(64), CByte(128))
        SiticoneButton_HTMLtoPDF.ShadowOffset = New Point(0, 2)
        SiticoneButton_HTMLtoPDF.ShakeDuration = 500
        SiticoneButton_HTMLtoPDF.ShakeIntensity = 5
        SiticoneButton_HTMLtoPDF.Size = New Size(32, 32)
        SiticoneButton_HTMLtoPDF.TabIndex = 16
        SiticoneButton_HTMLtoPDF.TextAlign = ContentAlignment.MiddleCenter
        SiticoneButton_HTMLtoPDF.TextColor = Color.White
        SiticoneButton_HTMLtoPDF.TooltipText = "Save Result to PDF, HTML or MD"
        SiticoneButton_HTMLtoPDF.UseAdvancedRendering = True
        SiticoneButton_HTMLtoPDF.UseParticles = False
        ' 
        ' SiticonePanel_prompt
        ' 
        SiticonePanel_prompt.AcrylicTintColor = Color.FromArgb(CByte(128), CByte(255), CByte(255), CByte(255))
        SiticonePanel_prompt.AutoSizeMode = AutoSizeMode.GrowAndShrink
        SiticonePanel_prompt.BackColor = Color.Transparent
        SiticonePanel_prompt.BorderAlignment = Drawing2D.PenAlignment.Center
        SiticonePanel_prompt.BorderDashPattern = Nothing
        SiticonePanel_prompt.BorderGradientEndColor = Color.Purple
        SiticonePanel_prompt.BorderGradientStartColor = Color.Blue
        SiticonePanel_prompt.BorderThickness = 2F
        SiticonePanel_prompt.Controls.Add(SiticonePanel_prompt_action)
        SiticonePanel_prompt.Controls.Add(SiticoneFlowPanel_prompt_filecontent)
        SiticonePanel_prompt.Controls.Add(SiticoneTextArea_prompt)
        SiticonePanel_prompt.CornerRadiusBottomLeft = 20F
        SiticonePanel_prompt.CornerRadiusBottomRight = 20F
        SiticonePanel_prompt.CornerRadiusTopLeft = 20F
        SiticonePanel_prompt.CornerRadiusTopRight = 20F
        SiticonePanel_prompt.Dock = DockStyle.Bottom
        SiticonePanel_prompt.EnableAcrylicEffect = False
        SiticonePanel_prompt.EnableMicaEffect = False
        SiticonePanel_prompt.EnableRippleEffect = False
        SiticonePanel_prompt.FillColor = Color.LightGray
        SiticonePanel_prompt.ForeColor = SystemColors.ControlText
        SiticonePanel_prompt.GradientColors = New Color() {Color.White, Color.LightGray, Color.Gray}
        SiticonePanel_prompt.GradientPositions = New Single() {0F, 0.5F, 1F}
        SiticonePanel_prompt.Location = New Point(2, 690)
        SiticonePanel_prompt.Name = "SiticonePanel_prompt"
        SiticonePanel_prompt.Padding = New Padding(10)
        SiticonePanel_prompt.PatternStyle = Drawing2D.HatchStyle.Max
        SiticonePanel_prompt.RippleAlpha = 50
        SiticonePanel_prompt.RippleAlphaDecrement = 3
        SiticonePanel_prompt.RippleColor = Color.FromArgb(CByte(50), CByte(255), CByte(255), CByte(255))
        SiticonePanel_prompt.RippleMaxSize = 600F
        SiticonePanel_prompt.RippleSpeed = 15F
        SiticonePanel_prompt.ShowBorder = True
        SiticonePanel_prompt.Size = New Size(1485, 87)
        SiticonePanel_prompt.TabIndex = 40
        SiticonePanel_prompt.TabStop = True
        SiticonePanel_prompt.TrackSystemTheme = False
        SiticonePanel_prompt.UseBorderGradient = False
        SiticonePanel_prompt.UseMultiGradient = False
        SiticonePanel_prompt.UsePatternTexture = False
        SiticonePanel_prompt.UseRadialGradient = False
        ' 
        ' SiticonePanel_prompt_action
        ' 
        SiticonePanel_prompt_action.AcrylicTintColor = Color.FromArgb(CByte(128), CByte(255), CByte(255), CByte(255))
        SiticonePanel_prompt_action.BackColor = Color.LightGray
        SiticonePanel_prompt_action.BorderAlignment = Drawing2D.PenAlignment.Center
        SiticonePanel_prompt_action.BorderDashPattern = Nothing
        SiticonePanel_prompt_action.BorderGradientEndColor = Color.Purple
        SiticonePanel_prompt_action.BorderGradientStartColor = Color.Blue
        SiticonePanel_prompt_action.BorderThickness = 2F
        SiticonePanel_prompt_action.Controls.Add(SiticoneToggleSwitch_show_menue)
        SiticonePanel_prompt_action.Controls.Add(SiticoneLabel_show_LLM)
        SiticonePanel_prompt_action.Controls.Add(SiticonePlayPauseButton_request)
        SiticonePanel_prompt_action.Controls.Add(SiticoneButton_file)
        SiticonePanel_prompt_action.Controls.Add(SiticoneButton_screenshot)
        SiticonePanel_prompt_action.Controls.Add(SiticoneButton_timing)
        SiticonePanel_prompt_action.Controls.Add(SiticoneButton_HTMLtoPDF)
        SiticonePanel_prompt_action.Controls.Add(SiticoneButton_show_thinking)
        SiticonePanel_prompt_action.Controls.Add(SiticoneLoadingSpinner_request)
        SiticonePanel_prompt_action.CornerRadiusBottomLeft = 0F
        SiticonePanel_prompt_action.CornerRadiusBottomRight = 0F
        SiticonePanel_prompt_action.CornerRadiusTopLeft = 0F
        SiticonePanel_prompt_action.CornerRadiusTopRight = 0F
        SiticonePanel_prompt_action.Dock = DockStyle.Top
        SiticonePanel_prompt_action.EnableAcrylicEffect = False
        SiticonePanel_prompt_action.EnableMicaEffect = False
        SiticonePanel_prompt_action.EnableRippleEffect = False
        SiticonePanel_prompt_action.FillColor = Color.LightGray
        SiticonePanel_prompt_action.ForeColor = Color.LightGray
        SiticonePanel_prompt_action.GradientColors = New Color() {Color.White, Color.LightGray, Color.Gray}
        SiticonePanel_prompt_action.GradientPositions = New Single() {0F, 0.5F, 1F}
        SiticonePanel_prompt_action.Location = New Point(10, 46)
        SiticonePanel_prompt_action.Name = "SiticonePanel_prompt_action"
        SiticonePanel_prompt_action.PatternStyle = Drawing2D.HatchStyle.Max
        SiticonePanel_prompt_action.RippleAlpha = 50
        SiticonePanel_prompt_action.RippleAlphaDecrement = 3
        SiticonePanel_prompt_action.RippleColor = Color.FromArgb(CByte(50), CByte(255), CByte(255), CByte(255))
        SiticonePanel_prompt_action.RippleMaxSize = 600F
        SiticonePanel_prompt_action.RippleSpeed = 15F
        SiticonePanel_prompt_action.ShowBorder = False
        SiticonePanel_prompt_action.Size = New Size(1465, 36)
        SiticonePanel_prompt_action.TabIndex = 18
        SiticonePanel_prompt_action.TabStop = True
        SiticonePanel_prompt_action.TrackSystemTheme = False
        SiticonePanel_prompt_action.UseBorderGradient = False
        SiticonePanel_prompt_action.UseMultiGradient = False
        SiticonePanel_prompt_action.UsePatternTexture = False
        SiticonePanel_prompt_action.UseRadialGradient = False
        ' 
        ' SiticoneToggleSwitch_show_menue
        ' 
        SiticoneToggleSwitch_show_menue.AccessibleDescription = "A customizable toggle switch that can be turned on or off."
        SiticoneToggleSwitch_show_menue.AccessibleName = "Siticone Toggle Switch"
        SiticoneToggleSwitch_show_menue.AccessibleRole = AccessibleRole.CheckButton
        SiticoneToggleSwitch_show_menue.CanBeep = True
        SiticoneToggleSwitch_show_menue.CanShake = True
        SiticoneToggleSwitch_show_menue.Checked = True
        SiticoneToggleSwitch_show_menue.DisabledColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        SiticoneToggleSwitch_show_menue.DisallowToggling = False
        SiticoneToggleSwitch_show_menue.EnableGlowEffect = True
        SiticoneToggleSwitch_show_menue.ExtraThumbSize = 2
        SiticoneToggleSwitch_show_menue.IsOn = True
        SiticoneToggleSwitch_show_menue.IsReadOnly = False
        SiticoneToggleSwitch_show_menue.IsRequired = False
        SiticoneToggleSwitch_show_menue.LabelColor = Color.Black
        SiticoneToggleSwitch_show_menue.LabelFont = New Font("Segoe UI", 9F)
        SiticoneToggleSwitch_show_menue.Location = New Point(0, 6)
        SiticoneToggleSwitch_show_menue.Logger = Nothing
        SiticoneToggleSwitch_show_menue.Name = "SiticoneToggleSwitch_show_menue"
        SiticoneToggleSwitch_show_menue.OffBackColor1 = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        SiticoneToggleSwitch_show_menue.OffBackColor2 = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        SiticoneToggleSwitch_show_menue.OffBorderColor1 = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        SiticoneToggleSwitch_show_menue.OffBorderColor2 = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        SiticoneToggleSwitch_show_menue.OffIcon = Nothing
        SiticoneToggleSwitch_show_menue.OffThumbColor1 = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        SiticoneToggleSwitch_show_menue.OffThumbColor2 = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        SiticoneToggleSwitch_show_menue.OnBackColor1 = Color.FromArgb(CByte(26), CByte(115), CByte(232))
        SiticoneToggleSwitch_show_menue.OnBackColor2 = Color.FromArgb(CByte(26), CByte(115), CByte(232))
        SiticoneToggleSwitch_show_menue.OnBorderColor1 = Color.FromArgb(CByte(26), CByte(115), CByte(232))
        SiticoneToggleSwitch_show_menue.OnBorderColor2 = Color.FromArgb(CByte(26), CByte(115), CByte(232))
        SiticoneToggleSwitch_show_menue.OnIcon = Nothing
        SiticoneToggleSwitch_show_menue.OnThumbColor1 = Color.White
        SiticoneToggleSwitch_show_menue.OnThumbColor2 = Color.White
        SiticoneToggleSwitch_show_menue.PreventToggleOff = False
        SiticoneToggleSwitch_show_menue.RippleColor = Color.FromArgb(CByte(100), CByte(255), CByte(255), CByte(255))
        SiticoneToggleSwitch_show_menue.RippleExpansionRate = 2F
        SiticoneToggleSwitch_show_menue.RippleOpacityDecay = 0.02F
        SiticoneToggleSwitch_show_menue.Size = New Size(50, 25)
        SiticoneToggleSwitch_show_menue.TabIndex = 52
        SiticoneToggleSwitch_show_menue.ToggleOffSoundPath = ""
        SiticoneToggleSwitch_show_menue.ToggleOnSoundPath = ""
        SiticoneToggleSwitch_show_menue.ToolTipText = "Show Menue"
        SiticoneToggleSwitch_show_menue.TrackDeviceTheme = True
        ' 
        ' SiticoneLabel_show_LLM
        ' 
        SiticoneLabel_show_LLM.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        SiticoneLabel_show_LLM.BackColor = Color.Transparent
        SiticoneLabel_show_LLM.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        SiticoneLabel_show_LLM.ForeColor = Color.FromArgb(CByte(26), CByte(115), CByte(232))
        SiticoneLabel_show_LLM.Location = New Point(185, 5)
        SiticoneLabel_show_LLM.Name = "SiticoneLabel_show_LLM"
        SiticoneLabel_show_LLM.Size = New Size(1008, 25)
        SiticoneLabel_show_LLM.TabIndex = 51
        SiticoneLabel_show_LLM.Text = "no LLM selected"
        SiticoneLabel_show_LLM.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' SiticonePlayPauseButton_request
        ' 
        SiticonePlayPauseButton_request.BackgroundEndColor = Color.LightGray
        SiticonePlayPauseButton_request.BackgroundStartColor = Color.LightGray
        SiticonePlayPauseButton_request.BorderEndColor = Color.LightGray
        SiticonePlayPauseButton_request.BorderStartColor = Color.LightGray
        SiticonePlayPauseButton_request.BorderWidth = 0F
        SiticonePlayPauseButton_request.BottomLeftRadius = 0
        SiticonePlayPauseButton_request.BottomRightRadius = 0
        SiticonePlayPauseButton_request.Dock = DockStyle.Right
        SiticonePlayPauseButton_request.Enabled = False
        SiticonePlayPauseButton_request.ForeColor = Color.LightGray
        SiticonePlayPauseButton_request.HoverColor = SystemColors.HotTrack
        SiticonePlayPauseButton_request.IconColor = Color.DodgerBlue
        SiticonePlayPauseButton_request.IconPadding = 0
        SiticonePlayPauseButton_request.IconScale = 0.8F
        SiticonePlayPauseButton_request.Location = New Point(1429, 0)
        SiticonePlayPauseButton_request.MaximumSize = New Size(200, 200)
        SiticonePlayPauseButton_request.MinimumSize = New Size(10, 10)
        SiticonePlayPauseButton_request.Name = "SiticonePlayPauseButton_request"
        SiticonePlayPauseButton_request.PlayProgress = 0.5F
        SiticonePlayPauseButton_request.ProgressColor = Color.SteelBlue
        SiticonePlayPauseButton_request.RadialBackgroundDesign = True
        SiticonePlayPauseButton_request.Size = New Size(36, 36)
        SiticonePlayPauseButton_request.StrokeWidth = 4F
        SiticonePlayPauseButton_request.TabIndex = 1
        LayoutState3.Location = New Point(3, 3)
        LayoutState3.Size = New Size(36, 36)
        LayoutState3.Visible = True
        SiticonePlayPauseButton_request.Tag = LayoutState3
        SiticonePlayPauseButton_request.TopLeftRadius = 0
        SiticonePlayPauseButton_request.TopRightRadius = 0
        ' 
        ' SiticoneButton_screenshot
        ' 
        SiticoneButton_screenshot.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard"
        SiticoneButton_screenshot.AccessibleName = ""
        SiticoneButton_screenshot.AutoSizeBasedOnText = False
        SiticoneButton_screenshot.BackColor = Color.Transparent
        SiticoneButton_screenshot.BadgeBackColor = Color.Red
        SiticoneButton_screenshot.BadgeFont = New Font("Segoe UI", 8F, FontStyle.Bold)
        SiticoneButton_screenshot.BadgeValue = 0
        SiticoneButton_screenshot.BadgeValueForeColor = Color.White
        SiticoneButton_screenshot.BorderColor = Color.Transparent
        SiticoneButton_screenshot.BorderWidth = 2
        SiticoneButton_screenshot.ButtonBackColor = Color.Transparent
        SiticoneButton_screenshot.ButtonImage = My.Resources.Resource_pic.screenshot_32
        SiticoneButton_screenshot.ButtonTextLeftPadding = 0
        SiticoneButton_screenshot.CanBeep = True
        SiticoneButton_screenshot.CanGlow = False
        SiticoneButton_screenshot.CanShake = True
        SiticoneButton_screenshot.ContextMenuStripEx = Nothing
        SiticoneButton_screenshot.CornerRadiusBottomLeft = 8
        SiticoneButton_screenshot.CornerRadiusBottomRight = 8
        SiticoneButton_screenshot.CornerRadiusTopLeft = 8
        SiticoneButton_screenshot.CornerRadiusTopRight = 8
        SiticoneButton_screenshot.CustomCursor = Cursors.Default
        SiticoneButton_screenshot.DisabledTextColor = Color.Transparent
        SiticoneButton_screenshot.EnableLongPress = False
        SiticoneButton_screenshot.EnablePressAnimation = True
        SiticoneButton_screenshot.EnableRippleEffect = True
        SiticoneButton_screenshot.EnableShadow = False
        SiticoneButton_screenshot.EnableTextWrapping = False
        SiticoneButton_screenshot.Font = New Font("Segoe UI", 9F)
        SiticoneButton_screenshot.ForeColor = Color.LightGray
        SiticoneButton_screenshot.GlowColor = Color.FromArgb(CByte(30), CByte(110), CByte(178), CByte(230))
        SiticoneButton_screenshot.GlowIntensity = 100
        SiticoneButton_screenshot.GlowRadius = 20F
        SiticoneButton_screenshot.GradientBackground = False
        SiticoneButton_screenshot.GradientColor = Color.FromArgb(CByte(255), CByte(77), CByte(146))
        SiticoneButton_screenshot.GradientMode = Drawing2D.LinearGradientMode.ForwardDiagonal
        SiticoneButton_screenshot.HintText = Nothing
        SiticoneButton_screenshot.HoverBackColor = SystemColors.ActiveCaption
        SiticoneButton_screenshot.HoverFontStyle = FontStyle.Regular
        SiticoneButton_screenshot.HoverTextColor = Color.White
        SiticoneButton_screenshot.HoverTransitionDuration = 250
        SiticoneButton_screenshot.ImageAlign = ContentAlignment.MiddleCenter
        SiticoneButton_screenshot.ImagePadding = 5
        SiticoneButton_screenshot.ImageSize = New Size(32, 32)
        SiticoneButton_screenshot.IsRadial = False
        SiticoneButton_screenshot.IsReadOnly = False
        SiticoneButton_screenshot.IsToggleButton = False
        SiticoneButton_screenshot.IsToggled = False
        SiticoneButton_screenshot.Location = New Point(92, 1)
        SiticoneButton_screenshot.LongPressDurationMS = 1000
        SiticoneButton_screenshot.Name = "SiticoneButton_screenshot"
        SiticoneButton_screenshot.NormalFontStyle = FontStyle.Regular
        SiticoneButton_screenshot.ParticleColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        SiticoneButton_screenshot.ParticleCount = 15
        SiticoneButton_screenshot.PressAnimationScale = 0.97F
        SiticoneButton_screenshot.PressedBackColor = Color.FromArgb(CByte(16), CByte(100), CByte(220))
        SiticoneButton_screenshot.PressedFontStyle = FontStyle.Regular
        SiticoneButton_screenshot.PressTransitionDuration = 150
        SiticoneButton_screenshot.ReadOnlyTextColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        SiticoneButton_screenshot.RippleColor = Color.White
        SiticoneButton_screenshot.RippleOpacity = 0.2F
        SiticoneButton_screenshot.RippleRadiusMultiplier = 0.6F
        SiticoneButton_screenshot.ShadowBlur = 5
        SiticoneButton_screenshot.ShadowColor = Color.FromArgb(CByte(50), CByte(0), CByte(64), CByte(128))
        SiticoneButton_screenshot.ShadowOffset = New Point(0, 2)
        SiticoneButton_screenshot.ShakeDuration = 500
        SiticoneButton_screenshot.ShakeIntensity = 5
        SiticoneButton_screenshot.Size = New Size(32, 32)
        SiticoneButton_screenshot.TabIndex = 16
        SiticoneButton_screenshot.TextAlign = ContentAlignment.MiddleCenter
        SiticoneButton_screenshot.TextColor = Color.White
        SiticoneButton_screenshot.TooltipText = "Add Screenshot to Context"
        SiticoneButton_screenshot.UseAdvancedRendering = True
        SiticoneButton_screenshot.UseParticles = False
        ' 
        ' SiticoneButton_timing
        ' 
        SiticoneButton_timing.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard"
        SiticoneButton_timing.AccessibleName = ""
        SiticoneButton_timing.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        SiticoneButton_timing.AutoSizeBasedOnText = False
        SiticoneButton_timing.BackColor = Color.Transparent
        SiticoneButton_timing.BadgeBackColor = Color.Red
        SiticoneButton_timing.BadgeFont = New Font("Segoe UI", 8F, FontStyle.Bold)
        SiticoneButton_timing.BadgeValue = 0
        SiticoneButton_timing.BadgeValueForeColor = Color.White
        SiticoneButton_timing.BorderColor = Color.Transparent
        SiticoneButton_timing.BorderWidth = 2
        SiticoneButton_timing.ButtonBackColor = Color.Transparent
        SiticoneButton_timing.ButtonImage = My.Resources.Resource_pic.statistics_32
        SiticoneButton_timing.ButtonTextLeftPadding = 0
        SiticoneButton_timing.CanBeep = True
        SiticoneButton_timing.CanGlow = False
        SiticoneButton_timing.CanShake = True
        SiticoneButton_timing.ContextMenuStripEx = Nothing
        SiticoneButton_timing.CornerRadiusBottomLeft = 8
        SiticoneButton_timing.CornerRadiusBottomRight = 8
        SiticoneButton_timing.CornerRadiusTopLeft = 8
        SiticoneButton_timing.CornerRadiusTopRight = 8
        SiticoneButton_timing.CustomCursor = Cursors.Default
        SiticoneButton_timing.DisabledTextColor = Color.Transparent
        SiticoneButton_timing.Enabled = False
        SiticoneButton_timing.EnableLongPress = False
        SiticoneButton_timing.EnablePressAnimation = True
        SiticoneButton_timing.EnableRippleEffect = True
        SiticoneButton_timing.EnableShadow = False
        SiticoneButton_timing.EnableTextWrapping = False
        SiticoneButton_timing.Font = New Font("Segoe UI", 9F)
        SiticoneButton_timing.ForeColor = Color.LightGray
        SiticoneButton_timing.GlowColor = Color.FromArgb(CByte(30), CByte(110), CByte(178), CByte(230))
        SiticoneButton_timing.GlowIntensity = 100
        SiticoneButton_timing.GlowRadius = 20F
        SiticoneButton_timing.GradientBackground = False
        SiticoneButton_timing.GradientColor = Color.FromArgb(CByte(255), CByte(77), CByte(146))
        SiticoneButton_timing.GradientMode = Drawing2D.LinearGradientMode.ForwardDiagonal
        SiticoneButton_timing.HintText = Nothing
        SiticoneButton_timing.HoverBackColor = SystemColors.ActiveCaption
        SiticoneButton_timing.HoverFontStyle = FontStyle.Regular
        SiticoneButton_timing.HoverTextColor = Color.White
        SiticoneButton_timing.HoverTransitionDuration = 250
        SiticoneButton_timing.ImageAlign = ContentAlignment.MiddleCenter
        SiticoneButton_timing.ImagePadding = 5
        SiticoneButton_timing.ImageSize = New Size(32, 32)
        SiticoneButton_timing.IsRadial = False
        SiticoneButton_timing.IsReadOnly = False
        SiticoneButton_timing.IsToggleButton = False
        SiticoneButton_timing.IsToggled = False
        SiticoneButton_timing.Location = New Point(1199, 1)
        SiticoneButton_timing.LongPressDurationMS = 1000
        SiticoneButton_timing.Name = "SiticoneButton_timing"
        SiticoneButton_timing.NormalFontStyle = FontStyle.Regular
        SiticoneButton_timing.ParticleColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        SiticoneButton_timing.ParticleCount = 15
        SiticoneButton_timing.PressAnimationScale = 0.97F
        SiticoneButton_timing.PressedBackColor = Color.FromArgb(CByte(16), CByte(100), CByte(220))
        SiticoneButton_timing.PressedFontStyle = FontStyle.Regular
        SiticoneButton_timing.PressTransitionDuration = 150
        SiticoneButton_timing.ReadOnlyTextColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        SiticoneButton_timing.RippleColor = Color.White
        SiticoneButton_timing.RippleOpacity = 0.2F
        SiticoneButton_timing.RippleRadiusMultiplier = 0.6F
        SiticoneButton_timing.ShadowBlur = 5
        SiticoneButton_timing.ShadowColor = Color.FromArgb(CByte(50), CByte(0), CByte(64), CByte(128))
        SiticoneButton_timing.ShadowOffset = New Point(0, 2)
        SiticoneButton_timing.ShakeDuration = 500
        SiticoneButton_timing.ShakeIntensity = 5
        SiticoneButton_timing.Size = New Size(32, 32)
        SiticoneButton_timing.TabIndex = 39
        SiticoneButton_timing.TextAlign = ContentAlignment.MiddleCenter
        SiticoneButton_timing.TextColor = Color.White
        SiticoneButton_timing.TooltipText = "Show Statistics"
        SiticoneButton_timing.UseAdvancedRendering = True
        SiticoneButton_timing.UseParticles = False
        ' 
        ' SiticoneButton_show_thinking
        ' 
        SiticoneButton_show_thinking.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard"
        SiticoneButton_show_thinking.AccessibleName = ""
        SiticoneButton_show_thinking.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        SiticoneButton_show_thinking.AutoSizeBasedOnText = False
        SiticoneButton_show_thinking.BackColor = Color.Transparent
        SiticoneButton_show_thinking.BadgeBackColor = Color.Red
        SiticoneButton_show_thinking.BadgeFont = New Font("Segoe UI", 8F, FontStyle.Bold)
        SiticoneButton_show_thinking.BadgeValue = 0
        SiticoneButton_show_thinking.BadgeValueForeColor = Color.White
        SiticoneButton_show_thinking.BorderColor = Color.Transparent
        SiticoneButton_show_thinking.BorderWidth = 2
        SiticoneButton_show_thinking.ButtonBackColor = Color.Transparent
        SiticoneButton_show_thinking.ButtonImage = My.Resources.Resource_pic.think_32
        SiticoneButton_show_thinking.ButtonTextLeftPadding = 0
        SiticoneButton_show_thinking.CanBeep = True
        SiticoneButton_show_thinking.CanGlow = False
        SiticoneButton_show_thinking.CanShake = True
        SiticoneButton_show_thinking.ContextMenuStripEx = Nothing
        SiticoneButton_show_thinking.CornerRadiusBottomLeft = 8
        SiticoneButton_show_thinking.CornerRadiusBottomRight = 8
        SiticoneButton_show_thinking.CornerRadiusTopLeft = 8
        SiticoneButton_show_thinking.CornerRadiusTopRight = 8
        SiticoneButton_show_thinking.CustomCursor = Cursors.Default
        SiticoneButton_show_thinking.DisabledTextColor = Color.Transparent
        SiticoneButton_show_thinking.Enabled = False
        SiticoneButton_show_thinking.EnableLongPress = False
        SiticoneButton_show_thinking.EnablePressAnimation = True
        SiticoneButton_show_thinking.EnableRippleEffect = True
        SiticoneButton_show_thinking.EnableShadow = False
        SiticoneButton_show_thinking.EnableTextWrapping = False
        SiticoneButton_show_thinking.Font = New Font("Segoe UI", 9F)
        SiticoneButton_show_thinking.ForeColor = Color.LightGray
        SiticoneButton_show_thinking.GlowColor = Color.FromArgb(CByte(30), CByte(110), CByte(178), CByte(230))
        SiticoneButton_show_thinking.GlowIntensity = 100
        SiticoneButton_show_thinking.GlowRadius = 20F
        SiticoneButton_show_thinking.GradientBackground = False
        SiticoneButton_show_thinking.GradientColor = Color.FromArgb(CByte(255), CByte(77), CByte(146))
        SiticoneButton_show_thinking.GradientMode = Drawing2D.LinearGradientMode.ForwardDiagonal
        SiticoneButton_show_thinking.HintText = Nothing
        SiticoneButton_show_thinking.HoverBackColor = SystemColors.ActiveCaption
        SiticoneButton_show_thinking.HoverFontStyle = FontStyle.Regular
        SiticoneButton_show_thinking.HoverTextColor = Color.White
        SiticoneButton_show_thinking.HoverTransitionDuration = 250
        SiticoneButton_show_thinking.ImageAlign = ContentAlignment.MiddleCenter
        SiticoneButton_show_thinking.ImagePadding = 5
        SiticoneButton_show_thinking.ImageSize = New Size(32, 32)
        SiticoneButton_show_thinking.IsRadial = False
        SiticoneButton_show_thinking.IsReadOnly = False
        SiticoneButton_show_thinking.IsToggleButton = False
        SiticoneButton_show_thinking.IsToggled = False
        SiticoneButton_show_thinking.Location = New Point(1237, 1)
        SiticoneButton_show_thinking.LongPressDurationMS = 1000
        SiticoneButton_show_thinking.Name = "SiticoneButton_show_thinking"
        SiticoneButton_show_thinking.NormalFontStyle = FontStyle.Regular
        SiticoneButton_show_thinking.ParticleColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        SiticoneButton_show_thinking.ParticleCount = 15
        SiticoneButton_show_thinking.PressAnimationScale = 0.97F
        SiticoneButton_show_thinking.PressedBackColor = Color.FromArgb(CByte(16), CByte(100), CByte(220))
        SiticoneButton_show_thinking.PressedFontStyle = FontStyle.Regular
        SiticoneButton_show_thinking.PressTransitionDuration = 150
        SiticoneButton_show_thinking.ReadOnlyTextColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        SiticoneButton_show_thinking.RippleColor = Color.White
        SiticoneButton_show_thinking.RippleOpacity = 0.2F
        SiticoneButton_show_thinking.RippleRadiusMultiplier = 0.6F
        SiticoneButton_show_thinking.ShadowBlur = 5
        SiticoneButton_show_thinking.ShadowColor = Color.FromArgb(CByte(50), CByte(0), CByte(64), CByte(128))
        SiticoneButton_show_thinking.ShadowOffset = New Point(0, 2)
        SiticoneButton_show_thinking.ShakeDuration = 500
        SiticoneButton_show_thinking.ShakeIntensity = 5
        SiticoneButton_show_thinking.Size = New Size(32, 32)
        SiticoneButton_show_thinking.TabIndex = 38
        SiticoneButton_show_thinking.TextAlign = ContentAlignment.MiddleCenter
        SiticoneButton_show_thinking.TextColor = Color.White
        SiticoneButton_show_thinking.TooltipText = "Show Thinking"
        SiticoneButton_show_thinking.UseAdvancedRendering = True
        SiticoneButton_show_thinking.UseParticles = False
        ' 
        ' SiticoneLoadingSpinner_request
        ' 
        SiticoneLoadingSpinner_request.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        SiticoneLoadingSpinner_request.CenterDotRadius = 2
        SiticoneLoadingSpinner_request.GradientColor = Color.White
        SiticoneLoadingSpinner_request.InnerCircleRadius = 8
        SiticoneLoadingSpinner_request.Location = New Point(1367, -13)
        SiticoneLoadingSpinner_request.MinimumSize = New Size(20, 20)
        SiticoneLoadingSpinner_request.Name = "SiticoneLoadingSpinner_request"
        SiticoneLoadingSpinner_request.OuterCircleRadius = 16
        SiticoneLoadingSpinner_request.ProgressFont = New Font("Segoe UI", 10F)
        SiticoneLoadingSpinner_request.ProgressTextColor = Color.FromArgb(CByte(50), CByte(0), CByte(0), CByte(0))
        SiticoneLoadingSpinner_request.Size = New Size(60, 60)
        SiticoneLoadingSpinner_request.SpinnerColor = Color.DodgerBlue
        SiticoneLoadingSpinner_request.Style = SiticoneNetCoreUI.SiticoneLoadingSpinner.AnimationStyle.Rotation
        SiticoneLoadingSpinner_request.TabIndex = 35
        SiticoneLoadingSpinner_request.Text = "Thinking"
        ' 
        ' SiticoneFlowPanel_prompt_filecontent
        ' 
        SiticoneFlowPanel_prompt_filecontent.AutoSize = True
        SiticoneFlowPanel_prompt_filecontent.Dock = DockStyle.Top
        SiticoneFlowPanel_prompt_filecontent.EnableAnimations = True
        SiticoneFlowPanel_prompt_filecontent.EnableAutoScale = True
        SiticoneFlowPanel_prompt_filecontent.EnableDragDrop = False
        SiticoneFlowPanel_prompt_filecontent.EnableLayoutCaching = True
        SiticoneFlowPanel_prompt_filecontent.EnableSmoothScrolling = True
        SiticoneFlowPanel_prompt_filecontent.EnableSnapToGrid = False
        SiticoneFlowPanel_prompt_filecontent.EnableTransparency = False
        SiticoneFlowPanel_prompt_filecontent.EnableVirtualization = False
        SiticoneFlowPanel_prompt_filecontent.EnableWrapping = True
        SiticoneFlowPanel_prompt_filecontent.GridSize = 8
        SiticoneFlowPanel_prompt_filecontent.IsTrackingTheme = False
        SiticoneFlowPanel_prompt_filecontent.ItemSpacing = 5
        SiticoneFlowPanel_prompt_filecontent.Location = New Point(10, 46)
        SiticoneFlowPanel_prompt_filecontent.Name = "SiticoneFlowPanel_prompt_filecontent"
        SiticoneFlowPanel_prompt_filecontent.Size = New Size(1465, 0)
        SiticoneFlowPanel_prompt_filecontent.TabIndex = 0
        SiticoneFlowPanel_prompt_filecontent.VirtualizationThreshold = 100
        ' 
        ' SiticoneButton_switch_chat
        ' 
        SiticoneButton_switch_chat.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard"
        SiticoneButton_switch_chat.AccessibleName = "Genarate > Chat"
        SiticoneButton_switch_chat.AutoSizeBasedOnText = False
        SiticoneButton_switch_chat.BackColor = Color.Transparent
        SiticoneButton_switch_chat.BadgeBackColor = Color.Red
        SiticoneButton_switch_chat.BadgeFont = New Font("Segoe UI", 8F, FontStyle.Bold)
        SiticoneButton_switch_chat.BadgeValue = 0
        SiticoneButton_switch_chat.BadgeValueForeColor = Color.White
        SiticoneButton_switch_chat.BorderColor = Color.FromArgb(CByte(16), CByte(100), CByte(220))
        SiticoneButton_switch_chat.BorderWidth = 2
        SiticoneButton_switch_chat.ButtonBackColor = Color.FromArgb(CByte(26), CByte(115), CByte(232))
        SiticoneButton_switch_chat.ButtonImage = Nothing
        SiticoneButton_switch_chat.ButtonTextLeftPadding = 0
        SiticoneButton_switch_chat.CanBeep = True
        SiticoneButton_switch_chat.CanGlow = True
        SiticoneButton_switch_chat.CanShake = True
        SiticoneButton_switch_chat.ContextMenuStripEx = Nothing
        SiticoneButton_switch_chat.CornerRadiusBottomLeft = 8
        SiticoneButton_switch_chat.CornerRadiusBottomRight = 8
        SiticoneButton_switch_chat.CornerRadiusTopLeft = 8
        SiticoneButton_switch_chat.CornerRadiusTopRight = 8
        SiticoneButton_switch_chat.CustomCursor = Cursors.Default
        SiticoneButton_switch_chat.DisabledTextColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        SiticoneButton_switch_chat.EnableLongPress = False
        SiticoneButton_switch_chat.EnablePressAnimation = True
        SiticoneButton_switch_chat.EnableRippleEffect = True
        SiticoneButton_switch_chat.EnableShadow = True
        SiticoneButton_switch_chat.EnableTextWrapping = False
        SiticoneButton_switch_chat.Font = New Font("Segoe UI", 9F)
        SiticoneButton_switch_chat.GlowColor = Color.FromArgb(CByte(30), CByte(110), CByte(178), CByte(230))
        SiticoneButton_switch_chat.GlowIntensity = 100
        SiticoneButton_switch_chat.GlowRadius = 20F
        SiticoneButton_switch_chat.GradientBackground = False
        SiticoneButton_switch_chat.GradientColor = Color.FromArgb(CByte(255), CByte(77), CByte(146))
        SiticoneButton_switch_chat.GradientMode = Drawing2D.LinearGradientMode.ForwardDiagonal
        SiticoneButton_switch_chat.HintText = Nothing
        SiticoneButton_switch_chat.HoverBackColor = Color.FromArgb(CByte(40), CByte(130), CByte(240))
        SiticoneButton_switch_chat.HoverFontStyle = FontStyle.Regular
        SiticoneButton_switch_chat.HoverTextColor = Color.White
        SiticoneButton_switch_chat.HoverTransitionDuration = 250
        SiticoneButton_switch_chat.ImageAlign = ContentAlignment.MiddleLeft
        SiticoneButton_switch_chat.ImagePadding = 5
        SiticoneButton_switch_chat.ImageSize = New Size(16, 16)
        SiticoneButton_switch_chat.IsRadial = False
        SiticoneButton_switch_chat.IsReadOnly = False
        SiticoneButton_switch_chat.IsToggleButton = False
        SiticoneButton_switch_chat.IsToggled = False
        SiticoneButton_switch_chat.Location = New Point(1063, 51)
        SiticoneButton_switch_chat.LongPressDurationMS = 1000
        SiticoneButton_switch_chat.Name = "SiticoneButton_switch_chat"
        SiticoneButton_switch_chat.NormalFontStyle = FontStyle.Regular
        SiticoneButton_switch_chat.ParticleColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        SiticoneButton_switch_chat.ParticleCount = 15
        SiticoneButton_switch_chat.PressAnimationScale = 0.97F
        SiticoneButton_switch_chat.PressedBackColor = Color.FromArgb(CByte(16), CByte(100), CByte(220))
        SiticoneButton_switch_chat.PressedFontStyle = FontStyle.Regular
        SiticoneButton_switch_chat.PressTransitionDuration = 150
        SiticoneButton_switch_chat.ReadOnlyTextColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        SiticoneButton_switch_chat.RippleColor = Color.White
        SiticoneButton_switch_chat.RippleOpacity = 0.2F
        SiticoneButton_switch_chat.RippleRadiusMultiplier = 0.6F
        SiticoneButton_switch_chat.ShadowBlur = 5
        SiticoneButton_switch_chat.ShadowColor = Color.FromArgb(CByte(50), CByte(0), CByte(64), CByte(128))
        SiticoneButton_switch_chat.ShadowOffset = New Point(0, 2)
        SiticoneButton_switch_chat.ShakeDuration = 500
        SiticoneButton_switch_chat.ShakeIntensity = 5
        SiticoneButton_switch_chat.Size = New Size(107, 30)
        SiticoneButton_switch_chat.TabIndex = 16
        SiticoneButton_switch_chat.Text = "Genarate > Chat"
        SiticoneButton_switch_chat.TextAlign = ContentAlignment.MiddleCenter
        SiticoneButton_switch_chat.TextColor = Color.White
        SiticoneButton_switch_chat.TooltipText = Nothing
        SiticoneButton_switch_chat.UseAdvancedRendering = True
        SiticoneButton_switch_chat.UseParticles = False
        ' 
        ' SiticoneLabel_default
        ' 
        SiticoneLabel_default.BackColor = Color.Transparent
        SiticoneLabel_default.Font = New Font("Segoe UI", 10F)
        SiticoneLabel_default.Location = New Point(1176, 27)
        SiticoneLabel_default.Name = "SiticoneLabel_default"
        SiticoneLabel_default.Size = New Size(146, 21)
        SiticoneLabel_default.TabIndex = 36
        SiticoneLabel_default.Text = "Load Default Setting:"
        ' 
        ' SiticoneDropdown_default
        ' 
        SiticoneDropdown_default.AllowMultipleSelection = False
        SiticoneDropdown_default.BackColor = Color.FromArgb(CByte(209), CByte(232), CByte(255))
        SiticoneDropdown_default.BorderColor = Color.Gray
        SiticoneDropdown_default.BorderSize = 2
        SiticoneDropdown_default.CanBeep = False
        SiticoneDropdown_default.CanShake = True
        SiticoneDropdown_default.CornerRadius = 8
        SiticoneDropdown_default.DataSource = Nothing
        SiticoneDropdown_default.DisplayMember = Nothing
        SiticoneDropdown_default.DropdownBackColor = Color.White
        SiticoneDropdown_default.DropdownCornerRadius = 8
        SiticoneDropdown_default.DropdownWidth = 0
        SiticoneDropdown_default.DropShadowEnabled = False
        SiticoneDropdown_default.Font = New Font("Segoe UI", 10F)
        SiticoneDropdown_default.ForeColor = Color.DimGray
        SiticoneDropdown_default.HoveredItemBackColor = Color.LightGray
        SiticoneDropdown_default.HoveredItemTextColor = Color.Black
        SiticoneDropdown_default.IsReadonly = False
        SiticoneDropdown_default.ItemHeight = 30
        SiticoneDropdown_default.Location = New Point(1176, 51)
        SiticoneDropdown_default.MaxDropDownItems = 8
        SiticoneDropdown_default.Name = "SiticoneDropdown_default"
        SiticoneDropdown_default.NotFoundBackColor = Color.Transparent
        SiticoneDropdown_default.NotFoundFont = Nothing
        SiticoneDropdown_default.NotFoundTextColor = Color.Gray
        SiticoneDropdown_default.PlaceholderColor = Color.Gray
        SiticoneDropdown_default.PlaceholderDisappearsOnFocus = False
        SiticoneDropdown_default.PlaceholderText = "Select a Default"
        SiticoneDropdown_default.SearchTextColor = Color.DimGray
        SiticoneDropdown_default.SearchTextFont = Nothing
        SiticoneDropdown_default.SelectedIndex = -1
        SiticoneDropdown_default.SelectedItem = Nothing
        SiticoneDropdown_default.SelectedItemBackColor = Color.LightBlue
        SiticoneDropdown_default.SelectedItemTextColor = Color.Black
        SiticoneDropdown_default.SelectedValue = Nothing
        SiticoneDropdown_default.Size = New Size(146, 30)
        SiticoneDropdown_default.TabIndex = 35
        SiticoneDropdown_default.UnselectedItemTextColor = Color.Black
        SiticoneDropdown_default.ValueMember = Nothing
        ' 
        ' SiticoneButton_preload
        ' 
        SiticoneButton_preload.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard"
        SiticoneButton_preload.AccessibleName = "Pre Load LLM"
        SiticoneButton_preload.AutoSizeBasedOnText = False
        SiticoneButton_preload.BackColor = Color.Transparent
        SiticoneButton_preload.BadgeBackColor = Color.Red
        SiticoneButton_preload.BadgeFont = New Font("Segoe UI", 8F, FontStyle.Bold)
        SiticoneButton_preload.BadgeValue = 0
        SiticoneButton_preload.BadgeValueForeColor = Color.White
        SiticoneButton_preload.BorderColor = Color.FromArgb(CByte(16), CByte(100), CByte(220))
        SiticoneButton_preload.BorderWidth = 2
        SiticoneButton_preload.ButtonBackColor = Color.FromArgb(CByte(26), CByte(115), CByte(232))
        SiticoneButton_preload.ButtonImage = Nothing
        SiticoneButton_preload.ButtonTextLeftPadding = 0
        SiticoneButton_preload.CanBeep = True
        SiticoneButton_preload.CanGlow = True
        SiticoneButton_preload.CanShake = True
        SiticoneButton_preload.ContextMenuStripEx = Nothing
        SiticoneButton_preload.CornerRadiusBottomLeft = 8
        SiticoneButton_preload.CornerRadiusBottomRight = 8
        SiticoneButton_preload.CornerRadiusTopLeft = 8
        SiticoneButton_preload.CornerRadiusTopRight = 8
        SiticoneButton_preload.CustomCursor = Cursors.Default
        SiticoneButton_preload.DisabledTextColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        SiticoneButton_preload.Enabled = False
        SiticoneButton_preload.EnableLongPress = False
        SiticoneButton_preload.EnablePressAnimation = True
        SiticoneButton_preload.EnableRippleEffect = True
        SiticoneButton_preload.EnableShadow = True
        SiticoneButton_preload.EnableTextWrapping = False
        SiticoneButton_preload.Font = New Font("Segoe UI", 9F)
        SiticoneButton_preload.GlowColor = Color.FromArgb(CByte(30), CByte(110), CByte(178), CByte(230))
        SiticoneButton_preload.GlowIntensity = 100
        SiticoneButton_preload.GlowRadius = 20F
        SiticoneButton_preload.GradientBackground = False
        SiticoneButton_preload.GradientColor = Color.FromArgb(CByte(255), CByte(77), CByte(146))
        SiticoneButton_preload.GradientMode = Drawing2D.LinearGradientMode.ForwardDiagonal
        SiticoneButton_preload.HintText = Nothing
        SiticoneButton_preload.HoverBackColor = Color.FromArgb(CByte(40), CByte(130), CByte(240))
        SiticoneButton_preload.HoverFontStyle = FontStyle.Regular
        SiticoneButton_preload.HoverTextColor = Color.White
        SiticoneButton_preload.HoverTransitionDuration = 250
        SiticoneButton_preload.ImageAlign = ContentAlignment.MiddleLeft
        SiticoneButton_preload.ImagePadding = 5
        SiticoneButton_preload.ImageSize = New Size(16, 16)
        SiticoneButton_preload.IsRadial = False
        SiticoneButton_preload.IsReadOnly = False
        SiticoneButton_preload.IsToggleButton = False
        SiticoneButton_preload.IsToggled = False
        SiticoneButton_preload.Location = New Point(684, 51)
        SiticoneButton_preload.LongPressDurationMS = 1000
        SiticoneButton_preload.Name = "SiticoneButton_preload"
        SiticoneButton_preload.NormalFontStyle = FontStyle.Regular
        SiticoneButton_preload.ParticleColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        SiticoneButton_preload.ParticleCount = 15
        SiticoneButton_preload.PressAnimationScale = 0.97F
        SiticoneButton_preload.PressedBackColor = Color.FromArgb(CByte(16), CByte(100), CByte(220))
        SiticoneButton_preload.PressedFontStyle = FontStyle.Regular
        SiticoneButton_preload.PressTransitionDuration = 150
        SiticoneButton_preload.ReadOnlyTextColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        SiticoneButton_preload.RippleColor = Color.White
        SiticoneButton_preload.RippleOpacity = 0.2F
        SiticoneButton_preload.RippleRadiusMultiplier = 0.6F
        SiticoneButton_preload.ShadowBlur = 5
        SiticoneButton_preload.ShadowColor = Color.FromArgb(CByte(50), CByte(0), CByte(64), CByte(128))
        SiticoneButton_preload.ShadowOffset = New Point(0, 2)
        SiticoneButton_preload.ShakeDuration = 500
        SiticoneButton_preload.ShakeIntensity = 5
        SiticoneButton_preload.Size = New Size(107, 30)
        SiticoneButton_preload.TabIndex = 37
        SiticoneButton_preload.Text = "Pre Load LLM"
        SiticoneButton_preload.TextAlign = ContentAlignment.MiddleCenter
        SiticoneButton_preload.TextColor = Color.White
        SiticoneButton_preload.TooltipText = Nothing
        SiticoneButton_preload.UseAdvancedRendering = True
        SiticoneButton_preload.UseParticles = False
        ' 
        ' SiticoneLabel_test
        ' 
        SiticoneLabel_test.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        SiticoneLabel_test.BackColor = Color.Transparent
        SiticoneLabel_test.Font = New Font("Segoe UI", 10F)
        SiticoneLabel_test.Location = New Point(1348, 27)
        SiticoneLabel_test.Name = "SiticoneLabel_test"
        SiticoneLabel_test.Size = New Size(112, 21)
        SiticoneLabel_test.TabIndex = 52
        SiticoneLabel_test.Text = "Bypass Test:"
        ' 
        ' SiticoneToggleSwitch_test
        ' 
        SiticoneToggleSwitch_test.AccessibleDescription = "A customizable toggle switch that can be turned on or off."
        SiticoneToggleSwitch_test.AccessibleName = "Siticone Toggle Switch"
        SiticoneToggleSwitch_test.AccessibleRole = AccessibleRole.CheckButton
        SiticoneToggleSwitch_test.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        SiticoneToggleSwitch_test.CanBeep = True
        SiticoneToggleSwitch_test.CanShake = True
        SiticoneToggleSwitch_test.DisabledColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        SiticoneToggleSwitch_test.DisallowToggling = False
        SiticoneToggleSwitch_test.EnableGlowEffect = True
        SiticoneToggleSwitch_test.ExtraThumbSize = 2
        SiticoneToggleSwitch_test.IsOn = False
        SiticoneToggleSwitch_test.IsReadOnly = False
        SiticoneToggleSwitch_test.IsRequired = False
        SiticoneToggleSwitch_test.LabelColor = Color.Black
        SiticoneToggleSwitch_test.LabelFont = New Font("Segoe UI", 9F)
        SiticoneToggleSwitch_test.Location = New Point(1348, 53)
        SiticoneToggleSwitch_test.Logger = Nothing
        SiticoneToggleSwitch_test.Name = "SiticoneToggleSwitch_test"
        SiticoneToggleSwitch_test.OffBackColor1 = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        SiticoneToggleSwitch_test.OffBackColor2 = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        SiticoneToggleSwitch_test.OffBorderColor1 = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        SiticoneToggleSwitch_test.OffBorderColor2 = Color.FromArgb(CByte(229), CByte(229), CByte(229))
        SiticoneToggleSwitch_test.OffIcon = Nothing
        SiticoneToggleSwitch_test.OffThumbColor1 = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        SiticoneToggleSwitch_test.OffThumbColor2 = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        SiticoneToggleSwitch_test.OnBackColor1 = Color.FromArgb(CByte(26), CByte(115), CByte(232))
        SiticoneToggleSwitch_test.OnBackColor2 = Color.FromArgb(CByte(26), CByte(115), CByte(232))
        SiticoneToggleSwitch_test.OnBorderColor1 = Color.FromArgb(CByte(26), CByte(115), CByte(232))
        SiticoneToggleSwitch_test.OnBorderColor2 = Color.FromArgb(CByte(26), CByte(115), CByte(232))
        SiticoneToggleSwitch_test.OnIcon = Nothing
        SiticoneToggleSwitch_test.OnThumbColor1 = Color.White
        SiticoneToggleSwitch_test.OnThumbColor2 = Color.White
        SiticoneToggleSwitch_test.PreventToggleOff = False
        SiticoneToggleSwitch_test.RippleColor = Color.FromArgb(CByte(100), CByte(255), CByte(255), CByte(255))
        SiticoneToggleSwitch_test.RippleExpansionRate = 2F
        SiticoneToggleSwitch_test.RippleOpacityDecay = 0.02F
        SiticoneToggleSwitch_test.Size = New Size(50, 25)
        SiticoneToggleSwitch_test.TabIndex = 51
        SiticoneToggleSwitch_test.ToggleOffSoundPath = ""
        SiticoneToggleSwitch_test.ToggleOnSoundPath = ""
        SiticoneToggleSwitch_test.ToolTipText = "Bypass LLM API Call"
        SiticoneToggleSwitch_test.TrackDeviceTheme = True
        ' 
        ' SiticoneGroupBox_LLM_setting
        ' 
        SiticoneGroupBox_LLM_setting.BackColor = Color.Transparent
        SiticoneGroupBox_LLM_setting.BadgeColor = Color.Red
        SiticoneGroupBox_LLM_setting.BadgeFont = New Font("Segoe UI", 8F, FontStyle.Bold)
        SiticoneGroupBox_LLM_setting.BadgeLeftPadding = 12
        SiticoneGroupBox_LLM_setting.BadgeValue = 0
        SiticoneGroupBox_LLM_setting.BadgeVisible = False
        SiticoneGroupBox_LLM_setting.BlinkInterval = 500
        SiticoneGroupBox_LLM_setting.BlinkMinOpacity = 0.3F
        SiticoneGroupBox_LLM_setting.BlinkOpacityStep = 0.05F
        SiticoneGroupBox_LLM_setting.BorderColor = Color.FromArgb(CByte(220), CByte(222), CByte(224))
        SiticoneGroupBox_LLM_setting.BorderWidth = 1F
        SiticoneGroupBox_LLM_setting.ChevronColor = Color.FromArgb(CByte(90), CByte(90), CByte(90))
        SiticoneGroupBox_LLM_setting.ChevronLeftSpacing = 4F
        SiticoneGroupBox_LLM_setting.ChevronSize = 10F
        SiticoneGroupBox_LLM_setting.ChevronThickness = 2F
        SiticoneGroupBox_LLM_setting.ContentPadding = 5
        SiticoneGroupBox_LLM_setting.Controls.Add(SiticoneLabel_test)
        SiticoneGroupBox_LLM_setting.Controls.Add(SiticoneLabel_host)
        SiticoneGroupBox_LLM_setting.Controls.Add(SiticoneToggleSwitch_test)
        SiticoneGroupBox_LLM_setting.Controls.Add(SiticoneLabel_API)
        SiticoneGroupBox_LLM_setting.Controls.Add(SiticoneDropdown_API)
        SiticoneGroupBox_LLM_setting.Controls.Add(SiticoneButton_preload)
        SiticoneGroupBox_LLM_setting.Controls.Add(SiticoneLabel_chat_clear)
        SiticoneGroupBox_LLM_setting.Controls.Add(SiticoneTextBox_host)
        SiticoneGroupBox_LLM_setting.Controls.Add(SiticoneButton_chat_clear)
        SiticoneGroupBox_LLM_setting.Controls.Add(SiticoneDropdown_model)
        SiticoneGroupBox_LLM_setting.Controls.Add(SiticoneButton_switch_chat)
        SiticoneGroupBox_LLM_setting.Controls.Add(SiticoneButton_get_llm)
        SiticoneGroupBox_LLM_setting.Controls.Add(SiticoneLabel_model)
        SiticoneGroupBox_LLM_setting.Controls.Add(SiticoneLabel_default)
        SiticoneGroupBox_LLM_setting.Controls.Add(SiticoneDropdown_default)
        SiticoneGroupBox_LLM_setting.CornerRadius = 8
        SiticoneGroupBox_LLM_setting.Dock = DockStyle.Bottom
        SiticoneGroupBox_LLM_setting.EnableBlinking = False
        SiticoneGroupBox_LLM_setting.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        SiticoneGroupBox_LLM_setting.GradientEndColor = Color.LightGray
        SiticoneGroupBox_LLM_setting.GradientMode = Drawing2D.LinearGradientMode.Vertical
        SiticoneGroupBox_LLM_setting.GradientStartColor = Color.White
        SiticoneGroupBox_LLM_setting.GroupTitle = "Ollama API Settings"
        SiticoneGroupBox_LLM_setting.HoveredBorderColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        SiticoneGroupBox_LLM_setting.HoveredTitleColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        SiticoneGroupBox_LLM_setting.Location = New Point(2, 777)
        SiticoneGroupBox_LLM_setting.MaxBlinkCount = 3
        SiticoneGroupBox_LLM_setting.Name = "SiticoneGroupBox_LLM_setting"
        SiticoneGroupBox_LLM_setting.PressedBorderColor = Color.FromArgb(CByte(0), CByte(84), CByte(153))
        SiticoneGroupBox_LLM_setting.ShadowColor = Color.FromArgb(CByte(20), CByte(0), CByte(0), CByte(0))
        SiticoneGroupBox_LLM_setting.ShadowDepth = 4
        SiticoneGroupBox_LLM_setting.ShowShadow = True
        SiticoneGroupBox_LLM_setting.Size = New Size(1485, 100)
        SiticoneGroupBox_LLM_setting.SolidFillColor = Color.FromArgb(CByte(249), CByte(249), CByte(249))
        SiticoneGroupBox_LLM_setting.StatusIcon = Nothing
        SiticoneGroupBox_LLM_setting.StatusText = ""
        SiticoneGroupBox_LLM_setting.TabIndex = 59
        SiticoneGroupBox_LLM_setting.TitleBackColor = Color.Transparent
        SiticoneGroupBox_LLM_setting.TitleColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        SiticoneGroupBox_LLM_setting.TitlePadding = New Padding(10, 3, 10, 3)
        SiticoneGroupBox_LLM_setting.TitlePos = SiticoneNetCoreUI.TitlePosition.TopLeft
        SiticoneGroupBox_LLM_setting.UltraFastMode = True
        SiticoneGroupBox_LLM_setting.UseGradient = False
        ' 
        ' SiticoneNavbar_tab
        ' 
        SiticoneNavbar_tab.AnimationDuration = 160
        SiticoneNavbar_tab.BackColor = Color.Transparent
        SiticoneNavbar_tab.BackgroundImageLayout = ImageLayout.None
        SiticoneNavbar_tab.ButtonBorderColor = Color.Transparent
        SiticoneNavbar_tab.ButtonBorderWidth = 3
        SiticoneNavbar_tab.ButtonImage = Nothing
        SiticoneNavbar_tab.ButtonInnerMargin = 2
        SiticoneNavbar_tab.ButtonPadding = New Padding(6, 10, 6, 10)
        SiticoneNavbar_tab.ButtonPressColor = Color.FromArgb(CByte(0), CByte(0), CByte(0))
        SiticoneNavbar_tab.ButtonSpacing = 10
        SiticoneNavbar_tab.ButtonStyle = SiticoneNetCoreUI.NavBarStyle.MaterialTabs
        SiticoneNavbar_tab.CollapseButtonBackColor = Color.White
        SiticoneNavbar_tab.CollapseButtonForeColor = SystemColors.Highlight
        SiticoneNavbar_tab.CollapsedIconSize = 32
        SiticoneNavbar_tab.CollapsedWidth = 70
        SiticoneNavbar_tab.DisabledButtonForeColor = Color.DarkGray
        SiticoneNavbar_tab.Dock = DockStyle.Left
        SiticoneNavbar_tab.ExpandedWidth = 170
        SiticoneNavbar_tab.FocusedButtonBorderColor = Color.DodgerBlue
        SiticoneNavbar_tab.Font = New Font("Segoe UI", 9F)
        SiticoneNavbar_tab.GradientEndColor = Color.FromArgb(CByte(0), CByte(180), CByte(240))
        SiticoneNavbar_tab.GradientStartColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        SiticoneNavbar_tab.HeaderTitle = "Menue"
        SiticoneNavbar_tab.HeaderTitleBackColor = Color.Transparent
        SiticoneNavbar_tab.HeaderTitleFont = New Font("Segoe UI Light", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SiticoneNavbar_tab.HeaderTitleForeColor = Color.Black
        SiticoneNavbar_tab.HeaderTitleHeight = 20
        SiticoneNavbar_tab.HeaderTitlePadding = New Padding(0, 10, 10, 10)
        SiticoneNavbar_tab.HoverButtonBorderColor = Color.Gray
        SiticoneNavbar_tab.IndicatorCornerRadius = 9
        SiticoneNavbar_tab.IndicatorGradientEndColor = Color.FromArgb(CByte(0), CByte(180), CByte(240))
        SiticoneNavbar_tab.IndicatorGradientStartColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        SiticoneNavbar_tab.IsCollapsed = True
        NavBarItem3.BackColor = Color.Empty
        NavBarItem3.BorderColor = Color.Empty
        NavBarItem3.ForeColor = Color.Empty
        NavBarItem3.Image = CType(resources.GetObject("NavBarItem3.Image"), Image)
        NavBarItem3.PressBackColor = Color.Empty
        NavBarItem3.SelectedBackColor = Color.Empty
        NavBarItem3.SelectedBorderColor = Color.Empty
        NavBarItem3.SelectedForeColor = Color.Empty
        NavBarItem3.Text = "Button 1"
        SiticoneNavbar_tab.Items.Add(NavBarItem3)
        SiticoneNavbar_tab.Location = New Point(2, 2)
        SiticoneNavbar_tab.MaterialTabSelectedIndicatorColor = SystemColors.Highlight
        SiticoneNavbar_tab.MaxButtonHeight = 60
        SiticoneNavbar_tab.MinimumHeight = 100
        SiticoneNavbar_tab.Name = "SiticoneNavbar_tab"
        SiticoneNavbar_tab.PreserveButtonSizes = False
        SiticoneNavbar_tab.PressButtonBorderColor = Color.DarkGray
        SiticoneNavbar_tab.RippleEffectNavColor = Color.LightGray
        SiticoneNavbar_tab.SelectedButtonBackColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        SiticoneNavbar_tab.SelectedButtonBorderColor = Color.Black
        SiticoneNavbar_tab.SelectedButtonForeColor = Color.Black
        SiticoneNavbar_tab.SelectedIndex = 0
        SiticoneNavbar_tab.SelectedIndicatorSideColor = Color.FromArgb(CByte(16), CByte(100), CByte(220))
        SiticoneNavbar_tab.SelectedIndicatorThickness = 3
        SiticoneNavbar_tab.SelectedItem = NavBarItem3
        SiticoneNavbar_tab.ShowCollapseButton = True
        SiticoneNavbar_tab.ShowHeaderTitle = True
        SiticoneNavbar_tab.ShowTitleSections = False
        SiticoneNavbar_tab.ShowTitleSeparator = True
        SiticoneNavbar_tab.SidebarBackColor = Color.Transparent
        SiticoneNavbar_tab.SidebarCollapseButtonSize = 16
        SiticoneNavbar_tab.Size = New Size(70, 688)
        SiticoneNavbar_tab.TabIndex = 60
        SiticoneNavbar_tab.Text = "SiticoneNavbar1"
        SiticoneNavbar_tab.TitleSeparatorColor = Color.Gray
        SiticoneNavbar_tab.UnselectedButtonBackColor = Color.Transparent
        SiticoneNavbar_tab.UnselectedButtonBorderColor = Color.FromArgb(CByte(10), CByte(215), CByte(79))
        SiticoneNavbar_tab.UnselectedButtonCursor = Cursors.Default
        SiticoneNavbar_tab.UnselectedButtonForeColor = Color.DimGray
        SiticoneNavbar_tab.UnselectedButtonHoverColor = Color.FromArgb(CByte(0), CByte(0), CByte(0))
        SiticoneNavbar_tab.UnselectedTabIndicatorColor = Color.LightGray
        SiticoneNavbar_tab.UseGradientIndicator = True
        ' 
        ' SiticonePanel_dock
        ' 
        SiticonePanel_dock.AcrylicTintColor = Color.FromArgb(CByte(128), CByte(255), CByte(255), CByte(255))
        SiticonePanel_dock.BackColor = Color.Transparent
        SiticonePanel_dock.BorderAlignment = Drawing2D.PenAlignment.Center
        SiticonePanel_dock.BorderDashPattern = Nothing
        SiticonePanel_dock.BorderGradientEndColor = Color.Purple
        SiticonePanel_dock.BorderGradientStartColor = Color.Blue
        SiticonePanel_dock.BorderThickness = 2F
        SiticonePanel_dock.Controls.Add(SiticoneTabControl_tab)
        SiticonePanel_dock.CornerRadiusBottomLeft = 10F
        SiticonePanel_dock.CornerRadiusBottomRight = 10F
        SiticonePanel_dock.CornerRadiusTopLeft = 10F
        SiticonePanel_dock.CornerRadiusTopRight = 10F
        SiticonePanel_dock.Dock = DockStyle.Fill
        SiticonePanel_dock.EnableAcrylicEffect = False
        SiticonePanel_dock.EnableMicaEffect = False
        SiticonePanel_dock.EnableRippleEffect = False
        SiticonePanel_dock.FillColor = Color.Transparent
        SiticonePanel_dock.GradientColors = New Color() {Color.White, Color.LightGray, Color.Gray}
        SiticonePanel_dock.GradientPositions = New Single() {0F, 0.5F, 1F}
        SiticonePanel_dock.Location = New Point(72, 2)
        SiticonePanel_dock.Name = "SiticonePanel_dock"
        SiticonePanel_dock.PatternStyle = Drawing2D.HatchStyle.Max
        SiticonePanel_dock.RippleAlpha = 50
        SiticonePanel_dock.RippleAlphaDecrement = 3
        SiticonePanel_dock.RippleColor = Color.FromArgb(CByte(50), CByte(255), CByte(255), CByte(255))
        SiticonePanel_dock.RippleMaxSize = 600F
        SiticonePanel_dock.RippleSpeed = 15F
        SiticonePanel_dock.ShowBorder = False
        SiticonePanel_dock.Size = New Size(1415, 688)
        SiticonePanel_dock.TabIndex = 61
        SiticonePanel_dock.TabStop = True
        SiticonePanel_dock.TrackSystemTheme = False
        SiticonePanel_dock.UseBorderGradient = False
        SiticonePanel_dock.UseMultiGradient = False
        SiticonePanel_dock.UsePatternTexture = False
        SiticonePanel_dock.UseRadialGradient = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1489, 879)
        Controls.Add(SiticonePanel_dock)
        Controls.Add(SiticoneNavbar_tab)
        Controls.Add(SiticonePanel_prompt)
        Controls.Add(SiticoneGroupBox_LLM_setting)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(1505, 905)
        Name = "Form1"
        Padding = New Padding(2)
        Text = "Ollama Desktop"
        CType(WebView21, ComponentModel.ISupportInitialize).EndInit()
        SiticoneTabControl_tab.ResumeLayout(False)
        TabPage_modelinfo.ResumeLayout(False)
        TabPage_modelparameter.ResumeLayout(False)
        TabPage_modelparameter.PerformLayout()
        SiticoneFlatPanel_trenn3.ResumeLayout(False)
        SiticoneFlatPanel_thinking_use.ResumeLayout(False)
        SiticoneFlatPanel_trenn2.ResumeLayout(False)
        SiticoneFlatPanel_trenn1.ResumeLayout(False)
        SiticoneFlatPanel_last_context.ResumeLayout(False)
        SiticoneFlatPanel_format_use.ResumeLayout(False)
        SiticoneFlatPanel_system_use.ResumeLayout(False)
        CType(dgv_option, ComponentModel.ISupportInitialize).EndInit()
        TabPage_tool.ResumeLayout(False)
        TabPage_tool.PerformLayout()
        SiticoneFlatPanel_tools.ResumeLayout(False)
        TabPage_ragtool.ResumeLayout(False)
        TabPage_ragtool.PerformLayout()
        SiticoneFlatPanel_ragtools.ResumeLayout(False)
        TabPage_requestjson.ResumeLayout(False)
        TabPage_responsejson.ResumeLayout(False)
        TabPage_responsemd.ResumeLayout(False)
        TabPage_responsehtml.ResumeLayout(False)
        TabPage_codeparameter.ResumeLayout(False)
        CType(dvg_execute, ComponentModel.ISupportInitialize).EndInit()
        TabPage_codeblock.ResumeLayout(False)
        SiticoneFlatPanel_UseShellExecute.ResumeLayout(False)
        SiticoneSplitContainer_runcont.Panel1.ResumeLayout(False)
        SiticoneSplitContainer_runcont.Panel2.ResumeLayout(False)
        SiticoneSplitContainer_runcont.Panel2.PerformLayout()
        CType(SiticoneSplitContainer_runcont, ComponentModel.ISupportInitialize).EndInit()
        SiticoneSplitContainer_runcont.ResumeLayout(False)
        SiticonePanel_prompt.ResumeLayout(False)
        SiticonePanel_prompt.PerformLayout()
        SiticonePanel_prompt_action.ResumeLayout(False)
        SiticoneGroupBox_LLM_setting.ResumeLayout(False)
        SiticonePanel_dock.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents WebView21 As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents SiticoneTextBox_num_predict As SiticoneNetCoreUI.SiticoneTextBox
    Friend WithEvents SiticoneTextBox_host As SiticoneNetCoreUI.SiticoneTextBox
    Friend WithEvents SiticoneDropdown_model As SiticoneNetCoreUI.SiticoneDropdown
    Friend WithEvents SiticoneButton_get_llm As SiticoneNetCoreUI.SiticoneButton
    Friend WithEvents SiticoneTextArea_prompt As SiticoneNetCoreUI.SiticoneTextArea
    Friend WithEvents SiticoneButton_file As SiticoneNetCoreUI.SiticoneButton
    Friend WithEvents SiticonehProgressBar1 As SiticoneNetCoreUI.SiticoneHProgressBar
    Friend WithEvents SiticoneTabControl_tab As SiticoneNetCoreUI.SiticoneTabControl
    Friend WithEvents TabPage_modelparameter As TabPage
    Friend WithEvents TabPage_requestjson As TabPage
    Friend WithEvents TabPage_responsejson As TabPage
    Friend WithEvents TabPage_responsemd As TabPage
    Friend WithEvents TabPage_responsehtml As TabPage
    Friend WithEvents SiticoneTextArea_system As SiticoneNetCoreUI.SiticoneTextArea
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents TabPage_modelinfo As TabPage
    Friend WithEvents SiticoneLabel_host As SiticoneNetCoreUI.SiticoneLabel
    Friend WithEvents SiticoneLabel_model As SiticoneNetCoreUI.SiticoneLabel
    Friend WithEvents SiticoneLabel4 As SiticoneNetCoreUI.SiticoneLabel
    Friend WithEvents TabPage_codeblock As TabPage
    Friend WithEvents SiticoneDropdown_language As SiticoneNetCoreUI.SiticoneDropdown
    Friend WithEvents SiticoneButton_code_run As SiticoneNetCoreUI.SiticoneButton
    Friend WithEvents SiticoneSplitContainer_runcont As SiticoneNetCoreUI.SiticoneSplitContainer
    Friend WithEvents SiticoneTextArea_run_output As SiticoneNetCoreUI.SiticoneTextArea
    Friend WithEvents SiticoneLabel_runpath As SiticoneNetCoreUI.SiticoneLabel
    Friend WithEvents SiticoneButton_chat_clear As SiticoneNetCoreUI.SiticoneButton
    Friend WithEvents SiticoneDropdown_API As SiticoneNetCoreUI.SiticoneDropdown
    Friend WithEvents SiticoneLabel_API As SiticoneNetCoreUI.SiticoneLabel
    Friend WithEvents SiticoneLabel_chat_clear As SiticoneNetCoreUI.SiticoneLabel
    Friend WithEvents SiticoneButton_HTMLtoPDF As SiticoneNetCoreUI.SiticoneButton
    Friend WithEvents SiticoneButton_code_save As SiticoneNetCoreUI.SiticoneButton
    Friend WithEvents SiticoneLoadingSpinner_request As SiticoneNetCoreUI.SiticoneLoadingSpinner
    Friend WithEvents SiticonePlayPauseButton_request As SiticoneNetCoreUI.SiticonePlayPauseButton
    Friend WithEvents dgv_option As DataGridView
    Friend WithEvents SiticoneLabel1 As SiticoneNetCoreUI.SiticoneLabel
    Friend WithEvents TabPage_codeparameter As TabPage
    Friend WithEvents dvg_execute As DataGridView
    Friend WithEvents SiticoneLabel2 As SiticoneNetCoreUI.SiticoneLabel
    Friend WithEvents MySiticoneLicenseSettings1 As SiticoneNetCoreUI.MySiticoneLicenseSettings
    Friend WithEvents SiticoneButton_save_parameter As SiticoneNetCoreUI.SiticoneButton
    Friend WithEvents SiticoneButton_load_parameter As SiticoneNetCoreUI.SiticoneButton
    Friend WithEvents SiticoneButton_ragpath As SiticoneNetCoreUI.SiticoneButton
    Friend WithEvents SiticoneButton2 As SiticoneNetCoreUI.SiticoneButton
    Friend WithEvents SiticoneButton_load_execute As SiticoneNetCoreUI.SiticoneButton
    Friend WithEvents SiticoneButton_save_execute As SiticoneNetCoreUI.SiticoneButton
    Friend WithEvents SiticoneTextBox_timeout As SiticoneNetCoreUI.SiticoneTextBox
    Friend WithEvents SiticoneLabel5 As SiticoneNetCoreUI.SiticoneLabel
    Friend WithEvents SiticoneLabel6 As SiticoneNetCoreUI.SiticoneLabel
    Friend WithEvents TabPage_tool As TabPage
    Friend WithEvents SiticoneLabel8 As SiticoneNetCoreUI.SiticoneLabel
    Friend WithEvents SiticoneLabel7 As SiticoneNetCoreUI.SiticoneLabel
    Friend WithEvents SiticoneTextArea_Tools_system As SiticoneNetCoreUI.SiticoneTextArea
    Friend WithEvents SiticoneLabel9 As SiticoneNetCoreUI.SiticoneLabel
    Friend WithEvents SiticoneTextBox_request_answer As SiticoneNetCoreUI.SiticoneTextBox
    Friend WithEvents SiticoneButton_load_tools As SiticoneNetCoreUI.SiticoneButton
    Friend WithEvents SiticoneButton_save_tools As SiticoneNetCoreUI.SiticoneButton
    Friend WithEvents SiticoneButton_switch_chat As SiticoneNetCoreUI.SiticoneButton
    Friend WithEvents SiticoneButton_resp_clp As SiticoneNetCoreUI.SiticoneButton
    Friend WithEvents SiticoneButton_screenshot As SiticoneNetCoreUI.SiticoneButton
    Friend WithEvents SiticoneLabel1_model_info_description As SiticoneNetCoreUI.SiticoneLabel
    Friend WithEvents SiticoneChip_model_info_Vision As SiticoneNetCoreUI.SiticoneChip
    Friend WithEvents SiticoneChip_model_info_Tools As SiticoneNetCoreUI.SiticoneChip
    Friend WithEvents SiticoneChip_model_info_Context As SiticoneNetCoreUI.SiticoneChip
    Friend WithEvents SiticoneChip_model_info_Embedding As SiticoneNetCoreUI.SiticoneChip
    Friend WithEvents SiticoneChip_model_info_Thinking As SiticoneNetCoreUI.SiticoneChip
    Friend WithEvents TabPage_ragtool As TabPage
    Friend WithEvents SiticoneLabel1_ragpath As SiticoneNetCoreUI.SiticoneLabel
    Friend WithEvents SiticoneTextBox_ragpath As SiticoneNetCoreUI.SiticoneTextBox
    Friend WithEvents SiticoneLabel10 As SiticoneNetCoreUI.SiticoneLabel
    Friend WithEvents SiticoneLabel_SentencesCount As SiticoneNetCoreUI.SiticoneLabel
    Friend WithEvents SiticoneLabel_SentencesCountVal As SiticoneNetCoreUI.SiticoneLabel
    Friend WithEvents SiticoneLabel_HitCountVal As SiticoneNetCoreUI.SiticoneLabel
    Friend WithEvents SiticoneLabel_HitCount As SiticoneNetCoreUI.SiticoneLabel
    Friend WithEvents SiticoneButton_resp_clp_rag As SiticoneNetCoreUI.SiticoneButton
    Friend WithEvents SiticoneDropdown_delta_val As SiticoneNetCoreUI.SiticoneDropdown
    Friend WithEvents SiticoneLabel1_delta As SiticoneNetCoreUI.SiticoneLabel
    Friend WithEvents SiticoneDropdown_thinking_use As SiticoneNetCoreUI.SiticoneDropdown
    Friend WithEvents SiticoneButton_show_thinking As SiticoneNetCoreUI.SiticoneButton
    Friend WithEvents SiticoneButton_link_options_parameter As SiticoneNetCoreUI.SiticoneButton
    Friend WithEvents SiticoneButton_show_licence As SiticoneNetCoreUI.SiticoneButton
    Friend WithEvents SiticoneButton_timing As SiticoneNetCoreUI.SiticoneButton
    Friend WithEvents SiticoneTextArea_Rag_system As SiticoneNetCoreUI.SiticoneTextArea
    Friend WithEvents SiticoneLabel11 As SiticoneNetCoreUI.SiticoneLabel
    Friend WithEvents SiticoneLabel12 As SiticoneNetCoreUI.SiticoneLabel
    Friend WithEvents SiticoneButton_load_rag As SiticoneNetCoreUI.SiticoneButton
    Friend WithEvents SiticoneButton_save_rag As SiticoneNetCoreUI.SiticoneButton
    Friend WithEvents SiticoneLabel_default As SiticoneNetCoreUI.SiticoneLabel
    Friend WithEvents SiticoneDropdown_default As SiticoneNetCoreUI.SiticoneDropdown
    Friend WithEvents SiticoneButton_link_system_prompt As SiticoneNetCoreUI.SiticoneButton
    Friend WithEvents SiticoneButton_link_output_format As SiticoneNetCoreUI.SiticoneButton
    Friend WithEvents SiticoneButton_link_tool_system_prompt As SiticoneNetCoreUI.SiticoneButton
    Friend WithEvents SiticoneButton_link_tool_python_code As SiticoneNetCoreUI.SiticoneButton
    Friend WithEvents SiticoneButton_link_tool_json As SiticoneNetCoreUI.SiticoneButton
    Friend WithEvents SiticoneTextArea_content_prompt As SiticoneNetCoreUI.SiticoneTextArea
    Friend WithEvents SiticoneLabel13 As SiticoneNetCoreUI.SiticoneLabel
    Friend WithEvents SiticoneButton_link_content_prompt As SiticoneNetCoreUI.SiticoneButton
    Friend WithEvents SiticoneButton_link_rag_tool_json As SiticoneNetCoreUI.SiticoneButton
    Friend WithEvents SiticoneButton_link_rag_tool_system_prompt As SiticoneNetCoreUI.SiticoneButton
    Friend WithEvents SiticoneButton_link_execute_list As SiticoneNetCoreUI.SiticoneButton
    Friend WithEvents Scintilla_model_info_request As ScintillaNET.Scintilla
    Friend WithEvents Scintilla_model_info As ScintillaNET.Scintilla
    Friend WithEvents Scintilla_format As ScintillaNET.Scintilla
    Friend WithEvents Scintilla_Tools_Json As ScintillaNET.Scintilla
    Friend WithEvents Scintilla_Tools_pythoncode As ScintillaNET.Scintilla
    Friend WithEvents Scintilla_Rag_Json As ScintillaNET.Scintilla
    Friend WithEvents Scintilla_Request_JSON As ScintillaNET.Scintilla
    Friend WithEvents Scintilla_Response_JSON As ScintillaNET.Scintilla
    Friend WithEvents Scintilla_response As ScintillaNET.Scintilla
    Friend WithEvents Scintilla_code_block As ScintillaNET.Scintilla
    Friend WithEvents SiticoneButton_execute_run As SiticoneNetCoreUI.SiticoneButton
    Friend WithEvents SiticoneButton_preload As SiticoneNetCoreUI.SiticoneButton
    Friend WithEvents SiticonePanel_prompt As SiticoneNetCoreUI.SiticonePanel
    Friend WithEvents SiticoneFlowPanel_prompt_filecontent As SiticoneNetCoreUI.SiticoneFlowPanel
    Friend WithEvents SiticonePanel_prompt_action As SiticoneNetCoreUI.SiticonePanel
    Friend WithEvents SiticonePanel_llm_load As SiticoneNetCoreUI.SiticonePanel
    Friend WithEvents SiticoneLabel_show_LLM As SiticoneNetCoreUI.SiticoneLabel
    Friend WithEvents SiticoneToggleSwitch_test As SiticoneNetCoreUI.SiticoneToggleSwitch
    Friend WithEvents SiticoneLabel_test As SiticoneNetCoreUI.SiticoneLabel
    Friend WithEvents SiticoneToggleSwitch_system_use As SiticoneNetCoreUI.SiticoneToggleSwitch
    Friend WithEvents SiticoneFlatPanel_system_use As SiticoneNetCoreUI.SiticoneFlatPanel
    Friend WithEvents SiticoneLabel_system_use As SiticoneNetCoreUI.SiticoneLabel
    Friend WithEvents SiticoneFlatPanel_format_use As SiticoneNetCoreUI.SiticoneFlatPanel
    Friend WithEvents SiticoneLabel_format_use As SiticoneNetCoreUI.SiticoneLabel
    Friend WithEvents SiticoneToggleSwitch_format_use As SiticoneNetCoreUI.SiticoneToggleSwitch
    Friend WithEvents SiticoneFlatPanel_thinking_use As SiticoneNetCoreUI.SiticoneFlatPanel
    Friend WithEvents SiticoneLabel_thinking_use As SiticoneNetCoreUI.SiticoneLabel
    Friend WithEvents SiticoneToggleSwitch_thinking_use As SiticoneNetCoreUI.SiticoneToggleSwitch
    Friend WithEvents SiticoneFlatPanel_last_context As SiticoneNetCoreUI.SiticoneFlatPanel
    Friend WithEvents SiticoneFlatPanel_tools As SiticoneNetCoreUI.SiticoneFlatPanel
    Friend WithEvents SiticoneLabel_tools As SiticoneNetCoreUI.SiticoneLabel
    Friend WithEvents SiticoneToggleSwitch_tools As SiticoneNetCoreUI.SiticoneToggleSwitch
    Friend WithEvents SiticoneFlatPanel_ragtools As SiticoneNetCoreUI.SiticoneFlatPanel
    Friend WithEvents SiticoneLabel_ragtools As SiticoneNetCoreUI.SiticoneLabel
    Friend WithEvents SiticoneToggleSwitch_ragtools As SiticoneNetCoreUI.SiticoneToggleSwitch
    Friend WithEvents SiticoneFlatPanel_UseShellExecute As SiticoneNetCoreUI.SiticoneFlatPanel
    Friend WithEvents SiticoneLabel_UseShellExecute As SiticoneNetCoreUI.SiticoneLabel
    Friend WithEvents SiticoneToggleSwitch_UseShellExecute As SiticoneNetCoreUI.SiticoneToggleSwitch
    Friend WithEvents SiticoneGroupBox_LLM_setting As SiticoneNetCoreUI.SiticoneGroupBox
    Friend WithEvents SiticoneFlatPanel_trenn1 As SiticoneNetCoreUI.SiticoneFlatPanel
    Friend WithEvents SiticoneLabel_last_context As SiticoneNetCoreUI.SiticoneLabel
    Friend WithEvents SiticoneToggleSwitch_last_context As SiticoneNetCoreUI.SiticoneToggleSwitch
    Friend WithEvents SiticoneButton_save_context As SiticoneNetCoreUI.SiticoneButton
    Friend WithEvents SiticoneButton_clear_context As SiticoneNetCoreUI.SiticoneButton
    Friend WithEvents SiticoneButton_load_context As SiticoneNetCoreUI.SiticoneButton
    Friend WithEvents SiticoneFlatPanel_trenn3 As SiticoneNetCoreUI.SiticoneFlatPanel
    Friend WithEvents SiticoneFlatPanel_trenn2 As SiticoneNetCoreUI.SiticoneFlatPanel
    Friend WithEvents SiticoneNavbar_tab As SiticoneNetCoreUI.SiticoneNavbar
    Friend WithEvents SiticonePanel_dock As SiticoneNetCoreUI.SiticonePanel
    Friend WithEvents SiticoneToggleSwitch_show_menue As SiticoneNetCoreUI.SiticoneToggleSwitch
    Friend WithEvents SiticoneChip_model_info_Image As SiticoneNetCoreUI.SiticoneChip

End Class
