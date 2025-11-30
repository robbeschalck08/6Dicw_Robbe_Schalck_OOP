Imports System

Module Program
    Class Auto
        Public dblBandenspanning As Double

        Public Sub New()
            Me.dblBandenspanning = 5.0
            Console.WriteLine("ik maak een nieuwe auto met banden van " & dblBandenspanning & " bar!")
        End Sub

        Public Sub GaOpVakantie()
            dblBandenspanning -= 1.0
            Console.WriteLine("ik ga op vakantie")
        End Sub

        Public Sub PompBandenOp()
            dblBandenspanning = 5.0
        End Sub

        Public Function GeefStaatWagenWeer()
            If dblBandenspanning > 3 Then
                Return "Alles is in orde!"
            Else
                Return "Pompen maar tot 5 bar opnieuw!"
            End If
        End Function



    End Class
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Dim objAudi As New Auto()
        Console.WriteLine("Bandendruk is (bar): " & objAudi.dblBandenspanning)
        objAudi.gaOpVakantie()
        Console.WriteLine("Bandendruk is (bar): " & objAudi.dblBandenspanning)
        Console.WriteLine(objAudi.GeefStaatWagenWeer())
        Console.WriteLine("Bandendruk is (bar): " & objAudi.dblBandenspanning)
    End Sub
End Module
