Public Class Book
    Public Property IdTitle As String
    Public Property IdPublisher As String
    Public Property IdAuthor As String
    Public Property numPrice As String

    Public Sub New(ByVal bTitleId As String,
     ByVal bPublisherId As String,
     ByVal bAuthorId As String,
     ByVal bPrice As String)

        IdTitle = bTitleId
        IdPublisher = bPublisherId
        IdAuthor = bAuthorId
        numPrice = bPrice

    End Sub

    'Public Overrides Function ToString() As String

    'Return IdNumber & ", " & LastName _
    '     & ", " & Gpa.ToString("n")
    'End Function

End Class
