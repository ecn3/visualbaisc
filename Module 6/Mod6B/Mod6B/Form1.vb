Public Class Form1
    Private Sub btnAddRainFall_Click(sender As Object, e As EventArgs) Handles btnAddRainFall.Click
        'Initalize
        Dim strRainFall As String
        Dim decRainFall As Decimal
        Dim decAverageRainFall As Decimal
        Dim decTotalRainFall As Decimal = 0D
        Dim strInputMessage As String = "Enter the rainfall for month #"
        Dim strNormalMessage As String = "Enter the rainfall for month #"
        Dim strInputHeading As String = "Rain Fall"
        Dim strNonNumericError As String = "Error - Enter a number for the rainfall of month #"
        Dim strNegativeError As String = "Error - Enter a  positive number for the rainfall of month #"


        'Dinitalize loop vars
        Dim strCancelClicked As String = ""
        Dim intMaxNumberOfEntries As Integer = 12
        Dim intNumberOfEntries As Integer = 1

        strRainFall = InputBox(strInputMessage & intNumberOfEntries, strInputHeading)

        Do Until intNumberOfEntries > intMaxNumberOfEntries Or strRainFall = strCancelClicked
            If IsNumeric(strRainFall) Then
                decRainFall = Convert.ToDecimal(strRainFall)
                If decRainFall > 0 Then
                    decRainFall = Decimal.Round(decRainFall, 1)
                    lstRainFall.Items.Add(decRainFall)
                    decTotalRainFall += decRainFall
                    intNumberOfEntries += 1
                    strInputMessage = strNormalMessage
                Else
                    strInputMessage = strNegativeError
                End If
            Else
                strInputMessage = strNonNumericError
            End If
            If intNumberOfEntries <= intMaxNumberOfEntries Then
                strRainFall = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")
            End If
        Loop

        'calculate and display average
        If intNumberOfEntries > 1 Then
            lblAverageRainFall.Visible = True
            decAverageRainFall = decTotalRainFall / (intNumberOfEntries - 1)
            lblAverageRainFall.Text = "Average Rain Fall is " & decAverageRainFall.ToString("F1") & " inches"
        ElseIf (intNumberOfEntries = 1) Then
            MsgBox("No Rain Fall value entered")
        End If

        btnAddRainFall.Enabled = False
    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        lstRainFall.Items.Clear()
        lblAverageRainFall.Visible = False
        btnAddRainFall.Enabled = True
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Close()
    End Sub
End Class
