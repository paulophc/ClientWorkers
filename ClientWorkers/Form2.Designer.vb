<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
   Inherits System.Windows.Forms.Form

   'Descartar substituições de formulário para limpar a lista de componentes.
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

   'Exigido pelo Windows Form Designer
   Private components As System.ComponentModel.IContainer

   'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
   'Pode ser modificado usando o Windows Form Designer.  
   'Não o modifique usando o editor de códigos.
   <System.Diagnostics.DebuggerStepThrough()> _
   Private Sub InitializeComponent()
      Me.IdLabel = New System.Windows.Forms.Label()
      Me.IdTextBox = New System.Windows.Forms.TextBox()
      Me.NomeTextBox = New System.Windows.Forms.TextBox()
      Me.NomeLabel = New System.Windows.Forms.Label()
      Me.EmailTextBox = New System.Windows.Forms.TextBox()
      Me.EmailLabel = New System.Windows.Forms.Label()
      Me.CargoTextBox = New System.Windows.Forms.TextBox()
      Me.CargoLabel = New System.Windows.Forms.Label()
      Me.SalarioTextBox = New System.Windows.Forms.TextBox()
      Me.SalarioLabel = New System.Windows.Forms.Label()
      Me.Data_ContratacaoLabel = New System.Windows.Forms.Label()
      Me.Data_ContratacaoDateTimePicker = New System.Windows.Forms.DateTimePicker()
      Me.EnviarButton = New System.Windows.Forms.Button()
      Me.RetornarButton = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'IdLabel
      '
      Me.IdLabel.AutoSize = True
      Me.IdLabel.Location = New System.Drawing.Point(118, 46)
      Me.IdLabel.Name = "IdLabel"
      Me.IdLabel.Size = New System.Drawing.Size(24, 18)
      Me.IdLabel.TabIndex = 0
      Me.IdLabel.Text = "Id:"
      '
      'IdTextBox
      '
      Me.IdTextBox.Location = New System.Drawing.Point(168, 43)
      Me.IdTextBox.MaxLength = 5
      Me.IdTextBox.Name = "IdTextBox"
      Me.IdTextBox.Size = New System.Drawing.Size(100, 25)
      Me.IdTextBox.TabIndex = 1
      '
      'NomeTextBox
      '
      Me.NomeTextBox.Location = New System.Drawing.Point(168, 96)
      Me.NomeTextBox.MaxLength = 100
      Me.NomeTextBox.Name = "NomeTextBox"
      Me.NomeTextBox.Size = New System.Drawing.Size(766, 25)
      Me.NomeTextBox.TabIndex = 3
      '
      'NomeLabel
      '
      Me.NomeLabel.AutoSize = True
      Me.NomeLabel.Location = New System.Drawing.Point(92, 99)
      Me.NomeLabel.Name = "NomeLabel"
      Me.NomeLabel.Size = New System.Drawing.Size(50, 18)
      Me.NomeLabel.TabIndex = 2
      Me.NomeLabel.Text = "Nome:"
      '
      'EmailTextBox
      '
      Me.EmailTextBox.Location = New System.Drawing.Point(168, 145)
      Me.EmailTextBox.MaxLength = 100
      Me.EmailTextBox.Name = "EmailTextBox"
      Me.EmailTextBox.Size = New System.Drawing.Size(766, 25)
      Me.EmailTextBox.TabIndex = 5
      '
      'EmailLabel
      '
      Me.EmailLabel.AutoSize = True
      Me.EmailLabel.Location = New System.Drawing.Point(96, 148)
      Me.EmailLabel.Name = "EmailLabel"
      Me.EmailLabel.Size = New System.Drawing.Size(46, 18)
      Me.EmailLabel.TabIndex = 4
      Me.EmailLabel.Text = "Email:"
      '
      'CargoTextBox
      '
      Me.CargoTextBox.Location = New System.Drawing.Point(166, 201)
      Me.CargoTextBox.MaxLength = 100
      Me.CargoTextBox.Name = "CargoTextBox"
      Me.CargoTextBox.Size = New System.Drawing.Size(768, 25)
      Me.CargoTextBox.TabIndex = 7
      '
      'CargoLabel
      '
      Me.CargoLabel.AutoSize = True
      Me.CargoLabel.Location = New System.Drawing.Point(95, 204)
      Me.CargoLabel.Name = "CargoLabel"
      Me.CargoLabel.Size = New System.Drawing.Size(47, 18)
      Me.CargoLabel.TabIndex = 6
      Me.CargoLabel.Text = "Cargo:"
      '
      'SalarioTextBox
      '
      Me.SalarioTextBox.Location = New System.Drawing.Point(168, 250)
      Me.SalarioTextBox.MaxLength = 9
      Me.SalarioTextBox.Name = "SalarioTextBox"
      Me.SalarioTextBox.Size = New System.Drawing.Size(161, 25)
      Me.SalarioTextBox.TabIndex = 9
      '
      'SalarioLabel
      '
      Me.SalarioLabel.AutoSize = True
      Me.SalarioLabel.Location = New System.Drawing.Point(88, 253)
      Me.SalarioLabel.Name = "SalarioLabel"
      Me.SalarioLabel.Size = New System.Drawing.Size(54, 18)
      Me.SalarioLabel.TabIndex = 8
      Me.SalarioLabel.Text = "Salario:"
      '
      'Data_ContratacaoLabel
      '
      Me.Data_ContratacaoLabel.AutoSize = True
      Me.Data_ContratacaoLabel.Location = New System.Drawing.Point(56, 309)
      Me.Data_ContratacaoLabel.Name = "Data_ContratacaoLabel"
      Me.Data_ContratacaoLabel.Size = New System.Drawing.Size(86, 18)
      Me.Data_ContratacaoLabel.TabIndex = 10
      Me.Data_ContratacaoLabel.Text = "Contratacao:"
      '
      'Data_ContratacaoDateTimePicker
      '
      Me.Data_ContratacaoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.Data_ContratacaoDateTimePicker.Location = New System.Drawing.Point(168, 304)
      Me.Data_ContratacaoDateTimePicker.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
      Me.Data_ContratacaoDateTimePicker.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
      Me.Data_ContratacaoDateTimePicker.Name = "Data_ContratacaoDateTimePicker"
      Me.Data_ContratacaoDateTimePicker.Size = New System.Drawing.Size(142, 25)
      Me.Data_ContratacaoDateTimePicker.TabIndex = 11
      '
      'EnviarButton
      '
      Me.EnviarButton.Location = New System.Drawing.Point(464, 352)
      Me.EnviarButton.Name = "EnviarButton"
      Me.EnviarButton.Size = New System.Drawing.Size(200, 48)
      Me.EnviarButton.TabIndex = 12
      Me.EnviarButton.Text = "&Enviar"
      Me.EnviarButton.UseVisualStyleBackColor = True
      '
      'RetornarButton
      '
      Me.RetornarButton.Location = New System.Drawing.Point(734, 352)
      Me.RetornarButton.Name = "RetornarButton"
      Me.RetornarButton.Size = New System.Drawing.Size(200, 48)
      Me.RetornarButton.TabIndex = 13
      Me.RetornarButton.Text = "&Retornar"
      Me.RetornarButton.UseVisualStyleBackColor = True
      '
      'Form2
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(978, 430)
      Me.Controls.Add(Me.RetornarButton)
      Me.Controls.Add(Me.EnviarButton)
      Me.Controls.Add(Me.Data_ContratacaoDateTimePicker)
      Me.Controls.Add(Me.Data_ContratacaoLabel)
      Me.Controls.Add(Me.SalarioTextBox)
      Me.Controls.Add(Me.SalarioLabel)
      Me.Controls.Add(Me.CargoTextBox)
      Me.Controls.Add(Me.CargoLabel)
      Me.Controls.Add(Me.EmailTextBox)
      Me.Controls.Add(Me.EmailLabel)
      Me.Controls.Add(Me.NomeTextBox)
      Me.Controls.Add(Me.NomeLabel)
      Me.Controls.Add(Me.IdTextBox)
      Me.Controls.Add(Me.IdLabel)
      Me.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Margin = New System.Windows.Forms.Padding(4)
      Me.Name = "Form2"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Dados Cadastrais"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents IdLabel As Label
   Friend WithEvents IdTextBox As TextBox
   Friend WithEvents NomeTextBox As TextBox
   Friend WithEvents NomeLabel As Label
   Friend WithEvents EmailTextBox As TextBox
   Friend WithEvents EmailLabel As Label
   Friend WithEvents CargoTextBox As TextBox
   Friend WithEvents CargoLabel As Label
   Friend WithEvents SalarioTextBox As TextBox
   Friend WithEvents SalarioLabel As Label
   Friend WithEvents Data_ContratacaoLabel As Label
   Friend WithEvents Data_ContratacaoDateTimePicker As DateTimePicker
   Friend WithEvents EnviarButton As Button
   Friend WithEvents RetornarButton As Button
End Class
