using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomainModel.Models;
using DataAccessLayer;
using System.Runtime.InteropServices;

namespace CookBook.UI
{
    public partial class IngredientsForm : Form
    {

        readonly IngredientsDataAccess _db;

        public IngredientsForm()
        {
            InitializeComponent();
            _db = new IngredientsDataAccess();
        }

        private void AddToFridgeBtn_Click(object sender, EventArgs e)
        {

            Ingredient ingredient = new Ingredient(NameTxt.Text, TypeTxt.Text,
                WeightNum.Value, KcalPer100gNum.Value, PricePer100gNum.Value);


            _db.AddIngredient(ingredient);

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

        }

        private void IngredientsForm_Load(object sender, EventArgs e)
        {
            IngredientsDataAccess db = new IngredientsDataAccess();
            List<Ingredient> ingredients = db.GetIngredients();
            IngredientsGrid.DataSource = ingredients;
            RefreshGridData();
            CustomizeGridAppearance();



        }


        private void RefreshGridData()
        {

            IngredientsGrid.DataSource = _db.GetIngredients(); ;

        }


        private void CustomizeGridAppearance()
        {

            // IngredientsGrid.AutoSizeColumnsMode =
            //   DataGridViewAutoSizeColumnMode.Fill;

            IngredientsGrid.AutoGenerateColumns = false;

            DataGridViewColumn[] columns = new DataGridViewColumn[6];
            columns[0] = new DataGridViewTextBoxColumn() { DataPropertyName = "Id",Visible = false };
            columns[1] = new DataGridViewTextBoxColumn() { DataPropertyName = "Name",HeaderText = "Name" };
            columns[2] = new DataGridViewTextBoxColumn() {DataPropertyName = "Type",HeaderText = "Type" };
            columns[3] = new DataGridViewTextBoxColumn() { DataPropertyName = "Weight", HeaderText = "Weight" };
            columns[4] = new DataGridViewTextBoxColumn() { DataPropertyName = "PricePer100g", HeaderText = "Price(100g)" };
            columns[5] = new DataGridViewTextBoxColumn() { DataPropertyName = "KcalPer100g", HeaderText = "Kcal(100g)" };

            IngredientsGrid.Columns.Clear();
            IngredientsGrid.Columns.AddRange(columns);


        }


    }
}


