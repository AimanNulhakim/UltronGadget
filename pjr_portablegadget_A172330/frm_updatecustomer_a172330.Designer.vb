<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_updatecustomer_a172330
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_updatecustomer_a172330))
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.lbl_add = New System.Windows.Forms.Label()
        Me.lbl_sname = New System.Windows.Forms.Label()
        Me.lbl_sid = New System.Windows.Forms.Label()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.grd_customer = New System.Windows.Forms.DataGridView()
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_back
        '
        Me.btn_back.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(397, 333)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(110, 35)
        Me.btn_back.TabIndex = 0
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(263, 333)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(110, 35)
        Me.btn_delete.TabIndex = 29
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(130, 333)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(110, 35)
        Me.btn_update.TabIndex = 28
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'lbl_add
        '
        Me.lbl_add.AutoSize = True
        Me.lbl_add.BackColor = System.Drawing.Color.Transparent
        Me.lbl_add.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_add.Location = New System.Drawing.Point(459, 285)
        Me.lbl_add.Name = "lbl_add"
        Me.lbl_add.Size = New System.Drawing.Size(112, 15)
        Me.lbl_add.TabIndex = 27
        Me.lbl_add.Text = "Customer Address"
        '
        'lbl_sname
        '
        Me.lbl_sname.AutoSize = True
        Me.lbl_sname.BackColor = System.Drawing.Color.Transparent
        Me.lbl_sname.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sname.Location = New System.Drawing.Point(268, 285)
        Me.lbl_sname.Name = "lbl_sname"
        Me.lbl_sname.Size = New System.Drawing.Size(100, 15)
        Me.lbl_sname.TabIndex = 26
        Me.lbl_sname.Text = "Customer Name"
        '
        'lbl_sid
        '
        Me.lbl_sid.AutoSize = True
        Me.lbl_sid.BackColor = System.Drawing.Color.Transparent
        Me.lbl_sid.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sid.Location = New System.Drawing.Point(82, 285)
        Me.lbl_sid.Name = "lbl_sid"
        Me.lbl_sid.Size = New System.Drawing.Size(79, 15)
        Me.lbl_sid.TabIndex = 25
        Me.lbl_sid.Text = "Customer ID"
        '
        'txt_address
        '
        Me.txt_address.Location = New System.Drawing.Point(440, 301)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(147, 20)
        Me.txt_address.TabIndex = 24
        Me.txt_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(246, 301)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(147, 20)
        Me.txt_name.TabIndex = 23
        Me.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(52, 301)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(147, 20)
        Me.txt_id.TabIndex = 22
        Me.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grd_customer
        '
        Me.grd_customer.AllowUserToAddRows = False
        Me.grd_customer.AllowUserToDeleteRows = False
        Me.grd_customer.AllowUserToOrderColumns = True
        Me.grd_customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_customer.Location = New System.Drawing.Point(52, 46)
        Me.grd_customer.Name = "grd_customer"
        Me.grd_customer.Size = New System.Drawing.Size(533, 220)
        Me.grd_customer.TabIndex = 20
        '
        'frm_updatecustomer_a172330
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(636, 436)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.lbl_add)
        Me.Controls.Add(Me.lbl_sname)
        Me.Controls.Add(Me.lbl_sid)
        Me.Controls.Add(Me.txt_address)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.grd_customer)
        Me.Controls.Add(Me.btn_back)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frm_updatecustomer_a172330"
        Me.Text = "frm_updatecustomer_a172330"
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_back As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents lbl_add As Label
    Friend WithEvents lbl_sname As Label
    Friend WithEvents lbl_sid As Label
    Friend WithEvents txt_address As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents grd_customer As DataGridView
End Class
