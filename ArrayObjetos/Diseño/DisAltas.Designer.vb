<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DisAltas
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
        Me.etqCodigoAltas = New System.Windows.Forms.Label()
        Me.etqNombreAlta = New System.Windows.Forms.Label()
        Me.etqApellidoAlta = New System.Windows.Forms.Label()
        Me.etqFechaIAlta = New System.Windows.Forms.Label()
        Me.etqSueldoAlta = New System.Windows.Forms.Label()
        Me.cajaCodAlta = New System.Windows.Forms.TextBox()
        Me.cajaNombreAlta = New System.Windows.Forms.TextBox()
        Me.cajaApellidoAlta = New System.Windows.Forms.TextBox()
        Me.dateFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.btnGrabarAlta = New System.Windows.Forms.Button()
        Me.etqRespAlta = New System.Windows.Forms.Label()
        Me.cajaSueldoAlta = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'etqCodigoAltas
        '
        Me.etqCodigoAltas.AutoSize = True
        Me.etqCodigoAltas.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etqCodigoAltas.Location = New System.Drawing.Point(55, 34)
        Me.etqCodigoAltas.Name = "etqCodigoAltas"
        Me.etqCodigoAltas.Size = New System.Drawing.Size(92, 29)
        Me.etqCodigoAltas.TabIndex = 0
        Me.etqCodigoAltas.Text = "Codigo"
        '
        'etqNombreAlta
        '
        Me.etqNombreAlta.AutoSize = True
        Me.etqNombreAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etqNombreAlta.Location = New System.Drawing.Point(55, 74)
        Me.etqNombreAlta.Name = "etqNombreAlta"
        Me.etqNombreAlta.Size = New System.Drawing.Size(101, 29)
        Me.etqNombreAlta.TabIndex = 1
        Me.etqNombreAlta.Text = "Nombre"
        '
        'etqApellidoAlta
        '
        Me.etqApellidoAlta.AutoSize = True
        Me.etqApellidoAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etqApellidoAlta.Location = New System.Drawing.Point(55, 120)
        Me.etqApellidoAlta.Name = "etqApellidoAlta"
        Me.etqApellidoAlta.Size = New System.Drawing.Size(114, 29)
        Me.etqApellidoAlta.TabIndex = 2
        Me.etqApellidoAlta.Text = "Apellidos"
        '
        'etqFechaIAlta
        '
        Me.etqFechaIAlta.AutoSize = True
        Me.etqFechaIAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etqFechaIAlta.Location = New System.Drawing.Point(55, 169)
        Me.etqFechaIAlta.Name = "etqFechaIAlta"
        Me.etqFechaIAlta.Size = New System.Drawing.Size(201, 29)
        Me.etqFechaIAlta.TabIndex = 3
        Me.etqFechaIAlta.Text = "Fecha de ingreso"
        '
        'etqSueldoAlta
        '
        Me.etqSueldoAlta.AutoSize = True
        Me.etqSueldoAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etqSueldoAlta.Location = New System.Drawing.Point(55, 215)
        Me.etqSueldoAlta.Name = "etqSueldoAlta"
        Me.etqSueldoAlta.Size = New System.Drawing.Size(90, 29)
        Me.etqSueldoAlta.TabIndex = 4
        Me.etqSueldoAlta.Text = "Sueldo"
        '
        'cajaCodAlta
        '
        Me.cajaCodAlta.Location = New System.Drawing.Point(208, 41)
        Me.cajaCodAlta.Name = "cajaCodAlta"
        Me.cajaCodAlta.Size = New System.Drawing.Size(95, 22)
        Me.cajaCodAlta.TabIndex = 5
        '
        'cajaNombreAlta
        '
        Me.cajaNombreAlta.Location = New System.Drawing.Point(208, 81)
        Me.cajaNombreAlta.Name = "cajaNombreAlta"
        Me.cajaNombreAlta.Size = New System.Drawing.Size(365, 22)
        Me.cajaNombreAlta.TabIndex = 6
        '
        'cajaApellidoAlta
        '
        Me.cajaApellidoAlta.Location = New System.Drawing.Point(208, 127)
        Me.cajaApellidoAlta.Name = "cajaApellidoAlta"
        Me.cajaApellidoAlta.Size = New System.Drawing.Size(365, 22)
        Me.cajaApellidoAlta.TabIndex = 7
        '
        'dateFechaIngreso
        '
        Me.dateFechaIngreso.Location = New System.Drawing.Point(281, 174)
        Me.dateFechaIngreso.Name = "dateFechaIngreso"
        Me.dateFechaIngreso.Size = New System.Drawing.Size(292, 22)
        Me.dateFechaIngreso.TabIndex = 8
        '
        'btnGrabarAlta
        '
        Me.btnGrabarAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrabarAlta.Location = New System.Drawing.Point(574, 260)
        Me.btnGrabarAlta.Name = "btnGrabarAlta"
        Me.btnGrabarAlta.Size = New System.Drawing.Size(116, 51)
        Me.btnGrabarAlta.TabIndex = 10
        Me.btnGrabarAlta.Text = "Grabar"
        Me.btnGrabarAlta.UseVisualStyleBackColor = True
        '
        'etqRespAlta
        '
        Me.etqRespAlta.AutoSize = True
        Me.etqRespAlta.Location = New System.Drawing.Point(118, 294)
        Me.etqRespAlta.Name = "etqRespAlta"
        Me.etqRespAlta.Size = New System.Drawing.Size(0, 17)
        Me.etqRespAlta.TabIndex = 11
        '
        'cajaSueldoAlta
        '
        Me.cajaSueldoAlta.Location = New System.Drawing.Point(208, 222)
        Me.cajaSueldoAlta.Mask = "999999.99"
        Me.cajaSueldoAlta.Name = "cajaSueldoAlta"
        Me.cajaSueldoAlta.Size = New System.Drawing.Size(95, 22)
        Me.cajaSueldoAlta.TabIndex = 9
        '
        'DisAltas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(739, 352)
        Me.Controls.Add(Me.etqRespAlta)
        Me.Controls.Add(Me.btnGrabarAlta)
        Me.Controls.Add(Me.cajaSueldoAlta)
        Me.Controls.Add(Me.dateFechaIngreso)
        Me.Controls.Add(Me.cajaApellidoAlta)
        Me.Controls.Add(Me.cajaNombreAlta)
        Me.Controls.Add(Me.cajaCodAlta)
        Me.Controls.Add(Me.etqSueldoAlta)
        Me.Controls.Add(Me.etqFechaIAlta)
        Me.Controls.Add(Me.etqApellidoAlta)
        Me.Controls.Add(Me.etqNombreAlta)
        Me.Controls.Add(Me.etqCodigoAltas)
        Me.Name = "DisAltas"
        Me.Text = "DisAltas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents etqCodigoAltas As Label
    Friend WithEvents etqNombreAlta As Label
    Friend WithEvents etqApellidoAlta As Label
    Friend WithEvents etqFechaIAlta As Label
    Friend WithEvents etqSueldoAlta As Label
    Friend WithEvents cajaCodAlta As TextBox
    Friend WithEvents cajaNombreAlta As TextBox
    Friend WithEvents cajaApellidoAlta As TextBox
    Friend WithEvents dateFechaIngreso As DateTimePicker
    Friend WithEvents btnGrabarAlta As Button
    Friend WithEvents etqRespAlta As Label
    Friend WithEvents cajaSueldoAlta As MaskedTextBox
End Class
