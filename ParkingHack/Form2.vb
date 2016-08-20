Public Class Form2
    'Dim msg As String = "您即將新增一筆資料至資料庫：識別碼" + TextBox1.Text + vbCrLf + "編號:" + TextBox2.Text + "121212"
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim res As Integer

        res = MsgBox("確定寫入資料庫?", MsgBoxStyle.YesNoCancel, "資料庫寫入警告")
        If res = 1 Then
            'Form1.車位資料_全TableAdapter.Insert(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, TextBox8.Text, TextBox9.Text, TextBox10.Text, TextBox11.Text, TextBox12.Text, TextBox13.Text.ToString, TextBox14.Text.ToString, TextBox15.Text, TextBox16.Text, TextBox17.Text, TextBox18.Text, TextBox19.Text, TextBox20.Text.ToString)
        ElseIf res = 2 Then
            Close()
        Else
            Form1.車位資料_全TableAdapter.Insert(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, TextBox8.Text, TextBox9.Text, TextBox10.Text, TextBox11.Text, TextBox12.Text, TextBox13.Text, TextBox14.Text, TextBox15.Text, TextBox16.Text, TextBox17.Text, TextBox18.Text, TextBox19.Text, TextBox20.Text)
            Close()
        End If
    End Sub
End Class