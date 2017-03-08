Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        addCliente.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        buscCliente.Show()
    End Sub
    Private Sub SobreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SobreToolStripMenuItem.Click
        about.Show()
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Application.Exit()

    End Sub
    Private Sub RealizarBackupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RealizarBackupToolStripMenuItem.Click

        Dim backupMsg = MessageBox.Show("Deseja executar o backup do banco de dados?", "Backup", MessageBoxButtons.YesNo)

        If backupMsg = DialogResult.Yes Then
            My.Computer.FileSystem.CopyFile(
            "C:\ChaleDaPizza\clientes.accdb",
            "C:\ChaleDaPizza\backup\clientes.accdb",
            Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
            Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
        End If


    End Sub

    Private Sub RestaurarBackupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestaurarBackupToolStripMenuItem.Click

        Dim backupMsg = MessageBox.Show("Deseja restaurar o backup do banco de dados?", "Backup", MessageBoxButtons.YesNo)

        If backupMsg = DialogResult.Yes Then

            Dim backupMsg2 = MessageBox.Show("ATENÇÃO!!! Isso irá restaurar os dados do último backup realizado. Você perderá todas as alterações feitas caso nenhum backup tenha sido feito. Deseja continuar?", "ATENÇÃO!", MessageBoxButtons.YesNo)
            If backupMsg2 = DialogResult.Yes Then

                My.Computer.FileSystem.CopyFile(
               "C:\ChaleDaPizza\backup\clientes.accdb",
               "C:\ChaleDaPizza\clientes.accdb",
                Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
                Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
            End If

        End If

    End Sub
End Class
