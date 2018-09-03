Public Class Cotorra
    Inherits Loro
    Private recordar As Boolean = True

    Sub New()
        MyBase.New()
        recordar = True
    End Sub

    Public ReadOnly Property EdadHumana As Short
        Get
            Return Edad * 2
        End Get
    End Property

    Public Overrides Sub Escuchar(palabra As String)
        If recordar = True Then
            _memoria.Enqueue(palabra)
            recordar = False
        Else
            recordar = True
        End If
    End Sub

End Class
