Imports System

Module Program
    Class Pizza
        Public strToppings As String
        Public intDiameter As Integer
        Public dblPrijsEuro As Double

        Public Sub New(strToppings As String, intDiameter As Integer, dblPrijsEuro As Double)
            If strToppings = "" Then
                Me.strToppings = "kaas"
            Else
                Me.strToppings = strToppings
            End If

            If intDiameter < 0 Then
                Me.intDiameter = 14
            Else
                Me.intDiameter = intDiameter
            End If

            If dblPrijsEuro < 0 Then
                Me.dblPrijsEuro = 10.0
            Else
                Me.dblPrijsEuro = dblPrijsEuro
            End If
        End Sub

        Public Sub ZetToppings(strToppings As String)
            Me.strToppings = strToppings
        End Sub

        Public Sub zetDiameter(intDiameter As Integer)
            Me.intDiameter = intDiameter
        End Sub

        Public Sub ZetPrijsEuro(dblPrijsEuro As Double)
            Me.dblPrijsEuro = dblPrijsEuro
        End Sub

        Public Function GetToppings()
            Return Me.strToppings
        End Function

        Public Function GetDiameter()
            Return Me.intDiameter
        End Function

        Public Function GetPrijsEuro()
            Return Me.dblPrijsEuro
        End Function

    End Class
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Dim objPizza As New Pizza("peperoni", 15, 19.0)
    End Sub
End Module
