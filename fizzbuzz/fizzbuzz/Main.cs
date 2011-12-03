using System;

namespace fizzbuzz
{
	class MainClass
	{
		static void fizzbuzz()
		{
			for (int i =1 ; i <=100; i++)
			{
				printfizzbuzz(i);
			}
			
		}
				
		static void printfizzbuzz(int i)
		{
			if ( isDivisibleby(i,3) && isDivisibleby (i,5) )
				Console.WriteLine(" fizzbuzz number " + i);
			else if( isDivisibleby(i,3) )
				Console.WriteLine(" fizz number " + i);
			else if( isDivisibleby(i,5) )
				Console.WriteLine(" buzz number " + i);
			else
				Console.WriteLine(" number " + i);
		}
		
		static bool isDivisibleby(int i, int divider)
		{
			return ( (i% divider) == 0);
		}
		
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			fizzbuzz();
			Console.WriteLine("done fizz buzz");
		}
	}
}
