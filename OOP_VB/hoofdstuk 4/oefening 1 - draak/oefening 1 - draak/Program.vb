Imports System

Module Program
    Class draak
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
        Dim objViserion As New draak("Viserion", "Game of Thrones", "Male", 6, "Dragon wight")
        Dim objDrogon As New draak("Drogon", "Game of Thrones", "Male", 7, "Dragon")
        Dim objRhaegal As New draak("Rhaegal", "Game of Thrones", "Male", 7, "Dragon")
        Console.WriteLine("De draak noemt " & objViserion.strNaam & " Hij is " & objViserion.intLeeftijd & " jaar oud en heeft de classificatie " & objViserion.strKlassificatie)
        Console.WriteLine("De draak noemt " & objDrogon.strNaam & " Hij is " & objDrogon.intLeeftijd & " jaar oud en heeft de classificatie " & objDrogon.strKlassificatie)
        Console.WriteLine("De draak noemt " & objRhaegal.strNaam & " Hij is " & objRhaegal.intLeeftijd & " jaar oud en heeft de classificatie " & objRhaegal.strKlassificatie)

    End Sub
End Module
