
namespace MuhasebeApp.UserUI.Forms
{
    partial class GelirHub
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
            this.btnGelirEkleme = new System.Windows.Forms.Button();
            this.btnGelirListeleme = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGelirEkleme
            // 
            this.btnGelirEkleme.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGelirEkleme.Location = new System.Drawing.Point(214, 171);
            this.btnGelirEkleme.Name = "btnGelirEkleme";
            this.btnGelirEkleme.Size = new System.Drawing.Size(100, 60);
            this.btnGelirEkleme.TabIndex = 2;
            this.btnGelirEkleme.Text = "Gelir Ekleme";
            this.btnGelirEkleme.UseVisualStyleBackColor = true;
            this.btnGelirEkleme.Click += new System.EventHandler(this.btnGelirEkleme_Click);
            // 
            // btnGelirListeleme
            // 
            this.btnGelirListeleme.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGelirListeleme.Location = new System.Drawing.Point(457, 171);
            this.btnGelirListeleme.Name = "btnGelirListeleme";
            this.btnGelirListeleme.Size = new System.Drawing.Size(100, 60);
            this.btnGelirListeleme.TabIndex = 3;
            this.btnGelirListeleme.Text = "Gelir Listeleme";
            this.btnGelirListeleme.UseVisualStyleBackColor = true;
            this.btnGelirListeleme.Click += new System.EventHandler(this.btnGelirListeleme_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.Location = new System.Drawing.Point(12, 413);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 25);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Geri Dön";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // GelirHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnGelirListeleme);
            this.Controls.Add(this.btnGelirEkleme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "GelirHub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GelirHub";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGelirEkleme;
        private System.Windows.Forms.Button btnGelirListeleme;
        private System.Windows.Forms.Button btnBack;
    }
}