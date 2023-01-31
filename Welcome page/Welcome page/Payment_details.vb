Public Class Payment_details

    Dim payment_method As String
    Dim payment_time As Integer
    Dim total_amount As Double
    Dim deposit As Double
    Dim intrest As Double
    Dim insurance As Double
    Dim monthly_payment As Double
    Private Sub btnexit_Click(sender As Object, e As EventArgs)
        'used to close the current window
        Me.Close()
    End Sub

    Private Sub cmbpaymet_method_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbpayment_method.SelectedIndexChanged
        'used to check which options have been selected on the payment method and add the payment duration to it
        If (cmbpayment_method.Text = "Instalment") Then
            cmbpayment_duration.Items.Clear()
            payment_time = cmbpayment_duration.Items.Add(12)
            payment_time = cmbpayment_duration.Items.Add(24)
            payment_time = cmbpayment_duration.Items.Add(36)
            payment_time = cmbpayment_duration.Items.Add(48)
            payment_time = cmbpayment_duration.Items.Add(60)
            payment_time = cmbpayment_duration.Items.Add(72)
            payment_time = cmbpayment_duration.Items.Add(84)
            payment_time = cmbpayment_duration.Items.Add(96)
            payment_time = cmbpayment_duration.Items.Add(108)
            payment_time = cmbpayment_duration.Items.Add(120)
        Else
            cmbpayment_duration.Items.Clear()
            payment_time = cmbpayment_duration.Items.Add(1)
        End If

        payment_method = cmbpayment_method.Text

    End Sub

    Private Sub btnshow_report_Click(sender As Object, e As EventArgs) Handles btnshow_report.Click
        Dim next_page As New Loading_page_5

        If (payment_method = "" Or deposit.ToString = "" Or intrest.ToString = "" Or insurance.ToString = "" Or total_amount.ToString = "" Or monthly_payment.ToString = "") Then
            MessageBox.Show("You have not completed all questions on the form")
        Else
            Me.Hide()
            next_page.Show()
        End If

    End Sub

    Private Sub cmbpayment_duration_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbpayment_duration.SelectedIndexChanged
        If (cmbpayment_method.Text = "Instalment") Then

            deposit = Integer.Parse(Car_details.txtcar_price.Text) * 0.01
            txtdeposit.Text = deposit

            intrest = Integer.Parse(Car_details.txtcar_price.Text) * 0.15
            txtintrest_rate.Text = intrest

            insurance = Integer.Parse(Car_details.txtcar_price.Text) * 0.02
            txtinsurance.Text = insurance

            total_amount = Integer.Parse(Car_details.txtcar_price.Text) + txtintrest_rate.Text
            txtsum_amount.Text = total_amount

            monthly_payment = total_amount * (1 + (txtintrest_rate.Text * payment_time))
            txtmonthly_amount.Text = monthly_payment
        Else
            intrest = Integer.Parse(Car_details.txtcar_price.Text) * 0.15
            txtintrest_rate.Text = intrest

            total_amount = Integer.Parse(Car_details.txtcar_price.Text) + txtintrest_rate.Text
            txtsum_amount.Text = total_amount

            txtdeposit.Text = 0
            txtinsurance.Text = 0
            txtmonthly_amount.Text = 0
        End If
    End Sub
End Class