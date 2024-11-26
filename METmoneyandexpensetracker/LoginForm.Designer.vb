<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2ControlBox3 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.glogbtnreg = New Guna.UI2.WinForms.Guna2Button()
        Me.glogbtnfor = New Guna.UI2.WinForms.Guna2Button()
        Me.glogbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.glogtbxpass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.glogtbxname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.gckbxshow1 = New Guna.UI2.WinForms.Guna2ImageCheckBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
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
        Me.Guna2Panel1.TabIndex = 0
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
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.Label4)
        Me.Guna2Panel2.Controls.Add(Me.Label3)
        Me.Guna2Panel2.Controls.Add(Me.Label2)
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 29)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(247, 371)
        Me.Guna2Panel2.TabIndex = 1
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(253, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 39)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Login"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(256, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(198, 21)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Don't have an account?"
        '
        'glogbtnreg
        '
        Me.glogbtnreg.CheckedState.Parent = Me.glogbtnreg
        Me.glogbtnreg.CustomImages.Parent = Me.glogbtnreg
        Me.glogbtnreg.FillColor = System.Drawing.Color.Transparent
        Me.glogbtnreg.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.glogbtnreg.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.glogbtnreg.HoverState.Parent = Me.glogbtnreg
        Me.glogbtnreg.Location = New System.Drawing.Point(450, 80)
        Me.glogbtnreg.Name = "glogbtnreg"
        Me.glogbtnreg.ShadowDecoration.Parent = Me.glogbtnreg
        Me.glogbtnreg.Size = New System.Drawing.Size(72, 27)
        Me.glogbtnreg.TabIndex = 12
        Me.glogbtnreg.Text = "Register"
        '
        'glogbtnfor
        '
        Me.glogbtnfor.CheckedState.Parent = Me.glogbtnfor
        Me.glogbtnfor.CustomImages.Parent = Me.glogbtnfor
        Me.glogbtnfor.FillColor = System.Drawing.Color.Transparent
        Me.glogbtnfor.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.glogbtnfor.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.glogbtnfor.HoverState.Parent = Me.glogbtnfor
        Me.glogbtnfor.Location = New System.Drawing.Point(344, 348)
        Me.glogbtnfor.Name = "glogbtnfor"
        Me.glogbtnfor.ShadowDecoration.Parent = Me.glogbtnfor
        Me.glogbtnfor.Size = New System.Drawing.Size(161, 27)
        Me.glogbtnfor.TabIndex = 15
        Me.glogbtnfor.Text = "Forgot password?"
        '
        'glogbtn
        '
        Me.glogbtn.BorderRadius = 10
        Me.glogbtn.CheckedState.Parent = Me.glogbtn
        Me.glogbtn.CustomImages.Parent = Me.glogbtn
        Me.glogbtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.glogbtn.ForeColor = System.Drawing.Color.White
        Me.glogbtn.HoverState.Parent = Me.glogbtn
        Me.glogbtn.Location = New System.Drawing.Point(274, 302)
        Me.glogbtn.Name = "glogbtn"
        Me.glogbtn.ShadowDecoration.Parent = Me.glogbtn
        Me.glogbtn.Size = New System.Drawing.Size(300, 40)
        Me.glogbtn.TabIndex = 16
        Me.glogbtn.Text = "Login"
        '
        'glogtbxpass
        '
        Me.glogtbxpass.BorderRadius = 12
        Me.glogtbxpass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.glogtbxpass.DefaultText = ""
        Me.glogtbxpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.glogtbxpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.glogtbxpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.glogtbxpass.DisabledState.Parent = Me.glogtbxpass
        Me.glogtbxpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.glogtbxpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.glogtbxpass.FocusedState.Parent = Me.glogtbxpass
        Me.glogtbxpass.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.glogtbxpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.glogtbxpass.HoverState.Parent = Me.glogtbxpass
        Me.glogtbxpass.IconLeft = Global.METmoneyandexpensetracker.My.Resources.Resources.Pass_icon
        Me.glogtbxpass.IconLeftSize = New System.Drawing.Size(30, 30)
        Me.glogtbxpass.Location = New System.Drawing.Point(274, 222)
        Me.glogtbxpass.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.glogtbxpass.Name = "glogtbxpass"
        Me.glogtbxpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.glogtbxpass.PlaceholderText = "Password"
        Me.glogtbxpass.SelectedText = ""
        Me.glogtbxpass.ShadowDecoration.Parent = Me.glogtbxpass
        Me.glogtbxpass.Size = New System.Drawing.Size(300, 40)
        Me.glogtbxpass.TabIndex = 14
        '
        'glogtbxname
        '
        Me.glogtbxname.BorderRadius = 12
        Me.glogtbxname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.glogtbxname.DefaultText = ""
        Me.glogtbxname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.glogtbxname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.glogtbxname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.glogtbxname.DisabledState.Parent = Me.glogtbxname
        Me.glogtbxname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.glogtbxname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.glogtbxname.FocusedState.Parent = Me.glogtbxname
        Me.glogtbxname.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.glogtbxname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.glogtbxname.HoverState.Parent = Me.glogtbxname
        Me.glogtbxname.IconLeft = Global.METmoneyandexpensetracker.My.Resources.Resources.User_icon
        Me.glogtbxname.IconLeftSize = New System.Drawing.Size(30, 30)
        Me.glogtbxname.Location = New System.Drawing.Point(274, 154)
        Me.glogtbxname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.glogtbxname.Name = "glogtbxname"
        Me.glogtbxname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.glogtbxname.PlaceholderText = "Username"
        Me.glogtbxname.SelectedText = ""
        Me.glogtbxname.ShadowDecoration.Parent = Me.glogtbxname
        Me.glogtbxname.Size = New System.Drawing.Size(300, 40)
        Me.glogtbxname.TabIndex = 13
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
        Me.gckbxshow1.Location = New System.Drawing.Point(535, 227)
        Me.gckbxshow1.Name = "gckbxshow1"
        Me.gckbxshow1.PressedState.Parent = Me.gckbxshow1
        Me.gckbxshow1.Size = New System.Drawing.Size(30, 30)
        Me.gckbxshow1.TabIndex = 29
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 400)
        Me.Controls.Add(Me.gckbxshow1)
        Me.Controls.Add(Me.glogbtn)
        Me.Controls.Add(Me.glogbtnfor)
        Me.Controls.Add(Me.glogtbxpass)
        Me.Controls.Add(Me.glogtbxname)
        Me.Controls.Add(Me.glogbtnreg)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginForm"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents glogbtnreg As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents glogtbxname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents glogtbxpass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents glogbtnfor As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents glogbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents gckbxshow1 As Guna.UI2.WinForms.Guna2ImageCheckBox
End Class
