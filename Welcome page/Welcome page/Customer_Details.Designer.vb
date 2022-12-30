<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer_Details
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
        Me.lblheader = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblmiddel_name = New System.Windows.Forms.Label()
        Me.lblmadien_name = New System.Windows.Forms.Label()
        Me.lbldate_of_birth = New System.Windows.Forms.Label()
        Me.gpbmarital_status = New System.Windows.Forms.GroupBox()
        Me.rdbrather_not_say = New System.Windows.Forms.RadioButton()
        Me.rdbdivorced = New System.Windows.Forms.RadioButton()
        Me.rdbsingle = New System.Windows.Forms.RadioButton()
        Me.rdbmarried = New System.Windows.Forms.RadioButton()
        Me.lblage = New System.Windows.Forms.Label()
        Me.lblcell_num = New System.Windows.Forms.Label()
        Me.lblgender = New System.Windows.Forms.Label()
        Me.rpbIdenification_number = New System.Windows.Forms.GroupBox()
        Me.txtID_num = New System.Windows.Forms.TextBox()
        Me.txtpassport_num = New System.Windows.Forms.TextBox()
        Me.rdbId_num = New System.Windows.Forms.RadioButton()
        Me.rdbpassport_num = New System.Windows.Forms.RadioButton()
        Me.txtcustomer_name = New System.Windows.Forms.TextBox()
        Me.txtcustomer_surname = New System.Windows.Forms.TextBox()
        Me.txtmiddle_name = New System.Windows.Forms.TextBox()
        Me.txtmadien_name = New System.Windows.Forms.TextBox()
        Me.dtpdate_of_birth = New System.Windows.Forms.DateTimePicker()
        Me.cmbgender = New System.Windows.Forms.ComboBox()
        Me.txtcustomer_age = New System.Windows.Forms.TextBox()
        Me.txtcell_num = New System.Windows.Forms.TextBox()
        Me.btnnext_form = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.gpbmarital_status.SuspendLayout()
        Me.rpbIdenification_number.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblheader
        '
        Me.lblheader.AutoSize = True
        Me.lblheader.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblheader.Location = New System.Drawing.Point(162, 9)
        Me.lblheader.Name = "lblheader"
        Me.lblheader.Size = New System.Drawing.Size(301, 39)
        Me.lblheader.TabIndex = 0
        Me.lblheader.Text = "Customer Details"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Location = New System.Drawing.Point(51, 93)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(41, 13)
        Me.lblname.TabIndex = 1
        Me.lblname.Text = "Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Surname :"
        '
        'lblmiddel_name
        '
        Me.lblmiddel_name.AutoSize = True
        Me.lblmiddel_name.Location = New System.Drawing.Point(51, 165)
        Me.lblmiddel_name.Name = "lblmiddel_name"
        Me.lblmiddel_name.Size = New System.Drawing.Size(73, 13)
        Me.lblmiddel_name.TabIndex = 3
        Me.lblmiddel_name.Text = "Middle name :"
        '
        'lblmadien_name
        '
        Me.lblmadien_name.AutoSize = True
        Me.lblmadien_name.Location = New System.Drawing.Point(51, 196)
        Me.lblmadien_name.Name = "lblmadien_name"
        Me.lblmadien_name.Size = New System.Drawing.Size(77, 13)
        Me.lblmadien_name.TabIndex = 4
        Me.lblmadien_name.Text = "Madien name :"
        '
        'lbldate_of_birth
        '
        Me.lbldate_of_birth.AutoSize = True
        Me.lbldate_of_birth.Location = New System.Drawing.Point(51, 227)
        Me.lbldate_of_birth.Name = "lbldate_of_birth"
        Me.lbldate_of_birth.Size = New System.Drawing.Size(71, 13)
        Me.lbldate_of_birth.TabIndex = 5
        Me.lbldate_of_birth.Text = "Date of birth :"
        '
        'gpbmarital_status
        '
        Me.gpbmarital_status.Controls.Add(Me.rdbrather_not_say)
        Me.gpbmarital_status.Controls.Add(Me.rdbdivorced)
        Me.gpbmarital_status.Controls.Add(Me.rdbsingle)
        Me.gpbmarital_status.Controls.Add(Me.rdbmarried)
        Me.gpbmarital_status.Location = New System.Drawing.Point(54, 367)
        Me.gpbmarital_status.Name = "gpbmarital_status"
        Me.gpbmarital_status.Size = New System.Drawing.Size(646, 101)
        Me.gpbmarital_status.TabIndex = 6
        Me.gpbmarital_status.TabStop = False
        Me.gpbmarital_status.Text = "Marital Status"
        '
        'rdbrather_not_say
        '
        Me.rdbrather_not_say.AutoSize = True
        Me.rdbrather_not_say.Location = New System.Drawing.Point(474, 45)
        Me.rdbrather_not_say.Name = "rdbrather_not_say"
        Me.rdbrather_not_say.Size = New System.Drawing.Size(94, 17)
        Me.rdbrather_not_say.TabIndex = 3
        Me.rdbrather_not_say.TabStop = True
        Me.rdbrather_not_say.Text = "Rather not say"
        Me.rdbrather_not_say.UseVisualStyleBackColor = True
        '
        'rdbdivorced
        '
        Me.rdbdivorced.AutoSize = True
        Me.rdbdivorced.Location = New System.Drawing.Point(330, 45)
        Me.rdbdivorced.Name = "rdbdivorced"
        Me.rdbdivorced.Size = New System.Drawing.Size(68, 17)
        Me.rdbdivorced.TabIndex = 2
        Me.rdbdivorced.TabStop = True
        Me.rdbdivorced.Text = "Divorced"
        Me.rdbdivorced.UseVisualStyleBackColor = True
        '
        'rdbsingle
        '
        Me.rdbsingle.AutoSize = True
        Me.rdbsingle.Location = New System.Drawing.Point(198, 45)
        Me.rdbsingle.Name = "rdbsingle"
        Me.rdbsingle.Size = New System.Drawing.Size(54, 17)
        Me.rdbsingle.TabIndex = 1
        Me.rdbsingle.TabStop = True
        Me.rdbsingle.Text = "Single"
        Me.rdbsingle.UseVisualStyleBackColor = True
        '
        'rdbmarried
        '
        Me.rdbmarried.AutoSize = True
        Me.rdbmarried.Location = New System.Drawing.Point(38, 45)
        Me.rdbmarried.Name = "rdbmarried"
        Me.rdbmarried.Size = New System.Drawing.Size(60, 17)
        Me.rdbmarried.TabIndex = 0
        Me.rdbmarried.TabStop = True
        Me.rdbmarried.Text = "Married"
        Me.rdbmarried.UseVisualStyleBackColor = True
        '
        'lblage
        '
        Me.lblage.AutoSize = True
        Me.lblage.Location = New System.Drawing.Point(51, 297)
        Me.lblage.Name = "lblage"
        Me.lblage.Size = New System.Drawing.Size(32, 13)
        Me.lblage.TabIndex = 7
        Me.lblage.Text = "Age :"
        '
        'lblcell_num
        '
        Me.lblcell_num.AutoSize = True
        Me.lblcell_num.Location = New System.Drawing.Point(51, 328)
        Me.lblcell_num.Name = "lblcell_num"
        Me.lblcell_num.Size = New System.Drawing.Size(68, 13)
        Me.lblcell_num.TabIndex = 10
        Me.lblcell_num.Text = "Cell number :"
        '
        'lblgender
        '
        Me.lblgender.AutoSize = True
        Me.lblgender.Location = New System.Drawing.Point(51, 258)
        Me.lblgender.Name = "lblgender"
        Me.lblgender.Size = New System.Drawing.Size(48, 13)
        Me.lblgender.TabIndex = 11
        Me.lblgender.Text = "Gender :"
        '
        'rpbIdenification_number
        '
        Me.rpbIdenification_number.Controls.Add(Me.txtID_num)
        Me.rpbIdenification_number.Controls.Add(Me.txtpassport_num)
        Me.rpbIdenification_number.Controls.Add(Me.rdbId_num)
        Me.rpbIdenification_number.Controls.Add(Me.rdbpassport_num)
        Me.rpbIdenification_number.Location = New System.Drawing.Point(54, 488)
        Me.rpbIdenification_number.Name = "rpbIdenification_number"
        Me.rpbIdenification_number.Size = New System.Drawing.Size(646, 110)
        Me.rpbIdenification_number.TabIndex = 12
        Me.rpbIdenification_number.TabStop = False
        Me.rpbIdenification_number.Text = "Idenification number"
        '
        'txtID_num
        '
        Me.txtID_num.Enabled = False
        Me.txtID_num.Location = New System.Drawing.Point(340, 65)
        Me.txtID_num.Name = "txtID_num"
        Me.txtID_num.Size = New System.Drawing.Size(167, 20)
        Me.txtID_num.TabIndex = 3
        '
        'txtpassport_num
        '
        Me.txtpassport_num.Enabled = False
        Me.txtpassport_num.Location = New System.Drawing.Point(38, 65)
        Me.txtpassport_num.Name = "txtpassport_num"
        Me.txtpassport_num.Size = New System.Drawing.Size(186, 20)
        Me.txtpassport_num.TabIndex = 2
        '
        'rdbId_num
        '
        Me.rdbId_num.AutoSize = True
        Me.rdbId_num.Location = New System.Drawing.Point(319, 30)
        Me.rdbId_num.Name = "rdbId_num"
        Me.rdbId_num.Size = New System.Drawing.Size(74, 17)
        Me.rdbId_num.TabIndex = 1
        Me.rdbId_num.TabStop = True
        Me.rdbId_num.Text = "ID number"
        Me.rdbId_num.UseVisualStyleBackColor = True
        '
        'rdbpassport_num
        '
        Me.rdbpassport_num.AutoSize = True
        Me.rdbpassport_num.Location = New System.Drawing.Point(18, 29)
        Me.rdbpassport_num.Name = "rdbpassport_num"
        Me.rdbpassport_num.Size = New System.Drawing.Size(104, 17)
        Me.rdbpassport_num.TabIndex = 0
        Me.rdbpassport_num.TabStop = True
        Me.rdbpassport_num.Text = "Passport number"
        Me.rdbpassport_num.UseVisualStyleBackColor = True
        '
        'txtcustomer_name
        '
        Me.txtcustomer_name.Location = New System.Drawing.Point(169, 85)
        Me.txtcustomer_name.Name = "txtcustomer_name"
        Me.txtcustomer_name.Size = New System.Drawing.Size(200, 20)
        Me.txtcustomer_name.TabIndex = 13
        '
        'txtcustomer_surname
        '
        Me.txtcustomer_surname.Location = New System.Drawing.Point(169, 119)
        Me.txtcustomer_surname.Name = "txtcustomer_surname"
        Me.txtcustomer_surname.Size = New System.Drawing.Size(200, 20)
        Me.txtcustomer_surname.TabIndex = 14
        '
        'txtmiddle_name
        '
        Me.txtmiddle_name.Location = New System.Drawing.Point(169, 157)
        Me.txtmiddle_name.Name = "txtmiddle_name"
        Me.txtmiddle_name.Size = New System.Drawing.Size(200, 20)
        Me.txtmiddle_name.TabIndex = 15
        '
        'txtmadien_name
        '
        Me.txtmadien_name.Location = New System.Drawing.Point(169, 188)
        Me.txtmadien_name.Name = "txtmadien_name"
        Me.txtmadien_name.Size = New System.Drawing.Size(200, 20)
        Me.txtmadien_name.TabIndex = 16
        '
        'dtpdate_of_birth
        '
        Me.dtpdate_of_birth.Location = New System.Drawing.Point(169, 219)
        Me.dtpdate_of_birth.Name = "dtpdate_of_birth"
        Me.dtpdate_of_birth.Size = New System.Drawing.Size(200, 20)
        Me.dtpdate_of_birth.TabIndex = 17
        '
        'cmbgender
        '
        Me.cmbgender.FormattingEnabled = True
        Me.cmbgender.Items.AddRange(New Object() {"Male", "Female", "Transgender", "Gender neutral", "Non-binary", "Agender", "Pangender", "Genderqueer"})
        Me.cmbgender.Location = New System.Drawing.Point(169, 249)
        Me.cmbgender.Name = "cmbgender"
        Me.cmbgender.Size = New System.Drawing.Size(200, 21)
        Me.cmbgender.TabIndex = 18
        '
        'txtcustomer_age
        '
        Me.txtcustomer_age.Location = New System.Drawing.Point(169, 290)
        Me.txtcustomer_age.Name = "txtcustomer_age"
        Me.txtcustomer_age.Size = New System.Drawing.Size(200, 20)
        Me.txtcustomer_age.TabIndex = 19
        '
        'txtcell_num
        '
        Me.txtcell_num.Location = New System.Drawing.Point(169, 321)
        Me.txtcell_num.Name = "txtcell_num"
        Me.txtcell_num.Size = New System.Drawing.Size(200, 20)
        Me.txtcell_num.TabIndex = 20
        '
        'btnnext_form
        '
        Me.btnnext_form.Location = New System.Drawing.Point(129, 617)
        Me.btnnext_form.Name = "btnnext_form"
        Me.btnnext_form.Size = New System.Drawing.Size(94, 23)
        Me.btnnext_form.TabIndex = 21
        Me.btnnext_form.Text = "Next Form"
        Me.btnnext_form.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(275, 617)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(94, 23)
        Me.btnclear.TabIndex = 22
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(447, 617)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(94, 23)
        Me.btnexit.TabIndex = 23
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'Customer_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 652)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnnext_form)
        Me.Controls.Add(Me.txtcell_num)
        Me.Controls.Add(Me.txtcustomer_age)
        Me.Controls.Add(Me.cmbgender)
        Me.Controls.Add(Me.dtpdate_of_birth)
        Me.Controls.Add(Me.txtmadien_name)
        Me.Controls.Add(Me.txtmiddle_name)
        Me.Controls.Add(Me.txtcustomer_surname)
        Me.Controls.Add(Me.txtcustomer_name)
        Me.Controls.Add(Me.rpbIdenification_number)
        Me.Controls.Add(Me.lblgender)
        Me.Controls.Add(Me.lblcell_num)
        Me.Controls.Add(Me.lblage)
        Me.Controls.Add(Me.gpbmarital_status)
        Me.Controls.Add(Me.lbldate_of_birth)
        Me.Controls.Add(Me.lblmadien_name)
        Me.Controls.Add(Me.lblmiddel_name)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.lblheader)
        Me.Name = "Customer_Details"
        Me.Text = "Customer_Details"
        Me.gpbmarital_status.ResumeLayout(False)
        Me.gpbmarital_status.PerformLayout()
        Me.rpbIdenification_number.ResumeLayout(False)
        Me.rpbIdenification_number.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblheader As System.Windows.Forms.Label
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblmiddel_name As System.Windows.Forms.Label
    Friend WithEvents lblmadien_name As System.Windows.Forms.Label
    Friend WithEvents lbldate_of_birth As System.Windows.Forms.Label
    Friend WithEvents gpbmarital_status As System.Windows.Forms.GroupBox
    Friend WithEvents rdbrather_not_say As System.Windows.Forms.RadioButton
    Friend WithEvents rdbdivorced As System.Windows.Forms.RadioButton
    Friend WithEvents rdbsingle As System.Windows.Forms.RadioButton
    Friend WithEvents rdbmarried As System.Windows.Forms.RadioButton
    Friend WithEvents lblage As System.Windows.Forms.Label
    Friend WithEvents lblcell_num As System.Windows.Forms.Label
    Friend WithEvents lblgender As System.Windows.Forms.Label
    Friend WithEvents rpbIdenification_number As System.Windows.Forms.GroupBox
    Friend WithEvents txtID_num As System.Windows.Forms.TextBox
    Friend WithEvents txtpassport_num As System.Windows.Forms.TextBox
    Friend WithEvents rdbId_num As System.Windows.Forms.RadioButton
    Friend WithEvents rdbpassport_num As System.Windows.Forms.RadioButton
    Friend WithEvents txtcustomer_name As System.Windows.Forms.TextBox
    Friend WithEvents txtcustomer_surname As System.Windows.Forms.TextBox
    Friend WithEvents txtmiddle_name As System.Windows.Forms.TextBox
    Friend WithEvents txtmadien_name As System.Windows.Forms.TextBox
    Friend WithEvents dtpdate_of_birth As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbgender As System.Windows.Forms.ComboBox
    Friend WithEvents txtcustomer_age As System.Windows.Forms.TextBox
    Friend WithEvents txtcell_num As System.Windows.Forms.TextBox
    Friend WithEvents btnnext_form As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
End Class
