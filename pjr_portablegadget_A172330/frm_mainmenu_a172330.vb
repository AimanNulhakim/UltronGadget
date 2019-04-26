Public Class frm_mainmenu_A172330
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MsgBox("Welcome to PortableGadget")
        ' Dim current_date As String = Date.Now
        'lbl_date.Text = current_date
    End Sub

    Private Sub btn_products_Click(sender As Object, e As EventArgs) Handles btn_products.Click
        frm_product_list_a172330.Show()
        Me.Hide()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End

    End Sub

    Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click
        frm_order_a172330.Show()
        Me.Hide()
    End Sub

    Private Sub btn_cust_Click(sender As Object, e As EventArgs) Handles btn_cust.Click
        frm_customer_a172330.Show()
        Me.Hide()
    End Sub

    Private Sub btn_staff_Click(sender As Object, e As EventArgs) Handles btn_staff.Click
        frm_staff_a172330.Show()
        Me.Hide()
    End Sub

    Private Sub lbl_date_Click(sender As Object, e As EventArgs) Handles lbl_date.Click

    End Sub
End Class
