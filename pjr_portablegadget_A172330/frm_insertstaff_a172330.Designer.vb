<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_insertstaff_a172330
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_insertstaff_a172330))
        Me.grd_staff = New System.Windows.Forms.DataGridView()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_age = New System.Windows.Forms.TextBox()
        Me.lbl_sid = New System.Windows.Forms.Label()
        Me.lbl_sname = New System.Windows.Forms.Label()
        Me.lbl_sage = New System.Windows.Forms.Label()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.grd_staff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grd_staff
        '
        Me.grd_staff.AllowUserToAddRows = False
        Me.grd_staff.AllowUserToDeleteRows = False
        Me.grd_staff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_staff.Location = New System.Drawing.Point(46, 47)
        Me.grd_staff.Name = "grd_staff"
        Me.grd_staff.Size = New System.Drawing.Size(552, 175)
        Me.grd_staff.TabIndex = 0
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(46, 266)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(147, 20)
        Me.txt_id.TabIndex = 2
        Me.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(248, 266)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(147, 20)
        Me.txt_name.TabIndex = 3
        Me.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_age
        '
        Me.txt_age.Location = New System.Drawing.Point(451, 266)
        Me.txt_age.Name = "txt_age"
        Me.txt_age.Size = New System.Drawing.Size(147, 20)
        Me.txt_age.TabIndex = 4
        Me.txt_age.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_sid
        '
        Me.lbl_sid.AutoSize = True
        Me.lbl_sid.BackColor = System.Drawing.Color.Transparent
        Me.lbl_sid.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sid.Location = New System.Drawing.Point(98, 248)
        Me.lbl_sid.Name = "lbl_sid"
        Me.lbl_sid.Size = New System.Drawing.Size(51, 15)
        Me.lbl_sid.TabIndex = 5
        Me.lbl_sid.Text = "Staff ID"
        '
        'lbl_sname
        '
        Me.lbl_sname.AutoSize = True
        Me.lbl_sname.BackColor = System.Drawing.Color.Transparent
        Me.lbl_sname.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sname.Location = New System.Drawing.Point(285, 248)
        Me.lbl_sname.Name = "lbl_sname"
        Me.lbl_sname.Size = New System.Drawing.Size(72, 15)
        Me.lbl_sname.TabIndex = 6
        Me.lbl_sname.Text = "Staff Name"
        '
        'lbl_sage
        '
        Me.lbl_sage.AutoSize = True
        Me.lbl_sage.BackColor = System.Drawing.Color.Transparent
        Me.lbl_sage.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sage.Location = New System.Drawing.Point(497, 248)
        Me.lbl_sage.Name = "lbl_sage"
        Me.lbl_sage.Size = New System.Drawing.Size(60, 15)
        Me.lbl_sage.TabIndex = 7
        Me.lbl_sage.Text = "Staff Age"
        '
        'btn_insert
        '
        Me.btn_insert.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insert.Location = New System.Drawing.Point(268, 304)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(110, 35)
        Me.btn_insert.TabIndex = 8
        Me.btn_insert.Text = "Insert"
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(268, 355)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 35)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frm_insertstaff_a172330
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
        Me.Controls.Add(Me.txt_age)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.grd_staff)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frm_insertstaff_a172330"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_insertstaff_a172330"
        CType(Me.grd_staff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grd_staff As DataGridView
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_age As TextBox
    Friend WithEvents lbl_sid As Label
    Friend WithEvents lbl_sname As Label
    Friend WithEvents lbl_sage As Label
    Friend WithEvents btn_insert As Button
    Friend WithEvents Button1 As Button
End Class
