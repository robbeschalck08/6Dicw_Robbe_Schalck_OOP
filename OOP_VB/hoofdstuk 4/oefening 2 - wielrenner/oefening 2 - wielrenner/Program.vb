Imports System

Module Program
    Class Wielrenner
        Public intLeeftijd As Integer
        Public strGeboortePlaats As String
        Public intGewicht As Integer
        Public blnOnder25 As Boolean
        Public intLengte As Integer
        Public intAantalPunten As Integer

        Public Sub New(intLeeftijd As Integer, strGeboortePlaats As String, intGewicht As Integer, blnOnder25 As Boolean, intLengte As Integer, intAantalPunten As Integer)
            Me.intLeeftijd = intLeeftijd
            Me.strGeboortePlaats = strGeboortePlaats
            Me.intGewicht = intGewicht
            Me.blnOnder25 = blnOnder25
            Me.intLengte = intLengte
            Me.intAantalPunten = intAantalPunten
        End Sub
    End Class
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Dim objWout As New Wielrenner(28, "Belgium", 78, False, 190, 2116)
        Dim objRobbe As New Wielrenner(17, "Belgium", 78, True, 188, 3000)

    End Sub
End Module
