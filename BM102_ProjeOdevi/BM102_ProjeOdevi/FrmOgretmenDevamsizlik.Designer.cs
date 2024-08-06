namespace BM102_ProjeOdevi
{
    partial class FrmOgretmenDevamsizlik
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
            this.TxtDevamsizlik = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MaskedNumara = new System.Windows.Forms.MaskedTextBox();
            this.LblNumara = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrDevamsizlikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDevamsizlikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbNotKayitDataSet1 = new BM102_ProjeOdevi.DbNotKayitDataSet1();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tblDevamsizlikTableAdapter = new BM102_ProjeOdevi.DbNotKayitDataSet1TableAdapters.TblDevamsizlikTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDevamsizlikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSet1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnKaydet);
            this.groupBox1.Controls.Add(this.TxtDevamsizlik);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.MaskedNumara);
            this.groupBox1.Controls.Add(this.LblNumara);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Devamsızlık Giriş Paneli";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(254, 152);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(145, 43);
            this.BtnKaydet.TabIndex = 4;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // TxtDevamsizlik
            // 
            this.TxtDevamsizlik.Location = new System.Drawing.Point(254, 99);
            this.TxtDevamsizlik.Name = "TxtDevamsizlik";
            this.TxtDevamsizlik.Size = new System.Drawing.Size(145, 29);
            this.TxtDevamsizlik.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Devamsızlık Sayısı:";
            // 
            // MaskedNumara
            // 
            this.MaskedNumara.Location = new System.Drawing.Point(254, 41);
            this.MaskedNumara.Mask = "0000";
            this.MaskedNumara.Name = "MaskedNumara";
            this.MaskedNumara.Size = new System.Drawing.Size(145, 29);
            this.MaskedNumara.TabIndex = 1;
            this.MaskedNumara.ValidatingType = typeof(int);
            // 
            // LblNumara
            // 
            this.LblNumara.AutoSize = true;
            this.LblNumara.Location = new System.Drawing.Point(32, 44);
            this.LblNumara.Name = "LblNumara";
            this.LblNumara.Size = new System.Drawing.Size(197, 23);
            this.LblNumara.TabIndex = 0;
            this.LblNumara.Text = "Öğrenci Numarası:";
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
            this.ogrDevamsizlikDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblDevamsizlikBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-180, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(739, 193);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ogrIDDataGridViewTextBoxColumn
            // 
            this.ogrIDDataGridViewTextBoxColumn.DataPropertyName = "OgrID";
            this.ogrIDDataGridViewTextBoxColumn.HeaderText = "OgrID";
            this.ogrIDDataGridViewTextBoxColumn.Name = "ogrIDDataGridViewTextBoxColumn";
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
            // ogrDevamsizlikDataGridViewTextBoxColumn
            // 
            this.ogrDevamsizlikDataGridViewTextBoxColumn.DataPropertyName = "OgrDevamsizlik";
            this.ogrDevamsizlikDataGridViewTextBoxColumn.HeaderText = "OgrDevamsizlik";
            this.ogrDevamsizlikDataGridViewTextBoxColumn.Name = "ogrDevamsizlikDataGridViewTextBoxColumn";
            // 
            // tblDevamsizlikBindingSource
            // 
            this.tblDevamsizlikBindingSource.DataMember = "TblDevamsizlik";
            this.tblDevamsizlikBindingSource.DataSource = this.dbNotKayitDataSet1;
            // 
            // dbNotKayitDataSet1
            // 
            this.dbNotKayitDataSet1.DataSetName = "DbNotKayitDataSet1";
            this.dbNotKayitDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(15, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(569, 216);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğrenci Listesi";
            // 
            // tblDevamsizlikTableAdapter
            // 
            this.tblDevamsizlikTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(442, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Menüye Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmOgretmenDevamsizlik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(74)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(595, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "FrmOgretmenDevamsizlik";
            this.Text = "FrmDevamsizlik";
            this.Load += new System.EventHandler(this.FrmDevamsizlik_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDevamsizlikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSet1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.TextBox TxtDevamsizlik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MaskedNumara;
        private System.Windows.Forms.Label LblNumara;
        private System.Windows.Forms.GroupBox groupBox2;
        private DbNotKayitDataSet1 dbNotKayitDataSet1;
        private System.Windows.Forms.BindingSource tblDevamsizlikBindingSource;
        private DbNotKayitDataSet1TableAdapters.TblDevamsizlikTableAdapter tblDevamsizlikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrDevamsizlikDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}