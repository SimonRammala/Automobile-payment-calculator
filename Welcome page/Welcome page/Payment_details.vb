Public Class Payment_details

    Private Sub btnexit_Click(sender As Object, e As EventArgs)
        'used to close the current window
        Me.Close()
    End Sub

    Private Sub cmbpaymet_method_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbpayment_method.SelectedIndexChanged
        'used to check which options have been selected on the payment method and add the payment duration to it
        If (cmbpayment_method.Text = "Instalment") Then
            cmbpayment_duration.Items.Clear()
            cmbpayment_duration.Items.Add("12")
            cmbpayment_duration.Items.Add("24")
            cmbpayment_duration.Items.Add("36")
            cmbpayment_duration.Items.Add("48")
            cmbpayment_duration.Items.Add("60")
            cmbpayment_duration.Items.Add("72")
            cmbpayment_duration.Items.Add("84")
            cmbpayment_duration.Items.Add("96")
            cmbpayment_duration.Items.Add("108")
            cmbpayment_duration.Items.Add("120")
        Else
            cmbpayment_duration.Items.Clear()
            cmbpayment_duration.Items.Add("1")
        End If
    End Sub

    Private Sub btndisplay_report_Click(sender As Object, e As EventArgs) Handles btndisplay_report.Click
        Dim payment_method As String
        Dim payment_time As Integer
        Dim total_amount As Double
        Dim deposit As Double
        Dim intrest As Double
        Dim insurance As Double
        Dim monthly_payment As Double


        payment_method = cmbpayment_method.Text
        payment_time = cmbpayment_duration.Text

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


        Dim next_page As New Loading_page_5

        If (payment_method = "" Or payment_time = "" Or deposit = "" Or intrest = "" Or insurance = "" Or total_amount = "" Or monthly_payment = "") Then
            MessageBox.Show("You have not completed all questions on the form")
        Else
            Me.Hide()
            next_page.Show()
        End If

    End Sub
End Class