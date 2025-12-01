Module Program
    Class Deck 'een klasse deck
        Private intCurrentSuit As String 'welke suit de kaart heeft
        Private IntCurrentValue As String 'welke value de kaart heeft

        Public Sub New(intCurrentSuit As String, IntCurrentValue As String) 'constructor 
            Me.intCurrentSuit = intCurrentSuit
            Me.IntCurrentValue = IntCurrentValue
        End Sub

        Public Sub ShowNextCard() 'toont de kaart die we op dat moment hebben
            IncrementCard()
        End Sub

        Private Sub IncrementCard() 'deze methode toont de kaart die er nu is en veranderd de kaart naar de volgende
            If Me.IntCurrentValue = "2" Then
                Console.WriteLine(IntCurrentValue & " van " & intCurrentSuit)
                Me.IntCurrentValue = "3"
            ElseIf Me.IntCurrentValue = "3" Then
                Console.WriteLine(IntCurrentValue & " van " & intCurrentSuit)
                Me.IntCurrentValue = "4"
            ElseIf Me.IntCurrentValue = "4" Then
                Console.WriteLine(IntCurrentValue & " van " & intCurrentSuit)
                Me.IntCurrentValue = "5"
            ElseIf Me.IntCurrentValue = "5" Then
                Console.WriteLine(IntCurrentValue & " van " & intCurrentSuit)
                Me.IntCurrentValue = "6"
            ElseIf Me.IntCurrentValue = "6" Then
                Console.WriteLine(IntCurrentValue & " van " & intCurrentSuit)
                Me.IntCurrentValue = "7"
            ElseIf Me.IntCurrentValue = "7" Then
                Console.WriteLine(IntCurrentValue & " van " & intCurrentSuit)
                Me.IntCurrentValue = "8"
            ElseIf Me.IntCurrentValue = "8" Then
                Console.WriteLine(IntCurrentValue & " van " & intCurrentSuit)
                Me.IntCurrentValue = "9"
            ElseIf Me.IntCurrentValue = "9" Then
                Console.WriteLine(IntCurrentValue & " van " & intCurrentSuit)
                Me.IntCurrentValue = "10"
            ElseIf Me.IntCurrentValue = "10" Then
                Console.WriteLine(IntCurrentValue & " van " & intCurrentSuit)
                Me.IntCurrentValue = "Boer"
            ElseIf Me.IntCurrentValue = "Boer" Then
                Console.WriteLine(IntCurrentValue & " van " & intCurrentSuit)
                Me.IntCurrentValue = "Dame"
            ElseIf Me.IntCurrentValue = "Dame" Then
                Console.WriteLine(IntCurrentValue & " van " & intCurrentSuit)
                Me.IntCurrentValue = "Heer"
            ElseIf Me.IntCurrentValue = "Heer" Then
                Console.WriteLine(IntCurrentValue & " van " & intCurrentSuit)
                Me.IntCurrentValue = "Aas"
            ElseIf Me.IntCurrentValue = "Aas" And Me.intCurrentSuit = "Harten" Then
                Console.WriteLine(IntCurrentValue & " van " & intCurrentSuit)
                Me.IntCurrentValue = "2"
                Me.intCurrentSuit = "Ruiten"
            ElseIf Me.IntCurrentValue = "Aas" And Me.intCurrentSuit = "Ruiten" Then
                Console.WriteLine(IntCurrentValue & " van " & intCurrentSuit)
                Me.IntCurrentValue = "2"
                Me.intCurrentSuit = "Schoppen"
            ElseIf Me.IntCurrentValue = "Aas" And Me.intCurrentSuit = "Schoppen" Then
                Console.WriteLine(IntCurrentValue & " van " & intCurrentSuit)
                Me.IntCurrentValue = "2"
                Me.intCurrentSuit = "Klaveren"
            ElseIf Me.IntCurrentValue = "Aas" And Me.intCurrentSuit = "Klaveren" Then
                Console.WriteLine(IntCurrentValue & " van " & intCurrentSuit)
                Console.WriteLine("Geen kaarten meer in het deck!")
            End If
        End Sub


    End Class
    Sub Main(args As String())
        Dim myDeck As New Deck("Harten", "2") 'maak een nieuw deck
        Console.WriteLine("De getrokken kaarten zijn: ") ' maakt de print mooier
        For i As Integer = 1 To 15 'print 15 kaarten af
            myDeck.ShowNextCard()
        Next


    End Sub
End Module

