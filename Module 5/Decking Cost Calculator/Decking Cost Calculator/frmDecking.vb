'* Program Name: Decking Cost Calculator
'* Author: Christian Nelson
'* Date: 11/23/19
'* Purpose: This Windows form application computes the estimated cost of decking based on the
'* number of quare feet and the following cost per quare foot: Lumbrt - $2.35
'* Redwood - $7.75, Composite - $8.50
Option Strict On

Public Class frmDecking
    Dim decFootage As Decimal
    Dim decCostPerSquareFoot As Decimal
    Dim decCostEstimate As Decimal
    Dim decLumberCost As Decimal = 2.35D
    Dim decRedwoodCost As Decimal = 7.75D
    Dim decCompositeCost As Decimal = 8.5D

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'estimates the cost

        If IsNumeric(txtFootage.Text) Then
            decFootage = Convert.ToDecimal(txtFootage.Text)


            If decFootage > 0 Then



                If radLumber.Checked Then
                    decCostPerSquareFoot = decLumberCost
                ElseIf radRedwood.Checked Then
                    decCostPerSquareFoot = decRedwoodCost
                ElseIf radComposite.Checked Then
                    decCostPerSquareFoot = decCompositeCost
                End If

                decCostEstimate = decFootage * decCostPerSquareFoot
                lblCostEstumate.Text = decCostEstimate.ToString("C")

            Else
                MsgBox("You entered " & decFootage.ToString() & " , Enter a positive number", , "Input Error")
                txtFootage.Text = ""
                txtFootage.Focus()
            End If
        Else
            MsgBox("Enter the square Footage of Decking", , "Input Error")
            txtFootage.Text = ""
            txtFootage.Focus()
        End If
    End Sub
End Class
