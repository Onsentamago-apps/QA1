Public Class setop
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True Then
            My.Settings.detal = True
        Else
            My.Settings.detal = False
        End If
        Me.Close()
    End Sub

    Private Sub setop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.detal = True Then
            CheckBox1.Checked = True
        Else
            CheckBox1.Checked = False
        End If
    End Sub

End Class
