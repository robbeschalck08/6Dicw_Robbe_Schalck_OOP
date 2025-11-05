Imports System

Module Program

    Class Voetballer
        Public strNaam As String
        Public intLeeftijd As Integer
        Public intGeleKaarten As Integer

        Public Sub New(strNaam As String, intLeeftijd As Integer)
            Me.strNaam = strNaam
            Me.intLeeftijd = intLeeftijd
            Me.intGeleKaarten = 0
        End Sub

        Public Function NaarKleedkamer() As String
            If Me.intGeleKaarten > 1 Then
                Return "Kleedkamer"
            Else
                Return "Spelen"
            End If
        End Function

        Public Sub GeefKaart()
            If intGeleKaarten >= 2 Then
                intGeleKaarten = 1
            ElseIf intGeleKaarten = 0 Then
                Console.WriteLine("Ik geef een kaart")
            Else
                Console.WriteLine("Ik geef nog een kaart")
            End If
            Me.intGeleKaarten += 1
        End Sub
    End Class
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Dim objVoetballer As New Voetballer("messi", 20)
        objVoetballer.GeefKaart()
        Console.WriteLine(objVoetballer.NaarKleedkamer())
    End Sub
End Module
