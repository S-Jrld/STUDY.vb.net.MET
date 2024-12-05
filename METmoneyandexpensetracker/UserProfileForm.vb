Imports MySql.Data.MySqlClient
Imports ZstdSharp.Unsafe

Public Class UserProfileForm

    Private Sub UpdateUserInfo()
        Dim query As String = "UPDATE tbluser set `uname` = @username, `fname` = @fname, `lname` = @lname, `address` = @address, `birthdate` = @birthdate, `status` = @status, `fundsource` = @fundsource, `mincome` = @mincome WHERE uname = @usernamekey"

        Try
            ' Check connection state; if closed, then open
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            ' Save SQL query to the variable cmd
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@username", gtbxuname.Text)
                cmd.Parameters.AddWithValue("@fname", gtbxfname.Text)
                cmd.Parameters.AddWithValue("@lname", gtbxlname.Text)
                cmd.Parameters.AddWithValue("@address", gtbxaddress.Text)
                cmd.Parameters.AddWithValue("@birthdate", CDate(gbirthdate.Value))
                cmd.Parameters.AddWithValue("@status", gcmboccupation.Text)
                cmd.Parameters.AddWithValue("@fundsource", gcmbsource.Text)
                cmd.Parameters.AddWithValue("@mincome", CInt(gtbxincome.Text))
                cmd.Parameters.AddWithValue("@usernamekey", usernamekey)
                ' Execute query into the database and return the data retrieved
                Dim i As Integer = cmd.ExecuteNonQuery()
                If i > 0 Then
                    MessageBox.Show("Update account Successfully!", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Close the form after success
                    Me.Close()
                Else
                    MessageBox.Show("Update account Unsuccessfully!", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
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
    Private Sub gbtnback_Click(sender As Object, e As EventArgs) Handles gbtnback.Click
        Me.Close()
    End Sub

    Private Sub btnupdateinfo_Click(sender As Object, e As EventArgs) Handles gbtnupdateinfo.Click
        UpdateUserInfo()
    End Sub

    Private Sub UserProfileForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'sets the primary name of combobox into info
        gcmbctrl.Text = "Info"

        'fill the textbox with info
        gtbxuname.Text = usernamekey
        gtbxfname.Text = gfname
        gtbxlname.Text = glname
        gtbxaddress.Text = gaddress
        gbirthdate.Text = guserbirthdate
        gcmboccupation.Text = gstatus
        gcmbsource.Text = gfundsource
        gtbxincome.Text = gmincome

    End Sub

    Private Sub gcmbctrl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gcmbctrl.SelectedIndexChanged
        'user can edit the information
        If gcmbctrl.Text = "EditInfo" Then
            gtbxuname.Enabled = True
            gtbxfname.Enabled = True
            gtbxlname.Enabled = True
            gtbxaddress.Enabled = True
            gbirthdate.Enabled = True
            gcmboccupation.Enabled = True
            gcmbsource.Enabled = True
            gtbxincome.Enabled = True

            gbtnupdateinfo.Enabled = True

            'user can only see the information
        ElseIf gcmbctrl.Text = "Info" Then
            gtbxuname.Enabled = False
            gtbxfname.Enabled = False
            gtbxlname.Enabled = False
            gtbxaddress.Enabled = False
            gbirthdate.Enabled = False
            gcmboccupation.Enabled = False
            gcmbsource.Enabled = False
            gtbxincome.Enabled = False

            gbtnupdateinfo.Enabled = False

        End If
    End Sub
End Class