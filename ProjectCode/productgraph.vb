'Imports System.Data.OleDb
'Imports System.Net.Mail
'Imports System.Windows.Forms.DataVisualization.Charting
'Public Class productgraph 
'    Private Sub productgraph_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        show_graph()
'    End Sub

'    Private Sub emailtoadminbtnBtn_Click(sender As Object, e As EventArgs) Handles EmailToAdminBtn.Click

'        Dim Bitmap As New Bitmap(Me.Width, me.Height)
'        Me.DrawToBitmap(Bitmap, New Rectangle(0, 0, Me.Width, Me.Height))
'        Bitmap.Save("C:\computingg1 (3)1\computingg1\computing coursework\ProjectCode\ProjectCode\bin\Debug\ProductsChart.png", Imaging.ImageFormat.Png)

'        Dim Smtp_server As New SmtpClient
'        Dim e_mail As New MailMessage()
'        Dim address As New MailAddress("enfeysmarket@outlook.com")

'        Smtp_server.UseDefaultCredentials = False
'        Smtp_server.Credentials = New Net.NetworkCredential("enfeysmarket@outlook.com", "Ycc87$Nucy4nai4")
'        Smtp_server.Port = 587
'        Smtp_server.EnableSsl = True
'        Smtp_server.Host = "smtp-mail.outlook.com"

'        e_mail.From = address
'        e_mail.To.Add("enfeysmarket@outlook.com")
'        e_mail.Subject = "Products Chart"
'        e_mail.Body = "This is the most recent product chart for Enfeys Market."
'        e_mail.Attachments.Add(New Attachment("C:\computingg1 (3)1\computingg1\computing coursework\ProjectCode\ProjectCode\bin\Debug\ProductsChart.png"))
'        e_mail.IsBodyHtml = False
'        Try
'            Smtp_server.Send(e_mail)
'            MessageBox.Show("Email Sent")
'        Catch ex As Exception
'            smtp_server.dispose()
'            MessageBox.Show("Error:" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        End Try
'    End Sub

'    Private Sub exit_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
'        Products.Show()
'        show_graph()
'        me.Hide()
'    End Sub
'    private sub show_graph()
'        Dim ds As New DataSet
'        Dim da As New OleDbDataAdapter
'        Dim chartarea As ChartArea = New ChartArea()
'        Dim chartseries As Series = New Series()
'        Dim legend As Legend = New Legend()
'        Dim chart As New Chart

'        dim sql as string = "SELECT ProductName, Quantity FROM Products ORDER BY QUANTITY"
'        da = New OleDbDataAdapter(sql, conn)
'        da.Fill(ds, "Product")

'        Me.Controls.Add(chart)
'        chartseries.ChartType = SeriesChartType.Doughnut
'        chartarea.Name = "chartarea"
'        chart.chartareas.add(chartarea)
'        legend.Name = "Legend"
'        chart.legends.add(legend)
'        chart.Location = New Point(13, 13)
'        chart.Name = "Inventory"
'        chart.titles.add("Inventory")
'        chartseries.Name = "Product"
'        chart.Series.Add(chartseries)
'        chart.Size = New Size(900, 620)
'        chart.BackImage = "C:\computingg1 (3)1\computingg1\computing coursework\ProjectCode\ProjectCode\Resources\background.png"


