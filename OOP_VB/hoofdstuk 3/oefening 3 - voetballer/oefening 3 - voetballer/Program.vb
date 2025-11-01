Imports System

Module Program
    Class Voetballer
        Public strNaam As String
        Public strBijnaam As String
        Public strGeboorteDatum As String
        Public strGeboortePlaats As String
        Public intLengte As Integer
        Public strBeen As String
        Public strPositie As String

        Public Sub New()
            Me.strNaam = "Cristiano Ronaldo"
            Me.strBijnaam = "CR7"
            Me.strGeboorteDatum = "5 Februari 1985"
            Me.strGeboortePlaats = "Portugal"
            Me.intLengte = 187
            Me.strBeen = "Rechts"
            Me.strPositie = "Aanvaller"
        End Sub

    End Class
    Sub Main(args As String())
        Dim objRonaldo As New Voetballer()
        Console.WriteLine("naam: " & objRonaldo.strNaam)
        Console.WriteLine("bijnaam: " & objRonaldo.strBijnaam)
        Console.WriteLine("geboortedatum: " & objRonaldo.strGeboorteDatum)
        Console.WriteLine("geboorteplaats: " & objRonaldo.strGeboortePlaats)
        Console.WriteLine("lengte: " & objRonaldo.intLengte)
        Console.WriteLine("voorkeur been: " & objRonaldo.strBeen)
        Console.WriteLine("positie: " & objRonaldo.strPositie)
    End Sub
End Module
