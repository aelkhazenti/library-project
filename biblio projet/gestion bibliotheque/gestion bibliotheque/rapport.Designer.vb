<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rapport
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Projet_bibliothequeDataSet1 = New gestion_bibliotheque.projet_bibliothequeDataSet1()
        Me.LivreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LivreTableAdapter = New gestion_bibliotheque.projet_bibliothequeDataSet1TableAdapters.livreTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.Projet_bibliothequeDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LivreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(207, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 31)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "ajouter un rapport"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(126, 209)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(101, 20)
        Me.TextBox3.TabIndex = 22
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(127, 171)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(39, 253)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "type"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "anne du rapport"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "titre"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"informatique", "economique", "politique"})
        Me.ComboBox1.Location = New System.Drawing.Point(126, 250)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 24
        '
        'Projet_bibliothequeDataSet1
        '
        Me.Projet_bibliothequeDataSet1.DataSetName = "projet_bibliothequeDataSet1"
        Me.Projet_bibliothequeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LivreBindingSource
        '
        Me.LivreBindingSource.DataMember = "livre"
        Me.LivreBindingSource.DataSource = Me.Projet_bibliothequeDataSet1
        '
        'LivreTableAdapter
        '
        Me.LivreTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(296, 379)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 30)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "ajouter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PeachPuff
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(644, 54)
        Me.Panel1.TabIndex = 26
        '
        'rapport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Name = "rapport"
        Me.Size = New System.Drawing.Size(644, 450)
        CType(Me.Projet_bibliothequeDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LivreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents LivreBindingSource As BindingSource
    Friend WithEvents Projet_bibliothequeDataSet1 As projet_bibliothequeDataSet1
    Friend WithEvents LivreTableAdapter As projet_bibliothequeDataSet1TableAdapters.livreTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
End Class
