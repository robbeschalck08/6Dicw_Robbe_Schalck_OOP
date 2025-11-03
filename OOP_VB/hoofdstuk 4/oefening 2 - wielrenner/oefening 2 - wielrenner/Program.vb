Imports System

Module Program
    Class Wielrenner
        Public intLeeftijd As Integer
        Public strGeboortePlaats As String
        Public intGewicht As Integer
        Public blnOnder25 As Boolean
        Public intLengte As Integer
        Public intPuntenTimeTrail As Integer

        Public Sub New(intLeeftijd As Integer, strGeboortePlaats As String, intGewicht As Integer, blnOnder25 As Boolean, intLengte As Integer, intPuntenTimeTrail As Integer)
            Me.intLeeftijd = intLeeftijd
            Me.strGeboortePlaats = strGeboortePlaats
            Me.intGewicht = intGewicht
            Me.blnOnder25 = blnOnder25
            Me.intLengte = intLengte
            Me.intPuntenTimeTrail = intPuntenTimeTrail
        End Sub

    End Class
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Dim objTadej As New Wielrenner(24, "Slovenia", 66, True, 176, 1611)
        Dim objWout As New Wielrenner(28, "Belgium", 78, False, 190, 2116)
        Console.WriteLine(objTadej.intPuntenTimeTrail)
        Console.WriteLine(objWout.intPuntenTimeTrail)
    End Sub
End Module
