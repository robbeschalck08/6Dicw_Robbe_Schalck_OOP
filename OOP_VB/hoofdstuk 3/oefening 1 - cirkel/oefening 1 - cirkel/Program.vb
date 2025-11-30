Imports System

Module Program
    Class Cirkel
        Private strKleur As String
        Private intStraal As Integer

        Public Sub New()
            Me.strKleur = "geel"
            Me.intStraal = 2
        End Sub
    End Class
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Dim objCirkel As New Cirkel()
    End Sub
End Module
