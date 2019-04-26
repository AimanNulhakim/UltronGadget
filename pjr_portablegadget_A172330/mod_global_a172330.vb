Module mod_global_a172330
    Public username As String
    Public myconnection As String = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=db_portablegadgets_a172330.accdb;Persist Security Info=False;"
    Public gDate As String
    Public Check As Boolean
    Public orderID As String
    Public subtotal As Double
    Public total As Double
    Public gAddress As String
    Public myconnection2 As New OleDb.OleDbConnection(myconnection)

    Public Function run_sql_query(mysql As String) As DataTable

        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        Try

            myreader.Fill(mydatatable)
        Catch ex As Exception

            Beep()
            MsgBox("There is an error:" & vbCrLf & vbCrLf & ex.Message)

        End Try

        Return mydatatable

    End Function

    Public Sub run_sql_command(thissql As String)

        Dim mywriter As New OleDb.OleDbCommand(thissql, myconnection2)

        Try

            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

        Catch ex As Exception

            Beep()
            MsgBox("There is a mistake : " & vbCrLf & vbCrLf & ex.Message)
            mywriter.Connection.Close()

        End Try


    End Sub

End Module
