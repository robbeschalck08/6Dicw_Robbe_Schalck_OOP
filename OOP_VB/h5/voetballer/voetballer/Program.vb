Imports System

Module Program
    Public Class Voetballer
        Public strNaam As String
        Public intLeeftijd As Integer
        Public intAantalGeleKaarten As Integer

        Public Sub New(strNaam As String, intLeeftijd As Integer, intAantalGeleKaarten As Integer)
            Me.strNaam = strNaam
            Me.intLeeftijd = intLeeftijd
            Me.intAantalGeleKaarten = intAantalGeleKaarten
        End Sub

        Public Function naarKleedkamer() As String
            If Me.intAantalGeleKaarten <= 1 Then
                Return "SPELEN"
            Else
                Return "KLEEDKAMER"
            End If
        End Function

        Public Sub geefKaart()
            If intAantalGeleKaarten >= 2 Then
                Me.intAantalGeleKaarten = 1
            ElseIf intAantalGeleKaarten = 0 Then
                Console.WriteLine("Ik geef een kaart")
            Else
                Console.WriteLine("ik geef nog een kaart")
            End If
            Me.intAantalGeleKaarten += 1
        End Sub
    End Class
    Sub Main(args As String())
        Dim objVoetballer As New Voetballer("Lukaku", 38, 0)
        Console.WriteLine("moet ik naar de kleedkamer:" & objVoetballer.naarKleedkamer)
        objVoetballer.geefKaart()
        objVoetballer.geefKaart()
        Console.WriteLine("moet ik naar de kleedkamer:" & objVoetballer.naarKleedkamer)
    End Sub
End Module
