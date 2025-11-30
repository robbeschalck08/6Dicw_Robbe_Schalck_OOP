Imports System

Module Program
    Public Class Draak
        Private strNaam As String
        Private strOrigin As String
        Private blnIsMale As Boolean
        Private intAge As Integer
        Private strClassification As String
        Public Sub New(strNaam As String, strOrigin As String, blnIsMale As Boolean, intAge As Integer, strClassification As String)
            Me.strNaam = strNaam
            Me.strOrigin = strOrigin
            Me.blnIsMale = blnIsMale
            Me.intAge = intAge
            Me.strClassification = strClassification
        End Sub

        Public Function getNaam() As String
            Return strNaam
        End Function

        Public Function getOrigin() As String
            Return strOrigin
        End Function

        Public Function getMale() As String
            Return blnIsMale
        End Function

        Public Function getAge() As String
            Return intAge
        End Function

        Public Function getClassification() As String
            Return strClassification
        End Function


    End Class
    Sub Main(args As String())
        Dim objViserion As New Draak("viserion", "Game of Thrones", True, 6, "Dragon, Wight")
        Dim objDrogon As New Draak("Drogon", "Game of Thrones", True, 7, "Dragon")
        Dim objRhaegal As New Draak("Rhaegal", "Game of Thrones", True, 7, "Dragon")
        Console.WriteLine("De draak noemt " & objViserion.getNaam() & " Hij is " & objViserion.getAge & " jaar oud en heeft de classificatie " & objViserion.getClassification)
        Console.WriteLine("De draak noemt " & objDrogon.getNaam() & " Hij is " & objDrogon.getAge & " jaar oud en heeft de classificatie " & objDrogon.getClassification)
        Console.WriteLine("De draak noemt " & objRhaegal.getNaam() & " Hij is " & objRhaegal.getAge & " jaar oud en heeft de classificatie " & objRhaegal.getClassification)
    End Sub
End Module