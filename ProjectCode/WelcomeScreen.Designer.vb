<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WelcomeScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WelcomeScreen))
        Me.WelcomeExitBtn = New System.Windows.Forms.Button()
        Me.WelcomeLoginBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WelcomeExitBtn
        '
        Me.WelcomeExitBtn.BackColor = System.Drawing.Color.Transparent
        Me.WelcomeExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.WelcomeExitBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WelcomeExitBtn.FlatAppearance.BorderSize = 0
        Me.WelcomeExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.WelcomeExitBtn.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WelcomeExitBtn.ForeColor = System.Drawing.Color.Transparent
        Me.WelcomeExitBtn.Image = Global.ProjectCode.My.Resources.Resources.exit_button
        Me.WelcomeExitBtn.Location = New System.Drawing.Point(669, 379)
        Me.WelcomeExitBtn.Name = "WelcomeExitBtn"
        Me.WelcomeExitBtn.Size = New System.Drawing.Size(212, 75)
        Me.WelcomeExitBtn.TabIndex = 11
        Me.WelcomeExitBtn.UseVisualStyleBackColor = False
        '
        'WelcomeLoginBtn
        '
        Me.WelcomeLoginBtn.BackColor = System.Drawing.Color.Transparent
        Me.WelcomeLoginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.WelcomeLoginBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WelcomeLoginBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.WelcomeLoginBtn.FlatAppearance.BorderSize = 0
        Me.WelcomeLoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.WelcomeLoginBtn.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WelcomeLoginBtn.ForeColor = System.Drawing.Color.Transparent
        Me.WelcomeLoginBtn.Image = CType(resources.GetObject("WelcomeLoginBtn.Image"), System.Drawing.Image)
        Me.WelcomeLoginBtn.Location = New System.Drawing.Point(308, 379)
        Me.WelcomeLoginBtn.Name = "WelcomeLoginBtn"
        Me.WelcomeLoginBtn.Size = New System.Drawing.Size(212, 75)
        Me.WelcomeLoginBtn.TabIndex = 12
        Me.WelcomeLoginBtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(395, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(403, 185)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(355, 233)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(489, 115)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'WelcomeScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1187, 618)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.WelcomeLoginBtn)
        Me.Controls.Add(Me.WelcomeExitBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "WelcomeScreen"
        Me.Text = "Enfey's Market Management System"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WelcomeExitBtn As Button
    Friend WithEvents WelcomeLoginBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
