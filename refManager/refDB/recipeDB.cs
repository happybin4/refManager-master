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
    public struct RecipeItems
    {
        //recipeID, recipeName, recipe, recipeID, itemID, rItemCount, rItemAmount
        public int recipeID;
        public string recipeName;
        public string recipe;
        public int itemID;
        public int rItemCount;
        public int rItemAmount;
    }
    class recipeDB : IDisposable
    {
        private MySqlConnection conn;
        public recipeDB()
        {
            conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ref"].ConnectionString);
            conn.Open();
        }
        public void Dispose()
        {
            conn.Close();
        }

        public void AddRecipe(RecipeItems ritem)
        {
            string sql = @"insert into recipes (recipeName, recipe)
                            values(@recipeName, @recipe);";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.Add("@recipeName", MySqlDbType.VarChar);
            cmd.Parameters["@recipeName"].Value = ritem.recipeName;

            cmd.Parameters.Add("@recipe", MySqlDbType.VarChar);
            cmd.Parameters["@recipe"].Value = ritem.recipe;

            cmd.ExecuteNonQuery();
        }
    }
}
