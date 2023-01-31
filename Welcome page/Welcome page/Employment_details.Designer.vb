<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employment_details
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
        Me.lblheading = New System.Windows.Forms.Label()
        Me.lblcompany = New System.Windows.Forms.Label()
        Me.lblocupation = New System.Windows.Forms.Label()
        Me.lblsalary = New System.Windows.Forms.Label()
        Me.lblcompany_tell_num = New System.Windows.Forms.Label()
        Me.txtcompany_name = New System.Windows.Forms.TextBox()
        Me.txtocupation = New System.Windows.Forms.TextBox()
        Me.txtsalary = New System.Windows.Forms.TextBox()
        Me.txtcompany_tell = New System.Windows.Forms.TextBox()
        Me.btnnext_form = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblheading
        '
        Me.lblheading.AutoSize = True
        Me.lblheading.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblheading.Location = New System.Drawing.Point(130, 9)
        Me.lblheading.Name = "lblheading"
        Me.lblheading.Size = New System.Drawing.Size(346, 39)
        Me.lblheading.TabIndex = 0
        Me.lblheading.Text = "Employment Details"
        '
        'lblcompany
        '
        Me.lblcompany.AutoSize = True
        Me.lblcompany.Location = New System.Drawing.Point(52, 96)
        Me.lblcompany.Name = "lblcompany"
        Me.lblcompany.Size = New System.Drawing.Size(86, 13)
        Me.lblcompany.TabIndex = 1
        Me.lblcompany.Text = "Company name :"
        '
        'lblocupation
        '
        Me.lblocupation.AutoSize = True
        Me.lblocupation.Location = New System.Drawing.Point(52, 137)
        Me.lblocupation.Name = "lblocupation"
        Me.lblocupation.Size = New System.Drawing.Size(120, 13)
        Me.lblocupation.TabIndex = 2
        Me.lblocupation.Text = "Ocupation at company :"
        '
        'lblsalary
        '
        Me.lblsalary.AutoSize = True
        Me.lblsalary.Location = New System.Drawing.Point(52, 193)
        Me.lblsalary.Name = "lblsalary"
        Me.lblsalary.Size = New System.Drawing.Size(72, 13)
        Me.lblsalary.TabIndex = 3
        Me.lblsalary.Text = "Yearly salary :"
        '
        'lblcompany_tell_num
        '
        Me.lblcompany_tell_num.AutoSize = True
        Me.lblcompany_tell_num.Location = New System.Drawing.Point(55, 238)
        Me.lblcompany_tell_num.Name = "lblcompany_tell_num"
        Me.lblcompany_tell_num.Size = New System.Drawing.Size(111, 13)
        Me.lblcompany_tell_num.TabIndex = 4
        Me.lblcompany_tell_num.Text = "Company tell number :"
        '
        'txtcompany_name
        '
        Me.txtcompany_name.Location = New System.Drawing.Point(206, 89)
        Me.txtcompany_name.Name = "txtcompany_name"
        Me.txtcompany_name.Size = New System.Drawing.Size(222, 20)
        Me.txtcompany_name.TabIndex = 5
        '
        'txtocupation
        '
        Me.txtocupation.Location = New System.Drawing.Point(206, 130)
        Me.txtocupation.Name = "txtocupation"
        Me.txtocupation.Size = New System.Drawing.Size(222, 20)
        Me.txtocupation.TabIndex = 6
        '
        'txtsalary
        '
        Me.txtsalary.Location = New System.Drawing.Point(248, 186)
        Me.txtsalary.Name = "txtsalary"
        Me.txtsalary.Size = New System.Drawing.Size(180, 20)
        Me.txtsalary.TabIndex = 7
        '
        'txtcompany_tell
        '
        Me.txtcompany_tell.Location = New System.Drawing.Point(206, 231)
        Me.txtcompany_tell.Name = "txtcompany_tell"
        Me.txtcompany_tell.Size = New System.Drawing.Size(222, 20)
        Me.txtcompany_tell.TabIndex = 8
        '
        'btnnext_form
        '
        Me.btnnext_form.Location = New System.Drawing.Point(91, 291)
        Me.btnnext_form.Name = "btnnext_form"
        Me.btnnext_form.Size = New System.Drawing.Size(75, 23)
        Me.btnnext_form.TabIndex = 9
        Me.btnnext_form.Text = "Next Form"
        Me.btnnext_form.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(301, 291)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(75, 23)
        Me.btnclear.TabIndex = 10
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(510, 291)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 23)
        Me.btnexit.TabIndex = 11
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(206, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "ZAR"
        '
        'Employment_details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 326)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnnext_form)
        Me.Controls.Add(Me.txtcompany_tell)
        Me.Controls.Add(Me.txtsalary)
        Me.Controls.Add(Me.txtocupation)
        Me.Controls.Add(Me.txtcompany_name)
        Me.Controls.Add(Me.lblcompany_tell_num)
        Me.Controls.Add(Me.lblsalary)
        Me.Controls.Add(Me.lblocupation)
        Me.Controls.Add(Me.lblcompany)
        Me.Controls.Add(Me.lblheading)
        Me.Name = "Employment_details"
        Me.Text = "Employment_details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblheading As System.Windows.Forms.Label
    Friend WithEvents lblcompany As System.Windows.Forms.Label
    Friend WithEvents lblocupation As System.Windows.Forms.Label
    Friend WithEvents lblsalary As System.Windows.Forms.Label
    Friend WithEvents lblcompany_tell_num As System.Windows.Forms.Label
    Friend WithEvents txtcompany_name As System.Windows.Forms.TextBox
    Friend WithEvents txtocupation As System.Windows.Forms.TextBox
    Friend WithEvents txtsalary As System.Windows.Forms.TextBox
    Friend WithEvents txtcompany_tell As System.Windows.Forms.TextBox
    Friend WithEvents btnnext_form As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label
End Class
