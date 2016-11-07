Public Class Form1
    Dim output As String
    Private Sub Calculate_Click(sender As Object, e As EventArgs) Handles Calculate.Click
        Dim combination_element()() As Integer
        ReDim combination_element(SpecList.Items.Count - 1)
        For i As Integer = 0 To SpecList.Items.Count - 1
            ReDim combination_element(i)(Int(Total_Width.Value / SpecList.Items(i).ToString))
            For j As Integer = 0 To Int(Total_Width.Value / SpecList.Items(i).ToString)
                combination_element(i)(j) = j
            Next
        Next

        output = ""
        Dim MyArray(SpecList.Items.Count) As String
        SpecList.Items.CopyTo(MyArray, 0)
        output += "Serial, " & String.Join(", ", MyArray) & "Wasted Material" & vbCrLf
        Dim count As Integer = 0
        For Each elements As Integer() In CartesianProduct(combination_element)
            Dim amount As Double = 0
            For k As Integer = 0 To elements.Length - 1
                amount += FormatNumber(CDbl(SpecList.Items(k).ToString), 1) * elements(k)
            Next
            If amount <= Total_Width.Value And amount >= Total_Width.Value - Acceptable_Max_Wasted.Value Then
                count += 1
                output += count & ", " & String.Join(", ", elements) & ", " & FormatNumber(CDbl(FormatNumber(CDbl(Total_Width.Value), 1) - FormatNumber(CDbl(amount), 1)), 1) & vbCrLf
            End If
        Next
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                System.IO.File.WriteAllText(SaveFileDialog1.FileName, output)
            Catch ex As Exception
                MsgBox("無法儲存檔案" & vbCrLf & ex.Message)
            End Try
        End If
        GC.Collect()
    End Sub

    Private Sub AddSpec_Click(sender As Object, e As EventArgs) Handles AddSpec.Click
        If SpecList.Items.Contains(SpecWidth.Value) Then
            MessageBox.Show("該規格已存在", "錯誤")
        Else
            SpecList.Items.Add(FormatNumber(CDbl(SpecWidth.Value), 1))
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

    Private Sub SpecWidth_KeyDown(sender As Object, e As KeyEventArgs) Handles SpecWidth.KeyDown
        If e.KeyCode = Keys.Enter Then
            AddSpec_Click(sender, e)
        End If
    End Sub

    Private Function CartesianProduct(Of T)(ParamArray sequences As T()()) As T()()
        Dim result As IEnumerable(Of T()) = {New T() {}}
        For Each sequence In sequences
            Dim s = sequence
            result = From seq In result
                     From item In s
                     Select seq.Concat({item}).ToArray()
        Next
        Return result.ToArray()
    End Function
End Class
