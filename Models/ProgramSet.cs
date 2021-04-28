using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Habit.Models
{
    public class ProgramSet
    {
        public int Id { get; set; }
        public string NameProgram { get; set; }
        public string TypeProgram { get; set; }
        public int DurationProgram { get; set; }
        public string Description { get; set; }
        public string Observation { get; set; }
    }
}
