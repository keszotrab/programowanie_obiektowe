using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Shop
    {
        public string Name
        {
            get => name;
            set => name = value;
        }

        private string name;
        private Person[]   people;
        private Product[]  products;

        

        public Shop(string name, Person[] people, Product[] products)
        {
            this.name = name;
            this.people = people;
            this.products = products;
        }

        public string Print()
        {
            Console.WriteLine("Shop: " + name);
            Console.WriteLine("-- People: --");
            foreach (var item in people)
            {
                if (item is Seller)
                    Console.WriteLine("        Seller: "+item.Print());

                if (item is Buyer)
                {
                    
                    Console.WriteLine("        Buyer: " + item.Print());
                }
            }
            Console.WriteLine("-- Products: --");
            foreach (var food in products)
            { 
                Console.WriteLine("        " + food.Print());
            }



                return "bass";
        }
    }
}
