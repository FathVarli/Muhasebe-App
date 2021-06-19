
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
            this.lblToplamZararMoney = new System.Windows.Forms.Label();
            this.lblToplamZarar = new System.Windows.Forms.Label();
            this.lblToplamKarMoney = new System.Windows.Forms.Label();
            this.lblKar = new System.Windows.Forms.Label();
            this.lblToplamGiderMoney = new System.Windows.Forms.Label();
            this.lblToplamGider = new System.Windows.Forms.Label();
            this.lblToplamGelirMoney = new System.Windows.Forms.Label();
            this.lblToplamGelir = new System.Windows.Forms.Label();
            this.gbxAylikGelirGider = new System.Windows.Forms.GroupBox();
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
            this.chart1.Location = new System.Drawing.Point(50, 321);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Gelir";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Gider";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(510, 310);
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
            this.chart2.Location = new System.Drawing.Point(640, 321);
            this.chart2.Name = "chart2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "AylıkSatilanMalzemeler";
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(510, 310);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            title2.Name = "Title1";
            title2.Text = "Aylık Satılan Malzemeler";
            this.chart2.Titles.Add(title2);
            // 
            // gbxTotal
            // 
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
            this.gbxAylikGelirGider.Location = new System.Drawing.Point(680, 30);
            this.gbxAylikGelirGider.Name = "gbxAylikGelirGider";
            this.gbxAylikGelirGider.Size = new System.Drawing.Size(470, 270);
            this.gbxAylikGelirGider.TabIndex = 3;
            this.gbxAylikGelirGider.TabStop = false;
            this.gbxAylikGelirGider.Text = "Aylık Gelir Gider";
            // 
            // bntHesapla
            // 
            this.bntHesapla.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bntHesapla.Location = new System.Drawing.Point(309, 167);
            this.bntHesapla.Name = "bntHesapla";
            this.bntHesapla.Size = new System.Drawing.Size(100, 30);
            this.bntHesapla.TabIndex = 10;
            this.bntHesapla.Text = "Hesapla";
            this.bntHesapla.UseVisualStyleBackColor = true;
            // 
            // txtYil
            // 
            this.txtYil.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYil.Location = new System.Drawing.Point(344, 101);
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
            this.label2.Location = new System.Drawing.Point(341, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Yıl Giriniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(239, 78);
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
            this.cbxAy.Location = new System.Drawing.Point(242, 100);
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
            this.btnBack.Location = new System.Drawing.Point(12, 624);
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
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbxAylikGelirGider);
            this.Controls.Add(this.gbxTotal);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Istatistik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İstatistik";
            this.Load += new System.EventHandler(this.Istatistik_Load);
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
    }
}