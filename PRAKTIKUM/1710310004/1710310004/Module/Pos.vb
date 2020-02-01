Imports alfathNET
Module Pos
    Public DB As New Database
    Public FS As New Fungsi
    Public LP As New Laporan
    Public INF As New Informasi
    Public Uang As New TerbilangMataUangNusantara
    '======================'
    Public kondisi As Boolean

    Dim IP, UID, PWD, DBase, Port As String
    Sub BukaKoneksi()
        With FormSetting
            IP = .tIP.Text
            UID = .tUser.Text
            PWD = .tPass.Text
            DBase = .tDB.Text
            Port = .cPort.Text
            DB.Koneksi(IP, UID, PWD, DBase, Port, FormUTAMA.stsDB)
        End With
    End Sub
End Module
