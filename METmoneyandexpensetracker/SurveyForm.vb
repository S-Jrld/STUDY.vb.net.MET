Imports MySql.Data.MySqlClient

Public Class SurveyForm

    Public Sub insertinfo()
        'create a method to insert info into users

        'create a query to insert values into null or empty columns in tblusers
        Dim query As String = "UPDATE `tblusers` SET `fname`=@fname,`lname`=@lname,`useraddress`=@useraddress,`birthdate`=@birthdate,`occupation`=@occupation,`fundsource`=@fundsource, incomemon =@incomemon WHERE Username = @Username"

        Try
            'check connection state if closed then open
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            'save sql query to the variable cmd
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Username", uname)
            cmd.Parameters.AddWithValue("@fname", gtbxfname.Text)
            cmd.Parameters.AddWithValue("@lname", gtbxlname.Text)
            cmd.Parameters.AddWithValue("@useraddress", gtbxaddress.Text)
            cmd.Parameters.AddWithValue("@birthdate", CDate(gbirthdate.Value))
            cmd.Parameters.AddWithValue("@occupation", gcmboccupation.Text)
            cmd.Parameters.AddWithValue("@fundsource", gcmbsource.Text)
            cmd.Parameters.AddWithValue("@incomemon", gtbxincome.Text)

            'execute the query and return integer value of rows affected after update
            Dim i As Integer = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Save Succesfully!", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'if true then proceed to dashboard
                Dim dash As New DashboardForm
                dash.Show()
                Me.Hide()
            Else
                MessageBox.Show("Save Unsuccessfully!", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

        Catch ex As Exception
            MessageBox.Show("An error occured in insertinfo from surveyform: ", ex.Message)
        Finally
            'check connection state if open then close
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try

    End Sub

    Private Function AreAllFieldsFilled() As Boolean
        ' Initialize a flag to true
        Dim allFilled As Boolean = True

        ' Check each control for emptiness
        If String.IsNullOrWhiteSpace(gtbxfname.Text) Then
            allFilled = False
        End If

        If String.IsNullOrWhiteSpace(gtbxlname.Text) Then
            allFilled = False
        End If

        If String.IsNullOrWhiteSpace(gtbxaddress.Text) Then
            allFilled = False
        End If

        If gbirthdate.Value = DateTime.MinValue Then
            allFilled = False
        End If

        If String.IsNullOrWhiteSpace(gcmboccupation.Text) Then
            allFilled = False
        End If

        If String.IsNullOrWhiteSpace(gcmbsource.Text) Then
            allFilled = False
        End If

        If String.IsNullOrWhiteSpace(gtbxincome.Text) Then
            allFilled = False
        End If

        ' Return the final result
        Return allFilled
    End Function

    Private Sub gbtncontinue_Click(sender As Object, e As EventArgs) Handles gbtncontinue.Click
        'check field if filled
        If AreAllFieldsFilled() Then
            insertinfo()
        Else
            MessageBox.Show("Please fill out all required fields.")
        End If
    End Sub

    Private Sub SurveyForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'set datetimepicker date to now to keep being updated
        gbirthdate.Value = Now
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles gctrlclose.Click
        'close the application if closebutton.clicked is yes else return to the same form
        If MsgBox("Do you want to close the application?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Application.Exit()
        Else
            Dim survey As New SurveyForm
            survey.Show()
            Me.Hide()
        End If
    End Sub
End Class