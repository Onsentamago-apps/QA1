Public Class Form1
    Public high As Integer
    Dim normal As Integer


    Public readed As Integer = 0
    Public all As Integer = 15
    Public corr As Integer = 0
    Public incorr As Integer = 0
    Public now As Integer = 1
    Public cor = New System.Media.SoundPlayer(My.Resources.atrue)
    Public icor = New System.Media.SoundPlayer(My.Resources.afalse)
    Public tbox As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'initts()
        Runload()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ans1.Click
        tbox = TextBox1.Text
        If qtype = "Ans" Then
            Checkcorrect(tbox)
        Else　'Select
            Checkcorrect("ans1")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ans2.Click
        Checkcorrect("ans2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ans3.Click
        Checkcorrect("ans3")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        setop.Show()
    End Sub

    Private Sub Checkcorrect(Optional A As String = "")
        If ansr = A Then
            cor.Play()
            corr = corr + 1
            MessageBox.Show("正解", "正解")
            Runload()
        Else
            icor.Play()
            incorr = incorr + 1
            MessageBox.Show("不正解", "不正解")
            Runload()
        End If
        Exit Sub
    End Sub

    Private Sub Runload()
        'Set many
        Dim easyth As Integer = 6
        Dim normth As Integer = 5
        Dim highth As Integer = 4
        Dim easy As Integer = easyth
        normal = easyth + normth
        high = normal + highth

        If now < easyth Then
            'MessageBox.Show("loadby e", "")
            loadq("e")
        ElseIf now = easy Then
            readed = 0
            loadq("n")
        ElseIf now < normal Then
            'MessageBox.Show("loadby n", "")
            loadq("n")
        ElseIf now = normal Then
            readed = 0
            loadq("h")
        ElseIf now < high Then
            'MessageBox.Show("loadby h", "")
            loadq("h")
        ElseIf now = high Then
            MessageBox.Show("おめでとうございます" & Environment.NewLine & "すべての問題が終わりました" & Environment.NewLine & "正答率：" & Calcper(all, corr) & "％", "おめでとうございます")
            Me.Close()
        End If

        now = now + 1
        Exit Sub
    End Sub
    Private Function Calcper(Optional A As Integer = 0, Optional N As Integer = 0)
        Dim c1 As Double = A / N
        Dim c2 As Double = 100 / c1
        Dim c3 As Double = Math.Floor(c2)
        Return c3
    End Function
    Private Sub loadq(Optional D As String = "n")
        If D = "e" Then 'Easy時の自動選別
            If readed = 0 Then
                initQ1()
                readed = readed + 1
            ElseIf readed = 1 Then
                initQ6()
                readed = readed + 1
            ElseIf readed = 2 Then
                initQ7()
                readed = readed + 1
            ElseIf readed = 3 Then
                initQ8()
                readed = readed + 1
            ElseIf readed = 4 Then
                initQ9()
                readed = readed + 1
            ElseIf readed = 5 Then
                initQ11()
                readed = readed + 1
            End If
        ElseIf D = "n" Then 'nomal時の自動選別
            If readed = 0 Then
                initQ2()
                readed = readed + 1
            ElseIf readed = 1 Then
                initQ3()
                readed = readed + 1
            ElseIf readed = 2 Then
                initQ10()
                readed = readed + 1
            ElseIf readed = 3 Then
                initQ13()
                readed = readed + 1
            ElseIf readed = 4 Then
                initQ14()
                readed = readed + 1
            End If
        ElseIf D = "h" Then
            If readed = 0 Then
                initQ4()
                readed = readed + 1
            ElseIf readed = 1 Then
                initQ5()
                readed = readed + 1
            ElseIf readed = 2 Then
                initQ12()
                readed = readed + 1
            ElseIf readed = 3 Then
                initQ15()
                readed = readed + 1
            End If
        End If


    End Sub
End Class