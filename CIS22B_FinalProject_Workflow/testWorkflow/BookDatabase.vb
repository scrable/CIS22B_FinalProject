﻿Public Class BookDatabase
    ''' <summary>
    ''' array of BookStructs of some arbitrary size
    ''' </summary>
    Private Property books As testWorkflow.BookStruct
        Get
            Return Nothing
        End Get
        Set(value As testWorkflow.BookStruct)
        End Set
    End Property

    ''' <summary>
    ''' number of BookStructs in books
    ''' </summary>
    Private Property size As Int
        Get
            Return Nothing
        End Get
        Set(value As Int)
        End Set
    End Property

    Public Property Cashier As Cashier
        Get
            Return Nothing
        End Get
        Set(value As Cashier)
        End Set
    End Property

    Public Property Report As Report
        Get
            Return Nothing
        End Get
        Set(value As Report)
        End Set
    End Property

    ''' <summary>
    ''' if the book already exists in the database, add the quantity to the existing quantity. Otherwise, use the book and quantity to create a BookStruct and add it to books and increase size by one
    ''' </summary>
    Public Sub addBook(book As testWorkflow.Book, quantity As Int)

    End Sub

    ''' <summary>
    ''' returns the index in books of the bookstruct with that isbn
    ''' </summary>
    Private Function searchIsbn(isbn As Int) As Int
    End Function

    ''' <summary>
    ''' takes in an isbn, removes one from the quantity of that book, then returns the retailPrice of that book. If there are no more copies afterward, remove the struct from books.
    ''' </summary>
    Public Function sellBook(isbn As Int) As Int
    End Function

    ''' <summary>
    ''' removes the book with isbn, then shifts all of the books after it to remove the gap. decreases size by 1
    ''' </summary>
    Public Sub removeBook(Isbn As Int)

    End Sub
End Class