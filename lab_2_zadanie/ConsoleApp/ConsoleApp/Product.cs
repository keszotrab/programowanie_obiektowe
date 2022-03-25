using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Product
    {

        private string name;
        public string Name
        {
            get => name;
            set => name = value;
        }

        
        public Product(string name)
        {
            this.Name = name;
            
        }
        public virtual string Print()
        {

            return name ;
        }


    }
}
