
namespace MuhasebeApp.UserUI.Forms
{
    partial class GiderEkleme
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
            this.gbxGiderEkleme = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.txtIcerik = new System.Windows.Forms.TextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.lblIcerik = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.validationError = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxGiderEkleme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validationError)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxGiderEkleme
            // 
            this.gbxGiderEkleme.Controls.Add(this.btnKaydet);
            this.gbxGiderEkleme.Controls.Add(this.txtAciklama);
            this.gbxGiderEkleme.Controls.Add(this.dtpTarih);
            this.gbxGiderEkleme.Controls.Add(this.txtToplamTutar);
            this.gbxGiderEkleme.Controls.Add(this.txtIcerik);
            this.gbxGiderEkleme.Controls.Add(this.lblAciklama);
            this.gbxGiderEkleme.Controls.Add(this.lblTarih);
            this.gbxGiderEkleme.Controls.Add(this.lblToplamTutar);
            this.gbxGiderEkleme.Controls.Add(this.lblIcerik);
            this.gbxGiderEkleme.Location = new System.Drawing.Point(171, 57);
            this.gbxGiderEkleme.Name = "gbxGiderEkleme";
            this.gbxGiderEkleme.Size = new System.Drawing.Size(379, 407);
            this.gbxGiderEkleme.TabIndex = 0;
            this.gbxGiderEkleme.TabStop = false;
            this.gbxGiderEkleme.Text = "Gider Ekleme";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(260, 325);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(135, 211);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(200, 74);
            this.txtAciklama.TabIndex = 7;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(135, 172);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(200, 20);
            this.dtpTarih.TabIndex = 6;
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Location = new System.Drawing.Point(135, 134);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.Size = new System.Drawing.Size(100, 20);
            this.txtToplamTutar.TabIndex = 5;
            this.txtToplamTutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtToplamTutar_KeyPress);
            this.txtToplamTutar.Validating += new System.ComponentModel.CancelEventHandler(this.txtToplamTutar_Validating);
            // 
            // txtIcerik
            // 
            this.txtIcerik.Location = new System.Drawing.Point(135, 97);
            this.txtIcerik.Name = "txtIcerik";
            this.txtIcerik.Size = new System.Drawing.Size(200, 20);
            this.txtIcerik.TabIndex = 4;
            this.txtIcerik.Validating += new System.ComponentModel.CancelEventHandler(this.txtIcerik_Validating);
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(39, 214);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(50, 13);
            this.lblAciklama.TabIndex = 3;
            this.lblAciklama.Text = "Açıklama";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(39, 172);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(31, 13);
            this.lblTarih.TabIndex = 2;
            this.lblTarih.Text = "Tarih";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(39, 137);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(70, 13);
            this.lblToplamTutar.TabIndex = 1;
            this.lblToplamTutar.Text = "Toplam Tutar";
            // 
            // lblIcerik
            // 
            this.lblIcerik.AutoSize = true;
            this.lblIcerik.Location = new System.Drawing.Point(39, 97);
            this.lblIcerik.Name = "lblIcerik";
            this.lblIcerik.Size = new System.Drawing.Size(33, 13);
            this.lblIcerik.TabIndex = 0;
            this.lblIcerik.Text = "İçerik";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 545);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Geri Dön";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // validationError
            // 
            this.validationError.ContainerControl = this;
            // 
            // GiderEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 580);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbxGiderEkleme);
            this.Name = "GiderEkleme";
            this.Text = "GiderEkleme";
            this.gbxGiderEkleme.ResumeLayout(false);
            this.gbxGiderEkleme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validationError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxGiderEkleme;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.TextBox txtIcerik;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Label lblIcerik;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ErrorProvider validationError;
    }
}