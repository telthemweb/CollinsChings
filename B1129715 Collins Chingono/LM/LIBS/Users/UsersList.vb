Public Class UsersList
    Private Sub UsersList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bookfindthis("SELECT `userID`, `name`,`surname`, `username`, `password`,`usertype` FROM `user`")
        LoadData(userlist, "users")


        bookfindthis("SELECT count(*) FROM `user`")
        Dim numberOfBook = GetCount()
        lblTotal.Text = numberOfBook
    End Sub


    Private Sub userlist_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles userlist.CellClick
        txtFname.Text = userlist.CurrentRow.Cells(1).Value.ToString
        txtSurname.Text = userlist.CurrentRow.Cells(2).Value.ToString
        txtUser.Text = userlist.CurrentRow.Cells(3).Value.ToString
        cbUserType.Text = userlist.CurrentRow.Cells(5).Value.ToString
    End Sub
End Class