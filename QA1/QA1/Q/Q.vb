Module Q

    Public all As Integer = 15 '全問題数
    Public easyth As Integer = 6 'Easy数
    Public normth As Integer = 5 'Normal数
    Public highth As Integer = 4 'Hard数

End Module

Module Q1
    Public Q1name As String = "カメラのシャッタースピードを上げるとどうなるでしょう"
    Public Q1type As String = "select"
    Public Q1ans1 As String = "シャッター音が大きくなる"
    Public Q1ans2 As String = "画面が暗くなる"
    Public Q1ans3 As String = "色合いが落ちる"
    Public Q1ansr As String = "ans2"
    Public Q1pict As Bitmap = Nothing

    Public Sub initQ1()
        'qname = N & "name"
        qname = Q1name


        Form1.PictureBox1.Image = Q1pict


        Form1.ans1.Text = Q1ans1

        Form1.ans2.Text = Q1ans2
        Form1.ans3.Text = Q1ans3
        Form1.Label1.Text = qname

        qans1 = Q1ans1
        qans2 = Q1ans2
        qans3 = Q1ans3
        ansr = Q1ansr
        qtype = Q1type
        qname = Q1name

    End Sub
End Module


Module Q2
    Public Q2name As String = "恐竜が絶滅したのは約何万年前？" '問題
    Public Q2type As String = "select"　'問題の種類（）
    Public Q2ans1 As String = "6500"
    Public Q2ans2 As String = "7500"
    Public Q2ans3 As String = "12000"
    Public Q2ansr As String = "ans1"
    Public Q2pict As Bitmap = Nothing

    Public Sub initQ2()
        'qname = N & "name"
        qname = Q2name

        Form1.PictureBox1.Image = Q2pict

        Form1.ans1.Text = Q2ans1
        Form1.ans2.Text = Q2ans2
        Form1.ans3.Text = Q2ans3
        Form1.Label1.Text = qname

        qans1 = Q2ans1
        qans2 = Q2ans2
        qans3 = Q2ans3
        ansr = Q2ansr
        qtype = Q2type
        qname = Q2name

    End Sub
End Module

Module Q3
    Public Q3name As String = "次の漢字を読みなさい『海星』" '問題 
    Public Q3type As String = "select"　'問題の種類（） 
    Public Q3ans1 As String = "サンゴ"
    Public Q3ans2 As String = "マンタ"
    Public Q3ans3 As String = "ヒトデ"
    Public Q3ansr As String = "ans3"
    Public Q3pict As Bitmap = Nothing

    Public Sub initQ3()
        'qname = N & "name"
        qname = Q3name

        Form1.PictureBox1.Image = Q3pict

        Form1.ans1.Text = Q3ans1
        Form1.ans2.Text = Q3ans2
        Form1.ans3.Text = Q3ans3
        Form1.Label1.Text = qname

        qans1 = Q3ans1
        qans2 = Q3ans2
        qans3 = Q3ans3
        ansr = Q3ansr
        qtype = Q3type
        qname = Q3name

    End Sub
End Module
Module Q4
    Public Q4name As String = "ギリシア神話における鍛冶の神は?" '問題 
    Public Q4type As String = "select"　'問題の種類（） 
    Public Q4ans1 As String = "ヘパイストス"
    Public Q4ans2 As String = "ヘスティア"
    Public Q4ans3 As String = "ヘカトンケイル"
    Public Q4ansr As String = "ans1"
    Public Q4pict As Bitmap = Nothing

    Public Sub initQ4()
        'qname = N & "name"
        qname = Q4name

        Form1.PictureBox1.Image = Q4pict

        Form1.ans1.Text = Q4ans1

        Form1.ans2.Text = Q4ans2
        Form1.ans3.Text = Q4ans3
        Form1.Label1.Text = qname

        qans1 = Q4ans1
        qans2 = Q4ans2
        qans3 = Q4ans3
        ansr = Q4ansr
        qtype = Q4type
        qname = Q4name

    End Sub
End Module

Module Q5
    Public Q5name As String = "南緯47度9分、西経126度43分の海底にあるものは?" '問題 
    Public Q5type As String = "select"　'問題の種類（） 
    Public Q5ans1 As String = "ルルイエ"
    Public Q5ans2 As String = "アイオワ"
    Public Q5ans3 As String = "サラトガ"
    Public Q5ansr As String = "ans1"
    Public Q5pict As Bitmap = Nothing

    Public Sub initQ5()
        'qname = N & "name"
        qname = Q5name

        Form1.PictureBox1.Image = Q5pict

        Form1.ans1.Text = Q5ans1

        Form1.ans2.Text = Q5ans2
        Form1.ans3.Text = Q5ans3
        Form1.Label1.Text = qname

        qans1 = Q5ans1
        qans2 = Q5ans2
        qans3 = Q5ans3
        ansr = Q5ansr
        qtype = Q5type
        qname = Q5name

    End Sub
