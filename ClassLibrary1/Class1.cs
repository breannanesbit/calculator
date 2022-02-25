using System;

namespace ClassLibrary1
{
	public class Calculator
	{
		public int FirstNumber { get; set; }
		public int SecondNumber { get; set; }
		public int result1 { get; set; }

		public int Add()
		{ 
			result1 = FirstNumber;
			return FirstNumber + SecondNumber;
		}

		public int Add(int num)
        {
			return result1 += num;
        }

		public int Subtract()
        {
			return FirstNumber - SecondNumber;
        }

		public int Subtract(int num)
        {
			return result1 -= num;
        }

		public int multiply()
        {
			return FirstNumber * SecondNumber;
        }

		public int DivideInt(int num)
        {
			 return result1 /= num;
        }

		public int modDivide(int num)
        {
			return result1 %= num;
        }
	}
}