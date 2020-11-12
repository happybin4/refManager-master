using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;

namespace refManager
{
    public struct Items
    {
        //refItemID, itemID, refID, amount, count, leftCount, stoPlace, dDay
        public int refItemID;
        public int itemID;
        public int refID;
        public int amount;
        public int count;
        public int leftCount;
        public string stoPlace;
        public DateTime dDay;
        public string itemType;
    }
    class ItemDB : IDisposable
    {
        private MySqlConnection conn;
        public ItemDB()
        {
            conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ref"].ConnectionString);
            conn.Open();
        }
        public DataSet GetCommonCode(string[] categorys)
        {
            string sql = @"select codeID ,codeName from refcode
                           where upCode = @upCode";

            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.Add("@upCode", MySqlDbType.VarChar);

            foreach (string category in categorys)
            {
                da.SelectCommand.Parameters["@upCode"].Value = category;
                da.Fill(ds, category);
            }
            return ds;
        }
        public DataSet GetRefName()
        {
            string sql = "select refID, refName from ref";

            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

            da.Fill(ds);
            return ds;
        }
        public DataSet GetItemName(string itype)
        {
            string sql = @"select itemID, itemName 
                        from items
                        where itemType = @itemType";

            

            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.Add("@itemType", MySqlDbType.VarChar);
            da.SelectCommand.Parameters["@itemType"].Value = itype;

            da.Fill(ds);
            return ds;
        }

        public void Dispose()
        {
            conn.Close();
        }
    }
}
