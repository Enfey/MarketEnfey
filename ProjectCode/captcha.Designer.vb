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
        Me.CancelBtn = New System.Windows.Forms.Button()
        CType(Me.CaptchaPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserCaptchaTxtBx
        '
        Me.UserCaptchaTxtBx.BackColor = System.Drawing.Color.Lavender
        Me.UserCaptchaTxtBx.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserCaptchaTxtBx.Location = New System.Drawing.Point(2, 99)
        Me.UserCaptchaTxtBx.Name = "UserCaptchaTxtBx"
        Me.UserCaptchaTxtBx.Size = New System.Drawing.Size(278, 44)
        Me.UserCaptchaTxtBx.TabIndex = 20
        '
        'VerifyBtn
        '
        Me.VerifyBtn.FlatAppearance.BorderSize = 0
        Me.VerifyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VerifyBtn.Image = CType(resources.GetObject("VerifyBtn.Image"), System.Drawing.Image)
        Me.VerifyBtn.Location = New System.Drawing.Point(291, 121)
        Me.VerifyBtn.Name = "VerifyBtn"
        Me.VerifyBtn.Size = New System.Drawing.Size(83, 44)
        Me.VerifyBtn.TabIndex = 21
        Me.VerifyBtn.UseVisualStyleBackColor = True
        '
        'RefreshBtn
        '
        Me.RefreshBtn.BackColor = System.Drawing.Color.Transparent
        Me.RefreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RefreshBtn.FlatAppearance.BorderSize = 0
        Me.RefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RefreshBtn.Image = CType(resources.GetObject("RefreshBtn.Image"), System.Drawing.Image)
        Me.RefreshBtn.Location = New System.Drawing.Point(291, 15)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.Size = New System.Drawing.Size(83, 50)
        Me.RefreshBtn.TabIndex = 22
        Me.RefreshBtn.UseVisualStyleBackColor = False
        '
        'CaptchaPicBox
        '
        Me.CaptchaPicBox.BackgroundImage = Global.ProjectCode.My.Resources.Resources.background
        Me.CaptchaPicBox.Location = New System.Drawing.Point(12, 15)
        Me.CaptchaPicBox.Name = "CaptchaPicBox"
        Me.CaptchaPicBox.Size = New System.Drawing.Size(233, 50)
        Me.CaptchaPicBox.TabIndex = 23
        Me.CaptchaPicBox.TabStop = False
        '
        'CancelBtn
        '
        Me.CancelBtn.FlatAppearance.BorderSize = 0
        Me.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelBtn.Image = CType(resources.GetObject("CancelBtn.Image"), System.Drawing.Image)
        Me.CancelBtn.Location = New System.Drawing.Point(291, 71)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(83, 44)
        Me.CancelBtn.TabIndex = 24
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'captcha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProjectCode.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(381, 187)
        Me.ControlBox = False
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.CaptchaPicBox)
        Me.Controls.Add(Me.RefreshBtn)
        Me.Controls.Add(Me.VerifyBtn)
        Me.Controls.Add(Me.UserCaptchaTxtBx)
        Me.Name = "captcha"
        Me.Text = "Enfey's Market Management System"
        CType(Me.CaptchaPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UserCaptchaTxtBx As TextBox
    Friend WithEvents VerifyBtn As Button
    Friend WithEvents RefreshBtn As Button
    Friend WithEvents CaptchaPicBox As PictureBox
    Friend WithEvents CancelBtn As Button
End Class
