﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SurveyForm
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
        Me.gctrlclose = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gbtncontinue = New Guna.UI2.WinForms.Guna2Button()
        Me.gtbxfname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gtbxlname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.gtbxaddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.gcmboccupation = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gcmbsource = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.gbirthdate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gtbxincome = New Guna.UI2.WinForms.Guna2TextBox()
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
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(600, 30)
        Me.Guna2Panel1.TabIndex = 1
        '
        'Guna2ControlBox3
        '
        Me.Guna2ControlBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox
        Me.Guna2ControlBox3.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox3.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Guna2ControlBox3.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox3.Location = New System.Drawing.Point(507, 1)
        Me.Guna2ControlBox3.Name = "Guna2ControlBox3"
        Me.Guna2ControlBox3.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox3.TabIndex = 6
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(462, 1)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox2.TabIndex = 5
        '
        'gctrlclose
        '
        Me.gctrlclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gctrlclose.FillColor = System.Drawing.Color.Transparent
        Me.gctrlclose.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.gctrlclose.IconColor = System.Drawing.Color.White
        Me.gctrlclose.Location = New System.Drawing.Point(552, 1)
        Me.gctrlclose.Name = "gctrlclose"
        Me.gctrlclose.Size = New System.Drawing.Size(45, 29)
        Me.gctrlclose.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(227, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(296, 18)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Answer for a personalized experience"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'gbtncontinue
        '
        Me.gbtncontinue.BorderRadius = 15
        Me.gbtncontinue.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gbtncontinue.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtncontinue.ForeColor = System.Drawing.Color.White
        Me.gbtncontinue.Location = New System.Drawing.Point(424, 349)
        Me.gbtncontinue.Name = "gbtncontinue"
        Me.gbtncontinue.Size = New System.Drawing.Size(155, 35)
        Me.gbtncontinue.TabIndex = 33
        Me.gbtncontinue.Text = "Continue"
        '
        'gtbxfname
        '
        Me.gtbxfname.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gtbxfname.BorderRadius = 15
        Me.gtbxfname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.gtbxfname.DefaultText = ""
        Me.gtbxfname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gtbxfname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.gtbxfname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gtbxfname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gtbxfname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gtbxfname.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gtbxfname.ForeColor = System.Drawing.Color.Black
        Me.gtbxfname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.gtbxfname.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gtbxfname.IconLeftSize = New System.Drawing.Size(25, 25)
        Me.gtbxfname.Location = New System.Drawing.Point(227, 99)
        Me.gtbxfname.Margin = New System.Windows.Forms.Padding(4)
        Me.gtbxfname.Name = "gtbxfname"
        Me.gtbxfname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.gtbxfname.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gtbxfname.PlaceholderText = "Firstname"
        Me.gtbxfname.SelectedText = ""
        Me.gtbxfname.Size = New System.Drawing.Size(172, 35)
        Me.gtbxfname.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(221, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 32)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Survey"
        '
        'gtbxlname
        '
        Me.gtbxlname.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gtbxlname.BorderRadius = 15
        Me.gtbxlname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.gtbxlname.DefaultText = ""
        Me.gtbxlname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gtbxlname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.gtbxlname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gtbxlname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gtbxlname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gtbxlname.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gtbxlname.ForeColor = System.Drawing.Color.Black
        Me.gtbxlname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.gtbxlname.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gtbxlname.IconLeftSize = New System.Drawing.Size(25, 25)
        Me.gtbxlname.Location = New System.Drawing.Point(407, 99)
        Me.gtbxlname.Margin = New System.Windows.Forms.Padding(4)
        Me.gtbxlname.Name = "gtbxlname"
        Me.gtbxlname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.gtbxlname.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gtbxlname.PlaceholderText = "Lastname"
        Me.gtbxlname.SelectedText = ""
        Me.gtbxlname.Size = New System.Drawing.Size(172, 35)
        Me.gtbxlname.TabIndex = 35
        '
        'gtbxaddress
        '
        Me.gtbxaddress.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gtbxaddress.BorderRadius = 15
        Me.gtbxaddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.gtbxaddress.DefaultText = ""
        Me.gtbxaddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gtbxaddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.gtbxaddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gtbxaddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gtbxaddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gtbxaddress.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gtbxaddress.ForeColor = System.Drawing.Color.Black
        Me.gtbxaddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.gtbxaddress.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gtbxaddress.IconLeftSize = New System.Drawing.Size(25, 25)
        Me.gtbxaddress.Location = New System.Drawing.Point(227, 140)
        Me.gtbxaddress.Margin = New System.Windows.Forms.Padding(4)
        Me.gtbxaddress.Name = "gtbxaddress"
        Me.gtbxaddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.gtbxaddress.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gtbxaddress.PlaceholderText = "Address"
        Me.gtbxaddress.SelectedText = ""
        Me.gtbxaddress.Size = New System.Drawing.Size(352, 35)
        Me.gtbxaddress.TabIndex = 36
        '
        'gcmboccupation
        '
        Me.gcmboccupation.BackColor = System.Drawing.Color.Transparent
        Me.gcmboccupation.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gcmboccupation.BorderRadius = 15
        Me.gcmboccupation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.gcmboccupation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.gcmboccupation.FocusedColor = System.Drawing.Color.Empty
        Me.gcmboccupation.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gcmboccupation.ForeColor = System.Drawing.Color.Black
        Me.gcmboccupation.FormattingEnabled = True
        Me.gcmboccupation.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.gcmboccupation.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gcmboccupation.ItemHeight = 30
        Me.gcmboccupation.Items.AddRange(New Object() {"Employed", "Self-Employed", "Student"})
        Me.gcmboccupation.Location = New System.Drawing.Point(389, 223)
        Me.gcmboccupation.Name = "gcmboccupation"
        Me.gcmboccupation.Size = New System.Drawing.Size(190, 36)
        Me.gcmboccupation.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(243, 231)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 18)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Occupation"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(243, 272)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 18)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Source of funds"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'gcmbsource
        '
        Me.gcmbsource.BackColor = System.Drawing.Color.Transparent
        Me.gcmbsource.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gcmbsource.BorderRadius = 15
        Me.gcmbsource.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.gcmbsource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.gcmbsource.FocusedColor = System.Drawing.Color.Empty
        Me.gcmbsource.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gcmbsource.ForeColor = System.Drawing.Color.Black
        Me.gcmbsource.FormattingEnabled = True
        Me.gcmbsource.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.gcmbsource.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gcmbsource.ItemHeight = 30
        Me.gcmbsource.Items.AddRange(New Object() {"Cash on Hand", "Bank Account", "E-money"})
        Me.gcmbsource.Location = New System.Drawing.Point(389, 265)
        Me.gcmbsource.Name = "gcmbsource"
        Me.gcmbsource.Size = New System.Drawing.Size(190, 36)
        Me.gcmbsource.TabIndex = 39
        '
        'gbirthdate
        '
        Me.gbirthdate.BackColor = System.Drawing.Color.Transparent
        Me.gbirthdate.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gbirthdate.BorderRadius = 15
        Me.gbirthdate.BorderThickness = 1
        Me.gbirthdate.Checked = True
        Me.gbirthdate.CustomFormat = "yyyy-mm-dd"
        Me.gbirthdate.FillColor = System.Drawing.Color.White
        Me.gbirthdate.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.gbirthdate.Location = New System.Drawing.Point(389, 181)
        Me.gbirthdate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.gbirthdate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.gbirthdate.Name = "gbirthdate"
        Me.gbirthdate.Size = New System.Drawing.Size(190, 36)
        Me.gbirthdate.TabIndex = 41
        Me.gbirthdate.Value = New Date(2024, 11, 26, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(243, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 18)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Date of Birth"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(243, 315)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 18)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Monthly Income"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'gtbxincome
        '
        Me.gtbxincome.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gtbxincome.BorderRadius = 15
        Me.gtbxincome.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.gtbxincome.DefaultText = ""
        Me.gtbxincome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gtbxincome.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.gtbxincome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gtbxincome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gtbxincome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gtbxincome.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gtbxincome.ForeColor = System.Drawing.Color.Black
        Me.gtbxincome.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.gtbxincome.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gtbxincome.IconLeftSize = New System.Drawing.Size(25, 25)
        Me.gtbxincome.Location = New System.Drawing.Point(389, 307)
        Me.gtbxincome.Margin = New System.Windows.Forms.Padding(4)
        Me.gtbxincome.Name = "gtbxincome"
        Me.gtbxincome.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.gtbxincome.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gtbxincome.PlaceholderText = "Income"
        Me.gtbxincome.SelectedText = ""
        Me.gtbxincome.Size = New System.Drawing.Size(190, 35)
        Me.gtbxincome.TabIndex = 44
        '
        'SurveyForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(600, 400)
        Me.Controls.Add(Me.gtbxincome)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.gbirthdate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gcmbsource)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gcmboccupation)
        Me.Controls.Add(Me.gtbxaddress)
        Me.Controls.Add(Me.gtbxlname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.gbtncontinue)
        Me.Controls.Add(Me.gtbxfname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SurveyForm"
        Me.Text = "SurveyForm"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents gctrlclose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Label4 As Label
    Friend WithEvents gbtncontinue As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents gtbxfname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents gtbxaddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents gtbxlname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents gcmboccupation As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents gcmbsource As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents gbirthdate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents gtbxincome As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
End Class
