Imports System
Imports System.Runtime.CompilerServices

Module Program
    Class Radio
        Dim random As New Random
        Private intGetal As Integer
        Public Sub SpeelLiedje()
            Console.Write("ik ga een liedje spelen: " & SpeelLiedjeRadio())
        End Sub

        Private Function SpeelLiedjeRadio()
            intGetal = random.Next(1, 3)
            If intGetal = 1 Then
                Return "baila"
            ElseIf intGetal = 2 Then
                Return "la vache"
            Else
                Return "beachball"
            End If
        End Function
    End Class
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Dim objRadio As New Radio()
        objRadio.SpeelLiedje()
    End Sub
End Module
