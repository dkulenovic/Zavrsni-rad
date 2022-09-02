namespace SvaSuceljaAplikacije
{
    partial class GlavnaForma
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
            this.uxKupnjaKarte = new System.Windows.Forms.Button();
            this.uxPregledProdanihKarata = new System.Windows.Forms.Button();
            this.uxValidacijaKarata = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxKupnjaKarte
            // 
            this.uxKupnjaKarte.BackColor = System.Drawing.Color.Yellow;
            this.uxKupnjaKarte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uxKupnjaKarte.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uxKupnjaKarte.Location = new System.Drawing.Point(48, 37);
            this.uxKupnjaKarte.Name = "uxKupnjaKarte";
            this.uxKupnjaKarte.Size = new System.Drawing.Size(114, 86);
            this.uxKupnjaKarte.TabIndex = 0;
            this.uxKupnjaKarte.Text = "Otvori kupnju karte";
            this.uxKupnjaKarte.UseVisualStyleBackColor = false;
            this.uxKupnjaKarte.Click += new System.EventHandler(this.uxKupnjaKarte_Click);
            // 
            // uxPregledProdanihKarata
            // 
            this.uxPregledProdanihKarata.BackColor = System.Drawing.Color.Yellow;
            this.uxPregledProdanihKarata.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uxPregledProdanihKarata.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uxPregledProdanihKarata.Location = new System.Drawing.Point(219, 37);
            this.uxPregledProdanihKarata.Name = "uxPregledProdanihKarata";
            this.uxPregledProdanihKarata.Size = new System.Drawing.Size(114, 86);
            this.uxPregledProdanihKarata.TabIndex = 1;
            this.uxPregledProdanihKarata.Text = "Pregled prodanih karata";
            this.uxPregledProdanihKarata.UseVisualStyleBackColor = false;
            this.uxPregledProdanihKarata.Click += new System.EventHandler(this.uxPregledProdanihKarata_Click);
            // 
            // uxValidacijaKarata
            // 
            this.uxValidacijaKarata.BackColor = System.Drawing.Color.Yellow;
            this.uxValidacijaKarata.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uxValidacijaKarata.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxValidacijaKarata.Location = new System.Drawing.Point(48, 174);
            this.uxValidacijaKarata.Name = "uxValidacijaKarata";
            this.uxValidacijaKarata.Size = new System.Drawing.Size(114, 86);
            this.uxValidacijaKarata.TabIndex = 2;
            this.uxValidacijaKarata.Text = "Validacija karata";
            this.uxValidacijaKarata.UseVisualStyleBackColor = false;
            this.uxValidacijaKarata.Click += new System.EventHandler(this.uxValidacijaKarata_Click);
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(389, 330);
            this.Controls.Add(this.uxValidacijaKarata);
            this.Controls.Add(this.uxPregledProdanihKarata);
            this.Controls.Add(this.uxKupnjaKarte);
            this.Name = "GlavnaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GlavnaForma";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uxKupnjaKarte;
        private System.Windows.Forms.Button uxPregledProdanihKarata;
        private System.Windows.Forms.Button uxValidacijaKarata;
    }
}

