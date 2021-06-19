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
    public partial class GelirHub : Form
    {
        public GelirHub()
        {
            InitializeComponent();
        }

        private void btnGelirEkleme_Click(object sender, EventArgs e)
        {
            GelirEkleme gelirEkle = new GelirEkleme();
            gelirEkle.Show();
            this.Hide();
        }

        private void btnGelirListeleme_Click(object sender, EventArgs e)
        {
            GelirListeleme gelirListele = new GelirListeleme();
            gelirListele.Show();
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
