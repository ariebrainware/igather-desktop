﻿Imports System.Data.Odbc
Module connection
    Public conn As OdbcConnection
    Public da As OdbcDataAdapter
    Public query As OdbcCommand
    Public ds As DataSet
    Public Sub dbconnection()
        Dim teks As String = "Driver={MySQL ODBC 5.3 ANSI Driver};server=127.0.0.1;uid=root;password=L0c4lDB;database=igather;port=3306"
        conn = New OdbcConnection(teks)

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
End Module
