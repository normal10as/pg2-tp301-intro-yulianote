Imports Entidades

Module Lorotests

    Sub Main()
        Dim texto As Loro
        texto = New Loro
        texto.Escuchar("papita")
        Console.WriteLine(texto.Hablar())
        texto.Escuchar("pa el loro")
        Console.WriteLine(texto.Hablar())
        texto.Escuchar("juan")
        Console.WriteLine(texto.Hablar())
        texto.Escuchar("aguante river")
        Console.WriteLine(texto.Hablar())
        'Dim edad_loro As Loro
        'Dim edad_cumplio As UShort
        'Dim edad_nocumplio As UShort
        'edad_loro = New Loro
        'edad_cumplio = edad_loro.CalcularEdad("28/2/2010")
        'edad_nocumplio = edad_loro.CalcularEdad("28/8/2010")
        'Console.WriteLine(edad_cumplio)
        'Console.WriteLine(edad_nocumplio)
    End Sub

End Module
