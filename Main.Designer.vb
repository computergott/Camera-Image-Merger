<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Sources = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Destination = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.FileList = New System.Windows.Forms.ListBox()
        Me.FilesScceeded = New System.Windows.Forms.ListBox()
        Me.FilesFailed = New System.Windows.Forms.ListBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.FileInfo = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.prefix = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Sources
        '
        Me.Sources.FormattingEnabled = True
        Me.Sources.Location = New System.Drawing.Point(12, 29)
        Me.Sources.Name = "Sources"
        Me.Sources.Size = New System.Drawing.Size(248, 173)
        Me.Sources.TabIndex = 0
        Me.Sources.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Quellen"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 209)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.TabStop = False
        Me.Button1.Text = "Hinzufügen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(176, 209)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.TabStop = False
        Me.Button2.Text = "Löschen"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.ShowNewFolderButton = False
        '
        'Destination
        '
        Me.Destination.Location = New System.Drawing.Point(15, 298)
        Me.Destination.Name = "Destination"
        Me.Destination.ReadOnly = True
        Me.Destination.Size = New System.Drawing.Size(245, 20)
        Me.Destination.TabIndex = 5
        Me.Destination.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 282)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Ausgabeordner"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(13, 324)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 7
        Me.Button4.TabStop = False
        Me.Button4.Text = "Wählen"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(13, 238)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(247, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.TabStop = False
        Me.Button3.Text = "Dateien einlesen"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'FileList
        '
        Me.FileList.FormattingEnabled = True
        Me.FileList.Location = New System.Drawing.Point(266, 29)
        Me.FileList.Name = "FileList"
        Me.FileList.Size = New System.Drawing.Size(248, 173)
        Me.FileList.TabIndex = 8
        Me.FileList.TabStop = False
        '
        'FilesScceeded
        '
        Me.FilesScceeded.FormattingEnabled = True
        Me.FilesScceeded.Location = New System.Drawing.Point(520, 29)
        Me.FilesScceeded.Name = "FilesScceeded"
        Me.FilesScceeded.Size = New System.Drawing.Size(248, 173)
        Me.FilesScceeded.TabIndex = 9
        Me.FilesScceeded.TabStop = False
        '
        'FilesFailed
        '
        Me.FilesFailed.FormattingEnabled = True
        Me.FilesFailed.Location = New System.Drawing.Point(520, 238)
        Me.FilesFailed.Name = "FilesFailed"
        Me.FilesFailed.Size = New System.Drawing.Size(248, 238)
        Me.FilesFailed.TabIndex = 10
        Me.FilesFailed.TabStop = False
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(430, 208)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(84, 23)
        Me.Button5.TabIndex = 11
        Me.Button5.TabStop = False
        Me.Button5.Text = "Löschen"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(266, 209)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(84, 23)
        Me.Button7.TabIndex = 13
        Me.Button7.TabStop = False
        Me.Button7.Text = "Bild zeigen"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'FileInfo
        '
        Me.FileInfo.Location = New System.Drawing.Point(266, 238)
        Me.FileInfo.Multiline = True
        Me.FileInfo.Name = "FileInfo"
        Me.FileInfo.ReadOnly = True
        Me.FileInfo.Size = New System.Drawing.Size(245, 238)
        Me.FileInfo.TabIndex = 14
        Me.FileInfo.TabStop = False
        Me.FileInfo.Text = "Keine Datei gewählt"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(15, 453)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(113, 23)
        Me.Button6.TabIndex = 15
        Me.Button6.TabStop = False
        Me.Button6.Text = "Dateien kopieren"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(266, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Dateiliste"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(520, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Dateien erfolgreich"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(521, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Dateien mit Fehlern"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(15, 424)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(245, 23)
        Me.Button8.TabIndex = 19
        Me.Button8.TabStop = False
        Me.Button8.Text = "RESET"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(15, 424)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(245, 23)
        Me.ProgressBar1.TabIndex = 21
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(147, 453)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(113, 23)
        Me.Button9.TabIndex = 22
        Me.Button9.TabStop = False
        Me.Button9.Text = "Einstellungen"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 480)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Beta 1.2"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(738, 480)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(30, 13)
        Me.LinkLabel1.TabIndex = 24
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Logs"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 357)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Präfix"
        '
        'prefix
        '
        Me.prefix.Location = New System.Drawing.Point(15, 373)
        Me.prefix.Name = "prefix"
        Me.prefix.Size = New System.Drawing.Size(245, 20)
        Me.prefix.TabIndex = 25
        Me.prefix.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 502)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.prefix)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.FileInfo)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.FilesFailed)
        Me.Controls.Add(Me.FilesScceeded)
        Me.Controls.Add(Me.FileList)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Destination)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Sources)
        Me.Controls.Add(Me.Button8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Camera Image Merger"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Sources As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Destination As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents FileList As ListBox
    Friend WithEvents FilesScceeded As ListBox
    Friend WithEvents FilesFailed As ListBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents FileInfo As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Button9 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label7 As Label
    Friend WithEvents prefix As TextBox
End Class
