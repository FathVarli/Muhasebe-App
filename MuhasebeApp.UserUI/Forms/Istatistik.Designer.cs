
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
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbxTotal = new System.Windows.Forms.GroupBox();
            this.lblToplamKarMoney = new System.Windows.Forms.Label();
            this.lblKar = new System.Windows.Forms.Label();
            this.lblToplamGiderMoney = new System.Windows.Forms.Label();
            this.lblToplamGider = new System.Windows.Forms.Label();
            this.lblToplamGelirMoney = new System.Windows.Forms.Label();
            this.lblToplamGelir = new System.Windows.Forms.Label();
            this.gbxAylikGelirGider = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblAylikKarMoney = new System.Windows.Forms.Label();
            this.lblAylikKar = new System.Windows.Forms.Label();
            this.lblAylikGiderMoney = new System.Windows.Forms.Label();
            this.lblAylikGider = new System.Windows.Forms.Label();
            this.lblAylikGelirMoney = new System.Windows.Forms.Label();
            this.lblAylikGelir = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.gbxTotal.SuspendLayout();
            this.gbxAylikGelirGider.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(22, 317);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Gelir";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Gider";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(466, 309);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chartAylikGelirGider";
            title1.BackColor = System.Drawing.Color.White;
            title1.Name = "GelirGiderTitle";
            title1.Text = "Aylara Göre Son 1 Yıllık Gelir Gider";
            this.chart1.Titles.Add(title1);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(631, 317);
            this.chart2.Name = "chart2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "AylıkSatilanMalzemeler";
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(456, 309);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            title2.Name = "Title1";
            title2.Text = "Aylık Satılan Malzemeler";
            this.chart2.Titles.Add(title2);
            // 
            // gbxTotal
            // 
            this.gbxTotal.Controls.Add(this.lblToplamKarMoney);
            this.gbxTotal.Controls.Add(this.lblKar);
            this.gbxTotal.Controls.Add(this.lblToplamGiderMoney);
            this.gbxTotal.Controls.Add(this.lblToplamGider);
            this.gbxTotal.Controls.Add(this.lblToplamGelirMoney);
            this.gbxTotal.Controls.Add(this.lblToplamGelir);
            this.gbxTotal.Location = new System.Drawing.Point(22, 44);
            this.gbxTotal.Name = "gbxTotal";
            this.gbxTotal.Size = new System.Drawing.Size(456, 251);
            this.gbxTotal.TabIndex = 2;
            this.gbxTotal.TabStop = false;
            this.gbxTotal.Text = "Toplam Gelir Gider";
            // 
            // lblToplamKarMoney
            // 
            this.lblToplamKarMoney.AutoSize = true;
            this.lblToplamKarMoney.Location = new System.Drawing.Point(161, 144);
            this.lblToplamKarMoney.Name = "lblToplamKarMoney";
            this.lblToplamKarMoney.Size = new System.Drawing.Size(19, 13);
            this.lblToplamKarMoney.TabIndex = 5;
            this.lblToplamKarMoney.Text = "00";
            // 
            // lblKar
            // 
            this.lblKar.AutoSize = true;
            this.lblKar.Location = new System.Drawing.Point(56, 144);
            this.lblKar.Name = "lblKar";
            this.lblKar.Size = new System.Drawing.Size(61, 13);
            this.lblKar.TabIndex = 4;
            this.lblKar.Text = "Toplam Kar";
            // 
            // lblToplamGiderMoney
            // 
            this.lblToplamGiderMoney.AutoSize = true;
            this.lblToplamGiderMoney.Location = new System.Drawing.Point(161, 103);
            this.lblToplamGiderMoney.Name = "lblToplamGiderMoney";
            this.lblToplamGiderMoney.Size = new System.Drawing.Size(19, 13);
            this.lblToplamGiderMoney.TabIndex = 3;
            this.lblToplamGiderMoney.Text = "00";
            // 
            // lblToplamGider
            // 
            this.lblToplamGider.AutoSize = true;
            this.lblToplamGider.Location = new System.Drawing.Point(56, 103);
            this.lblToplamGider.Name = "lblToplamGider";
            this.lblToplamGider.Size = new System.Drawing.Size(70, 13);
            this.lblToplamGider.TabIndex = 2;
            this.lblToplamGider.Text = "Toplam Gider";
            // 
            // lblToplamGelirMoney
            // 
            this.lblToplamGelirMoney.AutoSize = true;
            this.lblToplamGelirMoney.Location = new System.Drawing.Point(161, 58);
            this.lblToplamGelirMoney.Name = "lblToplamGelirMoney";
            this.lblToplamGelirMoney.Size = new System.Drawing.Size(19, 13);
            this.lblToplamGelirMoney.TabIndex = 1;
            this.lblToplamGelirMoney.Text = "00";
            // 
            // lblToplamGelir
            // 
            this.lblToplamGelir.AutoSize = true;
            this.lblToplamGelir.Location = new System.Drawing.Point(56, 58);
            this.lblToplamGelir.Name = "lblToplamGelir";
            this.lblToplamGelir.Size = new System.Drawing.Size(66, 13);
            this.lblToplamGelir.TabIndex = 0;
            this.lblToplamGelir.Text = "Toplam Gelir";
            // 
            // gbxAylikGelirGider
            // 
            this.gbxAylikGelirGider.Controls.Add(this.textBox1);
            this.gbxAylikGelirGider.Controls.Add(this.label2);
            this.gbxAylikGelirGider.Controls.Add(this.label1);
            this.gbxAylikGelirGider.Controls.Add(this.comboBox1);
            this.gbxAylikGelirGider.Controls.Add(this.lblAylikKarMoney);
            this.gbxAylikGelirGider.Controls.Add(this.lblAylikKar);
            this.gbxAylikGelirGider.Controls.Add(this.lblAylikGiderMoney);
            this.gbxAylikGelirGider.Controls.Add(this.lblAylikGider);
            this.gbxAylikGelirGider.Controls.Add(this.lblAylikGelirMoney);
            this.gbxAylikGelirGider.Controls.Add(this.lblAylikGelir);
            this.gbxAylikGelirGider.Location = new System.Drawing.Point(631, 44);
            this.gbxAylikGelirGider.Name = "gbxAylikGelirGider";
            this.gbxAylikGelirGider.Size = new System.Drawing.Size(456, 251);
            this.gbxAylikGelirGider.TabIndex = 3;
            this.gbxAylikGelirGider.TabStop = false;
            this.gbxAylikGelirGider.Text = "Aylık Gelir Gider";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(344, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(65, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Yıl Giriniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ay Seçiniz";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(242, 100);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(96, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // lblAylikKarMoney
            // 
            this.lblAylikKarMoney.AutoSize = true;
            this.lblAylikKarMoney.Location = new System.Drawing.Point(161, 144);
            this.lblAylikKarMoney.Name = "lblAylikKarMoney";
            this.lblAylikKarMoney.Size = new System.Drawing.Size(19, 13);
            this.lblAylikKarMoney.TabIndex = 5;
            this.lblAylikKarMoney.Text = "00";
            // 
            // lblAylikKar
            // 
            this.lblAylikKar.AutoSize = true;
            this.lblAylikKar.Location = new System.Drawing.Point(56, 144);
            this.lblAylikKar.Name = "lblAylikKar";
            this.lblAylikKar.Size = new System.Drawing.Size(61, 13);
            this.lblAylikKar.TabIndex = 4;
            this.lblAylikKar.Text = "Toplam Kar";
            // 
            // lblAylikGiderMoney
            // 
            this.lblAylikGiderMoney.AutoSize = true;
            this.lblAylikGiderMoney.Location = new System.Drawing.Point(161, 103);
            this.lblAylikGiderMoney.Name = "lblAylikGiderMoney";
            this.lblAylikGiderMoney.Size = new System.Drawing.Size(19, 13);
            this.lblAylikGiderMoney.TabIndex = 3;
            this.lblAylikGiderMoney.Text = "00";
            // 
            // lblAylikGider
            // 
            this.lblAylikGider.AutoSize = true;
            this.lblAylikGider.Location = new System.Drawing.Point(56, 103);
            this.lblAylikGider.Name = "lblAylikGider";
            this.lblAylikGider.Size = new System.Drawing.Size(70, 13);
            this.lblAylikGider.TabIndex = 2;
            this.lblAylikGider.Text = "Toplam Gider";
            // 
            // lblAylikGelirMoney
            // 
            this.lblAylikGelirMoney.AutoSize = true;
            this.lblAylikGelirMoney.Location = new System.Drawing.Point(161, 58);
            this.lblAylikGelirMoney.Name = "lblAylikGelirMoney";
            this.lblAylikGelirMoney.Size = new System.Drawing.Size(19, 13);
            this.lblAylikGelirMoney.TabIndex = 1;
            this.lblAylikGelirMoney.Text = "00";
            // 
            // lblAylikGelir
            // 
            this.lblAylikGelir.AutoSize = true;
            this.lblAylikGelir.Location = new System.Drawing.Point(56, 58);
            this.lblAylikGelir.Name = "lblAylikGelir";
            this.lblAylikGelir.Size = new System.Drawing.Size(66, 13);
            this.lblAylikGelir.TabIndex = 0;
            this.lblAylikGelir.Text = "Toplam Gelir";
            // 
            // Istatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 638);
            this.Controls.Add(this.gbxAylikGelirGider);
            this.Controls.Add(this.gbxTotal);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Name = "Istatistik";
            this.Text = "İstatistik";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.gbxTotal.ResumeLayout(false);
            this.gbxTotal.PerformLayout();
            this.gbxAylikGelirGider.ResumeLayout(false);
            this.gbxAylikGelirGider.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.GroupBox gbxTotal;
        private System.Windows.Forms.Label lblToplamKarMoney;
        private System.Windows.Forms.Label lblKar;
        private System.Windows.Forms.Label lblToplamGiderMoney;
        private System.Windows.Forms.Label lblToplamGider;
        private System.Windows.Forms.Label lblToplamGelirMoney;
        private System.Windows.Forms.Label lblToplamGelir;
        private System.Windows.Forms.GroupBox gbxAylikGelirGider;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblAylikKarMoney;
        private System.Windows.Forms.Label lblAylikKar;
        private System.Windows.Forms.Label lblAylikGiderMoney;
        private System.Windows.Forms.Label lblAylikGider;
        private System.Windows.Forms.Label lblAylikGelirMoney;
        private System.Windows.Forms.Label lblAylikGelir;
    }
}