Public Class frm_updatestaff_a172330

    Dim current_code As String

    Private Sub frm_updatestaff_a172330_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_grid()

        get_current_code()

        grd_staff.Columns(0).HeaderText = "Staff ID"
        grd_staff.Columns(1).HeaderText = "Staff Name"
        grd_staff.Columns(2).HeaderText = "Staff Age"

    End Sub

    Public Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM tbl_staff_a172330"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_staff.DataSource = mydatatable

    End Sub

    Private Sub clear_fields()

        txt_id.Text = ""
        txt_name.Text = ""
        txt_age.Text = ""

    End Sub

    Private Sub get_current_code()

        Dim current_row As Integer = grd_staff.CurrentRow.Index

        current_code = grd_staff(0, current_row).Value

        txt_id.Text = current_code
        txt_name.Text = grd_staff(1, current_row).Value
        txt_age.Text = grd_staff(2, current_row).Value

    End Sub

    Private Sub grd_staff_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_staff.CellClick

        get_current_code()

    End Sub

    Public Sub RefreshForm()
        refresh_grid()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        run_sql_query("UPDATE tbl_staff_a172330 SET fld_staffname ='" & txt_name.Text & "' WHERE fld_staffID = " & current_code & "")
        run_sql_query("UPDATE tbl_staff_a172330 SET fld_staffage =" & txt_age.Text & " WHERE fld_staffID = " & current_code & "")

        Beep()
        MsgBox("You have successfully updated the course""'" & current_code & "'"".")

        refresh_grid()
        clear_fields()
        get_current_code()

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        Dim delete_confirmation = MsgBox("Are you sure you would like to delete staff""" & current_code & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then


            run_sql_query("DELETE FROM tbl_staff_a172330 WHERE fld_staffID =" & current_code & "")

            Beep()
            MsgBox("The staff """ & current_code & """ has been successfully deleted.")

            refresh_grid()
            clear_fields()
            get_current_code()

        End If

    End Sub


    Private Sub btn__Click(sender As Object, e As EventArgs) Handles btn_.Click

        frm_staff_a172330.Show()
        Me.Hide()
        frm_staff_a172330.RefreshForm()

    End Sub


End Class