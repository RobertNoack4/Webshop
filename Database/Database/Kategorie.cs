using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class Kategorie
    {
        public int Id { get; }
        public string Name { get; }

        public Kategorie(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
