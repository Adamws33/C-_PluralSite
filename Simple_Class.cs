using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Simple_Class
    {
        public Simple_Class(int Age, string BirthMonth)
        {
            this.Age = Age;
            this.BirthMonth = BirthMonth;
        }
        public int Age { get; set; }
        public string BirthMonth { get; set; }
    }
}
