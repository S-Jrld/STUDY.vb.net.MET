Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub gstartbtn_Click(sender As Object, e As EventArgs) Handles gstartbtn.Click
        If MsgBox("Are you sure you want to Start the Application?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            'change into login form
            Dim login As New LoginForm
            login.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        'close the application
        Application.Exit()
    End Sub
End Class
