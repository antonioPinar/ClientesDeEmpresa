Public Class Metodos

    Public Shared arrayClientes() As Cliente

    Public Sub altaCliente(uncliente As Cliente)
        Dim contador As Integer = 0

        If arrayClientes Is Nothing Then
            ReDim arrayClientes(contador)

        Else
            contador = arrayClientes.GetLength(0)
            ReDim Preserve arrayClientes(contador)
        End If

        arrayClientes(contador) = uncliente
    End Sub

    Public Function buscarCodigo(form As DisBajas) As Integer
        Dim posicion As Integer

        For i As Integer = 0 To arrayClientes.GetUpperBound(0)
            If arrayClientes(i).Codigo1 = form.cajaCodBaja.Text Then

                posicion = i
                Exit For
            Else
                posicion = -1

            End If
        Next

        Return posicion
    End Function

    Public Sub borrarCliente(form As DisBajas)

        Dim posicion As Integer = form.posCod

        Try
            If posicion = arrayClientes.GetUpperBound(0) Then
                ReDim Preserve arrayClientes(arrayClientes.GetUpperBound(0) - 1)

            Else
                For i As Integer = posicion To arrayClientes.GetUpperBound(0) - 1

                    arrayClientes(i) = arrayClientes(i + 1)
                Next

                ReDim Preserve arrayClientes(arrayClientes.GetUpperBound(0) - 1)

            End If


        Catch ex As System.Exception
            Console.WriteLine("fuera de los limites del array, el array se encuentra vacio")
            If arrayClientes.GetUpperBound(0) < 0 Then
                ReDim arrayClientes(0)

            End If

        End Try

    End Sub

    Public Sub listar(form As DisListadoClientes)

        For i As Integer = 0 To arrayClientes.GetUpperBound(0)

            form.etqRespCodListado.Text &= arrayClientes(i).Codigo1 & vbCrLf
            form.etqRespNomListado.Text &= arrayClientes(i).Nombre1 & vbCrLf
            form.etqRespApellListado.Text &= arrayClientes(i).Apellido1 & vbCrLf
            form.etqRespFechaIListado.Text &= CType(arrayClientes(i).FechaIngreso1, String) & vbCrLf
            form.etqRespSueldoListado.Text &= CType(arrayClientes(i).Sueldo1, String) & vbCrLf
        Next

    End Sub

End Class
