Module Module1

    Sub Main()
        'déclaration des variables 
        Dim valeurentree As String = ""
        Dim valeur1 As Double
        Dim valeur2 As Double
        'recupération du 1er nombre

        Console.WriteLine(" Addition de deux nombres")
            Do
                Console.WriteLine("Entrer le premier nombre")

            valeurentree = Console.ReadLine()
        Loop Until IsNumeric(valeurentree)
        valeur1 = valeurentree

        ' récupération du 2ème nombre
        Do
            Console.WriteLine("Entrer la deuxième valeur")
            valeurentree = Console.ReadLine()
        Loop Until IsNumeric(valeurentree)
        valeur2 = valeurentree

        'addition 
        Console.WriteLine(valeur1 & " + " & valeur2 & " = " & valeur1 + valeur2)

        Console.Read()

        MsgBox("test")
    End Sub

End Module
