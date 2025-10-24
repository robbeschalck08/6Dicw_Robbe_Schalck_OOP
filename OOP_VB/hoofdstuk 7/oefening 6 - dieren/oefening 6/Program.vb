
Imports System

Module Program
    Class Salamander
        Protected intAantalPoten As Integer
        Protected intStaartLengte As Integer
        Protected dblLongCapaciteitInLiter As Double

        Public Sub New()
            Me.intAantalPoten = 4
            Me.intStaartLengte = 6
            Me.dblLongCapaciteitInLiter = 0.5
        End Sub

        Public Sub GeefAantalPoten()
            Console.WriteLine("Aantal poten: " & Me.intAantalPoten)
        End Sub

        Public Sub GeefLongCapaciteit()
            Console.WriteLine("Longcapaciteit in liter: " & Me.dblLongCapaciteitInLiter)
        End Sub

    End Class

    Class Tijger
        Inherits Salamander
        Private strHaarkleur As String

        Public Sub New()
            MyBase.New()
            Me.strHaarkleur = "wit"
            Me.intStaartLengte = 50
            Me.dblLongCapaciteitInLiter = 3.5
        End Sub

        Public Sub GeefHaarkleur()
            Console.WriteLine("Haarkleur: " & Me.strHaarkleur)
        End Sub

    End Class

    Class Mens
        Inherits Salamander
        Private intAantalBenen As Integer
        Private intAantalArmen As Integer
        Private strHaarkleur As String

        Public Sub New(strHaarkleur As String)
            MyBase.New()
            Me.intAantalPoten = 0
            Me.intStaartLengte = 0
            Me.intAantalBenen = 2
            Me.intAantalArmen = 2
            Me.dblLongCapaciteitInLiter = 7.0
            Me.strHaarkleur = strHaarkleur
        End Sub

        Public Sub GeefHaarkleur()
            Console.WriteLine("Haarkleur: " & Me.strHaarkleur)
        End Sub

    End Class

    Sub Main(args As String())
        Dim objSalamander As New Salamander()
        Dim objTijger As New Tijger()
        Dim objMens As New Mens("Blond")
        objSalamander.GeefAantalPoten()
        objSalamander.GeefLongCapaciteit()
        Console.WriteLine()

        objTijger.GeefAantalPoten()
        objTijger.GeefLongCapaciteit()
        objTijger.GeefHaarkleur()
        Console.WriteLine()

        objMens.GeefAantalPoten()
        objMens.GeefLongCapaciteit()
        objMens.GeefHaarkleur()
    End Sub
End Module

