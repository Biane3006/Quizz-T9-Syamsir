<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hasil_Quiz
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbNama = New System.Windows.Forms.Label()
        Me.tbNISN = New System.Windows.Forms.Label()
        Me.tbSalah = New System.Windows.Forms.Label()
        Me.tbBenar = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbNilai = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbTidakTerjawab = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(81, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 30)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "NISN  :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(81, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 30)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Nama :"
        '
        'tbNama
        '
        Me.tbNama.AutoSize = True
        Me.tbNama.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNama.Location = New System.Drawing.Point(170, 38)
        Me.tbNama.Name = "tbNama"
        Me.tbNama.Size = New System.Drawing.Size(71, 30)
        Me.tbNama.TabIndex = 10
        Me.tbNama.Text = "Nama"
        '
        'tbNISN
        '
        Me.tbNISN.AutoSize = True
        Me.tbNISN.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNISN.Location = New System.Drawing.Point(170, 79)
        Me.tbNISN.Name = "tbNISN"
        Me.tbNISN.Size = New System.Drawing.Size(66, 30)
        Me.tbNISN.TabIndex = 11
        Me.tbNISN.Text = "NISN"
        '
        'tbSalah
        '
        Me.tbSalah.AutoSize = True
        Me.tbSalah.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSalah.Location = New System.Drawing.Point(108, 57)
        Me.tbSalah.Name = "tbSalah"
        Me.tbSalah.Size = New System.Drawing.Size(66, 30)
        Me.tbSalah.TabIndex = 15
        Me.tbSalah.Text = "Salah"
        '
        'tbBenar
        '
        Me.tbBenar.AutoSize = True
        Me.tbBenar.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbBenar.Location = New System.Drawing.Point(105, 27)
        Me.tbBenar.Name = "tbBenar"
        Me.tbBenar.Size = New System.Drawing.Size(69, 30)
        Me.tbBenar.TabIndex = 14
        Me.tbBenar.Text = "Benar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 30)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Salah  :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(10, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 30)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Benar :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbTidakTerjawab)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tbNilai)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.tbSalah)
        Me.GroupBox1.Controls.Add(Me.tbBenar)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(86, 134)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(365, 250)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Hasil Quiz"
        '
        'tbNilai
        '
        Me.tbNilai.AutoSize = True
        Me.tbNilai.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNilai.Location = New System.Drawing.Point(164, 197)
        Me.tbNilai.Name = "tbNilai"
        Me.tbNilai.Size = New System.Drawing.Size(43, 50)
        Me.tbNilai.TabIndex = 17
        Me.tbNilai.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(125, 167)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 30)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Nilai Akhir"
        '
        'tbTidakTerjawab
        '
        Me.tbTidakTerjawab.AutoSize = True
        Me.tbTidakTerjawab.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTidakTerjawab.Location = New System.Drawing.Point(196, 87)
        Me.tbTidakTerjawab.Name = "tbTidakTerjawab"
        Me.tbTidakTerjawab.Size = New System.Drawing.Size(162, 30)
        Me.tbTidakTerjawab.TabIndex = 19
        Me.tbTidakTerjawab.Text = "Tidak Terjawab"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 30)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Tidak Terjawab  :"
        '
        'btnKembali
        '
        Me.btnKembali.BackColor = System.Drawing.Color.Transparent
        Me.btnKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKembali.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKembali.ForeColor = System.Drawing.Color.Black
        Me.btnKembali.Location = New System.Drawing.Point(86, 411)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(183, 62)
        Me.btnKembali.TabIndex = 64
        Me.btnKembali.Text = "Kembali Ke Menu Awal"
        Me.btnKembali.UseVisualStyleBackColor = False
        '
        'Hasil_Quiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 485)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tbNISN)
        Me.Controls.Add(Me.tbNama)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Hasil_Quiz"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hasil_Quiz"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbNama As System.Windows.Forms.Label
    Friend WithEvents tbNISN As System.Windows.Forms.Label
    Friend WithEvents tbSalah As System.Windows.Forms.Label
    Friend WithEvents tbBenar As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tbNilai As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tbTidakTerjawab As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnKembali As System.Windows.Forms.Button
End Class
