Public Class Form1
    Inherits System.Web.UI.Page


    Public all As Integer = 20 '全問題数
    Public easyth As Integer = 6 'Easy数
    Public normth As Integer = 9 'Normal数
    Public highth As Integer = 5 'Hard数


    Public readed As Integer
    Public ansr As String
    Public high As Integer
    Dim normal As Integer

    Public diffic As String = "Easy"
    Public corr As Integer = 0
    Public incorr As Integer = 0
    Public now As Integer = 1
    Public tbox As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Runload()
    End Sub

    Protected Sub ans1b_Click(sender As Object, e As EventArgs) Handles ans1b.Click
        checkcor("ans1")
    End Sub

    Protected Sub ans2b_Click(sender As Object, e As EventArgs) Handles ans2b.Click
        checkcor("ans2")
    End Sub

    Protected Sub ans3b_Click(sender As Object, e As EventArgs) Handles ans3b.Click
        checkcor("ans3")
    End Sub

    Private Sub checkcor(ByRef A As String)
        Dim cor As String = ansr
        If cor = A Then
            corr = corr + 1
            MsgBox("正解")
            Runload()
        Else
            incorr = incorr + 1
            MsgBox("不正解")
            Runload()
        End If
        cor = Nothing
        ansr = Nothing
    End Sub

    Private Sub Runload()
        Dim easy As Integer = easyth
        normal = easyth + normth
        high = normal + highth

        If now < easyth Then
            'MessageBox.Show("loadby e", "")
            loadq("e")
            diffic = "Easy"
        ElseIf now = easy Then
            readed = 0
            loadq("n")
            diffic = "Normal"
        ElseIf now < normal Then
            'MessageBox.Show("loadby n", "")
            loadq("n")
            diffic = "Normal"
        ElseIf now = normal Then
            readed = 0
            loadq("h")
            diffic = "Hard"
        ElseIf now < high Then
            'MessageBox.Show("loadby h", "")
            loadq("h")
            diffic = "Hard"

        ElseIf now = high Then
            MsgBox("おめでとうございます" & Environment.NewLine & "すべての問題が終わりました" & Environment.NewLine & "正答率：" & Calcper(all, corr) & "％")
            Response.Redirect("Result.aspx")
        End If

        'form1.Site = "クイズゲーム1  " & diffic

        now = now + 1
        Exit Sub
    End Sub

    Private Function Calcper(Optional A As Integer = 0, Optional N As Integer = 0)
        Dim c1 As Double = A / N
        Dim c2 As Double = 100 / c1
        Dim c3 As Double = Math.Floor(c2)
        Return c3
    End Function

    Public Sub qname(ByRef T As String)
        Label1.Text = T
    End Sub

    Public Sub qans1(ByRef T As String)
        ans1t.Text = T
    End Sub

    Public Sub qans2(ByRef T As String)
        ans2t.Text = T
    End Sub

    Public Sub qans3(ByRef T As String)
        ans3t.Text = T
    End Sub

    Public Sub loadq(Optional D As String = "n")
        If D = "e" Then 'Easy時の自動選別
            If readed = 0 Then
                initQ1()
                readed = readed + 1
            ElseIf readed = 1 Then
                initQ2()
                readed = readed + 1
            End If
        End If

    End Sub

    Public Sub initQ1()
        qname("カメラのシャッタースピードを上げるとどうなるでしょう")
        qans1("シャッター音が大きくなる")
        qans2("画面が暗くなる")
        qans3("色合いが落ちる")
        ansr = "ans2"
    End Sub

    Public Sub initQ2()
        qname("恐竜が絶滅したのは約何万年前？")
        qans1("6500")
        qans2("7500")
        qans3("12000")
        ansr = "ans1"
    End Sub
End Class
