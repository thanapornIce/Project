using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Class2 : Order
    {
        public string Time;
        public string Phone;
        public Class2(string Time, string Phone)
        {
            this.Time = Time;
            this.Phone = Phone;
        }
    }
}
