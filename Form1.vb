Imports System.IO
Imports System.Media

Public Class Form1

    ' общ soundplayer за всички звънци
    Dim player As SoundPlayer

    ' последен звънец, за да не звъни многократно в една минута
    Dim lastring As String = ""

    ' петленцето трябва да звънне само веднъж на ден
    Dim roosterRungToday As Boolean = False

    ' път до csv файла за графика
    Dim scheduleFile As String = Application.StartupPath & "\schedule.csv"

    ' -----------------------------
    ' форма load
    ' -----------------------------
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSchedule()
        Timer1.Start()
    End Sub

    ' -----------------------------
    ' таймер за текущо време и звънци
    ' -----------------------------
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ' текущо време
        Dim nowTime As DateTime = DateTime.Now
        lblClock.Text = nowTime.ToString("HH:mm:ss")

        Dim currentTime As String = nowTime.ToString("HH:mm")
        Dim today As String = nowTime.DayOfWeek.ToString().ToLower() ' monday, tuesday...

        ' =============================
        ' проверка за начало на часа (*_col)
        ' =============================
        Dim startColName As String = today.Substring(0, 3) & "_col"
        Dim startColIndex As Integer = -1

        For Each col As DataGridViewColumn In DataGridView1.Columns
            If col.Name.ToLower() = startColName Then
                startColIndex = col.Index
                Exit For
            End If
        Next

        If startColIndex <> -1 Then
            For Each row As DataGridViewRow In DataGridView1.Rows
                Dim cell As DataGridViewCell = row.Cells(startColIndex)
                If cell.Value IsNot Nothing Then
                    If cell.Value.ToString = currentTime And lastring <> currentTime Then
                        ' първи ред = първи час
                        If row.Index = 0 And Not roosterRungToday Then
                            PlayBell1()   ' petlence.wav
                            roosterRungToday = True
                        Else
                            PlayBell()    ' bell.wav
                        End If
                        lastring = currentTime
                    End If
                End If
            Next
        End If

        ' =============================
        ' проверка за край на часа (*_e_col)
        ' =============================
        Dim endColName As String = today.Substring(0, 3) & "e_col"
        Dim endColIndex As Integer = -1

        For Each col As DataGridViewColumn In DataGridView1.Columns
            If col.Name.ToLower() = endColName Then
                endColIndex = col.Index
                Exit For
            End If
        Next

        If endColIndex <> -1 Then
            For Each row As DataGridViewRow In DataGridView1.Rows
                Dim cell As DataGridViewCell = row.Cells(endColIndex)
                If cell.Value IsNot Nothing Then
                    If cell.Value.ToString = currentTime And lastring <> currentTime Then
                        PlayBell() ' винаги обикновен звънец
                        lastring = currentTime
                    End If
                End If
            Next
        End If

        ' =============================
        ' изчисляване на време до следващ час и междучасие
        ' =============================
        Dim nextClass As DateTime? = Nothing
        Dim nextBreak As DateTime? = Nothing

        ' проверка за следващ час
        If startColIndex <> -1 Then
            For Each row As DataGridViewRow In DataGridView1.Rows
                Dim cell As DataGridViewCell = row.Cells(startColIndex)
                If cell.Value IsNot Nothing Then
                    Dim t As DateTime
                    If DateTime.TryParseExact(cell.Value.ToString, "HH:mm", Nothing, Globalization.DateTimeStyles.None, t) Then
                        t = t.Date + t.TimeOfDay
                        If t > nowTime Then
                            nextClass = t
                            Exit For
                        End If
                    End If
                End If
            Next
        End If

        ' проверка за следващо междучасие
        If endColIndex <> -1 Then
            For Each row As DataGridViewRow In DataGridView1.Rows
                Dim cell As DataGridViewCell = row.Cells(endColIndex)
                If cell.Value IsNot Nothing Then
                    Dim t As DateTime
                    If DateTime.TryParseExact(cell.Value.ToString, "HH:mm", Nothing, Globalization.DateTimeStyles.None, t) Then
                        t = t.Date + t.TimeOfDay
                        If t > nowTime Then
                            nextBreak = t
                            Exit For
                        End If
                    End If
                End If
            Next
        End If

        ' обновяване на TimeTillClass
        If nextClass.HasValue Then
            Dim ts = nextClass.Value - nowTime
            TimeTillClass.Text = ts.ToString("hh\:mm\:ss")  ' само време
        Else
            TimeTillClass.Text = "-"
        End If

        ' обновяване на TimeTillBreak
        If nextBreak.HasValue Then
            Dim tsb = nextBreak.Value - nowTime
            TimeTillBreak.Text = tsb.ToString("hh\:mm\:ss")  ' само време
        Else
            TimeTillBreak.Text = "-"
        End If

        ' reset на петленцето за следващия ден
        If nowTime.ToString("HH:mm") = "00:00" Then
            roosterRungToday = False
        End If

    End Sub

    ' -----------------------------
    ' функции за звънци
    ' -----------------------------
    Sub PlayBell1()
        player = New SoundPlayer(Application.StartupPath & "\petlence.wav")
        player.Play()
    End Sub

    Sub PlayBell()
        player = New SoundPlayer(Application.StartupPath & "\bell.wav")
        player.Play()
    End Sub

    ' ръчно пускане на bell.wav
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PlayBell()
    End Sub

    ' ръчно пускане на petlence.wav
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PlayBell1()
    End Sub

    ' стоп бутон
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If player IsNot Nothing Then
            player.Stop()
        End If
    End Sub

    ' about popup
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MessageBox.Show("Bulcom School Bell" & vbCrLf &
                        "Версия 1.0" & vbCrLf &
                        "Автор: Андрей Янев" & vbCrLf &
                        "Булком, Bulcom © 2026",
                        "Относно програмата",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub

    ' -----------------------------
    ' запаметяване и зареждане на графика
    ' -----------------------------
    Private Sub SaveSchedule()
        Using sw As New StreamWriter(scheduleFile)
            ' заглавия
            Dim headers As New List(Of String)
            For Each col As DataGridViewColumn In DataGridView1.Columns
                headers.Add(col.Name)
            Next
            sw.WriteLine(String.Join(",", headers))

            ' редове
            For Each row As DataGridViewRow In DataGridView1.Rows
                Dim cells As New List(Of String)
                For Each cell As DataGridViewCell In row.Cells
                    If cell.Value IsNot Nothing Then
                        cells.Add(cell.Value.ToString)
                    Else
                        cells.Add("")
                    End If
                Next
                sw.WriteLine(String.Join(",", cells))
            Next
        End Using
    End Sub

    Private Sub LoadSchedule()
        If Not File.Exists(scheduleFile) Then Return

        DataGridView1.Rows.Clear()
        DataGridView1.Columns.Clear()

        Dim lines() As String = File.ReadAllLines(scheduleFile)
        If lines.Length = 0 Then Return

        ' заглавия
        Dim headers() As String = lines(0).Split(","c)
        For Each h In headers
            DataGridView1.Columns.Add(h, h)
        Next

        ' редове
        For i As Integer = 1 To lines.Length - 1
            Dim values() As String = lines(i).Split(","c)
            DataGridView1.Rows.Add(values)
        Next
    End Sub

    ' бутон Save
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveSchedule()
        MessageBox.Show("Графикът е запазен успешно!", "Запазване", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        MessageBox.Show("Тази програма е направена благодарение на ChatGPT и Tomasz (@th03_tlv)")
    End Sub
End Class