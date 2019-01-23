Public Class Form2
    Public Function IsConnectionAvailable() As Boolean
        Dim objUrl As New System.Uri("http://www.google.com")
        Dim objWebReq As System.Net.WebRequest
        objWebReq = System.Net.WebRequest.Create(objUrl)
        Dim objresp As System.Net.WebResponse

        Try
            objresp = objWebReq.GetResponse
            objresp.Close()
            objresp = Nothing
            Return True

        Catch ex As Exception
            objresp = Nothing
            objWebReq = Nothing
            Return False
        End Try
    End Function

    Public Sub updatecheck()
        If IsConnectionAvailable() = True Then
            Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://raw.githubusercontent.com/unblockhostid/unblockhostid.github.io/master/version.txt")
            Dim response As System.Net.HttpWebResponse = request.GetResponse()
            Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
            Dim newestversion As String = sr.ReadToEnd()
            Dim currentversion As String = Application.ProductVersion
            If newestversion.Contains(currentversion) Then
                MsgBox("Kamu sedang menggunakan versi terbaru")
            Else
                MsgBox("Versi baru tersedia, silahkan kunjungi website untuk update")
            End If
        Else
            MsgBox("Tidak bisa mengecek update, kamu sedang tidak terkoneksi internet")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        updatecheck()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        IO.File.WriteAllBytes("C:\Windows\Temp\ubhnonid.exe", My.Resources.ubhnonid)
        Process.Start("C:\Windows\Temp\ubhnonid.exe")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        IO.File.WriteAllBytes("C:\Windows\Temp\flushdns.bat", My.Resources.flushdns)
        Process.Start("C:\Windows\Temp\flushdns.bat")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        IO.File.WriteAllBytes("C:\Windows\Temp\vpn.exe", My.Resources.VPN)
        Process.Start("C:\Windows\Temp\vpn.exe")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        IO.File.Delete("C:\Windows\System32\drivers\etc\hosts")
        IO.File.WriteAllBytes("C:\Windows\System32\drivers\etc\hosts", My.Resources.hosts_original)
        MsgBox("Sukses, hosts anda telah kembali ke awal", MsgBoxStyle.Information)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Process.Start("https://github.com/gvoze32/unblockhostid/raw/master/UNBLOCKHOSTID.exe")
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        IO.File.WriteAllBytes("C:\Windows\Temp\mac.exe", My.Resources.mac)
        Process.Start("C:\Windows\Temp\mac.exe")
    End Sub
End Class