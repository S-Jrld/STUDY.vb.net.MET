<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountSecurityForm
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
        Me.Guna2ControlBox3 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.glogbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.glogbtnreg = New Guna.UI2.WinForms.Guna2Button()
        Me.gckbxshow2 = New Guna.UI2.WinForms.Guna2ImageCheckBox()
        Me.gckbxshow1 = New Guna.UI2.WinForms.Guna2ImageCheckBox()
        Me.gregtbxcon = New Guna.UI2.WinForms.Guna2TextBox()
        Me.gregtbxnew = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1.SuspendLayout()
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
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(500, 30)
        Me.Guna2Panel1.TabIndex = 1
        '
        'Guna2ControlBox3
        '
        Me.Guna2ControlBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox
        Me.Guna2ControlBox3.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox3.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Guna2ControlBox3.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox3.Location = New System.Drawing.Point(407, 1)
        Me.Guna2ControlBox3.Name = "Guna2ControlBox3"
        Me.Guna2ControlBox3.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox3.TabIndex = 3
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(362, 1)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox2.TabIndex = 2
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(452, 1)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox1.TabIndex = 1
        '
        'glogbtn
        '
        Me.glogbtn.BackColor = System.Drawing.Color.Transparent
        Me.glogbtn.BorderRadius = 15
        Me.glogbtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.glogbtn.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.glogbtn.ForeColor = System.Drawing.Color.White
        Me.glogbtn.Location = New System.Drawing.Point(325, 314)
        Me.glogbtn.Name = "glogbtn"
        Me.glogbtn.Size = New System.Drawing.Size(155, 35)
        Me.glogbtn.TabIndex = 49
        Me.glogbtn.Text = "Change"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(230, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 32)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Change password"
        '
        'glogbtnreg
        '
        Me.glogbtnreg.FillColor = System.Drawing.Color.Transparent
        Me.glogbtnreg.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.glogbtnreg.ForeColor = System.Drawing.Color.Black
        Me.glogbtnreg.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.glogbtnreg.HoverState.ForeColor = System.Drawing.Color.Black
        Me.glogbtnreg.Image = Global.METmoneyandexpensetracker.My.Resources.Resources.Back_icon48
        Me.glogbtnreg.Location = New System.Drawing.Point(211, 41)
        Me.glogbtnreg.Margin = New System.Windows.Forms.Padding(0)
        Me.glogbtnreg.Name = "glogbtnreg"
        Me.glogbtnreg.PressedColor = System.Drawing.Color.Transparent
        Me.glogbtnreg.Size = New System.Drawing.Size(65, 22)
        Me.glogbtnreg.TabIndex = 46
        Me.glogbtnreg.Text = "Back"
        '
        'gckbxshow2
        '
        Me.gckbxshow2.BackColor = System.Drawing.Color.Transparent
        Me.gckbxshow2.CheckedState.Image = Global.METmoneyandexpensetracker.My.Resources.Resources.ShowPass_icon48
        Me.gckbxshow2.CheckedState.ImageSize = New System.Drawing.Size(30, 30)
        Me.gckbxshow2.Image = Global.METmoneyandexpensetracker.My.Resources.Resources.HidePass_icon50
        Me.gckbxshow2.ImageOffset = New System.Drawing.Point(0, 0)
        Me.gckbxshow2.ImageRotate = 0!
        Me.gckbxshow2.ImageSize = New System.Drawing.Size(25, 25)
        Me.gckbxshow2.Location = New System.Drawing.Point(439, 228)
        Me.gckbxshow2.Name = "gckbxshow2"
        Me.gckbxshow2.Size = New System.Drawing.Size(30, 30)
        Me.gckbxshow2.TabIndex = 53
        '
        'gckbxshow1
        '
        Me.gckbxshow1.BackColor = System.Drawing.Color.Transparent
        Me.gckbxshow1.CheckedState.Image = Global.METmoneyandexpensetracker.My.Resources.Resources.ShowPass_icon48
        Me.gckbxshow1.CheckedState.ImageSize = New System.Drawing.Size(30, 30)
        Me.gckbxshow1.Image = Global.METmoneyandexpensetracker.My.Resources.Resources.HidePass_icon50
        Me.gckbxshow1.ImageOffset = New System.Drawing.Point(0, 0)
        Me.gckbxshow1.ImageRotate = 0!
        Me.gckbxshow1.ImageSize = New System.Drawing.Size(25, 25)
        Me.gckbxshow1.Location = New System.Drawing.Point(439, 168)
        Me.gckbxshow1.Name = "gckbxshow1"
        Me.gckbxshow1.Size = New System.Drawing.Size(30, 30)
        Me.gckbxshow1.TabIndex = 52
        '
        'gregtbxcon
        '
        Me.gregtbxcon.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gregtbxcon.BorderRadius = 15
        Me.gregtbxcon.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.gregtbxcon.DefaultText = ""
        Me.gregtbxcon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gregtbxcon.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.gregtbxcon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gregtbxcon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gregtbxcon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gregtbxcon.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gregtbxcon.ForeColor = System.Drawing.Color.Black
        Me.gregtbxcon.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.gregtbxcon.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gregtbxcon.IconLeft = Global.METmoneyandexpensetracker.My.Resources.Resources.Pass_icon
        Me.gregtbxcon.IconRightSize = New System.Drawing.Size(25, 25)
        Me.gregtbxcon.Location = New System.Drawing.Point(225, 225)
        Me.gregtbxcon.Margin = New System.Windows.Forms.Padding(4)
        Me.gregtbxcon.Name = "gregtbxcon"
        Me.gregtbxcon.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.gregtbxcon.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gregtbxcon.PlaceholderText = "Confirm Password"
        Me.gregtbxcon.SelectedText = ""
        Me.gregtbxcon.Size = New System.Drawing.Size(255, 35)
        Me.gregtbxcon.TabIndex = 51
        '
        'gregtbxnew
        '
        Me.gregtbxnew.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gregtbxnew.BorderRadius = 15
        Me.gregtbxnew.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.gregtbxnew.DefaultText = ""
        Me.gregtbxnew.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gregtbxnew.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.gregtbxnew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gregtbxnew.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gregtbxnew.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gregtbxnew.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gregtbxnew.ForeColor = System.Drawing.Color.Black
        Me.gregtbxnew.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.gregtbxnew.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gregtbxnew.IconLeft = Global.METmoneyandexpensetracker.My.Resources.Resources.Pass_icon
        Me.gregtbxnew.IconRightSize = New System.Drawing.Size(25, 25)
        Me.gregtbxnew.Location = New System.Drawing.Point(225, 165)
        Me.gregtbxnew.Margin = New System.Windows.Forms.Padding(4)
        Me.gregtbxnew.Name = "gregtbxnew"
        Me.gregtbxnew.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.gregtbxnew.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gregtbxnew.PlaceholderText = "New Password"
        Me.gregtbxnew.SelectedText = ""
        Me.gregtbxnew.Size = New System.Drawing.Size(255, 35)
        Me.gregtbxnew.TabIndex = 50
        '
        'AccountSecurityForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(500, 400)
        Me.Controls.Add(Me.gckbxshow2)
        Me.Controls.Add(Me.gckbxshow1)
        Me.Controls.Add(Me.gregtbxcon)
        Me.Controls.Add(Me.gregtbxnew)
        Me.Controls.Add(Me.glogbtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.glogbtnreg)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AccountSecurityForm"
        Me.Text = "AccountSecurityForm"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents glogbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents glogbtnreg As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents gckbxshow2 As Guna.UI2.WinForms.Guna2ImageCheckBox
    Friend WithEvents gckbxshow1 As Guna.UI2.WinForms.Guna2ImageCheckBox
    Friend WithEvents gregtbxcon As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents gregtbxnew As Guna.UI2.WinForms.Guna2TextBox
End Class
