Public Class FRMMATERIAS
    Private Sub FRMMATERIAS_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub FRMMATERIAS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Conexion As SqlClient.SqlConnection
        Dim Comando As SqlClient.SqlCommand
        Dim Tabla As DataTable

        Conexion = New SqlClient.SqlConnection()
        Conexion.ConnectionString = CADCONEX
        Conexion.Open()

        Comando = New SqlClient.SqlCommand()
        Comando.Connection = Conexion
        Comando.CommandType = CommandType.Text
        Comando.CommandText = "Select * from Carreras"

        Tabla = New DataTable()
        Tabla.Load(Comando.ExecuteReader)

        cmbCarrera.DataSource = Tabla
        cmbCarrera.DisplayMember = "Desc_Carrera"
        cmbCarrera.ValueMember = "Cod_Carrera"
        cmbCarrera.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCarrera.SelectedIndex = -1

        If Operacion = "Modificar" Then
            Comando = New SqlClient.SqlCommand()
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.Text
            Comando.CommandText = "Select * from Materias where Cod_Materia= '" & IDPERSELECT & "'"

            Tabla = New DataTable()
            Tabla.Load(Comando.ExecuteReader)

            txtMateria.Text = Tabla.Rows(0)("Cod_Materia")
            txtDescMateria.Text = Tabla.Rows(0)("Desc_Materia")
            cmbCarrera.SelectedValue = Tabla.Rows(0)("Cod_Carrera")
            txtLegajoProf.Text = Tabla.Rows(0)("Legajo_Prof")  

        End If
    End Sub

    Private Sub btn_registrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_registrar.Click
        Dim Conexion As SqlClient.SqlConnection
        Dim Comando As SqlClient.SqlCommand
        Dim Cadena As String
        Dim Tabla As DataTable

        If Validar() = True Then
            If Operacion = "Alta" Then
                Conexion = New SqlClient.SqlConnection()
                Conexion.ConnectionString = CADCONEX
                Conexion.Open()

                Comando = New SqlClient.SqlCommand()
                Comando.Connection = Conexion
                Comando.CommandType = CommandType.Text
                Comando.CommandText = "select * from Materias where Cod_Materia='" & IDPERSELECT & "'"

                Tabla = New DataTable()
                Tabla.Load(Comando.ExecuteReader)

                If Tabla.Rows.Count = 0 Then
                    Comando = New SqlClient.SqlCommand()
                    Comando.Connection = Conexion
                    Comando.CommandType = CommandType.Text

                    Cadena = "INSERT into Materias (Cod_Materia,Desc_Materia,Cod_Carrera,Legajo_Prof) values("
                    Cadena = Cadena & "'" & txtMateria.Text & "','" & txtDescMateria.Text & "','"
                    Cadena = Cadena & cmbCarrera.SelectedValue & "','" & txtLegajoProf.Text & "')"

                    Comando.CommandText = Cadena
                    Comando.ExecuteNonQuery()

                    MessageBox.Show("Registro completo!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    MessageBox.Show("Esa Materia ya se encuentra registrada!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else

                Conexion = New SqlClient.SqlConnection()
                Conexion.ConnectionString = CADCONEX
                Conexion.Open()

                Comando = New SqlClient.SqlCommand()
                Comando.Connection = Conexion
                Comando.CommandType = CommandType.Text
                Comando.CommandText = "select * from Materias where Cod_Materia='" & IDPERSELECT & "'"

                Tabla = New DataTable()
                Tabla.Load(Comando.ExecuteReader)

                If Tabla.Rows.Count = 0 Then
                    Comando = New SqlClient.SqlCommand()
                    Comando.Connection = Conexion
                    Comando.CommandType = CommandType.Text

                    Cadena = "Update Materias SET "
                    Cadena = Cadena & "Desc_Materia= '" & txtDescMateria.Text & "',"
                    Cadena = Cadena & "Cod_Carrera= '" & cmbCarrera.SelectedValue & "',"
                    Cadena = Cadena & "Legajo_Prof= '" & txtLegajoProf.Text & "',"
                    Cadena = Cadena & "where Cod_Materia= '" & IDPERSELECT & "'"

                    Comando.CommandText = Cadena
                    Comando.ExecuteNonQuery()

                    MessageBox.Show("Registro completo!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    MessageBox.Show("Esa Materia ya se encuentra registrada!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Function Validar() As Boolean
        Dim Ok As Boolean = False

        If txtMateria.Text.Trim <> "" Then
            If txtDescMateria.Text.Trim <> "" Then
                If cmbCarrera.SelectedIndex > -1 Then
                    If txtLegajoProf.Text.Trim <> "" Then
                        Ok = True
                    Else
                        MessageBox.Show("Ingrese un Legajo!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Seleccione una Carrera!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Ingrese una descripcion de la Materia!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Ingrese una Materia!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Return Ok
    End Function

End Class