<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.NewPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ConfirmPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CurrentPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ShowPasswordButton = New System.Windows.Forms.PictureBox()
        Me.ValidatedMark = New System.Windows.Forms.PictureBox()
        CType(Me.ShowPasswordButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ValidatedMark, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UpdateButton
        '
        Me.UpdateButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UpdateButton.Location = New System.Drawing.Point(57, 219)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(81, 29)
        Me.UpdateButton.TabIndex = 4
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CancelButton.Location = New System.Drawing.Point(194, 219)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(81, 29)
        Me.CancelButton.TabIndex = 5
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(94, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username"
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Enabled = False
        Me.UsernameTextBox.Location = New System.Drawing.Point(97, 50)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(155, 20)
        Me.UsernameTextBox.TabIndex = 0
        '
        'NewPasswordTextBox
        '
        Me.NewPasswordTextBox.Location = New System.Drawing.Point(97, 139)
        Me.NewPasswordTextBox.Name = "NewPasswordTextBox"
        Me.NewPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.NewPasswordTextBox.Size = New System.Drawing.Size(155, 20)
        Me.NewPasswordTextBox.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(94, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "New Password"
        '
        'ConfirmPasswordTextBox
        '
        Me.ConfirmPasswordTextBox.Location = New System.Drawing.Point(97, 184)
        Me.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox"
        Me.ConfirmPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.ConfirmPasswordTextBox.Size = New System.Drawing.Size(155, 20)
        Me.ConfirmPasswordTextBox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(94, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Confirm Password"
        '
        'CurrentPasswordTextBox
        '
        Me.CurrentPasswordTextBox.Enabled = False
        Me.CurrentPasswordTextBox.Location = New System.Drawing.Point(97, 91)
        Me.CurrentPasswordTextBox.Name = "CurrentPasswordTextBox"
        Me.CurrentPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.CurrentPasswordTextBox.ReadOnly = True
        Me.CurrentPasswordTextBox.Size = New System.Drawing.Size(155, 20)
        Me.CurrentPasswordTextBox.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(94, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Current Password"
        '
        'ShowPasswordButton
        '
        Me.ShowPasswordButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ShowPasswordButton.Image = Global.iGather.My.Resources.Resources.show_password24px
        Me.ShowPasswordButton.Location = New System.Drawing.Point(258, 87)
        Me.ShowPasswordButton.Name = "ShowPasswordButton"
        Me.ShowPasswordButton.Size = New System.Drawing.Size(24, 24)
        Me.ShowPasswordButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ShowPasswordButton.TabIndex = 12
        Me.ShowPasswordButton.TabStop = False
        '
        'ValidatedMark
        '
        Me.ValidatedMark.Image = Global.iGather.My.Resources.Resources.checklist_24px
        Me.ValidatedMark.Location = New System.Drawing.Point(258, 184)
        Me.ValidatedMark.Name = "ValidatedMark"
        Me.ValidatedMark.Size = New System.Drawing.Size(28, 20)
        Me.ValidatedMark.TabIndex = 9
        Me.ValidatedMark.TabStop = False
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 279)
        Me.Controls.Add(Me.ShowPasswordButton)
        Me.Controls.Add(Me.CurrentPasswordTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ValidatedMark)
        Me.Controls.Add(Me.ConfirmPasswordTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NewPasswordTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Settings"
        Me.Text = "Settings"
        CType(Me.ShowPasswordButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ValidatedMark, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UpdateButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents NewPasswordTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ConfirmPasswordTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ValidatedMark As PictureBox
    Friend WithEvents CurrentPasswordTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ShowPasswordButton As PictureBox
End Class
