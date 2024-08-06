namespace BM102_ProjeOdevi
{
    partial class FrmOgretmenDuyuru
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
            this.RchDuyuru = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dbNotKayitDataSet = new BM102_ProjeOdevi.DbNotKayitDataSet();
            this.dbNotKayitDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbNotKayitDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbNotKayitDataSet1 = new BM102_ProjeOdevi.DbNotKayitDataSet1();
            this.dbNotKayitDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbNotKayitDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tblNotKayitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblNotKayitTableAdapter = new BM102_ProjeOdevi.DbNotKayitDataSetTableAdapters.TblNotKayitTableAdapter();
            this.tblNotKayitBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblNotKayitBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tblDevamsizlikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblDevamsizlikTableAdapter = new BM102_ProjeOdevi.DbNotKayitDataSet1TableAdapters.TblDevamsizlikTableAdapter();
            this.dbNotKayitDataSetBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dbNotKayitDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbNotKayitDataSet2 = new BM102_ProjeOdevi.DbNotKayitDataSet2();
            this.dbNotKayitDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbNotKayitDataSet3 = new BM102_ProjeOdevi.DbNotKayitDataSet3();
            this.tblDuyuruBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblDuyuruTableAdapter = new BM102_ProjeOdevi.DbNotKayitDataSet3TableAdapters.TblDuyuruTableAdapter();
            this.RichDuyuruSil = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.duyuruIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duyuruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNotKayitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNotKayitBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNotKayitBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDevamsizlikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSetBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDuyuruBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // RchDuyuru
            // 
            this.RchDuyuru.Location = new System.Drawing.Point(12, 51);
            this.RchDuyuru.Name = "RchDuyuru";
            this.RchDuyuru.Size = new System.Drawing.Size(325, 309);
            this.RchDuyuru.TabIndex = 0;
            this.RchDuyuru.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Georgia", 14F);
            this.button1.Location = new System.Drawing.Point(12, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(325, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Duyuru Gönder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dbNotKayitDataSet
            // 
            this.dbNotKayitDataSet.DataSetName = "DbNotKayitDataSet";
            this.dbNotKayitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbNotKayitDataSetBindingSource
            // 
            this.dbNotKayitDataSetBindingSource.DataSource = this.dbNotKayitDataSet;
            this.dbNotKayitDataSetBindingSource.Position = 0;
            // 
            // dbNotKayitDataSetBindingSource1
            // 
            this.dbNotKayitDataSetBindingSource1.DataSource = this.dbNotKayitDataSet;
            this.dbNotKayitDataSetBindingSource1.Position = 0;
            // 
            // dbNotKayitDataSet1
            // 
            this.dbNotKayitDataSet1.DataSetName = "DbNotKayitDataSet1";
            this.dbNotKayitDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbNotKayitDataSet1BindingSource
            // 
            this.dbNotKayitDataSet1BindingSource.DataSource = this.dbNotKayitDataSet1;
            this.dbNotKayitDataSet1BindingSource.Position = 0;
            // 
            // dbNotKayitDataSetBindingSource2
            // 
            this.dbNotKayitDataSetBindingSource2.DataSource = this.dbNotKayitDataSet;
            this.dbNotKayitDataSetBindingSource2.Position = 0;
            // 
            // tblNotKayitBindingSource
            // 
            this.tblNotKayitBindingSource.DataMember = "TblNotKayit";
            this.tblNotKayitBindingSource.DataSource = this.dbNotKayitDataSetBindingSource1;
            // 
            // tblNotKayitTableAdapter
            // 
            this.tblNotKayitTableAdapter.ClearBeforeFill = true;
            // 
            // tblNotKayitBindingSource1
            // 
            this.tblNotKayitBindingSource1.DataMember = "TblNotKayit";
            this.tblNotKayitBindingSource1.DataSource = this.dbNotKayitDataSetBindingSource;
            // 
            // tblNotKayitBindingSource2
            // 
            this.tblNotKayitBindingSource2.DataMember = "TblNotKayit";
            this.tblNotKayitBindingSource2.DataSource = this.dbNotKayitDataSetBindingSource1;
            // 
            // tblDevamsizlikBindingSource
            // 
            this.tblDevamsizlikBindingSource.DataMember = "TblDevamsizlik";
            this.tblDevamsizlikBindingSource.DataSource = this.dbNotKayitDataSet1BindingSource;
            // 
            // tblDevamsizlikTableAdapter
            // 
            this.tblDevamsizlikTableAdapter.ClearBeforeFill = true;
            // 
            // dbNotKayitDataSetBindingSource3
            // 
            this.dbNotKayitDataSetBindingSource3.DataSource = this.dbNotKayitDataSet;
            this.dbNotKayitDataSetBindingSource3.Position = 0;
            // 
            // dbNotKayitDataSet1BindingSource1
            // 
            this.dbNotKayitDataSet1BindingSource1.DataSource = this.dbNotKayitDataSet1;
            this.dbNotKayitDataSet1BindingSource1.Position = 0;
            // 
            // dbNotKayitDataSet2
            // 
            this.dbNotKayitDataSet2.DataSetName = "DbNotKayitDataSet2";
            this.dbNotKayitDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbNotKayitDataSet2BindingSource
            // 
            this.dbNotKayitDataSet2BindingSource.DataSource = this.dbNotKayitDataSet2;
            this.dbNotKayitDataSet2BindingSource.Position = 0;
            // 
            // dbNotKayitDataSet3
            // 
            this.dbNotKayitDataSet3.DataSetName = "DbNotKayitDataSet3";
            this.dbNotKayitDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDuyuruBindingSource
            // 
            this.tblDuyuruBindingSource.DataMember = "TblDuyuru";
            this.tblDuyuruBindingSource.DataSource = this.dbNotKayitDataSet3;
            // 
            // tblDuyuruTableAdapter
            // 
            this.tblDuyuruTableAdapter.ClearBeforeFill = true;
            // 
            // RichDuyuruSil
            // 
            this.RichDuyuruSil.Location = new System.Drawing.Point(865, 51);
            this.RichDuyuruSil.Name = "RichDuyuruSil";
            this.RichDuyuruSil.Size = new System.Drawing.Size(325, 309);
            this.RichDuyuruSil.TabIndex = 2;
            this.RichDuyuruSil.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.duyuruIDDataGridViewTextBoxColumn,
            this.duyuruDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.DataSource = this.tblDuyuruBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(371, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(458, 309);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // duyuruIDDataGridViewTextBoxColumn
            // 
            this.duyuruIDDataGridViewTextBoxColumn.DataPropertyName = "DuyuruID";
            this.duyuruIDDataGridViewTextBoxColumn.HeaderText = "DuyuruID";
            this.duyuruIDDataGridViewTextBoxColumn.Name = "duyuruIDDataGridViewTextBoxColumn";
            this.duyuruIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // duyuruDataGridViewTextBoxColumn
            // 
            this.duyuruDataGridViewTextBoxColumn.DataPropertyName = "Duyuru";
            this.duyuruDataGridViewTextBoxColumn.HeaderText = "Duyuru";
            this.duyuruDataGridViewTextBoxColumn.Name = "duyuruDataGridViewTextBoxColumn";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Georgia", 14F);
            this.button2.Location = new System.Drawing.Point(865, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(325, 49);
            this.button2.TabIndex = 4;
            this.button2.Text = "Duyuru Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(841, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Duyuru silmek için veri tabanından duyuru seçiniz.";
            // 
            // BtnCikis
            // 
            this.BtnCikis.Font = new System.Drawing.Font("Georgia", 14F);
            this.BtnCikis.Location = new System.Drawing.Point(437, 402);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(325, 49);
            this.BtnCikis.TabIndex = 7;
            this.BtnCikis.Text = "Menüye Dön";
            this.BtnCikis.UseVisualStyleBackColor = true;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Duyuru Oluşturma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(368, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Duyurular";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(862, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Duyuru Sil";
            // 
            // FrmDuyuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(79)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(1259, 463);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnCikis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.RichDuyuruSil);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RchDuyuru);
            this.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmDuyuru";
            this.Text = "Duyurular";
            this.Load += new System.EventHandler(this.FrmDuyuru_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNotKayitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNotKayitBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNotKayitBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDevamsizlikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSetBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDuyuruBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RchDuyuru;
        private System.Windows.Forms.Button button1;
        private DbNotKayitDataSet dbNotKayitDataSet;
        private System.Windows.Forms.BindingSource dbNotKayitDataSetBindingSource;
        private System.Windows.Forms.BindingSource dbNotKayitDataSetBindingSource1;
        private DbNotKayitDataSet1 dbNotKayitDataSet1;
        private System.Windows.Forms.BindingSource dbNotKayitDataSet1BindingSource;
        private System.Windows.Forms.BindingSource dbNotKayitDataSetBindingSource2;
        private System.Windows.Forms.BindingSource tblNotKayitBindingSource;
        private DbNotKayitDataSetTableAdapters.TblNotKayitTableAdapter tblNotKayitTableAdapter;
        private System.Windows.Forms.BindingSource tblNotKayitBindingSource2;
        private System.Windows.Forms.BindingSource tblNotKayitBindingSource1;
        private System.Windows.Forms.BindingSource tblDevamsizlikBindingSource;
        private DbNotKayitDataSet1TableAdapters.TblDevamsizlikTableAdapter tblDevamsizlikTableAdapter;
        private DbNotKayitDataSet2 dbNotKayitDataSet2;
        private System.Windows.Forms.BindingSource dbNotKayitDataSetBindingSource3;
        private System.Windows.Forms.BindingSource dbNotKayitDataSet1BindingSource1;
        private System.Windows.Forms.BindingSource dbNotKayitDataSet2BindingSource;
        private DbNotKayitDataSet3 dbNotKayitDataSet3;
        private System.Windows.Forms.BindingSource tblDuyuruBindingSource;
        private DbNotKayitDataSet3TableAdapters.TblDuyuruTableAdapter tblDuyuruTableAdapter;
        private System.Windows.Forms.RichTextBox RichDuyuruSil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn duyuruIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duyuruDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}