Namespace L.Despues

    Public Class Empleado
        Implements IEmpleadoRegular, IPlanilla

        Public Property fechaDeIngreso As DateTime

        Public Function CalculeAntiguedad() As Integer Implements IEmpleadoRegular.CalculeAntiguedad
            Return Date.Now.Year - fechaDeIngreso.Year

        End Function

        Public Function CalculePlanilla(salarioMensual As Double, diasLaborados As Integer) As Double Implements IPlanilla.CalculePlanilla
            Return salarioMensual * diasLaborados / 30
        End Function
    End Class

End Namespace
