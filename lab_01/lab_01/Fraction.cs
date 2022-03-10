using System;
using System.Collections.Generic;
using System.Text;

namespace lab_01
{
    class Fraction : IEquatable<int>, IComparable<int>
    {


        private int counter;
        public int Counter 
        {
            get => counter;
            //set => counter = value;
        }

        private int denominator;
        private int Denominator
        {
            get => denominator;
            //set => denominator = value;
        }



        public bool Equals([AllowNull] int a)
        {
            return true;
        }

        public int CompareTo([AllowNull] int a) 
        {
            int result =2;
            return result; 
        }



        public Fraction()
        {
            
        }

        public Fraction(int a, int b)
        {

        }



        public Fraction(Fraction Whatever) // przyjmuje obiekt tego samego typu co kopiowana klasa
        {
            this.counter = Whatever.counter;
            this.denominator = Whatever.denominator;
        }

        /*
        public string ToString() 
        {
            string c ="coklwiek";

            return c ;
        }
        */

        public static Fraction operator +(Fraction a) => a;


        public static Fraction operator -(Fraction a) => new Fraction(-a.counter, a.denominator);

        public static Fraction operator +(Fraction a, Fraction b)
            => new Fraction(a.counter * b.denominator + b.counter * a.denominator, a.denominator * b.denominator);

        public static Fraction operator -(Fraction a, Fraction b)
            => a + (-b);

        public static Fraction operator *(Fraction a, Fraction b)
            => new Fraction(a.counter * b.counter, a.denominator * b.denominator);

        public static Fraction operator /(Fraction a, Fraction b)
        {
            if (b.counter == 0)
            {
                throw new DivideByZeroException();
            }
            return new Fraction(a.counter * b.denominator, a.denominator * b.counter);
        }






    }

    internal class AllowNullAttribute : Attribute
    {
    }
}
