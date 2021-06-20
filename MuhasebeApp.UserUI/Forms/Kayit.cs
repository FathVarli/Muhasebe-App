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
            if (ValidationRules())
            {
                var registerDto = new RegisterDto
                {
                    Ad = txtAd.Text.ToUpper(),
                    Soyad = txtSoyad.Text.ToUpper(),
                    Tc = txtTc.Text,
                    Sifre = txtSifre.Text.Trim()
                };
                var result = _kullaniciService.Register(registerDto);
                if (result.Success)
                {
                    MessageBox.Show(result.Message, "Muhasebe App", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Giris giris = new Giris();
                    giris.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(result.Message, "Muhasebe App", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private bool ValidationRules()
        {
            if (string.IsNullOrEmpty(txtAd.Text))
            {
                txtAd.Focus();
                validationError.SetError(txtAd, "Ad Alanı Boş Bırakılamaz!");
                return false;
            }
            if (string.IsNullOrEmpty(txtSoyad.Text))
            {
                txtSoyad.Focus();
                validationError.SetError(txtSoyad, "Soyad Alanı Boş Bırakılamaz!");
                return false;
            }
            if (string.IsNullOrEmpty(txtTc.Text))
            {
                txtTc.Focus();
                validationError.SetError(txtTc, "Tc Alanı Boş Bırakılamaz!");
                return false;
            }
            if (txtTc.Text.Length != 11)
            {
                txtTc.Focus();
                validationError.SetError(txtTc, "TC Numarası 11 Haneli Olmalıdır.");
                return false;
            }
            if (string.IsNullOrEmpty(txtSifre.Text))
            {
                txtSifre.Focus();
                validationError.SetError(txtSifre, "Şifre Alanı Boş Bırakılamaz!");
                return false;
            }
            if (txtSifre.Text.Length < 6)
            {
                txtSifre.Focus();
                validationError.SetError(txtSifre, "Şifre Uzunluğu Minimum 6 Karakter Olmalıdır!");
                return false;
            }

            return true;
        }
    }
}
