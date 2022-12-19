<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _2fa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_2fa))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.EmailResendBtn = New System.Windows.Forms.Button()
        Me.VerificationTxtBx = New System.Windows.Forms.TextBox()
        Me.VerifyBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(532, 308)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(403, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(403, 185)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'EmailResendBtn
        '
        Me.EmailResendBtn.BackColor = System.Drawing.Color.Transparent
        Me.EmailResendBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.EmailResendBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EmailResendBtn.FlatAppearance.BorderSize = 0
        Me.EmailResendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EmailResendBtn.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailResendBtn.Image = CType(resources.GetObject("EmailResendBtn.Image"), System.Drawing.Image)
        Me.EmailResendBtn.Location = New System.Drawing.Point(360, 485)
        Me.EmailResendBtn.Name = "EmailResendBtn"
        Me.EmailResendBtn.Size = New System.Drawing.Size(209, 76)
        Me.EmailResendBtn.TabIndex = 71
        Me.EmailResendBtn.UseVisualStyleBackColor = False
        '
        'VerificationTxtBx
        '
        Me.VerificationTxtBx.BackColor = System.Drawing.Color.Lavender
        Me.VerificationTxtBx.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VerificationTxtBx.Location = New System.Drawing.Point(468, 324)
        Me.VerificationTxtBx.Name = "VerificationTxtBx"
        Me.VerificationTxtBx.Size = New System.Drawing.Size(262, 44)
        Me.VerificationTxtBx.TabIndex = 73
        '
        'VerifyBtn
        '
        Me.VerifyBtn.BackColor = System.Drawing.Color.Transparent
        Me.VerifyBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.VerifyBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.VerifyBtn.FlatAppearance.BorderSize = 0
        Me.VerifyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VerifyBtn.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VerifyBtn.Image = CType(resources.GetObject("VerifyBtn.Image"), System.Drawing.Image)
        Me.VerifyBtn.Location = New System.Drawing.Point(621, 481)
        Me.VerifyBtn.Name = "VerifyBtn"
        Me.VerifyBtn.Size = New System.Drawing.Size(204, 85)
        Me.VerifyBtn.TabIndex = 74
        Me.VerifyBtn.UseVisualStyleBackColor = False
        '
        'ExitBtn
        '
        Me.ExitBtn.BackColor = System.Drawing.Color.Transparent
        Me.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExitBtn.FlatAppearance.BorderSize = 0
        Me.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitBtn.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitBtn.Image = CType(resources.GetObject("ExitBtn.Image"), System.Drawing.Image)
        Me.ExitBtn.Location = New System.Drawing.Point(963, 521)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(212, 85)
        Me.ExitBtn.TabIndex = 75
        Me.ExitBtn.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(468, 255)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(261, 50)
        Me.PictureBox2.TabIndex = 76
        Me.PictureBox2.TabStop = False
        '
        '_2fa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProjectCode.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(1187, 618)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.VerifyBtn)
        Me.Controls.Add(Me.VerificationTxtBx)
        Me.Controls.Add(Me.EmailResendBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "_2fa"
        Me.Text = "Enfey's Market Management System"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents EmailResendBtn As Button
    Friend WithEvents VerificationTxtBx As TextBox
    Friend WithEvents VerifyBtn As Button
    Friend WithEvents ExitBtn As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
