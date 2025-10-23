Imports System

Module Program
    Class Veelhoek
        Protected intAantalzijden As Integer
        Private random As Random

        Public Sub New()
            Me.intAantalzijden = random.Next(3, 7)
        End Sub

        Public Overridable Sub ToonInfo()
            Console.WriteLine("Deze veelhoek heeft " & intAantalZijden & " zijden.")
        End Sub

    End Class

    Class Vierkant
        Inherits Veelhoek

        Public Sub New()
            MyBase.New()
            Me.intAantalzijden = 4
        End Sub

        Public Overrides Sub ToonInfo()
            Console.WriteLine("Dit is een vierkant met " & intAantalzijden & " zijden.")
        End Sub
    End Class
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
    End Sub
End Module
