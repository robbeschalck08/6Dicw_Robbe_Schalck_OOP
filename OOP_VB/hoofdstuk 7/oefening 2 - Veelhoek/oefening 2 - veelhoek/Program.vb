Imports System

Module Program
    Public Class Veelhoek
        Protected intZijden As Integer
        Public Sub New(intZijden As Integer)
            Me.intZijden = intZijden
        End Sub
    End Class
    Public Class Vierkant
        Inherits Veelhoek
        Public Sub New()
            MyBase.New(4)
        End Sub
    End Class
    Sub Main(args As String())
        Dim objVeelhoek As New Veelhoek(2)
        Dim objVierkant As New Vierkant()
    End Sub
End Module