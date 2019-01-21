Public Class Form9

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("https://unblockhostid.github.io/")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Process.Start("https://github.com/gvoze32/unblockhostid/blob/master/CHANGELOG.md")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("https://github.com/gvoze32/unblockhostid/blob/master/raw.txt")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        IO.File.Delete("C:\Windows\System32\drivers\etc\hosts")
        IO.File.WriteAllBytes("C:\Windows\System32\drivers\etc\hosts", My.Resources.hosts_original)
        MsgBox("Sukses, hosts anda telah kembali ke awal", MsgBoxStyle.Information)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Process.Start("https://github.com/gvoze32/unblockhostid/raw/master/UNBLOCKHOSTID.exe")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Process.Start("https://github.com/gvoze32/unblockhostid/blob/master/SITES.md")
    End Sub
End Class