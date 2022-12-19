Imports System.Data.OleDb
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Net.Mail

Public Class productgraph

    Dim con As New OleDbConnection("Provider=microsoft.ACE.OLEDB.12.0;Data Source=C:\computingg1 (3)\computingg1\computing coursework\ProjectCode\freelancedatabase.accdb")
    Dim ds As New DataSet
    Dim da As New OleDbDataAdapter
    Dim chartarea As ChartArea = New ChartArea()
    Dim chartseries As Series = New Series()
    Dim legend As Legend = New Legend()
    Dim chart As New Chart


    Private Sub productgraph_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String
        sql = "SELECT ProductName, Quantity FROM Products ORDER BY QUANTITY"
        da = New OleDbDataAdapter(sql, con)
        da.Fill(ds, "Product")

        Me.Controls.Add(chart)
        chartseries.ChartType = SeriesChartType.Doughnut
        chartarea.Name = "chartarea"
        chart.chartareas.add(chartarea)
        legend.Name = "Legend"
        chart.legends.add(legend)
        chart.Location = New Point(13, 13)
        chart.Name = "Inventory"
        chart.titles.add("Inventory")
        chartseries.Name = "Product"
        chart.Series.Add(chartseries)
        chart.Size = New Size(900, 620)
        chart.BackImage = "C:\computingg1 (3)\computingg1\computing coursework\ProjectCode\ProjectCode\Resources\background.png"


        chart.Palette = ChartColorPalette.Berry
        chart.BackColor = Color.Transparent
        chart.BackSecondaryColor = Color.Transparent
        chart.BackGradientStyle = GradientStyle.DiagonalLeft
        chart.BorderlineColor = Color.Transparent
        chart.BorderlineWidth = 0
        chart.BorderlineDashStyle = ChartDashStyle.NotSet
        chart.BorderSkin.PageColor = Color.Transparent
        chart.BorderSkin.BackColor = Color.Transparent
        chart.BorderSkin.BackSecondaryColor = Color.Transparent
        chart.BorderSkin.BackGradientStyle = GradientStyle.DiagonalLeft
        chart.BorderSkin.BorderColor = Color.Transparent
        chart.BorderSkin.BorderWidth = 0
        chart.BorderSkin.BorderDashStyle = ChartDashStyle.NotSet
        chart.BackImageWrapMode = ChartImageWrapMode.Scaled
        chart.BackImageAlignment = ChartImageAlignmentStyle.Center
        chart.BackHatchStyle = ChartHatchStyle.Percent50
        chart.ChartAreas(0).BackColor = Color.Transparent
        chart.ChartAreas(0).BackSecondaryColor = Color.Transparent
        chart.ChartAreas(0).BackGradientStyle = GradientStyle.DiagonalLeft
        chart.ChartAreas(0).ShadowColor = Color.Transparent
        chart.ChartAreas(0).ShadowOffset = 0
        chart.ChartAreas(0).Area3DStyle.Enable3D = True
        chart.ChartAreas(0).Area3DStyle.Inclination = 15
        chart.ChartAreas(0).Area3DStyle.Perspective = 10
        chart.ChartAreas(0).Area3DStyle.Rotation = 10
        chart.ChartAreas(0).Area3DStyle.WallWidth = 0
        chart.ChartAreas(0).Area3DStyle.IsRightAngleAxes = False
        chart.ChartAreas(0).Area3DStyle.IsClustered = True
        chart.ChartAreas(0).Area3DStyle.PointGapDepth = 0
        chart.ChartAreas(0).Area3DStyle.LightStyle = LightStyle.Realistic
        chart.ChartAreas(0).Area3DStyle.IsClustered = True

        For i As Integer = 0 To ds.Tables("Product").Rows.Count - 1
            chartseries.Points.AddXY(ds.Tables("Product").Rows(i).Item(0), ds.Tables("Product").Rows(i).Item(1))
        Next

    End Sub

    Private Sub emailtoadminbtnBtn_Click(sender As Object, e As EventArgs) Handles EmailToAdminBtn.Click

        Dim Bitmap As New Bitmap(Me.Width, Me.Height)
        Me.DrawToBitmap(Bitmap, New Rectangle(0, 0, Me.Width, Me.Height))
        Bitmap.Save("C:\computingg1 (3)\computingg1\computing coursework\ProjectCode\ProjectCode\bin\Debug\ProductsChart.png", Imaging.ImageFormat.Png)
        'Bitmap.Save(Application.StartupPath & "ProductsChart.png", Imaging.ImageFormat.Png)


        Dim Smtp_server As New SmtpClient
        Dim e_mail As New MailMessage()
        Dim address As New MailAddress("enfeysmarket@outlook.com")

        Smtp_server.UseDefaultCredentials = False
        Smtp_server.Credentials = New Net.NetworkCredential("enfeysmarket@outlook.com", "Ycc87$Nucy4nai4")
        Smtp_server.Port = 587
        Smtp_server.EnableSsl = True
        Smtp_server.Host = "smtp-mail.outlook.com"

        e_mail.From = address
        e_mail.To.Add("enfeysmarket@outlook.com")
        e_mail.Subject = "Products Chart"
        e_mail.Body = "This is the most recent product chart for Enfeys Market."
        e_mail.Attachments.Add(New Attachment("C:\computingg1 (3)\computingg1\computing coursework\ProjectCode\ProjectCode\bin\Debug\ProductsChart.png"))
        e_mail.IsBodyHtml = False
        Smtp_server.Send(e_mail)
        MessageBox.Show("Email Sent")

    End Sub

    Private Sub exit_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Products.Show()
        Hide()
    End Sub
End Class