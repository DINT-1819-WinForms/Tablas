<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.NumerosComboBox = New System.Windows.Forms.ComboBox()
        Me.TablaListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'NumerosComboBox
        '
        Me.NumerosComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NumerosComboBox.FormattingEnabled = True
        Me.NumerosComboBox.Location = New System.Drawing.Point(39, 17)
        Me.NumerosComboBox.Name = "NumerosComboBox"
        Me.NumerosComboBox.Size = New System.Drawing.Size(135, 21)
        Me.NumerosComboBox.TabIndex = 0
        '
        'TablaListBox
        '
        Me.TablaListBox.FormattingEnabled = True
        Me.TablaListBox.Location = New System.Drawing.Point(40, 44)
        Me.TablaListBox.Name = "TablaListBox"
        Me.TablaListBox.Size = New System.Drawing.Size(134, 147)
        Me.TablaListBox.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(205, 216)
        Me.Controls.Add(Me.TablaListBox)
        Me.Controls.Add(Me.NumerosComboBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Tablas"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NumerosComboBox As ComboBox
    Friend WithEvents TablaListBox As ListBox
End Class
