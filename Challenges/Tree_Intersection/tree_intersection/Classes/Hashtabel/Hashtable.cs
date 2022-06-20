using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using tree_intersection.Classes.BinaryTree;

namespace tree_intersection
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

        public int Hash(int key)
        {
            int index = key;

            index = (index * 599) / Table.Length;
            return index;
        }
        public void Set(int key, int value)
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

        public bool Contains(int key) // // Determines if a Key is pre-existing in the HashTable.
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

        public IList<int> TreeIntersection(BinaryTree t1, BinaryTree t2)
        {
            IList<int> t1Vals = t1.InOrder(t1.Root);
            IList<int> t2Vals = t2.InOrder(t2.Root);
            List<int> sharedValues = new List<int>();
            Hashtable treeTable = new Hashtable(1024);

            foreach (int val in t1Vals)
            {
                treeTable.Set(val, val);
            }

            foreach (int val in t2Vals)
            {
                if (treeTable.Contains(val))
                {
                    sharedValues.Add(val);
                }
            }

            return sharedValues;
        }

    }
}
