Public Class frm_makeorder_A172330

    Dim current_code As String
    Private Sub frm_makeorder_A172330_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Enabled = True


        Try
            Check = False
            txt_orderID.Text = generate_order_id()
            orderID = txt_orderID.Text
            txt_itemID.Text = generate_item_id()
            'MsgBox(txt_orderID.Text)
            grd_item.DataSource = run_sql_query("SELECT * FROM tbl_item_A172330 WHERE fld_orderID = '" & txt_orderID.Text & "'")

            Dim mysql As String = "SELECT * FROM tbl_staff_a172330"
            Dim mydatatable As New DataTable
            Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
            myreader.Fill(mydatatable)
            cmb_staff.DataSource = mydatatable
            cmb_staff.DisplayMember = "fld_staffID"

            Dim mysql2 As String = "SELECT * FROM tbl_customer_a172330"
            Dim mydatatable2 As New DataTable
            Dim myreader2 As New OleDb.OleDbDataAdapter(mysql2, myconnection)
            myreader2.Fill(mydatatable2)
            cmb_customer.DataSource = mydatatable2
            cmb_customer.DisplayMember = "fld_custid"

            Dim mysql3 As String = "SELECT * FROM tbl_products_a172330"
            Dim mydatatable3 As New DataTable
            Dim myreader3 As New OleDb.OleDbDataAdapter(mysql3, myconnection)
            myreader3.Fill(mydatatable3)
            lst_productname.DataSource = mydatatable3
            lst_productname.DisplayMember = "fld_product_name"


            'grd_item.DataSource = mydatatable

            refresh_text(lst_productname.Text)
            refresh_grid()

        Catch ex As Exception

            Beep()
            MsgBox(“There is a mistake in the data you entered, as shown below” & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub

    Private Sub refresh_text(product As String)

        Dim mysql As String = "SELECT * FROM tbl_products_a172330 WHERE fld_product_name='" & product & "'"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        txt_productname.Text = mydatatable.Rows(0).Item("fld_product_name")
        txt_productID.Text = mydatatable.Rows(0).Item("fld_product_ID")
        txt_price.Text = mydatatable.Rows(0).Item("fld_price")
        txt_brand.Text = mydatatable.Rows(0).Item("fld_brand")
        txt_producttype.Text = mydatatable.Rows(0).Item("fld_type")


        Try
            pic_product.BackgroundImage = Image.FromFile("pictures/" & txt_productID.Text & ".jpg")

        Catch ex As Exception
            pic_product.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")
        End Try
        refresh_grid()



    End Sub

    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM tbl_item_A172330 WHERE fld_orderID = '" & txt_orderID.Text & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_item.DataSource = mydatatable

        grd_item.Columns(0).HeaderText = "Item ID"
        grd_item.Columns(1).HeaderText = "Order ID"
        grd_item.Columns(2).HeaderText = "Product ID"
        grd_item.Columns(3).HeaderText = "Name"
        grd_item.Columns(4).HeaderText = "Type"
        grd_item.Columns(5).HeaderText = "Quantity"
        grd_item.Columns(6).HeaderText = "Price per unit"
        grd_item.Columns(7).HeaderText = "Delivery Address"

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub btn_makeorder_Click(sender As Object, e As EventArgs) Handles btn_makeorder.Click

        'Dim mysql As String = "INSERT INTO tbl_item_a172330 VALUES('" & txt_productID.Text & "', '" & txt_orderID.Text & "', '" & txt_productID.Text & "', '" & txt_producttype.Text & "', '" & txt_quantity.Text & "', '" & txt_price.Text & "')"
        'Dim mysql2 As String = "INSERT INTO tbl_order_a172330 VALUES('" & txt_productID.Text & "', '" & txt_orderID.Text & "', '" & txt_productID.Text & "', '" & txt_producttype.Text & "', '" & txt_quantity.Text & "', '" & txt_price.Text & "')"

        'Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        'Dim startDate As String


        If Check = False Then

            Try

                Dim mysql As String = "INSERT INTO tbl_order_a172330 VALUES('" & txt_orderID.Text & "', '" & lbl_date.Text & "', '" & txt_productID.Text & "', '" & cmb_customer.Text & "', '" & cmb_staff.Text & "')"
                Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)
                Check = True

                mywriter.Connection.Open()
                mywriter.ExecuteNonQuery()
                mywriter.Connection.Close()

            Catch ex As Exception

                Beep()
                MsgBox(“There is a mistake in the data you entered, as shown below” & vbCrLf & vbCrLf & ex.Message)

            End Try
        End If

        Dim mysql2 As String = "INSERT INTO tbl_item_a172330 VALUES('" & txt_itemID.Text & "', '" & txt_orderID.Text & "', '" & txt_productID.Text & "', '" & txt_productname.Text & "', '" & txt_producttype.Text & "', '" & txt_quantity.Text & "', '" & txt_price.Text & "', '" & txt_address.Text & "')"

        Dim mywriter2 As New OleDb.OleDbCommand(mysql2, myconnection2)

        Try

            mywriter2.Connection.Open()
            mywriter2.ExecuteNonQuery()
            mywriter2.Connection.Close()

            Dim SubTotalPrice As Double = run_sql_query("SELECT fld_item_price * fld_item_quantity AS SUBTOTAL  FROM tbl_item_a172330 WHERE fld_item_id ='" & txt_itemID.Text & "'").Rows(0).Item("SUBTOTAL")
            txt_subtotal.Text = SubTotalPrice

            gAddress = txt_address.Text

            Dim TotPrice As Double = run_sql_query("SELECT SUM(fld_item_price * fld_item_quantity) AS TOTAL  FROM tbl_item_a172330 where fld_orderID ='" & txt_orderID.Text & "'").Rows(0).Item("TOTAL")
            'txt_subtotal.Text = TotPrice
            'MsgBox(TotPrice)
            'TotalPrice = TotPrice
            txt_total.Text = TotPrice
            total = TotPrice

            grd_item.DataSource = run_sql_query("SELECT * FROM tbl_item_A172330 WHERE fld_orderID = '" & txt_orderID.Text & "'")
            txt_itemID.Text = generate_item_id()
        Catch ex As Exception

            Beep()
            MsgBox(“There is a mistake in the data you entered, as shown below” & vbCrLf & vbCrLf & ex.Message)
            mywriter2.Connection.Close()

        End Try

    End Sub

    Private Function generate_order_id() As String

        Dim lastid As String = run_sql_query("SELECT MAX(fld_orderID) AS lastid FROM tbl_order_a172330").Rows(0).Item("lastid")

        'MsgBox(lastmatric)

        Dim newid As String = "P0" & Mid(lastid, 2) + 1

        Return newid

    End Function

    Private Function generate_item_id() As String

        Dim lastid As String = run_sql_query("SELECT MAX(fld_item_id) AS lastid FROM tbl_item_a172330").Rows(0).Item("lastid")

        'MsgBox(lastmatric)

        Dim newid As String = "G0" & Mid(lastid, 3) + 1

        Return newid

    End Function
    Private Sub grd_item_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_item.CellClick

        get_current_code()
        Dim SubTotalPrice As Double = run_sql_query("SELECT fld_item_price * fld_item_quantity AS SUBTOTAL  FROM tbl_item_a172330 WHERE fld_item_id ='" & current_code & "'").Rows(0).Item("SUBTOTAL")
        txt_subtotal.Text = SubTotalPrice

    End Sub

    Private Sub get_current_code()

        Try
            Dim current_row As Integer = grd_item.CurrentRow.Index

            current_code = grd_item(0, current_row).Value

            txt_itemID.Text = current_code
            txt_orderID.Text = grd_item(1, current_row).Value
            txt_productID.Text = grd_item(2, current_row).Value
            txt_productname.Text = grd_item(3, current_row).Value
            txt_producttype.Text = grd_item(4, current_row).Value
            txt_quantity.Text = grd_item(5, current_row).Value
            txt_price.Text = grd_item(6, current_row).Value

            Try
                pic_product.BackgroundImage = Image.FromFile("pictures/" & txt_productID.Text & ".jpg")

            Catch ex As Exception
                pic_product.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")
            End Try

        Catch ex As Exception

            Beep()
            MsgBox(“There is a mistake in the data you entered, as shown below” & vbCrLf & vbCrLf & ex.Message)

        End Try

    End Sub
    Private Sub lst_productName_MouseClick(sender As Object, e As MouseEventArgs) Handles lst_productname.MouseClick
        refresh_text(lst_productname.Text)
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btn_invoice_Click(sender As Object, e As EventArgs) Handles btn_invoice.Click
        frm_generate_invoice_a172330.Show()
    End Sub



    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        frm_order_a172330.Show()
        Me.Hide()
        frm_order_a172330.RefreshForm()

    End Sub


    Public Sub RefreshForm()
        refresh_grid()
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click

        txt_quantity.Text = ""
        txt_address.Text = ""

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        lbl_date.Text = Date.Now.ToString("MM/dd/yyyy")
        gDate = lbl_date.Text

    End Sub
End Class