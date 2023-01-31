Public Class Employment_details

    Private Sub btnnext_form_Click(sender As Object, e As EventArgs) Handles btnnext_form.Click
        'used to declare a variable to store the data
        Dim company_name As String
        Dim ocupation As String
        Dim yearly_salary As Integer
        Dim company_tell_num As Integer

        'used to link the variable to a textbox to store the information 
        company_name = txtcompany_name.Text
        ocupation = txtocupation.Text
        'used to check if the data entered by the end-user is in the formate
        Try
            yearly_salary = txtsalary.Text
        Catch ex As Exception
            MessageBox.Show("You have entered a invalide salary type")
        End Try
        Try
            company_tell_num = txtcompany_tell.Text
        Catch ex As Exception
            MessageBox.Show("You have entered an invalide tell number")
        End Try

        'used to decalare a variable that will call a new page
        Dim next_page As New Loading_page_3

        'used to validate the page befor it opens the next page
        If (ocupation = "" Or yearly_salary.ToString = "" Or company_tell_num.ToString = "") Then
            MessageBox.Show("You have not entered all the information")
        Else
            Me.Hide()
            next_page.Show()
        End If

    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        'used to exit the current page
        MessageBox.Show("Thanks for coming. Hope to see you again")
        Me.Close()
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtcompany_name.Clear()
        txtcompany_tell.Clear()
        txtocupation.Clear()
        txtsalary.Clear()
    End Sub
End Class