Public Class Form1
    Public Shared pictureSet As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (pictureSet < 4) Then
            PictureBox1.Image = My.Resources.Myrtle_Beach
            pictureSet = 1
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (pictureSet < 4) Then
            PictureBox1.Image = My.Resources.Key_West
            pictureSet = 2
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (pictureSet < 4) Then
            PictureBox1.Image = My.Resources.Venice_Beach
            pictureSet = 3
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ((pictureSet < 4) And (pictureSet > 0)) Then
            Call MsgBox("Enjoy your trip!")
            pictureSet = 4
        End If
    End Sub
End Class
