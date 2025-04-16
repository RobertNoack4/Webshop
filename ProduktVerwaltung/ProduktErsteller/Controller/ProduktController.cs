using Database.Modell;
using DataBase;
using Views;

namespace ProduktVerwaltung.Controller
{
    internal class ProduktController
    {
        internal NeuesProdukt NeuesProduktView { get; set; }
        internal Produkt? Produkt { get; set; }

        public ProduktController(NeuesProdukt neuesProdukt)
        {
            NeuesProduktView = neuesProdukt;
        }

        public void ProduktInDatenbankAnlegen()
        {
            ProduktModellAnlegen();

            if (Produkt == null)
            {
                return;
            }

            if (Produkt.Kategorie.Id == null)
            {
                DatabaseKategorieController.AddKategorie(Produkt.Kategorie.Name, out int kategorieId, out Exception exception);
            }
        }

        public void CheckIfProduktCanBeCreated()
        {
            NeuesProduktView.btnAddProdukt.Enabled = false;

            if (String.IsNullOrEmpty(NeuesProduktView.txbProduktName.Text))
            {
                return;
            }

            if (NeuesProduktView.cmbKategorie.SelectedIndex == 0)
            {
                return;
            }

            if (NeuesProduktView.cmbKategorie.SelectedItem is not Kategorie)
            {
                return;
            }

            if (!String.IsNullOrEmpty(NeuesProduktView.txbPreis.Text))
            {
                if (decimal.TryParse(NeuesProduktView.txbPreis.Text, out _) == false)
                {
                    return;
                }
            }

            if (String.IsNullOrEmpty(NeuesProduktView.txbStueckzahl.Text))
            {
                return;
            }

            if (int.TryParse(NeuesProduktView.txbStueckzahl.Text, out _) == false)
            {
                return;
            }

            if (!String.IsNullOrEmpty(NeuesProduktView.txbRabatt.Text))
            {
                if (int.TryParse(NeuesProduktView.txbRabatt.Text, out _) == false)
                {
                    return;
                }
            }

            NeuesProduktView.btnAddProdukt.Enabled = true;
        }

        private void ProduktModellAnlegen()
        {
            decimal? preis;
            int? rabatt;

            if (String.IsNullOrEmpty(NeuesProduktView.txbPreis.Text))
            {
                preis = null;
            }
            else
            {
                preis = decimal.Parse(NeuesProduktView.txbPreis.Text);
            }

            if (String.IsNullOrEmpty(NeuesProduktView.txbRabatt.Text))
            {
                rabatt = null;
            }
            else
            {
                rabatt = int.Parse(NeuesProduktView.txbRabatt.Text);
            }

            var stueckzahl = int.Parse(NeuesProduktView.txbStueckzahl.Text);

            Produkt = new Produkt(null, NeuesProduktView.txbProduktName.Text, NeuesProduktView.rtxbBeschreibung.Text, NeuesProduktView.cmbKategorie.SelectedItem as Kategorie, preis, stueckzahl, rabatt);
        }
    }
}
