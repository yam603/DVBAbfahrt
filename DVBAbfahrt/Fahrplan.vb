﻿Module Fahrplan

#Region "Fahrpläne"
    Private Linie10_Friedrichstadt As Byte(,,) = {{{0, 255, 0, 0, 0, 0, 0, 0}, _
                                 {1, 255, 0, 0, 0, 0, 0, 0}, _
                                 {2, 255, 0, 0, 0, 0, 0, 0}, _
                                 {3, 255, 0, 0, 0, 0, 0, 0}, _
                                 {4, 255, 0, 0, 0, 0, 0, 0}, _
                                 {5, 15, 32, 47, 255, 0, 0, 0}, _
                                 {6, 6, 26, 36, 46, 56, 255, 0}, _
                                 {7, 6, 16, 26, 36, 46, 56, 255}, _
                                 {8, 6, 16, 26, 36, 46, 56, 255}, _
                                 {9, 6, 16, 26, 36, 46, 56, 255}, _
                                 {10, 6, 16, 26, 36, 46, 56, 255}, _
                                 {11, 6, 16, 26, 36, 46, 56, 255}, _
                                 {12, 6, 16, 26, 36, 46, 56, 255}, _
                                 {13, 6, 16, 26, 36, 46, 56, 255}, _
                                 {14, 6, 16, 26, 36, 46, 56, 255}, _
                                 {15, 6, 16, 26, 36, 46, 56, 255}, _
                                 {16, 6, 16, 26, 36, 46, 56, 255}, _
                                 {17, 6, 16, 26, 36, 46, 56, 255}, _
                                 {18, 6, 16, 26, 36, 46, 56, 255}, _
                                 {19, 6, 16, 26, 36, 46, 255, 0}, _
                                 {20, 0, 15, 30, 45, 255, 0, 0}, _
                                 {21, 0, 15, 45, 255, 0, 0, 0}, _
                                 {22, 15, 45, 255, 0, 0, 0, 0}, _
                                 {23, 15, 45, 255, 0, 0, 0, 0}}, _
                                {{0, 255, 0, 0, 0, 0, 0, 0}, _
                                 {1, 255, 0, 0, 0, 0, 0, 0}, _
                                 {2, 255, 0, 0, 0, 0, 0, 0}, _
                                 {3, 255, 0, 0, 0, 0, 0, 0}, _
                                 {4, 255, 0, 0, 0, 0, 0, 0}, _
                                 {5, 15, 45, 255, 0, 0, 0, 0}, _
                                 {6, 15, 45, 255, 0, 0, 0, 0}, _
                                 {7, 15, 45, 255, 0, 0, 0, 0}, _
                                 {8, 15, 47, 255, 0, 0, 0, 0}, _
                                 {9, 2, 17, 30, 45, 255, 0, 0}, _
                                 {10, 0, 15, 30, 45, 255, 0, 0}, _
                                 {11, 0, 15, 30, 45, 255, 0, 0}, _
                                 {12, 0, 15, 30, 45, 255, 0, 0}, _
                                 {13, 0, 15, 30, 45, 255, 0, 0}, _
                                 {14, 0, 15, 30, 45, 255, 0, 0}, _
                                 {15, 0, 15, 30, 45, 255, 0, 0}, _
                                 {16, 0, 15, 30, 45, 255, 0, 0}, _
                                 {17, 0, 15, 30, 45, 255, 0, 0}, _
                                 {18, 0, 15, 30, 45, 255, 0, 0}, _
                                 {19, 0, 15, 30, 45, 255, 0, 0}, _
                                 {20, 0, 15, 30, 45, 255, 0, 0}, _
                                 {21, 0, 15, 45, 255, 0, 0, 0}, _
                                 {22, 15, 45, 255, 0, 0, 0, 0}, _
                                 {23, 15, 45, 255, 0, 0, 0, 0}}, _
                                {{0, 255, 0, 0, 0, 0, 0, 0}, _
                                 {1, 255, 0, 0, 0, 0, 0, 0}, _
                                 {2, 255, 0, 0, 0, 0, 0, 0}, _
                                 {3, 255, 0, 0, 0, 0, 0, 0}, _
                                 {4, 255, 0, 0, 0, 0, 0, 0}, _
                                 {5, 15, 45, 255, 0, 0, 0, 0}, _
                                 {6, 15, 45, 255, 0, 0, 0, 0}, _
                                 {7, 15, 45, 255, 0, 0, 0, 0}, _
                                 {8, 15, 45, 255, 0, 0, 0, 0}, _
                                 {9, 15, 47, 255, 0, 0, 0, 0}, _
                                 {10, 17, 45, 255, 0, 0, 0, 0}, _
                                 {11, 15, 45, 255, 0, 0, 0, 0}, _
                                 {12, 15, 45, 255, 0, 0, 0, 0}, _
                                 {13, 0, 15, 30, 45, 255, 0, 0}, _
                                 {14, 0, 15, 30, 45, 255, 0, 0}, _
                                 {15, 0, 15, 30, 45, 255, 0, 0}, _
                                 {16, 0, 15, 30, 45, 255, 0, 0}, _
                                 {17, 0, 15, 30, 45, 255, 0, 0}, _
                                 {18, 0, 15, 30, 45, 255, 0, 0}, _
                                 {19, 0, 15, 30, 45, 255, 0, 0}, _
                                 {20, 0, 15, 30, 45, 255, 0, 0}, _
                                 {21, 0, 15, 45, 255, 0, 0, 0}, _
                                 {22, 15, 45, 255, 0, 0, 0, 0}, _
                                 {23, 15, 45, 255, 0, 0, 0, 0}} _
                                 }

    Private Linie4_Weinboehla As Byte(,,) = {{{0, 28, 58, 255, 0, 0, 0, 0}, _
                             {1, 28, 255, 0, 0, 0, 0, 0}, _
                             {2, 8, 255, 0, 0, 0, 0, 0}, _
                             {3, 18, 58, 255, 0, 0, 0, 0}, _
                             {4, 28, 58, 255, 0, 0, 0, 0}, _
                             {5, 18, 37, 53, 255, 0, 0, 0}, _
                             {6, 12, 22, 32, 42, 52, 255, 0}, _
                             {7, 2, 12, 22, 32, 42, 52, 255}, _
                             {8, 2, 12, 22, 32, 42, 52, 255}, _
                             {9, 2, 12, 22, 32, 42, 52, 255}, _
                             {10, 2, 12, 22, 32, 42, 52, 255}, _
                             {11, 2, 12, 22, 32, 42, 52, 255}, _
                             {12, 2, 12, 22, 32, 42, 52, 255}, _
                             {13, 2, 12, 22, 32, 42, 52, 255}, _
                             {14, 2, 12, 22, 32, 42, 52, 255}, _
                             {15, 2, 12, 22, 32, 42, 52, 255}, _
                             {16, 2, 12, 22, 32, 42, 52, 255}, _
                             {17, 2, 12, 22, 32, 42, 52, 255}, _
                             {18, 2, 12, 22, 32, 42, 52, 255}, _
                             {19, 2, 13, 23, 38, 53, 255, 0}, _
                             {20, 9, 24, 39, 54, 255, 0, 0}, _
                             {21, 9, 24, 39, 54, 255, 0, 0}, _
                             {22, 9, 28, 58, 255, 0, 0, 0}, _
                             {23, 28, 58, 255, 0, 0, 0, 0}}, _
                            {{0, 28, 58, 255, 0, 0, 0, 0}, _
                             {1, 28, 255, 0, 0, 0, 0, 0}, _
                             {2, 8, 255, 0, 0, 0, 0, 0}, _
                             {3, 18, 58, 255, 0, 0, 0, 0}, _
                             {4, 28, 58, 255, 0, 0, 0, 0}, _
                             {5, 28, 58, 255, 0, 0, 0, 0}, _
                             {6, 28, 58, 255, 0, 0, 0, 0}, _
                             {7, 28, 58, 255, 0, 0, 0, 0}, _
                             {8, 28, 54, 255, 0, 0, 0, 0}, _
                             {9, 9, 23, 33, 43, 53, 255, 0}, _
                             {10, 3, 13, 23, 33, 43, 53, 255}, _
                             {11, 3, 13, 23, 33, 43, 53, 255}, _
                             {12, 3, 13, 23, 33, 43, 53, 255}, _
                             {13, 3, 13, 23, 33, 43, 53, 255}, _
                             {14, 3, 13, 23, 33, 43, 53, 255}, _
                             {15, 3, 13, 23, 33, 43, 53, 255}, _
                             {16, 3, 13, 23, 33, 43, 53, 255}, _
                             {17, 3, 13, 23, 33, 43, 53, 255}, _
                             {18, 8, 24, 39, 54, 255, 0, 0}, _
                             {19, 9, 24, 39, 54, 255, 0, 0}, _
                             {20, 9, 24, 39, 54, 255, 0, 0}, _
                             {21, 9, 24, 39, 54, 255, 0, 0}, _
                             {22, 9, 28, 58, 255, 0, 0, 0}, _
                             {23, 28, 58, 255, 0, 0, 0, 0}}, _
                           {{0, 28, 58, 255, 0, 0, 0, 0}, _
                             {1, 28, 255, 0, 0, 0, 0, 0}, _
                             {2, 8, 255, 0, 0, 0, 0, 0}, _
                             {3, 18, 58, 255, 0, 0, 0, 0}, _
                             {4, 28, 58, 255, 0, 0, 0, 0}, _
                             {5, 28, 58, 255, 0, 0, 0, 0}, _
                             {6, 28, 58, 255, 0, 0, 0, 0}, _
                             {7, 28, 58, 255, 0, 0, 0, 0}, _
                             {8, 28, 58, 255, 0, 0, 0, 0}, _
                             {9, 28, 40, 53, 255, 0, 0, 0}, _
                             {10, 9, 24, 39, 54, 255, 0, 0}, _
                             {11, 9, 24, 39, 54, 255, 0, 0}, _
                             {12, 9, 24, 39, 54, 255, 0, 0}, _
                             {13, 9, 24, 39, 54, 255, 0, 0}, _
                             {14, 9, 24, 39, 54, 255, 0, 0}, _
                             {15, 9, 24, 39, 54, 255, 0, 0}, _
                             {16, 9, 24, 39, 54, 255, 0, 0}, _
                             {17, 9, 24, 39, 54, 255, 0, 0}, _
                             {18, 9, 24, 39, 54, 255, 0, 0}, _
                             {19, 9, 24, 39, 54, 255, 0, 0}, _
                             {20, 9, 23, 35, 50, 255, 0, 0}, _
                             {21, 5, 20, 35, 50, 255, 0, 0}, _
                             {22, 5, 28, 58, 255, 0, 0, 0}, _
                             {23, 28, 58, 255, 0, 0, 0, 0}} _
                             }

    Private Linie63_Loebtau As Byte(,,) = {{{0, 29, 44, 255, 0, 0, 0, 0, 0}, _
                             {1, 14, 38, 255, 0, 0, 0, 0, 0}, _
                             {2, 255, 0, 0, 0, 0, 0, 0, 0}, _
                             {3, 255, 0, 0, 0, 0, 0, 0, 0}, _
                             {4, 255, 0, 0, 0, 0, 0, 0, 0}, _
                             {5, 16, 40, 255, 0, 0, 0, 0, 0}, _
                             {6, 0, 14, 29, 39, 49, 59, 255, 0}, _
                             {7, 9, 19, 29, 39, 49, 59, 255, 0}, _
                             {8, 9, 19, 29, 39, 49, 59, 255, 0}, _
                             {9, 9, 21, 32, 42, 52, 255, 0, 0}, _
                             {10, 2, 12, 22, 32, 42, 52, 255, 0}, _
                             {11, 2, 12, 22, 32, 42, 52, 255, 0}, _
                             {12, 2, 12, 22, 32, 42, 52, 255, 0}, _
                             {13, 2, 12, 22, 32, 42, 52, 255, 0}, _
                             {14, 2, 12, 22, 32, 42, 52, 255, 0}, _
                             {15, 2, 12, 22, 32, 42, 52, 255, 0}, _
                             {16, 2, 12, 22, 32, 42, 52, 255, 0}, _
                             {17, 2, 12, 22, 32, 42, 52, 255, 0}, _
                             {18, 2, 12, 22, 32, 42, 51, 56, 255}, _
                             {19, 6, 11, 21, 26, 41, 56, 255, 0}, _
                             {20, 2, 11, 26, 41, 56, 255, 0, 0}, _
                             {21, 11, 26, 38, 50, 255, 0, 0, 0}, _
                             {22, 0, 4, 29, 59, 255, 0, 0, 0}, _
                             {23, 29, 59, 255, 0, 0, 0, 0, 0}}, _
                            {{0, 29, 44, 255, 0, 0, 0, 0, 0}, _
                             {1, 14, 38, 255, 0, 0, 0, 0, 0}, _
                             {2, 255, 0, 0, 0, 0, 0, 0, 0}, _
                             {3, 255, 0, 0, 0, 0, 0, 0, 0}, _
                             {4, 255, 0, 0, 0, 0, 0, 0, 0}, _
                             {5, 29, 59, 255, 0, 0, 0, 0, 0}, _
                             {6, 29, 59, 255, 0, 0, 0, 0, 0}, _
                             {7, 29, 59, 255, 0, 0, 0, 0, 0}, _
                             {8, 29, 52, 255, 0, 0, 0, 0, 0}, _
                             {9, 11, 26, 41, 59, 255, 0, 0, 0}, _
                             {10, 11, 26, 41, 59, 255, 0, 0, 0}, _
                             {11, 11, 26, 41, 59, 255, 0, 0, 0}, _
                             {12, 11, 26, 41, 59, 255, 0, 0, 0}, _
                             {13, 11, 26, 41, 59, 255, 0, 0, 0}, _
                             {14, 11, 26, 41, 59, 255, 0, 0, 0}, _
                             {15, 11, 26, 41, 59, 255, 0, 0, 0}, _
                             {16, 11, 26, 41, 59, 255, 0, 0, 0}, _
                             {17, 11, 26, 41, 59, 255, 0, 0, 0}, _
                             {18, 11, 26, 41, 59, 255, 0, 0, 0}, _
                             {19, 11, 26, 41, 59, 255, 0, 0, 0}, _
                             {20, 11, 26, 41, 59, 255, 0, 0, 0}, _
                             {21, 11, 26, 38, 50, 255, 0, 0, 0}, _
                             {22, 0, 4, 29, 59, 255, 0, 0, 0}, _
                             {23, 29, 59, 255, 0, 0, 0, 0, 0}}, _
                           {{0, 29, 44, 255, 0, 0, 0, 0, 0}, _
                             {1, 14, 38, 255, 0, 0, 0, 0, 0}, _
                             {2, 255, 0, 0, 0, 0, 0, 0, 0}, _
                             {3, 255, 0, 0, 0, 0, 0, 0, 0}, _
                             {4, 255, 0, 0, 0, 0, 0, 0, 0}, _
                             {5, 29, 59, 255, 0, 0, 0, 0, 0}, _
                             {6, 29, 59, 255, 0, 0, 0, 0, 0}, _
                             {7, 29, 59, 255, 0, 0, 0, 0, 0}, _
                             {8, 29, 52, 255, 0, 0, 0, 0, 0}, _
                             {9, 11, 26, 41, 59, 255, 0, 0, 0}, _
                             {10, 11, 26, 41, 59, 255, 0, 0, 0}, _
                             {11, 11, 26, 41, 59, 255, 0, 0, 0}, _
                             {12, 11, 26, 41, 59, 255, 0, 0, 0}, _
                             {13, 11, 26, 41, 59, 255, 0, 0, 0}, _
                             {14, 11, 26, 41, 59, 255, 0, 0, 0}, _
                             {15, 11, 26, 41, 59, 255, 0, 0, 0}, _
                             {16, 11, 26, 41, 59, 255, 0, 0, 0}, _
                             {17, 11, 26, 41, 59, 255, 0, 0, 0}, _
                             {18, 11, 26, 41, 59, 255, 0, 0, 0}, _
                             {19, 11, 26, 41, 59, 255, 0, 0, 0}, _
                             {20, 11, 26, 41, 59, 255, 0, 0, 0}, _
                             {21, 11, 26, 38, 50, 255, 0, 0, 0}, _
                             {22, 0, 4, 29, 59, 255, 0, 0, 0}, _
                             {23, 29, 59, 255, 0, 0, 0, 0, 0}} _
                             }

    Private Linie74_Reick As Byte(,,) = {{{0, 12, 42, 255, 0}, _
                                 {1, 255, 0, 0, 0}, _
                                 {2, 255, 0, 0, 0}, _
                                 {3, 255, 0, 0, 0}, _
                                 {4, 255, 0, 0, 0}, _
                                 {5, 21, 46, 255, 0}, _
                                 {6, 11, 31, 51, 255}, _
                                 {7, 11, 31, 51, 255}, _
                                 {8, 11, 31, 51, 255}, _
                                 {9, 11, 31, 51, 255}, _
                                 {10, 11, 31, 51, 255}, _
                                 {11, 11, 31, 51, 255}, _
                                 {12, 11, 31, 51, 255}, _
                                 {13, 11, 31, 51, 255}, _
                                 {14, 11, 31, 51, 255}, _
                                 {15, 9, 29, 49, 255}, _
                                 {16, 9, 29, 49, 255}, _
                                 {17, 9, 29, 49, 255}, _
                                 {18, 9, 29, 51, 255}, _
                                 {19, 13, 43, 255, 0}, _
                                 {20, 13, 43, 255, 0}, _
                                 {21, 13, 42, 255, 0}, _
                                 {22, 12, 42, 255, 0}, _
                                 {23, 12, 42, 255, 0}}, _
                                {{0, 12, 42, 255, 0}, _
                                 {1, 255, 0, 0, 0}, _
                                 {2, 255, 0, 0, 0}, _
                                 {3, 255, 0, 0, 0}, _
                                 {4, 255, 0, 0, 0}, _
                                 {5, 42, 255, 0, 0}, _
                                 {6, 12, 42, 255, 0}, _
                                 {7, 12, 42, 255, 0}, _
                                 {8, 12, 43, 255, 0}, _
                                 {9, 13, 43, 255, 0}, _
                                 {10, 13, 43, 255, 0}, _
                                 {11, 13, 43, 255, 0}, _
                                 {12, 13, 43, 255, 0}, _
                                 {13, 13, 43, 255, 0}, _
                                 {14, 13, 43, 255, 0}, _
                                 {15, 13, 43, 255, 0}, _
                                 {16, 13, 43, 255, 0}, _
                                 {17, 13, 43, 255, 0}, _
                                 {18, 13, 43, 255, 0}, _
                                 {19, 13, 43, 255, 0}, _
                                 {20, 13, 43, 255, 0}, _
                                 {21, 13, 42, 255, 0}, _
                                 {22, 12, 42, 255, 0}, _
                                 {23, 12, 42, 255, 0}}, _
                                {{0, 12, 42, 255, 0}, _
                                 {1, 255, 0, 0, 0}, _
                                 {2, 255, 0, 0, 0}, _
                                 {3, 255, 0, 0, 0}, _
                                 {4, 255, 0, 0, 0}, _
                                 {5, 42, 255, 0, 0}, _
                                 {6, 12, 42, 255, 0}, _
                                 {7, 12, 42, 255, 0}, _
                                 {8, 12, 43, 255, 0}, _
                                 {9, 13, 43, 255, 0}, _
                                 {10, 13, 43, 255, 0}, _
                                 {11, 13, 43, 255, 0}, _
                                 {12, 13, 43, 255, 0}, _
                                 {13, 13, 43, 255, 0}, _
                                 {14, 13, 43, 255, 0}, _
                                 {15, 13, 43, 255, 0}, _
                                 {16, 13, 43, 255, 0}, _
                                 {17, 13, 43, 255, 0}, _
                                 {18, 13, 43, 255, 0}, _
                                 {19, 13, 43, 255, 0}, _
                                 {20, 13, 43, 255, 0}, _
                                 {21, 13, 42, 255, 0}, _
                                 {22, 12, 42, 255, 0}, _
                                 {23, 12, 42, 255, 0}} _
                                 }
