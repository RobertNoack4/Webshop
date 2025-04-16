namespace Database.Modell
{
    public class Bild
    {
        public string BildName { get; private set; }
        public string FilePath { get; private set; }

        public Bild(string bildName, string filePath)
        {
            BildName = bildName;
            FilePath = filePath;
        }
    }
}
