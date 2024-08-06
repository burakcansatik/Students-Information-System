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
    public partial class FrmOgretmenPanel : Form
    {
        public FrmOgretmenPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Öğretmenin not listesine gitmesi için not listesinin olduğu FrmOgretmenDetay formundan gitt adında bir nesne türetip oraya gidiyoruz.
            FrmOgretmenDetay gitt = new FrmOgretmenDetay();
            gitt.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Öğretmenin devamsızlık menüsüne gitmesi için yazdığımız kod
            FrmOgretmenDevamsizlik baglan = new FrmOgretmenDevamsizlik();
            baglan.Show();
            
        }

        private void FrmOgretmenPanel_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Öğretmenin duyuru formuna gitmesi için yazdığımız kod
            FrmOgretmenDuyuru git = new FrmOgretmenDuyuru();
            git.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Öğretmenin istek ve şikayet formuna gitmesi için yazdığımız kod
            FrmOgretmenIstek git =  new FrmOgretmenIstek();
            git.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Giriş menüsüne dönmek için mevcut formu gizliyoruz.
            this.Hide();
        }
    }
}
