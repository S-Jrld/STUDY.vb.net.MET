﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HistoryForm
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.chartexpense = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.lblHighestTotal = New System.Windows.Forms.Label()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblTotalSpent = New System.Windows.Forms.Label()
        Me.lblYear2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel6 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel9 = New Guna.UI2.WinForms.Guna2Panel()
        Me.gdashgrid = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbtnyearly = New Guna.UI2.WinForms.Guna2Button()
        Me.gbtnmonthly = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.chartexpense, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel6.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel9.SuspendLayout()
        CType(Me.gdashgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
        '
        'chartexpense
        '
        ChartArea1.Name = "ChartArea1"
        Me.chartexpense.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chartexpense.Legends.Add(Legend1)
        Me.chartexpense.Location = New System.Drawing.Point(14, 15)
        Me.chartexpense.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chartexpense.Name = "chartexpense"
        Me.chartexpense.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chartexpense.Series.Add(Series1)
        Me.chartexpense.Size = New System.Drawing.Size(900, 320)
        Me.chartexpense.TabIndex = 47
        Me.chartexpense.Text = "Chart1"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.ForeColor = System.Drawing.Color.White
        Me.lblYear.Location = New System.Drawing.Point(34, 79)
        Me.lblYear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(64, 28)
        Me.lblYear.TabIndex = 1
        Me.lblYear.Text = "Year"
        '
        'lbldate
        '
        Me.lbldate.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.ForeColor = System.Drawing.Color.White
        Me.lbldate.Location = New System.Drawing.Point(33, 122)
        Me.lbldate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(272, 88)
        Me.lbldate.TabIndex = 0
        Me.lbldate.Text = "Date"
        '
        'lblHighestTotal
        '
        Me.lblHighestTotal.AutoSize = True
        Me.lblHighestTotal.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighestTotal.ForeColor = System.Drawing.Color.White
        Me.lblHighestTotal.Location = New System.Drawing.Point(26, 148)
        Me.lblHighestTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHighestTotal.Name = "lblHighestTotal"
        Me.lblHighestTotal.Size = New System.Drawing.Size(87, 23)
        Me.lblHighestTotal.TabIndex = 3
        Me.lblHighestTotal.Text = "Top Buy"
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategory.ForeColor = System.Drawing.Color.White
        Me.lblCategory.Location = New System.Drawing.Point(22, 108)
        Me.lblCategory.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(233, 27)
        Me.lblCategory.TabIndex = 3
        Me.lblCategory.Text = "Categorie top buy"
        '
        'lblTotalSpent
        '
        Me.lblTotalSpent.AutoSize = True
        Me.lblTotalSpent.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSpent.ForeColor = System.Drawing.Color.White
        Me.lblTotalSpent.Location = New System.Drawing.Point(25, 126)
        Me.lblTotalSpent.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalSpent.Name = "lblTotalSpent"
        Me.lblTotalSpent.Size = New System.Drawing.Size(142, 28)
        Me.lblTotalSpent.TabIndex = 2
        Me.lblTotalSpent.Text = "Moneyspend"
        '
        'lblYear2
        '
        Me.lblYear2.AutoSize = True
        Me.lblYear2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear2.ForeColor = System.Drawing.Color.White
        Me.lblYear2.Location = New System.Drawing.Point(33, 84)
        Me.lblYear2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYear2.Name = "lblYear2"
        Me.lblYear2.Size = New System.Drawing.Size(64, 28)
        Me.lblYear2.TabIndex = 2
        Me.lblYear2.Text = "Year"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(32, 29)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 34)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Top Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(24, 26)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 34)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Top Year"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(33, 34)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 34)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Top Spend"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel3.BorderRadius = 20
        Me.Guna2Panel3.BorderThickness = 1
        Me.Guna2Panel3.Controls.Add(Me.Label3)
        Me.Guna2Panel3.Controls.Add(Me.lbldate)
        Me.Guna2Panel3.Controls.Add(Me.lblYear)
        Me.Guna2Panel3.FillColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Guna2Panel3.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Panel3.Location = New System.Drawing.Point(992, 297)
        Me.Guna2Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(338, 231)
        Me.Guna2Panel3.TabIndex = 61
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel2.BorderRadius = 20
        Me.Guna2Panel2.BorderThickness = 1
        Me.Guna2Panel2.Controls.Add(Me.lblTotalSpent)
        Me.Guna2Panel2.Controls.Add(Me.lblYear2)
        Me.Guna2Panel2.Controls.Add(Me.Label4)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Panel2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Panel2.Location = New System.Drawing.Point(992, 569)
        Me.Guna2Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(338, 231)
        Me.Guna2Panel2.TabIndex = 62
        '
        'Guna2Panel6
        '
        Me.Guna2Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel6.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel6.BorderRadius = 20
        Me.Guna2Panel6.BorderThickness = 1
        Me.Guna2Panel6.Controls.Add(Me.lblHighestTotal)
        Me.Guna2Panel6.Controls.Add(Me.Label5)
        Me.Guna2Panel6.Controls.Add(Me.lblCategory)
        Me.Guna2Panel6.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Guna2Panel6.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Panel6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Guna2Panel6.Location = New System.Drawing.Point(992, 25)
        Me.Guna2Panel6.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel6.Name = "Guna2Panel6"
        Me.Guna2Panel6.Size = New System.Drawing.Size(338, 231)
        Me.Guna2Panel6.TabIndex = 63
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel1.BorderRadius = 20
        Me.Guna2Panel1.BorderThickness = 2
        Me.Guna2Panel1.Controls.Add(Me.chartexpense)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.White
        Me.Guna2Panel1.Location = New System.Drawing.Point(26, 25)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(930, 354)
        Me.Guna2Panel1.TabIndex = 65
        '
        'Guna2Panel9
        '
        Me.Guna2Panel9.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel9.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel9.BorderRadius = 20
        Me.Guna2Panel9.BorderThickness = 2
        Me.Guna2Panel9.Controls.Add(Me.gdashgrid)
        Me.Guna2Panel9.Controls.Add(Me.gbtnyearly)
        Me.Guna2Panel9.Controls.Add(Me.gbtnmonthly)
        Me.Guna2Panel9.Controls.Add(Me.Label1)
        Me.Guna2Panel9.FillColor = System.Drawing.Color.White
        Me.Guna2Panel9.Location = New System.Drawing.Point(12, 402)
        Me.Guna2Panel9.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Guna2Panel9.Name = "Guna2Panel9"
        Me.Guna2Panel9.Size = New System.Drawing.Size(963, 426)
        Me.Guna2Panel9.TabIndex = 66
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
        Me.gdashgrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.column1, Me.column2, Me.column3, Me.column4, Me.column5, Me.column6, Me.column7})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gdashgrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.gdashgrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gdashgrid.Location = New System.Drawing.Point(18, 66)
        Me.gdashgrid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gdashgrid.Name = "gdashgrid"
        Me.gdashgrid.ReadOnly = True
        Me.gdashgrid.RowHeadersVisible = False
        Me.gdashgrid.RowHeadersWidth = 62
        Me.gdashgrid.Size = New System.Drawing.Size(928, 340)
        Me.gdashgrid.TabIndex = 12
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
        'column1
        '
        Me.column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.column1.HeaderText = "Transaction"
        Me.column1.MinimumWidth = 8
        Me.column1.Name = "column1"
        Me.column1.ReadOnly = True
        Me.column1.Width = 165
        '
        'column2
        '
        Me.column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.column2.HeaderText = "Category"
        Me.column2.MinimumWidth = 8
        Me.column2.Name = "column2"
        Me.column2.ReadOnly = True
        Me.column2.Width = 132
        '
        'column3
        '
        Me.column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.column3.HeaderText = "Transaction name"
        Me.column3.MinimumWidth = 8
        Me.column3.Name = "column3"
        Me.column3.ReadOnly = True
        '
        'column4
        '
        Me.column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.column4.HeaderText = "Price"
        Me.column4.MinimumWidth = 8
        Me.column4.Name = "column4"
        Me.column4.ReadOnly = True
        Me.column4.Width = 99
        '
        'column5
        '
        Me.column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.column5.HeaderText = "Quantity"
        Me.column5.MinimumWidth = 8
        Me.column5.Name = "column5"
        Me.column5.ReadOnly = True
        Me.column5.Width = 132
        '
        'column6
        '
        Me.column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.column6.HeaderText = "Total"
        Me.column6.MinimumWidth = 8
        Me.column6.Name = "column6"
        Me.column6.ReadOnly = True
        Me.column6.Width = 99
        '
        'column7
        '
        Me.column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.column7.HeaderText = "Date"
        Me.column7.MinimumWidth = 8
        Me.column7.Name = "column7"
        Me.column7.ReadOnly = True
        Me.column7.Width = 88
        '
        'gbtnyearly
        '
        Me.gbtnyearly.BackColor = System.Drawing.Color.White
        Me.gbtnyearly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.gbtnyearly.BorderRadius = 10
        Me.gbtnyearly.BorderThickness = 2
        Me.gbtnyearly.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gbtnyearly.FillColor = System.Drawing.Color.White
        Me.gbtnyearly.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnyearly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.gbtnyearly.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.gbtnyearly.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gbtnyearly.Location = New System.Drawing.Point(712, 18)
        Me.gbtnyearly.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbtnyearly.Name = "gbtnyearly"
        Me.gbtnyearly.PressedColor = System.Drawing.Color.Transparent
        Me.gbtnyearly.Size = New System.Drawing.Size(165, 38)
        Me.gbtnyearly.TabIndex = 11
        Me.gbtnyearly.Text = "Yearly"
        '
        'gbtnmonthly
        '
        Me.gbtnmonthly.BackColor = System.Drawing.Color.White
        Me.gbtnmonthly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.gbtnmonthly.BorderRadius = 10
        Me.gbtnmonthly.BorderThickness = 2
        Me.gbtnmonthly.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gbtnmonthly.FillColor = System.Drawing.Color.White
        Me.gbtnmonthly.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnmonthly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.gbtnmonthly.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.gbtnmonthly.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gbtnmonthly.Location = New System.Drawing.Point(532, 18)
        Me.gbtnmonthly.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbtnmonthly.Name = "gbtnmonthly"
        Me.gbtnmonthly.PressedColor = System.Drawing.Color.Transparent
        Me.gbtnmonthly.Size = New System.Drawing.Size(165, 38)
        Me.gbtnmonthly.TabIndex = 10
        Me.gbtnmonthly.Text = "Monthly"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(296, 48)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Transactions"
        '
        'HistoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(1350, 846)
        Me.Controls.Add(Me.Guna2Panel9)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2Panel6)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "HistoryForm"
        CType(Me.chartexpense, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel6.ResumeLayout(False)
        Me.Guna2Panel6.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel9.ResumeLayout(False)
        Me.Guna2Panel9.PerformLayout()
        CType(Me.gdashgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents chartexpense As DataVisualization.Charting.Chart
    Friend WithEvents lblHighestTotal As Label
    Friend WithEvents lblCategory As Label
    Friend WithEvents lblTotalSpent As Label
    Friend WithEvents lblYear2 As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lbldate As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel9 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents gbtnyearly As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents gbtnmonthly As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents gdashgrid As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents column1 As DataGridViewTextBoxColumn
    Friend WithEvents column2 As DataGridViewTextBoxColumn
    Friend WithEvents column3 As DataGridViewTextBoxColumn
    Friend WithEvents column4 As DataGridViewTextBoxColumn
    Friend WithEvents column5 As DataGridViewTextBoxColumn
    Friend WithEvents column6 As DataGridViewTextBoxColumn
    Friend WithEvents column7 As DataGridViewTextBoxColumn
End Class
