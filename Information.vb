Imports System.Data.Odbc
Public Class information
    Dim selectedInformationID As Integer
    Dim command As String
    Private Sub information_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        markSessionInactive()
        LoginForm.Close()
    End Sub
    Sub showData()
        dbconnection()
        da = New OdbcDataAdapter("SELECT * FROM information", conn)
        ds = New DataSet
        da.Fill(ds, "information")
        InfoDataGridView.DataSource = ds.Tables("information")
        conn.Close()
    End Sub
    Sub clearField()
        selectedInformationID = 0
        FirstNameTextBox.Text = ""
        NicknameTextBox.Text = ""
        LastNameTextBox.Text = ""
        EmailTextBox.Text = ""
        UsernameTextBox.Text = ""
        CurrentPasswordTextBox.Text = ""
        BirthdayDateTimePicker.Value = Today
        NoteTextBox.Text = ""
        SearchTextBox.Text = ""
    End Sub
    Sub markSessionInactive()
        dbconnection()
        'Mark session as in_active
        command = "UPDATE admin_session SET is_active='N',time_logout='" & Now & "' 
WHERE id='" & loggedInAdminSessionID & "'"

        query = New OdbcCommand(command, conn)
        query.ExecuteNonQuery()
        conn.Close()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        markSessionInactive()
        Me.Close()
    End Sub

    Private Sub information_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showData()
    End Sub
    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        dbconnection()
        command = "UPDATE information SET first_name='" & FirstNameTextBox.Text & "', 
nickname='" & NicknameTextBox.Text & "',last_name='" & LastNameTextBox.Text & "',email='" & EmailTextBox.Text & "',username='" & UsernameTextBox.Text & "',current_password='" & CurrentPasswordTextBox.Text & "',birthday='" & BirthdayDateTimePicker.Value & "',note='" & NoteTextBox.Text & "' WHERE id='" & selectedInformationID & "'"
        query = New OdbcCommand(command, conn)
        query.ExecuteNonQuery()
        If MessageBox.Show("Information updated", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.OK Then
            clearField()
            showData()
        End If
        conn.Close()
    End Sub
    Function validateIfExist(setfield As Boolean) As Boolean
        dbconnection()
        command = "SELECT * FROM information WHERE first_name='" & FirstNameTextBox.Text & "' 
AND nickname='" & NicknameTextBox.Text & "' AND last_name ='" & LastNameTextBox.Text & "'"
        query = New OdbcCommand(command, conn)
        reader = query.ExecuteReader()
        If setfield = True Then
            If reader.HasRows Then
                EmailTextBox.Text = reader.Item("email")
                UsernameTextBox.Text = reader.Item("username")
                CurrentPasswordTextBox.Text = reader.Item("current_password")
                BirthdayDateTimePicker.Value = reader.Item("birthday")
                NoteTextBox.Text = reader.Item("note")
                Return True
            Else
                Return False
            End If
        End If
        conn.Close()
    End Function
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        dbconnection()
        command = "INSERT INTO information (first_name,nickname,last_name,username,email,current_password,birthday,note,created_at) VALUES('" & FirstNameTextBox.Text & "','" & NicknameTextBox.Text & "',
'" & LastNameTextBox.Text & "','" & UsernameTextBox.Text & "','" & EmailTextBox.Text & "',
'" & CurrentPasswordTextBox.Text & "', '" & BirthdayDateTimePicker.Value & "','" & NoteTextBox.Text & "','" & Now & "')"
        query = New OdbcCommand(command, conn)
        query.ExecuteNonQuery()

        If MessageBox.Show("Information Saved", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.OK Then
            clearField()
            showData()
        End If
    End Sub

    Private Sub LastNameTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles LastNameTextBox.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Dim exist = validateIfExist(True)
                If exist Then
                    MessageBox.Show("Information based on this name already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    SaveButton.Enabled = False
                End If
        End Select
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        dbconnection()
        command = "DELETE FROM information WHERE id='" & selectedInformationID & "'"
        query = New OdbcCommand(command, conn)
        query.ExecuteNonQuery()
        If MessageBox.Show("Information Deleted", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.OK Then
            clearField()
            showData()
        End If
        conn.Close()
    End Sub
    Private Sub InfoDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles InfoDataGridView.CellClick
        If InfoDataGridView.RowCount > 0 Then
            Dim row As Integer
            With InfoDataGridView
                row = .CurrentRow.Index
                selectedInformationID = .Item(0, row).Value
                FirstNameTextBox.Text = .Item(1, row).Value
                NicknameTextBox.Text = .Item(2, row).Value
                LastNameTextBox.Text = .Item(3, row).Value
                UsernameTextBox.Text = .Item(4, row).Value
                EmailTextBox.Text = .Item(5, row).Value
                CurrentPasswordTextBox.Text = .Item(6, row).Value
                BirthdayDateTimePicker.Value = .Item(7, row).Value
                NoteTextBox.Text = .Item(8, row).Value
            End With
        End If
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        dbconnection()
        command = "SELECT * FROM information WHERE first_name LIKE '%' '" & SearchTextBox.Text & "' '%' OR nickname LIKE '%' '" & SearchTextBox.Text & "' '%' OR last_name LIKE '%' '" & SearchTextBox.Text & "' '%' OR email LIKE '%' '" & SearchTextBox.Text & "' '%' OR username LIKE '%' '" & SearchTextBox.Text & "' '%'"
        da = New OdbcDataAdapter(command, conn)
        ds = New DataSet
        da.Fill(ds, "information")
        InfoDataGridView.DataSource = ds.Tables("information")
        If InfoDataGridView.RowCount > 0 Then
            Dim row As Integer
            With InfoDataGridView
                row = .CurrentRow.Index
                selectedInformationID = .Item(0, row).Value
                FirstNameTextBox.Text = .Item(1, row).Value
                NicknameTextBox.Text = .Item(2, row).Value
                LastNameTextBox.Text = .Item(3, row).Value
                UsernameTextBox.Text = .Item(4, row).Value
                EmailTextBox.Text = .Item(5, row).Value
                CurrentPasswordTextBox.Text = .Item(6, row).Value
                BirthdayDateTimePicker.Value = .Item(7, row).Value
                NoteTextBox.Text = .Item(8, row).Value
            End With
        End If
        conn.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.Show()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Settings.Show()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        clearField()

    End Sub

    'Private Sub LastNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles InfoDataGridView.CellClick,' FirstNameTextBox.TextChanged, LastNameTextBox.TextChanged, FirstNameTextBox.TextChanged
    '    Dim exist = validateIfExist(True)
    '    If exist Then
    '        SaveButton.Enabled = False
    '    Else
    '        SaveButton.Enabled = True
    '    End If
    '
    'End Sub

End Class
