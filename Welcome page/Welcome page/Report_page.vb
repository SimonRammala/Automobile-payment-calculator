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


    End Sub
End Class