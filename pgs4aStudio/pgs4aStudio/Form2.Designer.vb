<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.sdkpath = New System.Windows.Forms.Button()
        Me.Tsdkpath = New System.Windows.Forms.TextBox()
        Me.apachepath = New System.Windows.Forms.Button()
        Me.Tapachepath = New System.Windows.Forms.TextBox()
        Me.pgs4apath = New System.Windows.Forms.Button()
        Me.Tpgs4apath = New System.Windows.Forms.TextBox()
        Me.andrplatformpath = New System.Windows.Forms.Button()
        Me.Tandrplatformpath = New System.Windows.Forms.TextBox()
        Me.save = New System.Windows.Forms.Button()
        Me.cancel = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'sdkpath
        '
        Me.sdkpath.Location = New System.Drawing.Point(13, 13)
        Me.sdkpath.Name = "sdkpath"
        Me.sdkpath.Size = New System.Drawing.Size(75, 23)
        Me.sdkpath.TabIndex = 0
        Me.sdkpath.Text = "android SDK"
        Me.sdkpath.UseVisualStyleBackColor = True
        '
        'Tsdkpath
        '
        Me.Tsdkpath.Location = New System.Drawing.Point(146, 16)
        Me.Tsdkpath.Name = "Tsdkpath"
        Me.Tsdkpath.Size = New System.Drawing.Size(396, 20)
        Me.Tsdkpath.TabIndex = 1
        '
        'apachepath
        '
        Me.apachepath.Location = New System.Drawing.Point(13, 57)
        Me.apachepath.Name = "apachepath"
        Me.apachepath.Size = New System.Drawing.Size(75, 23)
        Me.apachepath.TabIndex = 2
        Me.apachepath.Text = "apache"
        Me.apachepath.UseVisualStyleBackColor = True
        '
        'Tapachepath
        '
        Me.Tapachepath.Location = New System.Drawing.Point(146, 60)
        Me.Tapachepath.Name = "Tapachepath"
        Me.Tapachepath.Size = New System.Drawing.Size(396, 20)
        Me.Tapachepath.TabIndex = 3
        '
        'pgs4apath
        '
        Me.pgs4apath.Location = New System.Drawing.Point(13, 102)
        Me.pgs4apath.Name = "pgs4apath"
        Me.pgs4apath.Size = New System.Drawing.Size(75, 23)
        Me.pgs4apath.TabIndex = 4
        Me.pgs4apath.Text = "pgs4a"
        Me.pgs4apath.UseVisualStyleBackColor = True
        '
        'Tpgs4apath
        '
        Me.Tpgs4apath.Location = New System.Drawing.Point(146, 102)
        Me.Tpgs4apath.Name = "Tpgs4apath"
        Me.Tpgs4apath.Size = New System.Drawing.Size(396, 20)
        Me.Tpgs4apath.TabIndex = 5
        '
        'andrplatformpath
        '
        Me.andrplatformpath.Location = New System.Drawing.Point(12, 153)
        Me.andrplatformpath.Name = "andrplatformpath"
        Me.andrplatformpath.Size = New System.Drawing.Size(108, 23)
        Me.andrplatformpath.TabIndex = 6
        Me.andrplatformpath.Text = "android platform"
        Me.andrplatformpath.UseVisualStyleBackColor = True
        '
        'Tandrplatformpath
        '
        Me.Tandrplatformpath.Location = New System.Drawing.Point(146, 156)
        Me.Tandrplatformpath.Name = "Tandrplatformpath"
        Me.Tandrplatformpath.Size = New System.Drawing.Size(396, 20)
        Me.Tandrplatformpath.TabIndex = 7
        '
        'save
        '
        Me.save.Location = New System.Drawing.Point(13, 301)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(75, 23)
        Me.save.TabIndex = 8
        Me.save.Text = "Save"
        Me.save.UseVisualStyleBackColor = True
        '
        'cancel
        '
        Me.cancel.Location = New System.Drawing.Point(94, 301)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(75, 23)
        Me.cancel.TabIndex = 9
        Me.cancel.Text = "Cancel"
        Me.cancel.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 336)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.Tandrplatformpath)
        Me.Controls.Add(Me.andrplatformpath)
        Me.Controls.Add(Me.Tpgs4apath)
        Me.Controls.Add(Me.pgs4apath)
        Me.Controls.Add(Me.Tapachepath)
        Me.Controls.Add(Me.apachepath)
        Me.Controls.Add(Me.Tsdkpath)
        Me.Controls.Add(Me.sdkpath)
        Me.Name = "Form2"
        Me.Text = "SDK config"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sdkpath As System.Windows.Forms.Button
    Friend WithEvents Tsdkpath As System.Windows.Forms.TextBox
    Friend WithEvents apachepath As System.Windows.Forms.Button
    Friend WithEvents Tapachepath As System.Windows.Forms.TextBox
    Friend WithEvents pgs4apath As System.Windows.Forms.Button
    Friend WithEvents Tpgs4apath As System.Windows.Forms.TextBox
    Friend WithEvents andrplatformpath As System.Windows.Forms.Button
    Friend WithEvents Tandrplatformpath As System.Windows.Forms.TextBox
    Friend WithEvents save As System.Windows.Forms.Button
    Friend WithEvents cancel As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
End Class
