using Business.Abstract;
using MuhasebeApp.Business.DependecyResolvers.Ninject;
using MuhasebeApp.Core.Utils.Methods;
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
    public partial class Istatistik : Form
    {
        public Istatistik()
        {
            InitializeComponent();
            _raporService = InstanceFactory.GetInstance<IRaporService>();
        }
        IRaporService _raporService;
        private void Istatistik_Load(object sender, EventArgs e)
        {
            CalculateAllGelirGider();
            cbxAy.DataSource = Aylar.getAllAyName();
            cbxAy.SelectedIndex = DateTime.Now.Month-1;
            txtYil.Text = DateTime.Now.Year.ToString();
            LoadChart();
        }
        
        private void CalculateAllGelirGider()
        {
            var result = _raporService.CalculateToplamGelirGider();
            if (result.Success)
            {
                lblToplamGelirMoney.Text = result.Data.ToplamGelir.ToString();
                lblToplamGiderMoney.Text = result.Data.ToplamGider.ToString();
                lblToplamKarMoney.Text = result.Data.ToplamKar.ToString();
                lblToplamZararMoney.Text = result.Data.ToplamZarar.ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomePage hmPage = new HomePage();
            hmPage.Show();
            this.Hide();
        }

        private void txtYil_KeyPress(object sender, KeyPressEventArgs e)
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

        private void bntHesapla_Click(object sender, EventArgs e)
        {
            int monthId = Aylar.getAyByAd(cbxAy.Text).Id;
            int year = Convert.ToInt32(txtYil.Text);
            var result = _raporService.CalculataToplamGelirGiderByMonthAndYear(monthId,year);
            if (result.Success)
            {
                lblAylikGelirMoney.Text = result.Data.ToplamGelir.ToString();
                lblAylikGiderMoney.Text = result.Data.ToplamGider.ToString();
                lblAylikKarMoney.Text = result.Data.ToplamKar.ToString();
                lblAylikZararMoney.Text = result.Data.ToplamZarar.ToString();
            }
        }

        private void LoadChart()
        {
            var result = _raporService.CalculateLastOneYearTotalGelirGider();
            if (result.Success)
            {
                var resultList = result.Data.OrderBy(a => a.AyId).ToList();
                foreach (var total in resultList)
                {
                    chartTotalByMonth.Series["Gelir"].Points.AddXY(total.AyAdi, total.ToplamGelir);
                    chartTotalByMonth.Series["Gider"].Points.AddY(total.ToplamGider);

                }
            }

            var malzemeResult = _raporService.CalculataTotalGelirByMalzemeName();
            if (malzemeResult.Success)
            {
                var resultList = malzemeResult.Data.OrderBy(m => m.Total);
                foreach (var malzeme in resultList)
                {
                    chartMalzemeByMonth.Series["AylikSatilanMalzemeler"].Points.AddXY(malzeme.MalzemeAdi, malzeme.Total);
                }
            }
        }

    }
}
