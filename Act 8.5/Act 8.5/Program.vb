Imports System

Module Program
    Sub Main(args As String())
        Console.Write("Voltaje medido: ")
        Dim voltaje As Double = CDbl(Console.ReadLine())
        Console.WriteLine($"Mediste {voltaje} V")
        Console.ReadKey()
    End Sub
End Module
