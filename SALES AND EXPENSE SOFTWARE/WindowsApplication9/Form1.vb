Public Class Form1
    Dim cp As Double
    Dim sp As Double
    Dim ex As Double
    Dim ig As Double
    Dim tg As Double
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        Me.MinimizeBox = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cp = TextBox1.Text
        sp = TextBox2.Text
        ex = TextBox3.Text
        ig = sp - cp
        tg = ig - ex
        TextBox4.Text = ig
        TextBox5.Text = tg
        Label7.Text = TimeOfDay
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PrintDialog1.ShowDialog()
        PrintForm1.Print()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class
