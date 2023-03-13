<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class forgotpassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(forgotpassword))
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.UsernameTxtBx = New System.Windows.Forms.TextBox()
        Me.UsernameCheckBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.QuestionTxtBx = New System.Windows.Forms.TextBox()
        Me.AnswerTxtBx = New System.Windows.Forms.TextBox()
        Me.NewPassTxtBx = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.AnswerPicBox = New System.Windows.Forms.PictureBox()
        Me.PasswordPicBox = New System.Windows.Forms.PictureBox()
        Me.ChangePasswordBtn = New System.Windows.Forms.Button()
        Me.AnswerCheckBtn = New System.Windows.Forms.Button()
        Me.DoubleEntryTxtBx = New System.Windows.Forms.TextBox()
        Me.PasswordEnter2PicBx = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox4,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.AnswerPicBox,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PasswordPicBox,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PasswordEnter2PicBx,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'CancelBtn
        '
        Me.CancelBtn.BackColor = System.Drawing.Color.Transparent
        Me.CancelBtn.BackgroundImage = CType(resources.GetObject("CancelBtn.BackgroundImage"),System.Drawing.Image)
        Me.CancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CancelBtn.FlatAppearance.BorderSize = 0
        Me.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelBtn.Font = New System.Drawing.Font("Sitka Heading", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.CancelBtn.Location = New System.Drawing.Point(963, 521)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(212, 85)
        Me.CancelBtn.TabIndex = 12
        Me.CancelBtn.UseVisualStyleBackColor = False
        '
        'UsernameTxtBx
        '
        Me.UsernameTxtBx.BackColor = System.Drawing.Color.Lavender
        Me.UsernameTxtBx.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTxtBx.Location = New System.Drawing.Point(497, 206)
        Me.UsernameTxtBx.Name = "UsernameTxtBx"
        Me.UsernameTxtBx.Size = New System.Drawing.Size(262, 44)
        Me.UsernameTxtBx.TabIndex = 14
        '
        'UsernameCheckBtn
        '
        Me.UsernameCheckBtn.BackColor = System.Drawing.Color.Transparent
        Me.UsernameCheckBtn.BackgroundImage = CType(resources.GetObject("UsernameCheckBtn.BackgroundImage"), System.Drawing.Image)
        Me.UsernameCheckBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.UsernameCheckBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UsernameCheckBtn.FlatAppearance.BorderSize = 0
        Me.UsernameCheckBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UsernameCheckBtn.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameCheckBtn.Location = New System.Drawing.Point(295, 513)
        Me.UsernameCheckBtn.Name = "UsernameCheckBtn"
        Me.UsernameCheckBtn.Size = New System.Drawing.Size(212, 85)
        Me.UsernameCheckBtn.TabIndex = 16
        Me.UsernameCheckBtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(422, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(403, 185)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(276, 203)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(215, 63)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'QuestionTxtBx
        '
        Me.QuestionTxtBx.BackColor = System.Drawing.Color.Lavender
        Me.QuestionTxtBx.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuestionTxtBx.Location = New System.Drawing.Point(497, 266)
        Me.QuestionTxtBx.Name = "QuestionTxtBx"
        Me.QuestionTxtBx.ReadOnly = True
        Me.QuestionTxtBx.Size = New System.Drawing.Size(262, 44)
        Me.QuestionTxtBx.TabIndex = 22
        '
        'AnswerTxtBx
        '
        Me.AnswerTxtBx.BackColor = System.Drawing.Color.Lavender
        Me.AnswerTxtBx.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnswerTxtBx.Location = New System.Drawing.Point(497, 331)
        Me.AnswerTxtBx.Name = "AnswerTxtBx"
        Me.AnswerTxtBx.Size = New System.Drawing.Size(262, 44)
        Me.AnswerTxtBx.TabIndex = 23
        '
        'NewPassTxtBx
        '
        Me.NewPassTxtBx.BackColor = System.Drawing.Color.Lavender
        Me.NewPassTxtBx.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewPassTxtBx.Location = New System.Drawing.Point(497, 395)
        Me.NewPassTxtBx.Name = "NewPassTxtBx"
        Me.NewPassTxtBx.Size = New System.Drawing.Size(262, 44)
        Me.NewPassTxtBx.TabIndex = 28
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(323, 266)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(168, 50)
        Me.PictureBox4.TabIndex = 34
        Me.PictureBox4.TabStop = False
        '
        'AnswerPicBox
        '
        Me.AnswerPicBox.BackColor = System.Drawing.Color.Transparent
        Me.AnswerPicBox.Image = CType(resources.GetObject("AnswerPicBox.Image"), System.Drawing.Image)
        Me.AnswerPicBox.Location = New System.Drawing.Point(341, 331)
        Me.AnswerPicBox.Name = "AnswerPicBox"
        Me.AnswerPicBox.Size = New System.Drawing.Size(150, 46)
        Me.AnswerPicBox.TabIndex = 35
        Me.AnswerPicBox.TabStop = False
        '
        'PasswordPicBox
        '
        Me.PasswordPicBox.BackColor = System.Drawing.Color.Transparent
        Me.PasswordPicBox.Image = CType(resources.GetObject("PasswordPicBox.Image"), System.Drawing.Image)
        Me.PasswordPicBox.Location = New System.Drawing.Point(242, 389)
        Me.PasswordPicBox.Name = "PasswordPicBox"
        Me.PasswordPicBox.Size = New System.Drawing.Size(249, 50)
        Me.PasswordPicBox.TabIndex = 36
        Me.PasswordPicBox.TabStop = False
        '
        'ChangePasswordBtn
        '
        Me.ChangePasswordBtn.BackColor = System.Drawing.Color.Transparent
        Me.ChangePasswordBtn.BackgroundImage = CType(resources.GetObject("ChangePasswordBtn.BackgroundImage"), System.Drawing.Image)
        Me.ChangePasswordBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ChangePasswordBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChangePasswordBtn.FlatAppearance.BorderSize = 0
        Me.ChangePasswordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChangePasswordBtn.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangePasswordBtn.Location = New System.Drawing.Point(730, 513)
        Me.ChangePasswordBtn.Name = "ChangePasswordBtn"
        Me.ChangePasswordBtn.Size = New System.Drawing.Size(212, 85)
        Me.ChangePasswordBtn.TabIndex = 37
        Me.ChangePasswordBtn.UseVisualStyleBackColor = False
        '
        'AnswerCheckBtn
        '
        Me.AnswerCheckBtn.BackColor = System.Drawing.Color.Transparent
        Me.AnswerCheckBtn.BackgroundImage = CType(resources.GetObject("AnswerCheckBtn.BackgroundImage"), System.Drawing.Image)
        Me.AnswerCheckBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.AnswerCheckBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AnswerCheckBtn.FlatAppearance.BorderSize = 0
        Me.AnswerCheckBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AnswerCheckBtn.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnswerCheckBtn.Image = CType(resources.GetObject("AnswerCheckBtn.Image"), System.Drawing.Image)
        Me.AnswerCheckBtn.Location = New System.Drawing.Point(513, 513)
        Me.AnswerCheckBtn.Name = "AnswerCheckBtn"
        Me.AnswerCheckBtn.Size = New System.Drawing.Size(211, 85)
        Me.AnswerCheckBtn.TabIndex = 38
        Me.AnswerCheckBtn.UseVisualStyleBackColor = False
        '
        'DoubleEntryTxtBx
        '
        Me.DoubleEntryTxtBx.BackColor = System.Drawing.Color.Lavender
        Me.DoubleEntryTxtBx.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DoubleEntryTxtBx.Location = New System.Drawing.Point(497, 457)
        Me.DoubleEntryTxtBx.Name = "DoubleEntryTxtBx"
        Me.DoubleEntryTxtBx.Size = New System.Drawing.Size(262, 44)
        Me.DoubleEntryTxtBx.TabIndex = 39
        '
        'PasswordEnter2PicBx
        '
        Me.PasswordEnter2PicBx.BackColor = System.Drawing.Color.Transparent
        Me.PasswordEnter2PicBx.Image = CType(resources.GetObject("PasswordEnter2PicBx.Image"),System.Drawing.Image)
        Me.PasswordEnter2PicBx.Location = New System.Drawing.Point(193, 457)
        Me.PasswordEnter2PicBx.Name = "PasswordEnter2PicBx"
        Me.PasswordEnter2PicBx.Size = New System.Drawing.Size(298, 50)
        Me.PasswordEnter2PicBx.TabIndex = 40
        Me.PasswordEnter2PicBx.TabStop = false
        '
        'forgotpassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"),System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1187, 618)
        Me.ControlBox = false
        Me.Controls.Add(Me.PasswordEnter2PicBx)
        Me.Controls.Add(Me.DoubleEntryTxtBx)
        Me.Controls.Add(Me.AnswerCheckBtn)
        Me.Controls.Add(Me.ChangePasswordBtn)
        Me.Controls.Add(Me.PasswordPicBox)
        Me.Controls.Add(Me.AnswerPicBox)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.NewPassTxtBx)
        Me.Controls.Add(Me.AnswerTxtBx)
        Me.Controls.Add(Me.QuestionTxtBx)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.UsernameCheckBtn)
        Me.Controls.Add(Me.UsernameTxtBx)
        Me.Controls.Add(Me.CancelBtn)
        Me.Name = "forgotpassword"
        Me.Text = "Enfey's Market Management System"
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox4,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.AnswerPicBox,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PasswordPicBox,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PasswordEnter2PicBx,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents CancelBtn As Button
    Friend WithEvents UsernameTxtBx As TextBox
    Friend WithEvents UsernameCheckBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents QuestionTxtBx As TextBox
    Friend WithEvents AnswerTxtBx As TextBox
    Friend WithEvents NewPassTxtBx As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents AnswerPicBox As PictureBox
    Friend WithEvents PasswordPicBox As PictureBox
    Friend WithEvents ChangePasswordBtn As Button
    Friend WithEvents AnswerCheckBtn As Button
    Friend WithEvents DoubleEntryTxtBx As TextBox
    Friend WithEvents PasswordEnter2PicBx As PictureBox
End Class
