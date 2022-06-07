using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table
{
    public class Hashtable
    {
        public int Size { get; set; } // The size of the HashTable array.
        public LinkedList[] Table { get; set; } // The array making up the HashTable.
        public Hashtable(int size) // Constructor method to instantiate a new HashTable.
        {
            Size = size;
            Table = new LinkedList[size];
        }

        public int Hash(string key)
        {
            int total = 0;
            char[] letters = key.ToCharArray();

            for (int i = 0; i < letters.Length; i++)  // Add or multiply all the ASCII values together.
            {
                total += letters[i];
            }

            int primeValue = total * 599;  // Multiply it by a prime number such as 599.
            int index = primeValue % Table.Length;  // Use modulo to get the remainder of the result, when divided by the total size of the array.

            return index;  // Insert into the array at that index.
        }
        public void Set(string key, string value)
        {
            // Send the key to the GetHash method.
            int index = Hash(key);

            // If the current index is empty, instantiate a new LinkedList and add a Node containing the key and value.
            if (Table[index] == null)
            {
                LinkedList ll = new LinkedList();
                Node newNode = new Node(key, value);
                ll.Append(newNode);
                Table[index] = ll;
            }
            // If the current index is NOT empty, append a Node containing the key and value to the end of the LinkedList.
            else
            {
                Node newNode = new Node(key, value);
                Table[index].Append(newNode);
            }
        }

        public string Get(string key)  // Retrieve a value in the HashTable by its known key.
        {
            int index = Hash(key);
            var bucket = Table[index];
            bucket.Current = bucket.Head;
            Node current = bucket.Current;

            while (current.Key != key)
            {
                current = current.Next;
            }

            if (current.Key == key)
            {
                return current.Value;
            }
            return null;
        }

        public List<string> Keys(string key) // Returns: Collection of keys
        {
            int index = Hash(key);
            List<string> output = new List<string>();

            if (Table[index] != null)
            {
                var bucket = Table[index];
                bucket.Current = bucket.Head;
                Node current = bucket.Current;

                while (current != null)
                {
                    if (current.Key == key)
                    {
                        output.Add(current.Value);
                    }
                    current = current.Next;
                }
            }
            return output;
        }

        public bool Contains(string key) // // Determines if a Key is pre-existing in the HashTable.
        {
        int index = Hash(key);

        if (Table[index] != null)
        {
            var bucket = Table[index];
            bucket.Current = bucket.Head;
            Node current = bucket.Current;

            while (current != null)
            {
                if (current.Key == key)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }
        return false;
        }

    }
}
