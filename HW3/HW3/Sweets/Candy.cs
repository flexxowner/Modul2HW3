using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    public class Candy
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Callories { get; set; }
        public CandyType Type { get; set; }

        public virtual CandyType TypeOfCandy()
        {
            return Type;
        }
    }
}
