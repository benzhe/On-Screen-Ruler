<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UndoLastMarkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClearMarks = New System.Windows.Forms.ToolStripMenuItem
        Me.ShowMarksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EnableVMarkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.StayTopMostToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.TopTickerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LeftTickerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangeRulerColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangeBackgColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.UnitsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PixelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InchesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CentimetersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CorrectionForInScreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CorrectionForOutScreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ChangeLanguageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DonateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label1 = New System.Windows.Forms.Label
        Me.LabelVLine = New System.Windows.Forms.Label
        Me.LabelHLine = New System.Windows.Forms.Label
        Me.LabelHText = New System.Windows.Forms.Label
        Me.LabelVText = New System.Windows.Forms.Label
        Me.LabelInfo = New System.Windows.Forms.Label
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.LabelUnit = New System.Windows.Forms.Label
        Me.LabelMove = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoLastMarkToolStripMenuItem, Me.ClearMarks, Me.ShowMarksToolStripMenuItem, Me.EnableVMarkToolStripMenuItem, Me.ToolStripSeparator4, Me.StayTopMostToolStripMenuItem, Me.ToolStripSeparator2, Me.TopTickerToolStripMenuItem, Me.LeftTickerToolStripMenuItem, Me.ChangeRulerColorToolStripMenuItem, Me.ChangeToolStripMenuItem, Me.ChangeBackgColorToolStripMenuItem, Me.ToolStripSeparator3, Me.UnitsToolStripMenuItem, Me.CorrectionForInScreenToolStripMenuItem, Me.CorrectionForOutScreenToolStripMenuItem, Me.ToolStripSeparator1, Me.ChangeLanguageToolStripMenuItem, Me.HelpPageToolStripMenuItem, Me.AboutToolStripMenuItem, Me.DonateToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(232, 424)
        '
        'UndoLastMarkToolStripMenuItem
        '
        Me.UndoLastMarkToolStripMenuItem.Name = "UndoLastMarkToolStripMenuItem"
        Me.UndoLastMarkToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.UndoLastMarkToolStripMenuItem.Text = "Undo Last Mark"
        '
        'ClearMarks
        '
        Me.ClearMarks.Name = "ClearMarks"
        Me.ClearMarks.Size = New System.Drawing.Size(231, 22)
        Me.ClearMarks.Text = "Clear Marks"
        '
        'ShowMarksToolStripMenuItem
        '
        Me.ShowMarksToolStripMenuItem.Checked = True
        Me.ShowMarksToolStripMenuItem.CheckOnClick = True
        Me.ShowMarksToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ShowMarksToolStripMenuItem.Name = "ShowMarksToolStripMenuItem"
        Me.ShowMarksToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.ShowMarksToolStripMenuItem.Text = "Enable Horizontal Marks"
        '
        'EnableVMarkToolStripMenuItem
        '
        Me.EnableVMarkToolStripMenuItem.Checked = True
        Me.EnableVMarkToolStripMenuItem.CheckOnClick = True
        Me.EnableVMarkToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.EnableVMarkToolStripMenuItem.Name = "EnableVMarkToolStripMenuItem"
        Me.EnableVMarkToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.EnableVMarkToolStripMenuItem.Text = "Enable Vertical Marks"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(228, 6)
        '
        'StayTopMostToolStripMenuItem
        '
        Me.StayTopMostToolStripMenuItem.CheckOnClick = True
        Me.StayTopMostToolStripMenuItem.Name = "StayTopMostToolStripMenuItem"
        Me.StayTopMostToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.StayTopMostToolStripMenuItem.Text = "Stay On Top"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(228, 6)
        '
        'TopTickerToolStripMenuItem
        '
        Me.TopTickerToolStripMenuItem.CheckOnClick = True
        Me.TopTickerToolStripMenuItem.Name = "TopTickerToolStripMenuItem"
        Me.TopTickerToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.TopTickerToolStripMenuItem.Text = "Top Ticker"
        '
        'LeftTickerToolStripMenuItem
        '
        Me.LeftTickerToolStripMenuItem.CheckOnClick = True
        Me.LeftTickerToolStripMenuItem.Name = "LeftTickerToolStripMenuItem"
        Me.LeftTickerToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.LeftTickerToolStripMenuItem.Text = "Left Ticker"
        '
        'ChangeRulerColorToolStripMenuItem
        '
        Me.ChangeRulerColorToolStripMenuItem.Name = "ChangeRulerColorToolStripMenuItem"
        Me.ChangeRulerColorToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.ChangeRulerColorToolStripMenuItem.Text = "Change Ruler Color"
        '
        'ChangeToolStripMenuItem
        '
        Me.ChangeToolStripMenuItem.Name = "ChangeToolStripMenuItem"
        Me.ChangeToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.ChangeToolStripMenuItem.Text = "Change Mark Color"
        '
        'ChangeBackgColorToolStripMenuItem
        '
        Me.ChangeBackgColorToolStripMenuItem.Name = "ChangeBackgColorToolStripMenuItem"
        Me.ChangeBackgColorToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.ChangeBackgColorToolStripMenuItem.Text = "Change Background Color"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(228, 6)
        '
        'UnitsToolStripMenuItem
        '
        Me.UnitsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PixelToolStripMenuItem, Me.InchesToolStripMenuItem, Me.CentimetersToolStripMenuItem})
        Me.UnitsToolStripMenuItem.Name = "UnitsToolStripMenuItem"
        Me.UnitsToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.UnitsToolStripMenuItem.Text = "Unit"
        '
        'PixelToolStripMenuItem
        '
        Me.PixelToolStripMenuItem.Name = "PixelToolStripMenuItem"
        Me.PixelToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.PixelToolStripMenuItem.Text = "Pixels"
        '
        'InchesToolStripMenuItem
        '
        Me.InchesToolStripMenuItem.Name = "InchesToolStripMenuItem"
        Me.InchesToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.InchesToolStripMenuItem.Text = "Inches"
        '
        'CentimetersToolStripMenuItem
        '
        Me.CentimetersToolStripMenuItem.Name = "CentimetersToolStripMenuItem"
        Me.CentimetersToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.CentimetersToolStripMenuItem.Text = "Centimeters"
        '
        'CorrectionForInScreenToolStripMenuItem
        '
        Me.CorrectionForInScreenToolStripMenuItem.Name = "CorrectionForInScreenToolStripMenuItem"
        Me.CorrectionForInScreenToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.CorrectionForInScreenToolStripMenuItem.Text = "Correction For In-Screen"
        '
        'CorrectionForOutScreenToolStripMenuItem
        '
        Me.CorrectionForOutScreenToolStripMenuItem.Name = "CorrectionForOutScreenToolStripMenuItem"
        Me.CorrectionForOutScreenToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.CorrectionForOutScreenToolStripMenuItem.Text = "Correction For Out-Screen"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(228, 6)
        '
        'ChangeLanguageToolStripMenuItem
        '
        Me.ChangeLanguageToolStripMenuItem.Name = "ChangeLanguageToolStripMenuItem"
        Me.ChangeLanguageToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.ChangeLanguageToolStripMenuItem.Text = "Change Language"
        '
        'HelpPageToolStripMenuItem
        '
        Me.HelpPageToolStripMenuItem.Name = "HelpPageToolStripMenuItem"
        Me.HelpPageToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.HelpPageToolStripMenuItem.Text = "Help And Feed Back"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'DonateToolStripMenuItem
        '
        Me.DonateToolStripMenuItem.Name = "DonateToolStripMenuItem"
        Me.DonateToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.DonateToolStripMenuItem.Text = "Donate"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.GreenYellow
        Me.Label1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label1.Location = New System.Drawing.Point(100, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1, 1)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = " "
        '
        'LabelVLine
        '
        Me.LabelVLine.BackColor = System.Drawing.Color.Gray
        Me.LabelVLine.Location = New System.Drawing.Point(50, 0)
        Me.LabelVLine.Name = "LabelVLine"
        Me.LabelVLine.Size = New System.Drawing.Size(1, 1000)
        Me.LabelVLine.TabIndex = 5
        Me.LabelVLine.Text = " "
        '
        'LabelHLine
        '
        Me.LabelHLine.BackColor = System.Drawing.Color.Gray
        Me.LabelHLine.Location = New System.Drawing.Point(0, 50)
        Me.LabelHLine.Name = "LabelHLine"
        Me.LabelHLine.Size = New System.Drawing.Size(1000, 1)
        Me.LabelHLine.TabIndex = 6
        Me.LabelHLine.Text = "Label3"
        '
        'LabelHText
        '
        Me.LabelHText.AutoSize = True
        Me.LabelHText.Location = New System.Drawing.Point(100, 50)
        Me.LabelHText.Name = "LabelHText"
        Me.LabelHText.Size = New System.Drawing.Size(11, 12)
        Me.LabelHText.TabIndex = 7
        Me.LabelHText.Text = " "
        '
        'LabelVText
        '
        Me.LabelVText.AutoSize = True
        Me.LabelVText.Location = New System.Drawing.Point(50, 100)
        Me.LabelVText.Name = "LabelVText"
        Me.LabelVText.Size = New System.Drawing.Size(11, 12)
        Me.LabelVText.TabIndex = 8
        Me.LabelVText.Text = " "
        '
        'LabelInfo
        '
        Me.LabelInfo.BackColor = System.Drawing.Color.Transparent
        Me.LabelInfo.Location = New System.Drawing.Point(100, 120)
        Me.LabelInfo.Name = "LabelInfo"
        Me.LabelInfo.Size = New System.Drawing.Size(143, 12)
        Me.LabelInfo.TabIndex = 9
        Me.LabelInfo.Text = "Width:1000, Height:1000"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.YellowGreen
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(292, 54)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 600)
        Me.Panel1.TabIndex = 10
        Me.Panel1.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 66)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(151, 47)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(480, 77)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "How To: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(297, 559)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 18)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Zoom: 100%"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.on_screen_ruler.My.Resources.Resources.lbottom
        Me.PictureBox5.Location = New System.Drawing.Point(424, 547)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(100, 40)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 10
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.on_screen_ruler.My.Resources.Resources.top
        Me.PictureBox4.Location = New System.Drawing.Point(563, 159)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(230, 95)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(129, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(548, 25)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Fix This Panel To An A4 Paper In Your Screen "
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.on_screen_ruler.My.Resources.Resources.ltop
        Me.PictureBox3.Location = New System.Drawing.Point(6, 159)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(211, 95)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(220, 127)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(350, 416)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'LabelUnit
        '
        Me.LabelUnit.AutoSize = True
        Me.LabelUnit.Location = New System.Drawing.Point(7, 7)
        Me.LabelUnit.Name = "LabelUnit"
        Me.LabelUnit.Size = New System.Drawing.Size(17, 12)
        Me.LabelUnit.TabIndex = 11
        Me.LabelUnit.Text = "cm"
        '
        'LabelMove
        '
        Me.LabelMove.BackColor = System.Drawing.Color.Transparent
        Me.LabelMove.Cursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.LabelMove.Image = CType(resources.GetObject("LabelMove.Image"), System.Drawing.Image)
        Me.LabelMove.Location = New System.Drawing.Point(100, 140)
        Me.LabelMove.Name = "LabelMove"
        Me.LabelMove.Size = New System.Drawing.Size(12, 12)
        Me.LabelMove.TabIndex = 3
        Me.LabelMove.Text = " "
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1930, 1100)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(400, 200)
        Me.Controls.Add(Me.LabelMove)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LabelUnit)
        Me.Controls.Add(Me.LabelInfo)
        Me.Controls.Add(Me.LabelVText)
        Me.Controls.Add(Me.LabelHText)
        Me.Controls.Add(Me.LabelHLine)
        Me.Controls.Add(Me.LabelVLine)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1900, 1080)
        Me.MinimumSize = New System.Drawing.Size(280, 80)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "On Screen Ruler by benzhe"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelMove As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelVLine As System.Windows.Forms.Label
    Friend WithEvents LabelHLine As System.Windows.Forms.Label
    Friend WithEvents LabelHText As System.Windows.Forms.Label
    Friend WithEvents LabelVText As System.Windows.Forms.Label
    Friend WithEvents LabelInfo As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ClearMarks As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TopTickerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LeftTickerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DonateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpPageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeRulerColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnitsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PixelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InchesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CentimetersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CorrectionForOutScreenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents ShowMarksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UndoLastMarkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StayTopMostToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnableVMarkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CorrectionForInScreenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LabelUnit As System.Windows.Forms.Label
    Friend WithEvents ChangeBackgColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeLanguageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
