Imports system 
Module Program

    Class Dier
        Public strNaam As String
        Public intLeeftijdInAantalJaren As Integer
        Public blnAanwezig As Boolean
        Public intGewichtInKg As Integer
        Public Sub New(strNaam As String, intLeeftijdInAantalJaren As Integer, blnAanwezig As Boolean, intGewichtInKg As Integer)
            Me.strNaam = strNaam
            Me.intLeeftijdInAantalJaren = intLeeftijdInAantalJaren
            Me.blnAanwezig = blnAanwezig
            Me.intGewichtInKg = intGewichtInKg
        End Sub
        Dim objDier As New Dier("Joske de leeuw", 12, False, 280.2)

        Public Sub ZetAanwezig()
            If blnAanwezig = False Then
                Me.blnAanwezig = True
            Else
                Me.blnAanwezig = blnAanwezig
            End If
        End Sub

        Public Function GeefAanwezig() As String
            If Me.blnAanwezig Then
                Return "dier met naam:" & strNaam & "is aanwezig"
            Else
                Return "dier met naam:" & strNaam & "is afwezig"
            End If
        End Function

        Public Function Geefnaam() As String
            Return strNaam
        End Function

    End Class
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
    End Sub
End Module