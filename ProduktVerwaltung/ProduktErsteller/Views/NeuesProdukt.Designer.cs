namespace Views
{
    partial class NeuesProdukt
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblProduktName = new Label();
            txbProduktName = new TextBox();
            lblBeschreibung = new Label();
            rtxbBeschreibung = new RichTextBox();
            lblKategorie = new Label();
            cmbKategorie = new ComboBox();
            lblPreis = new Label();
            txbPreis = new TextBox();
            lblStueckzahl = new Label();
            txbStueckzahl = new TextBox();
            lblRabatt = new Label();
            txbRabatt = new TextBox();
            fdBilder = new OpenFileDialog();
            btnOpenFileDialog = new Button();
            btnAddProdukt = new Button();
            SuspendLayout();
            // 
            // lblProduktName
            // 
            lblProduktName.AutoSize = true;
            lblProduktName.Location = new Point(28, 52);
            lblProduktName.Name = "lblProduktName";
            lblProduktName.Size = new Size(42, 15);
            lblProduktName.TabIndex = 0;
            lblProduktName.Text = "Name:";
            // 
            // txbProduktName
            // 
            txbProduktName.Location = new Point(151, 49);
            txbProduktName.Name = "txbProduktName";
            txbProduktName.Size = new Size(268, 23);
            txbProduktName.TabIndex = 1;
            txbProduktName.TextChanged += txbProduktName_TextChanged;
            // 
            // lblBeschreibung
            // 
            lblBeschreibung.AutoSize = true;
            lblBeschreibung.Location = new Point(28, 112);
            lblBeschreibung.Name = "lblBeschreibung";
            lblBeschreibung.Size = new Size(82, 15);
            lblBeschreibung.TabIndex = 2;
            lblBeschreibung.Text = "Beschreibung:";
            // 
            // rtxbBeschreibung
            // 
            rtxbBeschreibung.Location = new Point(151, 109);
            rtxbBeschreibung.Name = "rtxbBeschreibung";
            rtxbBeschreibung.Size = new Size(615, 65);
            rtxbBeschreibung.TabIndex = 4;
            rtxbBeschreibung.Text = "";
            rtxbBeschreibung.TextChanged += rtxbBeschreibung_TextChanged;
            // 
            // lblKategorie
            // 
            lblKategorie.AutoSize = true;
            lblKategorie.Location = new Point(28, 196);
            lblKategorie.Name = "lblKategorie";
            lblKategorie.Size = new Size(60, 15);
            lblKategorie.TabIndex = 5;
            lblKategorie.Text = "Kategorie:";
            // 
            // cmbKategorie
            // 
            cmbKategorie.FormattingEnabled = true;
            cmbKategorie.Location = new Point(151, 193);
            cmbKategorie.Name = "cmbKategorie";
            cmbKategorie.Size = new Size(121, 23);
            cmbKategorie.TabIndex = 6;
            cmbKategorie.SelectedIndexChanged += cmbKategorie_SelectedIndexChanged;
            // 
            // lblPreis
            // 
            lblPreis.AutoSize = true;
            lblPreis.Location = new Point(28, 260);
            lblPreis.Name = "lblPreis";
            lblPreis.Size = new Size(35, 15);
            lblPreis.TabIndex = 7;
            lblPreis.Text = "Preis:";
            // 
            // txbPreis
            // 
            txbPreis.Location = new Point(151, 252);
            txbPreis.Name = "txbPreis";
            txbPreis.Size = new Size(121, 23);
            txbPreis.TabIndex = 8;
            txbPreis.TextChanged += txbPreis_TextChanged;
            txbPreis.KeyPress += txbPreis_KeyPress;
            // 
            // lblStueckzahl
            // 
            lblStueckzahl.AutoSize = true;
            lblStueckzahl.Location = new Point(28, 311);
            lblStueckzahl.Name = "lblStueckzahl";
            lblStueckzahl.Size = new Size(60, 15);
            lblStueckzahl.TabIndex = 9;
            lblStueckzahl.Text = "Stückzahl:";
            // 
            // txbStueckzahl
            // 
            txbStueckzahl.Location = new Point(151, 308);
            txbStueckzahl.Name = "txbStueckzahl";
            txbStueckzahl.Size = new Size(121, 23);
            txbStueckzahl.TabIndex = 10;
            txbStueckzahl.TextChanged += txbStueckzahl_TextChanged;
            // 
            // lblRabatt
            // 
            lblRabatt.AutoSize = true;
            lblRabatt.Location = new Point(28, 366);
            lblRabatt.Name = "lblRabatt";
            lblRabatt.Size = new Size(44, 15);
            lblRabatt.TabIndex = 11;
            lblRabatt.Text = "Rabatt:";
            // 
            // txbRabatt
            // 
            txbRabatt.Location = new Point(151, 358);
            txbRabatt.Name = "txbRabatt";
            txbRabatt.Size = new Size(121, 23);
            txbRabatt.TabIndex = 12;
            txbRabatt.TextChanged += txbRabatt_TextChanged;
            txbRabatt.KeyPress += txbRabatt_KeyPress;
            // 
            // fdBilder
            // 
            fdBilder.FileName = "openFileDialog1";
            fdBilder.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            fdBilder.Multiselect = true;
            fdBilder.Title = "Bilder auswählen";
            fdBilder.FileOk += fdBilder_FileOk;
            // 
            // btnOpenFileDialog
            // 
            btnOpenFileDialog.Location = new Point(28, 409);
            btnOpenFileDialog.Name = "btnOpenFileDialog";
            btnOpenFileDialog.Size = new Size(77, 23);
            btnOpenFileDialog.TabIndex = 13;
            btnOpenFileDialog.Text = "Bilder";
            btnOpenFileDialog.UseVisualStyleBackColor = true;
            btnOpenFileDialog.Click += btnOpenFileDialog_Click;
            // 
            // btnAddProdukt
            // 
            btnAddProdukt.Enabled = false;
            btnAddProdukt.Location = new Point(28, 461);
            btnAddProdukt.Name = "btnAddProdukt";
            btnAddProdukt.Size = new Size(179, 61);
            btnAddProdukt.TabIndex = 14;
            btnAddProdukt.Text = "Neues Produkt anlegen";
            btnAddProdukt.UseVisualStyleBackColor = true;
            btnAddProdukt.Click += btnAddProdukt_Click;
            // 
            // NeuesProdukt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 548);
            Controls.Add(btnAddProdukt);
            Controls.Add(btnOpenFileDialog);
            Controls.Add(txbRabatt);
            Controls.Add(lblRabatt);
            Controls.Add(txbStueckzahl);
            Controls.Add(lblStueckzahl);
            Controls.Add(txbPreis);
            Controls.Add(lblPreis);
            Controls.Add(cmbKategorie);
            Controls.Add(lblKategorie);
            Controls.Add(rtxbBeschreibung);
            Controls.Add(lblBeschreibung);
            Controls.Add(txbProduktName);
            Controls.Add(lblProduktName);
            Name = "NeuesProdukt";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProduktName;
        internal TextBox txbProduktName;
        private Label lblBeschreibung;
        internal RichTextBox rtxbBeschreibung;
        private Label lblKategorie;
        internal ComboBox cmbKategorie;
        private Label lblPreis;
        internal TextBox txbPreis;
        private Label lblStueckzahl;
        internal TextBox txbStueckzahl;
        private Label lblRabatt;
        internal TextBox txbRabatt;
        private OpenFileDialog fdBilder;
        private Button btnOpenFileDialog;
        internal Button btnAddProdukt;
    }
}
