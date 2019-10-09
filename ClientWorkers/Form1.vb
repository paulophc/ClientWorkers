Imports System.Net.Http
Imports Newtonsoft.Json

Public Class Form1
   Dim lWorkers As New List(Of Workers)
   Dim uri As String = "http://localhost:7607/api/Workers"
   Dim nome As String

   'variaveis relacionadas ao dgv
   Dim oldColumn As DataGridViewColumn
   Dim dSort As New Dictionary(Of String, SortOrder)

#Region " Form1_Load - checa a url e se Ok, chama Get_Workers "

   Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      UrlTextBox.Text = uri
      If Not String.IsNullOrWhiteSpace(uri) AndAlso isUrlValid(uri) Then Get_Workers(Nothing)
   End Sub

#End Region

#Region " Buttons "

   Private Sub ListarButton_Click(sender As Object, e As EventArgs) Handles ListarButton.Click
      Get_Workers(Nothing)
   End Sub

   Private Sub PesquisarButton_Click(sender As Object, e As EventArgs) Handles PesquisarButton.Click
      Dim PesquisarForm As New Form3

      nome = Nothing
      PesquisarForm.ShowDialog(nome)
      If nome IsNot Nothing Then Get_Workers(nome)
   End Sub

   Private Sub IncluirButton_Click(sender As Object, e As EventArgs) Handles IncluirButton.Click
      Call_Form3("I")
   End Sub

   Private Sub AlterarButton_Click(sender As Object, e As EventArgs) Handles AlterarButton.Click
      Call_Form3("A")
   End Sub

   Private Sub ExcluirButton_Click(sender As Object, e As EventArgs) Handles ExcluirButton.Click
      Call_Form3("E")
   End Sub

   Private Sub SairButton_Click(sender As Object, e As EventArgs) Handles SairButton.Click
      Me.Close()
   End Sub

#End Region

