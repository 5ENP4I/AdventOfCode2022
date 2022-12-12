using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    class Day2
    {
        public static void Execute(string input)
        {
            string[] lines = input.Split(new string[] { "\r\n" }, StringSplitOptions.None);

            char team1;
            char team2;
            Console.WriteLine([lines[0]]);
            /*
            int myscore = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i].Replace("\n", "");
                team1 = lines[i][1];
                team2 = lines[i][3];
                if ((team1 == 'A') && (team2 == 'X')) { myscore += 4; }
                else if ((team1 == 'A') && (team2 == 'Y')){myscore += 8;}
                else if ((team1 == 'A') && (team2 == 'Z')){myscore += 3;}
                else if ((team1 == 'B') && (team2 == 'X')){myscore += 1;}
                else if ((team1 == 'B') && (team2 == 'Y')){ myscore += 5;}
                else if ((team1 == 'B') && (team2 == 'Z')){myscore += 9;}
                else if ((team1 == 'C') && (team2 == 'X')){myscore += 7;}
                else if ((team1 == 'C') && (team2 == 'Y')){myscore += 2;}
                else if ((team1 == 'C') && (team2 == 'Z')){myscore += 6;}
            }
            Console.WriteLine(myscore);
            */
            Console.ReadKey();
        }
    }
}
