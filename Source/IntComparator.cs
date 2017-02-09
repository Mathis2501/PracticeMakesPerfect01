using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Source
{
    public class IntComparator
    {
        List<int> _intList = new List<int>();
        public int GetBiggestInt(int x, int y)
        {
            _intList.Add(x);
            _intList.Add(y);

            return _intList.Max();
        }

        public int GetBiggestInt(int x, int y, int z)
        {
            _intList.Add(x);
            _intList.Add(y);
            _intList.Add(z);

            return _intList.Max();
        }
    }
}
