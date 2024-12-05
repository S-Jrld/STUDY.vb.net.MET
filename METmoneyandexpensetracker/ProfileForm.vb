Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class ProfileForm

    Public Sub Dvg_load()

        'clear the rows of the datagrid view
        gdashgrid.Rows.Clear()

        Dim query As String = ""
        If gexpperiod = "Monthly" Then
            query = "SELECT transstatus, category, transname, price, quantity, total, transdate FROM tbltransaction WHERE uname = @username AND (YEAR(transdate) = YEAR(CURDATE()) AND MONTH(transdate) = MONTH(CURDATE()))"
        ElseIf gexpperiod = "Yearly" Then
            query = "SELECT transstatus, category, transname, price, quantity, total, transdate FROM tbltransaction WHERE uname = @username AND YEAR(transdate) = YEAR(CURDATE())"
        End If
        'will create a query to show the values into the datagridview
        Try

            'check connection state if closed then open
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            'save sql query to the variable cmd
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@username", usernamekey)

            'execute query into the database and return the read value of every columns selected
            Dim dr As MySqlDataReader = cmd.ExecuteReader
            While dr.Read
                gdashgrid.Rows.Add(
                    dr.Item("transstatus"),
                    dr.Item("category"),
                    dr.Item("transname"),
                    Convert.ToDecimal(dr("price")).ToString("F2"),
                    Convert.ToInt32(dr("quantity")),
                    Convert.ToDecimal(dr("total")).ToString("F2"),
                    Convert.ToDateTime(dr("transdate")).ToString("yyyy-MM-dd")
                )
            End While

            dr.Close()

        Catch ex As Exception
            MessageBox.Show("Error in dvgload from dashcontentsform: " & ex.Message)
        Finally
            'check connection state if open then close
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
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

    Private Sub selectuserinfo()
        Dim query As String = "SELECT `uname`, pass, `fname`, `lname`, `address`, `birthdate`, `status`, `fundsource`, `mincome` FROM `tbluser` WHERE uname = @username"

        Try
            ' Check connection state; if closed, then open
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            ' Save SQL query to the variable cmd
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@username", usernamekey)
                ' Execute query into the database and return the data retrieved
                Using dr As MySqlDataReader = cmd.ExecuteReader
                    If dr.Read() Then
                        guserpass = dr("pass")
                        gfname = dr("fname")
                        glname = dr("lname")
                        gaddress = dr("address")
                        guserbirthdate = Convert.ToDateTime(dr("birthdate")).ToString("yyyy-MM-dd")
                        gstatus = dr("status")
                        gfundsource = dr("fundsource")
                        gmincome = dr("mincome")
                    End If
                    dr.Close()
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("MySQL Error in selectuserinfo: " & ex.Message, "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error in selectuserinfo: " & ex.Message, "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Check connection state; if open, then close
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub
    Private Sub ProfileForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        selectuserinfo()
        lblprofileusername.Text = usernamekey
        lblcomname.Text = gfname & " " & glname

        Dvg_load()
        DisplayExpenseDetails()
        DashboardContentsForm.selectbalance()
        lblbal.Text = gavailbal
    End Sub

    Private Sub gbtnmonthly_Click(sender As Object, e As EventArgs)
        'set the value of expense period into yearly
        If gexpperiod = "Yearly" Then
            gexpperiod = "Monthly"
        End If

        Dvg_load()
    End Sub

    Private Sub gbtnyearly_Click(sender As Object, e As EventArgs)
        'set the value of expense period into yearly
        If gexpperiod = "Monthly" Then
            gexpperiod = "Yearly"
        End If

        Dvg_load()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles gbtnmonthly.Click
        'set the value of expense period into monthly
        If gexpperiod = "Yearly" Then
            gexpperiod = "Monthly"
        End If
        Dvg_load()
        Me.Refresh()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles gbtnyearly.Click
        'set the value of expense period into yearly
        If gexpperiod = "Monthly" Then
            gexpperiod = "Yearly"
        End If
        Dvg_load()
        Me.Refresh()
    End Sub

    Private Sub gbtnuser_Click(sender As Object, e As EventArgs) Handles gbtnuser.Click
        'select the information of user
        selectuserinfo()
        'show the info in another form
        Using user As New UserProfileForm()
            user.Owner = Me
            user.ShowDialog()
        End Using
    End Sub

    Private Sub gbtnsecurity_Click(sender As Object, e As EventArgs) Handles gbtnsecurity.Click
        selectuserinfo()

        'show the password of user and option to change pass
        Using usersecurity As New AccountSecurityForm()
            usersecurity.Owner = Me
            usersecurity.ShowDialog()
        End Using
    End Sub
End Class