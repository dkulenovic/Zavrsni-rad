namespace SvaSuceljaAplikacije
{
    partial class PregledProdanihKarata
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
            this.uxPregledKarata = new System.Windows.Forms.DataGridView();
            this.idkartaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trenutakaktivacijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumkupnjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mjestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstakarteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValjanostPrikaz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kartaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uxIspisiIzvjesce = new System.Windows.Forms.Button();
            this.izvjesceDatumOd = new System.Windows.Forms.DateTimePicker();
            this.izvjesceDatumDo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.filtriranjeDatumOd = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.filtriranjeDatumDo = new System.Windows.Forms.DateTimePicker();
            this.uxFiltriraj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.uxUkupnaZarada = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uxPregledKarata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uxPregledKarata
            // 
            this.uxPregledKarata.AllowUserToAddRows = false;
            this.uxPregledKarata.AllowUserToDeleteRows = false;
            this.uxPregledKarata.AutoGenerateColumns = false;
            this.uxPregledKarata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxPregledKarata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idkartaDataGridViewTextBoxColumn,
            this.trenutakaktivacijeDataGridViewTextBoxColumn,
            this.datumkupnjeDataGridViewTextBoxColumn,
            this.korisnikDataGridViewTextBoxColumn,
            this.mjestoDataGridViewTextBoxColumn,
            this.vrstakarteDataGridViewTextBoxColumn,
            this.ValjanostPrikaz});
            this.uxPregledKarata.DataSource = this.kartaBindingSource;
            this.uxPregledKarata.Location = new System.Drawing.Point(13, 13);
            this.uxPregledKarata.Name = "uxPregledKarata";
            this.uxPregledKarata.ReadOnly = true;
            this.uxPregledKarata.Size = new System.Drawing.Size(841, 269);
            this.uxPregledKarata.TabIndex = 0;
            // 
            // idkartaDataGridViewTextBoxColumn
            // 
            this.idkartaDataGridViewTextBoxColumn.DataPropertyName = "id_karta";
            this.idkartaDataGridViewTextBoxColumn.HeaderText = "Šifra karte";
            this.idkartaDataGridViewTextBoxColumn.Name = "idkartaDataGridViewTextBoxColumn";
            this.idkartaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trenutakaktivacijeDataGridViewTextBoxColumn
            // 
            this.trenutakaktivacijeDataGridViewTextBoxColumn.DataPropertyName = "trenutak_aktivacije";
            this.trenutakaktivacijeDataGridViewTextBoxColumn.HeaderText = "Vrijeme aktivacije";
            this.trenutakaktivacijeDataGridViewTextBoxColumn.Name = "trenutakaktivacijeDataGridViewTextBoxColumn";
            this.trenutakaktivacijeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumkupnjeDataGridViewTextBoxColumn
            // 
            this.datumkupnjeDataGridViewTextBoxColumn.DataPropertyName = "datum_kupnje";
            this.datumkupnjeDataGridViewTextBoxColumn.HeaderText = "Datum kupnje";
            this.datumkupnjeDataGridViewTextBoxColumn.Name = "datumkupnjeDataGridViewTextBoxColumn";
            this.datumkupnjeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // korisnikDataGridViewTextBoxColumn
            // 
            this.korisnikDataGridViewTextBoxColumn.DataPropertyName = "Korisnik";
            this.korisnikDataGridViewTextBoxColumn.HeaderText = "Korisnik";
            this.korisnikDataGridViewTextBoxColumn.Name = "korisnikDataGridViewTextBoxColumn";
            this.korisnikDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mjestoDataGridViewTextBoxColumn
            // 
            this.mjestoDataGridViewTextBoxColumn.DataPropertyName = "Mjesto";
            this.mjestoDataGridViewTextBoxColumn.HeaderText = "Mjesto";
            this.mjestoDataGridViewTextBoxColumn.Name = "mjestoDataGridViewTextBoxColumn";
            this.mjestoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vrstakarteDataGridViewTextBoxColumn
            // 
            this.vrstakarteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vrstakarteDataGridViewTextBoxColumn.DataPropertyName = "Vrsta_karte";
            this.vrstakarteDataGridViewTextBoxColumn.HeaderText = "Vrsta karte";
            this.vrstakarteDataGridViewTextBoxColumn.Name = "vrstakarteDataGridViewTextBoxColumn";
            this.vrstakarteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ValjanostPrikaz
            // 
            this.ValjanostPrikaz.DataPropertyName = "ValjanostPrikaz";
            this.ValjanostPrikaz.HeaderText = "Valjanost ";
            this.ValjanostPrikaz.Name = "ValjanostPrikaz";
            this.ValjanostPrikaz.ReadOnly = true;
            // 
            // kartaBindingSource
            // 
            this.kartaBindingSource.DataSource = typeof(SvaSuceljaAplikacije.EntityKlase.Karta);
            // 
            // uxIspisiIzvjesce
            // 
            this.uxIspisiIzvjesce.Location = new System.Drawing.Point(142, 429);
            this.uxIspisiIzvjesce.Name = "uxIspisiIzvjesce";
            this.uxIspisiIzvjesce.Size = new System.Drawing.Size(103, 23);
            this.uxIspisiIzvjesce.TabIndex = 1;
            this.uxIspisiIzvjesce.Text = "Ispiši izvješće";
            this.uxIspisiIzvjesce.UseVisualStyleBackColor = true;
            this.uxIspisiIzvjesce.Click += new System.EventHandler(this.uxIspisiIzvjesce_Click);
            // 
            // izvjesceDatumOd
            // 
            this.izvjesceDatumOd.Location = new System.Drawing.Point(111, 348);
            this.izvjesceDatumOd.Name = "izvjesceDatumOd";
            this.izvjesceDatumOd.Size = new System.Drawing.Size(134, 20);
            this.izvjesceDatumOd.TabIndex = 4;
            this.izvjesceDatumOd.Value = new System.DateTime(2021, 6, 29, 0, 0, 0, 0);
            // 
            // izvjesceDatumDo
            // 
            this.izvjesceDatumDo.Location = new System.Drawing.Point(111, 383);
            this.izvjesceDatumDo.Name = "izvjesceDatumDo";
            this.izvjesceDatumDo.Size = new System.Drawing.Size(134, 20);
            this.izvjesceDatumDo.TabIndex = 5;
            this.izvjesceDatumDo.Value = new System.DateTime(2021, 6, 29, 15, 25, 52, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Datum do:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Datum od:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ispis izvješća";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(284, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Filtriranje popisa";
            // 
            // filtriranjeDatumOd
            // 
            this.filtriranjeDatumOd.Location = new System.Drawing.Point(359, 347);
            this.filtriranjeDatumOd.Name = "filtriranjeDatumOd";
            this.filtriranjeDatumOd.Size = new System.Drawing.Size(134, 20);
            this.filtriranjeDatumOd.TabIndex = 11;
            this.filtriranjeDatumOd.Value = new System.DateTime(2021, 6, 29, 15, 25, 33, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Datum od:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(297, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Datum od:";
            // 
            // filtriranjeDatumDo
            // 
            this.filtriranjeDatumDo.Location = new System.Drawing.Point(359, 382);
            this.filtriranjeDatumDo.Name = "filtriranjeDatumDo";
            this.filtriranjeDatumDo.Size = new System.Drawing.Size(134, 20);
            this.filtriranjeDatumDo.TabIndex = 13;
            this.filtriranjeDatumDo.Value = new System.DateTime(2021, 6, 29, 0, 0, 0, 0);
            // 
            // uxFiltriraj
            // 
            this.uxFiltriraj.Location = new System.Drawing.Point(415, 429);
            this.uxFiltriraj.Name = "uxFiltriraj";
            this.uxFiltriraj.Size = new System.Drawing.Size(78, 23);
            this.uxFiltriraj.TabIndex = 15;
            this.uxFiltriraj.Text = "Filtriraj";
            this.uxFiltriraj.UseVisualStyleBackColor = true;
            this.uxFiltriraj.Click += new System.EventHandler(this.uxFiltriraj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(16, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 147);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(288, 321);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 147);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(552, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Ukupna zarada u razdoblju:";
            // 
            // uxUkupnaZarada
            // 
            this.uxUkupnaZarada.AutoSize = true;
            this.uxUkupnaZarada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uxUkupnaZarada.Location = new System.Drawing.Point(755, 298);
            this.uxUkupnaZarada.Name = "uxUkupnaZarada";
            this.uxUkupnaZarada.Size = new System.Drawing.Size(0, 16);
            this.uxUkupnaZarada.TabIndex = 19;
            // 
            // PregledProdanihKarata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 493);
            this.Controls.Add(this.uxUkupnaZarada);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.uxFiltriraj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.filtriranjeDatumDo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.filtriranjeDatumOd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.izvjesceDatumDo);
            this.Controls.Add(this.izvjesceDatumOd);
            this.Controls.Add(this.uxIspisiIzvjesce);
            this.Controls.Add(this.uxPregledKarata);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "PregledProdanihKarata";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PregledProdanihKarata";
            this.Load += new System.EventHandler(this.PregledProdanihKarata_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PregledProdanihKarata_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.uxPregledKarata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uxPregledKarata;
        private System.Windows.Forms.Button uxIspisiIzvjesce;
        private System.Windows.Forms.DateTimePicker izvjesceDatumOd;
        private System.Windows.Forms.DateTimePicker izvjesceDatumDo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker filtriranjeDatumOd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker filtriranjeDatumDo;
        private System.Windows.Forms.Button uxFiltriraj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label uxUkupnaZarada;
        private System.Windows.Forms.BindingSource kartaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkartaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trenutakaktivacijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumkupnjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mjestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrstakarteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValjanostPrikaz;
    }
}