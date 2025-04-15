using DataBase;

namespace ProduktErsteller
{
    public partial class NeueKategorie : Form
    {
        private NeuesProdukt NeuesProdukt;

        public NeueKategorie(NeuesProdukt neuesProdukt)
        {
            NeuesProdukt = neuesProdukt;
            InitializeComponent();
        }

        private void btnUebernehmen_Click(object sender, EventArgs e)
        {
            NeuesProdukt.neueKategorieName = txbNeueKategorie.Text;
            NeuesProdukt.neueKategorieHinzugefuegt = true;
            this.Close();
        }
    }
}
