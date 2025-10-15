Public Class Form4
    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.AcceptsReturn = True
    End Sub
    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter = True Then
            If TextBox1.Text = "undertaker" Then
                Form2.PictureBox18.Visible = True
                Form2.PictureBox1.Visible = False
                Form2.PictureBox2.Visible = False
                Form2.PictureBox3.Visible = False
                Form2.PictureBox4.Visible = False
                Form2.PictureBox5.Visible = False
                Form2.PictureBox6.Visible = False
                Form2.PictureBox7.Visible = False
                Form2.PictureBox8.Visible = False
                Form2.PictureBox9.Visible = False
                Form2.PictureBox10.Visible = False
                Form2.PictureBox11.Visible = False
                Form2.PictureBox12.Visible = False
                Form2.PictureBox13.Visible = False
                Form2.PictureBox14.Visible = False
                Form2.PictureBox15.Visible = False
                Form2.PictureBox16.Visible = False
                Form2.PictureBox17.Visible = False
                Form2.PictureBox19.Visible = False
                Me.Close()
                Form2.TextBox1.Focus()
            End If
        End If
    End Sub
End Class