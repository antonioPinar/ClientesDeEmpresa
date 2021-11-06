Public Class DisAltas
    Private Sub DisAltas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cajaCodAlta.Select()

    End Sub

    Private Sub btnGrabarAlta_Click(sender As Object, e As EventArgs) Handles btnGrabarAlta.Click
        Dim btn As New AccesoBotones
        Dim logica As New Metodos

        'en el evento grabar convertimos los datos de alta en un objeto cliente
        Dim unCliente As New Cliente
        unCliente.Codigo1 = cajaCodAlta.Text
        unCliente.Nombre1 = cajaNombreAlta.Text
        unCliente.Apellido1 = cajaApellidoAlta.Text
        unCliente.FechaIngreso1 = CDate(dateFechaIngreso.Text)
        unCliente.Sueldo1 = CDec(cajaSueldoAlta.Text)

        logica.altaCliente(unCliente)

        'sacamos un mensaje indicando que se ha guardado correctamente
        etqRespAlta.BackColor = Color.Green
        etqRespAlta.Text = "El cliente se ha guardado correctamente"

        cajaCodAlta.Clear()
        cajaNombreAlta.Clear()
        cajaApellidoAlta.Clear()
        cajaSueldoAlta.Clear()

        btn.activarBtns(DisPrincipal)

    End Sub

End Class