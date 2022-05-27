using System;
using System.Threading;


class Prime
{
    int NextPrimeNumber(int number, bool b)
    {




        return number;
    }



    public static bool isPrimeNumber(int number)
    {
        if (number < 2)
        {
            return false;
        }
        if (number == 2 || number == 3)
        {
            return true;
        }
        if (number % 2 == 0)
        {
            return true;
        }

        double limit = Math.Floor(Math.Sqrt(number));
        int d = 4;
        for (int i = 5; i <= limit; i += d)
        {
            if (number % i == 0)
            {
                return false;
            }
            d = 6 - d;
        }
        return true;
    }

    

}






public class Program
{
     bool isPrimeNumber(int number)
     {
        if (number < 2)
        {
            return false;
        }
        if (number == 2 || number == 3)
        {
            return true;
        }
        if (number % 2 == 0)
        {
            return false;
        }

        double limit = Math.Floor(Math.Sqrt(number));
        int d = 4;
        for (int i = 5; i <= limit; i += d)
        {
            if (number % i == 0)
            {
                return false;
            }
            d = 6 - d;
        }
        return true;
     }




        public static void Main(string[] args)
	    {
        int lastPrimeNumber = 2;
        bool a = true;
        int turn = 1;
        bool On = true;

		Thread thread1 = new Thread(() =>
		{
            while (a == true)
            { 
                if(turn == 1)
                {
                    bool On = true;
                    while (On)
                    {
                        lastPrimeNumber++;
                        if (Prime.isPrimeNumber(lastPrimeNumber))
                        {
                            Console.WriteLine(lastPrimeNumber);
                            On = false;
                            turn = 2;
                        }
                    }
                }
            }
		});

        Thread thread2 = new Thread(() =>
        {
            while (a == true)
            {
                if (turn == 2)
                {
                    bool On = true;
                    while (On)
                    {
                        lastPrimeNumber++;
                        if (Prime.isPrimeNumber(lastPrimeNumber))
                        {
                            Console.WriteLine(lastPrimeNumber);
                            On = false;
                            turn =  3;
                        }
                    }
                }
            }
        });

        Thread thread3 = new Thread(() =>
        {
            while (a == true)
            {
                if (turn == 3)
                {
                    bool On = true;
                    while (On)
                    {
                        lastPrimeNumber++;
                        if (Prime.isPrimeNumber(lastPrimeNumber))
                        {
                            Console.WriteLine(lastPrimeNumber);
                            On = false;
                            turn = 4;
                        }
                    }
                }
            }
        });


        Thread thread4 = new Thread(() =>
        {
            while (a == true)
            {
                if (turn == 4)
                {
                    bool On = true;
                    while (On)
                    {
                        lastPrimeNumber++;
                        if (Prime.isPrimeNumber(lastPrimeNumber))
                        {
                            Console.WriteLine(lastPrimeNumber);
                            On = false;
                            turn = 1;
                        }
                    }
                }
            }
        });
        
        thread1.Start();
        thread2.Start();
        thread3.Start();
        thread4.Start();
        //albo zrobic cos jak 1 thread wylicza liczby pierwsze a reszta wypisuje


    }
}












