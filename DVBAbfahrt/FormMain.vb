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

Public Class FormMain

    Private Sub ZeitAnzeigen()
        LabelUhrzeit.Text = TagDecodierungTagDeutsch(TagCodierungTag(Date.Now.DayOfWeek)) & ", " & UhrzeitFormat(Date.Now.Hour) & ":" & UhrzeitFormat(Date.Now.Minute)
    End Sub

    Private Sub ZeigeAbfahrtsZeit(ByVal Linie As String, ByVal AbfahrtsZeit As String)
        TextBoxAbfahrt.Text = TextBoxAbfahrt.Text & Linie & vbNewLine & "- " & AbfahrtsZeit & vbNewLine & vbNewLine
    End Sub

    Private Sub ButtonAbfahrt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAbfahrt.Click
        TextBoxAbfahrt.Text = ""
        ZeigeAbfahrtsZeit("Linie 10 - Friedrichstadt: ", BerrechneAbfahrtsZeit(Fahrplan.GetLinie10_Friedrichstadt, Einlesen()))
        ZeigeAbfahrtsZeit("Linie 4 - Weinböhla: ", BerrechneAbfahrtsZeit(Fahrplan.GetLinie4_Weinboehla, Einlesen()))
        ZeigeAbfahrtsZeit("Linie 63 - Löbtau: ", BerrechneAbfahrtsZeit(Fahrplan.GetLinie63_Loebtau, Einlesen()))
        ZeigeAbfahrtsZeit("Linie 74 - Reick: ", BerrechneAbfahrtsZeit(Fahrplan.GetLinie74_Reick, Einlesen()))
    End Sub

    Private Function Einlesen() As Integer
        If ComboWarteZeit.SelectedText = "" Then
            ComboWarteZeit.SelectedValue = 0
            Return 0
        Else : Return CInt(ComboWarteZeit.SelectedValue)
        End If
    End Function

    Private Sub FormMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ZeitAnzeigen()
        LabelVersion.Text = "Version: " & Assembly.GetExecutingAssembly.GetName.Version.ToString
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
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ZeitAnzeigen()
    End Sub
End Class
