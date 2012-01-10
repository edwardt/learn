using System;

namespace bitmanipulation
{
	// positional representation of x in base b
	// x = xn bn + xn-1 bn-1 + ... + x1 b1 + x0 b0.
	
	
	// NAME	   		OPERATOR		PURPOSE										Meaning
	// bitwise NOT	~x	    		Flip all the bits of x						Negation?
	// bitwise AND	x & y			Take the AND of each pair of bits			Intersection of bits from bit strings
	// bitwise OR	x | y			Take the OR of each pair of bits			Union of bits from bit strings,
	// bitwise XOR	x ^ y			Take the XOR of each pair of bits			Comparison of 2 bit strings, 0 -> same, 1 - different
	//																			p (+) q, either one is true
	//																			a (+) b (+) c +... n, true if odd number of se if true
	//																			=> ( a + b + c +... +n) %2 <-- summing up all vals then see even/odd
	// left shift	x << y			Move the bits of x to the left y positions	
	// right shift	x >> y			Move the bits of x to the right y positions
	// unsigned right shift	x >>> y	Move the bits of x to the right y positions
	
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
			
			int bitsetcount = getBitSetCount(20);
			Console.WriteLine(string.Format("number of bit set {0}", bitsetcount));
			                  
		}
		
		static private int getBitSetCount(int num)
		{
			int count = 0;
			int i = 0;
			
			while(i<32)
			{

			};
			return count;
		}
	}
}
