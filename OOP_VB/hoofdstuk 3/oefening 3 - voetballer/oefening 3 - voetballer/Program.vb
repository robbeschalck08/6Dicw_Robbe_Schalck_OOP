Imports System

Module Program
    Class Voetballer
        Private strNaam As String
        Private strBijnaam As String
        Private intGeboorteJaar As Integer
        Private intLengte As Integer

        Public Sub New()
            Me.strNaam = "Ronaldo"
            Me.strBijnaam = "CR7"
            Me.intGeboorteJaar = 1985
            Me.intLengte = 187
        End Sub
    End Class
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Dim objRonaldo As New Voetballer()
    End Sub
End Module
