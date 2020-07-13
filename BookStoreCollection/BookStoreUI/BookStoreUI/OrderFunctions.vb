Imports System.Data.SqlClient

Module OrderFunctions


    'I was going to set different tax rates, but it is not needed.
    Public Function getTax() As Double
        Return 0.065
    End Function

    Public Function doesDBContain(dataset As DataSet, searchFor As String) As Boolean
        'I highly doubt this will work, and find() my be better

        For Each dTable As DataTable In dataset.Tables
            For Each dRow As DataRow In dTable.Rows
                For index As Integer = 0 To dTable.Columns.Count - 1
                    Return Convert.ToString(dRow(index)).Contains(searchFor)
                Next
            Next
        Next

        Return False
    End Function

    Public Function doesDBContain(dtable As DataTable, searchFor As String) As Boolean
        'I highly doubt this will work, and find() my be better
        For Each dRow As DataRow In dtable.Rows
            For index As Integer = 0 To dtable.Columns.Count - 1
                Return Convert.ToString(dRow(index)).Contains(searchFor)
            Next
        Next

        Return False
    End Function

    Public Function genOrderNumber()
        Dim rand As New Random()
        Dim sResult As String = ""
        Dim adapter As New BookStoreDataSetTableAdapters.salesTableAdapter

        Do
            For i As Integer = 1 To 5
                sResult &= ChrW(rand.Next(32, 126))
            Next
        Loop While doesDBContain(adapter.GetData, sResult)

        Return sResult
    End Function

    Public Function getStoreID(name As String) As String
        'WIP
        'Must use functional co
        Return "Will return store name"
    End Function

End Module
