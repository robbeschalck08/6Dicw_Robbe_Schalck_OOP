Imports System

Module Program
    Class Trapper
        Private strVoorkeur As String
        Private intRandomSchot As Integer
        Private richtingen As List(Of String) = New List(Of String) From {"links", "midden", "rechts"}

        Public Sub New(strVoorkeur As String)
            Me.strVoorkeur = strVoorkeur
        End Sub

        Public Function neemSchot() As String
            ' Generate 1..10 to model probabilities:
            ' 1-4 -> voorkeur (4/10)
            ' 5-7 -> eerste other optie (3/10)
            ' 8-10 -> tweede other optie (3/10)
            intRandomSchot = Int((10 * Rnd()) + 1)
            Dim opties As New List(Of String)(richtingen)
            opties.Remove(strVoorkeur)

            If intRandomSchot <= 4 Then
                Return strVoorkeur
            ElseIf intRandomSchot <= 7 Then
                Return opties(0)
            Else
                Return opties(1)
            End If
        End Function
    End Class

    Class Keeper
        Private strVoorkeur As String
        Private intRandomKant As Integer
        Private richtingen As List(Of String) = New List(Of String) From {"links", "midden", "rechts"}

        Public Sub New(strVoorkeur As String)
            Me.strVoorkeur = strVoorkeur
        End Sub

        Public Function verdedigSchot() As String
            ' Generate 1..10 to model probabilities:
            ' 1-4 -> voorkeur (4/10)
            ' 5-7 -> eerste other optie (3/10)
            ' 8-10 -> tweede other optie (3/10)
            intRandomKant = Int((10 * Rnd()) + 1)
            Dim opties As New List(Of String)(richtingen)
            opties.Remove(strVoorkeur)

            If intRandomKant <= 4 Then
                Return strVoorkeur
            ElseIf intRandomKant <= 7 Then
                Return opties(0)
            Else
                Return opties(1)
            End If
        End Function
    End Class

    Sub Main(args As String())
        Randomize()
        Dim objMessi As New Trapper("rechts")
        Dim objCourtois As New Keeper("links")

        Dim schot As String = objMessi.neemSchot()
        Dim redding As String = objCourtois.verdedigSchot()

        'Console.WriteLine($"lukaku schiet: {schot}")
        Console.WriteLine($"Courtois duikt: {redding}")




    End Sub
End Module