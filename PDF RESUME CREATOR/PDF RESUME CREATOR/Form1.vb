Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub textBoxName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBoxName.KeyPress
        If (Not Char.IsLetter(e.KeyChar)) AndAlso (Not Char.IsWhiteSpace(e.KeyChar)) AndAlso (Not Char.IsControl(e.KeyChar)) AndAlso e.KeyChar <> "."c AndAlso e.KeyChar <> ","c Then
            e.Handled = True
        End If
    End Sub

    Private Sub textBoxProfession_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBoxProfession.KeyPress
        If (Not Char.IsLetter(e.KeyChar)) AndAlso (Not Char.IsWhiteSpace(e.KeyChar)) AndAlso (Not Char.IsControl(e.KeyChar)) AndAlso (Not Char.IsDigit(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub textBoxEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBoxEmail.KeyPress
        If (Not Char.IsLetterOrDigit(e.KeyChar)) AndAlso (Not Char.IsControl(e.KeyChar)) AndAlso e.KeyChar <> "."c AndAlso e.KeyChar <> "@"c Then
            e.Handled = True
        End If
    End Sub

    Private Sub textBoxContactNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBoxContactNo.KeyPress
        If (Not Char.IsDigit(e.KeyChar)) AndAlso (Not Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub textBoxPosition_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBoxPosition.KeyPress
        If (Not Char.IsLetter(e.KeyChar)) AndAlso (Not Char.IsWhiteSpace(e.KeyChar)) AndAlso (Not Char.IsControl(e.KeyChar)) AndAlso (Not Char.IsDigit(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub textBoxDefofJob_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBoxDefofJob.KeyPress
        If (Not Char.IsLetter(e.KeyChar)) AndAlso (Not Char.IsWhiteSpace(e.KeyChar)) AndAlso (Not Char.IsControl(e.KeyChar)) AndAlso e.KeyChar <> "."c AndAlso e.KeyChar <> ","c Then
            e.Handled = True
        End If
    End Sub

    Private Sub textBoxYear_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBoxYear.KeyPress
        If (Not Char.IsDigit(e.KeyChar)) AndAlso (Not Char.IsControl(e.KeyChar)) AndAlso e.KeyChar <> "-"c Then
            e.Handled = True
        End If
    End Sub

    Private Sub textBoxCourse_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBoxCourse.KeyPress
        If (Not Char.IsLetter(e.KeyChar)) AndAlso (Not Char.IsWhiteSpace(e.KeyChar)) AndAlso (Not Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub textBoxSchool_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBoxSchool.KeyPress
        If (Not Char.IsLetter(e.KeyChar)) AndAlso (Not Char.IsWhiteSpace(e.KeyChar)) AndAlso (Not Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub textBoxYearGraduated_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBoxYearGraduated.KeyPress
        If (Not Char.IsDigit(e.KeyChar)) AndAlso (Not Char.IsControl(e.KeyChar)) AndAlso e.KeyChar <> "-"c Then
            e.Handled = True
        End If
    End Sub
End Class
