
Imports System

Module Program
    Sub Main(args As String())
        Dim nota As Integer
        Console.Write("Ingresa una nota del (0 a 100): ")
        nota = Integer.Parse(Console.ReadLine())
        If nota > 100 OrElse nota < 0 Then
            Console.WriteLine("Nota inválida. Por favor, ingresa una nota entre 0 a 100 en la proxima vez.")
        End If
        If nota >= 90 Then
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine(" A :D")
            Console.ResetColor()
        ElseIf nota >= 80 Then
            Console.ForegroundColor = ConsoleColor.Yellow
            Console.WriteLine(" B :)")
            Console.ResetColor()
        ElseIf nota >= 70 Then
            Console.ForegroundColor = ConsoleColor.DarkYellow
            Console.WriteLine(" C ._.")
            Console.ResetColor()
        ElseIf nota >= 60 Then
            Console.ForegroundColor = ConsoleColor.DarkGray
            Console.WriteLine(" D .-.")
            Console.ResetColor()
        Else
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine(" F ;(")
            Console.ResetColor()
        End If
    End Sub
End Module
