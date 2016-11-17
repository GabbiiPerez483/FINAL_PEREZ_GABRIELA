Public Class frmListaProfesores

    'Private Sub frmListaProfesores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    'TODO: esta línea de código carga datos en la tabla 'Insc_ExamenDataSet.Profesores' Puede moverla o quitarla según sea necesario.
    '    Me.ProfesoresTableAdapter.Fill(Me.Insc_ExamenDataSet.Profesores)

    'End Sub

    Private Sub btn_filtrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_filtrar.Click
        Cargar()
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
        If txt_filtro.Text.Trim = "" Then
            Comando.CommandText = "select * from Profesores order by Ape_Nombre asc"
        Else
            Comando.CommandText = "select * from Profesores where Ape_Nombre like '" & txt_filtro.Text & "%'"
        End If

        Tabla = New DataTable()
        Tabla.Load(Comando.ExecuteReader)

        dgwProfesores.DataSource = Tabla

    End Sub

    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        Operacion = "Alta"
        FRMPROFESORES.ShowDialog()
    End Sub
    Private Sub ModificarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarToolStripMenuItem.Click
        If dgwProfesores.CurrentRow Is Nothing Then
            MessageBox.Show("Debe seleccionar un Profesor!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            IDPERSELECT = dgwProfesores.CurrentRow.Cells(0).Value
            Operacion = "Modificar"
            FRMPROFESORES.ShowDialog()
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
        If dgwProfesores.CurrentRow Is Nothing Then
            MessageBox.Show("Debe seleccionar un Profesor!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            IDPERSELECT = dgwProfesores.CurrentRow.Cells(0).Value
            Cadena = "Delete Profesores where Legajo_Prof= '" & IDPERSELECT & "'"

            Comando.CommandText = Cadena
            Comando.ExecuteNonQuery()
        End If
        Cargar()
    End Sub
End Class