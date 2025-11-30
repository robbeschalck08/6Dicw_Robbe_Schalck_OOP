Imports System

Module Program
    Class Draak
        Public strNaam As String
        Public strOorsprong As String
        Public strGeslacht As String
        Public intLeeftijd As Integer
        Public strKlassificatie As String

        Public Sub New(strNaam As String, strOorsprong As String, strGeslacht As String, intLeeftijd As Integer, strKlassificatie As String)
            Me.strNaam = strNaam
            Me.strOorsprong = strOorsprong
            Me.strGeslacht = strGeslacht
            Me.intLeeftijd = intLeeftijd
            Me.strKlassificatie = strKlassificatie
        End Sub

    End Class
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Dim objViserion As New Draak("Viserion", "game of thrones", "man", 6, "dragon(wight)")
        Dim objDragon As New Draak("Dragon", "game of thrones", "man", 7, "dragon")
        Dim objRhaegal As New Draak("Rhaegal", "game of thrones", "man", 7, "dragon")
        Console.WriteLine("dit is zijn naam: " & objViserion.strNaam)
    End Sub
End Module
