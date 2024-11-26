Imports MySql.Data.MySqlClient
Imports System.Text

Public Class RegisterForm

    'this initialize the ramdom indentifier as ramdom class
    Private Shared random As New Random()

    Dim idlength As Integer = 11
    ' Method to generate ID using random class
    Public Shared Function GenerateID(length As Integer) As String
        Const chars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim result As New StringBuilder()
        For i As Integer = 1 To length
            Dim index As Integer = random.Next(chars.Length)
            result.Append(chars(index))
        Next
        Return result.ToString()
    End Function

    ' Method to check if the generated user ID is unique
    Private Function IsUserIDUnique(userid As String) As Boolean
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM tblusers WHERE userid = @userid", connection)
            cmd.Parameters.AddWithValue("@userid", userid)
            Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Return result = 0
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    ' Method to generate a unique user ID
    Private Function GenerateUniqueUserID() As String
        Dim userid As String
        Do
            userid = GenerateID(11)
        Loop While Not IsUserIDUnique(userid)
        Return userid
    End Function

    'Method to insert query the user info
    Public Sub Insert(uniqueid As String, email As String, username As String, password As String)
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim cmd As New MySqlCommand("INSERT INTO tblusers (userid, Email, Username, Password) VALUES (@userid, @Email, @Username, @Password)", connection)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@userid", uniqueid)
            cmd.Parameters.AddWithValue("@Email", email)
            cmd.Parameters.AddWithValue("@Username", username)
            cmd.Parameters.AddWithValue("@Password", password)
            Dim i As Integer = cmd.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show("Save Successfully", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim login As New LoginForm
                login.Show()
                Me.Hide()

            Else
                MessageBox.Show("Save Unsuccessfully", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RegisterForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        'close the application
        Application.Exit()
    End Sub

    Private Sub glogbtnreg_Click(sender As Object, e As EventArgs) Handles gregbtnlog.Click
        'change form into login form
        Dim log As New LoginForm
        log.Show()
        Me.Hide()

    End Sub

    Private Sub glogbtn_Click(sender As Object, e As EventArgs) Handles gregbtn.Click
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
End Class