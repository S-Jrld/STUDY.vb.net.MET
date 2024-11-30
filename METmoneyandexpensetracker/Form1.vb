Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub gstartbtn_Click(sender As Object, e As EventArgs) Handles gloginbtn.Click
        'change into login form
        Dim login As New LoginForm
        login.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        'close the application
        Application.Exit()
    End Sub

    Private Sub gsignbtn_Click(sender As Object, e As EventArgs) Handles gsignbtn.Click
        'change into signup form
        Dim sign As New RegisterForm
        sign.Show()
        Me.Hide()
    End Sub
End Class
