Imports System.ComponentModel

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSettings
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtbSmtpPort = New System.Windows.Forms.TextBox()
        Me.chbEnableSsl = New System.Windows.Forms.CheckBox()
        Me.txtbNameSender = New System.Windows.Forms.TextBox()
        Me.txtbSmtpServer = New System.Windows.Forms.TextBox()
        Me.txtbPassword = New System.Windows.Forms.TextBox()
        Me.txtbEmail = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Email:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Пароль:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "SMTP сервер:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "SMTP порт:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Имя отправителя:"
        '
        'txtbSmtpPort
        '
        Me.txtbSmtpPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbSmtpPort.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.SamodelkinSendEmail.My.MySettings.Default, "pSmtpPort", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtbSmtpPort.Location = New System.Drawing.Point(113, 92)
        Me.txtbSmtpPort.Name = "txtbSmtpPort"
        Me.txtbSmtpPort.Size = New System.Drawing.Size(46, 20)
        Me.txtbSmtpPort.TabIndex = 13
        Me.txtbSmtpPort.Text = Global.SamodelkinSendEmail.My.MySettings.Default.pSmtpPort
        '
        'chbEnableSsl
        '
        Me.chbEnableSsl.AutoSize = True
        Me.chbEnableSsl.Checked = Global.SamodelkinSendEmail.My.MySettings.Default.pEnableSsl
        Me.chbEnableSsl.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbEnableSsl.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.SamodelkinSendEmail.My.MySettings.Default, "pEnableSsl", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chbEnableSsl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbEnableSsl.Location = New System.Drawing.Point(113, 143)
        Me.chbEnableSsl.Name = "chbEnableSsl"
        Me.chbEnableSsl.Size = New System.Drawing.Size(119, 17)
        Me.chbEnableSsl.TabIndex = 12
        Me.chbEnableSsl.Text = "Использовать SSL"
        Me.chbEnableSsl.UseVisualStyleBackColor = True
        '
        'txtbNameSender
        '
        Me.txtbNameSender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbNameSender.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.SamodelkinSendEmail.My.MySettings.Default, "pNameSender", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtbNameSender.Location = New System.Drawing.Point(113, 117)
        Me.txtbNameSender.Name = "txtbNameSender"
        Me.txtbNameSender.Size = New System.Drawing.Size(159, 20)
        Me.txtbNameSender.TabIndex = 10
        Me.txtbNameSender.Text = Global.SamodelkinSendEmail.My.MySettings.Default.pNameSender
        '
        'txtbSmtpServer
        '
        Me.txtbSmtpServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbSmtpServer.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.SamodelkinSendEmail.My.MySettings.Default, "pSmtpServer", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtbSmtpServer.Location = New System.Drawing.Point(113, 65)
        Me.txtbSmtpServer.Name = "txtbSmtpServer"
        Me.txtbSmtpServer.Size = New System.Drawing.Size(159, 20)
        Me.txtbSmtpServer.TabIndex = 6
        Me.txtbSmtpServer.Text = Global.SamodelkinSendEmail.My.MySettings.Default.pSmtpServer
        '
        'txtbPassword
        '
        Me.txtbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbPassword.Location = New System.Drawing.Point(113, 39)
        Me.txtbPassword.Name = "txtbPassword"
        Me.txtbPassword.Size = New System.Drawing.Size(159, 20)
        Me.txtbPassword.TabIndex = 4
        Me.txtbPassword.Text = Global.SamodelkinSendEmail.My.MySettings.Default.pPassword
        Me.txtbPassword.UseSystemPasswordChar = True
        '
        'txtbEmail
        '
        Me.txtbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbEmail.Location = New System.Drawing.Point(113, 14)
        Me.txtbEmail.Name = "txtbEmail"
        Me.txtbEmail.Size = New System.Drawing.Size(159, 20)
        Me.txtbEmail.TabIndex = 2
        Me.txtbEmail.Text = Global.SamodelkinSendEmail.My.MySettings.Default.pEmail
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(284, 169)
        Me.Controls.Add(Me.txtbSmtpPort)
        Me.Controls.Add(Me.chbEnableSsl)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtbNameSender)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtbSmtpServer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtbPassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtbEmail)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettings"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Настройки"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtbEmail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbSmtpServer As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtbNameSender As TextBox
    Friend WithEvents chbEnableSsl As CheckBox
    Friend WithEvents txtbSmtpPort As TextBox

    Private Sub frmSettings_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Settings.Save()
    End Sub
End Class
