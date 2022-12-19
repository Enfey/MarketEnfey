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
        Me.FgUserTxtBx = New System.Windows.Forms.TextBox()
        Me.UserCheckBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.QuestionBox = New System.Windows.Forms.TextBox()
        Me.AnswerTxtBx = New System.Windows.Forms.TextBox()
        Me.PasswordReset = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.AnswerPicBox = New System.Windows.Forms.PictureBox()
        Me.PasswordPicBox = New System.Windows.Forms.PictureBox()
        Me.ChangePswordBtn = New System.Windows.Forms.Button()
        Me.AnswerBtn = New System.Windows.Forms.Button()
        Me.DoubleEnterTxtBx = New System.Windows.Forms.TextBox()
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
        Me.CancelBtn.UseVisualStyleBackColor = false
        '
        'FgUserTxtBx
        '
        Me.FgUserTxtBx.BackColor = System.Drawing.Color.Lavender
        Me.FgUserTxtBx.Font = New System.Drawing.Font("Microsoft Sans Serif", 24!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FgUserTxtBx.Location = New System.Drawing.Point(497, 206)
        Me.FgUserTxtBx.Name = "FgUserTxtBx"
        Me.FgUserTxtBx.Size = New System.Drawing.Size(262, 44)
        Me.FgUserTxtBx.TabIndex = 14
        '
        'UserCheckBtn
        '
        Me.UserCheckBtn.BackColor = System.Drawing.Color.Transparent
        Me.UserCheckBtn.BackgroundImage = CType(resources.GetObject("UserCheckBtn.BackgroundImage"),System.Drawing.Image)
        Me.UserCheckBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.UserCheckBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UserCheckBtn.FlatAppearance.BorderSize = 0
        Me.UserCheckBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UserCheckBtn.Font = New System.Drawing.Font("Sitka Heading", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.UserCheckBtn.Location = New System.Drawing.Point(295, 513)
        Me.UserCheckBtn.Name = "UserCheckBtn"
        Me.UserCheckBtn.Size = New System.Drawing.Size(212, 85)
        Me.UserCheckBtn.TabIndex = 16
        Me.UserCheckBtn.UseVisualStyleBackColor = false
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"),System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(422, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(403, 185)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = false
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"),System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(276, 203)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(215, 63)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = false
        '
        'QuestionBox
        '
        Me.QuestionBox.BackColor = System.Drawing.Color.Lavender
        Me.QuestionBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 24!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.QuestionBox.Location = New System.Drawing.Point(497, 266)
        Me.QuestionBox.Name = "QuestionBox"
        Me.QuestionBox.ReadOnly = true
        Me.QuestionBox.Size = New System.Drawing.Size(262, 44)
        Me.QuestionBox.TabIndex = 22
        '
        'AnswerTxtBx
        '
        Me.AnswerTxtBx.BackColor = System.Drawing.Color.Lavender
        Me.AnswerTxtBx.Font = New System.Drawing.Font("Microsoft Sans Serif", 24!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.AnswerTxtBx.Location = New System.Drawing.Point(497, 331)
        Me.AnswerTxtBx.Name = "AnswerTxtBx"
        Me.AnswerTxtBx.Size = New System.Drawing.Size(262, 44)
        Me.AnswerTxtBx.TabIndex = 23
        '
        'PasswordReset
        '
        Me.PasswordReset.BackColor = System.Drawing.Color.Lavender
        Me.PasswordReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 24!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.PasswordReset.Location = New System.Drawing.Point(497, 395)
        Me.PasswordReset.Name = "PasswordReset"
        Me.PasswordReset.Size = New System.Drawing.Size(262, 44)
        Me.PasswordReset.TabIndex = 28
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"),System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(323, 266)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(168, 50)
        Me.PictureBox4.TabIndex = 34
        Me.PictureBox4.TabStop = false
        '
        'AnswerPicBox
        '
        Me.AnswerPicBox.BackColor = System.Drawing.Color.Transparent
        Me.AnswerPicBox.Image = CType(resources.GetObject("AnswerPicBox.Image"),System.Drawing.Image)
        Me.AnswerPicBox.Location = New System.Drawing.Point(341, 331)
        Me.AnswerPicBox.Name = "AnswerPicBox"
        Me.AnswerPicBox.Size = New System.Drawing.Size(150, 46)
        Me.AnswerPicBox.TabIndex = 35
        Me.AnswerPicBox.TabStop = false
        '
        'PasswordPicBox
        '
        Me.PasswordPicBox.BackColor = System.Drawing.Color.Transparent
        Me.PasswordPicBox.Image = CType(resources.GetObject("PasswordPicBox.Image"),System.Drawing.Image)
        Me.PasswordPicBox.Location = New System.Drawing.Point(242, 389)
        Me.PasswordPicBox.Name = "PasswordPicBox"
        Me.PasswordPicBox.Size = New System.Drawing.Size(249, 50)
        Me.PasswordPicBox.TabIndex = 36
        Me.PasswordPicBox.TabStop = false
        '
        'ChangePswordBtn
        '
        Me.ChangePswordBtn.BackColor = System.Drawing.Color.Transparent
        Me.ChangePswordBtn.BackgroundImage = CType(resources.GetObject("ChangePswordBtn.BackgroundImage"),System.Drawing.Image)
        Me.ChangePswordBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ChangePswordBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChangePswordBtn.FlatAppearance.BorderSize = 0
        Me.ChangePswordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChangePswordBtn.Font = New System.Drawing.Font("Sitka Heading", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ChangePswordBtn.Location = New System.Drawing.Point(730, 513)
        Me.ChangePswordBtn.Name = "ChangePswordBtn"
        Me.ChangePswordBtn.Size = New System.Drawing.Size(212, 85)
        Me.ChangePswordBtn.TabIndex = 37
        Me.ChangePswordBtn.UseVisualStyleBackColor = false
        '
        'AnswerBtn
        '
        Me.AnswerBtn.BackColor = System.Drawing.Color.Transparent
        Me.AnswerBtn.BackgroundImage = CType(resources.GetObject("AnswerBtn.BackgroundImage"),System.Drawing.Image)
        Me.AnswerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.AnswerBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AnswerBtn.FlatAppearance.BorderSize = 0
        Me.AnswerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AnswerBtn.Font = New System.Drawing.Font("Sitka Heading", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.AnswerBtn.Image = CType(resources.GetObject("AnswerBtn.Image"),System.Drawing.Image)
        Me.AnswerBtn.Location = New System.Drawing.Point(513, 513)
        Me.AnswerBtn.Name = "AnswerBtn"
        Me.AnswerBtn.Size = New System.Drawing.Size(211, 85)
        Me.AnswerBtn.TabIndex = 38
        Me.AnswerBtn.UseVisualStyleBackColor = false
        '
        'DoubleEnterTxtBx
        '
        Me.DoubleEnterTxtBx.BackColor = System.Drawing.Color.Lavender
        Me.DoubleEnterTxtBx.Font = New System.Drawing.Font("Microsoft Sans Serif", 24!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.DoubleEnterTxtBx.Location = New System.Drawing.Point(497, 457)
        Me.DoubleEnterTxtBx.Name = "DoubleEnterTxtBx"
        Me.DoubleEnterTxtBx.Size = New System.Drawing.Size(262, 44)
        Me.DoubleEnterTxtBx.TabIndex = 39
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
        Me.Controls.Add(Me.DoubleEnterTxtBx)
        Me.Controls.Add(Me.AnswerBtn)
        Me.Controls.Add(Me.ChangePswordBtn)
        Me.Controls.Add(Me.PasswordPicBox)
        Me.Controls.Add(Me.AnswerPicBox)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PasswordReset)
        Me.Controls.Add(Me.AnswerTxtBx)
        Me.Controls.Add(Me.QuestionBox)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.UserCheckBtn)
        Me.Controls.Add(Me.FgUserTxtBx)
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
    Friend WithEvents FgUserTxtBx As TextBox
    Friend WithEvents UserCheckBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents QuestionBox As TextBox
    Friend WithEvents AnswerTxtBx As TextBox
    Friend WithEvents PasswordReset As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents AnswerPicBox As PictureBox
    Friend WithEvents PasswordPicBox As PictureBox
    Friend WithEvents ChangePswordBtn As Button
    Friend WithEvents AnswerBtn As Button
    Friend WithEvents DoubleEnterTxtBx As TextBox
    Friend WithEvents PasswordEnter2PicBx As PictureBox
End Class
