Public Class Report_page
    Private Sub Report_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblclients_name.Text = Customer_Details.txtcustomer_name.Text
        lblclients_surname.Text = Customer_Details.txtcustomer_surname.Text
        lblclients_middle_name.Text = Customer_Details.txtmiddle_name.Text
        lblclients_madien_name.Text = Customer_Details.txtmadien_name.Text
        lblclients_date_of_birth.Text = Customer_Details.dtpdate_of_birth.Text
        lblclients_gender.Text = Customer_Details.cmbgender.Text
        lblclients_age.Text = Customer_Details.txtcustomer_age.Text
        lblclients_cell_num.Text = Customer_Details.txtcell_num.Text


        lblemp_company_name.Text = Employment_details.txtcompany_name.Text
        lblemp_occ_at_company.Text = Employment_details.txtocupation.Text
        lblemp_yearly_salary.Text = Employment_details.txtsalary.Text
        lblemp_company_tell_num.Text = Employment_details.txtcompany_tell.Text


        lblcar_brand.Text = Car_details.cmbcar_brand.Text
        lblcar_name.Text = Car_details.cmbcar_name.Text
        lblcar_body_type.Text = Car_details.cmbcar_body_type.Text
        lblcar_price.Text = Car_details.txtcar_price.Text


        lblpayment_method.Text = Payment_details.cmbpayment_method.Text
        lblpayment_duration.Text = Payment_details.cmbpayment_duration.Text
        lblpayment_deposit.Text = Payment_details.txtdeposit.Text
        lblpayment_intrest_rate.Text = Payment_details.txtintrest_rate.Text
        lblpayment_insurance.Text = Payment_details.txtinsurance.Text
        lblpayment_total.Text = Payment_details.txtsum_amount.Text
        lblpayment_monthly.Text = Payment_details.txtmonthly_amount.Text



        If (lblcar_brand.Text = "Chevrolet") Then
            PictureBox2.Visible = True
            PictureBox1.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox7.Visible = False
            PictureBox9.Visible = False
            PictureBox10.Visible = False
            PictureBox6.Visible = False
            PictureBox5.Visible = False
            PictureBox8.Visible = False
        ElseIf (lblcar_brand.Text = "Honda") Then
            PictureBox5.Visible = True
            PictureBox2.Visible = False
            PictureBox1.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox7.Visible = False
            PictureBox9.Visible = False
            PictureBox10.Visible = False
            PictureBox6.Visible = False
            PictureBox8.Visible = False
        ElseIf (lblcar_brand.Text = "Nissan") Then
            PictureBox8.Visible = True
            PictureBox5.Visible = False
            PictureBox2.Visible = False
            PictureBox1.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox7.Visible = False
            PictureBox9.Visible = False
            PictureBox10.Visible = False
            PictureBox6.Visible = False
        ElseIf (lblcar_brand.Text = "Ford") Then
            PictureBox4.Visible = True
            PictureBox2.Visible = False
            PictureBox1.Visible = False
            PictureBox3.Visible = False
            PictureBox7.Visible = False
            PictureBox9.Visible = False
            PictureBox10.Visible = False
            PictureBox6.Visible = False
            PictureBox5.Visible = False
            PictureBox8.Visible = False
        ElseIf (lblcar_brand.Text = "Fiat") Then
            PictureBox3.Visible = True
            PictureBox2.Visible = False
            PictureBox1.Visible = False
            PictureBox4.Visible = False
            PictureBox7.Visible = False
            PictureBox9.Visible = False
            PictureBox10.Visible = False
            PictureBox6.Visible = False
            PictureBox5.Visible = False
            PictureBox8.Visible = False
        ElseIf (lblcar_brand.Text = "Jeep") Then
            PictureBox7.Visible = True
            PictureBox2.Visible = False
            PictureBox1.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox9.Visible = False
            PictureBox10.Visible = False
            PictureBox6.Visible = False
            PictureBox5.Visible = False
            PictureBox8.Visible = False
        ElseIf (lblcar_brand.Text = "Volkswagen") Then
            PictureBox9.Visible = True
            PictureBox2.Visible = False
            PictureBox1.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox7.Visible = False
            PictureBox10.Visible = False
            PictureBox6.Visible = False
            PictureBox5.Visible = False
            PictureBox8.Visible = False
        ElseIf (lblcar_brand.Text = "Volvo") Then
            PictureBox10.Visible = True
            PictureBox2.Visible = False
            PictureBox1.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox7.Visible = False
            PictureBox9.Visible = False
            PictureBox6.Visible = False
            PictureBox5.Visible = False
            PictureBox8.Visible = False
        ElseIf (lblcar_brand.Text = "Jaguar") Then
            PictureBox6.Visible = True
            PictureBox2.Visible = False
            PictureBox1.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox7.Visible = False
            PictureBox9.Visible = False
            PictureBox10.Visible = False
            PictureBox5.Visible = False
            PictureBox8.Visible = False
        ElseIf (lblcar_brand.Text = "Audi") Then
            PictureBox1.Visible = True
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox7.Visible = False
            PictureBox9.Visible = False
            PictureBox10.Visible = False
            PictureBox6.Visible = False
            PictureBox5.Visible = False
            PictureBox8.Visible = False
        End If
    End Sub
End Class