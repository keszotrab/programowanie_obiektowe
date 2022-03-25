using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Meat : Product
    {
        private double weight;
        private double Weight
        {
            get => weight;
            set => weight = value;
        }

        public Meat(string name, double weight) : base(name)
        {
            this.Name = name;
            this.weight = weight;
        }

        public override string Print()
        {
            return Name + " (" + weight + " kg)";
        }
    }
}
