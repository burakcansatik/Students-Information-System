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
    public partial class FrmOgrenciDuyuru : Form
    {
        //Veri tabanından veri alacağımız için veri tabanına bağlanıyoruz
        SqlConnection yenibaglanti = new SqlConnection(@"Data Source=DESKTOP-R5RNIF9;Initial Catalog=DbNotKayit;Integrated Security=True");
        public FrmOgrenciDuyuru()
        {
            InitializeComponent();
        }

        private void FrmOgrenciDuyuru_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbNotKayitDataSet2.TblNotKayit' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblNotKayitTableAdapter.Fill(this.dbNotKayitDataSet2.TblNotKayit);
            //Sadece okuma işlemi yapacağımız için database seçip onu getiriyoruz, tabloya verilerin tam sığması için özelliğini doldur haline getiriyoruz.
            DataTable dt = new DataTable();
            SqlDataAdapter da  = new SqlDataAdapter("Select * From TblDuyuru", yenibaglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            // TODO: Bu kod satırı 'dbNotKayitDataSet2.TblDevamsizlik' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblDevamsizlikTableAdapter.Fill(this.dbNotKayitDataSet2.TblDevamsizlik);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Cellclick özelliği ile tablodaki verilerin istediğimiz yerlere gelmesini sağlıyoruz.
            int secilensatir = dataGridView1.SelectedCells[0].RowIndex;
            RichDuyuru.Text = dataGridView1.Rows[secilensatir].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //menüye dön butonu ile mevcut formu gizliyoruz.
            this.Hide();
        }
    }
}
