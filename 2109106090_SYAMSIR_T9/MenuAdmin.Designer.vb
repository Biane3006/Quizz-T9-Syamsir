<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuAdmin
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BankSoalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengaturanAkunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerateKodeBaruToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbId = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BankSoalToolStripMenuItem, Me.PengaturanAkunToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.GenerateKodeBaruToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(730, 40)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BankSoalToolStripMenuItem
        '
        Me.BankSoalToolStripMenuItem.Name = "BankSoalToolStripMenuItem"
        Me.BankSoalToolStripMenuItem.Size = New System.Drawing.Size(131, 36)
        Me.BankSoalToolStripMenuItem.Text = "Bank Soal"
        '
        'PengaturanAkunToolStripMenuItem
        '
        Me.PengaturanAkunToolStripMenuItem.Name = "PengaturanAkunToolStripMenuItem"
        Me.PengaturanAkunToolStripMenuItem.Size = New System.Drawing.Size(211, 36)
        Me.PengaturanAkunToolStripMenuItem.Text = "Pengaturan Akun"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(102, 36)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'GenerateKodeBaruToolStripMenuItem
        '
        Me.GenerateKodeBaruToolStripMenuItem.Name = "GenerateKodeBaruToolStripMenuItem"
        Me.GenerateKodeBaruToolStripMenuItem.Size = New System.Drawing.Size(241, 36)
        Me.GenerateKodeBaruToolStripMenuItem.Text = "Generate Kode Baru"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tbId)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(730, 350)
        Me.Panel1.TabIndex = 2
        '
        'tbId
        '
        Me.tbId.Location = New System.Drawing.Point(83, 73)
        Me.tbId.Name = "tbId"
        Me.tbId.Size = New System.Drawing.Size(100, 20)
        Me.tbId.TabIndex = 0
        Me.tbId.Visible = False
        '
        'MenuAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 390)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MenuAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Admin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents BankSoalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PengaturanAkunToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tbId As System.Windows.Forms.TextBox
    Friend WithEvents GenerateKodeBaruToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
