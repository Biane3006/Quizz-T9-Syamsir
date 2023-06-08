<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPeraturanQuiz
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbNama = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbNisn = New System.Windows.Forms.TextBox()
        Me.btnMulai = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(113, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Peraturan Quiz :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(113, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(226, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "1. Soal Benar Nilai +2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(113, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(219, 30)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "2. Soal Benar Nilai -1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(113, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(256, 30)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "3. Tidak Terjawab Nilai 0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(113, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 30)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Nama :"
        '
        'tbNama
        '
        Me.tbNama.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNama.Location = New System.Drawing.Point(225, 197)
        Me.tbNama.MaxLength = 100
        Me.tbNama.Name = "tbNama"
        Me.tbNama.Size = New System.Drawing.Size(204, 33)
        Me.tbNama.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(113, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 30)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "NISN"
        '
        'tbNisn
        '
        Me.tbNisn.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNisn.Location = New System.Drawing.Point(225, 236)
        Me.tbNisn.MaxLength = 100
        Me.tbNisn.Name = "tbNisn"
        Me.tbNisn.Size = New System.Drawing.Size(204, 33)
        Me.tbNisn.TabIndex = 6
        '
        'btnMulai
        '
        Me.btnMulai.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnMulai.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMulai.Location = New System.Drawing.Point(225, 304)
        Me.btnMulai.Name = "btnMulai"
        Me.btnMulai.Size = New System.Drawing.Size(108, 34)
        Me.btnMulai.TabIndex = 8
        Me.btnMulai.Text = "MULAI"
        Me.btnMulai.UseVisualStyleBackColor = False
        '
        'MenuPeraturanQuiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 400)
        Me.Controls.Add(Me.btnMulai)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbNisn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbNama)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MenuPeraturanQuiz"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuPeraturanQuiz"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbNama As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbNisn As System.Windows.Forms.TextBox
    Friend WithEvents btnMulai As System.Windows.Forms.Button
End Class
