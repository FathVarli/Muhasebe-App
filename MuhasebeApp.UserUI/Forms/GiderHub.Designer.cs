
namespace MuhasebeApp.UserUI.Forms
{
    partial class GiderHub
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnGiderListeleme = new System.Windows.Forms.Button();
            this.btnGiderEkleme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.Location = new System.Drawing.Point(12, 413);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 25);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Geri Dön";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnGiderListeleme
            // 
            this.btnGiderListeleme.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiderListeleme.Location = new System.Drawing.Point(481, 171);
            this.btnGiderListeleme.Name = "btnGiderListeleme";
            this.btnGiderListeleme.Size = new System.Drawing.Size(100, 60);
            this.btnGiderListeleme.TabIndex = 12;
            this.btnGiderListeleme.Text = "Gider Listeleme";
            this.btnGiderListeleme.UseVisualStyleBackColor = true;
            this.btnGiderListeleme.Click += new System.EventHandler(this.btnGiderListeleme_Click);
            // 
            // btnGiderEkleme
            // 
            this.btnGiderEkleme.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiderEkleme.Location = new System.Drawing.Point(238, 171);
            this.btnGiderEkleme.Name = "btnGiderEkleme";
            this.btnGiderEkleme.Size = new System.Drawing.Size(100, 60);
            this.btnGiderEkleme.TabIndex = 11;
            this.btnGiderEkleme.Text = "Gider Ekleme";
            this.btnGiderEkleme.UseVisualStyleBackColor = true;
            this.btnGiderEkleme.Click += new System.EventHandler(this.btnGiderEkleme_Click);
            // 
            // GiderHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnGiderListeleme);
            this.Controls.Add(this.btnGiderEkleme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "GiderHub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GiderHub";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnGiderListeleme;
        private System.Windows.Forms.Button btnGiderEkleme;
    }
}