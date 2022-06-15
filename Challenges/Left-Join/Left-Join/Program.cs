using System;
using System.Collections.Generic;

namespace Left_Join
{
    public class Program
    {
        static void Main(string[] args)
        {
            Hashtable tableOne = new Hashtable(1024);
            tableOne.Set("fond", "enamored");
            tableOne.Set("outfit", "garb");
            Hashtable tableTwo = new Hashtable(1024);
            tableTwo.Set("fond", "averse");
            PrintList(tableOne.LeftJoin(tableOne, tableTwo));

        }

        /// <summary>
        /// TEST HELPER: prints values in list
        /// </summary>
        /// <param name="list"></param>
        private static void PrintList(List<string> list)
        {
            Console.Write("[");
            foreach (string item in list)
            {
                Console.Write($"{item} ]\n[ ");
            }
        }


    }
}
