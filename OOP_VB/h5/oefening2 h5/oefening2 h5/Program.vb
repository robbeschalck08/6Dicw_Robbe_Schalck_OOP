Imports System



Module Program

    Class Voetballer
        Public StrNaam As String
        Public intLeeftijd As Integer
        Public intGeleKaarten As Integer

        Sub New(Naam As String, Leeftijd As Integer)
            Me.StrNaam = Naam
            Me.intLeeftijd = Leeftijd
            Me.intGeleKaarten = 0
        End Sub

    End Class
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
    End Sub
End Module
