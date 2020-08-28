using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CDS.MainApplicationTests.Library.ReverseArray
{
    public class ReverseBtye
    {
        public Byte[] Reverse (Byte[] array) 
        {
            int n = array.Length;
            Byte[] aux = new Byte[n];
            for (int i = 0; i < n; i++)
            {
                aux[n - 1 - i] = array[i];
            }

            //for (int i = 0; i < n; i++)
            //{
            //    array[i] = aux[i];
            //}
            return aux;
        }
    }
}
