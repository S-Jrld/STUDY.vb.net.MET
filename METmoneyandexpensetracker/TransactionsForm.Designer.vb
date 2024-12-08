<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TransactionsForm
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
        Me.gtbxtransname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gcmbcategory = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.gdatetrans = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.gtbxprice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.gtbxqty = New Guna.UI2.WinForms.Guna2TextBox()
        Me.gbtnedittrans = New Guna.UI2.WinForms.Guna2Button()
        Me.gbtnaddtrans = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.gtbxstatus = New Guna.UI2.WinForms.Guna2TextBox()
        Me.gbtnback = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
        '
        'gtbxtransname
        '
        Me.gtbxtransname.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gtbxtransname.BorderRadius = 15
        Me.gtbxtransname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.gtbxtransname.DefaultText = ""
        Me.gtbxtransname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gtbxtransname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.gtbxtransname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gtbxtransname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gtbxtransname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gtbxtransname.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gtbxtransname.ForeColor = System.Drawing.Color.Black
        Me.gtbxtransname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.gtbxtransname.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gtbxtransname.IconLeftSize = New System.Drawing.Size(25, 25)
        Me.gtbxtransname.Location = New System.Drawing.Point(44, 255)
        Me.gtbxtransname.Margin = New System.Windows.Forms.Padding(6)
        Me.gtbxtransname.Name = "gtbxtransname"
        Me.gtbxtransname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.gtbxtransname.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gtbxtransname.PlaceholderText = "Transaction name"
        Me.gtbxtransname.SelectedText = ""
        Me.gtbxtransname.Size = New System.Drawing.Size(291, 54)
        Me.gtbxtransname.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(42, 122)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(296, 48)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Transactions"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(58, 182)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(274, 46)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "note. savings and income" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "are for income"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'gcmbcategory
        '
        Me.gcmbcategory.BackColor = System.Drawing.Color.Transparent
        Me.gcmbcategory.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gcmbcategory.BorderRadius = 15
        Me.gcmbcategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.gcmbcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.gcmbcategory.FocusedColor = System.Drawing.Color.Empty
        Me.gcmbcategory.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gcmbcategory.ForeColor = System.Drawing.Color.Black
        Me.gcmbcategory.FormattingEnabled = True
        Me.gcmbcategory.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.gcmbcategory.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gcmbcategory.ItemHeight = 30
        Me.gcmbcategory.Items.AddRange(New Object() {"Rent", "Food", "Transportation", "Utilities", "Healthcare", "Wants"})
        Me.gcmbcategory.Location = New System.Drawing.Point(360, 178)
        Me.gcmbcategory.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gcmbcategory.Name = "gcmbcategory"
        Me.gcmbcategory.Size = New System.Drawing.Size(289, 36)
        Me.gcmbcategory.TabIndex = 42
        '
        'gdatetrans
        '
        Me.gdatetrans.BackColor = System.Drawing.Color.Transparent
        Me.gdatetrans.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gdatetrans.BorderRadius = 15
        Me.gdatetrans.BorderThickness = 1
        Me.gdatetrans.Checked = True
        Me.gdatetrans.CustomFormat = "yyyy-mm-dd"
        Me.gdatetrans.FillColor = System.Drawing.Color.White
        Me.gdatetrans.Font = New System.Drawing.Font("Consolas", 9.75!)
        Me.gdatetrans.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.gdatetrans.Location = New System.Drawing.Point(363, 331)
        Me.gdatetrans.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gdatetrans.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.gdatetrans.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.gdatetrans.Name = "gdatetrans"
        Me.gdatetrans.Size = New System.Drawing.Size(291, 55)
        Me.gdatetrans.TabIndex = 43
        Me.gdatetrans.Value = New Date(2024, 11, 26, 0, 0, 0, 0)
        '
        'gtbxprice
        '
        Me.gtbxprice.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gtbxprice.BorderRadius = 15
        Me.gtbxprice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.gtbxprice.DefaultText = ""
        Me.gtbxprice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gtbxprice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.gtbxprice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gtbxprice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gtbxprice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gtbxprice.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gtbxprice.ForeColor = System.Drawing.Color.Black
        Me.gtbxprice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.gtbxprice.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gtbxprice.IconLeftSize = New System.Drawing.Size(25, 25)
        Me.gtbxprice.Location = New System.Drawing.Point(363, 255)
        Me.gtbxprice.Margin = New System.Windows.Forms.Padding(6)
        Me.gtbxprice.Name = "gtbxprice"
        Me.gtbxprice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.gtbxprice.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gtbxprice.PlaceholderText = "Price"
        Me.gtbxprice.SelectedText = ""
        Me.gtbxprice.Size = New System.Drawing.Size(291, 54)
        Me.gtbxprice.TabIndex = 44
        '
        'gtbxqty
        '
        Me.gtbxqty.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gtbxqty.BorderRadius = 15
        Me.gtbxqty.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.gtbxqty.DefaultText = ""
        Me.gtbxqty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gtbxqty.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.gtbxqty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gtbxqty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gtbxqty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gtbxqty.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gtbxqty.ForeColor = System.Drawing.Color.Black
        Me.gtbxqty.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.gtbxqty.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gtbxqty.IconLeftSize = New System.Drawing.Size(25, 25)
        Me.gtbxqty.Location = New System.Drawing.Point(44, 332)
        Me.gtbxqty.Margin = New System.Windows.Forms.Padding(6)
        Me.gtbxqty.Name = "gtbxqty"
        Me.gtbxqty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.gtbxqty.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gtbxqty.PlaceholderText = "Quantity"
        Me.gtbxqty.SelectedText = ""
        Me.gtbxqty.Size = New System.Drawing.Size(290, 54)
        Me.gtbxqty.TabIndex = 45
        '
        'gbtnedittrans
        '
        Me.gbtnedittrans.BackColor = System.Drawing.Color.White
        Me.gbtnedittrans.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.gbtnedittrans.BorderRadius = 15
        Me.gbtnedittrans.BorderThickness = 2
        Me.gbtnedittrans.CheckedState.FillColor = System.Drawing.Color.Transparent
        Me.gbtnedittrans.FillColor = System.Drawing.Color.White
        Me.gbtnedittrans.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnedittrans.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.gbtnedittrans.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.gbtnedittrans.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gbtnedittrans.Location = New System.Drawing.Point(44, 429)
        Me.gbtnedittrans.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbtnedittrans.Name = "gbtnedittrans"
        Me.gbtnedittrans.PressedColor = System.Drawing.Color.Transparent
        Me.gbtnedittrans.Size = New System.Drawing.Size(291, 51)
        Me.gbtnedittrans.TabIndex = 46
        Me.gbtnedittrans.Text = "Edit Transaction"
        '
        'gbtnaddtrans
        '
        Me.gbtnaddtrans.BackColor = System.Drawing.Color.White
        Me.gbtnaddtrans.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.gbtnaddtrans.BorderRadius = 15
        Me.gbtnaddtrans.BorderThickness = 2
        Me.gbtnaddtrans.CheckedState.FillColor = System.Drawing.Color.Transparent
        Me.gbtnaddtrans.FillColor = System.Drawing.Color.White
        Me.gbtnaddtrans.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnaddtrans.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.gbtnaddtrans.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.gbtnaddtrans.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gbtnaddtrans.Location = New System.Drawing.Point(363, 429)
        Me.gbtnaddtrans.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbtnaddtrans.Name = "gbtnaddtrans"
        Me.gbtnaddtrans.PressedColor = System.Drawing.Color.Transparent
        Me.gbtnaddtrans.Size = New System.Drawing.Size(291, 51)
        Me.gbtnaddtrans.TabIndex = 47
        Me.gbtnaddtrans.Text = "Add Transaction"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(692, 46)
        Me.Guna2Panel1.TabIndex = 49
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.Guna2Panel1
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'gtbxstatus
        '
        Me.gtbxstatus.BackColor = System.Drawing.Color.Transparent
        Me.gtbxstatus.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gtbxstatus.BorderRadius = 15
        Me.gtbxstatus.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.gtbxstatus.DefaultText = "Expenses"
        Me.gtbxstatus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.gtbxstatus.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.gtbxstatus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gtbxstatus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gtbxstatus.Enabled = False
        Me.gtbxstatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gtbxstatus.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gtbxstatus.ForeColor = System.Drawing.Color.Black
        Me.gtbxstatus.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.gtbxstatus.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gtbxstatus.IconLeftSize = New System.Drawing.Size(25, 25)
        Me.gtbxstatus.Location = New System.Drawing.Point(360, 75)
        Me.gtbxstatus.Margin = New System.Windows.Forms.Padding(6)
        Me.gtbxstatus.Name = "gtbxstatus"
        Me.gtbxstatus.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.gtbxstatus.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.gtbxstatus.PlaceholderText = "Expenses"
        Me.gtbxstatus.SelectedText = ""
        Me.gtbxstatus.Size = New System.Drawing.Size(291, 54)
        Me.gtbxstatus.TabIndex = 50
        '
        'gbtnback
        '
        Me.gbtnback.FillColor = System.Drawing.Color.Transparent
        Me.gbtnback.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbtnback.ForeColor = System.Drawing.Color.Black
        Me.gbtnback.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gbtnback.HoverState.ForeColor = System.Drawing.Color.Black
        Me.gbtnback.Image = Global.METmoneyandexpensetracker.My.Resources.Resources.Back_icon48
        Me.gbtnback.Location = New System.Drawing.Point(21, 65)
        Me.gbtnback.Margin = New System.Windows.Forms.Padding(0)
        Me.gbtnback.Name = "gbtnback"
        Me.gbtnback.PressedColor = System.Drawing.Color.Transparent
        Me.gbtnback.Size = New System.Drawing.Size(98, 34)
        Me.gbtnback.TabIndex = 48
        Me.gbtnback.Text = "Back"
        '
        'TransactionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(692, 505)
        Me.Controls.Add(Me.gtbxstatus)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.gbtnback)
        Me.Controls.Add(Me.gbtnaddtrans)
        Me.Controls.Add(Me.gbtnedittrans)
        Me.Controls.Add(Me.gtbxqty)
        Me.Controls.Add(Me.gtbxprice)
        Me.Controls.Add(Me.gdatetrans)
        Me.Controls.Add(Me.gcmbcategory)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.gtbxtransname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "TransactionsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TransactionsForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents gtbxtransname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents gcmbcategory As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents gdatetrans As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents gtbxqty As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents gtbxprice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents gbtnaddtrans As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents gbtnedittrans As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents gbtnback As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents gtbxstatus As Guna.UI2.WinForms.Guna2TextBox
End Class
