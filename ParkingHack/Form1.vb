Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 這行程式碼會將資料載入 'HackParkingNTUDataSet1.車位資料_全' 資料表。您可以視需要進行移動或移除。
        Me.車位資料_全TableAdapter.Fill(Me.HackParkingNTUDataSet1.車位資料_全)
        'TODO: 這行程式碼會將資料載入 'HackParkingNTUDataSet.車位資料' 資料表。您可以視需要進行移動或移除。
        Me.車位資料TableAdapter.Fill(Me.HackParkingNTUDataSet.車位資料)
        Button_UD2Server.Enabled = False

    End Sub

    Private Sub Button_UD2Server_Click(sender As Object, e As EventArgs) Handles Button_UD2Server.Click

    End Sub

    Private Sub DataGridView_all_park_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_all_park.CellValueChanged
        Button_UD2Server.Enabled = True

    End Sub
End Class
