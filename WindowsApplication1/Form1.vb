Imports System.IO
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Status.Text = "Program berhasil dijalankan"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Status.Text = "Options"
        Form9.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Status.Text = "Settings"
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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim paths As List(Of String) = New List(Of String)
        paths.Add("C:\Windows\Temp\ubhnonid.exe")
        paths.Add("C:\Windows\Temp\flushdns.bat")
        paths.Add("C:\Windows\Temp\vpn.exe")
        paths.Add("C:\Windows\Temp\mac.exe")
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

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Status.Text = "About"
        MsgBox("Script ini dapat membantu anda untuk bypass semua konten website yang diblokir Internet Positif melalui file hosts.", MsgBoxStyle.Information)
    End Sub
End Class