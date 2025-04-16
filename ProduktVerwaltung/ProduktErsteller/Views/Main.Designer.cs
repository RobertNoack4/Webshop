namespace Views
{
    partial class Main
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
            btnStartProduktErsteller = new Button();
            SuspendLayout();
            // 
            // btnStartProduktErsteller
            // 
            btnStartProduktErsteller.Location = new Point(12, 43);
            btnStartProduktErsteller.Name = "btnStartProduktErsteller";
            btnStartProduktErsteller.Size = new Size(392, 47);
            btnStartProduktErsteller.TabIndex = 0;
            btnStartProduktErsteller.Text = "Produkt Ersteller";
            btnStartProduktErsteller.UseVisualStyleBackColor = true;
            btnStartProduktErsteller.Click += btnStartProduktErsteller_Click;
            // 
            // ProduktVerwaltung
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStartProduktErsteller);
            Name = "ProduktVerwaltung";
            Text = "ProduktVerwaltung";
            ResumeLayout(false);
        }

        #endregion

        private Button btnStartProduktErsteller;
    }
}