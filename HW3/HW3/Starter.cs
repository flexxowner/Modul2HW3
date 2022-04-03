using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    public static class Starter
    {
        public static void Run()
        {
            Gift gift = new Gift();
            WeightComparer weightComparer = new WeightComparer();

            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in gift.ListOfCandies)
            {
                stringBuilder.Append($"{item.Name}, {item.Weight}, {item.Callories}, {item.TypeOfCandy()}\n");
            }

            Console.WriteLine(stringBuilder.ToString());

            Console.WriteLine("Sort by weight:");

            Array.Sort(gift.ListOfCandies, weightComparer.Compare);
            foreach (var item in gift.ListOfCandies)
            {
                Console.WriteLine($"{item.Name} - {item.Weight}");
            }

            Console.WriteLine();
            Console.WriteLine($"Weight of the gift: {gift.GiftWeight()} \n");

            Console.WriteLine("Input name to find:");
            var text = Console.ReadLine();
            FindElement.SearchElement(gift.ListOfCandies, text);
        }
    }
}
