Imports MySql.Data.MySqlClient

Module ConexionBaseDatos

    Public conn As New MySqlConnection("server=localhost; userid=root; password=''; database= urubyte")

    Public Sub conexion()
        Try
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Function consultar(ByVal sql As String) As DataSet

        Dim ds As New DataSet

        Try
            Dim reader As New MySqlDataAdapter(Sql, conn)
            reader.Fill(ds, "Historial")

            conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Return ds
    End Function

    Public Sub ingresarComando(ByRef comandoSQL As String)

        'Ingresa un comando MySql a la base de datos. Ejemplo: INSERT, DELETE, UPDATE, etc.
        Dim sql As String
        Dim DA As New MySqlDataAdapter
        Dim DT As New DataTable

        Try
            sql = comandoSQL

            DA = New MySqlDataAdapter(sql, conn)
            DT = New DataTable
            DA.Fill(DT)

            conn.Close()


        Catch ex As Exception

            MsgBox("Error: " + ex.Message)

        End Try

    End Sub

End Module
