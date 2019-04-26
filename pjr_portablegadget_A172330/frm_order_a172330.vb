Public Class frm_order_a172330
    Private Sub frm_order_a172330_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_portablegadgets_a172330.accdb;Persist Security Info=False;"
        Dim mysql As String = "SELECT * FROM tbl_order_a172330"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_order.DataSource = mydatatable

        grd_order.Columns(0).HeaderText = "Order ID"
        grd_order.Columns(1).HeaderText = "Date Of Order"
        grd_order.Columns(2).HeaderText = "Product ID"
        grd_order.Columns(3).HeaderText = "Customer ID"
        grd_order.Columns(4).HeaderText = "Managing Staff"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        frm_mainmenu_A172330.Show()
        Me.Hide()

    End Sub

    Private Sub btn_makeorder_Click(sender As Object, e As EventArgs) Handles btn_makeorder.Click
        frm_makeorder_A172330.Show()
        Me.Hide()
    End Sub



    Public Sub RefreshForm()

        Dim mysql As String = "SELECT * FROM tbl_order_a172330"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        grd_order.DataSource = mydatatable

    End Sub
End Class