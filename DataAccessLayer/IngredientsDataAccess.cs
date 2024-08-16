using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
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

            string query = @"insert into Ingredients (Name,Weight,KcalPer100g,PricePer100g,Type)
                            values (@Name,@Weight,@KcalPer100g,@PricePer100g,@Type)";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, ingredient);
            }

            

        }


        public List<Ingredient> GetIngredients()
        {

            string connectionString = ConfigurationManager.ConnectionStrings["CookBookConnectionString"].ConnectionString;

            string query = "select * from Ingredients";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<Ingredient> ingredients = connection.Query<Ingredient>(query).ToList();
                return ingredients;
            }



        }


    }
}
