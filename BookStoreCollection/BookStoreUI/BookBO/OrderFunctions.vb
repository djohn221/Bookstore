Imports System.Data.SqlClient
Imports BookDO
'Affirmation of Authorship:

'Name: Darwin Chavez, David Johnson

'Date: 7/13/2020

'I affirm that this program was created by me. It is solely my work and ‘does not include any work done by an yon and anyone else.
Public Module OrderFunctions


    'I was going to set different tax rates, but it is not needed.
    Public Function getTax() As Double
        Return 0.065
    End Function

    Public Function genOrderNumber() As String
        Dim rdm As New Random()
        Dim allowChrs() As Char = "ABCDEFGHIJKLOMNOPQRSTUVWXYZ0123456789".ToCharArray()
        Dim ord_num As String = ""

        For i As Integer = 0 To 4
            ord_num += allowChrs(rdm.Next(0, allowChrs.Length))
        Next

        Dim order As New OrderDO

        If order.doesDBContain(ord_num) Then
            genOrderNumber()
        Else
            Return ord_num
        End If

    End Function

    Public Function getStoreID(name As String) As String
        Dim tempTable As New StoreDO()
        Dim stor_id = tempTable.adapter.getStoreID(name).ToString()

        Return stor_id
    End Function

End Module
