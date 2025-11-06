Imports System
Module Program
    Class Radio
        Dim Random As New Random()
        Private intNumber As Integer
        Public Sub New()

        End Sub
        Private Function SpeelLiedjeRadio() As String
            intNumber = Random.Next(1, 4)
            If intNumber = 1 Then
                Return "J'aime la vie"
            ElseIf intNumber = 2 Then
                Return "In this darkness"
            Else
                Return "Turn the Tide"
            End If
        End Function
        Public Sub SpeelLiedje()
            Console.WriteLine("Ik ga een liedje spelen...")
            Console.WriteLine(SpeelLiedjeRadio)
        End Sub
    End Class
    Sub Main(args As String())
        Dim objRadio As New radio()
        objRadio.SpeelLiedje()
    End Sub
End Module
