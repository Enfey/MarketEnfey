<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.passwrdBtn = New System.Windows.Forms.Button()
        Me.TxtBxUser = New System.Windows.Forms.TextBox()
        Me.TxtBxPsword = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.WelcomeLoginBtn = New System.Windows.Forms.Button()
        Me.WelcomeExitBtn = New System.Windows.Forms.Button()
        Me.DoubleEntryTxtBx = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox4,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'passwrdBtn
        '
        Me.passwrdBtn.BackColor = System.Drawing.Color.Transparent
        Me.passwrdBtn.BackgroundImage = CType(resources.GetObject("passwrdBtn.BackgroundImage"),System.Drawing.Image)
        Me.passwrdBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.passwrdBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.passwrdBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.passwrdBtn.FlatAppearance.BorderSize = 0
        Me.passwrdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.passwrdBtn.Font = New System.Drawing.Font("Sitka Heading", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.passwrdBtn.Location = New System.Drawing.Point(744, 509)
        Me.passwrdBtn.Name = "passwrdBtn"
        Me.passwrdBtn.Size = New System.Drawing.Size(208, 80)
        Me.passwrdBtn.TabIndex = 2
        Me.passwrdBtn.UseVisualStyleBackColor = false
        '
        'TxtBxUser
        '
        Me.TxtBxUser.BackColor = System.Drawing.Color.Lavender
        Me.TxtBxUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 24!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TxtBxUser.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtBxUser.Location = New System.Drawing.Point(481, 265)
        Me.TxtBxUser.Name = "TxtBxUser"
        Me.TxtBxUser.Size = New System.Drawing.Size(262, 44)
        Me.TxtBxUser.TabIndex = 3
        '
        'TxtBxPsword
        '
        Me.TxtBxPsword.BackColor = System.Drawing.Color.Lavender
        Me.TxtBxPsword.Font = New System.Drawing.Font("Microsoft Sans Serif", 24!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TxtBxPsword.Location = New System.Drawing.Point(481, 351)
        Me.TxtBxPsword.Name = "TxtBxPsword"
        Me.TxtBxPsword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtBxPsword.Size = New System.Drawing.Size(262, 44)
        Me.TxtBxPsword.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"),System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(406, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(403, 185)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = false
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"),System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(260, 256)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(215, 63)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = false
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"),System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(268, 339)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(207, 55)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 16
        Me.PictureBox3.TabStop = false
        '
        'CheckBox1
        '
        Me.CheckBox1.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox1.AutoSize = true
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.BackgroundImage = Global.ProjectCode.My.Resources.Resources.background
        Me.CheckBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CheckBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBox1.FlatAppearance.BorderSize = 0
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.Image = Global.ProjectCode.My.Resources.Resources.eye_close
        Me.CheckBox1.Location = New System.Drawing.Point(763, 363)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(34, 31)
        Me.CheckBox1.TabIndex = 18
        Me.CheckBox1.UseVisualStyleBackColor = false
        '
        'WelcomeLoginBtn
        '
        Me.WelcomeLoginBtn.BackColor = System.Drawing.Color.Transparent
        Me.WelcomeLoginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.WelcomeLoginBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WelcomeLoginBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.WelcomeLoginBtn.FlatAppearance.BorderSize = 0
        Me.WelcomeLoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.WelcomeLoginBtn.Font = New System.Drawing.Font("Sitka Heading", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.WelcomeLoginBtn.ForeColor = System.Drawing.Color.Transparent
        Me.WelcomeLoginBtn.Image = CType(resources.GetObject("WelcomeLoginBtn.Image"),System.Drawing.Image)
        Me.WelcomeLoginBtn.Location = New System.Drawing.Point(260, 509)
        Me.WelcomeLoginBtn.Name = "WelcomeLoginBtn"
        Me.WelcomeLoginBtn.Size = New System.Drawing.Size(212, 75)
        Me.WelcomeLoginBtn.TabIndex = 19
        Me.WelcomeLoginBtn.UseVisualStyleBackColor = false
        '
        'WelcomeExitBtn
        '
        Me.WelcomeExitBtn.BackColor = System.Drawing.Color.Transparent
        Me.WelcomeExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.WelcomeExitBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WelcomeExitBtn.FlatAppearance.BorderSize = 0
        Me.WelcomeExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.WelcomeExitBtn.Font = New System.Drawing.Font("Sitka Heading", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.WelcomeExitBtn.ForeColor = System.Drawing.Color.Transparent
        Me.WelcomeExitBtn.Image = Global.ProjectCode.My.Resources.Resources.exit_button
        Me.WelcomeExitBtn.Location = New System.Drawing.Point(501, 509)
        Me.WelcomeExitBtn.Name = "WelcomeExitBtn"
        Me.WelcomeExitBtn.Size = New System.Drawing.Size(212, 79)
        Me.WelcomeExitBtn.TabIndex = 20
        Me.WelcomeExitBtn.UseVisualStyleBackColor = false
        '
        'DoubleEntryTxtBx
        '
        Me.DoubleEntryTxtBx.BackColor = System.Drawing.Color.Lavender
        Me.DoubleEntryTxtBx.Font = New System.Drawing.Font("Microsoft Sans Serif", 24!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.DoubleEntryTxtBx.Location = New System.Drawing.Point(481, 433)
        Me.DoubleEntryTxtBx.Name = "DoubleEntryTxtBx"
        Me.DoubleEntryTxtBx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.DoubleEntryTxtBx.Size = New System.Drawing.Size(262, 44)
        Me.DoubleEntryTxtBx.TabIndex = 21
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"),System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(170, 426)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(305, 51)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 22
        Me.PictureBox4.TabStop = false
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"),System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1187, 618)
        Me.ControlBox = false
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.DoubleEntryTxtBx)
        Me.Controls.Add(Me.WelcomeExitBtn)
        Me.Controls.Add(Me.WelcomeLoginBtn)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TxtBxPsword)
        Me.Controls.Add(Me.TxtBxUser)
        Me.Controls.Add(Me.passwrdBtn)
        Me.Name = "login"
        Me.Text = "Enfey's Market Management System"
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox4,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents passwrdBtn As Button
    Friend WithEvents TxtBxUser As TextBox
    Friend WithEvents TxtBxPsword As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents WelcomeLoginBtn As Button
    Friend WithEvents WelcomeExitBtn As Button
    Friend WithEvents DoubleEntryTxtBx As TextBox
    Friend WithEvents PictureBox4 As PictureBox
End Class
