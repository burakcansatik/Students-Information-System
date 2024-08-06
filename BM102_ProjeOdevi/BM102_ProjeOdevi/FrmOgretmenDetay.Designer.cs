namespace BM102_ProjeOdevi
{
    partial class FrmOgretmenDetay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.MaskedNumara = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LblOrt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.TxtProje = new System.Windows.Forms.TextBox();
            this.TxtSinav2 = new System.Windows.Forms.TextBox();
            this.TxtSinav1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSinav1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSinav2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrProjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrOrtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblNotKayitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbNotKayitDataSet = new BM102_ProjeOdevi.DbNotKayitDataSet();
            this.tblNotKayitTableAdapter = new BM102_ProjeOdevi.DbNotKayitDataSetTableAdapters.TblNotKayitTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.LblDurumke = new System.Windows.Forms.Label();
            this.LblGecen = new System.Windows.Forms.Label();
            this.LblKalan = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGectiKaldi = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNotKayitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.BtnKaydet);
            this.groupBox1.Controls.Add(this.TxtSoyad);
            this.groupBox1.Controls.Add(this.TxtAd);
            this.groupBox1.Controls.Add(this.MaskedNumara);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 317);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Ekle";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(162, 212);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(161, 47);
            this.BtnKaydet.TabIndex = 6;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(162, 162);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(161, 29);
            this.TxtSoyad.TabIndex = 5;
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(162, 119);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(161, 29);
            this.TxtAd.TabIndex = 4;
            // 
            // MaskedNumara
            // 
            this.MaskedNumara.Location = new System.Drawing.Point(162, 78);
            this.MaskedNumara.Mask = "0000";
            this.MaskedNumara.Name = "MaskedNumara";
            this.MaskedNumara.Size = new System.Drawing.Size(161, 29);
            this.MaskedNumara.TabIndex = 3;
            this.MaskedNumara.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numara:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LblOrt);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.BtnGuncelle);
            this.groupBox2.Controls.Add(this.TxtProje);
            this.groupBox2.Controls.Add(this.TxtSinav2);
            this.groupBox2.Controls.Add(this.TxtSinav1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(459, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 317);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Not Güncelle";
            // 
            // LblOrt
            // 
            this.LblOrt.AutoSize = true;
            this.LblOrt.Location = new System.Drawing.Point(162, 271);
            this.LblOrt.Name = "LblOrt";
            this.LblOrt.Size = new System.Drawing.Size(68, 23);
            this.LblOrt.TabIndex = 11;
            this.LblOrt.Text = "00,00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ortalama:";
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(156, 200);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(130, 47);
            this.BtnGuncelle.TabIndex = 9;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // TxtProje
            // 
            this.TxtProje.Location = new System.Drawing.Point(156, 165);
            this.TxtProje.Name = "TxtProje";
            this.TxtProje.Size = new System.Drawing.Size(130, 29);
            this.TxtProje.TabIndex = 8;
            // 
            // TxtSinav2
            // 
            this.TxtSinav2.Location = new System.Drawing.Point(156, 122);
            this.TxtSinav2.Name = "TxtSinav2";
            this.TxtSinav2.Size = new System.Drawing.Size(130, 29);
            this.TxtSinav2.TabIndex = 7;
            // 
            // TxtSinav1
            // 
            this.TxtSinav1.Location = new System.Drawing.Point(156, 78);
            this.TxtSinav1.Name = "TxtSinav1";
            this.TxtSinav1.Size = new System.Drawing.Size(130, 29);
            this.TxtSinav1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Proje:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sınav 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sınav 1:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(12, 335);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1227, 268);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sınıf Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrIDDataGridViewTextBoxColumn,
            this.ogrNoDataGridViewTextBoxColumn,
            this.ogrAdDataGridViewTextBoxColumn,
            this.ogrSoyadDataGridViewTextBoxColumn,
            this.ogrSinav1DataGridViewTextBoxColumn,
            this.ogrSinav2DataGridViewTextBoxColumn,
            this.ogrProjeDataGridViewTextBoxColumn,
            this.ogrOrtDataGridViewTextBoxColumn,
            this.ogrDurumDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tblNotKayitBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1221, 243);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ogrIDDataGridViewTextBoxColumn
            // 
            this.ogrIDDataGridViewTextBoxColumn.DataPropertyName = "OgrID";
            this.ogrIDDataGridViewTextBoxColumn.HeaderText = "OgrID";
            this.ogrIDDataGridViewTextBoxColumn.Name = "ogrIDDataGridViewTextBoxColumn";
            this.ogrIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrNoDataGridViewTextBoxColumn
            // 
            this.ogrNoDataGridViewTextBoxColumn.DataPropertyName = "OgrNo";
            this.ogrNoDataGridViewTextBoxColumn.HeaderText = "OgrNo";
            this.ogrNoDataGridViewTextBoxColumn.Name = "ogrNoDataGridViewTextBoxColumn";
            // 
            // ogrAdDataGridViewTextBoxColumn
            // 
            this.ogrAdDataGridViewTextBoxColumn.DataPropertyName = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.HeaderText = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.Name = "ogrAdDataGridViewTextBoxColumn";
            // 
            // ogrSoyadDataGridViewTextBoxColumn
            // 
            this.ogrSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.HeaderText = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.Name = "ogrSoyadDataGridViewTextBoxColumn";
            // 
            // ogrSinav1DataGridViewTextBoxColumn
            // 
            this.ogrSinav1DataGridViewTextBoxColumn.DataPropertyName = "OgrSinav1";
            this.ogrSinav1DataGridViewTextBoxColumn.HeaderText = "OgrSinav1";
            this.ogrSinav1DataGridViewTextBoxColumn.Name = "ogrSinav1DataGridViewTextBoxColumn";
            // 
            // ogrSinav2DataGridViewTextBoxColumn
            // 
            this.ogrSinav2DataGridViewTextBoxColumn.DataPropertyName = "OgrSinav2";
            this.ogrSinav2DataGridViewTextBoxColumn.HeaderText = "OgrSinav2";
            this.ogrSinav2DataGridViewTextBoxColumn.Name = "ogrSinav2DataGridViewTextBoxColumn";
            // 
            // ogrProjeDataGridViewTextBoxColumn
            // 
            this.ogrProjeDataGridViewTextBoxColumn.DataPropertyName = "OgrProje";
            this.ogrProjeDataGridViewTextBoxColumn.HeaderText = "OgrProje";
            this.ogrProjeDataGridViewTextBoxColumn.Name = "ogrProjeDataGridViewTextBoxColumn";
            // 
            // ogrOrtDataGridViewTextBoxColumn
            // 
            this.ogrOrtDataGridViewTextBoxColumn.DataPropertyName = "OgrOrt";
            this.ogrOrtDataGridViewTextBoxColumn.HeaderText = "OgrOrt";
            this.ogrOrtDataGridViewTextBoxColumn.Name = "ogrOrtDataGridViewTextBoxColumn";
            // 
            // ogrDurumDataGridViewCheckBoxColumn
            // 
            this.ogrDurumDataGridViewCheckBoxColumn.DataPropertyName = "OgrDurum";
            this.ogrDurumDataGridViewCheckBoxColumn.HeaderText = "OgrDurum";
            this.ogrDurumDataGridViewCheckBoxColumn.Name = "ogrDurumDataGridViewCheckBoxColumn";
            // 
            // tblNotKayitBindingSource
            // 
            this.tblNotKayitBindingSource.DataMember = "TblNotKayit";
            this.tblNotKayitBindingSource.DataSource = this.dbNotKayitDataSet;
            // 
            // dbNotKayitDataSet
            // 
            this.dbNotKayitDataSet.DataSetName = "DbNotKayitDataSet";
            this.dbNotKayitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblNotKayitTableAdapter
            // 
            this.tblNotKayitTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(873, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(321, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Kutuları Temizle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblDurumke
            // 
            this.LblDurumke.AutoSize = true;
            this.LblDurumke.Location = new System.Drawing.Point(997, 174);
            this.LblDurumke.Name = "LblDurumke";
            this.LblDurumke.Size = new System.Drawing.Size(0, 23);
            this.LblDurumke.TabIndex = 6;
            // 
            // LblGecen
            // 
            this.LblGecen.AutoSize = true;
            this.LblGecen.Location = new System.Drawing.Point(1162, 212);
            this.LblGecen.Name = "LblGecen";
            this.LblGecen.Size = new System.Drawing.Size(36, 23);
            this.LblGecen.TabIndex = 7;
            this.LblGecen.Text = "00";
            // 
            // LblKalan
            // 
            this.LblKalan.AutoSize = true;
            this.LblKalan.Location = new System.Drawing.Point(1162, 248);
            this.LblKalan.Name = "LblKalan";
            this.LblKalan.Size = new System.Drawing.Size(36, 23);
            this.LblKalan.TabIndex = 8;
            this.LblKalan.Text = "00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(881, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(275, 23);
            this.label8.TabIndex = 9;
            this.label8.Text = "Dersi Geçen Öğrenci Sayısı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(858, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(298, 23);
            this.label9.TabIndex = 10;
            this.label9.Text = "Dersten Kalan Öğrenci Sayısı";
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(873, 102);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(321, 41);
            this.BtnSil.TabIndex = 11;
            this.BtnSil.Text = "Öğrenci Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGectiKaldi
            // 
            this.BtnGectiKaldi.Location = new System.Drawing.Point(873, 158);
            this.BtnGectiKaldi.Name = "BtnGectiKaldi";
            this.BtnGectiKaldi.Size = new System.Drawing.Size(321, 42);
            this.BtnGectiKaldi.TabIndex = 12;
            this.BtnGectiKaldi.Text = "Geçen ve Kalan Öğrenci Sayısı";
            this.BtnGectiKaldi.UseVisualStyleBackColor = true;
            this.BtnGectiKaldi.Click += new System.EventHandler(this.BtnGectiKaldi_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(873, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(321, 41);
            this.button2.TabIndex = 13;
            this.button2.Text = "Menüye Dön";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 23);
            this.label10.TabIndex = 7;
            // 
            // FrmOgretmenDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(74)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1244, 606);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnGectiKaldi);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LblKalan);
            this.Controls.Add(this.LblGecen);
            this.Controls.Add(this.LblDurumke);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "FrmOgretmenDetay";
            this.Text = "FrmOgretmenDetay";
            this.Load += new System.EventHandler(this.FrmOgretmenDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNotKayitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.MaskedTextBox MaskedNumara;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.TextBox TxtProje;
        private System.Windows.Forms.TextBox TxtSinav2;
        private System.Windows.Forms.TextBox TxtSinav1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private DbNotKayitDataSet dbNotKayitDataSet;
        private System.Windows.Forms.BindingSource tblNotKayitBindingSource;
        private DbNotKayitDataSetTableAdapters.TblNotKayitTableAdapter tblNotKayitTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSinav1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSinav2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrProjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrOrtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ogrDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label LblOrt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LblDurumke;
        private System.Windows.Forms.Label LblGecen;
        private System.Windows.Forms.Label LblKalan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGectiKaldi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
    }
}