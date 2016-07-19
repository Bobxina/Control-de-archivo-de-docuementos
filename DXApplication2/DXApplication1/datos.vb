Public Class datos
    Dim usuario As String
    Dim contrasena As Decimal
    Public Property gusuario()
        Get Return usuario
            End Get
        Set(ByVal value) usuario = value
        End Set
    End Property
    Public Property gcontrasena()
        Get Return contrasena
        End Get
        Set(ByVal value) contrasena = value
        End Set
    End Property

    Public Sub New(ByVal usuario As String, ByVal contrasena As Decimal)
        Me.gusuario = usuario
        Me.gcontrasena = contrasena
    End Sub
End Class
