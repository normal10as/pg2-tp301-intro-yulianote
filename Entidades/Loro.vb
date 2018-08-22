Public Class Loro

    Private _edad As Short
    Private _fechaNacimiento As Date
    Private _nombre As String
    Private _memoria As Queue

    Public Sub New()
        Nombre = ""
        FechaNacimiento = Now()
    End Sub

    Public ReadOnly Property Edad As Short
        Get
            Return _edad
        End Get

    End Property

    Public Property FechaNacimiento As Date
        Get
            Return _fechaNacimiento
        End Get
        Set(value As Date)
            _fechaNacimiento = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property




End Class
