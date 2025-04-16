using ProduktVerwaltung.Controller;

namespace Views
{
    public partial class NeueKategorie : Form
    {
        private KategorieController KategorieController;
        private NeuesProdukt NeuesProdukt;
        internal NeueKategorie(NeuesProdukt neuesProdukt, KategorieController kategorieController)
        {
            KategorieController = kategorieController;
            NeuesProdukt = neuesProdukt;
            InitializeComponent();
        }

        private void btnUebernehmen_Click(object sender, EventArgs e)
        {
            KategorieController.NeueKategorieAnlegen(this, NeuesProdukt);
            this.Close();
        }
    }
}
