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
    }
}
