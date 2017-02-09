using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source
{
    public class CustomMath
    {
        public int Modulus(int x, int y)
        {
            int output;

            output = Division(x, y);
            output = output * y;
            output = x - output;
            return output;
        }

        public int Division(int x, int y)
        {
            bool running = true;
            int output = 0;
            

            while (running)
            {
                if (x > y)
                {
                    x -= y;
                    output++;
                }
                else
                {
                    running = false;
                }
            }
            return output;
        }
    }
}
