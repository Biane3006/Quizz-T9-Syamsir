Imports System.Data.OleDb
Imports System.Data
Imports System.IO
Imports System.Windows.Forms
Public Class CrudSoal
    Dim Aksi As String
    Dim PathDatabase As String = Application.StartupPath & "\Database T9.accdb"
    Public koneksi As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & PathDatabase)
    Private dataAdapter As OleDbDataAdapter
    Private BacaData As OleDbDataReader
    Private dataSet As New DataSet()
    Private Sub CrudSoal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi.Open()
        Call ReadData()
        Call MengaturGrid()
        Call DisableComponent()
    End Sub

    Sub MengaturGrid()
        With DataGridView1
            .Columns(0).HeaderText = "Id"
            .Columns(0).Width = 80
            .Columns(0).Visible = False
            .Columns(1).HeaderText = "Pertanyaan"
            .Columns(1).Width = 380
            .Columns(2).HeaderText = "Kunci Jawaban"
            .Columns(2).Width = 120
            .Columns(3).HeaderText = "Jawaban Peserta"
            .Columns(3).Width = 150
            .Columns(3).Visible = False
        End With
    End Sub

    Private Sub ReadData()
        dataAdapter = New OleDbDataAdapter("SELECT * FROM tb_soal", koneksi)
        dataSet.Clear()
        dataAdapter.Fill(dataSet, "tb_soal")
        DataGridView1.DataSource = dataSet.Tables("tb_soal")
    End Sub

    Sub BersihkanForm()
        tbPertanyaan.Text = ""
        rbTrue.Checked = False
        rbFalse.Checked = False
    End Sub

    Sub EnableComponent()
        GroupBox1.Enabled = True
    End Sub

    Sub DisableComponent()
        GroupBox1.Enabled = False
        btnSimpan.Enabled = False
        btnBatal.Enabled = False
    End Sub
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Aksi = "Tambah"
        Call BersihkanForm()
        Call EnableComponent()
        btnSimpan.Enabled = True
        btnBatal.Enabled = True
        btnTambah.Enabled = False
        btnEdit.Enabled = False
        btnHapus.Enabled = False
        DataGridView1.Enabled = False
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Aksi = "Edit"
        Call EnableComponent()
        btnSimpan.Enabled = True
        btnBatal.Enabled = True
        btnTambah.Enabled = False
        btnEdit.Enabled = False
        btnHapus.Enabled = False
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim valueRadioButton As String
        If rbTrue.Checked Then
            valueRadioButton = rbTrue.Text
        Else
            valueRadioButton = rbFalse.Text
        End If
        Dim queryDelete As New OleDbCommand("DELETE FROM tb_soal WHERE Id=" & tbId.Text, koneksi)
        queryDelete.ExecuteNonQuery()
        Call ReadData()
        Call BersihkanForm()
        DataGridView1.Focus()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Call BersihkanForm()
        Call DisableComponent()
        btnTambah.Enabled = True
        btnEdit.Enabled = True
        btnHapus.Enabled = True
        DataGridView1.Enabled = True
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Aksi.Equals("Tambah") Then
            'Aksi = TAMBAH DATA
            '1. Cek Form nya dulu, apakah sudah terisi semua
            If tbPertanyaan.Text = "" Then
                MessageBox.Show("Pertanyaan Tidak Boleh Kosong !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                tbPertanyaan.Focus()
            ElseIf Not rbTrue.Checked And Not rbFalse.Checked Then
                MessageBox.Show("Pilih Kunci Jawaban", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim valueRadioButton As String
                If rbTrue.Checked Then
                    valueRadioButton = rbTrue.Text
                Else
                    valueRadioButton = rbFalse.Text
                End If
                Dim queryInput As New OleDbCommand("INSERT INTO tb_soal (Pertanyaan,Kunci_Jawaban) VALUES ('" & tbPertanyaan.Text & "','" & valueRadioButton & "')", koneksi)
                queryInput.ExecuteNonQuery()
                Call ReadData()
                Call DisableComponent()
                DataGridView1.Enabled = True
                btnTambah.Enabled = True
                btnEdit.Enabled = True
                btnHapus.Enabled = True
                DataGridView1.Focus()
            End If
        Else
            'edit
            '1. Cek Form nya dulu, apakah sudah terisi semua
            If tbPertanyaan.Text = "" Then
                MessageBox.Show("Pertanyaan Tidak Boleh Kosong !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                tbPertanyaan.Focus()
            ElseIf Not rbTrue.Checked And Not rbFalse.Checked Then
                MessageBox.Show("Pilih Kunci Jawaban", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim valueRadioButton As String
                If rbTrue.Checked Then
                    valueRadioButton = rbTrue.Text
                Else
                    valueRadioButton = rbFalse.Text
                End If
                Dim queryUpdate As New OleDbCommand("UPDATE tb_soal SET Pertanyaan='" & tbPertanyaan.Text & "',Kunci_Jawaban='" & valueRadioButton & "' WHERE Id=" & tbId.Text, koneksi)
                queryUpdate.ExecuteNonQuery()
                Call ReadData()
                Call DisableComponent()
                btnTambah.Enabled = True
                btnEdit.Enabled = True
                btnHapus.Enabled = True
                DataGridView1.Focus()
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        tbId.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
        tbPertanyaan.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
        If DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString.Equals("True") Then
            rbTrue.Checked = True
        Else
            rbFalse.Checked = True
        End If
    End Sub
End Class