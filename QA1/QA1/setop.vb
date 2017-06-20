Public Class setop
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True Then
            My.Settings.sound = "True"
        Else
            My.Settings.sound = "False"
        End If
        Me.Close()
    End Sub

    Private Sub setop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.sound = "True" Then
            CheckBox1.Checked = True
        Else
            CheckBox1.Checked = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub
End Class
