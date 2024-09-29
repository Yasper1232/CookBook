using DataAccessLayer.Contracts;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookBook.UI
{
    public partial class RecipeIngredientsForm : Form
    {

        private readonly IRecipeIngredientsRepository _recipeIngredientsRepository;
        private readonly IIngredientsRepository _ingredientsRepository;

        public int RecipeId { get; set; }
        public RecipeIngredientsForm(IRecipeIngredientsRepository recipeIngredientsRepository
            , IIngredientsRepository ingredientsRepository)
        {
            InitializeComponent();
            _recipeIngredientsRepository = recipeIngredientsRepository;
            _ingredientsRepository = ingredientsRepository;
        }

        private void RecipeIngredientsForm_Load(object sender, EventArgs e)
        {
            
            RefreshRecipeIngredients();

        }


        private async void RefreshRecipeIngredients()
        {

            RecipeIngredientslbx.DataSource = await
                _recipeIngredientsRepository.GetRecipeIngredients(RecipeId);
            RecipeIngredientslbx.DisplayMember = "Name";
        }

    }
}