#Region " UrlTextBox_Validated - verifica se a url e' valida, se for valida, entao uri = UrlTextBox.Text e chama Get_Workers "

   Private Sub UrlTextBox_Validated(sender As Object, e As EventArgs) Handles UrlTextBox.Validated
      If isUrlValid(UrlTextBox.Text) Then
         uri = UrlTextBox.Text
      Else
         MessageBox.Show("Não é possível acessar este site", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
      End If
   End Sub

#End Region

#Region " Call_Form3 - Efetua a chamada para o Form3 conforme os parametros de Inclusao, Alteracao e Exclusao "

   Private Sub Call_Form3(tipo As String) 'tipo = "I" - Incluir, "A" - Alterar ou "E" - Excluir
      Dim InsUptForm As New Form2
      Dim worker As New Workers
      Dim ok = False
      Dim chamar = True

      If tipo = "A" OrElse tipo = "E" Then 'Alteracao ou Exclusao
         With dgv.CurrentRow
            If dgv.CurrentRow IsNot Nothing AndAlso .Index >= 0 Then
               worker.Id = .Cells(0).Value
               worker.Nome = .Cells(1).Value
               worker.Email = .Cells(2).Value
               worker.Cargo = .Cells(3).Value
               worker.Salario = .Cells(4).Value
               worker.Data_Contratacao = .Cells(5).Value
            Else
               chamar = False
            End If
         End With
      End If

      If chamar Then
         InsUptForm.ShowDialog(tipo, worker, ok)

         If ok Then
            If tipo = "I" Then
               Post_Worker(worker)
            ElseIf tipo = "A" Then
               Put_Worker(worker)
            ElseIf tipo = "E" Then
               Delete_Worker(worker)
            End If
         End If
      End If
   End Sub

#End Region

#Region " ...Get_Workers, Post_Worker, Put_Worker, Delete_Worker... "

#Region " Get_Workers - Obtem a lista de Funcionários do WebServer "

   Private Async Sub Get_Workers(nome As String)
      Dim client = New HttpClient
      Dim response As HttpResponseMessage
      Dim vuri = uri & If(nome IsNot Nothing, "?nome=" & nome, Nothing)

      Try
         response = Await client.GetAsync(vuri)
         If response.IsSuccessStatusCode Then
            Dim workersJsonString = response.Content.ReadAsStringAsync

            lWorkers = JsonConvert.DeserializeObject(Of Workers())(Await workersJsonString).ToList
            dgv.DataSource = lWorkers
            Formata_dgv()
         Else
            MessageBox.Show("Falha detectada ao listar Funcionários" & vbCrLf & "Codigo de resposta: " & response.StatusCode)
         End If
      Catch ex As Exception
         MessageBox.Show("Falha detectada ao listar Funcionários" & vbCrLf & ex.Message)
      End Try
   End Sub

#End Region

#Region " Post_Worker - Efetua a inclusao do Funcionário enviando os dados com metodo POST para o WebServer "

   Private Async Sub Post_Worker(worker As Workers)
      Dim client = New HttpClient
      Dim response As HttpResponseMessage

      Try
         response = Await client.PostAsync(uri, Get_worker_formContent(worker))
         If response.IsSuccessStatusCode Then
            Dim responseBody = Await response.Content.ReadAsStringAsync

            If String.IsNullOrWhiteSpace(responseBody) OrElse responseBody.Equals("null") Then
               Get_Workers(worker.Nome)
            Else
               MessageBox.Show("Falha detectada ao incluir Funcionário." & vbCrLf & responseBody)
            End If
         Else
            MessageBox.Show("Falha detectada ao incluir Funcionário." & vbCrLf & "Codigo de resposta: " & response.StatusCode)
         End If
      Catch ex As Exception
         MessageBox.Show("Falha detectada ao incluir Funcionário." & vbCrLf & ex.Message)
      End Try
   End Sub

#End Region

#Region " Put_Worker - Efetua a alteracao do Funcionário enviando os dados com metodo Put para o WebServer "

   Private Async Sub Put_Worker(worker As Workers)
      Dim client = New HttpClient
      Dim response As HttpResponseMessage

      Try
         response = Await client.PutAsync(uri, Get_worker_formContent(worker))
         If response.IsSuccessStatusCode Then
            Dim responseBody = Await response.Content.ReadAsStringAsync

            If String.IsNullOrWhiteSpace(responseBody) OrElse responseBody.Equals("null") Then
               Get_Workers(worker.Nome)
            Else
               MessageBox.Show("Falha detectada ao alterar Funcionário." & vbCrLf & responseBody)
            End If
         Else
            MessageBox.Show("Falha detectada ao alterar Funcionário." & vbCrLf & "Codigo de resposta: " & response.StatusCode)
         End If
      Catch ex As Exception
         MessageBox.Show("Falha detectada ao alterar Funcionário." & vbCrLf & ex.Message)
      End Try
   End Sub

#End Region

#Region " Delete_Worker - Efetua a exclusao do Funcionário enviando os dados com metodo DELETE para o WebServer "

   Private Async Sub Delete_Worker(worker As Workers)
      Dim client = New HttpClient
      Dim response As HttpResponseMessage

      Try
         client.BaseAddress = New Uri(uri)
         response = Await client.DeleteAsync(uri & "/" & worker.Id)
         If response.IsSuccessStatusCode Then
            Dim responseBody = Await response.Content.ReadAsStringAsync

            If String.IsNullOrWhiteSpace(responseBody) OrElse responseBody.Equals("null") Then
               Get_Workers(Nothing)
            Else
               MessageBox.Show("Falha detectada ao excluir Funcionário." & vbCrLf & responseBody)
            End If
         Else
            MessageBox.Show("Falha detectada ao excluir Funcionário." & vbCrLf & "Codigo de resposta: " & response.StatusCode)
         End If
      Catch ex As Exception
         MessageBox.Show("Falha detectada ao excluir Funcionário." & vbCrLf & ex.Message)
      End Try
   End Sub

#End Region

#End Region

#Region " Get_worker_formContent - Retorna formurlEncodedContent com as informacoes da row worker "

   Function Get_worker_formContent(worker As Workers) As FormUrlEncodedContent
      Dim dKeyValues As New Dictionary(Of String, String)
      Dim formDataContent As FormUrlEncodedContent

      For Each info In worker.GetType().GetProperties()
         dKeyValues.Add(info.Name, worker.GetType.GetProperty(info.Name).GetValue(worker))
      Next

      formDataContent = New FormUrlEncodedContent(dKeyValues.AsEnumerable)

      Return formDataContent
   End Function

#End Region

#Region " Formata_dgv - Formata o alinhamento e o formato dos dados de algumas colunas do dgv "

   Private Sub Formata_dgv()
      If dgv.Rows.Count > 0 Then
         With dgv.Columns(0).DefaultCellStyle 'Id
            .Alignment = DataGridViewContentAlignment.MiddleRight
            .Format = "00000"
         End With
         With dgv.Columns(4).DefaultCellStyle 'Salario
            .Alignment = DataGridViewContentAlignment.MiddleRight
            .Format = "N2"
         End With
         dgv.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter 'Data de Contratacao
      End If
   End Sub

#End Region

#Region " dgv_ColumnHeaderMouseClick - Processa a classificação das colunas "

   Private Sub dgv_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv.ColumnHeaderMouseClick

      ' Check which column is selected, otherwise set NewColumn to Nothing.
      If e.ColumnIndex >= 0 Then
         Dim newColumn As DataGridViewColumn = dgv.Columns(e.ColumnIndex)
         Dim direction As ComponentModel.ListSortDirection
         Dim ascend = ComponentModel.ListSortDirection.Ascending
         Dim descend = ComponentModel.ListSortDirection.Descending
         Dim sort_order As SortOrder
         Dim lWorkers2 As New List(Of Workers)

         ' If oldColumn is null, then the DataGridView is not currently sorted.
         If oldColumn IsNot Nothing Then
            ' Sort the same column again, reversing the SortOrder.
            If oldColumn.DataPropertyName = newColumn.DataPropertyName Then
               direction = If(dSort(newColumn.DataPropertyName) = SortOrder.Ascending, descend, ascend)
            Else
               ' Sort a new column and remove the old SortGlyph.
               direction = ascend
               dgv.Columns(oldColumn.DataPropertyName).HeaderCell.SortGlyphDirection = SortOrder.None
               dSort(oldColumn.DataPropertyName) = SortOrder.None
            End If
         Else
            direction = ascend
         End If

         sort_order = If(direction = ascend, SortOrder.Ascending, SortOrder.Descending)

         If newColumn.Index = 0 Then 'Id
            lWorkers2 = If(direction = ascend, (From x In lWorkers Order By x.Id).ToList, (From x In lWorkers Order By x.Id Descending).ToList)
         ElseIf newColumn.Index = 1 Then 'Nome
            lWorkers2 = If(direction = ascend, (From x In lWorkers Order By x.Nome).ToList, (From x In lWorkers Order By x.Nome Descending).ToList)
         ElseIf newColumn.Index = 2 Then 'Email
            lWorkers2 = If(direction = ascend, (From x In lWorkers Order By x.Email).ToList, (From x In lWorkers Order By x.Email Descending).ToList)
         ElseIf newColumn.Index = 3 Then 'Cargo
            lWorkers2 = If(direction = ascend, (From x In lWorkers Order By x.Cargo).ToList, (From x In lWorkers Order By x.Cargo Descending).ToList)
         ElseIf newColumn.Index = 4 Then 'Salario
            lWorkers2 = If(direction = ascend, (From x In lWorkers Order By x.Salario).ToList, (From x In lWorkers Order By x.Salario Descending).ToList)
         ElseIf newColumn.Index = 5 Then 'Data_Contratacao
            lWorkers2 = If(direction = ascend, (From x In lWorkers Order By x.Data_Contratacao).ToList, (From x In lWorkers Order By x.Data_Contratacao Descending).ToList)
         End If

         dgv.DataSource = lWorkers2

         'Atualiza dSort
         If Not dSort.ContainsKey(newColumn.DataPropertyName) Then
            dSort.Add(newColumn.DataPropertyName, sort_order)
         Else
            dSort(newColumn.DataPropertyName) = sort_order
         End If

         'Seta SortGlyph
         dgv.Columns(newColumn.DataPropertyName).HeaderCell.SortGlyphDirection = sort_order

         oldColumn = newColumn

         dgv.CurrentCell = dgv(newColumn.Index, 0)
      End If
   End Sub

#End Region

#Region " isUrlValid - Verifica se a URL e' valida. (e' necessario http:// ou https://) "

   Public Function isUrlValid(url As String) As Boolean
      Dim ok As Boolean = True

      If Not String.IsNullOrWhiteSpace(url) Then
         If Not url.StartsWith("http") AndAlso Not url.StartsWith("//") Then url = "http://" & url

         Try
            Dim request As Net.WebRequest = Net.WebRequest.Create(url)
            Dim response As Net.WebResponse = request.GetResponse()
         Catch ex As Exception
            ok = False
         End Try
      Else
         MessageBox.Show("Url requer preenchimento obrigatório")
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
