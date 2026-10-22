Imports System

Module Program
    Sub Main()
        Console.WriteLine("Seleccionar un modo")
        Console.WriteLine("1. Medir Voltaje")
        Console.WriteLine("2. Medir corriente en CD")
        Console.WriteLine("3. Medir corriente en CA")
        Console.WriteLine("4. Probar continuidad")
        Console.WriteLine("5. Probar diodo")
        Console.WriteLine("7. Probar resistencia")
        Console.WriteLine("6. Probar capacitancia")
        Console.WriteLine("8. Probar frecuencia")
        Console.WriteLine("9. Salir")
        Console.WriteLine(" ")
        Console.Write("Ingrese su elección: ")
        Dim Modo As Integer = CInt(Console.ReadLine())
        Select Case Modo
            Case 1
                Console.Write("Medir Voltaje")
            Case 2
                Console.Write("Medir Corriente en CD")
            Case 3
                Console.Write("Medir Corriente en CA")
            Case 4
                Console.Write("Probar Continuidad")
            Case 5
                Console.Write("Probar Diodo")
            Case 6
                Console.Write("Probar Capacitancia")
            Case 7
                Console.Write("Probar Resistencia")
            Case 8
                Console.Write("Probar Frecuencia")
            Case 9
                Console.Write("Salir")
            Case Else
                Console.Write("Opción no válida")
        End Select
        Console.ReadKey()
    End Sub
End Module
