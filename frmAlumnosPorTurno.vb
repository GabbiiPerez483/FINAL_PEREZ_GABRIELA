Public Class frmAlumnosPorTurno

    'Private Sub frmAlumnosPorTurno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    'TODO: esta línea de código carga datos en la tabla 'Insc_ExamenDataSet.Examenes' Puede moverla o quitarla según sea necesario.
    '    Me.ExamenesTableAdapter.Fill(Me.Insc_ExamenDataSet.Examenes)

    'End Sub

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
            Comando.CommandText = "select Cod_Turno, Legajo_Alumno, Fecha_Ins from Examenes where cod_turno = '" & cmbTurno.SelectedValue & "'"
        End If

        Tabla = New DataTable()
        Tabla.Load(Comando.ExecuteReader)

        dgwTurnos.DataSource = Tabla

    End Sub

    Private Sub frmAlumnosPorTurno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub btn_filtrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_filtrar.Click
        Cargar()
    End Sub
End Class