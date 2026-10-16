Imports System

Module Program
    Sub Main(args As String())
        Console.Write("¿Cómo te llamas? ")
        Dim nombre As String = Console.ReadLine()
        Console.Write("¿Cuántos años tienes? ")
        Dim edad As Integer = CInt(Console.ReadLine())
        Console.WriteLine($"Hola {nombre}, tienes {edad} años")
        Console.ReadKey()
    End Sub
End Module
