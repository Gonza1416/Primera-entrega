<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Logueo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbl_logueo = New System.Windows.Forms.Label()
        Me.btn_entrar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_logueo
        '
        Me.lbl_logueo.AutoSize = True
        Me.lbl_logueo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_logueo.Location = New System.Drawing.Point(95, 9)
        Me.lbl_logueo.Name = "lbl_logueo"
        Me.lbl_logueo.Size = New System.Drawing.Size(90, 25)
        Me.lbl_logueo.TabIndex = 0
        Me.lbl_logueo.Text = "Logueo"
        '
        'btn_entrar
        '
        Me.btn_entrar.Location = New System.Drawing.Point(100, 149)
        Me.btn_entrar.Name = "btn_entrar"
        Me.btn_entrar.Size = New System.Drawing.Size(85, 23)
        Me.btn_entrar.TabIndex = 1
        Me.btn_entrar.Text = "Entrar"
        Me.btn_entrar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(100, 202)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(85, 23)
        Me.btn_salir.TabIndex = 2
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'Logueo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(291, 297)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_entrar)
        Me.Controls.Add(Me.lbl_logueo)
        Me.Name = "Logueo"
        Me.Text = "Logueo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_logueo As Label
    Friend WithEvents btn_entrar As Button
    Friend WithEvents btn_salir As Button
End Class
