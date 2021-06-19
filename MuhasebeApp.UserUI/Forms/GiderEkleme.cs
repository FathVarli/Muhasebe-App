using Business.Abstract;
using Entity.Concrete;
using MuhasebeApp.Business.DependecyResolvers.Ninject;
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
    public partial class GiderEkleme : Form
    {
        public GiderEkleme()
        {
            InitializeComponent();
            _giderService = InstanceFactory.GetInstance<IGiderService>();
        }
        private IGiderService _giderService;

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                validationError.Clear();

                var newGider = new Gider
                {
                    Icerik = txtIcerik.Text,
                    ToplamTutar = Convert.ToDecimal(txtToplamTutar.Text),
                    Tarih = setDate(dtpTarih.Value),
                    Aciklama = txtAciklama.Text
                };

                var result = _giderService.Add(newGider);
                MessageBox.Show(result.Message);
            }
        }

        private void txtToplamTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtIcerik_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtIcerik.Text))
            {
                e.Cancel = true;
                txtIcerik.Focus();
                validationError.SetError(txtIcerik, "İçerik Alanı Boş Bırakılamaz!");
            }
        }

        private void txtToplamTutar_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtToplamTutar.Text))
            {
                e.Cancel = true;
                txtToplamTutar.Focus();
                validationError.SetError(txtToplamTutar, "Toplam Tutar Boş Bırakılamaz!");
            }
        }


        private DateTime setDate(DateTime date)
        {
            return new DateTime(date.Year, date.Month, date.Day);
        }
    }
}
