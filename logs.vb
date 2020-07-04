Public Class logs
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Public Sub AddLog(Message As String)
        Dim NewLog As String
        NewLog = "[" + DateTime.Now.ToString("HH:mm:ss") + "] - " + Message
        TB_Logs.Text = NewLog + vbNewLine + TB_Logs.Text
    End Sub

    Private Sub logs_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AddLog("Test")
    End Sub
End Class