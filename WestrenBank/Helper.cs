using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
namespace WestrenBank
{
    class Helper
    {
        static string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\User\Documents\Visual Studio 2017\Projects\WestrenBank\BankDB.accdb'";
        public static void selectQuery(DataGridView dgv,string sql)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(sql, connStr);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgv.DataSource = ds.Tables[0];
        }
        public static DataSet insertQuery(string sql)
        {
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter(sql,connStr);
            da.Fill(ds);
            return ds;
        }
    }
}
