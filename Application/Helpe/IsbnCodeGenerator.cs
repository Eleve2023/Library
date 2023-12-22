using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Helpe
{
    public static class IsbnCodeGenerator
    {
        public static string Generated()
        {
            Random random = new Random();
            int[] isbnNumbers = new int[9];
            for (int i = 0; i < 9; i++)
            {
                isbnNumbers[i] = random.Next(10);
            }

            int sum = 0;
            for (int i = 0; i < 9; i++)
            {
                sum += isbnNumbers[i] * (i + 1);
            }

            int checkDigit = sum % 11;
            string checkDigitStr = checkDigit == 10 ? "X" : checkDigit.ToString();

            string isbn = string.Join("", isbnNumbers) + checkDigitStr;

            return isbn;
        }
    }
}
