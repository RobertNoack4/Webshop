using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace DataBase
{
    public static class DatabaseKategorie
    {
        public static List<Kategorie> GetKategorieList()
        {
            List<Kategorie > kategorieList = new List<Kategorie>();
            using (SqlConnection conn = new SqlConnection("Data Source=MYPC;Initial Catalog=OnlineShop;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"))
            {
                conn.Open();
                var command = conn.CreateCommand();
                command.CommandText = "SELECT * FROM KategorieView";

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var id = reader.GetInt32(0);
                        var name = reader.GetString(1);
                        kategorieList.Add(new Kategorie(id, name));
                    }
                }

                conn.Close();
            }

            return kategorieList;
        }
    }
}
