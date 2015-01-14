Namespace L.Antes

    Public Class Empleado
        Public Property fechaDeIngreso As DateTime

        Function CalculePlanilla(salarioMensual As Double, diasLaborados As Integer) As Double

            Return salarioMensual * diasLaborados / 30

        End Function

        Function CalculeAntiguedad() As Integer
            Return Date.Now.Year - fechaDeIngreso.Year
        End Function

    End Class

End Namespace
