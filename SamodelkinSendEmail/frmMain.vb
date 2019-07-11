Imports System.Net.Mail
Imports System.Text
Imports System
Imports System.IO
Imports System.Text.RegularExpressions
Public Class frmMain

    Dim WithEvents NI As New NotifyIcon

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Dim emailPattern As String = "^[\w-\._\+%]+@(?:[\w-]+\.)+[\w]{2,6}$"
        Dim counter As Integer
        'Create a string array and store the contents of the Lines property.
        Dim emails() As String
        emails = txtRecipient.Lines

        If emails.GetUpperBound(0) = -1 Then
            ShowBalloonMessage("Не заполнен список адресов!", ToolTipIcon.Error)
            Exit Sub
        End If

        If txtSubject.Text.Trim() = "" Then
            'MsgBox("Не задана тема письма!")
            ShowBalloonMessage("Не задана тема письма!", ToolTipIcon.Error)
            Exit Sub
        End If

        If Not IO.File.Exists(txtFileOfBody.Text) Then
            'MsgBox("Файл с телом письма не найден!")
            ShowBalloonMessage("Файл с телом письма не найден!", ToolTipIcon.Error)
            Exit Sub
        End If

        My.Settings.Reload()
        Dim lfrmProgress As New frmProgress
        Try
            lfrmProgress.Show(Me)
            lfrmProgress.ProgressBar.Maximum = emails.GetUpperBound(0) + 1

            For counter = 0 To emails.GetUpperBound(0)

                If (emails(counter).Trim <> "") And (Regex.Match(emails(counter), emailPattern).Success) Then

                    lfrmProgress.ProgressBar.Value = counter + 1

                    Dim txtBody As String

                    Dim F_R As New StreamReader(txtFileOfBody.Text) ' Открываем файл D:test1.txt в стандартной кодировке 1251
                    txtBody = F_R.ReadToEnd ' Читаем в текстовое поле текст. ReadToEnd - это метод чтения файла полностью, есть метод ReadLine - чтение одной строчки
                    F_R.Close()

                    Dim email As New MailMessage
                    Dim smtp As SmtpClient

                    smtp = New SmtpClient(My.Settings("pSmtpServer")) ' Пример smtp.mail.ru
                    smtp.Port = CInt(My.Settings("pSmtpPort"))
                    smtp.EnableSsl = My.Settings("pEnableSsl")
                    smtp.Credentials = New Net.NetworkCredential(My.Settings("pEmail").ToString(), My.Settings("pPassword").ToString())
                    email.From = New MailAddress(My.Settings("pEmail"), My.Settings("pNameSender"))
                    email.To.Add(New MailAddress(emails(counter)))
                    email.IsBodyHtml = True
                    email.Body = txtBody
                    email.Subject = txtSubject.Text
                    'email.Attachments.Add(New System.Net.Mail.Attachment("Путь к файлу, вложение")) ' Пример D:/SendMessage.exe
                    lfrmProgress.lblProgressNote.Text = "Отправка на адрес: " + emails(counter) + " (" + (counter + 1).ToString() + " из " + (emails.GetUpperBound(0) + 1).ToString() + ")"
                    lfrmProgress.Refresh()
                    Try
                        smtp.Send(email)
                        'MsgBox("Успешно отправленно на адрес " + emails(counter))
                        System.Threading.Thread.Sleep(200)
                    Catch ex As Exception
                        'MsgBox("Не удалось отправить письмо! " + ex.Message)
                        ShowBalloonMessage("Не удалось отправить письмо! " + ex.Message, ToolTipIcon.Error)
                        lfrmProgress.Close()
                    End Try
                Else
                    MsgBox("Не корректный адрес почты " + emails(counter))
                End If
            Next
            lfrmProgress.Close()
            ShowBalloonMessage("Письма отправлены адресатам", ToolTipIcon.Info)
        Catch
            lfrmProgress.Close()
        End Try

    End Sub

    Private Sub ShowBalloonMessage(strMessage As String, BalloonTipIcon As ToolTipIcon)
        NI.Visible = False
        NI.Text = "NEMCHINOV.PRO"
        NI.BalloonTipTitle = "Рассылка писем"
        NI.BalloonTipIcon = BalloonTipIcon
        NI.Icon = Me.Icon
        NI.BalloonTipText = strMessage.ToString()
        NI.Visible = True
        NI.ShowBalloonTip(10000)
    End Sub

    Private Sub NI_BalloonTipClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles NI.BalloonTipClosed
        NI.Visible = False
        'Icon = Nothing
        'NI.Dispose()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        OFD1.Title = "Выберите файл с телом письма" ' Указываем заголовок
        OFD1.Filter = "HTML файлы|*.html; *.htm" ' При помощи фильтра можно отбросить ненужные типы файлов(в нашем случае делаем выбор из списка(HTML файлы, Текстовые файлы, Все файлы)).
        OFD1.FilterIndex = 1 ' Если есть список выбора типов, то можно указать какой тип будет выбран при загрузке диалога
        If OFD1.ShowDialog = DialogResult.OK Then txtFileOfBody.Text = OFD1.FileName
    End Sub

    Private Sub Form1_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.pSubject = txtSubject.Text
        My.Settings.pFileOfBody = txtFileOfBody.Text
        My.MySettings.Default.Save()
        'SaveSetting("SamodelkinSendEmail", "Settings", "txtSubject", txtSubject.Text)
        'SaveSetting("SamodelkinSendEmail", "Settings", "txtFileOfBody", txtFileOfBody.Text)
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'txtSubject.Text = GetSetting("SamodelkinSendEmail", "Settings", "txtSubject")
        'txtFileOfBody.Text = GetSetting("SamodelkinSendEmail", "Settings", "txtFileOfBody")
        txtRecipient.ContextMenuStrip = ContextMenuStrip1
    End Sub

    Private Sub cmsInsert_Click(sender As System.Object, e As System.EventArgs) Handles cmsInsert.Click
        Dim strData As String
        strData = Replace(My.Computer.Clipboard.GetText, vbCrLf, " ")
        strData = strData.Substring(InStr(strData, "mailto:") + 6)
        strData = strData.Substring(0, InStr(strData, " "))
        txtRecipient.Text = strData.Trim
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://nemchinov.pro")
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        My.Forms.frmSettings.ShowDialog(Me)
    End Sub

End Class
