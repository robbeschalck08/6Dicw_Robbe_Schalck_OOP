Imports System

Module Program

    Class Kasteel
        Private strKoning As String
        Private intAantalRidders As Integer
        Private namenKoning As List(Of String)

        Public Sub New(intAantalRidders As Integer)
            Me.strKoning = VerkiesKoning()
            setRidders(intAantalRidders)
        End Sub

        Public Function VerkiesKoning() As String
            namenKoning = New List(Of String) From {"Arthur", "Lancelot", "Gawain", "Percival", "Galahad"}
            Dim random As New Random()
            Dim index As Integer = random.Next(namenKoning.Count)
            Return namenKoning(index)
        End Function

        Public Sub setRidders(aantal As Integer)
            Me.intAantalRidders = aantal
        End Sub

        Public Function GeefAantalRidders() As Integer
            Return Me.intAantalRidders
        End Function

        Public Function WieIsKoning() As String
            Return Me.strKoning
        End Function
    End Class
    Sub Main(args As String())
        Dim objGravensteen As New Kasteel(23)
        Console.WriteLine(objGravensteen.WieIsKoning())
        Console.WriteLine(objGravensteen.GeefAantalRidders())
    End Sub
End Module
