Imports System.Data.Odbc


Module ConnectDbModule
    Public conn As OdbcConnection
    Public dataAdpt As OdbcDataAdapter
    Public Dset As DataSet
    Public Rd As OdbcDataReader
    Public Cmd As OdbcCommand

    Public MyDb As String

    Public Sub Koneksi()

        MyDb = "Dsn=connect_dbpenjualan"
        conn = New OdbcConnection(MyDb)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If


    End Sub



End Module
