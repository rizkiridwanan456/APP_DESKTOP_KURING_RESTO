Public Class Login
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim username As String = TB1.Text.Trim()
        Dim password As String = TB2.Text.Trim()

        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
            ' Validasi username dan password kosong
            MessageBox.Show("Masukkan username dan password!")
        ElseIf username = "admin" AndAlso password = "admin" Then
            ' Login berhasil
            MessageBox.Show("Login berhasil!")
            Form1.Show()
            Form1.HomeToolStripMenuItem.Visible = True
            Form1.OrderListToolStripMenuItem.Visible = True
            Form1.BookListToolStripMenuItem.Visible = True
            Form1.LOGOUTToolStripMenuItem.Visible = True
            Form1.LOGINToolStripMenuItem.Visible = False
            Me.Visible = False
            ' Lanjutkan dengan tindakan setelah login sukses
        Else
            ' Login gagal
            MessageBox.Show("Username atau password salah!")
            ' Reset textbox username dan password
            TB1.Text = ""
            TB2.Text = ""
        End If
    End Sub

    Private Sub TB2_TextChanged(sender As Object, e As EventArgs) Handles TB2.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TB1.Clear()
        TB2.Clear()
    End Sub
End Class