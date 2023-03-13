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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.ForgotPasswordBtn = New System.Windows.Forms.Button()
        Me.UsernameTxtBx = New System.Windows.Forms.TextBox()
        Me.PasswordTxtBx = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PasswordHide = New System.Windows.Forms.CheckBox()
        Me.LoginBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.DoubleEntryTxtBx = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Shutdown = New System.Windows.Forms.Timer(Me.components)
        Me.HideControls = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox4,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'ForgotPasswordBtn
        '
        Me.ForgotPasswordBtn.BackColor = System.Drawing.Color.Transparent
        Me.ForgotPasswordBtn.BackgroundImage = CType(resources.GetObject("ForgotPasswordBtn.BackgroundImage"), System.Drawing.Image)
        Me.ForgotPasswordBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ForgotPasswordBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ForgotPasswordBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ForgotPasswordBtn.FlatAppearance.BorderSize = 0
        Me.ForgotPasswordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ForgotPasswordBtn.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForgotPasswordBtn.Location = New System.Drawing.Point(744, 509)
        Me.ForgotPasswordBtn.Name = "ForgotPasswordBtn"
        Me.ForgotPasswordBtn.Size = New System.Drawing.Size(208, 80)
        Me.ForgotPasswordBtn.TabIndex = 2
        Me.ForgotPasswordBtn.UseVisualStyleBackColor = False
        '
        'UsernameTxtBx
        '
        Me.UsernameTxtBx.BackColor = System.Drawing.Color.Lavender
        Me.UsernameTxtBx.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTxtBx.ForeColor = System.Drawing.SystemColors.WindowText
        Me.UsernameTxtBx.Location = New System.Drawing.Point(481, 265)
        Me.UsernameTxtBx.Name = "UsernameTxtBx"
        Me.UsernameTxtBx.Size = New System.Drawing.Size(262, 44)
        Me.UsernameTxtBx.TabIndex = 3
        '
        'PasswordTxtBx
        '
        Me.PasswordTxtBx.BackColor = System.Drawing.Color.Lavender
        Me.PasswordTxtBx.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTxtBx.Location = New System.Drawing.Point(481, 351)
        Me.PasswordTxtBx.Name = "PasswordTxtBx"
        Me.PasswordTxtBx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTxtBx.Size = New System.Drawing.Size(262, 44)
        Me.PasswordTxtBx.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(406, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(403, 185)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(260, 256)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(215, 63)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(268, 339)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(207, 55)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 16
        Me.PictureBox3.TabStop = False
        '
        'PasswordHide
        '
        Me.PasswordHide.Appearance = System.Windows.Forms.Appearance.Button
        Me.PasswordHide.AutoSize = True
        Me.PasswordHide.BackColor = System.Drawing.Color.Transparent
        Me.PasswordHide.BackgroundImage = Global.ProjectCode.My.Resources.Resources.background
        Me.PasswordHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PasswordHide.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PasswordHide.FlatAppearance.BorderSize = 0
        Me.PasswordHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PasswordHide.Image = Global.ProjectCode.My.Resources.Resources.eye_close
        Me.PasswordHide.Location = New System.Drawing.Point(763, 363)
        Me.PasswordHide.Name = "PasswordHide"
        Me.PasswordHide.Size = New System.Drawing.Size(34, 31)
        Me.PasswordHide.TabIndex = 18
        Me.PasswordHide.UseVisualStyleBackColor = False
        '
        'LoginBtn
        '
        Me.LoginBtn.BackColor = System.Drawing.Color.Transparent
        Me.LoginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoginBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.LoginBtn.FlatAppearance.BorderSize = 0
        Me.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoginBtn.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginBtn.ForeColor = System.Drawing.Color.Transparent
        Me.LoginBtn.Image = CType(resources.GetObject("LoginBtn.Image"), System.Drawing.Image)
        Me.LoginBtn.Location = New System.Drawing.Point(260, 509)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(212, 75)
        Me.LoginBtn.TabIndex = 19
        Me.LoginBtn.UseVisualStyleBackColor = False
        '
        'ExitBtn
        '
        Me.ExitBtn.BackColor = System.Drawing.Color.Transparent
        Me.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExitBtn.FlatAppearance.BorderSize = 0
        Me.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitBtn.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitBtn.ForeColor = System.Drawing.Color.Transparent
        Me.ExitBtn.Image = Global.ProjectCode.My.Resources.Resources.exit_button
        Me.ExitBtn.Location = New System.Drawing.Point(501, 509)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(212, 79)
        Me.ExitBtn.TabIndex = 20
        Me.ExitBtn.UseVisualStyleBackColor = False
        '
        'DoubleEntryTxtBx
        '
        Me.DoubleEntryTxtBx.BackColor = System.Drawing.Color.Lavender
        Me.DoubleEntryTxtBx.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DoubleEntryTxtBx.Location = New System.Drawing.Point(481, 433)
        Me.DoubleEntryTxtBx.Name = "DoubleEntryTxtBx"
        Me.DoubleEntryTxtBx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.DoubleEntryTxtBx.Size = New System.Drawing.Size(262, 44)
        Me.DoubleEntryTxtBx.TabIndex = 21
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(170, 426)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(305, 51)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 22
        Me.PictureBox4.TabStop = False
        '
        'Shutdown
        '
        Me.Shutdown.Interval = 1000
        '
        'HideControls
        '
        Me.HideControls.Interval = 1000
        '
        'BackgroundWorker
        '
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(388, 286)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(444, 33)
        Me.ProgressBar.TabIndex = 25
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"),System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1187, 618)
        Me.ControlBox = false
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.DoubleEntryTxtBx)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.LoginBtn)
        Me.Controls.Add(Me.PasswordHide)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PasswordTxtBx)
        Me.Controls.Add(Me.UsernameTxtBx)
        Me.Controls.Add(Me.ForgotPasswordBtn)
        Me.Name = "login"
        Me.Text = "Enfey's Market Management System"
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox4,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents ForgotPasswordBtn As Button
    Friend WithEvents UsernameTxtBx As TextBox
    Friend WithEvents PasswordTxtBx As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PasswordHide As CheckBox
    Friend WithEvents LoginBtn As Button
    Friend WithEvents ExitBtn As Button
    Friend WithEvents DoubleEntryTxtBx As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Shutdown As Timer
    Friend WithEvents HideControls As Timer
    Friend WithEvents BackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents ProgressBar As ProgressBar
End Class
