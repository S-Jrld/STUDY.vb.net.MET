Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class DashboardContentsForm

    Public Sub Dvg_load()
        'clear the rows of the datagrid view
        gdashgrid.Rows.Clear()
        'will create a query to show the values into the datagridview
        Try

            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim cmd As New MySqlCommand("SELECT expid, category, expname, price, qty, expdate, total FROM tblexpenses WHERE Username = @username", connection)
            cmd.Parameters.AddWithValue("@username", username)
            Dim dr As MySqlDataReader = cmd.ExecuteReader
            While dr.Read
                gdashgrid.Rows.Add(dr.Item("expid"), dr.Item("category"), dr.Item("expname"), dr.Item("price"), dr.Item("qty"), dr.Item("expdate"), dr.Item("total"))
            End While
            dr.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
        End Try
        gadddate.Value = Now
    End Sub

    Public Sub Save()
        'create query to insert values into the database
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim price As Decimal = CDec(gaddtbxprice.Text)
            Dim qty As Integer = CInt(gaddtbxqty.Text)
            Dim total As Decimal = price * qty

            Dim cmd As New MySqlCommand("INSERT INTO `tblexpenses`(`userid`, `Username`, `category`, `expname`, `price`, `qty`, `expdate`, `total`) VALUES ((SELECT userid FROM tblusers WHERE Username = @Username), @Username, @category, @expname, @price, @qty, @expdate, @total)", connection)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Username", username)
            cmd.Parameters.AddWithValue("@category", gaddcbxcat.Text)
            cmd.Parameters.AddWithValue("@expname", gaddtbxname.Text)
            cmd.Parameters.AddWithValue("@price", price)
            cmd.Parameters.AddWithValue("@qty", qty)
            cmd.Parameters.AddWithValue("@expdate", CDate(gadddate.Value))
            cmd.Parameters.AddWithValue("@total", total)

            Dim i As Integer = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Save Record Succesfully!", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Save Record Unsuccessfully!", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
        clear()
        Dvg_load()

    End Sub
    Public Sub Update()
        'create a query that will update the values of a tuple
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim price As Decimal = CDec(gaddtbxprice.Text)
            Dim qty As Integer = CInt(gaddtbxqty.Text)
            Dim total As Decimal = price * qty

            Dim cmd As New MySqlCommand("UPDATE `tblexpenses` SET `category`=@category,`expname`=@expname,`price`=@price,`qty`=@qty,`expdate`=@expdate,`total`=@total WHERE expid = @id", connection)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@category", gaddcbxcat.Text)
            cmd.Parameters.AddWithValue("@expname", gaddtbxname.Text)
            cmd.Parameters.AddWithValue("@price", price)
            cmd.Parameters.AddWithValue("@qty", qty)
            cmd.Parameters.AddWithValue("@expdate", CDate(gadddate.Value))
            cmd.Parameters.AddWithValue("@total", total)

            Dim i As Integer = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Update Record Success!", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Update Record Failed!", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
        clear()
        Dvg_load()

    End Sub
    Public Sub Delete()
        If MsgBox("Are you sure you want to Delete this record?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            'delete a tuple from the datagridview
            Try
                If connection.State = ConnectionState.Closed Then
                    connection.Open()
                End If

                Dim exid As Integer = CInt(gaddtbxid.Text)

                Dim cmd As New MySqlCommand("DELETE FROM tblexpenses WHERE expid = @expid", connection)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@expid", exid)

                Dim i As Integer = cmd.ExecuteNonQuery
                If i > 0 Then
                    MessageBox.Show("Record Deletion Success!", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Record Deletion Failed!", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                connection.Close()
            End Try
            clear()
            Dvg_load()
        Else
            Return
        End If
    End Sub

    Public Sub clear()
        'clear the fields of textboxes
        gaddcbxcat.Text = ""
        gaddtbxname.Clear()
        gaddtbxprice.Clear()
        gaddtbxqty.Clear()
        gadddate.Value = Now
        gaddtbxid.Clear()
    End Sub

    Public Sub LoadChartData()
        Dim query As String = "SELECT category, SUM(total) AS total_expense FROM tblexpenses where Username = @username GROUP BY category"

        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@username", username)
            Dim dr As MySqlDataReader = cmd.ExecuteReader()
            While dr.Read()
                Dim category As String = dr("category").ToString()
                Dim totalExpense As Decimal = Convert.ToDecimal(dr("total_expense"))

                ' Add data points to the chart
                chrtexpenses.Series("Expenses").Points.AddXY(category, totalExpense)
            End While
            dr.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
        Dvg_load()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles gbtndel.Click
        'use the method to delete a tuple from the datagridview
        Delete()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles gbtnupdate.Click
        'use the metheod to update a tuple from the datagridview
        Update()

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles gbtnsave.Click
        'use the method save
        Save()
    End Sub

    Private Sub gbtnprofile_Click(sender As Object, e As EventArgs) Handles gbtnclear.Click
        'clear the text fields and allow again to save
        clear()
        gaddtbxid.ReadOnly = True
        gbtnsave.Enabled = True
    End Sub

    Private Sub gaddtbxsearch_TextChanged(sender As Object, e As EventArgs) Handles gaddtbxsearch.TextChanged
        Try

            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim query As String = "SELECT * FROM tblexpenses WHERE Username = @username AND expname LIKE @search"

            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@search", "%" & gaddtbxsearch.Text & "%")
            Dim dr As MySqlDataReader = cmd.ExecuteReader()

            gdashgrid.Rows.Clear()
            While dr.Read()
                gdashgrid.Rows.Add(dr("expid"), dr("category"), dr("expname"), dr("price"), dr("qty"), dr("expdate"), dr("total"))
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub DashboardContentsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'use the method datagridview load to display the values into the datagridview
        Dvg_load()
        ' Configure the chart
        chrtexpenses.Series.Clear()
        chrtexpenses.Titles.Add("Expenses by Category")

        Dim series As New Series("Expenses")
        series.ChartType = SeriesChartType.Pie
        chrtexpenses.Series.Add(series)

        ' Load data into the chart
        LoadChartData()
    End Sub

    Private Sub gdashgrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gdashgrid.CellClick
        'when a record/tuple is clicked will display the values into the textboxes 
        gaddtbxid.Text = gdashgrid.CurrentRow.Cells(0).Value
        gaddcbxcat.Text = gdashgrid.CurrentRow.Cells(1).Value
        gaddtbxname.Text = gdashgrid.CurrentRow.Cells(2).Value
        gaddtbxprice.Text = gdashgrid.CurrentRow.Cells(3).Value
        gaddtbxqty.Text = gdashgrid.CurrentRow.Cells(4).Value
        gadddate.Text = gdashgrid.CurrentRow.Cells(5).Value

        id = gaddtbxid.Text
        gaddtbxid.ReadOnly = True
        gbtnsave.Enabled = False
    End Sub

    Private Sub gaddcbxcat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gaddcbxcat.SelectedIndexChanged

    End Sub

    Private Sub gdashgrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gdashgrid.CellContentClick

    End Sub
End Class