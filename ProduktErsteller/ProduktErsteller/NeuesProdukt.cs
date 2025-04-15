using ProduktErsteller;

namespace DataBase
{
    public partial class NeuesProdukt : Form
    {
        public string neueKategorieName;
        public bool neueKategorieHinzugefuegt;

        public NeuesProdukt()
        {
            InitializeComponent();
            neueKategorieHinzugefuegt = false;
            cmbKategorie.Items.Add("Neue Kategorie");
            var allKategories = DatabaseKategorie.GetKategorieList();
            allKategories.ForEach(x => cmbKategorie.Items.Add(x.Name));
        }

        private void cmbKategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKategorie.SelectedIndex == 0)
            {
                var neueKategorieForm = new NeueKategorie(this);
                neueKategorieForm.ShowDialog();
            }
        }
    }
}
