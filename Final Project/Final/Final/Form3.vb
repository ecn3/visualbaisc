Public Class Form3
    Dim numOfDucks As Integer

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        numOfDucks = numDucksUpDown.Value
        themeLbl.Text = "Theme"
        skinColorLbl.ForeColor = Form1.ColorDialog1.Color
        skinColorLbl.Text = Form1.ColorDialog1.Color.ToString()
        priceLbl.Text = (numOfDucks * 5)
    End Sub

    Private Sub numDucksUpDown_ValueChanged(sender As Object, e As EventArgs) Handles numDucksUpDown.ValueChanged
        numOfDucks = numDucksUpDown.Value
        priceLbl.Text = (numOfDucks * 5)
    End Sub

    Private Sub buyBtn_Click(sender As Object, e As EventArgs) Handles buyBtn.Click
        Form1.Close()
    End Sub
End Class