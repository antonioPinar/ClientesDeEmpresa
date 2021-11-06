<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DisPrincipal
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
        Me.btnAltas = New System.Windows.Forms.Button()
        Me.btnBajas = New System.Windows.Forms.Button()
        Me.btnListado = New System.Windows.Forms.Button()
        Me.btnSalida = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAltas
        '
        Me.btnAltas.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAltas.Location = New System.Drawing.Point(60, 20)
        Me.btnAltas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAltas.Name = "btnAltas"
        Me.btnAltas.Size = New System.Drawing.Size(100, 34)
        Me.btnAltas.TabIndex = 0
        Me.btnAltas.Text = "Altas"
        Me.btnAltas.UseVisualStyleBackColor = True
        '
        'btnBajas
        '
        Me.btnBajas.Enabled = False
        Me.btnBajas.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBajas.Location = New System.Drawing.Point(60, 72)
        Me.btnBajas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnBajas.Name = "btnBajas"
        Me.btnBajas.Size = New System.Drawing.Size(100, 34)
        Me.btnBajas.TabIndex = 1
        Me.btnBajas.Text = "Bajas"
        Me.btnBajas.UseVisualStyleBackColor = True
        '
        'btnListado
        '
        Me.btnListado.Enabled = False
        Me.btnListado.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListado.Location = New System.Drawing.Point(46, 125)
        Me.btnListado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnListado.Name = "btnListado"
        Me.btnListado.Size = New System.Drawing.Size(128, 34)
        Me.btnListado.TabIndex = 2
        Me.btnListado.Text = "Listado"
        Me.btnListado.UseVisualStyleBackColor = True
        '
        'btnSalida
        '
        Me.btnSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalida.Location = New System.Drawing.Point(46, 178)
        Me.btnSalida.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSalida.Name = "btnSalida"
        Me.btnSalida.Size = New System.Drawing.Size(128, 34)
        Me.btnSalida.TabIndex = 3
        Me.btnSalida.Text = "Salida"
        Me.btnSalida.UseVisualStyleBackColor = True
        '
        'DisPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(230, 237)
        Me.Controls.Add(Me.btnSalida)
        Me.Controls.Add(Me.btnListado)
        Me.Controls.Add(Me.btnBajas)
        Me.Controls.Add(Me.btnAltas)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "DisPrincipal"
        Me.Text = "DisPrincipal"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAltas As Button
    Friend WithEvents btnBajas As Button
    Friend WithEvents btnListado As Button
    Friend WithEvents btnSalida As Button
End Class
