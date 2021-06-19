using DataAccess.EntityFramework;
using MuhasebeApp.Business.Abstract;
using MuhasebeApp.Business.DependecyResolvers.Ninject;
using MuhasebeApp.DataAccess.EntityFramework;
using MuhasebeApp.Entity;
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
    public partial class Giris : Form
    {
        IKullaniciService _kullaniciService;
        public Giris()
        {
            InitializeComponent();
            _kullaniciService = InstanceFactory.GetInstance<IKullaniciService>();
        }
        private void Giris_Load(object sender, EventArgs e)
        {
            PgDbContext context = new PgDbContext();
            context.Database.EnsureCreated();
            DbInitializer.Initialize(context);

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            var loginDto = new LoginDto
            {
                Tc = txtTc.Text,
                Sifre = txtSifre.Text.Trim()
            };

            var result = _kullaniciService.Login(loginDto);
            if (result.Success)
            {
                HomePage hPage = new HomePage();
                hPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(result.Message,"Muhasebe App", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            Kayit kayit = new Kayit();
            kayit.Show();
            this.Hide();
        }
    }
}
