<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tanggal = New System.Windows.Forms.Label()
        Me.WAKTU = New System.Windows.Forms.Label()
        Me.Jam = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.OrderListToolStripMenuItem, Me.BookListToolStripMenuItem, Me.LOGINToolStripMenuItem, Me.LOGOUTToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(896, 37)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HomeToolStripMenuItem.Font = New System.Drawing.Font("Stencil", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(102, 33)
        Me.HomeToolStripMenuItem.Text = "Saung"
        '
        'OrderListToolStripMenuItem
        '
        Me.OrderListToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.OrderListToolStripMenuItem.Font = New System.Drawing.Font("Stencil", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderListToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.OrderListToolStripMenuItem.Name = "OrderListToolStripMenuItem"
        Me.OrderListToolStripMenuItem.Size = New System.Drawing.Size(162, 33)
        Me.OrderListToolStripMenuItem.Text = "Order list"
        '
        'BookListToolStripMenuItem
        '
        Me.BookListToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BookListToolStripMenuItem.Font = New System.Drawing.Font("Stencil", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookListToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.BookListToolStripMenuItem.Name = "BookListToolStripMenuItem"
        Me.BookListToolStripMenuItem.Size = New System.Drawing.Size(147, 33)
        Me.BookListToolStripMenuItem.Text = "Book list"
        '
        'LOGINToolStripMenuItem
        '
        Me.LOGINToolStripMenuItem.Font = New System.Drawing.Font("Stencil", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LOGINToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.LOGINToolStripMenuItem.Name = "LOGINToolStripMenuItem"
        Me.LOGINToolStripMenuItem.Size = New System.Drawing.Size(96, 33)
        Me.LOGINToolStripMenuItem.Text = "LOGIN"
        '
        'LOGOUTToolStripMenuItem
        '
        Me.LOGOUTToolStripMenuItem.Font = New System.Drawing.Font("Stencil", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LOGOUTToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.LOGOUTToolStripMenuItem.Name = "LOGOUTToolStripMenuItem"
        Me.LOGOUTToolStripMenuItem.Size = New System.Drawing.Size(115, 33)
        Me.LOGOUTToolStripMenuItem.Text = "LOGOUT"
        '
        'Tanggal
        '
        Me.Tanggal.AutoSize = True
        Me.Tanggal.BackColor = System.Drawing.Color.Transparent
        Me.Tanggal.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Tanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tanggal.ForeColor = System.Drawing.Color.Silver
        Me.Tanggal.Location = New System.Drawing.Point(0, 450)
        Me.Tanggal.Name = "Tanggal"
        Me.Tanggal.Size = New System.Drawing.Size(157, 44)
        Me.Tanggal.TabIndex = 1
        Me.Tanggal.Text = "Tanggal"
        '
        'WAKTU
        '
        Me.WAKTU.AutoSize = True
        Me.WAKTU.Location = New System.Drawing.Point(403, 118)
        Me.WAKTU.Name = "WAKTU"
        Me.WAKTU.Size = New System.Drawing.Size(0, 17)
        Me.WAKTU.TabIndex = 2
        '
        'Jam
        '
        Me.Jam.AutoSize = True
        Me.Jam.BackColor = System.Drawing.Color.Transparent
        Me.Jam.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Jam.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Jam.ForeColor = System.Drawing.Color.Silver
        Me.Jam.Location = New System.Drawing.Point(0, 406)
        Me.Jam.Name = "Jam"
        Me.Jam.Size = New System.Drawing.Size(128, 44)
        Me.Jam.TabIndex = 3
        Me.Jam.Text = "Waktu"
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(896, 494)
        Me.Controls.Add(Me.Jam)
        Me.Controls.Add(Me.WAKTU)
        Me.Controls.Add(Me.Tanggal)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Kuring Resto"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrderListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Tanggal As Label
    Friend WithEvents WAKTU As Label
    Friend WithEvents Jam As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LOGINToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LOGOUTToolStripMenuItem As ToolStripMenuItem
End Class
