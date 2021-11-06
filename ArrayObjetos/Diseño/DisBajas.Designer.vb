<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DisBajas
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
        Me.cajaApellidoBaja = New System.Windows.Forms.TextBox()
        Me.cajaNombreBaja = New System.Windows.Forms.TextBox()
        Me.etqSueldoBaja = New System.Windows.Forms.Label()
        Me.etqFechaIBaja = New System.Windows.Forms.Label()
        Me.etqApellidoBaja = New System.Windows.Forms.Label()
        Me.etqNombreBaja = New System.Windows.Forms.Label()
        Me.etqCodigoBaja = New System.Windows.Forms.Label()
        Me.cajaFechaIBaja = New System.Windows.Forms.TextBox()
        Me.btnborrarBaja = New System.Windows.Forms.Button()
        Me.btnBuscarBaja = New System.Windows.Forms.Button()
        Me.grupoDatosBaja = New System.Windows.Forms.GroupBox()
        Me.cajaSueldoBaja = New System.Windows.Forms.TextBox()
        Me.etqRespBaja = New System.Windows.Forms.Label()
        Me.cajaCodBaja = New System.Windows.Forms.TextBox()
        Me.grupoDatosBaja.SuspendLayout()
        Me.SuspendLayout()
        '
        'cajaApellidoBaja
        '
        Me.cajaApellidoBaja.Location = New System.Drawing.Point(119, 55)
        Me.cajaApellidoBaja.Margin = New System.Windows.Forms.Padding(2)
        Me.cajaApellidoBaja.Name = "cajaApellidoBaja"
        Me.cajaApellidoBaja.Size = New System.Drawing.Size(275, 20)
        Me.cajaApellidoBaja.TabIndex = 17
        '
        'cajaNombreBaja
        '
        Me.cajaNombreBaja.Location = New System.Drawing.Point(119, 32)
        Me.cajaNombreBaja.Margin = New System.Windows.Forms.Padding(2)
        Me.cajaNombreBaja.Name = "cajaNombreBaja"
        Me.cajaNombreBaja.Size = New System.Drawing.Size(275, 20)
        Me.cajaNombreBaja.TabIndex = 16
        '
        'etqSueldoBaja
        '
        Me.etqSueldoBaja.AutoSize = True
        Me.etqSueldoBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etqSueldoBaja.Location = New System.Drawing.Point(4, 99)
        Me.etqSueldoBaja.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.etqSueldoBaja.Name = "etqSueldoBaja"
        Me.etqSueldoBaja.Size = New System.Drawing.Size(70, 24)
        Me.etqSueldoBaja.TabIndex = 14
        Me.etqSueldoBaja.Text = "Sueldo"
        '
        'etqFechaIBaja
        '
        Me.etqFechaIBaja.AutoSize = True
        Me.etqFechaIBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etqFechaIBaja.Location = New System.Drawing.Point(4, 76)
        Me.etqFechaIBaja.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.etqFechaIBaja.Name = "etqFechaIBaja"
        Me.etqFechaIBaja.Size = New System.Drawing.Size(159, 24)
        Me.etqFechaIBaja.TabIndex = 13
        Me.etqFechaIBaja.Text = "Fecha de ingreso"
        '
        'etqApellidoBaja
        '
        Me.etqApellidoBaja.AutoSize = True
        Me.etqApellidoBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etqApellidoBaja.Location = New System.Drawing.Point(4, 50)
        Me.etqApellidoBaja.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.etqApellidoBaja.Name = "etqApellidoBaja"
        Me.etqApellidoBaja.Size = New System.Drawing.Size(88, 24)
        Me.etqApellidoBaja.TabIndex = 12
        Me.etqApellidoBaja.Text = "Apellidos"
        '
        'etqNombreBaja
        '
        Me.etqNombreBaja.AutoSize = True
        Me.etqNombreBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etqNombreBaja.Location = New System.Drawing.Point(4, 26)
        Me.etqNombreBaja.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.etqNombreBaja.Name = "etqNombreBaja"
        Me.etqNombreBaja.Size = New System.Drawing.Size(79, 24)
        Me.etqNombreBaja.TabIndex = 11
        Me.etqNombreBaja.Text = "Nombre"
        '
        'etqCodigoBaja
        '
        Me.etqCodigoBaja.AutoSize = True
        Me.etqCodigoBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etqCodigoBaja.Location = New System.Drawing.Point(46, 25)
        Me.etqCodigoBaja.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.etqCodigoBaja.Name = "etqCodigoBaja"
        Me.etqCodigoBaja.Size = New System.Drawing.Size(71, 24)
        Me.etqCodigoBaja.TabIndex = 10
        Me.etqCodigoBaja.Text = "Codigo"
        '
        'cajaFechaIBaja
        '
        Me.cajaFechaIBaja.Location = New System.Drawing.Point(178, 81)
        Me.cajaFechaIBaja.Margin = New System.Windows.Forms.Padding(2)
        Me.cajaFechaIBaja.Name = "cajaFechaIBaja"
        Me.cajaFechaIBaja.Size = New System.Drawing.Size(216, 20)
        Me.cajaFechaIBaja.TabIndex = 20
        '
        'btnborrarBaja
        '
        Me.btnborrarBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnborrarBaja.Location = New System.Drawing.Point(458, 170)
        Me.btnborrarBaja.Margin = New System.Windows.Forms.Padding(2)
        Me.btnborrarBaja.Name = "btnborrarBaja"
        Me.btnborrarBaja.Size = New System.Drawing.Size(87, 41)
        Me.btnborrarBaja.TabIndex = 21
        Me.btnborrarBaja.Text = "Borrar"
        Me.btnborrarBaja.UseVisualStyleBackColor = True
        '
        'btnBuscarBaja
        '
        Me.btnBuscarBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarBaja.Location = New System.Drawing.Point(266, 28)
        Me.btnBuscarBaja.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscarBaja.Name = "btnBuscarBaja"
        Me.btnBuscarBaja.Size = New System.Drawing.Size(73, 24)
        Me.btnBuscarBaja.TabIndex = 22
        Me.btnBuscarBaja.Text = "Buscar"
        Me.btnBuscarBaja.UseVisualStyleBackColor = True
        '
        'grupoDatosBaja
        '
        Me.grupoDatosBaja.BackColor = System.Drawing.SystemColors.Highlight
        Me.grupoDatosBaja.Controls.Add(Me.cajaSueldoBaja)
        Me.grupoDatosBaja.Controls.Add(Me.etqNombreBaja)
        Me.grupoDatosBaja.Controls.Add(Me.etqApellidoBaja)
        Me.grupoDatosBaja.Controls.Add(Me.etqFechaIBaja)
        Me.grupoDatosBaja.Controls.Add(Me.cajaFechaIBaja)
        Me.grupoDatosBaja.Controls.Add(Me.etqSueldoBaja)
        Me.grupoDatosBaja.Controls.Add(Me.cajaNombreBaja)
        Me.grupoDatosBaja.Controls.Add(Me.cajaApellidoBaja)
        Me.grupoDatosBaja.Location = New System.Drawing.Point(50, 71)
        Me.grupoDatosBaja.Margin = New System.Windows.Forms.Padding(2)
        Me.grupoDatosBaja.Name = "grupoDatosBaja"
        Me.grupoDatosBaja.Padding = New System.Windows.Forms.Padding(2)
        Me.grupoDatosBaja.Size = New System.Drawing.Size(400, 139)
        Me.grupoDatosBaja.TabIndex = 23
        Me.grupoDatosBaja.TabStop = False
        '
        'cajaSueldoBaja
        '
        Me.cajaSueldoBaja.Location = New System.Drawing.Point(119, 105)
        Me.cajaSueldoBaja.Margin = New System.Windows.Forms.Padding(2)
        Me.cajaSueldoBaja.Name = "cajaSueldoBaja"
        Me.cajaSueldoBaja.Size = New System.Drawing.Size(72, 20)
        Me.cajaSueldoBaja.TabIndex = 25
        '
        'etqRespBaja
        '
        Me.etqRespBaja.AutoSize = True
        Me.etqRespBaja.Location = New System.Drawing.Point(58, 241)
        Me.etqRespBaja.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.etqRespBaja.Name = "etqRespBaja"
        Me.etqRespBaja.Size = New System.Drawing.Size(0, 13)
        Me.etqRespBaja.TabIndex = 24
        '
        'cajaCodBaja
        '
        Me.cajaCodBaja.Location = New System.Drawing.Point(166, 31)
        Me.cajaCodBaja.Margin = New System.Windows.Forms.Padding(2)
        Me.cajaCodBaja.Name = "cajaCodBaja"
        Me.cajaCodBaja.Size = New System.Drawing.Size(76, 20)
        Me.cajaCodBaja.TabIndex = 25
        '
        'DisBajas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(554, 285)
        Me.Controls.Add(Me.cajaCodBaja)
        Me.Controls.Add(Me.etqRespBaja)
        Me.Controls.Add(Me.grupoDatosBaja)
        Me.Controls.Add(Me.btnBuscarBaja)
        Me.Controls.Add(Me.btnborrarBaja)
        Me.Controls.Add(Me.etqCodigoBaja)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "DisBajas"
        Me.Text = "DisBajas"
        Me.grupoDatosBaja.ResumeLayout(False)
        Me.grupoDatosBaja.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cajaApellidoBaja As TextBox
    Friend WithEvents cajaNombreBaja As TextBox
    Friend WithEvents etqSueldoBaja As Label
    Friend WithEvents etqFechaIBaja As Label
    Friend WithEvents etqApellidoBaja As Label
    Friend WithEvents etqNombreBaja As Label
    Friend WithEvents etqCodigoBaja As Label
    Friend WithEvents cajaFechaIBaja As TextBox
    Friend WithEvents btnborrarBaja As Button
    Friend WithEvents btnBuscarBaja As Button
    Friend WithEvents grupoDatosBaja As GroupBox
    Friend WithEvents etqRespBaja As Label
    Friend WithEvents cajaSueldoBaja As TextBox
    Friend WithEvents cajaCodBaja As TextBox
End Class
