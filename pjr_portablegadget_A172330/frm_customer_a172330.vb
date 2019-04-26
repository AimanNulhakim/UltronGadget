Public Class frm_customer_a172330
    Private Sub frm_customer_a712330_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_portablegadgets_a172330.accdb;Persist Security Info=False;"
        Dim mysql As String = "SELECT * FROM tbl_customer_a172330"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_customer.DataSource = mydatatable

        grd_customer.Columns(0).HeaderText = "Customer ID"
        grd_customer.Columns(1).HeaderText = "Customer Name"
        grd_customer.Columns(2).HeaderText = "Customer Address"

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbl_cust.Click

    End Sub

    Private Sub frm_customer_a172330_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        frm_updatecustomer_a172330.Show()
        Me.Hide()
        frm_updatecustomer_a172330.RefreshForm()


    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click


        frm_insertcustomer_a172330.Show()
        Me.Hide()
        frm_insertcustomer_a172330.RefreshForm()

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        frm_mainmenu_A172330.Show()
        Me.Hide()

    End Sub

    Public Sub RefreshForm()
        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_portablegadgets_a172330.accdb;Persist Security Info=False;"
        Dim mysql As String = "SELECT * FROM tbl_customer_a172330"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_customer.DataSource = mydatatable



    End Sub

End Class