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
        Me.PostalResult = New System.Windows.Forms.DataGridView()
        Me.WeightSearchBtn = New System.Windows.Forms.Button()
        Me.LengthSearchBtn = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DeliveryRadioButton = New System.Windows.Forms.RadioButton()
        Me.CentimetresRadioButton = New System.Windows.Forms.RadioButton()
        Me.WeightRadioButton = New System.Windows.Forms.RadioButton()
        CType(Me.PostalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FreelanceDatabaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PostalResult, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DeliveryTxtBx
        '
        Me.DeliveryTxtBx.BackColor = System.Drawing.Color.Lavender
        Me.DeliveryTxtBx.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeliveryTxtBx.Location = New System.Drawing.Point(271, 247)
        Me.DeliveryTxtBx.Name = "DeliveryTxtBx"
        Me.DeliveryTxtBx.Size = New System.Drawing.Size(278, 44)
        Me.DeliveryTxtBx.TabIndex = 15
        '
        'DimensionsTxtBx
        '
        Me.DimensionsTxtBx.BackColor = System.Drawing.Color.Lavender
        Me.DimensionsTxtBx.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DimensionsTxtBx.Location = New System.Drawing.Point(271, 320)
        Me.DimensionsTxtBx.Name = "DimensionsTxtBx"
        Me.DimensionsTxtBx.Size = New System.Drawing.Size(278, 44)
        Me.DimensionsTxtBx.TabIndex = 16
        '
        'WeightTxtBx
        '
        Me.WeightTxtBx.BackColor = System.Drawing.Color.Lavender
        Me.WeightTxtBx.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.DeliverySearchBtn.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeliverySearchBtn.Image = CType(resources.GetObject("DeliverySearchBtn.Image"), System.Drawing.Image)
        Me.DeliverySearchBtn.Location = New System.Drawing.Point(59, 496)
        Me.DeliverySearchBtn.Name = "DeliverySearchBtn"
        Me.DeliverySearchBtn.Size = New System.Drawing.Size(206, 82)
        Me.DeliverySearchBtn.TabIndex = 22
        Me.DeliverySearchBtn.UseVisualStyleBackColor = False
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
        Me.PostalTableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(45, 314)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(203, 50)
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(116, 386)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(132, 50)
        Me.PictureBox3.TabIndex = 29
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(12, 33)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(115, 50)
        Me.PictureBox4.TabIndex = 30
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(-4, -1)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(1196, 28)
        Me.PictureBox5.TabIndex = 31
        Me.PictureBox5.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(1061, 33)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(119, 101)
        Me.PictureBox8.TabIndex = 45
        Me.PictureBox8.TabStop = False
        '
        'PostalResult
        '
        Me.PostalResult.BackgroundColor = System.Drawing.Color.Lavender
        Me.PostalResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PostalResult.DefaultCellStyle = DataGridViewCellStyle1
        Me.PostalResult.GridColor = System.Drawing.Color.LavenderBlush
        Me.PostalResult.Location = New System.Drawing.Point(555, 206)
        Me.PostalResult.Name = "PostalResult"
        Me.PostalResult.Size = New System.Drawing.Size(625, 279)
        Me.PostalResult.TabIndex = 46
        '
        'WeightSearchBtn
        '
        Me.WeightSearchBtn.BackColor = System.Drawing.Color.Transparent
        Me.WeightSearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.WeightSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.WeightSearchBtn.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeightSearchBtn.Image = CType(resources.GetObject("WeightSearchBtn.Image"), System.Drawing.Image)
        Me.WeightSearchBtn.Location = New System.Drawing.Point(483, 491)
        Me.WeightSearchBtn.Name = "WeightSearchBtn"
        Me.WeightSearchBtn.Size = New System.Drawing.Size(206, 86)
        Me.WeightSearchBtn.TabIndex = 47
        Me.WeightSearchBtn.UseVisualStyleBackColor = False
        '
        'LengthSearchBtn
        '
        Me.LengthSearchBtn.BackColor = System.Drawing.Color.Transparent
        Me.LengthSearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LengthSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LengthSearchBtn.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LengthSearchBtn.Image = CType(resources.GetObject("LengthSearchBtn.Image"), System.Drawing.Image)
        Me.LengthSearchBtn.Location = New System.Drawing.Point(271, 496)
        Me.LengthSearchBtn.Name = "LengthSearchBtn"
        Me.LengthSearchBtn.Size = New System.Drawing.Size(206, 82)
        Me.LengthSearchBtn.TabIndex = 48
        Me.LengthSearchBtn.UseVisualStyleBackColor = False
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
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(969, 515)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(206, 91)
        Me.Button1.TabIndex = 49
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DeliveryRadioButton
        '
        Me.DeliveryRadioButton.AutoSize = True
        Me.DeliveryRadioButton.BackColor = System.Drawing.Color.Transparent
        Me.DeliveryRadioButton.BackgroundImage = Global.ProjectCode.My.Resources.Resources.background
        Me.DeliveryRadioButton.ForeColor = System.Drawing.Color.White
        Me.DeliveryRadioButton.Location = New System.Drawing.Point(254, 268)
        Me.DeliveryRadioButton.Name = "DeliveryRadioButton"
        Me.DeliveryRadioButton.Size = New System.Drawing.Size(14, 13)
        Me.DeliveryRadioButton.TabIndex = 51
        Me.DeliveryRadioButton.TabStop = True
        Me.DeliveryRadioButton.UseVisualStyleBackColor = False
        '
        'CentimetresRadioButton
        '
        Me.CentimetresRadioButton.AutoSize = True
        Me.CentimetresRadioButton.BackColor = System.Drawing.Color.Transparent
        Me.CentimetresRadioButton.Location = New System.Drawing.Point(254, 332)
        Me.CentimetresRadioButton.Name = "CentimetresRadioButton"
        Me.CentimetresRadioButton.Size = New System.Drawing.Size(14, 13)
        Me.CentimetresRadioButton.TabIndex = 52
        Me.CentimetresRadioButton.TabStop = True
        Me.CentimetresRadioButton.UseVisualStyleBackColor = False
        '
        'WeightRadioButton
        '
        Me.WeightRadioButton.AutoSize = True
        Me.WeightRadioButton.BackColor = System.Drawing.Color.Transparent
        Me.WeightRadioButton.Location = New System.Drawing.Point(254, 404)
        Me.WeightRadioButton.Name = "WeightRadioButton"
        Me.WeightRadioButton.Size = New System.Drawing.Size(14, 13)
        Me.WeightRadioButton.TabIndex = 53
        Me.WeightRadioButton.TabStop = True
        Me.WeightRadioButton.UseVisualStyleBackColor = False
        '
        'postal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.BackgroundImage = Global.ProjectCode.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(1187, 618)
        Me.ControlBox = False
        Me.Controls.Add(Me.WeightRadioButton)
        Me.Controls.Add(Me.CentimetresRadioButton)
        Me.Controls.Add(Me.DeliveryRadioButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LengthSearchBtn)
        Me.Controls.Add(Me.WeightSearchBtn)
        Me.Controls.Add(Me.PostalResult)
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
        CType(Me.PostalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FreelanceDatabaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PostalResult, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents PostalResult As DataGridView
    Friend WithEvents WeightSearchBtn As Button
    Friend WithEvents LengthSearchBtn As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DeliveryRadioButton As RadioButton
    Friend WithEvents CentimetresRadioButton As RadioButton
    Friend WithEvents WeightRadioButton As RadioButton
End Class
