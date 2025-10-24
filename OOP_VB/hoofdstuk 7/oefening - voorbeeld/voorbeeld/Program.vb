Imports System

Module Program

    Class Voetballer
        Protected intNummer As Integer
        Protected intPositie As Integer
        Protected strNaam As String
        Protected dblMassa As Double

        Public Sub New(intNummer As Integer, intPositie As Integer, strNaam As String, dblMassa As Double)
            Me.intNummer = intNummer
            Me.intPositie = intPositie
            Me.strNaam = strNaam
            Me.dblMassa = dblMassa
        End Sub

        Public Overridable Sub Speel()
            Console.WriteLine("ik speel voetbal,haha")
        End Sub
    End Class


    Class Aanvaller
        Inherits Voetballer
        Public Sub New(strNaam As String, dblMassa As Double)
            MyBase.New(10, 10, strNaam, dblMassa)
        End Sub

        Public Overrides Sub Speel()
            Console.WriteLine("ik speel aanvaller")
        End Sub

    End Class


    Sub Main(args As String())
        Console.WriteLine("Hello World!")

        Dim objMessi As New Aanvaller("messi", 66.9)
        objMessi.Speel()

    End Sub
End Module
