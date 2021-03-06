﻿Imports System
Imports System.Drawing
Imports System.Globalization
Imports System.IO
Imports System.Reflection
Imports System.Windows.Forms

Imports Microsoft.Drawing

Imports StedySoft.SenseSDK
Imports StedySoft.SenseSDK.DrawingCE
Imports StedySoft.SenseSDK.Localization

Public Class FormMain

    Public Sub ZeigeDebugInfo(ByVal Beschreibung As String, ByVal Wert As String)
        TextBoxAbfahrt.Text = TextBoxAbfahrt.Text & Beschreibung & ": " & Wert & vbNewLine & vbNewLine
    End Sub
    Private Sub ZeitAnzeigen()
        LabelUhrzeit.Text = TagDecodierungTagDeutsch(TagCodierungTag(Date.Now.DayOfWeek)) & ", " & UhrzeitFormat(Date.Now.Hour) & ":" & UhrzeitFormat(Date.Now.Minute)
    End Sub

    Private Sub ZeigeAbfahrtsZeit(ByVal Linie As String, ByVal AbfahrtsZeit As String)
        Dim Abfahrt As New DateTime(Funktionen.getAbfahrtsZeit.Year, Funktionen.getAbfahrtsZeit.Month, Funktionen.getAbfahrtsZeit.Day, Funktionen.getStundeAbfahrt, Funktionen.getMinuteAbfahrt, 0)

        TextBoxAbfahrt.Text = TextBoxAbfahrt.Text & Linie & vbNewLine & "- " & AbfahrtsZeit

        If FormEinstellungen.GetVerbleibendeZeit Then
            TextBoxAbfahrt.Text = TextBoxAbfahrt.Text & " (in " & Math.Round(Abfahrt.Subtract(Date.Now).TotalMinutes).ToString & " Minuten)"
        End If
        TextBoxAbfahrt.Text = TextBoxAbfahrt.Text & vbNewLine & vbNewLine
    End Sub

    Public Sub AbfahrtBerrechnen()
        TextBoxAbfahrt.Text = ""

        'Abhängige Abfrage
        Dim AktuelleHaltestelle, AktulleLinie As Byte

        AktuelleHaltestelle = FormEinstellungen.GetHaltestelle.Index
        'Debug
        If FormEinstellungen.GetDebug Then
            ZeigeDebugInfo("Feiertag", CStr(FormEinstellungen.GetFeiertag))
            ZeigeDebugInfo("UpdateStatus", CStr(FormEinstellungen.GetUpdateStatus))
            ZeigeDebugInfo("Aktulle Haltestelle", CStr(AktuelleHaltestelle))
            ZeigeDebugInfo("Anzahl Haltestellen - 1", CStr(Fahrplan.GetAnzahlLinien(AktuelleHaltestelle)))
        End If

        For i = 0 To Fahrplan.GetAnzahlLinien(AktuelleHaltestelle)
            AktulleLinie = Fahrplan.GetLinie(AktuelleHaltestelle, i)
            'Debug 
            If FormEinstellungen.GetDebug Then ZeigeDebugInfo("Aktuelle Linie", CStr(AktulleLinie))
            ZeigeAbfahrtsZeit(Fahrplan.GetLinienName(AktulleLinie), BerrechneAbfahrtsZeit(Fahrplan.GetFahrplan(AktulleLinie), Einlesen()))
        Next i
        ZeigeDebugInfo("Berrechnet um", Funktionen.UhrzeitFormat(CInt(Date.Now.Hour)) & ":" & Funktionen.UhrzeitFormat(CInt(Date.Now.Minute)) & ":" & Funktionen.UhrzeitFormat(CInt(Date.Now.Second)))
    End Sub

    Private Sub ButtonAbfahrt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAbfahrt.Click
        AbfahrtBerrechnen()
    End Sub

    Private Function Einlesen() As Integer
        If ComboWarteZeit.SelectedText = "" Then
            ComboWarteZeit.SelectedValue = 0
            Return 0
        Else : Return CInt(ComboWarteZeit.SelectedValue)
        End If
    End Function

    Private Sub FormMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormEinstellungen.SetVerbleibendeZeit(True)
        FormEinstellungen.SetDebug(False)
        FormEinstellungen.SetFeiertag(False)
        FormEinstellungen.SetUpdateStatus(False)

        ZeitAnzeigen()
        Funktionen.IniEinlesen()
        LabelHaltestelle.Text = "Haltestelle " & FormEinstellungen.GetHaltestelle.Name
        LabelVersion.Text = "Version: " & Assembly.GetExecutingAssembly.GetName.Version.ToString
        LabelFahrplanDatum.Text = "Fahrplandaten vom: " & Fahrplan.GetFahrplanDatum
        ComboWarteZeit.Items.Add(New SenseComboControl.Item("0 min", 0))
        ComboWarteZeit.Items.Add(New SenseComboControl.Item("3 min", 3))
        ComboWarteZeit.Items.Add(New SenseComboControl.Item("5 min", 5))
        ComboWarteZeit.Items.Add(New SenseComboControl.Item("10 min", 10))
        ComboWarteZeit.Items.Add(New SenseComboControl.Item("15 min", 15))
        ComboWarteZeit.Items.Add(New SenseComboControl.Item("20 min", 20))
        ComboWarteZeit.Items.Add(New SenseComboControl.Item("30 min", 30))
        ComboWarteZeit.Items.Add(New SenseComboControl.Item("45 min", 45))
        ComboWarteZeit.Items.Add(New SenseComboControl.Item("1 h", 60))
        ComboWarteZeit.Items.Add(New SenseComboControl.Item("1,5 h", 90))
        ComboWarteZeit.Items.Add(New SenseComboControl.Item("2 h", 120))
        ComboWarteZeit.Items.Add(New SenseComboControl.Item("3 h", 180))
        AbfahrtBerrechnen()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ZeitAnzeigen()
    End Sub

    Private Sub Einstellungen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Einstellungen.Click
        FormEinstellungen.Show()
    End Sub

    Private Sub FormMain_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        LabelHaltestelle.Text = "Haltestelle " & FormEinstellungen.GetHaltestelle.Name
    End Sub

    Public Sub AusgabeLeeren()
        TextBoxAbfahrt.Text = ""
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If FormEinstellungen.GetUpdateStatus Then AbfahrtBerrechnen()
    End Sub
End Class
