Imports alfathNET
Module POS
    Public DB As New Database
    Public FS As New Fungsi
    Public LP As New Laporan
    Public INF As New Informasi
    Public Uang As New TerbilangMataUangNusantara
    '============================================'
    Public Kondisi As Boolean

    Dim IP, UID, PWD, DBase, Port As String

    Sub BukaKoneksi()
        With FormSetting
            IP = .txtIP.Text
            UID = .txtUser.Text
            PWD = .txtPass.Text
            DBase = .txtDB.Text
            Port = .cbPort.Text
            '=============================='
            DB.Koneksi(IP, UID, PWD, DBase, Port, FormUtama.stsDB)
        End With
    End Sub
End Module
