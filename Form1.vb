Public Class Form1
    Private Sub Calculate_Click(sender As Object, e As EventArgs) Handles Calculate.Click

    End Sub

    Private Sub AddSpec_Click(sender As Object, e As EventArgs) Handles AddSpec.Click
        If SpecList.Items.Contains(SpecLength.Value) Then
            MessageBox.Show("該規格已存在", "錯誤")
        Else
            SpecList.Items.Add(SpecLength.Value)
        End If
    End Sub

    Private Sub DeleteSpec_Click(sender As Object, e As EventArgs) Handles DeleteSpec.Click
        If Not SpecList.SelectedIndex = -1 Then
            SpecList.Items.RemoveAt(SpecList.SelectedIndex)
        End If
    End Sub

    Private Sub ClearSpec_Click(sender As Object, e As EventArgs) Handles ClearSpec.Click
        SpecList.Items.Clear()
    End Sub
End Class
