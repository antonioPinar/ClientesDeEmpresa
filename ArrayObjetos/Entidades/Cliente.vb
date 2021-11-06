Public Class Cliente

    Dim codigo As String
    Dim nombre As String
    Dim apellido As String
    Dim fechaIngreso As Date
    Dim sueldo As Decimal

    Public Sub New(codigo As String, nombre As String, apellido As String, fechaIngreso As Date, sueldo As Decimal)
        Me.codigo = codigo
        Me.nombre = nombre
        Me.apellido = apellido
        Me.fechaIngreso = fechaIngreso
        Me.sueldo = sueldo
    End Sub

    Public Sub New()

    End Sub

    Public Property Codigo1 As String
        Get
            Return codigo
        End Get
        Set(value As String)
            codigo = value
        End Set
    End Property

    Public Property Nombre1 As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property Apellido1 As String
        Get
            Return apellido
        End Get
        Set(value As String)
            apellido = value
        End Set
    End Property

    Public Property FechaIngreso1 As Date
        Get
            Return fechaIngreso
        End Get
        Set(value As Date)
            fechaIngreso = value
        End Set
    End Property

    Public Property Sueldo1 As Decimal
        Get
            Return sueldo
        End Get
        Set(value As Decimal)
            sueldo = value
        End Set
    End Property
End Class
