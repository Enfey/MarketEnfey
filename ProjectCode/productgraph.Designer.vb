<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class productgraph
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(productgraph))
        Me.EmailToAdminBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'EmailToAdminBtn
        '
        Me.EmailToAdminBtn.BackColor = System.Drawing.Color.Transparent
        Me.EmailToAdminBtn.BackgroundImage = CType(resources.GetObject("EmailToAdminBtn.BackgroundImage"), System.Drawing.Image)
        Me.EmailToAdminBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.EmailToAdminBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EmailToAdminBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.EmailToAdminBtn.FlatAppearance.BorderSize = 0
        Me.EmailToAdminBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EmailToAdminBtn.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailToAdminBtn.Location = New System.Drawing.Point(754, 521)
        Me.EmailToAdminBtn.Name = "EmailToAdminBtn"
        Me.EmailToAdminBtn.Size = New System.Drawing.Size(207, 85)
        Me.EmailToAdminBtn.TabIndex = 3
        Me.EmailToAdminBtn.UseVisualStyleBackColor = False
        '
        'ExitBtn
        '
        Me.ExitBtn.BackColor = System.Drawing.Color.Transparent
        Me.ExitBtn.BackgroundImage = CType(resources.GetObject("ExitBtn.BackgroundImage"), System.Drawing.Image)
        Me.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExitBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ExitBtn.FlatAppearance.BorderSize = 0
        Me.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitBtn.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitBtn.Location = New System.Drawing.Point(967, 526)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(208, 80)
        Me.ExitBtn.TabIndex = 4
        Me.ExitBtn.UseVisualStyleBackColor = False
        '
        'productgraph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.ProjectCode.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(1187, 618)
        Me.ControlBox = False
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.EmailToAdminBtn)
        Me.Name = "productgraph"
        Me.Text = "Enfey's Market Management System"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents EmailToAdminBtn As Button
    Friend WithEvents ExitBtn As Button
End Class
