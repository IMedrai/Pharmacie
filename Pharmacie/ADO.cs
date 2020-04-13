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
        private SqlConnection con;
        public SqlCommand cmd;
        public SqlDataReader dr;
        public DataTable dt = new DataTable();
        private String cnxString;

        // declaration de la methode connecter
        public void connecter()
        {
            if (con == null || con.State != ConnectionState.Open)
            {
                
                con.Open();
            }
        }
        // declaration de la methode deconnection
        public void deconnecter()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        public Boolean executeRequest(String request, List<SqlParameter> param)
        {
            Boolean resultRequest = true;
            connecter();
            SqlCommand command = new SqlCommand(request);
            command.Parameters.AddRange(param.ToArray());
            int result = command.ExecuteNonQuery();
            if (result == -1)
            {
                resultRequest = false;
            }
            return resultRequest;
        }

        public ADO(String connectionString)
        {
            cnxString = connectionString;
            con = new SqlConnection();
            con.ConnectionString = this.cnxString;
        }
    }
}
