Module Module1
    Public lat As String
    Public readed As Integer
    Public qname As String
    Public qtype As String
    Public qans1 As String
    Public qans2 As String
    Public qans3 As String
    Public ansr As String
    Public pict As Bitmap

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
            End If
        End If
    End Sub
End Module