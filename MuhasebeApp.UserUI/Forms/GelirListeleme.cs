using Business.Abstract;
using Entity.Concrete;
using Entity.Dto;
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
    public partial class GelirListeleme : Form
    {
        public GelirListeleme()
        {
            InitializeComponent();
            _gelirService = InstanceFactory.GetInstance<IGelirService>();
            _malzemeService = InstanceFactory.GetInstance<IMalzemeService>();
        }
        private IGelirService _gelirService;
        private IMalzemeService _malzemeService;
        private void GelirListeleme_Load(object sender, EventArgs e)
        {
            cbxMalzemeAdi.DataSource = _malzemeService.GetAllMalzemeAdi().Data;
            cbxFMalzemeAdi.DataSource = _malzemeService.GetAllMalzemeAdi().Data;
            cbxFMalzemeAdi.SelectedIndex = -1;
            cbxOdemeSekli.DataSource = getOdemeSekliList();
            cbxFOdemeSekli.DataSource = getOdemeSekliList();
            cbxFOdemeSekli.SelectedIndex = -1;
            if (!string.IsNullOrEmpty(cbxMalzemeAdi.Text))
            {
                lblBirim.Text = _malzemeService.GetByName(cbxMalzemeAdi.Text).Data.Birim;
            }
            dtpFStartDate.Value = new DateTime(2000, 01, 01);
            dtpFEndDate.Value = new DateTime(2100, 12, 31);
            LoadGelir();
            dgwGelirListeleme.Width =
    dgwGelirListeleme.Columns.Cast<DataGridViewColumn>().Sum(x => x.Width)
    + (dgwGelirListeleme.RowHeadersVisible ? dgwGelirListeleme.RowHeadersWidth : 0) + 3;
        }

        private void LoadGelir()
        {
            var result = _gelirService.GetAll();
            if (result.Success)
            {
                dgwGelirListeleme.DataSource = result.Data;
                LoadField();
            }
        }

        private void dgwGelirListeleme_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadField();
        }



        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (ValidationRules())
            {
                validationError.Clear();
                var malzeme = _malzemeService.GetByName(cbxMalzemeAdi.Text);
                if (!malzeme.Success)
                {
                    MessageBox.Show(malzeme.Message, "Muhsabe App", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var id = Convert.ToInt32(dgwGelirListeleme.CurrentRow.Cells[0].Value.ToString());
                    if (id > 0)
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
                        DialogResult secenek = MessageBox.Show("Güncellemek istiyor musunuz?", "Muhasebe App", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (secenek == DialogResult.Yes)
                        {
                            var result = _gelirService.UpdateById(id, newGelir);
                            if (result.Success)
                            {
                                MessageBox.Show(result.Message, "Muhasebe App", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadGelir();
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
            if (!string.IsNullOrEmpty(txtToplamTutar.Text))
            {
                validationError.Clear();
                var id = Convert.ToInt32(dgwGelirListeleme.CurrentRow.Cells[0].Value.ToString());
                if (id > 0)
                {
                    DialogResult secenek = MessageBox.Show("Silmek istiyor musunuz?", "Muhasebe App", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (secenek == DialogResult.Yes)
                    {
                        var result = _gelirService.DeleteById(id);
                        if (result.Success)
                        {
                            MessageBox.Show(result.Message, "Muhasebe App", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadGelir();
                        }
                        else
                        {
                            MessageBox.Show(result.Message, "Muhasebe App", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            var gelirFilterDto = new GelirFilterDto
            {
                MalzemeAd = cbxFMalzemeAdi.Text,
                OdemeSekli = cbxFOdemeSekli.Text,
                StartDate = dtpFStartDate.Value,
                EndDate = dtpFEndDate.Value
            };

            var result = _gelirService.GetAllByFilter(gelirFilterDto);
            if (result.Success)
            {
                if (result.Data.Count > 0)
                {
                    dgwGelirListeleme.DataSource = result.Data;
                }
                else
                {
                    MessageBox.Show("Belirttiğiniz filtrelere uygun bir içerik bulunamadı");
                }
            }
        }

        private void btnFilterClear_Click(object sender, EventArgs e)
        {
            cbxFMalzemeAdi.SelectedIndex = -1;
            cbxFOdemeSekli.SelectedIndex = -1;
            dtpFStartDate.Value = new DateTime(2000, 01, 01);
            dtpFEndDate.Value = new DateTime(2100, 12, 31);
            LoadGelir();
        }

        private void cbxMalzemeAdi_TextChanged(object sender, EventArgs e)
        {
            lblBirim.Text = _malzemeService.GetByName(cbxMalzemeAdi.Text).Data.Birim;
        }

        private void txtAdet_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtAlinanTutar_KeyPress(object sender, KeyPressEventArgs e)
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
        private bool ValidationRules()
        {
            if (string.IsNullOrEmpty(txtAdet.Text))
            {
                txtAdet.Focus();
                validationError.SetError(txtAdet, "Adet Boş Bırakılamaz!");
                return false;
            }

            if (string.IsNullOrEmpty(txtAlinanTutar.Text))
            {
                txtAlinanTutar.Focus();
                validationError.SetError(txtAlinanTutar, "Alınan Tutar Boş Bırakılamaz!");
                return false;
            }

            return true;
        }

        private void txtAdet_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAdet.Text) && !string.IsNullOrEmpty(cbxMalzemeAdi.Text))
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

        private DateTime SetDgwCellDate(string dateCell)
        {
            var stringDateArr = dateCell.Split(' ');
            var dateArr = stringDateArr[0].Split('.');
            var date = new DateTime(Convert.ToInt32(dateArr[2]), Convert.ToInt32(dateArr[1]), Convert.ToInt32(dateArr[0]));
            return date;
        }
        private List<string> getOdemeSekliList()
        {
            var list = new List<string>();
            list.Add("NAKIT");
            list.Add("KREDI KARTI");
            return list;
        }

        private void LoadField()
        {
            if (dgwGelirListeleme.CurrentRow != null)
            {
                txtToplamTutar.Text = dgwGelirListeleme.CurrentRow.Cells[1].Value.ToString();
                txtAlinanTutar.Text = dgwGelirListeleme.CurrentRow.Cells[2].Value.ToString();
                dtpTarih.Value = SetDgwCellDate(dgwGelirListeleme.CurrentRow.Cells[3].Value.ToString());
                cbxMalzemeAdi.Text = dgwGelirListeleme.CurrentRow.Cells[4].Value.ToString();
                txtAdet.Text = dgwGelirListeleme.CurrentRow.Cells[5].Value.ToString();
                cbxOdemeSekli.Text = dgwGelirListeleme.CurrentRow.Cells[6].Value.ToString();
                txtAciklama.Text = dgwGelirListeleme.CurrentRow.Cells[7].Value.ToString();
            }
        }


        private DateTime setDate(DateTime date)
        {
            return new DateTime(date.Year, date.Month, date.Day);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            GelirHub gelirHub = new GelirHub();
            gelirHub.Show();
            this.Hide();
        }

      
    }
}
