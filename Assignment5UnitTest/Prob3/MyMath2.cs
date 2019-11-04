using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
{
    public class MyMath2
    {
        public static byte Add(byte a, byte b)
        {
            checked
            {
                byte sum = (byte)(a + b);
                return sum;
            }
        }
    }
}
