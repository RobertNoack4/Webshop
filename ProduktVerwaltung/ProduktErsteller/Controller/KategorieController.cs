using DataBase;
using Views;

namespace ProduktVerwaltung.Controller
{
    internal class KategorieController
    {
        internal bool NeueKategorieAngelegt { get; private set; }

        internal List<Kategorie> Kategories { get; private set; }

        internal KategorieController(Form form)
        {
            NeueKategorieAngelegt = false;
            Kategories = new List<Kategorie>();
            GetKategoriesFromDatabase(form);
        }

        private void GetKategoriesFromDatabase(Form form)
        {
            if (DatabaseKategorieController.GetKategorieList(out var allKategories, out var exception) == false)
            {
                MessageBox.Show(exception.Message, "Error with Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                form.Close();
            }

            Kategories = allKategories;
        }

        internal void NeueKategorieAnlegen(NeueKategorie neueKategorie, NeuesProdukt neuesProdukt)
        {
            var newKategorie = new Kategorie(null, neueKategorie.txbNeueKategorie.Text);

            if (NeueKategorieAngelegt)
            {
                neuesProdukt.cmbKategorie.Items[neuesProdukt.cmbKategorie.Items.Count - 1] = newKategorie;
            }
            else
            {
                neuesProdukt.cmbKategorie.Items.Add(newKategorie);
            }

            NeueKategorieAngelegt = true;
        }
    }
}
