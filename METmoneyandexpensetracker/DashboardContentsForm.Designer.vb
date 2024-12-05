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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend5 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
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
        Me.lblavailbal.Location = New System.Drawing.Point(57, 15)
        Me.lblavailbal.Name = "lblavailbal"
        Me.lblavailbal.Size = New System.Drawing.Size(160, 35)
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
        Me.Label1.Location = New System.Drawing.Point(15, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 19)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Available Balance"
        '
        'gdashgrid
        '
        Me.gdashgrid.AllowUserToAddRows = False
        Me.gdashgrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black
        Me.gdashgrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gdashgrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.gdashgrid.ColumnHeadersHeight = 19
        Me.gdashgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.gdashgrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Transaction, Me.Category, Me.Transname, Me.Price, Me.Quantity, Me.Total, Me.Transdate, Me.EditRec, Me.DeleteRec})
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gdashgrid.DefaultCellStyle = DataGridViewCellStyle15
        Me.gdashgrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gdashgrid.Location = New System.Drawing.Point(9, 43)
        Me.gdashgrid.Name = "gdashgrid"
        Me.gdashgrid.ReadOnly = True
        Me.gdashgrid.RowHeadersVisible = False
        Me.gdashgrid.Size = New System.Drawing.Size(852, 197)
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
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 44
        '
        'Transaction
        '
        Me.Transaction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Transaction.HeaderText = "Transaction"
        Me.Transaction.Name = "Transaction"
        Me.Transaction.ReadOnly = True
        Me.Transaction.Width = 107
        '
        'Category
        '
        Me.Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Category.HeaderText = "Category"
        Me.Category.Name = "Category"
        Me.Category.ReadOnly = True
        Me.Category.Width = 86
        '
        'Transname
        '
        Me.Transname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Transname.HeaderText = "Transaction name"
        Me.Transname.Name = "Transname"
        Me.Transname.ReadOnly = True
        '
        'Price
        '
        Me.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Price.HeaderText = "Price"
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        Me.Price.Width = 65
        '
        'Quantity
        '
        Me.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        Me.Quantity.Width = 86
        '
        'Total
        '
        Me.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 65
        '
        'Transdate
        '
        Me.Transdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Transdate.HeaderText = "Date"
        Me.Transdate.Name = "Transdate"
        Me.Transdate.ReadOnly = True
        Me.Transdate.Width = 58
        '
        'EditRec
        '
        Me.EditRec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.EditRec.HeaderText = "Edit"
        Me.EditRec.Name = "EditRec"
        Me.EditRec.ReadOnly = True
        Me.EditRec.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EditRec.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.EditRec.Text = "Edit"
        Me.EditRec.UseColumnTextForButtonValue = True
        Me.EditRec.Width = 58
        '
        'DeleteRec
        '
        Me.DeleteRec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DeleteRec.HeaderText = "Delete"
        Me.DeleteRec.Name = "DeleteRec"
        Me.DeleteRec.ReadOnly = True
        Me.DeleteRec.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DeleteRec.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DeleteRec.Text = "Delete"
        Me.DeleteRec.UseColumnTextForButtonValue = True
        Me.DeleteRec.Width = 72
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
        Me.gaddtbxsearch.Location = New System.Drawing.Point(218, 9)
        Me.gaddtbxsearch.Margin = New System.Windows.Forms.Padding(4)
        Me.gaddtbxsearch.Name = "gaddtbxsearch"
        Me.gaddtbxsearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.gaddtbxsearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gaddtbxsearch.PlaceholderText = "Search in table"
        Me.gaddtbxsearch.SelectedText = ""
        Me.gaddtbxsearch.Size = New System.Drawing.Size(371, 27)
        Me.gaddtbxsearch.TabIndex = 44
        '
        'chrtexpenses
        '
        ChartArea5.Name = "ChartArea1"
        Me.chrtexpenses.ChartAreas.Add(ChartArea5)
        Legend5.Name = "Legend1"
        Me.chrtexpenses.Legends.Add(Legend5)
        Me.chrtexpenses.Location = New System.Drawing.Point(11, 11)
        Me.chrtexpenses.Name = "chrtexpenses"
        Me.chrtexpenses.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series5.ChartArea = "ChartArea1"
        Series5.Legend = "Legend1"
        Series5.Name = "Series1"
        Me.chrtexpenses.Series.Add(Series5)
        Me.chrtexpenses.Size = New System.Drawing.Size(578, 223)
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
        Me.Guna2Panel3.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Guna2Panel3.Location = New System.Drawing.Point(628, 188)
        Me.Guna2Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(254, 83)
        Me.Guna2Panel3.TabIndex = 2
        '
        'lblexp
        '
        Me.lblexp.BackColor = System.Drawing.Color.Transparent
        Me.lblexp.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblexp.ForeColor = System.Drawing.Color.White
        Me.lblexp.Location = New System.Drawing.Point(47, 38)
        Me.lblexp.Name = "lblexp"
        Me.lblexp.Size = New System.Drawing.Size(130, 35)
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
        Me.Label2.Location = New System.Drawing.Point(11, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 19)
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
        Me.Guna2Panel6.FillColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Guna2Panel6.Location = New System.Drawing.Point(628, 11)
        Me.Guna2Panel6.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel6.Name = "Guna2Panel6"
        Me.Guna2Panel6.Size = New System.Drawing.Size(254, 167)
        Me.Guna2Panel6.TabIndex = 55
        '
        'lblbudgetname
        '
        Me.lblbudgetname.AutoSize = True
        Me.lblbudgetname.BackColor = System.Drawing.Color.Transparent
        Me.lblbudgetname.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbudgetname.ForeColor = System.Drawing.Color.White
        Me.lblbudgetname.Location = New System.Drawing.Point(31, 82)
        Me.lblbudgetname.Name = "lblbudgetname"
        Me.lblbudgetname.Size = New System.Drawing.Size(117, 19)
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
        Me.gbtnsetbudget.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gbtnsetbudget.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnsetbudget.ForeColor = System.Drawing.Color.White
        Me.gbtnsetbudget.Location = New System.Drawing.Point(161, 106)
        Me.gbtnsetbudget.Name = "gbtnsetbudget"
        Me.gbtnsetbudget.Size = New System.Drawing.Size(83, 43)
        Me.gbtnsetbudget.TabIndex = 60
        Me.gbtnsetbudget.Text = "Set budget"
        '
        'lblstartdate
        '
        Me.lblstartdate.AutoSize = True
        Me.lblstartdate.BackColor = System.Drawing.Color.Transparent
        Me.lblstartdate.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstartdate.ForeColor = System.Drawing.Color.White
        Me.lblstartdate.Location = New System.Drawing.Point(32, 130)
        Me.lblstartdate.Name = "lblstartdate"
        Me.lblstartdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblstartdate.Size = New System.Drawing.Size(63, 19)
        Me.lblstartdate.TabIndex = 48
        Me.lblstartdate.Text = "(date)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(13, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 19)
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
        Me.Guna2Panel7.Location = New System.Drawing.Point(12, 287)
        Me.Guna2Panel7.Name = "Guna2Panel7"
        Me.Guna2Panel7.Size = New System.Drawing.Size(870, 251)
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
        Me.gbtntransadd.Location = New System.Drawing.Point(812, 5)
        Me.gbtntransadd.Name = "gbtntransadd"
        Me.gbtntransadd.PressedColor = System.Drawing.Color.Transparent
        Me.gbtntransadd.Size = New System.Drawing.Size(47, 32)
        Me.gbtntransadd.TabIndex = 12
        Me.gbtntransadd.Text = "+"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(194, 32)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Transactions"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel1.BorderRadius = 20
        Me.Guna2Panel1.BorderThickness = 2
        Me.Guna2Panel1.Controls.Add(Me.chrtexpenses)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.White
        Me.Guna2Panel1.Location = New System.Drawing.Point(12, 25)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(600, 246)
        Me.Guna2Panel1.TabIndex = 57
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.Image = Global.METmoneyandexpensetracker.My.Resources.Resources.Peso_icon48
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(10, 35)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(40, 40)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 47
        Me.Guna2PictureBox2.TabStop = False
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.METmoneyandexpensetracker.My.Resources.Resources.Peso_icon48
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(19, 12)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 46
        Me.Guna2PictureBox1.TabStop = False
        '
        'DashboardContentsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(900, 550)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel7)
        Me.Controls.Add(Me.Guna2Panel6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
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
End Class
