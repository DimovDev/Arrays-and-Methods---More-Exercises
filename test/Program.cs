using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace test
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
                    List<String> myStringList = new List<string>();
                    foreach (string s in arr)
                    {
                        if (!myStringList.Contains(s))
                        {
                            myStringList.Add(s);
                        }
                    }

                    arr = myStringList;
                }
                else if (commands[0] == "Replace")
                {
                  int  commands1 = int.Parse(commands[1]);
                 
                    arr.RemoveAt(commands1);
                    arr.Insert(commands1, commands[2]);

                }

                }
            Console.WriteLine(string.Join(", ", arr));
        }
        }
    }


