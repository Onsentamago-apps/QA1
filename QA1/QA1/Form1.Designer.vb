<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ans1 = New System.Windows.Forms.Button()
        Me.ans2 = New System.Windows.Forms.Button()
        Me.ans3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ans1
        '
        Me.ans1.Location = New System.Drawing.Point(396, 101)
        Me.ans1.Name = "ans1"
        Me.ans1.Size = New System.Drawing.Size(213, 23)
        Me.ans1.TabIndex = 0
        Me.ans1.Text = "Button1"
        Me.ans1.UseVisualStyleBackColor = True
        '
        'ans2
        '
        Me.ans2.Location = New System.Drawing.Point(396, 130)
        Me.ans2.Name = "ans2"
        Me.ans2.Size = New System.Drawing.Size(213, 23)
        Me.ans2.TabIndex = 1
        Me.ans2.Text = "Button2"
        Me.ans2.UseVisualStyleBackColor = True
        '
        'ans3
        '
        Me.ans3.Location = New System.Drawing.Point(396, 159)
        Me.ans3.Name = "ans3"
        Me.ans3.Size = New System.Drawing.Size(213, 23)
        Me.ans3.TabIndex = 2
        Me.ans3.Text = "Button3"
        Me.ans3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 159)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Option"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(396, 76)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(213, 19)
        Me.TextBox1.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(93, 90)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 194)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.ans3)
        Me.Controls.Add(Me.ans2)
        Me.Controls.Add(Me.ans1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "クイズゲーム１"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ans1 As Button
    Friend WithEvents ans2 As Button
    Friend WithEvents ans3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
