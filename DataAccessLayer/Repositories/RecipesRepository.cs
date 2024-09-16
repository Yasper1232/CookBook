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
          
            catch (Exception ex)
            {



                string errorMessage = "An error happend while adding recipe";

                ErrorOccured(errorMessage);
                // Logger.LogError(ex.Message, DateTime.Now);
            }
        }

        public Task<List<Recipe>> GetRecipes()
        {
            throw new NotImplementedException();
        }
    }
}
