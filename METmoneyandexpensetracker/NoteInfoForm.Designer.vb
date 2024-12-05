<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NoteInfoForm
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
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.gbtnback = New Guna.UI2.WinForms.Guna2Button()
        Me.gbtnaddnote = New Guna.UI2.WinForms.Guna2Button()
        Me.gbtneditnote = New Guna.UI2.WinForms.Guna2Button()
        Me.gtbxcontext = New Guna.UI2.WinForms.Guna2TextBox()
        Me.gtbxtitle = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.gtbxgoalmoney = New Guna.UI2.WinForms.Guna2TextBox()
        Me.gtbxsavedmoney = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(474, 30)
        Me.Guna2Panel1.TabIndex = 56
        '
        'gbtnback
        '
        Me.gbtnback.FillColor = System.Drawing.Color.Transparent
        Me.gbtnback.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnback.ForeColor = System.Drawing.Color.Black
        Me.gbtnback.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gbtnback.HoverState.ForeColor = System.Drawing.Color.Black
        Me.gbtnback.Image = Global.METmoneyandexpensetracker.My.Resources.Resources.Back_icon48
        Me.gbtnback.Location = New System.Drawing.Point(13, 44)
        Me.gbtnback.Margin = New System.Windows.Forms.Padding(0)
        Me.gbtnback.Name = "gbtnback"
        Me.gbtnback.PressedColor = System.Drawing.Color.Transparent
        Me.gbtnback.Size = New System.Drawing.Size(65, 22)
        Me.gbtnback.TabIndex = 55
        Me.gbtnback.Text = "Back"
        '
        'gbtnaddnote
        '
        Me.gbtnaddnote.BackColor = System.Drawing.Color.White
        Me.gbtnaddnote.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.gbtnaddnote.BorderRadius = 15
        Me.gbtnaddnote.BorderThickness = 2
        Me.gbtnaddnote.CheckedState.FillColor = System.Drawing.Color.Transparent
        Me.gbtnaddnote.FillColor = System.Drawing.Color.White
        Me.gbtnaddnote.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnaddnote.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.gbtnaddnote.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.gbtnaddnote.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gbtnaddnote.Location = New System.Drawing.Point(242, 341)
        Me.gbtnaddnote.Name = "gbtnaddnote"
        Me.gbtnaddnote.PressedColor = System.Drawing.Color.Transparent
        Me.gbtnaddnote.Size = New System.Drawing.Size(194, 33)
        Me.gbtnaddnote.TabIndex = 54
        Me.gbtnaddnote.Text = "Add note"
        '
        'gbtneditnote
        '
        Me.gbtneditnote.BackColor = System.Drawing.Color.White
        Me.gbtneditnote.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.gbtneditnote.BorderRadius = 15
        Me.gbtneditnote.BorderThickness = 2
        Me.gbtneditnote.CheckedState.FillColor = System.Drawing.Color.Transparent
        Me.gbtneditnote.FillColor = System.Drawing.Color.White
        Me.gbtneditnote.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtneditnote.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.gbtneditnote.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.gbtneditnote.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gbtneditnote.Location = New System.Drawing.Point(30, 341)
        Me.gbtneditnote.Name = "gbtneditnote"
        Me.gbtneditnote.PressedColor = System.Drawing.Color.Transparent
        Me.gbtneditnote.Size = New System.Drawing.Size(194, 33)
        Me.gbtneditnote.TabIndex = 53
        Me.gbtneditnote.Text = "Edit note"
        '
        'gtbxcontext
        '
        Me.gtbxcontext.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gtbxcontext.BorderRadius = 15
        Me.gtbxcontext.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.gtbxcontext.DefaultText = ""
        Me.gtbxcontext.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gtbxcontext.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.gtbxcontext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gtbxcontext.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gtbxcontext.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gtbxcontext.Font = New System.Drawing.Font("Consolas", 11.25!)
        Me.gtbxcontext.ForeColor = System.Drawing.Color.Black
        Me.gtbxcontext.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.gtbxcontext.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gtbxcontext.IconLeftSize = New System.Drawing.Size(25, 25)
        Me.gtbxcontext.Location = New System.Drawing.Point(30, 159)
        Me.gtbxcontext.Margin = New System.Windows.Forms.Padding(4)
        Me.gtbxcontext.Multiline = True
        Me.gtbxcontext.Name = "gtbxcontext"
        Me.gtbxcontext.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.gtbxcontext.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gtbxcontext.PlaceholderText = "Comment"
        Me.gtbxcontext.SelectedText = ""
        Me.gtbxcontext.Size = New System.Drawing.Size(406, 121)
        Me.gtbxcontext.TabIndex = 52
        '
        'gtbxtitle
        '
        Me.gtbxtitle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gtbxtitle.BorderRadius = 15
        Me.gtbxtitle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.gtbxtitle.DefaultText = ""
        Me.gtbxtitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gtbxtitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.gtbxtitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gtbxtitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gtbxtitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gtbxtitle.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gtbxtitle.ForeColor = System.Drawing.Color.Black
        Me.gtbxtitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.gtbxtitle.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gtbxtitle.IconLeftSize = New System.Drawing.Size(25, 25)
        Me.gtbxtitle.Location = New System.Drawing.Point(29, 116)
        Me.gtbxtitle.Margin = New System.Windows.Forms.Padding(4)
        Me.gtbxtitle.Name = "gtbxtitle"
        Me.gtbxtitle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.gtbxtitle.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gtbxtitle.PlaceholderText = "Title"
        Me.gtbxtitle.SelectedText = ""
        Me.gtbxtitle.Size = New System.Drawing.Size(194, 35)
        Me.gtbxtitle.TabIndex = 51
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(24, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 32)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Note"
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 1.0R
        Me.Guna2DragControl1.DragStartTransparencyValue = 1.0R
        Me.Guna2DragControl1.TargetControl = Me.Guna2Panel1
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'gtbxgoalmoney
        '
        Me.gtbxgoalmoney.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gtbxgoalmoney.BorderRadius = 15
        Me.gtbxgoalmoney.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.gtbxgoalmoney.DefaultText = ""
        Me.gtbxgoalmoney.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gtbxgoalmoney.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.gtbxgoalmoney.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gtbxgoalmoney.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gtbxgoalmoney.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gtbxgoalmoney.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gtbxgoalmoney.ForeColor = System.Drawing.Color.Black
        Me.gtbxgoalmoney.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.gtbxgoalmoney.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gtbxgoalmoney.IconLeftSize = New System.Drawing.Size(25, 25)
        Me.gtbxgoalmoney.Location = New System.Drawing.Point(30, 288)
        Me.gtbxgoalmoney.Margin = New System.Windows.Forms.Padding(4)
        Me.gtbxgoalmoney.Name = "gtbxgoalmoney"
        Me.gtbxgoalmoney.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.gtbxgoalmoney.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gtbxgoalmoney.PlaceholderText = "Goal money"
        Me.gtbxgoalmoney.SelectedText = ""
        Me.gtbxgoalmoney.Size = New System.Drawing.Size(194, 35)
        Me.gtbxgoalmoney.TabIndex = 57
        '
        'gtbxsavedmoney
        '
        Me.gtbxsavedmoney.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gtbxsavedmoney.BorderRadius = 15
        Me.gtbxsavedmoney.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.gtbxsavedmoney.DefaultText = ""
        Me.gtbxsavedmoney.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gtbxsavedmoney.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.gtbxsavedmoney.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gtbxsavedmoney.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gtbxsavedmoney.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gtbxsavedmoney.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gtbxsavedmoney.ForeColor = System.Drawing.Color.Black
        Me.gtbxsavedmoney.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.gtbxsavedmoney.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gtbxsavedmoney.IconLeftSize = New System.Drawing.Size(25, 25)
        Me.gtbxsavedmoney.Location = New System.Drawing.Point(242, 288)
        Me.gtbxsavedmoney.Margin = New System.Windows.Forms.Padding(4)
        Me.gtbxsavedmoney.Name = "gtbxsavedmoney"
        Me.gtbxsavedmoney.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.gtbxsavedmoney.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gtbxsavedmoney.PlaceholderText = "Saved money"
        Me.gtbxsavedmoney.SelectedText = ""
        Me.gtbxsavedmoney.Size = New System.Drawing.Size(194, 35)
        Me.gtbxsavedmoney.TabIndex = 58
        '
        'NoteInfoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(474, 403)
        Me.Controls.Add(Me.gtbxsavedmoney)
        Me.Controls.Add(Me.gtbxgoalmoney)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.gbtnback)
        Me.Controls.Add(Me.gbtnaddnote)
        Me.Controls.Add(Me.gbtneditnote)
        Me.Controls.Add(Me.gtbxcontext)
        Me.Controls.Add(Me.gtbxtitle)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "NoteInfoForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NoteInfoForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents gbtnback As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents gbtnaddnote As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents gbtneditnote As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents gtbxcontext As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents gtbxtitle As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents gtbxsavedmoney As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents gtbxgoalmoney As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
End Class
