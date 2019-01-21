Imports System.IO
Public Class Form1
    Public Sub Exix_Click(sender As Object, e As EventArgs) Handles Exix.Click

        Dim paths As List(Of String) = New List(Of String)
        paths.Add("C:\Windows\Temp\ubhnonid.exe")
        paths.Add("C:\Windows\Temp\flushdns.bat")
        paths.Add("C:\Windows\Temp\vpn.exe")
        'Delete all file
        For Each loc As String In paths
            File.Delete(loc)
        Next

        KeluarDariApp()
        Status.Text = "Menutup Aplikasi"
        MsgBox("Risiko ditanggung sendiri, kami tidak bertanggung jawab atas dampak yang ditimbulkan dari penggunaan aplikasi ini tolong gunakan dengan bijak. Terima Kasih.", MsgBoxStyle.Information)
        Me.Close()
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Status.Text = "Program berhasil dijalankan"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form9.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form2.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If My.Computer.FileSystem.FileExists("C:\Windows\System32\drivers\etc\hosts") Then
            Status.Text = "Mengecek file hosts"

            File.Delete("C:\Windows\System32\drivers\etc\hosts")
            Status.Text = "Memasang file hosts"

            File.WriteAllBytes("C:\Windows\System32\drivers\etc\hosts", My.Resources.hosts)
            MsgBox("Sukses, hosts telah terpasang", MsgBoxStyle.Information)
            Status.Text = "Sukses, hosts telah terpasang"

        Else
            Status.Text = "Memasang...."
            File.WriteAllBytes("C:\Windows\System32\drivers\etc\hosts", My.Resources.hosts)
            MsgBox("Sukses, hosts telah terpasang", MsgBoxStyle.Information)
            Status.Text = "Sukses, hosts telah terpasang"
        End If

        Dim pasang As Button = DirectCast(sender, Button)
        pasang.Enabled = False
    End Sub
End Class