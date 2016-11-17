<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaMaterias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListaMaterias))
        Me.txt_filtro = New System.Windows.Forms.TextBox
        Me.lbl_apellido = New System.Windows.Forms.Label
        Me.btn_filtrar = New System.Windows.Forms.Button
        Me.dgwMaterias = New System.Windows.Forms.DataGridView
        Me.CodMateriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescMateriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodCarreraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LegajoProfDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MateriasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Insc_ExamenDataSet = New FINAL_PEREZ_GABRIELA.Insc_ExamenDataSet
        Me.MateriasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InscExamenDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InscExamenDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MateriasTableAdapter = New FINAL_PEREZ_GABRIELA.Insc_ExamenDataSetTableAdapters.MateriasTableAdapter
        Me.TitulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TitulosTableAdapter = New FINAL_PEREZ_GABRIELA.Insc_ExamenDataSetTableAdapters.TitulosTableAdapter
        CType(Me.dgwMaterias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.MateriasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Insc_ExamenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MateriasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InscExamenDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InscExamenDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_filtro
        '
        Me.txt_filtro.Location = New System.Drawing.Point(65, 6)
        Me.txt_filtro.Name = "txt_filtro"
        Me.txt_filtro.Size = New System.Drawing.Size(239, 20)
        Me.txt_filtro.TabIndex = 10
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(12, 9)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(45, 13)
        Me.lbl_apellido.TabIndex = 9
        Me.lbl_apellido.Text = "Materia:"
        '
        'btn_filtrar
        '
        Me.btn_filtrar.Location = New System.Drawing.Point(324, 4)
        Me.btn_filtrar.Name = "btn_filtrar"
        Me.btn_filtrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_filtrar.TabIndex = 11
        Me.btn_filtrar.Text = "Filtrar"
        Me.btn_filtrar.UseVisualStyleBackColor = True
        '
        'dgwMaterias
        '
        Me.dgwMaterias.AutoGenerateColumns = False
        Me.dgwMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwMaterias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodMateriaDataGridViewTextBoxColumn, Me.DescMateriaDataGridViewTextBoxColumn, Me.CodCarreraDataGridViewTextBoxColumn, Me.LegajoProfDataGridViewTextBoxColumn})
        Me.dgwMaterias.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgwMaterias.DataSource = Me.MateriasBindingSource1
        Me.dgwMaterias.Location = New System.Drawing.Point(12, 41)
        Me.dgwMaterias.Name = "dgwMaterias"
        Me.dgwMaterias.Size = New System.Drawing.Size(490, 266)
        Me.dgwMaterias.TabIndex = 12
        '
        'CodMateriaDataGridViewTextBoxColumn
        '
        Me.CodMateriaDataGridViewTextBoxColumn.DataPropertyName = "Cod_Materia"
        Me.CodMateriaDataGridViewTextBoxColumn.HeaderText = "Cod. Materia"
        Me.CodMateriaDataGridViewTextBoxColumn.Name = "CodMateriaDataGridViewTextBoxColumn"
        '
        'DescMateriaDataGridViewTextBoxColumn
        '
        Me.DescMateriaDataGridViewTextBoxColumn.DataPropertyName = "Desc_Materia"
        Me.DescMateriaDataGridViewTextBoxColumn.HeaderText = "Materia"
        Me.DescMateriaDataGridViewTextBoxColumn.Name = "DescMateriaDataGridViewTextBoxColumn"
        '
        'CodCarreraDataGridViewTextBoxColumn
        '
        Me.CodCarreraDataGridViewTextBoxColumn.DataPropertyName = "Cod_Carrera"
        Me.CodCarreraDataGridViewTextBoxColumn.HeaderText = "Carrera"
        Me.CodCarreraDataGridViewTextBoxColumn.Name = "CodCarreraDataGridViewTextBoxColumn"
        '
        'LegajoProfDataGridViewTextBoxColumn
        '
        Me.LegajoProfDataGridViewTextBoxColumn.DataPropertyName = "Legajo_Prof"
        Me.LegajoProfDataGridViewTextBoxColumn.HeaderText = "Legajo Prof."
        Me.LegajoProfDataGridViewTextBoxColumn.Name = "LegajoProfDataGridViewTextBoxColumn"
        Me.LegajoProfDataGridViewTextBoxColumn.Width = 120
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
        Me.NuevoToolStripMenuItem.Text = "Nueva"
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
        'MateriasBindingSource1
        '
        Me.MateriasBindingSource1.DataMember = "Materias"
        Me.MateriasBindingSource1.DataSource = Me.Insc_ExamenDataSet
        '
        'Insc_ExamenDataSet
        '
        Me.Insc_ExamenDataSet.DataSetName = "Insc_ExamenDataSet"
        Me.Insc_ExamenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MateriasBindingSource
        '
        Me.MateriasBindingSource.DataMember = "Materias"
        Me.MateriasBindingSource.DataSource = Me.InscExamenDataSetBindingSource
        '
        'InscExamenDataSetBindingSource
        '
        Me.InscExamenDataSetBindingSource.DataSource = Me.Insc_ExamenDataSet
        Me.InscExamenDataSetBindingSource.Position = 0
        '
        'InscExamenDataSetBindingSource1
        '
        Me.InscExamenDataSetBindingSource1.DataSource = Me.Insc_ExamenDataSet
        Me.InscExamenDataSetBindingSource1.Position = 0
        '
        'MateriasTableAdapter
        '
        Me.MateriasTableAdapter.ClearBeforeFill = True
        '
        'TitulosBindingSource
        '
        Me.TitulosBindingSource.DataMember = "Titulos"
        Me.TitulosBindingSource.DataSource = Me.Insc_ExamenDataSet
        '
        'TitulosTableAdapter
        '
        Me.TitulosTableAdapter.ClearBeforeFill = True
        '
        'frmListaMaterias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 319)
        Me.Controls.Add(Me.dgwMaterias)
        Me.Controls.Add(Me.txt_filtro)
        Me.Controls.Add(Me.lbl_apellido)
        Me.Controls.Add(Me.btn_filtrar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmListaMaterias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Materias"
        CType(Me.dgwMaterias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.MateriasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Insc_ExamenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MateriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InscExamenDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InscExamenDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_filtro As System.Windows.Forms.TextBox
    Friend WithEvents lbl_apellido As System.Windows.Forms.Label
    Friend WithEvents btn_filtrar As System.Windows.Forms.Button
    Friend WithEvents dgwMaterias As System.Windows.Forms.DataGridView
    Friend WithEvents InscExamenDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Insc_ExamenDataSet As FINAL_PEREZ_GABRIELA.Insc_ExamenDataSet
    Friend WithEvents InscExamenDataSetBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents MateriasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MateriasTableAdapter As FINAL_PEREZ_GABRIELA.Insc_ExamenDataSetTableAdapters.MateriasTableAdapter
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TitulosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TitulosTableAdapter As FINAL_PEREZ_GABRIELA.Insc_ExamenDataSetTableAdapters.TitulosTableAdapter
    Friend WithEvents CodMateriaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescMateriaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodCarreraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LegajoProfDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MateriasBindingSource1 As System.Windows.Forms.BindingSource
End Class
