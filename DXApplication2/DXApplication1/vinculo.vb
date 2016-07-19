Imports System.Data.SqlClient
Public Class vinculo
    Inherits conexion
    Dim cmd As New SqlCommand
    Public Function validar(da As datos) As Boolean
        Try
            Me.conecta()
            cmd = New SqlCommand(validar)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cone
            cmd.Parameters.AddWithValue("@usuario", da.gusuario)
            cmd.Parameters.AddWithValue("@contrasena", da.gcontrasena)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            If dr.HasRows = True Then
                Return True
            Else Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Me.desconecta()
        End Try
    End Function
End Class
