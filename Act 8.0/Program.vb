Imports System

Module Program
    Sub Main(args As String())
        Console.BackgroundColor = ConsoleColor.Black
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("¿Como te llamas?")
        Dim nombre As String = Console.ReadLine()
        Console.BackgroundColor = ConsoleColor.Black
        Console.ForegroundColor = ConsoleColor.Blue
        Console.WriteLine($"Un placer, {nombre}")
        Console.ReadKey()
    End Sub
End Module