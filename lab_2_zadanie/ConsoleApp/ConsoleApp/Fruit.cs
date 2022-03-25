using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    internal class Fruit : Product
    {
        private int count;
        private int Count {
            get => count;
            set => count = value;
        }

        public Fruit(string name, int count) : base(name)
        {
            this.Name = name;
            this.count = count;
        }

        public override string Print() 
        {
            return Name+" ("+count+" fruits)";
        }
    }
}
