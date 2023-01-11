Public Class Loading_page

    Private Sub Loading_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'used to call the next page
        Dim next_form As New Customer_Details

        If (ProgressBar1.Value <= ProgressBar1.Maximum - 1) Then
            ProgressBar1.Value += 1
            lblpercentage_display.Text = ProgressBar1.Value
        Else
            Me.Hide()
            next_form.Show()
            Timer1.Enabled = False
        End If



    End Sub

End Class