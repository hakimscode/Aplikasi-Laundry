<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FCucian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FCucian))
        Me.dgcucian = New System.Windows.Forms.DataGridView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtfaktur = New System.Windows.Forms.TextBox
        Me.rdkons = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtkons = New System.Windows.Forms.TextBox
        Me.rdfaktur = New System.Windows.Forms.RadioButton
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Button1 = New System.Windows.Forms.Button
        Me.thnhari = New System.Windows.Forms.ComboBox
        Me.blnhari = New System.Windows.Forms.ComboBox
        Me.tglhari = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Button2 = New System.Windows.Forms.Button
        Me.cmbket = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        CType(Me.dgcucian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgcucian
        '
        Me.dgcucian.AllowUserToAddRows = False
        Me.dgcucian.AllowUserToDeleteRows = False
        Me.dgcucian.BackgroundColor = System.Drawing.Color.Khaki
        Me.dgcucian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgcucian.Location = New System.Drawing.Point(12, 52)
        Me.dgcucian.Name = "dgcucian"
        Me.dgcucian.ReadOnly = True
        Me.dgcucian.Size = New System.Drawing.Size(986, 378)
        Me.dgcucian.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Khaki
        Me.Panel1.Controls.Add(Me.txtfaktur)
        Me.Panel1.Controls.Add(Me.rdkons)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtkons)
        Me.Panel1.Controls.Add(Me.rdfaktur)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(986, 25)
        Me.Panel1.TabIndex = 1
        '
        'txtfaktur
        '
        Me.txtfaktur.Enabled = False
        Me.txtfaktur.Location = New System.Drawing.Point(347, 3)
        Me.txtfaktur.Name = "txtfaktur"
        Me.txtfaktur.Size = New System.Drawing.Size(100, 20)
        Me.txtfaktur.TabIndex = 4
        '
        'rdkons
        '
        Me.rdkons.AutoSize = True
        Me.rdkons.Location = New System.Drawing.Point(286, 4)
        Me.rdkons.Name = "rdkons"
        Me.rdkons.Size = New System.Drawing.Size(55, 17)
        Me.rdkons.TabIndex = 1
        Me.rdkons.Text = "Faktur"
        Me.rdkons.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cari :"
        '
        'txtkons
        '
        Me.txtkons.Location = New System.Drawing.Point(152, 2)
        Me.txtkons.Name = "txtkons"
        Me.txtkons.Size = New System.Drawing.Size(100, 20)
        Me.txtkons.TabIndex = 0
        '
        'rdfaktur
        '
        Me.rdfaktur.AutoSize = True
        Me.rdfaktur.Checked = True
        Me.rdfaktur.Location = New System.Drawing.Point(71, 3)
        Me.rdfaktur.Name = "rdfaktur"
        Me.rdfaktur.Size = New System.Drawing.Size(75, 17)
        Me.rdfaktur.TabIndex = 8
        Me.rdfaktur.TabStop = True
        Me.rdfaktur.Text = "Konsumen"
        Me.rdfaktur.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 437)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(468, 84)
        Me.TabControl1.TabIndex = 10
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.thnhari)
        Me.TabPage1.Controls.Add(Me.blnhari)
        Me.TabPage1.Controls.Add(Me.tglhari)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(460, 58)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Filter Harian"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(368, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Filter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'thnhari
        '
        Me.thnhari.FormattingEnabled = True
        Me.thnhari.Location = New System.Drawing.Point(286, 19)
        Me.thnhari.Name = "thnhari"
        Me.thnhari.Size = New System.Drawing.Size(51, 21)
        Me.thnhari.TabIndex = 11
        '
        'blnhari
        '
        Me.blnhari.FormattingEnabled = True
        Me.blnhari.Items.AddRange(New Object() {"Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember"})
        Me.blnhari.Location = New System.Drawing.Point(148, 19)
        Me.blnhari.Name = "blnhari"
        Me.blnhari.Size = New System.Drawing.Size(79, 21)
        Me.blnhari.TabIndex = 4
        '
        'tglhari
        '
        Me.tglhari.FormattingEnabled = True
        Me.tglhari.Location = New System.Drawing.Point(58, 19)
        Me.tglhari.Name = "tglhari"
        Me.tglhari.Size = New System.Drawing.Size(35, 21)
        Me.tglhari.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(242, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Tahun"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(108, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Bulan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tanggal"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.cmbket)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(460, 58)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Filter Keterangan"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(262, 17)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Filter"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmbket
        '
        Me.cmbket.FormattingEnabled = True
        Me.cmbket.Items.AddRange(New Object() {"Lunas", "Belum Lunas"})
        Me.cmbket.Location = New System.Drawing.Point(77, 19)
        Me.cmbket.Name = "cmbket"
        Me.cmbket.Size = New System.Drawing.Size(79, 21)
        Me.cmbket.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Keterangan"
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("Arcade", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(510, 466)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(191, 39)
        Me.Button3.TabIndex = 61
        Me.Button3.Text = "Tampilkan Semua Data"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'FCucian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(1010, 532)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgcucian)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FCucian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cucian"
        CType(Me.dgcucian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgcucian As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtkons As System.Windows.Forms.TextBox
    Friend WithEvents rdfaktur As System.Windows.Forms.RadioButton
    Friend WithEvents txtfaktur As System.Windows.Forms.TextBox
    Friend WithEvents rdkons As System.Windows.Forms.RadioButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents thnhari As System.Windows.Forms.ComboBox
    Friend WithEvents blnhari As System.Windows.Forms.ComboBox
    Friend WithEvents tglhari As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cmbket As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
