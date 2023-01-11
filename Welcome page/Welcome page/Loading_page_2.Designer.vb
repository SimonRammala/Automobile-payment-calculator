<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loading_page_2
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
        Me.components = New System.ComponentModel.Container()
        Me.lblheading = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lblprogressbar_display = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblheading
        '
        Me.lblheading.AutoSize = True
        Me.lblheading.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblheading.ForeColor = System.Drawing.Color.Red
        Me.lblheading.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblheading.Location = New System.Drawing.Point(198, 9)
        Me.lblheading.Name = "lblheading"
        Me.lblheading.Size = New System.Drawing.Size(349, 39)
        Me.lblheading.TabIndex = 0
        Me.lblheading.Text = "Loading next page..."
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(113, 157)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(520, 34)
        Me.ProgressBar1.TabIndex = 1
        '
        'lblprogressbar_display
        '
        Me.lblprogressbar_display.AutoSize = True
        Me.lblprogressbar_display.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprogressbar_display.ForeColor = System.Drawing.Color.Red
        Me.lblprogressbar_display.Location = New System.Drawing.Point(294, 249)
        Me.lblprogressbar_display.Name = "lblprogressbar_display"
        Me.lblprogressbar_display.Size = New System.Drawing.Size(0, 20)
        Me.lblprogressbar_display.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(357, 249)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "%"
        '
        'Timer1
        '
        '
        'Loading_page_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 317)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblprogressbar_display)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.lblheading)
        Me.Name = "Loading_page_2"
        Me.Text = "Loading_page_2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblheading As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents lblprogressbar_display As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
End Class
