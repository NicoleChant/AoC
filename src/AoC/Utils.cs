using System;

namespace Utilities
{
	public class BinaryConverter
	{
		public string transform(int x)
		{
			// Returns the binary representation of a Decimal number

			return "";
		}

		public int detransform(string x)
		{
			// Returns the decimal number out of a binary representation

			double decimalNumber = 0;
			char[] digits = x.ToCharArray();
			for(int i=0; i<digits.Length; i++)
			{
				decimalNumber += Math.Pow(2.0, Convert.ToDouble(digits[i].ToString()));
			}
			return (int) decimalNumber;
		}


	}

}
