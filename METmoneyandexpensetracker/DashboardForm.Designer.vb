<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardForm))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ControlBox3 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.gbtnabout = New Guna.UI2.WinForms.Guna2Button()
        Me.gpnlmain = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.gbtndashboard = New Guna.UI2.WinForms.Guna2Button()
        Me.gbtnhistory = New Guna.UI2.WinForms.Guna2Button()
        Me.gdashbtnout = New Guna.UI2.WinForms.Guna2Button()
        Me.gbtngoal = New Guna.UI2.WinForms.Guna2Button()
        Me.gbtnprofile = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
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
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox3)
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1100, 30)
        Me.Guna2Panel1.TabIndex = 30
        '
        'Guna2ControlBox3
        '
        Me.Guna2ControlBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox
        Me.Guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Guna2ControlBox3.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Guna2ControlBox3.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox3.Location = New System.Drawing.Point(1007, 1)
        Me.Guna2ControlBox3.Name = "Guna2ControlBox3"
        Me.Guna2ControlBox3.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox3.TabIndex = 6
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(962, 1)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox2.TabIndex = 5
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(1052, 1)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox1.TabIndex = 4
        '
        'gbtnabout
        '
        Me.gbtnabout.BackColor = System.Drawing.Color.Transparent
        Me.gbtnabout.FillColor = System.Drawing.Color.Transparent
        Me.gbtnabout.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold)
        Me.gbtnabout.ForeColor = System.Drawing.Color.LightGreen
        Me.gbtnabout.Location = New System.Drawing.Point(23, 538)
        Me.gbtnabout.Name = "gbtnabout"
        Me.gbtnabout.Size = New System.Drawing.Size(97, 23)
        Me.gbtnabout.TabIndex = 42
        Me.gbtnabout.Text = "About Us"
        '
        'gpnlmain
        '
        Me.gpnlmain.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gpnlmain.BorderColor = System.Drawing.Color.Black
        Me.gpnlmain.BorderRadius = 20
        Me.gpnlmain.FillColor = System.Drawing.Color.WhiteSmoke
        Me.gpnlmain.Location = New System.Drawing.Point(183, 40)
        Me.gpnlmain.Margin = New System.Windows.Forms.Padding(0)
        Me.gpnlmain.Name = "gpnlmain"
        Me.gpnlmain.Size = New System.Drawing.Size(900, 600)
        Me.gpnlmain.TabIndex = 34
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.Guna2Panel1
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightGreen
        Me.Label2.Location = New System.Drawing.Point(16, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 41)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "M.E.T."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.BorderRadius = 20
        Me.Guna2Panel2.Controls.Add(Me.Label2)
        Me.Guna2Panel2.Controls.Add(Me.gbtndashboard)
        Me.Guna2Panel2.Controls.Add(Me.gbtnabout)
        Me.Guna2Panel2.Controls.Add(Me.gbtnhistory)
        Me.Guna2Panel2.Controls.Add(Me.gdashbtnout)
        Me.Guna2Panel2.Controls.Add(Me.gbtngoal)
        Me.Guna2Panel2.Controls.Add(Me.gbtnprofile)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Guna2Panel2.Location = New System.Drawing.Point(7, 40)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(168, 600)
        Me.Guna2Panel2.TabIndex = 44
        '
        'gbtndashboard
        '
        Me.gbtndashboard.Animated = True
        Me.gbtndashboard.BackColor = System.Drawing.Color.Transparent
        Me.gbtndashboard.BorderColor = System.Drawing.Color.Transparent
        Me.gbtndashboard.BorderRadius = 15
        Me.gbtndashboard.BorderThickness = 1
        Me.gbtndashboard.FillColor = System.Drawing.Color.Transparent
        Me.gbtndashboard.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtndashboard.ForeColor = System.Drawing.Color.LightGreen
        Me.gbtndashboard.Image = CType(resources.GetObject("gbtndashboard.Image"), System.Drawing.Image)
        Me.gbtndashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.gbtndashboard.ImageSize = New System.Drawing.Size(30, 30)
        Me.gbtndashboard.Location = New System.Drawing.Point(8, 171)
        Me.gbtndashboard.Margin = New System.Windows.Forms.Padding(0)
        Me.gbtndashboard.Name = "gbtndashboard"
        Me.gbtndashboard.Size = New System.Drawing.Size(140, 40)
        Me.gbtndashboard.TabIndex = 37
        Me.gbtndashboard.Text = "Dashboard"
        Me.gbtndashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'gbtnhistory
        '
        Me.gbtnhistory.Animated = True
        Me.gbtnhistory.BackColor = System.Drawing.Color.Transparent
        Me.gbtnhistory.BorderColor = System.Drawing.Color.Transparent
        Me.gbtnhistory.BorderRadius = 15
        Me.gbtnhistory.BorderThickness = 1
        Me.gbtnhistory.FillColor = System.Drawing.Color.Empty
        Me.gbtnhistory.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnhistory.ForeColor = System.Drawing.Color.LightGreen
        Me.gbtnhistory.Image = CType(resources.GetObject("gbtnhistory.Image"), System.Drawing.Image)
        Me.gbtnhistory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.gbtnhistory.ImageSize = New System.Drawing.Size(30, 30)
        Me.gbtnhistory.Location = New System.Drawing.Point(8, 259)
        Me.gbtnhistory.Margin = New System.Windows.Forms.Padding(0)
        Me.gbtnhistory.Name = "gbtnhistory"
        Me.gbtnhistory.Size = New System.Drawing.Size(140, 40)
        Me.gbtnhistory.TabIndex = 40
        Me.gbtnhistory.Text = "History"
        Me.gbtnhistory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'gdashbtnout
        '
        Me.gdashbtnout.Animated = True
        Me.gdashbtnout.BorderRadius = 15
        Me.gdashbtnout.FillColor = System.Drawing.Color.Empty
        Me.gdashbtnout.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gdashbtnout.ForeColor = System.Drawing.Color.LightGreen
        Me.gdashbtnout.Image = CType(resources.GetObject("gdashbtnout.Image"), System.Drawing.Image)
        Me.gdashbtnout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.gdashbtnout.ImageSize = New System.Drawing.Size(30, 30)
        Me.gdashbtnout.Location = New System.Drawing.Point(23, 486)
        Me.gdashbtnout.Margin = New System.Windows.Forms.Padding(0)
        Me.gdashbtnout.Name = "gdashbtnout"
        Me.gdashbtnout.Size = New System.Drawing.Size(125, 40)
        Me.gdashbtnout.TabIndex = 41
        Me.gdashbtnout.Text = "Logout"
        Me.gdashbtnout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'gbtngoal
        '
        Me.gbtngoal.Animated = True
        Me.gbtngoal.BackColor = System.Drawing.Color.Transparent
        Me.gbtngoal.BorderColor = System.Drawing.Color.Transparent
        Me.gbtngoal.BorderRadius = 15
        Me.gbtngoal.BorderThickness = 1
        Me.gbtngoal.FillColor = System.Drawing.Color.Empty
        Me.gbtngoal.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtngoal.ForeColor = System.Drawing.Color.LightGreen
        Me.gbtngoal.Image = CType(resources.GetObject("gbtngoal.Image"), System.Drawing.Image)
        Me.gbtngoal.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.gbtngoal.ImageSize = New System.Drawing.Size(30, 30)
        Me.gbtngoal.Location = New System.Drawing.Point(8, 215)
        Me.gbtngoal.Margin = New System.Windows.Forms.Padding(0)
        Me.gbtngoal.Name = "gbtngoal"
        Me.gbtngoal.Size = New System.Drawing.Size(140, 40)
        Me.gbtngoal.TabIndex = 39
        Me.gbtngoal.Text = "Goal"
        Me.gbtngoal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'gbtnprofile
        '
        Me.gbtnprofile.Animated = True
        Me.gbtnprofile.BackColor = System.Drawing.Color.Transparent
        Me.gbtnprofile.BorderColor = System.Drawing.Color.Transparent
        Me.gbtnprofile.BorderRadius = 15
        Me.gbtnprofile.BorderThickness = 1
        Me.gbtnprofile.Cursor = System.Windows.Forms.Cursors.Default
        Me.gbtnprofile.FillColor = System.Drawing.Color.Empty
        Me.gbtnprofile.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnprofile.ForeColor = System.Drawing.Color.LightGreen
        Me.gbtnprofile.Image = CType(resources.GetObject("gbtnprofile.Image"), System.Drawing.Image)
        Me.gbtnprofile.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.gbtnprofile.ImageSize = New System.Drawing.Size(30, 30)
        Me.gbtnprofile.Location = New System.Drawing.Point(8, 303)
        Me.gbtnprofile.Margin = New System.Windows.Forms.Padding(0)
        Me.gbtnprofile.Name = "gbtnprofile"
        Me.gbtnprofile.Size = New System.Drawing.Size(140, 40)
        Me.gbtnprofile.TabIndex = 38
        Me.gbtnprofile.Text = "Profile"
        Me.gbtnprofile.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'DashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1100, 650)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.gpnlmain)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DashboardForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DashboardForm"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents gbtnhistory As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents gbtngoal As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents gbtnprofile As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents gbtndashboard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents gbtnabout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents gdashbtnout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents gpnlmain As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
End Class
