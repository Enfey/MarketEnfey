<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class postal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(postal))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DeliveryTxtBx = New System.Windows.Forms.TextBox()
        Me.DimensionsTxtBx = New System.Windows.Forms.TextBox()
        Me.WeightTxtBx = New System.Windows.Forms.TextBox()
        Me.DeliverySearchBtn = New System.Windows.Forms.Button()
        Me.PostalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FreelanceDatabaseDataSet1 = New ProjectCode.FreelanceDatabaseDataSet1()
        Me.PostalTableAdapter = New ProjectCode.FreelanceDatabaseDataSet1TableAdapters.PostalTableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PostalDgv = New System.Windows.Forms.DataGridView()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.RefreshBtn = New System.Windows.Forms.Button()
        CType(Me.PostalBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.FreelanceDatabaseDataSet1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox4,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox5,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox8,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PostalDgv,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'DeliveryTxtBx
        '
        Me.DeliveryTxtBx.BackColor = System.Drawing.Color.Lavender
        Me.DeliveryTxtBx.Font = New System.Drawing.Font("Microsoft Sans Serif", 24!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.DeliveryTxtBx.Location = New System.Drawing.Point(271, 247)
        Me.DeliveryTxtBx.Name = "DeliveryTxtBx"
        Me.DeliveryTxtBx.Size = New System.Drawing.Size(278, 44)
        Me.DeliveryTxtBx.TabIndex = 15
        '
        'DimensionsTxtBx
        '
        Me.DimensionsTxtBx.BackColor = System.Drawing.Color.Lavender
        Me.DimensionsTxtBx.Font = New System.Drawing.Font("Microsoft Sans Serif", 24!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.DimensionsTxtBx.Location = New System.Drawing.Point(271, 320)
        Me.DimensionsTxtBx.Name = "DimensionsTxtBx"
        Me.DimensionsTxtBx.Size = New System.Drawing.Size(278, 44)
        Me.DimensionsTxtBx.TabIndex = 16
        '
        'WeightTxtBx
        '
        Me.WeightTxtBx.BackColor = System.Drawing.Color.Lavender
        Me.WeightTxtBx.Font = New System.Drawing.Font("Microsoft Sans Serif", 24!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.WeightTxtBx.Location = New System.Drawing.Point(271, 392)
        Me.WeightTxtBx.Name = "WeightTxtBx"
        Me.WeightTxtBx.Size = New System.Drawing.Size(278, 44)
        Me.WeightTxtBx.TabIndex = 17
        '
        'DeliverySearchBtn
        '
        Me.DeliverySearchBtn.BackColor = System.Drawing.Color.Transparent
        Me.DeliverySearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.DeliverySearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeliverySearchBtn.Font = New System.Drawing.Font("Sitka Heading", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.DeliverySearchBtn.Image = CType(resources.GetObject("DeliverySearchBtn.Image"),System.Drawing.Image)
        Me.DeliverySearchBtn.Location = New System.Drawing.Point(301, 493)
        Me.DeliverySearchBtn.Name = "DeliverySearchBtn"
        Me.DeliverySearchBtn.Size = New System.Drawing.Size(206, 82)
        Me.DeliverySearchBtn.TabIndex = 22
        Me.DeliverySearchBtn.UseVisualStyleBackColor = false
        '
        'PostalBindingSource
        '
        Me.PostalBindingSource.DataMember = "Postal"
        Me.PostalBindingSource.DataSource = Me.FreelanceDatabaseDataSet1
        '
        'FreelanceDatabaseDataSet1
        '
        Me.FreelanceDatabaseDataSet1.DataSetName = "FreelanceDatabaseDataSet1"
        Me.FreelanceDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PostalTableAdapter
        '
        Me.PostalTableAdapter.ClearBeforeFill = true
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"),System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(45, 314)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(203, 50)
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = false
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"),System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(116, 386)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(132, 50)
        Me.PictureBox3.TabIndex = 29
        Me.PictureBox3.TabStop = false
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"),System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(12, 33)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(115, 50)
        Me.PictureBox4.TabIndex = 30
        Me.PictureBox4.TabStop = false
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"),System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(-4, -1)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(1196, 28)
        Me.PictureBox5.TabIndex = 31
        Me.PictureBox5.TabStop = false
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"),System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(1061, 33)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(119, 101)
        Me.PictureBox8.TabIndex = 45
        Me.PictureBox8.TabStop = False
        '
        'PostalDgv
        '
        Me.PostalDgv.AllowUserToAddRows = False
        Me.PostalDgv.AllowUserToDeleteRows = False
        Me.PostalDgv.AllowUserToResizeColumns = False
        Me.PostalDgv.AllowUserToResizeRows = False
        Me.PostalDgv.BackgroundColor = System.Drawing.Color.Lavender
        Me.PostalDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PostalDgv.DefaultCellStyle = DataGridViewCellStyle1
        Me.PostalDgv.GridColor = System.Drawing.Color.LavenderBlush
        Me.PostalDgv.Location = New System.Drawing.Point(555, 206)
        Me.PostalDgv.Name = "PostalDgv"
        Me.PostalDgv.ReadOnly = True
        Me.PostalDgv.Size = New System.Drawing.Size(625, 279)
        Me.PostalDgv.TabIndex = 46
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 247)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(236, 44)
        Me.PictureBox2.TabIndex = 27
        Me.PictureBox2.TabStop = False
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
        Me.BackBtn.TabIndex = 49
        Me.BackBtn.UseVisualStyleBackColor = False
        '
        'RefreshBtn
        '
        Me.RefreshBtn.BackColor = System.Drawing.Color.Transparent
        Me.RefreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RefreshBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RefreshBtn.FlatAppearance.BorderSize = 0
        Me.RefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RefreshBtn.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefreshBtn.Image = CType(resources.GetObject("RefreshBtn.Image"), System.Drawing.Image)
        Me.RefreshBtn.Location = New System.Drawing.Point(737, 510)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.Size = New System.Drawing.Size(82, 48)
        Me.RefreshBtn.TabIndex = 74
        Me.RefreshBtn.UseVisualStyleBackColor = false
        '
        'postal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.BackgroundImage = Global.ProjectCode.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(1187, 618)
        Me.ControlBox = false
        Me.Controls.Add(Me.RefreshBtn)
        Me.Controls.Add(Me.BackBtn)
        Me.Controls.Add(Me.PostalDgv)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.DeliverySearchBtn)
        Me.Controls.Add(Me.WeightTxtBx)
        Me.Controls.Add(Me.DimensionsTxtBx)
        Me.Controls.Add(Me.DeliveryTxtBx)
        Me.Name = "postal"
        Me.Text = "Enfey's Market Management System"
        CType(Me.PostalBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.FreelanceDatabaseDataSet1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox4,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox5,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox8,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PostalDgv,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents DeliveryTxtBx As TextBox
    Friend WithEvents DimensionsTxtBx As TextBox
    Friend WithEvents WeightTxtBx As TextBox
    Friend WithEvents DeliverySearchBtn As Button
    Friend WithEvents FreelanceDatabaseDataSet1 As FreelanceDatabaseDataSet1
    Friend WithEvents PostalBindingSource As BindingSource
    Friend WithEvents PostalTableAdapter As FreelanceDatabaseDataSet1TableAdapters.PostalTableAdapter
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PostalDgv As DataGridView
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BackBtn As Button
    Friend WithEvents RefreshBtn As Button
End Class
