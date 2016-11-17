Public Class frmAlumnos
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
        If txt_filtro.Text.Trim = "" Then
            Comando.CommandText = "select * from Alumnos order by Ape_Nombre asc"
        Else
            Comando.CommandText = "select * from Alumnos where Ape_Nombre like '" & txt_filtro.Text & "%'"
        End If

        Tabla = New DataTable()
        Tabla.Load(Comando.ExecuteReader)

        dgvAlumnos.DataSource = Tabla

    End Sub

    'Private Sub frmAlumnos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    'TODO: esta línea de código carga datos en la tabla 'Insc_ExamenDataSet.Alumnos' Puede moverla o quitarla según sea necesario.
    '    Me.AlumnosTableAdapter.Fill(Me.Insc_ExamenDataSet.Alumnos)

    'End Sub

    Private Sub btn_filtrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_filtrar.Click
        Cargar()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        Operacion = "Alta"
        FRMPERSONAS.ShowDialog()
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarToolStripMenuItem.Click
        If dgvAlumnos.CurrentRow Is Nothing Then
            MessageBox.Show("Debe seleccionar un Alumno!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            IDPERSELECT = dgvAlumnos.CurrentRow.Cells(0).Value
            Operacion = "Modificar"
            FRMPERSONAS.ShowDialog()
        End If
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        Dim Conexion As SqlClient.SqlConnection
        Dim Comando As SqlClient.SqlCommand
        Dim Cadena As String

        Conexion = New SqlClient.SqlConnection()
        Conexion.ConnectionString = CADCONEX
        Conexion.Open()

        Comando = New SqlClient.SqlCommand()
        Comando.Connection = Conexion
        Comando.CommandType = CommandType.Text
        If dgvAlumnos.CurrentRow Is Nothing Then
            MessageBox.Show("Debe seleccionar un Alumno!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            IDPERSELECT = dgvAlumnos.CurrentRow.Cells(0).Value
            Cadena = "Delete Alumnos where Legajo_Alumno= '" & IDPERSELECT & "'"

            Comando.CommandText = Cadena
            Comando.ExecuteNonQuery()
        End If
        Cargar()
    End Sub

End Class