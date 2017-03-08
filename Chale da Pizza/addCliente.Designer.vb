<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addCliente
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addCliente))
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.ClientesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesDataSet1 = New Chale_da_Pizza.clientesDataSet1()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesDataSet = New Chale_da_Pizza.clientesDataSet()
        Me.NomeClienteTextBox = New System.Windows.Forms.TextBox()
        Me.RuaTextBox = New System.Windows.Forms.TextBox()
        Me.BairroTextBox = New System.Windows.Forms.TextBox()
        Me.ReferenciaTextBox = New System.Windows.Forms.TextBox()
        Me.FacebookTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.ClientesTableAdapter = New Chale_da_Pizza.clientesDataSetTableAdapters.clientesTableAdapter()
        Me.TableAdapterManager = New Chale_da_Pizza.clientesDataSetTableAdapters.TableAdapterManager()
        Me.ClientesTableAdapter1 = New Chale_da_Pizza.clientesDataSet1TableAdapters.clientesTableAdapter()
        Me.TableAdapterManager1 = New Chale_da_Pizza.clientesDataSet1TableAdapters.TableAdapterManager()
        Me.MaskedTextBox3 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        IDLabel = New System.Windows.Forms.Label()
        NomeClienteLabel = New System.Windows.Forms.Label()
        RuaLabel = New System.Windows.Forms.Label()
        NumCasaLabel = New System.Windows.Forms.Label()
        BairroLabel = New System.Windows.Forms.Label()
        ReferenciaLabel = New System.Windows.Forms.Label()
        Tel1Label = New System.Windows.Forms.Label()
        Tel2Label = New System.Windows.Forms.Label()
        FacebookLabel = New System.Windows.Forms.Label()
        CType(Me.ClientesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(9, 27)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'NomeClienteLabel
        '
        NomeClienteLabel.AutoSize = True
        NomeClienteLabel.Location = New System.Drawing.Point(51, 27)
        NomeClienteLabel.Name = "NomeClienteLabel"
        NomeClienteLabel.Size = New System.Drawing.Size(73, 13)
        NomeClienteLabel.TabIndex = 3
        NomeClienteLabel.Text = "Nome Cliente:"
        AddHandler NomeClienteLabel.Click, AddressOf Me.NomeClienteLabel_Click
        '
        'RuaLabel
        '
        RuaLabel.AutoSize = True
        RuaLabel.Location = New System.Drawing.Point(9, 66)
        RuaLabel.Name = "RuaLabel"
        RuaLabel.Size = New System.Drawing.Size(30, 13)
        RuaLabel.TabIndex = 5
        RuaLabel.Text = "Rua:"
        '
        'NumCasaLabel
        '
        NumCasaLabel.AutoSize = True
        NumCasaLabel.Location = New System.Drawing.Point(194, 66)
        NumCasaLabel.Name = "NumCasaLabel"
        NumCasaLabel.Size = New System.Drawing.Size(22, 13)
        NumCasaLabel.TabIndex = 7
        NumCasaLabel.Text = "Nº:"
        '
        'BairroLabel
        '
        BairroLabel.AutoSize = True
        BairroLabel.Location = New System.Drawing.Point(240, 66)
        BairroLabel.Name = "BairroLabel"
        BairroLabel.Size = New System.Drawing.Size(37, 13)
        BairroLabel.TabIndex = 9
        BairroLabel.Text = "Bairro:"
        '
        'ReferenciaLabel
        '
        ReferenciaLabel.AutoSize = True
        ReferenciaLabel.Location = New System.Drawing.Point(9, 107)
        ReferenciaLabel.Name = "ReferenciaLabel"
        ReferenciaLabel.Size = New System.Drawing.Size(62, 13)
        ReferenciaLabel.TabIndex = 11
        ReferenciaLabel.Text = "Referencia:"
        '
        'Tel1Label
        '
        Tel1Label.AutoSize = True
        Tel1Label.Location = New System.Drawing.Point(9, 145)
        Tel1Label.Name = "Tel1Label"
        Tel1Label.Size = New System.Drawing.Size(31, 13)
        Tel1Label.TabIndex = 13
        Tel1Label.Text = "Tel1:"
        '
        'Tel2Label
        '
        Tel2Label.AutoSize = True
        Tel2Label.Location = New System.Drawing.Point(115, 145)
        Tel2Label.Name = "Tel2Label"
        Tel2Label.Size = New System.Drawing.Size(31, 13)
        Tel2Label.TabIndex = 15
        Tel2Label.Text = "Tel2:"
        '
        'FacebookLabel
        '
        FacebookLabel.AutoSize = True
        FacebookLabel.Location = New System.Drawing.Point(221, 145)
        FacebookLabel.Name = "FacebookLabel"
        FacebookLabel.Size = New System.Drawing.Size(58, 13)
        FacebookLabel.TabIndex = 17
        FacebookLabel.Text = "Facebook:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource1, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(12, 43)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.ReadOnly = True
        Me.IDTextBox.Size = New System.Drawing.Size(36, 20)
        Me.IDTextBox.TabIndex = 100
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
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "clientes"
        Me.ClientesBindingSource.DataSource = Me.ClientesDataSet
        '
        'ClientesDataSet
        '
        Me.ClientesDataSet.DataSetName = "clientesDataSet"
        Me.ClientesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NomeClienteTextBox
        '
        Me.NomeClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource1, "NomeCliente", True))
        Me.NomeClienteTextBox.Location = New System.Drawing.Point(54, 43)
        Me.NomeClienteTextBox.Name = "NomeClienteTextBox"
        Me.NomeClienteTextBox.Size = New System.Drawing.Size(337, 20)
        Me.NomeClienteTextBox.TabIndex = 1
        '
        'RuaTextBox
        '
        Me.RuaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource1, "Rua", True))
        Me.RuaTextBox.Location = New System.Drawing.Point(12, 82)
        Me.RuaTextBox.Name = "RuaTextBox"
        Me.RuaTextBox.Size = New System.Drawing.Size(179, 20)
        Me.RuaTextBox.TabIndex = 2
        '
        'BairroTextBox
        '
        Me.BairroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource1, "Bairro", True))
        Me.BairroTextBox.Location = New System.Drawing.Point(243, 82)
        Me.BairroTextBox.Name = "BairroTextBox"
        Me.BairroTextBox.Size = New System.Drawing.Size(148, 20)
        Me.BairroTextBox.TabIndex = 4
        '
        'ReferenciaTextBox
        '
        Me.ReferenciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource1, "Referencia", True))
        Me.ReferenciaTextBox.Location = New System.Drawing.Point(12, 123)
        Me.ReferenciaTextBox.Name = "ReferenciaTextBox"
        Me.ReferenciaTextBox.Size = New System.Drawing.Size(379, 20)
        Me.ReferenciaTextBox.TabIndex = 5
        '
        'FacebookTextBox
        '
        Me.FacebookTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource1, "Facebook", True))
        Me.FacebookTextBox.Location = New System.Drawing.Point(224, 161)
        Me.FacebookTextBox.Name = "FacebookTextBox"
        Me.FacebookTextBox.Size = New System.Drawing.Size(167, 20)
        Me.FacebookTextBox.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(145, 200)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 42)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Salvar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource1, "NumCasa", True))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(197, 82)
        Me.MaskedTextBox1.Mask = "00000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(40, 20)
        Me.MaskedTextBox1.TabIndex = 3
        Me.MaskedTextBox1.ValidatingType = GetType(Integer)
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
        'MaskedTextBox3
        '
        Me.MaskedTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource1, "Tel2", True))
        Me.MaskedTextBox3.Location = New System.Drawing.Point(118, 161)
        Me.MaskedTextBox3.Mask = "000000000"
        Me.MaskedTextBox3.Name = "MaskedTextBox3"
        Me.MaskedTextBox3.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBox3.TabIndex = 7
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource1, "Tel1", True))
        Me.MaskedTextBox2.Location = New System.Drawing.Point(12, 161)
        Me.MaskedTextBox2.Mask = "000000000"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBox2.TabIndex = 6
        '
        'addCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 257)
        Me.Controls.Add(Me.MaskedTextBox3)
        Me.Controls.Add(Me.MaskedTextBox2)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.Button1)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "addCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastrar cliente"
        CType(Me.ClientesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ClientesDataSet As clientesDataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As clientesDataSetTableAdapters.clientesTableAdapter
    Friend WithEvents TableAdapterManager As clientesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents NomeClienteTextBox As TextBox
    Friend WithEvents RuaTextBox As TextBox
    Friend WithEvents BairroTextBox As TextBox
    Friend WithEvents ReferenciaTextBox As TextBox
    Friend WithEvents FacebookTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents ClientesDataSet1 As clientesDataSet1
    Friend WithEvents ClientesBindingSource1 As BindingSource
    Friend WithEvents ClientesTableAdapter1 As clientesDataSet1TableAdapters.clientesTableAdapter
    Friend WithEvents TableAdapterManager1 As clientesDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents MaskedTextBox3 As MaskedTextBox
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
End Class
