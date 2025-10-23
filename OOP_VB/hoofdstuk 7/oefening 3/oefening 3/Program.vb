Imports System
Imports System.IO

Module Program
    Class Speler
        Protected strNaam As String
        Protected random As New Random()

        Public Sub New(strNaam As String)
            Me.strNaam = strNaam
        End Sub

        Public Overridable Sub TrapBal()
            Console.WriteLine(strNaam & " trapt de bal.")
        End Sub
    End Class

    Class Verdediger
        Inherits Speler

        Public Sub New(strNaam As String)
            MyBase.New(strNaam)
        End Sub

        Public Overrides Sub TrapBal()
            Dim kans As Integer = random.Next(0, 10)

            If kans < 5 Then
                Console.WriteLine(strNaam & " verliest de bal!")
            Else
                Console.WriteLine(strNaam & " heeft de bal")
            End If
        End Sub
    End Class

    Class Aanvaller
        Inherits Speler

        Public Sub New(strNaam As String)
            MyBase.New(strNaam)
        End Sub

        Public Overrides Sub TrapBal()
            Dim kans As Integer = random.Next(0, 10)

            If kans < 7 Then
                Console.WriteLine(strNaam & " mist het doel!")
            Else
                Console.WriteLine(strNaam & " scoort! ")
            End If
        End Sub
    End Class
    Sub Main(args As String())
        Dim verdediger As New Verdediger("Jan")
        Dim aanvaller As New Aanvaller("Piet")

        verdediger.TrapBal()
        aanvaller.TrapBal()
    End Sub
End Module
