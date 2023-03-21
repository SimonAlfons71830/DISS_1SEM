using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISS_1SEM
{
    internal class ToupleComparer : IComparer<(int, int, double)>
    {
        public int Compare((int, int, double) x, (int, int, double) y)
        {
            return y.Item3.CompareTo(x.Item3);
        }
    }
}
