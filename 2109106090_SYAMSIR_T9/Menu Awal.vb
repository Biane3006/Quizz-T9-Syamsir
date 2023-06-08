Imports System.IO
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.Threading
Imports System.Data.OleDb
Imports System.Data
Public Class Menu_Awal
    Dim PathDatabase As String = Application.StartupPath & "\Database T9.accdb"
    Public koneksi As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & PathDatabase)
    Private dataAdapter As OleDbDataAdapter
    Private BacaData As OleDbDataReader
    Private dataSet As New DataSet()
    Private Sub Menu_Awal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi.Open()
    End Sub


    'Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint
    '    e.Graphics.TranslateTransform(0, 0)
    '    Dim animationSpeed As Single = 0.005
    '    Dim currentImage As Image = Image.FromFile(imageFile(currentImageIndex))
    '    e.Graphics.DrawImage(currentImage, 0, 0, PictureBox1.Width, PictureBox1.Height)
    '    e.Graphics.ResetTransform()
    '    currentImageIndex += 1
    '    If currentImageIndex >= imageFile.Length Then
    '        currentImageIndex = 0
    '    End If

    '    Thread.Sleep(2000)
    '    PictureBox1.Invalidate()
    'End Sub

    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click
        LoginAdmin.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub btnQuiz_Click(sender As Object, e As EventArgs) Handles btnQuiz.Click
        Dim querySelect As New OleDbCommand("SELECT * FROM KodeAplikasi", koneksi)
        BacaData = querySelect.ExecuteReader()
        If BacaData.Read() Then
            If BacaData.GetValue(0).ToString = "" Or BacaData.GetBoolean(1) = True Then
                BacaData.Close()
                MessageBox.Show("Kesempatan Quiz Telah Habis, Silahkan Hubungi Admin Untuk Membuat Kode Baru Agar dapat memulai Quiz Baru !!!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                BacaData.Close()
                MenuPeraturanQuiz.Show()
                Dim queryUpdate As New OleDbCommand("UPDATE KodeAplikasi SET Status=True", koneksi)
                queryUpdate.ExecuteNonQuery()
                Me.Close()
            End If
        End If
    End Sub
End Class