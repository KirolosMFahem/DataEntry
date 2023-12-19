Public Class Form3

    Private Sub AxWindowsMediaPlayer1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Table1BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Table1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataDataSet)

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataDataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.DataDataSet.Table1)

    End Sub




    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        AxWindowsMediaPlayer1.visible = True
        AxWindowsMediaPlayer1.url = VideoTextBox.Text
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        AxWindowsMediaPlayer1.visible = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            Me.Table1BindingSource.AddNew()
        Catch ex As Exception
            MsgBox("error")
        End Try

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try
            Me.Table1BindingSource.RemoveCurrent()
        Catch ex As Exception
            MsgBox("error")
        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            Me.Validate()
            Me.Table1BindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DataDataSet)
        Catch ex As Exception
            MsgBox("error")
        End Try
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Try
            Me.Validate()
            Me.Table1BindingSource.EndEdit()
            Me.Table1TableAdapter.Update(Me.DataDataSet.Table1)
            Me.Table1TableAdapter.Fill(Me.DataDataSet.Table1)
        Catch ex As Exception
            MsgBox("error")
        End Try
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Try
            Me.Table1BindingSource.RemoveFilter()
        Catch ex As Exception
            MsgBox("error")
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            Me.Table1BindingSource.Filter = "mname + field + type like '%" & TextBox1.Text & "%'"
        Catch ex As Exception
            MsgBox("error")
        End Try
    End Sub
End Class