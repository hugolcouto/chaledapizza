Public Class buscCliente
    Private Sub ClientesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub buscCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ClientesDataSet11.clientes' table. You can move, or remove it, as needed.
        Me.ClientesTableAdapter1.Fill(Me.ClientesDataSet1.clientes)
        'TODO: This line of code loads data into the 'ClientesDataSet1.clientes' table. You can move, or remove it, as needed.
        Me.ClientesTableAdapter1.Fill(Me.ClientesDataSet1.clientes)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        Me.ClientesBindingSource1.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.ClientesDataSet1)

        MsgBox("Alteração salva com sucesso", MsgBoxStyle.Information, Title:="Salvo")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result As Integer = MessageBox.Show("Tem certeza que deseja excluir o cadastro?", "Excluir cadastro", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.ClientesBindingSource1.RemoveCurrent()
            Me.Validate()
            Me.ClientesBindingSource1.EndEdit()
            Me.TableAdapterManager1.UpdateAll(Me.ClientesDataSet1)
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim registro = MessageBox.Show("Deseja registrar compra para esse cliente?", "Registrar compra", MessageBoxButtons.YesNo)

        If registro = DialogResult.Yes Then


            Dim compra As Integer
            If Integer.TryParse(QtdPedidoTextBox.Text, compra) Then
                compra += 1
            End If
            QtdPedidoTextBox.Text = compra.ToString()


            Me.Validate()
            Me.ClientesBindingSource1.EndEdit()
            Me.TableAdapterManager1.UpdateAll(Me.ClientesDataSet1)

        End If
    End Sub
End Class