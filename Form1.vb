Public Class Form1

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        'step 1: declare variables
        Dim weight, cost, cash, change, more As Double
        Const price As Double = 1.5
        'step 2: getting the user input
        weight = CDbl(txtPounds.Text)
        cash = CDbl(txtCash.Text)
        'step 3: makeing calculations
        cost = weight * price
        lblCost.Text = CStr(cost)
        If cash > cost Then
            change = cash - cost
            lblChange.Text = CStr(change)
        Else
            more = cost - cash
            lblChange.Text = "I need " & CStr(more) & " more"
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub resetButton_Click(sender As Object, e As EventArgs) Handles btnReset.Click


    End Sub
End Class
