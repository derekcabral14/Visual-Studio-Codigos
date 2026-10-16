Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("tu edad:")
        Dim edad As Integer = CInt(Console.ReadLine())
        Console.WriteLine($"Tu edad es:{edad}")
        Console.ReadKey()
    End Sub
End Module
