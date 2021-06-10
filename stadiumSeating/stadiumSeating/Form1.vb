Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtTicket_a_qty.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles gbTicketsSold.Enter

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub btnCalcRevenue_Click(sender As Object, e As EventArgs) Handles btnCalcRevenue.Click
        Try
            Dim A_qty As Double
            Dim B_qty As Double
            Dim C_qty As Double
            Dim A_res As Double
            Dim B_res As Double
            Dim C_res As Double
            Dim total_res As Double

            A_qty = CDbl(txtTicket_a_qty.Text)
            B_qty = CDbl(txtTicket_b_qty.Text)
            C_qty = CDbl(txtTicket_c_qty.Text)

            A_res = (A_qty * 15)
            B_res = (B_qty * 12)
            C_res = (C_qty * 9)
            total_res = (A_res + B_res + C_res)

            curRevA.Text = A_res.ToString("c")
            curRevB.Text = B_res.ToString("c")
            curRevC.Text = C_res.ToString("c")
            curRevTotal.Text = total_res.ToString("c")

        Catch

            MessageBox.Show("Numeric Values Only Please :-)")

        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        curRevA.Text = ""
        curRevB.Text = ""
        curRevC.Text = ""
        curRevTotal.Text = ""
        txtTicket_a_qty.Text = ""
        txtTicket_b_qty.Text = ""
        txtTicket_c_qty.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim frm As New Form1
        frm.Show()

        Me.Close()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs)

    End Sub
End Class
