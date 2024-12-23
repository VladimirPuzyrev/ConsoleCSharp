using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class1
    {
        static int dubFuc(int x)
        {
            int sum = 0;
            for(int i = 0; i < x; i++) 
            {
                sum *= x - i;
                i++;
            }

            return sum;
        }

        public static int[] writeMethod(int first, int second)
        {
            int[] array = new int[second - first + 1];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = first + i;
            }

            return array;
        }

        public static char[] writeMethod(char firstChar, char secondChar) /// cs0128 разобраться
        {
            char[] array = new char[(int)secondChar - (int)firstChar + 1];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (char)(firstChar + i);
            }

            return array;
        }

        public static int[] mmElement(params int[] a)
        {
            int max = -1, min = 9999;
            int[] Element = new int[2];

            foreach (int i in a)
            {

                if( i > max)
                {
                    max = i;
                }

                if( i < min)
                {
                    min = i;
                }

              
            }

            Element[0] = max;
            Element[1] = min;

            return Element;
        }

        public static string addChar(string s, params char[] a)
        {

            string res = s;

            for(int i  = 0; i < a.Length; i++)
            {

                res += a[i];
            }

            return res;
        }
    }
}
