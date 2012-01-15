using System;

namespace bitmanipulation
{
	public class binaryConverter
	{
	    int intsize = 0;
		public binaryConverter (int size)
		{
			intsize = size;
		}
		
		public byte[] tobinaryS64(int number)
		{
			int size = 64;
			
		}
		
		public byte[] tobinaryS32 (int number) 
		{
		    int size = 32;
			
		}
		
		public byte[] tobinaryS16(int number)
		{
			 int size = 16;
			
		}
		
		public byte[] tobinaryU64(int number)
		{
			int size = 64;
			
		}
		
		public byte[] tobinaryU32 (int number) 
		{
		    int size = 32;
			
		}
		
		public byte[] tobinaryU16(int number)
		{
			int size = 16;
			
		}
		
		public bool verify(int expected, byte[] bytes)
		{
			switch(intsize)
			{
				case 16:
					return (expected == BitConverter.ToInt16(bytes,0));
				case 32:
					return (expected == BitConverter.ToInt32(bytes,0));
				case 64:
					return (expected == BitConverter.ToInt64(bytes, 0));
				default:
					throw new NotSupportedException(
					intsize.ToString() + " interger size unsupported");
					
			}
		}
	}
}

