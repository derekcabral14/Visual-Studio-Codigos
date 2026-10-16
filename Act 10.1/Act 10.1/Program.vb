Module Program
    Sub Main()
        Console.Write("Nota: ")
        Dim nota As Integer = CInt(Console.ReadLine())
        If nota >= 70 Then
            Console.WriteLine("Aprobado")
        Else
            Console.WriteLine("Reprobado")
        End If
        Console.ReadKey()
    End Sub
End Module