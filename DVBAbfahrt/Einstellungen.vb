Imports System
Imports System.Drawing
Imports System.Globalization
Imports System.IO
Imports System.Reflection
Imports System.Windows.Forms

Imports Microsoft.Drawing

Imports StedySoft.SenseSDK
Imports StedySoft.SenseSDK.DrawingCE
Imports StedySoft.SenseSDK.Localization

Public Class FormEinstellungen
    Public Structure Haltestelle
        Dim Index As Byte
        Dim Name As String
    End Structure

    Private GewaehlteHaltestelle As Haltestelle

    Private Debug, Feiertag, Update As Boolean

    Private Sub Einstellungen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Debug = False
        Feiertag = False
        Update = False
        For i = 0 To Fahrplan.GetAnzahlHaltestellen - 1
            ComboBoxHaltestelle.Items.Add(New SenseComboControl.Item(Fahrplan.GetHaltestellenName(i), i))
        Next i
    End Sub

    Private Sub MenuItemUebernehmen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemUebernehmen.Click
        If ComboBoxHaltestelle.SelectedText = "" Then
            ComboBoxHaltestelle.SelectedValue = 0
        Else : GewaehlteHaltestelle.Index = ComboBoxHaltestelle.SelectedValue
            GewaehlteHaltestelle.Name = ComboBoxHaltestelle.SelectedText
        End If
        If CheckBoxDebug.Status = ItemStatus.On Then Debug = True Else Debug = False
        If CheckBoxFeiertag.Status = ItemStatus.On Then Feiertag = True Else Feiertag = False
        If CheckBoxUpdate.Status = ItemStatus.On Then
            FormMain.Timer2.Enabled = True
            Update = True
        Else : Update = False
            FormMain.Timer2.Enabled = False
        End If
        FormMain.AusgabeLeeren()
        FormMain.AbfahrtBerrechnen()
        Me.Hide()
    End Sub

    Public Function GetHaltestelle() As Haltestelle
        Return GewaehlteHaltestelle
    End Function

    Public Sub SetHaltestelle(ByVal Haltestelle As Byte, ByVal Name As String)
        GewaehlteHaltestelle.Index = Haltestelle
        GewaehlteHaltestelle.Name = Name
    End Sub

    Private Sub MenuItemZurueck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemZurueck.Click
        Me.Hide()
    End Sub

    Private Sub FormEinstellungen_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        ComboBoxHaltestelle.SelectedValue = GewaehlteHaltestelle.Index
    End Sub

    Public Function GetDebug() As Boolean
        Return Debug
    End Function

    Public Function GetFeiertag() As Boolean
        Return Feiertag
    End Function

    Public Function GetUpdateStatus() As Boolean
        Return Update
    End Function
End Class