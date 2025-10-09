Imports System

Module Program

    Public Class Koppel
        Private intLengteVrouw As Integer
        Private intLengteMan As Integer

        Public Sub New(intLengteVrouw As Integer, intLengteMan As Integer)
            Me.intLengteMan = intLengteMan
            Me.intLengteVrouw = intLengteVrouw


        End Sub
        Public Function BerekenLengteKind(geslacht As String) As Double
            If geslacht = "jongen" Then
                Return (intLengteMan + intLengteVrouw) / 2 + 6.5

            Else
                Return (intLengteMan + intLengteVrouw) / 2 - 6.5

            End If
        End Function

    End Class
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Dim objKoppel As New Koppel(170, 180)
        Console.WriteLine(objKoppel.BerekenLengteKind("jongen"))
    End Sub
End Module
