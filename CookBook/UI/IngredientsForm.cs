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

namespace CookBook.UI
{
    public partial class IngredientsForm : Form
    {
        public IngredientsForm()
        {
            InitializeComponent();
        }

        private void AddToFridgeBtn_Click(object sender, EventArgs e)
        {

            List<Ingredient> ingredients = new List<Ingredient>();

            Ingredient i1 = new Ingredient { Name = "apple", Type = "fruit", Weight = 500, KcalPer100g = 50m, PricePer100g = 5 };
            Ingredient i2 = new Ingredient { Name = "banana", Type = "fruit", Weight = 90, KcalPer100g = 20m, PricePer100g = 2 };
            Ingredient i3 = new Ingredient { Name = "orange", Type = "fruit", Weight = 500, KcalPer100g = 507m, PricePer100g = 3.4m };

            ingredients.Add(i1);
            ingredients.Add(i2);
            ingredients.Add(i3);


            string message = "";
//            foreach(Ingredient i in ingredients)
//            {
//               message += $@"
//{i.Name} {i.Type} {i.Weight} {i.KcalPer100g} {i.PricePer100g} ";
                
//            }
//            MessageBox.Show(message);

            ingredients.ForEach(i => { message += $@"
{i.Name} {i.Type} {i.Weight} {i.KcalPer100g} {i.PricePer100g} "; }) ;

            MessageBox.Show(message);

        }
    }
}


