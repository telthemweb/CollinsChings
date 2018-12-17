Public Class AvailableBooks
    'autofill combox
    Public Sub loadBookStaff()
        bookfindthis("select DISTINCT(isbn) from books")
        fillcombo(cbpublisher, "isbn", "isbn")

        bookfindthis("select DISTINCT(publisher) from books")
        fillcombo(cbAuthor, "publisher", "publisher")

    End Sub
    'resfresh the grid
    Public Sub refress()
        bookfindthis("SELECT `bookID`, `isbn`,`title`,`author`, `publisher`,`serial`, `Desrciption` FROM `books` Where `status` = 'Available'")
        LoadData(booksList, "Available")

        bookfindthis("SELECT count(*) FROM `books`  Where `status` = 'Available'")
        Dim numberOfBook = GetCount()
        lblTotal.Text = numberOfBook
    End Sub
    Private Sub AvailableBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refress()
        loadBookStaff()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        bookfindthis("SELECT * FROM `books` WHERE `isbn`='" & cbpublisher.Text & "' ")
        LoadData(booksList, "Available")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        bookfindthis("SELECT * FROM `books` WHERE `publisher`='" & cbAuthor.Text & "' ")
        LoadData(booksList, "Available")
    End Sub
End Class