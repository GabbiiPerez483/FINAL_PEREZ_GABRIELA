Public Class frmListaExamenes

    'Private Sub frmListaExamenes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        If txt_filtro.Text.Trim = "" Then
            Comando.CommandText = "select * from Examenes order by Cod_Turno asc"
        Else
            Comando.CommandText = "select * from Examenes where Año like '" & txt_filtro.Text & "%'"
        End If

        Tabla = New DataTable()
        Tabla.Load(Comando.ExecuteReader)

        dgwExamenes.DataSource = Tabla

    End Sub

    Private Sub btn_filtrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_filtrar.Click
        Cargar()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        Operacion = "Alta"
        FRMEXAMENES.ShowDialog()
    End Sub
    Private Sub ModificarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarToolStripMenuItem.Click
        If dgwExamenes.CurrentRow Is Nothing Then
            MessageBox.Show("Debe seleccionar un Examen!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            IDPERSELECT = dgwExamenes.CurrentRow.Cells(4).Value
            Operacion = "Modificar"
            FRMEXAMENES.ShowDialog()
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
        If dgwExamenes.CurrentRow Is Nothing Then
            MessageBox.Show("Debe seleccionar un Examen!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            IDPERSELECT = dgwExamenes.CurrentRow.Cells(4).Value
            Cadena = "Delete Examenes where Fecha_Ins= '" & IDPERSELECT & "'"

            Comando.CommandText = Cadena
            Comando.ExecuteNonQuery()
        End If
        Cargar()
    End Sub
End Class