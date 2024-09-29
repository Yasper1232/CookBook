using DataAccessLayer.Contracts;
using DataAccessLayer.CustomQueryResults;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Models;
using Dapper;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DataAccessLayer.Repositories
{
    public class RecipeIngredientsRepository : IRecipeIngredientsRepository
    {
        public event Action<string> OnError;

        private void ErrorOccured(string errorMessage)
        {
            if (OnError != null)
                OnError.Invoke(errorMessage);
        }

        public async Task<List<RecipeIngredientWithNameAndAmount>> GetRecipeIngredients(int recipeId)
        {

            try
            {

                string query = @$"select i.Name, ri.IngredientId, ri.Amount
                                    from Ingredients i join RecipeIngredients ri
                                    on i.id = ri.IngredientId
                                    where ri.RecipeId = {recipeId}";

                using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
                {

                    return (await connection.QueryAsync<RecipeIngredientWithNameAndAmount>(query)).ToList();

                }

            }
            catch (Exception ex)
            {
                {


                    string errorMessage = "An error happend while getting recipe ingredients.";

                    ErrorOccured(errorMessage);
                    return new List<RecipeIngredientWithNameAndAmount>();
                }

            }
        }


        public async Task AddRecipeIngredient(RecipeIngredient recipeingredient)
        {
            try
            {
                string query = @"insert into RecipeIngredients 
                (RecipeId,IngredientId,Amount) 
                values (@RecipeId, @IngredientId, @Amount)";

                using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
                {
                    await connection.ExecuteAsync(query, recipeingredient);
                }


            }
           

            catch (Exception ex)
            {


                string errorMessage = "An error happend while adding recipe ingredient";

                ErrorOccured(errorMessage);
            }
        }

        
        public async Task DeleteRecipeIngredient(int ingredientId,int recipeId)
        {
            try
            {
                string query = @$"delete from RecipeIngredients where IngredientId ={ingredientId} and RecipeId={recipeId}";

                using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
                {
                    await connection.ExecuteAsync(query);
                }

            }
            catch (Exception ex)
            {

                string errormessage = "An error happend when deleting recipe ingredient";

                ErrorOccured(errormessage);

            }


        }

        public async Task EditRecipeIngredientAmount(RecipeIngredient recipeIngredient)
        {

            try
            {
                string query = $@"update RecipeIngredients
                             set
                             Amount =@Amount
                             where IngredientId=@IngredientId and RecipeId =@RecipeId";





                using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
                {
                    await connection.ExecuteAsync(query, recipeIngredient);
                }
            }
            catch (Exception ex)
            {



                string errorMessage = "An error happend while editing recipe ingredient Amount";

                ErrorOccured(errorMessage);
            }

        }
    }
}
