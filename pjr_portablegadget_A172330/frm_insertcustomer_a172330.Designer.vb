<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_insertcustomer_a172330
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_insertcustomer_a172330))
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.lbl_sage = New System.Windows.Forms.Label()
        Me.lbl_sname = New System.Windows.Forms.Label()
        Me.lbl_sid = New System.Windows.Forms.Label()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.grd_customer = New System.Windows.Forms.DataGridView()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_insert
        '
        Me.btn_insert.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insert.Location = New System.Drawing.Point(424, 302)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(110, 35)
        Me.btn_insert.TabIndex = 33
        Me.btn_insert.Text = "Insert"
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'lbl_sage
        '
        Me.lbl_sage.AutoSize = True
        Me.lbl_sage.BackColor = System.Drawing.Color.Transparent
        Me.lbl_sage.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sage.Location = New System.Drawing.Point(421, 238)
        Me.lbl_sage.Name = "lbl_sage"
        Me.lbl_sage.Size = New System.Drawing.Size(112, 15)
        Me.lbl_sage.TabIndex = 32
        Me.lbl_sage.Text = "Customer Address"
        '
        'lbl_sname
        '
        Me.lbl_sname.AutoSize = True
        Me.lbl_sname.BackColor = System.Drawing.Color.Transparent
        Me.lbl_sname.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sname.Location = New System.Drawing.Point(427, 175)
        Me.lbl_sname.Name = "lbl_sname"
        Me.lbl_sname.Size = New System.Drawing.Size(100, 15)
        Me.lbl_sname.TabIndex = 31
        Me.lbl_sname.Text = "Customer Name"
        '
        'lbl_sid
        '
        Me.lbl_sid.AutoSize = True
        Me.lbl_sid.BackColor = System.Drawing.Color.Transparent
        Me.lbl_sid.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sid.Location = New System.Drawing.Point(437, 110)
        Me.lbl_sid.Name = "lbl_sid"
        Me.lbl_sid.Size = New System.Drawing.Size(79, 15)
        Me.lbl_sid.TabIndex = 30
        Me.lbl_sid.Text = "Customer ID"
        '
        'txt_address
        '
        Me.txt_address.Location = New System.Drawing.Point(406, 256)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(147, 20)
        Me.txt_address.TabIndex = 29
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(406, 193)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(147, 20)
        Me.txt_name.TabIndex = 28
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(406, 128)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(147, 20)
        Me.txt_id.TabIndex = 27
        '
        'grd_customer
        '
        Me.grd_customer.AllowUserToAddRows = False
        Me.grd_customer.AllowUserToDeleteRows = False
        Me.grd_customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_customer.Location = New System.Drawing.Point(51, 63)
        Me.grd_customer.Name = "grd_customer"
        Me.grd_customer.Size = New System.Drawing.Size(315, 321)
        Me.grd_customer.TabIndex = 25
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(423, 343)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 35)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frm_insertcustomer_a172330
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(636, 436)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.lbl_sage)
        Me.Controls.Add(Me.lbl_sname)
        Me.Controls.Add(Me.lbl_sid)
        Me.Controls.Add(Me.txt_address)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.grd_customer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frm_insertcustomer_a172330"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_insertcustomer_a172330"
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_insert As Button
    Friend WithEvents lbl_sage As Label
    Friend WithEvents lbl_sname As Label
    Friend WithEvents lbl_sid As Label
    Friend WithEvents txt_address As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents grd_customer As DataGridView
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button1 As Button
End Class
