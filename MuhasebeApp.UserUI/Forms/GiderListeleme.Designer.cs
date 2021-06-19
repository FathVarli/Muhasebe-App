
namespace MuhasebeApp.UserUI.Forms
{
    partial class GiderListeleme
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
            this.components = new System.ComponentModel.Container();
            this.dgwGiderListeleme = new System.Windows.Forms.DataGridView();
            this.gbxGiderEkleme = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.txtIcerik = new System.Windows.Forms.TextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.lblIcerik = new System.Windows.Forms.Label();
            this.gbxFiltreleme = new System.Windows.Forms.GroupBox();
            this.btnFilterClear = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.dtpFStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblFIcerik = new System.Windows.Forms.Label();
            this.dtpFEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtFIcerik = new System.Windows.Forms.TextBox();
            this.lblFTarihAralik = new System.Windows.Forms.Label();
            this.lblFBaslangicTarihi = new System.Windows.Forms.Label();
            this.lblBitişTarihi = new System.Windows.Forms.Label();
            this.validationError = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGiderListeleme)).BeginInit();
            this.gbxGiderEkleme.SuspendLayout();
            this.gbxFiltreleme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validationError)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwGiderListeleme
            // 
            this.dgwGiderListeleme.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgwGiderListeleme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwGiderListeleme.Location = new System.Drawing.Point(159, 32);
            this.dgwGiderListeleme.Name = "dgwGiderListeleme";
            this.dgwGiderListeleme.ReadOnly = true;
            this.dgwGiderListeleme.Size = new System.Drawing.Size(548, 150);
            this.dgwGiderListeleme.TabIndex = 0;
            this.dgwGiderListeleme.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwGiderListeleme_CellClick);
            // 
            // gbxGiderEkleme
            // 
            this.gbxGiderEkleme.Controls.Add(this.label1);
            this.gbxGiderEkleme.Controls.Add(this.btnSil);
            this.gbxGiderEkleme.Controls.Add(this.btnGüncelle);
            this.gbxGiderEkleme.Controls.Add(this.txtAciklama);
            this.gbxGiderEkleme.Controls.Add(this.dtpTarih);
            this.gbxGiderEkleme.Controls.Add(this.txtToplamTutar);
            this.gbxGiderEkleme.Controls.Add(this.txtIcerik);
            this.gbxGiderEkleme.Controls.Add(this.lblAciklama);
            this.gbxGiderEkleme.Controls.Add(this.lblTarih);
            this.gbxGiderEkleme.Controls.Add(this.lblToplamTutar);
            this.gbxGiderEkleme.Controls.Add(this.lblIcerik);
            this.gbxGiderEkleme.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxGiderEkleme.Location = new System.Drawing.Point(462, 233);
            this.gbxGiderEkleme.Name = "gbxGiderEkleme";
            this.gbxGiderEkleme.Size = new System.Drawing.Size(380, 296);
            this.gbxGiderEkleme.TabIndex = 1;
            this.gbxGiderEkleme.TabStop = false;
            this.gbxGiderEkleme.Text = "Gider Güncelleme";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(238, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "TL";
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(79, 244);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 30);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGüncelle.Location = new System.Drawing.Point(232, 244);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(100, 30);
            this.btnGüncelle.TabIndex = 8;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAciklama.Location = new System.Drawing.Point(132, 148);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(200, 74);
            this.txtAciklama.TabIndex = 7;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTarih.Location = new System.Drawing.Point(132, 109);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(190, 21);
            this.dtpTarih.TabIndex = 6;
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplamTutar.Location = new System.Drawing.Point(132, 71);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.Size = new System.Drawing.Size(100, 21);
            this.txtToplamTutar.TabIndex = 5;
            this.txtToplamTutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtToplamTutar_KeyPress);
            this.txtToplamTutar.Validating += new System.ComponentModel.CancelEventHandler(this.txtToplamTutar_Validating);
            // 
            // txtIcerik
            // 
            this.txtIcerik.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIcerik.Location = new System.Drawing.Point(132, 34);
            this.txtIcerik.Name = "txtIcerik";
            this.txtIcerik.Size = new System.Drawing.Size(200, 21);
            this.txtIcerik.TabIndex = 4;
            this.txtIcerik.Validating += new System.ComponentModel.CancelEventHandler(this.txtIcerik_Validating);
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama.Location = new System.Drawing.Point(36, 151);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(60, 15);
            this.lblAciklama.TabIndex = 3;
            this.lblAciklama.Text = "Açıklama";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Location = new System.Drawing.Point(36, 109);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(37, 15);
            this.lblTarih.TabIndex = 2;
            this.lblTarih.Text = "Tarih";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.Location = new System.Drawing.Point(36, 74);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(79, 15);
            this.lblToplamTutar.TabIndex = 1;
            this.lblToplamTutar.Text = "Toplam Tutar";
            // 
            // lblIcerik
            // 
            this.lblIcerik.AutoSize = true;
            this.lblIcerik.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIcerik.Location = new System.Drawing.Point(36, 34);
            this.lblIcerik.Name = "lblIcerik";
            this.lblIcerik.Size = new System.Drawing.Size(41, 15);
            this.lblIcerik.TabIndex = 0;
            this.lblIcerik.Text = "İçerik";
            // 
            // gbxFiltreleme
            // 
            this.gbxFiltreleme.Controls.Add(this.btnFilterClear);
            this.gbxFiltreleme.Controls.Add(this.btnAra);
            this.gbxFiltreleme.Controls.Add(this.dtpFStartDate);
            this.gbxFiltreleme.Controls.Add(this.lblFIcerik);
            this.gbxFiltreleme.Controls.Add(this.dtpFEndDate);
            this.gbxFiltreleme.Controls.Add(this.txtFIcerik);
            this.gbxFiltreleme.Controls.Add(this.lblFTarihAralik);
            this.gbxFiltreleme.Controls.Add(this.lblFBaslangicTarihi);
            this.gbxFiltreleme.Controls.Add(this.lblBitişTarihi);
            this.gbxFiltreleme.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxFiltreleme.Location = new System.Drawing.Point(32, 233);
            this.gbxFiltreleme.Name = "gbxFiltreleme";
            this.gbxFiltreleme.Size = new System.Drawing.Size(380, 296);
            this.gbxFiltreleme.TabIndex = 2;
            this.gbxFiltreleme.TabStop = false;
            this.gbxFiltreleme.Text = "Filtreleme";
            // 
            // btnFilterClear
            // 
            this.btnFilterClear.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilterClear.Location = new System.Drawing.Point(45, 216);
            this.btnFilterClear.Name = "btnFilterClear";
            this.btnFilterClear.Size = new System.Drawing.Size(100, 60);
            this.btnFilterClear.TabIndex = 53;
            this.btnFilterClear.Text = "Filtreleleri Temizle";
            this.btnFilterClear.UseVisualStyleBackColor = true;
            this.btnFilterClear.Click += new System.EventHandler(this.btnFilterClear_Click);
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(200, 231);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(100, 30);
            this.btnAra.TabIndex = 51;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // dtpFStartDate
            // 
            this.dtpFStartDate.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpFStartDate.Location = new System.Drawing.Point(154, 121);
            this.dtpFStartDate.Name = "dtpFStartDate";
            this.dtpFStartDate.Size = new System.Drawing.Size(190, 21);
            this.dtpFStartDate.TabIndex = 47;
            // 
            // lblFIcerik
            // 
            this.lblFIcerik.AutoSize = true;
            this.lblFIcerik.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFIcerik.Location = new System.Drawing.Point(26, 41);
            this.lblFIcerik.Name = "lblFIcerik";
            this.lblFIcerik.Size = new System.Drawing.Size(106, 15);
            this.lblFIcerik.TabIndex = 0;
            this.lblFIcerik.Text = "İçeriğe Göre Ara: ";
            // 
            // dtpFEndDate
            // 
            this.dtpFEndDate.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpFEndDate.Location = new System.Drawing.Point(154, 151);
            this.dtpFEndDate.Name = "dtpFEndDate";
            this.dtpFEndDate.Size = new System.Drawing.Size(190, 21);
            this.dtpFEndDate.TabIndex = 48;
            // 
            // txtFIcerik
            // 
            this.txtFIcerik.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFIcerik.Location = new System.Drawing.Point(84, 64);
            this.txtFIcerik.Name = "txtFIcerik";
            this.txtFIcerik.Size = new System.Drawing.Size(200, 21);
            this.txtFIcerik.TabIndex = 1;
            // 
            // lblFTarihAralik
            // 
            this.lblFTarihAralik.AutoSize = true;
            this.lblFTarihAralik.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFTarihAralik.Location = new System.Drawing.Point(26, 95);
            this.lblFTarihAralik.Name = "lblFTarihAralik";
            this.lblFTarihAralik.Size = new System.Drawing.Size(149, 15);
            this.lblFTarihAralik.TabIndex = 2;
            this.lblFTarihAralik.Text = "Tarih Aralığına Göre Ara:";
            // 
            // lblFBaslangicTarihi
            // 
            this.lblFBaslangicTarihi.AutoSize = true;
            this.lblFBaslangicTarihi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFBaslangicTarihi.Location = new System.Drawing.Point(26, 121);
            this.lblFBaslangicTarihi.Name = "lblFBaslangicTarihi";
            this.lblFBaslangicTarihi.Size = new System.Drawing.Size(99, 15);
            this.lblFBaslangicTarihi.TabIndex = 4;
            this.lblFBaslangicTarihi.Text = "Baslangıç Tarihi";
            // 
            // lblBitişTarihi
            // 
            this.lblBitişTarihi.AutoSize = true;
            this.lblBitişTarihi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBitişTarihi.Location = new System.Drawing.Point(26, 151);
            this.lblBitişTarihi.Name = "lblBitişTarihi";
            this.lblBitişTarihi.Size = new System.Drawing.Size(71, 15);
            this.lblBitişTarihi.TabIndex = 5;
            this.lblBitişTarihi.Text = "Bitiş Tarihi";
            // 
            // validationError
            // 
            this.validationError.ContainerControl = this;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.Location = new System.Drawing.Point(12, 535);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 25);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Geri Dön";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // GiderListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(874, 571);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbxFiltreleme);
            this.Controls.Add(this.gbxGiderEkleme);
            this.Controls.Add(this.dgwGiderListeleme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "GiderListeleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GiderListeleme";
            this.Load += new System.EventHandler(this.GiderListeleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwGiderListeleme)).EndInit();
            this.gbxGiderEkleme.ResumeLayout(false);
            this.gbxGiderEkleme.PerformLayout();
            this.gbxFiltreleme.ResumeLayout(false);
            this.gbxFiltreleme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validationError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwGiderListeleme;
        private System.Windows.Forms.GroupBox gbxGiderEkleme;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.TextBox txtIcerik;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Label lblIcerik;
        private System.Windows.Forms.GroupBox gbxFiltreleme;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.DateTimePicker dtpFEndDate;
        private System.Windows.Forms.DateTimePicker dtpFStartDate;
        private System.Windows.Forms.Label lblBitişTarihi;
        private System.Windows.Forms.Label lblFBaslangicTarihi;
        private System.Windows.Forms.Label lblFTarihAralik;
        private System.Windows.Forms.TextBox txtFIcerik;
        private System.Windows.Forms.Label lblFIcerik;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ErrorProvider validationError;
        private System.Windows.Forms.Button btnFilterClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
    }
}