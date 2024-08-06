using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BM102_ProjeOdevi
{
    public partial class FrmOgrenciPanel : Form
    {
        //Veri tabanımızdan ilgili verilerle işlem yapmak için veri tabanımıza bağlanıyoruz.
        SqlConnection yenibaglanti = new SqlConnection(@"Data Source=DESKTOP-R5RNIF9;Initial Catalog=DbNotKayit;Integrated Security=True");
        public FrmOgrenciPanel()
        {
            InitializeComponent();
        }
        //Öğrencinin not ekranındaki bilgilere ulaşmak için numarasını son panele kadar taşıyoruz.
        public string no;
        private void button1_Click(object sender, EventArgs e)
        {
            //Butona basıldığında OgrenciDetay formuna gidiyoruz ve numarayı da oraya taşıyoruz.
            FrmOgrenciDetay git = new FrmOgrenciDetay();
            LblNo.Text= no;
            git.numara = no;
            git.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Butona basıldığında OgrenciDuyuru formuna gidiyoruz.
            FrmOgrenciDuyuru go = new FrmOgrenciDuyuru();
            go.Show();
        }

        private void FrmOgrenciPanel_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Bir önceki menüye dönmek için mevcut menüyü gizliyoruz.
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Butona basıldığında FrmOgrenciIstek formuna gidiyoruz.
            FrmOgrenciIstek git = new FrmOgrenciIstek();
            git.Show();
        }
    }
}
