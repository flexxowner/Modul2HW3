using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    public class Chocolate : Candy
    {
        public Taste Taste { get; set; }

        public override CandyType TypeOfCandy()
        {
            return base.TypeOfCandy();
        }
    }
}
