using ProduktVerwaltung.Controller;

namespace Views
{
    public partial class NeuesProdukt : Form
    {
        private readonly KategorieController KategorieController;
        private readonly BildController BildController;
        private readonly ProduktController ProduktController;

        internal NeuesProdukt()
        {
            ProduktController = new ProduktController(this);
            KategorieController = new KategorieController(this);
            BildController = new BildController();

            InitializeComponent();
            cmbKategorie.Items.Add("Neue Kategorie");
            KategorieController.Kategories.ForEach(x => cmbKategorie.Items.Add(x));
        }

        private void cmbKategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKategorie.SelectedIndex == 0)
            {
                var neueKategorieForm = new NeueKategorie(this, KategorieController);
                neueKategorieForm.ShowDialog();
            }

            ProduktController.CheckIfProduktCanBeCreated();
        }

        private void txbPreis_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.Contains(e.KeyChar))
                    e.Handled = true;
            }
        }

        private void txbRabatt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9 and backspace
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8))
            {
                e.Handled = true;
                return;
            }
        }

        private void fdBilder_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            BildController.AddBilder(fdBilder.FileNames);
        }

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            this.fdBilder.ShowDialog();
        }

        private void txbProduktName_TextChanged(object sender, EventArgs e)
        {
            ProduktController.CheckIfProduktCanBeCreated();
        }

        private void rtxbBeschreibung_TextChanged(object sender, EventArgs e)
        {
            ProduktController.CheckIfProduktCanBeCreated();
        }

        private void txbPreis_TextChanged(object sender, EventArgs e)
        {
            ProduktController.CheckIfProduktCanBeCreated();
        }

        private void txbStueckzahl_TextChanged(object sender, EventArgs e)
        {
            ProduktController.CheckIfProduktCanBeCreated();
        }

        private void txbRabatt_TextChanged(object sender, EventArgs e)
        {
            ProduktController.CheckIfProduktCanBeCreated();
        }

        private void btnAddProdukt_Click(object sender, EventArgs e)
        {
            ProduktController.ProduktInDatenbankAnlegen();
        }
    }
}
