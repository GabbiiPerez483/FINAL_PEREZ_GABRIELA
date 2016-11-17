<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaProfesores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListaProfesores))
        Me.txt_filtro = New System.Windows.Forms.TextBox
        Me.lbl_apellido = New System.Windows.Forms.Label
        Me.btn_filtrar = New System.Windows.Forms.Button
        Me.dgwProfesores = New System.Windows.Forms.DataGridView
        Me.LegajoProfDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ApeNombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NroDocDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaNacDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EstCivilDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodDocDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodTituloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProfesoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Insc_ExamenDataSet = New FINAL_PEREZ_GABRIELA.Insc_ExamenDataSet
        Me.ProfesoresTableAdapter = New FINAL_PEREZ_GABRIELA.Insc_ExamenDataSetTableAdapters.ProfesoresTableAdapter
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.dgwProfesores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfesoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Insc_ExamenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_filtro
        '
        Me.txt_filtro.Location = New System.Drawing.Point(65, 6)
        Me.txt_filtro.Name = "txt_filtro"
        Me.txt_filtro.Size = New System.Drawing.Size(239, 20)
        Me.txt_filtro.TabIndex = 7
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(12, 9)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(47, 13)
        Me.lbl_apellido.TabIndex = 6
        Me.lbl_apellido.Text = "Apellido:"
        '
        'btn_filtrar
        '
        Me.btn_filtrar.Location = New System.Drawing.Point(324, 4)
        Me.btn_filtrar.Name = "btn_filtrar"
        Me.btn_filtrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_filtrar.TabIndex = 8
        Me.btn_filtrar.Text = "Filtrar"
        Me.btn_filtrar.UseVisualStyleBackColor = True
        '
        'dgwProfesores
        '
        Me.dgwProfesores.AutoGenerateColumns = False
        Me.dgwProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwProfesores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LegajoProfDataGridViewTextBoxColumn, Me.ApeNombreDataGridViewTextBoxColumn, Me.NroDocDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.SexoDataGridViewTextBoxColumn, Me.FechaNacDataGridViewTextBoxColumn, Me.EstCivilDataGridViewTextBoxColumn, Me.CodDocDataGridViewTextBoxColumn, Me.CodTituloDataGridViewTextBoxColumn})
        Me.dgwProfesores.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgwProfesores.DataSource = Me.ProfesoresBindingSource
        Me.dgwProfesores.Location = New System.Drawing.Point(12, 41)
        Me.dgwProfesores.Name = "dgwProfesores"
        Me.dgwProfesores.Size = New System.Drawing.Size(1142, 286)
        Me.dgwProfesores.TabIndex = 9
        '
        'LegajoProfDataGridViewTextBoxColumn
        '
        Me.LegajoProfDataGridViewTextBoxColumn.DataPropertyName = "Legajo_Prof"
        Me.LegajoProfDataGridViewTextBoxColumn.HeaderText = "Legajo"
        Me.LegajoProfDataGridViewTextBoxColumn.Name = "LegajoProfDataGridViewTextBoxColumn"
        Me.LegajoProfDataGridViewTextBoxColumn.Width = 90
        '
        'ApeNombreDataGridViewTextBoxColumn
        '
        Me.ApeNombreDataGridViewTextBoxColumn.DataPropertyName = "Ape_Nombre"
        Me.ApeNombreDataGridViewTextBoxColumn.HeaderText = "Apellido y Nombre"
        Me.ApeNombreDataGridViewTextBoxColumn.Name = "ApeNombreDataGridViewTextBoxColumn"
        Me.ApeNombreDataGridViewTextBoxColumn.Width = 120
        '
        'NroDocDataGridViewTextBoxColumn
        '
        Me.NroDocDataGridViewTextBoxColumn.DataPropertyName = "Nro_Doc"
        Me.NroDocDataGridViewTextBoxColumn.HeaderText = "Nro. Doc."
        Me.NroDocDataGridViewTextBoxColumn.Name = "NroDocDataGridViewTextBoxColumn"
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        '
        'SexoDataGridViewTextBoxColumn
        '
        Me.SexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo"
        Me.SexoDataGridViewTextBoxColumn.HeaderText = "Sexo"
        Me.SexoDataGridViewTextBoxColumn.Name = "SexoDataGridViewTextBoxColumn"
        '
        'FechaNacDataGridViewTextBoxColumn
        '
        Me.FechaNacDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Nac"
        Me.FechaNacDataGridViewTextBoxColumn.HeaderText = "Fecha Nac."
        Me.FechaNacDataGridViewTextBoxColumn.Name = "FechaNacDataGridViewTextBoxColumn"
        '
        'EstCivilDataGridViewTextBoxColumn
        '
        Me.EstCivilDataGridViewTextBoxColumn.DataPropertyName = "Est_Civil"
        Me.EstCivilDataGridViewTextBoxColumn.HeaderText = "Est. Civil"
        Me.EstCivilDataGridViewTextBoxColumn.Name = "EstCivilDataGridViewTextBoxColumn"
        '
        'CodDocDataGridViewTextBoxColumn
        '
        Me.CodDocDataGridViewTextBoxColumn.DataPropertyName = "Cod_Doc"
        Me.CodDocDataGridViewTextBoxColumn.HeaderText = "Cod. Doc."
        Me.CodDocDataGridViewTextBoxColumn.Name = "CodDocDataGridViewTextBoxColumn"
        '
        'CodTituloDataGridViewTextBoxColumn
        '
        Me.CodTituloDataGridViewTextBoxColumn.DataPropertyName = "Cod_Titulo"
        Me.CodTituloDataGridViewTextBoxColumn.HeaderText = "Cod. Titulo"
        Me.CodTituloDataGridViewTextBoxColumn.Name = "CodTituloDataGridViewTextBoxColumn"
        '
        'ProfesoresBindingSource
        '
        Me.ProfesoresBindingSource.DataMember = "Profesores"
        Me.ProfesoresBindingSource.DataSource = Me.Insc_ExamenDataSet
        '
        'Insc_ExamenDataSet
        '
        Me.Insc_ExamenDataSet.DataSetName = "Insc_ExamenDataSet"
        Me.Insc_ExamenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProfesoresTableAdapter
        '
        Me.ProfesoresTableAdapter.ClearBeforeFill = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.ModificarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(153, 92)
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'frmListaProfesores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1166, 339)
        Me.Controls.Add(Me.dgwProfesores)
        Me.Controls.Add(Me.txt_filtro)
        Me.Controls.Add(Me.lbl_apellido)
        Me.Controls.Add(Me.btn_filtrar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmListaProfesores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Profesores"
        CType(Me.dgwProfesores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfesoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Insc_ExamenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_filtro As System.Windows.Forms.TextBox
    Friend WithEvents lbl_apellido As System.Windows.Forms.Label
    Friend WithEvents btn_filtrar As System.Windows.Forms.Button
    Friend WithEvents dgwProfesores As System.Windows.Forms.DataGridView
    Friend WithEvents Insc_ExamenDataSet As FINAL_PEREZ_GABRIELA.Insc_ExamenDataSet
    Friend WithEvents ProfesoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProfesoresTableAdapter As FINAL_PEREZ_GABRIELA.Insc_ExamenDataSetTableAdapters.ProfesoresTableAdapter
    Friend WithEvents LegajoProfDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApeNombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NroDocDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SexoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaNacDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstCivilDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodDocDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodTituloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
