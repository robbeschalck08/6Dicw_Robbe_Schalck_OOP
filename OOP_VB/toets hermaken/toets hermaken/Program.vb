Imports System

Module Program
    Class Bestelling
        Protected strKlantNaam As String
        Protected dblTotaalBedrag As Double

        Public Sub New(strKlantNaam As String, dblTotaalBedrag As Double)
            Me.strKlantNaam = strKlantNaam
            Me.dblTotaalBedrag = dblTotaalBedrag
        End Sub

        Public Sub ToonBestelDetails()
            Console.WriteLine("klant met naam: " & strKlantNaam)
            Console.WriteLine("Totaal bedrag van bestelling: " & dblTotaalBedrag)
        End Sub

        Public Overridable Function BerekenVerzendKosten()
            Return 5 & " euro"
        End Function
    End Class

    Class SnelleLevering
        Inherits Bestelling
        Private dblSpoedToeslag As Double

        Public Sub New(strKlantNaam As String, dblTotaalBedrag As Double)
            MyBase.New(strKlantNaam, dblTotaalBedrag)
            Me.dblSpoedToeslag = 10.0
        End Sub

        Public Overrides Function BerekenVerzendKosten()
            Return 5 + dblSpoedToeslag
        End Function
    End Class

    Class InternationaleBestelling
        Inherits Bestelling
        Private strLand As String

        Public Sub New(strKlantNaam As String, dblTotaalBedrag As Double, strLand As String)
            MyBase.New(strKlantNaam, dblTotaalBedrag)
            Me.strLand = strLand
        End Sub

        Public Function BerekenDuaneKosten()
            Return (dblTotaalBedrag / 100 * 10)
        End Function

        Public Overrides Function BerekenVerzendKosten()
            Return 5 + BerekenDuaneKosten()
        End Function
    End Class

    Class Verzending
        Protected strVerzendType As String

        Public Sub New(strVerzendType As String)
            Me.strVerzendType = strVerzendType
        End Sub

        Public Overridable Function BerekenVerzendKosten()
            Return 3 + " euro"
        End Function
    End Class

    Class PakketVerzending
        Inherits Verzending
        Private strPakketgrootte As String

        Public Sub New(strVerzendType As String, strPakketgrootte As String)
            MyBase.New(strVerzendType)
            Me.strPakketgrootte = strPakketgrootte
        End Sub

        Public Overrides Function BerekenVerzendKosten()
            If strPakketgrootte = "klein" Then
                Return 3.0
            ElseIf strPakketgrootte = "middelgroot" Then
                Return 5.0
            Else
                Return 8.0
            End If
        End Function
    End Class

    Class Luchtpost
        Inherits Verzending
        Private dblLuchttarief As Double

        Public Sub New(strVerzendType As String)
            MyBase.New(strVerzendType)
            Me.dblLuchttarief = 15.0
        End Sub

        Public Overrides Function BerekenVerzendKosten() As Object
            Return 3 + dblLuchttarief
        End Function

    End Class
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Dim objSnelleLevering As New SnelleLevering("jansen", 100)
        objSnelleLevering.ToonBestelDetails()
        Console.WriteLine("Totale verzendkosten zijn: " & objSnelleLevering.BerekenVerzendKosten())
        Console.WriteLine("---")

        Dim objInternationaleBestelling As New InternationaleBestelling("Martinez", 200.0, "Frankrijk")
        Console.WriteLine(objInternationaleBestelling.BerekenVerzendKosten())

        Dim objPakketVerzending As New PakketVerzending("Pakket", "middelgroot")
        Console.WriteLine(objPakketVerzending.BerekenVerzendKosten())

        Dim objLuchtpost As New Luchtpost("Luchtpost")
        Console.WriteLine(objLuchtpost.BerekenVerzendKosten())

    End Sub
End Module
