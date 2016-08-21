<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ComboBox_column = New System.Windows.Forms.ComboBox()
        Me.HackParkingNTUDataSet1 = New ParkingHack.HackParkingNTUDataSet1()
        Me.車位資料全BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.車位資料_全TableAdapter = New ParkingHack.HackParkingNTUDataSet1TableAdapters.車位資料_全TableAdapter()
        Me.TextBox_pre = New System.Windows.Forms.TextBox()
        Me.TextBox_correct = New System.Windows.Forms.TextBox()
        Me.ComboBox_ID = New System.Windows.Forms.ComboBox()
        Me.車位資料全BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.HackParkingNTUDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.車位資料全BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.車位資料全BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox_column
        '
        Me.ComboBox_column.FormattingEnabled = True
        Me.ComboBox_column.Items.AddRange(New Object() {"Latitude", "Longitude", "收費時段", "收費時段結束", "行政區", "車位狀況", "車位型態", "車位類型", "車格施工日期", "車格塗銷日期", "服務時間", "服務時間結束", "修改人", "修改時間", "累進費率", "備註", "費率", "道路", "編號", "識別碼"})
        Me.ComboBox_column.Location = New System.Drawing.Point(150, 42)
        Me.ComboBox_column.Name = "ComboBox_column"
        Me.ComboBox_column.Size = New System.Drawing.Size(121, 23)
        Me.ComboBox_column.Sorted = True
        Me.ComboBox_column.TabIndex = 0
        Me.ComboBox_column.TabStop = False
        Me.ComboBox_column.Text = "編號"
        '
        'HackParkingNTUDataSet1
        '
        Me.HackParkingNTUDataSet1.DataSetName = "HackParkingNTUDataSet1"
        Me.HackParkingNTUDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '車位資料全BindingSource
        '
        Me.車位資料全BindingSource.DataMember = "車位資料_全"
        Me.車位資料全BindingSource.DataSource = Me.HackParkingNTUDataSet1
        '
        '車位資料_全TableAdapter
        '
        Me.車位資料_全TableAdapter.ClearBeforeFill = True
        '
        'TextBox_pre
        '
        Me.TextBox_pre.Enabled = False
        Me.TextBox_pre.Location = New System.Drawing.Point(291, 42)
        Me.TextBox_pre.Name = "TextBox_pre"
        Me.TextBox_pre.Size = New System.Drawing.Size(153, 25)
        Me.TextBox_pre.TabIndex = 1
        '
        'TextBox_correct
        '
        Me.TextBox_correct.Location = New System.Drawing.Point(450, 42)
        Me.TextBox_correct.Name = "TextBox_correct"
        Me.TextBox_correct.Size = New System.Drawing.Size(153, 25)
        Me.TextBox_correct.TabIndex = 2
        '
        'ComboBox_ID
        '
        Me.ComboBox_ID.DataSource = Me.車位資料全BindingSource1
        Me.ComboBox_ID.DisplayMember = "識別碼"
        Me.ComboBox_ID.FormattingEnabled = True
        Me.ComboBox_ID.Location = New System.Drawing.Point(12, 42)
        Me.ComboBox_ID.Name = "ComboBox_ID"
        Me.ComboBox_ID.Size = New System.Drawing.Size(121, 23)
        Me.ComboBox_ID.TabIndex = 3
        '
        '車位資料全BindingSource1
        '
        Me.車位資料全BindingSource1.DataMember = "車位資料_全"
        Me.車位資料全BindingSource1.DataSource = Me.HackParkingNTUDataSet1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "識別碼"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(147, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "項目"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(288, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "原始資料"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(447, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "變更後資料"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("微軟正黑體", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button1.Location = New System.Drawing.Point(624, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 44)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "變更"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 77)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox_ID)
        Me.Controls.Add(Me.TextBox_correct)
        Me.Controls.Add(Me.TextBox_pre)
        Me.Controls.Add(Me.ComboBox_column)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.HackParkingNTUDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.車位資料全BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.車位資料全BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox_column As ComboBox
    Friend WithEvents HackParkingNTUDataSet1 As HackParkingNTUDataSet1
    Friend WithEvents 車位資料全BindingSource As BindingSource
    Friend WithEvents 車位資料_全TableAdapter As HackParkingNTUDataSet1TableAdapters.車位資料_全TableAdapter
    Friend WithEvents TextBox_pre As TextBox
    Friend WithEvents TextBox_correct As TextBox
    Friend WithEvents ComboBox_ID As ComboBox
    Friend WithEvents 車位資料全BindingSource1 As BindingSource
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
End Class
