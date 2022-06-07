using System;
using System.Collections.Generic;

namespace Hash_Table
{
    public class Program
    {
        static void Main(string[] args)
        {
            Hashtable table = new Hashtable(1024);

            table.Set("Name", "Ola M AL-Shlool");

            var value = table.Get("Name");

            Console.WriteLine(value);

            var exists = table.Contains("Name");
            var exists2 = table.Contains("abc");

            Console.WriteLine($"Does it exist?  {exists}");
            Console.WriteLine($"Does it exist?  {exists2}");
        }
    }
}
