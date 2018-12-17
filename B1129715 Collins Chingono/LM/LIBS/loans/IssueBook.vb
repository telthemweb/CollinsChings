Public Class IssueBook
    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        Dim ts As TimeSpan = DateTimePicker2.Value.Date - DateTime.Today.Date

        Dim total As Integer = ts.Days
        lblNumofDays.Text = total.ToString()

        If Val(lblNumofDays.Text) < 0 Then
            lblNumofDays.Text = 0
        End If

        dtpReturned.Value = DateTimePicker2.Value
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        sql = "SELECT * FROM `loan` WHERE `bookID`='" & txtBookNumber.Text & "' "
        bookfindthis(sql)

        If GetNumRows() = 1 Then
            MsgBox("This book has been Borrowed ", MsgBoxStyle.Critical)
        Else
            If Val(lblNumofDays.Text) < 1 Then
                MsgBox("Only one or more days are allowed to borrow a book", MsgBoxStyle.Critical)
            Else
                If lblNumofDays.Text = "0" Then
                    MsgBox("Number of days are required ", MsgBoxStyle.Critical)
                Else
                    issucess = book_insert("INSERT INTO `loan` (`bookID`,`studentID`, `isbn`, `issuedate`, `dateReturned`,`numberOfday`)  VALUES ('" & txtBookNumber.Text & "','" & txtReg.Text & "','" & txISNB.Text & "','" & dtpBorrwed.Text & "', '" & dtpReturned.Text & "', '" & lblNumofDays.Text & "');")
                    If issucess = True Then
                        MsgBox("You have Issued book to '" & txtNam.Text & "'  successfully! Book will be return on  '" & DateTimePicker2.Text & "'", MsgBoxStyle.Information)
                        book_insert("UPDATE books SET status= 'Unavailable' WHERE isbn='" & txISNB.Text & "'")

                        book_insert("INSERT INTO `tbtransaction` (`bookID`,`isbn`, `studentID`, `issuedate`, `dateReturned`,`dateAdded`)  VALUES ('" & txtBookNumber.Text & "','" & txISNB.Text & "','" & txtReg.Text & "','" & dtpBorrwed.Text & "', '" & dtpReturned.Text & "', '" & dtpRegistered.Value & "');")

                    Else
                        MsgBox("No Book has been issued to '" & txtNam.Text & "'!")
                    End If
                End If
            End If

        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            bookfindthis("SELECT * FROM `books` WHERE `bookID`='" & txtCodeBook.Text & "'")
            con.Open()
            dReader = cmd.ExecuteReader()
            While dReader.Read
                txtBookNumber.Text = dReader("bookID")
                txISNB.Text = dReader("isbn")
                txtTitle.Text = dReader("title")
                txtAuth.Text = dReader("author")
                txtPublisher.Text = dReader("publisher")
                txtSerial.Text = dReader("serial")
                lblStatus.Text = dReader("status")
                If lblStatus.Text = "Unavailable" Then
                    lblStatus.ForeColor = Color.Red
                    Button3.BackColor = Color.Red
                    Button3.Enabled = False
                Else
                    Button3.BackColor = Color.Green
                    Button3.Enabled = True
                    lblStatus.ForeColor = Color.Green
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            da.Dispose()

        End Try
    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            bookfindthis("SELECT * FROM students WHERE studentID = '" & txtSearch2.Text & "'")
            con.Open()
            dReader = cmd.ExecuteReader()
            While dReader.Read
                txtReg.Text = dReader("studentID")
                txtNam.Text = dReader("name")
                txtSurname.Text = dReader("surname")
                cbClass.Text = dReader("class")
                cbGender.Text = dReader("gender")
                txtSearch2.Text = ""

            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            da.Dispose()
        End Try
    End Sub
End Class