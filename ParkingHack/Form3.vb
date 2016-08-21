Imports System.Data.SqlClient
Public Class Form3
    Dim cmdBuilder As SqlCommandBuilder
    Dim da As SqlDataAdapter
    Dim CustomersDataSet As New DataSet()
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 這行程式碼會將資料載入 'HackParkingNTUDataSet1.車位資料_全' 資料表。您可以視需要進行移動或移除。
        Me.車位資料_全TableAdapter.Fill(Me.HackParkingNTUDataSet1.車位資料_全)
        Using connection As New SqlConnection("Server=tcp:hackparkingntu.database.windows.net,1433;Initial Catalog=HackParkingNTU;Persist Security Info=False;User ID=henry1758f;Password=HackNTU1995/03/29;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
            connection.Open()

            da = New SqlDataAdapter("select * from 車位資料_全 order by 識別碼", connection)
            cmdBuilder = New SqlCommandBuilder(da)
            da.Fill(CustomersDataSet, "車位資料_全")
            connection.Close()
            'CustomersDataSet.Tables("車位資料_全").Rows(12)("車位狀況") = "50"
        End Using

    End Sub

    Private Sub ComboBox_ID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_ID.SelectedIndexChanged
        If ComboBox_column.Text IsNot vbNullString Then
            Try
                TextBox_pre.Text = CustomersDataSet.Tables("車位資料_全").Rows(ComboBox_ID.Text)(ComboBox_column.Text)
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using connection As New SqlConnection("Server=tcp:hackparkingntu.database.windows.net,1433;Initial Catalog=HackParkingNTU;Persist Security Info=False;User ID=henry1758f;Password=HackNTU1995/03/29;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
            connection.Open()
            da = New SqlDataAdapter("select * from 車位資料_全 order by 識別碼", connection)
            cmdBuilder = New SqlCommandBuilder(da)
            da.Fill(CustomersDataSet, "車位資料_全")
            Try
                CustomersDataSet.Tables("車位資料_全").Rows(ComboBox_ID.Text - 1)(ComboBox_column.Text) = TextBox_correct.Text
                da.Update(CustomersDataSet, "車位資料_全")
                MsgBox("變更資料成功", MsgBoxStyle.Information, "資料庫變更成功!")
                Form1.車位資料_全TableAdapter.Fill(HackParkingNTUDataSet1.車位資料_全)
            Catch ex As Exception
                MsgBox("變更資料時發生問題!請重新再試!", MsgBoxStyle.Critical, "資料庫變更失敗")
            End Try
            connection.Close()
        End Using


        Me.Close()
    End Sub

    Private Sub ComboBox_column_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_column.SelectedIndexChanged
        If ComboBox_column.Text IsNot vbNullString Then
            Try
                TextBox_pre.Text = CustomersDataSet.Tables("車位資料_全").Rows(ComboBox_ID.Text)(ComboBox_column.Text)
            Catch ex As Exception

            End Try

        End If
    End Sub
End Class