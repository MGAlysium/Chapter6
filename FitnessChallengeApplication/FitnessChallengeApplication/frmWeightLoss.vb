Public Class frmWeightLoss

    Dim weightLoss As String = " "
    Dim message As String = "Enter weight loss for player #"
    Dim title As String = "Weight Loss"

    Dim decWeightLoss As Decimal = 0D
    Dim total As Decimal = 0D
    Dim average As Decimal = 0D

    Dim i As Integer

    Private Sub btnEnterWeight_Click(sender As Object, e As EventArgs) Handles btnEnterWeight.Click
        If i > 1 Then
            lstWeights.Items.Clear()
        End If

        i = 1
        title = "Weight Loss"
        message = "Enter weight loss for player #"
        weightLoss = " "

        Do Until i > 8 Or weightLoss = ""
            weightLoss = InputBox(message & i, title)
            If IsNumeric(weightLoss) Then
                decWeightLoss = CDec(weightLoss)
                If decWeightLoss >= 0 Then
                    title = "Weight Loss"
                    message = "Enter weight loss for player #"
                    lstWeights.Items.Add(decWeightLoss)
                    total += decWeightLoss
                    i += 1
                Else
                    title = "Negative Error"
                    message = "Enter a positive weight loss value for player #"
                End If
            Else
                title = "Non-Numeric Error"
                message = "Enter a numeric weight loss value for player #"
            End If
        Loop

        If i = 1 Then
            MsgBox("Please enter a value for player #1", , "No Input Error")
        Else
            average = total / (i - 1)
            lblOutput.Text = "The average weight loss" + vbCrLf + "for the team is " + average.ToString("0.0") + " lbs."
        End If
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Close()
    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        lblOutput.Text = "The average weight loss" + vbCrLf + "for the team is 0.0 lbs."
        lstWeights.Items.Clear()
    End Sub
End Class
