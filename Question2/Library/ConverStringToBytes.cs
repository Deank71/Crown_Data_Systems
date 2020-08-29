using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2.Library
{
   public class ConverStringToBytes
    {

        internal byte[] GenerateBytesFromString(string text)
        {
            string[] listOfNumbers = text.Split(new string[] { "\r\n" },
                          StringSplitOptions.RemoveEmptyEntries);
         var byteList =  convertToBytes(listOfNumbers);
            byte[] results = ReverseBytes(byteList);

            return results;
        }

        private static byte[] convertToBytes(string[] listOfNumbers)
        {
            byte[] data = new byte[listOfNumbers.Length];
            for (int i = 0; i < listOfNumbers.Length; i++)
            {
                String number = listOfNumbers[i];
                byte.TryParse(number, out data[i]);
            }
            return data;
        }

        private static byte[] ReverseBytes(Byte[] array)
        {
            int n = array.Length;
            Byte[] aux = new Byte[n];
            for (int i = 0; i < n; i++)
            {
                aux[n - 1 - i] = array[i];
            }
            return aux;
        }

    }
}
