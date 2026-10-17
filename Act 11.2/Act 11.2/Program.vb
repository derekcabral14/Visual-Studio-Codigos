Module Program
    Sub Main(args As String())
        Console.Write("Ingresa tu edad: ")
        Dim edad As Integer = Integer.Parse(Console.ReadLine())

        Console.Write("Ingresa tus horas de taller: ")
        Dim horas As Integer = Integer.Parse(Console.ReadLine())

        If edad >= 15 AndAlso horas >= 40 Then
            Console.WriteLine("Certificado")
        Else
            Console.WriteLine("No cumples con los requisitos para el certificado ;(")
        End If
    End Sub
End Module
