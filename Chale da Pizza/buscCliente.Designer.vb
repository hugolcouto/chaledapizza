<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class buscCliente
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IDLabel As System.Windows.Forms.Label
        Dim NomeClienteLabel As System.Windows.Forms.Label
        Dim RuaLabel As System.Windows.Forms.Label
        Dim NumCasaLabel As System.Windows.Forms.Label
        Dim BairroLabel As System.Windows.Forms.Label
        Dim ReferenciaLabel As System.Windows.Forms.Label
        Dim Tel1Label As System.Windows.Forms.Label
        Dim Tel2Label As System.Windows.Forms.Label
        Dim FacebookLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim QtdPedidoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(buscCliente))
        Me.ClientesDataSet = New Chale_da_Pizza.clientesDataSet()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New Chale_da_Pizza.clientesDataSetTableAdapters.clientesTableAdapter()
        Me.TableAdapterManager = New Chale_da_Pizza.clientesDataSetTableAdapters.TableAdapterManager()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ClientesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesDataSet1 = New Chale_da_Pizza.clientesDataSet1()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MaskedTextBox3 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.NomeClienteTextBox = New System.Windows.Forms.TextBox()
        Me.RuaTextBox = New System.Windows.Forms.TextBox()
        Me.BairroTextBox = New System.Windows.Forms.TextBox()
        Me.ReferenciaTextBox = New System.Windows.Forms.TextBox()
        Me.FacebookTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.QtdPedidoTextBox = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ClientesTableAdapter1 = New Chale_da_Pizza.clientesDataSet1TableAdapters.clientesTableAdapter()
        Me.TableAdapterManager1 = New Chale_da_Pizza.clientesDataSet1TableAdapters.TableAdapterManager()
        IDLabel = New System.Windows.Forms.Label()
        NomeClienteLabel = New System.Windows.Forms.Label()
        RuaLabel = New System.Windows.Forms.Label()
        NumCasaLabel = New System.Windows.Forms.Label()
        BairroLabel = New System.Windows.Forms.Label()
        ReferenciaLabel = New System.Windows.Forms.Label()
        Tel1Label = New System.Windows.Forms.Label()
        Tel2Label = New System.Windows.Forms.Label()
        FacebookLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        QtdPedidoLabel = New System.Windows.Forms.Label()
        CType(Me.ClientesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(9, 108)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 61
        IDLabel.Text = "ID:"
        '
        'NomeClienteLabel
        '
        NomeClienteLabel.AutoSize = True
        NomeClienteLabel.Location = New System.Drawing.Point(51, 108)
        NomeClienteLabel.Name = "NomeClienteLabel"
        NomeClienteLabel.Size = New System.Drawing.Size(73, 13)
        NomeClienteLabel.TabIndex = 63
        NomeClienteLabel.Text = "Nome Cliente:"
        '
        'RuaLabel
        '
        RuaLabel.AutoSize = True
        RuaLabel.Location = New System.Drawing.Point(9, 147)
        RuaLabel.Name = "RuaLabel"
        RuaLabel.Size = New System.Drawing.Size(30, 13)
        RuaLabel.TabIndex = 65
        RuaLabel.Text = "Rua:"
        '
        'NumCasaLabel
        '
        NumCasaLabel.AutoSize = True
        NumCasaLabel.Location = New System.Drawing.Point(194, 147)
        NumCasaLabel.Name = "NumCasaLabel"
        NumCasaLabel.Size = New System.Drawing.Size(22, 13)
        NumCasaLabel.TabIndex = 67
        NumCasaLabel.Text = "Nº:"
        '
        'BairroLabel
        '
        BairroLabel.AutoSize = True
        BairroLabel.Location = New System.Drawing.Point(240, 147)
        BairroLabel.Name = "BairroLabel"
        BairroLabel.Size = New System.Drawing.Size(37, 13)
        BairroLabel.TabIndex = 68
        BairroLabel.Text = "Bairro:"
        '
        'ReferenciaLabel
        '
        ReferenciaLabel.AutoSize = True
        ReferenciaLabel.Location = New System.Drawing.Point(9, 188)
        ReferenciaLabel.Name = "ReferenciaLabel"
        ReferenciaLabel.Size = New System.Drawing.Size(62, 13)
        ReferenciaLabel.TabIndex = 70
        ReferenciaLabel.Text = "Referencia:"
        '
        'Tel1Label
        '
        Tel1Label.AutoSize = True
        Tel1Label.Location = New System.Drawing.Point(9, 226)
        Tel1Label.Name = "Tel1Label"
        Tel1Label.Size = New System.Drawing.Size(31, 13)
        Tel1Label.TabIndex = 72
        Tel1Label.Text = "Tel1:"
        '
        'Tel2Label
        '
        Tel2Label.AutoSize = True
        Tel2Label.Location = New System.Drawing.Point(115, 226)
        Tel2Label.Name = "Tel2Label"
        Tel2Label.Size = New System.Drawing.Size(31, 13)
        Tel2Label.TabIndex = 73
        Tel2Label.Text = "Tel2:"
        '
        'FacebookLabel
        '
        FacebookLabel.AutoSize = True
        FacebookLabel.Location = New System.Drawing.Point(221, 226)
        FacebookLabel.Name = "FacebookLabel"
        FacebookLabel.Size = New System.Drawing.Size(58, 13)
        FacebookLabel.TabIndex = 74
        FacebookLabel.Text = "Facebook:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(12, 33)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(78, 13)
        Label1.TabIndex = 80
        Label1.Text = "Buscar Cliente:"
        '
        'QtdPedidoLabel
        '
        QtdPedidoLabel.AutoSize = True
        QtdPedidoLabel.Location = New System.Drawing.Point(12, 265)
        QtdPedidoLabel.Name = "QtdPedidoLabel"
        QtdPedidoLabel.Size = New System.Drawing.Size(63, 13)
        QtdPedidoLabel.TabIndex = 80
        QtdPedidoLabel.Text = "Qtd Pedido:"
        '
        'ClientesDataSet
        '
        Me.ClientesDataSet.DataSetName = "clientesDataSet"
        Me.ClientesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "clientes"
        Me.ClientesBindingSource.DataSource = Me.ClientesDataSet
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager.UpdateOrder = Chale_da_Pizza.clientesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.DataSource = Me.ClientesBindingSource1
        Me.ComboBox1.DisplayMember = "Tel1"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(13, 49)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(115, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'ClientesBindingSource1
        '
        Me.ClientesBindingSource1.DataMember = "clientes"
        Me.ClientesBindingSource1.DataSource = Me.ClientesDataSet1
        '
        'ClientesDataSet1
        '
        Me.ClientesDataSet1.DataSetName = "clientesDataSet1"
        Me.ClientesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(13, 306)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 22)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Salvar alterações"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MaskedTextBox3
        '
        Me.MaskedTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource1, "Tel2", True))
        Me.MaskedTextBox3.Location = New System.Drawing.Point(118, 242)
        Me.MaskedTextBox3.Mask = "000000000"
        Me.MaskedTextBox3.Name = "MaskedTextBox3"
        Me.MaskedTextBox3.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBox3.TabIndex = 8
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource1, "Tel1", True))
        Me.MaskedTextBox2.Location = New System.Drawing.Point(12, 242)
        Me.MaskedTextBox2.Mask = "000000000"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBox2.TabIndex = 7
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource1, "NumCasa", True))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(197, 163)
        Me.MaskedTextBox1.Mask = "00000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(40, 20)
        Me.MaskedTextBox1.TabIndex = 4
        Me.MaskedTextBox1.ValidatingType = GetType(Integer)
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource1, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(12, 124)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.ReadOnly = True
        Me.IDTextBox.Size = New System.Drawing.Size(36, 20)
        Me.IDTextBox.TabIndex = 62
        '
        'NomeClienteTextBox
        '
        Me.NomeClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource1, "NomeCliente", True))
        Me.NomeClienteTextBox.Location = New System.Drawing.Point(54, 124)
        Me.NomeClienteTextBox.Name = "NomeClienteTextBox"
        Me.NomeClienteTextBox.Size = New System.Drawing.Size(337, 20)
        Me.NomeClienteTextBox.TabIndex = 2
        '
        'RuaTextBox
        '
        Me.RuaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource1, "Rua", True))
        Me.RuaTextBox.Location = New System.Drawing.Point(12, 163)
        Me.RuaTextBox.Name = "RuaTextBox"
        Me.RuaTextBox.Size = New System.Drawing.Size(179, 20)
        Me.RuaTextBox.TabIndex = 3
        '
        'BairroTextBox
        '
        Me.BairroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource1, "Bairro", True))
        Me.BairroTextBox.Location = New System.Drawing.Point(243, 163)
        Me.BairroTextBox.Name = "BairroTextBox"
        Me.BairroTextBox.Size = New System.Drawing.Size(148, 20)
        Me.BairroTextBox.TabIndex = 5
        '
        'ReferenciaTextBox
        '
        Me.ReferenciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource1, "Referencia", True))
        Me.ReferenciaTextBox.Location = New System.Drawing.Point(12, 204)
        Me.ReferenciaTextBox.Name = "ReferenciaTextBox"
        Me.ReferenciaTextBox.Size = New System.Drawing.Size(379, 20)
        Me.ReferenciaTextBox.TabIndex = 6
        '
        'FacebookTextBox
        '
        Me.FacebookTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource1, "Facebook", True))
        Me.FacebookTextBox.Location = New System.Drawing.Point(224, 242)
        Me.FacebookTextBox.Name = "FacebookTextBox"
        Me.FacebookTextBox.Size = New System.Drawing.Size(167, 20)
        Me.FacebookTextBox.TabIndex = 9
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(288, 306)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Excluir cadastro"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'QtdPedidoTextBox
        '
        Me.QtdPedidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource1, "QtdPedido", True))
        Me.QtdPedidoTextBox.Location = New System.Drawing.Point(15, 281)
        Me.QtdPedidoTextBox.Name = "QtdPedidoTextBox"
        Me.QtdPedidoTextBox.ReadOnly = True
        Me.QtdPedidoTextBox.Size = New System.Drawing.Size(58, 20)
        Me.QtdPedidoTextBox.TabIndex = 81
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(158, 306)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(101, 23)
        Me.Button3.TabIndex = 82
        Me.Button3.Text = "Registrar Compra"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'ClientesTableAdapter1
        '
        Me.ClientesTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.clientesTableAdapter = Me.ClientesTableAdapter1
        Me.TableAdapterManager1.UpdateOrder = Chale_da_Pizza.clientesDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'buscCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 351)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(QtdPedidoLabel)
        Me.Controls.Add(Me.QtdPedidoTextBox)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.MaskedTextBox3)
        Me.Controls.Add(Me.MaskedTextBox2)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(NomeClienteLabel)
        Me.Controls.Add(Me.NomeClienteTextBox)
        Me.Controls.Add(RuaLabel)
        Me.Controls.Add(Me.RuaTextBox)
        Me.Controls.Add(NumCasaLabel)
        Me.Controls.Add(BairroLabel)
        Me.Controls.Add(Me.BairroTextBox)
        Me.Controls.Add(ReferenciaLabel)
        Me.Controls.Add(Me.ReferenciaTextBox)
        Me.Controls.Add(Tel1Label)
        Me.Controls.Add(Tel2Label)
        Me.Controls.Add(FacebookLabel)
        Me.Controls.Add(Me.FacebookTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "buscCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar cliente"
        CType(Me.ClientesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ClientesDataSet As clientesDataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As clientesDataSetTableAdapters.clientesTableAdapter
    Friend WithEvents TableAdapterManager As clientesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents MaskedTextBox3 As MaskedTextBox
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents NomeClienteTextBox As TextBox
    Friend WithEvents RuaTextBox As TextBox
    Friend WithEvents BairroTextBox As TextBox
    Friend WithEvents ReferenciaTextBox As TextBox
    Friend WithEvents FacebookTextBox As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents QtdPedidoTextBox As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents ClientesDataSet1 As clientesDataSet1
    Friend WithEvents ClientesBindingSource1 As BindingSource
    Friend WithEvents ClientesTableAdapter1 As clientesDataSet1TableAdapters.clientesTableAdapter
    Friend WithEvents TableAdapterManager1 As clientesDataSet1TableAdapters.TableAdapterManager
End Class
