using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BM102_ProjeOdevi
{
    public partial class FrmOgretmenKaydol : Form
    {
        //Databasemizden veri çekmek için veya eklemek için databasemize bağlanıyoruz
        SqlConnection yenibaglanti = new SqlConnection(@"Data Source=DESKTOP-R5RNIF9;Initial Catalog=DbNotKayit;Integrated Security=True");
        public FrmOgretmenKaydol()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Eğer veri giriş yerleri tamamen doluysa işlem yapmaya başlıyoruz.
            if (MaskedTC.MaskFull && MaskedSifre.MaskFull)
            {
                //Bağlantımızı açıyoruz.
                yenibaglanti.Open();
                SqlCommand yenikomut = new SqlCommand("insert into TblOgretmenGiris (OgretmenTC, OgretmenSifre) values (@k1,@k2)", yenibaglanti);
                yenikomut.Parameters.AddWithValue("@k1", MaskedTC.Text);
                yenikomut.Parameters.AddWithValue("@k2", MaskedSifre.Text);
                //Yeni kaydı oluşturuyor ve kaydediyoruz
                yenikomut.ExecuteNonQuery();
                yenibaglanti.Close();
                //Kaydın başarıyla gerçekleştiğini messageboxta gösterip kaydolma formunu kapatıyoruz.
                MessageBox.Show("Yeni Öğretmen Kaydı Sisteme Başarılı Bir Şekilde Eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                //Eğer veri giriş yerleri tam dolmadıysa eksik girildiğine dair hata mesajı gösteriyoruz.
                MessageBox.Show("Eksik giriş yaptınız","Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmOgretmenKaydol_Load(object sender, EventArgs e)
        {

        }
    }
}
