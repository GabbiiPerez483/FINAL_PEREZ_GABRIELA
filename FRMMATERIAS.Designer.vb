<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMMATERIAS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMMATERIAS))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtMateria = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbCarrera = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtLegajoProf = New System.Windows.Forms.TextBox
        Me.btn_registrar = New System.Windows.Forms.Button
        Me.txtDescMateria = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cod. Materia:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Materia:"
        '
        'txtMateria
        '
        Me.txtMateria.Location = New System.Drawing.Point(88, 10)
        Me.txtMateria.MaxLength = 5
        Me.txtMateria.Name = "txtMateria"
        Me.txtMateria.Size = New System.Drawing.Size(121, 20)
        Me.txtMateria.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Carrera:"
        '
        'cmbCarrera
        '
        Me.cmbCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCarrera.FormattingEnabled = True
        Me.cmbCarrera.Location = New System.Drawing.Point(88, 63)
        Me.cmbCarrera.Name = "cmbCarrera"
        Me.cmbCarrera.Size = New System.Drawing.Size(184, 21)
        Me.cmbCarrera.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Legajo Prof.:"
        '
        'txtLegajoProf
        '
        Me.txtLegajoProf.Location = New System.Drawing.Point(88, 90)
        Me.txtLegajoProf.Name = "txtLegajoProf"
        Me.txtLegajoProf.Size = New System.Drawing.Size(121, 20)
        Me.txtLegajoProf.TabIndex = 7
        '
        'btn_registrar
        '
        Me.btn_registrar.Location = New System.Drawing.Point(197, 133)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_registrar.TabIndex = 19
        Me.btn_registrar.Text = "Registrar"
        Me.btn_registrar.UseVisualStyleBackColor = True
        '
        'txtDescMateria
        '
        Me.txtDescMateria.Location = New System.Drawing.Point(88, 37)
        Me.txtDescMateria.MaxLength = 30
        Me.txtDescMateria.Name = "txtDescMateria"
        Me.txtDescMateria.Size = New System.Drawing.Size(184, 20)
        Me.txtDescMateria.TabIndex = 20
        '
        'FRMMATERIAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 168)
        Me.Controls.Add(Me.txtDescMateria)
        Me.Controls.Add(Me.btn_registrar)
        Me.Controls.Add(Me.txtLegajoProf)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbCarrera)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMateria)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRMMATERIAS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MATERIAS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMateria As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbCarrera As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtLegajoProf As System.Windows.Forms.TextBox
    Friend WithEvents btn_registrar As System.Windows.Forms.Button
    Friend WithEvents txtDescMateria As System.Windows.Forms.TextBox
End Class