End Module

Module Q6
    Public Q6name As String = "童話『眠れる森の美女』において、美女がいる城は何で覆われている?" '問題 
    Public Q6type As String = "select"　'問題の種類（） 
    Public Q6ans1 As String = "薔薇"
    Public Q6ans2 As String = "鉄条網"
    Public Q6ans3 As String = "茨"
    Public Q6ansr As String = "ans3"
    Public Q6pict As Bitmap = Nothing

    Public Sub initQ6()
        'qname = N & "name"
        qname = Q6name

        Form1.PictureBox1.Image = Q6pict

        Form1.ans1.Text = Q6ans1

        Form1.ans2.Text = Q6ans2
        Form1.ans3.Text = Q6ans3
        Form1.Label1.Text = qname

        qans1 = Q6ans1
        qans2 = Q6ans2
        qans3 = Q6ans3
        ansr = Q6ansr
        qtype = Q6type
        qname = Q6name

    End Sub
End Module

Module Q7 'E
    Public Q7name As String = "Sonyの昔作っていたVAIOは何という会社の傘下になった？" '問題 
    Public Q7type As String = "select"　'問題の種類（） 
    Public Q7ans1 As String = "VAIO株式会社"
    Public Q7ans2 As String = "国立競技場"
    Public Q7ans3 As String = "VAIOコンピューターテクノロジー　株式会社"
    Public Q7ansr As String = "ans1"
    Public Q7pict As Bitmap = Nothing

    Public Sub initQ7()
        'qname = N & "name"
        qname = Q7name

        pict = Q7pict
        Form1.PictureBox1.Image = pict

        Form1.ans1.Text = Q7ans1

        Form1.ans2.Text = Q7ans2
        Form1.ans3.Text = Q7ans3
        Form1.Label1.Text = qname

        qans1 = Q7ans1
        qans2 = Q7ans2
        qans3 = Q7ans3
        ansr = Q7ansr
        qtype = Q7type
        qname = Q7name

    End Sub
End Module

Module Q8 'E
    Public Q8name As String = "日本の20世紀ごろのpianoの表記は" '問題
    Public Q8type As String = "select"　'問題の種類（）
    Public Q8ans1 As String = "ピカソ"
    Public Q8ans2 As String = "ピャノ"
    Public Q8ans3 As String = "ピヤノ"
    Public Q8ansr As String = "ans3"
    Public Q8pict As Bitmap = My.Resources.piano_pic

    Public Sub initQ8()
        'qname = N & "name"
        qname = Q8name

        Form1.PictureBox1.Image = Q8pict

        Form1.ans1.Text = Q8ans1

        Form1.ans2.Text = Q8ans2
        Form1.ans3.Text = Q8ans3
        Form1.Label1.Text = qname

        qans1 = Q8ans1
        qans2 = Q8ans2
        qans3 = Q8ans3
        ansr = Q8ansr
        qtype = Q8type
        qname = Q8name

    End Sub
End Module

Module Q9
    Public Q9name As String = "1999年に人類が滅びると予言したのはだれ?" '問題 
    Public Q9type As String = "select"　'問題の種類（） 
    Public Q9ans1 As String = "シュタイナー"
    Public Q9ans2 As String = "クルト"
    Public Q9ans3 As String = "ノストラダムス"
    Public Q9ansr As String = "ans3"
    Public Q9pict As Bitmap = Nothing

    Public Sub initQ9()
        'qname = N & "name"
        qname = Q9name

        Form1.PictureBox1.Image = Q9pict

        Form1.ans1.Text = Q9ans1
        Form1.ans2.Text = Q9ans2
        Form1.ans3.Text = Q9ans3
        Form1.Label1.Text = qname

        qans1 = Q9ans1
        qans2 = Q9ans2
        qans3 = Q9ans3
        ansr = Q9ansr
        qtype = Q9type
        qname = Q9name

    End Sub
End Module
Module Q10 'N
    Public Q10name As String = "ソロンの改革があった街の神殿は" '問題 
    Public Q10type As String = "select"　'問題の種類（） 
    Public Q10ans1 As String = "万神殿"
    Public Q10ans2 As String = "パルテノン神殿"
    Public Q10ans3 As String = "エルサレム神殿"
    Public Q10ansr As String = "ans2"
    Public Q10pict As Bitmap = Nothing

    Public Sub initQ10()
        'qname = N & "name"
        qname = Q10name

        Form1.PictureBox1.Image = Q10pict

        Form1.ans1.Text = Q10ans1

        Form1.ans2.Text = Q10ans2
        Form1.ans3.Text = Q10ans3
        Form1.Label1.Text = qname

        qans1 = Q10ans1
        qans2 = Q10ans2
        qans3 = Q10ans3
        ansr = Q10ansr
        qtype = Q10type
        qname = Q10name

    End Sub
