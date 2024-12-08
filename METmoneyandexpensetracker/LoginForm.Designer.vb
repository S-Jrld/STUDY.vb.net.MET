<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ControlBox3 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.gctrlclose = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gbtnforgot = New Guna.UI2.WinForms.Guna2Button()
        Me.gbtnlogin = New Guna.UI2.WinForms.Guna2Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gcheckshow = New Guna.UI2.WinForms.Guna2ImageCheckBox()
        Me.glogtbxpass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.glogtbxname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.gbtnback = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 1.0R
        Me.Guna2DragControl1.DragStartTransparencyValue = 1.0R
        Me.Guna2DragControl1.TargetControl = Me.Guna2Panel1
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox3)
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox2)
        Me.Guna2Panel1.Controls.Add(Me.gctrlclose)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(900, 46)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Guna2ControlBox3
        '
        Me.Guna2ControlBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox
        Me.Guna2ControlBox3.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox3.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Guna2ControlBox3.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox3.Location = New System.Drawing.Point(760, 2)
        Me.Guna2ControlBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Guna2ControlBox3.Name = "Guna2ControlBox3"
        Me.Guna2ControlBox3.Size = New System.Drawing.Size(68, 45)
        Me.Guna2ControlBox3.TabIndex = 6
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(693, 2)
        Me.Guna2ControlBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(68, 45)
        Me.Guna2ControlBox2.TabIndex = 5
        '
        'gctrlclose
        '
        Me.gctrlclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gctrlclose.FillColor = System.Drawing.Color.Transparent
        Me.gctrlclose.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.gctrlclose.IconColor = System.Drawing.Color.White
        Me.gctrlclose.Location = New System.Drawing.Point(828, 2)
        Me.gctrlclose.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gctrlclose.Name = "gctrlclose"
        Me.gctrlclose.Size = New System.Drawing.Size(68, 45)
        Me.gctrlclose.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(444, 111)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 48)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Login"
        '
        'gbtnforgot
        '
        Me.gbtnforgot.FillColor = System.Drawing.Color.Transparent
        Me.gbtnforgot.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnforgot.ForeColor = System.Drawing.Color.Black
        Me.gbtnforgot.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gbtnforgot.HoverState.ForeColor = System.Drawing.Color.Black
        Me.gbtnforgot.Location = New System.Drawing.Point(402, 371)
        Me.gbtnforgot.Margin = New System.Windows.Forms.Padding(0)
        Me.gbtnforgot.Name = "gbtnforgot"
        Me.gbtnforgot.Size = New System.Drawing.Size(244, 34)
        Me.gbtnforgot.TabIndex = 15
        Me.gbtnforgot.Text = "Forgot password?"
        '
        'gbtnlogin
        '
        Me.gbtnlogin.BorderRadius = 15
        Me.gbtnlogin.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gbtnlogin.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnlogin.ForeColor = System.Drawing.Color.White
        Me.gbtnlogin.Location = New System.Drawing.Point(434, 457)
        Me.gbtnlogin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbtnlogin.Name = "gbtnlogin"
        Me.gbtnlogin.Size = New System.Drawing.Size(382, 54)
        Me.gbtnlogin.TabIndex = 16
        Me.gbtnlogin.Text = "Access My Account"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(453, 165)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(233, 27)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Login to continue"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.METmoneyandexpensetracker.My.Resources.Resources.Designer__3__removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(64, 125)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(283, 265)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'gcheckshow
        '
        Me.gcheckshow.BackColor = System.Drawing.Color.White
        Me.gcheckshow.CheckedState.Image = Global.METmoneyandexpensetracker.My.Resources.Resources.ShowPass_icon48
        Me.gcheckshow.CheckedState.ImageSize = New System.Drawing.Size(30, 30)
        Me.gcheckshow.Image = Global.METmoneyandexpensetracker.My.Resources.Resources.HidePass_icon50
        Me.gcheckshow.ImageOffset = New System.Drawing.Point(0, 0)
        Me.gcheckshow.ImageRotate = 0!
        Me.gcheckshow.ImageSize = New System.Drawing.Size(25, 25)
        Me.gcheckshow.Location = New System.Drawing.Point(757, 302)
        Me.gcheckshow.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gcheckshow.Name = "gcheckshow"
        Me.gcheckshow.Size = New System.Drawing.Size(45, 46)
        Me.gcheckshow.TabIndex = 29
        '
        'glogtbxpass
        '
        Me.glogtbxpass.BackColor = System.Drawing.Color.Transparent
        Me.glogtbxpass.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.glogtbxpass.BorderRadius = 15
        Me.glogtbxpass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.glogtbxpass.DefaultText = ""
        Me.glogtbxpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.glogtbxpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.glogtbxpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.glogtbxpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.glogtbxpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.glogtbxpass.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.glogtbxpass.ForeColor = System.Drawing.Color.Black
        Me.glogtbxpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.glogtbxpass.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.glogtbxpass.IconLeft = Global.METmoneyandexpensetracker.My.Resources.Resources.Pass_icon
        Me.glogtbxpass.IconLeftSize = New System.Drawing.Size(25, 25)
        Me.glogtbxpass.Location = New System.Drawing.Point(434, 297)
        Me.glogtbxpass.Margin = New System.Windows.Forms.Padding(6)
        Me.glogtbxpass.Name = "glogtbxpass"
        Me.glogtbxpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.glogtbxpass.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.glogtbxpass.PlaceholderText = "Password"
        Me.glogtbxpass.SelectedText = ""
        Me.glogtbxpass.Size = New System.Drawing.Size(382, 54)
        Me.glogtbxpass.TabIndex = 14
        '
        'glogtbxname
        '
        Me.glogtbxname.BackColor = System.Drawing.Color.Transparent
        Me.glogtbxname.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.glogtbxname.BorderRadius = 15
        Me.glogtbxname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.glogtbxname.DefaultText = ""
        Me.glogtbxname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.glogtbxname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.glogtbxname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.glogtbxname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.glogtbxname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.glogtbxname.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.glogtbxname.ForeColor = System.Drawing.Color.Black
        Me.glogtbxname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.glogtbxname.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.glogtbxname.IconLeft = Global.METmoneyandexpensetracker.My.Resources.Resources.User_icon
        Me.glogtbxname.IconLeftSize = New System.Drawing.Size(25, 25)
        Me.glogtbxname.Location = New System.Drawing.Point(434, 220)
        Me.glogtbxname.Margin = New System.Windows.Forms.Padding(6)
        Me.glogtbxname.Name = "glogtbxname"
        Me.glogtbxname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.glogtbxname.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.glogtbxname.PlaceholderText = "Username"
        Me.glogtbxname.SelectedText = ""
        Me.glogtbxname.Size = New System.Drawing.Size(382, 54)
        Me.glogtbxname.TabIndex = 13
        '
        'gbtnback
        '
        Me.gbtnback.FillColor = System.Drawing.Color.Transparent
        Me.gbtnback.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnback.ForeColor = System.Drawing.Color.Black
        Me.gbtnback.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gbtnback.HoverState.ForeColor = System.Drawing.Color.Black
        Me.gbtnback.Image = Global.METmoneyandexpensetracker.My.Resources.Resources.Back_icon48
        Me.gbtnback.Location = New System.Drawing.Point(450, 62)
        Me.gbtnback.Margin = New System.Windows.Forms.Padding(0)
        Me.gbtnback.Name = "gbtnback"
        Me.gbtnback.PressedColor = System.Drawing.Color.Transparent
        Me.gbtnback.Size = New System.Drawing.Size(98, 34)
        Me.gbtnback.TabIndex = 12
        Me.gbtnback.Text = "Back"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(120, 371)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(201, 62)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "M.E.T."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(900, 615)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.gcheckshow)
        Me.Controls.Add(Me.gbtnlogin)
        Me.Controls.Add(Me.gbtnforgot)
        Me.Controls.Add(Me.glogtbxpass)
        Me.Controls.Add(Me.glogtbxname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.gbtnback)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginForm"
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents gctrlclose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents gbtnback As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label5 As Label
    Friend WithEvents glogtbxname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents glogtbxpass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents gbtnforgot As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents gbtnlogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents gcheckshow As Guna.UI2.WinForms.Guna2ImageCheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
End Class
