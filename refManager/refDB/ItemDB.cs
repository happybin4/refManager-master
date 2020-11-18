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
        public int amount;//개당용량
        
        public int leftCount; // 남은갯수
        public string stoPlace; //저장장소
        public DateTime dDay;
        public string itemType;
        public int leftAmount; // 남은용량
        public string itemUnit;
    }
    class ItemDB : IDisposable
    {
        private MySqlConnection conn;
        public ItemDB()
        {
            conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ref"].ConnectionString);
            conn.Open();
        }
        public DataSet GetAll()
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataSet ds = new DataSet();

            string sql = @"select refItemID, i.itemName, r.refName, stoPlace, leftCount, amount, leftAmount,
                                ItemUnit, i.itemType, datediff(dDay,curdate()) dDay
                            from refitems ri inner join items i 
                            	on ri.itemID = i.itemID
                                inner join ref r
                                on ri.refID = r.refID
                                order by dDay;";

            da.SelectCommand = new MySqlCommand(sql, conn);
            da.Fill(ds, "refItems");

            return ds;
        }
        public DataSet GetAllUpDateItems()
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataSet ds = new DataSet();

            string sql = @"select refItemID, i.itemName, r.refName, stoPlace, leftCount, amount, leftAmount,
                                ItemUnit, i.itemType, dDay
                            from refitems ri inner join items i 
                            	on ri.itemID = i.itemID
                                inner join ref r
                                on ri.refID = r.refID;";

            da.SelectCommand = new MySqlCommand(sql, conn);
            da.Fill(ds, "refItems");

            return ds;
        }
        public DataSet GetAll(string itemType)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataSet ds = new DataSet();

            string sql = @"select refItemID, i.itemName, r.refName, stoPlace, leftCount, amount, leftAmount,
                                ItemUnit, i.itemType, datediff(dDay,curdate()) dDay
                            from refitems ri inner join items i 
                            	on ri.itemID = i.itemID
                                inner join ref r
                                on ri.refID = r.refID
                            where i.itemType = @itemType
                            order by dDay;";

            da.SelectCommand = new MySqlCommand(sql, conn);
            da.SelectCommand.Parameters.Add("itemType", MySqlDbType.VarChar);
            da.SelectCommand.Parameters["itemType"].Value = itemType;
            da.Fill(ds, "typeItems");

            return ds;
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
        public void InsertItem(Items item)
        {
            string sql = @"insert into refitems (itemID, refID, amount, leftCount, stoPlace, dDay, leftAmount, ItemUnit)
                            values(@itemID, @refID, @amount, @leftCount, @stoPlace, @dDay, @leftAmount, @ItemUnit); ";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.Add("@itemID", MySqlDbType.Int32);
            cmd.Parameters["@itemID"].Value = item.itemID;

            cmd.Parameters.Add("@refID", MySqlDbType.Int32);
            cmd.Parameters["@refID"].Value = item.refID;

            cmd.Parameters.Add("@amount", MySqlDbType.Int32);
            cmd.Parameters["@amount"].Value = item.amount;            

            cmd.Parameters.Add("@leftCount", MySqlDbType.Int32);
            cmd.Parameters["@leftCount"].Value = item.leftCount;

            cmd.Parameters.Add("@stoPlace", MySqlDbType.VarChar);
            cmd.Parameters["@stoPlace"].Value = item.stoPlace;

            cmd.Parameters.Add("@dDay", MySqlDbType.Date);
            cmd.Parameters["@dDay"].Value = item.dDay;

            cmd.Parameters.Add("@leftAmount", MySqlDbType.Int32);
            cmd.Parameters["@leftAmount"].Value = item.leftAmount;

            cmd.Parameters.Add("@ItemUnit", MySqlDbType.VarChar);
            cmd.Parameters["@ItemUnit"].Value = item.itemUnit;

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
        public void WasteItem(Items item)
        {
            string sql = @"update refitems
                            set leftCount = @leftCount, leftAmount = @leftAmount
                            where refitemID = @refitemID";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.Add("@leftCount", MySqlDbType.Int32);
            cmd.Parameters["@leftCount"].Value = item.leftCount;

            cmd.Parameters.Add("@leftAmount", MySqlDbType.Int32);
            cmd.Parameters["@leftAmount"].Value = item.leftAmount;

            cmd.Parameters.Add("@refitemID", MySqlDbType.Int32);
            cmd.Parameters["@refitemID"].Value = item.refItemID;

            cmd.ExecuteNonQuery();
        }
        public void DeleteItem(int id)
        {
            string sql = @"delete from refitems
                            where refItemID = @refItemID";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.Add("@refItemID", MySqlDbType.Int32);
            cmd.Parameters["@refItemID"].Value = id;

            cmd.ExecuteNonQuery();
        }
        public void UpdateItems(Items item)
        {
            string sql = @"update refitems
                        set  itemID=@itemID, refID=@refID, amount=@amount, leftCount=@leftCount,
                            stoPlace=@stoPlace, dDay=@dDay, leftAmount=@leftAmount, ItemUnit=@ItemUnit
                        where refitemID = @refitemID";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.Add("@itemID", MySqlDbType.Int32);
            cmd.Parameters["@itemID"].Value = item.itemID;

            cmd.Parameters.Add("@refID", MySqlDbType.Int32);
            cmd.Parameters["@refID"].Value = item.refID;

            cmd.Parameters.Add("@amount", MySqlDbType.Int32);
            cmd.Parameters["@amount"].Value = item.amount;

            cmd.Parameters.Add("@leftCount", MySqlDbType.Int32);
            cmd.Parameters["@leftCount"].Value = item.leftCount;

            cmd.Parameters.Add("@stoPlace", MySqlDbType.VarChar);
            cmd.Parameters["@stoPlace"].Value = item.stoPlace;

            cmd.Parameters.Add("@dDay", MySqlDbType.Date);
            cmd.Parameters["@dDay"].Value = item.dDay;

            cmd.Parameters.Add("@leftAmount", MySqlDbType.Int32);
            cmd.Parameters["@leftAmount"].Value = item.leftAmount;

            cmd.Parameters.Add("@ItemUnit", MySqlDbType.VarChar);
            cmd.Parameters["@ItemUnit"].Value = item.itemUnit;

            cmd.Parameters.Add("@refitemID", MySqlDbType.Int32);
            cmd.Parameters["@refitemID"].Value = item.refItemID;

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
        public void Dispose()
        {
            conn.Close();
        }
    }
}
