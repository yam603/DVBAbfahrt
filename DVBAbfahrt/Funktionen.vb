Module Funktionen
    Public Function UhrzeitFormat(ByVal Time As Integer) As String
        If Time < 10 Then Return ("0" + CStr(Time)) Else Return CStr(Time)
    End Function

    Public Function TagCodierungTag(ByVal Tag As System.DayOfWeek) As Byte
        Select Case Tag
            Case DayOfWeek.Monday
                Return 0
            Case DayOfWeek.Tuesday
                Return 1
            Case DayOfWeek.Thursday
                Return 2
            Case DayOfWeek.Thursday
                Return 3
            Case DayOfWeek.Friday
                Return 4
            Case DayOfWeek.Saturday
                Return 5
            Case DayOfWeek.Sunday
                Return 6
        End Select
    End Function

    Public Function TagDecodierungTagDeutsch(ByVal Tag As Byte) As String
        Select Case Tag
            Case 0
                Return "Montag"
            Case 1
                Return "Dienstag"
            Case 2
                Return "Mittwoch"
            Case 3
                Return "Donnerstag"
            Case 4
                Return "Freitag"
            Case 5
                Return "Samstag"
            Case 6
                Return "Sonntag"
        End Select
    End Function

    Public Function TagDecodierungTag(ByVal Tag As Byte) As String
        Select Case Tag
            Case 0
                Return DayOfWeek.Monday.ToString
            Case 1
                Return DayOfWeek.Tuesday.ToString
            Case 2
                Return DayOfWeek.Thursday.ToString
            Case 3
                Return DayOfWeek.Thursday.ToString
            Case 4
                Return DayOfWeek.Friday.ToString
            Case 5
                Return DayOfWeek.Saturday.ToString
            Case 6
                Return DayOfWeek.Sunday.ToString
        End Select
    End Function

    Private Function TagCodierungIndex(ByVal Tag As Byte) As Byte
        Select Case Tag
            Case 0
                Return 0
            Case 1
                Return 0
            Case 2
                Return 0
            Case 3
                Return 0
            Case 4
                Return 0
            Case 5
                Return 1
            Case 6
                Return 2
        End Select
    End Function

    Public Function BerrechneAbfahrtsZeit(ByVal Fahrplan As Byte(,,), ByVal ZeitZurHaltestelle As Integer) As String
        Dim Ueberlauf As Boolean
        Dim LinienWahl, TagAbfahrt, StundeAbfahrt, MinuteAbfahrt, TagAbfahrtIndex, StundeAbfahrtIndex, MinuteAbfahrtIndex, TagAbfahrtWunsch, StundeAbfahrtWunsch, MinuteAbfahrtWunsch As Byte
        Dim UeberlaufZeit, UeberlaufAnzahl As Integer

        'Initialsierung
        TagAbfahrtWunsch = TagCodierungTag(Date.Now.DayOfWeek)
        StundeAbfahrtWunsch = Date.Now.Hour
        MinuteAbfahrtWunsch = Date.Now.Minute + ZeitZurHaltestelle
        TagAbfahrtIndex = TagCodierungIndex(TagCodierungTag(Date.Now.DayOfWeek))
        StundeAbfahrtIndex = 0
        MinuteAbfahrtIndex = 1
        TagAbfahrt = TagAbfahrtWunsch
        Ueberlauf = False
        UeberlaufZeit = 0
        UeberlaufAnzahl = 0

        'Berrechnung
        While Fahrplan(TagAbfahrtIndex, StundeAbfahrtIndex, 0) < StundeAbfahrtWunsch
            StundeAbfahrtIndex = StundeAbfahrtIndex + 1
        End While

        While Fahrplan(TagAbfahrtIndex, StundeAbfahrtIndex, MinuteAbfahrtIndex) <= MinuteAbfahrtWunsch
            MinuteAbfahrtIndex = MinuteAbfahrtIndex + 1
        End While

        'Überlaufberrechnung
        While Fahrplan(TagAbfahrtIndex, StundeAbfahrtIndex, MinuteAbfahrtIndex) = 255
            UeberlaufAnzahl = UeberlaufAnzahl + 1
            If StundeAbfahrtIndex = 23 Then
                StundeAbfahrtIndex = 0
                If TagAbfahrt = 6 Then
                    TagAbfahrt = 0
                Else : TagAbfahrt = TagAbfahrt + 1
                End If
                TagAbfahrtIndex = TagCodierungIndex(TagAbfahrt)
            Else : StundeAbfahrtIndex = StundeAbfahrtIndex + 1
            End If

            MinuteAbfahrtIndex = 1
            UeberlaufZeit = ZeitZurHaltestelle - (UeberlaufAnzahl * 60 - CInt(TimeOfDay.Minute))
            If UeberlaufZeit > 0 Then
                While Fahrplan(TagAbfahrtIndex, StundeAbfahrtIndex, MinuteAbfahrtIndex) <= UeberlaufZeit
                    MinuteAbfahrtIndex = MinuteAbfahrtIndex + 1
                End While
            End If
        End While

        StundeAbfahrt = CStr(Fahrplan(TagAbfahrtIndex, StundeAbfahrtIndex, 0))
        MinuteAbfahrt = CStr(Fahrplan(TagAbfahrtIndex, StundeAbfahrtIndex, MinuteAbfahrtIndex))

        Return (TagDecodierungTagDeutsch(TagAbfahrt) & ", " & UhrzeitFormat(StundeAbfahrt) & ":" & UhrzeitFormat(MinuteAbfahrt))
    End Function
End Module
