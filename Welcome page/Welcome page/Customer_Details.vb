Public Class Customer_Details

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub btnnext_form_Click(sender As Object, e As EventArgs) Handles btnnext_form.Click
        Dim customer_name As String
        Dim customer_surname As String
        Dim customer_middle_name As String
        Dim customer_madien_name As String
        Dim customer_date_of_birth As String
        Dim customer_gender As String
        Dim customer_age As Integer
        Dim customer_cell As Integer
        Dim customer_marital_status As String
        Dim customer_idenification_number As String

        'used to holde the information or data entered by the end-user
        customer_name = txtcustomer_name.Text
        customer_surname = txtcustomer_surname.Text
        customer_middle_name = txtmiddle_name.Text
        customer_madien_name = txtmadien_name.Text
        customer_date_of_birth = dtpdate_of_birth.Text
        customer_gender = ""
        customer_marital_status = ""
        customer_idenification_number = ""

        'used to check if the data-type entered by the end-user is the same as the declare date-type
        Try
            customer_cell = txtcell_num.Text
        Catch ex As Exception
            MessageBox.Show("You have entered a invalide cell phone number")
        End Try

        Try
            customer_age = txtcustomer_age.Text
        Catch ex As Exception
            MessageBox.Show("You have entered an invailde age")
        End Try

        'used to store te selected gender of the end-user
        If (cmbgender.Text = "Male") Then
            customer_gender = "Male"
        ElseIf (cmbgender.Text = "Female") Then
            customer_gender = "Female"
        ElseIf (cmbgender.Text = "Transgender") Then
            customer_gender = "Transgender"
        ElseIf (cmbgender.Text = "Gender neutral") Then
            customer_gender = "Gender neutral"
        ElseIf (cmbgender.Text = "Non-binary") Then
            customer_gender = "Non-binary"
        ElseIf (cmbgender.Text = "Agender") Then
            customer_gender = "Agender"
        ElseIf (cmbgender.Text = "Pangender") Then
            customer_gender = "Pangender"
        ElseIf (cmbgender.Text = "Genderqueer") Then
            customer_gender = "Genderqueer"
        Else
            MessageBox.Show("You have not selected a specific gender")
        End If


        'used to store the marital status of the end-user
        If (rdbmarried.Checked = True) Then
            customer_marital_status = "Married"
        ElseIf (rdbdivorced.Checked = True) Then
            customer_marital_status = "Divorced"
        ElseIf (rdbsingle.Checked = True) Then
            customer_marital_status = "Single"
        ElseIf (rdbrather_not_say.Checked = True) Then
            customer_marital_status = "Rather not say"
        Else
            MessageBox.Show("You have not selected a specific marital status")
        End If

        'used to check which option is slected by the end-user, so the information can be stored on the variable
        If (rdbpassport_num.Checked = True) Then
            customer_idenification_number = txtpassport_num.Text
        ElseIf (rdbId_num.Checked = True) Then
            customer_idenification_number = txtID_num.Text
        End If

        'used to call the next form 
        Dim next_page As New Loading_page_2

        'use to validate the text areas to make sure if every questions have been completed
        If (customer_name = "" Or customer_surname = "" Or customer_middle_name = "" Or customer_madien_name = "" Or customer_date_of_birth = "" Or customer_gender = "" Or customer_age.ToString = "" Or customer_cell.ToString = "" Or customer_marital_status = "" Or customer_idenification_number.ToString = "") Then
            MessageBox.Show("You have not entered some of the information")
        Else
            Me.Hide()
            next_page.Show()
        End If

        'used to add the following options to the combox on the Payment Details page
        If (customer_age < 21) Then
            Payment_details.cmbpayment_method.Items.Clear()
            Payment_details.cmbpayment_method.Items.Add("Cash")
        Else
            Payment_details.cmbpayment_method.Items.Clear()
            Payment_details.cmbpayment_method.Items.Add("Cash")
            Payment_details.cmbpayment_method.Items.Add("Instalment")
        End If

    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        'used to remove anything that is typed on the text box's
        txtcustomer_name.Clear()
        txtcustomer_surname.Clear()
        txtcell_num.Clear()
        txtcustomer_age.Clear()
        txtcustomer_age.Clear()
        txtID_num.Clear()
        txtmadien_name.Clear()
        txtmiddle_name.Clear()
    End Sub

    Private Sub rdbId_num_CheckedChanged(sender As Object, e As EventArgs) Handles rdbId_num.CheckedChanged
        'used to  enable the textbox if the user wants to enter information on it
        If (rdbId_num.Checked = True) Then
            txtID_num.Enabled = True
        Else
            txtID_num.Enabled = False
        End If
    End Sub

    Private Sub rdbpassport_num_CheckedChanged(sender As Object, e As EventArgs) Handles rdbpassport_num.CheckedChanged
        'used to  enable the textbox if the user wants to enter information on it
        If (rdbpassport_num.Checked = True) Then
            txtpassport_num.Enabled = True
        Else
            txtpassport_num.Enabled = False
        End If
    End Sub
End Class