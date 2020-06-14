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



        For Each file In FileList.Items

            Try
                Dim NewFileName As String
                NewFileName = System.IO.File.GetCreationTime(file)
                NewFileName = NewFileName.Replace(":", ".")
                NewFileName = NewFileName.Replace(" ", "_")
                NewFileName = NewFileName + IO.Path.GetExtension(file)
                NewFileName = Destination.Text + NewFileName

                If System.IO.File.Exists(NewFileName) Then 'Pfad = Kompeltter Pfad mit Dateinamen + ENdung

                    If FileOverwrite.Checked Then
                        My.Computer.FileSystem.DeleteFile(NewFileName)
                        FileCopy(file, NewFileName)
                        FilesScceeded.Items.Add(file)
                    Else
                        FilesFailed.Items.Add(file)
                    End If

                Else
                    FileCopy(file, NewFileName)
                    FilesScceeded.Items.Add(file)
                End If


            Catch ex As Exception
                FilesFailed.Items.Add(file)
            End Try
            FilesProcessed = FilesProcessed + 1
            ProgressBar1.Value = FilesProcessed / FilesCount * 100
            warte(0.1)

        Next
        MsgBox("Der Vorgang wurde abgeschlossen", MsgBoxStyle.Information, Title:="Fertig")
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
End Class
