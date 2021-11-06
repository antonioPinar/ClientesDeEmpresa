Public Class AccesoBotones
    Dim logica As New Metodos

    Public Sub desasctivarBtns(form As DisPrincipal)

        If logica.arrayClientes.Length = 0 Then
            With form
                .btnBajas.Enabled = False
                .btnListado.Enabled = False
            End With

        End If
    End Sub

    Public Sub activarBtns(form As DisPrincipal)

        With form
            .btnBajas.Enabled = True
            .btnListado.Enabled = True
        End With

    End Sub

End Class
