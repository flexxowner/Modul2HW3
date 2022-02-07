using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    public class WeightComparer : IComparer<Candy>
    {
        public int Compare(Candy p1, Candy p2)
        {
            if (p1.Weight > p2.Weight)
            {
                return 1;
            }
            else if (p1.Weight < p2.Weight)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
