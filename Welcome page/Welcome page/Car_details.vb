Public Class Car_details

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        'used to declare a variable that will call the privious page
        Dim privious_page As New Employment_details
        'used to hide the current window
        Me.Hide()
        'used to open the privious page
        privious_page.Show()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        'used to close the current programe
        Me.Close()
    End Sub

    Private Sub cmbcar_brand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcar_brand.SelectedIndexChanged
        'used to add car names to the combobox based on the selected car brand 
        If (cmbcar_brand.Text = "Chevrolet") Then
            cmbcar_name.Items.Clear()
            cmbcar_name.Items.Add("Camaro SS Auto")
            cmbcar_name.Items.Add("Camaro ZL1")
            cmbcar_name.Items.Add("Stringray V8")
            cmbcar_name.Items.Add("Lumina ute SS")
        ElseIf (cmbcar_brand.Text = "Honda") Then
            cmbcar_name.Items.Clear()
            cmbcar_name.Items.Add("Civic Type R")
            cmbcar_name.Items.Add("CR-V 1.5T Executive")
            cmbcar_name.Items.Add("Civic Sedan 1.5T Rs")
            cmbcar_name.Items.Add("CR-V 2.0T Executive")
        ElseIf (cmbcar_brand.Text = "Nissan") Then
            cmbcar_name.Items.Clear()
            cmbcar_name.Items.Add("GT-R")
            cmbcar_name.Items.Add("Skyline")
            cmbcar_name.Items.Add("Silvia 2.0")
            cmbcar_name.Items.Add("350Z")
        ElseIf (cmbcar_brand.Text = "Ford") Then
            cmbcar_name.Items.Clear()
            cmbcar_name.Items.Add("Mustang")
            cmbcar_name.Items.Add("F150")
            cmbcar_name.Items.Add("Ranger")
            cmbcar_name.Items.Add("Focus")
        ElseIf (cmbcar_brand.Text = "Fiat") Then
            cmbcar_name.Items.Clear()
            cmbcar_name.Items.Add("500")
            cmbcar_name.Items.Add("Grande Punto")
            cmbcar_name.Items.Add("Panda")
            cmbcar_name.Items.Add("Ducato")
        ElseIf (cmbcar_brand.Text = "Jeep") Then
            cmbcar_name.Items.Clear()
            cmbcar_name.Items.Add("Cherokee")
            cmbcar_name.Items.Add("Grand Cherokee")
            cmbcar_name.Items.Add("Wrangler")
            cmbcar_name.Items.Add("Commander Sport")
        ElseIf (cmbcar_brand.Text = "Volkswagen") Then
            cmbcar_name.Items.Clear()
            cmbcar_name.Items.Add("Amarok")
            cmbcar_name.Items.Add("Citi")
            cmbcar_name.Items.Add("Golf")
            cmbcar_name.Items.Add("Tiguan")
        ElseIf (cmbcar_brand.Text = "Volvo") Then
            cmbcar_name.Items.Clear()
            cmbcar_name.Items.Add("V40")
            cmbcar_name.Items.Add("S40")
            cmbcar_name.Items.Add("V60 Cross Country")
            cmbcar_name.Items.Add("V90 Cross Country")
        ElseIf (cmbcar_brand.Text = "Jaguar") Then
            cmbcar_name.Items.Clear()
            cmbcar_name.Items.Add("E-Pace")
            cmbcar_name.Items.Add("F-Type")
            cmbcar_name.Items.Add("S-Type")
            cmbcar_name.Items.Add("XF")
        ElseIf (cmbcar_brand.Text = "Audi") Then
            cmbcar_name.Items.Clear()
            cmbcar_name.Items.Add("A7 Sportback")
            cmbcar_name.Items.Add("R8")
            cmbcar_name.Items.Add("Rs 4")
            cmbcar_name.Items.Add("Rs 6")
        Else
            MessageBox.Show("You have not selected a vehical brand")
        End If

        'used to display the logo of the car brand the end-user has selected
        If (cmbcar_brand.Text = "Chevrolet") Then
            picchevrolet.Visible = True
            picaudi.Visible = False
            picfiat.Visible = False
            picford.Visible = False
            picjeep.Visible = False
            picvolkswagen.Visible = False
            picvolvo.Visible = False
            picjaguar.Visible = False
            pichonda.Visible = False
            picnissan.Visible = False
        ElseIf (cmbcar_brand.Text = "Honda") Then
            pichonda.Visible = True
            picchevrolet.Visible = False
            picaudi.Visible = False
            picfiat.Visible = False
            picford.Visible = False
            picjeep.Visible = False
            picvolkswagen.Visible = False
            picvolvo.Visible = False
            picjaguar.Visible = False
            picnissan.Visible = False
        ElseIf (cmbcar_brand.Text = "Nissan") Then
            picnissan.Visible = True
            pichonda.Visible = False
            picchevrolet.Visible = False
            picaudi.Visible = False
            picfiat.Visible = False
            picford.Visible = False
            picjeep.Visible = False
            picvolkswagen.Visible = False
            picvolvo.Visible = False
            picjaguar.Visible = False
        ElseIf (cmbcar_brand.Text = "Ford") Then
            picford.Visible = True
            picnissan.Visible = False
            pichonda.Visible = False
            picchevrolet.Visible = False
            picaudi.Visible = False
            picfiat.Visible = False
            picjeep.Visible = False
            picvolkswagen.Visible = False
            picvolvo.Visible = False
            picjaguar.Visible = False
        ElseIf (cmbcar_brand.Text = "Fiat") Then
            picfiat.Visible = True
            picford.Visible = False
            picnissan.Visible = False
            pichonda.Visible = False
            picchevrolet.Visible = False
            picaudi.Visible = False
            picjeep.Visible = False
            picvolkswagen.Visible = False
            picvolvo.Visible = False
            picjaguar.Visible = False
        ElseIf (cmbcar_brand.Text = "Jeep") Then
            picjeep.Visible = True
            picfiat.Visible = False
            picford.Visible = False
            picnissan.Visible = False
            pichonda.Visible = False
            picchevrolet.Visible = False
            picaudi.Visible = False
            picvolkswagen.Visible = False
            picvolvo.Visible = False
            picjaguar.Visible = False
        ElseIf (cmbcar_brand.Text = "Volkswagen") Then
            picvolkswagen.Visible = True
            picjeep.Visible = False
            picfiat.Visible = False
            picford.Visible = False
            picnissan.Visible = False
            pichonda.Visible = False
            picchevrolet.Visible = False
            picaudi.Visible = False
            picvolvo.Visible = False
            picjaguar.Visible = False
        ElseIf (cmbcar_brand.Text = "Volvo") Then
            picvolvo.Visible = True
            picvolkswagen.Visible = False
            picjeep.Visible = False
            picfiat.Visible = False
            picford.Visible = False
            picnissan.Visible = False
            pichonda.Visible = False
            picchevrolet.Visible = False
            picaudi.Visible = False
            picjaguar.Visible = False
        ElseIf (cmbcar_brand.Text = "Jaguar") Then
            picjaguar.Visible = True
            picvolvo.Visible = False
            picvolkswagen.Visible = False
            picjeep.Visible = False
            picfiat.Visible = False
            picford.Visible = False
            picnissan.Visible = False
            pichonda.Visible = False
            picchevrolet.Visible = False
            picaudi.Visible = False
        ElseIf (cmbcar_brand.Text = "Audi") Then
            picaudi.Visible = True
            picjaguar.Visible = False
            picvolvo.Visible = False
            picvolkswagen.Visible = False
            picjeep.Visible = False
            picfiat.Visible = False
            picford.Visible = False
            picnissan.Visible = False
            pichonda.Visible = False
            picchevrolet.Visible = False
        End If



    End Sub

    Private Sub cmbcar_body_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcar_body_type.SelectedIndexChanged
        'used to display the car price based on the car body type selected
        If (cmbcar_body_type.Text = "Cabriolet") Then
            txtcar_price.Text = 50000
        ElseIf (cmbcar_body_type.Text = "Copue") Then
            txtcar_price.Text = 835000
        ElseIf (cmbcar_body_type.Text = "Crew Bus") Then
            txtcar_price.Text = 32900
        ElseIf (cmbcar_body_type.Text = "Double Cab") Then
            txtcar_price.Text = 242900
        ElseIf (cmbcar_body_type.Text = "Extended Cab") Then
            txtcar_price.Text = 242900
        ElseIf (cmbcar_body_type.Text = "Fastback") Then
            txtcar_price.Text = 1175000
        ElseIf (cmbcar_body_type.Text = "Hatchback") Then
            txtcar_price.Text = 224300
        ElseIf (cmbcar_body_type.Text = "Sedan") Then
            txtcar_price.Text = 320000
        ElseIf (cmbcar_body_type.Text = "Sportback") Then
            txtcar_price.Text = 734000
        ElseIf (cmbcar_body_type.Text = "Super Cab") Then
            txtcar_price.Text = 599565
        ElseIf (cmbcar_body_type.Text = "Suv") Then
            txtcar_price.Text = 58970
        ElseIf (cmbcar_body_type.Text = "Station Wagon") Then
            txtcar_price.Text = 1000000
        ElseIf (cmbcar_body_type.Text = "Single Cab") Then
            txtcar_price.Text = 367500
        ElseIf (cmbcar_body_type.Text = "Panel Van") Then
            txtcar_price.Text = 482900
        ElseIf (cmbcar_body_type.Text = "Mpv") Then
            txtcar_price.Text = 129000
        ElseIf (cmbcar_body_type.Text = "Mini bus") Then
            txtcar_price.Text = 493900
        ElseIf (cmbcar_body_type.Text = "Lcv") Then
            txtcar_price.Text = 179100
        ElseIf (cmbcar_body_type.Text = "King Cab") Then
            txtcar_price.Text = 382852
        Else
            MessageBox.Show("You have not selected any vehicle body type")
        End If
    End Sub

    Private Sub btn_nextform_Click(sender As Object, e As EventArgs) Handles btn_nextform.Click
        'used to declare a varibale to store the data 
        Dim car_brand As String
        Dim car_name As String
        Dim car_body_type As String
        Dim car_price As String
        Dim add_features As String

        'used to add the end-used data to the respective variable
        car_name = cmbcar_name.Text
        car_brand = cmbcar_brand.Text
        car_body_type = cmbcar_body_type.Text
        car_price = txtcar_price.Text
        add_features = ""


        'used to add the additional features to the variable based on the end-users choice
        If (ckbforward_collision.Checked = True) Then
            add_features = "Forward Collision Warning"
        ElseIf (ckblane_departure.Checked = True) Then
            add_features = "Lane Departure Warning"
        ElseIf (ckblane_centering.Checked = True) Then
            add_features = "Lane Centering Assist"
        ElseIf (ckbblind_spot.Checked = True) Then
            add_features = "Blind Spot Monitoring"
        ElseIf (ckblane_keep.Checked = True) Then
            add_features = "Lane Keep Assist"
        ElseIf (ckbautomatic_emergency.Checked = True) Then
            add_features = "Automatic Emergency Braking"

        ElseIf (ckbforward_collision.Checked = True And ckblane_departure.Checked = True) Then
            add_features = "Forward Collision Warning and Lane Departure Warning"
        ElseIf (ckbforward_collision.Checked = True And ckblane_centering.Checked = True) Then
            add_features = "Forward Collision Warning and Lane Centering Assist"
        ElseIf (ckbforward_collision.Checked = True And ckbblind_spot.Checked = True) Then
            add_features = "Forward Collision Warning and Blind Spot Monitoring"
        ElseIf (ckbforward_collision.Checked = True And ckblane_keep.Checked = True) Then
            add_features = "Forward Collision Warning and Lane Keep Assist"
        ElseIf (ckbforward_collision.Checked = True And ckbautomatic_emergency.Checked = True) Then
            add_features = "Forward Collision Warning and Automatic Emergency Braking"

        ElseIf (ckblane_departure.Checked = True And ckblane_centering.Checked = True) Then
            add_features = "Lane Departure Warning and Lane Centering Assist"
        ElseIf (ckblane_departure.Checked = True And ckbblind_spot.Checked = True) Then
            add_features = "Lane Departure Warning and Blind Spot Monitoring"
        ElseIf (ckblane_departure.Checked = True And ckblane_keep.Checked = True) Then
            add_features = "Lane Departure Warning and Lane Keep Assist"
        ElseIf (ckblane_departure.Checked = True And ckbautomatic_emergency.Checked = True) Then
            add_features = "Lane Departure Warning and Automatic Emergency Braking"

        ElseIf (ckblane_centering.Checked = True And ckbblind_spot.Checked = True) Then
            add_features = "Lane Centering Assist and Blind Spot Monitoring"
        ElseIf (ckblane_centering.Checked = True And ckblane_keep.Checked = True) Then
            add_features = "Lane Centering Assist and Lane Keep Assist"
        ElseIf (ckblane_centering.Checked = True And ckbautomatic_emergency.Checked = True) Then
            add_features = "Lane Centering Assist and Automatic Emergancy Braking"

        ElseIf (ckbblind_spot.Checked = True And ckblane_keep.Checked = True) Then
            add_features = "Blind Spot Monitoring and Lane Keep Assist"
        ElseIf (ckbblind_spot.Checked = True And ckbautomatic_emergency.Checked = True) Then
            add_features = "Blind Spot Monitoring and Automatic Emergancy Braking"

        ElseIf (ckblane_keep.Checked = True And ckbautomatic_emergency.Checked = True) Then
            add_features = "Lane Keep Assist and Automatic Emergency Braking"

        End If

        'used to store the next page on a variable 
        Dim next_page As New Loading_page_4

        'used to validate the variable befor openinnig the next page 
        If (car_body_type = "" Or car_brand = "" Or car_name = "" Or car_price = "" Or add_features = "") Then
            MessageBox.Show("Some of the information is not complted correctly")
        Else
            Me.Hide()
            next_page.Show()
        End If
    End Sub


End Class