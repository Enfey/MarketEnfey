<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginVerifyMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginVerifyMenu))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Email2FABtn = New System.Windows.Forms.Button()
        Me.Phone2FABtn = New System.Windows.Forms.Button()
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.ProjectCode.My.Resources.Resources.background
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"),System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(27, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(320, 86)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Email2FABtn
        '
        Me.Email2FABtn.BackColor = System.Drawing.Color.Transparent
        Me.Email2FABtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Email2FABtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Email2FABtn.FlatAppearance.BorderSize = 0
        Me.Email2FABtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Email2FABtn.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email2FABtn.Image = CType(resources.GetObject("Email2FABtn.Image"), System.Drawing.Image)
        Me.Email2FABtn.Location = New System.Drawing.Point(231, 126)
        Me.Email2FABtn.Name = "Email2FABtn"
        Me.Email2FABtn.Size = New System.Drawing.Size(82, 48)
        Me.Email2FABtn.TabIndex = 72
        Me.Email2FABtn.UseVisualStyleBackColor = False
        '
        'Phone2FABtn
        '
        Me.Phone2FABtn.BackColor = System.Drawing.Color.Transparent
        Me.Phone2FABtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Phone2FABtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Phone2FABtn.FlatAppearance.BorderSize = 0
        Me.Phone2FABtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Phone2FABtn.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Phone2FABtn.Image = CType(resources.GetObject("Phone2FABtn.Image"), System.Drawing.Image)
        Me.Phone2FABtn.Location = New System.Drawing.Point(64, 126)
        Me.Phone2FABtn.Name = "Phone2FABtn"
        Me.Phone2FABtn.Size = New System.Drawing.Size(82, 47)
        Me.Phone2FABtn.TabIndex = 73
        Me.Phone2FABtn.UseVisualStyleBackColor = false
        '
        'loginVerifyMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProjectCode.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(381, 187)
        Me.ControlBox = false
        Me.Controls.Add(Me.Phone2FABtn)
        Me.Controls.Add(Me.Email2FABtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "loginVerifyMenu"
        Me.Text = "Enfey's Market Management System"
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Email2FABtn As Button
    Friend WithEvents Phone2FABtn As Button
End Class
