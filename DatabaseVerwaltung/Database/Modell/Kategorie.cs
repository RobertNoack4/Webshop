namespace DataBase
{
    public class Kategorie
    {
        public int? Id { get; }
        public string Name { get; }

        public Kategorie(int? id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
