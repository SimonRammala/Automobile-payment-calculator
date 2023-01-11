<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Car_details
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Car_details))
        Me.lblheader = New System.Windows.Forms.Label()
        Me.lblcar_brand = New System.Windows.Forms.Label()
        Me.lblcar_name = New System.Windows.Forms.Label()
        Me.lblcar_model = New System.Windows.Forms.Label()
        Me.lblcar_price = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ckbautomatic_emergency = New System.Windows.Forms.CheckBox()
        Me.ckblane_centering = New System.Windows.Forms.CheckBox()
        Me.ckblane_keep = New System.Windows.Forms.CheckBox()
        Me.ckblane_departure = New System.Windows.Forms.CheckBox()
        Me.ckbblind_spot = New System.Windows.Forms.CheckBox()
        Me.ckbforward_collision = New System.Windows.Forms.CheckBox()
        Me.cmbcar_brand = New System.Windows.Forms.ComboBox()
        Me.cmbcar_name = New System.Windows.Forms.ComboBox()
        Me.cmbcar_body_type = New System.Windows.Forms.ComboBox()
        Me.btnback = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btn_nextform = New System.Windows.Forms.Button()
        Me.txtcar_price = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picchevrolet = New System.Windows.Forms.PictureBox()
        Me.picaudi = New System.Windows.Forms.PictureBox()
        Me.picfiat = New System.Windows.Forms.PictureBox()
        Me.picford = New System.Windows.Forms.PictureBox()
        Me.pichonda = New System.Windows.Forms.PictureBox()
        Me.picjaguar = New System.Windows.Forms.PictureBox()
        Me.picjeep = New System.Windows.Forms.PictureBox()
        Me.picnissan = New System.Windows.Forms.PictureBox()
        Me.picvolkswagen = New System.Windows.Forms.PictureBox()
        Me.picvolvo = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picchevrolet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picaudi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picfiat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picford, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pichonda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picjaguar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picjeep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picnissan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picvolkswagen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picvolvo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblheader
        '
        Me.lblheader.AutoSize = True
        Me.lblheader.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblheader.Location = New System.Drawing.Point(236, 9)
        Me.lblheader.Name = "lblheader"
        Me.lblheader.Size = New System.Drawing.Size(200, 39)
        Me.lblheader.TabIndex = 0
        Me.lblheader.Text = "Car Details"
        '
        'lblcar_brand
        '
        Me.lblcar_brand.AutoSize = True
        Me.lblcar_brand.Location = New System.Drawing.Point(68, 89)
        Me.lblcar_brand.Name = "lblcar_brand"
        Me.lblcar_brand.Size = New System.Drawing.Size(60, 13)
        Me.lblcar_brand.TabIndex = 1
        Me.lblcar_brand.Text = "Car Brand :"
        '
        'lblcar_name
        '
        Me.lblcar_name.AutoSize = True
        Me.lblcar_name.Location = New System.Drawing.Point(68, 130)
        Me.lblcar_name.Name = "lblcar_name"
        Me.lblcar_name.Size = New System.Drawing.Size(57, 13)
        Me.lblcar_name.TabIndex = 2
        Me.lblcar_name.Text = "Car Name:"
        '
        'lblcar_model
        '
        Me.lblcar_model.AutoSize = True
        Me.lblcar_model.Location = New System.Drawing.Point(68, 174)
        Me.lblcar_model.Name = "lblcar_model"
        Me.lblcar_model.Size = New System.Drawing.Size(76, 13)
        Me.lblcar_model.TabIndex = 3
        Me.lblcar_model.Text = "Car Body type:"
        '
        'lblcar_price
        '
        Me.lblcar_price.AutoSize = True
        Me.lblcar_price.Location = New System.Drawing.Point(68, 218)
        Me.lblcar_price.Name = "lblcar_price"
        Me.lblcar_price.Size = New System.Drawing.Size(53, 13)
        Me.lblcar_price.TabIndex = 4
        Me.lblcar_price.Text = "Car Price:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ckbautomatic_emergency)
        Me.GroupBox1.Controls.Add(Me.ckblane_centering)
        Me.GroupBox1.Controls.Add(Me.ckblane_keep)
        Me.GroupBox1.Controls.Add(Me.ckblane_departure)
        Me.GroupBox1.Controls.Add(Me.ckbblind_spot)
        Me.GroupBox1.Controls.Add(Me.ckbforward_collision)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(31, 292)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(634, 100)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Additional Features"
        '
        'ckbautomatic_emergency
        '
        Me.ckbautomatic_emergency.AutoSize = True
        Me.ckbautomatic_emergency.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbautomatic_emergency.Location = New System.Drawing.Point(374, 66)
        Me.ckbautomatic_emergency.Name = "ckbautomatic_emergency"
        Me.ckbautomatic_emergency.Size = New System.Drawing.Size(168, 17)
        Me.ckbautomatic_emergency.TabIndex = 5
        Me.ckbautomatic_emergency.Text = "Automatic Emergency Braking"
        Me.ckbautomatic_emergency.UseVisualStyleBackColor = True
        '
        'ckblane_centering
        '
        Me.ckblane_centering.AutoSize = True
        Me.ckblane_centering.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckblane_centering.Location = New System.Drawing.Point(374, 45)
        Me.ckblane_centering.Name = "ckblane_centering"
        Me.ckblane_centering.Size = New System.Drawing.Size(128, 17)
        Me.ckblane_centering.TabIndex = 4
        Me.ckblane_centering.Text = "Lane-Centering Assist"
        Me.ckblane_centering.UseVisualStyleBackColor = True
        '
        'ckblane_keep
        '
        Me.ckblane_keep.AutoSize = True
        Me.ckblane_keep.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckblane_keep.Location = New System.Drawing.Point(214, 68)
        Me.ckblane_keep.Name = "ckblane_keep"
        Me.ckblane_keep.Size = New System.Drawing.Size(108, 17)
        Me.ckblane_keep.TabIndex = 3
        Me.ckblane_keep.Text = "Lane Keep Assist"
        Me.ckblane_keep.UseVisualStyleBackColor = True
        '
        'ckblane_departure
        '
        Me.ckblane_departure.AutoSize = True
        Me.ckblane_departure.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckblane_departure.Location = New System.Drawing.Point(214, 45)
        Me.ckblane_departure.Name = "ckblane_departure"
        Me.ckblane_departure.Size = New System.Drawing.Size(143, 17)
        Me.ckblane_departure.TabIndex = 2
        Me.ckblane_departure.Text = "Lane Departure Warning"
        Me.ckblane_departure.UseVisualStyleBackColor = True
        '
        'ckbblind_spot
        '
        Me.ckbblind_spot.AutoSize = True
        Me.ckbblind_spot.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbblind_spot.Location = New System.Drawing.Point(40, 68)
        Me.ckbblind_spot.Name = "ckbblind_spot"
        Me.ckbblind_spot.Size = New System.Drawing.Size(126, 17)
        Me.ckbblind_spot.TabIndex = 1
        Me.ckbblind_spot.Text = "Blind Spot Monitoring"
        Me.ckbblind_spot.UseVisualStyleBackColor = True
        '
        'ckbforward_collision
        '
        Me.ckbforward_collision.AutoSize = True
        Me.ckbforward_collision.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbforward_collision.Location = New System.Drawing.Point(40, 45)
        Me.ckbforward_collision.Name = "ckbforward_collision"
        Me.ckbforward_collision.Size = New System.Drawing.Size(148, 17)
        Me.ckbforward_collision.TabIndex = 0
        Me.ckbforward_collision.Text = "Forward Collision Warning"
        Me.ckbforward_collision.UseVisualStyleBackColor = True
        '
        'cmbcar_brand
        '
        Me.cmbcar_brand.FormattingEnabled = True
        Me.cmbcar_brand.Items.AddRange(New Object() {"Chevrolet", "Honda", "Nissan", "Ford", "Fiat", "Jeep", "Volkswagen", "Volvo", "Jaguar", "Audi"})
        Me.cmbcar_brand.Location = New System.Drawing.Point(188, 86)
        Me.cmbcar_brand.Name = "cmbcar_brand"
        Me.cmbcar_brand.Size = New System.Drawing.Size(121, 21)
        Me.cmbcar_brand.TabIndex = 6
        '
        'cmbcar_name
        '
        Me.cmbcar_name.FormattingEnabled = True
        Me.cmbcar_name.Location = New System.Drawing.Point(188, 122)
        Me.cmbcar_name.Name = "cmbcar_name"
        Me.cmbcar_name.Size = New System.Drawing.Size(121, 21)
        Me.cmbcar_name.TabIndex = 7
        '
        'cmbcar_body_type
        '
        Me.cmbcar_body_type.FormattingEnabled = True
        Me.cmbcar_body_type.Items.AddRange(New Object() {"Cabriolet", "Copue", "Crew Bus", "Double Cab", "Extended Cab", "Fastback", "Hatchback", "Sedan", "Sportback", "Super Cab", "Suv", "Station Wagon", "Single Cab", "Panel Van", "Mpv", "Mini bus", "Lcv", "Kingcab"})
        Me.cmbcar_body_type.Location = New System.Drawing.Point(188, 166)
        Me.cmbcar_body_type.Name = "cmbcar_body_type"
        Me.cmbcar_body_type.Size = New System.Drawing.Size(121, 21)
        Me.cmbcar_body_type.TabIndex = 8
        '
        'btnback
        '
        Me.btnback.Location = New System.Drawing.Point(426, 420)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(75, 23)
        Me.btnback.TabIndex = 10
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Location = New System.Drawing.Point(193, 420)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 23)
        Me.btnclose.TabIndex = 11
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(313, 420)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(75, 23)
        Me.btnclear.TabIndex = 12
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btn_nextform
        '
        Me.btn_nextform.Location = New System.Drawing.Point(89, 420)
        Me.btn_nextform.Name = "btn_nextform"
        Me.btn_nextform.Size = New System.Drawing.Size(75, 23)
        Me.btn_nextform.TabIndex = 13
        Me.btn_nextform.Text = "Next Form"
        Me.btn_nextform.UseVisualStyleBackColor = True
        '
        'txtcar_price
        '
        Me.txtcar_price.Enabled = False
        Me.txtcar_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcar_price.ForeColor = System.Drawing.Color.Red
        Me.txtcar_price.Location = New System.Drawing.Point(188, 210)
        Me.txtcar_price.Name = "txtcar_price"
        Me.txtcar_price.Size = New System.Drawing.Size(121, 26)
        Me.txtcar_price.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(140, 213)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 20)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "ZAR"
        '
        'picchevrolet
        '
        Me.picchevrolet.Image = CType(resources.GetObject("picchevrolet.Image"), System.Drawing.Image)
        Me.picchevrolet.Location = New System.Drawing.Point(336, 86)
        Me.picchevrolet.Name = "picchevrolet"
        Me.picchevrolet.Size = New System.Drawing.Size(329, 160)
        Me.picchevrolet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picchevrolet.TabIndex = 16
        Me.picchevrolet.TabStop = False
        Me.picchevrolet.Visible = False
        '
        'picaudi
        '
        Me.picaudi.Image = CType(resources.GetObject("picaudi.Image"), System.Drawing.Image)
        Me.picaudi.Location = New System.Drawing.Point(336, 86)
        Me.picaudi.Name = "picaudi"
        Me.picaudi.Size = New System.Drawing.Size(329, 160)
        Me.picaudi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picaudi.TabIndex = 17
        Me.picaudi.TabStop = False
        Me.picaudi.Visible = False
        '
        'picfiat
        '
        Me.picfiat.Image = CType(resources.GetObject("picfiat.Image"), System.Drawing.Image)
        Me.picfiat.Location = New System.Drawing.Point(336, 86)
        Me.picfiat.Name = "picfiat"
        Me.picfiat.Size = New System.Drawing.Size(329, 160)
        Me.picfiat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picfiat.TabIndex = 18
        Me.picfiat.TabStop = False
        Me.picfiat.Visible = False
        '
        'picford
        '
        Me.picford.Image = CType(resources.GetObject("picford.Image"), System.Drawing.Image)
        Me.picford.Location = New System.Drawing.Point(336, 86)
        Me.picford.Name = "picford"
        Me.picford.Size = New System.Drawing.Size(329, 160)
        Me.picford.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picford.TabIndex = 19
        Me.picford.TabStop = False
        Me.picford.Visible = False
        '
        'pichonda
        '
        Me.pichonda.Image = CType(resources.GetObject("pichonda.Image"), System.Drawing.Image)
        Me.pichonda.Location = New System.Drawing.Point(336, 86)
        Me.pichonda.Name = "pichonda"
        Me.pichonda.Size = New System.Drawing.Size(329, 160)
        Me.pichonda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pichonda.TabIndex = 20
        Me.pichonda.TabStop = False
        Me.pichonda.Visible = False
        '
        'picjaguar
        '
        Me.picjaguar.Image = CType(resources.GetObject("picjaguar.Image"), System.Drawing.Image)
        Me.picjaguar.Location = New System.Drawing.Point(336, 86)
        Me.picjaguar.Name = "picjaguar"
        Me.picjaguar.Size = New System.Drawing.Size(329, 160)
        Me.picjaguar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picjaguar.TabIndex = 21
        Me.picjaguar.TabStop = False
        Me.picjaguar.Visible = False
        '
        'picjeep
        '
        Me.picjeep.Image = CType(resources.GetObject("picjeep.Image"), System.Drawing.Image)
        Me.picjeep.Location = New System.Drawing.Point(336, 86)
        Me.picjeep.Name = "picjeep"
        Me.picjeep.Size = New System.Drawing.Size(329, 160)
        Me.picjeep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picjeep.TabIndex = 22
        Me.picjeep.TabStop = False
        Me.picjeep.Visible = False
        '
        'picnissan
        '
        Me.picnissan.Image = CType(resources.GetObject("picnissan.Image"), System.Drawing.Image)
        Me.picnissan.Location = New System.Drawing.Point(336, 86)
        Me.picnissan.Name = "picnissan"
        Me.picnissan.Size = New System.Drawing.Size(329, 160)
        Me.picnissan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picnissan.TabIndex = 23
        Me.picnissan.TabStop = False
        Me.picnissan.Visible = False
        '
        'picvolkswagen
        '
        Me.picvolkswagen.Image = CType(resources.GetObject("picvolkswagen.Image"), System.Drawing.Image)
        Me.picvolkswagen.Location = New System.Drawing.Point(336, 86)
        Me.picvolkswagen.Name = "picvolkswagen"
        Me.picvolkswagen.Size = New System.Drawing.Size(329, 160)
        Me.picvolkswagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picvolkswagen.TabIndex = 24
        Me.picvolkswagen.TabStop = False
        Me.picvolkswagen.Visible = False
        '
        'picvolvo
        '
        Me.picvolvo.Image = CType(resources.GetObject("picvolvo.Image"), System.Drawing.Image)
        Me.picvolvo.Location = New System.Drawing.Point(336, 86)
        Me.picvolvo.Name = "picvolvo"
        Me.picvolvo.Size = New System.Drawing.Size(329, 160)
        Me.picvolvo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picvolvo.TabIndex = 25
        Me.picvolvo.TabStop = False
        Me.picvolvo.Visible = False
        '
        'Car_details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 485)
        Me.Controls.Add(Me.picvolvo)
        Me.Controls.Add(Me.picvolkswagen)
        Me.Controls.Add(Me.picnissan)
        Me.Controls.Add(Me.picjeep)
        Me.Controls.Add(Me.picjaguar)
        Me.Controls.Add(Me.pichonda)
        Me.Controls.Add(Me.picaudi)
        Me.Controls.Add(Me.picfiat)
        Me.Controls.Add(Me.picford)
        Me.Controls.Add(Me.picchevrolet)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtcar_price)
        Me.Controls.Add(Me.btn_nextform)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.cmbcar_body_type)
        Me.Controls.Add(Me.cmbcar_name)
        Me.Controls.Add(Me.cmbcar_brand)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblcar_price)
        Me.Controls.Add(Me.lblcar_model)
        Me.Controls.Add(Me.lblcar_name)
        Me.Controls.Add(Me.lblcar_brand)
        Me.Controls.Add(Me.lblheader)
        Me.Name = "Car_details"
        Me.Text = "Car_details"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picchevrolet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picaudi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picfiat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picford, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pichonda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picjaguar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picjeep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picnissan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picvolkswagen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picvolvo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblheader As System.Windows.Forms.Label
    Friend WithEvents lblcar_brand As System.Windows.Forms.Label
    Friend WithEvents lblcar_name As System.Windows.Forms.Label
    Friend WithEvents lblcar_model As System.Windows.Forms.Label
    Friend WithEvents lblcar_price As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ckbautomatic_emergency As System.Windows.Forms.CheckBox
    Friend WithEvents ckblane_centering As System.Windows.Forms.CheckBox
    Friend WithEvents ckblane_keep As System.Windows.Forms.CheckBox
    Friend WithEvents ckblane_departure As System.Windows.Forms.CheckBox
    Friend WithEvents ckbblind_spot As System.Windows.Forms.CheckBox
    Friend WithEvents ckbforward_collision As System.Windows.Forms.CheckBox
    Friend WithEvents cmbcar_brand As System.Windows.Forms.ComboBox
    Friend WithEvents cmbcar_name As System.Windows.Forms.ComboBox
    Friend WithEvents cmbcar_body_type As System.Windows.Forms.ComboBox
    Friend WithEvents btnback As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btn_nextform As System.Windows.Forms.Button
    Friend WithEvents txtcar_price As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents picchevrolet As PictureBox
    Friend WithEvents picaudi As PictureBox
    Friend WithEvents picfiat As PictureBox
    Friend WithEvents picford As PictureBox
    Friend WithEvents pichonda As PictureBox
    Friend WithEvents picjaguar As PictureBox
    Friend WithEvents picjeep As PictureBox
    Friend WithEvents picnissan As PictureBox
    Friend WithEvents picvolkswagen As PictureBox
    Friend WithEvents picvolvo As PictureBox
End Class
