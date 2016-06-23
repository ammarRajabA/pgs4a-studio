Public Class Form1
    Dim prj_path, prj_name As String
    Dim sdkpath, apachepath, pgs4apath, androidplatformpath As String
    Dim settings_file = "pgs4a_Studio.ini"
    Dim index As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim prj_selected As Boolean
        prj_selected = FolderBrowserDialog1.ShowDialog()
        If prj_selected Then
            prj_path = FolderBrowserDialog1.SelectedPath
            TextBox1.Text = prj_path
            Dim t = prj_path.Split("\")
            prj_name = t(t.Length - 1)
            Label2.Text = prj_name
            Button2.Visible = True
            Button7.Visible = True
            On Error Resume Next
            Label5.Text = Microsoft.VisualBasic.FileIO.FileSystem.GetFiles(pgs4apath & "\bin",
                                        FileIO.SearchOption.SearchTopLevelOnly, "*.apk")(index)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim command As String
        command = "/k cd /d " & pgs4apath & " & python android.py build " & prj_path & " release"
        Process.Start("cmd", command)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fn = FreeFile()
        On Error GoTo setup
        FileSystem.FileOpen(fn, FileSystem.CurDir() & "\" & settings_file, OpenMode.Input)
        FileSystem.Input(fn, sdkpath)
        FileSystem.Input(fn, apachepath)
        FileSystem.Input(fn, pgs4apath)
        FileSystem.Input(fn, androidplatformpath)
        FileSystem.FileClose(fn)
        Return
setup:
        MsgBox("you have to setup environment first")
        Form2.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim prj_selected As Boolean
        prj_selected = FolderBrowserDialog1.ShowDialog()
        If prj_selected Then
            prj_path = FolderBrowserDialog1.SelectedPath
            TextBox1.Text = prj_path
            TextBox2.Text = prj_path
            Button5.Visible = True
            Button6.Visible = True
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim command As String
        command = "/k cd /d " & pgs4apath & " & python android.py configure " & prj_path
        Process.Start("cmd", command)
        Button2.Visible = True
        Button7.Visible = True
        Dim t = prj_path.Split("\")
        prj_name = t(t.Length - 1)
        Label2.Text = prj_name
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Process.Start("cmd", "/c explorer " & prj_path)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim command As String
        command = "/k cd /d " & sdkpath & "\platform-tools\ & adb install -r " & Label5.Text
        Process.Start("cmd", command)
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        index += 1
        On Error GoTo reset
        Label5.Text = Microsoft.VisualBasic.FileIO.FileSystem.GetFiles(pgs4apath & "\bin",
                                        FileIO.SearchOption.SearchTopLevelOnly, "*.apk")(index)
        Return
reset:
        index = 0
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Process.Start(sdkpath & "\AVD Manager.exe")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim command As String
        command = "/k cd /d " & sdkpath & "\platform-tools\ & adb logcat python:I *:S"
        Process.Start("cmd", Command)
    End Sub
End Class
