<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegisterForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Me.components = New System.ComponentModel.Container()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2ControlBox3 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.gctrlclose = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.gbtnsignup = New Guna.UI2.WinForms.Guna2Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.gcheckshow2 = New Guna.UI2.WinForms.Guna2ImageCheckBox()
        Me.gcheckshow1 = New Guna.UI2.WinForms.Guna2ImageCheckBox()
        Me.gtbxconfirmpass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.gtbxemail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.gtbxnewpass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.gtbxuname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.gbtnback = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 25)
        Me.Label1.TabIndex = 7
        '
        'Guna2ControlBox3
        '
        Me.Guna2ControlBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox
        Me.Guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Guna2ControlBox3.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Guna2ControlBox3.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox3.Location = New System.Drawing.Point(507, 1)
        Me.Guna2ControlBox3.Name = "Guna2ControlBox3"
        Me.Guna2ControlBox3.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox3.TabIndex = 6
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(462, 1)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox2.TabIndex = 5
        '
        'gctrlclose
        '
        Me.gctrlclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gctrlclose.FillColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.gctrlclose.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.gctrlclose.IconColor = System.Drawing.Color.White
        Me.gctrlclose.Location = New System.Drawing.Point(552, 1)
        Me.gctrlclose.Name = "gctrlclose"
        Me.gctrlclose.Size = New System.Drawing.Size(45, 29)
        Me.gctrlclose.TabIndex = 4
        '
        'gbtnsignup
        '
        Me.gbtnsignup.BackColor = System.Drawing.Color.Transparent
        Me.gbtnsignup.BorderRadius = 15
        Me.gbtnsignup.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gbtnsignup.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnsignup.ForeColor = System.Drawing.Color.White
        Me.gbtnsignup.Location = New System.Drawing.Point(389, 329)
        Me.gbtnsignup.Name = "gbtnsignup"
        Me.gbtnsignup.Size = New System.Drawing.Size(155, 35)
        Me.gbtnsignup.TabIndex = 25
        Me.gbtnsignup.Text = "Sign up"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(306, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 18)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Sign up to explore"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(300, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 32)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Sign up"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox3)
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox2)
        Me.Guna2Panel1.Controls.Add(Me.gctrlclose)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(600, 30)
        Me.Guna2Panel1.TabIndex = 17
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 1.0R
        Me.Guna2DragControl1.DragStartTransparencyValue = 1.0R
        Me.Guna2DragControl1.TargetControl = Me.Guna2Panel1
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'gcheckshow2
        '
        Me.gcheckshow2.BackColor = System.Drawing.Color.Transparent
        Me.gcheckshow2.CheckedState.Image = Global.METmoneyandexpensetracker.My.Resources.Resources.ShowPass_icon48
        Me.gcheckshow2.CheckedState.ImageSize = New System.Drawing.Size(30, 30)
        Me.gcheckshow2.Image = Global.METmoneyandexpensetracker.My.Resources.Resources.HidePass_icon50
        Me.gcheckshow2.ImageOffset = New System.Drawing.Point(0, 0)
        Me.gcheckshow2.ImageRotate = 0!
        Me.gcheckshow2.ImageSize = New System.Drawing.Size(25, 25)
        Me.gcheckshow2.Location = New System.Drawing.Point(503, 273)
        Me.gcheckshow2.Name = "gcheckshow2"
        Me.gcheckshow2.Size = New System.Drawing.Size(30, 30)
        Me.gcheckshow2.TabIndex = 29
        '
        'gcheckshow1
        '
        Me.gcheckshow1.BackColor = System.Drawing.Color.Transparent
        Me.gcheckshow1.CheckedState.Image = Global.METmoneyandexpensetracker.My.Resources.Resources.ShowPass_icon48
        Me.gcheckshow1.CheckedState.ImageSize = New System.Drawing.Size(30, 30)
        Me.gcheckshow1.Image = Global.METmoneyandexpensetracker.My.Resources.Resources.HidePass_icon50
        Me.gcheckshow1.ImageOffset = New System.Drawing.Point(0, 0)
        Me.gcheckshow1.ImageRotate = 0!
        Me.gcheckshow1.ImageSize = New System.Drawing.Size(25, 25)
        Me.gcheckshow1.Location = New System.Drawing.Point(503, 230)
        Me.gcheckshow1.Name = "gcheckshow1"
        Me.gcheckshow1.Size = New System.Drawing.Size(30, 30)
        Me.gcheckshow1.TabIndex = 28
        '
        'gtbxconfirmpass
        '
        Me.gtbxconfirmpass.BackColor = System.Drawing.Color.Transparent
        Me.gtbxconfirmpass.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gtbxconfirmpass.BorderRadius = 15
        Me.gtbxconfirmpass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.gtbxconfirmpass.DefaultText = ""
        Me.gtbxconfirmpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gtbxconfirmpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.gtbxconfirmpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gtbxconfirmpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gtbxconfirmpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gtbxconfirmpass.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gtbxconfirmpass.ForeColor = System.Drawing.Color.Black
        Me.gtbxconfirmpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.gtbxconfirmpass.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gtbxconfirmpass.IconLeft = Global.METmoneyandexpensetracker.My.Resources.Resources.Pass_icon
        Me.gtbxconfirmpass.IconRightSize = New System.Drawing.Size(25, 25)
        Me.gtbxconfirmpass.Location = New System.Drawing.Point(289, 270)
        Me.gtbxconfirmpass.Margin = New System.Windows.Forms.Padding(4)
        Me.gtbxconfirmpass.Name = "gtbxconfirmpass"
        Me.gtbxconfirmpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.gtbxconfirmpass.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gtbxconfirmpass.PlaceholderText = "Confirm Password"
        Me.gtbxconfirmpass.SelectedText = ""
        Me.gtbxconfirmpass.Size = New System.Drawing.Size(255, 35)
        Me.gtbxconfirmpass.TabIndex = 27
        '
        'gtbxemail
        '
        Me.gtbxemail.BackColor = System.Drawing.Color.Transparent
        Me.gtbxemail.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gtbxemail.BorderRadius = 15
        Me.gtbxemail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.gtbxemail.DefaultText = ""
        Me.gtbxemail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gtbxemail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.gtbxemail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gtbxemail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gtbxemail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gtbxemail.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gtbxemail.ForeColor = System.Drawing.Color.Black
        Me.gtbxemail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.gtbxemail.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gtbxemail.IconLeft = Global.METmoneyandexpensetracker.My.Resources.Resources.Email_icon
        Me.gtbxemail.IconRightSize = New System.Drawing.Size(25, 25)
        Me.gtbxemail.Location = New System.Drawing.Point(289, 185)
        Me.gtbxemail.Margin = New System.Windows.Forms.Padding(4)
        Me.gtbxemail.Name = "gtbxemail"
        Me.gtbxemail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.gtbxemail.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gtbxemail.PlaceholderText = "Email"
        Me.gtbxemail.SelectedText = ""
        Me.gtbxemail.Size = New System.Drawing.Size(255, 35)
        Me.gtbxemail.TabIndex = 26
        '
        'gtbxnewpass
        '
        Me.gtbxnewpass.BackColor = System.Drawing.Color.Transparent
        Me.gtbxnewpass.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gtbxnewpass.BorderRadius = 15
        Me.gtbxnewpass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.gtbxnewpass.DefaultText = ""
        Me.gtbxnewpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gtbxnewpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.gtbxnewpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gtbxnewpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gtbxnewpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gtbxnewpass.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gtbxnewpass.ForeColor = System.Drawing.Color.Black
        Me.gtbxnewpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.gtbxnewpass.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gtbxnewpass.IconLeft = Global.METmoneyandexpensetracker.My.Resources.Resources.Pass_icon
        Me.gtbxnewpass.IconRightSize = New System.Drawing.Size(25, 25)
        Me.gtbxnewpass.Location = New System.Drawing.Point(289, 227)
        Me.gtbxnewpass.Margin = New System.Windows.Forms.Padding(4)
        Me.gtbxnewpass.Name = "gtbxnewpass"
        Me.gtbxnewpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.gtbxnewpass.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gtbxnewpass.PlaceholderText = "New Password"
        Me.gtbxnewpass.SelectedText = ""
        Me.gtbxnewpass.Size = New System.Drawing.Size(255, 35)
        Me.gtbxnewpass.TabIndex = 23
        '
        'gtbxuname
        '
        Me.gtbxuname.BackColor = System.Drawing.Color.Transparent
        Me.gtbxuname.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gtbxuname.BorderRadius = 15
        Me.gtbxuname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.gtbxuname.DefaultText = ""
        Me.gtbxuname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gtbxuname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.gtbxuname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gtbxuname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gtbxuname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gtbxuname.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gtbxuname.ForeColor = System.Drawing.Color.Black
        Me.gtbxuname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.gtbxuname.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gtbxuname.IconLeft = Global.METmoneyandexpensetracker.My.Resources.Resources.User_icon
        Me.gtbxuname.IconRightSize = New System.Drawing.Size(25, 25)
        Me.gtbxuname.Location = New System.Drawing.Point(289, 142)
        Me.gtbxuname.Margin = New System.Windows.Forms.Padding(4)
        Me.gtbxuname.Name = "gtbxuname"
        Me.gtbxuname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.gtbxuname.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gtbxuname.PlaceholderText = "Username"
        Me.gtbxuname.SelectedText = ""
        Me.gtbxuname.Size = New System.Drawing.Size(255, 35)
        Me.gtbxuname.TabIndex = 22
        '
        'gbtnback
        '
        Me.gbtnback.BackColor = System.Drawing.Color.Transparent
        Me.gbtnback.BorderRadius = 10
        Me.gbtnback.FillColor = System.Drawing.Color.Transparent
        Me.gbtnback.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnback.ForeColor = System.Drawing.Color.Black
        Me.gbtnback.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gbtnback.HoverState.ForeColor = System.Drawing.Color.Black
        Me.gbtnback.Image = Global.METmoneyandexpensetracker.My.Resources.Resources.Back_icon48
        Me.gbtnback.Location = New System.Drawing.Point(300, 40)
        Me.gbtnback.Margin = New System.Windows.Forms.Padding(0)
        Me.gbtnback.Name = "gbtnback"
        Me.gbtnback.Size = New System.Drawing.Size(71, 24)
        Me.gbtnback.TabIndex = 21
        Me.gbtnback.Text = "Back"
        '
        'RegisterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(600, 400)
        Me.Controls.Add(Me.gcheckshow2)
        Me.Controls.Add(Me.gcheckshow1)
        Me.Controls.Add(Me.gtbxconfirmpass)
        Me.Controls.Add(Me.gtbxemail)
        Me.Controls.Add(Me.gtbxnewpass)
        Me.Controls.Add(Me.gbtnsignup)
        Me.Controls.Add(Me.gtbxuname)
        Me.Controls.Add(Me.gbtnback)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RegisterForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegisterForm"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents gtbxconfirmpass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents gtbxemail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents gtbxnewpass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents gbtnsignup As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents gtbxuname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents gbtnback As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents gctrlclose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents gcheckshow1 As Guna.UI2.WinForms.Guna2ImageCheckBox
    Friend WithEvents gcheckshow2 As Guna.UI2.WinForms.Guna2ImageCheckBox
End Class