'        chart.Palette = ChartColorPalette.Berry
'        chart.BackColor = Color.Transparent
'        chart.BackSecondaryColor = Color.Transparent
'        chart.BackGradientStyle = GradientStyle.DiagonalLeft
'        chart.BorderlineColor = Color.Transparent
'        chart.BorderlineWidth = 0
'        chart.BorderlineDashStyle = ChartDashStyle.NotSet
'        chart.BorderSkin.PageColor = Color.Transparent
'        chart.BorderSkin.BackColor = Color.Transparent
'        chart.BorderSkin.BackSecondaryColor = Color.Transparent
'        chart.BorderSkin.BackGradientStyle = GradientStyle.DiagonalLeft
'        chart.BorderSkin.BorderColor = Color.Transparent
'        chart.BorderSkin.BorderWidth = 0
'        chart.BorderSkin.BorderDashStyle = ChartDashStyle.NotSet
'        chart.BackImageWrapMode = ChartImageWrapMode.Scaled
'        chart.BackImageAlignment = ChartImageAlignmentStyle.Center
'        chart.BackHatchStyle = ChartHatchStyle.Percent50
'        chart.ChartAreas(0).BackColor = Color.Transparent
'        chart.ChartAreas(0).BackSecondaryColor = Color.Transparent
'        chart.ChartAreas(0).BackGradientStyle = GradientStyle.DiagonalLeft
'        chart.ChartAreas(0).ShadowColor = Color.Transparent
'        chart.ChartAreas(0).ShadowOffset = 0
'        chart.ChartAreas(0).Area3DStyle.Enable3D = True
'        chart.ChartAreas(0).Area3DStyle.Inclination = 15
'        chart.ChartAreas(0).Area3DStyle.Perspective = 10
'        chart.ChartAreas(0).Area3DStyle.Rotation = 10
'        chart.ChartAreas(0).Area3DStyle.WallWidth = 0
'        chart.ChartAreas(0).Area3DStyle.IsRightAngleAxes = False
'        chart.ChartAreas(0).Area3DStyle.IsClustered = True
'        chart.ChartAreas(0).Area3DStyle.PointGapDepth = 0
'        chart.ChartAreas(0).Area3DStyle.LightStyle = LightStyle.Realistic
'        chart.ChartAreas(0).Area3DStyle.IsClustered = True
'        chart.ChartAreas(0).Area3DStyle.IsRightAngleAxes = False
'        chart.ChartAreas(0).Area3DStyle.PointGapDepth = 0
'        chart.ChartAreas(0).Area3DStyle.Rotation = 10
'        chart.ChartAreas(0).Area3DStyle.WallWidth = 0
'        chart.ChartAreas(0).AxisX.LabelStyle.Font = New Font("Arial", 10, FontStyle.Bold)
'        chart.ChartAreas(0).AxisY.LabelStyle.Font = New Font("Arial", 10, FontStyle.Bold)
'        chart.ChartAreas(0).AxisX.LabelStyle.ForeColor = Color.White
'        chart.ChartAreas(0).AxisY.LabelStyle.ForeColor = Color.White
'        chart.ChartAreas(0).AxisX.LineColor = Color.White
'        chart.ChartAreas(0).AxisY.LineColor = Color.White
'        chart.ChartAreas(0).AxisX.MajorGrid.LineColor = Color.White
'        chart.ChartAreas(0).AxisY.MajorGrid.LineColor = Color.White
'        chart.ChartAreas(0).AxisX.MajorTickMark.LineColor = Color.White
'        chart.ChartAreas(0).AxisY.MajorTickMark.LineColor = Color.White
'        chart.ChartAreas(0).AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash
'        chart.ChartAreas(0).AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash
'        chart.ChartAreas(0).AxisX.MajorTickMark.LineDashStyle = ChartDashStyle.Dash
'        chart.ChartAreas(0).AxisY.MajorTickMark.LineDashStyle = ChartDashStyle.Dash
'        chart.ChartAreas(0).AxisX.MajorGrid.LineWidth = 1
'        chart.ChartAreas(0).AxisY.MajorGrid.LineWidth = 1
'        chart.ChartAreas(0).AxisX.MajorTickMark.LineWidth = 1
'        chart.ChartAreas(0).AxisY.MajorTickMark.LineWidth = 1
'        chart.ChartAreas(0).AxisX.MajorGrid.Enabled = True
'        chart.ChartAreas(0).AxisY.MajorGrid.Enabled = True
'        chart.ChartAreas(0).AxisX.MajorTickMark.Enabled = True
'        chart.ChartAreas(0).AxisY.MajorTickMark.Enabled = True


'        For i As Integer = 0 To ds.Tables("Product").Rows.Count - 1
'            chartseries.Points.AddXY(ds.Tables("Product").Rows(i).Item(0), ds.Tables("Product").Rows(i).Item(1))
'        Next
'    End sub
'End Class