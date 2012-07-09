Public Class Form2


    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
        PictureBox1.Width = 200 + TrackBar1.Value
        PictureBox5.Width = 220 + TrackBar1.Value
        TextBox1.Text = TrackBar1.Value
    End Sub

    Private Sub Form2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        TrackBar1.Value = Form1.correctionOut - 200
        PictureBox1.Width = 200 + TrackBar1.Value
        PictureBox5.Width = 220 + TrackBar1.Value
        TextBox1.Text = TrackBar1.Value
        'Label1.Text = 
        Label1.Text = My.Resources.ResourceManager.GetString("step" & Form1.lang) & _
        My.Resources.ResourceManager.GetString("stepthen" & Form1.lang)

        '"How To: Find a standard bank card(e.g, credit card, client card, whatever). Attach the shorter edges to the pic on lower right corner," & _
        '"then scroll the trackbar to control the size of the pic, make sure it fixed your card correctly. Then click OK."

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1.correctionOut = TrackBar1.Value + 200
        Form1.WriteRuler()
        Me.Dispose()
    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text <> "" Then
            If Convert.ToInt16(TextBox1.Text) > 60 Then
                TextBox1.Text = 60
            End If
            TrackBar1.Value = TextBox1.Text
        End If
        'Or (TextBox1.Text <> "" And Convert.ToInt16(TextBox1.Text) > 60)
        'Debug.Print(Convert.ToInt16(TextBox1.Text))

    End Sub
End Class