Public Class frm_insertstaff_a172330

    Private Sub frm_insertproduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_grid()

        txt_id.Text = generate_product()

        grd_staff.Columns(0).HeaderText = "Staff ID"
        grd_staff.Columns(1).HeaderText = "Staff Name"
        grd_staff.Columns(2).HeaderText = "Staff Age"

    End Sub

    Private Function generate_product() As String

        Dim lastid As String = run_sql_query("SELECT MAX(fld_staffID) AS lastid FROM tbl_staff_a172330").Rows(0).Item("lastid")

        'MsgBox(lastmatric)

        Dim newid As String = "10" & Mid(lastid, 2) + 1

        Return newid

    End Function

    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM tbl_staff_a172330"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_staff.DataSource = mydatatable

    End Sub

    Public Sub RefreshForm()

        refresh_grid()

    End Sub

    Private Sub clear_fields()

        txt_id.Text = ""
        txt_name.Text = ""
        txt_age.Text = ""

    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click

        Dim mysql As String = "INSERT INTO tbl_staff_a172330 VALUES('" & txt_id.Text & "', '" & txt_name.Text & "', '" & txt_age.Text & "')"

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            refresh_grid()
            clear_fields()

        Catch ex As Exception

            Beep()
            MsgBox(“There is a mistake in the data you entered, as shown below” & vbCrLf & vbCrLf & ex.Message)
            mywriter.Connection.Close()

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        frm_staff_a172330.Show()
        Me.Hide()
        frm_staff_a172330.RefreshForm()

    End Sub
End Class