Namespace L.Despues

    Public Class Consultor
        Implements IPlanilla

        Public Function CalculePlanilla(salarioMensual As Double, diasLaborados As Integer) As Double Implements IPlanilla.CalculePlanilla
            Return salarioMensual * diasLaborados / 20
        End Function

    End Class

End Namespace
