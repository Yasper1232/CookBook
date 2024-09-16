using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DomainModel.Models
{
    public class Recipe
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public int RecipeTypeId { get; set; }

        public Recipe(string name,string description, byte[]? image,int recipeTypeId) 
        {
            Name = name;
            Description = description;
            Image = image;
            RecipeTypeId = recipeTypeId;


        }

        public Recipe() { }

    }

    

}
