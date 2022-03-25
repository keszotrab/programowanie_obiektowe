using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Buyer : Person
    {

        public List<Product> tasks = new List<Product>();

        

        internal Buyer(string name, int age) : base(name, age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string Print()
        {
            string temp = "";
            foreach (var item in tasks)
            {
                temp = temp + "\n                " + item.Print();
            }
            
            return this.Name + " (" + this.Age + " y.o.)"+ "\n                --Products: -- " + temp;
            
        }
        public void AddProduct(Product product)
        {
            tasks.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            tasks.Remove(product);
        }


    }
}

