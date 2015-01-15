Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports BusquedaSencilla.BusinessLogic

<TestClass()> Public Class SolucionEstaEnBuild_UnitTests

    <TestMethod()> Public Sub SolucionSiEstaEnUnBuild()
        Dim builds As New List(Of Core.Build)
        builds.Add(New Core.Build())
        builds.Add(New Core.Build())

        Dim sut = New ReglaSolucionEnUnBuild

        Dim s As New Core.Solucion()

        Assert.IsTrue(sut.Validacion(s, builds))

    End Sub



End Class