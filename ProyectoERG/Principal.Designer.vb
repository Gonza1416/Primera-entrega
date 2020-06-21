<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl_seleccion = New System.Windows.Forms.Label()
        Me.btn_gestion = New System.Windows.Forms.Button()
        Me.btn_cliente = New System.Windows.Forms.Button()
        Me.btn_cerrarsesion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_seleccion
        '
        Me.lbl_seleccion.AutoSize = True
        Me.lbl_seleccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_seleccion.Location = New System.Drawing.Point(12, 23)
        Me.lbl_seleccion.Name = "lbl_seleccion"
        Me.lbl_seleccion.Size = New System.Drawing.Size(258, 25)
        Me.lbl_seleccion.TabIndex = 0
        Me.lbl_seleccion.Text = "Seleccione una opcion:"
        '
        'btn_gestion
        '
        Me.btn_gestion.Location = New System.Drawing.Point(94, 134)
        Me.btn_gestion.Name = "btn_gestion"
        Me.btn_gestion.Size = New System.Drawing.Size(96, 27)
        Me.btn_gestion.TabIndex = 1
        Me.btn_gestion.Text = "Gestion"
        Me.btn_gestion.UseVisualStyleBackColor = True
        '
        'btn_cliente
        '
        Me.btn_cliente.Location = New System.Drawing.Point(94, 74)
        Me.btn_cliente.Name = "btn_cliente"
        Me.btn_cliente.Size = New System.Drawing.Size(96, 27)
        Me.btn_cliente.TabIndex = 2
        Me.btn_cliente.Text = "Cliente"
        Me.btn_cliente.UseVisualStyleBackColor = True
        '
        'btn_cerrarsesion
        '
        Me.btn_cerrarsesion.Location = New System.Drawing.Point(178, 226)
        Me.btn_cerrarsesion.Name = "btn_cerrarsesion"
        Me.btn_cerrarsesion.Size = New System.Drawing.Size(92, 23)
        Me.btn_cerrarsesion.TabIndex = 3
        Me.btn_cerrarsesion.Text = "Cerrar sesion"
        Me.btn_cerrarsesion.UseVisualStyleBackColor = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 261)
        Me.Controls.Add(Me.btn_cerrarsesion)
        Me.Controls.Add(Me.btn_cliente)
        Me.Controls.Add(Me.btn_gestion)
        Me.Controls.Add(Me.lbl_seleccion)
        Me.Name = "Principal"
        Me.Text = "Menu Principal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_seleccion As Label
    Friend WithEvents btn_gestion As Button
    Friend WithEvents btn_cliente As Button
    Friend WithEvents btn_cerrarsesion As Button
End Class
