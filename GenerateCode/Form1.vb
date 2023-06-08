Imports System.Data.OleDb
Imports System.Data
Imports System.IO
Imports System.Windows.Forms

Public Class Form1
    Dim PathDatabase As String = Application.StartupPath & "\Database T9.accdb"
    Public koneksi As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & PathDatabase)
    Private dataAdapter As OleDbDataAdapter
    Private BacaData As OleDbDataReader
    Private dataSet As New DataSet()

    Private Function GenerateCode() As String
        Dim rnd As New Random()
        Dim code As String = ""
        Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz1234567890"
        Dim codeLength As Integer = 8
        For i As Integer = 0 To codeLength - 1
            Dim randomIndex As Integer = rnd.Next(0, allowedChars.Length)
            code += allowedChars(randomIndex)
        Next
        Return code
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi.Open()
        Dim querySelect As New OleDbCommand("SELECT * FROM KodeAplikasi", koneksi)
        BacaData = querySelect.ExecuteReader()
        If BacaData.Read() Then
            If BacaData.GetValue(0).ToString = "" Then
                tbKodeAplikasi.Text = GenerateCode()
                Dim queryUpdate As New OleDbCommand("UPDATE KodeAplikasi SET Kode='" & tbKodeAplikasi.Text & "',Status=False", koneksi)
                queryUpdate.ExecuteNonQuery()
            Else
                tbKodeAplikasi.Text = BacaData.GetValue(0).ToString
            End If
        End If
        BacaData.Close()
    End Sub
End Class
