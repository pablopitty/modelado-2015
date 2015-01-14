Namespace SRP.Antes

    Public Class Empleado

        Function CalculePlanilla(salarioMensual As Double, diasLaborados As Integer) As Double
            Dim resultado As Double = 0
            Try

                ' Logica adicional de servicios y base de datos
                '...

                resultado = (salarioMensual * diasLaborados / 30)

            Catch ex As Exception
                ' Es su responsabilidad saber como registrar en la bitacora!
                EventLog.WriteEntry("Application", "No se pudo calcular el salario diario el empleado. El error fue " + ex.ToString)
            End Try

            Return resultado

        End Function

    End Class

End Namespace

