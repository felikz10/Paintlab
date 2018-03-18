Imports System.IO

Public Class Form1
    Dim down = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox2.BackColor = Color.Black
        Timer1.Start()
        Form2.Show()
        Form2.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        down = True
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        Dim brushcolor As New SolidBrush(ColorDialog1.Color)
        If CheckBox1.Checked = True Then
            CheckBox1.BackColor = Color.RoyalBlue
            If down = True Then
                PictureBox1.CreateGraphics.FillEllipse(brushcolor, e.X, e.Y, Form2.NumericUpDown1.Value, Form2.NumericUpDown1.Value)
            End If
        End If
        If CheckBox2.Checked = True Then
            CheckBox2.BackColor = Color.RoyalBlue

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

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        ColorDialog1.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox2.BackColor = ColorDialog1.Color
        PictureBox2.Refresh()
        If CheckBox1.Checked = False Then
            CheckBox1.BackColor = Color.Transparent
        End If
        If CheckBox2.Checked = False Then
            CheckBox2.BackColor = Color.Transparent
        End If
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

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

    End Sub
End Class
