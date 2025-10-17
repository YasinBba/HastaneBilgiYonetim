namespace HastaneBilgiYonetim
{
    partial class FrmGirisler
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
            this.BtnHasta = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnDoktor = new System.Windows.Forms.Button();
            this.BtnSekreter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnHasta
            // 
            this.BtnHasta.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnHasta.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnHasta.Location = new System.Drawing.Point(14, 197);
            this.BtnHasta.Margin = new System.Windows.Forms.Padding(5);
            this.BtnHasta.Name = "BtnHasta";
            this.BtnHasta.Size = new System.Drawing.Size(248, 192);
            this.BtnHasta.TabIndex = 0;
            this.BtnHasta.Text = "Hasta";
            this.BtnHasta.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(569, 379);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(10, 10);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BtnDoktor
            // 
            this.BtnDoktor.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnDoktor.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDoktor.Location = new System.Drawing.Point(331, 197);
            this.BtnDoktor.Margin = new System.Windows.Forms.Padding(5);
            this.BtnDoktor.Name = "BtnDoktor";
            this.BtnDoktor.Size = new System.Drawing.Size(248, 192);
            this.BtnDoktor.TabIndex = 2;
            this.BtnDoktor.Text = "Doktor";
            this.BtnDoktor.UseVisualStyleBackColor = false;
            // 
            // BtnSekreter
            // 
            this.BtnSekreter.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnSekreter.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSekreter.Location = new System.Drawing.Point(646, 197);
            this.BtnSekreter.Margin = new System.Windows.Forms.Padding(5);
            this.BtnSekreter.Name = "BtnSekreter";
            this.BtnSekreter.Size = new System.Drawing.Size(248, 192);
            this.BtnSekreter.TabIndex = 3;
            this.BtnSekreter.Text = "Sekreter";
            this.BtnSekreter.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(130, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(690, 78);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hastane Yönetim Paneli";
            // 
            // FrmGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(917, 436);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnHasta);
            this.Controls.Add(this.BtnSekreter);
            this.Controls.Add(this.BtnDoktor);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmGirisler";
            this.Text = "FrmGirisler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnHasta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnDoktor;
        private System.Windows.Forms.Button BtnSekreter;
        private System.Windows.Forms.Label label1;
    }
}