#End Region

#Region "Linien/Haltestellen - Codierung"
    'LinienIndex, AnzahlHaltestellen, Haltestelle1 ... 6
    Private Linienzuordnung As Byte(,) = {{0, 4, 0, 1, 2, 3, 0, 0}, _
                                  {1, 3, 4, 5, 6, 0, 0, 0}, _
                                  {2, 2, 7, 8, 0, 0, 0, 0} _
                                  }

    Private LinienCodierung As Byte(,) = {{0, 4}, _
                                          {1, 10}, _
                                          {2, 63}, _
                                          {3, 74}, _
                                          {4, 61}, _
                                          {5, 66}, _
                                          {6, 85}, _
                                          {7, 1}, _
                                          {8, 2} _
                                          }

    Dim LinienNamen As String() = {"Linie 4 - Weinböhla", _
                                   "Linie 10 - Friedrichstadt", _
                                   "Linie 63 - Löbtau", _
                                   "Linie 74 - Reick", _
                                   "Linie 61 -", _
                                   "Linie 66 -", _
                                   "Linie 85 -", _
                                   "Linie 1 -", _
                                   "Linie 2 -" _
                                   }
#End Region

    Const FahrplanDatum As String = "12.03.2011"

    Const AnzahlHaltestellen As Byte = 3

    Public Function GetLinienName(ByVal Linie As Byte) As String
        Return LinienNamen(Linie)
    End Function

    Public Function GetFahrplanDatum() As String
        Return FahrplanDatum
    End Function

    Public Function GetFahrplan(ByVal Linie As Byte) As Byte(,,)
        Select Case Linie
            Case 0
                Return Linie4_Weinboehla
            Case 1
                Return Linie10_Friedrichstadt
            Case 2
                Return Linie63_Loebtau
            Case 3
                Return Linie74_Reick
            Case 4
            Case 5
            Case 6
            Case 7
            Case 8
        End Select
    End Function

    Public Function GetAnzahlLinien(ByVal Haltestelle As Byte) As Byte
        If Haltestelle <= AnzahlHaltestellen - 1 Then
            Return Linienzuordnung(Haltestelle, 1) - 1
        End If
    End Function

    Public Function GetLinie(ByVal Haltestelle As Byte, ByVal Index As Byte) As Byte
        If Haltestelle <= AnzahlHaltestellen - 1 Then
            Return Linienzuordnung(Haltestelle, Index + 2)
        End If
    End Function
End Module
