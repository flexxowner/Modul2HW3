using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
     public static class FindElement
    {
        public static void SearchElement(Candy[] candies, string name)
        {
            StringBuilder builder = new StringBuilder();
            foreach (var item in candies )
            {
                if (name == item.Name)
                {
                    builder.Append($"{item.Name}, {item.Weight},{item.Callories}");
                    Console.WriteLine(builder.ToString());
                }
            }
        }
    }
}
