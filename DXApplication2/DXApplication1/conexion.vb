Imports System.Data.SqlClient
Public Class conexion
    Protected cone As New SqlConnection
    Protected Function conecta()
        Try
            cone = New SqlConnection("ESCRITORIO\SQLEXPRESS;Initial Catalog=codedoc;Integrated Security=True;")
            cone.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Protected Function desconecta()
        Try
            If cone.State = ConnectionState.Open Then
                cone.Close()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

End Class
