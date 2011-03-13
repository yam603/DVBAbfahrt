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

    Private Debug As Boolean

    Private Feiertag As Boolean

    Private Sub Einstellungen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Debug = False
        Feiertag = False
        ComboBoxHaltestelle.Items.Add(New SenseComboControl.Item("Bergmannstraße", 0))
        ComboBoxHaltestelle.Items.Add(New SenseComboControl.Item("TU Campus", 1))
        ComboBoxHaltestelle.Items.Add(New SenseComboControl.Item("XXL Klettern", 2))
    End Sub

    Private Sub MenuItemUebernehmen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemUebernehmen.Click
        If ComboBoxHaltestelle.SelectedText = "" Then
            ComboBoxHaltestelle.SelectedValue = 0
        Else : GewaehlteHaltestelle.Index = ComboBoxHaltestelle.SelectedValue
            GewaehlteHaltestelle.Name = ComboBoxHaltestelle.SelectedText
        End If
        If CheckBoxDebug.Status = ItemStatus.On Then Debug = True Else Debug = False
        If CheckBoxFeiertag.Status = ItemStatus.On Then Feiertag = True Else Feiertag = False
        FormMain.AusgabeLeeren()
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
End Class