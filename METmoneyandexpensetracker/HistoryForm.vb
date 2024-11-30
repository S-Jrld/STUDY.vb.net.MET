Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Globalization

Public Class HistoryForm
    Public Sub Dvg_open()
        ' Clear the rows of the DataGridView
        gdatagrid.Rows.Clear()

        ' SQL query to fetch the required columns from the database
        Dim query As String = "SELECT category, expname, price, qty, expdate, total FROM tblexpenses WHERE Username = @username"

        Try
            ' Open the database connection if it's closed
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            ' Prepare the MySQL command
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@username", username)

            ' Execute the query and load the data into the DataGridView
            Dim dr As MySqlDataReader = cmd.ExecuteReader
            While dr.Read
                gdatagrid.Rows.Add(
                dr("category").ToString(),
                dr("expname").ToString(),
                Convert.ToDecimal(dr("price")).ToString("F2"), ' Format price as decimal (e.g., 12.50)
                Convert.ToInt32(dr("qty")),                  ' Convert quantity to integer
                Convert.ToDateTime(dr("expdate")).ToString("yyyy-MM-dd"), ' Format the date
                Convert.ToDecimal(dr("total")).ToString("F2") ' Format total as decimal
            )
            End While

            ' Close the data reader
            dr.Close()

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
    Public Sub LoadChartData()
        ' Clear the existing chart data
        chartexpense.Series.Clear()

        ' SQL query to fetch the required columns from the database
        Dim query As String = "SELECT category, qty, total, expdate FROM tblexpenses WHERE Username = @username"

        Try
            ' Open the database connection if it's closed
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            ' Prepare the MySQL command
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@username", username)

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
                Dim qty As Integer = Convert.ToInt32(dr("qty"))
                Dim total As Decimal = Convert.ToDecimal(dr("total"))
                Dim expdate As DateTime = Convert.ToDateTime(dr("expdate"))

                ' Add the data to the chart (X: Date, Y: qty or total)
                qtySeries.Points.AddXY(expdate.ToString("yyyy-MM-dd"), qty)
                totalSeries.Points.AddXY(expdate.ToString("yyyy-MM-dd"), total)
            End While

            ' Close the data reader
            dr.Close()

            ' Customize chart appearance
            CustomizeChart()

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
        chartexpense.Titles.Add("Expenses Over the Year")
        chartexpense.Titles(0).Font = New Font("Arial", 14, FontStyle.Bold)
    End Sub

    Public Sub DisplayExpenseDetails()
        ' SQL query to fetch the required columns (date, category, expname, and total) from the database
        Dim query As String = "SELECT category, expname, total, expdate FROM tblexpenses WHERE Username = @username"

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
            cmd.Parameters.AddWithValue("@username", username)

            ' Execute the query and fetch the data
            Dim dr As MySqlDataReader = cmd.ExecuteReader()

            ' Read data and populate the Month, Year, and Total calculations
            While dr.Read()
                ' Extract data
                Dim category As String = dr("category").ToString()
                Dim expname As String = dr("expname").ToString()
                Dim total As Decimal = Convert.ToDecimal(dr("total"))
                Dim expdate As DateTime = Convert.ToDateTime(dr("expdate"))

                ' Update total money spent
                totalMoneySpent += total

                ' Track the most recent date
                If expdate > mostRecentDate Then
                    mostRecentDate = expdate
                End If

                ' Collect unique months in "yyyy-MM" format
                Dim month As String = expdate.ToString("yyyy-MM")
                If Not monthList.Contains(month) Then
                    monthList.Add(month)
                End If

                ' Collect unique years
                Dim year As Integer = expdate.Year
                If Not yearList.Contains(year) Then
                    yearList.Add(year)
                End If

                ' Find the expense name with the highest total
                If total > highestTotal Then
                    highestTotal = total
                    highestExpName = expname
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
        Dvg_open()
        LoadChartData()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub gbtnhistory_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub gbtndashboard_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub chartexpense_Click(sender As Object, e As EventArgs) Handles chartexpense.Click

    End Sub

    Private Sub gdatagrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gdatagrid.CellContentClick


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub lblMonths_Click(sender As Object, e As EventArgs) Handles lbldate.Click

    End Sub
End Class