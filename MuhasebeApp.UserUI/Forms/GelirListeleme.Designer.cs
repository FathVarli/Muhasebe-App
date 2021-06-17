﻿
namespace MuhasebeApp.UserUI.Forms
{
    partial class GelirListeleme
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
            this.dgwGelirListeleme = new System.Windows.Forms.DataGridView();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.lblMalzeme = new System.Windows.Forms.Label();
            this.txtAlinanTutar = new System.Windows.Forms.TextBox();
            this.lblAdet = new System.Windows.Forms.Label();
            this.cbxOdemeSekli = new System.Windows.Forms.ComboBox();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.lblAlinanTutar = new System.Windows.Forms.Label();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblBirim = new System.Windows.Forms.Label();
            this.cbxMalzemeAdi = new System.Windows.Forms.ComboBox();
            this.lblOdemeŞekli = new System.Windows.Forms.Label();
            this.lblAçıklama = new System.Windows.Forms.Label();
            this.gbxFiltreleme = new System.Windows.Forms.GroupBox();
            this.cbxFMalzemeAdi = new System.Windows.Forms.ComboBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.cbxFOdemeSekli = new System.Windows.Forms.ComboBox();
            this.dtpFEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblOdemeSekli = new System.Windows.Forms.Label();
            this.lblOdemeSeklineGoreAra = new System.Windows.Forms.Label();
            this.lblBitişTarihi = new System.Windows.Forms.Label();
            this.lblFBaslangicTarihi = new System.Windows.Forms.Label();
            this.lblFTarihAralik = new System.Windows.Forms.Label();
            this.lblFMalzemeAdi = new System.Windows.Forms.Label();
            this.validationError = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnFilterClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGelirListeleme)).BeginInit();
            this.gbxUpdate.SuspendLayout();
            this.gbxFiltreleme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validationError)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwGelirListeleme
            // 
            this.dgwGelirListeleme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwGelirListeleme.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgwGelirListeleme.Location = new System.Drawing.Point(12, 12);
            this.dgwGelirListeleme.Name = "dgwGelirListeleme";
            this.dgwGelirListeleme.ReadOnly = true;
            this.dgwGelirListeleme.Size = new System.Drawing.Size(842, 150);
            this.dgwGelirListeleme.TabIndex = 0;
            this.dgwGelirListeleme.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwGelirListeleme_CellClick);
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.btnSil);
            this.gbxUpdate.Controls.Add(this.btnGuncelle);
            this.gbxUpdate.Controls.Add(this.txtAdet);
            this.gbxUpdate.Controls.Add(this.txtAciklama);
            this.gbxUpdate.Controls.Add(this.lblMalzeme);
            this.gbxUpdate.Controls.Add(this.txtAlinanTutar);
            this.gbxUpdate.Controls.Add(this.lblAdet);
            this.gbxUpdate.Controls.Add(this.cbxOdemeSekli);
            this.gbxUpdate.Controls.Add(this.lblToplamTutar);
            this.gbxUpdate.Controls.Add(this.dtpTarih);
            this.gbxUpdate.Controls.Add(this.lblAlinanTutar);
            this.gbxUpdate.Controls.Add(this.txtToplamTutar);
            this.gbxUpdate.Controls.Add(this.lblTarih);
            this.gbxUpdate.Controls.Add(this.lblBirim);
            this.gbxUpdate.Controls.Add(this.cbxMalzemeAdi);
            this.gbxUpdate.Controls.Add(this.lblOdemeŞekli);
            this.gbxUpdate.Controls.Add(this.lblAçıklama);
            this.gbxUpdate.Location = new System.Drawing.Point(514, 183);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(340, 342);
            this.gbxUpdate.TabIndex = 1;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Güncelleme";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(137, 292);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 51;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(243, 292);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 50;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(137, 79);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(64, 20);
            this.txtAdet.TabIndex = 44;
            this.txtAdet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdet_KeyPress);
            this.txtAdet.Validating += new System.ComponentModel.CancelEventHandler(this.txtAdet_Validating);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(137, 213);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(181, 55);
            this.txtAciklama.TabIndex = 49;
            // 
            // lblMalzeme
            // 
            this.lblMalzeme.AutoSize = true;
            this.lblMalzeme.Location = new System.Drawing.Point(47, 48);
            this.lblMalzeme.Name = "lblMalzeme";
            this.lblMalzeme.Size = new System.Drawing.Size(67, 13);
            this.lblMalzeme.TabIndex = 35;
            this.lblMalzeme.Text = "Malzeme Adi";
            // 
            // txtAlinanTutar
            // 
            this.txtAlinanTutar.Location = new System.Drawing.Point(137, 133);
            this.txtAlinanTutar.Name = "txtAlinanTutar";
            this.txtAlinanTutar.Size = new System.Drawing.Size(64, 20);
            this.txtAlinanTutar.TabIndex = 48;
            this.txtAlinanTutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlinanTutar_KeyPress);
            this.txtAlinanTutar.Validating += new System.ComponentModel.CancelEventHandler(this.txtAlinanTutar_Validating);
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Location = new System.Drawing.Point(47, 79);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(29, 13);
            this.lblAdet.TabIndex = 36;
            this.lblAdet.Text = "Adet";
            // 
            // cbxOdemeSekli
            // 
            this.cbxOdemeSekli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOdemeSekli.FormattingEnabled = true;
            this.cbxOdemeSekli.Location = new System.Drawing.Point(137, 185);
            this.cbxOdemeSekli.Name = "cbxOdemeSekli";
            this.cbxOdemeSekli.Size = new System.Drawing.Size(121, 21);
            this.cbxOdemeSekli.TabIndex = 47;
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(44, 107);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(70, 13);
            this.lblToplamTutar.TabIndex = 37;
            this.lblToplamTutar.Text = "Toplam Tutar";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(137, 159);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(181, 20);
            this.dtpTarih.TabIndex = 46;
            // 
            // lblAlinanTutar
            // 
            this.lblAlinanTutar.AutoSize = true;
            this.lblAlinanTutar.Location = new System.Drawing.Point(47, 133);
            this.lblAlinanTutar.Name = "lblAlinanTutar";
            this.lblAlinanTutar.Size = new System.Drawing.Size(64, 13);
            this.lblAlinanTutar.TabIndex = 38;
            this.lblAlinanTutar.Text = "Alinan Tutar";
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Location = new System.Drawing.Point(137, 107);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.ReadOnly = true;
            this.txtToplamTutar.Size = new System.Drawing.Size(64, 20);
            this.txtToplamTutar.TabIndex = 45;
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(47, 159);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(31, 13);
            this.lblTarih.TabIndex = 39;
            this.lblTarih.Text = "Tarih";
            // 
            // lblBirim
            // 
            this.lblBirim.AutoSize = true;
            this.lblBirim.Location = new System.Drawing.Point(229, 86);
            this.lblBirim.Name = "lblBirim";
            this.lblBirim.Size = new System.Drawing.Size(29, 13);
            this.lblBirim.TabIndex = 40;
            this.lblBirim.Text = "Birim";
            // 
            // cbxMalzemeAdi
            // 
            this.cbxMalzemeAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMalzemeAdi.FormattingEnabled = true;
            this.cbxMalzemeAdi.Location = new System.Drawing.Point(137, 48);
            this.cbxMalzemeAdi.Name = "cbxMalzemeAdi";
            this.cbxMalzemeAdi.Size = new System.Drawing.Size(121, 21);
            this.cbxMalzemeAdi.TabIndex = 43;
            this.cbxMalzemeAdi.TextChanged += new System.EventHandler(this.cbxMalzemeAdi_TextChanged);
            // 
            // lblOdemeŞekli
            // 
            this.lblOdemeŞekli.AutoSize = true;
            this.lblOdemeŞekli.Location = new System.Drawing.Point(44, 185);
            this.lblOdemeŞekli.Name = "lblOdemeŞekli";
            this.lblOdemeŞekli.Size = new System.Drawing.Size(67, 13);
            this.lblOdemeŞekli.TabIndex = 41;
            this.lblOdemeŞekli.Text = "Ödeme Şekli";
            // 
            // lblAçıklama
            // 
            this.lblAçıklama.AutoSize = true;
            this.lblAçıklama.Location = new System.Drawing.Point(44, 213);
            this.lblAçıklama.Name = "lblAçıklama";
            this.lblAçıklama.Size = new System.Drawing.Size(50, 13);
            this.lblAçıklama.TabIndex = 42;
            this.lblAçıklama.Text = "Açıklama";
            // 
            // gbxFiltreleme
            // 
            this.gbxFiltreleme.Controls.Add(this.btnFilterClear);
            this.gbxFiltreleme.Controls.Add(this.cbxFMalzemeAdi);
            this.gbxFiltreleme.Controls.Add(this.btnAra);
            this.gbxFiltreleme.Controls.Add(this.cbxFOdemeSekli);
            this.gbxFiltreleme.Controls.Add(this.dtpFEndDate);
            this.gbxFiltreleme.Controls.Add(this.dtpFStartDate);
            this.gbxFiltreleme.Controls.Add(this.lblOdemeSekli);
            this.gbxFiltreleme.Controls.Add(this.lblOdemeSeklineGoreAra);
            this.gbxFiltreleme.Controls.Add(this.lblBitişTarihi);
            this.gbxFiltreleme.Controls.Add(this.lblFBaslangicTarihi);
            this.gbxFiltreleme.Controls.Add(this.lblFTarihAralik);
            this.gbxFiltreleme.Controls.Add(this.lblFMalzemeAdi);
            this.gbxFiltreleme.Location = new System.Drawing.Point(12, 183);
            this.gbxFiltreleme.Name = "gbxFiltreleme";
            this.gbxFiltreleme.Size = new System.Drawing.Size(298, 342);
            this.gbxFiltreleme.TabIndex = 2;
            this.gbxFiltreleme.TabStop = false;
            this.gbxFiltreleme.Text = "Filtreleme";
            // 
            // cbxFMalzemeAdi
            // 
            this.cbxFMalzemeAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFMalzemeAdi.FormattingEnabled = true;
            this.cbxFMalzemeAdi.Items.AddRange(new object[] {
            "Malzeme Seçiniz"});
            this.cbxFMalzemeAdi.Location = new System.Drawing.Point(94, 79);
            this.cbxFMalzemeAdi.Name = "cbxFMalzemeAdi";
            this.cbxFMalzemeAdi.Size = new System.Drawing.Size(181, 21);
            this.cbxFMalzemeAdi.TabIndex = 44;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(200, 280);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 51;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // cbxFOdemeSekli
            // 
            this.cbxFOdemeSekli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFOdemeSekli.FormattingEnabled = true;
            this.cbxFOdemeSekli.Location = new System.Drawing.Point(94, 225);
            this.cbxFOdemeSekli.Name = "cbxFOdemeSekli";
            this.cbxFOdemeSekli.Size = new System.Drawing.Size(121, 21);
            this.cbxFOdemeSekli.TabIndex = 49;
            // 
            // dtpFEndDate
            // 
            this.dtpFEndDate.Location = new System.Drawing.Point(94, 166);
            this.dtpFEndDate.Name = "dtpFEndDate";
            this.dtpFEndDate.Size = new System.Drawing.Size(181, 20);
            this.dtpFEndDate.TabIndex = 48;
            // 
            // dtpFStartDate
            // 
            this.dtpFStartDate.Location = new System.Drawing.Point(94, 133);
            this.dtpFStartDate.Name = "dtpFStartDate";
            this.dtpFStartDate.Size = new System.Drawing.Size(181, 20);
            this.dtpFStartDate.TabIndex = 47;
            // 
            // lblOdemeSekli
            // 
            this.lblOdemeSekli.AutoSize = true;
            this.lblOdemeSekli.Location = new System.Drawing.Point(6, 228);
            this.lblOdemeSekli.Name = "lblOdemeSekli";
            this.lblOdemeSekli.Size = new System.Drawing.Size(67, 13);
            this.lblOdemeSekli.TabIndex = 7;
            this.lblOdemeSekli.Text = "Ödeme Şekli";
            // 
            // lblOdemeSeklineGoreAra
            // 
            this.lblOdemeSeklineGoreAra.AutoSize = true;
            this.lblOdemeSeklineGoreAra.Location = new System.Drawing.Point(6, 202);
            this.lblOdemeSeklineGoreAra.Name = "lblOdemeSeklineGoreAra";
            this.lblOdemeSeklineGoreAra.Size = new System.Drawing.Size(127, 13);
            this.lblOdemeSeklineGoreAra.TabIndex = 3;
            this.lblOdemeSeklineGoreAra.Text = "Ödeme Şekline Göre Ara:";
            // 
            // lblBitişTarihi
            // 
            this.lblBitişTarihi.AutoSize = true;
            this.lblBitişTarihi.Location = new System.Drawing.Point(6, 166);
            this.lblBitişTarihi.Name = "lblBitişTarihi";
            this.lblBitişTarihi.Size = new System.Drawing.Size(55, 13);
            this.lblBitişTarihi.TabIndex = 5;
            this.lblBitişTarihi.Text = "Bitiş Tarihi";
            // 
            // lblFBaslangicTarihi
            // 
            this.lblFBaslangicTarihi.AutoSize = true;
            this.lblFBaslangicTarihi.Location = new System.Drawing.Point(6, 136);
            this.lblFBaslangicTarihi.Name = "lblFBaslangicTarihi";
            this.lblFBaslangicTarihi.Size = new System.Drawing.Size(82, 13);
            this.lblFBaslangicTarihi.TabIndex = 4;
            this.lblFBaslangicTarihi.Text = "Baslangıç Tarihi";
            // 
            // lblFTarihAralik
            // 
            this.lblFTarihAralik.AutoSize = true;
            this.lblFTarihAralik.Location = new System.Drawing.Point(6, 110);
            this.lblFTarihAralik.Name = "lblFTarihAralik";
            this.lblFTarihAralik.Size = new System.Drawing.Size(122, 13);
            this.lblFTarihAralik.TabIndex = 2;
            this.lblFTarihAralik.Text = "Tarih Aralığına Göre Ara:";
            // 
            // lblFMalzemeAdi
            // 
            this.lblFMalzemeAdi.AutoSize = true;
            this.lblFMalzemeAdi.Location = new System.Drawing.Point(6, 56);
            this.lblFMalzemeAdi.Name = "lblFMalzemeAdi";
            this.lblFMalzemeAdi.Size = new System.Drawing.Size(130, 13);
            this.lblFMalzemeAdi.TabIndex = 0;
            this.lblFMalzemeAdi.Text = "Malzeme Adina Göre Ara: ";
            // 
            // validationError
            // 
            this.validationError.ContainerControl = this;
            // 
            // btnFilterClear
            // 
            this.btnFilterClear.Location = new System.Drawing.Point(26, 280);
            this.btnFilterClear.Name = "btnFilterClear";
            this.btnFilterClear.Size = new System.Drawing.Size(102, 23);
            this.btnFilterClear.TabIndex = 52;
            this.btnFilterClear.Text = "Filtreleleri Temizle";
            this.btnFilterClear.UseVisualStyleBackColor = true;
            this.btnFilterClear.Click += new System.EventHandler(this.btnFilterClear_Click);
            // 
            // GelirListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 568);
            this.Controls.Add(this.gbxFiltreleme);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.dgwGelirListeleme);
            this.Name = "GelirListeleme";
            this.Text = "GelirListeleme";
            this.Load += new System.EventHandler(this.GelirListeleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwGelirListeleme)).EndInit();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.gbxFiltreleme.ResumeLayout(false);
            this.gbxFiltreleme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validationError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwGelirListeleme;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label lblMalzeme;
        private System.Windows.Forms.TextBox txtAlinanTutar;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.ComboBox cbxOdemeSekli;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label lblAlinanTutar;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblBirim;
        private System.Windows.Forms.ComboBox cbxMalzemeAdi;
        private System.Windows.Forms.Label lblOdemeŞekli;
        private System.Windows.Forms.Label lblAçıklama;
        private System.Windows.Forms.GroupBox gbxFiltreleme;
        private System.Windows.Forms.DateTimePicker dtpFEndDate;
        private System.Windows.Forms.DateTimePicker dtpFStartDate;
        private System.Windows.Forms.Label lblOdemeSekli;
        private System.Windows.Forms.Label lblOdemeSeklineGoreAra;
        private System.Windows.Forms.Label lblBitişTarihi;
        private System.Windows.Forms.Label lblFBaslangicTarihi;
        private System.Windows.Forms.Label lblFTarihAralik;
        private System.Windows.Forms.Label lblFMalzemeAdi;
        private System.Windows.Forms.ComboBox cbxFOdemeSekli;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ComboBox cbxFMalzemeAdi;
        private System.Windows.Forms.ErrorProvider validationError;
        private System.Windows.Forms.Button btnFilterClear;
    }
}