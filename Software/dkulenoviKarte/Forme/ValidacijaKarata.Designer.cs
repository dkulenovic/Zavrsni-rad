namespace SvaSuceljaAplikacije
{
    partial class ValidacijaKarata
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
            this.uxOtvoriSlikuDijalog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.uxSifraKarte = new System.Windows.Forms.TextBox();
            this.uxValidirajKartu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.uxPoruka = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxOtvoriSlikuDijalog
            // 
            this.uxOtvoriSlikuDijalog.DefaultExt = "jpg";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Validacija karata";
            // 
            // uxSifraKarte
            // 
            this.uxSifraKarte.Location = new System.Drawing.Point(17, 93);
            this.uxSifraKarte.Name = "uxSifraKarte";
            this.uxSifraKarte.Size = new System.Drawing.Size(224, 20);
            this.uxSifraKarte.TabIndex = 1;
            // 
            // uxValidirajKartu
            // 
            this.uxValidirajKartu.BackColor = System.Drawing.Color.Yellow;
            this.uxValidirajKartu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uxValidirajKartu.Location = new System.Drawing.Point(38, 148);
            this.uxValidirajKartu.Name = "uxValidirajKartu";
            this.uxValidirajKartu.Size = new System.Drawing.Size(175, 41);
            this.uxValidirajKartu.TabIndex = 2;
            this.uxValidirajKartu.Text = "Provjeri valjanost";
            this.uxValidirajKartu.UseVisualStyleBackColor = false;
            this.uxValidirajKartu.Click += new System.EventHandler(this.uxValidirajKartu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Šifra karte:";
            // 
            // uxPoruka
            // 
            this.uxPoruka.AutoSize = true;
            this.uxPoruka.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uxPoruka.ForeColor = System.Drawing.Color.Black;
            this.uxPoruka.Location = new System.Drawing.Point(22, 116);
            this.uxPoruka.Name = "uxPoruka";
            this.uxPoruka.Size = new System.Drawing.Size(0, 19);
            this.uxPoruka.TabIndex = 4;
            // 
            // ValidacijaKarata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(292, 262);
            this.Controls.Add(this.uxPoruka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxValidirajKartu);
            this.Controls.Add(this.uxSifraKarte);
            this.Controls.Add(this.label1);
            this.Name = "ValidacijaKarata";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ValidacijaKarata";
            this.Load += new System.EventHandler(this.ValidacijaKarata_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ValidacijaKarata_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.OpenFileDialog uxOtvoriSlikuDijalog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uxSifraKarte;
        private System.Windows.Forms.Button uxValidirajKartu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label uxPoruka;
    }
}