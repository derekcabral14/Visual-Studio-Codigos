Module Program
    Sub Main()
        Console.Write("Voltaje medido: ")
        Dim voltaje As Double = CDbl(Console.ReadLine())
        If voltaje > 5 Then
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("Voltaje alto")
            Console.ResetColor()
        Else
            Console.ForegroundColor = ConsoleColor.Blue
            Console.WriteLine("Voltaje seguro")
            Console.ResetColor()
        End If
        Console.ReadKey()
    End Sub
End Module