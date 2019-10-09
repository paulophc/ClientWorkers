Public Class Form3

   Dim nome As String

#Region " ShowDialog "

   Public Overloads Sub ShowDialog(ByRef vnome As String)
      nome = vnome
      Me.ShowDialog()
      vnome = nome
   End Sub

#End Region

#Region " ...Buttons... "

   Private Sub EnviarButton_Click(sender As Object, e As EventArgs) Handles EnviarButton.Click
      If Not String.IsNullOrWhiteSpace(NomeTextBox.Text) Then
         nome = NomeTextBox.Text
         Me.Close()
      Else
         MessageBox.Show("Informar o nome ou apenas as iniciais do nome", Me.Text, MessageBoxButtons.OK)
      End If
   End Sub

   Private Sub RetornarButton_Click(sender As Object, e As EventArgs) Handles RetornarButton.Click
      Me.Close()
   End Sub

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