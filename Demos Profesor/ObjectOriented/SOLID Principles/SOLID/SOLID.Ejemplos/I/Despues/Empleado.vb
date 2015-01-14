Namespace I.Despues

    Public Class Empleado
        Implements IEmpleadoRegular

        Public Property fechaDeIngreso As DateTime

        Public Function CalculeAntiguedad() As Integer Implements IEmpleadoRegular.CalculeAntiguedad
            Return Date.Now.Year - fechaDeIngreso.Year
        End Function

    End Class

End Namespace
