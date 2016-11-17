<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlumnos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAlumnos))
        Me.btn_filtrar = New System.Windows.Forms.Button
        Me.txt_filtro = New System.Windows.Forms.TextBox
        Me.lbl_apellido = New System.Windows.Forms.Label
        Me.dgvAlumnos = New System.Windows.Forms.DataGridView
        Me.LegajoAlumnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ApeNombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NroDocDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaNacDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EstCivilDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodDocDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FecingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AlumnosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Insc_ExamenDataSet = New FINAL_PEREZ_GABRIELA.Insc_ExamenDataSet
        Me.AlumnosTableAdapter = New FINAL_PEREZ_GABRIELA.Insc_ExamenDataSetTableAdapters.AlumnosTableAdapter
        CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Insc_ExamenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_filtrar
        '
        Me.btn_filtrar.Location = New System.Drawing.Point(324, 4)
        Me.btn_filtrar.Name = "btn_filtrar"
        Me.btn_filtrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_filtrar.TabIndex = 5
        Me.btn_filtrar.Text = "Filtrar"
        Me.btn_filtrar.UseVisualStyleBackColor = True
        '
        'txt_filtro
        '
        Me.txt_filtro.Location = New System.Drawing.Point(65, 6)
        Me.txt_filtro.Name = "txt_filtro"
        Me.txt_filtro.Size = New System.Drawing.Size(239, 20)
        Me.txt_filtro.TabIndex = 4
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(12, 9)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(47, 13)
        Me.lbl_apellido.TabIndex = 3
        Me.lbl_apellido.Text = "Apellido:"
        '
        'dgvAlumnos
        '
        Me.dgvAlumnos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvAlumnos.AutoGenerateColumns = False
        Me.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAlumnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LegajoAlumnoDataGridViewTextBoxColumn, Me.ApeNombreDataGridViewTextBoxColumn, Me.NroDocDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.SexoDataGridViewTextBoxColumn, Me.FechaNacDataGridViewTextBoxColumn, Me.EstCivilDataGridViewTextBoxColumn, Me.CodDocDataGridViewTextBoxColumn, Me.FecingDataGridViewTextBoxColumn})
        Me.dgvAlumnos.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvAlumnos.DataSource = Me.AlumnosBindingSource
        Me.dgvAlumnos.Location = New System.Drawing.Point(12, 42)
        Me.dgvAlumnos.MultiSelect = False
        Me.dgvAlumnos.Name = "dgvAlumnos"
        Me.dgvAlumnos.Size = New System.Drawing.Size(1138, 309)
        Me.dgvAlumnos.TabIndex = 6
        '
        'LegajoAlumnoDataGridViewTextBoxColumn
        '
        Me.LegajoAlumnoDataGridViewTextBoxColumn.DataPropertyName = "Legajo_Alumno"
        Me.LegajoAlumnoDataGridViewTextBoxColumn.HeaderText = "Legajo Alumno"
        Me.LegajoAlumnoDataGridViewTextBoxColumn.Name = "LegajoAlumnoDataGridViewTextBoxColumn"
        '
        'ApeNombreDataGridViewTextBoxColumn
        '
        Me.ApeNombreDataGridViewTextBoxColumn.DataPropertyName = "Ape_Nombre"
        Me.ApeNombreDataGridViewTextBoxColumn.HeaderText = "Apellido y Nombre"
        Me.ApeNombreDataGridViewTextBoxColumn.Name = "ApeNombreDataGridViewTextBoxColumn"
        Me.ApeNombreDataGridViewTextBoxColumn.Width = 150
        '
        'NroDocDataGridViewTextBoxColumn
        '
        Me.NroDocDataGridViewTextBoxColumn.DataPropertyName = "Nro_Doc"
        Me.NroDocDataGridViewTextBoxColumn.HeaderText = "Nro. Documento"
        Me.NroDocDataGridViewTextBoxColumn.Name = "NroDocDataGridViewTextBoxColumn"
        Me.NroDocDataGridViewTextBoxColumn.Width = 110
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
        Me.SexoDataGridViewTextBoxColumn.Width = 35
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
        'FecingDataGridViewTextBoxColumn
        '
        Me.FecingDataGridViewTextBoxColumn.DataPropertyName = "fec_ing"
        Me.FecingDataGridViewTextBoxColumn.HeaderText = "Fecha Ing."
        Me.FecingDataGridViewTextBoxColumn.Name = "FecingDataGridViewTextBoxColumn"
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
        'AlumnosBindingSource
        '
        Me.AlumnosBindingSource.DataMember = "Alumnos"
        Me.AlumnosBindingSource.DataSource = Me.Insc_ExamenDataSet
        '
        'Insc_ExamenDataSet
        '
        Me.Insc_ExamenDataSet.DataSetName = "Insc_ExamenDataSet"
        Me.Insc_ExamenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AlumnosTableAdapter
        '
        Me.AlumnosTableAdapter.ClearBeforeFill = True
        '
        'frmAlumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1162, 363)
        Me.Controls.Add(Me.dgvAlumnos)
        Me.Controls.Add(Me.txt_filtro)
        Me.Controls.Add(Me.lbl_apellido)
        Me.Controls.Add(Me.btn_filtrar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAlumnos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alumnos"
        CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Insc_ExamenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_filtrar As System.Windows.Forms.Button
    Friend WithEvents txt_filtro As System.Windows.Forms.TextBox
    Friend WithEvents lbl_apellido As System.Windows.Forms.Label
    Friend WithEvents dgvAlumnos As System.Windows.Forms.DataGridView
    Friend WithEvents Insc_ExamenDataSet As FINAL_PEREZ_GABRIELA.Insc_ExamenDataSet
    Friend WithEvents AlumnosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AlumnosTableAdapter As FINAL_PEREZ_GABRIELA.Insc_ExamenDataSetTableAdapters.AlumnosTableAdapter
    Friend WithEvents LegajoAlumnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApeNombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NroDocDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SexoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaNacDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstCivilDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodDocDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FecingDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
