Imports iTextSharp.text.pdf.draw
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports Newtonsoft.Json
Imports System.IO

Public Class Form1
    Dim jsonRead As String = "C:\Users\User\Documents\5th Year\2ND SEM\ELECTIVE 3\A4_PDF RESUME CREATOR\PDF RESUME CREATOR\PDF RESUME CREATOR\My Resume.json"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnGenerateResume_Click(sender As Object, e As EventArgs) Handles btnGenerateResume.Click
        Dim Gen As DialogResult = MessageBox.Show("Confirm if you want to Generate your Resume", "Resume Generator", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If Gen = DialogResult.OK Then
            Dim jsonPath As String = "C:\Users\User\Documents\5th Year\2ND SEM\ELECTIVE 3\A4_PDF RESUME CREATOR\PDF RESUME CREATOR\PDF RESUME CREATOR\My Resume.json"
            Dim jsonFile As String = File.ReadAllText(jsonPath)
            Dim Result As Result = JsonConvert.DeserializeObject(Of Result)(jsonFile)
            Dim GenRes As Document = New Document()
            PdfWriter.GetInstance(GenRes, New FileStream("C:\Users\User\Documents\5th Year\2ND SEM\ELECTIVE 3\A4_PDF RESUME CREATOR\PDF RESUME CREATOR\PDF RESUME CREATOR\CALILUNG, Kristal L..pdf", FileMode.Create))

            Dim Sep As LineSeparator = New LineSeparator(3.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_CENTER, 1)
            Dim Ret As New Paragraph(" ")

            Dim Font1 As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 20, iTextSharp.text.Font.BOLD)
            Dim Font2 As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 14, iTextSharp.text.Font.BOLD)
            Dim Font3 As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 12, iTextSharp.text.Font.NORMAL)

            Dim Image As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(Result.Image)
            Image.ScalePercent(7.0F)
            Image.SetAbsolutePosition(GenRes.PageSize.Width - 30.0F - 150.0F, GenRes.PageSize.Height - 30.0F - 120.0F)

            Dim Name As New Paragraph(Result.FullName & vbLf, Font1)
            Dim Prof As New Paragraph(Result.Profession & vbLf, Font3)
            Dim Phone As New Paragraph(Result.Phone & vbLf, Font3)
            Dim Email As New Paragraph(Result.Email & vbLf, Font3)
            Dim H1 As New Paragraph(Result.Header1 & vbLf, Font2)
            Dim Quali As New Paragraph(Result.Qualifications & vbLf, Font3)
            Dim H2 As New Paragraph(Result.Header2 & vbLf, Font2)
            Dim Pos As New Paragraph(Result.Position & vbLf, Font3)
            Dim Com As New Paragraph(Result.Company & vbLf, Font3)
            Dim Job As New Paragraph(Result.JobDescription & vbLf, Font3)
            Dim H3 As New Paragraph(Result.Header3 & vbLf, Font2)
            Dim S1 As New Paragraph(Result.Skill1 & vbLf, Font3)
            Dim S2 As New Paragraph(Result.Skill2 & vbLf, Font3)
            Dim S3 As New Paragraph(Result.Skill3 & vbLf, Font3)
            Dim S4 As New Paragraph(Result.Skill4 & vbLf, Font3)
            Dim H4 As New Paragraph(Result.Header4 & vbLf, Font2)
            Dim Course As New Paragraph(Result.Course & vbLf, Font3)
            Dim School As New Paragraph(Result.School & vbLf, Font3)
            Dim Year As New Paragraph(Result.Year & vbLf, Font3)

            Name.Alignment = Element.ALIGN_JUSTIFIED
            Prof.Alignment = Element.ALIGN_JUSTIFIED
            Phone.Alignment = Element.ALIGN_JUSTIFIED
            Email.Alignment = Element.ALIGN_JUSTIFIED
            H1.Alignment = Element.ALIGN_JUSTIFIED
            Quali.Alignment = Element.ALIGN_JUSTIFIED
            H2.Alignment = Element.ALIGN_JUSTIFIED
            Pos.Alignment = Element.ALIGN_JUSTIFIED
            com.Alignment = Element.ALIGN_JUSTIFIED
            Job.Alignment = Element.ALIGN_JUSTIFIED
            H3.Alignment = Element.ALIGN_JUSTIFIED
            S1.Alignment = Element.ALIGN_JUSTIFIED
            S2.Alignment = Element.ALIGN_JUSTIFIED
            S3.Alignment = Element.ALIGN_JUSTIFIED
            S4.Alignment = Element.ALIGN_JUSTIFIED
            H4.Alignment = Element.ALIGN_JUSTIFIED
            Course.Alignment = Element.ALIGN_JUSTIFIED
            School.Alignment = Element.ALIGN_JUSTIFIED
            Year.Alignment = Element.ALIGN_JUSTIFIED

            GenRes.Open()
            GenRes.Add(Image)
            GenRes.Add(Name)
            GenRes.Add(Prof)
            GenRes.Add(Phone)
            GenRes.Add(Email)
            GenRes.Add(Ret)
            GenRes.Add(Ret)
            GenRes.Add(Sep)
            GenRes.Add(Ret)
            GenRes.Add(H1)
            GenRes.Add(Ret)
            GenRes.Add(Quali)
            GenRes.Add(Ret)
            GenRes.Add(Ret)
            GenRes.Add(Sep)
            GenRes.Add(Ret)
            GenRes.Add(H2)
            GenRes.Add(Ret)
            GenRes.Add(Pos)
            GenRes.Add(com)
            GenRes.Add(Job)
            GenRes.Add(Ret)
            GenRes.Add(Ret)
            GenRes.Add(Sep)
            GenRes.Add(Ret)
            GenRes.Add(H3)
            GenRes.Add(Ret)
            GenRes.Add(S1)
            GenRes.Add(S2)
            GenRes.Add(S3)
            GenRes.Add(S4)
            GenRes.Add(Ret)
            GenRes.Add(Ret)
            GenRes.Add(Sep)
            GenRes.Add(Ret)
            GenRes.Add(H4)
            GenRes.Add(Ret)
            GenRes.Add(Course)
            GenRes.Add(School)
            GenRes.Add(Year)
            GenRes.Close()
            RichTextBoxDisplay.Text = " "
            MessageBox.Show("Successfully created Resume!", "Resume Generator")
        End If

    End Sub

    Public Class Result
        Public Property Image As String
        Public Property FullName As String
        Public Property Profession As String
        Public Property Phone As String
        Public Property Email As String
        Public Property Header1 As String
        Public Property Qualifications As String
        Public Property Header2 As String
        Public Property Position As String
        Public Property Company As String
        Public Property JobDescription As String
        Public Property Header3 As String
        Public Property Skill1 As String
        Public Property Skill2 As String
        Public Property Skill3 As String
        Public Property Skill4 As String
        Public Property Header4 As String
        Public Property Course As String
        Public Property School As String
        Public Property Year As String
    End Class

    Private Sub btnLoadJson_Click(sender As Object, e As EventArgs) Handles btnLoadJson.Click
        Dim Load As DialogResult = MessageBox.Show("Confirm if you want to load JSON File", "Resume Generator", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If Load = DialogResult.OK Then
            RichTextBoxDisplay.Text = File.ReadAllText(jsonRead)
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim checkExit As DialogResult = MessageBox.Show("Confirm if you want to exit", "Resume Generator", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If checkExit = DialogResult.OK Then
            Application.Exit()
        End If
    End Sub
End Class
