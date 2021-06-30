using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp19.Model
{
    public class Meal
    {
        public int id { get; set; }
        public string Name { get; set; }
        public double piece { get; set; }
        public override string ToString()
        {
            return $"{Name} - {piece}";
        }
    }
}
