Imports System.IO

Public Class Form1
    Dim down = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.BackColor = Color.White
        PictureBox2.BackColor = Color.Black
        Timer1.Start()
        Form2.Show()
        Form2.Hide()
        Me.AutoSize = True
        Me.PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If CheckBox3.Checked = True Then
            Dim label1 As New Label
            label1.Name = "label1"
            label1.Text = "Your Text"
            label1.AutoSize = False
            label1.Location = New Point((PictureBox1.Width) \ 2, (PictureBox1.Height) \ 2)
            PictureBox1.Controls.Add(label1)
        End If
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        down = True
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        Dim brushcolor As New SolidBrush(ColorDialog1.Color)
        If CheckBox1.Checked = True Then
            If down = True Then
                PictureBox1.CreateGraphics.FillEllipse(brushcolor, e.X, e.Y, Form2.NumericUpDown1.Value, Form2.NumericUpDown1.Value)
            End If
        End If
        If CheckBox2.Checked = True Then
            If down = True Then
                PictureBox1.CreateGraphics.FillEllipse(Brushes.White, e.X, e.Y, Form2.NumericUpDown1.Value, Form2.NumericUpDown1.Value)
            End If
        End If
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        down = False
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Form3.Show()
        PictureBox1.Refresh()
        PictureBox1.Image = Nothing
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        CheckBox2.Checked = False
        CheckBox3.Checked = False
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        ColorDialog1.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox2.BackColor = ColorDialog1.Color
        PictureBox2.Refresh()
    End Sub

    Private Sub BrushSizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BrushSizeToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim open As New OpenFileDialog()
        open.Filter = "Image Files(*.png; *.jpg; *.bmp; *.gif)|*.png; *.jpg; *.bmp; *.gif"
        If open.ShowDialog() = DialogResult.OK Then
            Dim fileName As String = System.IO.Path.GetFullPath(open.FileName)
            PictureBox1.Image = New Bitmap(open.FileName)
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        CheckBox1.Checked = False
        CheckBox3.Checked = False
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        CheckBox1.Checked = False
        CheckBox2.Checked = False
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
        SaveFileDialog1.Filter = "Image File | *.png"
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            PictureBox1.Image.Save(SaveFileDialog1.FileName)
        End If
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk

    End Sub
End Class