using System;

namespace bitmanipulation
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			
			byte b = Convert.ToByte(20);
			Console.WriteLine(string.Format("{0}, {1}",
			                                Convert.ToByte(20), 
			                                Convert.ToString(b,2)
			                                )
			                  );
		//	a = 20 << 0x1;
			Console.WriteLine(string.Format("2x{0} is {1}",20,  20 << 1));
			Console.WriteLine(string.Format("{0}/2 is {1}",20, 20 >>1));
			for(int i =1; i<33; i++)
				Console.WriteLine(string.Format("{0}x2power{1} is {2}", 20, i, 20 << i));
			for(int i =1; i<33; i++)
				Console.WriteLine(string.Format("{0}/(2power{1}) is {2}", 20, i, 20 << i));
			Console.WriteLine("Overthrow shifting is round robin back MOD circle");
			                  
		}
	}
}
