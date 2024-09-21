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
using DataAccessLayer.CustomQueryResults;

namespace DataAccessLayer.Repositories
{
    public class RecipesRepository : IRecipeRepository
    {

        public async Task DeleteRecipe(Recipe recipe)
        {
            try
            {
                string query = @$"delete from Recipes where id={recipe.Id}";

                using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
                {
                    await connection.ExecuteAsync(query, recipe);
                }

            }
            catch (Exception ex) {

                string errormessage = "An error happend when deleting an REcipe";

                ErrorOccured(errormessage);

            }


        }

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

        public async Task<List<RecipeWithType>> GetRecipes()
        {

            try
            {

                string query = @"select r.Id,r.Name,r.Description,rt.Name as 'Type'
                                 from
                                 Recipes as r join RecipeTypes as rt
                                 on r.RecipeTypeId = rt.Id";

                using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
                {

                    return (await connection.QueryAsync<RecipeWithType>(query)).ToList();

                }

            }
            catch (Exception ex)
            {
                {


                    string errorMessage = "An error happend while getting recipes.";

                    ErrorOccured(errorMessage);
                    return new List<RecipeWithType>();
                }

            }
        }
    }
}
