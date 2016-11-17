Public Class FRMLOGEO
    Private Function Validar() As Boolean
        Dim OK As Boolean = False
        If txt_usuario.Text.Trim <> "" Then
            If txt_pass.Text.Trim <> "" Then
                OK = True
            Else
                MessageBox.Show("Password Incorrecta!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Usuario Incorrecto!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Return OK
    End Function
    Private Sub btn_ingresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ingresar.Click
        Dim Conexion As SqlClient.SqlConnection
        Dim Comando As SqlClient.SqlCommand
        Dim Tabla As DataTable
        Dim clave As String
        Dim apellido As String
        Dim nombre As String
        Dim fecha_cambio As Date

        If Validar() = True Then
            Conexion = New SqlClient.SqlConnection
            Conexion.ConnectionString = CADCONEX
            Conexion.Open()
            Comando = New SqlClient.SqlCommand()
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.Text
            Comando.CommandText = "select * from Usuarios_final where Usuario ='" & txt_usuario.Text & "'"
            Tabla = New DataTable
            Tabla.Load(Comando.ExecuteReader)
            If Tabla.Rows.Count = 1 Then
                clave = Tabla.Rows(0)("clave")
                apellido = Tabla.Rows(0)("Apellido")
                nombre = Tabla.Rows(0)("Nombre")
                fecha_cambio = Tabla.Rows(0)("fecha_cambio")
          
                Comando.ExecuteNonQuery()
                FRMENU.Show()
                Me.Close()
            End If
        Else
            MessageBox.Show("Datos incorrectos", "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

End Class