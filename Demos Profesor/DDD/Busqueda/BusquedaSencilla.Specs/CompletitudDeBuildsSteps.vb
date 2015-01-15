Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports TechTalk.SpecFlow

Namespace BusquedaSencilla.Specs

    ' For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

    <Binding()> _
    Public Class CompletitudDeBuildsSteps
        <TechTalk.SpecFlow.Given("las siguientes soluciones")> _
        Public Sub DadoLasSiguientesSoluciones(ByVal table As Table)
            ScenarioContext.Current.Pending()
        End Sub

        <TechTalk.SpecFlow.Given("los siguientes builds")> _
        Public Sub DadoLosSiguientesBuilds(ByVal table As Table)
            ScenarioContext.Current.Pending()
        End Sub

        <TechTalk.SpecFlow.When("analizo la completitud")> _
        Public Sub CuandoAnalizoLaCompletitud()
            ScenarioContext.Current.Pending()
        End Sub

        <TechTalk.SpecFlow.Then("las siguientes soluciones no tienen build")> _
        Public Sub EntoncesLasSiguientesSolucionesNoTienenBuild(ByVal table As Table)
            ScenarioContext.Current.Pending()
        End Sub

    End Class

End Namespace
