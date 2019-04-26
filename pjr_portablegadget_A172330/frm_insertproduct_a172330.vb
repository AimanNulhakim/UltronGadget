Public Class frm_insertproduct_a172330

    Dim defaultpicture As String = Application.StartupPath & "\pictures\nophoto.jpg"

    Private Sub frm_insertproduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_grid()

        txt_id.Text = generate_product()

        grd_productdetail.Columns(0).HeaderText = "Product ID"
        grd_productdetail.Columns(1).HeaderText = "Product Name"
        grd_productdetail.Columns(2).HeaderText = "Price"
        grd_productdetail.Columns(3).HeaderText = "Brand"
        grd_productdetail.Columns(4).HeaderText = "Product Type"
        grd_productdetail.Columns(5).HeaderText = "Quantity"
        grd_productdetail.Columns(6).HeaderText = "Product Warranty"


    End Sub

    Private Function generate_product() As String

        Dim lastid As String = run_sql_query("SELECT MAX(fld_product_id) AS lastid FROM tbl_products_a172330").Rows(0).Item("lastid")

        'MsgBox(lastmatric)

        Dim newid As String = "A0" & Mid(lastid, 2) + 1

        Return newid

    End Function

    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM tbl_products_a172330"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_productdetail.DataSource = mydatatable

    End Sub

    Private Sub clear_fields()

        txt_id.Text = ""
        txt_brand.Text = ""
        txt_name.Text = ""
        txt_price.Text = ""
        txt_quantity.Text = ""
        txt_type.Text = ""
        txt_warranty.Text = ""

    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click

        Dim mysql As String = "INSERT INTO tbl_products_a172330 VALUES('" & txt_id.Text & "', '" & txt_name.Text & "', '" & txt_price.Text & "', '" & txt_brand.Text & "', '" & txt_type.Text & "', '" & txt_quantity.Text & "', '" & txt_warranty.Text & "')"

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            My.Computer.FileSystem.CopyFile(txt_picture.Text, "pictures\" & txt_id.Text & ".jpg")

            pic_product.BackgroundImage = Image.FromFile(defaultpicture)

            refresh_grid()
            clear_fields()

        Catch ex As Exception

            Beep()
            MsgBox(“There is a mistake in the data you entered, as shown below” & vbCrLf & vbCrLf & ex.Message)
            mywriter.Connection.Close()

        End Try
    End Sub

    Private Sub btn_picture_Click(sender As Object, e As EventArgs) Handles btn_picture.Click

        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop

        OpenFileDialog1.InitialDirectory = mydesktop
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG Files (*.jpg)|*.jpg"
        OpenFileDialog1.ShowDialog()

        pic_product.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
        txt_picture.Text = OpenFileDialog1.FileName

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        frm_product_list_a172330.Show()
        Me.Hide()
        frm_product_list_a172330.RefreshForm()

    End Sub

    Public Sub RefreshForm()
        refresh_grid()

        txt_id.Text = generate_product()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub txt_id_TextChanged(sender As Object, e As EventArgs) Handles txt_id.TextChanged

    End Sub

    Private Sub grd_productdetail_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_productdetail.CellContentClick

    End Sub
End Class