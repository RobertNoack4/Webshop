using Database.Modell;

namespace ProduktVerwaltung.Controller
{
    internal class BildController
    {
        internal List<Bild> Bilder;
        public BildController() 
        {
            Bilder = new List<Bild>();
        }

        public void AddBilder(string[] fileNames)
        {
            foreach (string file in fileNames)
            {
                string name = Path.GetFileNameWithoutExtension(file);
                string path = file;

                Bilder.Add(new Bild(name, path));
            }
        }
    }
}
