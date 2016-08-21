<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.HackParkingNTUDataSet = New ParkingHack.HackParkingNTUDataSet()
        Me.車位資料BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.車位資料TableAdapter = New ParkingHack.HackParkingNTUDataSetTableAdapters.車位資料TableAdapter()
        Me.DataGridView_all_park = New System.Windows.Forms.DataGridView()
        Me.識別碼DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.編號DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.車位類型DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.車位型態DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.車位狀況DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.行政區DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.道路DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LatitudeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LongitudeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.費率DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.服務時間DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.服務時間結束DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.車格施工日期DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.車格塗銷日期DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.收費時段DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.收費時段結束DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.累進費率DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.修改人DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.備註DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.修改時間DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.車位資料全BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HackParkingNTUDataSet1 = New ParkingHack.HackParkingNTUDataSet1()
        Me.Button_UD2Server = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button_Refresh = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.車位資料_全TableAdapter = New ParkingHack.HackParkingNTUDataSet1TableAdapters.車位資料_全TableAdapter()
        Me.Label_DataTime = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.HackParkingNTUDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.車位資料BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_all_park, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.車位資料全BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HackParkingNTUDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HackParkingNTUDataSet
        '
        Me.HackParkingNTUDataSet.DataSetName = "HackParkingNTUDataSet"
        Me.HackParkingNTUDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '車位資料BindingSource
        '
        Me.車位資料BindingSource.DataMember = "車位資料"
        Me.車位資料BindingSource.DataSource = Me.HackParkingNTUDataSet
        '
        '車位資料TableAdapter
        '
        Me.車位資料TableAdapter.ClearBeforeFill = True
        '
        'DataGridView_all_park
        '
        Me.DataGridView_all_park.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle1.Font = New System.Drawing.Font("微軟正黑體", 8.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_all_park.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView_all_park.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_all_park.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.識別碼DataGridViewTextBoxColumn, Me.編號DataGridViewTextBoxColumn, Me.車位類型DataGridViewTextBoxColumn, Me.車位型態DataGridViewTextBoxColumn, Me.車位狀況DataGridViewTextBoxColumn, Me.行政區DataGridViewTextBoxColumn, Me.道路DataGridViewTextBoxColumn, Me.LatitudeDataGridViewTextBoxColumn, Me.LongitudeDataGridViewTextBoxColumn, Me.費率DataGridViewTextBoxColumn, Me.服務時間DataGridViewTextBoxColumn, Me.服務時間結束DataGridViewTextBoxColumn, Me.車格施工日期DataGridViewTextBoxColumn, Me.車格塗銷日期DataGridViewTextBoxColumn, Me.收費時段DataGridViewTextBoxColumn, Me.收費時段結束DataGridViewTextBoxColumn, Me.累進費率DataGridViewCheckBoxColumn, Me.修改人DataGridViewTextBoxColumn, Me.備註DataGridViewTextBoxColumn, Me.修改時間DataGridViewTextBoxColumn})
        Me.DataGridView_all_park.DataSource = Me.車位資料全BindingSource
        Me.DataGridView_all_park.Location = New System.Drawing.Point(21, 75)
        Me.DataGridView_all_park.Name = "DataGridView_all_park"
        Me.DataGridView_all_park.RowTemplate.Height = 27
        Me.DataGridView_all_park.Size = New System.Drawing.Size(1388, 564)
        Me.DataGridView_all_park.TabIndex = 0
        '
        '識別碼DataGridViewTextBoxColumn
        '
        Me.識別碼DataGridViewTextBoxColumn.DataPropertyName = "識別碼"
        DataGridViewCellStyle2.NullValue = "0"
        Me.識別碼DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.識別碼DataGridViewTextBoxColumn.Frozen = True
        Me.識別碼DataGridViewTextBoxColumn.HeaderText = "識別碼"
        Me.識別碼DataGridViewTextBoxColumn.Name = "識別碼DataGridViewTextBoxColumn"
        Me.識別碼DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.識別碼DataGridViewTextBoxColumn.Width = 80
        '
        '編號DataGridViewTextBoxColumn
        '
        Me.編號DataGridViewTextBoxColumn.DataPropertyName = "編號"
        Me.編號DataGridViewTextBoxColumn.HeaderText = "編號"
        Me.編號DataGridViewTextBoxColumn.Name = "編號DataGridViewTextBoxColumn"
        '
        '車位類型DataGridViewTextBoxColumn
        '
        Me.車位類型DataGridViewTextBoxColumn.DataPropertyName = "車位類型"
        Me.車位類型DataGridViewTextBoxColumn.HeaderText = "車位類型"
        Me.車位類型DataGridViewTextBoxColumn.Name = "車位類型DataGridViewTextBoxColumn"
        '
        '車位型態DataGridViewTextBoxColumn
        '
        Me.車位型態DataGridViewTextBoxColumn.DataPropertyName = "車位型態"
        Me.車位型態DataGridViewTextBoxColumn.HeaderText = "車位型態"
        Me.車位型態DataGridViewTextBoxColumn.Name = "車位型態DataGridViewTextBoxColumn"
        '
        '車位狀況DataGridViewTextBoxColumn
        '
        Me.車位狀況DataGridViewTextBoxColumn.DataPropertyName = "車位狀況"
        Me.車位狀況DataGridViewTextBoxColumn.HeaderText = "車位狀況"
        Me.車位狀況DataGridViewTextBoxColumn.Name = "車位狀況DataGridViewTextBoxColumn"
        '
        '行政區DataGridViewTextBoxColumn
        '
        Me.行政區DataGridViewTextBoxColumn.DataPropertyName = "行政區"
        Me.行政區DataGridViewTextBoxColumn.HeaderText = "行政區"
        Me.行政區DataGridViewTextBoxColumn.Name = "行政區DataGridViewTextBoxColumn"
        '
        '道路DataGridViewTextBoxColumn
        '
        Me.道路DataGridViewTextBoxColumn.DataPropertyName = "道路"
        Me.道路DataGridViewTextBoxColumn.HeaderText = "道路"
        Me.道路DataGridViewTextBoxColumn.Name = "道路DataGridViewTextBoxColumn"
        '
        'LatitudeDataGridViewTextBoxColumn
        '
        Me.LatitudeDataGridViewTextBoxColumn.DataPropertyName = "Latitude"
        Me.LatitudeDataGridViewTextBoxColumn.HeaderText = "Latitude"
        Me.LatitudeDataGridViewTextBoxColumn.Name = "LatitudeDataGridViewTextBoxColumn"
        '
        'LongitudeDataGridViewTextBoxColumn
        '
        Me.LongitudeDataGridViewTextBoxColumn.DataPropertyName = "Longitude"
        Me.LongitudeDataGridViewTextBoxColumn.HeaderText = "Longitude"
        Me.LongitudeDataGridViewTextBoxColumn.Name = "LongitudeDataGridViewTextBoxColumn"
        '
        '費率DataGridViewTextBoxColumn
        '
        Me.費率DataGridViewTextBoxColumn.DataPropertyName = "費率"
        Me.費率DataGridViewTextBoxColumn.HeaderText = "費率"
        Me.費率DataGridViewTextBoxColumn.Name = "費率DataGridViewTextBoxColumn"
        '
        '服務時間DataGridViewTextBoxColumn
        '
        Me.服務時間DataGridViewTextBoxColumn.DataPropertyName = "服務時間"
        Me.服務時間DataGridViewTextBoxColumn.HeaderText = "服務時間"
        Me.服務時間DataGridViewTextBoxColumn.Name = "服務時間DataGridViewTextBoxColumn"
        '
        '服務時間結束DataGridViewTextBoxColumn
        '
        Me.服務時間結束DataGridViewTextBoxColumn.DataPropertyName = "服務時間結束"
        Me.服務時間結束DataGridViewTextBoxColumn.HeaderText = "服務時間結束"
        Me.服務時間結束DataGridViewTextBoxColumn.Name = "服務時間結束DataGridViewTextBoxColumn"
        '
        '車格施工日期DataGridViewTextBoxColumn
        '
        Me.車格施工日期DataGridViewTextBoxColumn.DataPropertyName = "車格施工日期"
        Me.車格施工日期DataGridViewTextBoxColumn.HeaderText = "車格施工日期"
        Me.車格施工日期DataGridViewTextBoxColumn.Name = "車格施工日期DataGridViewTextBoxColumn"
        '
        '車格塗銷日期DataGridViewTextBoxColumn
        '
        Me.車格塗銷日期DataGridViewTextBoxColumn.DataPropertyName = "車格塗銷日期"
        Me.車格塗銷日期DataGridViewTextBoxColumn.HeaderText = "車格塗銷日期"
        Me.車格塗銷日期DataGridViewTextBoxColumn.Name = "車格塗銷日期DataGridViewTextBoxColumn"
        '
        '收費時段DataGridViewTextBoxColumn
        '
        Me.收費時段DataGridViewTextBoxColumn.DataPropertyName = "收費時段"
        Me.收費時段DataGridViewTextBoxColumn.HeaderText = "收費時段"
        Me.收費時段DataGridViewTextBoxColumn.Name = "收費時段DataGridViewTextBoxColumn"
        '
        '收費時段結束DataGridViewTextBoxColumn
        '
        Me.收費時段結束DataGridViewTextBoxColumn.DataPropertyName = "收費時段結束"
        Me.收費時段結束DataGridViewTextBoxColumn.HeaderText = "收費時段結束"
        Me.收費時段結束DataGridViewTextBoxColumn.Name = "收費時段結束DataGridViewTextBoxColumn"
        '
        '累進費率DataGridViewCheckBoxColumn
        '
        Me.累進費率DataGridViewCheckBoxColumn.DataPropertyName = "累進費率"
        Me.累進費率DataGridViewCheckBoxColumn.HeaderText = "累進費率"
        Me.累進費率DataGridViewCheckBoxColumn.Name = "累進費率DataGridViewCheckBoxColumn"
        '
        '修改人DataGridViewTextBoxColumn
        '
        Me.修改人DataGridViewTextBoxColumn.DataPropertyName = "修改人"
        Me.修改人DataGridViewTextBoxColumn.HeaderText = "修改人"
        Me.修改人DataGridViewTextBoxColumn.Name = "修改人DataGridViewTextBoxColumn"
        '
        '備註DataGridViewTextBoxColumn
        '
        Me.備註DataGridViewTextBoxColumn.DataPropertyName = "備註"
        Me.備註DataGridViewTextBoxColumn.HeaderText = "備註"
        Me.備註DataGridViewTextBoxColumn.Name = "備註DataGridViewTextBoxColumn"
        '
        '修改時間DataGridViewTextBoxColumn
        '
        Me.修改時間DataGridViewTextBoxColumn.DataPropertyName = "修改時間"
        Me.修改時間DataGridViewTextBoxColumn.HeaderText = "修改時間"
        Me.修改時間DataGridViewTextBoxColumn.Name = "修改時間DataGridViewTextBoxColumn"
        '
        '車位資料全BindingSource
        '
        Me.車位資料全BindingSource.DataMember = "車位資料_全"
        Me.車位資料全BindingSource.DataSource = Me.HackParkingNTUDataSet1
        '
        'HackParkingNTUDataSet1
        '
        Me.HackParkingNTUDataSet1.DataSetName = "HackParkingNTUDataSet1"
        Me.HackParkingNTUDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button_UD2Server
        '
        Me.Button_UD2Server.Enabled = False
        Me.Button_UD2Server.Font = New System.Drawing.Font("微軟正黑體", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button_UD2Server.Location = New System.Drawing.Point(1106, 660)
        Me.Button_UD2Server.Name = "Button_UD2Server"
        Me.Button_UD2Server.Size = New System.Drawing.Size(303, 44)
        Me.Button_UD2Server.TabIndex = 1
        Me.Button_UD2Server.Text = "Add New Data to Server"
        Me.Button_UD2Server.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("微軟正黑體", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button1.Location = New System.Drawing.Point(512, 660)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(291, 44)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Set Data to Server "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button_Refresh
        '
        Me.Button_Refresh.Font = New System.Drawing.Font("微軟正黑體", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button_Refresh.Location = New System.Drawing.Point(809, 660)
        Me.Button_Refresh.Name = "Button_Refresh"
        Me.Button_Refresh.Size = New System.Drawing.Size(291, 44)
        Me.Button_Refresh.TabIndex = 3
        Me.Button_Refresh.Text = "Refresh Database"
        Me.Button_Refresh.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        '車位資料_全TableAdapter
        '
        Me.車位資料_全TableAdapter.ClearBeforeFill = True
        '
        'Label_DataTime
        '
        Me.Label_DataTime.AutoSize = True
        Me.Label_DataTime.Location = New System.Drawing.Point(809, 642)
        Me.Label_DataTime.Name = "Label_DataTime"
        Me.Label_DataTime.Size = New System.Drawing.Size(0, 15)
        Me.Label_DataTime.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(21, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1353, 50)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "臺北市路側停車資料庫   Roadside Parking Place Database of Taipei City"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1507, 719)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label_DataTime)
        Me.Controls.Add(Me.Button_Refresh)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button_UD2Server)
        Me.Controls.Add(Me.DataGridView_all_park)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "臺北市路側停車資料庫管理系統"
        CType(Me.HackParkingNTUDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.車位資料BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_all_park, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.車位資料全BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HackParkingNTUDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HackParkingNTUDataSet As HackParkingNTUDataSet
    Friend WithEvents 車位資料BindingSource As BindingSource
    Friend WithEvents 車位資料TableAdapter As HackParkingNTUDataSetTableAdapters.車位資料TableAdapter
    Friend WithEvents HackParkingNTUDataSet1 As HackParkingNTUDataSet1
    Friend WithEvents 車位資料全BindingSource As BindingSource
    Friend WithEvents 車位資料_全TableAdapter As HackParkingNTUDataSet1TableAdapters.車位資料_全TableAdapter
    Friend WithEvents DataGridView_all_park As DataGridView
    Friend WithEvents Button_UD2Server As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button_Refresh As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents 識別碼DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 編號DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 車位類型DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 車位型態DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 車位狀況DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 行政區DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 道路DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LatitudeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LongitudeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 費率DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 服務時間DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 服務時間結束DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 車格施工日期DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 車格塗銷日期DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 收費時段DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 收費時段結束DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 累進費率DataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents 修改人DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 備註DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 修改時間DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label_DataTime As Label
    Friend WithEvents Label1 As Label
End Class
