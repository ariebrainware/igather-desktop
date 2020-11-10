Imports System.Data.Odbc

Public Class LoginForm
    Dim check As String
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        dbconnection()
        check = "SELECT * FROM admin WHERE username='" & UsernameTextBox.Text & "' AND password='" & PasswordTextBox.Text & "'"
        query = New OdbcCommand(check, conn)
        reader = query.ExecuteReader()
        While reader.Read()
            If reader.HasRows Then
                'Save login session and get last inserted id
                command = "INSERT INTO admin_session (username,time_login,is_active)VALUES('" & UsernameTextBox.Text & "',
'" & Now & "','Y')"
                query = New OdbcCommand(command, conn)
                query.ExecuteNonQuery()
                command = "SELECT LAST_INSERT_ID()"
                query = New OdbcCommand(command, conn)
                loggedInAdminSessionID = query.ExecuteScalar()

                conn.Close()
                username = UsernameTextBox.Text
                If MessageBox.Show("Success Login", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.OK Then
                    information.Show()
                    Me.Hide()
                End If
                Return
            End If
        End While
        MessageBox.Show("Failed Login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
