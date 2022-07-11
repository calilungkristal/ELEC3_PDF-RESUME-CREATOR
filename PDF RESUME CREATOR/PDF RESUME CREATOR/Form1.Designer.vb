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
        Me.btnGenerateResume = New System.Windows.Forms.Button()
        Me.RichTextBoxDisplay = New System.Windows.Forms.RichTextBox()
        Me.btnLoadJson = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'btnGenerateResume
        '
        Me.btnGenerateResume.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnGenerateResume.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGenerateResume.Location = New System.Drawing.Point(179, 387)
        Me.btnGenerateResume.Name = "btnGenerateResume"
        Me.btnGenerateResume.Size = New System.Drawing.Size(125, 48)
        Me.btnGenerateResume.TabIndex = 0
        Me.btnGenerateResume.Text = "Generate Resume"
        Me.btnGenerateResume.UseVisualStyleBackColor = False
        '
        'RichTextBoxDisplay
        '
        Me.RichTextBoxDisplay.Location = New System.Drawing.Point(23, 22)
        Me.RichTextBoxDisplay.Name = "RichTextBoxDisplay"
        Me.RichTextBoxDisplay.Size = New System.Drawing.Size(434, 342)
        Me.RichTextBoxDisplay.TabIndex = 1
        Me.RichTextBoxDisplay.Text = ""
        '
        'btnLoadJson
        '
        Me.btnLoadJson.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnLoadJson.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoadJson.Location = New System.Drawing.Point(23, 387)
        Me.btnLoadJson.Name = "btnLoadJson"
        Me.btnLoadJson.Size = New System.Drawing.Size(125, 48)
        Me.btnLoadJson.TabIndex = 2
        Me.btnLoadJson.Text = "Load JSON"
        Me.btnLoadJson.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Location = New System.Drawing.Point(332, 387)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(125, 48)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(480, 457)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLoadJson)
        Me.Controls.Add(Me.RichTextBoxDisplay)
        Me.Controls.Add(Me.btnGenerateResume)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(20, 19, 20, 19)
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RESUME GENERATOR"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnGenerateResume As Button
    Friend WithEvents RichTextBoxDisplay As RichTextBox
    Friend WithEvents btnLoadJson As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
