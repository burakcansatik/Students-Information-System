using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Database kütüphanemizi ekliyoruz.
using System.Data.SqlClient;

namespace BM102_ProjeOdevi
{
    public partial class FrmOgretmenDetay : Form
    {
        public FrmOgretmenDetay()
        {
            InitializeComponent();
        }
        //Sql databaseimize bağlanmak için yenibaglanti adında bir bağlantı oluşturuyoruz.
        SqlConnection yenibaglanti = new SqlConnection(@"Data Source=DESKTOP-R5RNIF9;Initial Catalog=DbNotKayit;Integrated Security=True");
        private void FrmOgretmenDetay_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbNotKayitDataSet.TblNotKayit' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblNotKayitTableAdapter.Fill(this.dbNotKayitDataSet.TblNotKayit);

        }

        public void temizle()
        {
            //Hem temizle hem de sil butonunda çalışması için kutuları temizleme özelliğini ayrı bir fonksiyon olarak tanımlayıp gerekli yerlerde çağıracağız.
            MaskedNumara.Text = "";
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            TxtSinav1.Text = "";
            TxtSinav2.Text = "";
            TxtProje.Text = "";
            
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        { 
            //kaydet butonu komudu, yenibaglanti ile açıyoruz
            //yeni komut oluşturup insert into ile hangi tablodan hangi sütunlara ekleme yapacağımızı belirtiyoruz.
            yenibaglanti.Open();
            SqlCommand yenikomut = new SqlCommand("insert into TblNotKayit (OgrNo, OgrAd, OgrSoyad) values (@k1,@k2,@k3)", yenibaglanti);
            //Belirlediğimiz parametrelere ilgili değer atamalarını gerçekleştiriyoruz.
            yenikomut.Parameters.AddWithValue("@k1", MaskedNumara.Text);
            yenikomut.Parameters.AddWithValue("@k2", TxtAd.Text);
            yenikomut.Parameters.AddWithValue("@k3", TxtSoyad.Text);
            //insert into, update ve delete komutlarında kullandığımız execute non query kodu
            //SQL sorgularını veritabanında çalıştırmak için kullanılan bir yöntemdir
            yenikomut.ExecuteNonQuery();
            yenibaglanti.Close();
            //kaydın başarıyla gerçekleştiğine dair bildiri mesajı
            MessageBox.Show("Yeni Öğrenci Sisteme Başarılı Bir Şekilde Eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Mesaj gösterildikten sonra verilerin anında gözükmesi için gerekli kodu buraya yazıyoruz.
            this.tblNotKayitTableAdapter.Fill(this.dbNotKayitDataSet.TblNotKayit);

            //Yukarıda kaydettiğimiz öğrenci verilerinin devamsizlik tablosuna da gelmesi için aynısını devamsızlık için de yazıyoruz.
            yenibaglanti.Open();
            SqlCommand sss = new SqlCommand("insert into TblDevamsizlik (OgrNo, OgrAd, OgrSoyad) values (@k1,@k2,@k3)", yenibaglanti);
            sss.Parameters.AddWithValue("@k1", MaskedNumara.Text);
            sss.Parameters.AddWithValue("@k2", TxtAd.Text);
            sss.Parameters.AddWithValue("@k3", TxtSoyad.Text);
            sss.ExecuteNonQuery();
            yenibaglanti.Close();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {  //CellClick özelliğini tablodan bir özelliğe bastığımızda verilerin istediğimiz hücrelere gelmesi için kullanıyoruz
            
            //secilensatır değişkeni oluşturup istediğimiz verileri bunun üzerinden istediğimiz kutulara aktarıyoruz
            int secilensatir = dataGridView1.SelectedCells[0].RowIndex; 
            MaskedNumara.Text = dataGridView1.Rows[secilensatir].Cells[1].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilensatir].Cells[2].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilensatir].Cells[3].Value.ToString();
            TxtSinav1.Text = dataGridView1.Rows[secilensatir].Cells[4].Value.ToString();
            TxtSinav2.Text = dataGridView1.Rows[secilensatir].Cells[5].Value.ToString();
            TxtProje.Text = dataGridView1.Rows[secilensatir].Cells[6].Value.ToString();
        }
        
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            //Güncelle butonu kodları, ortalama hesaplamak için değişkenlerimizi oluşturup gerekli döngülere sokuyoruz
            int sinav1, sinav2, projenotu;
            if (int.TryParse(TxtSinav1.Text, out sinav1) && int.TryParse(TxtSinav2.Text, out sinav2) && int.TryParse(TxtProje.Text, out projenotu))
            { 
                //Notların 0 ile 100 arasında olup olmadığını kontrol ediyoruz.
                if (sinav1 < 0 || sinav1 > 100 || sinav2 < 0 || sinav2 > 100 || projenotu < 0 || projenotu > 100)
                {
                    MessageBox.Show("Notlar 0 ile 100 arasında olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Geçersiz notlar olduğunda fonksiyondan çıkarak işlemi durdur
                }

                // Notlar geçerli, güncelleme işlemini yapmaya başlayabiliriz
                //baglantimizi açıyoruz yine
                yenibaglanti.Open();
                SqlCommand komut = new SqlCommand("update TblNotKayit set OgrSinav1=@j1, OgrSinav2=@j2, OgrProje=@j3 where OgrNo=@j6", yenibaglanti);
                komut.Parameters.AddWithValue("@j1", TxtSinav1.Text);
                komut.Parameters.AddWithValue("@j2", TxtSinav2.Text);
                komut.Parameters.AddWithValue("@j3", TxtProje.Text);
                komut.Parameters.AddWithValue("@j6", MaskedNumara.Text);
                //Yukarıda bahsettiğim gibi update komutu yazdığımız için verilerin işlenmesi amacıyla executenonquery yapıyoruz.
                komut.ExecuteNonQuery();
                yenibaglanti.Close();
                //Güncelleme işleminin başarılı bir şekilde gerçekleştiğine dair bilgi mesajı gösteriyoruz.
                MessageBox.Show("Öğrenci Notları Başarılı Bir Şekilde Güncellendi.", "Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Mesaj gösterildikten sonra verilerin anında gözükmesi için gerekli kodu buraya yazıyoruz.
                this.tblNotKayitTableAdapter.Fill(this.dbNotKayitDataSet.TblNotKayit);
            }
            else
            { 
                //eğer notlar 0 ile 100 arasında değilse güncelleme işlemi yapılmıyor ve veriler önceki haliyle kalıyor.
                MessageBox.Show("Geçersiz not girişi. Notlar 0 ile 100 arasında olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Notların 0 ile 100 arasında olduğunu garantiye aldıktan sonra ortalama hesaplama işlemini yapabiliriz
            double ortalama, s1, s2, proje;
            string durum;
            //Textboxlara girilen değerleri hesap yapmak için inte çeviriyoruz.
            s1 = Convert.ToInt16(TxtSinav1.Text);
            s2 = Convert.ToInt16(TxtSinav2.Text);
            proje = Convert.ToInt16(TxtProje.Text);
            //Ortalamamız sınavların %40ının ve projenin %20sinin alınmasıyla oluşuyor.
            ortalama = (s1 * 2 / 5) + (s2 * 2 / 5) + (proje / 5);
            LblOrt.Text = ortalama.ToString();

            //Öğrencininin geçti mi kaldı mı durumunu belirlemek için bit olarak tanımladığımız OgrDurumun true false olmasını belirliyoruz.
            if (ortalama >= 50) 
            {
                //Ortalama elliden fazla ise öğrenci sınıfı geçiyor ve durumu "True" oluyor.
                durum = "True";
            }
            else
            {
                //Ortalama elliden az ise öğrenci sınıfta kalıyor ve durumu "False" oluyor.
                durum = "False";
            }

            //Durumu ve ortalamayı belirlediğimize göre artık bunları da güncelleme işlemine dahil edebiliriz.
            //Yukarıdaki kodların aynısı
            yenibaglanti.Open();
            SqlCommand komut2 = new SqlCommand("update TblNotKayit set OgrOrt=@j4, OgrDurum=@j5 where OgrNo=@j6", yenibaglanti);
            komut2.Parameters.AddWithValue("@j5", durum);
            komut2.Parameters.AddWithValue("@j4", decimal.Parse(LblOrt.Text));
            komut2.Parameters.AddWithValue("@j6", MaskedNumara.Text);
            //Hala update işlemi yaptığımız için executenonquery yazmayı unutmuyoruz
            komut2.ExecuteNonQuery();
            yenibaglanti.Close();
            //Baglantiyi kapatıyoruz ve bilgilerin anında güncellenmesi için gerekli kodumuzu buraya da yazıyoruz.
            this.tblNotKayitTableAdapter.Fill(this.dbNotKayitDataSet.TblNotKayit);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //yukarıda tanımladığımız temizle fonksiyonunu kutuları temizlemek için buraya çağırıyoruz.
            temizle();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            //Öğrenci kaydı silmek için sil butonumuzun altında kodlarımızı yazıyoruz.
            yenibaglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete From TblNotKayit where OgrNo=@a1", yenibaglanti);
            komutsil.Parameters.AddWithValue("@a1", MaskedNumara.Text);
            //Delete işlemi yaptığımız için executenonquery yazmayı unutmuyoruz.
            komutsil.ExecuteNonQuery();
            yenibaglanti.Close();
            yenibaglanti.Open();
            SqlCommand sil = new SqlCommand("Delete From TblDevamsizlik where OgrNo=@a1", yenibaglanti);
            sil.Parameters.AddWithValue("@a1", MaskedNumara.Text);
            //Delete işlemi yaptığımız için executenonquery yazmayı unutmuyoruz.
            sil.ExecuteNonQuery();
            yenibaglanti.Close();
            //Mesaj kutusunda kaydın başarılı bir şekilde silindiğini belirtmek için bilgilendirme mesajı gösteriyoruz.
            MessageBox.Show("Kayıt Başarılı Bir Şekilde Silindi.", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Öğrenci sildikten sonra kutularımızı temizlemek için tekrar temizleme fonksiyonumuzu çağırıyoruz.
            temizle();
            //Bilgilerin anında güncellenmesi için gerekli kodumuzu buraya da yazıyoruz.
            this.tblNotKayitTableAdapter.Fill(this.dbNotKayitDataSet.TblNotKayit);
        }

        private void BtnGectiKaldi_Click(object sender, EventArgs e)
        {
            //gecen ve kalan öğrenci hesabını bu buton altında yapıyoruz.
            //Değişkenlerimizi belirliyoruz ve hepsini 0a atıyoruz.
            int gecen = 0, kalan = 0; int i = 0;


            while (dataGridView1.Rows[i].Cells[0].Value != null)

            {

                if (dataGridView1.Rows[i].Cells[8].Value.ToString() == "True")
                    //Eğer durum true ise geçen kısmını bir arttırıyoruz.
                    gecen = gecen + 1;

                if (dataGridView1.Rows[i].Cells[8].Value.ToString() == "False")
                    //Eğer durum false ise kalan kısmını bir arttırıyoruz.
                    kalan++;

                i++;

            }
            //Kalan öğrencileri kalan labelına
            LblKalan.Text = kalan.ToString();
            //Geçen öğrencileri geçen labelına yazdırıyoruz.
            LblGecen.Text = gecen.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Çıkış butonumuza basıldığında mevcut görüntülenen form gizleniyor ve menüye dönülüyor.
            this.Hide();
        }
    }
    
}
