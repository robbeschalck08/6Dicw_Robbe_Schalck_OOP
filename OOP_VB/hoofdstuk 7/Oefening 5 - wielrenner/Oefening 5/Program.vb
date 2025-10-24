Imports System

Module Program

    Class Wielrenner
        Protected strNaam As String
        Protected intLeeftijd As Integer
        Protected strPloeg As String

        Public Sub New(strNaam As String, intLeeftijd As Integer, strPloeg As String)
            Me.strNaam = strNaam
            Me.intLeeftijd = intLeeftijd
            Me.strPloeg = strPloeg
        End Sub

        Public Sub ToonNaam()
            Console.WriteLine("Naam: " & strNaam)
        End Sub

        Public Sub ToonLeeftijd()
            Console.WriteLine("Leeftijd: " & intLeeftijd)
        End Sub

        Public Sub ToonPloeg()
            Console.WriteLine("Ploeg: " & strPloeg)
        End Sub

    End Class

    Class ProfWielrenner
        Inherits Wielrenner
        Private intAantalOverwinningen As Integer
        Private dblSalaris As Double

        Public Sub New(strNaam As String, intLeeftijd As Integer, strPloeg As String, intAantalOverwinningen As Integer, dblSalaris As Double)
            MyBase.New(strNaam, intLeeftijd, strPloeg)
            Me.intAantalOverwinningen = intAantalOverwinningen
            Me.dblSalaris = dblSalaris
        End Sub

        Public Sub ToonAantalOverwinningen()
            Console.WriteLine("Aantal Overwinningen: " & intAantalOverwinningen)
        End Sub

        Public Sub ToonSalaris()
            Console.WriteLine("Salaris: " & dblSalaris)
        End Sub
    End Class

    Class AmateurWielrenner
        Inherits Wielrenner
        Private intAantalDeelnames As Integer
        Private intAantalOverwinningen As Integer

        Public Sub New(strNaam As String, intLeeftijd As Integer, strPloeg As String, intAantalDeelnames As Integer, intAantalOverwinningen As Integer)
            MyBase.New(strNaam, intLeeftijd, strPloeg)
            Me.intAantalDeelnames = intAantalDeelnames
            Me.intAantalOverwinningen = intAantalOverwinningen
        End Sub

        Public Sub ToonAantalDeelnames()
            Console.WriteLine("Aantal Deelnames: " & intAantalDeelnames)
        End Sub

        Public Sub ToonAantalOverwinningen()
            Console.WriteLine("Aantal Overwinningen: " & intAantalOverwinningen)
        End Sub
    End Class

    Sub Main(args As String())
        Dim objRobbeSchalck As New AmateurWielrenner("Joris Custers", 25, "Wielerclub Evergem", 15, 3)
        objRobbeSchalck.ToonNaam()
        objRobbeSchalck.ToonLeeftijd()
        objRobbeSchalck.ToonPloeg()
        objRobbeSchalck.ToonAantalDeelnames()
        objRobbeSchalck.ToonAantalOverwinningen()
        Console.WriteLine()

        Dim objLarsVermeulen As New AmateurWielrenner("Jan Persan", 30, "Wielerclub Evergem", 50, 13)
        objLarsVermeulen.ToonNaam()
        objLarsVermeulen.ToonLeeftijd()
        objLarsVermeulen.ToonPloeg()
        objLarsVermeulen.ToonAantalDeelnames()
        objLarsVermeulen.ToonAantalOverwinningen()
        Console.WriteLine()

        Dim objVanDerPoel As New ProfWielrenner("Wout van Aert", 28, "Jumbo-Visma", 45, 4500000)
        objVanDerPoel.ToonNaam()
        objVanDerPoel.ToonLeeftijd()
        objVanDerPoel.ToonPloeg()
        objVanDerPoel.ToonAantalOverwinningen()
        objVanDerPoel.ToonSalaris()
    End Sub
End Module
