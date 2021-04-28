using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Habit.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string NameProduct { get; set; }
        public string TypeProduct { get; set; }
        public int QuantityProduct { get; set; }
        public string Description { get; set; }
        public string Observation { get; set; }


    }
}