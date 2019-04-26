Public Class frm_product_list_a172330
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_productdetail.CellContentClick

    End Sub

    Private Sub frm_product_list_a172330_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_portablegadgets_a172330.accdb;Persist Security Info=False;"
        'Dim mysql1 As String = "SELECT * FROM tbl_products_a172330"
        'Dim mydatatable As New DataTable
        'Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        'myreader.Fill(mydatatable)
        'grd_product.DataSource = mydatatable

        Dim mysql As String = "SELECT * FROM tbl_products_a172330"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        lst_productName.DataSource = mydatatable
        lst_productName.DisplayMember = "fld_product_name"
        grd_productdetail.DataSource = mydatatable

        grd_productdetail.Columns(0).HeaderText = "Product ID"
        grd_productdetail.Columns(1).HeaderText = "Product Name"
        grd_productdetail.Columns(2).HeaderText = "Price"
        grd_productdetail.Columns(3).HeaderText = "Brand"
        grd_productdetail.Columns(4).HeaderText = "Product Type"
        grd_productdetail.Columns(5).HeaderText = "Quantity"
        grd_productdetail.Columns(6).HeaderText = "Product Warranty"

        refresh_text(lst_productName.Text)

    End Sub

    Private Sub refresh_text(product As String)

        Dim mysql As String = "SELECT * FROM tbl_products_a172330 WHERE fld_product_name='" & product & "'"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        txt_productID.Text = mydatatable.Rows(0).Item("fld_product_id")
        txt_productBrand.Text = mydatatable.Rows(0).Item("fld_brand")
        txt_productPrice.Text = mydatatable.Rows(0).Item("fld_price")

        Try
            pic_product.BackgroundImage = Image.FromFile("pictures/" & txt_productID.Text & ".jpg")

        Catch ex As Exception
            pic_product.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")
        End Try


    End Sub

    Private Sub lst_productName_MouseClick(sender As Object, e As MouseEventArgs) Handles lst_productName.MouseClick
        refresh_text(lst_productName.Text)
    End Sub

    Private Sub pic_product_Click(sender As Object, e As EventArgs) Handles pic_product.Click

    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        frm_insertproduct_a172330.Show()
        frm_insertproduct_a172330.RefreshForm()
        Me.Hide()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        frm_updateproduct_a172330.Show()
        frm_updateproduct_a172330.RefreshForm()
        Me.Hide()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_A172330.Show()
        Me.Hide()

    End Sub

    Public Sub RefreshForm()

        Dim mysql As String = "SELECT * FROM tbl_products_a172330"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        lst_productName.DataSource = mydatatable
        lst_productName.DisplayMember = "fld_product_name"
        grd_productdetail.DataSource = mydatatable

        refresh_text(lst_productName.Text)
    End Sub

    Private Sub lbl_product_Click(sender As Object, e As EventArgs) Handles lbl_product.Click

    End Sub

    Private Sub lst_productName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_productName.SelectedIndexChanged

    End Sub

    Private Sub txt_productID_TextChanged(sender As Object, e As EventArgs) Handles txt_productID.TextChanged

    End Sub
End Class