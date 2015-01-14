Namespace OC.Despues

    Public Class Empleado

        Function CalculePlanilla(salarioMensual As Double, diasLaborados As Integer) As Double

            Return salarioMensual * diasLaborados / 30

        End Function

    End Class

End Namespace
