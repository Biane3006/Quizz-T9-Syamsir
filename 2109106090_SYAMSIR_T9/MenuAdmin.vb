Imports System.Data.OleDb
Imports System.Data
Imports System.IO
Imports System.Windows.Forms

Public Class MenuAdmin
    Dim Aksi As String
    Dim PathDatabase As String = Application.StartupPath & "\Database T9.accdb"
    Public koneksi As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & PathDatabase)
    Private dataAdapter As OleDbDataAdapter
    Private BacaData As OleDbDataReader
    Private dataSet As New DataSet()
    Private Sub MenuAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi.Open()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Menu_Awal.Show()
        Me.Close()
    End Sub

    Private Sub BankSoalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BankSoalToolStripMenuItem.Click
        With CrudSoal
            .TopLevel = False
            Panel1.Controls.Clear()
            .Dock = DockStyle.Fill
            Panel1.Controls.Add(CrudSoal)
            .Location = New Point(0, 0)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub PengaturanAkunToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengaturanAkunToolStripMenuItem.Click
        With CrudAdmin
            .TopLevel = False
            Panel1.Controls.Clear()
            .Dock = DockStyle.Fill
            Panel1.Controls.Add(CrudAdmin)
            .Location = New Point(0, 0)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub GenerateKodeBaruToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerateKodeBaruToolStripMenuItem.Click
        Dim queryUpdate As New OleDbCommand("UPDATE KodeAplikasi SET Kode='', Status=False", koneksi)
        queryUpdate.ExecuteNonQuery()
        MessageBox.Show("Kode Telah Diperbarui, Silahkan Jalankan Aplikasi GenerateCode Kemabli unutk mendapatakan Kode Baru !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class