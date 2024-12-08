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
        Me.gbtnchangepass = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gcmbstatus = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.gcheckshow0 = New Guna.UI2.WinForms.Guna2ImageCheckBox()
        Me.gtbxcurrentpass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.gcheckshow2 = New Guna.UI2.WinForms.Guna2ImageCheckBox()
        Me.gcheckshow1 = New Guna.UI2.WinForms.Guna2ImageCheckBox()
        Me.gtbxconfirmpass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.gtbxnewpass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.gbtnback = New Guna.UI2.WinForms.Guna2Button()
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
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(488, 46)
        Me.Guna2Panel1.TabIndex = 1
        '
        'gbtnchangepass
        '
        Me.gbtnchangepass.BackColor = System.Drawing.Color.Transparent
        Me.gbtnchangepass.BorderRadius = 15
        Me.gbtnchangepass.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gbtnchangepass.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnchangepass.ForeColor = System.Drawing.Color.White
        Me.gbtnchangepass.Location = New System.Drawing.Point(130, 447)
        Me.gbtnchangepass.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbtnchangepass.Name = "gbtnchangepass"
        Me.gbtnchangepass.Size = New System.Drawing.Size(232, 54)
        Me.gbtnchangepass.TabIndex = 49
        Me.gbtnchangepass.Text = "Change"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(40, 140)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(388, 48)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Account Password"
        '
        'gcmbstatus
        '
        Me.gcmbstatus.BackColor = System.Drawing.Color.Transparent
        Me.gcmbstatus.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gcmbstatus.BorderRadius = 15
        Me.gcmbstatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.gcmbstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.gcmbstatus.FocusedColor = System.Drawing.Color.Empty
        Me.gcmbstatus.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gcmbstatus.ForeColor = System.Drawing.Color.Black
        Me.gcmbstatus.FormattingEnabled = True
        Me.gcmbstatus.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.gcmbstatus.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gcmbstatus.ItemHeight = 30
        Me.gcmbstatus.Items.AddRange(New Object() {"AccountSecurity", "ChangePassword"})
        Me.gcmbstatus.Location = New System.Drawing.Point(188, 65)
        Me.gcmbstatus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gcmbstatus.Name = "gcmbstatus"
        Me.gcmbstatus.Size = New System.Drawing.Size(242, 36)
        Me.gcmbstatus.TabIndex = 56
        '
        'gcheckshow0
        '
        Me.gcheckshow0.BackColor = System.Drawing.Color.Transparent
        Me.gcheckshow0.CheckedState.Image = Global.METmoneyandexpensetracker.My.Resources.Resources.ShowPass_icon48
        Me.gcheckshow0.CheckedState.ImageSize = New System.Drawing.Size(30, 30)
        Me.gcheckshow0.Image = Global.METmoneyandexpensetracker.My.Resources.Resources.HidePass_icon50
        Me.gcheckshow0.ImageOffset = New System.Drawing.Point(0, 0)
        Me.gcheckshow0.ImageRotate = 0!
        Me.gcheckshow0.ImageSize = New System.Drawing.Size(25, 25)
        Me.gcheckshow0.Location = New System.Drawing.Point(369, 223)
        Me.gcheckshow0.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gcheckshow0.Name = "gcheckshow0"
        Me.gcheckshow0.Size = New System.Drawing.Size(45, 46)
        Me.gcheckshow0.TabIndex = 55
        Me.gcheckshow0.UseTransparentBackground = True
        '
        'gtbxcurrentpass
        '
        Me.gtbxcurrentpass.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gtbxcurrentpass.BorderRadius = 15
        Me.gtbxcurrentpass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.gtbxcurrentpass.DefaultText = ""
        Me.gtbxcurrentpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gtbxcurrentpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.gtbxcurrentpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gtbxcurrentpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gtbxcurrentpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gtbxcurrentpass.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gtbxcurrentpass.ForeColor = System.Drawing.Color.Black
        Me.gtbxcurrentpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.gtbxcurrentpass.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gtbxcurrentpass.IconLeft = Global.METmoneyandexpensetracker.My.Resources.Resources.Pass_icon
        Me.gtbxcurrentpass.IconRightSize = New System.Drawing.Size(25, 25)
        Me.gtbxcurrentpass.Location = New System.Drawing.Point(50, 218)
        Me.gtbxcurrentpass.Margin = New System.Windows.Forms.Padding(6)
        Me.gtbxcurrentpass.Name = "gtbxcurrentpass"
        Me.gtbxcurrentpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.gtbxcurrentpass.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gtbxcurrentpass.PlaceholderText = "Current password"
        Me.gtbxcurrentpass.SelectedText = ""
        Me.gtbxcurrentpass.Size = New System.Drawing.Size(382, 54)
        Me.gtbxcurrentpass.TabIndex = 54
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
        Me.gcheckshow2.Location = New System.Drawing.Point(369, 374)
        Me.gcheckshow2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gcheckshow2.Name = "gcheckshow2"
        Me.gcheckshow2.Size = New System.Drawing.Size(45, 46)
        Me.gcheckshow2.TabIndex = 53
        Me.gcheckshow2.UseTransparentBackground = True
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
        Me.gcheckshow1.Location = New System.Drawing.Point(369, 309)
        Me.gcheckshow1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gcheckshow1.Name = "gcheckshow1"
        Me.gcheckshow1.Size = New System.Drawing.Size(45, 46)
        Me.gcheckshow1.TabIndex = 52
        Me.gcheckshow1.UseTransparentBackground = True
        '
        'gtbxconfirmpass
        '
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
        Me.gtbxconfirmpass.Location = New System.Drawing.Point(50, 368)
        Me.gtbxconfirmpass.Margin = New System.Windows.Forms.Padding(6)
        Me.gtbxconfirmpass.Name = "gtbxconfirmpass"
        Me.gtbxconfirmpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.gtbxconfirmpass.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gtbxconfirmpass.PlaceholderText = "Confirm Password"
        Me.gtbxconfirmpass.SelectedText = ""
        Me.gtbxconfirmpass.Size = New System.Drawing.Size(382, 54)
        Me.gtbxconfirmpass.TabIndex = 51
        '
        'gtbxnewpass
        '
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
        Me.gtbxnewpass.Location = New System.Drawing.Point(50, 303)
        Me.gtbxnewpass.Margin = New System.Windows.Forms.Padding(6)
        Me.gtbxnewpass.Name = "gtbxnewpass"
        Me.gtbxnewpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.gtbxnewpass.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gtbxnewpass.PlaceholderText = "New Password"
        Me.gtbxnewpass.SelectedText = ""
        Me.gtbxnewpass.Size = New System.Drawing.Size(382, 54)
        Me.gtbxnewpass.TabIndex = 50
        '
        'gbtnback
        '
        Me.gbtnback.FillColor = System.Drawing.Color.Transparent
        Me.gbtnback.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnback.ForeColor = System.Drawing.Color.Black
        Me.gbtnback.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gbtnback.HoverState.ForeColor = System.Drawing.Color.Black
        Me.gbtnback.Image = Global.METmoneyandexpensetracker.My.Resources.Resources.Back_icon48
        Me.gbtnback.Location = New System.Drawing.Point(28, 72)
        Me.gbtnback.Margin = New System.Windows.Forms.Padding(0)
        Me.gbtnback.Name = "gbtnback"
        Me.gbtnback.PressedColor = System.Drawing.Color.Transparent
        Me.gbtnback.Size = New System.Drawing.Size(98, 34)
        Me.gbtnback.TabIndex = 46
        Me.gbtnback.Text = "Back"
        '
        'AccountSecurityForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(488, 525)
        Me.Controls.Add(Me.gcmbstatus)
        Me.Controls.Add(Me.gcheckshow0)
        Me.Controls.Add(Me.gtbxcurrentpass)
        Me.Controls.Add(Me.gcheckshow2)
        Me.Controls.Add(Me.gcheckshow1)
        Me.Controls.Add(Me.gtbxconfirmpass)
        Me.Controls.Add(Me.gtbxnewpass)
        Me.Controls.Add(Me.gbtnchangepass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gbtnback)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "AccountSecurityForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AccountSecurityForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents gbtnchangepass As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents gbtnback As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents gcheckshow2 As Guna.UI2.WinForms.Guna2ImageCheckBox
    Friend WithEvents gcheckshow1 As Guna.UI2.WinForms.Guna2ImageCheckBox
    Friend WithEvents gtbxconfirmpass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents gtbxnewpass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents gcheckshow0 As Guna.UI2.WinForms.Guna2ImageCheckBox
    Friend WithEvents gtbxcurrentpass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents gcmbstatus As Guna.UI2.WinForms.Guna2ComboBox
End Class
