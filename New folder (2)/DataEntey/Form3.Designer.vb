<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim IdLabel As System.Windows.Forms.Label
        Dim MnameLabel As System.Windows.Forms.Label
        Dim FieldLabel As System.Windows.Forms.Label
        Dim TypeLabel As System.Windows.Forms.Label
        Dim SchoolstageLabel As System.Windows.Forms.Label
        Dim BandLabel As System.Windows.Forms.Label
        Dim SubjectLabel As System.Windows.Forms.Label
        Dim PdfLabel As System.Windows.Forms.Label
        Dim VideoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.DataDataSet = New DataEntey.dataDataSet()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table1TableAdapter = New DataEntey.dataDataSetTableAdapters.Table1TableAdapter()
        Me.TableAdapterManager = New DataEntey.dataDataSetTableAdapters.TableAdapterManager()
        Me.IdLabel1 = New System.Windows.Forms.Label()
        Me.MnameTextBox = New System.Windows.Forms.TextBox()
        Me.FieldComboBox = New System.Windows.Forms.ComboBox()
        Me.TypeComboBox = New System.Windows.Forms.ComboBox()
        Me.SchoolstageComboBox = New System.Windows.Forms.ComboBox()
        Me.BandComboBox = New System.Windows.Forms.ComboBox()
        Me.SubjectComboBox = New System.Windows.Forms.ComboBox()
        Me.PdfTextBox = New System.Windows.Forms.TextBox()
        Me.Table1DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.VideoTextBox = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        IdLabel = New System.Windows.Forms.Label()
        MnameLabel = New System.Windows.Forms.Label()
        FieldLabel = New System.Windows.Forms.Label()
        TypeLabel = New System.Windows.Forms.Label()
        SchoolstageLabel = New System.Windows.Forms.Label()
        BandLabel = New System.Windows.Forms.Label()
        SubjectLabel = New System.Windows.Forms.Label()
        PdfLabel = New System.Windows.Forms.Label()
        VideoLabel = New System.Windows.Forms.Label()
        CType(Me.DataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Dock = System.Windows.Forms.DockStyle.Fill
        IdLabel.Location = New System.Drawing.Point(119, 0)
        IdLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        IdLabel.Name = "IdLabel"
        IdLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        IdLabel.Size = New System.Drawing.Size(114, 22)
        IdLabel.TabIndex = 1
        IdLabel.Text = "id:"
        '
        'MnameLabel
        '
        MnameLabel.AutoSize = True
        MnameLabel.Dock = System.Windows.Forms.DockStyle.Fill
        MnameLabel.Location = New System.Drawing.Point(119, 22)
        MnameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        MnameLabel.Name = "MnameLabel"
        MnameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        MnameLabel.Size = New System.Drawing.Size(114, 22)
        MnameLabel.TabIndex = 3
        MnameLabel.Text = "اسم الوسيله"
        '
        'FieldLabel
        '
        FieldLabel.AutoSize = True
        FieldLabel.Dock = System.Windows.Forms.DockStyle.Fill
        FieldLabel.Location = New System.Drawing.Point(119, 44)
        FieldLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        FieldLabel.Name = "FieldLabel"
        FieldLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        FieldLabel.Size = New System.Drawing.Size(114, 22)
        FieldLabel.TabIndex = 5
        FieldLabel.Text = "مجال الوسيله"
        '
        'TypeLabel
        '
        TypeLabel.AutoSize = True
        TypeLabel.Dock = System.Windows.Forms.DockStyle.Fill
        TypeLabel.Location = New System.Drawing.Point(119, 66)
        TypeLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        TypeLabel.Name = "TypeLabel"
        TypeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        TypeLabel.Size = New System.Drawing.Size(114, 22)
        TypeLabel.TabIndex = 7
        TypeLabel.Text = "نوع الوسيله"
        '
        'SchoolstageLabel
        '
        SchoolstageLabel.AutoSize = True
        SchoolstageLabel.Dock = System.Windows.Forms.DockStyle.Fill
        SchoolstageLabel.Location = New System.Drawing.Point(119, 88)
        SchoolstageLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        SchoolstageLabel.Name = "SchoolstageLabel"
        SchoolstageLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        SchoolstageLabel.Size = New System.Drawing.Size(114, 22)
        SchoolstageLabel.TabIndex = 9
        SchoolstageLabel.Text = "السنه الدراسيه"
        '
        'BandLabel
        '
        BandLabel.AutoSize = True
        BandLabel.Dock = System.Windows.Forms.DockStyle.Fill
        BandLabel.Location = New System.Drawing.Point(119, 110)
        BandLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        BandLabel.Name = "BandLabel"
        BandLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        BandLabel.Size = New System.Drawing.Size(114, 22)
        BandLabel.TabIndex = 11
        BandLabel.Text = "الصف"
        '
        'SubjectLabel
        '
        SubjectLabel.AutoSize = True
        SubjectLabel.Dock = System.Windows.Forms.DockStyle.Fill
        SubjectLabel.Location = New System.Drawing.Point(119, 132)
        SubjectLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        SubjectLabel.Name = "SubjectLabel"
        SubjectLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        SubjectLabel.Size = New System.Drawing.Size(114, 22)
        SubjectLabel.TabIndex = 13
        SubjectLabel.Text = "الماده"
        '
        'PdfLabel
        '
        PdfLabel.AutoSize = True
        PdfLabel.Dock = System.Windows.Forms.DockStyle.Fill
        PdfLabel.Location = New System.Drawing.Point(119, 154)
        PdfLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        PdfLabel.Name = "PdfLabel"
        PdfLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        PdfLabel.Size = New System.Drawing.Size(114, 22)
        PdfLabel.TabIndex = 15
        PdfLabel.Text = "pdf:"
        '
        'VideoLabel
        '
        VideoLabel.AutoSize = True
        VideoLabel.Dock = System.Windows.Forms.DockStyle.Fill
        VideoLabel.Location = New System.Drawing.Point(119, 176)
        VideoLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        VideoLabel.Name = "VideoLabel"
        VideoLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        VideoLabel.Size = New System.Drawing.Size(114, 22)
        VideoLabel.TabIndex = 17
        VideoLabel.Text = "video:"
        '
        'DataDataSet
        '
        Me.DataDataSet.DataSetName = "dataDataSet"
        Me.DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Table1BindingSource
        '
        Me.Table1BindingSource.DataMember = "Table1"
        Me.Table1BindingSource.DataSource = Me.DataDataSet
        '
        'Table1TableAdapter
        '
        Me.Table1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Table1TableAdapter = Me.Table1TableAdapter
        Me.TableAdapterManager.UpdateOrder = DataEntey.dataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IdLabel1
        '
        Me.IdLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "id", True))
        Me.IdLabel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IdLabel1.Location = New System.Drawing.Point(2, 0)
        Me.IdLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.IdLabel1.Name = "IdLabel1"
        Me.IdLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.IdLabel1.Size = New System.Drawing.Size(113, 22)
        Me.IdLabel1.TabIndex = 2
        Me.IdLabel1.Text = "Label1"
        '
        'MnameTextBox
        '
        Me.MnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "mname", True))
        Me.MnameTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MnameTextBox.Location = New System.Drawing.Point(2, 24)
        Me.MnameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.MnameTextBox.Name = "MnameTextBox"
        Me.MnameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MnameTextBox.Size = New System.Drawing.Size(113, 20)
        Me.MnameTextBox.TabIndex = 4
        '
        'FieldComboBox
        '
        Me.FieldComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "field", True))
        Me.FieldComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FieldComboBox.FormattingEnabled = True
        Me.FieldComboBox.Items.AddRange(New Object() {"حاسب", "مناهج", "مكتبات"})
        Me.FieldComboBox.Location = New System.Drawing.Point(2, 46)
        Me.FieldComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.FieldComboBox.Name = "FieldComboBox"
        Me.FieldComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FieldComboBox.Size = New System.Drawing.Size(113, 21)
        Me.FieldComboBox.TabIndex = 6
        '
        'TypeComboBox
        '
        Me.TypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "type", True))
        Me.TypeComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TypeComboBox.FormattingEnabled = True
        Me.TypeComboBox.Items.AddRange(New Object() {"مجسم", "كهربيه", "وبريه", "لوحه", "مسمريه", "برمجيه"})
        Me.TypeComboBox.Location = New System.Drawing.Point(2, 68)
        Me.TypeComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.TypeComboBox.Name = "TypeComboBox"
        Me.TypeComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TypeComboBox.Size = New System.Drawing.Size(113, 21)
        Me.TypeComboBox.TabIndex = 8
        '
        'SchoolstageComboBox
        '
        Me.SchoolstageComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "schoolstage", True))
        Me.SchoolstageComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SchoolstageComboBox.FormattingEnabled = True
        Me.SchoolstageComboBox.Items.AddRange(New Object() {"ابتدائي", "اعدادى", "ثانوي"})
        Me.SchoolstageComboBox.Location = New System.Drawing.Point(2, 90)
        Me.SchoolstageComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.SchoolstageComboBox.Name = "SchoolstageComboBox"
        Me.SchoolstageComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SchoolstageComboBox.Size = New System.Drawing.Size(113, 21)
        Me.SchoolstageComboBox.TabIndex = 10
        '
        'BandComboBox
        '
        Me.BandComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "band", True))
        Me.BandComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BandComboBox.FormattingEnabled = True
        Me.BandComboBox.Items.AddRange(New Object() {"اول", "تانى", "تالت", "رابع", "خامس", "سادس"})
        Me.BandComboBox.Location = New System.Drawing.Point(2, 112)
        Me.BandComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.BandComboBox.Name = "BandComboBox"
        Me.BandComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BandComboBox.Size = New System.Drawing.Size(113, 21)
        Me.BandComboBox.TabIndex = 12
        '
        'SubjectComboBox
        '
        Me.SubjectComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "subject", True))
        Me.SubjectComboBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SubjectComboBox.FormattingEnabled = True
        Me.SubjectComboBox.Items.AddRange(New Object() {"اللغة العربية", "الرياضيات", "العلوم", "الدراسات الاجتماعية", "حاسب", "اللغة الإنجليزية", "الفيزياء", "الكيمياء", "الاقتصاد"})
        Me.SubjectComboBox.Location = New System.Drawing.Point(2, 134)
        Me.SubjectComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.SubjectComboBox.Name = "SubjectComboBox"
        Me.SubjectComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SubjectComboBox.Size = New System.Drawing.Size(113, 21)
        Me.SubjectComboBox.TabIndex = 14
        '
        'PdfTextBox
        '
        Me.PdfTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "pdf", True))
        Me.PdfTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PdfTextBox.Location = New System.Drawing.Point(2, 156)
        Me.PdfTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PdfTextBox.Name = "PdfTextBox"
        Me.PdfTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PdfTextBox.Size = New System.Drawing.Size(113, 20)
        Me.PdfTextBox.TabIndex = 16
        '
        'Table1DataGridView
        '
        Me.Table1DataGridView.AutoGenerateColumns = False
        Me.Table1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.Table1DataGridView.DataSource = Me.Table1BindingSource
        Me.Table1DataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Table1DataGridView.Location = New System.Drawing.Point(2, 266)
        Me.Table1DataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.Table1DataGridView.Name = "Table1DataGridView"
        Me.Table1DataGridView.RowTemplate.Height = 24
        Me.Table1DataGridView.Size = New System.Drawing.Size(804, 207)
        Me.Table1DataGridView.TabIndex = 19
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "mname"
        Me.DataGridViewTextBoxColumn2.HeaderText = "mname"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "field"
        Me.DataGridViewTextBoxColumn3.HeaderText = "field"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "type"
        Me.DataGridViewTextBoxColumn4.HeaderText = "type"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "schoolstage"
        Me.DataGridViewTextBoxColumn5.HeaderText = "schoolstage"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "band"
        Me.DataGridViewTextBoxColumn6.HeaderText = "band"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "subject"
        Me.DataGridViewTextBoxColumn7.HeaderText = "subject"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "pdf"
        Me.DataGridViewTextBoxColumn8.HeaderText = "pdf"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "video"
        Me.DataGridViewTextBoxColumn9.HeaderText = "video"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Table1DataGridView, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(808, 529)
        Me.TableLayoutPanel1.TabIndex = 20
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 4
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Button1, 3, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Button2, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Button3, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Button4, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 478)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(802, 48)
        Me.TableLayoutPanel4.TabIndex = 21
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Location = New System.Drawing.Point(603, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(196, 42)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "السابق"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.Location = New System.Drawing.Point(403, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(194, 42)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "video"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button3.Location = New System.Drawing.Point(203, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(194, 42)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "pdf"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button4.Location = New System.Drawing.Point(3, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(194, 42)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "اغلاق"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel5, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(802, 258)
        Me.TableLayoutPanel2.TabIndex = 20
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(IdLabel, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.VideoTextBox, 0, 8)
        Me.TableLayoutPanel3.Controls.Add(Me.PdfTextBox, 0, 7)
        Me.TableLayoutPanel3.Controls.Add(Me.SubjectComboBox, 0, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.BandComboBox, 0, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.SchoolstageComboBox, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.TypeComboBox, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.FieldComboBox, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.IdLabel1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(MnameLabel, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(FieldLabel, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(TypeLabel, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(SchoolstageLabel, 1, 4)
        Me.TableLayoutPanel3.Controls.Add(BandLabel, 1, 5)
        Me.TableLayoutPanel3.Controls.Add(SubjectLabel, 1, 6)
        Me.TableLayoutPanel3.Controls.Add(PdfLabel, 1, 7)
        Me.TableLayoutPanel3.Controls.Add(VideoLabel, 1, 8)
        Me.TableLayoutPanel3.Controls.Add(Me.MnameTextBox, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Button5, 1, 9)
        Me.TableLayoutPanel3.Controls.Add(Me.Button6, 0, 9)
        Me.TableLayoutPanel3.Controls.Add(Me.Button7, 1, 10)
        Me.TableLayoutPanel3.Controls.Add(Me.Button8, 0, 10)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(564, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 11
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(235, 252)
        Me.TableLayoutPanel3.TabIndex = 21
        '
        'VideoTextBox
        '
        Me.VideoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "video", True))
        Me.VideoTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VideoTextBox.Location = New System.Drawing.Point(2, 178)
        Me.VideoTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.VideoTextBox.Name = "VideoTextBox"
        Me.VideoTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.VideoTextBox.Size = New System.Drawing.Size(113, 20)
        Me.VideoTextBox.TabIndex = 18
        '
        'Button5
        '
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button5.Location = New System.Drawing.Point(120, 201)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(112, 16)
        Me.Button5.TabIndex = 19
        Me.Button5.Text = "اضف"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button6.Location = New System.Drawing.Point(3, 201)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(111, 16)
        Me.Button6.TabIndex = 20
        Me.Button6.Text = "تعديل"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button7.Location = New System.Drawing.Point(120, 223)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(112, 26)
        Me.Button7.TabIndex = 21
        Me.Button7.Text = "حذف"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button8.Location = New System.Drawing.Point(3, 223)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(111, 26)
        Me.Button8.TabIndex = 22
        Me.Button8.Text = "حفظ"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel6, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.GroupBox1, 0, 1)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(555, 252)
        Me.TableLayoutPanel5.TabIndex = 22
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.TextBox1, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Button9, 0, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(549, 19)
        Me.TableLayoutPanel6.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Location = New System.Drawing.Point(167, 3)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(379, 13)
        Me.TextBox1.TabIndex = 0
        '
        'Button9
        '
        Me.Button9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button9.Location = New System.Drawing.Point(3, 3)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(158, 13)
        Me.Button9.TabIndex = 1
        Me.Button9.Text = "استرجاع"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(549, 221)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Video"
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(3, 16)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(543, 202)
        Me.AxWindowsMediaPlayer1.TabIndex = 0
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(808, 529)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form3"
        Me.Text = "DataPreview"
        CType(Me.DataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataDataSet As DataEntey.dataDataSet
    Friend WithEvents Table1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table1TableAdapter As DataEntey.dataDataSetTableAdapters.Table1TableAdapter
    Friend WithEvents TableAdapterManager As DataEntey.dataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdLabel1 As System.Windows.Forms.Label
    Friend WithEvents MnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FieldComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SchoolstageComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BandComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SubjectComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PdfTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Table1DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents VideoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
End Class
