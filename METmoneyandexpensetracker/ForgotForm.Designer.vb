<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gforbtncnl = New Guna.UI2.WinForms.Guna2Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2ControlBox3 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.gforbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.gfortbxcon = New Guna.UI2.WinForms.Guna2TextBox()
        Me.gfortbxnew = New Guna.UI2.WinForms.Guna2TextBox()
        Me.gfortbxname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.gckbxshow1 = New Guna.UI2.WinForms.Guna2ImageCheckBox()
        Me.gckbxshow2 = New Guna.UI2.WinForms.Guna2ImageCheckBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me.Guna2Panel1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(270, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 16)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "response to error"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'gforbtncnl
        '
        Me.gforbtncnl.CheckedState.Parent = Me.gforbtncnl
        Me.gforbtncnl.CustomImages.Parent = Me.gforbtncnl
        Me.gforbtncnl.FillColor = System.Drawing.Color.Transparent
        Me.gforbtncnl.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gforbtncnl.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.gforbtncnl.HoverState.Parent = Me.gforbtncnl
        Me.gforbtncnl.Location = New System.Drawing.Point(277, 347)
        Me.gforbtncnl.Name = "gforbtncnl"
        Me.gforbtncnl.ShadowDecoration.Parent = Me.gforbtncnl
        Me.gforbtncnl.Size = New System.Drawing.Size(72, 27)
        Me.gforbtncnl.TabIndex = 33
        Me.gforbtncnl.Text = "Cancel"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(304, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(246, 16)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "you can change your password here"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(326, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(190, 25)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Forgot password?"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox3)
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(600, 30)
        Me.Guna2Panel1.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "M.E.T"
        '
        'Guna2ControlBox3
        '
        Me.Guna2ControlBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox
        Me.Guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Guna2ControlBox3.HoverState.Parent = Me.Guna2ControlBox3
        Me.Guna2ControlBox3.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox3.Location = New System.Drawing.Point(505, 1)
        Me.Guna2ControlBox3.Name = "Guna2ControlBox3"
        Me.Guna2ControlBox3.ShadowDecoration.Parent = Me.Guna2ControlBox3
        Me.Guna2ControlBox3.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox3.TabIndex = 6
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Guna2ControlBox2.HoverState.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(460, 1)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.ShadowDecoration.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox2.TabIndex = 5
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(550, 1)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox1.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(41, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 48)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "'A good budget tracking" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "is the way to become" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "wealth-hacking'" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(229, 21)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Money and Expense Tracker"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(74, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 39)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "M.E.T"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.Label4)
        Me.Guna2Panel2.Controls.Add(Me.Label3)
        Me.Guna2Panel2.Controls.Add(Me.Label2)
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 29)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(247, 371)
        Me.Guna2Panel2.TabIndex = 30
        '
        'gforbtn
        '
        Me.gforbtn.BorderRadius = 10
        Me.gforbtn.CheckedState.Parent = Me.gforbtn
        Me.gforbtn.CustomImages.Parent = Me.gforbtn
        Me.gforbtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.gforbtn.ForeColor = System.Drawing.Color.White
        Me.gforbtn.HoverState.Parent = Me.gforbtn
        Me.gforbtn.Location = New System.Drawing.Point(430, 334)
        Me.gforbtn.Name = "gforbtn"
        Me.gforbtn.ShadowDecoration.Parent = Me.gforbtn
        Me.gforbtn.Size = New System.Drawing.Size(143, 40)
        Me.gforbtn.TabIndex = 36
        Me.gforbtn.Text = "Confirm"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.METmoneyandexpensetracker.My.Resources.Resources.Pass_icon
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(396, 55)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 40
        Me.Guna2PictureBox1.TabStop = False
        '
        'gfortbxcon
        '
        Me.gfortbxcon.BorderRadius = 12
        Me.gfortbxcon.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.gfortbxcon.DefaultText = ""
        Me.gfortbxcon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gfortbxcon.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.gfortbxcon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gfortbxcon.DisabledState.Parent = Me.gfortbxcon
        Me.gfortbxcon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gfortbxcon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gfortbxcon.FocusedState.Parent = Me.gfortbxcon
        Me.gfortbxcon.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gfortbxcon.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gfortbxcon.HoverState.Parent = Me.gfortbxcon
        Me.gfortbxcon.IconLeft = Global.METmoneyandexpensetracker.My.Resources.Resources.Pass_icon
        Me.gfortbxcon.IconLeftSize = New System.Drawing.Size(30, 30)
        Me.gfortbxcon.Location = New System.Drawing.Point(273, 277)
        Me.gfortbxcon.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gfortbxcon.Name = "gfortbxcon"
        Me.gfortbxcon.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.gfortbxcon.PlaceholderText = "Confirm Password"
        Me.gfortbxcon.SelectedText = ""
        Me.gfortbxcon.ShadowDecoration.Parent = Me.gfortbxcon
        Me.gfortbxcon.Size = New System.Drawing.Size(300, 40)
        Me.gfortbxcon.TabIndex = 39
        '
        'gfortbxnew
        '
        Me.gfortbxnew.BorderRadius = 12
        Me.gfortbxnew.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.gfortbxnew.DefaultText = ""
        Me.gfortbxnew.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gfortbxnew.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.gfortbxnew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gfortbxnew.DisabledState.Parent = Me.gfortbxnew
        Me.gfortbxnew.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gfortbxnew.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gfortbxnew.FocusedState.Parent = Me.gfortbxnew
        Me.gfortbxnew.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gfortbxnew.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gfortbxnew.HoverState.Parent = Me.gfortbxnew
        Me.gfortbxnew.IconLeft = Global.METmoneyandexpensetracker.My.Resources.Resources.Pass_icon
        Me.gfortbxnew.IconLeftSize = New System.Drawing.Size(30, 30)
        Me.gfortbxnew.Location = New System.Drawing.Point(273, 230)
        Me.gfortbxnew.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gfortbxnew.Name = "gfortbxnew"
        Me.gfortbxnew.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.gfortbxnew.PlaceholderText = "New Password"
        Me.gfortbxnew.SelectedText = ""
        Me.gfortbxnew.ShadowDecoration.Parent = Me.gfortbxnew
        Me.gfortbxnew.Size = New System.Drawing.Size(300, 40)
        Me.gfortbxnew.TabIndex = 38
        '
        'gfortbxname
        '
        Me.gfortbxname.BorderRadius = 12
        Me.gfortbxname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.gfortbxname.DefaultText = ""
        Me.gfortbxname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gfortbxname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.gfortbxname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gfortbxname.DisabledState.Parent = Me.gfortbxname
        Me.gfortbxname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gfortbxname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gfortbxname.FocusedState.Parent = Me.gfortbxname
        Me.gfortbxname.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gfortbxname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gfortbxname.HoverState.Parent = Me.gfortbxname
        Me.gfortbxname.IconLeft = Global.METmoneyandexpensetracker.My.Resources.Resources.User_icon
        Me.gfortbxname.IconLeftSize = New System.Drawing.Size(30, 30)
        Me.gfortbxname.Location = New System.Drawing.Point(273, 184)
        Me.gfortbxname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gfortbxname.Name = "gfortbxname"
        Me.gfortbxname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.gfortbxname.PlaceholderText = "Username"
        Me.gfortbxname.SelectedText = ""
        Me.gfortbxname.ShadowDecoration.Parent = Me.gfortbxname
        Me.gfortbxname.Size = New System.Drawing.Size(300, 40)
        Me.gfortbxname.TabIndex = 37
        '
        'gckbxshow1
        '
        Me.gckbxshow1.BackColor = System.Drawing.Color.White
        Me.gckbxshow1.CheckedState.Image = Global.METmoneyandexpensetracker.My.Resources.Resources.ShowPass_icon48
        Me.gckbxshow1.CheckedState.ImageSize = New System.Drawing.Size(30, 30)
        Me.gckbxshow1.CheckedState.Parent = Me.gckbxshow1
        Me.gckbxshow1.HoverState.Parent = Me.gckbxshow1
        Me.gckbxshow1.Image = Global.METmoneyandexpensetracker.My.Resources.Resources.HidePass_icon50
        Me.gckbxshow1.ImageSize = New System.Drawing.Size(30, 30)
        Me.gckbxshow1.Location = New System.Drawing.Point(534, 235)
        Me.gckbxshow1.Name = "gckbxshow1"
        Me.gckbxshow1.PressedState.Parent = Me.gckbxshow1
        Me.gckbxshow1.Size = New System.Drawing.Size(30, 30)
        Me.gckbxshow1.TabIndex = 41
        '
        'gckbxshow2
        '
        Me.gckbxshow2.BackColor = System.Drawing.Color.White
        Me.gckbxshow2.CheckedState.Image = Global.METmoneyandexpensetracker.My.Resources.Resources.ShowPass_icon48
        Me.gckbxshow2.CheckedState.ImageSize = New System.Drawing.Size(30, 30)
        Me.gckbxshow2.CheckedState.Parent = Me.gckbxshow2
        Me.gckbxshow2.HoverState.Parent = Me.gckbxshow2
        Me.gckbxshow2.Image = Global.METmoneyandexpensetracker.My.Resources.Resources.HidePass_icon50
        Me.gckbxshow2.ImageSize = New System.Drawing.Size(30, 30)
        Me.gckbxshow2.Location = New System.Drawing.Point(534, 282)
        Me.gckbxshow2.Name = "gckbxshow2"
        Me.gckbxshow2.PressedState.Parent = Me.gckbxshow2
        Me.gckbxshow2.Size = New System.Drawing.Size(30, 30)
        Me.gckbxshow2.TabIndex = 42
        '
        'ForgotForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 400)
        Me.Controls.Add(Me.gckbxshow2)
        Me.Controls.Add(Me.gckbxshow1)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.gfortbxcon)
        Me.Controls.Add(Me.gforbtncnl)
        Me.Controls.Add(Me.gfortbxnew)
        Me.Controls.Add(Me.gfortbxname)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.gforbtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ForgotForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ForgotForm"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Label7 As Label
    Friend WithEvents gforbtncnl As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents gforbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents gfortbxcon As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents gfortbxnew As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents gfortbxname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents gckbxshow2 As Guna.UI2.WinForms.Guna2ImageCheckBox
    Friend WithEvents gckbxshow1 As Guna.UI2.WinForms.Guna2ImageCheckBox
End Class
