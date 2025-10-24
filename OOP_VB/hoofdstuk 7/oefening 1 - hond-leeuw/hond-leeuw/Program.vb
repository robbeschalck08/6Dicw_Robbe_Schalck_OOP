Imports System

Module Program
    Class dier
        Protected strkleur As String

        Public Sub New(strKleur As String)
            Me.strkleur = strKleur
        End Sub
        Public Sub eet()
            Console.WriteLine("lekker")
        End Sub

        Public Sub slaap()
            Console.WriteLine("snurk snurk")
        End Sub

    End Class

    Class Hond
        Inherits dier
        Private strbaasje As String

        Public Sub New(strKleur As String, strbaasje As String)
            MyBase.New(strKleur)
            Me.strbaasje = strbaasje
        End Sub

        Public Sub blaf()
            Console.WriteLine("woef woef")
        End Sub
        Public Function geefeigenaar() As String
            Return strbaasje
        End Function

        Public Sub zetEigenaar(strbaasje As String)
            Me.strbaasje = strbaasje
        End Sub

        Public Sub PrintInformatie()
            Console.WriteLine("kleur:" & strkleur)
            Console.WriteLine("baasje:" & strbaasje)
        End Sub
    End Class

    Class Leeuw
        Inherits dier
        Public strJungleNaam As String

        Public Sub New(strKleur As String, strJungleNaam As String)
            MyBase.New(strKleur)
            Me.strJungleNaam = strJungleNaam
        End Sub
        Public Sub brult()
            Console.WriteLine("rowrrr")
        End Sub
        Public Function geefJungle() As String
            Return strJungleNaam
        End Function

        Public Sub zetJungle(strJungleNaam As String)
            Me.strJungleNaam = strJungleNaam
        End Sub
        Public Sub PrintInformatie()
            Console.WriteLine("kleur:" & strkleur)
            Console.WriteLine("jungle:" & strJungleNaam)
        End Sub
    End Class
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Dim objHond As New Hond("blond", "robbe")
        Dim objLeeuw As New Leeuw("oranje", "jungle")
        objHond.PrintInformatie()
        objLeeuw.PrintInformatie()

    End Sub
End Module
