using System;

namespace Repeated_Word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashTable = new Hashtable(1024);
            string str = "Once upon a time, there was a brave princess who...";
            Console.WriteLine(hashTable.RepeatedWord(str));
        }

    }
}
