﻿'Affirmation of Authorship:

'Name: Darwin Chavez, David Johnson

'Date: 7/13/2020

'I affirm that this program was created by me. It is solely my work and ‘does not include any work done by an yon and anyone else.
Imports BookBO.BookBO

Public Class frmTitles
    'Creating a variable from a structure'
    Private titleName As BookFeatures
    Private Sub TitlesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TitlesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TitlesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BookStoreDataSet)

    End Sub

    Private Sub frmTitles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BookStoreDataSet.titles' table. You can move, or remove it, as needed.
        'Me.TitlesTableAdapter.Fill(Me.BookStoreDataSet.titles)

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            'Referencing a field within the structure'
            titleName.strTitleName = txtTitle.Text
            Me.TitlesTableAdapter.FillTitle(Me.BookStoreDataSet.titles, titleName.strTitleName)

            'Clear TextBox Values After Search'
            txtTitle.Text = String.Empty
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Data Input Error")
        End Try
    End Sub
End Class