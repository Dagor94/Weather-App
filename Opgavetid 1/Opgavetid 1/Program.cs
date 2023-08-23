using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Opgavetid_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new ToDoList();

            do
            {
                Console.Write("Skriv et indput: ");
                string input = Console.ReadLine();
                list.Add(input);

                Console.WriteLine(list + "\n");
                Console.ReadKey();
            } while (true);
        }

        private class ToDoList
        {
            string[] toDoList = new string[10];
            int nextIndex = 0;

            // ADD
            public void Add(string input)
            {
                toDoList[nextIndex] = input;
               
                nextIndex++;
            }
            
            // REMOVE
            public void remove(string item)
            {
                string[] new_list = new string[10];
                int x = toDoList.Length;
                int i = 0;
                foreach (string row in toDoList)
                {
                    new_list[i++] = row;
                }
            }

            // ToString
            public override string ToString()
            {
                return string.Join(",", toDoList);
            }
        }






        /*
           public void Add(string input)
            {
                toDolist.Add(input);
            }

            public void Remove(string input)
            {
                toDolist.Remove(input);
            }
        */
        /*
            * int[] tal =
        {
            0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
        };
        int b = 0;

        foreach (int i in tal)
        {

            Console.WriteLine(i);
            if (i % 2 != 0)
            {
                b = b + i;
            };
        };
        Console.WriteLine(b);
        Console.ReadKey();
        */
    }
}
