Public Class Form1

    Private Sub Calculate_Click(sender As Object, e As EventArgs) Handles Calculate.Click
        If Not SpecList.Items.Count = 0 Then
            Dim combination_element(SpecList.Items.Count - 1) As Integer
            For i As Integer = 0 To SpecList.Items.Count - 1
                combination_element(i) = Int(Total_Width.Value / SpecList.Items(i).ToString)
            Next

            Dim output As String = ""
            Dim output_count As Integer = 0
            Dim temp(SpecList.Items.Count - 1) As String
            SpecList.Items.CopyTo(temp, 0)
            output = "Serial, " & String.Join(", ", temp) & ", Wasted Material, Equation" & vbCrLf

            run(1, combination_element, 0, {})
            For Each elements As Integer() In result
                Dim amount As Double = 0
                For k As Integer = 0 To elements.Length - 1
                    amount += CDbl(SpecList.Items(k).ToString) * elements(k)
                Next
                output_count += 1
                output += output_count & ", " & String.Join(", ", elements) & ", " & FormatNumber(CDbl(Total_Width.Value - amount), 1) & ", " & print_equation(SpecList.Items, elements, amount) & vbCrLf
            Next

            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                Try
                    System.IO.File.WriteAllText(SaveFileDialog1.FileName, output)
                Catch ex As Exception
                    MsgBox("無法儲存檔案" & vbCrLf & ex.Message)
                End Try
            End If
            GC.Collect()
        Else
            MsgBox("請新增需求規格")
        End If
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

    Dim result(0)() As Integer
    Dim result_count As Integer
    Private Sub run(ByVal depth As Integer, ByVal input As Integer(), ByVal sum As Double, ByVal road As Integer())
        If depth = 1 Then
            Array.Clear(result, 0, result.Length)
            result_count = 0
        End If
        If depth > SpecList.Items.Count Then
            If sum <= Total_Width.Value And sum >= Total_Width.Value - Acceptable_Max_Wasted.Value Then
                result_count += 1
                Array.Resize(result, result_count)
                Array.Resize(result(result_count - 1), SpecList.Items.Count)
                road.CopyTo(result(result_count - 1), 0)
            End If
        Else
            Dim osum As Double
            For i As Integer = 0 To input(0)
                If i = 0 Then
                    osum = sum
                End If
                sum = osum
                sum += CDbl(SpecList.Items(SpecList.Items.Count - input.Length)) * i
                Array.Resize(road, depth)
                road(road.Length - 1) = i
                run(depth + 1, input.Skip(1).ToArray, sum, road)
            Next
        End If
    End Sub

    Private Function print_equation(ByVal spec As ListBox.ObjectCollection, ByVal input As Integer(), ByVal sum As Double)
        Dim out As New List(Of String)
        For i As Integer = 0 To spec.Count - 1
            If input(i) > 0 Then
                out.Add(spec(i).ToString & "*" & input(i))
            End If
        Next
        Return (String.Join("+", out) & "=" & sum)
    End Function
End Class
