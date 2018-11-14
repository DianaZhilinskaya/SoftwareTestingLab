using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle2
{
    public class Triangle
    {
        public bool test(int a, int b, int c)
        {
                if (a + b <= c || a + c <= b || b + c <= a)
                {
                    return false;
                }

                return true;
            }
    }
}
