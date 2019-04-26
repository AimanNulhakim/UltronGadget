Public Class frm_updateproduct_a172330

    Dim current_code As String

    Private Sub frm_updateproduct_a172330_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_grid()

        get_current_code()

        grd_productdetail.Columns(0).HeaderText = "Product ID"
        grd_productdetail.Columns(1).HeaderText = "Product Name"
        grd_productdetail.Columns(2).HeaderText = "Price"
        grd_productdetail.Columns(3).HeaderText = "Brand"
        grd_productdetail.Columns(4).HeaderText = "Product Type"
        grd_productdetail.Columns(5).HeaderText = "Quantity"
        grd_productdetail.Columns(6).HeaderText = "Product Warranty"

    End Sub

    Public Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM tbl_products_a172330"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_productdetail.DataSource = mydatatable

    End Sub

    Private Sub clear_fields()

        txt_id.Text = ""
        txt_name.Text = ""
        txt_price.Text = ""
        txt_brand.Text = ""
        txt_type.Text = ""
        txt_quantity.Text = ""
        txt_warranty.Text = ""

    End Sub

    Private Sub get_current_code()

        Dim current_row As Integer = grd_productdetail.CurrentRow.Index

        current_code = grd_productdetail(0, current_row).Value

        txt_id.Text = current_code
        txt_name.Text = grd_productdetail(1, current_row).Value
        txt_price.Text = grd_productdetail(2, current_row).Value
        txt_brand.Text = grd_productdetail(3, current_row).Value
        txt_type.Text = grd_productdetail(4, current_row).Value
        txt_quantity.Text = grd_productdetail(5, current_row).Value
        txt_warranty.Text = grd_productdetail(6, current_row).Value

    End Sub

    Private Sub grd_productdetail_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_productdetail.CellClick

        get_current_code()

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        run_sql_query("UPDATE tbl_products_a172330 SET fld_product_name ='" & txt_name.Text & "' WHERE fld_product_id = '" & current_code & "'")
        run_sql_query("UPDATE tbl_products_a172330 SET fld_price =" & txt_price.Text & " WHERE fld_product_id = '" & current_code & "'")
        run_sql_query("UPDATE tbl_products_a172330 SET fld_brand ='" & txt_brand.Text & "' WHERE fld_product_id = '" & current_code & "'")
        run_sql_query("UPDATE tbl_products_a172330 SET fld_type ='" & txt_type.Text & "' WHERE fld_product_id = '" & current_code & "'")
        run_sql_query("UPDATE tbl_products_a172330 SET fld_quantity =" & txt_quantity.Text & " WHERE fld_product_id = '" & current_code & "'")
        run_sql_query("UPDATE tbl_products_a172330 SET fld_warrantylength ='" & txt_warranty.Text & "' WHERE fld_product_id = '" & current_code & "'")

        'run_sql_command("UPDATE tbl_products_a172330 SET fld_product_name='" & txt_name.Text & "', fld_price =" & txt_price.Text & " , fld_brand ='" & txt_brand.Text & "', fld_type = '" & txt_type.Text & "', fld_quantity ='" & txt_quantity.Text & "',fld_warranty ='" & txt_warranty.Text & "' WHERE fld_product_id = '" & current_code & "'")

        Beep()
        MsgBox("You have successfully updated the course""'" & current_code & """.")

        refresh_grid()
        clear_fields()
        get_current_code()

    End Sub




    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        frm_product_list_a172330.Show()
        Me.Hide()
        frm_product_list_a172330.RefreshForm()

    End Sub

    Public Sub RefreshForm()
        refresh_grid()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the product""" & current_code & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then


            run_sql_query("DELETE FROM tbl_products_a172330 WHERE fld_product_id ='" & current_code & "'")

            Beep()
            MsgBox("The product """ & current_code & """ has been successfully deleted.")

            refresh_grid()
            clear_fields()
            get_current_code()

        End If

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub txt_price_TextChanged(sender As Object, e As EventArgs) Handles txt_price.TextChanged

    End Sub

    Private Sub txt_brand_TextChanged(sender As Object, e As EventArgs) Handles txt_brand.TextChanged

    End Sub

    Private Sub txt_type_TextChanged(sender As Object, e As EventArgs) Handles txt_type.TextChanged

    End Sub

    Private Sub txt_quantity_TextChanged(sender As Object, e As EventArgs) Handles txt_quantity.TextChanged

    End Sub

    Private Sub txt_warranty_TextChanged(sender As Object, e As EventArgs) Handles txt_warranty.TextChanged

    End Sub
End Class