<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardContentsForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.lblavailbal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gdashgrid = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Transaction = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Transname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Transdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EditRec = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DeleteRec = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.gaddtbxsearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.chrtexpenses = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblexp = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2Panel6 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblbudgetname = New System.Windows.Forms.Label()
        Me.gbtnsetbudget = New Guna.UI2.WinForms.Guna2Button()
        Me.lblstartdate = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2Panel7 = New Guna.UI2.WinForms.Guna2Panel()
        Me.gbtntransadd = New Guna.UI2.WinForms.Guna2Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.gdashgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chrtexpenses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel6.SuspendLayout()
        Me.Guna2Panel7.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
        '
        'lblavailbal
        '
        Me.lblavailbal.BackColor = System.Drawing.Color.Transparent
        Me.lblavailbal.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblavailbal.ForeColor = System.Drawing.Color.White
        Me.lblavailbal.Location = New System.Drawing.Point(86, 23)
        Me.lblavailbal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblavailbal.Name = "lblavailbal"
        Me.lblavailbal.Size = New System.Drawing.Size(240, 54)
        Me.lblavailbal.TabIndex = 11
        Me.lblavailbal.Text = "0"
        Me.lblavailbal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(22, 89)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 28)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Available Balance"
        '
        'gdashgrid
        '
        Me.gdashgrid.AllowUserToAddRows = False
        Me.gdashgrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.gdashgrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gdashgrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.gdashgrid.ColumnHeadersHeight = 19
        Me.gdashgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.gdashgrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Transaction, Me.Category, Me.Transname, Me.Price, Me.Quantity, Me.Total, Me.Transdate, Me.EditRec, Me.DeleteRec})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gdashgrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.gdashgrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gdashgrid.Location = New System.Drawing.Point(14, 66)
        Me.gdashgrid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gdashgrid.Name = "gdashgrid"
        Me.gdashgrid.ReadOnly = True
        Me.gdashgrid.RowHeadersVisible = False
        Me.gdashgrid.RowHeadersWidth = 62
        Me.gdashgrid.Size = New System.Drawing.Size(1278, 303)
        Me.gdashgrid.TabIndex = 0
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
        'ID
        '
        Me.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ID.HeaderText = "ID"
        Me.ID.MinimumWidth = 8
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 66
        '
        'Transaction
        '
        Me.Transaction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Transaction.HeaderText = "Transaction"
        Me.Transaction.MinimumWidth = 8
        Me.Transaction.Name = "Transaction"
        Me.Transaction.ReadOnly = True
        Me.Transaction.Width = 165
        '
        'Category
        '
        Me.Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Category.HeaderText = "Category"
        Me.Category.MinimumWidth = 8
        Me.Category.Name = "Category"
        Me.Category.ReadOnly = True
        Me.Category.Width = 132
        '
        'Transname
        '
        Me.Transname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Transname.HeaderText = "Transaction name"
        Me.Transname.MinimumWidth = 8
        Me.Transname.Name = "Transname"
        Me.Transname.ReadOnly = True
        '
        'Price
        '
        Me.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Price.HeaderText = "Price"
        Me.Price.MinimumWidth = 8
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        Me.Price.Width = 99
        '
        'Quantity
        '
        Me.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.MinimumWidth = 8
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        Me.Quantity.Width = 132
        '
        'Total
        '
        Me.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Total.HeaderText = "Total"
        Me.Total.MinimumWidth = 8
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 99
        '
        'Transdate
        '
        Me.Transdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Transdate.HeaderText = "Date"
        Me.Transdate.MinimumWidth = 8
        Me.Transdate.Name = "Transdate"
        Me.Transdate.ReadOnly = True
        Me.Transdate.Width = 88
        '
        'EditRec
        '
        Me.EditRec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.EditRec.HeaderText = "Edit"
        Me.EditRec.MinimumWidth = 8
        Me.EditRec.Name = "EditRec"
        Me.EditRec.ReadOnly = True
        Me.EditRec.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EditRec.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.EditRec.Text = "Edit"
        Me.EditRec.UseColumnTextForButtonValue = True
        Me.EditRec.Width = 88
        '
        'DeleteRec
        '
        Me.DeleteRec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DeleteRec.HeaderText = "Delete"
        Me.DeleteRec.MinimumWidth = 8
        Me.DeleteRec.Name = "DeleteRec"
        Me.DeleteRec.ReadOnly = True
        Me.DeleteRec.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DeleteRec.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DeleteRec.Text = "Delete"
        Me.DeleteRec.UseColumnTextForButtonValue = True
        Me.DeleteRec.Width = 110
        '
        'gaddtbxsearch
        '
        Me.gaddtbxsearch.BackColor = System.Drawing.Color.Transparent
        Me.gaddtbxsearch.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gaddtbxsearch.BorderRadius = 12
        Me.gaddtbxsearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.gaddtbxsearch.DefaultText = ""
        Me.gaddtbxsearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gaddtbxsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.gaddtbxsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gaddtbxsearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gaddtbxsearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gaddtbxsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gaddtbxsearch.ForeColor = System.Drawing.Color.Black
        Me.gaddtbxsearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.gaddtbxsearch.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gaddtbxsearch.IconLeftSize = New System.Drawing.Size(30, 30)
        Me.gaddtbxsearch.Location = New System.Drawing.Point(327, 14)
        Me.gaddtbxsearch.Margin = New System.Windows.Forms.Padding(6)
        Me.gaddtbxsearch.Name = "gaddtbxsearch"
        Me.gaddtbxsearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.gaddtbxsearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gaddtbxsearch.PlaceholderText = "Search in table"
        Me.gaddtbxsearch.SelectedText = ""
        Me.gaddtbxsearch.Size = New System.Drawing.Size(556, 42)
        Me.gaddtbxsearch.TabIndex = 44
        '
        'chrtexpenses
        '
        ChartArea1.Name = "ChartArea1"
        Me.chrtexpenses.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chrtexpenses.Legends.Add(Legend1)
        Me.chrtexpenses.Location = New System.Drawing.Point(16, 17)
        Me.chrtexpenses.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chrtexpenses.Name = "chrtexpenses"
        Me.chrtexpenses.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chrtexpenses.Series.Add(Series1)
        Me.chrtexpenses.Size = New System.Drawing.Size(867, 343)
        Me.chrtexpenses.TabIndex = 46
        Me.chrtexpenses.Text = "Chart1"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.BorderRadius = 20
        Me.Guna2Panel3.BorderThickness = 1
        Me.Guna2Panel3.Controls.Add(Me.Guna2PictureBox2)
        Me.Guna2Panel3.Controls.Add(Me.lblexp)
        Me.Guna2Panel3.Controls.Add(Me.Label2)
        Me.Guna2Panel3.FillColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Guna2Panel3.Location = New System.Drawing.Point(942, 289)
        Me.Guna2Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(381, 128)
        Me.Guna2Panel3.TabIndex = 2
        '
        'lblexp
        '
        Me.lblexp.BackColor = System.Drawing.Color.Transparent
        Me.lblexp.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblexp.ForeColor = System.Drawing.Color.White
        Me.lblexp.Location = New System.Drawing.Point(95, 54)
        Me.lblexp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblexp.Name = "lblexp"
        Me.lblexp.Size = New System.Drawing.Size(210, 54)
        Me.lblexp.TabIndex = 12
        Me.lblexp.Text = "0"
        Me.lblexp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 23)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(194, 28)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Total Expenses"
        '
        'Guna2Panel6
        '
        Me.Guna2Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel6.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel6.BorderRadius = 20
        Me.Guna2Panel6.BorderThickness = 1
        Me.Guna2Panel6.Controls.Add(Me.lblbudgetname)
        Me.Guna2Panel6.Controls.Add(Me.gbtnsetbudget)
        Me.Guna2Panel6.Controls.Add(Me.lblstartdate)
        Me.Guna2Panel6.Controls.Add(Me.Label3)
        Me.Guna2Panel6.Controls.Add(Me.lblavailbal)
        Me.Guna2Panel6.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel6.Controls.Add(Me.Label1)
        Me.Guna2Panel6.FillColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Guna2Panel6.Location = New System.Drawing.Point(942, 17)
        Me.Guna2Panel6.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel6.Name = "Guna2Panel6"
        Me.Guna2Panel6.Size = New System.Drawing.Size(381, 257)
        Me.Guna2Panel6.TabIndex = 55
        '
        'lblbudgetname
        '
        Me.lblbudgetname.AutoSize = True
        Me.lblbudgetname.BackColor = System.Drawing.Color.Transparent
        Me.lblbudgetname.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbudgetname.ForeColor = System.Drawing.Color.White
        Me.lblbudgetname.Location = New System.Drawing.Point(46, 126)
        Me.lblbudgetname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblbudgetname.Name = "lblbudgetname"
        Me.lblbudgetname.Size = New System.Drawing.Size(168, 28)
        Me.lblbudgetname.TabIndex = 61
        Me.lblbudgetname.Text = "(budgetname)"
        '
        'gbtnsetbudget
        '
        Me.gbtnsetbudget.Animated = True
        Me.gbtnsetbudget.BackColor = System.Drawing.Color.Transparent
        Me.gbtnsetbudget.BorderColor = System.Drawing.Color.Transparent
        Me.gbtnsetbudget.BorderRadius = 10
        Me.gbtnsetbudget.BorderThickness = 1
        Me.gbtnsetbudget.FillColor = System.Drawing.Color.Black
        Me.gbtnsetbudget.FocusedColor = System.Drawing.Color.Green
        Me.gbtnsetbudget.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnsetbudget.ForeColor = System.Drawing.Color.White
        Me.gbtnsetbudget.Location = New System.Drawing.Point(242, 163)
        Me.gbtnsetbudget.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbtnsetbudget.Name = "gbtnsetbudget"
        Me.gbtnsetbudget.Size = New System.Drawing.Size(124, 66)
        Me.gbtnsetbudget.TabIndex = 60
        Me.gbtnsetbudget.Text = "Set budget"
        '
        'lblstartdate
        '
        Me.lblstartdate.AutoSize = True
        Me.lblstartdate.BackColor = System.Drawing.Color.Transparent
        Me.lblstartdate.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstartdate.ForeColor = System.Drawing.Color.White
        Me.lblstartdate.Location = New System.Drawing.Point(48, 200)
        Me.lblstartdate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblstartdate.Name = "lblstartdate"
        Me.lblstartdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblstartdate.Size = New System.Drawing.Size(90, 28)
        Me.lblstartdate.TabIndex = 48
        Me.lblstartdate.Text = "(date)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(20, 160)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 28)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Startdate"
        '
        'Guna2Panel7
        '
        Me.Guna2Panel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel7.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel7.BorderRadius = 20
        Me.Guna2Panel7.BorderThickness = 2
        Me.Guna2Panel7.Controls.Add(Me.gbtntransadd)
        Me.Guna2Panel7.Controls.Add(Me.Label4)
        Me.Guna2Panel7.Controls.Add(Me.gdashgrid)
        Me.Guna2Panel7.Controls.Add(Me.gaddtbxsearch)
        Me.Guna2Panel7.FillColor = System.Drawing.Color.White
        Me.Guna2Panel7.Location = New System.Drawing.Point(18, 442)
        Me.Guna2Panel7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Guna2Panel7.Name = "Guna2Panel7"
        Me.Guna2Panel7.Size = New System.Drawing.Size(1305, 386)
        Me.Guna2Panel7.TabIndex = 56
        '
        'gbtntransadd
        '
        Me.gbtntransadd.BackColor = System.Drawing.Color.White
        Me.gbtntransadd.BorderColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.gbtntransadd.BorderRadius = 10
        Me.gbtntransadd.BorderThickness = 2
        Me.gbtntransadd.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gbtntransadd.FillColor = System.Drawing.Color.White
        Me.gbtntransadd.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtntransadd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.gbtntransadd.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.gbtntransadd.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gbtntransadd.Location = New System.Drawing.Point(1218, 8)
        Me.gbtntransadd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbtntransadd.Name = "gbtntransadd"
        Me.gbtntransadd.PressedColor = System.Drawing.Color.Transparent
        Me.gbtntransadd.Size = New System.Drawing.Size(70, 49)
        Me.gbtntransadd.TabIndex = 12
        Me.gbtntransadd.Text = "+"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 12)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(296, 48)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Transactions"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel1.BorderRadius = 20
        Me.Guna2Panel1.BorderThickness = 2
        Me.Guna2Panel1.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.Guna2Panel1.Controls.Add(Me.chrtexpenses)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.White
        Me.Guna2Panel1.Location = New System.Drawing.Point(18, 17)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(900, 399)
        Me.Guna2Panel1.TabIndex = 57
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(737, 156)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(8, 10)
        Me.Guna2CustomGradientPanel1.TabIndex = 47
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.Image = Global.METmoneyandexpensetracker.My.Resources.Resources.Peso_icon48
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(27, 54)
        Me.Guna2PictureBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(60, 62)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 47
        Me.Guna2PictureBox2.TabStop = False
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.METmoneyandexpensetracker.My.Resources.Resources.Peso_icon48
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(27, 15)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(60, 62)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 46
        Me.Guna2PictureBox1.TabStop = False
        '
        'DashboardContentsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(1350, 846)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel7)
        Me.Controls.Add(Me.Guna2Panel6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "DashboardContentsForm"
        Me.Text = " "
        CType(Me.gdashgrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chrtexpenses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.Guna2Panel6.ResumeLayout(False)
        Me.Guna2Panel6.PerformLayout()
        Me.Guna2Panel7.ResumeLayout(False)
        Me.Guna2Panel7.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Label1 As Label
    Friend WithEvents gdashgrid As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents gaddtbxsearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lblavailbal As Label
    Friend WithEvents chrtexpenses As DataVisualization.Charting.Chart
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lblexp As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2Panel7 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblstartdate As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents gbtnsetbudget As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents gbtntransadd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblbudgetname As Label
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Transaction As DataGridViewTextBoxColumn
    Friend WithEvents Category As DataGridViewTextBoxColumn
    Friend WithEvents Transname As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents Transdate As DataGridViewTextBoxColumn
    Friend WithEvents EditRec As DataGridViewButtonColumn
    Friend WithEvents DeleteRec As DataGridViewButtonColumn
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
End Class
