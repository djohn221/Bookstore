Public Class BookBO

    'Remember to use application tiers w/ database in datalayer
    'then add business logic as appropriate in business layer.
    Structure BookFeatures
        Dim strAutFirstName As String
        Dim strAuthLastName As String
        Dim strPublisherName As String
        Dim strTitleName As String
    End Structure

    Public Property strTitleID As String
    Public Property strTitleName As String
    Public Property dblPrice As Double
    Public Property intQuantity As Integer

    'Class for Order Screen Checkout Form'
    Public Sub New(ByVal bTitleID As String,
     ByVal bTitleName As String,
     ByVal bPrice As Double, ByVal bQuantity As Integer)

        strTitleID = bTitleID
        strTitleName = bTitleName
        dblPrice = bPrice
        intQuantity = bQuantity

    End Sub
    Public Function getPrice() As String
        Return dblPrice
    End Function
    Public Overrides Function ToString() As String
        Return strTitleID & ", " & strTitleName _
             & ", " & dblPrice & ", " & intQuantity
    End Function

End Class
