Public Class Form1

    Private Const V As Integer = 1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ProgressBar1.Value += V
        If ProgressBar1.Value = 100 Then
            Button1.Enabled = False
            Button2.Enabled = False
            Button1.Visible = False
            Button2.Visible = False
            Victory.Visible = True
        End If
        Label1.Text = ProgressBar1.Value
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ProgressBar1.Value = 99
        Label1.Text = ProgressBar1.Value
        If ProgressBar1.Value <= 99 Then
            Button2.Enabled = False
            Button2.Visible = False
        End If
    End Sub

End Class
