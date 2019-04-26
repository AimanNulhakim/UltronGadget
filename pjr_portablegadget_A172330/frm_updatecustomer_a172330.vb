Public Class frm_updatecustomer_a172330

    Dim current_code As String

    Private Sub frm_updatecustomer_a172330_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_grid()

        get_current_code()

        grd_customer.Columns(0).HeaderText = "Customer ID"
        grd_customer.Columns(1).HeaderText = "Customer Name"
        grd_customer.Columns(2).HeaderText = "Customer Address"

    End Sub


    Public Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM tbl_customer_a172330"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_customer.DataSource = mydatatable

    End Sub


    Private Sub clear_fields()

        txt_id.Text = ""
        txt_name.Text = ""
        txt_address.Text = ""

    End Sub


    Private Sub get_current_code()

        Dim current_row As Integer = grd_customer.CurrentRow.Index

        current_code = grd_customer(0, current_row).Value

        txt_id.Text = current_code
        txt_name.Text = grd_customer(1, current_row).Value
        txt_address.Text = grd_customer(2, current_row).Value


    End Sub

    Private Sub grd_customer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_customer.CellClick

        get_current_code()

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        run_sql_query("UPDATE tbl_customer_a172330 SET fld_custname ='" & txt_name.Text & "' WHERE fld_custid = '" & current_code & "'")
        run_sql_query("UPDATE tbl_customer_a172330 SET fld_cust_address ='" & txt_address.Text & "' WHERE fld_custid = '" & current_code & "'")

        Beep()
        MsgBox("You have successfully updated customer""'" & current_code & """.")

        refresh_grid()
        clear_fields()
        get_current_code()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        frm_customer_a172330.Show()
        Me.Hide()
        frm_customer_a172330.RefreshForm()

    End Sub

    Public Sub RefreshForm()
        refresh_grid()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        Dim delete_confirmation = MsgBox("Are you sure you would like to delete customer """ & current_code & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then

            run_sql_command("DELETE FROM tbl_customer_a172330 WHERE fld_custid= '" & current_code & "'")

            Beep()
            MsgBox("The Staff """ & current_code & """ data has been sucessfully deleted.")

            refresh_grid()
            clear_fields()
            get_current_code()


        End If

    End Sub

End Class