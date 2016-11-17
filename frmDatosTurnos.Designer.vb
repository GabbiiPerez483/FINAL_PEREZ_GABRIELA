<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatosTurnos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDatosTurnos))
        Me.cmbTurno = New System.Windows.Forms.ComboBox
        Me.lbl_apellido = New System.Windows.Forms.Label
        Me.btn_filtrar = New System.Windows.Forms.Button
        Me.dgwAlumnos = New System.Windows.Forms.DataGridView
        CType(Me.dgwAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbTurno
        '
        Me.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTurno.FormattingEnabled = True
        Me.cmbTurno.Location = New System.Drawing.Point(56, 6)
        Me.cmbTurno.Name = "cmbTurno"
        Me.cmbTurno.Size = New System.Drawing.Size(151, 21)
        Me.cmbTurno.TabIndex = 4
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(12, 9)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(38, 13)
        Me.lbl_apellido.TabIndex = 3
        Me.lbl_apellido.Text = "Turno:"
        '
        'btn_filtrar
        '
        Me.btn_filtrar.Location = New System.Drawing.Point(237, 4)
        Me.btn_filtrar.Name = "btn_filtrar"
        Me.btn_filtrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_filtrar.TabIndex = 5
        Me.btn_filtrar.Text = "Filtrar"
        Me.btn_filtrar.UseVisualStyleBackColor = True
        '
        'dgwAlumnos
        '
        Me.dgwAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwAlumnos.Location = New System.Drawing.Point(12, 45)
        Me.dgwAlumnos.Name = "dgwAlumnos"
        Me.dgwAlumnos.Size = New System.Drawing.Size(543, 257)
        Me.dgwAlumnos.TabIndex = 6
        '
        'frmDatosTurnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 316)
        Me.Controls.Add(Me.dgwAlumnos)
        Me.Controls.Add(Me.cmbTurno)
        Me.Controls.Add(Me.lbl_apellido)
        Me.Controls.Add(Me.btn_filtrar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDatosTurnos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos Turnos"
        CType(Me.dgwAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbTurno As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_apellido As System.Windows.Forms.Label
    Friend WithEvents btn_filtrar As System.Windows.Forms.Button
    Friend WithEvents dgwAlumnos As System.Windows.Forms.DataGridView
End Class
