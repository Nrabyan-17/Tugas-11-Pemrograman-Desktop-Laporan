<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txFaktur = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txHargaJual = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txTotal = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txSubTotal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.txJumlah = New System.Windows.Forms.TextBox()
        Me.txJenis = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txKodeBrg = New System.Windows.Forms.TextBox()
        Me.cbBarang = New System.Windows.Forms.ComboBox()
        Me.txPelanggan = New System.Windows.Forms.TextBox()
        Me.cbPelanggan = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(73, 391)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 33)
        Me.Button2.TabIndex = 134
        Me.Button2.Text = "Cetak Laporan"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txFaktur
        '
        Me.txFaktur.Location = New System.Drawing.Point(386, 30)
        Me.txFaktur.Name = "txFaktur"
        Me.txFaktur.Size = New System.Drawing.Size(130, 20)
        Me.txFaktur.TabIndex = 133
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(504, 351)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 13)
        Me.Label13.TabIndex = 132
        Me.Label13.Text = "Harga Jual:"
        '
        'txHargaJual
        '
        Me.txHargaJual.Location = New System.Drawing.Point(586, 346)
        Me.txHargaJual.Name = "txHargaJual"
        Me.txHargaJual.Size = New System.Drawing.Size(100, 20)
        Me.txHargaJual.TabIndex = 131
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(504, 349)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 13)
        Me.Label12.TabIndex = 130
        '
        'txTotal
        '
        Me.txTotal.Location = New System.Drawing.Point(348, 386)
        Me.txTotal.Name = "txTotal"
        Me.txTotal.Size = New System.Drawing.Size(100, 20)
        Me.txTotal.TabIndex = 129
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(277, 386)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 128
        Me.Label10.Text = "Total:"
        '
        'txSubTotal
        '
        Me.txSubTotal.Location = New System.Drawing.Point(348, 348)
        Me.txSubTotal.Name = "txSubTotal"
        Me.txSubTotal.Size = New System.Drawing.Size(100, 20)
        Me.txSubTotal.TabIndex = 127
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(277, 351)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 126
        Me.Label9.Text = "Sub Total:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(73, 346)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 33)
        Me.Button1.TabIndex = 125
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView
        '
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Location = New System.Drawing.Point(93, 163)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.Size = New System.Drawing.Size(639, 163)
        Me.DataGridView.TabIndex = 124
        '
        'txJumlah
        '
        Me.txJumlah.Location = New System.Drawing.Point(386, 128)
        Me.txJumlah.Name = "txJumlah"
        Me.txJumlah.Size = New System.Drawing.Size(130, 20)
        Me.txJumlah.TabIndex = 123
        '
        'txJenis
        '
        Me.txJenis.Location = New System.Drawing.Point(386, 97)
        Me.txJenis.Name = "txJenis"
        Me.txJenis.Size = New System.Drawing.Size(130, 20)
        Me.txJenis.TabIndex = 122
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(547, 58)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 121
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(544, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 120
        Me.Label8.Text = "Tanggal:"
        '
        'txKodeBrg
        '
        Me.txKodeBrg.Location = New System.Drawing.Point(386, 62)
        Me.txKodeBrg.Name = "txKodeBrg"
        Me.txKodeBrg.Size = New System.Drawing.Size(130, 20)
        Me.txKodeBrg.TabIndex = 119
        '
        'cbBarang
        '
        Me.cbBarang.FormattingEnabled = True
        Me.cbBarang.Location = New System.Drawing.Point(152, 100)
        Me.cbBarang.Name = "cbBarang"
        Me.cbBarang.Size = New System.Drawing.Size(100, 21)
        Me.cbBarang.TabIndex = 118
        '
        'txPelanggan
        '
        Me.txPelanggan.Location = New System.Drawing.Point(152, 67)
        Me.txPelanggan.Name = "txPelanggan"
        Me.txPelanggan.Size = New System.Drawing.Size(100, 20)
        Me.txPelanggan.TabIndex = 117
        '
        'cbPelanggan
        '
        Me.cbPelanggan.FormattingEnabled = True
        Me.cbPelanggan.Location = New System.Drawing.Point(152, 27)
        Me.cbPelanggan.Name = "cbPelanggan"
        Me.cbPelanggan.Size = New System.Drawing.Size(100, 21)
        Me.cbPelanggan.TabIndex = 116
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(290, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 115
        Me.Label7.Text = "Jumlah Beli:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(290, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 114
        Me.Label6.Text = "Jenis:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(290, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 113
        Me.Label5.Text = "Kode Barang:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(290, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 112
        Me.Label4.Text = "Faktur Penjualan:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(54, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 111
        Me.Label3.Text = "Barang:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "Nama Pelanggan:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 109
        Me.Label1.Text = "Pelanggan:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txFaktur)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txHargaJual)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txTotal)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txSubTotal)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.txJumlah)
        Me.Controls.Add(Me.txJenis)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txKodeBrg)
        Me.Controls.Add(Me.cbBarang)
        Me.Controls.Add(Me.txPelanggan)
        Me.Controls.Add(Me.cbPelanggan)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents txFaktur As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txHargaJual As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txTotal As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txSubTotal As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents txJumlah As TextBox
    Friend WithEvents txJenis As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents txKodeBrg As TextBox
    Friend WithEvents cbBarang As ComboBox
    Friend WithEvents txPelanggan As TextBox
    Friend WithEvents cbPelanggan As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
