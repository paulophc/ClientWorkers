Public Class Form2

#Region " ShowDialog "
   Dim tipo As String
   Dim worker As Workers
   Dim ok As Boolean

   Public Overloads Sub ShowDialog(ByVal vtipo As String, ByRef vworker As Workers, ByRef vok As Boolean)
      tipo = vtipo
      worker = vworker
      ok = vok
      Me.ShowDialog()
      vworker = worker
      vok = ok
   End Sub

#End Region

#Region " Form2_Load - Inicializa Texboxes e Buttons "

   Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Dim str_send = vbTab

      With worker
         IdTextBox.Text = If(.Id > 0, .Id.ToString, String.Empty)
         NomeTextBox.Text = .Nome
         EmailTextBox.Text = .Email
         CargoTextBox.Text = .Cargo
         SalarioTextBox.Text = .Salario.ToString("N2")
      End With

      With Data_ContratacaoDateTimePicker
         If worker.Data_Contratacao >= .MinDate AndAlso worker.Data_Contratacao <= .MaxDate Then
            .Value = worker.Data_Contratacao
         End If
      End With

      IdTextBox.ReadOnly = True

      If tipo = "I" Then 'Incluir
         EnviarButton.Text = "&Incluir"
      ElseIf tipo = "A" Then 'Alterar
         EnviarButton.Text = "Alterar"
      ElseIf tipo = "E" Then 'Excluir
         NomeTextBox.ReadOnly = True
         EmailTextBox.ReadOnly = True
         CargoTextBox.ReadOnly = True
         SalarioTextBox.ReadOnly = True
         Data_ContratacaoDateTimePicker.Enabled = False
         EnviarButton.Text = "Exlcuir"
         Me.EnviarButton.Focus()
         str_send += StrDup(5, vbTab)
      End If

      My.Computer.Keyboard.SendKeys(str_send)
   End Sub

#End Region

#Region " ...Buttons... "

   Private Sub EnviarButton_Click(sender As Object, e As EventArgs) Handles EnviarButton.Click
      If tipo = "I" OrElse tipo = "A" Then
         If Consiste_Campo_Vazio(NomeTextBox.Text, "Nome") AndAlso Consiste_Campo_Vazio(CargoTextBox.Text, "Cargo") AndAlso Consiste_Email(EmailTextBox.Text) AndAlso Consiste_Salario(SalarioTextBox.Text) AndAlso Consiste_DataContracao(Data_ContratacaoDateTimePicker.Value) Then
            With worker
               .Nome = NomeTextBox.Text
               .Email = EmailTextBox.Text
               .Cargo = CargoTextBox.Text
               .Salario = SalarioTextBox.Text
               .Data_Contratacao = Data_ContratacaoDateTimePicker.Value.ToShortDateString
            End With

            ok = True
         End If
      Else 'E - Excluir
         ok = True
      End If

      If ok Then Me.Close()
   End Sub

   Private Sub RetornarButton_Click(sender As Object, e As EventArgs) Handles RetornarButton.Click
      Me.Close()
   End Sub

#End Region

#Region " SalarioTextBox_Validated - Formata o salario com a mascara numerica e com 2 decimais "

   Private Sub SalarioTextBox_Validated(sender As Object, e As EventArgs) Handles SalarioTextBox.Validated
      Dim value As Decimal

      If Decimal.TryParse(SalarioTextBox.Text, value) Then
         SalarioTextBox.Text = Format(value, "N2")
      End If
   End Sub

#End Region

#Region " Consiste_Email - Verifica se o email e' valido "

   Shared Function Consiste_Email(email As String) As Boolean
      Dim ok = True

      If Not String.IsNullOrWhiteSpace(email) Then
         Try
            Dim em = New Net.Mail.MailAddress(email)
         Catch ex As FormatException
            MessageBox.Show("Email inválido." & vbCrLf & ex.Message, "Dados Cadastrais", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ok = False
         End Try
      End If

      Return ok
   End Function

#End Region

#Region " Consiste_Salario - Verifica se o salario e' valido "

   Shared Function Consiste_Salario(salario As String) As Boolean
      Dim ok = True

      If Not String.IsNullOrWhiteSpace(salario) Then
         Dim result As Decimal
         If Decimal.TryParse(salario, result) Then
            If result < 998 OrElse result > 60000 Then
               ok = False
               MessageBox.Show("Salário deve ser preenchido com valor entre 998.00 e 60.000.", "Dados Cadastrais", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
         Else
            ok = False
            MessageBox.Show("Salário inválido.", "Dados Cadastrais", MessageBoxButtons.OK, MessageBoxIcon.Warning)
         End If
      Else
         MessageBox.Show("Salário requer preenchimento obrigatório.", "Dados Cadastrais", MessageBoxButtons.OK, MessageBoxIcon.Warning)
         ok = False
      End If

      Return ok
   End Function

#End Region

#Region " Consiste_Campo_Vazio - Verifica se o campo esta preenchido "

   Shared Function Consiste_Campo_Vazio(campo As String, nome_campo As String) As Boolean
      Dim ok = True

      If String.IsNullOrWhiteSpace(campo) Then
         MessageBox.Show(nome_campo & " requer preenchimento obrigatório.", "Dados Cadastrais", MessageBoxButtons.OK, MessageBoxIcon.Warning)
         ok = False
      End If

      Return ok
   End Function

#End Region

#Region " Consiste_DataContracao - Verifica se a data esta no intervalo correto "

   Private Function Consiste_DataContracao(data_contracao As Date) As Boolean
      Dim ok = True

      If data_contracao < CDate("01/01/2010") OrElse data_contracao > Now Then
         MessageBox.Show("Data de Data_Contratacao, fora do intervalo permitido.", "Dados Cadastrais", MessageBoxButtons.OK, MessageBoxIcon.Warning)
         ok = False
      End If

      Return ok
   End Function

#End Region

#Region " ...ProcessCmdKey - <Enter> - Muda o foco do TextBox ou ComboBox | Esc - encerra o programa "

   Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
      If keyData = Keys.Enter Then
         If Not TypeOf Me.ActiveControl Is Button AndAlso Not TypeOf Me.ActiveControl Is RichTextBox Then
            SelectNextControl(Me.ActiveControl, True, True, True, True)
            Return True
         End If
      ElseIf keyData = Keys.Escape Then
         Me.Close()
         Return True
      End If
      Return MyBase.ProcessCmdKey(msg, keyData)
   End Function

#End Region

End Class