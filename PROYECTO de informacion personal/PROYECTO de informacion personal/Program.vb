Imports System

Module Program
    Sub Main(args As String())
        Console.Title = "Datos personales"
        Console.WriteLine("¿Cuál es tu nombre?")
        Dim Nombre As String = Console.ReadLine()
        'Nombre listo
        Console.WriteLine("¿Cuál es tu apellido?")
        Dim Apellido As String = Console.ReadLine()
        'Apellido listo
        Console.WriteLine("¿Cuál es tu edad?")
        Dim Edad As Integer = CInt(Console.ReadLine())
        'Edad listo
        Console.WriteLine("¿Cuál es tu Fecha de nacimiento?")
        Dim Fec_naci As String = Console.ReadLine()
        'Fec_naci listo
        Console.WriteLine("¿Cuál es tu taller?")
        Dim Taller As String = Console.ReadLine()
        'Nombre listo
        Console.WriteLine("¿Cuál es tu asignatura?")
        Dim Asignatura As String = Console.ReadLine()

        Console.WriteLine(" ")
        Console.ForegroundColor = ConsoleColor.Blue
        Console.WriteLine("Nombre:" & Nombre)
        Console.WriteLine("Apellido:" & Apellido)
        Console.WriteLine("Edad:" & Edad)
        Console.WriteLine("Fecha de nacimiento:" & Fec_naci)
        Console.WriteLine("Taller:" & Taller)
        Console.WriteLine("Asignatura:" & Asignatura)
    End Sub
End Module
