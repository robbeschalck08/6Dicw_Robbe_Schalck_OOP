Imports System

Module Program
    Class Film
        Private strTitel As String
        Private intJaar As Integer
        Private strRegisseur As String
        Private dblRating As Double

        Public Sub New()
            Me.strTitel = "Pulp fiction"
            Me.intJaar = 1984
            Me.strRegisseur = "Patrick"
            Me.dblRating = 8.9
        End Sub
    End Class
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Dim objPulpFiction As New Film()
    End Sub
End Module
