Imports MySql.Data.MySqlClient

Public Class ProfileForm

    Public Sub Dvg_load()

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
            'initialize query into the command "cmd"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@Username", uname)

            'read every column of selected row
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
            End While
            dr.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            'close connection to db if connection is open
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub
    Private Sub ProfileForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dvg_load()
    End Sub

    Private Sub gbtnmonthly_Click(sender As Object, e As EventArgs) Handles gbtnmonthly.Click
        'set the value of expense period into yearly
        If expperiod = "Yearly" Then
            expperiod = "Monthly"
        End If

        Dvg_load()
    End Sub

    Private Sub gbtnyearly_Click(sender As Object, e As EventArgs) Handles gbtnyearly.Click
        'set the value of expense period into yearly
        If expperiod = "Monthly" Then
            expperiod = "Yearly"
        End If

        Dvg_load()
    End Sub
End Class