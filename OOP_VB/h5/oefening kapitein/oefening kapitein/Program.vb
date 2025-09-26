Imports System

Module Program

    Class Voetballer
        Public strNaam As String
        Public blnKapitein As Boolean

        Public Sub New(strNaam As String)
            Me.strNaam = strNaam
            Me.blnKapitein = False

        End Sub

        Public Sub geefKapitein()
            If blnKapitein Then
                Console.WriteLine("ik ben kapitein")
            Else
                Console.WriteLine("Ik ben geen kapitein")
            End If

        End Sub

        Public Sub ZetKapitein(blnKapiteinWantIkBenEenParameter As Boolean)
            Me.blnKapitein = blnKapiteinWantIkBenEenParameter
        End Sub
    End Class
    Sub Main(args As String())
        Console.WriteLine("Hello World")
        Dim objVoetballer As New Voetballer("Kevin")
        objVoetballer.geefKapitein()
        objVoetballer.ZetKapitein(True)



    End Sub
End Module
