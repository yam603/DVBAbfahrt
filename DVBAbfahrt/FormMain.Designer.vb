﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FormMain
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ButtonAbfahrt = New StedySoft.SenseSDK.SenseButtonControl
        Me.ComboWarteZeit = New StedySoft.SenseSDK.SenseComboControl
        Me.LabelUhrzeit = New System.Windows.Forms.Label
        Me.TextBoxAbfahrt = New StedySoft.SenseSDK.SenseTextboxControl
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.Einstellungen = New System.Windows.Forms.MenuItem
        Me.Timer1 = New System.Windows.Forms.Timer
        Me.LabelHaltestelle = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.HeaderMain = New StedySoft.SenseSDK.SenseHeaderControl
        Me.LabelVersion = New System.Windows.Forms.Label
        Me.MainMenu2 = New System.Windows.Forms.MainMenu
        Me.MenuItemEinstellungen = New System.Windows.Forms.MenuItem
        Me.LabelFahrplanDatum = New System.Windows.Forms.Label
        Me.Timer2 = New System.Windows.Forms.Timer
        Me.SuspendLayout()
        '
        'ButtonAbfahrt
        '
        Me.ButtonAbfahrt.Location = New System.Drawing.Point(20, 105)
        Me.ButtonAbfahrt.Name = "ButtonAbfahrt"
        Me.ButtonAbfahrt.Size = New System.Drawing.Size(199, 28)
        Me.ButtonAbfahrt.TabIndex = 0
        Me.ButtonAbfahrt.Text = "Nächste Abfahrt"
        '
        'ComboWarteZeit
        '
        Me.ComboWarteZeit.Location = New System.Drawing.Point(119, 51)
        Me.ComboWarteZeit.MaxDropdowns = 7
        Me.ComboWarteZeit.Name = "ComboWarteZeit"
        Me.ComboWarteZeit.Size = New System.Drawing.Size(100, 28)
        Me.ComboWarteZeit.TabIndex = 1
        '
        'LabelUhrzeit
        '
        Me.LabelUhrzeit.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.LabelUhrzeit.Location = New System.Drawing.Point(110, 28)
        Me.LabelUhrzeit.Name = "LabelUhrzeit"
        Me.LabelUhrzeit.Size = New System.Drawing.Size(109, 20)
        Me.LabelUhrzeit.Text = "Uhrzeit"
        Me.LabelUhrzeit.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBoxAbfahrt
        '
        Me.TextBoxAbfahrt.AcceptsReturn = True
        Me.TextBoxAbfahrt.AcceptsTab = True
        Me.TextBoxAbfahrt.HideSelection = True
        Me.TextBoxAbfahrt.Location = New System.Drawing.Point(20, 139)
        Me.TextBoxAbfahrt.MaxLength = 32767
        Me.TextBoxAbfahrt.Multiline = True
        Me.TextBoxAbfahrt.Name = "TextBoxAbfahrt"
        Me.TextBoxAbfahrt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBoxAbfahrt.ReadOnly = True
        Me.TextBoxAbfahrt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TextBoxAbfahrt.Size = New System.Drawing.Size(199, 191)
        Me.TextBoxAbfahrt.TabIndex = 3
        Me.TextBoxAbfahrt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextBoxAbfahrt.WordWrap = False
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.Add(Me.Einstellungen)
        '
        'Einstellungen
        '
        Me.Einstellungen.Text = "Einstellungen"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'LabelHaltestelle
        '
        Me.LabelHaltestelle.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelHaltestelle.Location = New System.Drawing.Point(20, 82)
        Me.LabelHaltestelle.Name = "LabelHaltestelle"
        Me.LabelHaltestelle.Size = New System.Drawing.Size(199, 20)
        Me.LabelHaltestelle.Text = "Haltestelle"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(20, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 20)
        Me.Label1.Text = "Abfahrt in:"
        '
        'HeaderMain
        '
        Me.HeaderMain.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderMain.Location = New System.Drawing.Point(0, 0)
        Me.HeaderMain.Name = "HeaderMain"
        Me.HeaderMain.Size = New System.Drawing.Size(240, 25)
        Me.HeaderMain.TabIndex = 0
        Me.HeaderMain.Text = "DVBAbfahrt"
        '
        'LabelVersion
        '
        Me.LabelVersion.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.LabelVersion.Location = New System.Drawing.Point(20, 28)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(100, 14)
        Me.LabelVersion.Text = "Version"
        '
        'MainMenu2
        '
        Me.MainMenu2.MenuItems.Add(Me.MenuItemEinstellungen)
        '
        'MenuItemEinstellungen
        '
        Me.MenuItemEinstellungen.Text = "Einstellungen"
        '
        'LabelFahrplanDatum
        '
        Me.LabelFahrplanDatum.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.LabelFahrplanDatum.Location = New System.Drawing.Point(20, 332)
        Me.LabelFahrplanDatum.Name = "LabelFahrplanDatum"
        Me.LabelFahrplanDatum.Size = New System.Drawing.Size(199, 14)
        Me.LabelFahrplanDatum.Text = "FahrplanDatum"
        '
        'Timer2
        '
        Me.Timer2.Interval = 10000
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.LabelFahrplanDatum)
        Me.Controls.Add(Me.LabelVersion)
        Me.Controls.Add(Me.HeaderMain)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelHaltestelle)
        Me.Controls.Add(Me.TextBoxAbfahrt)
        Me.Controls.Add(Me.LabelUhrzeit)
        Me.Controls.Add(Me.ComboWarteZeit)
        Me.Controls.Add(Me.ButtonAbfahrt)
        Me.Menu = Me.MainMenu1
        Me.Name = "FormMain"
        Me.Text = "DVBAbfahrt"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonAbfahrt As StedySoft.SenseSDK.SenseButtonControl
    Friend WithEvents ComboWarteZeit As StedySoft.SenseSDK.SenseComboControl
    Friend WithEvents LabelUhrzeit As System.Windows.Forms.Label
    Friend WithEvents TextBoxAbfahrt As StedySoft.SenseSDK.SenseTextboxControl
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LabelHaltestelle As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents HeaderMain As StedySoft.SenseSDK.SenseHeaderControl
    Friend WithEvents LabelVersion As System.Windows.Forms.Label
    Friend WithEvents MainMenu2 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItemEinstellungen As System.Windows.Forms.MenuItem
    Friend WithEvents Einstellungen As System.Windows.Forms.MenuItem
    Friend WithEvents LabelFahrplanDatum As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer

End Class
