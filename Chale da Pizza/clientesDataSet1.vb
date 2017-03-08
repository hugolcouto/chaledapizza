Partial Class clientesDataSet1
    Partial Public Class clientesDataTable
        Private Sub clientesDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.NomeClienteColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
