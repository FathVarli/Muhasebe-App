
namespace MuhasebeApp.UserUI.Forms
{
    partial class Istatistik
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartTotalByMonth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartMalzemeByMonth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbxTotal = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblToplamZararMoney = new System.Windows.Forms.Label();
            this.lblToplamZarar = new System.Windows.Forms.Label();
            this.lblToplamKarMoney = new System.Windows.Forms.Label();
            this.lblKar = new System.Windows.Forms.Label();
            this.lblToplamGiderMoney = new System.Windows.Forms.Label();
            this.lblToplamGider = new System.Windows.Forms.Label();
            this.lblToplamGelirMoney = new System.Windows.Forms.Label();
            this.lblToplamGelir = new System.Windows.Forms.Label();
            this.gbxAylikGelirGider = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAylikZararMoney = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bntHesapla = new System.Windows.Forms.Button();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxAy = new System.Windows.Forms.ComboBox();
            this.lblAylikKarMoney = new System.Windows.Forms.Label();
            this.lblAylikKar = new System.Windows.Forms.Label();
            this.lblAylikGiderMoney = new System.Windows.Forms.Label();
            this.lblAylikGider = new System.Windows.Forms.Label();
            this.lblAylikGelirMoney = new System.Windows.Forms.Label();
            this.lblAylikGelir = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalByMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMalzemeByMonth)).BeginInit();
            this.gbxTotal.SuspendLayout();
            this.gbxAylikGelirGider.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartTotalByMonth
            // 
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Times New Roman", 10F);
            chartArea1.AxisX.LabelStyle.Interval = 0D;
            chartArea1.AxisX.LabelStyle.IntervalOffset = 0D;
            chartArea1.AxisX.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.Name = "ChartArea1";
            this.chartTotalByMonth.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTotalByMonth.Legends.Add(legend1);
            this.chartTotalByMonth.Location = new System.Drawing.Point(50, 399);
            this.chartTotalByMonth.Name = "chartTotalByMonth";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Gelir";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Gider";
            this.chartTotalByMonth.Series.Add(series1);
            this.chartTotalByMonth.Series.Add(series2);
            this.chartTotalByMonth.Size = new System.Drawing.Size(676, 310);
            this.chartTotalByMonth.TabIndex = 0;
            this.chartTotalByMonth.Text = "chartAylikGelirGider";
            title1.BackColor = System.Drawing.Color.White;
            title1.Name = "GelirGiderTitle";
            title1.Text = "Aylara Göre Son 1 Yıllık Gelir Gider";
            this.chartTotalByMonth.Titles.Add(title1);
            // 
            // chartMalzemeByMonth
            // 
            chartArea2.Name = "ChartArea1";
            this.chartMalzemeByMonth.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartMalzemeByMonth.Legends.Add(legend2);
            this.chartMalzemeByMonth.Location = new System.Drawing.Point(830, 399);
            this.chartMalzemeByMonth.Name = "chartMalzemeByMonth";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "AylikSatilanMalzemeler";
            this.chartMalzemeByMonth.Series.Add(series3);
            this.chartMalzemeByMonth.Size = new System.Drawing.Size(510, 310);
            this.chartMalzemeByMonth.TabIndex = 1;
            this.chartMalzemeByMonth.Text = "chart2";
            // 
            // gbxTotal
            // 
            this.gbxTotal.Controls.Add(this.label7);
            this.gbxTotal.Controls.Add(this.label6);
            this.gbxTotal.Controls.Add(this.label5);
            this.gbxTotal.Controls.Add(this.label3);
            this.gbxTotal.Controls.Add(this.lblToplamZararMoney);
            this.gbxTotal.Controls.Add(this.lblToplamZarar);
            this.gbxTotal.Controls.Add(this.lblToplamKarMoney);
            this.gbxTotal.Controls.Add(this.lblKar);
            this.gbxTotal.Controls.Add(this.lblToplamGiderMoney);
            this.gbxTotal.Controls.Add(this.lblToplamGider);
            this.gbxTotal.Controls.Add(this.lblToplamGelirMoney);
            this.gbxTotal.Controls.Add(this.lblToplamGelir);
            this.gbxTotal.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxTotal.Location = new System.Drawing.Point(50, 30);
            this.gbxTotal.Name = "gbxTotal";
            this.gbxTotal.Size = new System.Drawing.Size(470, 270);
            this.gbxTotal.TabIndex = 2;
            this.gbxTotal.TabStop = false;
            this.gbxTotal.Text = "Toplam Gelir Gider";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(197, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "TL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(197, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "TL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(197, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "TL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(197, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "TL";
            // 
            // lblToplamZararMoney
            // 
            this.lblToplamZararMoney.AutoSize = true;
            this.lblToplamZararMoney.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamZararMoney.Location = new System.Drawing.Point(161, 182);
            this.lblToplamZararMoney.Name = "lblToplamZararMoney";
            this.lblToplamZararMoney.Size = new System.Drawing.Size(19, 15);
            this.lblToplamZararMoney.TabIndex = 7;
            this.lblToplamZararMoney.Text = "00";
            // 
            // lblToplamZarar
            // 
            this.lblToplamZarar.AutoSize = true;
            this.lblToplamZarar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamZarar.Location = new System.Drawing.Point(56, 182);
            this.lblToplamZarar.Name = "lblToplamZarar";
            this.lblToplamZarar.Size = new System.Drawing.Size(95, 17);
            this.lblToplamZarar.TabIndex = 6;
            this.lblToplamZarar.Text = "Toplam Zarar";
            // 
            // lblToplamKarMoney
            // 
            this.lblToplamKarMoney.AutoSize = true;
            this.lblToplamKarMoney.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamKarMoney.Location = new System.Drawing.Point(161, 144);
            this.lblToplamKarMoney.Name = "lblToplamKarMoney";
            this.lblToplamKarMoney.Size = new System.Drawing.Size(19, 15);
            this.lblToplamKarMoney.TabIndex = 5;
            this.lblToplamKarMoney.Text = "00";
            // 
            // lblKar
            // 
            this.lblKar.AutoSize = true;
            this.lblKar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKar.Location = new System.Drawing.Point(56, 144);
            this.lblKar.Name = "lblKar";
            this.lblKar.Size = new System.Drawing.Size(85, 17);
            this.lblKar.TabIndex = 4;
            this.lblKar.Text = "Toplam Kar";
            // 
            // lblToplamGiderMoney
            // 
            this.lblToplamGiderMoney.AutoSize = true;
            this.lblToplamGiderMoney.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamGiderMoney.Location = new System.Drawing.Point(161, 103);
            this.lblToplamGiderMoney.Name = "lblToplamGiderMoney";
            this.lblToplamGiderMoney.Size = new System.Drawing.Size(19, 15);
            this.lblToplamGiderMoney.TabIndex = 3;
            this.lblToplamGiderMoney.Text = "00";
            // 
            // lblToplamGider
            // 
            this.lblToplamGider.AutoSize = true;
            this.lblToplamGider.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamGider.Location = new System.Drawing.Point(56, 103);
            this.lblToplamGider.Name = "lblToplamGider";
            this.lblToplamGider.Size = new System.Drawing.Size(97, 17);
            this.lblToplamGider.TabIndex = 2;
            this.lblToplamGider.Text = "Toplam Gider";
            // 
            // lblToplamGelirMoney
            // 
            this.lblToplamGelirMoney.AutoSize = true;
            this.lblToplamGelirMoney.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamGelirMoney.Location = new System.Drawing.Point(161, 58);
            this.lblToplamGelirMoney.Name = "lblToplamGelirMoney";
            this.lblToplamGelirMoney.Size = new System.Drawing.Size(19, 15);
            this.lblToplamGelirMoney.TabIndex = 1;
            this.lblToplamGelirMoney.Text = "00";
            // 
            // lblToplamGelir
            // 
            this.lblToplamGelir.AutoSize = true;
            this.lblToplamGelir.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamGelir.Location = new System.Drawing.Point(56, 58);
            this.lblToplamGelir.Name = "lblToplamGelir";
            this.lblToplamGelir.Size = new System.Drawing.Size(93, 17);
            this.lblToplamGelir.TabIndex = 0;
            this.lblToplamGelir.Text = "Toplam Gelir";
            // 
            // gbxAylikGelirGider
            // 
            this.gbxAylikGelirGider.Controls.Add(this.label11);
            this.gbxAylikGelirGider.Controls.Add(this.label10);
            this.gbxAylikGelirGider.Controls.Add(this.label9);
            this.gbxAylikGelirGider.Controls.Add(this.label8);
            this.gbxAylikGelirGider.Controls.Add(this.lblAylikZararMoney);
            this.gbxAylikGelirGider.Controls.Add(this.label4);
            this.gbxAylikGelirGider.Controls.Add(this.bntHesapla);
            this.gbxAylikGelirGider.Controls.Add(this.txtYil);
            this.gbxAylikGelirGider.Controls.Add(this.label2);
            this.gbxAylikGelirGider.Controls.Add(this.label1);
            this.gbxAylikGelirGider.Controls.Add(this.cbxAy);
            this.gbxAylikGelirGider.Controls.Add(this.lblAylikKarMoney);
            this.gbxAylikGelirGider.Controls.Add(this.lblAylikKar);
            this.gbxAylikGelirGider.Controls.Add(this.lblAylikGiderMoney);
            this.gbxAylikGelirGider.Controls.Add(this.lblAylikGider);
            this.gbxAylikGelirGider.Controls.Add(this.lblAylikGelirMoney);
            this.gbxAylikGelirGider.Controls.Add(this.lblAylikGelir);
            this.gbxAylikGelirGider.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxAylikGelirGider.Location = new System.Drawing.Point(870, 30);
            this.gbxAylikGelirGider.Name = "gbxAylikGelirGider";
            this.gbxAylikGelirGider.Size = new System.Drawing.Size(470, 270);
            this.gbxAylikGelirGider.TabIndex = 3;
            this.gbxAylikGelirGider.TabStop = false;
            this.gbxAylikGelirGider.Text = "Aylık Gelir Gider";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(201, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "TL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(201, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "TL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(201, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "TL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(201, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "TL";
            // 
            // lblAylikZararMoney
            // 
            this.lblAylikZararMoney.AutoSize = true;
            this.lblAylikZararMoney.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAylikZararMoney.Location = new System.Drawing.Point(161, 182);
            this.lblAylikZararMoney.Name = "lblAylikZararMoney";
            this.lblAylikZararMoney.Size = new System.Drawing.Size(19, 15);
            this.lblAylikZararMoney.TabIndex = 12;
            this.lblAylikZararMoney.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(56, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Toplam Zarar";
            // 
            // bntHesapla
            // 
            this.bntHesapla.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bntHesapla.Location = new System.Drawing.Point(340, 167);
            this.bntHesapla.Name = "bntHesapla";
            this.bntHesapla.Size = new System.Drawing.Size(100, 30);
            this.bntHesapla.TabIndex = 10;
            this.bntHesapla.Text = "Hesapla";
            this.bntHesapla.UseVisualStyleBackColor = true;
            this.bntHesapla.Click += new System.EventHandler(this.bntHesapla_Click);
            // 
            // txtYil
            // 
            this.txtYil.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYil.Location = new System.Drawing.Point(375, 101);
            this.txtYil.MaxLength = 4;
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(65, 22);
            this.txtYil.TabIndex = 9;
            this.txtYil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYil_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(372, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Yıl Giriniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(270, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ay Seçiniz";
            // 
            // cbxAy
            // 
            this.cbxAy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAy.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxAy.FormattingEnabled = true;
            this.cbxAy.Location = new System.Drawing.Point(273, 100);
            this.cbxAy.Name = "cbxAy";
            this.cbxAy.Size = new System.Drawing.Size(96, 23);
            this.cbxAy.TabIndex = 6;
            // 
            // lblAylikKarMoney
            // 
            this.lblAylikKarMoney.AutoSize = true;
            this.lblAylikKarMoney.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAylikKarMoney.Location = new System.Drawing.Point(161, 144);
            this.lblAylikKarMoney.Name = "lblAylikKarMoney";
            this.lblAylikKarMoney.Size = new System.Drawing.Size(19, 15);
            this.lblAylikKarMoney.TabIndex = 5;
            this.lblAylikKarMoney.Text = "00";
            // 
            // lblAylikKar
            // 
            this.lblAylikKar.AutoSize = true;
            this.lblAylikKar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAylikKar.Location = new System.Drawing.Point(56, 144);
            this.lblAylikKar.Name = "lblAylikKar";
            this.lblAylikKar.Size = new System.Drawing.Size(85, 17);
            this.lblAylikKar.TabIndex = 4;
            this.lblAylikKar.Text = "Toplam Kar";
            // 
            // lblAylikGiderMoney
            // 
            this.lblAylikGiderMoney.AutoSize = true;
            this.lblAylikGiderMoney.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAylikGiderMoney.Location = new System.Drawing.Point(161, 103);
            this.lblAylikGiderMoney.Name = "lblAylikGiderMoney";
            this.lblAylikGiderMoney.Size = new System.Drawing.Size(19, 15);
            this.lblAylikGiderMoney.TabIndex = 3;
            this.lblAylikGiderMoney.Text = "00";
            // 
            // lblAylikGider
            // 
            this.lblAylikGider.AutoSize = true;
            this.lblAylikGider.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAylikGider.Location = new System.Drawing.Point(56, 103);
            this.lblAylikGider.Name = "lblAylikGider";
            this.lblAylikGider.Size = new System.Drawing.Size(97, 17);
            this.lblAylikGider.TabIndex = 2;
            this.lblAylikGider.Text = "Toplam Gider";
            // 
            // lblAylikGelirMoney
            // 
            this.lblAylikGelirMoney.AutoSize = true;
            this.lblAylikGelirMoney.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAylikGelirMoney.Location = new System.Drawing.Point(161, 58);
            this.lblAylikGelirMoney.Name = "lblAylikGelirMoney";
            this.lblAylikGelirMoney.Size = new System.Drawing.Size(19, 15);
            this.lblAylikGelirMoney.TabIndex = 1;
            this.lblAylikGelirMoney.Text = "00";
            // 
            // lblAylikGelir
            // 
            this.lblAylikGelir.AutoSize = true;
            this.lblAylikGelir.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAylikGelir.Location = new System.Drawing.Point(56, 58);
            this.lblAylikGelir.Name = "lblAylikGelir";
            this.lblAylikGelir.Size = new System.Drawing.Size(93, 17);
            this.lblAylikGelir.TabIndex = 0;
            this.lblAylikGelir.Text = "Toplam Gelir";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.Location = new System.Drawing.Point(12, 740);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 25);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Geri Dön";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Istatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1366, 777);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbxAylikGelirGider);
            this.Controls.Add(this.gbxTotal);
            this.Controls.Add(this.chartMalzemeByMonth);
            this.Controls.Add(this.chartTotalByMonth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Istatistik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İstatistik";
            this.Load += new System.EventHandler(this.Istatistik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalByMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMalzemeByMonth)).EndInit();
            this.gbxTotal.ResumeLayout(false);
            this.gbxTotal.PerformLayout();
            this.gbxAylikGelirGider.ResumeLayout(false);
            this.gbxAylikGelirGider.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTotalByMonth;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMalzemeByMonth;
        private System.Windows.Forms.GroupBox gbxTotal;
        private System.Windows.Forms.Label lblToplamKarMoney;
        private System.Windows.Forms.Label lblKar;
        private System.Windows.Forms.Label lblToplamGiderMoney;
        private System.Windows.Forms.Label lblToplamGider;
        private System.Windows.Forms.Label lblToplamGelirMoney;
        private System.Windows.Forms.Label lblToplamGelir;
        private System.Windows.Forms.GroupBox gbxAylikGelirGider;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxAy;
        private System.Windows.Forms.Label lblAylikKarMoney;
        private System.Windows.Forms.Label lblAylikKar;
        private System.Windows.Forms.Label lblAylikGiderMoney;
        private System.Windows.Forms.Label lblAylikGider;
        private System.Windows.Forms.Label lblAylikGelirMoney;
        private System.Windows.Forms.Label lblAylikGelir;
        private System.Windows.Forms.Button bntHesapla;
        private System.Windows.Forms.Label lblToplamZararMoney;
        private System.Windows.Forms.Label lblToplamZarar;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblAylikZararMoney;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}