Imports System
Imports System.Security.Cryptography.X509Certificates

Module Program
    Class Atleet
        Public strGeboortePlaats As String
        Public intLengteInCentimeter As Integer
        Public intGewichtInKilogram As Integer

        Public Sub New(strGeboortePlaats As String, intLengteInCentimeter As Integer, intGewichtInKilogram As Integer)
            Me.strGeboortePlaats = strGeboortePlaats
            Me.intLengteInCentimeter = intLengteInCentimeter
            Me.intGewichtInKilogram = intGewichtInKilogram
        End Sub

    End Class
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Dim objAtleet As New Atleet("Brussel", 184, 69.3)
        Console.WriteLine("Thiam is geboren in:" & objAtleet.strGeboortePlaats)
        Console.WriteLine("Thiam haar lengte (in cm):" & objAtleet.intLengteInCentimeter)
        Console.WriteLine("Thiam haar gewicht (in kg):" & objAtleet.intGewichtInKilogram)
    End Sub
End Module
