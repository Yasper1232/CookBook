﻿using DataAccessLayer.CustomQueryResults;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Contracts
{
    public interface IRecipeRepository
    {
        public event Action<string> OnError;

        public Task AddRecipe(Recipe recipe);

        public Task<List<RecipeWithType>> GetRecipes();

        public Task DeleteRecipe(Recipe recipe);
    }
}
