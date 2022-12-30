<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payment_details
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbpayment_method = New System.Windows.Forms.ComboBox()
        Me.cmbpayment_duration = New System.Windows.Forms.ComboBox()
        Me.txtdeposit = New System.Windows.Forms.TextBox()
        Me.txtintrest_rate = New System.Windows.Forms.TextBox()
        Me.txtinsurance = New System.Windows.Forms.TextBox()
        Me.txtsum_amount = New System.Windows.Forms.TextBox()
        Me.txtmonthly_amount = New System.Windows.Forms.TextBox()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btndisplay_report = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(254, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(286, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Payment Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Payment method:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Payment duration:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Deposit:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Intrest rate:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 227)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Insurance:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(38, 260)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Total payment:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(40, 299)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Monthly payment:"
        '
        'cmbpayment_method
        '
        Me.cmbpayment_method.FormattingEnabled = True
        Me.cmbpayment_method.Location = New System.Drawing.Point(198, 78)
        Me.cmbpayment_method.Name = "cmbpayment_method"
        Me.cmbpayment_method.Size = New System.Drawing.Size(167, 21)
        Me.cmbpayment_method.TabIndex = 8
        '
        'cmbpayment_duration
        '
        Me.cmbpayment_duration.FormattingEnabled = True
        Me.cmbpayment_duration.Location = New System.Drawing.Point(198, 112)
        Me.cmbpayment_duration.Name = "cmbpayment_duration"
        Me.cmbpayment_duration.Size = New System.Drawing.Size(167, 21)
        Me.cmbpayment_duration.TabIndex = 9
        '
        'txtdeposit
        '
        Me.txtdeposit.Enabled = False
        Me.txtdeposit.Location = New System.Drawing.Point(198, 149)
        Me.txtdeposit.Name = "txtdeposit"
        Me.txtdeposit.Size = New System.Drawing.Size(167, 20)
        Me.txtdeposit.TabIndex = 10
        '
        'txtintrest_rate
        '
        Me.txtintrest_rate.Enabled = False
        Me.txtintrest_rate.Location = New System.Drawing.Point(198, 182)
        Me.txtintrest_rate.Name = "txtintrest_rate"
        Me.txtintrest_rate.Size = New System.Drawing.Size(167, 20)
        Me.txtintrest_rate.TabIndex = 11
        '
        'txtinsurance
        '
        Me.txtinsurance.Enabled = False
        Me.txtinsurance.Location = New System.Drawing.Point(198, 219)
        Me.txtinsurance.Name = "txtinsurance"
        Me.txtinsurance.Size = New System.Drawing.Size(167, 20)
        Me.txtinsurance.TabIndex = 12
        '
        'txtsum_amount
        '
        Me.txtsum_amount.Enabled = False
        Me.txtsum_amount.Location = New System.Drawing.Point(198, 252)
        Me.txtsum_amount.Name = "txtsum_amount"
        Me.txtsum_amount.Size = New System.Drawing.Size(167, 20)
        Me.txtsum_amount.TabIndex = 13
        '
        'txtmonthly_amount
        '
        Me.txtmonthly_amount.Enabled = False
        Me.txtmonthly_amount.Location = New System.Drawing.Point(198, 291)
        Me.txtmonthly_amount.Name = "txtmonthly_amount"
        Me.txtmonthly_amount.Size = New System.Drawing.Size(167, 20)
        Me.txtmonthly_amount.TabIndex = 14
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(169, 353)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(75, 23)
        Me.btnclear.TabIndex = 15
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btndisplay_report
        '
        Me.btndisplay_report.Location = New System.Drawing.Point(465, 353)
        Me.btndisplay_report.Name = "btndisplay_report"
        Me.btndisplay_report.Size = New System.Drawing.Size(96, 23)
        Me.btndisplay_report.TabIndex = 17
        Me.btndisplay_report.Text = "Display Report"
        Me.btndisplay_report.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(150, 147)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 20)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "ZAR"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(150, 182)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 20)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "ZAR"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(150, 217)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 20)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "ZAR"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(151, 252)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 20)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "ZAR"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(150, 289)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 20)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "ZAR"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(380, 110)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 20)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "Months"
        '
        'Payment_details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 405)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btndisplay_report)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.txtmonthly_amount)
        Me.Controls.Add(Me.txtsum_amount)
        Me.Controls.Add(Me.txtinsurance)
        Me.Controls.Add(Me.txtintrest_rate)
        Me.Controls.Add(Me.txtdeposit)
        Me.Controls.Add(Me.cmbpayment_duration)
        Me.Controls.Add(Me.cmbpayment_method)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Payment_details"
        Me.Text = "Payment_details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbpayment_method As System.Windows.Forms.ComboBox
    Friend WithEvents cmbpayment_duration As System.Windows.Forms.ComboBox
    Friend WithEvents txtdeposit As System.Windows.Forms.TextBox
    Friend WithEvents txtintrest_rate As System.Windows.Forms.TextBox
    Friend WithEvents txtinsurance As System.Windows.Forms.TextBox
    Friend WithEvents txtsum_amount As System.Windows.Forms.TextBox
    Friend WithEvents txtmonthly_amount As System.Windows.Forms.TextBox
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btndisplay_report As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
