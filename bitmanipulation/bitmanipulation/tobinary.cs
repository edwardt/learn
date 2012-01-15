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
		
		public byte[] tobinary64(int number)
		{
			
			
		}
		
		public byte[] tobinary32 (int number) 
		{
		   
			
		}
		
		public byte[] tobinary16(int number)
		{
			
			
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

