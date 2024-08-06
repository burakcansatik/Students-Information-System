using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BM102_ProjeOdevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Öğrenci giriş ekranına gitmek için öğrencigiriş formundan aktar adında bir nesne türetip ona gidiyoruz.
            FrmOgrenciGiris aktar = new FrmOgrenciGiris();
            aktar.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Öğretmen giriş ekranına gitmek için yazdığımız kod
            FrmOgretmenGiris aktarr = new FrmOgretmenGiris();
            aktarr.Show();  
            this.Hide();
        }
    }
}
