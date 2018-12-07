Imports System.Net.Mail
Imports System.Net
Imports System.Data.SqlClient
Public Class RecuperarContraseña
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sc As SqlConnection = New SqlConnection(My.Settings.BD_TRAMITEConnectionString)
        Dim cmd As New SqlCommand("ValidarCorreoElectrónico", sc)

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@correo", txtCorreoElectronico.Text)
        Try
            sc.Open()
            Dim lector As SqlDataReader = cmd.ExecuteReader()
            If lector.Read() Then

                GenerarNuevaContrasena(txtCorreoElectronico.Text)

            Else
                MessageBox.Show("Correo no encontrado")

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub


    Public Sub GenerarNuevaContrasena(email As String)
        Dim nuevaContrasena As String
        nuevaContrasena = InputBox("Ingrese Nueva Contraseña", "Restableser Contraseña").ToUpper

        If nuevaContrasena.Length > 0 Then

            Dim sc As New SqlConnection(My.Settings.BD_TRAMITEConnectionString)

            Dim cmd As New SqlCommand("NuevaContraseña", sc)

            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@Correo", email)
            cmd.Parameters.AddWithValue("@Contraseña", nuevaContrasena)
            Try
                sc.Open()
                Dim filasAfectadas As String = cmd.ExecuteNonQuery()
                If filasAfectadas <> 0 Then
                    EnviarCorreoContrasena(nuevaContrasena, email)

                End If
            Catch

            End Try
        Else
            Me.Close()
        End If
    End Sub

    Private Sub EnviarCorreoContrasena(contrasenaNueva As String, correo As String)

        Dim contraseña As String = My.Settings.Contrasena
        Dim mensaje As String = String.Empty
        'Creando el correo electronico
        Dim destinatario As String = correo
        Dim remitente As String = "eliascar_888@hotmail.com"
        Dim asunto As String = "Nueva contraseña Apps Easy"
        Dim cuerpoDelMesaje As String = "Su nueva contraseña es:" & " " & contrasenaNueva
        Dim smtp As New SmtpClient
        smtp.Host = "smtp.live.com"
        smtp.Port = 587
        smtp.EnableSsl = True
        smtp.Credentials = New NetworkCredential("eliascar_888@hotmail.com", contraseña)
        Dim ms As New MailMessage(remitente, destinatario, asunto, cuerpoDelMesaje)

        Try
            Dim t As Task = Task.Run(Sub()
                                         smtp.Send(ms)
                                         ms.Dispose()

                                         MessageBox.Show("Correo enviado, sirvase revisar su bandeja de entrada")


                                     End Sub)

            MessageBox.Show("Esta tarea puede tardar unos segundos, por favor espere.")

        Catch ex As Exception
            MessageBox.Show("Error al enviar correo electronico: " & ex.Message)

        End Try
    End Sub

End Class