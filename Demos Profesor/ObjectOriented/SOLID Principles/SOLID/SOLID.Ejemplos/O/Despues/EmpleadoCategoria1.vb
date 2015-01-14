Namespace OC.Despues

    Public Class EmpleadoCategoria1
        Inherits Empleado

        Overloads Function CalculePlanilla(salarioMensual As Double, diasLaborados As Integer) As Double

            Dim salarioBase As Double = MyBase.CalculePlanilla(salarioMensual, diasLaborados)
            Return salarioBase * 1.1 ' 10% bonificacion

        End Function

    End Class

End Namespace
