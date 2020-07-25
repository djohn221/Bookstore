Imports System.Windows.Forms

Public Class StoreDO
    Public adapter As New _
        BookStoreDataSetTableAdapters.storesTableAdapter
    Private current As Integer

    Public Function Insert(ByVal storeId As String,
     ByVal stor_name As String, ByVal stor_address As String,
     ByVal city As String, ByVal state As String, ByVal zip As String) As Boolean
        Try
            adapter.Insert(storeId, stor_name, stor_address,
              city, state, zip)
            Return True
        Catch ex As Exception
            MessageBox.Show("There's an error with the data you have provided!")
            Return False
        End Try
    End Function

    Public ReadOnly Property items As DataTable
        Get
            Return adapter.GetData
        End Get
    End Property

    Public Sub New()
        current = 0
    End Sub

    Public Function GetNext() As Integer
        If current < items.Rows.Count - 1 Then
            current = current + 1
        End If
        Return current
    End Function

    Public Function GetPrev() As Integer
        If current > 0 Then
            current = current - 1
        End If
        Return current
    End Function

    Public Function GetStoreID(storeName As String) As String
        Return adapter.GetStoreID(storeName)
    End Function

End Class
