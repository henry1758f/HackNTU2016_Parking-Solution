Imports System.Data.SqlClient

Public Class Form1
    Dim cmdBuilder As SqlCommandBuilder
    Dim da As SqlDataAdapter
    Dim CustomersDataSet As New DataSet()
    Dim NForm2 As New Form2
    Dim NForm3 As New Form3
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 這行程式碼會將資料載入 'HackParkingNTUDataSet1.車位資料_全' 資料表。您可以視需要進行移動或移除。
        Me.車位資料_全TableAdapter.Fill(Me.HackParkingNTUDataSet1.車位資料_全)
        'TODO: 這行程式碼會將資料載入 'HackParkingNTUDataSet.車位資料' 資料表。您可以視需要進行移動或移除。
        Me.車位資料TableAdapter.Fill(Me.HackParkingNTUDataSet.車位資料)
        Button_UD2Server.Enabled = True
        Label_DataTime.Text = "資料時間:" + DateString + TimeOfDay

    End Sub

    Private Sub Button_UD2Server_Click(sender As Object, e As EventArgs) Handles Button_UD2Server.Click
        NForm2.ShowDialog(Me)
        '車位資料_全TableAdapter.Insert(33, "T0000001", 1, 1, 0, 0, "sss", 100, 100, 100, 100, 100, "2002/2/2", "2001/1/1", 100, 100, 100, "100", 100, "2006/8/7")
        '車位資料_全TableAdapter.Update(DataGridView_all_park.DataSource)
        Me.車位資料_全TableAdapter.Fill(Me.HackParkingNTUDataSet1.車位資料_全)
    End Sub

    Private Sub DataGridView_all_park_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_all_park.CellValueChanged
        Button_UD2Server.Enabled = True

    End Sub

    Private Sub Button_Refresh_Click(sender As Object, e As EventArgs) Handles Button_Refresh.Click
        Me.車位資料_全TableAdapter.Fill(HackParkingNTUDataSet1.車位資料_全)

        Label_DataTime.Text = "資料時間:" + DateString + TimeOfDay
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.車位資料_全TableAdapter.Fill(Me.HackParkingNTUDataSet1.車位資料_全)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NForm3.ShowDialog(Me)

        'Dim command As SqlCommand = New SqlCommand("ALTER TABLE Customer ADD PRIMARY KEY (SID);")
        'Using connection As New SqlConnection("Server=tcp:hackparkingntu.database.windows.net,1433;Initial Catalog=HackParkingNTU;Persist Security Info=False;User ID=henry1758f;Password=HackNTU1995/03/29;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
        '    connection.Open()

        'da = New SqlDataAdapter("select * from 車位資料_全 order by 識別碼", connection)
        'cmdBuilder = New SqlCommandBuilder(da)
        'da.Fill(CustomersDataSet, "車位資料_全")
        'CustomersDataSet.Tables("車位資料_全").Rows(12)("車位狀況") = "50"

        'Dim commandup As New SqlCommand("UPDATE ", connection)
        '' Create an instance of a DataAdapter.
        'Dim daAuthors As _
        'New SqlDataAdapter("Select * From Authors", connection)
        '' Create an instance of a DataSet and retreive data from the Authors table.
        'Dim dsPubs As New DataSet("Pubs")
        'daAuthors.FillSchema(dsPubs, SchemaType.Source, "Authors")
        'daAuthors.Fill(dsPubs, "Authors")

        ''Dim objCommandBuilder As New SqlCommandBuilder(daAuthors)
        'Dim objCommandBuilder As New SqlCommandBuilder()
        'da.Update(CustomersDataSet, "車位資料_全")


        'Me.Validate()
        'Me.車位資料全BindingSource.EndEdit()
        'Me.車位資料_全TableAdapter.Update(Me.HackParkingNTUDataSet1.車位資料_全)

        'End Using

    End Sub

End Class
