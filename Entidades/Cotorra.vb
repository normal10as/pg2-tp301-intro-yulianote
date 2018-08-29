Public Class Cotorra
    Inherits Loro

    Sub New()
        MyBase.New()
    End Sub

    Public ReadOnly Property EdadHumana As Short
        Get
            Return Edad * 2
        End Get
    End Property

    Public Overloads Sub Escuchar(palabra As String)
        Dim recordar As Boolean = recordar
        If recordar = True Then
            _memoria.Enqueue(palabra)
            _memoria.Dequeue()
            recordar = False
        Else
            _memoria.Enqueue(palabra)
            recordar = True
        End If
    End Sub

End Class
