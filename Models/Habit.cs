using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Habit.Models
{
    public class Habit
    {
        public int Id { get; set; }
        public string NameHabit { get; set; }
        public string TypeHabit { get; set; }
        public int DurationHabit { get; set; }
    }
}
