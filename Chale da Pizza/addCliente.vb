Public Class addCliente


    Private Sub addCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ClientesDataSet11.clientes' table. You can move, or remove it, as needed.
        Me.ClientesTableAdapter1.Fill(Me.ClientesDataSet1.clientes)
        'TODO: This line of code loads data into the 'ClientesDataSet1.clientes' table. You can move, or remove it, as needed.
        Me.ClientesTableAdapter1.Fill(Me.ClientesDataSet1.clientes)

        Me.ClientesBindingSource1.AddNew()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If NomeClienteTextBox.Text <> "" And RuaTextBox.Text <> "" And BairroTextBox.Text <> "" Then

            MsgBox("Salvo com sucesso", MsgBoxStyle.Information, Title:="Salvo")

            Me.Validate()
            Me.ClientesBindingSource1.EndEdit()
            Me.TableAdapterManager1.UpdateAll(Me.ClientesDataSet1)

            Close()

        Else

            MsgBox("Informações obrigatórias ausentes. Por favor, verifique os dados", MsgBoxStyle.Information, Title:="Alerta!")

        End If

    End Sub

    Private Sub NomeClienteLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub QtdPedidoLabel_Click(sender As Object, e As EventArgs)

    End Sub
End Class