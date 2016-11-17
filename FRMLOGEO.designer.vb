<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMLOGEO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMLOGEO))
        Me.lbl_usuario = New System.Windows.Forms.Label
        Me.txt_usuario = New System.Windows.Forms.TextBox
        Me.lbl_pass = New System.Windows.Forms.Label
        Me.txt_pass = New System.Windows.Forms.TextBox
        Me.btn_ingresar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Location = New System.Drawing.Point(7, 18)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(46, 13)
        Me.lbl_usuario.TabIndex = 0
        Me.lbl_usuario.Text = "Usuario:"
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(59, 15)
        Me.txt_usuario.MaxLength = 20
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(150, 20)
        Me.txt_usuario.TabIndex = 1
        '
        'lbl_pass
        '
        Me.lbl_pass.AutoSize = True
        Me.lbl_pass.Location = New System.Drawing.Point(16, 47)
        Me.lbl_pass.Name = "lbl_pass"
        Me.lbl_pass.Size = New System.Drawing.Size(37, 13)
        Me.lbl_pass.TabIndex = 2
        Me.lbl_pass.Text = "Clave:"
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(59, 44)
        Me.txt_pass.MaxLength = 20
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pass.Size = New System.Drawing.Size(150, 20)
        Me.txt_pass.TabIndex = 3
        Me.txt_pass.UseSystemPasswordChar = True
        '
        'btn_ingresar
        '
        Me.btn_ingresar.Location = New System.Drawing.Point(79, 76)
        Me.btn_ingresar.Name = "btn_ingresar"
        Me.btn_ingresar.Size = New System.Drawing.Size(75, 23)
        Me.btn_ingresar.TabIndex = 4
        Me.btn_ingresar.Text = "Ingresar"
        Me.btn_ingresar.UseVisualStyleBackColor = True
        '
        'FRMLOGEO
        '
        Me.AcceptButton = Me.btn_ingresar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(231, 111)
        Me.Controls.Add(Me.btn_ingresar)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.lbl_pass)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.lbl_usuario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRMLOGEO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_usuario As System.Windows.Forms.Label
    Friend WithEvents txt_usuario As System.Windows.Forms.TextBox
    Friend WithEvents lbl_pass As System.Windows.Forms.Label
    Friend WithEvents txt_pass As System.Windows.Forms.TextBox
    Friend WithEvents btn_ingresar As System.Windows.Forms.Button
End Class
