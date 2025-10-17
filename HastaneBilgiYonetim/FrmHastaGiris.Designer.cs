namespace HastaneBilgiYonetim
{
    partial class FrmHastaGiris
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
            this.TxtTcKimlik = new System.Windows.Forms.MaskedTextBox();
            this.TxtSifre = new System.Windows.Forms.MaskedTextBox();
            this.BtnGirisYap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LinkLblUyeOl = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // TxtTcKimlik
            // 
            this.TxtTcKimlik.Location = new System.Drawing.Point(161, 173);
            this.TxtTcKimlik.Mask = "00000000000";
            this.TxtTcKimlik.Name = "TxtTcKimlik";
            this.TxtTcKimlik.Size = new System.Drawing.Size(137, 33);
            this.TxtTcKimlik.TabIndex = 0;
            this.TxtTcKimlik.ValidatingType = typeof(int);
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(161, 213);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(137, 33);
            this.TxtSifre.TabIndex = 1;
            // 
            // BtnGirisYap
            // 
            this.BtnGirisYap.Location = new System.Drawing.Point(161, 271);
            this.BtnGirisYap.Name = "BtnGirisYap";
            this.BtnGirisYap.Size = new System.Drawing.Size(137, 38);
            this.BtnGirisYap.TabIndex = 2;
            this.BtnGirisYap.Text = "Giriş Yap";
            this.BtnGirisYap.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "TC Kimlik No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(48, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 42);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hasta Giriş Paneli";
            // 
            // LinkLblUyeOl
            // 
            this.LinkLblUyeOl.AutoSize = true;
            this.LinkLblUyeOl.Location = new System.Drawing.Point(156, 326);
            this.LinkLblUyeOl.Name = "LinkLblUyeOl";
            this.LinkLblUyeOl.Size = new System.Drawing.Size(69, 26);
            this.LinkLblUyeOl.TabIndex = 6;
            this.LinkLblUyeOl.TabStop = true;
            this.LinkLblUyeOl.Text = "Üye Ol";
            // 
            // FrmHastaGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(369, 383);
            this.Controls.Add(this.LinkLblUyeOl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGirisYap);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.TxtTcKimlik);
            this.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmHastaGiris";
            this.Text = "FrmHastaGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox TxtTcKimlik;
        private System.Windows.Forms.MaskedTextBox TxtSifre;
        private System.Windows.Forms.Button BtnGirisYap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel LinkLblUyeOl;
    }
}