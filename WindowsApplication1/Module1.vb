Module Module1
    ' Gua buat kek gini biar ga ribet kopas, mending manggil daripada kopas :"v
    Public Sub KeluarDariApp()
        If My.Computer.FileSystem.FileExists("C:\Windows\Temp\raw") Then
            My.Computer.FileSystem.DeleteFile("C:\Windows\Temp\raw")
        End If
        If My.Computer.FileSystem.FileExists("C:\Windows\Temp\sites") Then
            My.Computer.FileSystem.DeleteFile("C:\Windows\Temp\sites")
        End If
        If My.Computer.FileSystem.FileExists("C:\Windows\Temp\changelog") Then
            My.Computer.FileSystem.DeleteFile("C:\Windows\Temp\changelog")
        End If
        If My.Computer.FileSystem.FileExists("C:\Windows\Temp\HostsInject.bat") Then
            My.Computer.FileSystem.DeleteFile("C:\Windows\Temp\HostsInject.bat")
        End If
        If My.Computer.FileSystem.FileExists("C:\Windows\Temp\HostsInject2.bat") Then
            My.Computer.FileSystem.DeleteFile("C:\Windows\Temp\HostsInject2.bat")
        End If
        If My.Computer.FileSystem.FileExists("C:\Windows\Temp\vpn.exe") Then
            My.Computer.FileSystem.DeleteFile("C:\Windows\Temp\vpn.exe")
        End If
        If My.Computer.FileSystem.DirectoryExists("%userprofile%\documents\vpnconnector") Then
            My.Computer.FileSystem.DeleteDirectory("%userprofile%\documents\vpnconnector", FileIO.DeleteDirectoryOption.DeleteAllContents)
        End If
        If My.Computer.FileSystem.FileExists("C:\Windows\Temp\flushdns.bat") Then
            My.Computer.FileSystem.DeleteFile("C:\Windows\Temp\flushdns.bat")
        End If
        If My.Computer.FileSystem.FileExists("C:\Windows\Temp\dbu.mdb") Then
            LoginForm1.con.Close()
            My.Computer.FileSystem.DeleteFile("C:\Windows\Temp\dbu.mdb")
        End If
    End Sub
End Module
