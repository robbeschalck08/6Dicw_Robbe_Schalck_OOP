Imports System

Module Program
    Class Voetballer
        Public strNaam As String
        Public intLeeftijd As Integer
        Public intAantalGeleKaarten As Integer

        Public Sub New(strNaam As String, intLeeftijd As Integer)
            Me.strNaam = strNaam
            Me.intLeeftijd = intLeeftijd
            Me.intAantalGeleKaarten = 0
        End Sub

        Public Function NaarKleedkamer()
            If intAantalGeleKaarten > 1 Then
                Return "Kleedkamer"
            Else
                Return "Spelen"
            End If
        End Function

        Public Sub GeefKaart()
            If intAantalGeleKaarten >= 1 Then
                intAantalGeleKaarten = 0
                intAantalGeleKaarten += 1
                Console.WriteLine("Ik geef nog een kaart")
            Else
                Console.WriteLine("Ik geef een kaart")
                intAantalGeleKaarten += 1
            End If
        End Sub
    End Class
    Sub Main(args As String())
        Dim objLukaku As New Voetballer("Lukaku", 30)
        Console.WriteLine(objLukaku.NaarKleedkamer())
        objLukaku.GeefKaart()
        objLukaku.GeefKaart()
        Console.WriteLine(objLukaku.NaarKleedkamer())
    End Sub
End Module
