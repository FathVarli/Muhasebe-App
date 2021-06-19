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
    public partial class GiderHub : Form
    {
        public GiderHub()
        {
            InitializeComponent();
        }

        private void btnGiderEkleme_Click(object sender, EventArgs e)
        {
            GiderEkleme giderEkleme = new GiderEkleme();
            giderEkleme.Show();
            this.Hide();
        }

        private void btnGiderListeleme_Click(object sender, EventArgs e)
        {
            GiderListeleme giderListeleme = new GiderListeleme();
            giderListeleme.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomePage hmPage = new HomePage();
            hmPage.Show();
            this.Hide();
        }
    }
}
