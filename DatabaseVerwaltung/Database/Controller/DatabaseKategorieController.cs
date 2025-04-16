using System;
using System.Collections.Generic;
using Database;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DataBase
{
    public static class DatabaseKategorieController
    {
        public static bool GetKategorieList(out List<Kategorie> kategorieListe, out Exception exception)
        {
            kategorieListe = new List<Kategorie>();
            exception = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseParameterStrings.ConnectionString))
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
                            kategorieListe.Add(new Kategorie(id, name));
                        }
                    }

                    conn.Close();
                }

                return true;
            }
            catch(Exception ex)
            {
                exception = ex;
                return false;
            }
        }

        public static bool AddKategorie(string name, out int id, out Exception exception)
        {
            id = -1;
            exception = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseParameterStrings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(DatabaseParameterStrings.AddKategorieProcedureName, conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter(DatabaseParameterStrings.KategorieNameParameter, name));
                        
                        var returnParameter = command.Parameters.Add(DatabaseParameterStrings.KategorieNameReturnParameter, SqlDbType.Int);
                        returnParameter.Direction = ParameterDirection.Output;

                        conn.Open();
                        command.ExecuteNonQuery();
                        id = (int)returnParameter.Value;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                exception = ex;
                return false;
            }
        }
    }
}
