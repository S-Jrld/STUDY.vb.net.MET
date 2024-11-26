Imports MySql.Data.MySqlClient

Public Class ForgotForm
    Public Property Username As Boolean = False

    Public Sub checkusername()
        'check the username if the same as input by user in the textbox
        Try
            connection.Open()

            Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM tblusers WHERE Username = @Username", connection)
            cmd.Parameters.AddWithValue("@Username", gfortbxname.Text)
            Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If result > 0 Then
                Username = True
            Else
                MessageBox.Show("Invalid username")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Public Sub changepass()
        'using the query will update the password into the current password
        Try
            connection.Open()

            Dim cmd As New MySqlCommand("UPDATE `tblusers` SET Password = @Password WHERE Username =@Username ", connection)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Password", gfortbxcon.Text)
            cmd.Parameters.AddWithValue("@Username", gfortbxname.Text)

            Dim i As Integer = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Save Succesfully", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Save Unsuccessfully", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub ForgotForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ForgotForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        'close the application
        Application.Exit()
    End Sub

    Private Sub gregbtnlog_Click(sender As Object, e As EventArgs) Handles gforbtncnl.Click
        'will cancel the forgot form and go back to login
        Dim log As New LoginForm
        log.Show()
        Hide()
    End Sub

    Private Sub gregbtn_Click(sender As Object, e As EventArgs) Handles gforbtn.Click
        'this is the condition that will combine 2 methods to work
        checkusername()

        If Username = True Then
            changepass()
            Dim login As New LoginForm
            login.Show()
            Me.Hide()

        Else
            MessageBox.Show("Invalid username")
        End If
    End Sub

    Private Sub Guna2ImageCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles gckbxshow2.CheckedChanged
        'the condition to show password
        If gckbxshow2.Checked Then
            ' Show the password
            gfortbxcon.PasswordChar = ControlChars.NullChar
        Else ' Hide the password
            gfortbxcon.PasswordChar = "*"c
        End If
    End Sub

    Private Sub gckbxshow1_CheckedChanged(sender As Object, e As EventArgs) Handles gckbxshow1.CheckedChanged
        'the condition to show password
        If gckbxshow1.Checked Then
            ' Show the password
            gfortbxnew.PasswordChar = ControlChars.NullChar
        Else ' Hide the password
            gfortbxnew.PasswordChar = "*"c
        End If
    End Sub
End Class