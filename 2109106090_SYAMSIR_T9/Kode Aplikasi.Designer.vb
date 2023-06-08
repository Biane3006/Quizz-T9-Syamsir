<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kode_Aplikasi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Kode_Aplikasi))
        Me.tbKodeAwal = New System.Windows.Forms.TextBox()
        Me.lblKodeAwal = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbKodeAwal
        '
        Me.tbKodeAwal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbKodeAwal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbKodeAwal.Location = New System.Drawing.Point(250, 156)
        Me.tbKodeAwal.MaxLength = 50
        Me.tbKodeAwal.Name = "tbKodeAwal"
        Me.tbKodeAwal.Size = New System.Drawing.Size(184, 22)
        Me.tbKodeAwal.TabIndex = 0
        Me.tbKodeAwal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblKodeAwal
        '
        Me.lblKodeAwal.AutoSize = True
        Me.lblKodeAwal.BackColor = System.Drawing.Color.Transparent
        Me.lblKodeAwal.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKodeAwal.Location = New System.Drawing.Point(311, 121)
        Me.lblKodeAwal.Name = "lblKodeAwal"
        Me.lblKodeAwal.Size = New System.Drawing.Size(64, 30)
        Me.lblKodeAwal.TabIndex = 1
        Me.lblKodeAwal.Text = "Kode"
        '
        'btnSubmit
        '
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Image = CType(resources.GetObject("btnSubmit.Image"), System.Drawing.Image)
        Me.btnSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSubmit.Location = New System.Drawing.Point(293, 235)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(107, 37)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Kode_Aplikasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(684, 312)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblKodeAwal)
        Me.Controls.Add(Me.tbKodeAwal)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Kode_Aplikasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kode Aplikasi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbKodeAwal As System.Windows.Forms.TextBox
    Friend WithEvents lblKodeAwal As System.Windows.Forms.Label
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
End Class
