Imports System.Windows.Forms
Imports System.Resources

Public Class Dialog1

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub



    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        Process.Start("mailto:ben304zhe@gmail.com")
    End Sub

    Private Sub Dialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim resourceMgrIns As ResourceManager
        'Dim value As String

        'resourceMgrIns = New ResourceManager("onscreenruler.Resources", GetType(My.Resources.Resources).Assembly)

        'Dim lang = 1
        Label1.Text = My.Resources.ResourceManager.GetString("appname" & Form1.lang)
        Label4.Text = My.Resources.ResourceManager.GetString("thisis" & Form1.lang)
        Label2.Text = My.Resources.ResourceManager.GetString("tips" & Form1.lang)
        Label3.Text = My.Resources.ResourceManager.GetString("history" & Form1.lang)

    End Sub



End Class
