<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_updatestaff_a172330
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_updatestaff_a172330))
        Me.btn_update = New System.Windows.Forms.Button()
        Me.lbl_sage = New System.Windows.Forms.Label()
        Me.lbl_sname = New System.Windows.Forms.Label()
        Me.lbl_sid = New System.Windows.Forms.Label()
        Me.txt_age = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.grd_staff = New System.Windows.Forms.DataGridView()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_ = New System.Windows.Forms.Button()
        CType(Me.grd_staff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_update
        '
        Me.btn_update.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(135, 322)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(110, 35)
        Me.btn_update.TabIndex = 17
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'lbl_sage
        '
        Me.lbl_sage.AutoSize = True
        Me.lbl_sage.BackColor = System.Drawing.Color.Transparent
        Me.lbl_sage.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sage.Location = New System.Drawing.Point(482, 280)
        Me.lbl_sage.Name = "lbl_sage"
        Me.lbl_sage.Size = New System.Drawing.Size(60, 15)
        Me.lbl_sage.TabIndex = 16
        Me.lbl_sage.Text = "Staff Age"
        '
        'lbl_sname
        '
        Me.lbl_sname.AutoSize = True
        Me.lbl_sname.BackColor = System.Drawing.Color.Transparent
        Me.lbl_sname.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sname.Location = New System.Drawing.Point(288, 280)
        Me.lbl_sname.Name = "lbl_sname"
        Me.lbl_sname.Size = New System.Drawing.Size(72, 15)
        Me.lbl_sname.TabIndex = 15
        Me.lbl_sname.Text = "Staff Name"
        '
        'lbl_sid
        '
        Me.lbl_sid.AutoSize = True
        Me.lbl_sid.BackColor = System.Drawing.Color.Transparent
        Me.lbl_sid.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sid.Location = New System.Drawing.Point(102, 280)
        Me.lbl_sid.Name = "lbl_sid"
        Me.lbl_sid.Size = New System.Drawing.Size(51, 15)
        Me.lbl_sid.TabIndex = 14
        Me.lbl_sid.Text = "Staff ID"
        '
        'txt_age
        '
        Me.txt_age.Location = New System.Drawing.Point(438, 296)
        Me.txt_age.Name = "txt_age"
        Me.txt_age.Size = New System.Drawing.Size(147, 20)
        Me.txt_age.TabIndex = 13
        Me.txt_age.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(247, 296)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(147, 20)
        Me.txt_name.TabIndex = 12
        Me.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(52, 296)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(147, 20)
        Me.txt_id.TabIndex = 11
        Me.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grd_staff
        '
        Me.grd_staff.AllowUserToAddRows = False
        Me.grd_staff.AllowUserToDeleteRows = False
        Me.grd_staff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_staff.Location = New System.Drawing.Point(52, 46)
        Me.grd_staff.Name = "grd_staff"
        Me.grd_staff.Size = New System.Drawing.Size(533, 220)
        Me.grd_staff.TabIndex = 9
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(265, 322)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(110, 35)
        Me.btn_delete.TabIndex = 18
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_
        '
        Me.btn_.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_.Location = New System.Drawing.Point(395, 322)
        Me.btn_.Name = "btn_"
        Me.btn_.Size = New System.Drawing.Size(110, 35)
        Me.btn_.TabIndex = 19
        Me.btn_.Text = "Back"
        Me.btn_.UseVisualStyleBackColor = True
        '
        'frm_updatestaff_a172330
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(636, 436)
        Me.Controls.Add(Me.btn_)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.lbl_sage)
        Me.Controls.Add(Me.lbl_sname)
        Me.Controls.Add(Me.lbl_sid)
        Me.Controls.Add(Me.txt_age)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.grd_staff)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frm_updatestaff_a172330"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_updatestaff_a172330"
        CType(Me.grd_staff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_update As Button
    Friend WithEvents lbl_sage As Label
    Friend WithEvents lbl_sname As Label
    Friend WithEvents lbl_sid As Label
    Friend WithEvents txt_age As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents grd_staff As DataGridView
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_ As Button
End Class
