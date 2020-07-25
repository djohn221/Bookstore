Imports System.Data.SqlClient
Imports BookBO
'Affirmation of Authorship:

'Name: Darwin Chavez, David Johnson

'Date: 7/13/2020

'I affirm that this program was created by me. It is solely my work and ‘does not include any work done by an yon and anyone else.
Module OrderFunctions

    Public Property SubTotal As Double
    Public Property storeName As String
    Public Property grandTotal As Double

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

        'If order number already exist in the database'
        If order.doesDBContain(ord_num) Then
            'Generate New Order Number'
            genOrderNumber()
            Return ord_num
        Else 'Else Return random generated order number'
            Return ord_num
        End If

    End Function
    Public Function getStoreID(name As String) As String
        Dim tempTable As New StoreDO()
        Dim stor_id = tempTable.adapter.GetStoreID(name).ToString()

        Return stor_id
    End Function
    Public Function getSubTotal(price As Double, quantity As Double) As Double
        'SubTotal is product of Price x Q'
        SubTotal += (price * quantity)
        Return SubTotal
    End Function
    Public Function subtractSubTotal(price As Double, quantity As Double) As Double
        'Removing Item and updating subtotal variable.'
        SubTotal -= (price * quantity)
        Return SubTotal
    End Function
End Module
