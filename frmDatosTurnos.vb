Public Class frmDatosTurnos

    Private Sub frmDatosTurnos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Conexion As SqlClient.SqlConnection
        Dim Comando As SqlClient.SqlCommand
        Dim Tabla As DataTable

        Conexion = New SqlClient.SqlConnection()
        Conexion.ConnectionString = CADCONEX
        Conexion.Open()

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

    End Sub

    Private Sub Cargar()
        Dim Conexion As SqlClient.SqlConnection
        Dim Comando As SqlClient.SqlCommand
        Dim Tabla As DataTable

        Conexion = New SqlClient.SqlConnection()
        Conexion.ConnectionString = CADCONEX
        Conexion.Open()

        Comando = New SqlClient.SqlCommand()
        Comando.Connection = Conexion
        Comando.CommandType = CommandType.Text
        If cmbTurno.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un Turno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            Comando.CommandText = " select p.año as 'Año', p.cod_turno as 'Cod. Turno', m.desc_materia as 'Materia', p.fecha_examen as 'FechaExamen', m.legajo_prof as 'LegajoProfesor' from Planificacion p Join Materias m on (p.cod_materia=m.cod_materia) where p.cod_turno = '" & cmbTurno.SelectedValue & "'"
        End If

        Tabla = New DataTable()
        Tabla.Load(Comando.ExecuteReader)

        dgwAlumnos.DataSource = Tabla

    End Sub
   
    Private Sub btn_filtrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_filtrar.Click
        Cargar()
    End Sub
End Class