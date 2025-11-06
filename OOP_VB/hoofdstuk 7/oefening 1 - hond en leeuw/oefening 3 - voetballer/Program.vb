
Imports System

Module Program
	Public Class Dier
		Protected intKleur As Integer
		Public Sub New(intKleur As Integer)
			Me.intKleur = intKleur
		End Sub
	End Class

	Public Class Hond
		Inherits Dier
		Private strBaasje As String
		Public Sub New(intKleur As Integer, strBaasje As String)
			MyBase.New(intKleur)
			Me.strBaasje = strBaasje
		End Sub
		Public Sub Blaf()
			Console.WriteLine("WAF WAF")
		End Sub
		Public Function GeefEigenaar() As String
			Return strBaasje
		End Function
		Public Sub ZetEigenaar(strBaasje As String)
			Me.strBaasje = strBaasje
		End Sub
		Public Sub PrintInformatie()
			Console.WriteLine("De Hond heeft een kleurwaarde van: " & intKleur & ", Zijn baasje noemt: " & strBaasje)
		End Sub
	End Class
	Public Class Leeuw
		Inherits Dier
		Private strJungleNaam As String
		Public Sub New(intKleur As Integer, strJungleNaam As String)
			MyBase.New(intKleur)
			Me.strJungleNaam = strJungleNaam
		End Sub
		Public Sub Brult()
			Console.WriteLine("Rawr")
		End Sub
		Public Function GeefJungleNaam() As String
			Return strJungleNaam
		End Function
		Public Sub ZetJungleNaam(strJungleNaam As String)
			Me.strJungleNaam = strJungleNaam
		End Sub
		Public Sub PrintInformatie()
			Console.WriteLine("De Leeuw heeft een kleurwaarde van: " & intKleur & ", Zijn Jungle noemt: " & strJungleNaam)
		End Sub
	End Class
	Sub Main(args As String())
		Dim objBobby As New Hond(4, "Freddy")
		Dim objSimba As New Leeuw(4, "JungleBook")
		objBobby.PrintInformatie()
		objBobby.Blaf()
		objSimba.PrintInformatie()
		objSimba.Brult()
	End Sub
End Module
