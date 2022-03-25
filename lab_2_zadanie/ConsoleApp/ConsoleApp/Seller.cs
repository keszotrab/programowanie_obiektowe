using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Seller : Person
    {
        

        internal Seller(string name, int age) : base(name, age)
        {
            this.Name = name;
            this.Age = age;

        }

        public override string Print()
        {
            return this.Name + " (" + this.Age + " y.o.)";
        }

    }
}
