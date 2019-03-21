Public Class LOGINFORM

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub signout_Click(sender As Object, e As EventArgs) Handles signout.Click
        Me.Hide()
        login.Show()

    End Sub
End Class