<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OrderSearch

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrderSearch))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CustomerIDTxtBx = New System.Windows.Forms.TextBox()
        Me.SearchCustomerIDBtn = New System.Windows.Forms.Button()
        Me.PostalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FreelanceDatabaseDataSet1 = New ProjectCode.FreelanceDatabaseDataSet1()
        Me.PostalTableAdapter = New ProjectCode.FreelanceDatabaseDataSet1TableAdapters.PostalTableAdapter()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PostalResult = New System.Windows.Forms.DataGridView()
        Me.DateOrderBtn = New System.Windows.Forms.Button()
        Me.DateSearchBtn = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.DateSearchTxtBx = New System.Windows.Forms.TextBox()
        Me.OrderComboBox = New System.Windows.Forms.ComboBox()
        Me.DateSearchRadioButton = New System.Windows.Forms.RadioButton()
        Me.CustomerRadioButton = New System.Windows.Forms.RadioButton()
        Me.SearchAndSortBtn = New System.Windows.Forms.Button()
        Me.RefreshBtn = New System.Windows.Forms.Button()
        Me.enablecomplexsearchbtn = New System.Windows.Forms.Button()
        Me.DisableComplexSearchBtn = New System.Windows.Forms.Button()
        CType(Me.PostalBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.FreelanceDatabaseDataSet1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox4,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox5,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox8,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PostalResult,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'CustomerIDTxtBx
        '
        Me.CustomerIDTxtBx.BackColor = System.Drawing.Color.Lavender
        Me.CustomerIDTxtBx.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerIDTxtBx.Location = New System.Drawing.Point(271, 247)
        Me.CustomerIDTxtBx.Name = "CustomerIDTxtBx"
        Me.CustomerIDTxtBx.Size = New System.Drawing.Size(278, 44)
        Me.CustomerIDTxtBx.TabIndex = 15
        '
        'SearchCustomerIDBtn
        '
        Me.SearchCustomerIDBtn.BackColor = System.Drawing.Color.Transparent
        Me.SearchCustomerIDBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SearchCustomerIDBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchCustomerIDBtn.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchCustomerIDBtn.Image = CType(resources.GetObject("SearchCustomerIDBtn.Image"), System.Drawing.Image)
        Me.SearchCustomerIDBtn.Location = New System.Drawing.Point(59, 491)
        Me.SearchCustomerIDBtn.Name = "SearchCustomerIDBtn"
        Me.SearchCustomerIDBtn.Size = New System.Drawing.Size(206, 82)
        Me.SearchCustomerIDBtn.TabIndex = 22
        Me.SearchCustomerIDBtn.UseVisualStyleBackColor = False
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
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImage = Global.ProjectCode.My.Resources.Resources.background
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(12, 33)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(215, 44)
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
        Me.PostalResult.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.PostalResult.GridColor = System.Drawing.Color.LavenderBlush
        Me.PostalResult.Location = New System.Drawing.Point(555, 197)
        Me.PostalResult.Name = "PostalResult"
        Me.PostalResult.Size = New System.Drawing.Size(625, 279)
        Me.PostalResult.TabIndex = 46
        '
        'DateOrderBtn
        '
        Me.DateOrderBtn.BackColor = System.Drawing.Color.Transparent
        Me.DateOrderBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.DateOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DateOrderBtn.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateOrderBtn.Image = CType(resources.GetObject("DateOrderBtn.Image"), System.Drawing.Image)
        Me.DateOrderBtn.Location = New System.Drawing.Point(483, 487)
        Me.DateOrderBtn.Name = "DateOrderBtn"
        Me.DateOrderBtn.Size = New System.Drawing.Size(206, 91)
        Me.DateOrderBtn.TabIndex = 47
        Me.DateOrderBtn.UseVisualStyleBackColor = False
        '
        'DateSearchBtn
        '
        Me.DateSearchBtn.BackColor = System.Drawing.Color.Transparent
        Me.DateSearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.DateSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DateSearchBtn.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateSearchBtn.Image = CType(resources.GetObject("DateSearchBtn.Image"), System.Drawing.Image)
        Me.DateSearchBtn.Location = New System.Drawing.Point(271, 491)
        Me.DateSearchBtn.Name = "DateSearchBtn"
        Me.DateSearchBtn.Size = New System.Drawing.Size(206, 82)
        Me.DateSearchBtn.TabIndex = 48
        Me.DateSearchBtn.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(15, 392)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(233, 50)
        Me.PictureBox3.TabIndex = 29
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(167, 320)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(81, 50)
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(50, 247)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(198, 44)
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
        Me.BackBtn.TabIndex = 50
        Me.BackBtn.UseVisualStyleBackColor = False
        '
        'DateSearchTxtBx
        '
        Me.DateSearchTxtBx.BackColor = System.Drawing.Color.Lavender
        Me.DateSearchTxtBx.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateSearchTxtBx.Location = New System.Drawing.Point(271, 320)
        Me.DateSearchTxtBx.Name = "DateSearchTxtBx"
        Me.DateSearchTxtBx.Size = New System.Drawing.Size(278, 44)
        Me.DateSearchTxtBx.TabIndex = 51
        '
        'OrderComboBox
        '
        Me.OrderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.OrderComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderComboBox.FormattingEnabled = True
        Me.OrderComboBox.Items.AddRange(New Object() {"Ascending Order", "Descending Order"})
        Me.OrderComboBox.Location = New System.Drawing.Point(270, 397)
        Me.OrderComboBox.Name = "OrderComboBox"
        Me.OrderComboBox.Size = New System.Drawing.Size(279, 45)
        Me.OrderComboBox.TabIndex = 52
        '
        'DateSearchRadioButton
        '
        Me.DateSearchRadioButton.AutoSize = True
        Me.DateSearchRadioButton.BackColor = System.Drawing.Color.Transparent
        Me.DateSearchRadioButton.BackgroundImage = Global.ProjectCode.My.Resources.Resources.background
        Me.DateSearchRadioButton.ForeColor = System.Drawing.Color.White
        Me.DateSearchRadioButton.Location = New System.Drawing.Point(254, 341)
        Me.DateSearchRadioButton.Name = "DateSearchRadioButton"
        Me.DateSearchRadioButton.Size = New System.Drawing.Size(14, 13)
        Me.DateSearchRadioButton.TabIndex = 54
        Me.DateSearchRadioButton.TabStop = True
        Me.DateSearchRadioButton.UseVisualStyleBackColor = False
        '
        'CustomerRadioButton
        '
        Me.CustomerRadioButton.AutoSize = True
        Me.CustomerRadioButton.BackColor = System.Drawing.Color.Transparent
        Me.CustomerRadioButton.BackgroundImage = Global.ProjectCode.My.Resources.Resources.background
        Me.CustomerRadioButton.ForeColor = System.Drawing.Color.White
        Me.CustomerRadioButton.Location = New System.Drawing.Point(254, 268)
        Me.CustomerRadioButton.Name = "CustomerRadioButton"
        Me.CustomerRadioButton.Size = New System.Drawing.Size(14, 13)
        Me.CustomerRadioButton.TabIndex = 55
        Me.CustomerRadioButton.TabStop = True
        Me.CustomerRadioButton.UseVisualStyleBackColor = False
        '
        'SearchAndSortBtn
        '
        Me.SearchAndSortBtn.BackColor = System.Drawing.Color.Transparent
        Me.SearchAndSortBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SearchAndSortBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchAndSortBtn.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchAndSortBtn.Image = CType(resources.GetObject("SearchAndSortBtn.Image"), System.Drawing.Image)
        Me.SearchAndSortBtn.Location = New System.Drawing.Point(271, 491)
        Me.SearchAndSortBtn.Name = "SearchAndSortBtn"
        Me.SearchAndSortBtn.Size = New System.Drawing.Size(206, 82)
        Me.SearchAndSortBtn.TabIndex = 56
        Me.SearchAndSortBtn.UseVisualStyleBackColor = False
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
        Me.RefreshBtn.Location = New System.Drawing.Point(751, 487)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.Size = New System.Drawing.Size(82, 48)
        Me.RefreshBtn.TabIndex = 73
        Me.RefreshBtn.UseVisualStyleBackColor = False
        '
        'enablecomplexsearchbtn
        '
        Me.enablecomplexsearchbtn.BackColor = System.Drawing.Color.Transparent
        Me.enablecomplexsearchbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.enablecomplexsearchbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.enablecomplexsearchbtn.FlatAppearance.BorderSize = 0
        Me.enablecomplexsearchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.enablecomplexsearchbtn.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enablecomplexsearchbtn.Image = CType(resources.GetObject("enablecomplexsearchbtn.Image"), System.Drawing.Image)
        Me.enablecomplexsearchbtn.Location = New System.Drawing.Point(751, 536)
        Me.enablecomplexsearchbtn.Name = "enablecomplexsearchbtn"
        Me.enablecomplexsearchbtn.Size = New System.Drawing.Size(82, 48)
        Me.enablecomplexsearchbtn.TabIndex = 74
        Me.enablecomplexsearchbtn.UseVisualStyleBackColor = False
        '
        'DisableComplexSearchBtn
        '
        Me.DisableComplexSearchBtn.BackColor = System.Drawing.Color.Transparent
        Me.DisableComplexSearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.DisableComplexSearchBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DisableComplexSearchBtn.FlatAppearance.BorderSize = 0
        Me.DisableComplexSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DisableComplexSearchBtn.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisableComplexSearchBtn.Image = CType(resources.GetObject("DisableComplexSearchBtn.Image"), System.Drawing.Image)
        Me.DisableComplexSearchBtn.Location = New System.Drawing.Point(751, 536)
        Me.DisableComplexSearchBtn.Name = "DisableComplexSearchBtn"
        Me.DisableComplexSearchBtn.Size = New System.Drawing.Size(82, 48)
        Me.DisableComplexSearchBtn.TabIndex = 75
        Me.DisableComplexSearchBtn.UseVisualStyleBackColor = false
        '
        'OrderSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.BackgroundImage = Global.ProjectCode.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(1187, 618)
        Me.ControlBox = false
        Me.Controls.Add(Me.DisableComplexSearchBtn)
        Me.Controls.Add(Me.enablecomplexsearchbtn)
        Me.Controls.Add(Me.RefreshBtn)
        Me.Controls.Add(Me.SearchAndSortBtn)
        Me.Controls.Add(Me.CustomerRadioButton)
        Me.Controls.Add(Me.DateSearchRadioButton)
        Me.Controls.Add(Me.OrderComboBox)
        Me.Controls.Add(Me.DateSearchTxtBx)
        Me.Controls.Add(Me.BackBtn)
        Me.Controls.Add(Me.DateSearchBtn)
        Me.Controls.Add(Me.DateOrderBtn)
        Me.Controls.Add(Me.PostalResult)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.SearchCustomerIDBtn)
        Me.Controls.Add(Me.CustomerIDTxtBx)
        Me.Name = "OrderSearch"
        Me.Text = "Enfey's Market Management System"
        CType(Me.PostalBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.FreelanceDatabaseDataSet1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox4,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox5,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox8,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PostalResult,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents CustomerIDTxtBx As TextBox
    Friend WithEvents SearchCustomerIDBtn As Button
    Friend WithEvents FreelanceDatabaseDataSet1 As FreelanceDatabaseDataSet1
    Friend WithEvents PostalBindingSource As BindingSource
    Friend WithEvents PostalTableAdapter As FreelanceDatabaseDataSet1TableAdapters.PostalTableAdapter
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PostalResult As DataGridView
    Friend WithEvents DateOrderBtn As Button
    Friend WithEvents DateSearchBtn As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BackBtn As Button
    Friend WithEvents DateSearchTxtBx As TextBox
    Friend WithEvents OrderComboBox As ComboBox
    Friend WithEvents DateSearchRadioButton As RadioButton
    Friend WithEvents CustomerRadioButton As RadioButton
    Friend WithEvents SearchAndSortBtn As Button
    Friend WithEvents RefreshBtn As Button
    Friend WithEvents enablecomplexsearchbtn As Button
    Friend WithEvents DisableComplexSearchBtn As Button
End Class
