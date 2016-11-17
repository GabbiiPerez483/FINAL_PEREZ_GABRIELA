Public Class FRMPERSONAS
    Private Sub FRMPERSONAS_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
    Private Sub FRMPERSONAS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Conexion As SqlClient.SqlConnection
        Dim Comando As SqlClient.SqlCommand
        Dim Tabla As DataTable

        Conexion = New SqlClient.SqlConnection()
        Conexion.ConnectionString = CADCONEX
        Conexion.Open()

        Comando = New SqlClient.SqlCommand()
        Comando.Connection = Conexion
        Comando.CommandType = CommandType.Text
        Comando.CommandText = "Select * from TipoDoc"

        Tabla = New DataTable()
        Tabla.Load(Comando.ExecuteReader)

        cmbTipoDoc.DataSource = Tabla
        cmbTipoDoc.DisplayMember = "Desc_Doc"
        cmbTipoDoc.ValueMember = "Cod_Doc"
        cmbTipoDoc.DropDownStyle = ComboBoxStyle.DropDownList
        cmbTipoDoc.SelectedIndex = -1

        rbF.Checked = True

        If Operacion = "Modificar" Then
            Comando = New SqlClient.SqlCommand()
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.Text
            Comando.CommandText = "Select * from Alumnos where Legajo_Alumno= '" & IDPERSELECT & "'"

            Tabla = New DataTable()
            Tabla.Load(Comando.ExecuteReader)

            txt_apellido.Text = Tabla.Rows(0)("Ape_Nombre")
            cmbTipoDoc.SelectedValue = Tabla.Rows(0)("Cod_Doc")
            txt_dni.Text = Tabla.Rows(0)("Nro_doc")
            txt_telefono.Text = Tabla.Rows(0)("Telefono")
            txtDireccion.Text = Tabla.Rows(0)("Direccion")
            txtEmail.Text = Tabla.Rows(0)("Email")
            If Tabla.Rows(0)("Sexo") = "F" Then
                rbF.Checked = True
            Else
                rbM.Checked = True
            End If
            dtp_fecha.Text = Tabla.Rows(0)("Fecha_Nac")
            txtEstCivil.Text = Tabla.Rows(0)("Est_Civil")
            If Tabla.Rows(0)("fec_ing") IsNot Nothing Then
                dtpFechaIng.Text = Tabla.Rows(0)("fec_ing").ToString
            Else
                dtpFechaIng.Value = Now()
            End If
        End If
    End Sub
    Private Function Validar() As Boolean
        Dim Ok As Boolean = False
        Dim DNI As Integer
        'Dim TEL As Integer

        If txt_apellido.Text.Trim <> "" Then
            If cmbTipoDoc.SelectedIndex > -1 Then
                If txt_dni.Text.Trim <> "" Then
                    If Integer.TryParse(txt_dni.Text, DNI) Then
                        If DNI > 0 Then
                            If txt_telefono.Text.Trim <> "" Then
                                If txtDireccion.Text.Trim <> "" Then
                                    If txtEmail.Text.Trim <> "" Then
                                        If dtp_fecha.Text < Date.Today Then
                                            If txtEstCivil.Text.Trim <> "" Then
                                                If dtpFechaIng.Text <= Date.Today Then
                                                    Ok = True
                                                Else
                                                    MessageBox.Show("Seleccione una fecha menor o igual a HOY!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                                End If
                                            Else
                                                MessageBox.Show("Ingrese un Estado Civil!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                            End If
                                        Else
                                            MessageBox.Show("Debe ser una fecha menor a hoy", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        End If
                                    Else
                                        MessageBox.Show("Debe ingresar un email", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    End If
                                Else
                                    MessageBox.Show("Debe ingresar una Dirección", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If
                            Else
                                MessageBox.Show("Debe ingresar un telefono", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        Else
                            MessageBox.Show("El DNI debe ser mayor a cero", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        MessageBox.Show(" El DNI debe ser numerico", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Ingrese un numero de dni!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Seleccione un Tipo de Documento!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Ingrese un apellido y nombre!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Return Ok
    End Function
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
                Comando.CommandText = "select * from Alumnos where Nro_Doc='" & txt_dni.Text & "'"

                Tabla = New DataTable()
                Tabla.Load(Comando.ExecuteReader)

                If Tabla.Rows.Count = 0 Then
                    Comando = New SqlClient.SqlCommand()
                    Comando.Connection = Conexion
                    Comando.CommandType = CommandType.Text

                    Cadena = "INSERT into Alumnos (Ape_Nombre,Cod_Doc,Direccion,Email,Est_Civil,Fecha_Nac,Nro_Doc,Sexo,fec_ing,Telefono) VALUES("
                    Cadena = Cadena & "'" & txt_apellido.Text & "'," & cmbTipoDoc.SelectedValue & ",'" & txtDireccion.Text & "','" & txtEmail.Text & "','" & txtEstCivil.Text & "','"
                    Cadena = Cadena & dtp_fecha.Value.ToShortDateString & "'," & txt_dni.Text & ","
                    If rbF.Checked = True Then
                        Cadena = Cadena & "'F',"
                    Else
                        Cadena = Cadena & "'M',"
                    End If
                    Cadena = Cadena & Date.Today() & ","
                    Cadena = Cadena & txt_telefono.Text & ","

                    Comando.CommandText = Cadena
                    Comando.ExecuteNonQuery()

                    MessageBox.Show("Registro completo!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    MessageBox.Show("Ese dni ya se encuentra registrado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                Conexion = New SqlClient.SqlConnection()
                Conexion.ConnectionString = CADCONEX
                Conexion.Open()

                Comando = New SqlClient.SqlCommand()
                Comando.Connection = Conexion
                Comando.CommandType = CommandType.Text
                Comando.CommandText = "select * from Alumnos where Nro_Doc='" & txt_dni.Text & "' and Legajo_Alumno <> " & IDPERSELECT

                Tabla = New DataTable()
                Tabla.Load(Comando.ExecuteReader)

                If Tabla.Rows.Count = 0 Then
                    Comando = New SqlClient.SqlCommand()
                    Comando.Connection = Conexion
                    Comando.CommandType = CommandType.Text

                    Cadena = "Update Alumnos SET "
                    Cadena = Cadena & "Ape_Nombre= '" & txt_apellido.Text & "',"
                    Cadena = Cadena & "Cod_Doc= '" & cmbTipoDoc.SelectedValue & "',"
                    Cadena = Cadena & "Direccion= '" & txtDireccion.Text & "',"
                    Cadena = Cadena & "Email= '" & txtEmail.Text & "',"
                    Cadena = Cadena & "Est_Civil= '" & txtEstCivil.Text & "',"
                    Cadena = Cadena & "Nro_Doc= " & txt_dni.Text & ","
                    Cadena = Cadena & "Fecha_Nac= '" & dtp_fecha.Value.ToShortDateString & "',"

                    If rbF.Checked = True Then
                        Cadena = Cadena & "Sexo= " & "'F',"
                    Else
                        Cadena = Cadena & "Sexo= " & "'M',"
                    End If
                    Cadena = Cadena & "fec_ing= '" & dtpFechaIng.Value.ToShortDateString & "',"
                    Cadena = Cadena & "Telefono= " & txt_telefono.Text

                    Cadena = Cadena & " where Legajo_Alumno= '" & IDPERSELECT & "'"
                    Comando.CommandText = Cadena
                    Comando.ExecuteNonQuery()

                    MessageBox.Show("Registro completo!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    MessageBox.Show("Ese dni ya se encuentra registrado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub
End Class