Public Class Form1

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        'Used to close the current window
        Me.Close()
    End Sub

    Private Sub btnnext_page_Click(sender As Object, e As EventArgs) Handles btnnext_page.Click
        'used to declare a variable to call the next page
        Dim next_page As New Loading_page

        'used to check which radio button has been selected
        If (rdboption_yes.Checked = True) Then
            'used to hide the current page
            Me.Hide()
            'used to display the declared page
            next_page.Show()
        Else
            'used to display a messaage when the use selects no or non of the options
            MessageBox.Show("Thanks for coming. Hope to see you again")
            Me.Close()
        End If
    End Sub
End Class
