Imports System

Module Program
    Sub Main(args As String())
        Dim corriente As Double = 0.015
        Dim resistencia As Double = 470
        Dim voltaje As Double = corriente * resistencia
        Console.WriteLine("Voltaje: {0:F2} V", voltaje)
        Console.ReadKey()
    End Sub
End Module
