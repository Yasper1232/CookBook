﻿using Dapper;
using DataAccessLayer.Contracts;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccessLayer.Repositories
{

    public class IngredientsRepository : IIngredientsRepository
    {

        public event Action<string> OnError;

        public event Action<string> OnSuccess;

        public async Task AddIngredient(Ingredient ingredient)
        {

            try
            {
                string query = @"insert into Ingredients 
                (Name, Weight, KcalPer100g, PricePer100g, Type) 
                values (@Name, @Weight, @KcalPer100g, @PricePer100g, @Type)";

                using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
                {
                    await connection.ExecuteAsync(query, ingredient);
                }
            }
            catch (SqlException ex)
            {
                string errorMessage = "";

                if (ex.Number == 2627)
                {
                    errorMessage = "That Ingredient already exists.";

                }
                else
                {

                    errorMessage = "An error happend in the database";


                }

                ErrorOccured(errorMessage);

            }
            catch (Exception ex) 
            {

                

                string errorMessage = "An error happend while adding ingredient";

                ErrorOccured(errorMessage);
                // Logger.LogError(ex.Message, DateTime.Now);
            }

        }


        private void ErrorOccured(string errorMessage)
        {
            if(OnError != null)
                OnError.Invoke(errorMessage);
        }

        private void SuccessfullyCompleted(string successMessage)
        {
            if(OnSuccess!= null) OnSuccess.Invoke(successMessage);
        }


        public async Task<List<Ingredient>> GetIngredients(string? name = "")
        {

            try {
                string query = "select * from Ingredients";
                if (!string.IsNullOrEmpty(name))
                    query += $" where Name like '{name}%'";

                //string delay = " WAITFOR DELAY '00:00:02'";
                //query += delay;

                using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
                {
                    return (await connection.QueryAsync<Ingredient>(query)).ToList();
                }
            }
            catch (Exception ex)
            {



                string errorMessage = "An error happend while getting ingredients.";

                ErrorOccured(errorMessage);
                return new List<Ingredient>();
            }
        }


        public async Task DeleteIngredient(Ingredient ingredient)
        {
            try {
                string query = @$"delete from Ingredients where Id={ingredient.Id}";

                using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
                {
                    await connection.ExecuteAsync(query, ingredient);
                }
            }catch(Exception ex)
            {



                string errorMessage = "An error happend while deleting ingredient";

                ErrorOccured(errorMessage);
            }


        }

        public async Task EditIngredient(Ingredient ingredient)
        {

            try {
                string query = @"update Ingredients
                             set
                             Name = @Name,
                             Weight = @Weight,
                             KcalPer100g = @KcalPer100g,
                             PricePer100g = @PricePer100g,
                             Type = @Type
                             where Id = @Id";





                using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
                {
                    await connection.ExecuteAsync(query, ingredient);
                }
            }
            catch (Exception ex)
            {



                string errorMessage = "An error happend while editing ingredient";

                ErrorOccured(errorMessage);
            }

        }

        public async Task UpdateAmounts(List<RecipeIngredient> recipeIngredients)
        {
            string query = "";

            foreach (RecipeIngredient recipeIngredient in recipeIngredients)
            {

                string formattedAmount = recipeIngredient.Amount.ToString("0.00",CultureInfo.InvariantCulture);
                query += $@"update Ingredients
                             set
                             Weight = Weight - {formattedAmount}
                             where Id = {recipeIngredient.IngredientId} ";
            }



                try
                {

                using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
                {

                        await connection.ExecuteAsync(query);
                    SuccessfullyCompleted("Successfully Completed !");
                }

            }
            catch (Exception ex)
            {



                string errorMessage = "An error happend while updating ingredient";

                ErrorOccured(errorMessage);
            }



        }
    }
}