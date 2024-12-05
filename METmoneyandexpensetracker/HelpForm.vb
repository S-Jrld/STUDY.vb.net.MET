Imports MySql.Data.MySqlClient

Public Class HelpForm

    Private Sub selecthelp(help As Integer)
        Dim query As String = "SELECT `helptitle`, `helpcontext` FROM `tblhelp` WHERE helpid = @helpid"

        Try
            ' Check connection state; if closed, then open
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            ' Save SQL query to the variable cmd
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@helpid", help)
                ' Execute query into the database and return the data retrieved
                Using dr As MySqlDataReader = cmd.ExecuteReader
                    If dr.Read() Then
                        Lbltitle.Text = dr("helptitle")
                        Lblcontext.Text = dr("helpcontext")
                    End If
                    dr.Close()
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("MySQL Error in selecthelp: " & ex.Message, "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error in selecthelp: " & ex.Message, "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Check connection state; if open, then close
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub
    Private Sub gctrlclose_Click(sender As Object, e As EventArgs)
        'close the application if closebutton.clicked is yes else return to the same form
        If MsgBox("Do you want to close the application?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Application.Exit()
        Else
            Dim dashboard As New DashboardForm
            dashboard.Show()
            Me.Close()
        End If
    End Sub

    Private Sub gbtnback_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub HelpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub gbtnquest1_Click(sender As Object, e As EventArgs) Handles gbtnquest1.Click
        Dim helpid As Integer = 1
        selecthelp(helpid)
    End Sub

    Private Sub gbtnquest2_Click(sender As Object, e As EventArgs) Handles gbtnquest2.Click
        Dim helpid As Integer = 2
        selecthelp(helpid)
    End Sub

    Private Sub gbtnquest3_Click(sender As Object, e As EventArgs) Handles gbtnquest3.Click
        Dim helpid As Integer = 3
        selecthelp(helpid)
    End Sub

    Private Sub gbtnquest4_Click(sender As Object, e As EventArgs) Handles gbtnquest4.Click
        Dim helpid As Integer = 4
        selecthelp(helpid)
    End Sub

    Private Sub gbtnquest5_Click(sender As Object, e As EventArgs) Handles gbtnquest5.Click
        Dim helpid As Integer = 5
        selecthelp(helpid)
    End Sub

    Private Sub gbtnquest6_Click(sender As Object, e As EventArgs) Handles gbtnquest6.Click
        Dim helpid As Integer = 6
        selecthelp(helpid)
    End Sub

    Private Sub gbtnquest7_Click(sender As Object, e As EventArgs) Handles gbtnquest7.Click
        Dim helpid As Integer = 7
        selecthelp(helpid)
    End Sub

    Private Sub gbtnquest8_Click(sender As Object, e As EventArgs) Handles gbtnquest8.Click
        Dim helpid As Integer = 8
        selecthelp(helpid)
    End Sub

    Private Sub gbtnquest9_Click(sender As Object, e As EventArgs) Handles gbtnquest9.Click
        Dim helpid As Integer = 9
        selecthelp(helpid)
    End Sub

    Private Sub gbtnquest10_Click(sender As Object, e As EventArgs) Handles gbtnquest10.Click
        Dim helpid As Integer = 10
        selecthelp(helpid)
    End Sub

    Private Sub gbtnquest11_Click(sender As Object, e As EventArgs) Handles gbtnquest11.Click
        Dim helpid As Integer = 11
        selecthelp(helpid)
    End Sub

    Private Sub gbtnquest12_Click(sender As Object, e As EventArgs) Handles gbtnquest12.Click
        Dim helpid As Integer = 12
        selecthelp(helpid)
    End Sub

    Private Sub gbtnquest13_Click(sender As Object, e As EventArgs) Handles gbtnquest13.Click
        Dim helpid As Integer = 13
        selecthelp(helpid)
    End Sub

    Private Sub gbtnquest14_Click(sender As Object, e As EventArgs) Handles gbtnquest14.Click
        Dim helpid As Integer = 14
        selecthelp(helpid)
    End Sub

    Private Sub gbtnquest15_Click(sender As Object, e As EventArgs) Handles gbtnquest15.Click
        Dim helpid As Integer = 15
        selecthelp(helpid)
    End Sub

    Private Sub gbtnquest16_Click(sender As Object, e As EventArgs) Handles gbtnquest16.Click
        Dim helpid As Integer = 16
        selecthelp(helpid)
    End Sub
End Class