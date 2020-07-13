Module OrderFunctions

    'I was going to set different tax rates, but it is not needed.
    Public Function getTax() As Double
        Return 0.065
    End Function

    Public Function genOrderNumber()
        Dim sResult As String = ""
        Dim rdm As New Random()

        For i As Integer = 1 To 5
            sResult &= ChrW(rdm.Next(32, 126))
        Next

        Return sResult
    End Function

End Module
