Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins


Public Class Form1
    Sub New()
        InitSkins()
        InitializeComponent()
        Me.InitGrid()

    End Sub
    Sub InitSkins()
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()
        UserLookAndFeel.Default.SetSkinStyle("DevExpress Style")

    End Sub
    Dim gridDataList As New BindingList(Of Person)
    Private Sub InitGrid()
        gridDataList.Add(New Person("John", "Smith"))
        gridDataList.Add(New Person("Gabriel", "Smith"))
        gridDataList.Add(New Person("Ashley", "Smith", "some comment"))
        gridDataList.Add(New Person("Adrian", "Smith", "some comment"))
        gridDataList.Add(New Person("Gabriella", "Smith", "some comment"))
        'Me.gridControl.DataSource = gridDataList
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Threading.Thread.Sleep(4000)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim da As New datos
        Dim funcion As New funciones
        da.gusuario = Me.TextBox1.Text
        da.gcontrasena = Me.TextBox2.Text
        Try
            If funcion.validar(da) = True Then
                Dim frm As New Form1
                frm.Show()
                Me.Hide()
            Else MessageBox.Show("DATOS INCORECTOS", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.TextBox1.Clear()
                Me.TextBox2.Clear()
                Me.TextBox1.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class
