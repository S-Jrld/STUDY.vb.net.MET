<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GoalsForm
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
        Me.mainflowpanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblsavings = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblwants = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblnecessities = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblincome = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbtnaddnote = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.mainflowpanel.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
        '
        'mainflowpanel
        '
        Me.mainflowpanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.mainflowpanel.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.mainflowpanel.Location = New System.Drawing.Point(24, 18)
        Me.mainflowpanel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mainflowpanel.Name = "mainflowpanel"
        Me.mainflowpanel.Size = New System.Drawing.Size(825, 674)
        Me.mainflowpanel.TabIndex = 65
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(4, 5)
        Me.Guna2CustomGradientPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(12, 12)
        Me.Guna2CustomGradientPanel1.TabIndex = 0
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.AutoScroll = True
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel1.BorderRadius = 20
        Me.Guna2Panel1.BorderThickness = 2
        Me.Guna2Panel1.Controls.Add(Me.lblsavings)
        Me.Guna2Panel1.Controls.Add(Me.Label12)
        Me.Guna2Panel1.Controls.Add(Me.lblwants)
        Me.Guna2Panel1.Controls.Add(Me.Label10)
        Me.Guna2Panel1.Controls.Add(Me.lblnecessities)
        Me.Guna2Panel1.Controls.Add(Me.Label7)
        Me.Guna2Panel1.Controls.Add(Me.lblincome)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.White
        Me.Guna2Panel1.Location = New System.Drawing.Point(923, 106)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(414, 442)
        Me.Guna2Panel1.TabIndex = 66
        Me.Guna2Panel1.UseTransparentBackground = True
        '
        'lblsavings
        '
        Me.lblsavings.AutoSize = True
        Me.lblsavings.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsavings.Location = New System.Drawing.Point(183, 342)
        Me.lblsavings.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblsavings.Name = "lblsavings"
        Me.lblsavings.Size = New System.Drawing.Size(116, 28)
        Me.lblsavings.TabIndex = 78
        Me.lblsavings.Text = "(Budget)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(15, 342)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(116, 28)
        Me.Label12.TabIndex = 77
        Me.Label12.Text = "Savings:"
        '
        'lblwants
        '
        Me.lblwants.AutoSize = True
        Me.lblwants.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwants.Location = New System.Drawing.Point(183, 274)
        Me.lblwants.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblwants.Name = "lblwants"
        Me.lblwants.Size = New System.Drawing.Size(116, 28)
        Me.lblwants.TabIndex = 76
        Me.lblwants.Text = "(budget)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 274)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 28)
        Me.Label10.TabIndex = 75
        Me.Label10.Text = "Wants:"
        '
        'lblnecessities
        '
        Me.lblnecessities.AutoSize = True
        Me.lblnecessities.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnecessities.Location = New System.Drawing.Point(183, 206)
        Me.lblnecessities.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnecessities.Name = "lblnecessities"
        Me.lblnecessities.Size = New System.Drawing.Size(116, 28)
        Me.lblnecessities.TabIndex = 74
        Me.lblnecessities.Text = "(budget)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 206)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(168, 28)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "Necessities:"
        '
        'lblincome
        '
        Me.lblincome.AutoSize = True
        Me.lblincome.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblincome.Location = New System.Drawing.Point(63, 120)
        Me.lblincome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblincome.Name = "lblincome"
        Me.lblincome.Size = New System.Drawing.Size(126, 31)
        Me.lblincome.TabIndex = 72
        Me.lblincome.Text = "(Income)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 82)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(210, 31)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Monthly Income"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 18)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(287, 34)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Next month budget"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 42)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Notes"
        '
        'gbtnaddnote
        '
        Me.gbtnaddnote.BackColor = System.Drawing.Color.Transparent
        Me.gbtnaddnote.BorderRadius = 10
        Me.gbtnaddnote.BorderThickness = 1
        Me.gbtnaddnote.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.gbtnaddnote.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.gbtnaddnote.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.gbtnaddnote.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.gbtnaddnote.FillColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.gbtnaddnote.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnaddnote.ForeColor = System.Drawing.Color.White
        Me.gbtnaddnote.Location = New System.Drawing.Point(720, 45)
        Me.gbtnaddnote.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbtnaddnote.Name = "gbtnaddnote"
        Me.gbtnaddnote.Size = New System.Drawing.Size(172, 52)
        Me.gbtnaddnote.TabIndex = 69
        Me.gbtnaddnote.Text = "Add Note"
        Me.gbtnaddnote.UseTransparentBackground = True
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel3.BorderRadius = 20
        Me.Guna2Panel3.BorderThickness = 2
        Me.Guna2Panel3.Controls.Add(Me.mainflowpanel)
        Me.Guna2Panel3.FillColor = System.Drawing.Color.White
        Me.Guna2Panel3.Location = New System.Drawing.Point(18, 106)
        Me.Guna2Panel3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(874, 720)
        Me.Guna2Panel3.TabIndex = 70
        Me.Guna2Panel3.UseTransparentBackground = True
        '
        'GoalsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(1350, 846)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.gbtnaddnote)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "GoalsForm"
        Me.Text = "Forecast end of month"
        Me.mainflowpanel.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents mainflowpanel As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents gbtnaddnote As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents lblsavings As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblwants As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblnecessities As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblincome As Label
    Friend WithEvents Label3 As Label
End Class
