Imports MySql.Data.MySqlClient

Public Class TransactionsForm
    Public Sub AddTransaction()
        ' Create query to insert values into the database
        Dim query As String = "INSERT INTO tbltransaction(userid, uname, transstatus, category, transname, price, quantity, total, transdate) " &
                          "VALUES ((SELECT userid FROM tbluser WHERE uname = @username), @username, @transstatus, @category, @transname, @price, @quantity, @total, @transdate)"

        Try
            ' Check connection state; if closed, then open
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            ' Initialize new variables
            Dim price As Decimal = CDec(gtbxprice.Text)
            Dim qty As Integer = CInt(gtbxqty.Text)
            Dim total As Decimal = price * qty

            ' Save SQL query to the variable cmd
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@username", usernamekey)
                cmd.Parameters.AddWithValue("@transstatus", gtbxstatus.Text)
                cmd.Parameters.AddWithValue("@category", gcmbcategory.Text)
                cmd.Parameters.AddWithValue("@transname", gtbxtransname.Text)
                cmd.Parameters.AddWithValue("@price", price)
                cmd.Parameters.AddWithValue("@quantity", qty)
                cmd.Parameters.AddWithValue("@total", total)
                cmd.Parameters.AddWithValue("@transdate", CDate(gdatetrans.Value))

                ' Execute query in the database and return the integer value of rows affected 
                Dim i As Integer = cmd.ExecuteNonQuery()
                If i > 0 Then
                    MessageBox.Show("Save Record Successfully!", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' Close the transaction form after adding transaction
                    Me.Close()
                Else
                    MessageBox.Show("Save Record Unsuccessfully!", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            End Using

        Catch ex As MySqlException
            MessageBox.Show("MySQL Error in AddTransaction: " & ex.Message, "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error in AddTransaction: " & ex.Message, "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Check connection state; if open, then close
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Public Sub UpdateTransaction()
        ' Create a query to update values in the database
        Dim query As String = "UPDATE tbltransaction SET transstatus = @transstatus, category = @category, transname = @transname, price = @price, quantity = @quantity, total = @total, transdate = @transdate WHERE transid = @transid"

        Try
            ' Check connection state; if closed, then open
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            ' Initialize new variables
            Dim price As Decimal = CDec(gtbxprice.Text)
            Dim qty As Integer = CInt(gtbxqty.Text)
            Dim total As Decimal = price * qty

            ' Save SQL query to the variable cmd
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@transid", gtransid)
                cmd.Parameters.AddWithValue("@transstatus", gtbxstatus.Text)
                cmd.Parameters.AddWithValue("@category", gcmbcategory.Text)
                cmd.Parameters.AddWithValue("@transname", gtbxtransname.Text)
                cmd.Parameters.AddWithValue("@price", price)
                cmd.Parameters.AddWithValue("@quantity", qty)
                cmd.Parameters.AddWithValue("@total", total)
                cmd.Parameters.AddWithValue("@transdate", CDate(gdatetrans.Value))

                ' Execute query in the database and return the integer value of rows affected 
                Dim i As Integer = cmd.ExecuteNonQuery()
                If i > 0 Then
                    MessageBox.Show("Update Record Successfully!", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    editrecords = False
                    ' Close the transaction form after updating transaction
                    Me.Close()
                Else
                    MessageBox.Show("Update Record Unsuccessfully!", "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            End Using

        Catch ex As MySqlException
            MessageBox.Show("MySQL Error in UpdateTransaction: " & ex.Message, "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error in UpdateTransaction: " & ex.Message, "MoneyExpenseTracker", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Check connection state; if open, then close
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub gbtnback_Click(sender As Object, e As EventArgs) Handles gbtnback.Click
        'Close the transaction form after clicking back
        Me.Close()

    End Sub

    Private Sub gbtnaddtrans_Click(sender As Object, e As EventArgs) Handles gbtnaddtrans.Click
        AddTransaction()
    End Sub

    Private Sub gbtnedittrans_Click(sender As Object, e As EventArgs) Handles gbtnedittrans.Click
        UpdateTransaction()
    End Sub

    Private Sub TransactionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If editrecords Then
            gtbxstatus.Text = gtransstatus
            gcmbcategory.Text = gcategory
            gtbxtransname.Text = gtransname
            gtbxprice.Text = gprice
            gtbxqty.Text = gquantity
            gdatetrans.Text = gtransdate

            gbtnaddtrans.Enabled = False
        Else
            gdatetrans.Value = Now()
            gbtnedittrans.Enabled = False
        End If
    End Sub
End Class