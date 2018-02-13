using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2._Manipulate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> arr = Console.ReadLine().Split(' ').ToList();
            int numOfcommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfcommands; i++)
            {
                List<string> commands = Console.ReadLine().Split(' ').ToList();

                if (commands[0] == "Reverse")
                {
                    arr.Reverse();
                }
                else if (commands[0] == "Distinct")
                {
                    arr.Distinct().ToArray();
                }
                else if (commands[0] == "Replace")
                {
                    arr.RemoveAt((int.Parse)(commands[1]));
                    arr.Insert((int.Parse)(commands[1]), commands[2]));
        }
    }
    }
        }

}
        }
    }
}
               
 
