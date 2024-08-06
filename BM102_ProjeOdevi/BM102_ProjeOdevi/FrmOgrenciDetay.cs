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
using System.Security.Cryptography;


namespace BM102_ProjeOdevi
{
    public partial class FrmOgrenciDetay : Form
    {
        public FrmOgrenciDetay()
        {
            InitializeComponent();
        }
        //Databaseimizden veri çekeceğimiz için databasemize bağlanıyoruz.
        SqlConnection yenibaglanti = new SqlConnection(@"Data Source=DESKTOP-R5RNIF9;Initial Catalog=DbNotKayit;Integrated Security=True");
       
        //Databasemizden çekilecek verileri numara üzerinden gerçekleştireceğimiz için public bir numara değişkeni oluşturup
        //bu değişkenin değerini öğrencigiris ekranında girilen numaradan alıyoruz.
        public string numara;
        

        private void FrmOgrenciDetay_Load(object sender, EventArgs e)
        {
            //Girişte aldığımız numara değerini burdaki numara değişkenine aktarıyoruz.
            LblNumara.Text = numara;

            yenibaglanti.Open();
            //Bağlantımızı açtık ve öğrencinin devamsızlık sayısını numaraya göre bulup getiriyoruz.
            SqlCommand komut = new SqlCommand("SELECT OgrDevamsizlik FROM TblDevamsizlik WHERE OgrNo = @k1", yenibaglanti);
            //Parametremize değer atamasını yapıyoruz.
            komut.Parameters.AddWithValue("@k1", numara.ToString());
            //Devamsızlık sayımızı getirtmek için bağlandığımız yerdeki verileri okuyoruz ve devamsızlık verisini 
            //labele yazdırdıktan sonra bağlantımızı kapatıyoruz.
            using (SqlDataReader reader = komut.ExecuteReader())
            {
                if (reader.Read())
                {
                    short devamsizlikSayisi = reader.GetInt16(0);
                    LblDevamsizlik.Text = devamsizlikSayisi.ToString();
                }
            }
            yenibaglanti.Close(); 
            

            yenibaglanti.Open();
            //baglantimizi tekrar açıyoruz ve ogrenci numarasına ulaşıyoruz
            SqlCommand yenikomut = new SqlCommand("Select * From TblNotKayit where OgrNo=@a1", yenibaglanti);
            yenikomut.Parameters.AddWithValue("@a1", numara);
            //ulaştığımız numara verisi ile tablomuzdaki diğer verilerin okuma işlemini yapıyoruz
            SqlDataReader dr = yenikomut.ExecuteReader();
            while (dr.Read())
            {
                //Ad ve soyadı yan yana yazacağımız için okuma işlemi yaparken aynı satırda yazdırıp arasına bir adet boşluk koyuyoruz.
                LblAdSoyad.Text = dr[2].ToString() + " " + dr[3].ToString();
                LblSinav1.Text = dr[4].ToString();
                LblSinav2.Text = dr[5].ToString();
                LblProjeNotu.Text = dr[6].ToString();
                LblOrtalama.Text = dr[7].ToString();
                LblKontrol.Text = dr[8].ToString();

                if (LblKontrol.Text == "True")
                {
                    //Eğer öğrencinin geçme durumu true ise öğrencinin durumuna öğrenci sınıfı geçti yazıyoruz ve
                    //sadece tik olan pictureboxımızın görünürlük özelliğini true hale getiriyoruz.
                    LblDurum.Text = "Öğrenci Sınıfı Geçti.";
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = false;
                }
                else
                {
                    //Eğer öğrencinin geçme durumu false ise öğrencinin durumuna öğrenci sınıfta kaldı yazıyoruz ve
                    //sadece çarpı işareti olan pictureboxımızın görünürlük özelliğini true hale getiriyoruz.
                    LblDurum.Text = "Öğrenci Sınıfta Kaldı.";
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = true;
                }

            }
            yenibaglanti.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Bir önceki menüye dönmek için yazdığımız kod.
            this.Hide();
        }
    }
}
