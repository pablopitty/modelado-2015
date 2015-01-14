Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports TechTalk.SpecFlow
Imports TechTalk.SpecFlow.Assist

Namespace SpecsES

    ' For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

    <Binding()> _
    Public Class ClaveSteps
        Private elUsuario As Usuario
        Private claveOk As String
        Private claveError As String

        <TechTalk.SpecFlow.Given("un usuario existente en el sistema:")> _
        Public Sub DadoUnUsuarioExistenteEnElSistema(ByVal table As Table)
            elUsuario = table.CreateInstance(Of Usuario)()
        End Sub


        <TechTalk.SpecFlow.When("inicia sesion con una clave (.*)")> _
        Public Sub CuandoIniciaSesionConUnaClave(clave As String)
            claveOk = clave
        End Sub

        <TechTalk.SpecFlow.Then("puede iniciar sesion en el sistema")> _
        Public Sub EntoncesPuedeIniciarSesionEnElSistema()
            Assert.IsTrue(elUsuario.PuedeIniciarSesion(claveOk))
        End Sub

    End Class

End Namespace
