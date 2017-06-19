Module ts
    Public tsname As String = "恐竜が絶滅したのは約何万年前？" '問題
    Public tstype As String = "ans"　'問題の種類（）
    Public tsans1 As String = "6500"
    Public tsans2 As String = "7500"
    Public tsans3 As String = "30"
    Public tsansr As String = "abc"
    Public tspict As Bitmap = Nothing

    Public Sub initts()
        'qname = N & "name"
        qname = tsname

        Form1.PictureBox1.Image = tspict

        If tstype = "select" Then
            Form1.TextBox1.Visible = False
            Form1.ans1.Text = tsans1
            Form1.ans2.Visible = True
            Form1.ans3.Visible = True
        ElseIf tstype = "ans" Then
            Form1.TextBox1.Visible = True
            Form1.ans1.Text = "答える"
            Form1.ans2.Visible = False
            Form1.ans3.Visible = False
        End If
        Form1.ans2.Text = tsans2
        Form1.ans3.Text = tsans3
        Form1.Label1.Text = qname

        qans1 = tsans1
        qans2 = tsans2
        qans3 = tsans3
        ansr = tsansr
        qtype = tstype
        qname = tsname

    End Sub
End Module
