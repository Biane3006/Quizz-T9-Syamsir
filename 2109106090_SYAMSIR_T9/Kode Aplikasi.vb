Imports System.Data.OleDb
Imports System.Data
Imports System.IO
Imports System.Windows.Forms

Public Class Kode_Aplikasi
    Dim PathDatabase As String = Application.StartupPath & "\Database T9.accdb"
    Public koneksi As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & PathDatabase)
    Private dataAdapter As OleDbDataAdapter
    Private BacaData As OleDbDataReader
    Private dataSet As New DataSet()

    Private Sub Kode_Aplikasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi.Open()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim querySelect As New OleDbCommand("SELECT * FROM KodeAplikasi", koneksi)
        BacaData = querySelect.ExecuteReader()
        If BacaData.Read() Then
            If tbKodeAwal.Text = "" Then
                MessageBox.Show("Silahkan Masukkan Kode Aplikasi", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf BacaData.GetValue(0).ToString = "" Then
                MessageBox.Show("Silahkan Jalankan Aplikasi GenerateCode Terlebih dahulu untuk mendapatkan Kode Baru", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf BacaData.GetValue(0).ToString = tbKodeAwal.Text Then
                Menu_Awal.Show()
                Me.Close()
            Else
                MessageBox.Show("Kode Salah, Silahkan Buka Aplikasi GenerateCode!!!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        BacaData.Close()
    End Sub
End Class