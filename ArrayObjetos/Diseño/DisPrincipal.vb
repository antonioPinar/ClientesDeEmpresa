Public Class DisPrincipal

    Private Sub btnAltas_Click(sender As Object, e As EventArgs) Handles btnAltas.Click
        Dim altas As New DisAltas
        altas.Show()
    End Sub

    Private Sub btnBajas_Click(sender As Object, e As EventArgs) Handles btnBajas.Click
        Dim bajas As New DisBajas
        bajas.Show()
    End Sub

    Private Sub btnListado_Click(sender As Object, e As EventArgs) Handles btnListado.Click
        Dim listar As New DisListadoClientes
        listar.Show()
    End Sub

    Private Sub btnSalida_Click(sender As Object, e As EventArgs) Handles btnSalida.Click
        Me.Close()
    End Sub

End Class