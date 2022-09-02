namespace SvaSuceljaAplikacije
{
    partial class KupnjaKarte
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
            this.uxNaslov = new System.Windows.Forms.Label();
            this.uxKupiKartu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uxCijena = new System.Windows.Forms.TextBox();
            this.uxVrstaKarte = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.uxMjesto = new System.Windows.Forms.ComboBox();
            this.uxDatum = new System.Windows.Forms.TextBox();
            this.uxVrijeme = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxNaslov
            // 
            this.uxNaslov.AutoSize = true;
            this.uxNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uxNaslov.Location = new System.Drawing.Point(12, 9);
            this.uxNaslov.Name = "uxNaslov";
            this.uxNaslov.Size = new System.Drawing.Size(145, 25);
            this.uxNaslov.TabIndex = 1;
            this.uxNaslov.Text = "Kupnja karata";
            // 
            // uxKupiKartu
            // 
            this.uxKupiKartu.BackColor = System.Drawing.Color.Yellow;
            this.uxKupiKartu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uxKupiKartu.Location = new System.Drawing.Point(64, 366);
            this.uxKupiKartu.Name = "uxKupiKartu";
            this.uxKupiKartu.Size = new System.Drawing.Size(190, 40);
            this.uxKupiKartu.TabIndex = 3;
            this.uxKupiKartu.Text = "Kupi kartu";
            this.uxKupiKartu.UseVisualStyleBackColor = false;
            this.uxKupiKartu.Click += new System.EventHandler(this.uxKupiKartu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(60, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Datum:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(61, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mjesto kupnje:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(61, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cijena karte:";
            // 
            // uxCijena
            // 
            this.uxCijena.Location = new System.Drawing.Point(64, 311);
            this.uxCijena.Name = "uxCijena";
            this.uxCijena.ReadOnly = true;
            this.uxCijena.Size = new System.Drawing.Size(190, 20);
            this.uxCijena.TabIndex = 13;
            // 
            // uxVrstaKarte
            // 
            this.uxVrstaKarte.FormattingEnabled = true;
            this.uxVrstaKarte.Location = new System.Drawing.Point(63, 81);
            this.uxVrstaKarte.Name = "uxVrstaKarte";
            this.uxVrstaKarte.Size = new System.Drawing.Size(190, 21);
            this.uxVrstaKarte.TabIndex = 17;
            this.uxVrstaKarte.SelectedIndexChanged += new System.EventHandler(this.uxVrstaKarte_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(60, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Vrsta karte:";
            // 
            // uxMjesto
            // 
            this.uxMjesto.FormattingEnabled = true;
            this.uxMjesto.Location = new System.Drawing.Point(65, 257);
            this.uxMjesto.Name = "uxMjesto";
            this.uxMjesto.Size = new System.Drawing.Size(190, 21);
            this.uxMjesto.TabIndex = 19;
            // 
            // uxDatum
            // 
            this.uxDatum.Location = new System.Drawing.Point(64, 136);
            this.uxDatum.Name = "uxDatum";
            this.uxDatum.ReadOnly = true;
            this.uxDatum.Size = new System.Drawing.Size(190, 20);
            this.uxDatum.TabIndex = 20;
            // 
            // uxVrijeme
            // 
            this.uxVrijeme.Location = new System.Drawing.Point(63, 193);
            this.uxVrijeme.Name = "uxVrijeme";
            this.uxVrijeme.ReadOnly = true;
            this.uxVrijeme.Size = new System.Drawing.Size(190, 20);
            this.uxVrijeme.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(59, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 18);
            this.label9.TabIndex = 21;
            this.label9.Text = "Vrijeme:";
            // 
            // KupnjaKarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(316, 442);
            this.Controls.Add(this.uxVrijeme);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.uxDatum);
            this.Controls.Add(this.uxMjesto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.uxVrstaKarte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uxCijena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxKupiKartu);
            this.Controls.Add(this.uxNaslov);
            this.Name = "KupnjaKarte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kupnja karata";
            this.Load += new System.EventHandler(this.KupnjaKarata_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KupnjaKarte_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label uxNaslov;
        private System.Windows.Forms.Button uxKupiKartu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox uxCijena;
        private System.Windows.Forms.ComboBox uxVrstaKarte;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox uxMjesto;
        private System.Windows.Forms.TextBox uxDatum;
        private System.Windows.Forms.TextBox uxVrijeme;
        private System.Windows.Forms.Label label9;
    }
}