﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomainModel.Models;
using System.Runtime.InteropServices;
using DataAccessLayer.Repositories;
using DataAccessLayer.Contracts;

namespace CookBook.UI
{
    public partial class IngredientsForm : Form
    {

        readonly IIngredientsRepository _ingredientsRepository;

        private int _ingredientToEditId;
        public IngredientsForm(IIngredientsRepository ingredientsRepository)
        {
            InitializeComponent();
            _ingredientsRepository = ingredientsRepository;
            _ingredientsRepository.OnError += OnErrorOccured;
        }

        private void OnErrorOccured(string errorMessage)
        {

            MessageBox.Show(errorMessage);

        }

        private async void AddToFridgeBtn_Click(object sender, EventArgs e)
        {
            if (!IsValid())
                return;

            Ingredient ingredient = new Ingredient(NameTxt.Text, TypeTxt.Text,
                WeightNum.Value, KcalPer100gNum.Value, PricePer100gNum.Value);

            AddToFridgeBtn.Enabled = false;
            await _ingredientsRepository.AddIngredient(ingredient);
            AddToFridgeBtn.Enabled = true;

            ClearAllFields();
            RefreshGridData();
        }


        private void ClearAllFields()
        {

            NameTxt.Text = string.Empty;
            TypeTxt.Text = string.Empty;
            WeightNum.Value = 1;
            KcalPer100gNum.Value = 0;
            PricePer100gNum.Value = 0;
            SearchTxt.Text = string.Empty;
        }

        private void IngredientsForm_Load(object sender, EventArgs e)
        {
            //IngredientsRepository db = new IngredientsRepository();
            //List<Ingredient> ingredients = db.GetIngredients();
            //IngredientsGrid.DataSource = ingredients;
            RefreshGridData();
            CustomizeGridAppearance();

            AddToFridgeBtn.Visible = true;
            EditIngredientBtn.Visible = false;

        }


        private async void RefreshGridData()
        {

            IngredientsGrid.DataSource = await _ingredientsRepository.GetIngredients(SearchTxt.Text);

        }


        private void CustomizeGridAppearance()
        {

            // IngredientsGrid.AutoSizeColumnsMode =
            //   DataGridViewAutoSizeColumnMode.Fill;

            IngredientsGrid.AutoGenerateColumns = false;

            DataGridViewColumn[] columns = new DataGridViewColumn[8];
            columns[0] = new DataGridViewTextBoxColumn() { DataPropertyName = "Id", Visible = false };
            columns[1] = new DataGridViewTextBoxColumn() { DataPropertyName = "Name", HeaderText = "Name" };
            columns[2] = new DataGridViewTextBoxColumn() { DataPropertyName = "Type", HeaderText = "Type" };
            columns[3] = new DataGridViewTextBoxColumn() { DataPropertyName = "Weight", HeaderText = "Weight" };
            columns[4] = new DataGridViewTextBoxColumn() { DataPropertyName = "PricePer100g", HeaderText = "Price(100g)" };
            columns[5] = new DataGridViewTextBoxColumn() { DataPropertyName = "KcalPer100g", HeaderText = "Kcal(100g)" };

            columns[6] = new DataGridViewButtonColumn()
            {
                Text = "Delete",
                Name = "DeleteBtn",
                HeaderText = "",
                UseColumnTextForButtonValue = true
            };

            columns[7] = new DataGridViewButtonColumn()
            {

                Text = "Edit",
                Name = "EditBtn",
                HeaderText = "",
                UseColumnTextForButtonValue = true

            };

            IngredientsGrid.Columns.Clear();
            IngredientsGrid.Columns.AddRange(columns);


        }
        private void ClearAllFieldsButton_Click(object sender, EventArgs e)
        {
            ClearAllFields();

            AddToFridgeBtn.Visible = true;

            EditIngredientBtn.Visible = false;
            _ingredientToEditId= 0;

        }

        private async void SearchTxt_TextChanged(object sender, EventArgs e)
        {

            int lengthBeforePause = SearchTxt.Text.Length;

            await Task.Delay(300);

            int lengthAfterPause = SearchTxt.Text.Length;

            if (lengthBeforePause == lengthAfterPause)
                RefreshGridData();


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
            //else if(_ingredientToEditId==0)
            //{


            //    List<Ingredient> allIngredients = (List<Ingredient>)
            //        IngredientsGrid.DataSource;


            //    foreach (Ingredient ingredient in allIngredients)
            //    {
            //        if (ingredient.Name.ToLower() == NameTxt.Text.ToLower())
            //        {

            //            MessageBox.Show("That ingredient already exists!, Form not valid!");
            //            return false;
            //        }
            //    }
            //}

            if (string.IsNullOrEmpty(TypeTxt.Text))
            {
                IsValid = false;
                message += "Please enter type.\n\n";

            }

            if (WeightNum.Value <= 0)
            {
                IsValid = false;
                message += "Weight must be greater than 0.\n\n";

            }

            if (KcalPer100gNum.Value < 0)
            {
                IsValid = false;
                message += "Kcal must be greater than or equal to 0.\n\n";

            }
            if (PricePer100gNum.Value <= 0)
            {
                IsValid = false;
                message += "Price must be greater than 0.\n\n";

            }

            if (!IsValid)
                MessageBox.Show(message, "Form not valid!");


            return IsValid;

        }

        private async void IngredientsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex >= 0 && IngredientsGrid.CurrentCell is DataGridViewButtonCell)
            {
                Ingredient clickedIngredient = (Ingredient)IngredientsGrid.Rows[e.RowIndex].DataBoundItem;


                if (IngredientsGrid.CurrentCell.OwningColumn.Name == "DeleteBtn")
                {

                    await _ingredientsRepository.DeleteIngredient(clickedIngredient);
                    RefreshGridData();

                }
                else if ((IngredientsGrid.CurrentCell.OwningColumn.Name == "EditBtn"))
                {

                    FillFormForEdit(clickedIngredient);
                }



            }

        }

        private void FillFormForEdit(Ingredient clickedIngredient)
        {
            _ingredientToEditId = clickedIngredient.Id;

            NameTxt.Text = clickedIngredient.Name;
            TypeTxt.Text = clickedIngredient.Type;
            WeightNum.Value = clickedIngredient.Weight;
            PricePer100gNum.Value = clickedIngredient.PricePer100g;
            KcalPer100gNum.Value = clickedIngredient.KcalPer100g;


            AddToFridgeBtn.Visible = false;
            EditIngredientBtn.Visible = true;
        }

        private async void EditIngredientBtn_Click(object sender, EventArgs e)
        {

            if (!IsValid())
            {
                return;
            }
                Ingredient ingredient = new Ingredient(NameTxt.Text,TypeTxt.Text,WeightNum.Value,KcalPer100gNum.Value,PricePer100gNum.Value,_ingredientToEditId);

                await _ingredientsRepository.EditIngredient(ingredient);
                ClearAllFields();
                RefreshGridData();

            EditIngredientBtn.Visible = false;
            AddToFridgeBtn.Visible = true;

            _ingredientToEditId = 0;
            

        }
    }
}


