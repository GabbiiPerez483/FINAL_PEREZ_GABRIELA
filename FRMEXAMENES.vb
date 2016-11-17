Public Class FRMEXAMENES
    Private Sub FRMEXAMENES_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub FRMEXAMENES_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Conexion As SqlClient.SqlConnection
        Dim Comando As SqlClient.SqlCommand
        Dim Tabla As DataTable

        Conexion = New SqlClient.SqlConnection()
        Conexion.ConnectionString = CADCONEX
        Conexion.Open()

        Comando = New SqlClient.SqlCommand()
        Comando.Connection = Conexion
        Comando.CommandType = CommandType.Text
        Comando.CommandText = "Select * from Materias"

        Tabla = New DataTable()
        Tabla.Load(Comando.ExecuteReader)

        cmbMateria.DataSource = Tabla
        cmbMateria.DisplayMember = "Desc_Materia"
        cmbMateria.ValueMember = "Cod_Materia"
        cmbMateria.DropDownStyle = ComboBoxStyle.DropDownList
        cmbMateria.SelectedIndex = -1

        Comando = New SqlClient.SqlCommand()
        Comando.Connection = Conexion
        Comando.CommandType = CommandType.Text
        Comando.CommandText = "Select * from Turnos"

        Tabla = New DataTable()
        Tabla.Load(Comando.ExecuteReader)

        cmbTurno.DataSource = Tabla
        cmbTurno.DisplayMember = "Desc_Turno"
        cmbTurno.ValueMember = "Cod_Turno"
        cmbTurno.DropDownStyle = ComboBoxStyle.DropDownList
        cmbTurno.SelectedIndex = -1

        cmbAño.Items.Add("2008")
        cmbAño.Items.Add("2009")
        cmbAño.Items.Add("2010")
        cmbAño.Items.Add("2011")
        cmbAño.Items.Add("2012")
        cmbAño.Items.Add("2013")
        cmbAño.Items.Add("2014")
        cmbAño.Items.Add("2015")
        cmbAño.Items.Add("2016")
        cmbAño.DropDownStyle = ComboBoxStyle.DropDownList
        cmbAño.SelectedIndex = -1

        If Operacion = "Modificar" Then
            Comando = New SqlClient.SqlCommand()
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.Text
            Comando.CommandText = "Select * from Examenes where Fecha_Ins= '" & IDPERSELECT & "'"

            Tabla = New DataTable()
            Tabla.Load(Comando.ExecuteReader)

            cmbAño.SelectedValue = Tabla.Rows(0)("Año")
            cmbTurno.SelectedValue = Tabla.Rows(0)("Cod_Turno")
            cmbMateria.SelectedValue = Tabla.Rows(0)("Cod_Materia")
            txtLegajoAlumno.Text = Tabla.Rows(0)("Legajo_Alumno")
            dtpFechaInsc.Text = Tabla.Rows(0)("Fecha_Ins")
            txtNota.Text = Tabla.Rows(0)("Nota")
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
                Comando.CommandText = "select * from Examenes where Fecha_Ins='" & IDPERSELECT & "'"

                Tabla = New DataTable()
                Tabla.Load(Comando.ExecuteReader)

                If Tabla.Rows.Count = 0 Then
                    Comando = New SqlClient.SqlCommand()
                    Comando.Connection = Conexion
                    Comando.CommandType = CommandType.Text

                    Cadena = "INSERT into Examenes (Año,Cod_Turno,Cod_Materia,Legajo_Alumno,Fecha_Ins,Nota) values("
                    Cadena = Cadena & "'" & cmbAño.SelectedItem & "','" & cmbTurno.SelectedValue & "','"
                    Cadena = Cadena & cmbMateria.SelectedValue & "','" & txtLegajoAlumno.Text & "','"
                    Cadena = Cadena & dtpFechaInsc.Text & "','" & txtNota.Text & "')"

                    Comando.CommandText = Cadena
                    Comando.ExecuteNonQuery()

                    MessageBox.Show("Registro completo!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    MessageBox.Show("Ese Examen ya se encuentra registrado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else

                Conexion = New SqlClient.SqlConnection()
                Conexion.ConnectionString = CADCONEX
                Conexion.Open()

                Comando = New SqlClient.SqlCommand()
                Comando.Connection = Conexion
                Comando.CommandType = CommandType.Text
                Comando.CommandText = "select * from Examenes where Legajo_Alumno = '" & txtLegajoAlumno.Text & "' and Cod_Turno= '" & cmbTurno.SelectedValue & "' and Cod_Materia='" & cmbMateria.SelectedValue & "'"

                Tabla = New DataTable()
                Tabla.Load(Comando.ExecuteReader)

                If Tabla.Rows.Count = 1 Then
                    Comando = New SqlClient.SqlCommand()
                    Comando.Connection = Conexion
                    Comando.CommandType = CommandType.Text

                    Cadena = "Update Examenes SET "
                    Cadena = Cadena & "Año= '" & cmbAño.SelectedItem & "',"
                    Cadena = Cadena & "Cod_Turno= '" & cmbTurno.SelectedValue & "',"
                    Cadena = Cadena & "Cod_Materia= '" & cmbMateria.SelectedValue & "',"
                    Cadena = Cadena & "Legajo_Alumno= '" & txtLegajoAlumno.Text & "',"
                    Cadena = Cadena & "Nota= '" & txtNota.Text & "' "
                    Cadena = Cadena & " where Fecha_ins= '" & IDPERSELECT & "'"

                    Comando.CommandText = Cadena
                    Comando.ExecuteNonQuery()

                    MessageBox.Show("Registro completo!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    MessageBox.Show("Ese Examen ya se encuentra registrado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Function Validar() As Boolean
        Dim Ok As Boolean = False
        If Operacion = "Alta" Then
            If cmbAño.SelectedIndex > -1 Then
                If cmbTurno.SelectedIndex > -1 Then
                    If cmbMateria.SelectedIndex > -1 Then
                        If txtLegajoAlumno.Text.Trim <> "" Then
                            If dtpFechaInsc.Text > Date.Today Then
                                If txtNota.Text.Trim <> "" Then
                                    Ok = True
                                Else
                                    MessageBox.Show("Ingrese una Nota!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If
                            Else
                                MessageBox.Show("Seleccione una Fecha superior a HOY!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        Else
                            MessageBox.Show("Ingrese un Legajo!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        MessageBox.Show("Seleccione una Materia!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Seleccione un Truno!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Seleccione un Año!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            If cmbAño.SelectedIndex > -1 Then
                If cmbTurno.SelectedIndex > -1 Then
                    If cmbMateria.SelectedIndex > -1 Then
                        If txtLegajoAlumno.Text.Trim <> "" Then
                            If txtNota.Text.Trim <> "" Then
                                Ok = True
                            Else
                                MessageBox.Show("Ingrese una Nota!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        Else
                            MessageBox.Show("Ingrese un Legajo!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                Else
                    MessageBox.Show("Seleccione una Materia!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                Else
                    MessageBox.Show("Seleccione un Truno!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Seleccione un Año!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        Return Ok
    End Function

End Class