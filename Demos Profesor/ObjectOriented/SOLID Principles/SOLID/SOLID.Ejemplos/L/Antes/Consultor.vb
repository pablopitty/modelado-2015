Namespace L.Antes

    Public Class Consultor
        Inherits Empleado

        Overloads Function CalculePlanilla(salarioMensual As Double, diasLaborados As Integer) As Double

            Throw New Exception("Los consultores no tienen salario mensual.")

        End Function

        Overloads Function CalculeAntiguedad() As Integer
            Throw New InvalidExpressionException("Los consultores no tienen fecha de ingreso.")
        End Function

    End Class

End Namespace
