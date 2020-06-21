<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Gestion
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lbl_sintomas = New System.Windows.Forms.Label()
        Me.btn_volver = New System.Windows.Forms.Button()
        Me.dgvPatologias = New System.Windows.Forms.DataGridView()
        Me.lbl_listado = New System.Windows.Forms.Label()
        Me.lbl_accion = New System.Windows.Forms.Label()
        Me.cbo_accion = New System.Windows.Forms.ComboBox()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.btn_confirmar = New System.Windows.Forms.Button()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.lbl_patologias = New System.Windows.Forms.Label()
        Me.txt_sintomas = New System.Windows.Forms.TextBox()
        Me.txt_identificacion = New System.Windows.Forms.TextBox()
        Me.lbl_Identificacion = New System.Windows.Forms.Label()
        Me.lbl_mod1 = New System.Windows.Forms.Label()
        Me.lbl_mod2 = New System.Windows.Forms.Label()
        Me.lbl_mod3 = New System.Windows.Forms.Label()
        CType(Me.dgvPatologias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_sintomas
        '
        Me.lbl_sintomas.AutoSize = True
        Me.lbl_sintomas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sintomas.Location = New System.Drawing.Point(7, 10)
        Me.lbl_sintomas.Name = "lbl_sintomas"
        Me.lbl_sintomas.Size = New System.Drawing.Size(114, 25)
        Me.lbl_sintomas.TabIndex = 0
        Me.lbl_sintomas.Text = "Gestionar"
        '
        'btn_volver
        '
        Me.btn_volver.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_volver.Location = New System.Drawing.Point(10, 245)
        Me.btn_volver.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(75, 23)
        Me.btn_volver.TabIndex = 1
        Me.btn_volver.Text = "Volver"
        Me.btn_volver.UseVisualStyleBackColor = True
        '
        'dgvPatologias
        '
        Me.dgvPatologias.AllowUserToAddRows = False
        Me.dgvPatologias.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPatologias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPatologias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPatologias.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPatologias.Location = New System.Drawing.Point(306, 52)
        Me.dgvPatologias.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.dgvPatologias.Name = "dgvPatologias"
        Me.dgvPatologias.ReadOnly = True
        Me.dgvPatologias.Size = New System.Drawing.Size(235, 216)
        Me.dgvPatologias.TabIndex = 5
        '
        'lbl_listado
        '
        Me.lbl_listado.AutoSize = True
        Me.lbl_listado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_listado.Location = New System.Drawing.Point(303, 37)
        Me.lbl_listado.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lbl_listado.Name = "lbl_listado"
        Me.lbl_listado.Size = New System.Drawing.Size(52, 13)
        Me.lbl_listado.TabIndex = 6
        Me.lbl_listado.Text = "Listado:"
        '
        'lbl_accion
        '
        Me.lbl_accion.AutoSize = True
        Me.lbl_accion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_accion.Location = New System.Drawing.Point(7, 64)
        Me.lbl_accion.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lbl_accion.Name = "lbl_accion"
        Me.lbl_accion.Size = New System.Drawing.Size(98, 13)
        Me.lbl_accion.TabIndex = 7
        Me.lbl_accion.Text = "Seleccione accion:"
        '
        'cbo_accion
        '
        Me.cbo_accion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_accion.FormattingEnabled = True
        Me.cbo_accion.Items.AddRange(New Object() {"Añadir", "Modificar", "Eliminar"})
        Me.cbo_accion.Location = New System.Drawing.Point(108, 61)
        Me.cbo_accion.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.cbo_accion.Name = "cbo_accion"
        Me.cbo_accion.Size = New System.Drawing.Size(137, 21)
        Me.cbo_accion.TabIndex = 8
        Me.cbo_accion.Tag = ""
        Me.cbo_accion.Text = "Ninguna seleccionada"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(10, 104)
        Me.lbl_nombre.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(47, 13)
        Me.lbl_nombre.TabIndex = 9
        Me.lbl_nombre.Text = "Nombre:"
        '
        'btn_confirmar
        '
        Me.btn_confirmar.Location = New System.Drawing.Point(170, 244)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(75, 23)
        Me.btn_confirmar.TabIndex = 10
        Me.btn_confirmar.Text = "Confirmar"
        Me.btn_confirmar.UseVisualStyleBackColor = True
        Me.btn_confirmar.Visible = False
        '
        'txt_nombre
        '
        Me.txt_nombre.Enabled = False
        Me.txt_nombre.Location = New System.Drawing.Point(108, 101)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(137, 20)
        Me.txt_nombre.TabIndex = 11
        '
        'lbl_patologias
        '
        Me.lbl_patologias.AutoSize = True
        Me.lbl_patologias.Location = New System.Drawing.Point(9, 144)
        Me.lbl_patologias.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lbl_patologias.Name = "lbl_patologias"
        Me.lbl_patologias.Size = New System.Drawing.Size(45, 13)
        Me.lbl_patologias.TabIndex = 12
        Me.lbl_patologias.Text = "Sintoma"
        '
        'txt_sintomas
        '
        Me.txt_sintomas.Enabled = False
        Me.txt_sintomas.Location = New System.Drawing.Point(108, 141)
        Me.txt_sintomas.Name = "txt_sintomas"
        Me.txt_sintomas.Size = New System.Drawing.Size(137, 20)
        Me.txt_sintomas.TabIndex = 13
        '
        'txt_identificacion
        '
        Me.txt_identificacion.Enabled = False
        Me.txt_identificacion.Location = New System.Drawing.Point(108, 178)
        Me.txt_identificacion.Name = "txt_identificacion"
        Me.txt_identificacion.Size = New System.Drawing.Size(137, 20)
        Me.txt_identificacion.TabIndex = 14
        '
        'lbl_Identificacion
        '
        Me.lbl_Identificacion.AutoSize = True
        Me.lbl_Identificacion.Location = New System.Drawing.Point(9, 181)
        Me.lbl_Identificacion.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lbl_Identificacion.Name = "lbl_Identificacion"
        Me.lbl_Identificacion.Size = New System.Drawing.Size(73, 13)
        Me.lbl_Identificacion.TabIndex = 15
        Me.lbl_Identificacion.Text = "Identificacion:"
        '
        'lbl_mod1
        '
        Me.lbl_mod1.AutoSize = True
        Me.lbl_mod1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mod1.Location = New System.Drawing.Point(124, 201)
        Me.lbl_mod1.Name = "lbl_mod1"
        Me.lbl_mod1.Size = New System.Drawing.Size(103, 24)
        Me.lbl_mod1.TabIndex = 16
        Me.lbl_mod1.Text = "Se modificara el registro" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " segun la ID ingresada." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lbl_mod1.Visible = False
        '
        'lbl_mod2
        '
        Me.lbl_mod2.AutoSize = True
        Me.lbl_mod2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mod2.Location = New System.Drawing.Point(25, 157)
        Me.lbl_mod2.Name = "lbl_mod2"
        Me.lbl_mod2.Size = New System.Drawing.Size(57, 12)
        Me.lbl_mod2.TabIndex = 17
        Me.lbl_mod2.Text = "(Modificado)"
        Me.lbl_mod2.Visible = False
        '
        'lbl_mod3
        '
        Me.lbl_mod3.AutoSize = True
        Me.lbl_mod3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mod3.Location = New System.Drawing.Point(25, 117)
        Me.lbl_mod3.Name = "lbl_mod3"
        Me.lbl_mod3.Size = New System.Drawing.Size(57, 12)
        Me.lbl_mod3.TabIndex = 18
        Me.lbl_mod3.Text = "(Modificado)"
        Me.lbl_mod3.Visible = False
        '
        'Gestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 279)
        Me.Controls.Add(Me.lbl_mod3)
        Me.Controls.Add(Me.lbl_mod2)
        Me.Controls.Add(Me.lbl_mod1)
        Me.Controls.Add(Me.lbl_Identificacion)
        Me.Controls.Add(Me.txt_identificacion)
        Me.Controls.Add(Me.txt_sintomas)
        Me.Controls.Add(Me.lbl_patologias)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.btn_confirmar)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.cbo_accion)
        Me.Controls.Add(Me.lbl_accion)
        Me.Controls.Add(Me.lbl_listado)
        Me.Controls.Add(Me.dgvPatologias)
        Me.Controls.Add(Me.btn_volver)
        Me.Controls.Add(Me.lbl_sintomas)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Gestion"
        Me.Text = "Sintomas"
        CType(Me.dgvPatologias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_sintomas As Label
    Friend WithEvents btn_volver As Button
    Friend WithEvents dgvPatologias As DataGridView
    Friend WithEvents lbl_listado As Label
    Friend WithEvents lbl_accion As Label
    Friend WithEvents cbo_accion As ComboBox
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents btn_confirmar As Button
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents lbl_patologias As Label
    Friend WithEvents txt_sintomas As TextBox
    Friend WithEvents txt_identificacion As TextBox
    Friend WithEvents lbl_Identificacion As Label
    Friend WithEvents lbl_mod1 As Label
    Friend WithEvents lbl_mod2 As Label
    Friend WithEvents lbl_mod3 As Label
End Class
