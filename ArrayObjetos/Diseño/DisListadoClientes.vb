Public Class DisListadoClientes
    Dim logica As New Metodos

    Private Sub DisListadoClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        logica.listar(Me)
    End Sub

End Class