Public Class Form2
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.AcceptsReturn = True
        Me.Text = "Livello 1"
        PictureBox1.Image = My.Resources.Misunderstood
    End Sub
    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter = True Then
            If TextBox1.Text = "misunderstood" And PictureBox1.Visible = True Then
                PictureBox1.Visible = False
                PictureBox2.Visible = True
                PictureBox3.Visible = False
                PictureBox4.Visible = False
                PictureBox5.Visible = False
                PictureBox6.Visible = False
                PictureBox7.Visible = False
                PictureBox8.Visible = False
                PictureBox9.Visible = False
                PictureBox10.Visible = False
                PictureBox11.Visible = False
                PictureBox12.Visible = False
                PictureBox13.Visible = False
                PictureBox14.Visible = False
                PictureBox15.Visible = False
                PictureBox16.Visible = False
                PictureBox17.Visible = False
                PictureBox18.Visible = False
                PictureBox19.Visible = False
                Me.Text = "Livello 2"
                TextBox1.Text = ""
                TextBox1.Focus()
            End If
            If TextBox1.Text = "angels" And PictureBox2.Visible = True Then
                PictureBox1.Visible = False
                PictureBox2.Visible = False
                PictureBox3.Visible = True
                PictureBox4.Visible = False
                PictureBox5.Visible = False
                PictureBox6.Visible = False
                PictureBox7.Visible = False
                PictureBox8.Visible = False
                PictureBox9.Visible = False
                PictureBox10.Visible = False
                PictureBox11.Visible = False
                PictureBox12.Visible = False
                PictureBox13.Visible = False
                PictureBox14.Visible = False
                PictureBox15.Visible = False
                PictureBox16.Visible = False
                PictureBox17.Visible = False
                PictureBox18.Visible = False
                PictureBox19.Visible = False
                Me.Text = "Livello 3"
                TextBox1.Text = ""
                TextBox1.Focus()
            End If
            If TextBox1.Text = "feel" And PictureBox3.Visible = True Then
                PictureBox1.Visible = False
                PictureBox2.Visible = False
                PictureBox3.Visible = False
                PictureBox4.Visible = True
                PictureBox5.Visible = False
                PictureBox6.Visible = False
                PictureBox7.Visible = False
                PictureBox8.Visible = False
                PictureBox9.Visible = False
                PictureBox10.Visible = False
                PictureBox11.Visible = False
                PictureBox12.Visible = False
                PictureBox13.Visible = False
                PictureBox14.Visible = False
                PictureBox15.Visible = False
                PictureBox16.Visible = False
                PictureBox17.Visible = False
                PictureBox18.Visible = False
                PictureBox19.Visible = False
                Me.Text = "Livello 4"
                TextBox1.Text = ""
                TextBox1.Focus()
            End If
            If TextBox1.Text = "be a boy" And PictureBox4.Visible = True Then
                PictureBox1.Visible = False
                PictureBox2.Visible = False
                PictureBox3.Visible = False
                PictureBox4.Visible = False
                PictureBox5.Visible = True
                PictureBox6.Visible = False
                PictureBox7.Visible = False
                PictureBox8.Visible = False
                PictureBox9.Visible = False
                PictureBox10.Visible = False
                PictureBox11.Visible = False
                PictureBox12.Visible = False
                PictureBox13.Visible = False
                PictureBox14.Visible = False
                PictureBox15.Visible = False
                PictureBox16.Visible = False
                PictureBox17.Visible = False
                PictureBox18.Visible = False
                PictureBox19.Visible = False
                Me.Text = "Livello 5"
                TextBox1.Text = ""
                TextBox1.Focus()
            End If
            If TextBox1.Text = "different" And PictureBox5.Visible = True Then
                PictureBox1.Visible = False
                PictureBox2.Visible = False
                PictureBox3.Visible = False
                PictureBox4.Visible = False
                PictureBox5.Visible = False
                PictureBox6.Visible = True
                PictureBox7.Visible = False
                PictureBox8.Visible = False
                PictureBox9.Visible = False
                PictureBox10.Visible = False
                PictureBox11.Visible = False
                PictureBox12.Visible = False
                PictureBox13.Visible = False
                PictureBox14.Visible = False
                PictureBox15.Visible = False
                PictureBox16.Visible = False
                PictureBox17.Visible = False
                PictureBox18.Visible = False
                PictureBox19.Visible = False
                Me.Text = "Livello 6"
                TextBox1.Text = ""
                TextBox1.Focus()
            End If
            If TextBox1.Text = "eternity" And PictureBox6.Visible = True Then
                PictureBox1.Visible = False
                PictureBox2.Visible = False
                PictureBox3.Visible = False
                PictureBox4.Visible = False
                PictureBox5.Visible = False
                PictureBox6.Visible = False
                PictureBox7.Visible = True
                PictureBox8.Visible = False
                PictureBox9.Visible = False
                PictureBox10.Visible = False
                PictureBox11.Visible = False
                PictureBox12.Visible = False
                PictureBox13.Visible = False
                PictureBox14.Visible = False
                PictureBox15.Visible = False
                PictureBox16.Visible = False
                PictureBox17.Visible = False
                PictureBox18.Visible = False
                PictureBox19.Visible = False
                Me.Text = "Livello 7"
                TextBox1.Text = ""
                TextBox1.Focus()
            End If
            If TextBox1.Text = "dance with the devil" And PictureBox7.Visible = True Then
                PictureBox1.Visible = False
                PictureBox2.Visible = False
                PictureBox3.Visible = False
                PictureBox4.Visible = False
                PictureBox5.Visible = False
                PictureBox6.Visible = False
                PictureBox7.Visible = False
                PictureBox8.Visible = True
                PictureBox9.Visible = False
                PictureBox10.Visible = False
                PictureBox11.Visible = False
                PictureBox12.Visible = False
                PictureBox13.Visible = False
                PictureBox14.Visible = False
                PictureBox15.Visible = False
                PictureBox16.Visible = False
                PictureBox17.Visible = False
                PictureBox18.Visible = False
                PictureBox19.Visible = False
                Me.Text = "Livello 8"
                TextBox1.Text = ""
                TextBox1.Focus()
            End If
            If TextBox1.Text = "candy" And PictureBox8.Visible = True Then
                PictureBox1.Visible = False
                PictureBox2.Visible = False
                PictureBox3.Visible = False
                PictureBox4.Visible = False
                PictureBox5.Visible = False
                PictureBox6.Visible = False
                PictureBox7.Visible = False
                PictureBox8.Visible = False
                PictureBox9.Visible = True
                PictureBox10.Visible = False
                PictureBox11.Visible = False
                PictureBox12.Visible = False
                PictureBox13.Visible = False
                PictureBox14.Visible = False
                PictureBox15.Visible = False
                PictureBox16.Visible = False
                PictureBox17.Visible = False
                PictureBox18.Visible = False
                PictureBox19.Visible = False
                Me.Text = "Livello 9"
                TextBox1.Text = ""
                TextBox1.Focus()
            End If
            If TextBox1.Text = "come undone" And PictureBox9.Visible = True Then
                PictureBox1.Visible = False
                PictureBox2.Visible = False
                PictureBox3.Visible = False
                PictureBox4.Visible = False
                PictureBox5.Visible = False
                PictureBox6.Visible = False
                PictureBox7.Visible = False
                PictureBox8.Visible = False
                PictureBox9.Visible = False
                PictureBox10.Visible = True
                PictureBox11.Visible = False
                PictureBox12.Visible = False
                PictureBox13.Visible = False
                PictureBox14.Visible = False
                PictureBox15.Visible = False
                PictureBox16.Visible = False
                PictureBox17.Visible = False
                PictureBox18.Visible = False
                PictureBox19.Visible = False
                Me.Text = "Livello 10"
                TextBox1.Text = ""
                TextBox1.Focus()
            End If
            If TextBox1.Text = "no regrets" And PictureBox10.Visible = True Then
                PictureBox1.Visible = False
                PictureBox2.Visible = False
                PictureBox3.Visible = False
                PictureBox4.Visible = False
                PictureBox5.Visible = False
                PictureBox6.Visible = False
                PictureBox7.Visible = False
                PictureBox8.Visible = False
                PictureBox9.Visible = False
                PictureBox10.Visible = False
                PictureBox11.Visible = True
                PictureBox12.Visible = False
                PictureBox13.Visible = False
                PictureBox14.Visible = False
                PictureBox15.Visible = False
                PictureBox16.Visible = False
                PictureBox17.Visible = False
                PictureBox18.Visible = False
                PictureBox19.Visible = False
                Me.Text = "Livello 11"
                TextBox1.Text = ""
                TextBox1.Focus()
            End If
            If TextBox1.Text = "me and my monkey" And PictureBox11.Visible = True Then
                PictureBox1.Visible = False
                PictureBox2.Visible = False
                PictureBox3.Visible = False
                PictureBox4.Visible = False
                PictureBox5.Visible = False
                PictureBox6.Visible = False
                PictureBox7.Visible = False
                PictureBox8.Visible = False
                PictureBox9.Visible = False
                PictureBox10.Visible = False
                PictureBox11.Visible = False
                PictureBox12.Visible = True
                PictureBox13.Visible = False
                PictureBox14.Visible = False
                PictureBox15.Visible = False
                PictureBox16.Visible = False
                PictureBox17.Visible = False
                PictureBox18.Visible = False
                PictureBox19.Visible = False
                Me.Text = "Livello 12"
                TextBox1.Text = ""
                TextBox1.Focus()
            End If
            If TextBox1.Text = "rock dj" And PictureBox12.Visible = True Then
                PictureBox1.Visible = False
                PictureBox2.Visible = False
                PictureBox3.Visible = False
                PictureBox4.Visible = False
                PictureBox5.Visible = False
                PictureBox6.Visible = False
                PictureBox7.Visible = False
                PictureBox8.Visible = False
                PictureBox9.Visible = False
                PictureBox10.Visible = False
                PictureBox11.Visible = False
                PictureBox12.Visible = False
                PictureBox13.Visible = True
                PictureBox14.Visible = False
                PictureBox15.Visible = False
                PictureBox16.Visible = False
                PictureBox17.Visible = False
                PictureBox18.Visible = False
                PictureBox19.Visible = False
                Me.Text = "Livello 13"
                TextBox1.Text = ""
                TextBox1.Focus()
            End If

            If TextBox1.Text = "go gentle" And PictureBox13.Visible = True Then
                PictureBox1.Visible = False
                PictureBox2.Visible = False
                PictureBox3.Visible = False
                PictureBox4.Visible = False
                PictureBox5.Visible = False
                PictureBox6.Visible = False
                PictureBox7.Visible = False
                PictureBox8.Visible = False
                PictureBox9.Visible = False
                PictureBox10.Visible = False
                PictureBox11.Visible = False
                PictureBox12.Visible = False
                PictureBox13.Visible = False
                PictureBox14.Visible = True
                PictureBox15.Visible = False
                PictureBox16.Visible = False
                PictureBox17.Visible = False
                PictureBox18.Visible = False
                PictureBox19.Visible = False
                Me.Text = "Livello 14"
                TextBox1.Text = ""
                TextBox1.Focus()
            End If
            If TextBox1.Text = "shame" And PictureBox14.Visible = True Then
                PictureBox1.Visible = False
                PictureBox2.Visible = False
                PictureBox3.Visible = False
                PictureBox4.Visible = False
                PictureBox5.Visible = False
                PictureBox6.Visible = False
                PictureBox7.Visible = False
                PictureBox8.Visible = False
                PictureBox9.Visible = False
                PictureBox10.Visible = False
                PictureBox11.Visible = False
                PictureBox12.Visible = False
                PictureBox13.Visible = False
                PictureBox14.Visible = False
                PictureBox15.Visible = True
                PictureBox16.Visible = False
                PictureBox17.Visible = False
                PictureBox18.Visible = False
                PictureBox19.Visible = False
                Me.Text = "Livello 15"
                TextBox1.Text = ""
                TextBox1.Focus()
            End If
            If TextBox1.Text = "she's the one" And PictureBox15.Visible = True Then
                PictureBox1.Visible = False
                PictureBox2.Visible = False
                PictureBox3.Visible = False
                PictureBox4.Visible = False
                PictureBox5.Visible = False
                PictureBox6.Visible = False
                PictureBox7.Visible = False
                PictureBox8.Visible = False
                PictureBox9.Visible = False
                PictureBox10.Visible = False
                PictureBox11.Visible = False
                PictureBox12.Visible = False
                PictureBox13.Visible = False
                PictureBox14.Visible = False
                PictureBox15.Visible = False
                PictureBox16.Visible = True
                PictureBox17.Visible = False
                PictureBox18.Visible = False
                PictureBox19.Visible = False
                Me.Text = "Livello 16"
                TextBox1.Text = ""
                TextBox1.Focus()
            End If
            If TextBox1.Text = "something stupid" And PictureBox16.Visible = True Then
                PictureBox1.Visible = False
                PictureBox2.Visible = False
                PictureBox3.Visible = False
                PictureBox4.Visible = False
                PictureBox5.Visible = False
                PictureBox6.Visible = False
                PictureBox7.Visible = False
                PictureBox8.Visible = False
                PictureBox9.Visible = False
                PictureBox10.Visible = False
                PictureBox11.Visible = False
                PictureBox12.Visible = False
                PictureBox13.Visible = False
                PictureBox14.Visible = False
                PictureBox15.Visible = False
                PictureBox16.Visible = False
                PictureBox17.Visible = True
                PictureBox18.Visible = False
                PictureBox19.Visible = False
                Me.Text = "Livello 17"
                TextBox1.Text = ""
                TextBox1.Focus()
            End If
            If TextBox1.Text = "supreme" And PictureBox17.Visible = True Then
                PictureBox1.Visible = False
                PictureBox2.Visible = False
                PictureBox3.Visible = False
                PictureBox4.Visible = False
                PictureBox5.Visible = False
                PictureBox6.Visible = False
                PictureBox7.Visible = False
                PictureBox8.Visible = False
                PictureBox9.Visible = False
                PictureBox10.Visible = False
                PictureBox11.Visible = False
                PictureBox12.Visible = False
                PictureBox13.Visible = False
                PictureBox14.Visible = False
                PictureBox15.Visible = False
                PictureBox16.Visible = False
                PictureBox17.Visible = False
                PictureBox18.Visible = True
                PictureBox19.Visible = False
                Me.Text = "Livello 18"
                TextBox1.Text = ""
                TextBox1.Focus()
            End If
            If TextBox1.Text = "tripping" And PictureBox18.Visible = True Then
                PictureBox1.Visible = False
                PictureBox2.Visible = False
                PictureBox3.Visible = False
                PictureBox4.Visible = False
                PictureBox5.Visible = False
                PictureBox6.Visible = False
                PictureBox7.Visible = False
                PictureBox8.Visible = False
                PictureBox9.Visible = False
                PictureBox10.Visible = False
                PictureBox11.Visible = False
                PictureBox12.Visible = False
                PictureBox13.Visible = False
                PictureBox14.Visible = False
                PictureBox15.Visible = False
                PictureBox16.Visible = False
                PictureBox17.Visible = False
                PictureBox18.Visible = False
                PictureBox19.Visible = True
                Me.Text = "Congratulazioni!"
                TextBox1.Hide()
                TextBox2.Hide()
                Button1.Visible = True
                Button2.Visible = False
            End If
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form3.Show()
        Form1.Button2.Visible = True
        Me.Close()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form4.Show()
    End Sub
End Class
