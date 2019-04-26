Public Class frm_insertcustomer_a172330

    Private Sub frm_insertcustomer_a172330_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_grid()

        txt_id.Text = generate_product()

        grd_customer.Columns(0).HeaderText = "Customer ID"
        grd_customer.Columns(1).HeaderText = "Customer Name"
        grd_customer.Columns(2).HeaderText = "Customer Address"

    End Sub

    Private Function generate_product() As String

        Dim lastid As String = run_sql_query("SELECT MAX(fld_custid) AS lastid FROM tbl_customer_a172330").Rows(0).Item("lastid")

        'MsgBox(lastmatric)

        Dim newid As String = "C" & Mid(lastid, 2) + 1

        Return newid

    End Function

    Private Sub refresh_grid()

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

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click

        Dim mysql As String = "INSERT INTO tbl_customer_a172330 VALUES('" & txt_id.Text & "', '" & txt_name.Text & "', '" & txt_address.Text & "')"

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

        frm_customer_a172330.Show()
        Me.Hide()
        frm_customer_a172330.RefreshForm()

    End Sub

    Public Sub RefreshForm()

        refresh_grid()

        txt_id.Text = generate_product()

    End Sub

End Class