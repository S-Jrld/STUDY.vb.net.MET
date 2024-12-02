Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Web.UI.WebControls

Public Class RegisterForm

    'this initialize the ramdom indentifier as ramdom class
    Private Shared random As New Random()

    'set the idlength to 11
    Dim idlength As Integer = 11

    Public Shared Function GenerateID(length As Integer) As String
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
        Dim query As String = "SELECT COUNT(*) FROM tblusers WHERE userid = @userid"

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

    Public Sub Insert(uniqueid As String, email As String, username As String, password As String)
        'this insert query of user info into the tblusers

        Dim query As String = "INSERT INTO tblusers (userid, Email, Username, Password) VALUES (@userid, @Email, @Username, @Password)"
        Try
            'check connection state if closed then open
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            'save sql query to the variable cmd
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@userid", uniqueid)
            cmd.Parameters.AddWithValue("@Email", email)
            cmd.Parameters.AddWithValue("@Username", username)
            cmd.Parameters.AddWithValue("@Password", password)

            'execute query into the database and return the integer value of number of rows affected
            Dim i As Integer = cmd.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show("Save Successfully", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'if the condition is true the proceed to login form to login the account just created
                Dim login As New LoginForm
                login.Show()
                Me.Hide()

            Else
                MessageBox.Show("Save Unsuccessfully", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch ex As Exception
            MessageBox.Show("Error in Insert from regform: " & ex.Message)
        Finally
            'check connection state if open then close
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub glogbtnreg_Click(sender As Object, e As EventArgs) Handles gregbtnlog.Click
        'change form into loginform
        Dim login As New LoginForm
        login.Show()
        Me.Hide()

    End Sub

    Private Sub glogbtn_Click(sender As Object, e As EventArgs) Handles gregbtn.Click
        'the log button will execute this conditions and if passed then do the task

        'check if the email and username is empty
        If String.IsNullOrEmpty(gregtbxmail.Text) OrElse String.IsNullOrEmpty(gregtbxname.Text) Then
            MessageBox.Show("Fill up the Email and Username", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            'check if the password is empty
            If String.IsNullOrEmpty(gregtbxnew.Text) OrElse String.IsNullOrEmpty(gregtbxcon.Text) Then
                MessageBox.Show("Fill up the password", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                'initialize new variable
                Dim newpass As String = gregtbxnew.Text
                Dim confirmpass As String = gregtbxcon.Text

                'confirm the password
                If newpass = confirmpass Then
                    Dim newuserid As String = GenerateUniqueUserID()
                    Insert(newuserid, gregtbxmail.Text, gregtbxname.Text, gregtbxcon.Text)
                Else
                    MessageBox.Show("Password do not match", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                End If
            End If
        End If

    End Sub

    Private Sub gckbxshow2_CheckedChanged(sender As Object, e As EventArgs) Handles gckbxshow2.CheckedChanged
        'the condition to show password
        If gckbxshow2.Checked Then
            ' Show the password
            gregtbxcon.PasswordChar = ControlChars.NullChar
        Else ' Hide the password
            gregtbxcon.PasswordChar = "*"c
        End If
    End Sub

    Private Sub gckbxshow1_CheckedChanged(sender As Object, e As EventArgs) Handles gckbxshow1.CheckedChanged
        'the condition to show password
        If gckbxshow1.Checked Then
            ' Show the password
            gregtbxnew.PasswordChar = ControlChars.NullChar
        Else ' Hide the password
            gregtbxnew.PasswordChar = "*"c
        End If
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles gctrlclose.Click
        'close the application if closebutton.clicked is yes else return to the same form
        If MsgBox("Do you want to close the application?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Application.Exit()
        Else
            Dim register As New RegisterForm
            register.Show()
            Me.Hide()
        End If
    End Sub
End Class