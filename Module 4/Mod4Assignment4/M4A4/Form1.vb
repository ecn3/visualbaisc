Public Class Form1

    Public Shared grossPay1 As Decimal = 0.0
    Public Shared grossPay2 As Decimal = 0.0
    Public Shared grossTwoWeekPay As Decimal = 0.0
    Public Shared adjustedTwoWeekPay As Decimal = 0.0
    Public Shared ficaTax As Decimal = 0.0
    Public Shared federalTax As Decimal = 0.0
    Public Shared stateIncomeTax As Decimal = 0.0


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        Label8.Text = "$"
        Label9.Text = "$"
        Label10.Text = "$"
        Label11.Text = "$"
        Label12.Text = "$"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        grossPay1 = CDbl(Val(TextBox1.Text)) '// sets grosspay to what the current week is
        grossPay2 = CDbl(Val(TextBox2.Text)) '// sets grosspay to what the current week is
        grossTwoWeekPay = grossPay1 + grossPay2
        ficaTax = (grossTwoWeekPay * 0.0765)
        federalTax = (grossTwoWeekPay * 0.22)
        stateIncomeTax = (grossTwoWeekPay * 0.04)
        adjustedTwoWeekPay = grossTwoWeekPay - (ficaTax + federalTax + stateIncomeTax)

        Dim formattedValue As String = String.Format("{0:n}", grossTwoWeekPay)
        Label9.Text = "$" + formattedValue
    End Sub
End Class
