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
    public partial class FrmOgrenciGiris : Form
    {
        //Databaseimize bağlanıyoruz
        SqlConnection yenibaglanti = new SqlConnection(@"Data Source=DESKTOP-R5RNIF9;Initial Catalog=DbNotKayit;Integrated Security=True");
        public FrmOgrenciGiris()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            yenibaglanti.Open();
            //Databasemize bağlanıyoruz ve öğrenci numarasını databasede sorgulatmaya başlıyoruz.
            SqlCommand yenikomut = new SqlCommand("Select * From TblNotKayit Where OgrNo=@p1", yenibaglanti);
            yenikomut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            SqlDataReader dr = yenikomut.ExecuteReader();

            if(dr.Read())
            { 
                //Yaptığımız sorgulatmada eğer database ile eşleşen veri bulursak bir sonraki forma gidiyoruz.
                FrmOgrenciPanel git = new FrmOgrenciPanel();
                git.no = maskedTextBox1.Text;
                git.Show();
            }
            else
            {
                //Eğer veriler eşleşmiyorsa hata uyarısı veriyoruz.
                MessageBox.Show("Hatalı Numara Girişi", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            yenibaglanti.Close();
        }

        private void FrmOgrenciGiris_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Uygulamayı tamamen kapatmak için kullandığımız kod.
            Application.Exit();
        }
    }
}
