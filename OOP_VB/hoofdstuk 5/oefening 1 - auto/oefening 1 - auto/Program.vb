Imports System

Module Program

    Class Auto
        Public dblBandenspanning As Double

        Public Sub New()
            Me.dblBandenspanning = 5.0
            Console.WriteLine("Ik maak een nieuwe auto met banden van 5.0 bar!")
        End Sub

        Public Sub GaOpVakantie()
            dblBandenspanning -= 1.0
            Console.WriteLine("ik ben op vakantie gegaan!")
        End Sub

        Public Sub PompBandenOp()
            dblBandenspanning = 5.0
            Console.WriteLine("banden terug tot 5.0 bar opgepompt!")
        End Sub

        Public Function GeefStaatWagenWeer()
            If dblBandenspanning > 3.0 Then
                Console.WriteLine("bandenspanning is in orde (bar): " & dblBandenspanning)
            Else
                Console.WriteLine("bandenspanning is niet in orde (bar): " & dblBandenspanning)
            End If
        End Function
    End Class
    Sub Main(args As String())
        Dim objAudi As New Auto()
        objAudi.GeefStaatWagenWeer()
        objAudi.GaOpVakantie()
        objAudi.GaOpVakantie()
        objAudi.GaOpVakantie()
        objAudi.GeefStaatWagenWeer()
        objAudi.PompBandenOp()
        objAudi.GeefStaatWagenWeer()
    End Sub
End Module
