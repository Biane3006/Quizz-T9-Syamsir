Imports System.Data.OleDb
Imports System.Data
Imports System.IO
Imports System.Windows.Forms
Public Class CrudAdmin
    Dim aksi As String
    Dim PathDatabase As String = Application.StartupPath & "\Database T9.accdb"
    Public koneksi As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & PathDatabase)
    Private dataAdapter As OleDbDataAdapter
    Private BacaData As OleDbDataReader
    Private dataSet As New DataSet()
    Private Sub CrudAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi.Open()
        Dim querySelect As New OleDbCommand("SELECT * FROM tb_admin WHERE Id=" & MenuAdmin.tbId.Text, koneksi)
        BacaData = querySelect.ExecuteReader()
        If BacaData.Read() Then
            tbUsername.Text = BacaData.GetString(1)
            tbPassword.Text = BacaData.GetString(2)
            BacaData.Close()
            aksi = "Edit"
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        aksi = "Tambah"
        Call BersihkanForm()
        btnSimpan.Enabled = True
        btnTambah.Enabled = False
    End Sub

    Sub BersihkanForm()
        tbUsername.Text = ""
        tbPassword.Text = ""
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If aksi = "Tambah" Then
            Dim queryInsert As New OleDbCommand("INSERT INTO tb_admin (Username,Password) VALUES('" & tbUsername.Text & "','" & tbPassword.Text & "'", koneksi)
            queryInsert.ExecuteNonQuery()
            aksi = "Edit"
        ElseIf aksi = "Edit" Then
            Dim queryUpdate As New OleDbCommand("UPDATE tb_admin SET Username='" & tbUsername.Text & "', Password='" & tbPassword.Text & "' WHERE Id=" & MenuAdmin.tbId.Text, koneksi)
            queryUpdate.ExecuteNonQuery()
        End If
    End Sub
End Class