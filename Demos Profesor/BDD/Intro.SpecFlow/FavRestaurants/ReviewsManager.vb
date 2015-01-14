Public Class ReviewsManager

    Public Property RestaurantList As IList(Of RestaurantReview)

    Public Sub New()
        RestaurantList = New List(Of RestaurantReview)
    End Sub

    Public Sub ReviewIt(review As RestaurantReview)
        Dim exists As RestaurantReview = GetReview(review.Reviewer, review.Name)
        If exists Is Nothing Then
            RestaurantList.Add(review)
        Else
            exists.Rating = review.Rating
        End If
    End Sub

    Function GetReview(reviewer As String, restaurant As String) As RestaurantReview
        Return RestaurantList.Where(Function(c) c.Name.Equals(restaurant) And c.Reviewer.Equals(reviewer)).FirstOrDefault
    End Function

End Class
