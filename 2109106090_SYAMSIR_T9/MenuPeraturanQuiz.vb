Imports System.Data.OleDb
Imports System.Data
Imports System.IO
Imports System.Windows.Forms

Public Class MenuPeraturanQuiz
    Private Sub btnMulai_Click(sender As Object, e As EventArgs) Handles btnMulai.Click
        If tbNama.Text = "" Then
            MessageBox.Show("Nama Tidak Boleh Kosong !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf tbNisn.Text = "" Then
            MessageBox.Show("NISN Tidak Boleh Kosong !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            MessageBox.Show("Apakah Anda Ingin Memulai Kuis? !!!", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If DialogResult.Yes Then
                Hasil_Quiz.tbNama.Text = tbNama.Text
                Hasil_Quiz.tbNISN.Text = tbNisn.Text
                ListSoal.Show()
                Me.Close()
            End If
        End If
    End Sub
End Class