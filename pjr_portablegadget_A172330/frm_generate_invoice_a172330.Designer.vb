<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_generate_invoice_a172330
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_pg = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grd_details = New System.Windows.Forms.DataGridView()
        Me.lbl_invoice = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_deliveryaddress = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.grd_details, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(283, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 19)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Your No 1 Gadget Partner"
        '
        'lbl_pg
        '
        Me.lbl_pg.AutoSize = True
        Me.lbl_pg.BackColor = System.Drawing.Color.Transparent
        Me.lbl_pg.Font = New System.Drawing.Font("Stencil Std", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pg.Location = New System.Drawing.Point(272, 18)
        Me.lbl_pg.Name = "lbl_pg"
        Me.lbl_pg.Size = New System.Drawing.Size(252, 36)
        Me.lbl_pg.TabIndex = 13
        Me.lbl_pg.Text = "ULTRON GADGET" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 18)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "INVOICE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(256, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(290, 64)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "No 14, Jalan Perindustrian Bangi 7" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "34550, Kajang, Selangor, Malaysia" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "03-3445 " &
    "6712 | business@ultrongadget.asia"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'grd_details
        '
        Me.grd_details.AllowUserToAddRows = False
        Me.grd_details.AllowUserToDeleteRows = False
        Me.grd_details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_details.BackgroundColor = System.Drawing.Color.White
        Me.grd_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_details.Location = New System.Drawing.Point(31, 143)
        Me.grd_details.Name = "grd_details"
        Me.grd_details.ReadOnly = True
        Me.grd_details.Size = New System.Drawing.Size(739, 150)
        Me.grd_details.TabIndex = 17
        '
        'lbl_invoice
        '
        Me.lbl_invoice.AutoSize = True
        Me.lbl_invoice.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_invoice.Location = New System.Drawing.Point(730, 48)
        Me.lbl_invoice.Name = "lbl_invoice"
        Me.lbl_invoice.Size = New System.Drawing.Size(44, 15)
        Me.lbl_invoice.TabIndex = 19
        Me.lbl_invoice.Text = "Label5"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(659, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 15)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Invoice No."
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Location = New System.Drawing.Point(727, 305)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(39, 13)
        Me.lbl_total.TabIndex = 22
        Me.lbl_total.Text = "Label6"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(658, 305)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Total Price : $"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 305)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Delivery Address :"
        '
        'txt_deliveryaddress
        '
        Me.txt_deliveryaddress.BackColor = System.Drawing.Color.White
        Me.txt_deliveryaddress.Location = New System.Drawing.Point(126, 305)
        Me.txt_deliveryaddress.Multiline = True
        Me.txt_deliveryaddress.Name = "txt_deliveryaddress"
        Me.txt_deliveryaddress.ReadOnly = True
        Me.txt_deliveryaddress.Size = New System.Drawing.Size(526, 62)
        Me.txt_deliveryaddress.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(256, 431)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(290, 15)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Make all checks payable to the ULTRON GADGET "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(181, 447)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(416, 15)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Total due in 15 days. Overdue accounts subject to a service charge 5%"
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.Location = New System.Drawing.Point(702, 24)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(44, 15)
        Me.lbl_date.TabIndex = 28
        Me.lbl_date.Text = "Label9"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(662, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 15)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Date"
        '
        'frm_generate_invoice_a172330
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 490)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_deliveryaddress)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_invoice)
        Me.Controls.Add(Me.grd_details)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_pg)
        Me.Name = "frm_generate_invoice_a172330"
        Me.Text = "frm_generate_invoice_a172330"
        CType(Me.grd_details, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_pg As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents grd_details As DataGridView
    Friend WithEvents lbl_invoice As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_deliveryaddress As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents Label9 As Label
End Class
