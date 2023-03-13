<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class captcha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(captcha))
        Me.UserCaptchaTxtBx = New System.Windows.Forms.TextBox()
        Me.VerifyBtn = New System.Windows.Forms.Button()
        Me.RefreshBtn = New System.Windows.Forms.Button()
        Me.CaptchaPicBox = New System.Windows.Forms.PictureBox()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.CaptchaPicBox,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox9,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'UserCaptchaTxtBx
        '
        Me.UserCaptchaTxtBx.BackColor = System.Drawing.Color.Lavender
        Me.UserCaptchaTxtBx.Font = New System.Drawing.Font("Microsoft Sans Serif", 24!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.UserCaptchaTxtBx.Location = New System.Drawing.Point(451, 399)
        Me.UserCaptchaTxtBx.Name = "UserCaptchaTxtBx"
        Me.UserCaptchaTxtBx.Size = New System.Drawing.Size(278, 44)
        Me.UserCaptchaTxtBx.TabIndex = 20
        '
        'VerifyBtn
        '
        Me.VerifyBtn.BackColor = System.Drawing.Color.Transparent
        Me.VerifyBtn.FlatAppearance.BorderSize = 0
        Me.VerifyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VerifyBtn.Image = CType(resources.GetObject("VerifyBtn.Image"),System.Drawing.Image)
        Me.VerifyBtn.Location = New System.Drawing.Point(623, 500)
        Me.VerifyBtn.Name = "VerifyBtn"
        Me.VerifyBtn.Size = New System.Drawing.Size(217, 82)
        Me.VerifyBtn.TabIndex = 21
        Me.VerifyBtn.UseVisualStyleBackColor = false
        '
        'RefreshBtn
        '
        Me.RefreshBtn.BackColor = System.Drawing.Color.Transparent
        Me.RefreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RefreshBtn.FlatAppearance.BorderSize = 0
        Me.RefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RefreshBtn.Image = CType(resources.GetObject("RefreshBtn.Image"),System.Drawing.Image)
        Me.RefreshBtn.Location = New System.Drawing.Point(336, 500)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.Size = New System.Drawing.Size(206, 82)
        Me.RefreshBtn.TabIndex = 22
        Me.RefreshBtn.UseVisualStyleBackColor = false
        '
        'CaptchaPicBox
        '
        Me.CaptchaPicBox.BackgroundImage = Global.ProjectCode.My.Resources.Resources.background
        Me.CaptchaPicBox.Location = New System.Drawing.Point(392, 212)
        Me.CaptchaPicBox.Name = "CaptchaPicBox"
        Me.CaptchaPicBox.Size = New System.Drawing.Size(395, 81)
        Me.CaptchaPicBox.TabIndex = 23
        Me.CaptchaPicBox.TabStop = False
        '
        'ExitBtn
        '
        Me.ExitBtn.BackColor = System.Drawing.Color.Transparent
        Me.ExitBtn.FlatAppearance.BorderSize = 0
        Me.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitBtn.Image = CType(resources.GetObject("ExitBtn.Image"), System.Drawing.Image)
        Me.ExitBtn.Location = New System.Drawing.Point(970, 524)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(205, 82)
        Me.ExitBtn.TabIndex = 24
        Me.ExitBtn.UseVisualStyleBackColor = false
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"),System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(441, 306)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(301, 71)
        Me.PictureBox9.TabIndex = 52
        Me.PictureBox9.TabStop = false
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"),System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(392, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(403, 185)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 53
        Me.PictureBox1.TabStop = false
        '
        'captcha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProjectCode.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(1187, 618)
        Me.ControlBox = false
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.CaptchaPicBox)
        Me.Controls.Add(Me.RefreshBtn)
        Me.Controls.Add(Me.VerifyBtn)
        Me.Controls.Add(Me.UserCaptchaTxtBx)
        Me.Name = "captcha"
        Me.Text = "Enfey's Market Management System"
        CType(Me.CaptchaPicBox,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox9,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents UserCaptchaTxtBx As TextBox
    Friend WithEvents VerifyBtn As Button
    Friend WithEvents RefreshBtn As Button
    Friend WithEvents CaptchaPicBox As PictureBox
    Friend WithEvents ExitBtn As Button
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
