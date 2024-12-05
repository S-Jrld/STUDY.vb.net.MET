<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BudgetForm
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
        Me.gbtnsetnew = New Guna.UI2.WinForms.Guna2Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gtbxmonthlybudget = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.gtbxyearlybudget = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gcmbbudgetname = New Guna.UI2.WinForms.Guna2ComboBox()
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
        Me.Guna2Panel1.Size = New System.Drawing.Size(461, 30)
        Me.Guna2Panel1.TabIndex = 61
        '
        'gbtnback
        '
        Me.gbtnback.BackColor = System.Drawing.Color.Transparent
        Me.gbtnback.FillColor = System.Drawing.Color.Transparent
        Me.gbtnback.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnback.ForeColor = System.Drawing.Color.Black
        Me.gbtnback.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gbtnback.HoverState.ForeColor = System.Drawing.Color.Black
        Me.gbtnback.Image = Global.METmoneyandexpensetracker.My.Resources.Resources.Back_icon48
        Me.gbtnback.Location = New System.Drawing.Point(14, 42)
        Me.gbtnback.Margin = New System.Windows.Forms.Padding(0)
        Me.gbtnback.Name = "gbtnback"
        Me.gbtnback.PressedColor = System.Drawing.Color.Transparent
        Me.gbtnback.Size = New System.Drawing.Size(65, 22)
        Me.gbtnback.TabIndex = 60
        Me.gbtnback.Text = "Back"
        Me.gbtnback.UseTransparentBackground = True
        '
        'gbtnsetnew
        '
        Me.gbtnsetnew.BackColor = System.Drawing.Color.Transparent
        Me.gbtnsetnew.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.gbtnsetnew.BorderRadius = 15
        Me.gbtnsetnew.BorderThickness = 2
        Me.gbtnsetnew.CheckedState.FillColor = System.Drawing.Color.Transparent
        Me.gbtnsetnew.FillColor = System.Drawing.Color.White
        Me.gbtnsetnew.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnsetnew.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.gbtnsetnew.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.gbtnsetnew.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gbtnsetnew.Location = New System.Drawing.Point(242, 260)
        Me.gbtnsetnew.Name = "gbtnsetnew"
        Me.gbtnsetnew.PressedColor = System.Drawing.Color.Transparent
        Me.gbtnsetnew.Size = New System.Drawing.Size(194, 33)
        Me.gbtnsetnew.TabIndex = 59
        Me.gbtnsetnew.Text = "Set new budget"
        Me.gbtnsetnew.UseTransparentBackground = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(27, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 32)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Set Budget"
        '
        'gtbxmonthlybudget
        '
        Me.gtbxmonthlybudget.BackColor = System.Drawing.Color.Transparent
        Me.gtbxmonthlybudget.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gtbxmonthlybudget.BorderRadius = 15
        Me.gtbxmonthlybudget.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.gtbxmonthlybudget.DefaultText = ""
        Me.gtbxmonthlybudget.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gtbxmonthlybudget.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.gtbxmonthlybudget.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gtbxmonthlybudget.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gtbxmonthlybudget.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gtbxmonthlybudget.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gtbxmonthlybudget.ForeColor = System.Drawing.Color.Black
        Me.gtbxmonthlybudget.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.gtbxmonthlybudget.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gtbxmonthlybudget.IconLeftSize = New System.Drawing.Size(25, 25)
        Me.gtbxmonthlybudget.Location = New System.Drawing.Point(29, 149)
        Me.gtbxmonthlybudget.Margin = New System.Windows.Forms.Padding(4)
        Me.gtbxmonthlybudget.Name = "gtbxmonthlybudget"
        Me.gtbxmonthlybudget.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.gtbxmonthlybudget.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gtbxmonthlybudget.PlaceholderText = "Monthly Budget"
        Me.gtbxmonthlybudget.SelectedText = ""
        Me.gtbxmonthlybudget.Size = New System.Drawing.Size(194, 35)
        Me.gtbxmonthlybudget.TabIndex = 50
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.Guna2Panel1
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'gtbxyearlybudget
        '
        Me.gtbxyearlybudget.BackColor = System.Drawing.Color.Transparent
        Me.gtbxyearlybudget.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gtbxyearlybudget.BorderRadius = 15
        Me.gtbxyearlybudget.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.gtbxyearlybudget.DefaultText = ""
        Me.gtbxyearlybudget.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gtbxyearlybudget.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.gtbxyearlybudget.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gtbxyearlybudget.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gtbxyearlybudget.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gtbxyearlybudget.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gtbxyearlybudget.ForeColor = System.Drawing.Color.Black
        Me.gtbxyearlybudget.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.gtbxyearlybudget.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gtbxyearlybudget.IconLeftSize = New System.Drawing.Size(25, 25)
        Me.gtbxyearlybudget.Location = New System.Drawing.Point(242, 149)
        Me.gtbxyearlybudget.Margin = New System.Windows.Forms.Padding(4)
        Me.gtbxyearlybudget.Name = "gtbxyearlybudget"
        Me.gtbxyearlybudget.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.gtbxyearlybudget.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gtbxyearlybudget.PlaceholderText = "Yearly Budget"
        Me.gtbxyearlybudget.SelectedText = ""
        Me.gtbxyearlybudget.Size = New System.Drawing.Size(194, 35)
        Me.gtbxyearlybudget.TabIndex = 62
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(26, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 120)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Note." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "all fields must be filled" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "if you are not sure about" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the yearly budget ju" &
    "st " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "multiply your monthly" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "budget into the number" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of months remaining" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "before " &
    "the year ends."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'gcmbbudgetname
        '
        Me.gcmbbudgetname.BackColor = System.Drawing.Color.Transparent
        Me.gcmbbudgetname.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gcmbbudgetname.BorderRadius = 15
        Me.gcmbbudgetname.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.gcmbbudgetname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.gcmbbudgetname.FocusedColor = System.Drawing.Color.Empty
        Me.gcmbbudgetname.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gcmbbudgetname.ForeColor = System.Drawing.Color.Black
        Me.gcmbbudgetname.FormattingEnabled = True
        Me.gcmbbudgetname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.gcmbbudgetname.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gcmbbudgetname.ItemHeight = 30
        Me.gcmbbudgetname.Items.AddRange(New Object() {"Monthly", "Both"})
        Me.gcmbbudgetname.Location = New System.Drawing.Point(242, 67)
        Me.gcmbbudgetname.Name = "gcmbbudgetname"
        Me.gcmbbudgetname.Size = New System.Drawing.Size(194, 36)
        Me.gcmbbudgetname.TabIndex = 66
        '
        'BudgetForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(461, 328)
        Me.Controls.Add(Me.gcmbbudgetname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gtbxyearlybudget)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.gbtnback)
        Me.Controls.Add(Me.gbtnsetnew)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.gtbxmonthlybudget)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BudgetForm"
        Me.Text = "BudgetForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents gbtnback As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents gbtnsetnew As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label5 As Label
    Friend WithEvents gtbxmonthlybudget As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents gtbxyearlybudget As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents gcmbbudgetname As Guna.UI2.WinForms.Guna2ComboBox
End Class
