Module Program
    Sub Main()
        Console.Write("Voltaje medido: ")
        Dim voltaje As Double = CDbl(Console.ReadLine())
        If voltaje > 5 Then
            Console.WriteLine("Cuidado: voltaje muy alto")
        Else
            Console.WriteLine("Voltaje seguro")
        End If
        Console.ReadKey()
    End Sub
End Module