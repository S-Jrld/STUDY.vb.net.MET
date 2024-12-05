Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Web.UI.WebControls

Public Class RegisterForm

    'this initialize the ramdom indentifier as ramdom class
    Private Shared random As New Random()

    'set the idlength to 11
    Dim idlength As Integer = 11

    Private Shared Function GenerateID(length As Integer) As String
        'this create a method to generate ID using random class
        Const chars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim result As New StringBuilder()
        For i As Integer = 1 To length
            Dim index As Integer = random.Next(chars.Length)
            result.Append(chars(index))
        Next
        Return result.ToString()
    End Function

    Private Function IsUserIDUnique(userid As String) As Boolean
        'this checked if the generated user ID is unique and don't have a same id in database

        'create a query that will select the number of rows to see if there is a record with the same generatedid
        Dim query As String = "SELECT COUNT(*) FROM tbluser WHERE userid = @userid"

        Try
            'check connection state if closed then open
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            'save sql query to the variable cmd
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@userid", userid)

            'execute query into database and return number of rows selected
            Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Return result = 0

        Catch ex As Exception
            MessageBox.Show("Error in IsUserIDUnique from regform: " & ex.Message)
            Return False
        Finally
            'check connection state if open then close
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Function

    Private Function GenerateUniqueUserID() As String
        ' Method to generate a unique user ID
        Dim userid As String
        Do
            userid = GenerateID(11)
        Loop While Not IsUserIDUnique(userid)
        Return userid
    End Function

    Public Sub InsertNewAccount(uniqueid As String, email As String, username As String, password As String)
        'this insert query of user info into the tblusers

        Dim query As String = "INSERT INTO tbluser (userid, uname, email, pass) VALUES (@userid, @username, @email, @password)"
        Try
            'check connection state if closed then open
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            'save sql query to the variable cmd
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@userid", uniqueid)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@email", email)
            cmd.Parameters.AddWithValue("@password", password)

            'execute query into the database and return the integer value of number of rows affected
            Dim i As Integer = cmd.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show("Save Successfully", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'if the condition is true the proceed to login form to login the account just created
                Dim start As New Form1()
                start.Show()
                Me.Hide()

            Else
                MessageBox.Show("Save Unsuccessfully", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch ex As MySqlException
            MessageBox.Show("MySQL Error in Insert from regform: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Error in Insert from regform: " & ex.Message)
        Finally
            'check connection state if open then close
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub gbtnback_Click(sender As Object, e As EventArgs) Handles gbtnback.Click
        'change form into loginform
        Dim login As New LoginForm()
        login.Show()
        Me.Hide()

    End Sub

    Private Sub gbtnsignup_Click(sender As Object, e As EventArgs) Handles gbtnsignup.Click
        ' Check if the email and username fields are empty
        If String.IsNullOrEmpty(gtbxemail.Text) OrElse String.IsNullOrEmpty(gtbxuname.Text) Then
            MessageBox.Show("Fill up the Email and Username", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Return
        End If

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
            ' Generate a unique user ID
            Dim newuserid As String = GenerateUniqueUserID()

            ' Insert the new account into the database
            InsertNewAccount(newuserid, gtbxemail.Text, gtbxuname.Text, newpass)
        Else
            MessageBox.Show("Passwords do not match", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
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

    Private Sub gcheckshow1_CheckedChanged(sender As Object, e As EventArgs) Handles gcheckshow1.CheckedChanged
        'the condition to show password
        If gcheckshow1.Checked Then
            ' Show the password
            gtbxnewpass.PasswordChar = ControlChars.NullChar
        Else ' Hide the password
            gtbxnewpass.PasswordChar = "*"c
        End If
    End Sub

    Private Sub gctrlclose_Click(sender As Object, e As EventArgs) Handles gctrlclose.Click
        'close the application if closebutton.clicked is yes else return to the same form
        If MsgBox("Do you want to close the application?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Application.Exit()
        Else
            Dim register As New RegisterForm
            register.Show()
            Me.Close()
        End If
    End Sub
End Class