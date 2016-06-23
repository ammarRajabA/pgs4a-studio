Public Class Form2
    Dim settings_file = "pgs4a_Studio.ini"

    Private Sub sdkpath_Click(sender As Object, e As EventArgs) Handles sdkpath.Click
        Dim folder_selected = FolderBrowserDialog1.ShowDialog()
        If folder_selected Then
            Tsdkpath.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub apachepath_Click(sender As Object, e As EventArgs) Handles apachepath.Click
        Dim folder_selected = FolderBrowserDialog1.ShowDialog()
        If folder_selected Then
            Tapachepath.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub pgs4apath_Click(sender As Object, e As EventArgs) Handles pgs4apath.Click
        Dim folder_selected = FolderBrowserDialog1.ShowDialog()
        If folder_selected Then
            Tpgs4apath.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub andrplatformpath_Click(sender As Object, e As EventArgs) Handles andrplatformpath.Click
        Dim folder_selected = FolderBrowserDialog1.ShowDialog()
        If folder_selected Then
            Tandrplatformpath.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub
    Private Function check_settings()
        If System.IO.Path.IsPathRooted(Tsdkpath.Text) And
            System.IO.Path.IsPathRooted(Tapachepath.Text) And
            System.IO.Path.IsPathRooted(Tpgs4apath.Text) And
            System.IO.Path.IsPathRooted(Tandrplatformpath.Text) Then
            Return True
        End If
        Return False
    End Function

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        Dim settings_valid = check_settings()
        If Not settings_valid Then
            MsgBox("settings are not valid", MsgBoxStyle.Information)
            Return
        End If

        Dim fn = FreeFile()
        FileSystem.FileOpen(fn, FileSystem.CurDir() & "\" & settings_file, OpenMode.Output)
        FileSystem.Write(fn, Tsdkpath.Text, Tapachepath.Text, Tpgs4apath.Text, Tandrplatformpath.Text)
        FileSystem.FileClose(fn)
        MsgBox("Settings Saved !!" & vbNewLine & "restart program to take effect", MsgBoxStyle.Information)
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Hide()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fn = FreeFile()
        On Error Resume Next
        FileSystem.FileOpen(fn, FileSystem.CurDir() & "\" & settings_file, OpenMode.Input)
        FileSystem.Input(fn, Tsdkpath.Text)
        FileSystem.Input(fn, Tapachepath.Text)
        FileSystem.Input(fn, Tpgs4apath.Text)
        FileSystem.Input(fn, Tandrplatformpath.Text)
        FileSystem.FileClose(fn)
    End Sub
End Class