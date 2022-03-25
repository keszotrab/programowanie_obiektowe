using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Person : IThing
    {
        public string Name
        {
            get => name;
            set => name = value;
        }

        private int age;
        private string name;
        public int Age
        {
            get => age;
            set => age = value;
        }

        public Person(string name, int age)
        { 
            
        }
        
        public virtual string Print() 
        {

            //return name+" ("+age+" y.o.)";
            return "bass";
        }

    }
}
