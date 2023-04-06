using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Class1 : Order
    {
        public string Name;
        public string Lastname;
        public string Food;

        public Class1(string Name, string Lastname, string Food)
        {
            this.Name = Name;
            this.Lastname = Lastname;
            this.Food = Food;
        }
    }
}
