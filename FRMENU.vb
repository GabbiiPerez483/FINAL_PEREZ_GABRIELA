Public Class FRMENU
    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AlumnosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlumnosToolStripMenuItem.Click
        frmAlumnos.ShowDialog()
    End Sub

    Private Sub ProfesoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfesoresToolStripMenuItem.Click
        frmListaProfesores.ShowDialog()
    End Sub

    Private Sub MateriasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MateriasToolStripMenuItem.Click
        frmListaMaterias.ShowDialog()
    End Sub

    Private Sub ExámenesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExámenesToolStripMenuItem.Click
        frmListaExamenes.ShowDialog()
    End Sub

    Private Sub AlumnosPorTurnoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlumnosPorTurnoToolStripMenuItem.Click
        frmAlumnosPorTurno.ShowDialog()
    End Sub

    Private Sub AlumnosPorMateriaPorTurnoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlumnosPorMateriaPorTurnoToolStripMenuItem.Click
        frmAlumnosPorMateriaPorTurno.ShowDialog()
    End Sub

    Private Sub DatosDelTurnoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatosDelTurnoToolStripMenuItem.Click
        frmDatosTurnos.showdialog()
    End Sub
End Class
