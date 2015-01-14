Namespace SRP

    Public Class Empleado

        Private eventos As New Bitacora

        Function CalculePlanilla(salarioMensual As Double, diasLaborados As Integer) As Double
            Dim resultado As Double = 0

            Try
                resultado = salarioMensual * diasLaborados / 30

            Catch ex As Exception
                ' Extraemos la responsabilidad a otra clase
                eventos.Registrar("No se pudo calcular el salario del empleado. El error fue " + ex.ToString)
            End Try

            Return resultado

        End Function

    End Class

End Namespace
