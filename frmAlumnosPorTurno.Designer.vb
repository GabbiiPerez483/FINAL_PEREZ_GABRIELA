<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlumnosPorTurno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAlumnosPorTurno))
        Me.lbl_apellido = New System.Windows.Forms.Label
        Me.btn_filtrar = New System.Windows.Forms.Button
        Me.cmbTurno = New System.Windows.Forms.ComboBox
        Me.dgwTurnos = New System.Windows.Forms.DataGridView
        Me.CodTurnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LegajoAlumnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaInsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ExamenesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Insc_ExamenDataSet = New FINAL_PEREZ_GABRIELA.Insc_ExamenDataSet
        Me.ExamenesTableAdapter = New FINAL_PEREZ_GABRIELA.Insc_ExamenDataSetTableAdapters.ExamenesTableAdapter
        CType(Me.dgwTurnos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExamenesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Insc_ExamenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(12, 9)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(38, 13)
        Me.lbl_apellido.TabIndex = 0
        Me.lbl_apellido.Text = "Turno:"
        '
        'btn_filtrar
        '
        Me.btn_filtrar.Location = New System.Drawing.Point(237, 4)
        Me.btn_filtrar.Name = "btn_filtrar"
        Me.btn_filtrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_filtrar.TabIndex = 2
        Me.btn_filtrar.Text = "Filtrar"
        Me.btn_filtrar.UseVisualStyleBackColor = True
        '
        'cmbTurno
        '
        Me.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTurno.FormattingEnabled = True
        Me.cmbTurno.Location = New System.Drawing.Point(56, 6)
        Me.cmbTurno.Name = "cmbTurno"
        Me.cmbTurno.Size = New System.Drawing.Size(151, 21)
        Me.cmbTurno.TabIndex = 1
        '
        'dgwTurnos
        '
        Me.dgwTurnos.AutoGenerateColumns = False
        Me.dgwTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwTurnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodTurnoDataGridViewTextBoxColumn, Me.LegajoAlumnoDataGridViewTextBoxColumn, Me.FechaInsDataGridViewTextBoxColumn})
        Me.dgwTurnos.DataSource = Me.ExamenesBindingSource
        Me.dgwTurnos.Location = New System.Drawing.Point(12, 42)
        Me.dgwTurnos.Name = "dgwTurnos"
        Me.dgwTurnos.Size = New System.Drawing.Size(344, 208)
        Me.dgwTurnos.TabIndex = 3
        '
        'CodTurnoDataGridViewTextBoxColumn
        '
        Me.CodTurnoDataGridViewTextBoxColumn.DataPropertyName = "Cod_Turno"
        Me.CodTurnoDataGridViewTextBoxColumn.HeaderText = "Cod. Turno"
        Me.CodTurnoDataGridViewTextBoxColumn.Name = "CodTurnoDataGridViewTextBoxColumn"
        '
        'LegajoAlumnoDataGridViewTextBoxColumn
        '
        Me.LegajoAlumnoDataGridViewTextBoxColumn.DataPropertyName = "Legajo_Alumno"
        Me.LegajoAlumnoDataGridViewTextBoxColumn.HeaderText = "Legajo Alumno"
        Me.LegajoAlumnoDataGridViewTextBoxColumn.Name = "LegajoAlumnoDataGridViewTextBoxColumn"
        '
        'FechaInsDataGridViewTextBoxColumn
        '
        Me.FechaInsDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Ins"
        Me.FechaInsDataGridViewTextBoxColumn.HeaderText = "Fecha Insc."
        Me.FechaInsDataGridViewTextBoxColumn.Name = "FechaInsDataGridViewTextBoxColumn"
        '
        'ExamenesBindingSource
        '
        Me.ExamenesBindingSource.DataMember = "Examenes"
        Me.ExamenesBindingSource.DataSource = Me.Insc_ExamenDataSet
        '
        'Insc_ExamenDataSet
        '
        Me.Insc_ExamenDataSet.DataSetName = "Insc_ExamenDataSet"
        Me.Insc_ExamenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ExamenesTableAdapter
        '
        Me.ExamenesTableAdapter.ClearBeforeFill = True
        '
        'frmAlumnosPorTurno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 262)
        Me.Controls.Add(Me.dgwTurnos)
        Me.Controls.Add(Me.cmbTurno)
        Me.Controls.Add(Me.lbl_apellido)
        Me.Controls.Add(Me.btn_filtrar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAlumnosPorTurno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alumnos Por Turno"
        CType(Me.dgwTurnos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExamenesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Insc_ExamenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_apellido As System.Windows.Forms.Label
    Friend WithEvents btn_filtrar As System.Windows.Forms.Button
    Friend WithEvents cmbTurno As System.Windows.Forms.ComboBox
    Friend WithEvents dgwTurnos As System.Windows.Forms.DataGridView
    Friend WithEvents Insc_ExamenDataSet As FINAL_PEREZ_GABRIELA.Insc_ExamenDataSet
    Friend WithEvents ExamenesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ExamenesTableAdapter As FINAL_PEREZ_GABRIELA.Insc_ExamenDataSetTableAdapters.ExamenesTableAdapter
    Friend WithEvents CodTurnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LegajoAlumnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaInsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
