Public Class Form1
	Private Sub btnCalcSale_Click(sender As Object, e As EventArgs) Handles btnCalcSale.Click
		Dim dblTotalPrice As Double
		Dim dblRetailPrice As Double
		Const dblTAX_RATE As Double = 1.07

		dblRetailPrice = CDbl(txtRetailPrice.Text)

		dblTotalPrice = dblTAX_RATE * dblRetailPrice

		lblTotal.Text = dblTotalPrice.ToString("c")
	End Sub
End Class
