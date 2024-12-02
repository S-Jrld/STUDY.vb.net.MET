Public Class Form1

    Private Sub gstartbtn_Click(sender As Object, e As EventArgs) Handles gloginbtn.Click
        'change into login form
        Dim login As New LoginForm
        login.Show()
        Me.Hide()
    End Sub

    Private Sub gsignbtn_Click(sender As Object, e As EventArgs) Handles gsignbtn.Click
        'change into signup form
        Dim sign As New RegisterForm
        sign.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles gctrlclose.Click
        'close the application if closebutton.clicked is yes else return to the same form
        If MsgBox("Do you want to close the application?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Application.Exit()
        Else
            Dim start As New Form1
            start.Show()
            Me.Hide()
        End If
    End Sub
End Class
