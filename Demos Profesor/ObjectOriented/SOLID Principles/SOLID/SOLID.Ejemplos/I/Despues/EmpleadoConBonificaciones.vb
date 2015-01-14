Namespace I.Despues

    Public Class EmpleadoConBonificaciones
        Implements IEmpleadoRegularConBonificaciones

        Public Property fechaDeIngreso As DateTime

        Public Function CalculeAntiguedad() As Integer Implements IEmpleadoRegular.CalculeAntiguedad
            Return Date.Now.Year - fechaDeIngreso.Year
        End Function

        Public Function CalculeBonificaciones() As Double Implements IEmpleadoRegularConBonificaciones.CalculeBonificaciones
            Return CalculeAntiguedad() * 10000
        End Function
    End Class

End Namespace
