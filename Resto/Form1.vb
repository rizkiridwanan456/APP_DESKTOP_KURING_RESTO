Public Class Form1
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Tanggal.Text = "Date :" & Format(Now, "dd/MM/yyyy")
		Timer1.Start()
		HomeToolStripMenuItem.Visible = False
		OrderListToolStripMenuItem.Visible = False
		BookListToolStripMenuItem.Visible = False
		LOGOUTToolStripMenuItem.Visible = False
	End Sub
	Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
		Saung.Show()
	End Sub
	Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
		Saung.Show()
	End Sub
	Private Sub OrderListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrderListToolStripMenuItem.Click
		Order_list.Show()
	End Sub
	Private Sub BookListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookListToolStripMenuItem.Click
		Booking_list.Show()
	End Sub
	Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
		Jam.Text = "Waktu :" & DateTime.Now.ToString("HH:mm:ss")
	End Sub

	Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

	End Sub

	Private Sub LOGINToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGINToolStripMenuItem.Click
		Login.Show()
	End Sub

	Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem.Click
		HomeToolStripMenuItem.Visible = False
		OrderListToolStripMenuItem.Visible = False
		BookListToolStripMenuItem.Visible = False
		LOGOUTToolStripMenuItem.Visible = False
		LOGINToolStripMenuItem.Visible = True
	End Sub
End Class
