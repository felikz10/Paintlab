Public Class Form3

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.PictureBox1.Width = TextBox1.Text
        Form1.PictureBox1.Height = TextBox2.Text
        Form1.PictureBox1.Anchor = AnchorStyles.Bottom
        Form1.PictureBox1.Anchor = AnchorStyles.Top
        Form1.PictureBox1.Anchor = AnchorStyles.Left
        Form1.PictureBox1.Anchor = AnchorStyles.Right
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
End Class