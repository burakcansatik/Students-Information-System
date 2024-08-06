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
    public partial class FrmOgretmenDuyuru : Form
    {
        //Database ile işimiz olduğu için databasemize bağlanıyoruz.
        SqlConnection yenibaglanti = new SqlConnection(@"Data Source=DESKTOP-R5RNIF9;Initial Catalog=DbNotKayit;Integrated Security=True");
        public FrmOgretmenDuyuru()
        {
            InitializeComponent();
        }

        

        private void FrmDuyuru_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbNotKayitDataSet3.TblDuyuru' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblDuyuruTableAdapter.Fill(this.dbNotKayitDataSet3.TblDuyuru);
            // TODO: Bu kod satırı 'dbNotKayitDataSet1.TblDevamsizlik' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblDevamsizlikTableAdapter.Fill(this.dbNotKayitDataSet1.TblDevamsizlik);
            // TODO: Bu kod satırı 'dbNotKayitDataSet.TblNotKayit' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblNotKayitTableAdapter.Fill(this.dbNotKayitDataSet.TblNotKayit);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //baglantimizi açıyoruz ve insert into ile yeni duyurumuzu kaydetmeye başlıyoruz.
            yenibaglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TblDuyuru (Duyuru) values (@d1)", yenibaglanti);
            //Atadığımız parametrelere değer atama işlemini gerçekleştiriyoruz.
            komut.Parameters.AddWithValue("@d1", RchDuyuru.Text);
            komut.ExecuteNonQuery();
            //executenonquery ile veri atama işlemini tamamlayıp bağlantımızı kapatıyoruz.
            yenibaglanti.Close();
            //mesaj kutusunda işlemin başarılı bir şekilde gerçekleştiğini belirtip tablodaki bilgileri anlık olarak güncelliyoruz. 
            MessageBox.Show("Yeni Duyuru Oluşturuldu ve Öğrencilere Gönderildi", "Gönderildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.tblDuyuruTableAdapter.Fill(this.dbNotKayitDataSet3.TblDuyuru);
            //İşlemler bittikten sonra RichTextBoxtaki metni de temizliyoruz.
            RchDuyuru.Text = "";
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //Cellclick özelliği ile datagridviewdeki seçilen duyuruyu duyuru silme alanına taşıyoruz.
            int secilensatir = dataGridView1.SelectedCells[0].RowIndex;
            RichDuyuruSil.Text = dataGridView1.Rows[secilensatir].Cells[1].Value.ToString();

        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            //Menüye dön butonu ile mevcut formu gizleyip önceki menüyü açıyoruz.
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //baglantimizi açıyoruz ve delete komutu ile  duyurumuzu silme işlemine başlıyoruz.
            yenibaglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete From TblDuyuru where Duyuru=@a1", yenibaglanti);
            //Atadığımız parametrelere ilgili değerleri işlemin yapılacağı verileri atıyoruz. 
            komutsil.Parameters.AddWithValue("@a1", RichDuyuruSil.Text);
            //Kodları işleyip bağlantımızı kapatıyoruz.
            komutsil.ExecuteNonQuery();
            yenibaglanti.Close();
            //Mesaj kutusunda işlemin gerçekleştiğini belirtip metnin geldiği kısmı temizliyor ve tablomuzu anlık olarak güncelliyoruz.
            MessageBox.Show("Kayıt Başarılı Bir Şekilde Silindi.", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RichDuyuruSil.Text = "";
            this.tblDuyuruTableAdapter.Fill(this.dbNotKayitDataSet3.TblDuyuru);
        }
    }
}
