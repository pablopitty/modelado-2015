Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports TechTalk.SpecFlow

Namespace Specs

    <Binding()> _
    Public Class CajeroSteps

        Dim c As New CajeroAutomatico.Cuenta


        <TechTalk.SpecFlow.Given("Una cuenta con saldo (.*) dólares")> _
        Public Sub DadoUnaCuentaConSaldoDolares(ByVal saldo As Int32)
            c.SetSaldoInicial(saldo)
        End Sub

        <TechTalk.SpecFlow.When("se hace un retiro de (.*) dólares\.")> _
        Public Sub CuandoSeHaceUnRetiroDeDolares_(ByVal montoRetiro As Int32)
            c.HacerRetiro(montoRetiro)
        End Sub

        <TechTalk.SpecFlow.Then("el saldo restante es de (.*) dólares\.")> _
        Public Sub EntoncesElSaldoRestanteEsDeDolares_(ByVal saldoEsperado As Int32)
            Assert.AreEqual(saldoEsperado, c.GetSaldo)
        End Sub


    End Class

End Namespace
