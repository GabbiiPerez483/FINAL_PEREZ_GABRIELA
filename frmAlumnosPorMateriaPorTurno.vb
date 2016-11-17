Public Class frmAlumnosPorMateriaPorTurno

    'Private Sub frmAlumnosPorMateriaPorTurno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    'TODO: esta línea de código carga datos en la tabla 'Insc_ExamenDataSet.Examenes' Puede moverla o quitarla según sea necesario.
    '    Me.ExamenesTableAdapter.Fill(Me.Insc_ExamenDataSet.Examenes)
    'End Sub


    Private Sub frmAlumnosPorMateriaPorTurno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            If cmbMateria.SelectedIndex = -1 Then
                MessageBox.Show("Debe seleccionar una Materia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                Comando.CommandText = "select e.cod_turno,e.Legajo_Alumno,e.fecha_ins, m.Desc_Materia, año from Examenes e Join Materias m on (e.cod_materia=m.cod_materia) where cod_turno = '" & cmbTurno.SelectedValue & "'  and e.cod_materia= '" & cmbMateria.SelectedValue & "'"
            End If
        End If

        Tabla = New DataTable()
        Tabla.Load(Comando.ExecuteReader)

        dgwAlumnos.DataSource = Tabla

    End Sub

    Private Sub btn_filtrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_filtrar.Click
        Cargar()
    End Sub
End Class