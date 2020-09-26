Imports System.IO

Public Class Main
    Private Sub warte(Sekunden As Double)
        Dim ZeitSpanne As Double
        Dim Start As Double
        ZeitSpanne = Sekunden / 100000
        Start = DateTime.Now.ToOADate()   ' Anfangszeit setzen.
        Do While DateTime.Now.ToOADate() < Start + ZeitSpanne
            Application.DoEvents()  ' Steuerung an andere Prozesse abgeben
        Loop
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Visible = False
        Settings.WorkingSpeed.Text = "2 - Normal"
        Settings.DateMode.Text = "Änderungsdatum"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FolderBrowserDialog1.SelectedPath = ""
        FolderBrowserDialog1.ShowDialog()
        If FolderBrowserDialog1.SelectedPath = "" Then
            Return
        End If

        Dim Newpath As String
        Newpath = FolderBrowserDialog1.SelectedPath
        If Newpath.EndsWith("\") Then
        Else
            Newpath = Newpath + "\"
        End If

        For Each item In Sources.Items
            If item = Newpath Then
                MsgBox("Der Ordner wurde bereits hinzugefügt", MsgBoxStyle.Critical, "Ordner bereits vorhanden")
                Return
            End If
        Next
        Sources.Items.Add(Newpath.Trim)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Sources.SelectedItem = "" Then
            Return
        End If

        Sources.Items.Remove(Sources.SelectedItem)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FolderBrowserDialog1.SelectedPath = ""
        FolderBrowserDialog1.ShowDialog()
        If FolderBrowserDialog1.SelectedPath = "" Then
            Return
        End If

        Dim Destpath As String
        Destpath = FolderBrowserDialog1.SelectedPath
        If Destpath.EndsWith("\") Then
        Else
            Destpath = Destpath + "\"
        End If
        Destination.Text = Destpath.Trim
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        FileList.Items.Clear()
        For Each Source In Sources.Items

            For Each File In IO.Directory.GetFiles(Source)
                FileList.Items.Add(File)
            Next

        Next
    End Sub

    Private Sub FileList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FileList.SelectedIndexChanged
        If FileList.SelectedItem = "" Then
            FileInfo.Text = "Keine Datei gewählt"
            Return
        End If

        FileInfo.Text = "Gewählte Datei:" + vbNewLine + vbNewLine + "Datei:" + vbNewLine + FileList.SelectedItem + vbNewLine + "Dateidatum:" + vbNewLine + System.IO.File.GetCreationTime(FileList.SelectedItem)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If FileList.SelectedItem = "" Then
            Return
        End If

        Process.Start(FileList.SelectedItem)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If FileList.SelectedItem = "" Then
            Return
        End If

        FileList.Items.Remove(FileList.SelectedItem)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Destination.Text = "" Then
            MsgBox("Es wurde kein Ausgabepfad gewählt", MsgBoxStyle.Critical, Title:="Kein Ausgabepfad")
            Return
        End If

        For Each item In Sources.Items
            If item = Destination.Text Then
                MsgBox("Der Zielordner darf kein Quellordner sein!", MsgBoxStyle.Critical, "Das funktioniert so nicht")
                Return
            End If
        Next

        If FileList.Items.Count = 0 Then
            MsgBox("Es wurde keine Dateiliste erstellt!", MsgBoxStyle.Critical, Title:="Keine Dateien in der Liste")
            Return
        End If

        ProgressBar1.Visible = True
        ProgressBar1.Value = 0
        Dim FilesCount As Integer = FileList.Items.Count
        Dim FilesProcessed As Integer = 0

        FilesScceeded.Items.Clear()
        FilesFailed.Items.Clear()

        If Settings.LogOnlyErrors.CheckState = CheckState.Unchecked Then
            logs.AddLog("=== Ein neuer Kopierdurchlauf wurde gestartet ===")

        End If


        For Each file In FileList.Items

            Try
                Dim NewFileName As String

                Select Case Settings.DateMode.Text
                    Case "Änderungsdatum"
                        If prefix.Text = "" Then
                            NewFileName = System.IO.File.GetLastWriteTime(file)
                        Else
                            NewFileName = prefix.Text + "_" + System.IO.File.GetLastWriteTime(file)
                        End If
                    Case "Erstelldatum"
                        If prefix.Text = "" Then
                            NewFileName = System.IO.File.GetCreationTime(file)
                        Else
                            NewFileName = prefix.Text + "_" + System.IO.File.GetCreationTime(file)
                        End If
                    Case "Nur Präfix (+ Dateiname)"
                        NewFileName = prefix.Text + "_" + Path.GetFileName(file)
                    Case "Präfix + Nummerierung"
                        Dim Nummer As String = FilesProcessed + 1

                        While Nummer.Length < FilesCount.ToString.Length
                            Nummer = "0" + Nummer
                        End While


                        NewFileName = prefix.Text + "_" + (Nummer).ToString
                End Select

                NewFileName = NewFileName.Replace(":", ".")
                NewFileName = NewFileName.Replace(" ", "_")
                NewFileName = NewFileName + IO.Path.GetExtension(file)
                NewFileName = Destination.Text + NewFileName

                If System.IO.File.Exists(NewFileName) Then

                    If Settings.FileOverwrite.Checked Then
                        My.Computer.FileSystem.DeleteFile(NewFileName)
                        FileCopy(file, NewFileName)
                        FilesScceeded.Items.Add(file)
                    Else

                        If Settings.LogOnlyErrors.CheckState = CheckState.Unchecked Then
                            logs.AddLog("Die Datei " + file + " wurde nicht kopiert, da sie schon vorhanden ist.")

                        End If

                        FilesFailed.Items.Add(file)
                    End If

                Else
                    FileCopy(file, NewFileName)
                    FilesScceeded.Items.Add(file)
                    If Settings.LogOnlyErrors.CheckState = CheckState.Unchecked Then
                        logs.AddLog("Die Datei " + file + " wurde kopiert.")
                    End If
                End If


            Catch ex As Exception
                FilesFailed.Items.Add(file)
            logs.AddLog("Die Datei " + file + " konnte nicht Kopiert werden:" + ex.GetType.ToString)
            End Try
            FilesProcessed = FilesProcessed + 1
            ProgressBar1.Value = FilesProcessed / FilesCount * 100

            Select Case Settings.WorkingSpeed.Text
                Case "1 - Langsamer"
                    warte(0.5)
                Case "2 - Normal"
                    warte(0.2)
                Case "3 - Schnell"

            End Select

        Next

        If FilesFailed.Items.Count = 0 Then
            MsgBox("Der Vorgang wurde abgeschlossen", MsgBoxStyle.Information, Title:="Fertig")
        Else
            Select Case MessageBox.Show(FilesFailed.Items.Count.ToString + " Dateien konnten nicht kopiert werden. Sollen diese für einen neuen Versuch in die Dateiliste übernommen werden?", "Fehlerhafte Dateien", MessageBoxButtons.YesNo)
                Case Windows.Forms.DialogResult.Yes
                    FileList.Items.Clear()
                    FilesScceeded.Items.Clear()

                    For Each item In FilesFailed.Items
                        FileList.Items.Add(item)
                    Next

                    FilesFailed.Items.Clear()

                    MsgBox("Die Dateien wurden in die Liste geschoben" + vbNewLine + vbNewLine + "Starte jetzt einfach den Kopiervorgang", MsgBoxStyle.Information, Title:="Dateien hinzugefügt")

                Case Windows.Forms.DialogResult.No

            End Select
        End If

        ProgressBar1.Visible = False
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Sources.Items.Clear()
        Destination.Text = ""
        FileList.Items.Clear()
        FilesFailed.Items.Clear()
        FilesScceeded.Items.Clear()
        FileInfo.Text = "Keine Datei gewählt"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Settings.ShowDialog()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        logs.ShowDialog()
    End Sub

    Private Sub prefix_insertchar(sender As Object, e As KeyPressEventArgs) Handles prefix.KeyPress, prefix.KeyPress
        Dim c = e.KeyChar
        If c >= "a" AndAlso c <= "z" OrElse c >= "A" AndAlso c <= "Z" Or Not Char.IsDigit(c, 0) = False Then
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub prefix_DeleteChar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles prefix.KeyDown
        If e.KeyData = Keys.Back Then
            If prefix.Text = "" Then
                Return
            Else
                prefix.Text = prefix.Text.Substring(0, prefix.Text.Length - 1)
                prefix.SelectionStart = prefix.TextLength
            End If
        End If
    End Sub
End Class
