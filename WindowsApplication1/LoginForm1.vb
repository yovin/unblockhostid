Imports System.Data.OleDb
Imports System.IO

Public Class LoginForm1

    ' Sengaja di kasih public, biar konek ama Module1
    Public con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Windows\temp\dbu.mdb;Jet OLEDB:Database Password=l0k0nt0l;")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myfilename As String = "C:\Windows\Temp\dbu.mdb"
        IO.File.WriteAllBytes(myfilename, My.Resources.dbu)

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [Table1] WHERE [name] = '" & TextBox1.Text & "' AND [password] = '" & TextBox2.Text & "'", con)
        Dim user As String = ""
        Dim pass As String = ""

        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Isian masih kosong!", MsgBoxStyle.Information, "Informasi")
        Else
            con.Open()
            Dim sdr As OleDbDataReader = cmd.ExecuteReader
            If sdr.Read = True Then
                user = "username"
                pass = "password"
                Me.Visible = False
                Form1.Show()
            Else
                con.Close()
                MessageBox.Show("Login Gagal!")
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox1.Focus()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        KeluarDariApp()
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form7.Show()
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Default tombol Login
        Me.AcceptButton = Button1
        Button1.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub
End Class
