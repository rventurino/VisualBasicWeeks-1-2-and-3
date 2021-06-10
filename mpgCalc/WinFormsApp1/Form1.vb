Public Class Form1
    Private Sub lblTotalMiles_Click(sender As Object, e As EventArgs) Handles lblTotalMiles.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalcMPG_Click(sender As Object, e As EventArgs) Handles btnCalcMPG.Click
        Dim gallons As Double
        Dim miles As Double
        Dim mpg As Double

        gallons = CDbl(txtGallons.Text)
        miles = CDbl(txtMiles.Text)

        mpg = (miles / gallons)

        txtMPG.Text = mpg.ToString("n")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtGallons.Text = ""
        txtMiles.Text = ""
        txtMPG.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim frm As New Form1
        frm.Show()

        Me.Close()
    End Sub
End Class
