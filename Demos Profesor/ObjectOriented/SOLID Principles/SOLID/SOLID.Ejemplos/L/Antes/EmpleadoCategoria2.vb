Namespace L.Antes

    Public Class EmpleadoCategoria2
        Inherits Empleado

        Overloads Function CalculePlanilla(salarioMensual As Double, diasLaborados As Integer) As Double

            Dim salarioBase As Double = MyBase.CalculePlanilla(salarioMensual, diasLaborados)
            Return salarioBase * 1.2 ' 20% bonificacion

        End Function

    End Class

End Namespace
