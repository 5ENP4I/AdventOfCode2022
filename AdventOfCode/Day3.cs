using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    class Day3
    {
        static List<BackPack> inventory = new List<BackPack>();

        struct BackPack
        {
            public string left;
            public string right;
        }

        public static void Execute(string input)
        {
            int sumPriority = 0;

            string[] lines = input.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            foreach(string s in lines)
            {
                BackPack backPack = new BackPack();
                backPack.left = s.Substring(0,s.Length/2);
                backPack.right = s.Substring(s.Length / 2, s.Length/2);
                inventory.Add(backPack);
            }

            foreach(BackPack b in inventory)
            {
                for (int i = 0; i < b.left.Length; i++)
                {
                    if(b.left.Contains(b.right[i]))
                    {
                        int index = (int)b.left[i] % 32;
                        if (Char.IsUpper(b.left[i]))
                        {
                            index += 26;
                        }
                        sumPriority += index;
                    }
                    continue;
                }
            }
            Console.WriteLine(sumPriority);
        }
    }
}
//priority counter
//char c = Console.ReadLine()[0];
//int index = (int)c % 32;
//if (Char.IsUpper(c))
//{
//    index+= 26;
//}