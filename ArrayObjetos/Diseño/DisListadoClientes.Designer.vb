<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DisListadoClientes
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
        Me.etqCodigoListado = New System.Windows.Forms.Label()
        Me.etqNombreListado = New System.Windows.Forms.Label()
        Me.etqApellidoListado = New System.Windows.Forms.Label()
        Me.etqFechaIListado = New System.Windows.Forms.Label()
        Me.etqSueldoListado = New System.Windows.Forms.Label()
        Me.etqRespCodListado = New System.Windows.Forms.Label()
        Me.etqRespNomListado = New System.Windows.Forms.Label()
        Me.etqRespApellListado = New System.Windows.Forms.Label()
        Me.etqRespFechaIListado = New System.Windows.Forms.Label()
        Me.etqRespSueldoListado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'etqCodigoListado
        '
        Me.etqCodigoListado.AutoSize = True
        Me.etqCodigoListado.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etqCodigoListado.Location = New System.Drawing.Point(29, 27)
        Me.etqCodigoListado.Name = "etqCodigoListado"
        Me.etqCodigoListado.Size = New System.Drawing.Size(92, 29)
        Me.etqCodigoListado.TabIndex = 11
        Me.etqCodigoListado.Text = "Codigo"
        '
        'etqNombreListado
        '
        Me.etqNombreListado.AutoSize = True
        Me.etqNombreListado.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etqNombreListado.Location = New System.Drawing.Point(164, 27)
        Me.etqNombreListado.Name = "etqNombreListado"
        Me.etqNombreListado.Size = New System.Drawing.Size(101, 29)
        Me.etqNombreListado.TabIndex = 12
        Me.etqNombreListado.Text = "Nombre"
        '
        'etqApellidoListado
        '
        Me.etqApellidoListado.AutoSize = True
        Me.etqApellidoListado.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etqApellidoListado.Location = New System.Drawing.Point(315, 27)
        Me.etqApellidoListado.Name = "etqApellidoListado"
        Me.etqApellidoListado.Size = New System.Drawing.Size(114, 29)
        Me.etqApellidoListado.TabIndex = 13
        Me.etqApellidoListado.Text = "Apellidos"
        '
        'etqFechaIListado
        '
        Me.etqFechaIListado.AutoSize = True
        Me.etqFechaIListado.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etqFechaIListado.Location = New System.Drawing.Point(479, 27)
        Me.etqFechaIListado.Name = "etqFechaIListado"
        Me.etqFechaIListado.Size = New System.Drawing.Size(201, 29)
        Me.etqFechaIListado.TabIndex = 14
        Me.etqFechaIListado.Text = "Fecha de ingreso"
        Me.etqFechaIListado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'etqSueldoListado
        '
        Me.etqSueldoListado.AutoSize = True
        Me.etqSueldoListado.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etqSueldoListado.Location = New System.Drawing.Point(723, 27)
        Me.etqSueldoListado.Name = "etqSueldoListado"
        Me.etqSueldoListado.Size = New System.Drawing.Size(90, 29)
        Me.etqSueldoListado.TabIndex = 15
        Me.etqSueldoListado.Text = "Sueldo"
        Me.etqSueldoListado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'etqRespCodListado
        '
        Me.etqRespCodListado.Location = New System.Drawing.Point(31, 78)
        Me.etqRespCodListado.Name = "etqRespCodListado"
        Me.etqRespCodListado.Size = New System.Drawing.Size(90, 299)
        Me.etqRespCodListado.TabIndex = 16
        '
        'etqRespNomListado
        '
        Me.etqRespNomListado.AutoSize = True
        Me.etqRespNomListado.Location = New System.Drawing.Point(165, 78)
        Me.etqRespNomListado.Name = "etqRespNomListado"
        Me.etqRespNomListado.Size = New System.Drawing.Size(0, 17)
        Me.etqRespNomListado.TabIndex = 17
        '
        'etqRespApellListado
        '
        Me.etqRespApellListado.AutoSize = True
        Me.etqRespApellListado.Location = New System.Drawing.Point(317, 78)
        Me.etqRespApellListado.Name = "etqRespApellListado"
        Me.etqRespApellListado.Size = New System.Drawing.Size(0, 17)
        Me.etqRespApellListado.TabIndex = 18
        '
        'etqRespFechaIListado
        '
        Me.etqRespFechaIListado.AutoSize = True
        Me.etqRespFechaIListado.Location = New System.Drawing.Point(481, 78)
        Me.etqRespFechaIListado.Name = "etqRespFechaIListado"
        Me.etqRespFechaIListado.Size = New System.Drawing.Size(0, 17)
        Me.etqRespFechaIListado.TabIndex = 19
        '
        'etqRespSueldoListado
        '
        Me.etqRespSueldoListado.AutoSize = True
        Me.etqRespSueldoListado.Location = New System.Drawing.Point(724, 78)
        Me.etqRespSueldoListado.Name = "etqRespSueldoListado"
        Me.etqRespSueldoListado.Size = New System.Drawing.Size(0, 17)
        Me.etqRespSueldoListado.TabIndex = 20
        '
        'DisListadoClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(859, 386)
        Me.Controls.Add(Me.etqRespSueldoListado)
        Me.Controls.Add(Me.etqRespFechaIListado)
        Me.Controls.Add(Me.etqRespApellListado)
        Me.Controls.Add(Me.etqRespNomListado)
        Me.Controls.Add(Me.etqRespCodListado)
        Me.Controls.Add(Me.etqSueldoListado)
        Me.Controls.Add(Me.etqFechaIListado)
        Me.Controls.Add(Me.etqApellidoListado)
        Me.Controls.Add(Me.etqNombreListado)
        Me.Controls.Add(Me.etqCodigoListado)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "DisListadoClientes"
        Me.Text = "DisListadoClientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents etqCodigoListado As Label
    Friend WithEvents etqNombreListado As Label
    Friend WithEvents etqApellidoListado As Label
    Friend WithEvents etqFechaIListado As Label
    Friend WithEvents etqSueldoListado As Label
    Friend WithEvents etqRespCodListado As Label
    Friend WithEvents etqRespNomListado As Label
    Friend WithEvents etqRespApellListado As Label
    Friend WithEvents etqRespFechaIListado As Label
    Friend WithEvents etqRespSueldoListado As Label
End Class
