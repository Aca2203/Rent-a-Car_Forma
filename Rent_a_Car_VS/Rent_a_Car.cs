using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Rent_a_Car_VS
{
    public class Rent_a_Car
    {
        SqlConnection veza = new SqlConnection();
        string CS = ConfigurationManager.ConnectionStrings["Rent_a_Car"].ConnectionString;
        SqlCommand komanda = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet set = new DataSet();

        public int Provera_Korisnika(string email, string lozinka)
        {
            veza.ConnectionString = CS;

            int rezultat;

            komanda.Connection = veza;
            komanda.CommandType = CommandType.StoredProcedure;
            komanda.CommandText = "Korisnik_Email";
            
            komanda.Parameters.Add(new SqlParameter("@email", SqlDbType.NVarChar, 100, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Current, email));
            komanda.Parameters.Add(new SqlParameter("@lozinka", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Current, lozinka));
            komanda.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, true, 0, 0, "", DataRowVersion.Current, null));

            veza.Open();
            komanda.ExecuteNonQuery();
            veza.Close();

            int ret;
            ret = (int) komanda.Parameters["@RETURN_VALUE"].Value;
            if (ret == 0)
            {
                rezultat = 0;
            }
            else
            {
                rezultat = 1;
            }

            return rezultat;
        }
    }
}