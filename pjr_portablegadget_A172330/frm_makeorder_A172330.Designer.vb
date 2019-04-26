<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_makeorder_A172330
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
        Me.grd_item = New System.Windows.Forms.DataGridView()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_productname = New System.Windows.Forms.TextBox()
        Me.txt_productID = New System.Windows.Forms.TextBox()
        Me.txt_brand = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_producttype = New System.Windows.Forms.TextBox()
        Me.btn_makeorder = New System.Windows.Forms.Button()
        Me.cmb_staff = New System.Windows.Forms.ComboBox()
        Me.cmb_customer = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_orderID = New System.Windows.Forms.TextBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.lst_productname = New System.Windows.Forms.ListBox()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_itemID = New System.Windows.Forms.TextBox()
        Me.txt_subtotal = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_invoice = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.grd_item, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'grd_item
        '
        Me.grd_item.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_item.Location = New System.Drawing.Point(308, 45)
        Me.grd_item.Name = "grd_item"
        Me.grd_item.ReadOnly = True
        Me.grd_item.Size = New System.Drawing.Size(633, 119)
        Me.grd_item.TabIndex = 0
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(94, 53)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.ReadOnly = True
        Me.txt_price.Size = New System.Drawing.Size(100, 20)
        Me.txt_price.TabIndex = 1
        '
        'txt_productname
        '
        Me.txt_productname.Location = New System.Drawing.Point(94, 23)
        Me.txt_productname.Name = "txt_productname"
        Me.txt_productname.ReadOnly = True
        Me.txt_productname.Size = New System.Drawing.Size(100, 20)
        Me.txt_productname.TabIndex = 3
        '
        'txt_productID
        '
        Me.txt_productID.Location = New System.Drawing.Point(94, 120)
        Me.txt_productID.Name = "txt_productID"
        Me.txt_productID.ReadOnly = True
        Me.txt_productID.Size = New System.Drawing.Size(100, 20)
        Me.txt_productID.TabIndex = 4
        '
        'txt_brand
        '
        Me.txt_brand.Location = New System.Drawing.Point(94, 87)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.ReadOnly = True
        Me.txt_brand.Size = New System.Drawing.Size(100, 20)
        Me.txt_brand.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Product Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Product Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Product Brand "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Product ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Product Type"
        '
        'txt_producttype
        '
        Me.txt_producttype.Location = New System.Drawing.Point(94, 151)
        Me.txt_producttype.Name = "txt_producttype"
        Me.txt_producttype.ReadOnly = True
        Me.txt_producttype.Size = New System.Drawing.Size(100, 20)
        Me.txt_producttype.TabIndex = 11
        '
        'btn_makeorder
        '
        Me.btn_makeorder.Location = New System.Drawing.Point(781, 310)
        Me.btn_makeorder.Name = "btn_makeorder"
        Me.btn_makeorder.Size = New System.Drawing.Size(115, 23)
        Me.btn_makeorder.TabIndex = 12
        Me.btn_makeorder.Text = "Make Order"
        Me.btn_makeorder.UseVisualStyleBackColor = True
        '
        'cmb_staff
        '
        Me.cmb_staff.FormattingEnabled = True
        Me.cmb_staff.Location = New System.Drawing.Point(94, 134)
        Me.cmb_staff.Name = "cmb_staff"
        Me.cmb_staff.Size = New System.Drawing.Size(100, 21)
        Me.cmb_staff.TabIndex = 13
        '
        'cmb_customer
        '
        Me.cmb_customer.FormattingEnabled = True
        Me.cmb_customer.Location = New System.Drawing.Point(94, 24)
        Me.cmb_customer.Name = "cmb_customer"
        Me.cmb_customer.Size = New System.Drawing.Size(100, 21)
        Me.cmb_customer.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Managing Staff"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Customer ID"
        '
        'txt_orderID
        '
        Me.txt_orderID.Location = New System.Drawing.Point(94, 23)
        Me.txt_orderID.Name = "txt_orderID"
        Me.txt_orderID.ReadOnly = True
        Me.txt_orderID.Size = New System.Drawing.Size(100, 20)
        Me.txt_orderID.TabIndex = 17
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(18, 23)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(47, 13)
        Me.lbl1.TabIndex = 18
        Me.lbl1.Text = "Order ID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Quantity"
        '
        'txt_quantity
        '
        Me.txt_quantity.Location = New System.Drawing.Point(94, 97)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.Size = New System.Drawing.Size(100, 20)
        Me.txt_quantity.TabIndex = 19
        '
        'lst_productname
        '
        Me.lst_productname.FormattingEnabled = True
        Me.lst_productname.Location = New System.Drawing.Point(53, 45)
        Me.lst_productname.Name = "lst_productname"
        Me.lst_productname.Size = New System.Drawing.Size(246, 433)
        Me.lst_productname.TabIndex = 25
        '
        'pic_product
        '
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_product.Location = New System.Drawing.Point(308, 174)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(200, 118)
        Me.pic_product.TabIndex = 26
        Me.pic_product.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Item ID"
        '
        'txt_itemID
        '
        Me.txt_itemID.Location = New System.Drawing.Point(94, 60)
        Me.txt_itemID.Name = "txt_itemID"
        Me.txt_itemID.ReadOnly = True
        Me.txt_itemID.Size = New System.Drawing.Size(100, 20)
        Me.txt_itemID.TabIndex = 27
        '
        'txt_subtotal
        '
        Me.txt_subtotal.Location = New System.Drawing.Point(92, 23)
        Me.txt_subtotal.Name = "txt_subtotal"
        Me.txt_subtotal.ReadOnly = True
        Me.txt_subtotal.Size = New System.Drawing.Size(100, 20)
        Me.txt_subtotal.TabIndex = 29
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 13)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Sub Total"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(26, 59)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 13)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Total"
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(93, 56)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.ReadOnly = True
        Me.txt_total.Size = New System.Drawing.Size(100, 20)
        Me.txt_total.TabIndex = 31
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_price)
        Me.GroupBox1.Controls.Add(Me.txt_productname)
        Me.GroupBox1.Controls.Add(Me.txt_productID)
        Me.GroupBox1.Controls.Add(Me.txt_brand)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_producttype)
        Me.GroupBox1.Location = New System.Drawing.Point(308, 299)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 183)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product Details"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txt_orderID)
        Me.GroupBox2.Controls.Add(Me.lbl1)
        Me.GroupBox2.Controls.Add(Me.txt_quantity)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txt_itemID)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cmb_staff)
        Me.GroupBox2.Location = New System.Drawing.Point(514, 174)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 165)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Order Details"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_address)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.cmb_customer)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(514, 345)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 137)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Customer Details"
        '
        'txt_address
        '
        Me.txt_address.Location = New System.Drawing.Point(16, 76)
        Me.txt_address.Multiline = True
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(178, 55)
        Me.txt_address.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Delivery Address"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txt_subtotal)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.txt_total)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Location = New System.Drawing.Point(726, 174)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox4.TabIndex = 36
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Price"
        '
        'btn_invoice
        '
        Me.btn_invoice.Location = New System.Drawing.Point(781, 340)
        Me.btn_invoice.Name = "btn_invoice"
        Me.btn_invoice.Size = New System.Drawing.Size(115, 23)
        Me.btn_invoice.TabIndex = 37
        Me.btn_invoice.Text = "Generate Invoice"
        Me.btn_invoice.UseVisualStyleBackColor = True
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(781, 398)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(115, 23)
        Me.btn_back.TabIndex = 38
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'btn_reset
        '
        Me.btn_reset.Location = New System.Drawing.Point(781, 369)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(115, 23)
        Me.btn_reset.TabIndex = 39
        Me.btn_reset.Text = "Reset"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Location = New System.Drawing.Point(908, 9)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(45, 13)
        Me.lbl_date.TabIndex = 40
        Me.lbl_date.Text = "Label13"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(862, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 13)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "Date : "
        '
        'frm_makeorder_A172330
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumTurquoise
        Me.ClientSize = New System.Drawing.Size(983, 494)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_invoice)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.lst_productname)
        Me.Controls.Add(Me.btn_makeorder)
        Me.Controls.Add(Me.grd_item)
        Me.Name = "frm_makeorder_A172330"
        Me.Text = "frm_makeorder_A172330"
        CType(Me.grd_item, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grd_item As DataGridView
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_productname As TextBox
    Friend WithEvents txt_productID As TextBox
    Friend WithEvents txt_brand As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_producttype As TextBox
    Friend WithEvents btn_makeorder As Button
    Friend WithEvents cmb_staff As ComboBox
    Friend WithEvents cmb_customer As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_orderID As TextBox
    Friend WithEvents lbl1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_quantity As TextBox
    Friend WithEvents lst_productname As ListBox
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_itemID As TextBox
    Friend WithEvents txt_subtotal As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_total As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txt_address As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btn_invoice As Button
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_reset As Button
    Friend WithEvents lbl_date As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label13 As Label
End Class
