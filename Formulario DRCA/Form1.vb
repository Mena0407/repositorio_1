Public Class Form1
    Sub asignarmunicipios(departamento, numero)
        Dim municipios() As String
        municipios = {}
        Select Case departamento
            Case "Alta Verapaz"
                municipios = {"Coban", "Santa Cruz Verapaz", "San Cristobal Verapaz", "Tactic", "Tamahu", "San Miguel Tucuru", "Panzos", "Senahu", "San Pedro Carcha", "San Juan Chamelco", "Lanquin", "Santa Maria Cahabon", "Chisec", "Chahal", "Fray Bartolome De Las Casas", "La Tinta", "Raxruhá"}
            Case "Baja Verapaz"
                municipios = {"Salama", "San Miguel Chicaj", "Rabinal", "Cubulco", "Granados", "Santa Cruz El Chol", "San Jeronimo", "Purulha"}
            Case "Chimaltenango"
                municipios = {"Chimaltenango", "San Jose Poaquil", "San Martin Jilotepeque", "San Juan Comalapa", "Santa Apolonia", "Tecpan Guatemala", "Patzun", "San Miguel Pochuta", "Patzicia", "Santa Cruz Balanya", "Acatenango", "San Pedro Yepocapa", "San Andres Itzapa", "Parramos", "Zaragoza", "El Tejar"}
            Case "Chiquimula"
                municipios = {"Chiquimula", "San Jose La Arada", "San Juan La Ermita", "Jocotan", "Camotan", "Olopa", "Esquipulas", "Concepcion Las Minas", "Quezaltepeque", "San Jacinto", "Ipala"}
            Case "Guatemala"
                municipios = {"Guatemala", "Santa Catarina Pinula", "San Jose Pinula", "San Jose Del Golfo", "Palencia", "Chinautla", "San Pedro Ayampuc", "Mixco", "San Pedro Sacatepequez", "San Juan Sacatepequez", "San Raymundo", "Chuarrancho", "Fraijanes", "Amatitlan", "Villa Nueva", "Villa Canales", "San Miguel Petapa"}
            Case "El Progreso"
                municipios = {"Guastatoya", "Morazan", "San Agustin Acasaguastlan", "San Cristobal Acasaguastlan", "El Jicaro", "Sansare", "Sanarate", "San Antonio La Paz"}
            Case "Escuintla"
                municipios = {"Escuintla", "Santa Lucia Cotzumalguapa", "La Democracia", "Siquinala", "Masagua", "Tiquisate", "La Gomera", "Guanagazapa", "San Jose", "Iztapa", "Palin", "San Vicente Pacaya"}
            Case "Huehuetenango"
                municipios = {"Huehuetenango", "Chiantla", "Malacatancito", "Cuilco", "Nenton", "San Pedro Necta", "Jacaltenango", "San Pedro Soloma", "San Ildefonso Ixtahuacan", "Santa Barbara", "La Libertad", "La Democracia", "San Miguel Acatan", "San Rafael La Independencia", "Todos Santos Cuchumatan", "San Juan Atitan", "Santa Eulalia", "San Mateo Ixtatan", "Colotenango", "San Sebastian Huehuetenango", "Tectitan", "Concepcion Huista", "San Juan Ixcoy", "San Antonio Huista", "San Sebastian Coatan", "Santa Cruz Barillas", "Aguacatan", "San Rafael Petzal", "San Gaspar Ixchil", "Santiago Chimaltenango", "Santa Ana Huista", "Unión Cantinil"}
            Case "Izabal"
                municipios = {"Puerto Barrios", "Livingston", "El Estor", "Morales", "Los Amates"}
            Case "Jalapa"
                municipios = {"Jalapa", "San Pedro Pinula", "San Luis Jilotepeque", "San Manuel Chaparron", "San Carlos Alzatate", "Monjas", "Mataquescuintla"}
            Case "Jutiapa"
                municipios = {"Jutiapa", "El Progreso", "Santa Catarina Mita", "Agua Blanca", "Asuncion Mita", "Yupiltepeque", "Atescatempa", "Jerez", "El Adelanto", "Zapotitlan", "Comapa", "Jalpatagua", "Conguaco", "Moyuta", "Pasaco", "San Jose Acatempa", "Quesada"}
            Case "Petén"
                municipios = {"Flores", "San Jose", "San Benito", "San Andres", "La Libertad", "San Francisco", "Santa Ana", "Dolores", "San Luis", "Sayaxche", "Melchor De Mencos", "Poptun"}
            Case "Quetzaltenango"
                municipios = {"Quetzaltenango", "Salcaja", "Olintepeque", "San Carlos Sija", "Sibilia", "Cabrican", "Cajola", "San Miguel Siguila", "San Juan Ostuncalco", "San Mateo", "Concepcion Chiquirichapa", "San Martin Sacatepequez", "Almolonga", "Cantel", "Huitan", "Zunil", "Colomba Costa Cuca", "San Francisco La Union", "El Palmar", "Coatepeque", "Genova Costa Cuca", "Flores Costa Cuca", "La Esperanza", "Palestina De Los Altos"}
            Case "Quiché"
                municipios = {"Santa Cruz Del Quiche", "Chiche", "Chinique", "Zacualpa", "Chajul", "Sto Tomas Chichicastenango", "Patzite", "San Antonio Ilotenango", "San Pedro Jocopilas", "Cunen", "San Juan Cotzal", "Joyabaj", "Nebaj", "San Andres Sajcabaja", "San Miguel Uspantan", "Sacapulas", "San Bartolome Jocotenango", "Canilla", "Chicaman", "Ixcan", "Pachalun", "Playa Grande"}
            Case "Retalhuleu"
                municipios = {"Retalhuleu", "San Sebastian", "Santa Cruz Mulua", "San Martin Zapotitlan", "San Felipe", "San Andres Villa Seca", "Champerico", "Nuevo San Carlos", "El Asintal"}
            Case "Sacatepequez"
                municipios = {"Antigua", "Jocotenango", "Pastores", "Sumpango", "Santo Domingo Xenacoj", "Santiago Sacatepequez", "San Bartolome Milpas Altas", "San Lucas Sacatepequez", "Santa Lucia Milpas Altas", "Magdalena Milpas Altas", "Santa Maria De Jesus", "Ciudad Vieja", "San Miguel Duenas", "Alotenango", "San Antonio Aguas Calientes", "Santa Catarina Barahona"}
            Case "San Marcos"
                municipios = {"San Marcos", "San Pedro Sacatepequez", "San Antonio Sacatepequez", "Comitancillo", "San Miguel Ixtahuacan", "Concepcion Tutuapa", "Tacana", "Sibinal", "Tajumulco", "Tejutla", "San Rafael Pie De La Cuesta", "Nuevo Progreso", "El Tumbador", "San Jose El Rodeo", "Malacatan", "Catarina", "Ayutla (Tecun Uman)", "Ocos", "San Pablo", "El Quetzal", "La Reforma", "Pajapita", "Ixchiguan", "San Jose Ojetenan", "San Cristobal Cucho", "Sipacapa", "Esquipulas Palo Gordo", "Rio Blanco", "San Lorenzo"}
            Case "Santa Rosa"
                municipios = {"Cuilapa", "Barberena", "Santa Rosa De Lima", "Casillas", "San Rafael Las Flores", "Oratorio", "San Juan Tecuaco", "Chiquimulilla", "Taxisco", "Santa Maria Ixhuatan", "Guazacapan", "Santa Cruz Naranjo", "Municipio Nuevo Viñas", "Nueva Santa Rosa"}
            Case "Sololá"
                municipios = {"Solola", "San Jose Chacaya", "Santa Maria Visitacion", "Santa Lucia Utatlan", "Nahuala", "Santa Catarina Ixtahuacan", "Santa Clara La Laguna", "Concepcion", "San Andres Semetabaj", "Panajachel", "Santa Catarina Palopo", "San Antonio Palopo", "San Lucas Toliman", "Santa Cruz La Laguna", "San Pablo La Laguna", "San Marcos La Laguna", "San Juan La Laguna", "San Pedro La Laguna", "Santiago Atitlan"}
            Case "Suchitepequez"
                municipios = {"Mazatenango", "Cuyotenango", "San Francisco Zapotitlan", "San Bernardino", "San Jose El Idolo", "Santo Domingo Suchitepequez", "San Lorenzo", "Samayac", "San Pablo Jocopilas", "San Antonio Suchitepequez", "San Miguel Panam", "San Gabriel", "Chicacao", "Patulul", "Santa Barbara", "San Juan Bautista", "Santo Tomas La Union", "Zunilito", "Municipio Nuevo", "Rio Bravo"}
            Case "Totonicapán"
                municipios = {"Totonicapan", "San Cristobal Totonicapan", "San Francisco El Alto", "San Andres Xecul", "Momostenango", "Santa Maria Chiquimula", "Santa Lucia La Reforma", "San Bartolo Aguas Calientes"}
            Case "Zacapa"
                municipios = {"Zacapa", "Estanzuela", "Rio Hondo", "Gualan", "Teculutan", "Usumatlan", "Cabanas", "San Diego", "La Union", "Huite"}
        End Select
        If numero = 1 Then
            cbmunicipios.Items.Clear()
            cbmunicipios.Items.AddRange(municipios)
        End If

        If numero = 2 Then
            cbmunicipioOC.Items.Clear()
            cbmunicipioOC.Items.AddRange(municipios)
        End If
    End Sub
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpfechapresen.ValueChanged

    End Sub

    Private Sub cbdepartamentos_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cbdepartamentos_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbdepartamentos.SelectedIndexChanged
        asignarmunicipios(cbdepartamentos.SelectedItem, 1)
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub cbdepartamentoOC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbdepartamentoOC.SelectedIndexChanged
        asignarmunicipios(cbdepartamentoOC.SelectedItem, 2)
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles Checkjunio.CheckedChanged

    End Sub

    Private Sub CheckTodoelaño_CheckedChanged(sender As Object, e As EventArgs) Handles CheckTodoelaño.CheckedChanged
        If CheckTodoelaño.Checked = True Then
            Checkenero.Checked = False
            Checkenero.Enabled = False
            Checkfebrero.Enabled = False
            Checkfebrero.Checked = False
            Checkmarzo.Enabled = False
            Checkmarzo.Checked = False
            Checkabril.Enabled = False
            Checkabril.Checked = False
            Checkmayo.Enabled = False
            Checkmayo.Checked = False
            Checkjunio.Enabled = False
            Checkjunio.Checked = False
            Checkjulio.Enabled = False
            Checkjulio.Checked = False
            Checkagosto.Enabled = False
            Checkagosto.Checked = False
            Checkseptiembre.Enabled = False
            Checkseptiembre.Checked = False
            Checkoctubre.Enabled = False
            Checkoctubre.Checked = False
            Checknoviembre.Enabled = False
            Checknoviembre.Checked = False
            Checkdiciembre.Enabled = False
            Checkdiciembre.Checked = False
        End If
        If CheckTodoelaño.Checked = False Then
            Checkenero.Enabled = True
            Checkfebrero.Enabled = True
            Checkmarzo.Enabled = True
            Checkabril.Enabled = True
            Checkmayo.Enabled = True
            Checkjunio.Enabled = True
            Checkjulio.Enabled = True
            Checkagosto.Enabled = True
            Checkseptiembre.Enabled = True
            Checkoctubre.Enabled = True
            Checknoviembre.Enabled = True
            Checkdiciembre.Enabled = True
        End If
    End Sub

    Private Sub Checkdiario_CheckedChanged(sender As Object, e As EventArgs) Handles Checkdiario.CheckedChanged
        If Checkdiario.Checked = True Then
            Checklunes.Checked = False
            Checklunes.Enabled = False
            Checkmartes.Checked = False
            Checkmartes.Enabled = False
            Checkmiercoles.Checked = False
            Checkmiercoles.Enabled = False
            Checkjueves.Checked = False
            Checkjueves.Enabled = False
            Checkviernes.Checked = False
            Checkviernes.Enabled = False
            Checksabado.Checked = False
            Checksabado.Enabled = False
            Checkdomingo.Checked = False
            Checkdomingo.Enabled = False
        End If
        If Checkdiario.Checked = False Then
            Checklunes.Enabled = True
            Checkmartes.Enabled = True
            Checkmiercoles.Enabled = True
            Checkjueves.Enabled = True
            Checkviernes.Enabled = True
            Checksabado.Enabled = True
            Checkdomingo.Enabled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tbobservaciones.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormReporte.Show()

    End Sub
End Class
