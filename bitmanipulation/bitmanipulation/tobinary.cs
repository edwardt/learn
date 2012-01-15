using System;

namespace bitmanipulation
{
	public class binaryConverter
	{

		public binaryConverter (int size)
		{
		
		}
		
		static public byte[] tobinaryS64(int number)
		{
			int size = 64;
			byte[] bytes = new byte[size/8];
			
			
		}
		
		static public byte[] tobinaryS32 (int number) 
		{
		    int size = 32;
			byte[] bytes = new byte[size/8];
		}
		
		static public byte[] tobinaryS16(int number)
		{
			 int size = 16;
			 byte[] bytes = new byte[size/8];
		}
		
		static public byte[] tobinaryU64(int number)
		{
			int size = 64;
			byte[] bytes = new byte[size/8];
		}
		
		static public byte[] tobinaryU32 (int number) 
		{
		    int size = 32;
			byte[] bytes = new byte[size/8];
		}
		
		static public byte[] tobinaryU16(int number)
		{
			int size = 16;
			byte[] bytes = new byte[size/8];
		}
		
		static public bool verify(int expected, byte[] bytes, int size)
		{
			switch(size)
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

