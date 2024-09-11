using Dapper;
using DataAccessLayer.Contracts;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccessLayer.Repositories
{
    public class IngredientsRepository : IIngredientsRepository
    {
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

            }
            catch (Exception ex) 
            {

                

                string errorMessase = "An error happend while adding ingredient";
                //TODO :  Show error message to user 

               // Logger.LogError(ex.Message, DateTime.Now);
            }
       
        }

        public async Task<List<Ingredient>> GetIngredients(string? name="")
        {
            string query = "select * from Ingredients";
            if(!string.IsNullOrEmpty(name))
                query+= $" where Name like '{name}%'";

            //string delay = " WAITFOR DELAY '00:00:02'";
            //query += delay;

            using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
            {
                return (await connection.QueryAsync<Ingredient>(query)).ToList();
            }
        }


        public async Task DeleteIngredient(Ingredient ingredient)
        {
            string query = @$"delete from Ingredients where Id={ingredient.Id}";

            using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
            {
                await connection.ExecuteAsync(query, ingredient);
            }
        }

        public async Task EditIngredient(Ingredient ingredient)
        {
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


    }
}