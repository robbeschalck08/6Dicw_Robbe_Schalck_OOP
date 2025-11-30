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
            Console.WriteLine("Klant met naam: " & strKlantNaam)
            Console.WriteLine("Totaal bedrag van bestelling: " & dblTotaalBedrag)
        End Sub

        Public Overridable Function BerekenVerzendkosten()
            Return "totale verzendkosten zijn: 5 Euro"
        End Function

    End Class

    Class SnelleLevering
        Inherits Bestelling
        Public dblSpoedToeslag As Integer
        Public hulpje As Integer

        Public Sub New(strKlantNaam As String, dblTotaalBedrag As Double)
            MyBase.New(strKlantNaam, dblTotaalBedrag)
            Me.dblSpoedToeslag = 10
        End Sub

        Public Overrides Function BerekenVerzendkosten()
            hulpje = 5 + Me.dblSpoedToeslag
            Return "Totale verzendkosten zijn: " & hulpje
        End Function

    End Class

    Class InternationaleBestelling
        Inherits Bestelling
        Public strLand As String
        Public hulpje As Integer
        Public douaneKosten As Integer

        Public Sub New(strKlantNaam As String, dblTotaalBedrag As Double, strLand As String)
            MyBase.New(strKlantNaam, dblTotaalBedrag)
            Me.strLand = strLand
        End Sub

        Public Function BerekenDouaneKosten()
            douaneKosten = dblTotaalBedrag / 100 * 10
            Return "douanekosten zijn: " & douaneKosten
        End Function

        Public Overrides Function BerekenVerzendkosten()
            hulpje = 5 + dblTotaalBedrag / 100 * 10
            Return "Totale verzendkosten zijn: " & hulpje
        End Function
    End Class

    Class Verzending
        Public strVerzendType As String

        Public Sub New(strVerzendType)
            Me.strVerzendType = strVerzendType
        End Sub

        Public Overridable Function BerekenVerzendKosten()
            Return 3 & " Euro"
        End Function
    End Class

    Class PakketVerzending
        Inherits Verzending
        Public strPakketgrootte As String

        Public Sub New(strVerzendType As String, strPakketgrootte As String)
            MyBase.New(strVerzendType)
            Me.strPakketgrootte = strPakketgrootte
        End Sub

        Public Overrides Function BerekenVerzendKosten()
            If strPakketgrootte = "klein" Then
                Return "Verzendkosten voor pakket met grootte: klein is: " & 3 & " Euro"
            ElseIf strPakketgrootte = "middelgroot" Then
                Return "Verzendkosten voor pakket met grootte: middelgroot is: " & 5 & " Euro"
            Else
                Return "Verzendkosten voor pakket met grootte: groot is: " & 8 & " Euro"
            End If
        End Function
    End Class

    Class Luchtpost
        Inherits Verzending
        Public dblLuchttarief As Double
        Public hulpje As Integer

        Public Sub New(strVerzendType As String)
            MyBase.New(strVerzendType)
            Me.dblLuchttarief = 15
        End Sub

        Public Overrides Function BerekenVerzendKosten()
            hulpje = 3 + dblLuchttarief
            Return "Verzendkosten voor luchtpakket zijn: " & hulpje & " Euro"
        End Function

    End Class

    Sub Main(args As String())
        Dim objSnelleLevering As New SnelleLevering("jansen", 100)
        objSnelleLevering.ToonBestelDetails()
        Console.WriteLine(objSnelleLevering.BerekenVerzendkosten())
        Console.WriteLine("---")
        Dim objInternationaleBestelling As New InternationaleBestelling("Martinez", 200, "Frankrijk")
        objInternationaleBestelling.ToonBestelDetails()
        Console.WriteLine(objInternationaleBestelling.BerekenDouaneKosten())
        Console.WriteLine(objInternationaleBestelling.BerekenVerzendkosten())
        Dim objPakket As New PakketVerzending("Pakket", "middelgroot")
        Console.WriteLine("---")
        Console.WriteLine(objPakket.BerekenVerzendKosten())
        Console.WriteLine("---")
        Dim objLuchtpost As New Luchtpost("Luchtpost")
        Console.WriteLine(objLuchtpost.BerekenVerzendKosten())
        Console.WriteLine("---")
    End Sub
End Module

