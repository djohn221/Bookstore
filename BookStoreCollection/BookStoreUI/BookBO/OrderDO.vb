Imports System.Windows.Forms

Public Class OrderDO
    Private adapter As New BookStoreDataSetTableAdapters.salesTableAdapter

    Public ReadOnly Property Items As DataTable
        Get
            Dim table As DataTable = adapter.GetData()
        End Get
    End Property

    Public Function Insert(ByVal stor_id As String,
     ByVal ord_num As String, ByVal ord_date As DateTime,
     ByVal qty As Int16, ByVal payterms As String, ByVal title_id As String) As Boolean
        Try
            adapter.Insert(stor_id, ord_num, ord_date,
              qty, payterms, title_id)
            Return True
        Catch ex As Exception
            MessageBox.Show("There's an error with the data you have provided!")
            Return False
        End Try
    End Function

    Public Function doesDBContain(searchFor As String) As Boolean
        'I highly doubt this will work, and find() may be better

        If String.IsNullOrEmpty(adapter.doesOrdExist(searchFor)) Then
            Return False
        End If

        Return True

    End Function

    Public Function NewInsert(ByVal stor_id As String,
     ByVal ord_num As String, ByVal ord_date As DateTime,
     ByVal qty As Int16, ByVal payterms As String, ByVal title_id As String) As Boolean
        Try
            adapter.NewInsert(stor_id, ord_num, ord_date,
              qty, payterms, title_id)
            Return True
        Catch ex As Exception
            MessageBox.Show("There's an error with new insert!")
            Return False
        End Try
    End Function

End Class
