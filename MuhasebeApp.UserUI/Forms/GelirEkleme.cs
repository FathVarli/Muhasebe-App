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
    public partial class GelirEkleme : Form
    {
        public GelirEkleme()
        {
            InitializeComponent();
            _gelirService = InstanceFactory.GetInstance<IGelirService>();
            _malzemeService = InstanceFactory.GetInstance<IMalzemeService>();
        }

        private IGelirService _gelirService;
        private IMalzemeService _malzemeService;

        private void GelirEkleme_Load(object sender, EventArgs e)
        {
            cbxMalzemeAdi.DataSource = _malzemeService.GetAllMalzemeAdi().Data;
            cbxOdemeSekli.DataSource = getOdemeSekliList();
            if (!string.IsNullOrEmpty(cbxMalzemeAdi.Text))
            {
                lblBirim.Text = _malzemeService.GetByName(cbxMalzemeAdi.Text).Data.Birim;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                validationError.Clear();
                var malzeme = _malzemeService.GetByName(cbxMalzemeAdi.Text);
                if (!malzeme.Success)
                {
                    MessageBox.Show(malzeme.Message);
                }
                else
                {

                    var newGelir = new Gelir
                    {
                        MalzemeId = malzeme.Data.Id,
                        Tarih = setDate(dtpTarih.Value),
                        AlinanTutar = Convert.ToDecimal(txtAlinanTutar.Text),
                        ToplamTutar = Convert.ToDecimal(txtToplamTutar.Text),
                        Adet = Convert.ToInt32(txtAdet.Text),
                        Aciklama = txtAciklama.Text,
                        OdemeSekli = cbxOdemeSekli.Text

                    };
                    var result = _gelirService.Add(newGelir);
                    MessageBox.Show(result.Message);
                }
            }
        }

        private void txtAlinanTutar_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtAdet_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtAdet_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAdet.Text))
            {
                var malzeme = _malzemeService.GetByName(cbxMalzemeAdi.Text).Data;
                decimal toplamTutar = Convert.ToInt32(txtAdet.Text) * malzeme.BirimFiyat;
                txtToplamTutar.Text = toplamTutar.ToString();
            }
            else
            {
                txtToplamTutar.Text = "";
            }
        }

        private void cbxMalzemeAdi_TextChanged(object sender, EventArgs e)
        {
            lblBirim.Text = _malzemeService.GetByName(cbxMalzemeAdi.Text).Data.Birim;
        }

        private List<string> getOdemeSekliList()
        {
            var list = new List<string>();
            list.Add("NAKIT");
            list.Add("KREDI KARTI");
            return list;
        }


        private DateTime setDate(DateTime date)
        {
            return new DateTime(date.Year, date.Month, date.Day);
        }

        private void txtAdet_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdet.Text))
            {
                e.Cancel = true;
                txtAdet.Focus();
                validationError.SetError(txtAdet, "Adet Boş Bırakılamaz!");
            }
        }

        private void txtAlinanTutar_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAlinanTutar.Text))
            {
                e.Cancel = true;
                txtAlinanTutar.Focus();
                validationError.SetError(txtAlinanTutar, "Alınan Tutar Boş Bırakılamaz!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            GelirHub gelirHub = new GelirHub();
            gelirHub.Show();
            this.Hide();
        }
    }
}
