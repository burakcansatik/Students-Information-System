using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BM102_ProjeOdevi
{
    public partial class GirisPaneli : Form
    {
        public GirisPaneli()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmOgretmenGiris git = new FrmOgretmenGiris();  
            git.Show();
            this.Hide(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmOgrenciGiris gitt = new FrmOgrenciGiris();    
            gitt.Show();
            this.Hide();
           
        }
    }
}
