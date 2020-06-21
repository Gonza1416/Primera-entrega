<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cliente
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
        Me.lbl_sintoma_control = New System.Windows.Forms.Label()
        Me.lbl_cliente = New System.Windows.Forms.Label()
        Me.btn_diagnostico = New System.Windows.Forms.Button()
        Me.btn_volver = New System.Windows.Forms.Button()
        Me.txt_sintomas = New System.Windows.Forms.TextBox()
        Me.dgvDiagnostico = New System.Windows.Forms.DataGridView()
        CType(Me.dgvDiagnostico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_sintoma_control
        '
        Me.lbl_sintoma_control.AutoSize = True
        Me.lbl_sintoma_control.Location = New System.Drawing.Point(54, 102)
        Me.lbl_sintoma_control.Name = "lbl_sintoma_control"
        Me.lbl_sintoma_control.Size = New System.Drawing.Size(53, 13)
        Me.lbl_sintoma_control.TabIndex = 0
        Me.lbl_sintoma_control.Text = "Sintomas:"
        '
        'lbl_cliente
        '
        Me.lbl_cliente.AutoSize = True
        Me.lbl_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cliente.Location = New System.Drawing.Point(10, 9)
        Me.lbl_cliente.Name = "lbl_cliente"
        Me.lbl_cliente.Size = New System.Drawing.Size(86, 25)
        Me.lbl_cliente.TabIndex = 8
        Me.lbl_cliente.Text = "Cliente"
        '
        'btn_diagnostico
        '
        Me.btn_diagnostico.Location = New System.Drawing.Point(416, 229)
        Me.btn_diagnostico.Name = "btn_diagnostico"
        Me.btn_diagnostico.Size = New System.Drawing.Size(123, 23)
        Me.btn_diagnostico.TabIndex = 12
        Me.btn_diagnostico.Text = "Generar Diagnostico"
        Me.btn_diagnostico.UseVisualStyleBackColor = True
        '
        'btn_volver
        '
        Me.btn_volver.Location = New System.Drawing.Point(12, 229)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(65, 23)
        Me.btn_volver.TabIndex = 13
        Me.btn_volver.Text = "Volver"
        Me.btn_volver.UseVisualStyleBackColor = True
        '
        'txt_sintomas
        '
        Me.txt_sintomas.Location = New System.Drawing.Point(111, 117)
        Me.txt_sintomas.Name = "txt_sintomas"
        Me.txt_sintomas.Size = New System.Drawing.Size(148, 20)
        Me.txt_sintomas.TabIndex = 14
        '
        'dgvDiagnostico
        '
        Me.dgvDiagnostico.AllowUserToAddRows = False
        Me.dgvDiagnostico.AllowUserToDeleteRows = False
        Me.dgvDiagnostico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDiagnostico.Location = New System.Drawing.Point(299, 56)
        Me.dgvDiagnostico.Name = "dgvDiagnostico"
        Me.dgvDiagnostico.ReadOnly = True
        Me.dgvDiagnostico.Size = New System.Drawing.Size(240, 150)
        Me.dgvDiagnostico.TabIndex = 15
        '
        'Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 264)
        Me.Controls.Add(Me.dgvDiagnostico)
        Me.Controls.Add(Me.txt_sintomas)
        Me.Controls.Add(Me.btn_volver)
        Me.Controls.Add(Me.btn_diagnostico)
        Me.Controls.Add(Me.lbl_cliente)
        Me.Controls.Add(Me.lbl_sintoma_control)
        Me.Name = "Cliente"
        Me.Text = "Cliente"
        CType(Me.dgvDiagnostico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_sintoma_control As Label
    Friend WithEvents lbl_cliente As Label
    Friend WithEvents btn_diagnostico As Button
    Friend WithEvents btn_volver As Button
    Friend WithEvents txt_sintomas As TextBox
    Friend WithEvents dgvDiagnostico As DataGridView
End Class