End Module

Module Q11 'E
    Public Q11name As String = "バロック・ヴァイオリンの弦は" '問題 
    Public Q11type As String = "select"　'問題の種類（） 
    Public Q11ans1 As String = "スティール弦"
    Public Q11ans2 As String = "ナイロン弦"
    Public Q11ans3 As String = "裸ガット弦"
    Public Q11ansr As String = "ans3"
    Public Q11pict As Bitmap = Nothing

    Public Sub initQ11()
        'qname = N & "name"
        qname = Q11name

        Form1.PictureBox1.Image = Q11pict

        Form1.ans1.Text = Q11ans1

        Form1.ans2.Text = Q11ans2
        Form1.ans3.Text = Q11ans3
        Form1.Label1.Text = qname

        qans1 = Q11ans1
        qans2 = Q11ans2
        qans3 = Q11ans3
        ansr = Q11ansr
        qtype = Q11type
        qname = Q11name

    End Sub
End Module

Module Q12
    Public Q12name As String = "絶世の美女と言われたクレオパトラ7世の愛人は" '問題 
    Public Q12type As String = "select"　'問題の種類（） 
    Public Q12ans1 As String = "アレクサンドロス"
    Public Q12ans2 As String = "ポンペイウス"
    Public Q12ans3 As String = "カエサル"
    Public Q12ansr As String = "ans3"
    Public Q12pict As Bitmap = Nothing

    Public Sub initQ12()
        'qname = N & "name"
        qname = Q12name

        Form1.PictureBox1.Image = Q12pict

        Form1.ans1.Text = Q12ans1

        Form1.ans2.Text = Q12ans2
        Form1.ans3.Text = Q12ans3
        Form1.Label1.Text = qname

        qans1 = Q12ans1
        qans2 = Q12ans2
        qans3 = Q12ans3
        ansr = Q12ansr
        qtype = Q12type
        qname = Q12name

    End Sub
End Module

Module Q13 'N
    Public Q13name As String = "落語の竹の水仙で正しいのはどれか" '問題 
    Public Q13type As String = "select"　'問題の種類（） 
    Public Q13ans1 As String = "主人公は作中の宿に泊まる間無一文だ”
    Public Q13ans2 As String = "竹の水仙は200両で売れた"
    Public Q13ans3 As String = “主人公は最後に100両渡した"
    Public Q13ansr As String = "ans1"
    Public Q13pict As Bitmap = Nothing

    Public Sub initQ13()
        'qname = N & "name"
        qname = Q13name

        Form1.PictureBox1.Image = Q13pict

        Form1.ans1.Text = Q13ans1

        Form1.ans2.Text = Q13ans2
        Form1.ans3.Text = Q13ans3
        Form1.Label1.Text = qname

        qans1 = Q13ans1
        qans2 = Q13ans2
        qans3 = Q13ans3
        ansr = Q13ansr
        qtype = Q13type
        qname = Q13name

    End Sub
End Module

Module Q14
    Public Q14name As String = "アルプホルンは何楽器か" '問題 
    Public Q14type As String = "select"　'問題の種類（） 
    Public Q14ans1 As String = "木管楽器”
    Public Q14ans2 As String = "金管楽器"
    Public Q14ans3 As String = “エアリード楽器"
    Public Q14ansr As String = "ans2"
    Public Q14pict As Bitmap = Nothing

    Public Sub initQ14()
        'qname = N & "name"
        qname = Q14name

        Form1.PictureBox1.Image = Q14pict


        Form1.ans1.Text = Q14ans1

        Form1.ans2.Text = Q14ans2
        Form1.ans3.Text = Q14ans3
        Form1.Label1.Text = qname

        qans1 = Q14ans1
        qans2 = Q14ans2
        qans3 = Q14ans3
        ansr = Q14ansr
        qtype = Q14type
        qname = Q14name

    End Sub
End Module

Module Q15
    Public Q15name As String = "ヴァイオリン奏法のデタシェとは" '問題 
    Public Q15type As String = "select"　'問題の種類（） 
    Public Q15ans1 As String = "同音を符頭で指定された音価で反復する”
    Public Q15ans2 As String = "一音ごとに弓を返して演奏すること"
    Public Q15ans3 As String = “駒から離れたところで使う奏法"
    Public Q15ansr As String = "ans2"
    Public Q15pict As Bitmap = Nothing
    Public Sub initQ15()
        qname = Q15name
        Form1.PictureBox1.Image = Q15pict
        Form1.ans1.Text = Q15ans1
        Form1.ans2.Text = Q15ans2
        Form1.ans3.Text = Q15ans3
        Form1.Label1.Text = qname
        qans1 = Q15ans1
        qans2 = Q15ans2
        qans3 = Q15ans3
        ansr = Q15ansr
        qtype = Q15type
        qname = Q15name
    End Sub
End Module