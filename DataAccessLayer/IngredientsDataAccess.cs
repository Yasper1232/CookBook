using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DomainModel.Models;

namespace DataAccessLayer
{
    public class IngredientsDataAccess
    {
        public void AddIngredient(Ingredient ingredient) 
        {

            string connectionString = ConfigurationManager.ConnectionStrings["CookBookConnectionString"].ConnectionString;

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Execute("dbo.InsertIngredientProcedure @Name,@Weight,@KcalPer100g,@PricePer100g,@Type", ingredient);
            }

        }
    }
}
