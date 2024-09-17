using DataAccessLayer.Contracts;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DataAccessLayer.Repositories
{
    public class RecipesRepository : IRecipeRepository
    {



        public event Action<string> OnError;

        private void ErrorOccured(string errorMessage)
        {
            if (OnError != null)
                OnError.Invoke(errorMessage);
        }

        public async Task AddRecipe(Recipe recipe)
        {
            try
            {
                string query = @"insert into Recipes 
                (Name,Description,Image,RecipeTypeId) 
                values (@Name, @Description, @Image, @RecipeTypeId)";

                using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
                {
                    await connection.ExecuteAsync(query, recipe);
                }


            }
            catch (SqlException ex)
            {
                string errorMessage = "";
                if (ex.Number == 2627)
                {

                    errorMessage = "That recipe already exists!";

                }
                else
                {
                    errorMessage = "Error happend in database:(";
                }

                ErrorOccured(errorMessage);
            }

            catch (Exception ex)
            {


                //2627
                string errorMessage = "An error happend while adding recipe";

                ErrorOccured(errorMessage);
                // Logger.LogError(ex.Message, DateTime.Now);
            }
        }

        public async Task<List<Recipe>> GetRecipes()
        {

            try
            {

                string query = "select Name,Description from Recipes";

                using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
                {

                    return (await connection.QueryAsync<Recipe>(query)).ToList();

                }

            }
            catch (Exception ex)
            {
                {


                    string errorMessage = "An error happend while getting recipes.";

                    ErrorOccured(errorMessage);
                    return new List<Recipe>();
                }

            }
        }
    }
}
