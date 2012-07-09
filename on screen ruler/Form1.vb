Imports System.Drawing.Image
Imports System.IO.Stream
Imports System.Drawing.Drawing2D

Public Class Form1

    Private mouse_offset As Point
    Private markcolor As Drawing.Color
    Private rulercolor As Drawing.Color
    Private backgcolor As Drawing.Color
    Private markyes As Boolean
    Public correctionOut, correctionIn As Int16
    Private correction As Boolean
    Private unit As Int16
    Private rulerTop, rulerLeft, rulerRight, rulerBottom As Boolean
    Private onTop As Boolean
    Private showmarks As Boolean 'H水平
    Private showmarksvs As Boolean 'V垂直
    Private prevmark As Image
    Private correcting As Boolean
    Private prevFormW, prevFormH As Int16
    Private correctusing As Int16
    Public lang As Int16
    Private emptymark As Boolean
    Dim rr = 0

    Private Sub Form1_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Try
            SaveSetting("On Screen Rluer By BenZhe", "Setting", "rulercolor", rulercolor.ToArgb)
            SaveSetting("On Screen Rluer By BenZhe", "Setting", "markcolor", markcolor.ToArgb)
            SaveSetting("On Screen Rluer By BenZhe", "Setting", "unit", unit)
            SaveSetting("On Screen Rluer By BenZhe", "Setting", "correctionOut", correctionOut)
            SaveSetting("On Screen Rluer By BenZhe", "Setting", "correctionIn", correctionIn)
            SaveSetting("On Screen Rluer By BenZhe", "Setting", "correction", correction)
            SaveSetting("On Screen Rluer By BenZhe", "Setting", "showmarks", showmarks)
            SaveSetting("On Screen Rluer By BenZhe", "Setting", "showmarksvs", showmarksvs)
            SaveSetting("On Screen Rluer By BenZhe", "Setting", "ontop", onTop)
            SaveSetting("On Screen Rluer By BenZhe", "Setting", "rulerTop", rulerTop)
            SaveSetting("On Screen Rluer By BenZhe", "Setting", "rulerLeft", rulerLeft)
            SaveSetting("On Screen Rluer By BenZhe", "Setting", "lang", lang)
            SaveSetting("On Screen Rluer By BenZhe", "Setting", "backgcolor", backgcolor.ToArgb)
        Catch
            MsgBox("Error in Saving Setting.", MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim posx = Me.Left + Label1.Left
        Dim posy = Me.Top + Label1.Top
        Select Case e.KeyData
            Case Keys.Up
                System.Windows.Forms.Cursor.Position = New Point(posx, posy - 1)
            Case Keys.Right
                System.Windows.Forms.Cursor.Position = New Point(posx + 1, posy)
            Case Keys.Down
                System.Windows.Forms.Cursor.Position = New Point(posx, posy + 1)
            Case Keys.Left
                System.Windows.Forms.Cursor.Position = New Point(posx - 1, posy)
            Case Keys.Enter
                'MsgBox("asdfsdf")
                Dim pos As New Point(Label1.Left, Label1.Top)
                markyes = True
                If markyes And correcting = False Then Markpos(pos)
            Case Keys.Space
                'MsgBox("asdfsdf")
                Dim pos As New Point(Label1.Left, Label1.Top)
                markyes = True
                If markyes And correcting = False Then Markpos(pos)
        End Select

    End Sub

    Private Sub Form1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        'If e.keydata = Keys.Enter Then
        '    MsgBox("asdf")

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'PictureBox1.Image = New Bitmap(PictureBox1.Width, PictureBox1.Height)

        emptymark = True

        LabelMove.Parent = Me
        LabelInfo.Parent = Me

        rulercolor = Color.Black
        markcolor = Color.Gray
        unit = 0
        correctionOut = 218
        correctionIn = 800
        correction = False
        showmarks = True
        showmarksvs = True
        onTop = False
        rulerTop = True
        rulerLeft = True
        lang = 0
        backgcolor = Color.LightGray

        Try
            rulercolor = Color.FromArgb(GetSetting("On Screen Rluer By BenZhe", "Setting", "rulercolor", Color.Black.ToArgb))
            markcolor = Color.FromArgb(GetSetting("On Screen Rluer By BenZhe", "Setting", "markcolor", Color.Gray.ToArgb))
            unit = Convert.ToInt16(GetSetting("On Screen Rluer By BenZhe", "Setting", "unit", 1))
            correctionOut = Convert.ToInt16(GetSetting("On Screen Rluer By BenZhe", "Setting", "correctionOut", 218))
            correctionIn = Convert.ToInt16(GetSetting("On Screen Rluer By BenZhe", "Setting", "correctionIn", 800))
            correction = Convert.ToBoolean(GetSetting("On Screen Rluer By BenZhe", "Setting", "correction", 1))
            showmarks = Convert.ToBoolean(GetSetting("On Screen Rluer By BenZhe", "Setting", "showmarks", 1))
            showmarksvs = Convert.ToBoolean(GetSetting("On Screen Rluer By BenZhe", "Setting", "showmarksvs", 1))
            onTop = Convert.ToBoolean(GetSetting("On Screen Rluer By BenZhe", "Setting", "ontop", 0))
            rulerTop = Convert.ToBoolean(GetSetting("On Screen Rluer By BenZhe", "Setting", "rulerTop", 1))
            rulerLeft = Convert.ToBoolean(GetSetting("On Screen Rluer By BenZhe", "Setting", "rulerLeft", 1))
            lang = Convert.ToInt16(GetSetting("On Screen Rluer By BenZhe", "Setting", "lang", 0))
            backgcolor = Color.FromArgb(GetSetting("On Screen Rluer By BenZhe", "Setting", "backgcolor", Color.LightGray.ToArgb))
        Catch
            rr = 1
        End Try

        LabelMove.BackColor = backgcolor
        LabelInfo.BackColor = backgcolor
        PictureBox1.BackColor = backgcolor
        LabelUnit.BackColor = backgcolor


        If correctionOut < 200 Then correctionOut = 218
        'If correctionIn <


        'Debug.Print(rulerLeft.ToString)
        'Debug.Print(onTop)


        If onTop = True Then
            StayTopMostToolStripMenuItem.CheckState = CheckState.Checked
            Me.TopMost = True
        End If

        If showmarks = True Then
            ShowMarksToolStripMenuItem.CheckState = CheckState.Checked
        Else
            ShowMarksToolStripMenuItem.CheckState = CheckState.Unchecked
        End If

        If showmarksvs = True Then
            EnableVMarkToolStripMenuItem.CheckState = CheckState.Checked
        Else
            EnableVMarkToolStripMenuItem.CheckState = CheckState.Unchecked
        End If

        If correction = True Then
            CorrectionForOutScreenToolStripMenuItem.CheckState = CheckState.Checked
        Else
            CorrectionForInScreenToolStripMenuItem.CheckState = CheckState.Checked
        End If

        If rulerTop = True Then TopTickerToolStripMenuItem.CheckState = CheckState.Checked
        If rulerLeft = True Then LeftTickerToolStripMenuItem.CheckState = CheckState.Checked
        'If rulerRight = True Then RightTickerToolStripMenuItem.CheckState = CheckState.Checked
        'If rulerBottom = True Then BottomTickerToolStripMenuItem.CheckState = CheckState.Checked





        LabelVLine.BackColor = markcolor
        LabelHLine.BackColor = markcolor

        LabelHText.ForeColor = markcolor

        LabelVText.ForeColor = markcolor


        LabelHLine.Width = PictureBox1.Width

        LabelVLine.Height = PictureBox1.Height

        LabelUnit.ForeColor = rulercolor
        LabelInfo.ForeColor = rulercolor






        Debug.Print(rulercolor.ToString)
        Debug.Print(markcolor.ToString)
        Debug.Print(unit)
        Debug.Print(correctionOut)
        Debug.Print(correctionIn)
        Debug.Print(correction)
        Debug.Print(showmarks)
        Debug.Print(showmarksvs)
        Debug.Print(onTop)
        Debug.Print(rulerTop)
        Debug.Print(rulerLeft)
        Debug.Print(rulerRight)
        Debug.Print(rulerBottom)
        Debug.Print(rr)






        followmouse()

        'rulercolor = Color.Black
        'markcolor = Color.Gray
        'Form2.Show()
        Me.Opacity = 0.84

        'Debug.Print(rulerBottom.ToString)
        'rulerTop = True
        'rulerLeft = True
        WriteRuler()

        'rulercolor = Color.FromArgb(GetSetting("On Screen Rluer By BenZhe", "Setting", "markcolor"))
        'Debug.Print(G)


        refleshlang()

        UndoLastMarkToolStripMenuItem.Enabled = False
    End Sub

    Public Sub WriteRuler()

        'Debug.Print(unit)
        'rulercolor

        Dim Bmp As Bitmap

        Dim Gra As Graphics

        Dim Pen As New Pen(rulercolor)

        Bmp = New Bitmap(PictureBox1.Width, PictureBox1.Height)

        Gra = Graphics.FromImage(Bmp)

        Dim mpen As New Pen(rulercolor)
        Dim mBrush As New SolidBrush(rulercolor)
        Gra.DrawLine(mpen, 0, 0, 0, PictureBox1.Height)
        Gra.DrawLine(mpen, 0, 0, PictureBox1.Width, 0)







        Dim a As Single

        If correction = True Then         '外测量时
            Select Case unit
                Case 1      '像素
                    a = 2
                Case 2           '英寸
                    a = correctionOut / (53.98 * 0.03937) / 10
                Case 3          '厘米
                    a = correctionOut / 53.98
                    'Debug.Print("correctionOut: " & correctionOut)
                Case Else
                    a = 2
            End Select
        Else                 '内测量时

            'Debug.Print("内测量" & correctionIn & "," & unit)

            Select Case unit
                Case 1      '像素
                    a = 2
                Case 2           '英寸
                    a = correctionIn / (210 * 0.03937) / 10
                Case 3          '厘米
                    a = correctionIn / 210
                    'Debug.Print("correctionOut: " & correctionOut)
                Case Else
                    a = 2
            End Select

        End If



        'Debug.Print("a: " & a)




        Dim i As Int16

        Dim count As Int16
        '---------------------------------------------------
        '上
        If rulerTop = True Then

            i = 0
            count = 0

            While i <= 1930
                Gra.DrawLine(mpen, i, 0, i, 6)
                i = i + a
                count = i / a
                'Debug.Print(i Mod 100)

                If unit = 1 Then             '像素

                    If i Mod 100 = 0 Then

                        Dim mFont As New Font("Dotum", 10, FontStyle.Bold)

                        Gra.DrawLine(mpen, i, 0, i, 17)

                        Gra.DrawString(i, mFont, mBrush, i - 20, 20)
                    ElseIf i Mod 50 = 0 Then
                        'Dim mBrush As New SolidBrush(color.Blue)
                        Dim mFont As New Font("Dotum", 10)

                        Gra.DrawLine(mpen, i, 0, i, 13)

                        Gra.DrawString(i, mFont, mBrush, i - 15, 18)
                    ElseIf i Mod 10 = 0 Then
                        Gra.DrawLine(mpen, i, 0, i, 9)
                    End If


                ElseIf unit = 3 Then
                    If count Mod 100 = 0 Then
                        Dim mFont As New Font("Dotum", 10, FontStyle.Bold)

                        Gra.DrawLine(mpen, i, 0, i, 17)

                        Gra.DrawString(count / 10, mFont, mBrush, i - 15, 20)

                    ElseIf count Mod 10 = 0 Then
                        'Dim mBrush As New SolidBrush(color.Blue)
                        Dim mFont As New Font("Dotum", 10)

                        Gra.DrawLine(mpen, i, 0, i, 13)

                        Gra.DrawString(count / 10, mFont, mBrush, i - 10, 18)

                    Else

                        Gra.DrawLine(mpen, i, 0, i, 9)

                    End If

                Else

                    If count Mod 10 = 0 Then
                        'Dim mBrush As New SolidBrush(color.Blue)
                        Dim mFont As New Font("Dotum", 10)

                        Gra.DrawLine(mpen, i, 0, i, 15)

                        Gra.DrawString(count / 10, mFont, mBrush, i - 10, 18)

                    Else

                        Gra.DrawLine(mpen, i, 0, i, 9)

                    End If

                End If










            End While

        End If

        '---------------------------------------------------
        '左

        If rulerLeft = True Then
            i = 0
            count = 0

            While i <= 1100
                Gra.DrawLine(mpen, 0, i, 6, i)
                i = i + a
                count = (i / a)
                'Debug.Print("a:" & a)

                If unit = 1 Then             '像素

                    If i Mod 100 = 0 Then             '画刻度为100

                        Dim mFont As New Font("Dotum", 10, FontStyle.Bold)

                        Gra.DrawLine(mpen, 0, i, 17, i)

                        Gra.DrawString(i, mFont, mBrush, 20, i - 8)
                    ElseIf i Mod 50 = 0 Then          '画刻度为50
                        'Dim mBrush As New SolidBrush(color.Blue)
                        Dim mFont As New Font("Dotum", 10)

                        Gra.DrawLine(mpen, 0, i, 13, i)

                        Gra.DrawString(i, mFont, mBrush, 15, i - 8)
                    ElseIf i Mod 10 = 0 Then          '画刻度为10
                        Gra.DrawLine(mpen, 0, i, 9, i)
                    End If


                ElseIf unit = 3 Then              '厘米
                    If count Mod 100 = 0 Then
                        Dim mFont As New Font("Dotum", 10, FontStyle.Bold)

                        Gra.DrawLine(mpen, 0, i, 17, i)

                        Gra.DrawString(count / 10, mFont, mBrush, 20, i - 8)

                    ElseIf count Mod 10 = 0 Then
                        'Dim mBrush As New SolidBrush(color.Blue)
                        Dim mFont As New Font("Dotum", 10)

                        Gra.DrawLine(mpen, 0, i, 13, i)

                        Gra.DrawString(count / 10, mFont, mBrush, 15, i - 8)

                    Else

                        Gra.DrawLine(mpen, 0, i, 9, i)

                    End If

                Else                            '英寸

                    If count Mod 10 = 0 Then
                        'Dim mBrush As New SolidBrush(color.Blue)
                        Dim mFont As New Font("Dotum", 10)

                        Gra.DrawLine(mpen, 0, i, 15, i)

                        Gra.DrawString(count / 10, mFont, mBrush, 15, i - 8)

                    Else

                        Gra.DrawLine(mpen, 0, i, 9, i)

                    End If

                End If










            End While


        End If


        '---------------------------------------------------
        '右
        If rulerRight = True Then
            i = 0
            count = 0




        End If

        '---------------------------------------------------
        '下
        If rulerBottom = True Then
            i = 0
            count = 0


        End If

        PictureBox1.Image = Bmp
        'Bmp.Dispose()
    End Sub

    Private Sub Markpos(ByVal pos As Point)

        emptymark = False
        'Dim Bmp As Bitmap
        'Dim ir As Graphics
        'ir = Graphics.FromImage(PictureBox1.Image)
        'Bmp = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        'Bmp = PictureBox1.Image.Clone

        'Gra = Graphics.FromImage(Bmp)
        prevmark = PictureBox1.Image.Clone
        'Bmp.Dispose()
        Dim markx = pos.X
        Dim marky = pos.Y

        Debug.Print(markx & " " & marky)


        'Dim Bmp As Bitmap

        Dim Gra As Graphics

        Dim Pen As New Pen(markcolor)

        'Bmp = Graphics.FromImage

        Gra = Graphics.FromImage(PictureBox1.Image)
        Dim mpen As New Pen(markcolor)
        Dim mBrush As New SolidBrush(Color.White)

        'Dim mBrush As New HatchBrush(HatchStyle.BackwardDiagonal, markcolor, Color.Black)
        Dim mFont As New Font("Dotum", 10)


        'Gra.

        Dim markw, markh

        Select Case UnitResult(markx, 0)(0)
            Case Is < 10
                markw = 31
            Case Is < 100
                markw = 37
            Case Else
                markw = 38
        End Select

        Select Case UnitResult(0, marky)(1)
            Case Is < 10
                markh = 31
            Case Is < 100
                markh = 37
            Case Else
                markh = 38
        End Select



        If unit = 1 Then

            Select Case UnitResult(markx, 0)(0)
                Case Is < 100
                    markw = 18
                Case Is < 1000
                    markw = 25
                Case Else
                    markw = 32
            End Select

            Select Case UnitResult(0, marky)(1)
                Case Is < 100
                    markh = 18
                Case Is < 1000
                    markh = 25
                Case Else
                    markh = 36
            End Select


        End If
        'Select Case unit
        '    Case 2
        '        markh = markh + 4
        '        markw = markw + 4
        '    Case 3

        '        markh = markh + 12
        '        markw = markw + 12

        'End Select


        Dim Rectanglea As New Drawing.Rectangle(LabelVText.Left, LabelVText.Top, markw, 14)
        Dim Rectangleb As New Drawing.Rectangle(LabelHText.Left, LabelHText.Top, markh, 14)
        'Dim Rectanglec As New Drawing.Rectangle(

        Dim mBrushb As New SolidBrush(Color.Black)

        Debug.Print(showmarksvs.ToString & " " & showmarks.ToString)

        If showmarksvs = True Then
            Gra.DrawLine(mpen, markx, 0, markx, PictureBox1.Height)
            Gra.FillRectangle(mBrushb, Rectanglea)
            Gra.DrawString(UnitResult(markx, 0)(0), mFont, mBrush, LabelVText.Left, LabelVText.Top)

        End If

        If showmarks = True Then
            Gra.DrawLine(mpen, 0, marky, PictureBox1.Width, marky)
            Gra.FillRectangle(mBrushb, Rectangleb)
            Gra.DrawString(UnitResult(0, marky)(1), mFont, mBrush, LabelHText.Left, LabelHText.Top)
        End If

        PictureBox1.Refresh()

        Gra.Dispose()
        UndoLastMarkToolStripMenuItem.Enabled = True

    End Sub

    '----------------------------------------------------------------------
    '----------------------------------------------------------------------
    '窗体调整大小

    Private Sub LabelMove_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LabelMove.MouseDown
        mouse_offset = New Point(e.X, e.Y)
    End Sub
    Private Sub LabelMove_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LabelMove.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim mousePos As Point = sender.findform().MousePosition
            '获得鼠标偏移量 
            mousePos.Offset(-mouse_offset.X, -mouse_offset.Y)
            '设置窗体随鼠标一起移动 
            'sender.findform().Location = mousePos
            Me.Width = mousePos.X - Me.Left + 12
            Me.Height = mousePos.Y - Me.Top + 12
        End If
    End Sub

    '----------------------------------------------------------------------
    '----------------------------------------------------------------------
    '窗体移动

    Private Sub Label1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseDown
        mouse_offset = New Point(e.X + Label1.Left, e.Y + Label1.Top)
        markyes = True
    End Sub
    Private Sub Label1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseMove
        markyes = False
        'Label1.Left = Label1.Left + e.X
        'Label1.Top = Label1.Top + e.Y
        'followmouse()

        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim mousePos As Point = sender.findform().MousePosition
            '获得鼠标偏移量 
            mousePos.Offset(-mouse_offset.X, -mouse_offset.Y)
            '设置窗体随鼠标一起移动 
            sender.findform().Location = mousePos
        End If
    End Sub


    '----------------------------------------------------------------------
    '----------------------------------------------------------------------


    Private Sub Form1_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseWheel
        'MsgBox("w")
        'Debug.Print(e.Delta)
        'e.Delta
        If e.Delta > 0 Then
            Me.Opacity = Me.Opacity + 0.1
        ElseIf e.Delta < 0 And Me.Opacity > 0.4 Then
            Me.Opacity = Me.Opacity - 0.1
        End If
    End Sub
    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        LabelMove.Top = Me.Height - 12
        LabelMove.Left = Me.Width - 12
        LabelInfo.Top = Me.Height - 12
        LabelInfo.Left = Me.Width - 12 - LabelInfo.Width

        LabelInfo.Text = "Width:" & Format(Convert.ToSingle(UnitResult(Me.Width, 0)(0)), "##.#") & ", Height:" & Format(Convert.ToSingle(UnitResult(0, Me.Height)(1)), "##.#")

        If correcting = True Then
            Panel1.Width = Me.Width
            Panel1.Height = Me.Height
        End If
    End Sub


    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Dim pos As New Point(Label1.Left, Label1.Top)
        If markyes And correcting = False Then Markpos(pos)
    End Sub

    Private Sub Label1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.DoubleClick
        If correcting = False Then
            If MsgBox("Clear all marks?", MsgBoxStyle.YesNo, "Clear Marks") = 6 Then WriteRuler()
        End If
    End Sub


    Function UnitResult(ByVal x, ByVal y)
        Dim result(2)
        Dim percm, perinche As Single
        If correction = True Then
            percm = (correctionOut / 53.98 * 10)
            perinche = (correctionOut / (53.98 * 0.03937))
        Else
            percm = (correctionIn / 210 * 10)
            perinche = (correctionIn / (210 * 0.03937))
        End If
        Select Case unit
            Case 1
                result(0) = x
                result(1) = y

            Case 2

                result(0) = Format(x / perinche, "##0.##")
                result(1) = Format(y / perinche, "##0.##")
                'Debug.Print(result.X)

            Case 3
                result(0) = Format(x / percm, "##0.##")
                result(1) = Format(y / percm, "##0.##")
                'correctionOut / 53.98


            Case Else
                result(0) = x
                result(1) = y
        End Select

        Return result

    End Function

    '-------------------------------------------------------------------
    '-------------------------------------------------------------------
    'Mark跟随

    Private Sub followmouse()
        LabelVLine.Top = 0
        LabelVLine.Left = Label1.Left
        LabelHLine.Left = 0
        LabelHLine.Top = Label1.Top

        If Label1.Left < 100 Then
            LabelHText.Left = Label1.Left + 14
        Else
            LabelHText.Left = Label1.Left - 44
        End If

        If Label1.Top < 70 Then
            LabelVText.Top = Label1.Top + 14
        Else
            LabelVText.Top = Label1.Top - 30
        End If

        LabelHText.Top = Label1.Top - 5

        LabelVText.Left = Label1.Left - 10


        LabelHText.Text = UnitResult(0, Label1.Top)(1)
        LabelVText.Text = UnitResult(Label1.Left, 0)(0)


    End Sub
    Private Sub LabelVLine_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LabelVLine.MouseMove
        Label1.Left = LabelVLine.Left + e.X
        Label1.Top = LabelVLine.Top + e.Y
        followmouse()
    End Sub
    Private Sub LabelHLine_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LabelHLine.MouseMove
        Label1.Left = LabelHLine.Left + e.X
        Label1.Top = LabelHLine.Top + e.Y
        followmouse()
    End Sub
    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        'PictureBox1.Refresh()
        Label1.Left = e.X
        Label1.Top = e.Y
        followmouse()

    End Sub

    '-------------------------------------------------------------------
    '-------------------------------------------------------------------





    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Panel1.Visible = False
        Label1.ContextMenuStrip.Enabled = True
        correctionIn = Me.Width
        'Debug.Print(correctionIn)
        If prevFormH Then Me.Height = prevFormH
        If prevFormW Then Me.Width = prevFormW
        correction = False
        correcting = False
        WriteRuler()

    End Sub

    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        Label1.Left = e.X
        Label1.Top = e.Y
        followmouse()
    End Sub
    Private Sub PictureBox2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseMove
        Label1.Left = e.X + PictureBox2.Left
        Label1.Top = e.Y + PictureBox2.Top
        followmouse()
    End Sub
    Private Sub PictureBox3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox3.MouseMove
        Label1.Left = e.X + PictureBox3.Left
        Label1.Top = e.Y + PictureBox3.Top
        followmouse()
    End Sub
    Private Sub PictureBox4_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox4.MouseMove
        Label1.Left = e.X + PictureBox4.Left
        Label1.Top = e.Y + PictureBox4.Top
        followmouse()
    End Sub
    Private Sub PictureBox5_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox5.MouseMove
        Label1.Left = e.X + PictureBox5.Left
        Label1.Top = e.Y + PictureBox5.Top
        followmouse()
    End Sub
    Private Sub Label8_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label8.MouseMove
        Label1.Left = e.X + Label8.Left
        Label1.Top = e.Y + Label8.Top
        followmouse()
    End Sub
    Private Sub Label9_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label9.MouseMove
        Label1.Left = e.X + Label9.Left
        Label1.Top = e.Y + Label9.Top
        followmouse()
    End Sub
    Private Sub Label10_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label10.MouseMove
        Label1.Left = e.X + Label10.Left
        Label1.Top = e.Y + Label10.Top
        followmouse()
    End Sub



    Private Sub ClearMarks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearMarks.Click
        WriteRuler()
    End Sub
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Dispose()
    End Sub
    Private Sub ChangeRulerColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeRulerColorToolStripMenuItem.Click

        If emptymark = False Then
            If MsgBox(My.Resources.ResourceManager.GetString("cleartip" & lang), MsgBoxStyle.YesNo, "Change Ruler Color") = 6 Then
                emptymark = True
            End If
        End If

        If emptymark = True Then
            Dim b = rulercolor
            ColorDialog1.Color = rulercolor
            ColorDialog1.ShowDialog()
            If ColorDialog1.Color <> b Then
                rulercolor = ColorDialog1.Color
                LabelUnit.ForeColor = rulercolor
                LabelInfo.ForeColor = rulercolor
                WriteRuler()
            End If
            emptymark = True
        End If

    End Sub
    Private Sub ChangeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeToolStripMenuItem.Click
        Dim b = markcolor
        ColorDialog1.Color = markcolor
        ColorDialog1.ShowDialog()
        If ColorDialog1.Color <> b Then
            markcolor = ColorDialog1.Color
            LabelVLine.BackColor = markcolor
            LabelHLine.BackColor = markcolor
            LabelHText.ForeColor = markcolor
            LabelVText.ForeColor = markcolor
            'WriteRuler()
        End If
    End Sub
    Private Sub ChangeBackgColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeBackgColorToolStripMenuItem.Click
        Dim b = backgcolor
        ColorDialog1.Color = backgcolor
        ColorDialog1.ShowDialog()
        If ColorDialog1.Color <> b Then
            backgcolor = ColorDialog1.Color
            PictureBox1.BackColor = backgcolor
            LabelUnit.BackColor = backgcolor
            LabelMove.BackColor = backgcolor
            LabelInfo.BackColor = backgcolor
            'WriteRuler()
        End If
    End Sub

    Private Sub PixelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PixelToolStripMenuItem.Click
        PixelToolStripMenuItem.CheckState = CheckState.Checked
        InchesToolStripMenuItem.CheckState = CheckState.Unchecked
        CentimetersToolStripMenuItem.CheckState = CheckState.Unchecked
        unit = 1
        WriteRuler()
        Me.Width = Me.Width - 1
        Me.Width = Me.Width + 1
        LabelUnit.Text = My.Resources.ResourceManager.GetString("pixel" & lang)
    End Sub
    Private Sub InchesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InchesToolStripMenuItem.Click
        PixelToolStripMenuItem.CheckState = CheckState.Unchecked
        InchesToolStripMenuItem.CheckState = CheckState.Checked
        CentimetersToolStripMenuItem.CheckState = CheckState.Unchecked
        unit = 2
        WriteRuler()
        Me.Width = Me.Width - 1
        Me.Width = Me.Width + 1
        LabelUnit.Text = My.Resources.ResourceManager.GetString("inche" & lang)
    End Sub
    Private Sub CentimetersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CentimetersToolStripMenuItem.Click
        PixelToolStripMenuItem.CheckState = CheckState.Unchecked
        InchesToolStripMenuItem.CheckState = CheckState.Unchecked
        CentimetersToolStripMenuItem.CheckState = CheckState.Checked

        If unit = 0 Then Form2.Show()
        unit = 3
        WriteRuler()
        Me.Width = Me.Width - 1
        Me.Width = Me.Width + 1
        LabelUnit.Text = My.Resources.ResourceManager.GetString("centi" & lang)
    End Sub

    Private Sub TopTickerToolStripMenuItem_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TopTickerToolStripMenuItem.CheckStateChanged
        If TopTickerToolStripMenuItem.CheckState = CheckState.Checked Then
            rulerTop = True
        Else
            rulerTop = False
        End If
        WriteRuler()
    End Sub
    Private Sub LeftTickerToolStripMenuItem_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LeftTickerToolStripMenuItem.CheckStateChanged
        If LeftTickerToolStripMenuItem.CheckState = CheckState.Checked Then
            rulerLeft = True
        Else
            rulerLeft = False
        End If
        WriteRuler()
    End Sub

    Private Sub UndoLastMarkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoLastMarkToolStripMenuItem.Click
        If prevmark IsNot Nothing Then PictureBox1.Image = prevmark
        UndoLastMarkToolStripMenuItem.Enabled = False
    End Sub
    Private Sub StayTopMostToolStripMenuItem_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles StayTopMostToolStripMenuItem.CheckStateChanged
        If StayTopMostToolStripMenuItem.CheckState = CheckState.Checked Then
            onTop = True
            Me.TopMost = True
        Else
            onTop = False
            Me.TopMost = False
        End If
    End Sub
    Private Sub ShowMarksToolStripMenuItem_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ShowMarksToolStripMenuItem.CheckStateChanged
        If ShowMarksToolStripMenuItem.CheckState = CheckState.Checked Then
            'Debug.Print("Show")
            'LabelVLine.Show()
            LabelHLine.Show()
            LabelHText.Show()
            'LabelVText.Show()
            showmarks = True

        Else
            'Debug.Print("Hide")
            'LabelVLine.Hide()
            LabelHLine.Hide()
            LabelHText.Hide()
            'LabelVText.Hide()
            showmarks = False
        End If
    End Sub
    Private Sub EnableVMarkToolStripMenuItem_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles EnableVMarkToolStripMenuItem.CheckStateChanged
        If EnableVMarkToolStripMenuItem.CheckState = CheckState.Checked Then
            'Debug.Print("Show")
            LabelVLine.Show()
            'LabelHLine.Show()
            'LabelHText.Show()
            LabelVText.Show()
            showmarksvs = True

        Else
            'Debug.Print("Hide")
            LabelVLine.Hide()
            'LabelHLine.Hide()
            'LabelHText.Hide()
            LabelVText.Hide()
            showmarksvs = False
        End If
    End Sub

    Private Sub CorrectionForInScreenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CorrectionForInScreenToolStripMenuItem.Click
        'Form2.Show()
        prevFormW = Me.Width
        prevFormH = Me.Height
        correcting = True
        Panel1.Visible = True
        Me.Width = correctionIn
        Me.Height = 600
        'Debug.Print(correctionIn)
        Panel1.Left = 0
        Panel1.Top = 0
        Panel1.Width = Me.Width
        Panel1.Height = Me.Height
        Label10.Text = My.Resources.ResourceManager.GetString("howto" & lang) & vbCrLf & _
            My.Resources.ResourceManager.GetString("openaw" & lang) & _
            My.Resources.ResourceManager.GetString("bydrag" & lang) & _
            My.Resources.ResourceManager.GetString("whenf" & lang)


        '"1. Open A Word Document, PDF Document Or Just Your Document, Then Set The Page Size To A4 And Zoom 100%." & vbCrLf & _
        '        "2. By Drag The Little Label On Lower Right Corner To Fix The Size Of This Panel To Your A4 Page." & vbCrLf & _
        '"3. When You Finish, Click OK."
        CorrectionForOutScreenToolStripMenuItem.CheckState = CheckState.Unchecked
        CorrectionForInScreenToolStripMenuItem.CheckState = CheckState.Checked
        Label1.ContextMenuStrip.Enabled = False
        'labelv
    End Sub
    Private Sub CorrectionForOutScreenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CorrectionForOutScreenToolStripMenuItem.Click
        Form2.Show()
        correction = True
        CorrectionForOutScreenToolStripMenuItem.CheckState = CheckState.Checked
        CorrectionForInScreenToolStripMenuItem.CheckState = CheckState.Unchecked
    End Sub

    Private Sub DonateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DonateToolStripMenuItem.Click
        Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=ben304zhe%40gmail%2ecom&lc=US&item_name=Donation%20To%20On%20Screen%20Ruler&no_note=0&currency_code=USD&bn=PP%2dDonationsBF%3abtn_donateCC_LG%2egif%3aNonHostedGuest")
    End Sub
    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Dialog1.Show()
    End Sub
    Private Sub HelpPageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpPageToolStripMenuItem.Click
        Process.Start("http://on-screen-ruler.blogspot.com")
    End Sub

    Private Sub ChangeLanguageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeLanguageToolStripMenuItem.Click
        If lang = 0 Then
            lang = 1
        Else
            lang = 0
        End If

        refleshlang()

    End Sub

    Private Sub refleshlang()
        Label8.Text = My.Resources.ResourceManager.GetString("fixthispanel" & lang)
        ClearMarks.Text = My.Resources.ResourceManager.GetString("clearmark" & lang)
        ExitToolStripMenuItem.Text = My.Resources.ResourceManager.GetString("exit" & lang)
        ChangeRulerColorToolStripMenuItem.Text = My.Resources.ResourceManager.GetString("rulerc" & lang)
        ChangeToolStripMenuItem.Text = My.Resources.ResourceManager.GetString("markc" & lang)
        TopTickerToolStripMenuItem.Text = My.Resources.ResourceManager.GetString("topticker" & lang)
        LeftTickerToolStripMenuItem.Text = My.Resources.ResourceManager.GetString("leftticker" & lang)
        UnitsToolStripMenuItem.Text = My.Resources.ResourceManager.GetString("unit" & lang)
        PixelToolStripMenuItem.Text = My.Resources.ResourceManager.GetString("pixel" & lang)
        CentimetersToolStripMenuItem.Text = My.Resources.ResourceManager.GetString("centi" & lang)
        InchesToolStripMenuItem.Text = My.Resources.ResourceManager.GetString("inche" & lang)
        UndoLastMarkToolStripMenuItem.Text = My.Resources.ResourceManager.GetString("undomark" & lang)
        StayTopMostToolStripMenuItem.Text = My.Resources.ResourceManager.GetString("staytop" & lang)
        EnableVMarkToolStripMenuItem.Text = My.Resources.ResourceManager.GetString("envermark" & lang)
        ShowMarksToolStripMenuItem.Text = My.Resources.ResourceManager.GetString("enhormark" & lang)
        ChangeLanguageToolStripMenuItem.Text = My.Resources.ResourceManager.GetString("changelang" & lang)
        ChangeBackgColorToolStripMenuItem.Text = My.Resources.ResourceManager.GetString("changb" & lang)
        HelpPageToolStripMenuItem.Text = My.Resources.ResourceManager.GetString("help" & lang)
        AboutToolStripMenuItem.Text = My.Resources.ResourceManager.GetString("about" & lang)
        DonateToolStripMenuItem.Text = My.Resources.ResourceManager.GetString("donate" & lang)
        CorrectionForInScreenToolStripMenuItem.Text = My.Resources.ResourceManager.GetString("corrfin" & lang)
        CorrectionForOutScreenToolStripMenuItem.Text = My.Resources.ResourceManager.GetString("corrfout" & lang)

        Select Case unit

            Case 1
                PixelToolStripMenuItem.CheckState = CheckState.Checked
                LabelUnit.Text = My.Resources.ResourceManager.GetString("pixel" & lang)
            Case 2
                InchesToolStripMenuItem.CheckState = CheckState.Checked
                LabelUnit.Text = My.Resources.ResourceManager.GetString("inche" & lang)
            Case 3
                CentimetersToolStripMenuItem.CheckState = CheckState.Checked
                LabelUnit.Text = My.Resources.ResourceManager.GetString("centi" & lang)
        End Select
    End Sub


End Class
