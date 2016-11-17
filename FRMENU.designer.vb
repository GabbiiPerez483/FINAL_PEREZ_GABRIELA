<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMENU
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMENU))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.AltaLocalidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AlumnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProfesoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MateriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExámenesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TurnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AlumnosPorTurnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AlumnosPorMateriaPorTurnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DatosDelTurnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaLocalidadToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AltaLocalidadToolStripMenuItem
        '
        Me.AltaLocalidadToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlumnosToolStripMenuItem, Me.ProfesoresToolStripMenuItem, Me.MateriasToolStripMenuItem, Me.ExámenesToolStripMenuItem, Me.TurnosToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.AltaLocalidadToolStripMenuItem.Name = "AltaLocalidadToolStripMenuItem"
        Me.AltaLocalidadToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.AltaLocalidadToolStripMenuItem.Text = "Archivo"
        '
        'AlumnosToolStripMenuItem
        '
        Me.AlumnosToolStripMenuItem.Name = "AlumnosToolStripMenuItem"
        Me.AlumnosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AlumnosToolStripMenuItem.Text = "Alumnos"
        '
        'ProfesoresToolStripMenuItem
        '
        Me.ProfesoresToolStripMenuItem.Name = "ProfesoresToolStripMenuItem"
        Me.ProfesoresToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ProfesoresToolStripMenuItem.Text = "Profesores"
        '
        'MateriasToolStripMenuItem
        '
        Me.MateriasToolStripMenuItem.Name = "MateriasToolStripMenuItem"
        Me.MateriasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MateriasToolStripMenuItem.Text = "Materias"
        '
        'ExámenesToolStripMenuItem
        '
        Me.ExámenesToolStripMenuItem.Name = "ExámenesToolStripMenuItem"
        Me.ExámenesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExámenesToolStripMenuItem.Text = "Exámenes"
        '
        'TurnosToolStripMenuItem
        '
        Me.TurnosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlumnosPorTurnoToolStripMenuItem, Me.AlumnosPorMateriaPorTurnoToolStripMenuItem, Me.DatosDelTurnoToolStripMenuItem})
        Me.TurnosToolStripMenuItem.Name = "TurnosToolStripMenuItem"
        Me.TurnosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TurnosToolStripMenuItem.Text = "Turnos"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'AlumnosPorTurnoToolStripMenuItem
        '
        Me.AlumnosPorTurnoToolStripMenuItem.Name = "AlumnosPorTurnoToolStripMenuItem"
        Me.AlumnosPorTurnoToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.AlumnosPorTurnoToolStripMenuItem.Text = "Alumnos Por Turno"
        '
        'AlumnosPorMateriaPorTurnoToolStripMenuItem
        '
        Me.AlumnosPorMateriaPorTurnoToolStripMenuItem.Name = "AlumnosPorMateriaPorTurnoToolStripMenuItem"
        Me.AlumnosPorMateriaPorTurnoToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.AlumnosPorMateriaPorTurnoToolStripMenuItem.Text = "Alumnos Por Materia Por Turno"
        '
        'DatosDelTurnoToolStripMenuItem
        '
        Me.DatosDelTurnoToolStripMenuItem.Name = "DatosDelTurnoToolStripMenuItem"
        Me.DatosDelTurnoToolStripMenuItem.Size = New System.Drawing.Size(242, 22)
        Me.DatosDelTurnoToolStripMenuItem.Text = "Datos del Turno"
        '
        'FRMENU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FRMENU"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Exámenes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AltaLocalidadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlumnosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProfesoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MateriasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExámenesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TurnosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlumnosPorTurnoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlumnosPorMateriaPorTurnoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatosDelTurnoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
