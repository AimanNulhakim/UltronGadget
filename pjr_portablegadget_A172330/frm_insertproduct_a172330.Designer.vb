<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_insertproduct_a172330
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_insertproduct_a172330))
        Me.grd_productdetail = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.txt_type = New System.Windows.Forms.TextBox()
        Me.txt_brand = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_warranty = New System.Windows.Forms.TextBox()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.btn_picture = New System.Windows.Forms.Button()
        Me.txt_picture = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btn_back = New System.Windows.Forms.Button()
        CType(Me.grd_productdetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grd_productdetail
        '
        Me.grd_productdetail.AllowUserToAddRows = False
        Me.grd_productdetail.AllowUserToDeleteRows = False
        Me.grd_productdetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_productdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_productdetail.Location = New System.Drawing.Point(54, 51)
        Me.grd_productdetail.Name = "grd_productdetail"
        Me.grd_productdetail.Size = New System.Drawing.Size(913, 344)
        Me.grd_productdetail.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(221, 413)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Product ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(212, 468)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Product Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(237, 518)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(374, 518)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Product Brand"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(383, 413)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Product Type"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(392, 468)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 15)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Quantity"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(557, 518)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 15)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Warranty"
        '
        'txt_quantity
        '
        Me.txt_quantity.Location = New System.Drawing.Point(348, 484)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.Size = New System.Drawing.Size(147, 20)
        Me.txt_quantity.TabIndex = 9
        Me.txt_quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_type
        '
        Me.txt_type.Location = New System.Drawing.Point(348, 433)
        Me.txt_type.Name = "txt_type"
        Me.txt_type.Size = New System.Drawing.Size(147, 20)
        Me.txt_type.TabIndex = 10
        Me.txt_type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_brand
        '
        Me.txt_brand.Location = New System.Drawing.Point(348, 535)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.Size = New System.Drawing.Size(147, 20)
        Me.txt_brand.TabIndex = 11
        Me.txt_brand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(183, 535)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(147, 20)
        Me.txt_price.TabIndex = 12
        Me.txt_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(183, 484)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(147, 20)
        Me.txt_name.TabIndex = 13
        Me.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_id
        '
        Me.txt_id.Enabled = False
        Me.txt_id.Location = New System.Drawing.Point(183, 433)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(147, 20)
        Me.txt_id.TabIndex = 14
        Me.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_warranty
        '
        Me.txt_warranty.Location = New System.Drawing.Point(519, 535)
        Me.txt_warranty.Name = "txt_warranty"
        Me.txt_warranty.Size = New System.Drawing.Size(147, 20)
        Me.txt_warranty.TabIndex = 15
        Me.txt_warranty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_insert
        '
        Me.btn_insert.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insert.Location = New System.Drawing.Point(682, 479)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(110, 35)
        Me.btn_insert.TabIndex = 16
        Me.btn_insert.Text = "Insert"
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'pic_product
        '
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_product.Location = New System.Drawing.Point(518, 413)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(147, 95)
        Me.pic_product.TabIndex = 17
        Me.pic_product.TabStop = False
        '
        'btn_picture
        '
        Me.btn_picture.Location = New System.Drawing.Point(682, 445)
        Me.btn_picture.Name = "btn_picture"
        Me.btn_picture.Size = New System.Drawing.Size(109, 23)
        Me.btn_picture.TabIndex = 19
        Me.btn_picture.Text = "Select Picture"
        Me.btn_picture.UseVisualStyleBackColor = True
        '
        'txt_picture
        '
        Me.txt_picture.Location = New System.Drawing.Point(682, 415)
        Me.txt_picture.Name = "txt_picture"
        Me.txt_picture.Size = New System.Drawing.Size(109, 20)
        Me.txt_picture.TabIndex = 20
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btn_back
        '
        Me.btn_back.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(682, 520)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(110, 35)
        Me.btn_back.TabIndex = 21
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'frm_insertproduct_a172330
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1020, 607)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.txt_picture)
        Me.Controls.Add(Me.btn_picture)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.txt_warranty)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_brand)
        Me.Controls.Add(Me.txt_type)
        Me.Controls.Add(Me.txt_quantity)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grd_productdetail)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frm_insertproduct_a172330"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_insertproduct"
        CType(Me.grd_productdetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grd_productdetail As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_quantity As TextBox
    Friend WithEvents txt_type As TextBox
    Friend WithEvents txt_brand As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_warranty As TextBox
    Friend WithEvents btn_insert As Button
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents btn_picture As Button
    Friend WithEvents txt_picture As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btn_back As Button
End Class
