Imports System
Imports System.Globalization

Module Program
    Class Restaurant
        Public strNaam As String
        Public strAdress As String
        Public intTelefoonnummer As Integer
        Public strSoortKeuken As String
        Public Sub New(strNaam As String, strAdress As String, intTelefoonnummer As Integer, strSoortKeuken As String)
            Me.strNaam = strNaam
            Me.strAdress = strAdress
            Me.intTelefoonnummer = intTelefoonnummer
            Me.strSoortKeuken = strSoortKeuken
        End Sub
    End Class
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Dim objRestaurant As New Restaurant("frietex", "Koningslinde 14", 4442930, "mooie keuken")
    End Sub
End Module
