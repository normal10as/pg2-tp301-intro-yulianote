Imports Entidades

Module Cotorratest
    Sub Main()
        Dim palabra As Cotorra
        palabra = New Cotorra
        palabra.Escuchar("papita")
        Console.WriteLine(palabra.Hablar())
        palabra.Escuchar("pa el loro")
        Console.WriteLine(palabra.Hablar())
        palabra.Escuchar("juan")
        Console.WriteLine(palabra.Hablar())
        palabra.Escuchar("aguante river")
        Console.WriteLine(palabra.Hablar())
    End Sub
End Module
