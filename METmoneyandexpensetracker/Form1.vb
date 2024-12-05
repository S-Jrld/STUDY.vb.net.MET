Public Class Form1

    Private Sub gbtnlogin_Click(sender As Object, e As EventArgs) Handles gbtnlogin.Click
        'change into login form
        Dim login As New LoginForm()
        login.Show()
        Me.Hide()
    End Sub

    Private Sub gbtnsignup_Click(sender As Object, e As EventArgs) Handles gbtnsignup.Click
        'change into signup form
        Dim sign As New RegisterForm()
        sign.Show()
        Me.Hide()
    End Sub

    Private Sub gctrlclose_Click(sender As Object, e As EventArgs) Handles gctrlclose.Click
        If MsgBox("Do you want to close the application?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Application.Exit()
        Else
            Dim login As New LoginForm
            login.Show()
            Me.Hide()
        End If
    End Sub
End Class
