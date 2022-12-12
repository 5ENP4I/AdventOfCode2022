using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    class Day1
    {
        public static void Execute(string input)
        {
            string[] lines = input.Split(new string[] { "\r\n" }, StringSplitOptions.None);

            List<int> elfs = new List<int>();
            int calories = 0;
            int currentCalories = 0;

            for (int i = 0; i < lines.Length; i++)
            {
                bool isItANumber = int.TryParse(lines[i], out currentCalories);
                if (isItANumber)
                {
                    calories += currentCalories;
                }
                else
                {
                    elfs.Add(calories);
                    calories = 0;
                }
            }
            elfs.Add(calories);
            elfs.Sort();
            elfs.Reverse();
            Console.WriteLine(elfs[0]+elfs[1]+elfs[2]);
            Console.Read();
        }//Help mem please ima stack here
    }
}
