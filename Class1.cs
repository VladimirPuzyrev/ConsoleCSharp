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
    }
}
