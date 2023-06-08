Imports System.Data.OleDb
Imports System.Data
Imports System.IO
Imports System.Windows.Forms


Public Class LoginAdmin
    Dim Aksi As String
    Dim PathDatabase As String = Application.StartupPath & "\Database T9.accdb"
    Public koneksi As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & PathDatabase)
    Private dataAdapter As OleDbDataAdapter
    Private BacaData As OleDbDataReader
    Private dataSet As New DataSet()
    Private Sub LoginAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi.Open()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim querySelect As New OleDbCommand("SELECT * FROM tb_admin WHERE Username='" & tbUsername.Text & "' AND Password='" & tbPassword.Text & "'", koneksi)
        BacaData = querySelect.ExecuteReader()
        If BacaData.Read() Then
            'Masuk ke menu admin
            MenuAdmin.tbId.Text = BacaData.GetInt32(0)
            MenuAdmin.Show()
            Menu_Awal.Close()
            Me.Close()
        Else
            MessageBox.Show("Username dan Password Salah !!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class