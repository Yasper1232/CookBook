using CookBook.Helpers;
using DataAccessLayer.Contracts;
using CookBook.Helpers;
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
using System.Reflection;
using System.Globalization;

namespace CookBook.UI
{
    public partial class RecipesForm : Form
    {

        private readonly IRecipeTypesRepository _recipeTypesRepository;
        private readonly IRecipeRepository _recipeRepository;
        private readonly IServiceProvider _serviceProvider;

        private Image _placeholderImage
        {
            get
            {
                var executingAssemblyLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                var imagePath = Path.Combine(executingAssemblyLocation, "Assets\\Images\\recipe_placeholder_image.png");
                return Image.FromFile(imagePath);
            }
        }
        private bool _isUserImageAdded = false;

        public RecipesForm(IRecipeTypesRepository recipeTypesRepository, IServiceProvider
            serviceProvider, IRecipeRepository recipeRepository)
        {
            InitializeComponent();

            _recipeTypesRepository = recipeTypesRepository;
            _serviceProvider = serviceProvider;
            _recipeRepository = recipeRepository;
            _recipeRepository.OnError += (message) => MessageBox.Show(message);

        }

        //private void OnErrorOccured(string errorMessage)
        //{

        //    MessageBox.Show(errorMessage);

        //}
        internal async void RefreshRecipeTypes()
        {

            RecipeTypesCbx.DataSource = await _recipeTypesRepository.GetRecipeTypes();

            RecipeTypesCbx.DisplayMember = "Name";
        }

        private void RecipesForm_Load(object sender, EventArgs e)
        {

            CustomizeGridAppearance();
            RefreshRecipesGrid();
            RefreshRecipeTypes();
            RecipePictureBox.Image = _placeholderImage;
            RecipePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private async void RefreshRecipesGrid()
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
            if (!IsValid())
                return;

            byte[] image = null;
            if (_isUserImageAdded)
            {
                image = ImageHelper.ConvertToDbImage(RecipePictureBox.ImageLocation);
            }
            int recipeTypeId = ((RecipeType)RecipeTypesCbx.SelectedItem).Id;
            Recipe newRecipe = new Recipe(NameTxt.Text, DescriptionTxt.Text, image, recipeTypeId);

            await _recipeRepository.AddRecipe(newRecipe);


            ClearAllFields();
            RefreshRecipesGrid();

        }

        private void ClearAllFields()
        {
            NameTxt.Text = string.Empty;
            DescriptionTxt.Text = string.Empty;
            RecipePictureBox.ImageLocation = string.Empty;
            RecipePictureBox.Image = _placeholderImage;
            _isUserImageAdded = false;


        }

        private void RecipesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private bool IsValid()
        {

            bool IsValid = true;
            string message = "";

            if (string.IsNullOrEmpty(NameTxt.Text))
            {
                IsValid = false;
                message += "Please enter name.\n\n";

            }


            if (string.IsNullOrEmpty(DescriptionTxt.Text))
            {
                IsValid = false;
                message += "Please enter description.\n\n";

            }


            if (!IsValid)
                MessageBox.Show(message, "Form not valid!");


            return IsValid;

        }

        private void RecipePictureBox_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Title = "Please select an image",
                Filter = "PNG|*.png|JPG|*jpg|JPEG|*jpeg",
                Multiselect = false
            })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    RecipePictureBox.ImageLocation = openFileDialog.FileName;
                    _isUserImageAdded = true;

                }


            }
        }

        private void ClearAllFieldsBtn_Click(object sender, EventArgs e)
        {
            ClearAllFields();

        }

        private void FillFormForEdit(Recipe clickedRecipe)
        {
            //_RecipeToEditId = clickedRecipe.Id;

            NameTxt.Text = clickedRecipe.Name;
            


           
        }
        private async void RecipesGrid_CellClick(object sender, DataGridViewCellEventArgs e)
            {
            if(e.RowIndex>=0 && RecipesGrid.CurrentCell is DataGridViewButtonCell)
            {
                Recipe clickedRecipe = (Recipe)RecipesGrid.Rows[e.RowIndex].DataBoundItem;

                if (RecipesGrid.CurrentCell.OwningColumn.Name == "DeleteBtn")
                {
                    await _recipeRepository.DeleteRecipe(clickedRecipe);
                    RefreshRecipesGrid();
                }else if(RecipesGrid.CurrentCell.OwningColumn.Name == "EditBtn")
                {
                    FillFormForEdit(clickedRecipe);
                }
            }
            }

        private void CustomizeGridAppearance()
        {
            RecipesGrid.AutoGenerateColumns = false;

            DataGridViewColumn[] columns = new DataGridViewColumn[6];
            columns[0] = new DataGridViewTextBoxColumn() { DataPropertyName = "Id", Visible = false };
            columns[1] = new DataGridViewTextBoxColumn() { DataPropertyName = "Name", HeaderText = "Name" };
            columns[2] = new DataGridViewTextBoxColumn() { DataPropertyName = "Type", HeaderText = "Type" };
            columns[3] = new DataGridViewTextBoxColumn() { DataPropertyName = "Description", HeaderText = "Description" };
            columns[4] = new DataGridViewButtonColumn()
            {

                Text = "Edit",
                Name = "EditBtn",
                HeaderText = "",
                UseColumnTextForButtonValue = true



            };
            columns[5] = new DataGridViewButtonColumn()
            {
                Text = "Delete",
                Name = "DeleteBtn",
                HeaderText = "",
                UseColumnTextForButtonValue = true

            };
            RecipesGrid.Columns.Clear();
            RecipesGrid.Columns.AddRange(columns);

        }
    }

    
}
