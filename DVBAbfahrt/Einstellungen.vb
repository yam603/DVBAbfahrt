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

    Private Linienzuordnung As Byte(,) = {{0, 10, 4, 63, 74, 255, 0, 0}, _
                                      {1, 61, 66, 85, 255, 0, 0, 0}, _
                                      {2, 1, 2, 255, 0, 0, 0, 0} _
                                      }

    Private GewaehlteHaltestelle As Haltestelle

    Private Sub Einstellungen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBoxHaltestelle.Items.Add(New SenseComboControl.Item("Bergmannstraße", 0))
        ComboBoxHaltestelle.Items.Add(New SenseComboControl.Item("TU Campus", 1))
        ComboBoxHaltestelle.Items.Add(New SenseComboControl.Item("XXL Klettern", 2))
    End Sub

    Private Sub MenuItemUebernehmen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemUebernehmen.Click
        GewaehlteHaltestelle.Index = ComboBoxHaltestelle.SelectedValue
        GewaehlteHaltestelle.Name = ComboBoxHaltestelle.SelectedText
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
End Class