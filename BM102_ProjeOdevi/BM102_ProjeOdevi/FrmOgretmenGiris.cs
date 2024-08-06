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
    public partial class FrmOgretmenGiris : Form
    {
        //databasemizden veri çekmek için yenibaglanti oluşturuyoruz 
        SqlConnection yenibaglanti = new SqlConnection(@"Data Source=DESKTOP-R5RNIF9;Initial Catalog=DbNotKayit;Integrated Security=True");
        public FrmOgretmenGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Giriş yapmak için databasedeki verilerle uyumlu mu değil mi kontrolünü yapacağız
            yenibaglanti.Open();
            SqlCommand yenikomut = new SqlCommand("Select * From TblOgretmenGiris Where OgretmenTC=@p1 and OgretmenSifre=@p2", yenibaglanti);
            yenikomut.Parameters.AddWithValue("@p1", MaskedTc.Text);
            yenikomut.Parameters.AddWithValue("@p2", MaskedSifre.Text);

            //Buradan itibaren yazılan kodlar girilen verilerin databasede olup olmadığını kontrol etmek için
            SqlDataReader dr = yenikomut.ExecuteReader();

            if (dr.Read())
            {
                //Eğer okuduğumuzda veriler eşleşiyorsa öğretmen panel formuna gidiyoruz
                FrmOgretmenPanel git = new FrmOgretmenPanel();
                git.Show();
                
            }
            else
            {
                //Eğer okuma yapıldığında veritabanında aynı veriler yok ise uyarı mesajı veriyoruz.
                MessageBox.Show("Hatalı Öğretmen Girişi", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            yenibaglanti.Close();
            
        }

        private void FrmOgretmenGiris_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Kayıt olma labeline tıklandığında kaydolma forumuna gitmek için yazdığımız kod.
            FrmOgretmenKaydol git = new FrmOgretmenKaydol();
            git.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Programı tamamen kapatmak için yazdığımız kod.
            Application.Exit();
        }
    }
}
