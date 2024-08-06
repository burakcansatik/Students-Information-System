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
    public partial class FrmOgretmenDevamsizlik : Form
    {

        
        public FrmOgretmenDevamsizlik()
        {
            InitializeComponent();
        }
        SqlConnection yenibaglanti = new SqlConnection(@"Data Source=DESKTOP-R5RNIF9;Initial Catalog=DbNotKayit;Integrated Security=True");
        private void FrmDevamsizlik_Load(object sender, EventArgs e)

        {
           
            
            // TODO: Bu kod satırı 'dbNotKayitDataSet1.TblDevamsizlik' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblDevamsizlikTableAdapter.Fill(this.dbNotKayitDataSet1.TblDevamsizlik);

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Cellclick özelliği ile datagridviewde üstüne bastığımız verileri ilgili alanlara dolduruyoruz.
            int secilensatir = dataGridView1.SelectedCells[0].RowIndex;
            MaskedNumara.Text = dataGridView1.Rows[secilensatir].Cells[1].Value.ToString();
            TxtDevamsizlik.Text = dataGridView1.Rows[secilensatir].Cells[4].Value.ToString();

            
        }
        
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            //Database ile işlem yapacağımız için bağlantımızı açıyoruz.
            yenibaglanti.Open();
            //TblDevamsizlik tablosundaki verileri güncellemek için gerekli kodları giriyoruz.
            SqlCommand yenikomut2 = new SqlCommand("update TblDevamsizlik set OgrDevamsizlik=@j1 where OgrNo=@p1", yenibaglanti);
            //Belirlediğimiz parametrelere ilgili alanlardaki verileri ekliyoruz.
            yenikomut2.Parameters.AddWithValue("@j1", TxtDevamsizlik.Text);
            yenikomut2.Parameters.AddWithValue("@p1", MaskedNumara.Text);
            int etkilenensatir = yenikomut2.ExecuteNonQuery();

            //Burada devamsızlıkta geçersiz numara girilip girilmediğini kontrol edeceğiz.
            if (etkilenensatir > 0)
            {
                //eğer executenonqueryde etkilenensatır 0 olmadı ise ilgili öğrencinin devamsizlik bilgisini güncelliyoruz.
                MessageBox.Show("Öğrencinin Devamsızlık Sayısı Sisteme Başarılı Bir Şekilde Eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //etkilenen satır 0 değil ise hatalı numara girişi olarak uyarı mesajı veriyoruz.
                MessageBox.Show("Hatalı Numara Girişi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //baglantimizi kapatıp tablodaki verilen anlık güncellenmesi için gerekli kodu yazıyoruz.
            yenibaglanti.Close();
            this.tblDevamsizlikTableAdapter.Fill(this.dbNotKayitDataSet1.TblDevamsizlik);
            MaskedNumara.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
