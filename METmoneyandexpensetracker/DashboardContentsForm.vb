Imports MySql.Data.MySqlClient
Imports System.Web.Configuration
Imports System.Windows.Forms.DataVisualization.Charting
Imports ZstdSharp.Unsafe

Public Class DashboardContentsForm

    Public Sub DataGridView_load()
        ' Clear the value of totalcalc
        gtotal = 0

        ' Clear the rows of the DataGridView
        gdashgrid.Rows.Clear()

        Dim query As String = ""
        If gexpperiod = "Monthly" Then
            query = "SELECT transid, transstatus, category, transname, price, quantity, total, transdate FROM tbltransaction WHERE uname = @username AND (YEAR(transdate) = YEAR(CURDATE()) AND MONTH(transdate) = MONTH(CURDATE()))"
        ElseIf gexpperiod = "Yearly" Then
            query = "SELECT transid, transstatus, category, transname, price, quantity, total, transdate FROM tbltransaction WHERE uname = @username AND YEAR(transdate) = YEAR(CURDATE())"
        End If

        ' Create a query to show the values into the DataGridView
        Try
            ' Check connection state; if closed, then open
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            ' Save SQL query to the variable cmd
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@username", usernamekey)

                ' Execute query in the database and return the read value of every column selected
                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        gdashgrid.Rows.Add(
                            dr.Item("transid"),
                            dr.Item("transstatus"),
                            dr.Item("category"),
                            dr.Item("transname"),
                            Convert.ToDecimal(dr("price")).ToString("F2"),
                            Convert.ToInt32(dr("quantity")),
                            Convert.ToDecimal(dr("total")).ToString("F2"),
                            Convert.ToDateTime(dr("transdate")).ToString("yyyy-MM-dd")
                        )
                        gtotal += Convert.ToDecimal(dr("total"))
                    End While
                End Using
            End Using

        Catch ex As MySqlException
            MessageBox.Show("MySQL Error in dgvload from dashcontentsform: " & ex.Message, "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error in dgvload from dashcontentsform: " & ex.Message, "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Check connection state; if open, then close
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try

        ' Update the total expense label
        lblexp.Text = gtotal.ToString("F2")

    End Sub

    Private Sub DeleteTransaction(transactionId As Integer)
        Dim query As String = "DELETE FROM tbltransaction WHERE transid = @transid"

        Try
            ' Check connection state; if closed, then open
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            ' Save SQL query to the variable cmd
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@transid", transactionId)

                ' Execute the query to delete the record from the database
                Dim i As Integer = cmd.ExecuteNonQuery()
                If i > 0 Then
                    MessageBox.Show("Record deleted successfully!", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Failed to delete record!", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            End Using

        Catch ex As MySqlException
            MessageBox.Show("MySQL Error in DeleteTransaction: " & ex.Message, "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error in DeleteTransaction: " & ex.Message, "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Check connection state; if open, then close
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Public Sub LoadChartData()

        Dim query As String = ""
        If gexpperiod = "Monthly" Then
            query = "SELECT category, SUM(total) AS total_expense FROM tbltransaction where uname = @username AND (YEAR(transdate) = YEAR(CURDATE()) AND MONTH(transdate) = MONTH(CURDATE())) GROUP BY category"
        ElseIf gexpperiod = "Yearly" Then
            query = "SELECT category, SUM(total) AS total_expense FROM tbltransaction where uname = @username AND YEAR(transdate) = YEAR(CURDATE()) GROUP BY category"
        End If
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@Username", usernamekey)
            Dim dr As MySqlDataReader = cmd.ExecuteReader()
            While dr.Read()
                Dim category As String = dr("category").ToString()
                Dim totalExpense As Decimal = Convert.ToDecimal(dr("total_expense"))

                ' Add data points to the chart
                chrtexpenses.Series("Expenses").Points.AddXY(category, totalExpense)
            End While
            dr.Close()

        Catch ex As Exception
            MessageBox.Show("Error in loadchartdata from dashcontentform: " & ex.Message)
        Finally
            connection.Close()
        End Try
        DataGridView_load()
    End Sub

    Public Sub SelectBalance()
        Dim query As String = ""
        If gexpperiod = "Monthly" Then
            query = "SELECT budgetname, budget, availbal, totalexp, startdate FROM tblbalance WHERE budgetname = 'Monthly' AND (YEAR(startdate) = YEAR(CURDATE()) AND MONTH(startdate) = MONTH(CURDATE())) ORDER BY ABS(DATEDIFF(NOW(), startdate)) LIMIT 1"
        ElseIf gexpperiod = "Yearly" Then
            query = "SELECT budgetname, budget, availbal, totalexp, startdate FROM tblbalance WHERE budgetname = 'Yearly' AND YEAR(startdate) = YEAR(CURDATE()) ORDER BY ABS(DATEDIFF(NOW(), startdate)) LIMIT 1"
        End If

        Try
            ' Check connection state; if closed, then open
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            ' Save SQL query to the variable cmd
            Dim cmd As New MySqlCommand(query, connection)
            ' Execute query into the database and return the data retrieved
            Dim dr As MySqlDataReader = cmd.ExecuteReader()
            If dr.Read() Then
                gbudgetname = dr("budgetname").ToString()
                gbudget = Convert.ToDecimal(dr("budget"))
                gavailbal = Convert.ToDecimal(dr("availbal"))
                gtotalexp = Convert.ToDecimal(dr("totalexp"))
                gstartdate = Convert.ToDateTime(dr("startdate")).ToString("yyyy-MM-dd")
            End If

            dr.Close()

        Catch ex As MySqlException
            MessageBox.Show("MySQL Error in SelectBalance: " & ex.Message, "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error in SelectBalance: " & ex.Message, "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Check connection state; if open, then close
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try

        ' Update UI labels
        lblbudgetname.Text = gbudgetname
        lblavailbal.Text = gavailbal.ToString("F2")
        lblexp.Text = gtotalexp.ToString("F2")
        lblstartdate.Text = gstartdate
    End Sub

    Public Sub UpdateBudget()
        ' Calculate the remaining balance
        Dim remaining As Decimal = gbudget - gtotal
        Dim query As String = ""
        If gexpperiod = "Monthly" Then
            query = "UPDATE tblbalance SET availbal = @availbal, totalexp = @totalexp WHERE budgetname = 'Monthly' AND (YEAR(startdate) = YEAR(CURDATE()) AND MONTH(startdate) = MONTH(CURDATE())) ORDER BY ABS(DATEDIFF(NOW(), startdate)) LIMIT 1"
        ElseIf gexpperiod = "Yearly" Then
            query = "UPDATE tblbalance SET availbal = @availbal, totalexp = @totalexp WHERE budgetname = 'Yearly' AND YEAR(startdate) = YEAR(CURDATE()) ORDER BY ABS(DATEDIFF(NOW(), startdate)) LIMIT 1"
        End If

        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@availbal", remaining)
            cmd.Parameters.AddWithValue("@totalexp", gtotal)

            Dim i As Integer = cmd.ExecuteNonQuery()
            If i > 0 Then
                ' Update the global variable gavailbal
                gavailbal = remaining

                ' Update UI labels
                lblbudgetname.Text = gbudgetname
                lblavailbal.Text = gavailbal.ToString("F2")
                lblexp.Text = gtotalexp.ToString("F2")
                lblstartdate.Text = gstartdate
            End If

        Catch ex As MySqlException
            MessageBox.Show("MySQL Error in UpdateBudget: " & ex.Message, "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error in UpdateBudget: " & ex.Message, "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub


    Public Sub searchtable()
        ' Clear the rows of the DataGridView
        gdashgrid.Rows.Clear()

        Dim query As String = ""
        If gexpperiod = "Monthly" Then
            query = "SELECT transid, transstatus, category, transname, price, quantity, total, transdate FROM tbltransaction WHERE uname = @username AND transname LIKE @search AND (YEAR(transdate) = YEAR(CURDATE()) AND MONTH(transdate) = MONTH(CURDATE()))"
        ElseIf gexpperiod = "Yearly" Then
            query = "SELECT transid, transstatus, category, transname, price, quantity, total, transdate FROM tbltransaction WHERE uname = @username AND transname LIKE @search AND YEAR(transdate) = YEAR(CURDATE())"
        End If
        Try
            'check connection state if closed then open
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            'save sql query to the variable cmd
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@username", usernamekey)
            cmd.Parameters.AddWithValue("@search", "%" & gaddtbxsearch.Text & "%")
            Dim dr As MySqlDataReader = cmd.ExecuteReader()

            gdashgrid.Rows.Clear()
            While dr.Read()
                gdashgrid.Rows.Add(
                dr.Item("transid"),
                dr.Item("transstatus"),
                dr.Item("category"),
                dr.Item("transname"),
                Convert.ToDecimal(dr("price")).ToString("F2"),
                Convert.ToInt32(dr("quantity")),
                Convert.ToDecimal(dr("total")).ToString("F2"),
                Convert.ToDateTime(dr("transdate")).ToString("yyyy-MM-dd"))
            End While
            dr.Close()
        Catch ex As Exception
            MessageBox.Show("Error in search from historyform: " & ex.Message)
        Finally
            'check connection state if open then close
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub gaddtbxsearch_TextChanged(sender As Object, e As EventArgs) Handles gaddtbxsearch.TextChanged
        searchtable()
    End Sub

    Private Sub DashboardContentsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'use the method datagridview load to display the values into the datagridview
        DataGridView_load()

        'load balance
        SelectBalance()

        UpdateBudget()

        ' Configure the chart
        chrtexpenses.Series.Clear()
        chrtexpenses.Titles.Add("Expenses by Category")

        Dim series As New Series("Expenses")
        series.ChartType = SeriesChartType.Pie
        chrtexpenses.Series.Add(series)

        ' Load data into the chart
        LoadChartData()

    End Sub

    Private Sub gdashgrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gdashgrid.CellContentClick

        'this set the columns selected from datagridview into the
        'corresponding globalvariables to be access in another form
        Try
            If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Return
            ' Ensure row and column indices are valid
            Dim selectedRow As DataGridViewRow = gdashgrid.Rows(e.RowIndex)
            If gdashgrid.Columns(e.ColumnIndex).Name = "EditRec" Then
                gtransid = selectedRow.Cells("ID").Value.ToString()
                gtransstatus = selectedRow.Cells("Transaction").Value.ToString()
                gcategory = selectedRow.Cells("Category").Value.ToString()
                gtransname = selectedRow.Cells("Transname").Value.ToString()
                gprice = selectedRow.Cells("Price").Value.ToString()
                gquantity = selectedRow.Cells("Quantity").Value.ToString()
                gtransdate = selectedRow.Cells("Transdate").Value.ToString()
                'set edit to true to display the contents in transaction form 
                editrecords = True
                ' Create and show the form as a dialog
                Using transactions As New TransactionsForm()
                    transactions.Owner = Me
                    transactions.ShowDialog()
                End Using
            ElseIf gdashgrid.Columns(e.ColumnIndex).Name = "DeleteRec" Then
                Dim transactionId As Integer = Convert.ToInt32(selectedRow.Cells("ID").Value)
                ' Delete the transaction from the database
                DeleteTransaction(transactionId)

                ' Remove the row from the DataGridView
                gdashgrid.Rows.RemoveAt(e.RowIndex)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub gbtntransadd_click(sender As Object, e As EventArgs) Handles gbtntransadd.Click
        ' Create and show the form as a dialog
        Using transactions As New TransactionsForm()
            transactions.Owner = Me
            transactions.ShowDialog()
        End Using
    End Sub

    Private Sub gbtnsetbudget_Click(sender As Object, e As EventArgs) Handles gbtnsetbudget.Click
        ' Create and show the form as a dialog
        Using Budget As New BudgetForm()
            Budget.Owner = Me
            Budget.ShowDialog()
        End Using
    End Sub
End Class