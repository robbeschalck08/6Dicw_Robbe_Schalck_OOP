Imports System

Module Program

    Class Cirkel
        Public strKleur As String
        Public intStraal As Integer

        Public Sub New()
            Me.strKleur = "geel"
            Me.intStraal = "2"
        End Sub
    End Class
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Dim objCirkel As New Cirkel()
        Console.WriteLine("De cirkel heeft kleur: " & objCirkel.strKleur)
        Console.WriteLine("De cirkel heeft straal (in cm): " & objCirkel.intStraal)
    End Sub
End Module
