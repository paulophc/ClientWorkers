<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
   Inherits System.Windows.Forms.Form

   'Descartar substituições de formulário para limpar a lista de componentes.
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

   'Exigido pelo Windows Form Designer
   Private components As System.ComponentModel.IContainer

   'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
   'Pode ser modificado usando o Windows Form Designer.  
   'Não o modifique usando o editor de códigos.
   <System.Diagnostics.DebuggerStepThrough()>
   Private Sub InitializeComponent()
      Me.RetornarButton = New System.Windows.Forms.Button()
      Me.EnviarButton = New System.Windows.Forms.Button()
      Me.NomeTextBox = New System.Windows.Forms.TextBox()
      Me.NomeLabel = New System.Windows.Forms.Label()
      Me.SuspendLayout()
      '
      'RetornarButton
      '
      Me.RetornarButton.Location = New System.Drawing.Point(669, 81)
      Me.RetornarButton.Name = "RetornarButton"
      Me.RetornarButton.Size = New System.Drawing.Size(200, 48)
      Me.RetornarButton.TabIndex = 17
      Me.RetornarButton.Text = "&Retornar"
      Me.RetornarButton.UseVisualStyleBackColor = True
      '
      'EnviarButton
      '
      Me.EnviarButton.Location = New System.Drawing.Point(399, 81)
      Me.EnviarButton.Name = "EnviarButton"
      Me.EnviarButton.Size = New System.Drawing.Size(200, 48)
      Me.EnviarButton.TabIndex = 16
      Me.EnviarButton.Text = "&Enviar"
      Me.EnviarButton.UseVisualStyleBackColor = True
      '
      'NomeTextBox
      '
      Me.NomeTextBox.Location = New System.Drawing.Point(103, 29)
      Me.NomeTextBox.MaxLength = 100
      Me.NomeTextBox.Name = "NomeTextBox"
      Me.NomeTextBox.Size = New System.Drawing.Size(766, 25)
      Me.NomeTextBox.TabIndex = 15
      '
      'NomeLabel
      '
      Me.NomeLabel.AutoSize = True
      Me.NomeLabel.Location = New System.Drawing.Point(28, 32)
      Me.NomeLabel.Name = "NomeLabel"
      Me.NomeLabel.Size = New System.Drawing.Size(50, 18)
      Me.NomeLabel.TabIndex = 14
      Me.NomeLabel.Text = "Nome:"
      '
      'Form3
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(911, 156)
      Me.Controls.Add(Me.RetornarButton)
      Me.Controls.Add(Me.EnviarButton)
      Me.Controls.Add(Me.NomeTextBox)
      Me.Controls.Add(Me.NomeLabel)
      Me.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Margin = New System.Windows.Forms.Padding(4)
      Me.Name = "Form3"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Pesquisar (Filtrar Funcionários)"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents RetornarButton As Button
   Friend WithEvents EnviarButton As Button
   Friend WithEvents NomeTextBox As TextBox
   Friend WithEvents NomeLabel As Label
End Class
