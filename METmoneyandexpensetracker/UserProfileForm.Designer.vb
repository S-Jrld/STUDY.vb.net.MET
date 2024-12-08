<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserProfileForm
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
        Me.gtbxincome = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbirthdate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gcmbsource = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gcmboccupation = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.gtbxaddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.gtbxlname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gbtnupdateinfo = New Guna.UI2.WinForms.Guna2Button()
        Me.gtbxfname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gtbxuname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.gbtnback = New Guna.UI2.WinForms.Guna2Button()
        Me.gcmbctrl = New Guna.UI2.WinForms.Guna2ComboBox()
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
        Me.Guna2Panel1.Size = New System.Drawing.Size(608, 46)
        Me.Guna2Panel1.TabIndex = 45
        '
        'gtbxincome
        '
        Me.gtbxincome.BackColor = System.Drawing.Color.Transparent
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
        Me.gtbxincome.Location = New System.Drawing.Point(276, 614)
        Me.gtbxincome.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.gtbxincome.Name = "gtbxincome"
        Me.gtbxincome.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.gtbxincome.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gtbxincome.PlaceholderText = "Income"
        Me.gtbxincome.SelectedText = ""
        Me.gtbxincome.Size = New System.Drawing.Size(285, 54)
        Me.gtbxincome.TabIndex = 59
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(57, 626)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(194, 27)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Monthly Income"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(57, 434)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 27)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Date of Birth"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me.gbirthdate.Location = New System.Drawing.Point(276, 420)
        Me.gbirthdate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbirthdate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.gbirthdate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.gbirthdate.Name = "gbirthdate"
        Me.gbirthdate.Size = New System.Drawing.Size(285, 55)
        Me.gbirthdate.TabIndex = 56
        Me.gbirthdate.Value = New Date(2024, 11, 26, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(57, 560)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 27)
        Me.Label2.TabIndex = 55
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
        Me.gcmbsource.Location = New System.Drawing.Point(276, 549)
        Me.gcmbsource.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gcmbsource.Name = "gcmbsource"
        Me.gcmbsource.Size = New System.Drawing.Size(283, 36)
        Me.gcmbsource.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(57, 497)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 27)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Occupation"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me.gcmboccupation.Location = New System.Drawing.Point(276, 485)
        Me.gcmboccupation.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gcmboccupation.Name = "gcmboccupation"
        Me.gcmboccupation.Size = New System.Drawing.Size(283, 36)
        Me.gcmboccupation.TabIndex = 52
        '
        'gtbxaddress
        '
        Me.gtbxaddress.BackColor = System.Drawing.Color.Transparent
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
        Me.gtbxaddress.Location = New System.Drawing.Point(33, 357)
        Me.gtbxaddress.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.gtbxaddress.Name = "gtbxaddress"
        Me.gtbxaddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.gtbxaddress.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gtbxaddress.PlaceholderText = "Address"
        Me.gtbxaddress.SelectedText = ""
        Me.gtbxaddress.Size = New System.Drawing.Size(528, 54)
        Me.gtbxaddress.TabIndex = 51
        '
        'gtbxlname
        '
        Me.gtbxlname.BackColor = System.Drawing.Color.Transparent
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
        Me.gtbxlname.Location = New System.Drawing.Point(303, 294)
        Me.gtbxlname.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.gtbxlname.Name = "gtbxlname"
        Me.gtbxlname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.gtbxlname.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gtbxlname.PlaceholderText = "Lastname"
        Me.gtbxlname.SelectedText = ""
        Me.gtbxlname.Size = New System.Drawing.Size(258, 54)
        Me.gtbxlname.TabIndex = 50
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(36, 171)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(233, 27)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Edit your profile"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'gbtnupdateinfo
        '
        Me.gbtnupdateinfo.BackColor = System.Drawing.Color.Transparent
        Me.gbtnupdateinfo.BorderRadius = 15
        Me.gbtnupdateinfo.FillColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.gbtnupdateinfo.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnupdateinfo.ForeColor = System.Drawing.Color.White
        Me.gbtnupdateinfo.Location = New System.Drawing.Point(328, 678)
        Me.gbtnupdateinfo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbtnupdateinfo.Name = "gbtnupdateinfo"
        Me.gbtnupdateinfo.Size = New System.Drawing.Size(232, 54)
        Me.gbtnupdateinfo.TabIndex = 48
        Me.gbtnupdateinfo.Text = "Update Info"
        '
        'gtbxfname
        '
        Me.gtbxfname.BackColor = System.Drawing.Color.Transparent
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
        Me.gtbxfname.Location = New System.Drawing.Point(33, 294)
        Me.gtbxfname.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.gtbxfname.Name = "gtbxfname"
        Me.gtbxfname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.gtbxfname.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gtbxfname.PlaceholderText = "Firstname"
        Me.gtbxfname.SelectedText = ""
        Me.gtbxfname.Size = New System.Drawing.Size(258, 54)
        Me.gtbxfname.TabIndex = 47
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(32, 108)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(296, 48)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "User profile"
        '
        'gtbxuname
        '
        Me.gtbxuname.BackColor = System.Drawing.Color.Transparent
        Me.gtbxuname.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gtbxuname.BorderRadius = 15
        Me.gtbxuname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.gtbxuname.DefaultText = ""
        Me.gtbxuname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gtbxuname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.gtbxuname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gtbxuname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gtbxuname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gtbxuname.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gtbxuname.ForeColor = System.Drawing.Color.Black
        Me.gtbxuname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.gtbxuname.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gtbxuname.IconLeftSize = New System.Drawing.Size(25, 25)
        Me.gtbxuname.Location = New System.Drawing.Point(33, 228)
        Me.gtbxuname.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.gtbxuname.Name = "gtbxuname"
        Me.gtbxuname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.gtbxuname.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gtbxuname.PlaceholderText = "Username"
        Me.gtbxuname.SelectedText = ""
        Me.gtbxuname.Size = New System.Drawing.Size(528, 54)
        Me.gtbxuname.TabIndex = 60
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
        Me.gbtnback.Location = New System.Drawing.Point(24, 69)
        Me.gbtnback.Margin = New System.Windows.Forms.Padding(0)
        Me.gbtnback.Name = "gbtnback"
        Me.gbtnback.PressedColor = System.Drawing.Color.Transparent
        Me.gbtnback.Size = New System.Drawing.Size(98, 34)
        Me.gbtnback.TabIndex = 61
        Me.gbtnback.Text = "Back"
        Me.gbtnback.UseTransparentBackground = True
        '
        'gcmbctrl
        '
        Me.gcmbctrl.BackColor = System.Drawing.Color.Transparent
        Me.gcmbctrl.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gcmbctrl.BorderRadius = 15
        Me.gcmbctrl.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.gcmbctrl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.gcmbctrl.FocusedColor = System.Drawing.Color.Empty
        Me.gcmbctrl.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gcmbctrl.ForeColor = System.Drawing.Color.Black
        Me.gcmbctrl.FormattingEnabled = True
        Me.gcmbctrl.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.gcmbctrl.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gcmbctrl.ItemHeight = 30
        Me.gcmbctrl.Items.AddRange(New Object() {"Info", "EditInfo"})
        Me.gcmbctrl.Location = New System.Drawing.Point(378, 69)
        Me.gcmbctrl.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gcmbctrl.Name = "gcmbctrl"
        Me.gcmbctrl.Size = New System.Drawing.Size(181, 36)
        Me.gcmbctrl.TabIndex = 62
        '
        'UserProfileForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(608, 769)
        Me.Controls.Add(Me.gcmbctrl)
        Me.Controls.Add(Me.gbtnback)
        Me.Controls.Add(Me.gtbxuname)
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
        Me.Controls.Add(Me.gbtnupdateinfo)
        Me.Controls.Add(Me.gtbxfname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "UserProfileForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserProfileForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents gtbxincome As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents gbirthdate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents gcmbsource As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents gcmboccupation As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents gtbxaddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents gtbxlname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents gbtnupdateinfo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents gtbxfname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents gtbxuname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents gbtnback As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents gcmbctrl As Guna.UI2.WinForms.Guna2ComboBox
End Class
