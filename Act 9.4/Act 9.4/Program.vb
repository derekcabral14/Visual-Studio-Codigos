Imports System

Module Program
    Sub Main(args As String())
        Console.Write("Nota1:")
        Dim n1 As Integer = CInt(Console.ReadLine())
        Console.Write("Nota2:")
        Dim n2 As Integer = CInt(Console.ReadLine())
        Console.Write("Nota3:")
        Dim n3 As Integer = CInt(Console.ReadLine())
        Dim suma As Integer = n1 + n2 + n3
        Dim prom As Double = suma / 3
        Console.WriteLine("Promedio: {0:F2}", prom)
        Console.ReadKey()
    End Sub
End Module
