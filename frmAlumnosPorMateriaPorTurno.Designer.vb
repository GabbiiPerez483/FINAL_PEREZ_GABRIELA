<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlumnosPorMateriaPorTurno
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAlumnosPorMateriaPorTurno))
        Me.cmbTurno = New System.Windows.Forms.ComboBox
        Me.lbl_apellido = New System.Windows.Forms.Label
        Me.btn_filtrar = New System.Windows.Forms.Button
        Me.cmbMateria = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dgwAlumnos = New System.Windows.Forms.DataGridView
        Me.ExamenesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Insc_ExamenDataSet = New FINAL_PEREZ_GABRIELA.Insc_ExamenDataSet
        Me.ExamenesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExamenesTableAdapter = New FINAL_PEREZ_GABRIELA.Insc_ExamenDataSetTableAdapters.ExamenesTableAdapter
        Me.CodTurnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodMateriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LegajoAlumnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Fecha_Ins = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgwAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExamenesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Insc_ExamenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExamenesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbTurno
        '
        Me.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTurno.FormattingEnabled = True
        Me.cmbTurno.Location = New System.Drawing.Point(50, 12)
        Me.cmbTurno.Name = "cmbTurno"
        Me.cmbTurno.Size = New System.Drawing.Size(151, 21)
        Me.cmbTurno.TabIndex = 1
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(6, 15)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(38, 13)
        Me.lbl_apellido.TabIndex = 0
        Me.lbl_apellido.Text = "Turno:"
        '
        'btn_filtrar
        '
        Me.btn_filtrar.Location = New System.Drawing.Point(522, 10)
        Me.btn_filtrar.Name = "btn_filtrar"
        Me.btn_filtrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_filtrar.TabIndex = 4
        Me.btn_filtrar.Text = "Filtrar"
        Me.btn_filtrar.UseVisualStyleBackColor = True
        '
        'cmbMateria
        '
        Me.cmbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMateria.FormattingEnabled = True
        Me.cmbMateria.Location = New System.Drawing.Point(280, 12)
        Me.cmbMateria.Name = "cmbMateria"
        Me.cmbMateria.Size = New System.Drawing.Size(200, 21)
        Me.cmbMateria.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(236, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Materia:"
        '
        'dgwAlumnos
        '
        Me.dgwAlumnos.AutoGenerateColumns = False
        Me.dgwAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwAlumnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodTurnoDataGridViewTextBoxColumn, Me.CodMateriaDataGridViewTextBoxColumn, Me.LegajoAlumnoDataGridViewTextBoxColumn, Me.Fecha_Ins, Me.Column1})
        Me.dgwAlumnos.DataSource = Me.ExamenesBindingSource1
        Me.dgwAlumnos.Location = New System.Drawing.Point(12, 49)
        Me.dgwAlumnos.Name = "dgwAlumnos"
        Me.dgwAlumnos.Size = New System.Drawing.Size(585, 281)
        Me.dgwAlumnos.TabIndex = 5
        '
        'ExamenesBindingSource1
        '
        Me.ExamenesBindingSource1.DataMember = "Examenes"
        Me.ExamenesBindingSource1.DataSource = Me.Insc_ExamenDataSet
        '
        'Insc_ExamenDataSet
        '
        Me.Insc_ExamenDataSet.DataSetName = "Insc_ExamenDataSet"
        Me.Insc_ExamenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ExamenesBindingSource
        '
        Me.ExamenesBindingSource.DataMember = "Examenes"
        Me.ExamenesBindingSource.DataSource = Me.Insc_ExamenDataSet
        '
        'ExamenesTableAdapter
        '
        Me.ExamenesTableAdapter.ClearBeforeFill = True
        '
        'CodTurnoDataGridViewTextBoxColumn
        '
        Me.CodTurnoDataGridViewTextBoxColumn.DataPropertyName = "Cod_Turno"
        Me.CodTurnoDataGridViewTextBoxColumn.HeaderText = "Cod. Turno"
        Me.CodTurnoDataGridViewTextBoxColumn.Name = "CodTurnoDataGridViewTextBoxColumn"
        '
        'CodMateriaDataGridViewTextBoxColumn
        '
        Me.CodMateriaDataGridViewTextBoxColumn.DataPropertyName = "Desc_Materia"
        Me.CodMateriaDataGridViewTextBoxColumn.HeaderText = "Materia"
        Me.CodMateriaDataGridViewTextBoxColumn.Name = "CodMateriaDataGridViewTextBoxColumn"
        Me.CodMateriaDataGridViewTextBoxColumn.Width = 120
        '
        'LegajoAlumnoDataGridViewTextBoxColumn
        '
        Me.LegajoAlumnoDataGridViewTextBoxColumn.DataPropertyName = "Legajo_Alumno"
        Me.LegajoAlumnoDataGridViewTextBoxColumn.HeaderText = "Legajo Alumno"
        Me.LegajoAlumnoDataGridViewTextBoxColumn.Name = "LegajoAlumnoDataGridViewTextBoxColumn"
        '
        'Fecha_Ins
        '
        Me.Fecha_Ins.DataPropertyName = "Fecha_Ins"
        Me.Fecha_Ins.HeaderText = "Fecha Inscripción"
        Me.Fecha_Ins.Name = "Fecha_Ins"
        Me.Fecha_Ins.Width = 120
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Año"
        Me.Column1.HeaderText = "Año"
        Me.Column1.Name = "Column1"
        '
        'frmAlumnosPorMateriaPorTurno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 342)
        Me.Controls.Add(Me.dgwAlumnos)
        Me.Controls.Add(Me.cmbMateria)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbTurno)
        Me.Controls.Add(Me.lbl_apellido)
        Me.Controls.Add(Me.btn_filtrar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAlumnosPorMateriaPorTurno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alumnos Por Materia y Por Turno"
        CType(Me.dgwAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExamenesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Insc_ExamenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExamenesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbTurno As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_apellido As System.Windows.Forms.Label
    Friend WithEvents btn_filtrar As System.Windows.Forms.Button
    Friend WithEvents cmbMateria As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgwAlumnos As System.Windows.Forms.DataGridView
    Friend WithEvents Insc_ExamenDataSet As FINAL_PEREZ_GABRIELA.Insc_ExamenDataSet
    Friend WithEvents ExamenesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ExamenesTableAdapter As FINAL_PEREZ_GABRIELA.Insc_ExamenDataSetTableAdapters.ExamenesTableAdapter
    Friend WithEvents ExamenesBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents CodTurnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodMateriaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LegajoAlumnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha_Ins As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
