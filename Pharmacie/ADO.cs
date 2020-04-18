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

        public Boolean executeNoOutputRequest(String request, List<SqlParameter> param)
        {
            Boolean resultRequest = true;
            connecter();
            cmd = new SqlCommand(request);
            cmd.Connection = this.con;
            cmd.Parameters.AddRange(param.ToArray());
            int result = cmd.ExecuteNonQuery();
            if (result == -1)
            {
                resultRequest = false;
            }
            return resultRequest;
        }

        public String getSqRefVente()
        {
            String selectQuery = "select next value for dbo.sq_ref_vente as 'sq'";
            List <Dictionary<String, Object>> listResults = this.executeRequest(selectQuery, null);
            Object obj = null;
            listResults[0].TryGetValue("sq", out obj);
            Console.WriteLine(obj.GetType());
            return obj.ToString();
        }

        public List<Dictionary<String, Object>> executeRequest(String request, List<SqlParameter> param)
        {
            connecter();
            cmd = new SqlCommand(request);
            cmd.Connection = this.con;
            if (param != null && param.Count > 0)
            {
                cmd.Parameters.AddRange(param.ToArray());
            }
            
            dr = cmd.ExecuteReader();
            Console.WriteLine(this.dr.VisibleFieldCount);
            return setReaderDataInDict();
        }

        public List<Dictionary<String, Object>> setReaderDataInDict()
        {
            List<Dictionary<String, Object>> listMapData = new List<Dictionary<string, object>>();
            Dictionary<String, Object> mapData = null ;
            while (dr.Read())
            {
                if (dr == null || !dr.HasRows)
                {
                    continue;
                }
                mapData = new Dictionary<string, object>();
                for (int i = 0;i < dr.VisibleFieldCount;i++)
                {
                    mapData.Add(dr.GetName(i), dr.GetValue(i));
                }
                listMapData.Add(mapData);


            }
            dr.Close();
            return listMapData;
        }

        public ADO(String connectionString)
        {
            cnxString = connectionString;
            con = new SqlConnection();
            con.ConnectionString = this.cnxString;
        }
    }
}
