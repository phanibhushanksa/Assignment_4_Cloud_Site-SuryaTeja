using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_4_Cloud_Site.Models
{
    public class Food
    {
        [Key]
        public int FdcId { get; set; }
        public string DataType { get; set; }
        public string Description { get; set; }
        public int FoodCategory { get; set; }
    }
    public class Nutrient
    {
        [Key]
        public int NutriId { get; set; }
        public int FdcId { get; set; }
        public string NutrientName { get; set; }
        public int Amount { get; set; }
        public List<Nutrient> CalorieNutrient { get; set; }
    }
    public class Calorie
    {
        [Key]
        public int CalId { get; set; }
        public int FdcId { get; set; }
        public string ProteinValue { get; set; }
        public string FatValue { get; set; }
        public int CarbohydrateValue { get; set; }
        public List<Nutrient> FoodNutrient { get; set; }
    }
}
 