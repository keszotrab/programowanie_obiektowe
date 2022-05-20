using System;
using System.Threading;








/*
	public static string Whatever_string(string a, string b)
	{
		string bambam = a + " " + b;
		return bambam;
		
	}
*/


class bass 
{ 




}
//public delegate string parada(string a, string b);

public delegate void Del(string message);



public class Program
	{
		public static void Main(string[] args)
		{
			string x = "cykcyk";
			string y = "bambam";



			Thread thread = new Thread(() =>
			{
				for (int i = 1; i <= 5; ++i)
				{
					Console.WriteLine("Iteration: " + i);
					Thread.Sleep(1000); // sleeps created thread for 1 second
			}
			});

			thread.Start();




			Thread babumts = new Thread(() =>
			{
				Console.WriteLine("asd");
			});
			babumts.Start();


			Thread skraaa = new Thread(() =>
			{
				Console.WriteLine("sadasd");
			});
			skraaa.Start();

			
		
		
		}

		





	}
