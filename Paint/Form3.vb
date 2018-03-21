Public Class Form3

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text > 1920 And TextBox2.Text > 1080 Then
            MessageBox.Show("Error: Size cannot be bigger than 1920x1080!")
        Else
            Form1.PictureBox1.Width = TextBox1.Text
            Form1.PictureBox1.Height = TextBox2.Text
            Form1.PictureBox1.Anchor = AnchorStyles.Bottom
            Form1.PictureBox1.Anchor = AnchorStyles.Top
            Form1.PictureBox1.Anchor = AnchorStyles.Left
            Form1.PictureBox1.Anchor = AnchorStyles.Right
            Form1.AutoSize = True
            Form1.PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
            Me.Hide()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
End Class