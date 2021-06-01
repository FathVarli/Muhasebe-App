using MuhasebeApp.Business.Abstract;
using MuhasebeApp.Business.DependecyResolvers.Ninject;
using MuhasebeApp.Entity.Dto;
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
    public partial class Kayit : Form
    {
        IKullaniciService _kullaniciService;
        public Kayit()
        {
            InitializeComponent();
            _kullaniciService = InstanceFactory.GetInstance<IKullaniciService>();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var registerDto = new RegisterDto
            {
                Ad = txtAd.Text.ToUpper(),
                Soyad = txtSoyad.Text.ToUpper(),
                Tc = txtTc.Text,
                Sifre = txtSifre.Text.Trim()
            };
           var result = _kullaniciService.Register(registerDto);
            MessageBox.Show(result.Message);
        }
    }
}
