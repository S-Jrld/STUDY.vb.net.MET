﻿Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class DashboardContentsForm
    Dim calculatetotal As Decimal
    Public Sub Dvg_load()
        'clear the lblexp to avoid redunduncy of values
        calculatetotal = 0
        'clear the rows of the datagrid view
        gdashgrid.Rows.Clear()
        Dim query As String = ""
        If expperiod = "Monthly" Then
            query = "SELECT expid, category, expname, price, qty, expdate, total FROM tblexpenses WHERE Username = @Username AND YEAR(expdate) = YEAR(CURDATE()) AND MONTH(expdate) = MONTH(CURDATE())"
        ElseIf expperiod = "Yearly" Then
            query = "SELECT expid, category, expname, price, qty, expdate, total FROM tblexpenses WHERE Username = @Username AND YEAR(expdate) = YEAR(CURDATE())"
        End If
        'will create a query to show the values into the datagridview
        Try

            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@Username", uname)

            Dim dr As MySqlDataReader = cmd.ExecuteReader
            While dr.Read
                gdashgrid.Rows.Add(
                    dr.Item("expid"),
                    dr.Item("category"),
                    dr.Item("expname"),
                    Convert.ToDecimal(dr("price")).ToString("F2"),
                    Convert.ToInt32(dr("qty")),
                    Convert.ToDateTime(dr("expdate")).ToString("yyyy-MM-dd"),
                    Convert.ToDecimal(dr("total")).ToString("F2")
                )
                calculatetotal += Convert.ToDecimal(dr("total"))
            End While

            dr.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
        gadddate.Value = Now
        'change the lblexp to display values of total expenses
        lblexp.Text = calculatetotal

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
            cmd.Parameters.AddWithValue("@Username", uname)
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
    Public Sub Updaterecord()
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
            cmd.Parameters.AddWithValue("@id", userid)
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

        Dim query As String = ""
        If expperiod = "Monthly" Then
            query = "SELECT category, SUM(total) AS total_expense FROM tblexpenses where Username = @Username AND YEAR(expdate) = YEAR(CURDATE()) AND MONTH(expdate) = MONTH(CURDATE()) GROUP BY category"
        ElseIf expperiod = "Yearly" Then
            query = "SELECT category, SUM(total) AS total_expense FROM tblexpenses where Username = @Username AND YEAR(expdate) = YEAR(CURDATE()) GROUP BY category"
        End If
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@Username", uname)
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

    Public Sub newbudget()
        'create a query that will insert a new balance into the table
        Dim query As String = "INSERT INTO tblbalance(userid, Username, balance, remainbal, totalexp, startdate) VALUES((SELECT userid FROM tblusers WHERE Username = @Username), @Username, @balance, @remainbal, @totalexp, @startdate)"
        Dim remaining As Decimal = lblbudget.Text - lblexp.Text
        If MsgBox("Do you want to set new budget?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Try
                If connection.State = ConnectionState.Closed Then
                    connection.Open()
                End If

                Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@Username", uname)
                cmd.Parameters.AddWithValue("@balance", gtbxbudget.Text)
                cmd.Parameters.AddWithValue("@remainbal", remaining)
                cmd.Parameters.AddWithValue("@totalexp", lblexp.Text)
                cmd.Parameters.AddWithValue("@startdate", Now())

                Dim i As Integer = cmd.ExecuteNonQuery
                If i > 0 Then
                    MessageBox.Show("Set New Budget Succesfully!", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Set New Budget Unsuccessfully!", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If

            Catch ex As Exception
                MessageBox.Show("An error occurred: newbalance" & ex.Message)
            Finally
                connection.Close()
            End Try
        End If
    End Sub
    Public Sub selectcurrentbalance()
        Dim query As String = "SELECT balance, startdate FROM tblbalance ORDER BY ABS(DATEDIFF(NOW(), startdate)) LIMIT 1"

        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim cmd As New MySqlCommand(query, connection)
            Dim dr As MySqlDataReader = cmd.ExecuteReader
            While dr.Read
                balance = Convert.ToDecimal(dr("balance"))
                startdate = Convert.ToDateTime(dr("startdate")).ToString("yyyy-MM-dd")
            End While

            dr.Close()

        Catch ex As Exception
            MessageBox.Show("An error occurred: SelectCurrentBalance" & ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Public Sub addbudget()
        Dim budget As Decimal = balance + Val(gtbxbudget.Text)
        Dim query As String = "UPDATE tblbalance SET balance = @balance ORDER BY ABS(DATEDIFF(NOW(), startdate)) LIMIT 1"
        If MsgBox("Do you want to add new funds?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Try
                If connection.State = ConnectionState.Closed Then
                    connection.Open()
                End If
                Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@balance", budget)

                Dim i As Integer = cmd.ExecuteNonQuery
                If i > 0 Then
                    MessageBox.Show("Add Budget Succesfully!", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Add Budget Unsuccessfully!", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If

            Catch ex As Exception
                MessageBox.Show("An Error Occured: addbudget" & ex.Message)
            Finally
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles gbtndel.Click
        'use the method to delete a tuple from the datagridview
        Delete()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles gbtnupdate.Click
        'use the metheod to update a tuple from the datagridview
        Updaterecord()

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
            cmd.Parameters.AddWithValue("@username", uname)
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
        'use method to get the balance and startdate
        selectcurrentbalance()

        'change username into user account
        lblusername.Text = uname

        'set the tbx id for read only
        gaddtbxid.ReadOnly = True

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

        'set the label into select value from balance and startdate
        lblbudget.Text = balance

        'set the remaining balance from the difference of budget and total expense
        Dim remaining As Decimal = CDec(lblbudget.Text) - CDec(lblexp.Text)
        lblbal.Text = remaining

    End Sub

    Private Sub gdashgrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gdashgrid.CellClick
        'when a record/tuple is clicked will display the values into the textboxes 
        gaddtbxid.Text = gdashgrid.CurrentRow.Cells(0).Value
        gaddcbxcat.Text = gdashgrid.CurrentRow.Cells(1).Value
        gaddtbxname.Text = gdashgrid.CurrentRow.Cells(2).Value
        gaddtbxprice.Text = gdashgrid.CurrentRow.Cells(3).Value
        gaddtbxqty.Text = gdashgrid.CurrentRow.Cells(4).Value
        gadddate.Text = gdashgrid.CurrentRow.Cells(5).Value

        userid = gaddtbxid.Text

        'setting the values 
        gaddtbxid.ReadOnly = True
        gbtnsave.Enabled = False
    End Sub

    Private Sub gaddcbxcat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gaddcbxcat.SelectedIndexChanged

    End Sub

    Private Sub gdashgrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gdashgrid.CellContentClick

    End Sub

    Private Sub gbtnset_Click(sender As Object, e As EventArgs) Handles gbtnaddbal.Click
        'execute the method to add budget
        addbudget()

    End Sub

    Private Sub gbtnnewbal_Click(sender As Object, e As EventArgs) Handles gbtnnewbal.Click
        'a method to insert value into db
        newbudget()
    End Sub

    Private Sub gsignbtn_Click(sender As Object, e As EventArgs) Handles gbtnmonthly.Click
        'set the value of expense period into monthly
        If expperiod = "Yearly" Then
            expperiod = "Monthly"
        End If

        Dvg_load()
    End Sub

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles gbtnyearly.Click
        'set the value of expense period into yearly
        If expperiod = "Monthly" Then
            expperiod = "Yearly"
        End If

        Dvg_load()
    End Sub
End Class