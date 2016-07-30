Public Class ConsultaCep

    Dim ht As Hashtable
    Dim ds As DataSet
    Dim _resultado As String

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        'limpa o conteudo das textboxs
        limpatxts()

        'acionado a função para buscar o cep, passando o cep como parametro "txtCep"
        BuscaCep(txtCep.Text)

        'tratamos o resultado
        If _resultado = Nothing Then
            Exit Sub
        ElseIf _resultado = 1 Then
            txtUF.Text = ht.Values(3)
            txtCidade.Text = ht.Values(2)
            txtBairro.Text = ht.Values(5)
            txtTipologradouro.Text = ht.Values(1)
            txtLogradouro.Text = ht.Values(0)
        ElseIf _resultado = 2 Then
            txtUF.Text = ht.Values(1)
            txtCidade.Text = ht.Values(0)
        Else
            MessageBox.Show("Cep não encontrado")
        End If

    End Sub

    Function BuscaCep(ByVal cep As String) As Hashtable
        Try
            ds = New DataSet()
            ds.ReadXml("http://cep.republicavirtual.com.br/web_cep.php?cep=" + cep.Replace("-", "").Trim() + "&formato=xml")
            If Not IsNothing(ds) Then
                If (ds.Tables(0).Rows.Count > 0) Then
                    _resultado = ds.Tables(0).Rows(0).Item("resultado").ToString()
                    ht = New Hashtable
                    Select Case _resultado
                        Case "1"
                            ht.Add("UF", ds.Tables(0).Rows(0).Item("uf").ToString().Trim())
                            ht.Add("cidade", ds.Tables(0).Rows(0).Item("cidade").ToString().Trim())
                            ht.Add("bairro", ds.Tables(0).Rows(0).Item("bairro").ToString().Trim())
                            ht.Add("tipologradouro", ds.Tables(0).Rows(0).Item("tipo_logradouro").ToString().Trim())
                            ht.Add("logradouro", ds.Tables(0).Rows(0).Item("logradouro").ToString().Trim())
                            ht.Add("tipo", 1)
                        Case "2"
                            ht.Add("UF", ds.Tables(0).Rows(0).Item("uf").ToString().Trim())
                            ht.Add("cidade", ds.Tables(0).Rows(0).Item("cidade").ToString().Trim())
                            ht.Add("tipo", 2)
                        Case Else
                            ht.Add("tipo", 0)
                    End Select

                End If
            End If
            Return ht
        Catch ex As Exception
            MessageBox.Show("Falha ao Buscar o Cep:  " & ex.Message)
            Return Nothing
        End Try
    End Function

    Private Sub limpatxts()
        txtUF.Clear()
        txtCidade.Clear()
        txtTipologradouro.Clear()
        txtLogradouro.Clear()
        txtBairro.Clear()
    End Sub
End Class
