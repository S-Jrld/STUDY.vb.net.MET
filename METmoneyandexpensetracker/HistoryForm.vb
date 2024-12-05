Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Globalization

Public Class HistoryForm
    Public Sub DataGridView_load()
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
    End Sub
    Public Sub LoadChartData()
        ' Clear the existing chart data
        chartexpense.Series.Clear()

        ' SQL query to fetch the required columns from the database
        Dim query As String = ""
        If gexpperiod = "Monthly" Then
            query = "SELECT category, quantity, total, transdate FROM tbltransaction WHERE uname = @username AND (YEAR(transdate) = YEAR(CURDATE()) AND MONTH(transdate) = MONTH(CURDATE()))"
        ElseIf gexpperiod = "Yearly" Then
            query = "SELECT category, quantity, total, transdate FROM tbltransaction WHERE uname = @username AND YEAR(transdate) = YEAR(CURDATE())"
        End If
        Try
            ' Open the database connection if it's closed
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            ' Prepare the MySQL command
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@username", usernamekey)

            ' Execute the query and fetch the data
            Dim dr As MySqlDataReader = cmd.ExecuteReader()

            ' Prepare the data series for the chart
            Dim qtySeries As New Series("Quantity")
            qtySeries.ChartType = SeriesChartType.Line
            qtySeries.BorderWidth = 3
            qtySeries.Color = Color.Blue
            qtySeries.MarkerStyle = MarkerStyle.Circle
            qtySeries.MarkerSize = 8

            Dim totalSeries As New Series("Total")
            totalSeries.ChartType = SeriesChartType.Line
            totalSeries.BorderWidth = 3
            totalSeries.Color = Color.Green
            totalSeries.MarkerStyle = MarkerStyle.Circle
            totalSeries.MarkerSize = 8

            ' Add the series to the chart
            chartexpense.Series.Add(qtySeries)
            chartexpense.Series.Add(totalSeries)

            ' Read data and populate the Line Chart
            While dr.Read()
                ' Extract data
                Dim quantity As Integer = Convert.ToInt32(dr("quantity"))
                Dim total As Decimal = Convert.ToDecimal(dr("total"))
                Dim transdate As DateTime = Convert.ToDateTime(dr("transdate"))

                ' Add the data to the chart (X: Date, Y: qty or total)
                qtySeries.Points.AddXY(transdate.ToString("yyyy-MM-dd"), quantity)
                totalSeries.Points.AddXY(transdate.ToString("yyyy-MM-dd"), total)
            End While

            ' Close the data reader
            dr.Close()

            ' Customize chart appearance
            CustomizeChart()

        Catch ex As Exception
            ' Show the exception message in case of errors
            MessageBox.Show("An error occurred in loadchart from historyform: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure the database connection is closed
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub CustomizeChart()
        ' Customize chart area appearance
        Dim chartArea = chartexpense.ChartAreas(0)
        chartArea.AxisX.Title = "Date"
        chartArea.AxisY.Title = "Values"
        chartArea.AxisX.Interval = 1 ' Ensure all dates are shown
        chartArea.AxisX.MajorGrid.LineColor = Color.LightGray
        chartArea.AxisY.MajorGrid.LineColor = Color.LightGray
        chartArea.AxisX.LabelStyle.Angle = -45 ' Rotate X-axis labels if needed

        ' Add chart title
        chartexpense.Titles.Clear()
        chartexpense.Titles.Add("Expenses Over the " & gexpperiod)
        chartexpense.Titles(0).Font = New Font("Arial", 14, FontStyle.Bold)
    End Sub

    Public Sub DisplayExpenseDetails()
        ' SQL query to fetch the required columns (date, category, expname, and total) from the database
        Dim query As String = "SELECT category, transname, total, transdate FROM tbltransaction WHERE uname = @username"

        ' Variables to track the unique months, years, and total calculations
        Dim monthList As New List(Of String)()
        Dim yearList As New List(Of Integer)()
        Dim mostRecentDate As DateTime = DateTime.MinValue
        Dim totalMoneySpent As Decimal = 0
        Dim highestTotal As Decimal = 0
        Dim highestExpName As String = ""
        Dim highestCategory As String = ""

        Try
            ' Open the database connection if it's closed
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            ' Prepare the MySQL command
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@username", usernamekey)

            ' Execute the query and fetch the data
            Dim dr As MySqlDataReader = cmd.ExecuteReader()

            ' Read data and populate the Month, Year, and Total calculations
            While dr.Read()
                ' Extract data
                Dim category As String = dr("category").ToString()
                Dim transname As String = dr("transname").ToString()
                Dim total As Decimal = Convert.ToDecimal(dr("total"))
                Dim transdate As DateTime = Convert.ToDateTime(dr("transdate"))

                ' Update total money spent
                totalMoneySpent += total

                ' Track the most recent date
                If transdate > mostRecentDate Then
                    mostRecentDate = transdate
                End If

                ' Collect unique months in "yyyy-MM" format
                Dim month As String = transdate.ToString("yyyy-MM")
                If Not monthList.Contains(month) Then
                    monthList.Add(month)
                End If

                ' Collect unique years
                Dim year As Integer = transdate.Year
                If Not yearList.Contains(year) Then
                    yearList.Add(year)
                End If

                ' Find the expense name with the highest total
                If total > highestTotal Then
                    highestTotal = total
                    highestExpName = transname
                    highestCategory = category
                End If
            End While

            ' Close the data reader
            dr.Close()

            ' Display the results in labels
            lbldate.Text = mostRecentDate.ToString("yyyy-MM")
            lblYear.Text = String.Join(", ", yearList)
            lblYear2.Text = String.Join(", ", yearList)
            lbldate.Text = String.Join(", ", monthList)

            lblTotalSpent.Text = totalMoneySpent.ToString("C2", New CultureInfo("en-PH"))
            lblHighestTotal.Text = highestExpName & " - " & highestTotal.ToString("C2", New CultureInfo("en-PH"))
            lblCategory.Text = highestCategory

        Catch ex As Exception
            ' Show the exception message in case of errors
            MessageBox.Show("An error occurred while loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure the database connection is closed
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub HistoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayExpenseDetails()
        DataGridView_load()
        LoadChartData()

        'change value of label username to show user acc
        lblname.Text = usernamekey
    End Sub

    Private Sub gbtnmonthly_Click(sender As Object, e As EventArgs) Handles gbtnmonthly.Click
        'set the value of expense period into monthly
        If gexpperiod = "Yearly" Then
            gexpperiod = "Monthly"
        End If

        DataGridView_load()
    End Sub

    Private Sub gbtnyearly_Click(sender As Object, e As EventArgs) Handles gbtnyearly.Click
        'set the value of expense period into yearly
        If gexpperiod = "Monthly" Then
            gexpperiod = "Yearly"
        End If

        DataGridView_load()
    End Sub

End Class