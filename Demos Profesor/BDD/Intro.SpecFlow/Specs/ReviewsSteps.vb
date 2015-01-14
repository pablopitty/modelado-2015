Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports TechTalk.SpecFlow
Imports FavRestaurants

Namespace Specs

    ' For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

    <Binding()> _
    Public Class ReviewsSteps

        Private manager As New ReviewsManager
        Private firstReview As New RestaurantReview

        <TechTalk.SpecFlow.Given("a restaurant called (.*)")> _
        Public Sub GivenARestaurantCalledNachosPlace(name As String)
            firstReview.Name = name
        End Sub

        <TechTalk.SpecFlow.When("(.*) rates it (.*) stars")> _
        Public Sub WhenSomeoneRatesItStars(reviewer As String, ByVal rating As Integer)
            firstReview.Reviewer = reviewer
            firstReview.Rating = rating
            manager.ReviewIt(firstReview)
        End Sub

        <TechTalk.SpecFlow.Then("it shows up in the restaurant reviews list with (.*) stars from (.*)")> _
        Public Sub ThenItShowsUpInTheRestaurantsReviewListWithStarsFrom(ByVal stars As Integer, reviewer As String)
            Assert.IsNotNull(manager.GetReview(firstReview.Reviewer, firstReview.Name), "El review no fue registrado.")
            Assert.AreEqual(Of Integer)(firstReview.Rating, manager.GetReview(firstReview.Reviewer, firstReview.Name).Rating, "El rating es incorrecto")
        End Sub

        <TechTalk.SpecFlow.When("(.*) tries to rate it a second time (.*) stars")> _
        Public Sub WhenSomeoneTriesToRateItASecondTime(reviewer As String, ByVal newRating As Integer)
            Dim second As New RestaurantReview
            second.Reviewer = reviewer
            second.Rating = newRating
            second.Name = firstReview.Name

            manager.ReviewIt(second)

        End Sub

    End Class

End Namespace