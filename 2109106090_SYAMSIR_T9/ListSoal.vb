Imports System.Data.OleDb
Imports System.Data
Imports System.IO
Imports System.Windows.Forms

Public Class ListSoal
    Dim NilaiAkhir As Integer = 0
    Dim SoalBenar As Integer = 0
    Dim SoalSalah As Integer = 0
    Dim SoalTidakTerjawab As Integer = 0
    Dim Aksi As String
    Dim PathDatabase As String = Application.StartupPath & "\Database T9.accdb"
    Public koneksi As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & PathDatabase)
    Private dataAdapter As OleDbDataAdapter
    Private BacaData As OleDbDataReader
    Private dataSet As New DataSet()
    Private currentIndex As Integer = 0
    Private Sub ListSoal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi.Open()
        Call ReadData()
        FocusData(currentIndex)
        Label1.Text = DataGridView1.Rows.Count
        Label2.Text = currentIndex + 1
    End Sub

    Private Sub ReadData()
        dataAdapter = New OleDbDataAdapter("SELECT * FROM tb_soal", koneksi)
        dataSet.Clear()
        dataAdapter.Fill(dataSet, "tb_soal")
        DataGridView1.DataSource = dataSet.Tables("tb_soal")
        FocusData(currentIndex)
    End Sub

    Private Sub rbTrue_CheckedChanged(sender As Object, e As EventArgs) Handles rbTrue.CheckedChanged
        Dim queryUpdate As New OleDbCommand("UPDATE tb_soal SET Jawaban_Peserta='" & rbTrue.Text & "' WHERE Id=" & tbId.Text, koneksi)
        queryUpdate.ExecuteNonQuery()
        ReadData()
    End Sub

    Private Sub rbFalse_CheckedChanged(sender As Object, e As EventArgs) Handles rbFalse.CheckedChanged
        Dim queryUpdate As New OleDbCommand("UPDATE tb_soal SET Jawaban_Peserta='" & rbFalse.Text & "' WHERE Id=" & tbId.Text, koneksi)
        queryUpdate.ExecuteNonQuery()
        ReadData()
    End Sub

    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        tbId.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
        tbPertanyaan.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
    End Sub

    Private Sub FocusData(index As Integer)
        If index >= 0 And index < DataGridView1.Rows.Count Then
            DataGridView1.CurrentCell = DataGridView1.Rows(index).Cells(0)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < DataGridView1.Rows.Count - 1 Then
            currentIndex += 1
            Label2.Text = currentIndex + 1
            FocusData(currentIndex)
            If DataGridView1.Rows(currentIndex).Cells(3).Value.ToString.Equals("True") Then
                rbTrue.Checked = True
            ElseIf DataGridView1.Rows(currentIndex).Cells(3).Value.ToString.Equals("False") Then
                rbFalse.Checked = True
            Else
                rbTrue.Checked = False
                rbFalse.Checked = False
            End If
        End If
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            Label2.Text = currentIndex + 1
            FocusData(currentIndex)
            If DataGridView1.Rows(currentIndex).Cells(3).Value.ToString.Equals("True") Then
                rbTrue.Checked = True
            ElseIf DataGridView1.Rows(currentIndex).Cells(3).Value.ToString.Equals("False") Then
                rbFalse.Checked = True
            Else
                rbTrue.Checked = False
                rbFalse.Checked = False
            End If
        End If
    End Sub

    Private Sub Label2_TextChanged(sender As Object, e As EventArgs) Handles Label2.TextChanged
        If (currentIndex + 1).ToString = Label1.Text Then
            btnSubmitJawaban.Visible = True
        Else
            btnSubmitJawaban.Visible = False
        End If
    End Sub

    Private Sub btnSubmitJawaban_Click(sender As Object, e As EventArgs) Handles btnSubmitJawaban.Click
        MessageBox.Show("Anda Tidak Dapat Mengubah Jawaban Anda Setelah Terkirim. Kirim Jawaban?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If DialogResult.Yes Then
            NilaiAkhir = 0
            SoalBenar = 0
            SoalSalah = 0
            SoalTidakTerjawab = 0
            For Each baris As DataGridViewRow In DataGridView1.Rows
                If baris.Cells(3).Value.ToString = baris.Cells(2).Value.ToString Then
                    NilaiAkhir += 2
                    SoalBenar += 1
                ElseIf baris.Cells(3).Value.ToString = "" Then
                    NilaiAkhir += 0
                    SoalTidakTerjawab += 1
                Else
                    NilaiAkhir -= 1
                    SoalSalah += 1
                End If
            Next
            Hasil_Quiz.tbBenar.Text = SoalBenar
            Hasil_Quiz.tbSalah.Text = SoalSalah
            Hasil_Quiz.tbTidakTerjawab.Text = SoalTidakTerjawab
            Hasil_Quiz.tbNilai.Text = NilaiAkhir
            Dim queryUpdate As New OleDbCommand("UPDATE tb_soal SET Jawaban_Peserta=''", koneksi)
            queryUpdate.ExecuteNonQuery()
            Hasil_Quiz.Show()
            Me.Close()
        Else
            'Nothing
        End If
    End Sub
End Class