<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaExamenes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListaExamenes))
        Me.txt_filtro = New System.Windows.Forms.TextBox
        Me.lbl_apellido = New System.Windows.Forms.Label
        Me.btn_filtrar = New System.Windows.Forms.Button
        Me.dgwExamenes = New System.Windows.Forms.DataGridView
        Me.Insc_ExamenDataSet = New FINAL_PEREZ_GABRIELA.Insc_ExamenDataSet
        Me.ExamenesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExamenesTableAdapter = New FINAL_PEREZ_GABRIELA.Insc_ExamenDataSetTableAdapters.ExamenesTableAdapter
        Me.AñoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodTurnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodMateriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LegajoAlumnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaInsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NotaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.dgwExamenes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Insc_ExamenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExamenesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_filtro
        '
        Me.txt_filtro.Location = New System.Drawing.Point(47, 6)
        Me.txt_filtro.Name = "txt_filtro"
        Me.txt_filtro.Size = New System.Drawing.Size(123, 20)
        Me.txt_filtro.TabIndex = 1
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(12, 9)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(29, 13)
        Me.lbl_apellido.TabIndex = 0
        Me.lbl_apellido.Text = "Año:"
        '
        'btn_filtrar
        '
        Me.btn_filtrar.Location = New System.Drawing.Point(189, 4)
        Me.btn_filtrar.Name = "btn_filtrar"
        Me.btn_filtrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_filtrar.TabIndex = 2
        Me.btn_filtrar.Text = "Filtrar"
        Me.btn_filtrar.UseVisualStyleBackColor = True
        '
        'dgwExamenes
        '
        Me.dgwExamenes.AutoGenerateColumns = False
        Me.dgwExamenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwExamenes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AñoDataGridViewTextBoxColumn, Me.CodTurnoDataGridViewTextBoxColumn, Me.CodMateriaDataGridViewTextBoxColumn, Me.LegajoAlumnoDataGridViewTextBoxColumn, Me.FechaInsDataGridViewTextBoxColumn, Me.NotaDataGridViewTextBoxColumn})
        Me.dgwExamenes.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgwExamenes.DataSource = Me.ExamenesBindingSource
        Me.dgwExamenes.Location = New System.Drawing.Point(12, 42)
        Me.dgwExamenes.Name = "dgwExamenes"
        Me.dgwExamenes.Size = New System.Drawing.Size(643, 315)
        Me.dgwExamenes.TabIndex = 3
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
        'AñoDataGridViewTextBoxColumn
        '
        Me.AñoDataGridViewTextBoxColumn.DataPropertyName = "Año"
        Me.AñoDataGridViewTextBoxColumn.HeaderText = "Año"
        Me.AñoDataGridViewTextBoxColumn.Name = "AñoDataGridViewTextBoxColumn"
        '
        'CodTurnoDataGridViewTextBoxColumn
        '
        Me.CodTurnoDataGridViewTextBoxColumn.DataPropertyName = "Cod_Turno"
        Me.CodTurnoDataGridViewTextBoxColumn.HeaderText = "Cod. Turno"
        Me.CodTurnoDataGridViewTextBoxColumn.Name = "CodTurnoDataGridViewTextBoxColumn"
        '
        'CodMateriaDataGridViewTextBoxColumn
        '
        Me.CodMateriaDataGridViewTextBoxColumn.DataPropertyName = "Cod_Materia"
        Me.CodMateriaDataGridViewTextBoxColumn.HeaderText = "Cod. Materia"
        Me.CodMateriaDataGridViewTextBoxColumn.Name = "CodMateriaDataGridViewTextBoxColumn"
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
        'NotaDataGridViewTextBoxColumn
        '
        Me.NotaDataGridViewTextBoxColumn.DataPropertyName = "Nota"
        Me.NotaDataGridViewTextBoxColumn.HeaderText = "Nota"
        Me.NotaDataGridViewTextBoxColumn.Name = "NotaDataGridViewTextBoxColumn"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.ModificarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(126, 70)
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'frmListaExamenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 369)
        Me.Controls.Add(Me.dgwExamenes)
        Me.Controls.Add(Me.txt_filtro)
        Me.Controls.Add(Me.lbl_apellido)
        Me.Controls.Add(Me.btn_filtrar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmListaExamenes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Examenes"
        CType(Me.dgwExamenes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Insc_ExamenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExamenesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_filtro As System.Windows.Forms.TextBox
    Friend WithEvents lbl_apellido As System.Windows.Forms.Label
    Friend WithEvents btn_filtrar As System.Windows.Forms.Button
    Friend WithEvents dgwExamenes As System.Windows.Forms.DataGridView
    Friend WithEvents Insc_ExamenDataSet As FINAL_PEREZ_GABRIELA.Insc_ExamenDataSet
    Friend WithEvents ExamenesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ExamenesTableAdapter As FINAL_PEREZ_GABRIELA.Insc_ExamenDataSetTableAdapters.ExamenesTableAdapter
    Friend WithEvents AñoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodTurnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodMateriaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LegajoAlumnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaInsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NotaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
