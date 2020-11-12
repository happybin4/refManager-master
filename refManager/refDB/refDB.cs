using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Security.Authentication.ExtendedProtection;
using System.Data;

using System.Windows.Forms;

namespace refManager
{
    public struct Ref
    {
        public int refID;
        public string refName;
        public int refSize;
    }
    class refDB : IDisposable
    {
        private MySqlConnection conn;
        public refDB()
        {
            conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ref"].ConnectionString);
            conn.Open();
        }

        public DataSet GetAll()
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataSet ds = new DataSet();

            string sql = @"select refID, refName, refSize
                        from ref";

            da.SelectCommand = new MySqlCommand(sql, conn);
            da.Fill(ds, "ref");

            return ds;
        }

        public void Insert(Ref myref)
        {
            string sql = @"insert into ref(refName, refSize)
                         values(@refName,@refSize)";

            MySqlCommand cmd = new MySqlCommand(sql,conn);

            cmd.Parameters.Add("@refName", MySqlDbType.VarChar);
            cmd.Parameters["@refName"].Value = myref.refName;

            cmd.Parameters.Add("@refSize", MySqlDbType.VarChar);
            cmd.Parameters["@refSize"].Value = myref.refSize;

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
        public void update(Ref myref)
        {
            try
            {
                string sql = @"update ref 
                    set refName=@refName, refSize = @refSize
                    where refID = @refID;";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@refName", MySqlDbType.VarChar);
                cmd.Parameters["@refName"].Value = myref.refName;

                cmd.Parameters.Add("@refSize", MySqlDbType.Int32);
                cmd.Parameters["@refSize"].Value = myref.refSize;

                cmd.Parameters.Add("@refID", MySqlDbType.Int32);
                cmd.Parameters["@refID"].Value = myref.refID;

                cmd.ExecuteNonQuery();
            }
            catch(Exception err)
            {
                throw err;
            }
        }
        public void delete(Ref myref)
        {
            try
            {
                string sql = @"delete from ref
                        where refID = @refID;";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@refID", MySqlDbType.Int32);
                cmd.Parameters["@refID"].Value = myref.refID;

                cmd.ExecuteNonQuery();
            }
            catch(Exception err)
            {
                throw err;
            }
        }
        public DataTable SearchData(string refName)
        {
            string sql = @"select refID, refName, refSize
                        from ref
                        where refName = @refName" ;

            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.Add("@refName", MySqlDbType.VarChar);
            da.SelectCommand.Parameters["@refName"].Value = refName;

            DataTable dt = new DataTable();

            da.Fill(dt);
            return dt;
        }
        

        public void Dispose()
        {
            conn.Close();
        }
    }
}

