namespace BM102_ProjeOdevi
{
    partial class FrmOgretmenIstek
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrMesajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblIstekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbNotKayitDataSet4 = new BM102_ProjeOdevi.DbNotKayitDataSet4();
            this.tblIstekTableAdapter = new BM102_ProjeOdevi.DbNotKayitDataSet4TableAdapters.TblIstekTableAdapter();
            this.RichGoruntule = new System.Windows.Forms.RichTextBox();
            this.LabelAd = new System.Windows.Forms.Label();
            this.LabelSoyad = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIstekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSet4)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrAdDataGridViewTextBoxColumn,
            this.ogrSoyadDataGridViewTextBoxColumn,
            this.ogrMesajDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblIstekBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(434, 296);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // ogrMesajDataGridViewTextBoxColumn
            // 
            this.ogrMesajDataGridViewTextBoxColumn.DataPropertyName = "OgrMesaj";
            this.ogrMesajDataGridViewTextBoxColumn.HeaderText = "OgrMesaj";
            this.ogrMesajDataGridViewTextBoxColumn.Name = "ogrMesajDataGridViewTextBoxColumn";
            // 
            // tblIstekBindingSource
            // 
            this.tblIstekBindingSource.DataMember = "TblIstek";
            this.tblIstekBindingSource.DataSource = this.dbNotKayitDataSet4;
            // 
            // dbNotKayitDataSet4
            // 
            this.dbNotKayitDataSet4.DataSetName = "DbNotKayitDataSet4";
            this.dbNotKayitDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblIstekTableAdapter
            // 
            this.tblIstekTableAdapter.ClearBeforeFill = true;
            // 
            // RichGoruntule
            // 
            this.RichGoruntule.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RichGoruntule.Location = new System.Drawing.Point(8, 107);
            this.RichGoruntule.Name = "RichGoruntule";
            this.RichGoruntule.Size = new System.Drawing.Size(339, 303);
            this.RichGoruntule.TabIndex = 1;
            this.RichGoruntule.Text = "";
            // 
            // LabelAd
            // 
            this.LabelAd.AutoSize = true;
            this.LabelAd.Font = new System.Drawing.Font("Georgia", 12.5F, System.Drawing.FontStyle.Bold);
            this.LabelAd.Location = new System.Drawing.Point(203, 39);
            this.LabelAd.Name = "LabelAd";
            this.LabelAd.Size = new System.Drawing.Size(45, 20);
            this.LabelAd.TabIndex = 2;
            this.LabelAd.Text = "------";
            // 
            // LabelSoyad
            // 
            this.LabelSoyad.AutoSize = true;
            this.LabelSoyad.Font = new System.Drawing.Font("Georgia", 12.5F, System.Drawing.FontStyle.Bold);
            this.LabelSoyad.Location = new System.Drawing.Point(203, 81);
            this.LabelSoyad.Name = "LabelSoyad";
            this.LabelSoyad.Size = new System.Drawing.Size(45, 20);
            this.LabelSoyad.TabIndex = 3;
            this.LabelSoyad.Text = "------";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.RichGoruntule);
            this.groupBox1.Controls.Add(this.LabelSoyad);
            this.groupBox1.Controls.Add(this.LabelAd);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBox1.Location = new System.Drawing.Point(432, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 416);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İstek ve Şikayet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12.5F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Gönderenin Soyadı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12.5F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(36, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gönderenin Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12.5F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(377, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Not: Mesajı detaylı bir şekilde okumak ve";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12.5F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(8, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "silmek için üstüne tıklayabilirsiniz.";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button1.Location = new System.Drawing.Point(16, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(410, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Menüye Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button2.Location = new System.Drawing.Point(16, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(410, 38);
            this.button2.TabIndex = 8;
            this.button2.Text = "İstek ve Şikayeti Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmOgretmenIstek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(74)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(797, 440);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmOgretmenIstek";
            this.Text = "Öğretmen İstek ve Şikayet";
            this.Load += new System.EventHandler(this.FrmOgretmenIstek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIstekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSet4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DbNotKayitDataSet4 dbNotKayitDataSet4;
        private System.Windows.Forms.BindingSource tblIstekBindingSource;
        private DbNotKayitDataSet4TableAdapters.TblIstekTableAdapter tblIstekTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrMesajDataGridViewTextBoxColumn;
        private System.Windows.Forms.RichTextBox RichGoruntule;
        private System.Windows.Forms.Label LabelAd;
        private System.Windows.Forms.Label LabelSoyad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}