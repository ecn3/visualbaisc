Public Class Form1
    Public myIndex = 0

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Image = My.Resources.Bean_Burrito
        myIndex = 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox1.Image = My.Resources.Falafel
        myIndex = 2
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PictureBox1.Image = My.Resources.Greek_Yogurt
        myIndex = 3
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PictureBox1.Image = My.Resources.Spring_Rolls
        myIndex = 4
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (myIndex = 1) Then
            MessageBox.Show("You have choosen Bean Burrito")
        ElseIf (myIndex = 2) Then
            MessageBox.Show("You have choosen Falafel")
        ElseIf (myIndex = 3) Then
            MessageBox.Show("You have choosen Greek Yogurt")
        ElseIf (myIndex = 4) Then
            MessageBox.Show("You have choosen Spring Rolls")
        End If
    End Sub

End Class
