Imports System

Module Program

    Public Class Draak
        Public Naam As String
        Public Afkomst As String
        Public Karakter As String
        Public Age As Integer
        Public Klassificatie As String

    End Class
    Sub Main(args As String())
        Dim objViserion As New Draak()
        objViserion.Naam = "Viserion"
        objViserion.Afkomst = "Game of Thrones"
        objViserion.Karakter = "M"
        objViserion.Age = 6
        objViserion.Klassificatie = "Dragon, Wight"

        Dim objRhaegal As New Draak()
        objRhaegal.Naam = "Rhaegal"
        objRhaegal.Afkomst = "Game of Thrones"
        objRhaegal.Karakter = "M"
        objRhaegal.Age = 7
        objRhaegal.Klassificatie = "Dragon"

        Dim objDragon As New Draak()
        objDragon.Naam = "Dragon"
        objDragon.Afkomst = "Game of Thrones"
        objDragon.Karakter = "M"
        objDragon.Age = 7
        objDragon.Klassificatie = "Dragon"
        Console.WriteLine(objDragon)

        Dim objViserion As New Draak()
        objViserion.Naam = "Viserion"
        objViserion.Afkomst = "Game of Thrones"
        objViserion.Karakter = "M"
        objViserion.Age = 6
        objViserion.Klassificatie = "Dragon, Wight"

        Dim objRhaegal As New Draak()
        objRhaegal.Naam = "Rhaegal"
        objRhaegal.Afkomst = "Game of Thrones"
        objRhaegal.Karakter = "M"
        objRhaegal.Age = 7
        objRhaegal.Klassificatie = "Dragon"

        Dim objdrogon As New Draak()
        objdrogon.Naam = "Drogon"
        objdrogon.Afkomst = "Game of Thrones"
        objdrogon.Karakter = "M"
        objdrogon.Age = 7
        objdrogon.Klassificatie = "Dragon"

        Console.WriteLine("Naam: " & objViserion.Naam)
        Console.WriteLine("Afkomst: " & objViserion.Afkomst)
        Console.WriteLine("Geslacht: " & objViserion.Karakter)
        Console.WriteLine("Leeftijd: " & objViserion.Age)
        Console.WriteLine("Klassificatie: " & objViserion.Klassificatie)

        Console.WriteLine()

        Console.WriteLine("Naam: " & objRhaegal.Naam)
        Console.WriteLine("Afkomst: " & objRhaegal.Afkomst)
        Console.WriteLine("Geslacht: " & objRhaegal.Karakter)
        Console.WriteLine("Leeftijd: " & objRhaegal.Age)
        Console.WriteLine("Klassificatie: " & objRhaegal.Klassificatie)

        Console.WriteLine()

        Console.WriteLine("Naam: " & objdrogon.Naam)
        Console.WriteLine("Afkomst: " & objdrogon.Afkomst)
        Console.WriteLine("Geslacht: " & objdrogon.Karakter)
        Console.WriteLine("Leeftijd: " & objdrogon.Age)
        Console.WriteLine("Klassificatie: " & objdrogon.Klassificatie)










    End Sub
End Module
