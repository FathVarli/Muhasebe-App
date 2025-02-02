﻿using Business.Abstract;
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
    public partial class GiderListeleme : Form
    {
        public GiderListeleme()
        {
            InitializeComponent();
            _giderService = InstanceFactory.GetInstance<IGiderService>();
        }
        private IGiderService _giderService;
        private void GiderListeleme_Load(object sender, EventArgs e)
        {
            dtpFStartDate.Value = new DateTime(2000, 01, 01);
            dtpFEndDate.Value = new DateTime(2100, 12, 31);
            LoadGider();
            dgwGiderListeleme.Width =
    dgwGiderListeleme.Columns.Cast<DataGridViewColumn>().Sum(x => x.Width)
    + (dgwGiderListeleme.RowHeadersVisible ? dgwGiderListeleme.RowHeadersWidth : 0) + 3;
        }

        void LoadGider()
        {
            var result = _giderService.GetAll();
            if (result.Success)
            {
                dgwGiderListeleme.DataSource = result.Data;
                LoadField();
            }
        }

        private void dgwGiderListeleme_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadField();
        }

        private void LoadField()
        {
            if (dgwGiderListeleme.CurrentRow != null)
            {
                txtIcerik.Text = dgwGiderListeleme.CurrentRow.Cells[1].Value.ToString();
                txtToplamTutar.Text = dgwGiderListeleme.CurrentRow.Cells[2].Value.ToString();
                dtpTarih.Value = SetDgwCellDate(dgwGiderListeleme.CurrentRow.Cells[3].Value.ToString());
                txtAciklama.Text = dgwGiderListeleme.CurrentRow.Cells[4].Value.ToString();
            }
        }


        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (ValidationRules())
            {
                validationError.Clear();
                if (dgwGiderListeleme.CurrentRow != null)
                {
                    var id = Convert.ToInt32(dgwGiderListeleme.CurrentRow.Cells[0].Value.ToString());
                    if (id > 0)
                    {
                        var newGider = new Gider
                        {
                            Icerik = txtIcerik.Text,
                            ToplamTutar = Convert.ToDecimal(txtToplamTutar.Text),
                            Tarih = setDate(dtpTarih.Value),
                            Aciklama = txtAciklama.Text
                        };
                        DialogResult secenek = MessageBox.Show("Güncellemek istiyor musunuz?", "Muhasebe App", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (secenek == DialogResult.Yes)
                        {
                            var result = _giderService.UpdateById(id, newGider);
                            if (result.Success)
                            {
                                MessageBox.Show(result.Message, "Muhasebe App", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadGider();
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
            if (!string.IsNullOrEmpty(txtIcerik.Text))
            {
                validationError.Clear();
                if (dgwGiderListeleme.CurrentRow != null)
                {
                    var id = Convert.ToInt32(dgwGiderListeleme.CurrentRow.Cells[0].Value.ToString());
                    if (id > 0)
                    {
                        DialogResult secenek = MessageBox.Show("Silmek istiyor musunuz?", "Muhasebe App", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (secenek == DialogResult.Yes)
                        {
                            var result = _giderService.DeleteById(id);
                            if (result.Success)
                            {
                                MessageBox.Show(result.Message, "Muhasebe App", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadGider();
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
        private void btnAra_Click(object sender, EventArgs e)
        {
            var giderFilterDto = new GiderFilterDto
            {
                İcerik = txtFIcerik.Text,
                StartDate = dtpFStartDate.Value,
                EndDate = dtpFEndDate.Value
            };
            var result = _giderService.GetAllByFilter(giderFilterDto);
            if (result.Success)
            {
                if (result.Data.Count > 0)
                {
                    dgwGiderListeleme.DataSource = result.Data;
                }
                else
                {
                    MessageBox.Show("Belirttiğiniz filtrelere uygun bir içerik bulunamadı", "Muhasebe App", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btnFilterClear_Click(object sender, EventArgs e)
        {
            dtpFStartDate.Value = new DateTime(2000, 01, 01);
            dtpFEndDate.Value = new DateTime(2100, 12, 31);
            LoadGider();
        }

        private DateTime setDate(DateTime date)
        {
            return new DateTime(date.Year, date.Month, date.Day);
        }
        private DateTime SetDgwCellDate(string dateCell)
        {
            var stringDateArr = dateCell.Split(' ');
            var dateArr = stringDateArr[0].Split('.');
            var date = new DateTime(Convert.ToInt32(dateArr[2]), Convert.ToInt32(dateArr[1]), Convert.ToInt32(dateArr[0]));
            return date;
        }

        public bool ValidationRules()
        {
            if (string.IsNullOrEmpty(txtToplamTutar.Text))
            {
                txtIcerik.Focus();
                validationError.SetError(txtToplamTutar, "Toplam Tutar Alanı Boş Bırakılamaz!");
                return false;
            }
            if (string.IsNullOrEmpty(txtIcerik.Text))
            {
                txtIcerik.Focus();
                validationError.SetError(txtIcerik, "İçerik Alanı Boş Bırakılamaz!");
                return false;
            }
            return true;
        }

        private void txtToplamTutar_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            GiderHub giderHub = new GiderHub();
            giderHub.Show();
            this.Hide();
        }
    }
}
