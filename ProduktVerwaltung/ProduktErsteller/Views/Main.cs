namespace Views
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnStartProduktErsteller_Click(object sender, EventArgs e)
        {
            NeuesProdukt neuesProdukt = new NeuesProdukt();
            if (!neuesProdukt.IsDisposed)
            {
                neuesProdukt.Show();
                this.Hide();
            }
        }
    }
}
