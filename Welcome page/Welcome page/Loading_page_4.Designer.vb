<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loading_page_4
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
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lblheader = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblpercentage_display = New System.Windows.Forms.Label()
        Me.lblperctage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(108, 119)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(605, 46)
        Me.ProgressBar1.TabIndex = 0
        '
        'lblheader
        '
        Me.lblheader.AutoSize = True
        Me.lblheader.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblheader.ForeColor = System.Drawing.Color.Red
        Me.lblheader.Location = New System.Drawing.Point(243, 9)
        Me.lblheader.Name = "lblheader"
        Me.lblheader.Size = New System.Drawing.Size(273, 39)
        Me.lblheader.TabIndex = 1
        Me.lblheader.Text = "Loading Page..."
        '
        'Timer1
        '
        '
        'lblpercentage_display
        '
        Me.lblpercentage_display.AutoSize = True
        Me.lblpercentage_display.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpercentage_display.ForeColor = System.Drawing.Color.Red
        Me.lblpercentage_display.Location = New System.Drawing.Point(292, 204)
        Me.lblpercentage_display.Name = "lblpercentage_display"
        Me.lblpercentage_display.Size = New System.Drawing.Size(0, 25)
        Me.lblpercentage_display.TabIndex = 2
        '
        'lblperctage
        '
        Me.lblperctage.AutoSize = True
        Me.lblperctage.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblperctage.ForeColor = System.Drawing.Color.Red
        Me.lblperctage.Location = New System.Drawing.Point(391, 204)
        Me.lblperctage.Name = "lblperctage"
        Me.lblperctage.Size = New System.Drawing.Size(31, 25)
        Me.lblperctage.TabIndex = 3
        Me.lblperctage.Text = "%"
        '
        'Loading_page_4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 327)
        Me.Controls.Add(Me.lblperctage)
        Me.Controls.Add(Me.lblpercentage_display)
        Me.Controls.Add(Me.lblheader)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Name = "Loading_page_4"
        Me.Text = "Loading_page4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblheader As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblpercentage_display As System.Windows.Forms.Label
    Friend WithEvents lblperctage As System.Windows.Forms.Label
End Class
