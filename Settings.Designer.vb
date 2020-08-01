<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.FileOverwrite = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.WorkingSpeed = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LogOnlyErrors = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateMode = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'FileOverwrite
        '
        Me.FileOverwrite.AutoSize = True
        Me.FileOverwrite.Location = New System.Drawing.Point(11, 12)
        Me.FileOverwrite.Name = "FileOverwrite"
        Me.FileOverwrite.Size = New System.Drawing.Size(194, 17)
        Me.FileOverwrite.TabIndex = 21
        Me.FileOverwrite.TabStop = False
        Me.FileOverwrite.Text = "Vorhandene Dateien überschreiben"
        Me.FileOverwrite.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(11, 177)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(197, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.TabStop = False
        Me.Button1.Text = "Schließen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'WorkingSpeed
        '
        Me.WorkingSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.WorkingSpeed.FormattingEnabled = True
        Me.WorkingSpeed.Items.AddRange(New Object() {"1 - Langsamer", "2 - Normal", "3 - Schnell"})
        Me.WorkingSpeed.Location = New System.Drawing.Point(11, 111)
        Me.WorkingSpeed.Name = "WorkingSpeed"
        Me.WorkingSpeed.Size = New System.Drawing.Size(194, 21)
        Me.WorkingSpeed.TabIndex = 23
        Me.WorkingSpeed.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Arbeitsgeschwindigkeit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 26)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Wenn viele Dateien fehlerhaft sind," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "stelle diesen Wert herunter"
        '
        'LogOnlyErrors
        '
        Me.LogOnlyErrors.AutoSize = True
        Me.LogOnlyErrors.Checked = True
        Me.LogOnlyErrors.CheckState = System.Windows.Forms.CheckState.Checked
        Me.LogOnlyErrors.Location = New System.Drawing.Point(11, 35)
        Me.LogOnlyErrors.Name = "LogOnlyErrors"
        Me.LogOnlyErrors.Size = New System.Drawing.Size(167, 17)
        Me.LogOnlyErrors.TabIndex = 26
        Me.LogOnlyErrors.TabStop = False
        Me.LogOnlyErrors.Text = "Nur Fehler in den Logs zeigen"
        Me.LogOnlyErrors.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Datumsermittlung" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'DateMode
        '
        Me.DateMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DateMode.FormattingEnabled = True
        Me.DateMode.Items.AddRange(New Object() {"Änderungsdatum", "Erstelldatum", "Kein Datum (Nur Präfix)"})
        Me.DateMode.Location = New System.Drawing.Point(11, 71)
        Me.DateMode.Name = "DateMode"
        Me.DateMode.Size = New System.Drawing.Size(194, 21)
        Me.DateMode.TabIndex = 27
        Me.DateMode.TabStop = False
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(219, 219)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateMode)
        Me.Controls.Add(Me.LogOnlyErrors)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WorkingSpeed)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.FileOverwrite)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Einstellungen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FileOverwrite As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents WorkingSpeed As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LogOnlyErrors As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DateMode As ComboBox
End Class
