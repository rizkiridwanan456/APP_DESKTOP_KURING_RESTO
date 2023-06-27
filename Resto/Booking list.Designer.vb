<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Booking_list
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
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
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Booking_list))
        Me.DG = New System.Windows.Forms.DataGridView()
        Me.SA = New System.Windows.Forms.Button()
        Me.Close = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB1 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DG
        '
        Me.DG.BackgroundColor = System.Drawing.Color.Green
        Me.DG.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG.DefaultCellStyle = DataGridViewCellStyle2
        Me.DG.Location = New System.Drawing.Point(133, 104)
        Me.DG.Name = "DG"
        Me.DG.RowHeadersWidth = 51
        Me.DG.RowTemplate.Height = 24
        Me.DG.Size = New System.Drawing.Size(728, 343)
        Me.DG.TabIndex = 4
        '
        'SA
        '
        Me.SA.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.SA.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SA.Location = New System.Drawing.Point(782, 464)
        Me.SA.Name = "SA"
        Me.SA.Size = New System.Drawing.Size(102, 45)
        Me.SA.TabIndex = 5
        Me.SA.Text = "SAUNG"
        Me.SA.UseVisualStyleBackColor = False
        '
        'Close
        '
        Me.Close.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Close.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Close.Location = New System.Drawing.Point(674, 464)
        Me.Close.Name = "Close"
        Me.Close.Size = New System.Drawing.Size(102, 45)
        Me.Close.TabIndex = 6
        Me.Close.Text = "CLOSE"
        Me.Close.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(201, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(643, 46)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "SAUNG KURING LIST BOOKING"
        '
        'TB1
        '
        Me.TB1.Location = New System.Drawing.Point(133, 464)
        Me.TB1.Name = "TB1"
        Me.TB1.Size = New System.Drawing.Size(162, 22)
        Me.TB1.TabIndex = 11
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(217, 504)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(78, 36)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Data"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(133, 504)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(78, 36)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Search"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Booking_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(963, 594)
        Me.Controls.Add(Me.TB1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Close)
        Me.Controls.Add(Me.SA)
        Me.Controls.Add(Me.DG)
        Me.Name = "Booking_list"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Booking_list"
        CType(Me.DG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DG As DataGridView
    Friend WithEvents SA As Button
    Friend WithEvents Close As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TB1 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
End Class
