Public Class Form5
    Private Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Long, ByVal hwndCallback As Long) As Long
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        mciSendString("set cdaudio door open", 0, 0, 0)
        Label1.Visible = False
        Label2.Visible = True
    End Sub
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        mciSendString("set cdaudio door closed", 0, 0, 0)
        Label1.Visible = False
        Label2.Visible = False
        Me.Close()
    End Sub
End Class