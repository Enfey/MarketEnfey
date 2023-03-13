<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SimpleCustomerSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SimpleCustomerSearch))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.CustomerDgv = New System.Windows.Forms.DataGridView()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.SearchCustomerBtn = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.CustomerIDTxtBx = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox8,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox4,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.CustomerDgv,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"),System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(1056, 36)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(119, 101)
        Me.PictureBox8.TabIndex = 46
        Me.PictureBox8.TabStop = false
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"),System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-12, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1201, 32)
        Me.PictureBox1.TabIndex = 47
        Me.PictureBox1.TabStop = false
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"),System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(12, 36)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(398, 50)
        Me.PictureBox4.TabIndex = 48
        Me.PictureBox4.TabStop = False
        '
        'CustomerDgv
        '
        Me.CustomerDgv.AllowUserToAddRows = False
        Me.CustomerDgv.AllowUserToDeleteRows = False
        Me.CustomerDgv.AllowUserToResizeColumns = False
        Me.CustomerDgv.AllowUserToResizeRows = False
        Me.CustomerDgv.BackgroundColor = System.Drawing.Color.Lavender
        Me.CustomerDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CustomerDgv.DefaultCellStyle = DataGridViewCellStyle1
        Me.CustomerDgv.GridColor = System.Drawing.Color.LavenderBlush
        Me.CustomerDgv.Location = New System.Drawing.Point(550, 198)
        Me.CustomerDgv.Name = "CustomerDgv"
        Me.CustomerDgv.Size = New System.Drawing.Size(625, 279)
        Me.CustomerDgv.TabIndex = 49
        '
        'BackBtn
        '
        Me.BackBtn.BackColor = System.Drawing.Color.Transparent
        Me.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackBtn.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackBtn.Image = CType(resources.GetObject("BackBtn.Image"), System.Drawing.Image)
        Me.BackBtn.Location = New System.Drawing.Point(969, 515)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(206, 91)
        Me.BackBtn.TabIndex = 50
        Me.BackBtn.UseVisualStyleBackColor = False
        '
        'SearchCustomerBtn
        '
        Me.SearchCustomerBtn.BackColor = System.Drawing.Color.Transparent
        Me.SearchCustomerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SearchCustomerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchCustomerBtn.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchCustomerBtn.Image = CType(resources.GetObject("SearchCustomerBtn.Image"), System.Drawing.Image)
        Me.SearchCustomerBtn.Location = New System.Drawing.Point(180, 495)
        Me.SearchCustomerBtn.Name = "SearchCustomerBtn"
        Me.SearchCustomerBtn.Size = New System.Drawing.Size(206, 86)
        Me.SearchCustomerBtn.TabIndex = 51
        Me.SearchCustomerBtn.UseVisualStyleBackColor = false
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"),System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 223)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(200, 44)
        Me.PictureBox2.TabIndex = 52
        Me.PictureBox2.TabStop = false
        '
        'CustomerIDTxtBx
        '
        Me.CustomerIDTxtBx.BackColor = System.Drawing.Color.Lavender
        Me.CustomerIDTxtBx.Font = New System.Drawing.Font("Microsoft Sans Serif", 24!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.CustomerIDTxtBx.Location = New System.Drawing.Point(238, 223)
        Me.CustomerIDTxtBx.Name = "CustomerIDTxtBx"
        Me.CustomerIDTxtBx.Size = New System.Drawing.Size(278, 44)
        Me.CustomerIDTxtBx.TabIndex = 53
        '
        'SimpleCustomerSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProjectCode.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(1187, 618)
        Me.ControlBox = false
        Me.Controls.Add(Me.CustomerIDTxtBx)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.SearchCustomerBtn)
        Me.Controls.Add(Me.BackBtn)
        Me.Controls.Add(Me.CustomerDgv)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox8)
        Me.Name = "SimpleCustomerSearch"
        Me.Text = "SimpleCustomerSearch"
        CType(Me.PictureBox8,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox4,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.CustomerDgv,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents CustomerDgv As DataGridView
    Friend WithEvents BackBtn As Button
    Friend WithEvents SearchCustomerBtn As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents CustomerIDTxtBx As TextBox
End Class
