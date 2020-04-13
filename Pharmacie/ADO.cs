using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Pharmacie
{
    class ADO
    {
        // declaration des objets sql 
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader dr;
        public DataTable dt = new DataTable();

        // declaration de la methode connecter
        public void CONNECTER()
        {
            if (con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)
            {
                con.ConnectionString = "Data Source=SSR\\SQLEXPRESS;Initial Catalog=Pharmacie;Integrated Security=True";
                con.Open();
            }
        }
        // declaration de la methode deconnection
        public void DECONNECTER()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
