Module Qread
    Public qname As String
    Public qtype As String
    Public qans1 As String
    Public qans2 As String
    Public qans3 As String
    Public ansr As String
    Public pict As Bitmap

    Public readed As Integer

    Public Sub loadq(Optional D As String = "n")
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
            ElseIf readed = 6 Then
                initQ37()
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
            ElseIf readed = 5 Then
                initQ16()
                readed = readed + 1
            ElseIf readed = 6 Then
                initQ17()
                readed = readed + 1
            ElseIf readed = 7 Then
                initQ19()
                readed = readed + 1
            ElseIf readed = 8 Then
                initQ20()
                readed = readed + 1
            ElseIf readed = 9 Then
                initQ21()
                readed = readed + 1
            ElseIf readed = 10 Then
                initQ22()
                readed = readed + 1
            ElseIf readed = 11 Then
                initQ23()
                readed = readed + 1
            ElseIf readed = 12 Then
                initQ24()
                readed = readed + 1
            ElseIf readed = 13 Then
                initQ25()
                readed = readed + 1
            ElseIf readed = 14 Then
                initQ26()
                readed = readed + 1
            ElseIf readed = 15 Then
                initQ27()
                readed = readed + 1
            ElseIf readed = 16 Then
                initQ28()
                readed = readed + 1
            ElseIf readed = 17 Then
                initQ29()
                readed = readed + 1
            ElseIf readed = 18 Then
                initQ30()
                readed = readed + 1
            ElseIf readed = 19 Then
                initQ31()
                readed = readed + 1
            ElseIf readed = 20 Then
                initQ32()
                readed = readed + 1
            ElseIf readed = 21 Then
                initQ35()
                readed = readed + 1
            ElseIf readed = 22 Then
                initQ39()
                readed = readed + 1
            ElseIf readed = 23 Then
                initQ40()
                readed = readed + 1
            End If
        ElseIf D = "h" Then 'hard時の自動選別
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
            ElseIf readed = 4 Then
                initQ18()
                readed = readed + 1
            ElseIf readed = 5 Then
                initQ22()
                readed = readed + 1
            ElseIf readed = 6 Then
                initQ33()
                readed = readed + 1
            ElseIf readed = 7 Then
                initQ34()
                readed = readed + 1
            ElseIf readed = 8 Then
                initQ36()
                readed = readed + 1
            ElseIf readed = 9 Then
                initQ38()
                readed = readed + 1
            ElseIf readed = 10 Then
                initQ41()
                readed = readed + 1
            ElseIf readed = 11 Then
                initQ42()
                readed = readed + 1
            ElseIf readed = 12 Then
                initQ43()
                readed = readed + 1
            ElseIf readed = 13 Then
                initQ44()
                readed = readed + 1
            ElseIf readed = 14 Then
                initQ45()
                readed = readed + 1
            ElseIf readed = 15 Then
                initQ46()
                readed = readed + 1
            ElseIf readed = 16 Then
                initQ47()
                readed = readed + 1
            ElseIf readed = 17 Then
                initQ48()
                readed = readed + 1
            ElseIf readed = 18 Then
                initQ49()
                readed = readed + 1
            ElseIf readed = 19 Then
                initQ50()
                readed = readed + 1
            End If
        End If
    End Sub
End Module
