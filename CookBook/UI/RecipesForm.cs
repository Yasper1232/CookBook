using DataAccessLayer.Contracts;
using DataAccessLayer.Repositories;
using DomainModel.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookBook.UI
{
    public partial class RecipesForm : Form
    {

        private readonly IRecipeTypesRepository _recipeTypesRepository;
        private readonly IRecipeRepository _recipeRepository;
        private readonly IServiceProvider _serviceProvider;
        public RecipesForm(IRecipeTypesRepository recipeTypesRepository, IServiceProvider
            serviceProvider, IRecipeRepository recipeRepository)
        {
            InitializeComponent();

            _recipeTypesRepository = recipeTypesRepository;
            _serviceProvider = serviceProvider;
            _recipeRepository = recipeRepository;
            _recipeRepository.OnError += OnErrorOccured;

        }

        private void OnErrorOccured(string errorMessage)
        {

            MessageBox.Show(errorMessage);

        }
        internal async void RefreshRecipeTypes()
        {

            RecipeTypesCbx.DataSource = await _recipeTypesRepository.GetRecipeTypes();

            RecipeTypesCbx.DisplayMember = "Name";
        }









        private void RecipesForm_Load(object sender, EventArgs e)
        {


            RefreshGridData();
            RefreshRecipeTypes();

        }

        private async void RefreshGridData()
        {

                RecipesGrid.DataSource = await _recipeRepository.GetRecipes();
        }

        private void AddRecipeTypeBtn_Click(object sender, EventArgs e)
        {
            RecipeTypesForm form = _serviceProvider.GetRequiredService<RecipeTypesForm>();

            //form.FormClosed += OnRecipeTypeFormClosed;


            form.FormClosed += (sender, e) => RefreshRecipeTypes();

            form.ShowDialog();

        }

        private async void AddRecipeBtn_Click(object sender, EventArgs e)
        {
            string message = "";

            if (NameTxt.Text == string.Empty)
            {
                message = "Please enter name to recipe";
                MessageBox.Show(message);

            }
            else if (DescriptionTxt.Text == string.Empty)
            {

                message = "Please enter description to recipe ";
                MessageBox.Show(message);

            }
            else
            {



                byte[] image = null;
                int recipeTypeId = ((RecipeType)RecipeTypesCbx.SelectedItem).Id;
                Recipe newRecipe = new Recipe(NameTxt.Text, DescriptionTxt.Text, image, recipeTypeId);

                await _recipeRepository.AddRecipe(newRecipe);


                RefreshRecipe();
                RefreshGridData();
            }
        }

        private void RefreshRecipe()
        {
            NameTxt.Text = string.Empty;
            DescriptionTxt.Text = string.Empty;
            RecipePictureBox.Image = null;

        }

        private void RecipesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
