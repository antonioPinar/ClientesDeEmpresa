Public Class DisBajas

    Dim logica As New Metodos
    Public Shared posCod As Integer

    Private Sub DisBajas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cajaCodBaja.Select()
    End Sub

    Private Sub btnBuscarBaja_Click(sender As Object, e As EventArgs) Handles btnBuscarBaja.Click

        If logica.arrayClientes Is Nothing Then

            etqRespBaja.BackColor = Color.Red
            etqRespBaja.Text = "Cliente no encontrado, la lista ahora mismo se encuentra vacia"
        Else

            If logica.buscarCodigo(Me) >= 0 Then

                etqRespBaja.BackColor = Color.Green
                etqRespBaja.Text = "Cliente a buscar encontrado"

                cajaNombreBaja.Text = logica.arrayClientes(logica.buscarCodigo(Me)).Nombre1
                cajaApellidoBaja.Text = logica.arrayClientes(logica.buscarCodigo(Me)).Apellido1
                cajaFechaIBaja.Text = CType(logica.arrayClientes(logica.buscarCodigo(Me)).FechaIngreso1, String)
                cajaSueldoBaja.Text = CType(logica.arrayClientes(logica.buscarCodigo(Me)).Sueldo1, String)

            Else
                cajaNombreBaja.Clear()
                cajaApellidoBaja.Clear()
                cajaFechaIBaja.Clear()
                cajaSueldoBaja.Clear()

                etqRespBaja.BackColor = Color.Red
                etqRespBaja.Text = "Cliente a buscar no encontrado"
            End If

        End If

    End Sub

    Private Sub btnborrarBaja_Click(sender As Object, e As EventArgs) Handles btnborrarBaja.Click
        Dim btn As New AccesoBotones

        posCod = logica.buscarCodigo(Me)
        logica.borrarCliente(Me)

        etqRespBaja.BackColor = Color.Green
        etqRespBaja.Text = "Cliente borrado con exito"

        cajaNombreBaja.Clear()
        cajaApellidoBaja.Clear()
        cajaFechaIBaja.Clear()
        cajaSueldoBaja.Clear()

        btn.desasctivarBtns(DisPrincipal)
    End Sub

End Class