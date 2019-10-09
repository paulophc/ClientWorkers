<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
      Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Me.dgv = New System.Windows.Forms.DataGridView()
      Me.ListarButton = New System.Windows.Forms.Button()
      Me.PesquisarButton = New System.Windows.Forms.Button()
      Me.IncluirButton = New System.Windows.Forms.Button()
      Me.AlterarButton = New System.Windows.Forms.Button()
      Me.ExcluirButton = New System.Windows.Forms.Button()
      Me.UrlLabel = New System.Windows.Forms.Label()
      Me.UrlTextBox = New System.Windows.Forms.TextBox()
      Me.SairButton = New System.Windows.Forms.Button()
      CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'dgv
      '
      Me.dgv.AllowUserToAddRows = False
      Me.dgv.AllowUserToDeleteRows = False
      Me.dgv.AllowUserToOrderColumns = True
      Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
      DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
      DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
      DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
      DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
      DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
      DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
      Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
      Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.dgv.Location = New System.Drawing.Point(28, 79)
      Me.dgv.MultiSelect = False
      Me.dgv.Name = "dgv"
      Me.dgv.ReadOnly = True
      Me.dgv.RowTemplate.Height = 28
      Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
      Me.dgv.Size = New System.Drawing.Size(945, 315)
      Me.dgv.TabIndex = 8
      '
      'ListarButton
      '
      Me.ListarButton.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.ListarButton.Location = New System.Drawing.Point(28, 413)
      Me.ListarButton.Name = "ListarButton"
      Me.ListarButton.Size = New System.Drawing.Size(120, 48)
      Me.ListarButton.TabIndex = 2
      Me.ListarButton.Text = "&Listar Todos"
      Me.ListarButton.UseVisualStyleBackColor = True
      '
      'PesquisarButton
      '
      Me.PesquisarButton.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.PesquisarButton.Location = New System.Drawing.Point(186, 413)
      Me.PesquisarButton.Name = "PesquisarButton"
      Me.PesquisarButton.Size = New System.Drawing.Size(120, 48)
      Me.PesquisarButton.TabIndex = 3
      Me.PesquisarButton.Text = "&Pesquisar"
      Me.PesquisarButton.UseVisualStyleBackColor = True
      '
      'IncluirButton
      '
      Me.IncluirButton.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.IncluirButton.Location = New System.Drawing.Point(349, 413)
      Me.IncluirButton.Name = "IncluirButton"
      Me.IncluirButton.Size = New System.Drawing.Size(120, 48)
      Me.IncluirButton.TabIndex = 4
      Me.IncluirButton.Text = "&Incluir"
      Me.IncluirButton.UseVisualStyleBackColor = True
      '
      'AlterarButton
      '
      Me.AlterarButton.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.AlterarButton.Location = New System.Drawing.Point(518, 413)
      Me.AlterarButton.Name = "AlterarButton"
      Me.AlterarButton.Size = New System.Drawing.Size(120, 48)
      Me.AlterarButton.TabIndex = 5
      Me.AlterarButton.Text = "&Alterar"
      Me.AlterarButton.UseVisualStyleBackColor = True
      '
      'ExcluirButton
      '
      Me.ExcluirButton.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.ExcluirButton.Location = New System.Drawing.Point(688, 413)
      Me.ExcluirButton.Name = "ExcluirButton"
      Me.ExcluirButton.Size = New System.Drawing.Size(120, 48)
      Me.ExcluirButton.TabIndex = 6
      Me.ExcluirButton.Text = "&Excluir"
      Me.ExcluirButton.UseVisualStyleBackColor = True
      '
      'UrlLabel
      '
      Me.UrlLabel.AutoSize = True
      Me.UrlLabel.Location = New System.Drawing.Point(25, 37)
      Me.UrlLabel.Name = "UrlLabel"
      Me.UrlLabel.Size = New System.Drawing.Size(30, 18)
      Me.UrlLabel.TabIndex = 6
      Me.UrlLabel.Text = "Url:"
      '
      'UrlTextBox
      '
      Me.UrlTextBox.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.UrlTextBox.Location = New System.Drawing.Point(75, 34)
      Me.UrlTextBox.Name = "UrlTextBox"
      Me.UrlTextBox.Size = New System.Drawing.Size(898, 26)
      Me.UrlTextBox.TabIndex = 1
      '
      'SairButton
      '
      Me.SairButton.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.SairButton.Location = New System.Drawing.Point(853, 413)
      Me.SairButton.Name = "SairButton"
      Me.SairButton.Size = New System.Drawing.Size(120, 48)
      Me.SairButton.TabIndex = 7
      Me.SairButton.Text = "&Sair"
      Me.SairButton.UseVisualStyleBackColor = True
      '
      'Form1
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
      Me.ClientSize = New System.Drawing.Size(1008, 501)
      Me.Controls.Add(Me.SairButton)
      Me.Controls.Add(Me.UrlTextBox)
      Me.Controls.Add(Me.UrlLabel)
      Me.Controls.Add(Me.ExcluirButton)
      Me.Controls.Add(Me.AlterarButton)
      Me.Controls.Add(Me.IncluirButton)
      Me.Controls.Add(Me.PesquisarButton)
      Me.Controls.Add(Me.ListarButton)
      Me.Controls.Add(Me.dgv)
      Me.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Name = "Form1"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Workers"
      CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents dgv As DataGridView
   Friend WithEvents ListarButton As Button
   Friend WithEvents PesquisarButton As Button
   Friend WithEvents IncluirButton As Button
   Friend WithEvents AlterarButton As Button
   Friend WithEvents ExcluirButton As Button
   Friend WithEvents UrlLabel As Label
   Friend WithEvents UrlTextBox As TextBox
   Friend WithEvents SairButton As Button
End Class
