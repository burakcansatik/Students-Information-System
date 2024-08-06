namespace BM102_ProjeOdevi
{
    partial class FrmOgretmenKaydol
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MaskedTC = new System.Windows.Forms.MaskedTextBox();
            this.MaskedSifre = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(46, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğretmen TC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // MaskedTC
            // 
            this.MaskedTC.Location = new System.Drawing.Point(200, 87);
            this.MaskedTC.Mask = "00000000000";
            this.MaskedTC.Name = "MaskedTC";
            this.MaskedTC.Size = new System.Drawing.Size(177, 29);
            this.MaskedTC.TabIndex = 2;
            this.MaskedTC.ValidatingType = typeof(int);
            // 
            // MaskedSifre
            // 
            this.MaskedSifre.Location = new System.Drawing.Point(200, 123);
            this.MaskedSifre.Mask = "0000";
            this.MaskedSifre.Name = "MaskedSifre";
            this.MaskedSifre.Size = new System.Drawing.Size(177, 29);
            this.MaskedSifre.TabIndex = 3;
            this.MaskedSifre.ValidatingType = typeof(int);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Kayıt Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(42, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(352, 43);
            this.label3.TabIndex = 5;
            this.label3.Text = "Öğretmen Kayıt Ekranı";
            // 
            // FrmOgretmenKaydol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(74)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(437, 220);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MaskedSifre);
            this.Controls.Add(this.MaskedTC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmOgretmenKaydol";
            this.Text = "OgretmenKaydol";
            this.Load += new System.EventHandler(this.FrmOgretmenKaydol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox MaskedTC;
        private System.Windows.Forms.MaskedTextBox MaskedSifre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}