<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FormEinstellungen
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
    Private mainMenu1 As System.Windows.Forms.MainMenu

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItemZurueck = New System.Windows.Forms.MenuItem
        Me.MenuItemUebernehmen = New System.Windows.Forms.MenuItem
        Me.HeaderMain = New StedySoft.SenseSDK.SenseHeaderControl
        Me.ComboBoxHaltestelle = New StedySoft.SenseSDK.SenseComboControl
        Me.LabelHaltestelle = New System.Windows.Forms.Label
        Me.CheckBoxFeiertag = New StedySoft.SenseSDK.SenseCheckboxControl
        Me.CheckBoxDebug = New StedySoft.SenseSDK.SenseCheckboxControl
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.Add(Me.MenuItemZurueck)
        Me.mainMenu1.MenuItems.Add(Me.MenuItemUebernehmen)
        '
        'MenuItemZurueck
        '
        Me.MenuItemZurueck.Text = "zurück"
        '
        'MenuItemUebernehmen
        '
        Me.MenuItemUebernehmen.Text = "übernehmen"
        '
        'HeaderMain
        '
        Me.HeaderMain.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderMain.Location = New System.Drawing.Point(0, 0)
        Me.HeaderMain.Name = "HeaderMain"
        Me.HeaderMain.Size = New System.Drawing.Size(240, 25)
        Me.HeaderMain.TabIndex = 0
        Me.HeaderMain.Text = "Einstellungen"
        '
        'ComboBoxHaltestelle
        '
        Me.ComboBoxHaltestelle.Location = New System.Drawing.Point(20, 65)
        Me.ComboBoxHaltestelle.MaxDropdowns = 4
        Me.ComboBoxHaltestelle.Name = "ComboBoxHaltestelle"
        Me.ComboBoxHaltestelle.Size = New System.Drawing.Size(199, 28)
        Me.ComboBoxHaltestelle.TabIndex = 1
        '
        'LabelHaltestelle
        '
        Me.LabelHaltestelle.Location = New System.Drawing.Point(20, 42)
        Me.LabelHaltestelle.Name = "LabelHaltestelle"
        Me.LabelHaltestelle.Size = New System.Drawing.Size(100, 20)
        Me.LabelHaltestelle.Text = "Haltestelle:"
        '
        'CheckBoxFeiertag
        '
        Me.CheckBoxFeiertag.Location = New System.Drawing.Point(20, 115)
        Me.CheckBoxFeiertag.Name = "CheckBoxFeiertag"
        Me.CheckBoxFeiertag.Size = New System.Drawing.Size(168, 19)
        Me.CheckBoxFeiertag.Status = StedySoft.SenseSDK.ItemStatus.Off
        Me.CheckBoxFeiertag.TabIndex = 12
        Me.CheckBoxFeiertag.Text = "Heute ist Feitertag!"
        '
        'CheckBoxDebug
        '
        Me.CheckBoxDebug.Location = New System.Drawing.Point(20, 140)
        Me.CheckBoxDebug.Name = "CheckBoxDebug"
        Me.CheckBoxDebug.Size = New System.Drawing.Size(180, 19)
        Me.CheckBoxDebug.Status = StedySoft.SenseSDK.ItemStatus.Off
        Me.CheckBoxDebug.TabIndex = 14
        Me.CheckBoxDebug.Text = "DebugInfos anzeigen"
        '
        'FormEinstellungen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.CheckBoxDebug)
        Me.Controls.Add(Me.CheckBoxFeiertag)
        Me.Controls.Add(Me.LabelHaltestelle)
        Me.Controls.Add(Me.ComboBoxHaltestelle)
        Me.Controls.Add(Me.HeaderMain)
        Me.Menu = Me.mainMenu1
        Me.Name = "FormEinstellungen"
        Me.Text = "Einstellungen"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HeaderMain As StedySoft.SenseSDK.SenseHeaderControl
    Friend WithEvents MenuItemZurueck As System.Windows.Forms.MenuItem
    Friend WithEvents ComboBoxHaltestelle As StedySoft.SenseSDK.SenseComboControl
    Friend WithEvents LabelHaltestelle As System.Windows.Forms.Label
    Friend WithEvents MenuItemUebernehmen As System.Windows.Forms.MenuItem
    Friend WithEvents CheckBoxFeiertag As StedySoft.SenseSDK.SenseCheckboxControl
    Friend WithEvents CheckBoxDebug As StedySoft.SenseSDK.SenseCheckboxControl
End Class
