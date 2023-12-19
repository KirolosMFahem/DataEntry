Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        TextBox1.Visible = True
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        TextBox1.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If RadioButton1.Checked = True And TextBox1.Text = "123" Then
                Me.Hide()
                Form2.Show()
                Form3.MnameTextBox.ReadOnly = False
                Form3.FieldComboBox.Enabled = True
                Form3.TypeComboBox.Enabled = True
                Form3.SchoolstageComboBox.Enabled = True
                Form3.BandComboBox.Enabled = True
                Form3.SubjectComboBox.Enabled = True
                Form3.PdfTextBox.ReadOnly = False
                Form3.VideoTextBox.ReadOnly = False
                Form3.Button5.Enabled = True
                Form3.Button6.Enabled = True
                Form3.Button7.Enabled = True
                Form3.Button8.Enabled = True
                Form3.Table1DataGridView.ReadOnly = False
            ElseIf RadioButton2.Checked = True Then
                Form3.MnameTextBox.ReadOnly = True
                Form3.FieldComboBox.Enabled = False
                Form3.TypeComboBox.Enabled = False
                Form3.SchoolstageComboBox.Enabled = False
                Form3.BandComboBox.Enabled = False
                Form3.SubjectComboBox.Enabled = False
                Form3.PdfTextBox.ReadOnly = True
                Form3.VideoTextBox.ReadOnly = True
                Form3.Button5.Enabled = False
                Form3.Button6.Enabled = False
                Form3.Button7.Enabled = False
                Form3.Button8.Enabled = False
                Form3.Table1DataGridView.ReadOnly = True
                Me.Hide()
                Form2.Show()
            Else
                MsgBox("Wrong Password")

            End If
        Catch ex As Exception
            MsgBox("error")
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub
End Class
