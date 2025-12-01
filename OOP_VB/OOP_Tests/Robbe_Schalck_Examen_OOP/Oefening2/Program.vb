Imports System
Imports System.Runtime.InteropServices.JavaScript.JSType
Imports System.Security.Cryptography.X509Certificates

Module Program
    Class Organisme 'hoofdklasse Organisme
        Protected strNaam As String 'veld strNaam dat kan worden overgeerfd
        Protected intLeeftijd As Integer 'veld intLeeftijd dat kan worden overgeerfd

        Public Sub New(strNaam As String, intLeeftijd As Integer) 'constructor 
            Me.strNaam = strNaam
            Me.intLeeftijd = intLeeftijd
        End Sub

        Public Overridable Sub Groei() 'methode dat kan worden overgeschreven, word hier niet gebruikt
            Console.WriteLine("dier is zo oud (in jaar): ")
        End Sub
    End Class

    Class Plant 'subklasse Plant 
        Inherits Organisme 'schrijft over van Organisme
        Protected dblHoogteInMeter As Double 'veld dblHoogteInMeter dat kan worden overgeerfd

        Public Sub New(strNaam As String, intLeeftijd As Integer, dblHoogteInMeter As Integer) 'constructor
            MyBase.New(strNaam, intLeeftijd)
            Me.dblHoogteInMeter = dblHoogteInMeter
        End Sub


        Public Overrides Sub Groei() 'overgeschreven methode van de klasse Organisme 
            Me.dblHoogteInMeter += 0.001
            Console.WriteLine(strNaam & " is gegroeid, het is nu: " & dblHoogteInMeter & " meter hoog.")
            Console.WriteLine("plant is zo oud (in jaar): " & intLeeftijd)
        End Sub

        Public Overridable Sub Fotosynthese() 'methode Fotosynthese dat je kan overschrijven 
            Console.WriteLine(strNaam & " is bezig met fotosynthese!")
        End Sub
    End Class

    Class Boom 'subklasse Boom
        Inherits Plant 'schrijft over van Plant 
        Private strType As String 'veld strType dat alleen bij boom hoort 

        Public Sub New(strNaam As String, intLeeftijd As Integer, dblHoogteInMeter As Integer, strType As String) 'constructor 
            MyBase.New(strNaam, intLeeftijd, dblHoogteInMeter)
            Me.strType = strType
        End Sub

        Public Overrides Sub Groei() 'overgeschreven methde van Plant 
            Me.dblHoogteInMeter += 0.002
            Console.WriteLine(strNaam & " is gegroeid met type blad: " & strType)
            Console.WriteLine("De nieuwe hoogte van de boom is: " & dblHoogteInMeter & " meter.")
            Console.WriteLine("Boom is zo oud (in jaar): " & intLeeftijd)
        End Sub
        Public Overrides Sub Fotosynthese() 'overgeschreven methode van Plant 
            Console.WriteLine(strNaam & " is bezig met fotosynthese!")
        End Sub

    End Class
    Class Dier 'subklasse Dier
        Inherits Organisme 'schrijft over van Organisme
        Protected strGeluid As String 'veld dat kan worden overgeerfd 

        Public Sub New(strNaam As String, intLeeftijd As Integer, strGeluid As String) 'constructor
            MyBase.New(strNaam, intLeeftijd)
            Me.strGeluid = strGeluid
        End Sub

        Public Overrides Sub Groei() 'overgeschreven methde van Plant 
            Console.WriteLine(strNaam & " is gegroeid, op een unieke dierlijke manier.")
            Console.WriteLine("Dier is zo oud (in jaar): " & intLeeftijd)
        End Sub

        Public Overridable Sub MaakGeluid() 'methode dat kan worden overgeschreven, hier niet gebruikt 
            Console.WriteLine("mag niet worden opgeroepen")
        End Sub
    End Class

    Class Vogel 'subklasse Vogel
        Inherits Dier ''schrijft over van Dier
        Private intSpanwijdteVanDeVleugelsInMeter As Integer 'veld intSpanwijdteVanDeVleugelsInMeter dat alleen hier word gebruikt 

        Public Sub New(strNaam As String, intLeeftijd As Integer, strGeluid As String, intSpanwijdteVanDeVleugelsInMeter As Integer) 'constructor
            MyBase.New(strNaam, intLeeftijd, strGeluid)
            Me.intSpanwijdteVanDeVleugelsInMeter = intSpanwijdteVanDeVleugelsInMeter
        End Sub


        Public Overrides Sub MaakGeluid() ''overgeschreven methde van Dier 
            Console.WriteLine(strNaam & " met vleugelspanwijdte: " & intSpanwijdteVanDeVleugelsInMeter & " meter zingt: " & strGeluid)
        End Sub
    End Class
    Sub Main(args As String())
        'Volgend object heeft volgende velden(Naam, Leeftijd, Hoogte, Type van het blad)
        Dim objEik As New Boom("Eik", 50, 15, "Eivormig")

        'Volgend object heeft volgende velden(Naam, Leeftijd, Hoogte)
        Dim objBlauweKorenbloem As New Plant("Blauwe korenbloem", 0.1, 0.05 / 100)

        'Volgend object heeft volgende velden(Naam, Leeftijd, geluid, Spanwijdte van de vleugels)
        Dim objAdelaar As New Vogel("Zeearend", 5, "Krijs", 2)

        'eerst alles overlopen van de klasse Boom
        objEik.Groei()
        objEik.Fotosynthese()
        Console.WriteLine("---")

        'dan alles overlopen van de klasse Plant
        objBlauweKorenbloem.Groei()
        objBlauweKorenbloem.Fotosynthese()
        Console.WriteLine("---")

        'ten slotte alles overlopen van de klasse Vogel
        objAdelaar.Groei()
        objAdelaar.MaakGeluid()
        Console.WriteLine("---")


    End Sub
End Module
