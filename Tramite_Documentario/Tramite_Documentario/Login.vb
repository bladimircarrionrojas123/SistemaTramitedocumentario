Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_TRAMITE.TLOGIN' Puede moverla o quitarla según sea necesario.
        Me.TLOGINTableAdapter.Fill(Me.BD_TRAMITE.TLOGIN)
    End Sub
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Dim Temp
        Temp = Me.TLOGINTableAdapter.Login(Me.BD_TRAMITE.TLOGIN, txtUsuario.Text, txtContraseña.Text)
        If Temp <> "0" Then
            MsgBox("Bienvenido al sistema")
            MDIPrincipal.Show()
        Else
            MsgBox("Usuario Incorrecto")
        End If
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        RecuperarContraseña.Show()
    End Sub
End Class
