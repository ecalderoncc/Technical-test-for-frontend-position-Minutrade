using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProductsPortfolio
{
    class DataAccess
    {

        private string chain = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\DB_TEST.mdf;Integrated Security=True;Connect Timeout=30";
        public SqlConnection cn;
        private SqlCommandBuilder cmb;
        public DataSet ds = new DataSet();
        public SqlDataAdapter da;
        public SqlCommand comand;
        private void connect()
        {
            cn = new SqlConnection(chain);
        }

        public DataAccess()
        {
            connect();
        }
        public void consult (string sql, string table)
        {
            ds.Tables.Clear();
            da = new SqlDataAdapter(sql, cn);
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, table);
        }

        public bool delete (string table, string condition)
        {
            cn.Open();
            string sql = "delete from " + table + " where " + condition;
            comand = new SqlCommand(sql, cn);
            int i = comand.ExecuteNonQuery();
            cn.Close();
            if(i>0)
            {
                return true;
            }
            else { return false; }
        }

        public bool update (string table, string fields, string condition)
        {
            cn.Open();
            string sql = "update " + table + " set NAMEPROD, PRICEPROD, CATEPROD where" + condition;
            comand = new SqlCommand(sql, cn);
            int i = comand.ExecuteNonQuery();
            cn.Close();
            if (i > 0)
            {
                return true;
            }
            else { return false; }
        }

        public DataTable consult2(string table)
        {
            string sql = "select * from " + table;
            da = new SqlDataAdapter(sql, cn);
            DataSet dts = new DataSet();
            da.Fill(dts, table);
            DataTable dt = new DataTable();
            dt = dts.Tables[table];
            return dt;
        }

        public bool insert(string sql)
        {
            cn.Open();
            comand = new SqlCommand(sql, cn);
            int i = comand.ExecuteNonQuery();
            cn.Close();
            if (i > 0)
            {
                return true;
            }
            else { return false; }
        }

    }
}
