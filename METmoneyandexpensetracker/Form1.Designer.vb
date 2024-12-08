<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gbtnlogin = New Guna.UI2.WinForms.Guna2Button()
        Me.gbtnsignup = New Guna.UI2.WinForms.Guna2Button()
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
        Me.Guna2ControlBox3.TabIndex = 3
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
        Me.Guna2ControlBox2.TabIndex = 2
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
        Me.gctrlclose.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Consolas", 32.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(337, 154)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 75)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "M.E.T"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Consolas", 21.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(368, 244)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 50)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Hello"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label4.Location = New System.Drawing.Point(296, 315)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(285, 54)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "A good money tracking" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "is wealth-hacking"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'gbtnlogin
        '
        Me.gbtnlogin.BackColor = System.Drawing.Color.White
        Me.gbtnlogin.BorderRadius = 15
        Me.gbtnlogin.FillColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.gbtnlogin.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnlogin.ForeColor = System.Drawing.Color.White
        Me.gbtnlogin.Location = New System.Drawing.Point(278, 390)
        Me.gbtnlogin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbtnlogin.Name = "gbtnlogin"
        Me.gbtnlogin.PressedColor = System.Drawing.Color.White
        Me.gbtnlogin.Size = New System.Drawing.Size(315, 51)
        Me.gbtnlogin.TabIndex = 8
        Me.gbtnlogin.Text = "Login"
        '
        'gbtnsignup
        '
        Me.gbtnsignup.BackColor = System.Drawing.Color.White
        Me.gbtnsignup.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.gbtnsignup.BorderRadius = 15
        Me.gbtnsignup.BorderThickness = 2
        Me.gbtnsignup.CheckedState.FillColor = System.Drawing.Color.Transparent
        Me.gbtnsignup.FillColor = System.Drawing.Color.White
        Me.gbtnsignup.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnsignup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.gbtnsignup.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.gbtnsignup.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gbtnsignup.Location = New System.Drawing.Point(278, 468)
        Me.gbtnsignup.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbtnsignup.Name = "gbtnsignup"
        Me.gbtnsignup.PressedColor = System.Drawing.Color.Transparent
        Me.gbtnsignup.Size = New System.Drawing.Size(315, 51)
        Me.gbtnsignup.TabIndex = 9
        Me.gbtnsignup.Text = "Sign Up"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(900, 615)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.gbtnsignup)
        Me.Controls.Add(Me.gbtnlogin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents gctrlclose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents gbtnlogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents gbtnsignup As Guna.UI2.WinForms.Guna2Button
End Class
