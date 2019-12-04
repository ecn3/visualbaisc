Public Class Form1
    Private Sub changeColorBtn_Click(sender As Object, e As EventArgs) Handles changeColorBtn.Click
        If ColorDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            changeColorBtn.ForeColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub changeThemeBtn_Click(sender As Object, e As EventArgs) Handles changeThemeBtn.Click
        Dim MyForm As New Form2
        MyForm.Show()
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        changeColorBtn.ForeColor = Color.Black
        pic.Image = My.Resources.plainYellowDuck
    End Sub

    Private Sub purchaseBtn_Click(sender As Object, e As EventArgs) Handles purchaseBtn.Click
        Dim MyForm As New Form3
        MyForm.Show()
    End Sub
End Class
