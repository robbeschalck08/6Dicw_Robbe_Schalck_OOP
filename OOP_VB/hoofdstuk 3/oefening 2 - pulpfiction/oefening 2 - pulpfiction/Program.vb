Imports System
Imports System.Security.Cryptography.X509Certificates

Module Program
    Class Film
        Public strFilm As String
        Public intJaar As Integer
        Public strRegisseur As String
        Public intDuur As Integer
        Public dblRating As Double

        Public Sub New()
            Me.strFilm = "pulp fiction"
            Me.intJaar = 1994
            Me.strRegisseur = "Quentin Tarantino"
            Me.intDuur = "154"
            Me.dblRating = "4,5"
        End Sub
    End Class
    Sub Main(args As String())
        Dim publicobjPulpFiction As New Film()
        Console.WriteLine("film: " & publicobjPulpFiction.strFilm)
        Console.WriteLine("jaar: " & publicobjPulpFiction.intJaar)
        Console.WriteLine("regisseur: " & publicobjPulpFiction.strRegisseur)
        Console.WriteLine("duur (in minuten): " & publicobjPulpFiction.intDuur)
        Console.WriteLine("rating: " & publicobjPulpFiction.dblRating)
    End Sub
End Module
