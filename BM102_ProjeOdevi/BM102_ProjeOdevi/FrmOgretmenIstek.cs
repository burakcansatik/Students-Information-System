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
    public partial class FrmOgretmenIstek : Form
    {
        public FrmOgretmenIstek()
        {
            InitializeComponent();
        }
        //Databasemizden verileri çekmek için databasemize bağlanıyoruz.
        SqlConnection yenibaglanti = new SqlConnection(@"Data Source=DESKTOP-R5RNIF9;Initial Catalog=DbNotKayit;Integrated Security=True");
        private void FrmOgretmenIstek_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbNotKayitDataSet4.TblIstek' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblIstekTableAdapter.Fill(this.dbNotKayitDataSet4.TblIstek);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Datagridviewdeki verileri isteidğimiz alanlara doldurmak için yazdığımız kod.
            int secilensatir = dataGridView1.SelectedCells[0].RowIndex;
            LabelAd.Text = dataGridView1.Rows[secilensatir].Cells[0].Value.ToString();
            LabelSoyad.Text = dataGridView1.Rows[secilensatir].Cells[1].Value.ToString();
            RichGoruntule.Text = dataGridView1.Rows[secilensatir].Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Menüye döne basıldığında mevcut gösterilen formu kapatıyoruz.
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Öğrenci istek ve şikayetlerini okuduğumuz zaman gelen kutusunda birikmemesi için siliyoruz
            yenibaglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete From TblIstek where OgrMesaj=@a1", yenibaglanti);
            komutsil.Parameters.AddWithValue("@a1", RichGoruntule.Text);
            komutsil.ExecuteNonQuery();
            yenibaglanti.Close();
            //Silme işleminin başarılı bir şekilde gerçekleştiğini belirtiyoruz.
            MessageBox.Show("Kayıt Başarılı Bir Şekilde Silindi.", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Metni sildiğimiz için tabloyu temizliyoruz
            RichGoruntule.Text = "";
            //Verileri güncelliyoruz.
            this.tblIstekTableAdapter.Fill(this.dbNotKayitDataSet4.TblIstek);
        }
    }
}
