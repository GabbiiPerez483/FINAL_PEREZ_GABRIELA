<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMPERSONAS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMPERSONAS))
        Me.lbl_apellido = New System.Windows.Forms.Label
        Me.txt_apellido = New System.Windows.Forms.TextBox
        Me.lbl_nombre = New System.Windows.Forms.Label
        Me.lbl_dni = New System.Windows.Forms.Label
        Me.txt_dni = New System.Windows.Forms.TextBox
        Me.lbl_telefono = New System.Windows.Forms.Label
        Me.txt_telefono = New System.Windows.Forms.TextBox
        Me.lbl_fecha_nac = New System.Windows.Forms.Label
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker
        Me.lbl_obs = New System.Windows.Forms.Label
        Me.btn_registrar = New System.Windows.Forms.Button
        Me.lb_estado = New System.Windows.Forms.Label
        Me.rbF = New System.Windows.Forms.RadioButton
        Me.rbM = New System.Windows.Forms.RadioButton
        Me.cmbTipoDoc = New System.Windows.Forms.ComboBox
        Me.txtDireccion = New System.Windows.Forms.TextBox
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtEstCivil = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpFechaIng = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(12, 9)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(95, 13)
        Me.lbl_apellido.TabIndex = 0
        Me.lbl_apellido.Text = "Apellido y Nombre:"
        Me.lbl_apellido.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(113, 6)
        Me.txt_apellido.MaxLength = 30
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(292, 20)
        Me.txt_apellido.TabIndex = 1
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(18, 42)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(89, 13)
        Me.lbl_nombre.TabIndex = 2
        Me.lbl_nombre.Text = "Tipo Documento:"
        Me.lbl_nombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_dni
        '
        Me.lbl_dni.AutoSize = True
        Me.lbl_dni.Location = New System.Drawing.Point(42, 72)
        Me.lbl_dni.Name = "lbl_dni"
        Me.lbl_dni.Size = New System.Drawing.Size(65, 13)
        Me.lbl_dni.TabIndex = 4
        Me.lbl_dni.Text = "Documento:"
        Me.lbl_dni.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_dni
        '
        Me.txt_dni.Location = New System.Drawing.Point(113, 69)
        Me.txt_dni.MaxLength = 8
        Me.txt_dni.Name = "txt_dni"
        Me.txt_dni.Size = New System.Drawing.Size(169, 20)
        Me.txt_dni.TabIndex = 5
        '
        'lbl_telefono
        '
        Me.lbl_telefono.AutoSize = True
        Me.lbl_telefono.Location = New System.Drawing.Point(55, 103)
        Me.lbl_telefono.Name = "lbl_telefono"
        Me.lbl_telefono.Size = New System.Drawing.Size(52, 13)
        Me.lbl_telefono.TabIndex = 6
        Me.lbl_telefono.Text = "Telefono:"
        Me.lbl_telefono.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(113, 100)
        Me.txt_telefono.MaxLength = 30
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(168, 20)
        Me.txt_telefono.TabIndex = 7
        '
        'lbl_fecha_nac
        '
        Me.lbl_fecha_nac.AutoSize = True
        Me.lbl_fecha_nac.Location = New System.Drawing.Point(41, 209)
        Me.lbl_fecha_nac.Name = "lbl_fecha_nac"
        Me.lbl_fecha_nac.Size = New System.Drawing.Size(66, 13)
        Me.lbl_fecha_nac.TabIndex = 8
        Me.lbl_fecha_nac.Text = "Fecha Nac.:"
        Me.lbl_fecha_nac.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtp_fecha
        '
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha.Location = New System.Drawing.Point(113, 209)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(96, 20)
        Me.dtp_fecha.TabIndex = 9
        '
        'lbl_obs
        '
        Me.lbl_obs.AutoSize = True
        Me.lbl_obs.Location = New System.Drawing.Point(52, 132)
        Me.lbl_obs.Name = "lbl_obs"
        Me.lbl_obs.Size = New System.Drawing.Size(55, 13)
        Me.lbl_obs.TabIndex = 13
        Me.lbl_obs.Text = "Dirección:"
        Me.lbl_obs.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_registrar
        '
        Me.btn_registrar.Location = New System.Drawing.Point(326, 290)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_registrar.TabIndex = 18
        Me.btn_registrar.Text = "Registrar"
        Me.btn_registrar.UseVisualStyleBackColor = True
        '
        'lb_estado
        '
        Me.lb_estado.AutoSize = True
        Me.lb_estado.Location = New System.Drawing.Point(73, 183)
        Me.lb_estado.Name = "lb_estado"
        Me.lb_estado.Size = New System.Drawing.Size(34, 13)
        Me.lb_estado.TabIndex = 19
        Me.lb_estado.Text = "Sexo:"
        Me.lb_estado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rbF
        '
        Me.rbF.AutoSize = True
        Me.rbF.Location = New System.Drawing.Point(113, 181)
        Me.rbF.Name = "rbF"
        Me.rbF.Size = New System.Drawing.Size(71, 17)
        Me.rbF.TabIndex = 20
        Me.rbF.TabStop = True
        Me.rbF.Text = "Femenino"
        Me.rbF.UseVisualStyleBackColor = True
        '
        'rbM
        '
        Me.rbM.AutoSize = True
        Me.rbM.Location = New System.Drawing.Point(190, 181)
        Me.rbM.Name = "rbM"
        Me.rbM.Size = New System.Drawing.Size(73, 17)
        Me.rbM.TabIndex = 21
        Me.rbM.TabStop = True
        Me.rbM.Text = "Masculino"
        Me.rbM.UseVisualStyleBackColor = True
        '
        'cmbTipoDoc
        '
        Me.cmbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoDoc.FormattingEnabled = True
        Me.cmbTipoDoc.Location = New System.Drawing.Point(113, 39)
        Me.cmbTipoDoc.Name = "cmbTipoDoc"
        Me.cmbTipoDoc.Size = New System.Drawing.Size(81, 21)
        Me.cmbTipoDoc.TabIndex = 22
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(113, 129)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(168, 20)
        Me.txtDireccion.TabIndex = 23
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(113, 155)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(168, 20)
        Me.txtEmail.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Email:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEstCivil
        '
        Me.txtEstCivil.Location = New System.Drawing.Point(113, 235)
        Me.txtEstCivil.Name = "txtEstCivil"
        Me.txtEstCivil.Size = New System.Drawing.Size(168, 20)
        Me.txtEstCivil.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 238)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Est. Civil:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpFechaIng
        '
        Me.dtpFechaIng.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIng.Location = New System.Drawing.Point(113, 261)
        Me.dtpFechaIng.Name = "dtpFechaIng"
        Me.dtpFechaIng.Size = New System.Drawing.Size(96, 20)
        Me.dtpFechaIng.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 261)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Fecha Ing.:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FRMPERSONAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 325)
        Me.Controls.Add(Me.dtpFechaIng)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEstCivil)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.cmbTipoDoc)
        Me.Controls.Add(Me.rbM)
        Me.Controls.Add(Me.rbF)
        Me.Controls.Add(Me.lb_estado)
        Me.Controls.Add(Me.btn_registrar)
        Me.Controls.Add(Me.lbl_obs)
        Me.Controls.Add(Me.dtp_fecha)
        Me.Controls.Add(Me.lbl_fecha_nac)
        Me.Controls.Add(Me.txt_telefono)
        Me.Controls.Add(Me.lbl_telefono)
        Me.Controls.Add(Me.txt_dni)
        Me.Controls.Add(Me.lbl_dni)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.lbl_apellido)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRMPERSONAS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Alumno"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_apellido As System.Windows.Forms.Label
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_dni As System.Windows.Forms.Label
    Friend WithEvents txt_dni As System.Windows.Forms.TextBox
    Friend WithEvents lbl_telefono As System.Windows.Forms.Label
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents lbl_fecha_nac As System.Windows.Forms.Label
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_obs As System.Windows.Forms.Label
    Friend WithEvents btn_registrar As System.Windows.Forms.Button
    Friend WithEvents lb_estado As System.Windows.Forms.Label
    Friend WithEvents rbF As System.Windows.Forms.RadioButton
    Friend WithEvents rbM As System.Windows.Forms.RadioButton
    Friend WithEvents cmbTipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEstCivil As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaIng As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
