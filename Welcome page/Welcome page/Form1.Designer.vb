<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblheading_1 = New System.Windows.Forms.Label()
        Me.lblsub_heading = New System.Windows.Forms.Label()
        Me.rdboption_yes = New System.Windows.Forms.RadioButton()
        Me.rdboption_no = New System.Windows.Forms.RadioButton()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnnext_page = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblheading_1
        '
        Me.lblheading_1.AutoSize = True
        Me.lblheading_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblheading_1.Location = New System.Drawing.Point(42, 9)
        Me.lblheading_1.Name = "lblheading_1"
        Me.lblheading_1.Size = New System.Drawing.Size(591, 37)
        Me.lblheading_1.TabIndex = 0
        Me.lblheading_1.Text = "Welcome to Simon's Dynamic Garage"
        '
        'lblsub_heading
        '
        Me.lblsub_heading.AutoSize = True
        Me.lblsub_heading.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsub_heading.Location = New System.Drawing.Point(74, 120)
        Me.lblsub_heading.Name = "lblsub_heading"
        Me.lblsub_heading.Size = New System.Drawing.Size(536, 16)
        Me.lblsub_heading.TabIndex = 1
        Me.lblsub_heading.Text = "Would you like to get a quote on a specific car mode that you are intrested in pu" & _
    "rchasing ?"
        '
        'rdboption_yes
        '
        Me.rdboption_yes.AutoSize = True
        Me.rdboption_yes.Location = New System.Drawing.Point(164, 175)
        Me.rdboption_yes.Name = "rdboption_yes"
        Me.rdboption_yes.Size = New System.Drawing.Size(43, 17)
        Me.rdboption_yes.TabIndex = 2
        Me.rdboption_yes.TabStop = True
        Me.rdboption_yes.Text = "Yes"
        Me.rdboption_yes.UseVisualStyleBackColor = True
        '
        'rdboption_no
        '
        Me.rdboption_no.AutoSize = True
        Me.rdboption_no.Location = New System.Drawing.Point(386, 175)
        Me.rdboption_no.Name = "rdboption_no"
        Me.rdboption_no.Size = New System.Drawing.Size(39, 17)
        Me.rdboption_no.TabIndex = 3
        Me.rdboption_no.TabStop = True
        Me.rdboption_no.Text = "No"
        Me.rdboption_no.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Location = New System.Drawing.Point(149, 235)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 23)
        Me.btnclose.TabIndex = 4
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnnext_page
        '
        Me.btnnext_page.Location = New System.Drawing.Point(375, 235)
        Me.btnnext_page.Name = "btnnext_page"
        Me.btnnext_page.Size = New System.Drawing.Size(75, 23)
        Me.btnnext_page.TabIndex = 5
        Me.btnnext_page.Text = "Next form"
        Me.btnnext_page.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 270)
        Me.Controls.Add(Me.btnnext_page)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.rdboption_no)
        Me.Controls.Add(Me.rdboption_yes)
        Me.Controls.Add(Me.lblsub_heading)
        Me.Controls.Add(Me.lblheading_1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblheading_1 As System.Windows.Forms.Label
    Friend WithEvents lblsub_heading As System.Windows.Forms.Label
    Friend WithEvents rdboption_yes As System.Windows.Forms.RadioButton
    Friend WithEvents rdboption_no As System.Windows.Forms.RadioButton
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnnext_page As System.Windows.Forms.Button

End Class
