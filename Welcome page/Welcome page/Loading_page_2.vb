﻿Public Class Loading_page_2
    Private Sub Loading_page_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'used to call the next page 

        If (ProgressBar1.Value <= ProgressBar1.Maximum - 1) Then
            ProgressBar1.Value += 1
            lblprogressbar_display.Text = ProgressBar1.Value
        Else
            Me.Hide()
            Employment_details.Show()
            Timer1.Enabled = False
        End If
    End Sub
End Class