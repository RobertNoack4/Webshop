namespace DataBase
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
            rtxbBeschreibung.Size = new Size(615, 176);
            rtxbBeschreibung.TabIndex = 4;
            rtxbBeschreibung.Text = "";
            // 
            // lblKategorie
            // 
            lblKategorie.AutoSize = true;
            lblKategorie.Location = new Point(28, 331);
            lblKategorie.Name = "lblKategorie";
            lblKategorie.Size = new Size(60, 15);
            lblKategorie.TabIndex = 5;
            lblKategorie.Text = "Kategorie:";
            // 
            // cmbKategorie
            // 
            cmbKategorie.FormattingEnabled = true;
            cmbKategorie.Location = new Point(151, 328);
            cmbKategorie.Name = "cmbKategorie";
            cmbKategorie.Size = new Size(121, 23);
            cmbKategorie.TabIndex = 6;
            cmbKategorie.SelectedIndexChanged += cmbKategorie_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbKategorie);
            Controls.Add(lblKategorie);
            Controls.Add(rtxbBeschreibung);
            Controls.Add(lblBeschreibung);
            Controls.Add(txbProduktName);
            Controls.Add(lblProduktName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProduktName;
        private TextBox txbProduktName;
        private Label lblBeschreibung;
        private RichTextBox rtxbBeschreibung;
        private Label lblKategorie;
        private ComboBox cmbKategorie;
    }
}
