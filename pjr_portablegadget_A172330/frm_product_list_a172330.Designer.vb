<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_product_list_a172330
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_product_list_a172330))
        Me.grd_productdetail = New System.Windows.Forms.DataGridView()
        Me.lbl_product = New System.Windows.Forms.Label()
        Me.txt_productID = New System.Windows.Forms.TextBox()
        Me.lbl_productName = New System.Windows.Forms.Label()
        Me.txt_productBrand = New System.Windows.Forms.TextBox()
        Me.lbl_productBrand = New System.Windows.Forms.Label()
        Me.lbl_productPrice = New System.Windows.Forms.Label()
        Me.txt_productPrice = New System.Windows.Forms.TextBox()
        Me.lst_productName = New System.Windows.Forms.ListBox()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        CType(Me.grd_productdetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grd_productdetail
        '
        Me.grd_productdetail.AllowUserToAddRows = False
        Me.grd_productdetail.AllowUserToDeleteRows = False
        Me.grd_productdetail.AllowUserToOrderColumns = True
        Me.grd_productdetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_productdetail.BackgroundColor = System.Drawing.Color.MediumAquamarine
        Me.grd_productdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_productdetail.Location = New System.Drawing.Point(28, 51)
        Me.grd_productdetail.Name = "grd_productdetail"
        Me.grd_productdetail.Size = New System.Drawing.Size(964, 297)
        Me.grd_productdetail.TabIndex = 0
        '
        'lbl_product
        '
        Me.lbl_product.AutoSize = True
        Me.lbl_product.BackColor = System.Drawing.Color.Transparent
        Me.lbl_product.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_product.Location = New System.Drawing.Point(419, 25)
        Me.lbl_product.Name = "lbl_product"
        Me.lbl_product.Size = New System.Drawing.Size(173, 23)
        Me.lbl_product.TabIndex = 1
        Me.lbl_product.Text = "List of Product"
        '
        'txt_productID
        '
        Me.txt_productID.Location = New System.Drawing.Point(336, 409)
        Me.txt_productID.Name = "txt_productID"
        Me.txt_productID.Size = New System.Drawing.Size(147, 20)
        Me.txt_productID.TabIndex = 2
        Me.txt_productID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_productName
        '
        Me.lbl_productName.AutoSize = True
        Me.lbl_productName.BackColor = System.Drawing.Color.Transparent
        Me.lbl_productName.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_productName.Location = New System.Drawing.Point(374, 393)
        Me.lbl_productName.Name = "lbl_productName"
        Me.lbl_productName.Size = New System.Drawing.Size(68, 15)
        Me.lbl_productName.TabIndex = 3
        Me.lbl_productName.Text = "Product ID"
        '
        'txt_productBrand
        '
        Me.txt_productBrand.Location = New System.Drawing.Point(336, 460)
        Me.txt_productBrand.Name = "txt_productBrand"
        Me.txt_productBrand.Size = New System.Drawing.Size(147, 20)
        Me.txt_productBrand.TabIndex = 4
        Me.txt_productBrand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_productBrand
        '
        Me.lbl_productBrand.AutoSize = True
        Me.lbl_productBrand.BackColor = System.Drawing.Color.Transparent
        Me.lbl_productBrand.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_productBrand.Location = New System.Drawing.Point(362, 444)
        Me.lbl_productBrand.Name = "lbl_productBrand"
        Me.lbl_productBrand.Size = New System.Drawing.Size(89, 15)
        Me.lbl_productBrand.TabIndex = 5
        Me.lbl_productBrand.Text = "Product Brand"
        '
        'lbl_productPrice
        '
        Me.lbl_productPrice.AutoSize = True
        Me.lbl_productPrice.BackColor = System.Drawing.Color.Transparent
        Me.lbl_productPrice.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_productPrice.Location = New System.Drawing.Point(365, 500)
        Me.lbl_productPrice.Name = "lbl_productPrice"
        Me.lbl_productPrice.Size = New System.Drawing.Size(84, 15)
        Me.lbl_productPrice.TabIndex = 6
        Me.lbl_productPrice.Text = "Product Price"
        '
        'txt_productPrice
        '
        Me.txt_productPrice.Location = New System.Drawing.Point(336, 516)
        Me.txt_productPrice.Name = "txt_productPrice"
        Me.txt_productPrice.Size = New System.Drawing.Size(147, 20)
        Me.txt_productPrice.TabIndex = 7
        Me.txt_productPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lst_productName
        '
        Me.lst_productName.FormattingEnabled = True
        Me.lst_productName.Location = New System.Drawing.Point(76, 365)
        Me.lst_productName.Name = "lst_productName"
        Me.lst_productName.Size = New System.Drawing.Size(231, 225)
        Me.lst_productName.TabIndex = 8
        '
        'pic_product
        '
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_product.Location = New System.Drawing.Point(527, 378)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(231, 187)
        Me.pic_product.TabIndex = 9
        Me.pic_product.TabStop = False
        '
        'btn_insert
        '
        Me.btn_insert.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insert.Location = New System.Drawing.Point(805, 413)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(110, 35)
        Me.btn_insert.TabIndex = 10
        Me.btn_insert.Text = "Insert"
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(805, 457)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(110, 35)
        Me.btn_update.TabIndex = 11
        Me.btn_update.Text = "Update "
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_back
        '
        Me.btn_back.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(805, 500)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(110, 35)
        Me.btn_back.TabIndex = 12
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'frm_product_list_a172330
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumTurquoise
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1020, 607)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.lst_productName)
        Me.Controls.Add(Me.txt_productPrice)
        Me.Controls.Add(Me.lbl_productPrice)
        Me.Controls.Add(Me.lbl_productBrand)
        Me.Controls.Add(Me.txt_productBrand)
        Me.Controls.Add(Me.lbl_productName)
        Me.Controls.Add(Me.txt_productID)
        Me.Controls.Add(Me.lbl_product)
        Me.Controls.Add(Me.grd_productdetail)
        Me.Name = "frm_product_list_a172330"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_product_list"
        CType(Me.grd_productdetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grd_productdetail As DataGridView
    Friend WithEvents lbl_product As Label
    Friend WithEvents txt_productID As TextBox
    Friend WithEvents lbl_productName As Label
    Friend WithEvents txt_productBrand As TextBox
    Friend WithEvents lbl_productBrand As Label
    Friend WithEvents lbl_productPrice As Label
    Friend WithEvents txt_productPrice As TextBox
    Friend WithEvents lst_productName As ListBox
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents btn_insert As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_back As Button
End Class
