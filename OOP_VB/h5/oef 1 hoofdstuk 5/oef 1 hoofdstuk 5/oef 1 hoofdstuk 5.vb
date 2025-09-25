Imports System

Module Program
    Public Class auto
        Public dblBandenSpanning As Double

        Public Sub New()
            Me.dblBandenSpanning = 5.0
            Console.WriteLine("Nieuwe auto aangemaakt met waarde: 5.0 bar")
        End Sub

        Public Sub GaOpVakantie()
            Me.dblBandenSpanning -= 1.0
            Console.WriteLine("Net op vakantie gegaan!")
        End Sub

        Public Sub PompBandenOp()
            Me.dblBandenSpanning = 5.0
            Console.WriteLine("Wagen terug tot 5.0 bar gepompt!")
        End Sub

        Public Sub geefStaatWagenWeer()
            If Me.dblBandenSpanning > 3.0 Then
                Console.WriteLine("De bandenSpanning is in orde: " & dblBandenSpanning & " bar")
            Else
                Console.WriteLine("De bandenSpanning is in te laag: " & dblBandenSpanning & " bar")
            End If
        End Sub
    End Class

    Sub Main(args As String())
        Dim objAuto As New auto()
        objAuto.GaOpVakantie()
        objAuto.geefStaatWagenWeer()
        objAuto.GaOpVakantie()
        objAuto.GaOpVakantie()
        objAuto.geefStaatWagenWeer()
        objAuto.PompBandenOp()
    End Sub
End Module
