namespace ProduktErsteller
{
    partial class NeueKategorie
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
            lblNeueKategorie = new Label();
            txbNeueKategorie = new TextBox();
            btnUebernehmen = new Button();
            SuspendLayout();
            // 
            // lblNeueKategorie
            // 
            lblNeueKategorie.Anchor = AnchorStyles.Top;
            lblNeueKategorie.AutoSize = true;
            lblNeueKategorie.Location = new Point(12, 21);
            lblNeueKategorie.Name = "lblNeueKategorie";
            lblNeueKategorie.Size = new Size(91, 15);
            lblNeueKategorie.TabIndex = 0;
            lblNeueKategorie.Text = "Neue Kategorie:";
            // 
            // txbNeueKategorie
            // 
            txbNeueKategorie.Location = new Point(122, 18);
            txbNeueKategorie.Name = "txbNeueKategorie";
            txbNeueKategorie.Size = new Size(217, 23);
            txbNeueKategorie.TabIndex = 1;
            // 
            // btnUebernehmen
            // 
            btnUebernehmen.Location = new Point(12, 74);
            btnUebernehmen.Name = "btnUebernehmen";
            btnUebernehmen.Size = new Size(91, 23);
            btnUebernehmen.TabIndex = 2;
            btnUebernehmen.Text = "Übernehmen";
            btnUebernehmen.UseVisualStyleBackColor = true;
            btnUebernehmen.Click += btnUebernehmen_Click;
            // 
            // NeueKategorie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 109);
            Controls.Add(btnUebernehmen);
            Controls.Add(txbNeueKategorie);
            Controls.Add(lblNeueKategorie);
            Name = "NeueKategorie";
            Text = "NeueKategorie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNeueKategorie;
        private TextBox txbNeueKategorie;
        private Button btnUebernehmen;
    }
}