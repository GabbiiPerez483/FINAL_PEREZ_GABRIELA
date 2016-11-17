Public Class frmListaMaterias

    'Private Sub frmListaMaterias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    'TODO: esta línea de código carga datos en la tabla 'Insc_ExamenDataSet.Materias' Puede moverla o quitarla según sea necesario.
    '    Me.MateriasTableAdapter.Fill(Me.Insc_ExamenDataSet.Materias)

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
            Comando.CommandText = "select * from Materias order by Cod_Materia asc"
        Else
            Comando.CommandText = "select * from Materias where Desc_Materia like '" & txt_filtro.Text & "%'"
        End If

        Tabla = New DataTable()
        Tabla.Load(Comando.ExecuteReader)

        dgwMaterias.DataSource = Tabla

    End Sub

    Private Sub btn_filtrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_filtrar.Click
        Cargar()
    End Sub


    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        Operacion = "Alta"
        FRMMATERIAS.ShowDialog()
    End Sub
    Private Sub ModificarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarToolStripMenuItem.Click
        If dgwMaterias.CurrentRow Is Nothing Then
            MessageBox.Show("Debe seleccionar una Materia!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            IDPERSELECT = dgwMaterias.CurrentRow.Cells(0).Value
            Operacion = "Modificar"
            FRMMATERIAS.ShowDialog()
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
        If dgwMaterias.CurrentRow Is Nothing Then
            MessageBox.Show("Debe seleccionar una Materia!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            IDPERSELECT = dgwMaterias.CurrentRow.Cells(0).Value
            Cadena = "Delete Materias where Cod_Materia= '" & IDPERSELECT & "'"

            Comando.CommandText = Cadena
            Comando.ExecuteNonQuery()
        End If
        Cargar()
    End Sub

End Class