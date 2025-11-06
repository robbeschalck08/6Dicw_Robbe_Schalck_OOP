Imports System

Module Program
    Class Speler
        Protected strNaam As String

        Public Sub New(strNaam As String)
            Me.strNaam = strNaam
        End Sub

        Public Overridable Sub Trapbal()
            Console.WriteLine("ik trap de bal")
        End Sub
    End Class

    Class Aanvaller
        Inherits Speler
        Dim objRandom As New Random
        Private Test As Integer

        Public Sub New(strNaam As String)
            MyBase.New(strNaam)
        End Sub

        Public Overrides Sub Trapbal()
            Test = objRandom.Next(0, 10)
            If (Test < 4) Then
                Console.WriteLine("de aanvaller raakt")
            Else
                Console.WriteLine("de aanvaller mist")
            End If
        End Sub
    End Class

    Class Verdediger
        Inherits Speler
        Dim objRandom As New Random
        Private Test As Integer

        Public Sub New(strNaam As String)
            MyBase.New(strNaam)
        End Sub

        Public Overrides Sub Trapbal()
            Test = objRandom.Next(0, 10)
            If (Test > 2) Then
                Console.WriteLine("de verdediger raakt")
            Else
                Console.WriteLine("de verdediger mist")
            End If
        End Sub
    End Class
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
    End Sub
End Module
