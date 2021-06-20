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
    public partial class MalzemeIslemleri : Form
    {
        public MalzemeIslemleri()
        {
            InitializeComponent();
            _malzemeService = InstanceFactory.GetInstance<IMalzemeService>();
        }

        private IMalzemeService _malzemeService;

        private void MalzemeIslemleri_Load(object sender, EventArgs e)
        {
            LoadMalzemeList();
            dgwMalzeme.Width = dgwMalzeme.Columns.Cast<DataGridViewColumn>().Sum(x => x.Width) + (dgwMalzeme.RowHeadersVisible ? dgwMalzeme.RowHeadersWidth : 0) + 3;
            LoadField();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (ValidationRules())
            {
                validationError.Clear();

                var malzeme = new Malzeme
                {
                    Ad = txtAd.Text.ToUpper(),
                    Birim = txtBirim.Text.ToUpper(),
                    BirimFiyat = Convert.ToDecimal(txtBirimFiyati.Text)
                };
                var result = _malzemeService.Add(malzeme);
                if (result.Success)
                {
                    MessageBox.Show(result.Message, "Muhasebe App", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadMalzemeList();
                    ClearField();
                }
                else
                {
                    MessageBox.Show(result.Message, "Muhasebe App", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (ValidationRules())
            {
                validationError.Clear();
                var malzeme = new Malzeme
                {
                    Ad = txtAd.Text.ToUpper(),
                    Birim = txtBirim.Text.ToUpper(),
                    BirimFiyat = Convert.ToDecimal(txtBirimFiyati.Text)
                };
                if (dgwMalzeme.CurrentRow != null)
                {
                    int id = Convert.ToInt32(dgwMalzeme.CurrentRow.Cells[0].Value);
                    if (id > 0)
                    {
                        DialogResult secenek = MessageBox.Show("Güncellemek istiyor musunuz?", "Muhasebe App", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (secenek == DialogResult.Yes)
                        {
                            var result = _malzemeService.UpdateById(id, malzeme);
                            if (result.Success)
                            {
                                MessageBox.Show(result.Message, "Muhasebe App", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadMalzemeList();
                                ClearField();
                            }
                            else
                            {
                                MessageBox.Show(result.Message, "Muhasebe App", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }


            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtAd.Text))
            {
                DialogResult secenek = MessageBox.Show("Silmek istiyor musunuz?", "Muhasebe App", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (secenek == DialogResult.Yes)
                {
                    _malzemeService.DeleteById(Convert.ToInt32(dgwMalzeme.CurrentRow.Cells[0].Value));
                    MessageBox.Show("Başarıyla Silinmiştir!", "Muhasebe App", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearField();
                    LoadMalzemeList();

                }
            }
            else
            {
                MessageBox.Show("Silmek istediğiniz satırı seçiniz.", "Muhasebe App", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void txtAdArama_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdArama.Text))
            {
                LoadMalzemeList();
            }
        }

        private void dgwMalzeme_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwMalzeme.CurrentCell != null)
            {
                LoadField();
            }
        }

        private void LoadField()
        {
            if (dgwMalzeme.CurrentRow != null)
            {
                txtAd.Text = dgwMalzeme.CurrentRow.Cells[1].Value.ToString();
                txtBirim.Text = dgwMalzeme.CurrentRow.Cells[2].Value.ToString();
                txtBirimFiyati.Text = dgwMalzeme.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAdArama.Text))
            {
                dgwMalzeme.DataSource = _malzemeService.GetAllListByMalzemeAdi(txtAdArama.Text.ToUpper()).Data;
            }
            else
            {
                LoadMalzemeList();

            }
        }

        private void LoadMalzemeList()
        {
            var result = _malzemeService.GetAll();
            if (result.Success)
            {
                dgwMalzeme.DataSource = result.Data.OrderBy(m => m.Id).ToList();
                LoadField();
            }
        }

        private bool ValidationRules()
        {
            if (string.IsNullOrEmpty(txtAd.Text))
            {
                txtAd.Focus();
                validationError.SetError(txtAd, "Malzeme Adı Boş Bırakılamaz!");
                return false;
            }

            if (string.IsNullOrEmpty(txtBirim.Text))
            {
                txtBirim.Focus();
                validationError.SetError(txtBirim, "Malzeme Birimi Boş Bırakılamaz!");
                return false;
            }

            if (string.IsNullOrEmpty(txtBirimFiyati.Text))
            {
                txtBirimFiyati.Focus();
                validationError.SetError(txtBirimFiyati, "Malzeme Birim Fiyatı Boş Bırakılamaz!");
                return false;
            }

            return true;
        }

        private void txtBirimFiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ClearField()
        {
            txtAd.Clear();
            txtBirim.Clear();
            txtBirimFiyati.Clear();
        }

        private void bntBack_Click(object sender, EventArgs e)
        {
            HomePage hmPage = new HomePage();
            hmPage.Show();
            this.Hide();
        }

    }
}
