Imports System

Module Program
    Class Koppel
        Private intLengteVrouw As Integer
        Private intLengteMan As Integer

        Public Sub New(intLengteVrouw As Integer, intLengteMan As Integer)
            Me.intLengteVrouw = intLengteVrouw
            Me.intLengteMan = intLengteMan
        End Sub

        Public Function BerekenLengteKind(strGeslacht As String)
            If strGeslacht = "jongen" Then
                Return (intLengteVrouw + intLengteMan) / 2 + 6.5
            Else
                Return (intLengteVrouw + intLengteMan) / 2 - 6.5
            End If

        End Function

    End Class
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Dim objJongen As New Koppel(170, 180)
        Dim objMeisje As New Koppel(170, 180)
        Console.WriteLine(objJongen.BerekenLengteKind("jongen"))
        Console.WriteLine(objMeisje.BerekenLengteKind("meisje"))
    End Sub
End Module
