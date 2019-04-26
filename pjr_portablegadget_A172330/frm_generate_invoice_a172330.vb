Public Class frm_generate_invoice_a172330
    Private Sub frm_generate_invoice_a172330_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Dim mysql As String = "SELECT fld_item_id, fld_orderID, fld_product_ID, fld_item_name, fld_item_type, fld_item_quantity, fld_item_price FROM tbl_item_a172330"
        'Dim mydatatable As New DataTable
        'Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        'myreader.Fill(mydatatable)
        'grd_details.DataSource = mydatatable
        grd_details.DataSource = run_sql_query("SELECT fld_item_id, fld_orderID, fld_product_ID, fld_item_name, fld_item_type, fld_item_quantity, fld_item_price FROM tbl_item_A172330 WHERE fld_orderID = '" & orderID & "'")
        'grd_details.DisplayMember = "fld_product_name"

        grd_details.Columns(0).HeaderText = "Item ID"
        grd_details.Columns(1).HeaderText = "Order ID"
        grd_details.Columns(2).HeaderText = "Pproduct ID"
        grd_details.Columns(3).HeaderText = "Name"
        grd_details.Columns(4).HeaderText = "Type"
        grd_details.Columns(5).HeaderText = "Quantity"
        grd_details.Columns(6).HeaderText = "Price per unit"



        lbl_invoice.Text = orderID
        lbl_total.Text = total
        txt_deliveryaddress.Text = gAddress
        lbl_date.Text = gDate


        refresh_text()

        'refresh_grid()

    End Sub

    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM tbl_item_A172330 WHERE fld_orderID = '" & orderID & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_details.DataSource = mydatatable

        txt_deliveryaddress.Text = mydatatable.Rows(0).Item("fld_delivery_address")

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub refresh_text()
        'Try
        '    Dim DelAddress As String = run_sql_query("SELECT fld_delivery_address  AS DelAddress FROM tbl_item_a172330 WHERE fld_order_id ='" & orderID & "'").Rows(0).Item("Address")

        '    txt_deliveryaddress.Text = DelAddress
        'Catch ex As Exception

        '    Beep()
        '    MsgBox(“There is a mistake in the data you entered, as shown below” & vbCrLf & vbCrLf & ex.Message)

        'End Try
    End Sub
End Class