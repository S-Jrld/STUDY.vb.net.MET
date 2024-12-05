Imports MySql.Data.MySqlClient
Imports ZstdSharp.Unsafe

Public Class AccountSecurityForm
    Private Sub UpdateUserPass()
        Dim query As String = "UPDATE tbluser set pass = @pass WHERE uname = @usernamekey"

        Try
            ' Check connection state; if closed, then open
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            ' Save SQL query to the variable cmd
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@pass", gtbxconfirmpass.Text)
                cmd.Parameters.AddWithValue("@usernamekey", usernamekey)
                ' Execute query into the database and return the data retrieved
                Dim i As Integer = cmd.ExecuteNonQuery()
                If i > 0 Then
                    MessageBox.Show("Change password Successfully!", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Close the accountform after successful change of password
                    Me.Close()
                Else
                    MessageBox.Show("Change password Unsuccessfully!", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If

            End Using
        Catch ex As MySqlException
            MessageBox.Show("MySQL Error in updateuserinfo: " & ex.Message, "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error in updateuserinfo: " & ex.Message, "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Check connection state; if open, then close
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub
    Private Sub gcmbstatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcmbstatus.SelectedIndexChanged
        If gcmbstatus.Text = "AccountSecurity" Then
            gtbxcurrentpass.ReadOnly = True
            gtbxnewpass.Enabled = False
            gtbxconfirmpass.Enabled = False
            'change the status to not be accessible to user for input
        ElseIf gcmbstatus.Text = "ChangePassword" Then
            gtbxcurrentpass.ReadOnly = True
            gtbxnewpass.Enabled = True
            gtbxconfirmpass.Enabled = True
            'change the status to enabled to be accessible to user for input
        End If
    End Sub

    Private Sub gbtnback_Click(sender As Object, e As EventArgs) Handles gbtnback.Click
        'close the form
        Me.Close()
    End Sub

    Private Sub gbtnchangepass_Click(sender As Object, e As EventArgs) Handles gbtnchangepass.Click
        ' Check if the password fields are empty
        If String.IsNullOrEmpty(gtbxnewpass.Text) OrElse String.IsNullOrEmpty(gtbxconfirmpass.Text) Then
            MessageBox.Show("Fill up the password", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Return
        End If

        ' Initialize new variables
        Dim newpass As String = gtbxnewpass.Text
        Dim confirmpass As String = gtbxconfirmpass.Text

        ' Confirm the password
        If newpass = confirmpass Then

            ' update the account password into the database
            UpdateUserPass()
        Else
            MessageBox.Show("Passwords do not match", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub

    Private Sub AccountSecurityForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gcmbstatus.Text = "AccountSecurity"

        gtbxcurrentpass.Text = guserpass
    End Sub

    Private Sub gckbxshow0_CheckedChanged(sender As Object, e As EventArgs) Handles gcheckshow0.CheckedChanged
        'the condition to show password
        If gcheckshow0.Checked Then
            ' Show the password
            gtbxcurrentpass.PasswordChar = ControlChars.NullChar
        Else ' Hide the password
            gtbxcurrentpass.PasswordChar = "*"c
        End If
    End Sub

    Private Sub gcheckshow1_CheckedChanged(sender As Object, e As EventArgs) Handles gcheckshow1.CheckedChanged
        'the condition to show password
        If gcheckshow1.Checked Then
            ' Show the password
            gtbxnewpass.PasswordChar = ControlChars.NullChar
        Else ' Hide the password
            gtbxnewpass.PasswordChar = "*"c
        End If
    End Sub

    Private Sub gcheckshow2_CheckedChanged(sender As Object, e As EventArgs) Handles gcheckshow2.CheckedChanged
        'the condition to show password
        If gcheckshow2.Checked Then
            ' Show the password
            gtbxconfirmpass.PasswordChar = ControlChars.NullChar
        Else ' Hide the password
            gtbxconfirmpass.PasswordChar = "*"c
        End If
    End Sub
End Class