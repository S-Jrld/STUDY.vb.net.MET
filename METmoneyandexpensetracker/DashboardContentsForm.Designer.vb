<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardContentsForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lbldashtitle = New System.Windows.Forms.Label()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblexp = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblbal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gaddtbxqty = New Guna.UI2.WinForms.Guna2TextBox()
        Me.gaddtbxname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.gaddtbxprice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.gaddcbxcat = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.gadddate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.gdashgrid = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.gaddtbxid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.gaddtbxsearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbtnsave = New Guna.UI2.WinForms.Guna2Button()
        Me.gbtnupdate = New Guna.UI2.WinForms.Guna2Button()
        Me.gbtndel = New Guna.UI2.WinForms.Guna2Button()
        Me.gbtnclear = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.chrtexpenses = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.gdashgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chrtexpenses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel1.BorderRadius = 15
        Me.Guna2Panel1.BorderThickness = 1
        Me.Guna2Panel1.Controls.Add(Me.lbldashtitle)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel3)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.LightGreen
        Me.Guna2Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(485, 115)
        Me.Guna2Panel1.TabIndex = 0
        '
        'lbldashtitle
        '
        Me.lbldashtitle.AutoSize = True
        Me.lbldashtitle.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldashtitle.Location = New System.Drawing.Point(13, 2)
        Me.lbldashtitle.Name = "lbldashtitle"
        Me.lbldashtitle.Size = New System.Drawing.Size(125, 25)
        Me.lbldashtitle.TabIndex = 9
        Me.lbldashtitle.Text = "Dashboard"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel3.BorderRadius = 15
        Me.Guna2Panel3.BorderThickness = 1
        Me.Guna2Panel3.Controls.Add(Me.Guna2PictureBox2)
        Me.Guna2Panel3.Controls.Add(Me.lblexp)
        Me.Guna2Panel3.Controls.Add(Me.Label2)
        Me.Guna2Panel3.FillColor = System.Drawing.Color.Honeydew
        Me.Guna2Panel3.Location = New System.Drawing.Point(251, 31)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(226, 76)
        Me.Guna2Panel3.TabIndex = 2
        '
        'lblexp
        '
        Me.lblexp.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblexp.Location = New System.Drawing.Point(40, 45)
        Me.lblexp.Name = "lblexp"
        Me.lblexp.Size = New System.Drawing.Size(183, 25)
        Me.lblexp.TabIndex = 12
        Me.lblexp.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 25)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Total Expenses"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel2.BorderRadius = 15
        Me.Guna2Panel2.BorderThickness = 1
        Me.Guna2Panel2.Controls.Add(Me.lblbal)
        Me.Guna2Panel2.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel2.Controls.Add(Me.Label1)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.Honeydew
        Me.Guna2Panel2.Location = New System.Drawing.Point(9, 30)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(226, 76)
        Me.Guna2Panel2.TabIndex = 1
        '
        'lblbal
        '
        Me.lblbal.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbal.Location = New System.Drawing.Point(40, 45)
        Me.lblbal.Name = "lblbal"
        Me.lblbal.Size = New System.Drawing.Size(183, 25)
        Me.lblbal.TabIndex = 11
        Me.lblbal.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Remaining Balance"
        '
        'gaddtbxqty
        '
        Me.gaddtbxqty.BorderRadius = 12
        Me.gaddtbxqty.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.gaddtbxqty.DefaultText = ""
        Me.gaddtbxqty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gaddtbxqty.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.gaddtbxqty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gaddtbxqty.DisabledState.Parent = Me.gaddtbxqty
        Me.gaddtbxqty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gaddtbxqty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gaddtbxqty.FocusedState.Parent = Me.gaddtbxqty
        Me.gaddtbxqty.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gaddtbxqty.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gaddtbxqty.HoverState.Parent = Me.gaddtbxqty
        Me.gaddtbxqty.IconLeftSize = New System.Drawing.Size(30, 30)
        Me.gaddtbxqty.Location = New System.Drawing.Point(638, 184)
        Me.gaddtbxqty.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gaddtbxqty.Name = "gaddtbxqty"
        Me.gaddtbxqty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.gaddtbxqty.PlaceholderText = "Quantity"
        Me.gaddtbxqty.SelectedText = ""
        Me.gaddtbxqty.ShadowDecoration.Parent = Me.gaddtbxqty
        Me.gaddtbxqty.Size = New System.Drawing.Size(200, 39)
        Me.gaddtbxqty.TabIndex = 28
        '
        'gaddtbxname
        '
        Me.gaddtbxname.BorderRadius = 12
        Me.gaddtbxname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.gaddtbxname.DefaultText = ""
        Me.gaddtbxname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gaddtbxname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.gaddtbxname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gaddtbxname.DisabledState.Parent = Me.gaddtbxname
        Me.gaddtbxname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gaddtbxname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gaddtbxname.FocusedState.Parent = Me.gaddtbxname
        Me.gaddtbxname.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gaddtbxname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gaddtbxname.HoverState.Parent = Me.gaddtbxname
        Me.gaddtbxname.IconLeftSize = New System.Drawing.Size(30, 30)
        Me.gaddtbxname.Location = New System.Drawing.Point(638, 88)
        Me.gaddtbxname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gaddtbxname.Name = "gaddtbxname"
        Me.gaddtbxname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.gaddtbxname.PlaceholderText = "Expenses name"
        Me.gaddtbxname.SelectedText = ""
        Me.gaddtbxname.ShadowDecoration.Parent = Me.gaddtbxname
        Me.gaddtbxname.Size = New System.Drawing.Size(200, 39)
        Me.gaddtbxname.TabIndex = 29
        '
        'gaddtbxprice
        '
        Me.gaddtbxprice.BorderRadius = 12
        Me.gaddtbxprice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.gaddtbxprice.DefaultText = ""
        Me.gaddtbxprice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gaddtbxprice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.gaddtbxprice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gaddtbxprice.DisabledState.Parent = Me.gaddtbxprice
        Me.gaddtbxprice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gaddtbxprice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gaddtbxprice.FocusedState.Parent = Me.gaddtbxprice
        Me.gaddtbxprice.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gaddtbxprice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gaddtbxprice.HoverState.Parent = Me.gaddtbxprice
        Me.gaddtbxprice.IconLeftSize = New System.Drawing.Size(30, 30)
        Me.gaddtbxprice.Location = New System.Drawing.Point(638, 136)
        Me.gaddtbxprice.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gaddtbxprice.Name = "gaddtbxprice"
        Me.gaddtbxprice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.gaddtbxprice.PlaceholderText = "Price"
        Me.gaddtbxprice.SelectedText = ""
        Me.gaddtbxprice.ShadowDecoration.Parent = Me.gaddtbxprice
        Me.gaddtbxprice.Size = New System.Drawing.Size(200, 39)
        Me.gaddtbxprice.TabIndex = 31
        '
        'gaddcbxcat
        '
        Me.gaddcbxcat.BackColor = System.Drawing.Color.Transparent
        Me.gaddcbxcat.BorderRadius = 12
        Me.gaddcbxcat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.gaddcbxcat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.gaddcbxcat.FocusedColor = System.Drawing.Color.Empty
        Me.gaddcbxcat.FocusedState.Parent = Me.gaddcbxcat
        Me.gaddcbxcat.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.gaddcbxcat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.gaddcbxcat.FormattingEnabled = True
        Me.gaddcbxcat.HoverState.Parent = Me.gaddcbxcat
        Me.gaddcbxcat.ItemHeight = 30
        Me.gaddcbxcat.Items.AddRange(New Object() {"Food", "Transportation", "Utilities", "Clothing", "Healthcare", "Insurance", "Necessity", "Debt", "Savings", "Other expenses"})
        Me.gaddcbxcat.ItemsAppearance.Parent = Me.gaddcbxcat
        Me.gaddcbxcat.Location = New System.Drawing.Point(638, 45)
        Me.gaddcbxcat.Name = "gaddcbxcat"
        Me.gaddcbxcat.ShadowDecoration.Parent = Me.gaddcbxcat
        Me.gaddcbxcat.Size = New System.Drawing.Size(200, 36)
        Me.gaddcbxcat.TabIndex = 32
        '
        'gadddate
        '
        Me.gadddate.BorderRadius = 12
        Me.gadddate.CheckedState.Parent = Me.gadddate
        Me.gadddate.CustomFormat = "yyyy-mm-dd"
        Me.gadddate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.gadddate.HoverState.Parent = Me.gadddate
        Me.gadddate.Location = New System.Drawing.Point(638, 231)
        Me.gadddate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.gadddate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.gadddate.Name = "gadddate"
        Me.gadddate.ShadowDecoration.Parent = Me.gadddate
        Me.gadddate.Size = New System.Drawing.Size(200, 39)
        Me.gadddate.TabIndex = 33
        Me.gadddate.Value = New Date(2024, 11, 26, 0, 0, 0, 0)
        '
        'gdashgrid
        '
        Me.gdashgrid.AllowUserToAddRows = False
        Me.gdashgrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.gdashgrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.gdashgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gdashgrid.BackgroundColor = System.Drawing.Color.White
        Me.gdashgrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gdashgrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.gdashgrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gdashgrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.gdashgrid.ColumnHeadersHeight = 19
        Me.gdashgrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gdashgrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.gdashgrid.EnableHeadersVisualStyles = False
        Me.gdashgrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gdashgrid.Location = New System.Drawing.Point(12, 336)
        Me.gdashgrid.Name = "gdashgrid"
        Me.gdashgrid.ReadOnly = True
        Me.gdashgrid.RowHeadersVisible = False
        Me.gdashgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gdashgrid.Size = New System.Drawing.Size(826, 202)
        Me.gdashgrid.TabIndex = 7
        Me.gdashgrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.gdashgrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.gdashgrid.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.gdashgrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.gdashgrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.gdashgrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.gdashgrid.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.gdashgrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gdashgrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gdashgrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.gdashgrid.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.gdashgrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.gdashgrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.gdashgrid.ThemeStyle.HeaderStyle.Height = 19
        Me.gdashgrid.ThemeStyle.ReadOnly = True
        Me.gdashgrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.gdashgrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.gdashgrid.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.gdashgrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.gdashgrid.ThemeStyle.RowsStyle.Height = 22
        Me.gdashgrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gdashgrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'gaddtbxid
        '
        Me.gaddtbxid.BorderRadius = 12
        Me.gaddtbxid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.gaddtbxid.DefaultText = "ID"
        Me.gaddtbxid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gaddtbxid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.gaddtbxid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gaddtbxid.DisabledState.Parent = Me.gaddtbxid
        Me.gaddtbxid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gaddtbxid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gaddtbxid.FocusedState.Parent = Me.gaddtbxid
        Me.gaddtbxid.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gaddtbxid.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gaddtbxid.HoverState.Parent = Me.gaddtbxid
        Me.gaddtbxid.IconLeftSize = New System.Drawing.Size(30, 30)
        Me.gaddtbxid.Location = New System.Drawing.Point(13, 290)
        Me.gaddtbxid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gaddtbxid.Name = "gaddtbxid"
        Me.gaddtbxid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.gaddtbxid.PlaceholderText = "Expenses name"
        Me.gaddtbxid.SelectedText = ""
        Me.gaddtbxid.SelectionStart = 2
        Me.gaddtbxid.ShadowDecoration.Parent = Me.gaddtbxid
        Me.gaddtbxid.Size = New System.Drawing.Size(76, 39)
        Me.gaddtbxid.TabIndex = 43
        '
        'gaddtbxsearch
        '
        Me.gaddtbxsearch.BorderRadius = 12
        Me.gaddtbxsearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.gaddtbxsearch.DefaultText = ""
        Me.gaddtbxsearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gaddtbxsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.gaddtbxsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gaddtbxsearch.DisabledState.Parent = Me.gaddtbxsearch
        Me.gaddtbxsearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gaddtbxsearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gaddtbxsearch.FocusedState.Parent = Me.gaddtbxsearch
        Me.gaddtbxsearch.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gaddtbxsearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gaddtbxsearch.HoverState.Parent = Me.gaddtbxsearch
        Me.gaddtbxsearch.IconLeftSize = New System.Drawing.Size(30, 30)
        Me.gaddtbxsearch.Location = New System.Drawing.Point(97, 290)
        Me.gaddtbxsearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gaddtbxsearch.Name = "gaddtbxsearch"
        Me.gaddtbxsearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.gaddtbxsearch.PlaceholderText = "Search"
        Me.gaddtbxsearch.SelectedText = ""
        Me.gaddtbxsearch.ShadowDecoration.Parent = Me.gaddtbxsearch
        Me.gaddtbxsearch.Size = New System.Drawing.Size(328, 39)
        Me.gaddtbxsearch.TabIndex = 44
        '
        'Guna2Button4
        '
        Me.Guna2Button4.CheckedState.Parent = Me.Guna2Button4
        Me.Guna2Button4.CustomImages.Parent = Me.Guna2Button4
        Me.Guna2Button4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button4.ForeColor = System.Drawing.Color.White
        Me.Guna2Button4.HoverState.Parent = Me.Guna2Button4
        Me.Guna2Button4.Location = New System.Drawing.Point(512, 18)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.ShadowDecoration.Parent = Me.Guna2Button4
        Me.Guna2Button4.Size = New System.Drawing.Size(99, 45)
        Me.Guna2Button4.TabIndex = 45
        Me.Guna2Button4.Text = "Set budget"
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 46
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "Category"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 88
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Expenses Name"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "Price"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 61
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "Quantity"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 86
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "Date"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 61
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "Total"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 61
        '
        'gbtnsave
        '
        Me.gbtnsave.BorderRadius = 10
        Me.gbtnsave.CheckedState.Parent = Me.gbtnsave
        Me.gbtnsave.CustomImages.Parent = Me.gbtnsave
        Me.gbtnsave.FillColor = System.Drawing.Color.Transparent
        Me.gbtnsave.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.gbtnsave.ForeColor = System.Drawing.Color.White
        Me.gbtnsave.HoverState.Parent = Me.gbtnsave
        Me.gbtnsave.Image = Global.METmoneyandexpensetracker.My.Resources.Resources.Save_icon48
        Me.gbtnsave.ImageSize = New System.Drawing.Size(48, 48)
        Me.gbtnsave.Location = New System.Drawing.Point(449, 281)
        Me.gbtnsave.Name = "gbtnsave"
        Me.gbtnsave.ShadowDecoration.Parent = Me.gbtnsave
        Me.gbtnsave.Size = New System.Drawing.Size(48, 48)
        Me.gbtnsave.TabIndex = 42
        '
        'gbtnupdate
        '
        Me.gbtnupdate.BorderRadius = 10
        Me.gbtnupdate.CheckedState.Parent = Me.gbtnupdate
        Me.gbtnupdate.CustomImages.Parent = Me.gbtnupdate
        Me.gbtnupdate.FillColor = System.Drawing.Color.Transparent
        Me.gbtnupdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.gbtnupdate.ForeColor = System.Drawing.Color.White
        Me.gbtnupdate.HoverState.Parent = Me.gbtnupdate
        Me.gbtnupdate.Image = Global.METmoneyandexpensetracker.My.Resources.Resources.Update_icon64
        Me.gbtnupdate.ImageSize = New System.Drawing.Size(48, 48)
        Me.gbtnupdate.Location = New System.Drawing.Point(503, 281)
        Me.gbtnupdate.Name = "gbtnupdate"
        Me.gbtnupdate.ShadowDecoration.Parent = Me.gbtnupdate
        Me.gbtnupdate.Size = New System.Drawing.Size(48, 48)
        Me.gbtnupdate.TabIndex = 41
        '
        'gbtndel
        '
        Me.gbtndel.BorderRadius = 10
        Me.gbtndel.CheckedState.Parent = Me.gbtndel
        Me.gbtndel.CustomImages.Parent = Me.gbtndel
        Me.gbtndel.FillColor = System.Drawing.Color.Transparent
        Me.gbtndel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.gbtndel.ForeColor = System.Drawing.Color.White
        Me.gbtndel.HoverState.Parent = Me.gbtndel
        Me.gbtndel.Image = Global.METmoneyandexpensetracker.My.Resources.Resources.Delete_icon48
        Me.gbtndel.ImageSize = New System.Drawing.Size(48, 48)
        Me.gbtndel.Location = New System.Drawing.Point(557, 281)
        Me.gbtndel.Name = "gbtndel"
        Me.gbtndel.ShadowDecoration.Parent = Me.gbtndel
        Me.gbtndel.Size = New System.Drawing.Size(48, 48)
        Me.gbtndel.TabIndex = 40
        '
        'gbtnclear
        '
        Me.gbtnclear.BorderRadius = 10
        Me.gbtnclear.CheckedState.Parent = Me.gbtnclear
        Me.gbtnclear.CustomImages.Parent = Me.gbtnclear
        Me.gbtnclear.FillColor = System.Drawing.Color.Transparent
        Me.gbtnclear.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.gbtnclear.ForeColor = System.Drawing.Color.White
        Me.gbtnclear.HoverState.Parent = Me.gbtnclear
        Me.gbtnclear.Image = Global.METmoneyandexpensetracker.My.Resources.Resources.Clear_icon48
        Me.gbtnclear.ImageSize = New System.Drawing.Size(48, 48)
        Me.gbtnclear.Location = New System.Drawing.Point(618, 282)
        Me.gbtnclear.Name = "gbtnclear"
        Me.gbtnclear.ShadowDecoration.Parent = Me.gbtnclear
        Me.gbtnclear.Size = New System.Drawing.Size(48, 48)
        Me.gbtnclear.TabIndex = 39
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Image = Global.METmoneyandexpensetracker.My.Resources.Resources.Peso_icon48
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(3, 39)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.ShadowDecoration.Parent = Me.Guna2PictureBox2
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(35, 35)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 47
        Me.Guna2PictureBox2.TabStop = False
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.METmoneyandexpensetracker.My.Resources.Resources.Peso_icon48
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(3, 38)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(35, 35)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 46
        Me.Guna2PictureBox1.TabStop = False
        '
        'chrtexpenses
        '
        ChartArea1.Name = "ChartArea1"
        Me.chrtexpenses.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chrtexpenses.Legends.Add(Legend1)
        Me.chrtexpenses.Location = New System.Drawing.Point(13, 133)
        Me.chrtexpenses.Name = "chrtexpenses"
        Me.chrtexpenses.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chrtexpenses.Series.Add(Series1)
        Me.chrtexpenses.Size = New System.Drawing.Size(430, 150)
        Me.chrtexpenses.TabIndex = 46
        Me.chrtexpenses.Text = "Chart1"
        '
        'DashboardContentsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 550)
        Me.Controls.Add(Me.chrtexpenses)
        Me.Controls.Add(Me.Guna2Button4)
        Me.Controls.Add(Me.gaddtbxsearch)
        Me.Controls.Add(Me.gaddtbxid)
        Me.Controls.Add(Me.gbtnsave)
        Me.Controls.Add(Me.gbtnupdate)
        Me.Controls.Add(Me.gbtndel)
        Me.Controls.Add(Me.gbtnclear)
        Me.Controls.Add(Me.gdashgrid)
        Me.Controls.Add(Me.gadddate)
        Me.Controls.Add(Me.gaddcbxcat)
        Me.Controls.Add(Me.gaddtbxprice)
        Me.Controls.Add(Me.gaddtbxname)
        Me.Controls.Add(Me.gaddtbxqty)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DashboardContentsForm"
        Me.Text = "DashboardContentsForm"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.gdashgrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chrtexpenses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lbldashtitle As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents gaddtbxname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents gaddtbxqty As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents gdashgrid As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents gadddate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents gaddcbxcat As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents gaddtbxprice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents gbtnsave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents gbtnupdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents gbtndel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents gbtnclear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents gaddtbxid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents gaddtbxsearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lblexp As Label
    Friend WithEvents lblbal As Label
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents chrtexpenses As DataVisualization.Charting.Chart
End Class
