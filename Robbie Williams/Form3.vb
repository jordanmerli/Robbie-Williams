Public Class Form3
    Private Sub Form3_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter
        If Button1.Enabled = False Then
            MsgBox("Hai perso! L'auto di Robbie è finita fuori strada!")
            Me.Close()
        End If
    End Sub
    Private Sub Label1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.MouseEnter
        MsgBox("Hai accompagnato Robbie a letto con successo. Gustati un drink come lui!")
        Form5.Show()
        Me.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label1.Enabled = True
        Button1.Enabled = False
    End Sub
End Class