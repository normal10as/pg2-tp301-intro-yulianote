Public Class Loro
    Private _fechaNacimiento As Date
    Private _nombre As String
    Private _memoria As Queue(Of String)
    Private texto As String

    Public Sub New()
        Me.Nombre = ""
        Me.FechaNacimiento = Now()
        _memoria = New Queue(Of String)
    End Sub

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

    Public ReadOnly Property Edad As Short
        Get
            Return CalcularEdad(FechaNacimiento)
        End Get

    End Property

    Private Function CalcularEdad(fechaNacimiento As Date) As UShort
        Dim hoy As Date = Now
        Dim anios As UShort
        anios = hoy.Year() - fechaNacimiento.Year()
        If fechaNacimiento.Month() >= hoy.Month() Then
            If fechaNacimiento.Day() >= hoy.Day() Then
                anios = anios + 1
            End If
        End If
        Return anios
        ''Return DateDiff(DateInterval.Year, fechaNacimiento, Now)


    End Function

    Public Sub Escuchar(Frase As String)
        _memoria.Enqueue(Frase)
    End Sub

    Public Function Hablar() As String
        If _memoria.Count > 0 Then
            texto = texto & _memoria.Dequeue & " "
        End If
        Return texto
    End Function

End Class
