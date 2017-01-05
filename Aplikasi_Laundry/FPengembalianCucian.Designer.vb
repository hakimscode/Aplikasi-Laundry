<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FPengembalianCucian
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FPengembalianCucian))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtsisa = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtbayar = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.btnreset = New System.Windows.Forms.Button
        Me.btnsimpan = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtpanjar = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtdiskon = New System.Windows.Forms.TextBox
        Me.txtharga = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rdoanggota = New System.Windows.Forms.RadioButton
        Me.rdobukan = New System.Windows.Forms.RadioButton
        Me.cmbkode = New System.Windows.Forms.ComboBox
        Me.cmbanggota = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmbket = New System.Windows.Forms.ComboBox
        Me.txtpakaian = New System.Windows.Forms.TextBox
        Me.txtberat = New System.Windows.Forms.TextBox
        Me.txtkons = New System.Windows.Forms.TextBox
        Me.txtfaktur = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbltanggal = New System.Windows.Forms.Label
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.gensoft = New System.Windows.Forms.ToolStripStatusLabel
        Me.jam = New System.Windows.Forms.ToolStripStatusLabel
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Khaki
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txtsisa)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.txtbayar)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.btnreset)
        Me.Panel1.Controls.Add(Me.btnsimpan)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.txtpanjar)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtdiskon)
        Me.Panel1.Controls.Add(Me.txtharga)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.cmbket)
        Me.Panel1.Controls.Add(Me.txtpakaian)
        Me.Panel1.Controls.Add(Me.txtberat)
        Me.Panel1.Controls.Add(Me.txtkons)
        Me.Panel1.Controls.Add(Me.txtfaktur)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(584, 285)
        Me.Panel1.TabIndex = 50
        '
        'txtsisa
        '
        Me.txtsisa.Enabled = False
        Me.txtsisa.Location = New System.Drawing.Point(409, 186)
        Me.txtsisa.Name = "txtsisa"
        Me.txtsisa.Size = New System.Drawing.Size(117, 20)
        Me.txtsisa.TabIndex = 56
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(305, 189)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(31, 13)
        Me.Label17.TabIndex = 57
        Me.Label17.Text = "Sisa"
        '
        'txtbayar
        '
        Me.txtbayar.Enabled = False
        Me.txtbayar.Location = New System.Drawing.Point(409, 160)
        Me.txtbayar.Name = "txtbayar"
        Me.txtbayar.Size = New System.Drawing.Size(117, 20)
        Me.txtbayar.TabIndex = 54
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(305, 163)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(75, 13)
        Me.Label16.TabIndex = 55
        Me.Label16.Text = "Total_Bayar"
        '
        'btnreset
        '
        Me.btnreset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnreset.Font = New System.Drawing.Font("Arcade", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.Location = New System.Drawing.Point(430, 230)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(108, 39)
        Me.btnreset.TabIndex = 53
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.BackColor = System.Drawing.Color.DarkGreen
        Me.btnsimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsimpan.Enabled = False
        Me.btnsimpan.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnsimpan.Font = New System.Drawing.Font("Arcade", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsimpan.Location = New System.Drawing.Point(298, 230)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(108, 39)
        Me.btnsimpan.TabIndex = 52
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(143, 177)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(15, 13)
        Me.Label13.TabIndex = 51
        Me.Label13.Text = "%"
        '
        'txtpanjar
        '
        Me.txtpanjar.Enabled = False
        Me.txtpanjar.Location = New System.Drawing.Point(110, 209)
        Me.txtpanjar.Name = "txtpanjar"
        Me.txtpanjar.Size = New System.Drawing.Size(117, 20)
        Me.txtpanjar.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 212)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "Panjar"
        '
        'txtdiskon
        '
        Me.txtdiskon.Enabled = False
        Me.txtdiskon.Location = New System.Drawing.Point(110, 174)
        Me.txtdiskon.Name = "txtdiskon"
        Me.txtdiskon.Size = New System.Drawing.Size(27, 20)
        Me.txtdiskon.TabIndex = 44
        '
        'txtharga
        '
        Me.txtharga.Enabled = False
        Me.txtharga.Location = New System.Drawing.Point(110, 139)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(117, 20)
        Me.txtharga.TabIndex = 87
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 177)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Diskon"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 142)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Harga"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoanggota)
        Me.GroupBox1.Controls.Add(Me.rdobukan)
        Me.GroupBox1.Controls.Add(Me.cmbkode)
        Me.GroupBox1.Controls.Add(Me.cmbanggota)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(298, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 136)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Anggota"
        '
        'rdoanggota
        '
        Me.rdoanggota.AutoSize = True
        Me.rdoanggota.Location = New System.Drawing.Point(154, 26)
        Me.rdoanggota.Name = "rdoanggota"
        Me.rdoanggota.Size = New System.Drawing.Size(65, 17)
        Me.rdoanggota.TabIndex = 42
        Me.rdoanggota.TabStop = True
        Me.rdoanggota.Text = "Anggota"
        Me.rdoanggota.UseVisualStyleBackColor = True
        '
        'rdobukan
        '
        Me.rdobukan.AutoSize = True
        Me.rdobukan.Location = New System.Drawing.Point(20, 26)
        Me.rdobukan.Name = "rdobukan"
        Me.rdobukan.Size = New System.Drawing.Size(99, 17)
        Me.rdobukan.TabIndex = 41
        Me.rdobukan.TabStop = True
        Me.rdobukan.Text = "Bukan Anggota"
        Me.rdobukan.UseVisualStyleBackColor = True
        '
        'cmbkode
        '
        Me.cmbkode.Enabled = False
        Me.cmbkode.FormattingEnabled = True
        Me.cmbkode.Location = New System.Drawing.Point(111, 64)
        Me.cmbkode.Name = "cmbkode"
        Me.cmbkode.Size = New System.Drawing.Size(117, 21)
        Me.cmbkode.TabIndex = 38
        '
        'cmbanggota
        '
        Me.cmbanggota.Enabled = False
        Me.cmbanggota.Location = New System.Drawing.Point(111, 91)
        Me.cmbanggota.Name = "cmbanggota"
        Me.cmbanggota.Size = New System.Drawing.Size(117, 20)
        Me.cmbanggota.TabIndex = 37
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Kode Anggota"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Nama Anggota"
        '
        'cmbket
        '
        Me.cmbket.FormattingEnabled = True
        Me.cmbket.Items.AddRange(New Object() {"Lunas", "Belum Lunas"})
        Me.cmbket.Location = New System.Drawing.Point(110, 243)
        Me.cmbket.Name = "cmbket"
        Me.cmbket.Size = New System.Drawing.Size(117, 21)
        Me.cmbket.TabIndex = 32
        '
        'txtpakaian
        '
        Me.txtpakaian.Enabled = False
        Me.txtpakaian.Location = New System.Drawing.Point(110, 104)
        Me.txtpakaian.Name = "txtpakaian"
        Me.txtpakaian.Size = New System.Drawing.Size(117, 20)
        Me.txtpakaian.TabIndex = 1
        '
        'txtberat
        '
        Me.txtberat.Enabled = False
        Me.txtberat.Location = New System.Drawing.Point(110, 71)
        Me.txtberat.Name = "txtberat"
        Me.txtberat.Size = New System.Drawing.Size(39, 20)
        Me.txtberat.TabIndex = 0
        '
        'txtkons
        '
        Me.txtkons.Enabled = False
        Me.txtkons.Location = New System.Drawing.Point(110, 39)
        Me.txtkons.Name = "txtkons"
        Me.txtkons.Size = New System.Drawing.Size(117, 20)
        Me.txtkons.TabIndex = 31
        '
        'txtfaktur
        '
        Me.txtfaktur.Location = New System.Drawing.Point(110, 8)
        Me.txtfaktur.Name = "txtfaktur"
        Me.txtfaktur.Size = New System.Drawing.Size(117, 20)
        Me.txtfaktur.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Jumlah Pakaian"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Berat Cucian"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 245)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Keterangan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Konsumen"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Faktur"
        '
        'lbltanggal
        '
        Me.lbltanggal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbltanggal.Font = New System.Drawing.Font("BN Defect", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltanggal.ForeColor = System.Drawing.Color.Cornsilk
        Me.lbltanggal.Location = New System.Drawing.Point(626, 12)
        Me.lbltanggal.Name = "lbltanggal"
        Me.lbltanggal.Size = New System.Drawing.Size(191, 35)
        Me.lbltanggal.TabIndex = 58
        Me.lbltanggal.Text = "Tanggal"
        Me.lbltanggal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.gensoft, Me.jam})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 319)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(830, 24)
        Me.StatusStrip1.TabIndex = 59
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'gensoft
        '
        Me.gensoft.Font = New System.Drawing.Font("MR FUGLESANG OUTLINE", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gensoft.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gensoft.Image = CType(resources.GetObject("gensoft.Image"), System.Drawing.Image)
        Me.gensoft.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.gensoft.IsLink = True
        Me.gensoft.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.gensoft.LinkVisited = True
        Me.gensoft.Name = "gensoft"
        Me.gensoft.Size = New System.Drawing.Size(407, 19)
        Me.gensoft.Spring = True
        Me.gensoft.Text = "Aplikasi Laundry -- GenSoft-H"
        Me.gensoft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.gensoft.VisitedLinkColor = System.Drawing.Color.DarkGreen
        '
        'jam
        '
        Me.jam.Font = New System.Drawing.Font("MR FUGLESANG OUTLINE", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jam.ForeColor = System.Drawing.Color.DarkGreen
        Me.jam.Image = CType(resources.GetObject("jam.Image"), System.Drawing.Image)
        Me.jam.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.jam.Name = "jam"
        Me.jam.Size = New System.Drawing.Size(407, 19)
        Me.jam.Spring = True
        Me.jam.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Arcade", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(626, 63)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(191, 39)
        Me.Button1.TabIndex = 60
        Me.Button1.Text = "Daftar Cucian"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(626, 118)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(191, 179)
        Me.PictureBox1.TabIndex = 61
        Me.PictureBox1.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Green
        Me.Label15.Location = New System.Drawing.Point(659, 272)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(132, 16)
        Me.Label15.TabIndex = 62
        Me.Label15.Text = "Bersih, Rapi dan Wangi"
        '
        'FPengembalianCucian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(830, 343)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lbltanggal)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FPengembalianCucian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pengembalian Cucian"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtsisa As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtbayar As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtpanjar As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtdiskon As System.Windows.Forms.TextBox
    Friend WithEvents txtharga As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdoanggota As System.Windows.Forms.RadioButton
    Friend WithEvents rdobukan As System.Windows.Forms.RadioButton
    Friend WithEvents cmbkode As System.Windows.Forms.ComboBox
    Friend WithEvents cmbanggota As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbket As System.Windows.Forms.ComboBox
    Friend WithEvents txtpakaian As System.Windows.Forms.TextBox
    Friend WithEvents txtberat As System.Windows.Forms.TextBox
    Friend WithEvents txtkons As System.Windows.Forms.TextBox
    Friend WithEvents txtfaktur As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbltanggal As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents gensoft As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents jam As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
