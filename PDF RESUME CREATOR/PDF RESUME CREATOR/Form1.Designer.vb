<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Roundpb = New PDF_RESUME_CREATOR.RoundPictureBox()
        Me.btnUploadPhoto = New System.Windows.Forms.Button()
        Me.textBoxName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblProfession = New System.Windows.Forms.Label()
        Me.textBoxProfession = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.textBoxEmail = New System.Windows.Forms.TextBox()
        Me.lblContactNumber = New System.Windows.Forms.Label()
        Me.textBoxContactNo = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.textBoxAddress = New System.Windows.Forms.TextBox()
        Me.panelPersonalInformation = New System.Windows.Forms.Panel()
        Me.lblProfile = New System.Windows.Forms.Label()
        Me.panelWorkExperience = New System.Windows.Forms.Panel()
        Me.textBoxYear1 = New System.Windows.Forms.TextBox()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.textBoxDefofJob1 = New System.Windows.Forms.TextBox()
        Me.lblDefofJob1 = New System.Windows.Forms.Label()
        Me.textBoxCompany1 = New System.Windows.Forms.TextBox()
        Me.lblCompany1 = New System.Windows.Forms.Label()
        Me.lblWorkExperience = New System.Windows.Forms.Label()
        Me.textBoxPosition1 = New System.Windows.Forms.TextBox()
        Me.lblPosition1 = New System.Windows.Forms.Label()
        Me.panelSkills = New System.Windows.Forms.Panel()
        Me.textBoxSkills5 = New System.Windows.Forms.TextBox()
        Me.textBoxSkills4 = New System.Windows.Forms.TextBox()
        Me.textBoxSkills3 = New System.Windows.Forms.TextBox()
        Me.textBoxSkills2 = New System.Windows.Forms.TextBox()
        Me.lblSkills = New System.Windows.Forms.Label()
        Me.textBoxSkills1 = New System.Windows.Forms.TextBox()
        Me.panelEducation = New System.Windows.Forms.Panel()
        Me.textBoxYearGraduated = New System.Windows.Forms.TextBox()
        Me.lblYearGraduated = New System.Windows.Forms.Label()
        Me.textBoxSchool = New System.Windows.Forms.TextBox()
        Me.lblSchool = New System.Windows.Forms.Label()
        Me.lblEducation = New System.Windows.Forms.Label()
        Me.textBoxCourse = New System.Windows.Forms.TextBox()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.btnGenerateResume = New System.Windows.Forms.Button()
        Me.btnLoadJsonFile = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.Roundpb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelPersonalInformation.SuspendLayout()
        Me.panelWorkExperience.SuspendLayout()
        Me.panelSkills.SuspendLayout()
        Me.panelEducation.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Roundpb
        '
        Me.Roundpb.BackColor = System.Drawing.Color.White
        Me.Roundpb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Roundpb.Location = New System.Drawing.Point(18, 61)
        Me.Roundpb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Roundpb.Name = "Roundpb"
        Me.Roundpb.Size = New System.Drawing.Size(174, 174)
        Me.Roundpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Roundpb.TabIndex = 1
        Me.Roundpb.TabStop = False
        '
        'btnUploadPhoto
        '
        Me.btnUploadPhoto.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnUploadPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUploadPhoto.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnUploadPhoto.Location = New System.Drawing.Point(40, 251)
        Me.btnUploadPhoto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUploadPhoto.Name = "btnUploadPhoto"
        Me.btnUploadPhoto.Size = New System.Drawing.Size(127, 32)
        Me.btnUploadPhoto.TabIndex = 2
        Me.btnUploadPhoto.Text = "Upload Photo"
        Me.btnUploadPhoto.UseVisualStyleBackColor = False
        '
        'textBoxName
        '
        Me.textBoxName.BackColor = System.Drawing.SystemColors.HighlightText
        Me.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textBoxName.Font = New System.Drawing.Font("Garamond", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.textBoxName.Location = New System.Drawing.Point(294, 51)
        Me.textBoxName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.textBoxName.Multiline = True
        Me.textBoxName.Name = "textBoxName"
        Me.textBoxName.Size = New System.Drawing.Size(400, 35)
        Me.textBoxName.TabIndex = 3
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(208, 60)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(47, 18)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "Name:"
        '
        'lblProfession
        '
        Me.lblProfession.AutoSize = True
        Me.lblProfession.Location = New System.Drawing.Point(208, 109)
        Me.lblProfession.Name = "lblProfession"
        Me.lblProfession.Size = New System.Drawing.Size(77, 18)
        Me.lblProfession.TabIndex = 5
        Me.lblProfession.Text = "Profession:"
        '
        'textBoxProfession
        '
        Me.textBoxProfession.BackColor = System.Drawing.SystemColors.HighlightText
        Me.textBoxProfession.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textBoxProfession.Font = New System.Drawing.Font("Garamond", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.textBoxProfession.Location = New System.Drawing.Point(294, 100)
        Me.textBoxProfession.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.textBoxProfession.Multiline = True
        Me.textBoxProfession.Name = "textBoxProfession"
        Me.textBoxProfession.Size = New System.Drawing.Size(400, 35)
        Me.textBoxProfession.TabIndex = 6
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(208, 158)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(46, 18)
        Me.lblEmail.TabIndex = 7
        Me.lblEmail.Text = "Email:"
        '
        'textBoxEmail
        '
        Me.textBoxEmail.BackColor = System.Drawing.SystemColors.HighlightText
        Me.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textBoxEmail.Font = New System.Drawing.Font("Garamond", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.textBoxEmail.Location = New System.Drawing.Point(294, 149)
        Me.textBoxEmail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.textBoxEmail.Multiline = True
        Me.textBoxEmail.Name = "textBoxEmail"
        Me.textBoxEmail.Size = New System.Drawing.Size(400, 35)
        Me.textBoxEmail.TabIndex = 8
        '
        'lblContactNumber
        '
        Me.lblContactNumber.AutoSize = True
        Me.lblContactNumber.Location = New System.Drawing.Point(208, 258)
        Me.lblContactNumber.Name = "lblContactNumber"
        Me.lblContactNumber.Size = New System.Drawing.Size(80, 18)
        Me.lblContactNumber.TabIndex = 9
        Me.lblContactNumber.Text = "Contact No:"
        '
        'textBoxContactNo
        '
        Me.textBoxContactNo.BackColor = System.Drawing.SystemColors.HighlightText
        Me.textBoxContactNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textBoxContactNo.Font = New System.Drawing.Font("Garamond", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.textBoxContactNo.Location = New System.Drawing.Point(294, 247)
        Me.textBoxContactNo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.textBoxContactNo.Multiline = True
        Me.textBoxContactNo.Name = "textBoxContactNo"
        Me.textBoxContactNo.Size = New System.Drawing.Size(400, 35)
        Me.textBoxContactNo.TabIndex = 10
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(208, 207)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(62, 18)
        Me.lblAddress.TabIndex = 11
        Me.lblAddress.Text = "Address:"
        '
        'textBoxAddress
        '
        Me.textBoxAddress.BackColor = System.Drawing.SystemColors.HighlightText
        Me.textBoxAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textBoxAddress.Font = New System.Drawing.Font("Garamond", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.textBoxAddress.Location = New System.Drawing.Point(294, 198)
        Me.textBoxAddress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.textBoxAddress.Multiline = True
        Me.textBoxAddress.Name = "textBoxAddress"
        Me.textBoxAddress.Size = New System.Drawing.Size(400, 35)
        Me.textBoxAddress.TabIndex = 12
        '
        'panelPersonalInformation
        '
        Me.panelPersonalInformation.AccessibleDescription = ""
        Me.panelPersonalInformation.AccessibleName = ""
        Me.panelPersonalInformation.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.panelPersonalInformation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelPersonalInformation.Controls.Add(Me.lblProfile)
        Me.panelPersonalInformation.Controls.Add(Me.Roundpb)
        Me.panelPersonalInformation.Controls.Add(Me.textBoxAddress)
        Me.panelPersonalInformation.Controls.Add(Me.btnUploadPhoto)
        Me.panelPersonalInformation.Controls.Add(Me.lblAddress)
        Me.panelPersonalInformation.Controls.Add(Me.textBoxName)
        Me.panelPersonalInformation.Controls.Add(Me.textBoxContactNo)
        Me.panelPersonalInformation.Controls.Add(Me.lblName)
        Me.panelPersonalInformation.Controls.Add(Me.lblContactNumber)
        Me.panelPersonalInformation.Controls.Add(Me.lblProfession)
        Me.panelPersonalInformation.Controls.Add(Me.textBoxEmail)
        Me.panelPersonalInformation.Controls.Add(Me.textBoxProfession)
        Me.panelPersonalInformation.Controls.Add(Me.lblEmail)
        Me.panelPersonalInformation.Location = New System.Drawing.Point(23, 22)
        Me.panelPersonalInformation.Name = "panelPersonalInformation"
        Me.panelPersonalInformation.Padding = New System.Windows.Forms.Padding(15)
        Me.panelPersonalInformation.Size = New System.Drawing.Size(722, 304)
        Me.panelPersonalInformation.TabIndex = 13
        '
        'lblProfile
        '
        Me.lblProfile.AutoSize = True
        Me.lblProfile.BackColor = System.Drawing.Color.Gold
        Me.lblProfile.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblProfile.Location = New System.Drawing.Point(18, 15)
        Me.lblProfile.Name = "lblProfile"
        Me.lblProfile.Size = New System.Drawing.Size(84, 24)
        Me.lblProfile.TabIndex = 13
        Me.lblProfile.Text = "PROFILE"
        '
        'panelWorkExperience
        '
        Me.panelWorkExperience.AccessibleDescription = ""
        Me.panelWorkExperience.AccessibleName = ""
        Me.panelWorkExperience.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.panelWorkExperience.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelWorkExperience.Controls.Add(Me.textBoxYear1)
        Me.panelWorkExperience.Controls.Add(Me.lblYear)
        Me.panelWorkExperience.Controls.Add(Me.textBoxDefofJob1)
        Me.panelWorkExperience.Controls.Add(Me.lblDefofJob1)
        Me.panelWorkExperience.Controls.Add(Me.textBoxCompany1)
        Me.panelWorkExperience.Controls.Add(Me.lblCompany1)
        Me.panelWorkExperience.Controls.Add(Me.lblWorkExperience)
        Me.panelWorkExperience.Controls.Add(Me.textBoxPosition1)
        Me.panelWorkExperience.Controls.Add(Me.lblPosition1)
        Me.panelWorkExperience.Location = New System.Drawing.Point(23, 338)
        Me.panelWorkExperience.Name = "panelWorkExperience"
        Me.panelWorkExperience.Padding = New System.Windows.Forms.Padding(15)
        Me.panelWorkExperience.Size = New System.Drawing.Size(722, 256)
        Me.panelWorkExperience.TabIndex = 14
        '
        'textBoxYear1
        '
        Me.textBoxYear1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.textBoxYear1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textBoxYear1.Font = New System.Drawing.Font("Garamond", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.textBoxYear1.Location = New System.Drawing.Point(127, 198)
        Me.textBoxYear1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.textBoxYear1.Multiline = True
        Me.textBoxYear1.Name = "textBoxYear1"
        Me.textBoxYear1.Size = New System.Drawing.Size(567, 35)
        Me.textBoxYear1.TabIndex = 26
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(18, 207)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(101, 18)
        Me.lblYear.TabIndex = 25
        Me.lblYear.Text = "Year(From-To):"
        '
        'textBoxDefofJob1
        '
        Me.textBoxDefofJob1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.textBoxDefofJob1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textBoxDefofJob1.Font = New System.Drawing.Font("Garamond", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.textBoxDefofJob1.Location = New System.Drawing.Point(127, 149)
        Me.textBoxDefofJob1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.textBoxDefofJob1.Multiline = True
        Me.textBoxDefofJob1.Name = "textBoxDefofJob1"
        Me.textBoxDefofJob1.Size = New System.Drawing.Size(567, 35)
        Me.textBoxDefofJob1.TabIndex = 18
        '
        'lblDefofJob1
        '
        Me.lblDefofJob1.AutoSize = True
        Me.lblDefofJob1.Location = New System.Drawing.Point(18, 158)
        Me.lblDefofJob1.Name = "lblDefofJob1"
        Me.lblDefofJob1.Size = New System.Drawing.Size(104, 18)
        Me.lblDefofJob1.TabIndex = 17
        Me.lblDefofJob1.Text = "Define Position:"
        '
        'textBoxCompany1
        '
        Me.textBoxCompany1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.textBoxCompany1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textBoxCompany1.Font = New System.Drawing.Font("Garamond", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.textBoxCompany1.Location = New System.Drawing.Point(127, 100)
        Me.textBoxCompany1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.textBoxCompany1.Multiline = True
        Me.textBoxCompany1.Name = "textBoxCompany1"
        Me.textBoxCompany1.Size = New System.Drawing.Size(567, 35)
        Me.textBoxCompany1.TabIndex = 16
        '
        'lblCompany1
        '
        Me.lblCompany1.AutoSize = True
        Me.lblCompany1.Location = New System.Drawing.Point(18, 109)
        Me.lblCompany1.Name = "lblCompany1"
        Me.lblCompany1.Size = New System.Drawing.Size(69, 18)
        Me.lblCompany1.TabIndex = 15
        Me.lblCompany1.Text = "Company:"
        '
        'lblWorkExperience
        '
        Me.lblWorkExperience.AutoSize = True
        Me.lblWorkExperience.BackColor = System.Drawing.Color.Gold
        Me.lblWorkExperience.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblWorkExperience.Location = New System.Drawing.Point(18, 15)
        Me.lblWorkExperience.Name = "lblWorkExperience"
        Me.lblWorkExperience.Size = New System.Drawing.Size(178, 24)
        Me.lblWorkExperience.TabIndex = 14
        Me.lblWorkExperience.Text = "WORK EXPERIENCE"
        '
        'textBoxPosition1
        '
        Me.textBoxPosition1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.textBoxPosition1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textBoxPosition1.Font = New System.Drawing.Font("Garamond", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.textBoxPosition1.Location = New System.Drawing.Point(127, 51)
        Me.textBoxPosition1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.textBoxPosition1.Multiline = True
        Me.textBoxPosition1.Name = "textBoxPosition1"
        Me.textBoxPosition1.Size = New System.Drawing.Size(567, 35)
        Me.textBoxPosition1.TabIndex = 3
        '
        'lblPosition1
        '
        Me.lblPosition1.AutoSize = True
        Me.lblPosition1.Location = New System.Drawing.Point(18, 60)
        Me.lblPosition1.Name = "lblPosition1"
        Me.lblPosition1.Size = New System.Drawing.Size(61, 18)
        Me.lblPosition1.TabIndex = 4
        Me.lblPosition1.Text = "Position:"
        '
        'panelSkills
        '
        Me.panelSkills.AccessibleDescription = ""
        Me.panelSkills.AccessibleName = ""
        Me.panelSkills.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.panelSkills.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelSkills.Controls.Add(Me.textBoxSkills5)
        Me.panelSkills.Controls.Add(Me.textBoxSkills4)
        Me.panelSkills.Controls.Add(Me.textBoxSkills3)
        Me.panelSkills.Controls.Add(Me.textBoxSkills2)
        Me.panelSkills.Controls.Add(Me.lblSkills)
        Me.panelSkills.Controls.Add(Me.textBoxSkills1)
        Me.panelSkills.Location = New System.Drawing.Point(761, 22)
        Me.panelSkills.Name = "panelSkills"
        Me.panelSkills.Padding = New System.Windows.Forms.Padding(15)
        Me.panelSkills.Size = New System.Drawing.Size(574, 304)
        Me.panelSkills.TabIndex = 15
        '
        'textBoxSkills5
        '
        Me.textBoxSkills5.BackColor = System.Drawing.SystemColors.HighlightText
        Me.textBoxSkills5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textBoxSkills5.Font = New System.Drawing.Font("Garamond", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.textBoxSkills5.Location = New System.Drawing.Point(18, 249)
        Me.textBoxSkills5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.textBoxSkills5.Multiline = True
        Me.textBoxSkills5.Name = "textBoxSkills5"
        Me.textBoxSkills5.Size = New System.Drawing.Size(534, 35)
        Me.textBoxSkills5.TabIndex = 18
        '
        'textBoxSkills4
        '
        Me.textBoxSkills4.BackColor = System.Drawing.SystemColors.HighlightText
        Me.textBoxSkills4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textBoxSkills4.Font = New System.Drawing.Font("Garamond", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.textBoxSkills4.Location = New System.Drawing.Point(18, 200)
        Me.textBoxSkills4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.textBoxSkills4.Multiline = True
        Me.textBoxSkills4.Name = "textBoxSkills4"
        Me.textBoxSkills4.Size = New System.Drawing.Size(534, 35)
        Me.textBoxSkills4.TabIndex = 17
        '
        'textBoxSkills3
        '
        Me.textBoxSkills3.BackColor = System.Drawing.SystemColors.HighlightText
        Me.textBoxSkills3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textBoxSkills3.Font = New System.Drawing.Font("Garamond", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.textBoxSkills3.Location = New System.Drawing.Point(18, 149)
        Me.textBoxSkills3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.textBoxSkills3.Multiline = True
        Me.textBoxSkills3.Name = "textBoxSkills3"
        Me.textBoxSkills3.Size = New System.Drawing.Size(534, 35)
        Me.textBoxSkills3.TabIndex = 16
        '
        'textBoxSkills2
        '
        Me.textBoxSkills2.BackColor = System.Drawing.SystemColors.HighlightText
        Me.textBoxSkills2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textBoxSkills2.Font = New System.Drawing.Font("Garamond", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.textBoxSkills2.Location = New System.Drawing.Point(18, 100)
        Me.textBoxSkills2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.textBoxSkills2.Multiline = True
        Me.textBoxSkills2.Name = "textBoxSkills2"
        Me.textBoxSkills2.Size = New System.Drawing.Size(534, 35)
        Me.textBoxSkills2.TabIndex = 15
        '
        'lblSkills
        '
        Me.lblSkills.AutoSize = True
        Me.lblSkills.BackColor = System.Drawing.Color.Gold
        Me.lblSkills.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblSkills.Location = New System.Drawing.Point(18, 15)
        Me.lblSkills.Name = "lblSkills"
        Me.lblSkills.Size = New System.Drawing.Size(69, 24)
        Me.lblSkills.TabIndex = 14
        Me.lblSkills.Text = "SKILLS"
        '
        'textBoxSkills1
        '
        Me.textBoxSkills1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.textBoxSkills1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textBoxSkills1.Font = New System.Drawing.Font("Garamond", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.textBoxSkills1.Location = New System.Drawing.Point(18, 51)
        Me.textBoxSkills1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.textBoxSkills1.Multiline = True
        Me.textBoxSkills1.Name = "textBoxSkills1"
        Me.textBoxSkills1.Size = New System.Drawing.Size(534, 35)
        Me.textBoxSkills1.TabIndex = 3
        '
        'panelEducation
        '
        Me.panelEducation.AccessibleDescription = ""
        Me.panelEducation.AccessibleName = ""
        Me.panelEducation.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.panelEducation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelEducation.Controls.Add(Me.textBoxYearGraduated)
        Me.panelEducation.Controls.Add(Me.lblYearGraduated)
        Me.panelEducation.Controls.Add(Me.textBoxSchool)
        Me.panelEducation.Controls.Add(Me.lblSchool)
        Me.panelEducation.Controls.Add(Me.lblEducation)
        Me.panelEducation.Controls.Add(Me.textBoxCourse)
        Me.panelEducation.Controls.Add(Me.lblCourse)
        Me.panelEducation.Location = New System.Drawing.Point(761, 338)
        Me.panelEducation.Name = "panelEducation"
        Me.panelEducation.Padding = New System.Windows.Forms.Padding(15)
        Me.panelEducation.Size = New System.Drawing.Size(574, 207)
        Me.panelEducation.TabIndex = 16
        '
        'textBoxYearGraduated
        '
        Me.textBoxYearGraduated.BackColor = System.Drawing.SystemColors.HighlightText
        Me.textBoxYearGraduated.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textBoxYearGraduated.Font = New System.Drawing.Font("Garamond", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.textBoxYearGraduated.Location = New System.Drawing.Point(136, 149)
        Me.textBoxYearGraduated.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.textBoxYearGraduated.Multiline = True
        Me.textBoxYearGraduated.Name = "textBoxYearGraduated"
        Me.textBoxYearGraduated.Size = New System.Drawing.Size(416, 35)
        Me.textBoxYearGraduated.TabIndex = 18
        '
        'lblYearGraduated
        '
        Me.lblYearGraduated.AutoSize = True
        Me.lblYearGraduated.Location = New System.Drawing.Point(18, 158)
        Me.lblYearGraduated.Name = "lblYearGraduated"
        Me.lblYearGraduated.Size = New System.Drawing.Size(110, 18)
        Me.lblYearGraduated.TabIndex = 17
        Me.lblYearGraduated.Text = "Year Graduated:"
        '
        'textBoxSchool
        '
        Me.textBoxSchool.BackColor = System.Drawing.SystemColors.HighlightText
        Me.textBoxSchool.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textBoxSchool.Font = New System.Drawing.Font("Garamond", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.textBoxSchool.Location = New System.Drawing.Point(136, 100)
        Me.textBoxSchool.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.textBoxSchool.Multiline = True
        Me.textBoxSchool.Name = "textBoxSchool"
        Me.textBoxSchool.Size = New System.Drawing.Size(416, 35)
        Me.textBoxSchool.TabIndex = 16
        '
        'lblSchool
        '
        Me.lblSchool.AutoSize = True
        Me.lblSchool.Location = New System.Drawing.Point(18, 109)
        Me.lblSchool.Name = "lblSchool"
        Me.lblSchool.Size = New System.Drawing.Size(58, 18)
        Me.lblSchool.TabIndex = 15
        Me.lblSchool.Text = "School::"
        '
        'lblEducation
        '
        Me.lblEducation.AutoSize = True
        Me.lblEducation.BackColor = System.Drawing.Color.Gold
        Me.lblEducation.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblEducation.Location = New System.Drawing.Point(18, 15)
        Me.lblEducation.Name = "lblEducation"
        Me.lblEducation.Size = New System.Drawing.Size(111, 24)
        Me.lblEducation.TabIndex = 14
        Me.lblEducation.Text = "EDUCATION"
        '
        'textBoxCourse
        '
        Me.textBoxCourse.BackColor = System.Drawing.SystemColors.HighlightText
        Me.textBoxCourse.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textBoxCourse.Font = New System.Drawing.Font("Garamond", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.textBoxCourse.Location = New System.Drawing.Point(136, 51)
        Me.textBoxCourse.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.textBoxCourse.Multiline = True
        Me.textBoxCourse.Name = "textBoxCourse"
        Me.textBoxCourse.Size = New System.Drawing.Size(416, 35)
        Me.textBoxCourse.TabIndex = 3
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Location = New System.Drawing.Point(18, 60)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(55, 18)
        Me.lblCourse.TabIndex = 4
        Me.lblCourse.Text = "Course:"
        '
        'btnGenerateResume
        '
        Me.btnGenerateResume.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnGenerateResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerateResume.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGenerateResume.Location = New System.Drawing.Point(761, 562)
        Me.btnGenerateResume.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGenerateResume.Name = "btnGenerateResume"
        Me.btnGenerateResume.Size = New System.Drawing.Size(185, 32)
        Me.btnGenerateResume.TabIndex = 14
        Me.btnGenerateResume.Text = "Generate Resume"
        Me.btnGenerateResume.UseVisualStyleBackColor = False
        '
        'btnLoadJsonFile
        '
        Me.btnLoadJsonFile.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.btnLoadJsonFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoadJsonFile.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnLoadJsonFile.Location = New System.Drawing.Point(956, 562)
        Me.btnLoadJsonFile.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLoadJsonFile.Name = "btnLoadJsonFile"
        Me.btnLoadJsonFile.Size = New System.Drawing.Size(185, 32)
        Me.btnLoadJsonFile.TabIndex = 17
        Me.btnLoadJsonFile.Text = "Load JSON File"
        Me.btnLoadJsonFile.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Peru
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnExit.Location = New System.Drawing.Point(1150, 562)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(185, 32)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(1358, 616)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLoadJsonFile)
        Me.Controls.Add(Me.btnGenerateResume)
        Me.Controls.Add(Me.panelEducation)
        Me.Controls.Add(Me.panelSkills)
        Me.Controls.Add(Me.panelWorkExperience)
        Me.Controls.Add(Me.panelPersonalInformation)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(20, 19, 20, 19)
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RESUME GENERATOR"
        CType(Me.Roundpb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelPersonalInformation.ResumeLayout(False)
        Me.panelPersonalInformation.PerformLayout()
        Me.panelWorkExperience.ResumeLayout(False)
        Me.panelWorkExperience.PerformLayout()
        Me.panelSkills.ResumeLayout(False)
        Me.panelSkills.PerformLayout()
        Me.panelEducation.ResumeLayout(False)
        Me.panelEducation.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Roundpb As RoundPictureBox
    Friend WithEvents btnUploadPhoto As Button
    Friend WithEvents textBoxName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblProfession As Label
    Friend WithEvents textBoxProfession As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents textBoxEmail As TextBox
    Friend WithEvents lblContactNumber As Label
    Friend WithEvents textBoxContactNo As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents textBoxAddress As TextBox
    Friend WithEvents panelPersonalInformation As Panel
    Friend WithEvents panelWorkExperience As Panel
    Friend WithEvents lblProfile As Label
    Friend WithEvents lblWorkExperience As Label
    Friend WithEvents textBoxYear1 As TextBox
    Friend WithEvents lblYear As Label
    Friend WithEvents textBoxDefofJob1 As TextBox
    Friend WithEvents lblDefofJob1 As Label
    Friend WithEvents textBoxCompany1 As TextBox
    Friend WithEvents lblCompany1 As Label
    Friend WithEvents textBoxPosition1 As TextBox
    Friend WithEvents lblPosition1 As Label
    Friend WithEvents panelSkills As Panel
    Friend WithEvents textBoxSkills5 As TextBox
    Friend WithEvents textBoxSkills4 As TextBox
    Friend WithEvents textBoxSkills3 As TextBox
    Friend WithEvents textBoxSkills2 As TextBox
    Friend WithEvents lblSkills As Label
    Friend WithEvents textBoxSkills1 As TextBox
    Friend WithEvents panelEducation As Panel
    Friend WithEvents textBoxYearGraduated As TextBox
    Friend WithEvents lblYearGraduated As Label
    Friend WithEvents textBoxSchool As TextBox
    Friend WithEvents lblSchool As Label
    Friend WithEvents lblEducation As Label
    Friend WithEvents textBoxCourse As TextBox
    Friend WithEvents lblCourse As Label
    Friend WithEvents btnGenerateResume As Button
    Friend WithEvents btnLoadJsonFile As Button
    Friend WithEvents btnExit As Button
End Class
