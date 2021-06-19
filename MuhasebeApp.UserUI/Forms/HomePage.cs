using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuhasebeApp.UserUI.Forms
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToLongTimeString();
            lblTarih.Text = DateTime.Now.ToLongDateString();
        }

        private void btnGelir_Click(object sender, EventArgs e)
        {
            GelirHub gelirHub = new GelirHub();
            gelirHub.Show();
            this.Hide();
        }

        private void btnGider_Click(object sender, EventArgs e)
        {
            GiderHub giderHub = new GiderHub();
            giderHub.Show();
            this.Hide();
        }

        private void btnMalzeme_Click(object sender, EventArgs e)
        {
            MalzemeIslemleri malIslem = new MalzemeIslemleri();
            malIslem.Show();
            this.Hide();
        }

        private void btnRaporlama_Click(object sender, EventArgs e)
        {
            Istatistik istatistik = new Istatistik();
            istatistik.Show();
            this.Hide();
        }
    }
}
