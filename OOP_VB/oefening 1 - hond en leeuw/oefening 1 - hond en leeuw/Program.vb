Imports System

Module Program
    Class Dier
        Protected intKleur As Integer

        Public Sub New(intKleur As Integer)
            Me.intKleur = intKleur
        End Sub

        Public Function Eet()
            Return "njam njam"
        End Function

        Public Function Slaap()
            Return "snork snork"
        End Function
    End Class

    Class Hond
        Inherits Dier
        Private strBaasje As String

        Public Sub New(intKleur As Integer, strBaasje As String)
            MyBase.New(intKleur)
            Me.strBaasje = strBaasje
        End Sub

        Public Sub Blaf()
            Console.WriteLine("roewrr")
        End Sub

        Public Function GeefEigenaar()
            Return strBaasje
        End Function

        Public Sub zetEigenaar(strBaasje As String)
            Me.strBaasje = strBaasje
        End Sub
    End Class

    Class Leeuw
        Inherits Dier
        Private strJungleNaam As String

        Public Sub New(intKleur As Integer, strJungleNaam As String)
            MyBase.New(intKleur)
            Me.strJungleNaam = strJungleNaam
        End Sub

        Public Sub Brult()
            Console.WriteLine("roewrr")
        End Sub

        Public Function GeefJungle()
            Return strJungleNaam
        End Function

        Public Sub ZetJungle(strJungleNaam As String)
            Me.strJungleNaam = strJungleNaam
        End Sub
    End Class

    Sub Main(args As String())
        Console.WriteLine("Hello World!")
    End Sub
End Module
