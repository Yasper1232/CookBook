using CookBook.Helpers;
using CookBook.Services;
using CookBook.ViewModels;
using DomainModel.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookBook.UI
{

    public enum RecipeAvailability { Available,Unavailable};
    public partial class FoodManagerForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        FoodManagerCache _foodManagerCache;


        public FoodManagerForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            _serviceProvider = serviceProvider;
            _foodManagerCache = _serviceProvider.GetRequiredService<FoodManagerCache>();

            RecipesLbx.OnSelectedItemChanged += OnSelectedRecipeChanged;
        }

        private void OnSelectedRecipeChanged(ListBoxItemVM selectedItem)
        {

            Recipe selectedRecipe = (Recipe)selectedItem.Item;
            var ingredients = _foodManagerCache.GetIngredients(selectedRecipe.Id);
            List<ListBoxItemVM> dataSource = new List<ListBoxItemVM>();

            decimal totalKcal = 0;
            decimal totalPrice = 0;



            foreach (RecipeIngredientExtendedVM ingredient in ingredients)
            {
                ListBoxItemVM item = new ListBoxItemVM(ingredient, ingredient.NameWithMissingAmount);
                dataSource.Add(item);

                totalKcal += (ingredient.KcalPer100g / 100) * ingredient.Amount;
                totalPrice += (ingredient.PricePer100g) / 100 * ingredient.Amount;
            }
            IngredientsLbx.SetDataSource(dataSource);

            DescriptionTxt.Text = selectedRecipe.Description;
            if (selectedRecipe.Image != null)
                RecipePicture.Image = ImageHelper.ConvertFromDbImage(selectedRecipe.Image);
            else RecipePicture.Image = ImageHelper.PlaceholderImage;

            TotalKcalLbl.Text = totalKcal.ToString();
            TotalPriceLbl.Text = totalPrice.ToString();
        }

        private async void FoodManagerForm_Load(object sender, EventArgs e)
        {
            await _foodManagerCache.RefreshData();

            RecipePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            
            RefreshRecipesLbx(RecipeAvailability.Available);


        }
        private void AvailableBtn_Click(object sender, EventArgs e)
        {

            if (RecipesLbx.SelectedItem == null)
            {
                RightPanel.Visible = false;
            }
            RefreshRecipesLbx(RecipeAvailability.Available);

          
        }

        private void UnvailableBtn_Click(object sender, EventArgs e)
        {
            RefreshRecipesLbx(RecipeAvailability.Unavailable);
            RightPanel.Visible = true;

        }


        private void RefreshRecipesLbx(RecipeAvailability recipeAvailability)
        {
            List<ListBoxItemVM> dataSource = new List<ListBoxItemVM>();
            List<Recipe> recipes = new List<Recipe>();
            if (recipeAvailability == RecipeAvailability.Available)
            {
                recipes = _foodManagerCache.AvailableRecipes;


                PrepareFoodBtn.Visible = true;
                CreateShopingListBtn.Visible = false;
            }
            else if (recipeAvailability == RecipeAvailability.Unavailable)
            {
                recipes = _foodManagerCache.UnavailableRecipes;
                PrepareFoodBtn.Visible = false;
                CreateShopingListBtn.Visible = true;

            }

            foreach (Recipe recipe in recipes)
            {

                ListBoxItemVM item = new ListBoxItemVM(recipe, recipe.Name);
                dataSource.Add(item);

            }

            RecipesLbx.SetDataSource(dataSource);

            if (RecipesLbx.SelectedItem == null)
                RightPanel.Visible = false;
           



        }

        private async void PrepareFoodBtn_Click(object sender, EventArgs e)
        {

            if (RecipesLbx.SelectedItem == null)
            return;
            Recipe selectedRecipe = RecipesLbx.SelectedItem.Item as Recipe;

            await _foodManagerCache.PrepareFood(selectedRecipe);

            await _foodManagerCache.RefreshData();
            RefreshRecipesLbx(RecipeAvailability.Available);




        }

        private void RecipesLbx_Load(object sender, EventArgs e)
        {

           

        }
    }
}