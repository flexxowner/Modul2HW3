using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    public class Gift : IGift
    {
        public Candy[] ListOfCandies = new Candy[3]
        {
            new Chocolate() { Name = "Milka", Weight = 100, Callories = 550, Type = CandyType.Chocolate, Taste = Taste.Salty },
            new Lollipops() { Name = "Chupa Chups", Weight = 150, Callories = 700, Type = CandyType.ChupaChups, Taste = Taste.Sweet },
            new JellyCandies() { Name = "Roshen", Weight = 50, Callories = 70, Type = CandyType.Lollipop, Taste = Taste.Sweet }
        };

        public int GiftWeight()
        {
            int totalWeight = 0;
            for (int i = 0; i < ListOfCandies.Length; i++)
            {
                totalWeight += ListOfCandies[i].Weight;
            }

            return totalWeight;
        }
    }
}
