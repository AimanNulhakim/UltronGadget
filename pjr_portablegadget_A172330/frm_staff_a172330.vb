Public Class frm_staff_a172330


    Private Sub frm_customer_a712330_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_portablegadgets_a172330.accdb;Persist Security Info=False;"
        Dim mysql As String = "SELECT * FROM tbl_staff_a172330"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_staff.DataSource = mydatatable

        grd_staff.Columns(0).HeaderText = "Staff ID"
        grd_staff.Columns(1).HeaderText = "Staff Name"
        grd_staff.Columns(2).HeaderText = "Staff Age"

    End Sub

    Public Sub RefreshForm()

        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_portablegadgets_a172330.accdb;Persist Security Info=False;"
        Dim mysql As String = "SELECT * FROM tbl_staff_a172330"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_staff.DataSource = mydatatable

    End Sub


    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        frm_updatestaff_a172330.Show()
        Me.Hide()
        frm_updatestaff_a172330.RefreshForm()

    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click

        frm_insertstaff_a172330.Show()
        Me.Hide()
        frm_insertstaff_a172330.RefreshForm()

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        frm_mainmenu_A172330.Show()
        Me.Hide()

    End Sub
End Class