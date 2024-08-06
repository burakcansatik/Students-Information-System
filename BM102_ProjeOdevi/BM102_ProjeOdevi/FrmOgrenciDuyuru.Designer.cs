namespace BM102_ProjeOdevi
{
    partial class FrmOgrenciDuyuru
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
            this.dbNotKayitDataSet2 = new BM102_ProjeOdevi.DbNotKayitDataSet2();
            this.tblDevamsizlikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblDevamsizlikTableAdapter = new BM102_ProjeOdevi.DbNotKayitDataSet2TableAdapters.TblDevamsizlikTableAdapter();
            this.tblNotKayitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblNotKayitTableAdapter = new BM102_ProjeOdevi.DbNotKayitDataSet2TableAdapters.TblNotKayitTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RichDuyuru = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDevamsizlikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNotKayitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dbNotKayitDataSet2
            // 
            this.dbNotKayitDataSet2.DataSetName = "DbNotKayitDataSet2";
            this.dbNotKayitDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDevamsizlikBindingSource
            // 
            this.tblDevamsizlikBindingSource.DataMember = "TblDevamsizlik";
            this.tblDevamsizlikBindingSource.DataSource = this.dbNotKayitDataSet2;
            // 
            // tblDevamsizlikTableAdapter
            // 
            this.tblDevamsizlikTableAdapter.ClearBeforeFill = true;
            // 
            // tblNotKayitBindingSource
            // 
            this.tblNotKayitBindingSource.DataMember = "TblNotKayit";
            this.tblNotKayitBindingSource.DataSource = this.dbNotKayitDataSet2;
            // 
            // tblNotKayitTableAdapter
            // 
            this.tblNotKayitTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(446, 231);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // RichDuyuru
            // 
            this.RichDuyuru.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RichDuyuru.Location = new System.Drawing.Point(0, 281);
            this.RichDuyuru.Name = "RichDuyuru";
            this.RichDuyuru.Size = new System.Drawing.Size(446, 248);
            this.RichDuyuru.TabIndex = 1;
            this.RichDuyuru.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Not: Duyuruyu detaylı okumak için üstüne tıklayınız.";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(120, 535);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Duyurulardan Çık";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmOgrenciDuyuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(74)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(445, 578);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RichDuyuru);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmOgrenciDuyuru";
            this.Text = "Öğrenci Duyuru Formu";
            this.Load += new System.EventHandler(this.FrmOgrenciDuyuru_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDevamsizlikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNotKayitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DbNotKayitDataSet2 dbNotKayitDataSet2;
        private System.Windows.Forms.BindingSource tblDevamsizlikBindingSource;
        private DbNotKayitDataSet2TableAdapters.TblDevamsizlikTableAdapter tblDevamsizlikTableAdapter;
        private System.Windows.Forms.BindingSource tblNotKayitBindingSource;
        private DbNotKayitDataSet2TableAdapters.TblNotKayitTableAdapter tblNotKayitTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox RichDuyuru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}