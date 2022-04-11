Public Class frmSnow

    Dim weightLoss As String = " "
    Dim message As String = "Enter snowfall for "
    Dim title As String = "Snow Fall"
    Dim month = New String(6) {"October", "November", "December", "January", "February", "March", "April"}

    Dim decWeightLoss As Decimal = 0D
    Dim total As Decimal = 0D

    Dim i As Integer

    Private Sub btnEnterWeight_Click(sender As Object, e As EventArgs) Handles btnEnterWeight.Click
        If i > 1 Then
            lstWeights.Items.Clear()
        End If

        i = 1
        title = "Snow Fall"
        message = "Enter snowfall for "
        weightLoss = " "
        total = 0

        Do Until i > 7 Or weightLoss = ""
            weightLoss = InputBox(message & month(i - 1), title)
            If IsNumeric(weightLoss) Then
                decWeightLoss = CDec(weightLoss)
                If decWeightLoss >= 0 Then
                    title = "Snow Fall"
                    message = "Enter snowfall for "
                    lstWeights.Items.Add(decWeightLoss)
                    total += decWeightLoss
                    i += 1
                Else
                    title = "Negative Error"
                    message = "Enter a positive snowfall amount for "
                End If
            Else
                title = "Non-Numeric Error"
                message = "Enter a numeric snowfall amount for "
            End If
        Loop

        If i = 1 Then
            MsgBox("Please enter a snowfall amount for October", , "No Input Error")
        Else
            lblOutput.Text = "The total snowfall" + vbCrLf + "for Buffalo is " + total.ToString("0.0") + " inches."
        End If
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Close()
    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        lblOutput.Text = "The total snowfall" + vbCrLf + "for Buffalo is 0 inches."
        lstWeights.Items.Clear()
    End Sub
End Class
