<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.AddSpec = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Acceptable_Max_Wasted = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Total_Length = New System.Windows.Forms.NumericUpDown()
        Me.SpecLength = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Calculate = New System.Windows.Forms.Button()
        Me.SaveAsExcel = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.DeleteSpec = New System.Windows.Forms.Button()
        Me.ClearSpec = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Acceptable_Max_Wasted, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Total_Length, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpecLength, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AddSpec
        '
        Me.AddSpec.Location = New System.Drawing.Point(30, 116)
        Me.AddSpec.Name = "AddSpec"
        Me.AddSpec.Size = New System.Drawing.Size(380, 47)
        Me.AddSpec.TabIndex = 0
        Me.AddSpec.Text = "新增規格"
        Me.AddSpec.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ClearSpec)
        Me.GroupBox1.Controls.Add(Me.DeleteSpec)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.SpecLength)
        Me.GroupBox1.Controls.Add(Me.AddSpec)
        Me.GroupBox1.Location = New System.Drawing.Point(44, 167)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(431, 539)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "需求規格"
        '
        'Acceptable_Max_Wasted
        '
        Me.Acceptable_Max_Wasted.Location = New System.Drawing.Point(248, 32)
        Me.Acceptable_Max_Wasted.Name = "Acceptable_Max_Wasted"
        Me.Acceptable_Max_Wasted.Size = New System.Drawing.Size(206, 36)
        Me.Acceptable_Max_Wasted.TabIndex = 4
        Me.Acceptable_Max_Wasted.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "可容許耗損範圍："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "鋼捲總長度："
        '
        'Total_Length
        '
        Me.Total_Length.Location = New System.Drawing.Point(248, 92)
        Me.Total_Length.Name = "Total_Length"
        Me.Total_Length.Size = New System.Drawing.Size(206, 36)
        Me.Total_Length.TabIndex = 7
        Me.Total_Length.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'SpecLength
        '
        Me.SpecLength.Location = New System.Drawing.Point(204, 45)
        Me.SpecLength.Name = "SpecLength"
        Me.SpecLength.Size = New System.Drawing.Size(206, 36)
        Me.SpecLength.TabIndex = 8
        Me.SpecLength.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 24)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "長度："
        '
        'Calculate
        '
        Me.Calculate.Location = New System.Drawing.Point(505, 32)
        Me.Calculate.Name = "Calculate"
        Me.Calculate.Size = New System.Drawing.Size(314, 96)
        Me.Calculate.TabIndex = 8
        Me.Calculate.Text = "計算"
        Me.Calculate.UseVisualStyleBackColor = True
        '
        'SaveAsExcel
        '
        Me.SaveAsExcel.Location = New System.Drawing.Point(870, 32)
        Me.SaveAsExcel.Name = "SaveAsExcel"
        Me.SaveAsExcel.Size = New System.Drawing.Size(314, 96)
        Me.SaveAsExcel.TabIndex = 9
        Me.SaveAsExcel.Text = "存成Excel"
        Me.SaveAsExcel.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 24
        Me.ListBox1.Location = New System.Drawing.Point(30, 187)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(380, 268)
        Me.ListBox1.TabIndex = 9
        '
        'DeleteSpec
        '
        Me.DeleteSpec.Location = New System.Drawing.Point(30, 474)
        Me.DeleteSpec.Name = "DeleteSpec"
        Me.DeleteSpec.Size = New System.Drawing.Size(180, 42)
        Me.DeleteSpec.TabIndex = 10
        Me.DeleteSpec.Text = "刪除所選取的"
        Me.DeleteSpec.UseVisualStyleBackColor = True
        '
        'ClearSpec
        '
        Me.ClearSpec.Location = New System.Drawing.Point(230, 474)
        Me.ClearSpec.Name = "ClearSpec"
        Me.ClearSpec.Size = New System.Drawing.Size(180, 42)
        Me.ClearSpec.TabIndex = 11
        Me.ClearSpec.Text = "清空規格列表"
        Me.ClearSpec.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1210, 726)
        Me.Controls.Add(Me.SaveAsExcel)
        Me.Controls.Add(Me.Calculate)
        Me.Controls.Add(Me.Total_Length)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Acceptable_Max_Wasted)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Acceptable_Max_Wasted, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Total_Length, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpecLength, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AddSpec As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents SpecLength As NumericUpDown
    Friend WithEvents Acceptable_Max_Wasted As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Total_Length As NumericUpDown
    Friend WithEvents Calculate As Button
    Friend WithEvents SaveAsExcel As Button
    Friend WithEvents ClearSpec As Button
    Friend WithEvents DeleteSpec As Button
    Friend WithEvents ListBox1 As ListBox
End Class
