
Public Class Form1
    Dim NForm2 As New Form2
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 這行程式碼會將資料載入 'HackParkingNTUDataSet1.車位資料_全' 資料表。您可以視需要進行移動或移除。
        Me.車位資料_全TableAdapter.Fill(Me.HackParkingNTUDataSet1.車位資料_全)
        'TODO: 這行程式碼會將資料載入 'HackParkingNTUDataSet.車位資料' 資料表。您可以視需要進行移動或移除。
        Me.車位資料TableAdapter.Fill(Me.HackParkingNTUDataSet.車位資料)
        Button_UD2Server.Enabled = True


    End Sub

    Private Sub Button_UD2Server_Click(sender As Object, e As EventArgs) Handles Button_UD2Server.Click
        NForm2.Show()
        '車位資料_全TableAdapter.Insert(33, "T0000001", 1, 1, 0, 0, "sss", 100, 100, 100, 100, 100, "2002/2/2", "2001/1/1", 100, 100, 100, "100", 100, "2006/8/7")
        '車位資料_全TableAdapter.Update(DataGridView_all_park.DataSource)
        Me.車位資料_全TableAdapter.Fill(Me.HackParkingNTUDataSet1.車位資料_全)
    End Sub

    Private Sub DataGridView_all_park_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_all_park.CellValueChanged
        Button_UD2Server.Enabled = True

    End Sub

    Private Sub Button_Refresh_Click(sender As Object, e As EventArgs) Handles Button_Refresh.Click
        Me.車位資料_全TableAdapter.Fill(Me.HackParkingNTUDataSet1.車位資料_全)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.車位資料_全TableAdapter.Fill(Me.HackParkingNTUDataSet1.車位資料_全)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
