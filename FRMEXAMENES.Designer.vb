<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMEXAMENES
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMEXAMENES))
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbAño = New System.Windows.Forms.ComboBox
        Me.cmbTurno = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbMateria = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtLegajoAlumno = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtpFechaInsc = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtNota = New System.Windows.Forms.TextBox
        Me.btn_registrar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Año:"
        '
        'cmbAño
        '
        Me.cmbAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAño.FormattingEnabled = True
        Me.cmbAño.Location = New System.Drawing.Point(93, 12)
        Me.cmbAño.Name = "cmbAño"
        Me.cmbAño.Size = New System.Drawing.Size(121, 21)
        Me.cmbAño.TabIndex = 1
        '
        'cmbTurno
        '
        Me.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTurno.FormattingEnabled = True
        Me.cmbTurno.Location = New System.Drawing.Point(93, 39)
        Me.cmbTurno.Name = "cmbTurno"
        Me.cmbTurno.Size = New System.Drawing.Size(121, 21)
        Me.cmbTurno.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cod. Turno:"
        '
        'cmbMateria
        '
        Me.cmbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMateria.FormattingEnabled = True
        Me.cmbMateria.Location = New System.Drawing.Point(93, 66)
        Me.cmbMateria.Name = "cmbMateria"
        Me.cmbMateria.Size = New System.Drawing.Size(121, 21)
        Me.cmbMateria.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cod. Materia:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Legajo Alumno:"
        '
        'txtLegajoAlumno
        '
        Me.txtLegajoAlumno.Location = New System.Drawing.Point(93, 93)
        Me.txtLegajoAlumno.Name = "txtLegajoAlumno"
        Me.txtLegajoAlumno.Size = New System.Drawing.Size(121, 20)
        Me.txtLegajoAlumno.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Fecha Insc.:"
        '
        'dtpFechaInsc
        '
        Me.dtpFechaInsc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInsc.Location = New System.Drawing.Point(93, 119)
        Me.dtpFechaInsc.Name = "dtpFechaInsc"
        Me.dtpFechaInsc.Size = New System.Drawing.Size(121, 20)
        Me.dtpFechaInsc.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(53, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Nota:"
        '
        'txtNota
        '
        Me.txtNota.Location = New System.Drawing.Point(93, 145)
        Me.txtNota.MaxLength = 5
        Me.txtNota.Name = "txtNota"
        Me.txtNota.Size = New System.Drawing.Size(121, 20)
        Me.txtNota.TabIndex = 11
        '
        'btn_registrar
        '
        Me.btn_registrar.Location = New System.Drawing.Point(145, 184)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_registrar.TabIndex = 12
        Me.btn_registrar.Text = "Registrar"
        Me.btn_registrar.UseVisualStyleBackColor = True
        '
        'FRMEXAMENES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(232, 219)
        Me.Controls.Add(Me.btn_registrar)
        Me.Controls.Add(Me.txtNota)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpFechaInsc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtLegajoAlumno)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbMateria)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbTurno)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbAño)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRMEXAMENES"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EXAMENES"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbAño As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTurno As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbMateria As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtLegajoAlumno As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaInsc As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNota As System.Windows.Forms.TextBox
    Friend WithEvents btn_registrar As System.Windows.Forms.Button
End Class
