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
    public partial class FrmOgrenciIstek : Form
    {
        //Burada yazılacak şeyleri veritabanımıza kaydedeceğimiz için veri tabanımıza bağlanıyoruz.
        SqlConnection yenibaglanti = new SqlConnection(@"Data Source=DESKTOP-R5RNIF9;Initial Catalog=DbNotKayit;Integrated Security=True");
        public FrmOgrenciIstek()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Bağlantımızı açıyoruz.
            yenibaglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TblIstek (OgrAd,OgrSoyad,OgrMesaj) values (@d1,@d2,@d3)", yenibaglanti);
            //Insert into ile verilere parametre veriyoruz ve bu parametrelere aşağıdan değer atıyoruz
            komut.Parameters.AddWithValue("@d1", TxtAd.Text);
            komut.Parameters.AddWithValue("@d2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@d3", Richistek.Text);
            komut.ExecuteNonQuery();
            yenibaglanti.Close();
            //İşlemin başarılı bir şekilde gerçekleştiğini messagebox ile bildiriyoruz.
            MessageBox.Show("İstek ve Şikayetiniz Öğretmene Gönderildi.", "Gönderildi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Gönderme işleminin ardından kutuları temizliyoruz.
            Richistek.Text = "";
            TxtAd.Text = "";
            TxtSoyad.Text = "";
        }

        private void Frmistek_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Mevcut pencereyi kapatarak menüye dönüyoruz
            this.Hide();
        }
    }
}
